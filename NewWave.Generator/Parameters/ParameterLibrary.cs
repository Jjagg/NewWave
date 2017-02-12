using System;
using System.Linq;
using NewWave.Core.Chords;
using NewWave.Core.Pitches;
using NewWave.Core.Tunings;
using NewWave.Generator.Common;

namespace NewWave.Generator.Parameters
{
	public static class ParameterLibrary
	{
		public static Func<MarkovChainNode<Chord>, MarkovChainNode<Chord>> MinorFilter
		{
			get
			{
				return n => n.Data.Quality != ChordQuality.Minor && n.Data.Quality != ChordQuality.Diminished
					? new MarkovChainNode<Chord>(n.Data, n.Probability * 0.25f, n.ChildNodes?.Where(c => c.Probability > 0.08).ToList())
					: n;
			}
		}

		public static Func<MarkovChainNode<Chord>, MarkovChainNode<Chord>> MajorFilter
		{
			get
			{
				return n =>
					n.Data.Quality == ChordQuality.Minor
						? new MarkovChainNode<Chord>(n.Data, n.Probability * 0.25f, n.ChildNodes?.Where(c => c.Probability > 0.08).ToList())
						: n;
			}
		}

		public static OctavePitch GetKey(GuitarTuning tuning)
		{
			var possibleKeys = new[] { tuning.Pitches[0], tuning.Pitches[0] + 2, tuning.Pitches[1] }; // e.g. E, F#, A (0, 2, 5)
			return possibleKeys[Randomizer.Next(possibleKeys.Length)];
		}
	}
}
