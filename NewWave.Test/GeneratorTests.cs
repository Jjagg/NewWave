using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Generator;
using NewWave.Generator.ChordProgressions;
using NewWave.Midi;

namespace NewWave.Test
{
	[TestClass]
	public class GeneratorTests
	{
		[TestMethod]
		public void RenderTest()
		{
			Common.RenderAndPlay(new GeneratedSong(), "output.mid");
		}

		[TestMethod]
		public void ChordProgressionTest()
		{
			var progression = ChordProgressionGenerator.ChordProgression(Pitch.C3);
			foreach (var chord in progression)
			{
				Console.WriteLine(chord);
			}
		}
	}
}
