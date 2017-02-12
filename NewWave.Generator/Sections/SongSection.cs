using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Core.Chords;
using NewWave.Core.Grooves;
using NewWave.Core.Pitches;
using NewWave.Generator.Common;
using NewWave.Generator.Grooves;
using NewWave.Generator.Parameters;
using NewWave.Generator.Riffs;
using NewWave.Generator.SoloLead;
using NewWave.Midi;

namespace NewWave.Generator.Sections
{
    public class SongSection
	{
		internal readonly SectionType Type;
		private readonly SongInfo _songInfo;

		internal readonly List<Tuple<int, Chord>> Chords;
		internal readonly IEnumerable<Note> Lead;

		private readonly int _measures;
		private readonly int _repeats;
		private readonly DrumStyle _drumstyle;
		private readonly RiffStrummer _strummer;

		internal SongSection(SongInfo songInfo, SectionType type, ChordProgression chordProgression, MarkovGeneratorParameters parameters = null)
		{
		    var ps = parameters ?? new MarkovGeneratorParameters();

			Type = type;
			_songInfo = songInfo;

			_measures = ps.MeasuresPerSection(type);
			Chords = GetChordProgression(ps.GuitarTuning.Pitches[0], chordProgression, ps);
			_repeats = ps.RepeatsPerSection(type, _measures);
			Lead = SoloLeadGenerator.GetSoloLead(_songInfo, _measures * _songInfo.TimeSignature.BeatCount, Chords);
			_drumstyle = ps.DrumStyle(Type);
			var groove = GetGroove();
			_drumstyle.Generate(groove);
			var riff = RiffGenerator.Rhythm(songInfo.TimeSignature, groove.Beats.ToList(), ps.RiffResolutionFunc(type), songInfo.Feel).ToList();
			_strummer = new RiffStrummer(riff);
		}

		internal int Measures => _measures * _repeats;

	    internal int Render(InstrumentTrack guitarR, InstrumentTrack guitarL, InstrumentTrack guitarC,
	        InstrumentTrack guitarLc, InstrumentTrack guitarRc, InstrumentTrack bass, PercussionTrack drums,
	        MarkovGeneratorParameters ps)
	    {
	        for (var repeat = 0; repeat < _repeats; repeat++)
	            RenderRepeat(guitarR, guitarL, guitarC, guitarLc, guitarRc, bass, drums, repeat, ps);

	        return Measures;
	    }

	    private void RenderRepeat(InstrumentTrack guitarR, InstrumentTrack guitarL, InstrumentTrack guitarC,
	        InstrumentTrack guitarLc, InstrumentTrack guitarRc, InstrumentTrack bass, PercussionTrack drums, int repeat,
	        MarkovGeneratorParameters ps)
	    {
	        if (Type == SectionType.Verse || Type == SectionType.Chorus)
	        {
	            guitarC.Notes.Add(Lead.ToList());
	        }
	        else
	        {
	            guitarC.Notes.Add(new List<Note>());
	        }

	        for (var measure = 0; measure < _measures; measure++)
	            RenderMeasure(guitarR, guitarL, guitarC, guitarLc, guitarRc, bass, drums, repeat, measure, ps);
	    }

	    private void RenderMeasure(InstrumentTrack guitarR, InstrumentTrack guitarL, InstrumentTrack guitarC,
	        InstrumentTrack guitarLc, InstrumentTrack guitarRc, InstrumentTrack bass, PercussionTrack drums, int repeat,
	        int measure, MarkovGeneratorParameters ps)
	    {
	        var grooveNotes = _drumstyle.Notes;
	        var kicks = grooveNotes.Where(n => n.PercussionId == (int) Percussion.BassDrum1).ToList();
	        var gNotes =
	            kicks.Select(
	                (k, i) =>
	                    new Tuple<float, float>(k.Start,
	                        i < kicks.Count - 1
	                            ? kicks[i + 1].Start - k.Start
	                            : _songInfo.TimeSignature.BeatCount - k.Start)).ToList();
	        if (!gNotes.Any())
	        {
	            gNotes.Add(new Tuple<float, float>(0, _songInfo.TimeSignature.BeatCount));
	        }

	        if (Type == SectionType.Intro || Type == SectionType.Outro || Type == SectionType.Bridge)
	        {
	            _strummer.AddGuitarNotes(new[] {guitarLc, guitarRc}, Chords, measure, _songInfo, ps);
	            guitarL.Notes.Add(new List<Note>());
	            guitarR.Notes.Add(new List<Note>());
	        }
	        else
	        {
	            _strummer.AddGuitarNotes(new[] {guitarL, guitarR}, Chords, measure, _songInfo, ps);
	            guitarLc.Notes.Add(new List<Note>());
	            guitarRc.Notes.Add(new List<Note>());
	        }

	        _strummer.AddBassNotes(bass, Chords, measure, _songInfo, ps);
	        drums.Notes.Add(AddFill(repeat, measure, grooveNotes));

	        if (measure != 0)
	        {
	            // All the solo lead notes are actually in the first measure, so add empty ones after it
	            guitarC.Notes.Add(new List<Note>());
	        }
	    }

