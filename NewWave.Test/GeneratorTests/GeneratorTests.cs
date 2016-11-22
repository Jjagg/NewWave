using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator;
using NewWave.Generator.ChordProgressions;
using NewWave.Library.Chords;
using NewWave.Midi;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class BasicGeneratorTests
	{
		private readonly Parameters _parameters = new Parameters
		{
			MinorKey = Pitch.E2,
			TempoMean = 150,
			TempoStandardDeviation = 20,
			TimeSignatureFunc = () => new TimeSignature(Randomizer.ProbabilityOfTrue(0.75) ? 4 : 3, 4),
			FeelFunc = t => Randomizer.ProbabilityOfTrue(t.BeatCount == 4 ? 0.65 : 0.8) ? 4 : 3
		};

		[TestMethod]
		public void GenerateTest()
		{
			var song = new GeneratedSong();
			Console.WriteLine(song.Generate(_parameters));
			foreach (var section in song.Sections)
			{
				Console.WriteLine("{0}: {1} meas, {2}", section.Type, section.Measures, string.Join(" - ", section.Chords.Select(c => c.Item2)));
			}
		}

		[TestMethod]
		public void RenderTest()
		{
			var song = new GeneratedSong();
			Common.RenderAndPlay(_parameters, song, "output.mid");
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
	                    ? new MarkovChainNode<Chord>(n.Data, n.Probability * 0.25, n.ChildNodes?.Where(c => c.Probability > 0.08).ToList())
	                    : n;
	        }
	    }
	}
}
