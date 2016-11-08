using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Generator.ChordProgressions;
using NewWave.Library.Chords;
using NewWave.Library.Grooves;
using NewWave.Midi;

namespace NewWave.Generator
{
	internal class SongSection
	{
		internal readonly TimeSignature Time;
		private readonly InstrumentTrack _guitarR;
		private readonly InstrumentTrack _guitarL;
		private readonly InstrumentTrack _bass;
		private readonly PercussionTrack _drums;

		internal readonly int Measures;
		internal readonly List<Tuple<int, Chord>> Chords;
		private Groove _groove;

		internal SongSection(TimeSignature time, InstrumentTrack guitarR, InstrumentTrack guitarL, InstrumentTrack bass, PercussionTrack drums)
		{
			Time = time;
			_guitarR = guitarR;
			_guitarL = guitarL;
			_bass = bass;
			_drums = drums;

			Measures = 8;
			Chords = GetChordProgression();
			GetGroove();
		}

		internal int Render()
		{
			var timeKeepers = new List<Percussion> { Percussion.ClosedHiHat, Percussion.OpenHiHat, Percussion.RideCymbal1 };
			var timeKeeper = timeKeepers[Randomizer.Next(timeKeepers.Count)];

			for (var measure = 0; measure < Measures; measure++)
			{
				var grooveNotes = _groove.Notes(timeKeeper, measure == 0, Time).ToList();

				var guitarRnotes = new List<Note>();
				var guitarLnotes = new List<Note>();
				var bassNotes = new List<Note>();

				for (var beat = 0; beat < Time.BeatCount; beat++)
				{
					var pitches = Chords.Last(c => c.Item1 <= measure * Time.BeatCount + beat).Item2.Pitches();
					guitarRnotes.AddRange(pitches.Take(2).Select(p => new Note(beat, 1, p, Velocity.F)));
					guitarLnotes.AddRange(pitches.Skip(2).Select(p => new Note(beat, 1, p, Velocity.F)));
					bassNotes.Add(new Note(beat, 1, pitches[0].AddOctave(-1), Velocity.Fff));
				}

				_guitarL.Notes.Add(guitarLnotes);
				_guitarR.Notes.Add(guitarRnotes);
				_bass.Notes.Add(bassNotes);
				_drums.Notes.Add(grooveNotes);
			}

			return Measures;
		}

		private List<Tuple<int, Chord>> GetChordProgression()
		{
			List<Chord> chordList;
			do
			{
				chordList = ChordProgressionGenerator.ChordProgression(MinorOrDiminshedFilter).Select(c => TransposeForKey(Pitch.E3, c)).ToList();
			} while (chordList.Count <= 2 && chordList.Count(c => c.Quality == ChordQuality.Minor) < 2);

			var sectionLengthInBeats = Measures * Time.BeatCount;
			var averageChordLength = sectionLengthInBeats / chordList.Count;
			var roughSpread = chordList.Select((c, i) => new Tuple<int, Chord>(NearestMeasureStart(i * averageChordLength), c)).ToList();

			// The int indicates the (beat x measure) value where this particular chord starts

			return roughSpread.OrderBy(c => c.Item1).ToList();
		}

		private static Func<MarkovChainNode<Chord>, MarkovChainNode<Chord>> MinorOrDiminshedFilter
		{
			get
			{
				return n =>
					n.Data.Quality == ChordQuality.Minor
						? new MarkovChainNode<Chord>(n.Data, n.Probability * 8.0, n.ChildNodes?.Where(c => c.Probability > 0.08).ToList())
						: n;
			}
		}

		private void GetGroove()
		{
			_groove = GrooveLibrary.AllGrooves[Randomizer.Next(GrooveLibrary.AllGrooves.Count)];
		}

		private int NearestMeasureStart(int input)
		{
			// Bad but works for now
			var options = Enumerable.Range(0, Measures).Select(m => m * Time.BeatCount).ToList();
			var distances = options.Select(o => Math.Abs(input - o)).ToList();
			return options[distances.IndexOf(distances.Min())];
		}

		private static Chord TransposeForKey(Pitch key, Chord result)
		{
			var transposeDiff = key - Pitch.C0;
			result.Transpose(transposeDiff);
			return result;
		}
	}
}
