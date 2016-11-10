using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator;
using NewWave.Midi;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class SectionTests
	{
		[TestMethod]
		public void SectionTest()
		{
			var guitarR = new InstrumentTrack(Instrument.DistortionGuitar, Pan.Right, new List<List<Note>>());
			var guitarL = new InstrumentTrack(Instrument.DistortionGuitar, Pan.Left, new List<List<Note>>());
			var bass = new InstrumentTrack(Instrument.ElectricBassFinger, Pan.Center, new List<List<Note>>());
			var drums = new PercussionTrack(new List<List<PercussionNote>>());
			var section = new SongSection(TimeSignature.CommonTime, guitarR, guitarL, bass, drums);

			var totalBeats = section.Measures * section.Time.BeatCount;
			Console.WriteLine("Total beats: {0}", totalBeats);
			for (var beat = 0; beat < totalBeats; beat++)
			{
				var chordHere = section.Chords.FirstOrDefault(c => c.Item1 == beat);
				Console.WriteLine("{0} {1} - {2}", beat % section.Time.BeatCount == 0 ? "-" : " ", beat, chordHere?.Item2);
			}
		}
	}
}
