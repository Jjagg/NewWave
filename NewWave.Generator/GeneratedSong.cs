using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

			var sections = SectionLayoutGenerator.GetSectionLayout().ToList();
			var chordProgressions = GetDistinctChordProgressions(sections.Distinct().Count());
			var mappedChordProgressions = sections.Distinct().Select((s, i) => new Tuple<int, SectionType>(i, s));
			var sectionTypes = mappedChordProgressions.Distinct()
				.ToDictionary(s => s.Item2, s => new SongSection(s.Item2, _time, chordProgressions[s.Item1]));
			Sections = sections.Select(s => sectionTypes[s]).ToList();
			return WriteStats();
		}

		public override Score Render()
		{
			var guitarL = new InstrumentTrack(Instrument.DistortionGuitar, Pan.Left, new List<List<Note>>());
			var guitarR = new InstrumentTrack(Instrument.OverdrivenGuitar, Pan.Right, new List<List<Note>>());
			var bass = new InstrumentTrack(Instrument.ElectricBassPick, Pan.Center, new List<List<Note>>());
			var drums = new PercussionTrack(new List<List<PercussionNote>>());

			var renderedSections = Sections.Select(s => s.Render(guitarR, guitarL, bass, drums));

			return new Score(renderedSections.Sum(s => s),
				new Dictionary<int, TimeSignature> { { 0, _time } },
				new Dictionary<int, int> { { 0, _tempo } },
				new List<InstrumentTrack> { guitarL, guitarR, bass },
				drums);
		}

		private string WriteStats()
		{
			var totalBeatCount = Sections.Sum(s => s.Measures * s.Time.BeatCount);
			var totalMinutes = (double)totalBeatCount / _tempo;
			var minutes = (int)totalMinutes;
			var seconds = (int)((totalMinutes - minutes) * 60);

			var sb = new StringBuilder();
			sb.AppendLine("----------");
			sb.AppendLine(string.Format("Measures: {0}", Sections.Sum(s => s.Measures)));
			sb.AppendLine(string.Format("Song length: {0}:{1:00}", minutes, seconds));
			return sb.ToString();
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
