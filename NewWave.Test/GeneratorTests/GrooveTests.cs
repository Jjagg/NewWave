﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator;
using NewWave.Generator.Grooves;
using NewWave.Library.Grooves;
using NewWave.Midi;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class GrooveTests
	{
		[TestMethod]
		public void GenerateGroove()
		{
			for (var i = 0; i < 20; i++)
			{
				var timeSignature = new TimeSignature(Randomizer.ProbabilityOfTrue(0.7) ? 4 : 3, 4);
				var feel = Randomizer.ProbabilityOfTrue(0.6) ? 4 : 3;
				var groove = GrooveGenerator.GenerateGroove(new SongInfo(timeSignature, feel));
				Console.WriteLine(TabWriter.AsTab(groove.Feel, groove.Notes(Percussion.RideCymbal1, false, timeSignature), timeSignature.BeatCount));
			}
		}
	}
}
