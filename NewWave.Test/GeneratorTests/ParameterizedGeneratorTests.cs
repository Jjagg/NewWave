using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Core.Tunings;
using NewWave.Generator;
using NewWave.Generator.Common;
using NewWave.Generator.Parameters;
using NewWave.Generator.Sections;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class ParameterizedGenerators
	{
		[TestMethod]
		public void Default()
		{
			RenderAndPlay(new MarkovGeneratorParameters());
		}

		[TestMethod]
		public void MinorFastSong()
		{
			var parameters = new MarkovGeneratorParameters
			{
				GuitarTuning = GuitarTuningLibrary.DropDGuitarTuning,
				MinorKeyFunc = () => ParameterLibrary.GetKey(GuitarTuningLibrary.DropDGuitarTuning),
				ChordProgressionFilter = ParameterLibrary.MinorFilter,
				TimeSignatureFunc = () => new TimeSignature((Randomizer.ProbabilityOfTrue(0.5f) ? 1 : 2) * (Randomizer.ProbabilityOfTrue(0.5f) ? 3 : 4), 4),
				TempoMean = 130,
				TempoStandardDeviation = 10,
				LengthInSecondsMean = 240,
				LengthInSecondsStandardDeviation = 45,
				DrumStyle = t => new DrumStyle(t),
				MeasuresPerSection = LongSections,
				RepeatsPerSection = FewRepeats,
				RiffResolutionFunc = RiffResolutionFunc
			};
			RenderAndPlay(parameters);
		}

		private static Func<SectionType, int> LongSections
		{
			get { return type => type == SectionType.Verse || type == SectionType.Chorus ? 8 : 4; }
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
					returnVal = Randomizer.ProbabilityOfTrue(0.5f) ? baseLength * 2 : baseLength;
					break;
				case SectionType.Intro:
				case SectionType.Outro:
				case SectionType.Prechorus:
					returnVal = baseLength / 2;
					break;
				case SectionType.Bridge:
					returnVal = Randomizer.ProbabilityOfTrue(0.5f) ? baseLength : baseLength / 2;
					break;
			}

			return Math.Max(1, multiplier * returnVal);
		}

		private static Func<SectionType, float> RiffResolutionFunc
		{
			get
			{
				return t =>
				{
					switch (t)
					{
						case SectionType.Verse:
						case SectionType.Chorus:
							return 4.0f / Randomizer.NextNormalized(5.0f, 1.0f);
						case SectionType.Intro:
						case SectionType.Outro:
						case SectionType.Bridge:
							return 0;
					}

					return 1.0f;
				};
			}
		}

		[TestMethod]
		public void SlowSong()
		{
			RenderAndPlay(new MarkovGeneratorParameters
			{
				TempoMean = 100,
				TempoStandardDeviation = 5
			});
		}

		private static void RenderAndPlay(MarkovGeneratorParameters parameterList)
		{
			var song = Common.RenderAndPlay(parameterList, "output.mid");
			foreach (var section in song.Sections)
				Console.WriteLine("{0}: {1} meas, {2}", section.Type, section.Measures, string.Join(" - ", section.Chords.Select(c => c.Item2)));
		}
	}
}
