using System;
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
			score.ExportMidi(Path.Combine(_dir, "output.mid"));
		}
	}
}
