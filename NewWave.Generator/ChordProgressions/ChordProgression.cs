using System.Collections.Generic;
using System.Linq;
using NewWave.Library.Chords;

namespace NewWave.Generator.ChordProgressions
{
	public class ChordProgression
	{
		public readonly List<Chord> Chords;

		public ChordProgression(List<Chord> chords)
		{
			Chords = chords;
		}

		public override string ToString()
		{
			return string.Join(" - ", Chords);
		}

		public override bool Equals(object obj)
		{
			var other = obj as ChordProgression;
			return other != null &&
				   Chords.Count == other.Chords.Count &&
				   Chords.Select((c, i) => other.Chords[i].Equals(c)).All(t => t);
		}
	}
}
