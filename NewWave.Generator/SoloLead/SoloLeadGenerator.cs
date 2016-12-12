using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Library.Chords;
using NewWave.Library.Pitches;
using NewWave.Library.Scales;
using NewWave.Midi;

namespace NewWave.Generator.SoloLead
{
	internal static class SoloLeadGenerator
	{
		internal static IEnumerable<Note> GetSoloLead(SongInfo songInfo, int length, List<Tuple<int, Chord>> chordProgression)
		{
			var notes = new List<Note>();
			var lastIndex = -1;
			var thisStart = 0.0;
			var lengths = GetNoteLengths(length, songInfo.Feel);

			for (var note = 0; note < lengths.Count; note++)
			{
				var thisChord = chordProgression.Last(c => c.Item1 <= note).Item2;
				var thisScale = ScaleLibrary.GetScale(thisChord.BasePitch, ScaleType.MinorPentatonic).ToList();
				var interval = Randomizer.Clamp(Randomizer.NextNormalized(0, 1.5), -7, 7);
				var thisIndex = Randomizer.Clamp(lastIndex + interval, 0, thisScale.Count - 1);
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

				notes.Add(new Note(thisStart, thisLength, PitchExtensions.ToMidiPitch(thisPitch, 4), Velocity.Ff));
				lastIndex = thisIndex;
				thisStart += thisLength;
			}
			return notes;
		}

		private static List<double> GetNoteLengths(int totalLength, int feel)
		{
			var thisLength = 0.0;
			var lengths = new List<double>();
			while (thisLength < totalLength)
			{
				var seg = feel == 4
					? LengthSegments4[Randomizer.Next(LengthSegments4.Count)]
					: LengthSegments3[Randomizer.Next(LengthSegments3.Count)];
				lengths.AddRange(seg);
				thisLength += seg.Sum();
			}

			return lengths;
		}

		private static List<List<double>> LengthSegments4 => new List<List<double>>
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
			new List<double> { 0.5, 0.5 },
			new List<double> { 0.5, 0.5, 0.5, 0.5 },
			new List<double> { 0.5, 0.5, 1 }
		};

		private static List<List<double>> LengthSegments3 => new List<List<double>>
		{
			new List<double> { 2 },
			new List<double> { 2, 1, 1 },
			new List<double> { 1, 2, 1 },
			new List<double> { 1 },
			new List<double> { 1, 1 },
			new List<double> { 0.33, 0.33, 0.33 },
			new List<double> { 0.33, 0.67 },
			new List<double> { 0.67, 0.33 },
			new List<double> { 0.67, 0.67, 0.67 }
		};
	}
}
