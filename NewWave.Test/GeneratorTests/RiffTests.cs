using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator;
using NewWave.Generator.ChordProgressions;
using NewWave.Generator.Riffs;
using NewWave.Generator.Sections;
using NewWave.Library.Chords;
using NewWave.Midi;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class RiffTests
	{
		[TestMethod]
		public void RiffTest()
		{
			var section = new SongSection(new SongInfo(TimeSignature.CommonTime, 4), SectionType.None, 1, ChordProgressionGenerator.ChordProgression(n => n));
			var riff = section.Riff;
			foreach (var note in riff)
			{
				Console.WriteLine(note);
			}
		}

		[TestMethod]
		public void MajorScaleTest()
		{
			var scale = RiffGenerator.GetScale(new Chord(Pitch.C0, ChordQuality.Major));
			Assert.AreEqual(7, scale.Count);
			Assert.AreEqual(Pitch.C0, scale[0]);
			Assert.AreEqual(Pitch.D0, scale[1]);
			Assert.AreEqual(Pitch.E0, scale[2]);
			Assert.AreEqual(Pitch.F0, scale[3]);
			Assert.AreEqual(Pitch.G0, scale[4]);
			Assert.AreEqual(Pitch.A0, scale[5]);
			Assert.AreEqual(Pitch.B0, scale[6]);
		}

		[TestMethod]
		public void MinorScaleTest()
		{
			var scale = RiffGenerator.GetScale(new Chord(Pitch.A0, ChordQuality.Minor));
			Assert.AreEqual(7, scale.Count);
			Assert.AreEqual(Pitch.A0, scale[0]);
			Assert.AreEqual(Pitch.B0, scale[1]);
			Assert.AreEqual(Pitch.C1, scale[2]);
			Assert.AreEqual(Pitch.D1, scale[3]);
			Assert.AreEqual(Pitch.E1, scale[4]);
			Assert.AreEqual(Pitch.F1, scale[5]);
			Assert.AreEqual(Pitch.G1, scale[6]);
		}

		[TestMethod]
		public void MajorPentatonicScaleTest()
		{
			var scale = RiffGenerator.GetScale(new Chord(Pitch.C0));
			Assert.AreEqual(5, scale.Count);
			Assert.AreEqual(Pitch.C0, scale[0]);
			Assert.AreEqual(Pitch.D0, scale[1]);
			Assert.AreEqual(Pitch.E0, scale[2]);
			Assert.AreEqual(Pitch.G0, scale[3]);
			Assert.AreEqual(Pitch.A0, scale[4]);
		}

		[TestMethod]
		public void MinorPentatonicScaleTest()
		{
			var scale = RiffGenerator.GetScale(new Chord(Pitch.C0));
			Assert.AreEqual(5, scale.Count);
			Assert.AreEqual(Pitch.C0, scale[0]);
			Assert.AreEqual(Pitch.DSharp0, scale[1]);
			Assert.AreEqual(Pitch.F0, scale[2]);
			Assert.AreEqual(Pitch.G0, scale[3]);
			Assert.AreEqual(Pitch.ASharp0, scale[4]);
		}
	}
}
