using System;
using System.Linq;
using NewWave.Library.Chords;

namespace NewWave.Generator.Parameters
{
	public static class ParameterLibrary
	{
		public static Func<MarkovChainNode<Chord>, MarkovChainNode<Chord>> MinorFilter
		{
			get
			{
				return n => n.Data.Quality != ChordQuality.Minor && n.Data.Quality != ChordQuality.Diminished
					? new MarkovChainNode<Chord>(n.Data, n.Probability * 0.25, n.ChildNodes?.Where(c => c.Probability > 0.08).ToList())
					: n;
			}
		}

		public static Func<MarkovChainNode<Chord>, MarkovChainNode<Chord>> MajorFilter
		{
			get
			{
				return n =>
					n.Data.Quality == ChordQuality.Minor
						? new MarkovChainNode<Chord>(n.Data, n.Probability * 0.25, n.ChildNodes?.Where(c => c.Probability > 0.08).ToList())
						: n;
			}
		}
	}
}
