using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Library.Pitches;
using NewWave.Midi;

namespace NewWave.Test.LibraryTests
{
	[TestClass]
	public class PitchTests
	{
		[TestMethod]
		public void PitchConversionTestA0()
		{
			Assert.AreEqual(MidiPitch.A0, Pitch.A.ToMidiPitch(0));
		}

		[TestMethod]
		public void PitchConversionTestB0()
		{
			Assert.AreEqual(MidiPitch.B0, Pitch.B.ToMidiPitch(0));
		}

		[TestMethod]
		public void PitchConversionTestCSharp1()
		{
			Assert.AreEqual(MidiPitch.CSharp1, Pitch.CSharp.ToMidiPitch(1));
		}

		[TestMethod]
		public void PitchConversionTestDNeg1()
		{
			Assert.AreEqual(MidiPitch.DNeg1, Pitch.D.ToMidiPitch(-1));
		}

		[TestMethod]
		public void PitchConversionTestF3()
		{
			Assert.AreEqual(MidiPitch.F3, Pitch.F.ToMidiPitch(3));
		}

		[TestMethod]
		public void OctaveOfTestA0()
		{
			Assert.AreEqual(0, MidiPitch.A0.OctaveOf());
		}

		[TestMethod]
		public void OctaveOfTestC3()
		{
			Assert.AreEqual(3, MidiPitch.C3.OctaveOf());
		}

		[TestMethod]
		public void OctaveOfTestDSharpNeg1()
		{
			Assert.AreEqual(-1, MidiPitch.DSharpNeg1.OctaveOf());
		}

		[TestMethod]
		public void FromMidiPitchTests()
		{
			Assert.AreEqual(Pitch.A, MidiPitch.A3.FromMidiPitch());
		}
	}
}
