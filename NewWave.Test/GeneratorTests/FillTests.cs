using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator;
using NewWave.Generator.Grooves;
using NewWave.Library.Grooves;
using NewWave.Midi;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class FillTests
	{
		[TestMethod]
		public void GetFill()
		{
			const double lengthInBeats = 4.0;
			Console.WriteLine(TabWriter.AsTab(4, FillGenerator.GetFill(0, lengthInBeats).ToList(), (int)lengthInBeats));
		}

		[TestMethod]
		public void GrooveWithFill()
		{
			var time = TimeSignature.CommonTime;
			const int measures = 4;
			var totalLength = measures * time.BeatCount;
			var groove = GrooveLibrary.GetGroove();
			var grooveNotes = Enumerable.Range(0, measures).SelectMany(i => groove.Notes(Percussion.OpenHiHat, i == 0, time).Select(n => new PercussionNote(n.Start + i * time.BeatCount, n.Percussion, n.Velocity)));
			var fillLength = new List<double> { 2.0, 4.0 }[Randomizer.GetWeightedIndex(new List<double> { 0.5, 0.5 })];
			var fill = FillGenerator.GetFill(totalLength - fillLength, fillLength);
			grooveNotes = grooveNotes.Where(n => n.Start < totalLength - fillLength).Union(fill);
			Console.WriteLine(TabWriter.AsTab(4, grooveNotes.ToList(), measures * time.BeatCount));
		}
	}
}