	    private List<PercussionNote> AddFill(int repeat, int measure, List<PercussionNote> grooveNotes)
		{
			var isLastMeasureInRepeatedSection = measure == _measures - 1 && repeat == _repeats - 1;
			var isLastMeasureInSingleMediumSection = _measures > 2 && measure == _measures - 1;
			var isMiddleMeasureInSingleLongSection = _measures > 4 && (measure + 1) % 8 == 0;

			if (isLastMeasureInRepeatedSection || isLastMeasureInSingleMediumSection || isMiddleMeasureInSingleLongSection)
			{
				var fillLength = new List<float> { 1.0f, 2.0f }[Randomizer.GetWeightedIndex(new List<float> { 0.5f, 0.5f })];

				if (isLastMeasureInRepeatedSection)
				{
					fillLength *= 2;
				}

				var fill = FillGenerator.GetFill(_songInfo.TimeSignature.BeatCount - fillLength, fillLength, _songInfo.Feel);
				grooveNotes = grooveNotes.Where(n => n.Start < _songInfo.TimeSignature.BeatCount - fillLength).Union(fill).ToList();
			}
			return grooveNotes;
		}

		private List<Tuple<int, Chord>> GetChordProgression(OctavePitch lowestPossibleNote, ChordProgression progression, MarkovGeneratorParameters ps)
		{
			var chordList = progression
				.Chords
				.Take(Randomizer.Clamp(Randomizer.NextNormalized(3, 1), 2, 3))
				.Select(c => TransposeForLowestNote(lowestPossibleNote, TransposeForKey(ps.MajorKey, c)))
				.ToList();

			return AssignChords(chordList, _measures * _songInfo.TimeSignature.BeatCount);
		}

		private static List<Tuple<int, Chord>> AssignChords(IReadOnlyList<Chord> chords, int maxValue)
		{
			if (chords.Count == 1)
			{
				return new List<Tuple<int, Chord>>
				{
					new Tuple<int, Chord>(0, chords[0])
				};
			}

			// Split available beats arbitrarily (weight closer to halves, quarters, etc.)
			// Split available chords arbitrarily
			// Recursively assign each half
			var beatSplitPoint = GetSplitPoint(maxValue);

			var chordSplitIndex = 0;

			while (chordSplitIndex == 0)
			{
				chordSplitIndex = GetSplitPoint(chords.Count);
			}

			var chords1 = chords.Take(chordSplitIndex).ToList();
			var chords2 = chords.Skip(chordSplitIndex).ToList();

			var assignments1 = new List<Tuple<int, Chord>>();
			var assignments2 = new List<Tuple<int, Chord>>();
			if (chords1.Any())
			{
				assignments1 = AssignChords(chords1, beatSplitPoint);
			}
			if (chords2.Any())
			{
				assignments2 = AssignChords(chords2, maxValue - beatSplitPoint);
			}

			return assignments1.Union(assignments2.Select(a => new Tuple<int, Chord>(a.Item1 + beatSplitPoint, a.Item2))).ToList();
		}

		private static int GetSplitPoint(int maxValue)
		{
			if (Randomizer.ProbabilityOfTrue(0.9f))
			{
				return maxValue / 2;
			}

			return GetSplitPoint(maxValue / 2) + (Randomizer.ProbabilityOfTrue(0.5f) ? maxValue / 2 : 0);
		}

		private Groove GetGroove()
		{
			return GrooveGenerator.GenerateGroove(_songInfo);
		}

		private static Chord TransposeForKey(OctavePitch key, Chord result)
		{
			var transposeDiff = key - OctavePitch.C0;
			result.Transpose(transposeDiff);
			return result;
		}

		private static Chord TransposeForLowestNote(OctavePitch lowestPossibleNote, Chord result)
		{
			var rootOctave = lowestPossibleNote.OctaveOf();
			var currentLowest = result.Pitches(rootOctave).Min();
			var minPitchToTranspose = lowestPossibleNote.AddOctave(1);
			while (currentLowest >= minPitchToTranspose)
			{
				result.Transpose(-12);
				currentLowest = result.Pitches(rootOctave).Min();
			}
			return result;
		}
	}
}
