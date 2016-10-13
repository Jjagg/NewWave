using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Library.Grooves;

namespace NewWave.Test.LibraryTests
{
	[TestClass]
	public class GrooveTests
	{
		[TestMethod]
		public void RockGroove()
		{
			var groove = new Groove(TimeSignature.CommonTime, 4);
			var notes = groove.Notes();

			Assert.AreEqual(12, notes.Count);

			Console.WriteLine(groove.AsTab());
		}
	}
}
