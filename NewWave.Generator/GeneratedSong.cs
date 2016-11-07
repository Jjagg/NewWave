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
	public class GeneratedSong : Song
	{
		private int _tempo;
		private TimeSignature _time;

		public override string Generate()
		{
			_tempo = (int)Randomizer.NextNormalized(180, 10);
			_time = new TimeSignature(4, 4);

			return "Finished";
		}

		public override Score Render()
		{
			var guitar = new InstrumentTrack(Instrument.DistortionGuitar, Pan.Center, new List<List<Note>>());
			var bass = new InstrumentTrack(Instrument.ElectricBassFinger, Pan.Center, new List<List<Note>>());
			var drums = new PercussionTrack(new List<List<PercussionNote>>());

			var sections = Enumerable.Range(0, 8).Select(i => RenderSection(guitar, bass, drums));

			return new Score(sections.Sum(s => s),
				new Dictionary<int, TimeSignature> { { 0, _time } },
				new Dictionary<int, int> { { 0, _tempo } },
				new List<InstrumentTrack> { guitar, bass },
				drums);
		}

		private int RenderSection(InstrumentTrack guitar, InstrumentTrack bass, PercussionTrack drums)
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
				var kicks = grooveNotes.Where(gn => gn.Percussion == Percussion.BassDrum1).ToList();

				guitar.Notes.Add(kicks.SelectMany((gn, i) => pitches.Select(p => new Note(gn.Start, GetLength(gn, i, kicks), p, Velocity.F))).ToList());
				bass.Notes.Add(kicks.Select((gn, i) => new Note(gn.Start, GetLength(gn, i, kicks), pitches[0].AddOctave(-1), Velocity.Fff)).ToList());
				//guitar.Notes.Add(new List<Note>());
				//bass.Notes.Add(new List<Note>());
				drums.Notes.Add(grooveNotes);
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

		public override string DisplayName
		{
			get { return "Generated song"; }
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
						? new MarkovChainNode<Chord>(n.Data, n.Probability * 8.0, n.ChildNodes)
						: n;
			}
		}
	}
}
