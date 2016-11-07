using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Generator;
using NewWave.Generator.ChordProgressions;
using NewWave.Library.Chords;
using NewWave.Midi;

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
			    Console.WriteLine(string.Join(" - ", ChordProgressionGenerator.ChordProgression(Pitch.G3, n => n)));
			}
		}

        [TestMethod]
        public void ChordProgressionMinorOrDiminishedOnlyTest()
        {
            for (var i = 0; i < 50; i++)
            {
                Console.WriteLine(string.Join(" - ", ChordProgressionGenerator.ChordProgression(Pitch.G3, MinorOrDiminshedFilter)));
            }
        }

	    private static Func<MarkovChainNode<Chord>, MarkovChainNode<Chord>> MinorOrDiminshedFilter
	    {
	        get
	        {
	            return n =>
	                n.Data.Quality != ChordQuality.Minor && n.Data.Quality != ChordQuality.Diminished
	                    ? new MarkovChainNode<Chord>(n.Data, n.Probability * 0.25, n.ChildNodes)
	                    : n;
	        }
	    }
	}
}
