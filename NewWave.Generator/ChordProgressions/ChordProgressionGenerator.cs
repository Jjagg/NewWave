using System.Collections.Generic;
using NewWave.Library.Chords;
using NewWave.Midi;

namespace NewWave.Generator.ChordProgressions
{
	public static class ChordProgressionGenerator
	{
		public static List<Chord> ChordProgression(Pitch key)
		{
			var guitarBase = key.LowestAbovePitch(Pitch.E3);

			var chords = new List<Chord>();
			var chain = ChordProgressionLibrary.Chain;

			do
			{
				var chord = MarkovChainNode<Chord>.Choose(chain);
				if (chord != null)
				{
					chords.Add(TransposeForKey(guitarBase, chord.Data));
					chain = chord.ChildNodes;
				}
			} while (chain != null && chain.Count > 0);

			return chords;
		}

		private static Chord TransposeForKey(Pitch key, Chord result)
		{
			var transposeDiff = key - Pitch.C0;
			result.Transpose(transposeDiff);
			return result;
		}
	}
}
