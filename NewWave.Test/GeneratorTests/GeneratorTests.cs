using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Generator;
using NewWave.Generator.ChordProgressions;
using NewWave.Library.Chords;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class BasicGeneratorTests
	{
		[TestMethod]
		public void GenerateTest()
		{
			var song = new GeneratedSong();
			Console.WriteLine(song.Generate());
			foreach (var section in song.Sections)
			{
				Console.WriteLine("{0}: {1} meas, {2}", section.Type, section.Measures, string.Join(" - ", section.Chords.Select(c => c.Item2)));
			}
		}

		[TestMethod]
		public void RenderTest()
		{
			Common.RenderAndPlay(new GeneratedSong(), "output.mid");
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
