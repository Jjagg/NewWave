using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator;
using NewWave.Generator.Parameters;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class ParameterizedGenerators
	{
		[TestMethod]
		public void Default()
		{
			RenderAndPlay(new DefaultParameterList());
		}

		[TestMethod]
		public void MinorFastSong()
		{
			RenderAndPlay(new MinorFastSongParameterList());
		}

		[TestMethod]
		public void SlowSong()
		{
			RenderAndPlay(new SlowSongParameterList());
		}

		private static void RenderAndPlay(IParameterList parameterList)
		{
			var song = new GeneratedSong();
			Common.RenderAndPlay(parameterList, song, "output.mid");
			foreach (var section in song.Sections)
			{
				Console.WriteLine("{0}: {1} meas, {2}", section.Type, section.Measures, string.Join(" - ", section.Chords.Select(c => c.Item2)));
			}
		}
	}
}
