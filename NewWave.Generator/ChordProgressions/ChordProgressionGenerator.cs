using System;
using System.Collections.Generic;
using NewWave.Library.Chords;

namespace NewWave.Generator.ChordProgressions
{
	public static class ChordProgressionGenerator
	{
		public static ChordProgression ChordProgression(Func<MarkovChainNode<Chord>, MarkovChainNode<Chord>> filterFunc)
		{
			var chords = new List<Chord>();
			var chain = ChordProgressionLibrary.Chain;

			do
			{
				var chord = MarkovChainNode<Chord>.Choose(chain, filterFunc);
				if (chord != null)
				{
					chords.Add(chord.Data);
					chain = chord.ChildNodes;
				}
			} while (chain != null && chain.Count > 0);

			return new ChordProgression(chords);
		}
	}
}
