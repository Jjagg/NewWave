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
			Assert.AreEqual(MidiPitch.A0, PitchExtensions.ToMidiPitch(Pitch.A, 0));
		}

		[TestMethod]
		public void PitchConversionTestB0()
		{
			Assert.AreEqual(MidiPitch.B0, PitchExtensions.ToMidiPitch(Pitch.B, 0));
		}

		[TestMethod]
		public void PitchConversionTestCSharp1()
		{
			Assert.AreEqual(MidiPitch.CSharp1, PitchExtensions.ToMidiPitch(Pitch.CSharp, 1));
		}

		[TestMethod]
		public void PitchConversionTestDNeg1()
		{
			Assert.AreEqual(MidiPitch.DNeg1, PitchExtensions.ToMidiPitch(Pitch.D, -1));
		}

		[TestMethod]
		public void PitchConversionTestF3()
		{
			Assert.AreEqual(MidiPitch.F3, PitchExtensions.ToMidiPitch(Pitch.F, 3));
		}

		[TestMethod]
		public void OctaveOfTestA0()
		{
			Assert.AreEqual(0, PitchExtensions.OctaveOf(MidiPitch.A0));
		}

		[TestMethod]
		public void OctaveOfTestC3()
		{
			Assert.AreEqual(3, PitchExtensions.OctaveOf(MidiPitch.C3));
		}

		[TestMethod]
		public void OctaveOfTestDSharpNeg1()
		{
			Assert.AreEqual(-1, PitchExtensions.OctaveOf(MidiPitch.DSharpNeg1));
		}
	}
}
