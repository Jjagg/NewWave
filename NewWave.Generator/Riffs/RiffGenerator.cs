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
			var notes = new List<Note>();
			var lastIndex = -1;
		    var thisStart = 0.0;
		    var lengths = GetNoteLengths(length);

			for (var note = 0; note < lengths.Count; note++)
			{
				var thisChord = chordProgression.Last(c => c.Item1 <= note).Item2;
				var thisScale = GetScale(thisChord).ToList();
				var interval = Randomizer.Clamp(Randomizer.NextNormalized(0, 1.5), -7, 7);
				var thisIndex = Randomizer.Clamp(lastIndex + interval, 0, thisScale.Count);
				var thisPitch = thisScale[thisIndex];
			    var thisLength = lengths[note];

			    if (thisStart + thisLength > length)
			    {
			        thisLength = length - thisStart;
			    }

			    if (thisStart >= length)
			    {
			        break;
			    }

                notes.Add(new Note(thisStart, thisLength, thisPitch + 12, Velocity.Ff));
				lastIndex = thisIndex;
			    thisStart += thisLength;
			}
			return notes;
		}

	    private static List<double> GetNoteLengths(int totalLength)
	    {
	        var thisLength = 0.0;
	        var lengths = new List<double>();
	        while (thisLength < totalLength)
	        {
	            var seg = LengthSegments[Randomizer.Next(LengthSegments.Count)];
                lengths.AddRange(seg);
	            thisLength += seg.Sum();
	        }

	        return lengths;
	    }

        private static List<List<double>> LengthSegments => new List<List<double>>
        {
            new List<double> { 2 },
            new List<double> { 2, 1, 1 },
            new List<double> { 1, 2, 1 },
            new List<double> { 1 },
            new List<double> { 1, 1 },
            new List<double> { 0.5, 0.5 },
            new List<double> { 1.5, 1, 1.5 },
            new List<double> { 1.5, 1.5 },
            new List<double> { 0.5, 1, 0.5 },
            new List<double> { 0.5, 0.5 }
        };

		internal static List<Pitch> GetScale(Chord chord)
		{
			List<Pitch> notes;
			var pitch = !chord.IsInverted ? chord.BasePitch : chord.Inversion;

			switch (chord.Quality)
			{
				case ChordQuality.Minor:
				case ChordQuality.Diminished:
					notes =  MinorPentatonicScale.Select(n => pitch + n).ToList();
					break;
				case ChordQuality.NotSpecified:
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
