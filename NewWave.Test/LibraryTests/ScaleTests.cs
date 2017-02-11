using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core.Pitches;
using NewWave.Core.Scales;

namespace NewWave.Test.LibraryTests
{
	[TestClass]
	public class ScaleTests
	{
		[TestMethod]
		public void MajorScaleTest()
		{
			var scale = ScaleLibrary.GetScale(Pitch.C, ScaleType.Major).Select(p => p.ToOctavePitch(0)).ToList();
			Assert.AreEqual(7, scale.Count);
			Assert.AreEqual(OctavePitch.C0, scale[0]);
			Assert.AreEqual(OctavePitch.D0, scale[1]);
			Assert.AreEqual(OctavePitch.E0, scale[2]);
			Assert.AreEqual(OctavePitch.F0, scale[3]);
			Assert.AreEqual(OctavePitch.G0, scale[4]);
			Assert.AreEqual(OctavePitch.A0, scale[5]);
			Assert.AreEqual(OctavePitch.B0, scale[6]);
		}

		[TestMethod]
		public void MinorScaleTest()
		{
			var scale = ScaleLibrary.GetScale(Pitch.C, ScaleType.Minor).Select(p => p.ToOctavePitch(0)).ToList();
			Assert.AreEqual(7, scale.Count);
			Assert.AreEqual(OctavePitch.C0, scale[0]);
			Assert.AreEqual(OctavePitch.D0, scale[1]);
			Assert.AreEqual(OctavePitch.DSharp0, scale[2]);
			Assert.AreEqual(OctavePitch.F0, scale[3]);
			Assert.AreEqual(OctavePitch.G0, scale[4]);
			Assert.AreEqual(OctavePitch.GSharp0, scale[5]);
			Assert.AreEqual(OctavePitch.ASharp0, scale[6]);
		}

		[TestMethod]
		public void MajorPentatonicScaleTest()
		{
			var scale = ScaleLibrary.GetScale(Pitch.C, ScaleType.MajorPentatonic).Select(p => p.ToOctavePitch(0)).ToList();
			Assert.AreEqual(5, scale.Count);
			Assert.AreEqual(OctavePitch.C0, scale[0]);
			Assert.AreEqual(OctavePitch.D0, scale[1]);
			Assert.AreEqual(OctavePitch.E0, scale[2]);
			Assert.AreEqual(OctavePitch.G0, scale[3]);
			Assert.AreEqual(OctavePitch.A0, scale[4]);
		}

		[TestMethod]
		public void MinorPentatonicScaleTest()
		{
			var scale = ScaleLibrary.GetScale(Pitch.C, ScaleType.MinorPentatonic).Select(p => p.ToOctavePitch(0)).ToList();
			Assert.AreEqual(5, scale.Count);
			Assert.AreEqual(OctavePitch.C0, scale[0]);
			Assert.AreEqual(OctavePitch.DSharp0, scale[1]);
			Assert.AreEqual(OctavePitch.F0, scale[2]);
			Assert.AreEqual(OctavePitch.G0, scale[3]);
			Assert.AreEqual(OctavePitch.ASharp0, scale[4]);
		}

		[TestMethod]
		public void MajorScaleStepTest()
		{
			Assert.AreEqual(OctavePitch.E0, ScaleLibrary.Step(Pitch.C, ScaleType.Major, OctavePitch.A0, -3));
			Assert.AreEqual(OctavePitch.GNeg1, ScaleLibrary.Step(Pitch.C, ScaleType.Major, OctavePitch.C0, -3));
			Assert.AreEqual(OctavePitch.D1, ScaleLibrary.Step(Pitch.C, ScaleType.Major, OctavePitch.A0, 3));
		}

		[TestMethod]
		public void MinorScaleStepTest()
		{
			Assert.AreEqual(OctavePitch.GSharpNeg1, ScaleLibrary.Step(Pitch.C, ScaleType.Minor, OctavePitch.D0, -3));
			Assert.AreEqual(OctavePitch.D4, ScaleLibrary.Step(Pitch.C, ScaleType.Minor, OctavePitch.G4, -3));
			Assert.AreEqual(OctavePitch.F2, ScaleLibrary.Step(Pitch.C, ScaleType.Minor, OctavePitch.DSharp2, 1));
		}
	}
}
