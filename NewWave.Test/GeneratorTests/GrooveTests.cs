using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator;
using NewWave.Generator.Grooves;
using NewWave.Generator.Sections;
using NewWave.Library.Grooves;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class GrooveTests
	{
		[TestMethod]
		public void GenerateGroove()
		{
			var drumStyle = new DrumStyle(SectionType.Verse);
			for (var i = 0; i < 20; i++)
			{
				var timeSignature = new TimeSignature(Randomizer.ProbabilityOfTrue(0.7) ? 4 : 3, 4);
				var feel = Randomizer.ProbabilityOfTrue(0.6) ? 4 : 2;
				var groove = GrooveGenerator.GenerateGroove(new SongInfo(timeSignature, feel));
				Console.WriteLine("{0}, {1} feel", timeSignature, feel);
				Console.WriteLine(TabWriter.AsTab(groove.Feel, drumStyle.Notes(groove), timeSignature.BeatCount));
			}
		}
	}
}
