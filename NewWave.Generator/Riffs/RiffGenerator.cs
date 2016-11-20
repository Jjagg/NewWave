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
		internal static IEnumerable<Note> GetRiff(int length, List<Tuple<int, Chord>> chordProgression)
		{
			return Enumerable.Range(0, length).Select(n => new Note(n, 1, chordProgression[0].Item2.Pitches().First() + 12, Velocity.Ff));
		}

		internal static List<Pitch> GetScale(Chord chord)
		{
			switch (chord.Quality)
			{
				case ChordQuality.NotSpecified:
					return PentatonicScale.Select(n => chord.BasePitch + n).ToList();
				case ChordQuality.Major:
					return MajorScale.Select(n => chord.BasePitch + n).ToList();
				case ChordQuality.Minor:
					return MinorScale.Select(n => chord.BasePitch + n).ToList();
			}

			return new List<Pitch>();
		}

		private static IEnumerable<int> PentatonicScale => new[] { 0, 3, 5, 7, 10 };
		private static IEnumerable<int> MajorScale => new[] { 0, 2, 4, 5, 7, 9, 11 };
		private static IEnumerable<int> MinorScale => new[] { 0, 2, 3, 5, 7, 8, 10 };
	}
}
