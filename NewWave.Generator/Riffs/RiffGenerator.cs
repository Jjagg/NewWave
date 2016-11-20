using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Library.Chords;
using NewWave.Midi;

namespace NewWave.Generator.Riffs
{
	internal static class RiffGenerator
	{
		internal static IEnumerable<Note> GetRiff(int length, IEnumerable<Tuple<int, Chord>> chordProgression)
		{
			return Enumerable.Range(0, length).Select(n =>
			{
				var thisChord = chordProgression.Last(c => c.Item1 <= n);
				var thisScale = GetScale(thisChord.Item2).ToList();
				return new Note(n, 1, thisScale[Randomizer.Next(thisScale.Count)] + 12, Velocity.Ff);
			});
		}

		internal static List<Pitch> GetScale(Chord chord)
		{
			switch (chord.Quality)
			{
				case ChordQuality.NotSpecified:
				case ChordQuality.Minor:
					return MinorPentatonicScale.Select(n => chord.BasePitch + n).ToList();
				case ChordQuality.Major:
					return MajorPentatonicScale.Select(n => chord.BasePitch + n).ToList();
			}

			return new List<Pitch>();
		}

		private static IEnumerable<int> MajorPentatonicScale => new[] { 0, 2, 4, 7, 9 };
		private static IEnumerable<int> MinorPentatonicScale => new[] { 0, 3, 5, 7, 10 };
		private static IEnumerable<int> MajorScale => new[] { 0, 2, 4, 5, 7, 9, 11 };
		private static IEnumerable<int> MinorScale => new[] { 0, 2, 3, 5, 7, 8, 10 };
	}
}
