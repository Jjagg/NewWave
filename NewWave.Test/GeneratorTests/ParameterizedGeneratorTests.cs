using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator;
using NewWave.Generator.Parameters;
using NewWave.Generator.Sections;
using NewWave.Generator.Sections.GuitarStrummers;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class ParameterizedGenerators
	{
		[TestMethod]
		public void Default()
		{
			RenderAndPlay(new ParameterList());
		}

		[TestMethod]
		public void MinorFastSong()
		{
			var parameters = new ParameterList()
				.Apply(plb => plb.ChordProgressionFilter = ParameterLibrary.MinorFilter)
				.Apply(plb => plb.TempoMean = 130)
				.Apply(plb => plb.TempoStandardDeviation = 10)
				.Apply(plb => plb.LengthInSecondsMean = 130)
				.Apply(plb => plb.LengthInSecondsStandardDeviation = 30)
				.Apply(plb => plb.GuitarStrummer = t => t == SectionType.Verse || t == SectionType.Outro
					? (IGuitarStrummer)new ChugStrummer()
					: new FollowTheDrumStrummer());
			RenderAndPlay(parameters);
		}

		private static Func<SectionType, int> LongSections
		{
			get { return type => type == SectionType.Verse || type == SectionType.Chorus ? 16 : 8; }
		}

		private static Func<SectionType, int> ShortSections
		{
			get { return type => type == SectionType.Verse ? 1 : 2; }
		}

		private static Func<SectionType, int, int> FewRepeats
		{
			get { return (type, length) => GetRepeats(length, type, 1); }
		}

		private static Func<SectionType, int, int> ManyRepeats
		{
			get { return (type, length) => GetRepeats(length, type, 4); }
		}

		private static int GetRepeats(int length, SectionType type, int baseLength)
		{
			var multiplier = length < 2 ? 2 : 1;
			var returnVal = baseLength;
			switch (type)
			{
				case SectionType.Verse:
				case SectionType.Chorus:
					returnVal = Randomizer.ProbabilityOfTrue(0.5) ? baseLength * 2 : baseLength;
					break;
				case SectionType.Intro:
				case SectionType.Outro:
				case SectionType.Prechorus:
					returnVal = baseLength / 2;
					break;
				case SectionType.Bridge:
					returnVal = Randomizer.ProbabilityOfTrue(0.5) ? baseLength : baseLength / 2;
					break;
			}

			return Math.Max(1, multiplier * returnVal);
		}

		[TestMethod]
		public void SlowSong()
		{
			RenderAndPlay(new ParameterList()
				.Apply(plb => plb.TempoMean = 100)
				.Apply(plb => plb.TempoStandardDeviation = 5));
		}

		private static void RenderAndPlay(IParameterList parameterList)
		{
			var song = new GeneratedSong();
			Common.RenderAndPlay(parameterList, song, "output.mid");
			foreach (var section in song.Sections)
			{
				Console.WriteLine("{0}: {1} meas, {2}", section.Type, section.Measures, string.Join(" - ", section.Chords.Select(c => c.Item2)));
			}
		}
	}
}
