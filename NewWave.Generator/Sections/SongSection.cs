﻿using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Generator.ChordProgressions;
using NewWave.Generator.Grooves;
using NewWave.Generator.Riffs;
using NewWave.Library.Chords;
using NewWave.Library.Grooves;
using NewWave.Midi;

namespace NewWave.Generator.Sections
{
	internal class SongSection
	{
		internal readonly SectionType Type;
		private readonly SongInfo _songInfo;

		internal readonly List<Tuple<int, Chord>> Chords;
		internal readonly IEnumerable<Note> Riff;

		private readonly int _measures;
		private readonly Groove _groove;
		private readonly Percussion _timeKeeper;
		private readonly int _repeats;

		internal SongSection(SongInfo songInfo, SectionType type, ChordProgression chordProgression)
		{
			Type = type;
			_songInfo = songInfo;

			_measures = songInfo.Parameters.MeasuresPerSection(type);
			Chords = GetChordProgression(songInfo.Parameters.GuitarTuning.Pitches[0], chordProgression);
			_groove = GetGroove();

			_timeKeeper = GetTimeKeeper(type);
			_repeats = songInfo.Parameters.RepeatsPerSection(type, _measures);
			Riff = RiffGenerator.GetRiff(_songInfo, _measures * _songInfo.TimeSignature.BeatCount, Chords);
		}

		internal int Measures => _measures * _repeats;

		internal int Render(InstrumentTrack guitarR, InstrumentTrack guitarL, InstrumentTrack guitarC, InstrumentTrack guitarLc, InstrumentTrack guitarRc, InstrumentTrack bass, PercussionTrack drums)
		{
			for (var repeat = 0; repeat < _repeats; repeat++)
			{
				RenderRepeat(guitarR, guitarL, guitarC, guitarLc, guitarRc, bass, drums, repeat);
			}

			return Measures;
		}

		private void RenderRepeat(InstrumentTrack guitarR, InstrumentTrack guitarL, InstrumentTrack guitarC, InstrumentTrack guitarLc, InstrumentTrack guitarRc, InstrumentTrack bass, PercussionTrack drums, int repeat)
		{
			if (Type == SectionType.Verse || Type == SectionType.Chorus)
			{
				guitarC.Notes.Add(Riff.ToList());
			}
			else
			{
				guitarC.Notes.Add(new List<Note>());
			}

			for (var measure = 0; measure < _measures; measure++)
			{
				RenderMeasure(guitarR, guitarL, guitarC, guitarLc, guitarRc, bass, drums, repeat, measure);
			}
		}

		private void RenderMeasure(InstrumentTrack guitarR, InstrumentTrack guitarL, InstrumentTrack guitarC, InstrumentTrack guitarLc, InstrumentTrack guitarRc, InstrumentTrack bass, PercussionTrack drums, int repeat, int measure)
		{
			var addCrash = (repeat % 2 == 0 && measure == 0) || (_measures > 4 && measure % 4 == 0);
			var grooveNotes = AddFill(repeat, measure, _groove.Notes(_timeKeeper, addCrash, _songInfo.TimeSignature));
			var kicks = grooveNotes.Where(n => n.Percussion == Percussion.BassDrum1).ToList();
			var gNotes = kicks.Select((k, i) => new Tuple<double, double>(k.Start, i < kicks.Count - 1 ? kicks[i + 1].Start - k.Start : _songInfo.TimeSignature.BeatCount - k.Start)).ToList();
			if (!gNotes.Any())
			{
				gNotes.Add(new Tuple<double, double>(0, _songInfo.TimeSignature.BeatCount));
			}

			if (Type == SectionType.Intro || Type == SectionType.Outro || Type == SectionType.Bridge)
			{
				GuitarStrummer.AddNotes(gNotes, guitarLc, Chords, measure, _songInfo);
				GuitarStrummer.AddNotes(gNotes, guitarRc, Chords, measure, _songInfo);
				guitarL.Notes.Add(new List<Note>());
				guitarR.Notes.Add(new List<Note>());
			}
			else
			{
				GuitarStrummer.AddNotes(gNotes, guitarL, Chords, measure, _songInfo);
				GuitarStrummer.AddNotes(gNotes, guitarR, Chords, measure, _songInfo);
				guitarLc.Notes.Add(new List<Note>());
				guitarRc.Notes.Add(new List<Note>());
			}
			
			GuitarStrummer.AddNotes(gNotes, bass, Chords, measure, _songInfo);
			drums.Notes.Add(grooveNotes);

			if (measure != 0)
			{
				// All the riff notes are actually in the first measure, so add empty ones after it
				guitarC.Notes.Add(new List<Note>());
			}
		}

