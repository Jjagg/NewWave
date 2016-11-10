using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Library.Grooves;
using NewWave.Midi;

namespace NewWave.Test.LibraryTests
{
	[TestClass]
	public class GrooveTests
	{
		[TestMethod]
		public void RockGroove()
		{
			var groove = GrooveLibrary.GetGroove();
			var notes = groove.Notes(Percussion.ClosedHiHat, false, TimeSignature.CommonTime);

			Assert.AreEqual(12, notes.Count);

			Console.WriteLine(TabWriter.AsTab(4, notes, 4));
		}

		[TestMethod]
		public void GrooveList()
		{
			foreach (var groove in GrooveLibrary.AllGrooves)
			{
				Console.WriteLine(groove);
				Console.WriteLine(TabWriter.AsTab(4, groove.Notes(Percussion.ClosedHiHat, false, TimeSignature.CommonTime), 4));
			}
		}
	}
}
