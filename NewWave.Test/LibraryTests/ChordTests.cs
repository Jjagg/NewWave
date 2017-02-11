using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core.Chords;
using NewWave.Core.Pitches;

namespace NewWave.Test.LibraryTests
{
	[TestClass]
	public class ChordTests
	{
		[TestMethod]
		public void CChordTest()
		{
			var chord = new Chord(Pitch.C);
			var pitches = chord.Pitches(3).ToList();
			Assert.AreEqual(3, pitches.Count);

			Assert.AreEqual(OctavePitch.C3, pitches[0]);
			Assert.AreEqual(OctavePitch.E3, pitches[1]);
			Assert.AreEqual(OctavePitch.G3, pitches[2]);
		}

		[TestMethod]
		public void CminChordTest()
		{
			var chord = new Chord(Pitch.C, ChordQuality.Minor);
			var pitches = chord.Pitches(3).ToList();
			Assert.AreEqual(3, pitches.Count);

			Assert.AreEqual(OctavePitch.C3, pitches[0]);
			Assert.AreEqual(OctavePitch.DSharp3, pitches[1]);
			Assert.AreEqual(OctavePitch.G3, pitches[2]);
		}

		[TestMethod]
		public void Cmin7ChordTest()
		{
			var chord = new Chord(Pitch.C, ChordQuality.Minor, ChordAdded.Seven);
			var pitches = chord.Pitches(3).ToList();
			Assert.AreEqual(4, pitches.Count);

			Assert.AreEqual(OctavePitch.C3, pitches[0]);
			Assert.AreEqual(OctavePitch.DSharp3, pitches[1]);
			Assert.AreEqual(OctavePitch.G3, pitches[2]);
			Assert.AreEqual(OctavePitch.ASharp3, pitches[3]);
		}

		[TestMethod]
		public void Cmin9ChordTest()
		{
			var chord = new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.Nine);
			var pitches = chord.Pitches(3).ToList();
			Assert.AreEqual(5, pitches.Count);

			Assert.AreEqual(OctavePitch.C3, pitches[0]);
			Assert.AreEqual(OctavePitch.E3, pitches[1]);
			Assert.AreEqual(OctavePitch.G3, pitches[2]);
			Assert.AreEqual(OctavePitch.ASharp3, pitches[3]);
			Assert.AreEqual(OctavePitch.D4, pitches[4]);
		}

		[TestMethod]
		public void Cmin11ChordTest()
		{
			var chord = new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.Eleven);
			var pitches = chord.Pitches(3).ToList();
			Assert.AreEqual(6, pitches.Count);

			Assert.AreEqual(OctavePitch.C3, pitches[0]);
			Assert.AreEqual(OctavePitch.E3, pitches[1]);
			Assert.AreEqual(OctavePitch.G3, pitches[2]);
			Assert.AreEqual(OctavePitch.ASharp3, pitches[3]);
			Assert.AreEqual(OctavePitch.D4, pitches[4]);
			Assert.AreEqual(OctavePitch.F4, pitches[5]);
		}

		[TestMethod]
		public void CsusChordTest()
		{
			var chord = new Chord(Pitch.C, ChordQuality.Suspended, ChordAdded.Nine);
			var pitches = chord.Pitches(3).ToList();
			Assert.AreEqual(5, pitches.Count);

			Assert.AreEqual(OctavePitch.C3, pitches[0]);
			Assert.AreEqual(OctavePitch.F3, pitches[1]);
			Assert.AreEqual(OctavePitch.G3, pitches[2]);
			Assert.AreEqual(OctavePitch.ASharp3, pitches[3]);
			Assert.AreEqual(OctavePitch.D4, pitches[4]);
		}
	}
}
