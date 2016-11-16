using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator.ChordProgressions;
using NewWave.Generator.Sections;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class SectionTests
	{
		[TestMethod]
		public void SectionTest()
		{
			var section = new SongSection(SectionType.None, TimeSignature.CommonTime, ChordProgressionGenerator.ChordProgression(n => n));

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
