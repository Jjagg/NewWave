using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Core.Chords;
using NewWave.Core.Pitches;
using NewWave.Generator;
using NewWave.Generator.ChordProgressions;
using NewWave.Generator.Common;
using NewWave.Generator.Parameters;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class BasicGeneratorTests
	{
		private const OctavePitch LowestPitch = OctavePitch.E2;
		private static readonly MarkovGeneratorParameters Parameters = new MarkovGeneratorParameters
		{
			MinorKeyFunc = () => new List<OctavePitch> { LowestPitch, LowestPitch + 5, LowestPitch + 2 }[Randomizer.GetWeightedIndex(new List<float>
			{
				0.5f, 0.3f, 0.2f
			})],
			TimeSignatureFunc = () => new TimeSignature(Randomizer.ProbabilityOfTrue(0.75f) ? 4 : 3, 4),
			FeelFunc = t => Randomizer.ProbabilityOfTrue(t.BeatCount == 4 ? 0.65f : 0.8f) ? 4 : 3,
			ChordProgressionFilter = MinorOrDiminshedFilter
		};

		[TestMethod]
		public void GenerateTest()
		{
		    var song = MarkovGeneratorSong.Generate(Parameters);
		    Console.WriteLine(song.ToString());
			foreach (var section in song.Sections)
			{
				Console.WriteLine("{0}: {1} meas, {2}", section.Type, section.Measures, string.Join(" - ", section.Chords.Select(c => c.Item2)));
			}
		}

		[TestMethod]
		public void RenderTest()
		{
		    var song = MarkovGeneratorSong.Generate(new MarkovGeneratorParameters());
			Common.RenderAndPlay(Parameters, "output.mid");
			foreach (var section in song.Sections)
			{
				Console.WriteLine("{0}: {1} meas, {2}", section.Type, section.Measures, string.Join(" - ", section.Chords.Select(c => c.Item2)));
			}
		}

		[TestMethod]
		public void ChordProgressionTest()
		{
			for (var i = 0; i < 50; i++)
			{
				Console.WriteLine(ChordProgressionGenerator.ChordProgression(n => n));
			}
		}

		[TestMethod]
		public void ChordProgressionMinorOrDiminishedOnlyTest()
		{
			for (var i = 0; i < 50; i++)
			{
				Console.WriteLine(ChordProgressionGenerator.ChordProgression(MinorOrDiminshedFilter));
			}
		}

		private static Func<MarkovChainNode<Chord>, MarkovChainNode<Chord>> MinorOrDiminshedFilter
		{
			get
			{
				return n =>
					n.Data.Quality != ChordQuality.Minor && n.Data.Quality != ChordQuality.Diminished
						? new MarkovChainNode<Chord>(n.Data, n.Probability * 0.25f, n.ChildNodes?.Where(c => c.Probability > 0.08).ToList())
						: n;
			}
		}
	}
}
