using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Generator;
using NewWave.Generator.ChordProgressions;
using NewWave.Library.Chords;

namespace NewWave.Test
{
	[TestClass]
	public class GeneratorTests
	{
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
			    Console.WriteLine(string.Join(" - ", ChordProgressionGenerator.ChordProgression(n => n)));
			}
		}

        [TestMethod]
        public void ChordProgressionMinorOrDiminishedOnlyTest()
        {
            for (var i = 0; i < 50; i++)
            {
                Console.WriteLine(string.Join(" - ", ChordProgressionGenerator.ChordProgression(MinorOrDiminshedFilter)));
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
