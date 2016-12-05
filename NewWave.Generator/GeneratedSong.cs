using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewWave.Core;
using NewWave.Generator.ChordProgressions;
using NewWave.Generator.Parameters;
using NewWave.Generator.Sections;
using NewWave.Midi;

namespace NewWave.Generator
{
	public class GeneratedSong : Song
	{
		private SongInfo _songInfo;
		internal List<SongSection> Sections;

		public override string Generate(IParameterList parameterList)
		{
			var param = (ParameterList)parameterList;
			var time = param.TimeSignatureFunc();
			var feel = param.FeelFunc(time);
			_songInfo = new SongInfo(time, feel) { Parameters = param };

			var sections = new SectionLayoutGenerator().GetSectionLayout(_songInfo).ToList();
			var chordProgressions = GetDistinctChordProgressions(param, sections.Distinct().Count());
			var mappedChordProgressions = sections.Distinct().Select((s, i) => new Tuple<int, SectionType>(i, s));
			var sectionTypes = mappedChordProgressions.Distinct()
				.ToDictionary(s => s.Item2, s => new SongSection(_songInfo, s.Item2, chordProgressions[s.Item1]));
			Sections = sections.Select(s => sectionTypes[s]).ToList();
			return WriteStats(_songInfo);
		}

		public override Score Render()
		{
			var guitarLc = new InstrumentTrack(Instrument.ElectricGuitarJazz, Pan.Left, new List<List<Note>>());
			var guitarL = new InstrumentTrack(Instrument.DistortionGuitar, Pan.Left, new List<List<Note>>());
			var guitarRc = new InstrumentTrack(Instrument.ElectricGuitarClean, Pan.Right, new List<List<Note>>());
			var guitarR = new InstrumentTrack(Instrument.OverdrivenGuitar, Pan.Right, new List<List<Note>>());
			var guitarC = new InstrumentTrack(Instrument.OverdrivenGuitar, Pan.Center, new List<List<Note>>());
			var bass = new InstrumentTrack(Instrument.ElectricBassPick, Pan.Center, new List<List<Note>>());
			var drums = new PercussionTrack(new List<List<PercussionNote>>());

			var renderedSections = Sections.Select(s => s.Render(guitarR, guitarL, guitarC, guitarLc, guitarRc, bass, drums));

			return new Score(renderedSections.Sum(s => s),
				new Dictionary<int, TimeSignature> { { 0, _songInfo.TimeSignature } },
				new Dictionary<int, int> { { 0, _songInfo.Tempo } },
				new List<InstrumentTrack> { guitarL, guitarR, guitarC, guitarLc, guitarRc, bass },
				drums);
		}

		private string WriteStats(SongInfo songInfo)
		{
			var totalBeatCount = Sections.Sum(s => s.Measures * songInfo.TimeSignature.BeatCount);
			var totalMinutes = (double)totalBeatCount / _songInfo.Tempo;
			var minutes = (int)totalMinutes;
			var seconds = (int)((totalMinutes - minutes) * 60);

			var sb = new StringBuilder();
			sb.AppendLine(DisplayName);
			sb.AppendLine("----------");
			sb.AppendLine(string.Format("Measures: {0}", Sections.Sum(s => s.Measures)));
			sb.AppendLine(string.Format("Attempted song length: {0:0}:{1:00}", songInfo.LengthInSeconds / 60, songInfo.LengthInSeconds % 60));
			sb.AppendLine(string.Format("Song length: {0}:{1:00}", minutes, seconds));
			sb.AppendLine(string.Format("Time signature: {0}", _songInfo.TimeSignature));
			sb.AppendLine(string.Format("Tempo: {0}", _songInfo.Tempo));
			sb.AppendLine(string.Format("Feel: 1/{0}", _songInfo.Feel));
			sb.AppendLine(string.Format("Key: {0}maj / {1}min", _songInfo.Parameters.MajorKey.NoteName(), _songInfo.Parameters.MinorKey.NoteName()));
			return sb.ToString();
		}

		private static List<ChordProgression> GetDistinctChordProgressions(ParameterList parameters, int amount)
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

		public override string DisplayName => "Generated song";
	}
}
