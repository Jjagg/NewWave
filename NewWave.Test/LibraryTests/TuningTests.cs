using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core.Pitches;
using NewWave.Core.Tunings;

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
			Assert.AreEqual(OctavePitch.E2, tuning.Pitches[0]);
			Assert.AreEqual(OctavePitch.A2, tuning.Pitches[1]);
			Assert.AreEqual(OctavePitch.D3, tuning.Pitches[2]);
			Assert.AreEqual(OctavePitch.G3, tuning.Pitches[3]);
			Assert.AreEqual(OctavePitch.B3, tuning.Pitches[4]);
			Assert.AreEqual(OctavePitch.E4, tuning.Pitches[5]);
			Assert.IsFalse(tuning.IsDropTuning);
		}

		[TestMethod]
		public void DropDGuitarTuningTest()
		{
			var tuning = GuitarTuningLibrary.DropDGuitarTuning;
			Assert.AreEqual(6, tuning.Pitches.Length);
			Assert.AreEqual(OctavePitch.D2, tuning.Pitches[0]);
			Assert.AreEqual(OctavePitch.A2, tuning.Pitches[1]);
			Assert.AreEqual(OctavePitch.D3, tuning.Pitches[2]);
			Assert.AreEqual(OctavePitch.G3, tuning.Pitches[3]);
			Assert.AreEqual(OctavePitch.B3, tuning.Pitches[4]);
			Assert.AreEqual(OctavePitch.E4, tuning.Pitches[5]);
			Assert.IsTrue(tuning.IsDropTuning);
		}

		[TestMethod]
		public void DropAGuitarTuningTest()
		{
			var tuning = GuitarTuningLibrary.DropDGuitarTuning.Retune(-5);
			Assert.AreEqual(6, tuning.Pitches.Length);
			Assert.AreEqual(OctavePitch.A1, tuning.Pitches[0]);
			Assert.AreEqual(OctavePitch.E2, tuning.Pitches[1]);
			Assert.AreEqual(OctavePitch.A2, tuning.Pitches[2]);
			Assert.AreEqual(OctavePitch.D3, tuning.Pitches[3]);
			Assert.AreEqual(OctavePitch.FSharp3, tuning.Pitches[4]);
			Assert.AreEqual(OctavePitch.B3, tuning.Pitches[5]);
			Assert.IsTrue(tuning.IsDropTuning);
		}

		[TestMethod]
		public void StandardBassTuningTest()
		{
			var tuning = GuitarTuningLibrary.StandardBassTuning;
			Assert.AreEqual(4, tuning.Pitches.Length);
			Assert.AreEqual(OctavePitch.E1, tuning.Pitches[0]);
			Assert.AreEqual(OctavePitch.A1, tuning.Pitches[1]);
			Assert.AreEqual(OctavePitch.D2, tuning.Pitches[2]);
			Assert.AreEqual(OctavePitch.G2, tuning.Pitches[3]);
			Assert.IsFalse(tuning.IsDropTuning);
		}

		[TestMethod]
		public void StandardFiveStringBassTuningTest()
		{
			var tuning = GuitarTuningLibrary.StandardFiveStringBassTuning;
			Assert.AreEqual(5, tuning.Pitches.Length);
			Assert.AreEqual(OctavePitch.B0, tuning.Pitches[0]);
			Assert.AreEqual(OctavePitch.E1, tuning.Pitches[1]);
			Assert.AreEqual(OctavePitch.A1, tuning.Pitches[2]);
			Assert.AreEqual(OctavePitch.D2, tuning.Pitches[3]);
			Assert.AreEqual(OctavePitch.G2, tuning.Pitches[4]);
			Assert.IsFalse(tuning.IsDropTuning);
		}

		[TestMethod]
		public void DetunedGuitarTuningTest()
		{
			var tuning = GuitarTuningLibrary.StandardGuitarTuning;
			tuning.Retune(-3);
			Assert.AreEqual(6, tuning.Pitches.Length);
			Assert.AreEqual(OctavePitch.CSharp2, tuning.Pitches[0]);
			Assert.AreEqual(OctavePitch.FSharp2, tuning.Pitches[1]);
			Assert.AreEqual(OctavePitch.B2, tuning.Pitches[2]);
			Assert.AreEqual(OctavePitch.E3, tuning.Pitches[3]);
			Assert.AreEqual(OctavePitch.GSharp3, tuning.Pitches[4]);
			Assert.AreEqual(OctavePitch.CSharp4, tuning.Pitches[5]);
			Assert.IsFalse(tuning.IsDropTuning);
		}
	}
}
