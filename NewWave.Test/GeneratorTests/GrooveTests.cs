using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Core.Grooves;
using NewWave.Generator;
using NewWave.Generator.Common;
using NewWave.Generator.Grooves;
using NewWave.Generator.Sections;
using NewWave.Midi;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class GrooveTests
	{
		[TestMethod]
		public void GenerateGroove()
		{;
			for (var i = 0; i < 20; i++)
			{
				var timeSignature = new TimeSignature(Randomizer.ProbabilityOfTrue(0.7) ? 4 : 3, 4);
				var feel = Randomizer.ProbabilityOfTrue(0.75) ? 4 : 3;
				var groove = GrooveGenerator.GenerateGroove(new SongInfo(timeSignature, feel));
				var drumStyle = new DrumStyle(SectionType.Verse);
				drumStyle.Generate(groove);
				Console.WriteLine("{0}, {1} feel", timeSignature, feel);
				Console.WriteLine(TabWriter.AsTab(groove.Feel, drumStyle.Notes, timeSignature.BeatCount));
			}
		}
	}
}
