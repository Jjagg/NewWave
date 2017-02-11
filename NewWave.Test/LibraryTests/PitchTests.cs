using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core.Pitches;

namespace NewWave.Test.LibraryTests
{
	[TestClass]
	public class PitchTests
	{
		[TestMethod]
		public void PitchConversionTestA0()
		{
			Assert.AreEqual(OctavePitch.A0, Pitch.A.ToOctavePitch(0));
		}

		[TestMethod]
		public void PitchConversionTestB0()
		{
			Assert.AreEqual(OctavePitch.B0, Pitch.B.ToOctavePitch(0));
		}

		[TestMethod]
		public void PitchConversionTestCSharp1()
		{
			Assert.AreEqual(OctavePitch.CSharp1, Pitch.CSharp.ToOctavePitch(1));
		}

		[TestMethod]
		public void PitchConversionTestDNeg1()
		{
			Assert.AreEqual(OctavePitch.DNeg1, Pitch.D.ToOctavePitch(-1));
		}

		[TestMethod]
		public void PitchConversionTestF3()
		{
			Assert.AreEqual(OctavePitch.F3, Pitch.F.ToOctavePitch(3));
		}

		[TestMethod]
		public void OctaveOfTestA0()
		{
			Assert.AreEqual(0, OctavePitch.A0.OctaveOf());
		}

		[TestMethod]
		public void OctaveOfTestC3()
		{
			Assert.AreEqual(3, OctavePitch.C3.OctaveOf());
		}

		[TestMethod]
		public void OctaveOfTestDSharpNeg1()
		{
			Assert.AreEqual(-1, OctavePitch.DSharpNeg1.OctaveOf());
		}

		[TestMethod]
		public void FromMidiPitchTests()
		{
			Assert.AreEqual(Pitch.A, OctavePitch.A3.FromOctavePitch());
		}
	}
}
