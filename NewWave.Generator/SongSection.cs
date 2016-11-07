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

		private readonly int _measures = 8;
		internal List<Chord> Chords;
		private Groove _groove;

		internal SongSection(TimeSignature time, InstrumentTrack guitarR, InstrumentTrack guitarL, InstrumentTrack bass, PercussionTrack drums)
		{
			_time = time;
			_guitarR = guitarR;
			_guitarL = guitarL;
			_bass = bass;
			_drums = drums;

			GetChordProgression();
			GetGroove();
		}

		internal int Render()
		{
			var timeKeepers = new List<Percussion> { Percussion.ClosedHiHat, Percussion.OpenHiHat, Percussion.RideCymbal1 };
			var timeKeeper = timeKeepers[Randomizer.Next(timeKeepers.Count)];

			for (var measure = 0; measure < _measures; measure++)
			{
				var chordIndex = measure % Chords.Count;
				var pitches = Chords[chordIndex].Pitches();
				var grooveNotes = _groove.Notes(timeKeeper, measure == 0, _time).ToList();
				var kicks = grooveNotes.Where(gn => gn.Percussion == timeKeeper || gn.Start == 0).ToList();

				_guitarR.Notes.Add(kicks.SelectMany((gn, i) => pitches.Take(2).Select(p => new Note(gn.Start, GetLength(gn, i, kicks), p, Velocity.F))).ToList());
				_guitarL.Notes.Add(kicks.SelectMany((gn, i) => pitches.Skip(2).Select(p => new Note(gn.Start, GetLength(gn, i, kicks), p, Velocity.F))).ToList());
				_bass.Notes.Add(kicks.Select((gn, i) => new Note(gn.Start, GetLength(gn, i, kicks), pitches[0].AddOctave(-1), Velocity.Fff)).ToList());
				_drums.Notes.Add(grooveNotes);
			}

			return _measures;
		}

		private void GetChordProgression()
		{
			do
			{
				Chords = ChordProgressionGenerator.ChordProgression(Pitch.G0, MinorOrDiminshedFilter);
			} while (Chords.Count <= 2 && Chords.Count(c => c.Quality == ChordQuality.Minor) < 2);

			if (Chords.Count == 3)
			{
				AugmentThreeChordProgression();
			}
		}

		private double GetLength(PercussionNote gn, int i, IReadOnlyList<PercussionNote> kicks)
		{
			var start = gn.Start;
			var nextStart = i == kicks.Count - 1 ? _time.BeatCount : kicks[i + 1].Start;
			var length = nextStart - start;
			return length;
		}

		private void AugmentThreeChordProgression()
		{
			if (Chords.Count != 3) throw new ArgumentException("Must have three chords");

			switch (new[] { 0, 1, 2 }[Randomizer.GetWeightedIndex(new List<double> { 0.2, 0.3, 0.5 })])
			{
				case 0: // Extend chord 1
					Chords.Insert(1, Chords[0]);
					break;
				case 1: // Extend chord 2
					Chords.Insert(2, Chords[1]);
					break;
				default: // Extend chord 3
					Chords.Add(Chords[2]);
					break;
			}
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
	}
}
