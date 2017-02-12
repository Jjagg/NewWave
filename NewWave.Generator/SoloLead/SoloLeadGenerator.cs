using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Core.Chords;
using NewWave.Core.Pitches;
using NewWave.Core.Scales;
using NewWave.Generator.Common;

namespace NewWave.Generator.SoloLead
{
	internal static class SoloLeadGenerator
	{
		internal static IEnumerable<Note> GetSoloLead(SongInfo songInfo, int length, List<Tuple<int, Chord>> chordProgression)
		{
			var notes = new List<Note>();
			var lastIndex = -1;
			var thisStart = 0f;
			var lengths = GetNoteLengths(length, songInfo.Feel);

			for (var note = 0; note < lengths.Count; note++)
			{
				var thisChord = chordProgression.Last(c => c.Item1 <= note).Item2;
				var thisScale = ScaleLibrary.GetScale(thisChord.BasePitch, ScaleType.MinorPentatonic).ToList();
				var interval = Randomizer.Clamp(Randomizer.NextNormalized(0, 1.5f), -7, 7);
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

				notes.Add(new Note(thisStart, thisLength, thisPitch.ToOctavePitch(4), (int) Velocity.Ff));
				lastIndex = thisIndex;
				thisStart += thisLength;
			}
			return notes;
		}

		private static List<float> GetNoteLengths(int totalLength, int feel)
		{
			var thisLength = 0.0;
			var lengths = new List<float>();
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

		private static List<List<float>> LengthSegments4 => new List<List<float>>
		{
			new List<float> { 2 },
			new List<float> { 2, 1, 1 },
			new List<float> { 1, 2, 1 },
			new List<float> { 1 },
			new List<float> { 1, 1 },
			new List<float> { 0.5f, 0.5f },
			new List<float> { 1.5f, 1, 1.5f },
			new List<float> { 1.5f, 1.5f },
			new List<float> { 0.5f, 1, 0.5f },
			new List<float> { 0.5f, 0.5f },
			new List<float> { 0.5f, 0.5f, 0.5f, 0.5f },
			new List<float> { 0.5f, 0.5f, 1 }
		};

		private static List<List<float>> LengthSegments3 => new List<List<float>>
		{
			new List<float> { 2 },
			new List<float> { 2, 1, 1 },
			new List<float> { 1, 2, 1 },
			new List<float> { 1 },
			new List<float> { 1, 1 },
			new List<float> { 0.33f, 0.33f, 0.33f },
			new List<float> { 0.33f, 0.67f },
			new List<float> { 0.67f, 0.33f },
			new List<float> { 0.67f, 0.67f, 0.67f }
		};
	}
}
