using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator;
using NewWave.Generator.ChordProgressions;
using NewWave.Generator.Sections;
using NewWave.Generator.SoloLead;
using NewWave.Library.Chords;
using NewWave.Library.Pitches;
using NewWave.Midi;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class SoloLeadTests
	{
		[TestMethod]
		public void SoloLeadTest()
		{
			var section = new SongSection(new SongInfo(TimeSignature.CommonTime, 4), SectionType.None, ChordProgressionGenerator.ChordProgression(n => n));
			var lead = section.Lead;
			foreach (var note in lead)
			{
				Console.WriteLine(note);
			}
		}

		[TestMethod]
		public void MajorPentatonicScaleTest()
		{
			var scale = SoloLeadGenerator.GetScale(new Chord(Pitch.C)).Select(p => PitchExtensions.ToMidiPitch(p, 0)).ToList();
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
			var scale = SoloLeadGenerator.GetScale(new Chord(Pitch.C, ChordQuality.Minor)).Select(p => PitchExtensions.ToMidiPitch(p, 0)).ToList();
			Assert.AreEqual(5, scale.Count);
			Assert.AreEqual(MidiPitch.C0, scale[0]);
			Assert.AreEqual(MidiPitch.DSharp0, scale[1]);
			Assert.AreEqual(MidiPitch.F0, scale[2]);
			Assert.AreEqual(MidiPitch.G0, scale[3]);
			Assert.AreEqual(MidiPitch.ASharp0, scale[4]);
		}
	}
}
