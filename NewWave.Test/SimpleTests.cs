using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewWave.Test
{
	[TestClass]
	public class SimpleTests
	{
		private readonly string _dir = AppDomain.CurrentDomain.BaseDirectory;

		[TestMethod]
		public void ScoreTest()
		{
			var song = new TestSong();
			Console.WriteLine(song.Generate());
			var score = song.Render();
			var outputPath = Path.Combine(_dir, "output.mid");
			score.ExportMidi(outputPath);
			Process.Start(outputPath);
		}
	}
}