		private static Percussion GetTimeKeeper(SectionType type)
		{
			List<Percussion> timeKeepers;
			switch (type)
			{
				case SectionType.Intro:
				case SectionType.Outro:
					timeKeepers = new List<Percussion> { Percussion.RideBell, Percussion.RideCymbal1, Percussion.LowTom1 };
					break;
				case SectionType.Chorus:
					timeKeepers = new List<Percussion> { Percussion.OpenHiHat, Percussion.CrashCymbal2 };
					break;
				case SectionType.Prechorus:
					timeKeepers = new List<Percussion> { Percussion.CrashCymbal2, Percussion.RideCymbal1, Percussion.HighTom1, Percussion.RideBell };
					break;
				case SectionType.Verse:
					timeKeepers = new List<Percussion> { Percussion.ClosedHiHat, Percussion.OpenHiHat };
					break;
				case SectionType.Bridge:
					timeKeepers = new List<Percussion> { Percussion.LowTom1, Percussion.RideCymbal1, Percussion.RideCymbal2 };
					break;
				default:
					timeKeepers = new List<Percussion> { Percussion.ClosedHiHat };
					break;
			}

			return timeKeepers[Randomizer.Next(timeKeepers.Count)];
		}

		private List<PercussionNote> AddFill(int repeat, int measure, List<PercussionNote> grooveNotes)
		{
			var isLastMeasureInRepeatedSection = measure == _measures - 1 && repeat == _repeats - 1;
			var isLastMeasureInSingleMediumSection = _measures > 2 && measure == _measures - 1;
			var isMiddleMeasureInSingleLongSection = _measures > 4 && (measure + 1) % 8 == 0;

			if (isLastMeasureInRepeatedSection || isLastMeasureInSingleMediumSection || isMiddleMeasureInSingleLongSection)
			{
				var fillLength = new List<double> { 1.0, 2.0 }[Randomizer.GetWeightedIndex(new List<double> { 0.5, 0.5 })];

				if (isLastMeasureInRepeatedSection)
				{
					fillLength *= 2;
				}

				var fill = FillGenerator.GetFill(_songInfo.TimeSignature.BeatCount - fillLength, fillLength, _songInfo.Feel);
				grooveNotes = grooveNotes.Where(n => n.Start < _songInfo.TimeSignature.BeatCount - fillLength).Union(fill).ToList();
			}
			return grooveNotes;
		}

		private List<Tuple<int, Chord>> GetChordProgression(Pitch lowestPossibleNote, ChordProgression progression)
		{
			var chordList = progression
				.Chords
				.Take(Randomizer.Clamp(Randomizer.NextNormalized(4, 1), 3, 6))
				.Select(c => TransposeForLowestNote(lowestPossibleNote, TransposeForKey(_songInfo.Parameters.MajorKey, c)))
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
			if (Randomizer.ProbabilityOfTrue(0.9))
			{
				return maxValue / 2;
			}

			return GetSplitPoint(maxValue / 2) + (Randomizer.ProbabilityOfTrue(0.5) ? maxValue / 2 : 0);
		}

		private Groove GetGroove()
		{
			return GrooveGenerator.GenerateGroove(_songInfo);
		}

		private static Chord TransposeForKey(Pitch key, Chord result)
		{
			var transposeDiff = key - Pitch.C0;
			result.Transpose(transposeDiff);
			return result;
		}

		private static Chord TransposeForLowestNote(Pitch lowestPossibleNote, Chord result)
		{
			var currentLowest = result.Pitches().Min();
			var minPitchToTranspose = lowestPossibleNote.AddOctave(1);
			while (currentLowest >= minPitchToTranspose)
			{
				result.Transpose(-12);
				currentLowest = result.Pitches().Min();
			}
			return result;
		}
	}
}
