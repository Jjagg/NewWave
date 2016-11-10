using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
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
			var guitarL = new InstrumentTrack(Instrument.DistortionGuitar, Pan.Left, new List<List<Note>>());
			var guitarR = new InstrumentTrack(Instrument.OverdrivenGuitar, Pan.Right, new List<List<Note>>());
			var bass = new InstrumentTrack(Instrument.ElectricBassPick, Pan.Center, new List<List<Note>>());
			var drums = new PercussionTrack(new List<List<PercussionNote>>());

			var sections = Enumerable.Range(0, 8).Select(i => new SongSection(_time, guitarR, guitarL, bass, drums));
			var renderedSections = sections.Select(s => s.Render());

			return new Score(renderedSections.Sum(s => s),
				new Dictionary<int, TimeSignature> { { 0, _time } },
				new Dictionary<int, int> { { 0, _tempo } },
				new List<InstrumentTrack> { guitarL, guitarR, bass },
				drums);
		}

		public override string DisplayName => "Generated song";
	}
}
