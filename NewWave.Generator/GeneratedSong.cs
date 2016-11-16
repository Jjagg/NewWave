using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Generator.ChordProgressions;
using NewWave.Generator.Sections;
using NewWave.Library.Chords;
using NewWave.Midi;

namespace NewWave.Generator
{
	public class GeneratedSong : Song
	{
		private int _tempo;
		private TimeSignature _time;
		internal List<SongSection> Sections;

		public override string Generate()
		{
			_tempo = (int)Randomizer.NextNormalized(180, 10);
			_time = new TimeSignature(4, 4);

			const int sectionCount = 8;
			var chordProgressions = GetDistinctChordProgressions(sectionCount);
			Sections = Enumerable.Range(0, sectionCount).Select(i => new SongSection(SectionType.None, _time, chordProgressions[i])).ToList();
			
			return "Finished";
		}

		public override Score Render()
		{
			var guitarL = new InstrumentTrack(Instrument.DistortionGuitar, Pan.Left, new List<List<Note>>());
			var guitarR = new InstrumentTrack(Instrument.OverdrivenGuitar, Pan.Right, new List<List<Note>>());
			var bass = new InstrumentTrack(Instrument.ElectricBassPick, Pan.Center, new List<List<Note>>());
			var drums = new PercussionTrack(new List<List<PercussionNote>>());

			var renderedSections = Sections.Select(s => s.Render(guitarR, guitarL, bass, drums));

			WriteStats(Sections);

			return new Score(renderedSections.Sum(s => s),
				new Dictionary<int, TimeSignature> { { 0, _time } },
				new Dictionary<int, int> { { 0, _tempo } },
				new List<InstrumentTrack> { guitarL, guitarR, bass },
				drums);
		}

		private void WriteStats(List<SongSection> sections)
		{
			var totalBeatCount = sections.Sum(s => s.Measures * s.Time.BeatCount);
			var totalMinutes = (double)totalBeatCount / _tempo;
			var minutes = (int)totalMinutes;
			var seconds = (int)((totalMinutes - minutes) * 60);

			Console.WriteLine("----------");
			Console.WriteLine("Measures: {0}", sections.Sum(s => s.Measures));
			Console.WriteLine("Song length: {0}:{1:00}", minutes, seconds);
		}

		private static List<ChordProgression> GetDistinctChordProgressions(int amount)
		{
			var progressions = new List<ChordProgression>();
			while (progressions.Count < amount)
			{
				var prog = ChordProgressionGenerator.ChordProgression(MinorOrDiminshedFilter);
				if (progressions.All(p => !Equals(p, prog)))
				{
					progressions.Add(prog);
				}
			}
			return progressions;
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

		public override string DisplayName => "Generated song";
	}
}
