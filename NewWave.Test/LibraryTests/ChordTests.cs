using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Library;
using NewWave.Midi;

namespace NewWave.Test.LibraryTests
{
	[TestClass]
	public class ChordTests
	{
		[TestMethod]
		public void CChordTest()
		{
			var chord = new Chord(Pitch.C3, ChordQuality.NotSpecified, ChordAdded.None);
			var pitches = chord.Pitches().ToList();
			Assert.AreEqual(3, pitches.Count);

			Assert.AreEqual(Pitch.C3, pitches[0]);
			Assert.AreEqual(Pitch.E3, pitches[1]);
			Assert.AreEqual(Pitch.G3, pitches[2]);
		}

		[TestMethod]
		public void CminChordTest()
		{
			var chord = new Chord(Pitch.C3, ChordQuality.Minor, ChordAdded.None);
			var pitches = chord.Pitches().ToList();
			Assert.AreEqual(3, pitches.Count);

			Assert.AreEqual(Pitch.C3, pitches[0]);
			Assert.AreEqual(Pitch.DSharp3, pitches[1]);
			Assert.AreEqual(Pitch.G3, pitches[2]);
		}

		[TestMethod]
		public void Cmin7ChordTest()
		{
			var chord = new Chord(Pitch.C3, ChordQuality.Minor, ChordAdded.Seven);
			var pitches = chord.Pitches().ToList();
			Assert.AreEqual(4, pitches.Count);

			Assert.AreEqual(Pitch.C3, pitches[0]);
			Assert.AreEqual(Pitch.DSharp3, pitches[1]);
			Assert.AreEqual(Pitch.G3, pitches[2]);
			Assert.AreEqual(Pitch.ASharp3, pitches[3]);
		}
	}
}
