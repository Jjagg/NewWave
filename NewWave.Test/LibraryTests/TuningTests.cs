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
			Assert.AreEqual(Pitch.E2, tuning.Pitches[0]);
			Assert.AreEqual(Pitch.A2, tuning.Pitches[1]);
			Assert.AreEqual(Pitch.D3, tuning.Pitches[2]);
			Assert.AreEqual(Pitch.G3, tuning.Pitches[3]);
			Assert.AreEqual(Pitch.B3, tuning.Pitches[4]);
			Assert.AreEqual(Pitch.E4, tuning.Pitches[5]);
			Assert.IsFalse(tuning.IsDropTuning);
		}

		[TestMethod]
		public void DropDGuitarTuningTest()
		{
			var tuning = GuitarTuningLibrary.DropDGuitarTuning;
			Assert.AreEqual(6, tuning.Pitches.Length);
			Assert.AreEqual(Pitch.D2, tuning.Pitches[0]);
			Assert.AreEqual(Pitch.A2, tuning.Pitches[1]);
			Assert.AreEqual(Pitch.D3, tuning.Pitches[2]);
			Assert.AreEqual(Pitch.G3, tuning.Pitches[3]);
			Assert.AreEqual(Pitch.B3, tuning.Pitches[4]);
			Assert.AreEqual(Pitch.E4, tuning.Pitches[5]);
			Assert.IsTrue(tuning.IsDropTuning);
		}

		[TestMethod]
		public void DropAGuitarTuningTest()
		{
			var tuning = GuitarTuningLibrary.DropDGuitarTuning.Retune(-5);
			Assert.AreEqual(6, tuning.Pitches.Length);
			Assert.AreEqual(Pitch.A1, tuning.Pitches[0]);
			Assert.AreEqual(Pitch.E2, tuning.Pitches[1]);
			Assert.AreEqual(Pitch.A2, tuning.Pitches[2]);
			Assert.AreEqual(Pitch.D3, tuning.Pitches[3]);
			Assert.AreEqual(Pitch.FSharp3, tuning.Pitches[4]);
			Assert.AreEqual(Pitch.B3, tuning.Pitches[5]);
			Assert.IsTrue(tuning.IsDropTuning);
		}

		[TestMethod]
		public void StandardBassTuningTest()
		{
			var tuning = GuitarTuningLibrary.StandardBassTuning;
			Assert.AreEqual(4, tuning.Pitches.Length);
			Assert.AreEqual(Pitch.E1, tuning.Pitches[0]);
			Assert.AreEqual(Pitch.A1, tuning.Pitches[1]);
			Assert.AreEqual(Pitch.D2, tuning.Pitches[2]);
			Assert.AreEqual(Pitch.G2, tuning.Pitches[3]);
			Assert.IsFalse(tuning.IsDropTuning);
		}

		[TestMethod]
		public void StandardFiveStringBassTuningTest()
		{
			var tuning = GuitarTuningLibrary.StandardFiveStringBassTuning;
			Assert.AreEqual(5, tuning.Pitches.Length);
			Assert.AreEqual(Pitch.B0, tuning.Pitches[0]);
			Assert.AreEqual(Pitch.E1, tuning.Pitches[1]);
			Assert.AreEqual(Pitch.A1, tuning.Pitches[2]);
			Assert.AreEqual(Pitch.D2, tuning.Pitches[3]);
			Assert.AreEqual(Pitch.G2, tuning.Pitches[4]);
			Assert.IsFalse(tuning.IsDropTuning);
		}

		[TestMethod]
		public void DetunedGuitarTuningTest()
		{
			var tuning = GuitarTuningLibrary.StandardGuitarTuning;
			tuning.Retune(-3);
			Assert.AreEqual(6, tuning.Pitches.Length);
			Assert.AreEqual(Pitch.CSharp2, tuning.Pitches[0]);
			Assert.AreEqual(Pitch.FSharp2, tuning.Pitches[1]);
			Assert.AreEqual(Pitch.B2, tuning.Pitches[2]);
			Assert.AreEqual(Pitch.E3, tuning.Pitches[3]);
			Assert.AreEqual(Pitch.GSharp3, tuning.Pitches[4]);
			Assert.AreEqual(Pitch.CSharp4, tuning.Pitches[5]);
			Assert.IsFalse(tuning.IsDropTuning);
		}
	}
}
