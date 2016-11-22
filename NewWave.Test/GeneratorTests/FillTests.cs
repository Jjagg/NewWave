using System;
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
			Console.WriteLine(TabWriter.AsTab(3, FillGenerator.GetFill(0, lengthInBeats, 3).ToList(), (int)lengthInBeats));
		}

		[TestMethod]
		public void GrooveWithFill()
		{
			var time = TimeSignature.CommonTime;
			var feel = Randomizer.ProbabilityOfTrue(0.6) ? 4 : 3;
			const int measures = 4;
			var totalLength = measures * time.BeatCount;
			var groove = GrooveGenerator.GenerateGroove(new SongInfo(time, feel));
			var grooveNotes = Enumerable.Range(0, measures).SelectMany(i => groove.Notes(Percussion.OpenHiHat, i == 0, time).Select(n => new PercussionNote(n.Start + i * time.BeatCount, n.Percussion, n.Velocity)));
			var fillLength = Randomizer.ProbabilityOfTrue(0.5) ? 2 : 4;
			var fill = FillGenerator.GetFill(totalLength - fillLength, fillLength, feel);
			grooveNotes = grooveNotes.Where(n => n.Start < totalLength - fillLength).Union(fill);
			Console.WriteLine(TabWriter.AsTab(feel, grooveNotes.ToList(), measures * time.BeatCount));
		}
	}
}
