using System.Collections.Generic;
using System.Linq;
using NewWave.Library.Chords;
using NewWave.Library.Pitches;

namespace NewWave.Library.Scales
{
	public static class ScaleLibrary
	{
		public static List<Pitch> GetScale(Chord chord)
		{
			List<Pitch> notes;
			var pitch = !chord.IsInverted ? chord.BasePitch : chord.Inversion;

			switch (chord.Quality)
			{
				case ChordQuality.Minor:
				case ChordQuality.Diminished:
					notes = MinorPentatonicScale.Select(n => pitch + n).ToList();
					break;
				case ChordQuality.NotSpecified:
				case ChordQuality.Major:
					notes = MajorPentatonicScale.Select(n => pitch + n).ToList();
					break;
				default:
					notes = new List<Pitch>();
					break;
			}

			return notes.ToList();
		}

		public static IEnumerable<int> MajorPentatonicScale => new[] { 0, 2, 4, 7, 9 };
		public static IEnumerable<int> MinorPentatonicScale => new[] { 0, 3, 5, 7, 10 };
		public static IEnumerable<int> MajorScale => new[] { 0, 2, 4, 5, 7, 9, 11 };
		public static IEnumerable<int> MinorScale => new[] { 0, 2, 3, 5, 7, 8, 10 };
	}
}
