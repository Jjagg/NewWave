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
			for (var i = 0; i < 50; i++)
			{
				Console.WriteLine(string.Join(" - ", ChordProgressionGenerator.ChordProgression(Pitch.C3)));
			}
		}
	}
}
