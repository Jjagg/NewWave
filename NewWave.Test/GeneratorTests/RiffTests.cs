using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator;
using NewWave.Generator.Grooves;
using NewWave.Generator.Riffs;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class RiffTests
	{
		[TestMethod]
		public void RiffResolutionTest()
		{
			const int feel = 4;
			var timeSignature = new TimeSignature(8, 4);
			var songInfo = new SongInfo(timeSignature, feel);
			var groove = GrooveGenerator.GenerateGroove(songInfo);
			WriteRhythm("Original groove", groove.Beats, timeSignature.BeatCount, feel);

			for (var i = 1; i <= 10; i ++)
			{
				var res = 4.0 / i;
				var riffBeats = RiffGenerator.Rhythm(timeSignature, groove.Beats.ToList(), res, feel);
				WriteRhythm(string.Format("{0:0}% resolution", res * 100), riffBeats, timeSignature.BeatCount, feel);
			}
		}

		private void WriteRhythm(string label, IEnumerable<double> lengths, int lengthInBeats, int feel)
		{
			var spacesPerBeat = feel;
			var tabLength = lengthInBeats * spacesPerBeat;
			Console.WriteLine(label);
			Console.WriteLine(string.Join("", Enumerable.Range(0, lengthInBeats).Select(i => string.Format("{0}{1}", i + 1, new string('.', feel - 1)))));
			Console.WriteLine(string.Join("", Enumerable.Range(0, tabLength).Select(i => lengths.Any(n => n * spacesPerBeat == i) ? "o" : "-")));
			Console.WriteLine();
		}
	}
}
