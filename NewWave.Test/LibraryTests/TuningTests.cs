using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Library.Tunings;
using NewWave.Midi;

namespace NewWave.Test.LibraryTests
{
	[TestClass]
	public class TuningTests
	{
		[TestMethod]
		public void StandardGuitarTuningTest()
		{
			var tuning = GuitarTuningLibrary.StandardGuitarTuning;
			Assert.AreEqual(6, tuning.Pitches.Length);
			Assert.AreEqual(MidiPitch.E2, tuning.Pitches[0]);
			Assert.AreEqual(MidiPitch.A2, tuning.Pitches[1]);
			Assert.AreEqual(MidiPitch.D3, tuning.Pitches[2]);
			Assert.AreEqual(MidiPitch.G3, tuning.Pitches[3]);
			Assert.AreEqual(MidiPitch.B3, tuning.Pitches[4]);
			Assert.AreEqual(MidiPitch.E4, tuning.Pitches[5]);
			Assert.IsFalse(tuning.IsDropTuning);
		}

		[TestMethod]
		public void DropDGuitarTuningTest()
		{
			var tuning = GuitarTuningLibrary.DropDGuitarTuning;
			Assert.AreEqual(6, tuning.Pitches.Length);
			Assert.AreEqual(MidiPitch.D2, tuning.Pitches[0]);
			Assert.AreEqual(MidiPitch.A2, tuning.Pitches[1]);
			Assert.AreEqual(MidiPitch.D3, tuning.Pitches[2]);
			Assert.AreEqual(MidiPitch.G3, tuning.Pitches[3]);
			Assert.AreEqual(MidiPitch.B3, tuning.Pitches[4]);
			Assert.AreEqual(MidiPitch.E4, tuning.Pitches[5]);
			Assert.IsTrue(tuning.IsDropTuning);
		}

		[TestMethod]
		public void DropAGuitarTuningTest()
		{
			var tuning = GuitarTuningLibrary.DropDGuitarTuning.Retune(-5);
			Assert.AreEqual(6, tuning.Pitches.Length);
			Assert.AreEqual(MidiPitch.A1, tuning.Pitches[0]);
			Assert.AreEqual(MidiPitch.E2, tuning.Pitches[1]);
			Assert.AreEqual(MidiPitch.A2, tuning.Pitches[2]);
			Assert.AreEqual(MidiPitch.D3, tuning.Pitches[3]);
			Assert.AreEqual(MidiPitch.FSharp3, tuning.Pitches[4]);
			Assert.AreEqual(MidiPitch.B3, tuning.Pitches[5]);
			Assert.IsTrue(tuning.IsDropTuning);
		}

		[TestMethod]
		public void StandardBassTuningTest()
		{
			var tuning = GuitarTuningLibrary.StandardBassTuning;
			Assert.AreEqual(4, tuning.Pitches.Length);
			Assert.AreEqual(MidiPitch.E1, tuning.Pitches[0]);
			Assert.AreEqual(MidiPitch.A1, tuning.Pitches[1]);
			Assert.AreEqual(MidiPitch.D2, tuning.Pitches[2]);
			Assert.AreEqual(MidiPitch.G2, tuning.Pitches[3]);
			Assert.IsFalse(tuning.IsDropTuning);
		}

		[TestMethod]
		public void StandardFiveStringBassTuningTest()
		{
			var tuning = GuitarTuningLibrary.StandardFiveStringBassTuning;
			Assert.AreEqual(5, tuning.Pitches.Length);
			Assert.AreEqual(MidiPitch.B0, tuning.Pitches[0]);
			Assert.AreEqual(MidiPitch.E1, tuning.Pitches[1]);
			Assert.AreEqual(MidiPitch.A1, tuning.Pitches[2]);
			Assert.AreEqual(MidiPitch.D2, tuning.Pitches[3]);
			Assert.AreEqual(MidiPitch.G2, tuning.Pitches[4]);
			Assert.IsFalse(tuning.IsDropTuning);
		}

		[TestMethod]
		public void DetunedGuitarTuningTest()
		{
			var tuning = GuitarTuningLibrary.StandardGuitarTuning;
			tuning.Retune(-3);
			Assert.AreEqual(6, tuning.Pitches.Length);
			Assert.AreEqual(MidiPitch.CSharp2, tuning.Pitches[0]);
			Assert.AreEqual(MidiPitch.FSharp2, tuning.Pitches[1]);
			Assert.AreEqual(MidiPitch.B2, tuning.Pitches[2]);
			Assert.AreEqual(MidiPitch.E3, tuning.Pitches[3]);
			Assert.AreEqual(MidiPitch.GSharp3, tuning.Pitches[4]);
			Assert.AreEqual(MidiPitch.CSharp4, tuning.Pitches[5]);
			Assert.IsFalse(tuning.IsDropTuning);
		}
	}
}
