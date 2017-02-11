using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewWave.Core;
using NewWave.Core.Instruments;
using NewWave.Core.Pitches;
using NewWave.Generator.ChordProgressions;
using NewWave.Generator.Common;
using NewWave.Generator.Common.ChordProgressions;
using NewWave.Generator.Parameters;
using NewWave.Generator.Sections;
using NewWave.Midi;

namespace NewWave.Generator
{
	public class MarkovGeneratorSong
	{
	    public SongInfo SongInfo { get; }
        public List<SongSection> Sections { get; }
	    public MarkovGeneratorParameters Parameters { get; }

	    public MarkovGeneratorSong(SongInfo songInfo, List<SongSection> sections, MarkovGeneratorParameters parameters)
	    {
	        SongInfo = songInfo;
	        Sections = sections;
	        Parameters = parameters;
	    }

		public static MarkovGeneratorSong Generate(MarkovGeneratorParameters ps)
		{
			var param = ps;
			var time = param.TimeSignatureFunc();
			var feel = param.FeelFunc(time);

            var tempo = (int)Randomizer.NextNormalized(ps.TempoMean, ps.TempoStandardDeviation);
            var length = Randomizer.NextNormalized(ps.LengthInSecondsMean, ps.LengthInSecondsStandardDeviation);
			var songInfo = new SongInfo(time, feel, tempo, length);

			var sections = new SectionLayoutGenerator().GetSectionLayout(songInfo).ToList();
			var chordProgressions = GetDistinctChordProgressions(param, sections.Distinct().Count());
			var mappedChordProgressions = sections.Distinct().Select((s, i) => new Tuple<int, SectionType>(i, s));
			var sectionTypes = mappedChordProgressions.Distinct()
				.ToDictionary(s => s.Item2, s => new SongSection(songInfo, s.Item2, chordProgressions[s.Item1], ps));
			var songSections = sections.Select(s => sectionTypes[s]).ToList();
			return new MarkovGeneratorSong(songInfo, songSections, ps);
		}

		public Score Render()
		{
			var guitarLc = new InstrumentTrack((int) Instrument.ElectricGuitarJazz, (int) Pan.Left, new List<List<Note>>());
			var guitarL = new InstrumentTrack((int) Instrument.DistortionGuitar, (int) Pan.Left, new List<List<Note>>());
			var guitarRc = new InstrumentTrack((int) Instrument.ElectricGuitarClean, (int) Pan.Right, new List<List<Note>>());
			var guitarR = new InstrumentTrack((int) Instrument.OverdrivenGuitar, (int) Pan.Right, new List<List<Note>>());
			var guitarC = new InstrumentTrack((int) Instrument.OverdrivenGuitar, (int) Pan.Center, new List<List<Note>>());
			var bass = new InstrumentTrack((int) Instrument.ElectricBassPick, (int) Pan.Center, new List<List<Note>>());
			var drums = new PercussionTrack(new List<List<PercussionNote>>());

			var renderedSections = Sections.Select(s => s.Render(guitarR, guitarL, guitarC, guitarLc, guitarRc, bass, drums, Parameters));

			return new Score(renderedSections.Sum(s => s),
				new Dictionary<int, TimeSignature> { { 0, SongInfo.TimeSignature } },
				new Dictionary<int, int> { { 0, SongInfo.Tempo } },
				new List<InstrumentTrack> { guitarL, guitarR, guitarC, guitarLc, guitarRc, bass },
				drums);
		}

		public override string ToString()
		{
			var totalBeatCount = Sections.Sum(s => s.Measures * SongInfo.TimeSignature.BeatCount);
			var totalMinutes = (double)totalBeatCount / SongInfo.Tempo;
			var minutes = (int)totalMinutes;
			var seconds = (int)((totalMinutes - minutes) * 60);

			var sb = new StringBuilder();
			sb.AppendLine(DisplayName);
			sb.AppendLine("----------");
			sb.AppendLine(string.Format("Measures: {0}", Sections.Sum(s => s.Measures)));
			sb.AppendLine(string.Format("Attempted song length: {0:0}:{1:00}", SongInfo.LengthInSeconds / 60, SongInfo.LengthInSeconds % 60));
			sb.AppendLine(string.Format("Song length: {0}:{1:00}", minutes, seconds));
			sb.AppendLine(string.Format("Time signature: {0}", SongInfo.TimeSignature));
			sb.AppendLine(string.Format("Tempo: {0}", SongInfo.Tempo));
			sb.AppendLine(string.Format("Feel: 1/{0}", SongInfo.Feel));
			sb.AppendLine(string.Format("Key: {0}maj / {1}min", Parameters.MajorKey.NoteName(), Parameters.MinorKey.NoteName()));
			return sb.ToString();
		}

		private static List<ChordProgression> GetDistinctChordProgressions(MarkovGeneratorParameters parameters, int amount)
		{
			var progressions = new List<ChordProgression>();
			while (progressions.Count < amount)
			{
				var prog = ChordProgressionGenerator.ChordProgression(parameters.ChordProgressionFilter);
				if (progressions.All(p => !Equals(p, prog)))
				{
					progressions.Add(prog);
				}
			}
			return progressions;
		}

		public string DisplayName { get; set; } = "Generated song";
	}
}
