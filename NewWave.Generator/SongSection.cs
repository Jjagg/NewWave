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
		private readonly TimeSignature _time;
		private readonly InstrumentTrack _guitarR;
		private readonly InstrumentTrack _guitarL;
		private readonly InstrumentTrack _bass;
		private readonly PercussionTrack _drums;

		internal SongSection(TimeSignature time, InstrumentTrack guitarR, InstrumentTrack guitarL, InstrumentTrack bass, PercussionTrack drums)
		{
			_time = time;
			_guitarR = guitarR;
			_guitarL = guitarL;
			_bass = bass;
			_drums = drums;
		}

		internal int Render()
		{
			const int measures = 8;
			var timeKeepers = new List<Percussion> { Percussion.ClosedHiHat, Percussion.OpenHiHat, Percussion.RideCymbal1 };
			var timeKeeper = timeKeepers[Randomizer.Next(timeKeepers.Count)];

			List<Chord> chords;
			do
			{
				chords = ChordProgressionGenerator.ChordProgression(Pitch.G0, MinorOrDiminshedFilter);
			} while (chords.Count <= 2 && chords.Count(c => c.Quality == ChordQuality.Minor) < 2);

			if (chords.Count == 3)
			{
				chords = AugmentThreeChordProgression(chords);
			}

			var groove = GrooveLibrary.AllGrooves[Randomizer.Next(GrooveLibrary.AllGrooves.Count)];

			for (var measure = 0; measure < measures; measure++)
			{
				var chordIndex = measure % chords.Count;
				var pitches = chords[chordIndex].Pitches();
				var grooveNotes = groove.Notes(timeKeeper, measure == 0, _time).ToList();
				var kicks = grooveNotes.Where(gn => gn.Percussion == timeKeeper || gn.Start == 0).ToList();

				_guitarR.Notes.Add(kicks.SelectMany((gn, i) => pitches.Take(2).Select(p => new Note(gn.Start, GetLength(gn, i, kicks), p, Velocity.F))).ToList());
				_guitarL.Notes.Add(kicks.SelectMany((gn, i) => pitches.Skip(2).Select(p => new Note(gn.Start, GetLength(gn, i, kicks), p, Velocity.F))).ToList());
				_bass.Notes.Add(kicks.Select((gn, i) => new Note(gn.Start, GetLength(gn, i, kicks), pitches[0].AddOctave(-1), Velocity.Fff)).ToList());
				_drums.Notes.Add(grooveNotes);
			}

			return measures;
		}

		private double GetLength(PercussionNote gn, int i, IReadOnlyList<PercussionNote> kicks)
		{
			var start = gn.Start;
			var nextStart = i == kicks.Count - 1 ? _time.BeatCount : kicks[i + 1].Start;
			var length = nextStart - start;
			return length;
		}

		private static List<Chord> AugmentThreeChordProgression(List<Chord> chords)
		{
			if (chords.Count != 3) throw new ArgumentException("Must have three chords");

			switch (new[] { 0, 1, 2 }[Randomizer.GetWeightedIndex(new List<double> { 0.2, 0.3, 0.5 })])
			{
				case 0: // Extend chord 1
					chords.Insert(1, chords[0]);
					break;
				case 1: // Extend chord 2
					chords.Insert(2, chords[1]);
					break;
				default: // Extend chord 3
					chords.Add(chords[2]);
					break;
			}

			return chords;
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
	}
}
