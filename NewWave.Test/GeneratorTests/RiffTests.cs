using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator.ChordProgressions;
using NewWave.Generator.Sections;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class RiffTests
	{
		[TestMethod]
		public void RiffTest()
		{
			var section = new SongSection(SectionType.None, 1, TimeSignature.CommonTime, 4, ChordProgressionGenerator.ChordProgression(n => n));
			var riff = section.Riff;
			foreach (var note in riff)
			{
				Console.WriteLine(note);
			}
		}
	}
}
