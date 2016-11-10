﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

			Measures = new List<int> { 8, 4 }[Randomizer.GetWeightedIndex(new List<double> { 0.5, 0.5 })];
			Chords = GetChordProgression();
			GetGroove();
		}

		internal int Render()
		{
			var timeKeepers = new List<Percussion> { Percussion.ClosedHiHat, Percussion.OpenHiHat, Percussion.RideCymbal1 };
			var timeKeeper = timeKeepers[Randomizer.Next(timeKeepers.Count)];

			var notesPerBeat = new List<int> { 1, 2, 4 }[Randomizer.GetWeightedIndex(new List<double> { 1, 0.5, 0.25 })];
			var noteLength = 1.0 / notesPerBeat;

			for (var measure = 0; measure < Measures; measure++)
			{
				var grooveNotes = _groove.Notes(timeKeeper, measure == 0, Time).ToList();

				var guitarRnotes = new List<Note>();
				var guitarLnotes = new List<Note>();
				var bassNotes = new List<Note>();

				for (var beat = 0; beat < Time.BeatCount; beat++)
				{
					var pitches = Chords.Last(c => c.Item1 <= measure * Time.BeatCount + beat).Item2.Pitches();
					guitarRnotes.AddRange(Enumerable.Range(0, notesPerBeat).SelectMany(s => pitches.Select(p => new Note(beat + noteLength * s, noteLength, p, Velocity.F))));
					guitarLnotes.AddRange(Enumerable.Range(0, notesPerBeat).SelectMany(s => pitches.Select(p => new Note(beat + noteLength * s, noteLength, p, Velocity.F))));
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
				chordList = ChordProgressionGenerator.ChordProgression(MinorOrDiminshedFilter)
					.Take(Randomizer.Clamp(Randomizer.NextNormalized(4, 1), 3, 6))
					.Select(c => TransposeForKey(Pitch.G2, c))
					.ToList();
			} while (chordList.Count(c => c.Quality == ChordQuality.Minor) < 2);

			Debug.WriteLine(string.Join(" - ", chordList));
			return AssignChords(chordList, Measures * Time.BeatCount);
		}

		private List<Tuple<int, Chord>> AssignChords(IReadOnlyList<Chord> chords, int maxValue)
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

		private int GetSplitPoint(int maxValue)
		{
			if (Randomizer.ProbabilityOfTrue(0.9))
			{
				return maxValue / 2;
			}

			return GetSplitPoint(maxValue / 2) + (Randomizer.ProbabilityOfTrue(0.5) ? maxValue / 2 : 0);
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

		private static Chord TransposeForKey(Pitch key, Chord result)
		{
			var transposeDiff = key - Pitch.C0;
			result.Transpose(transposeDiff);
			return result;
		}
	}
}
