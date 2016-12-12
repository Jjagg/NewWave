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
	}
}
