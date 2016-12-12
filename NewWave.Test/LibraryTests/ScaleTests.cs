using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Library.Pitches;
using NewWave.Library.Scales;
using NewWave.Midi;

namespace NewWave.Test.LibraryTests
{
	[TestClass]
	public class ScaleTests
	{
		[TestMethod]
		public void MajorScaleTest()
		{
			var scale = ScaleLibrary.GetScale(Pitch.C, ScaleType.Major).Select(p => PitchExtensions.ToMidiPitch(p, 0)).ToList();
			Assert.AreEqual(7, scale.Count);
			Assert.AreEqual(MidiPitch.C0, scale[0]);
			Assert.AreEqual(MidiPitch.D0, scale[1]);
			Assert.AreEqual(MidiPitch.E0, scale[2]);
			Assert.AreEqual(MidiPitch.F0, scale[3]);
			Assert.AreEqual(MidiPitch.G0, scale[4]);
			Assert.AreEqual(MidiPitch.A0, scale[5]);
			Assert.AreEqual(MidiPitch.B0, scale[6]);
		}

		[TestMethod]
		public void MinorScaleTest()
		{
			var scale = ScaleLibrary.GetScale(Pitch.C, ScaleType.Minor).Select(p => PitchExtensions.ToMidiPitch(p, 0)).ToList();
			Assert.AreEqual(7, scale.Count);
			Assert.AreEqual(MidiPitch.C0, scale[0]);
			Assert.AreEqual(MidiPitch.D0, scale[1]);
			Assert.AreEqual(MidiPitch.DSharp0, scale[2]);
			Assert.AreEqual(MidiPitch.F0, scale[3]);
			Assert.AreEqual(MidiPitch.G0, scale[4]);
			Assert.AreEqual(MidiPitch.GSharp0, scale[5]);
			Assert.AreEqual(MidiPitch.ASharp0, scale[6]);
		}

		[TestMethod]
		public void MajorPentatonicScaleTest()
		{
			var scale = ScaleLibrary.GetScale(Pitch.C, ScaleType.MajorPentatonic).Select(p => PitchExtensions.ToMidiPitch(p, 0)).ToList();
			Assert.AreEqual(5, scale.Count);
			Assert.AreEqual(MidiPitch.C0, scale[0]);
			Assert.AreEqual(MidiPitch.D0, scale[1]);
			Assert.AreEqual(MidiPitch.E0, scale[2]);
			Assert.AreEqual(MidiPitch.G0, scale[3]);
			Assert.AreEqual(MidiPitch.A0, scale[4]);
		}

		[TestMethod]
		public void MinorPentatonicScaleTest()
		{
			var scale = ScaleLibrary.GetScale(Pitch.C, ScaleType.MinorPentatonic).Select(p => PitchExtensions.ToMidiPitch(p, 0)).ToList();
			Assert.AreEqual(5, scale.Count);
			Assert.AreEqual(MidiPitch.C0, scale[0]);
			Assert.AreEqual(MidiPitch.DSharp0, scale[1]);
			Assert.AreEqual(MidiPitch.F0, scale[2]);
			Assert.AreEqual(MidiPitch.G0, scale[3]);
			Assert.AreEqual(MidiPitch.ASharp0, scale[4]);
		}
	}
}
