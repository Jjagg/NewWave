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
			var notes = new List<Note>();
			var lastIndex = -1;
			var thisChord = chordProgression.First().Item2;
			for (var note = 0; note < length; note++)
			{
				var thisScale = GetScale(thisChord).ToList();
				var interval = Randomizer.Clamp(Randomizer.NextNormalized(0, 1.5), -7, 7);
				var thisIndex = Randomizer.Clamp(lastIndex + interval, 0, thisScale.Count);
				var thisPitch = thisScale[thisIndex];
				notes.Add(new Note(note, 1, thisPitch + 12, Velocity.Ff));
				lastIndex = thisIndex;
			}
			return notes;
		}

		internal static List<Pitch> GetScale(Chord chord)
		{
			List<Pitch> notes;
			var pitch = !chord.IsInverted ? chord.BasePitch : chord.Inversion;

			switch (chord.Quality)
			{
				case ChordQuality.NotSpecified:
				case ChordQuality.Minor:
				case ChordQuality.Diminished:
					notes =  MinorPentatonicScale.Select(n => pitch + n).ToList();
					break;
				case ChordQuality.Major:
					notes = MajorPentatonicScale.Select(n => pitch + n).ToList();
					break;
				default:
					notes = new List<Pitch>();
					break;
			}

			return notes
				.Union(notes.Select(n => n + 12))
				.Union(notes.Select(n => n + 24))
				.OrderBy(n => n).ToList();
		}

		private static IEnumerable<int> MajorPentatonicScale => new[] { 0, 2, 4, 7, 9 };
		private static IEnumerable<int> MinorPentatonicScale => new[] { 0, 3, 5, 7, 10 };
		private static IEnumerable<int> MajorScale => new[] { 0, 2, 4, 5, 7, 9, 11 };
		private static IEnumerable<int> MinorScale => new[] { 0, 2, 3, 5, 7, 8, 10 };
	}
}
