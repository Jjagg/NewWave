using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
			var notes = groove.Notes(Percussion.ClosedHiHat, false);

			Assert.AreEqual(12, notes.Count);

			Console.WriteLine(groove.AsTab());
		}

		[TestMethod]
		public void GrooveList()
		{
			foreach (var groove in GrooveLibrary.AllGrooves)
			{
				Console.WriteLine(groove);
				Console.WriteLine(groove.AsTab());
			}
		}
	}
}
