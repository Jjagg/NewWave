using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Library.Chords;
using NewWave.Library.Pitches;
using NewWave.Midi;

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

			Assert.AreEqual(MidiPitch.C3, pitches[0]);
			Assert.AreEqual(MidiPitch.E3, pitches[1]);
			Assert.AreEqual(MidiPitch.G3, pitches[2]);
		}

		[TestMethod]
		public void CminChordTest()
		{
			var chord = new Chord(Pitch.C, ChordQuality.Minor);
			var pitches = chord.Pitches(3).ToList();
			Assert.AreEqual(3, pitches.Count);

			Assert.AreEqual(MidiPitch.C3, pitches[0]);
			Assert.AreEqual(MidiPitch.DSharp3, pitches[1]);
			Assert.AreEqual(MidiPitch.G3, pitches[2]);
		}

		[TestMethod]
		public void Cmin7ChordTest()
		{
			var chord = new Chord(Pitch.C, ChordQuality.Minor, ChordAdded.Seven);
			var pitches = chord.Pitches(3).ToList();
			Assert.AreEqual(4, pitches.Count);

			Assert.AreEqual(MidiPitch.C3, pitches[0]);
			Assert.AreEqual(MidiPitch.DSharp3, pitches[1]);
			Assert.AreEqual(MidiPitch.G3, pitches[2]);
			Assert.AreEqual(MidiPitch.ASharp3, pitches[3]);
		}

		[TestMethod]
		public void Cmin9ChordTest()
		{
			var chord = new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.Nine);
			var pitches = chord.Pitches(3).ToList();
			Assert.AreEqual(5, pitches.Count);

			Assert.AreEqual(MidiPitch.C3, pitches[0]);
			Assert.AreEqual(MidiPitch.E3, pitches[1]);
			Assert.AreEqual(MidiPitch.G3, pitches[2]);
			Assert.AreEqual(MidiPitch.ASharp3, pitches[3]);
			Assert.AreEqual(MidiPitch.D4, pitches[4]);
		}

		[TestMethod]
		public void Cmin11ChordTest()
		{
			var chord = new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.Eleven);
			var pitches = chord.Pitches(3).ToList();
			Assert.AreEqual(6, pitches.Count);

			Assert.AreEqual(MidiPitch.C3, pitches[0]);
			Assert.AreEqual(MidiPitch.E3, pitches[1]);
			Assert.AreEqual(MidiPitch.G3, pitches[2]);
			Assert.AreEqual(MidiPitch.ASharp3, pitches[3]);
			Assert.AreEqual(MidiPitch.D4, pitches[4]);
			Assert.AreEqual(MidiPitch.F4, pitches[5]);
		}

		[TestMethod]
		public void CsusChordTest()
		{
			var chord = new Chord(Pitch.C, ChordQuality.Suspended, ChordAdded.Nine);
			var pitches = chord.Pitches(3).ToList();
			Assert.AreEqual(5, pitches.Count);

			Assert.AreEqual(MidiPitch.C3, pitches[0]);
			Assert.AreEqual(MidiPitch.F3, pitches[1]);
			Assert.AreEqual(MidiPitch.G3, pitches[2]);
			Assert.AreEqual(MidiPitch.ASharp3, pitches[3]);
			Assert.AreEqual(MidiPitch.D4, pitches[4]);
		}
	}
}
