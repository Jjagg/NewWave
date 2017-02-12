using System.Collections.Generic;
using System.Linq;
using NewWave.Core.Grooves;
using NewWave.Generator.Common;

namespace NewWave.Generator.Grooves
{
	internal static class GrooveGenerator
	{
		internal static Groove GenerateGroove(SongInfo songInfo)
		{
			var halfSize = false;
			var maxBeat = songInfo.TimeSignature.BeatCount;
			if (maxBeat % 2 == 0 && Randomizer.ProbabilityOfTrue(0.75f))
			{
				halfSize = true;
				maxBeat = maxBeat / 2;
			}

			var beats = GetBeatPoints(maxBeat, songInfo.Feel);
			if (halfSize)
			{
				beats = beats.Union(beats.Select(b => maxBeat + b)).ToList();
			}

			return new Groove(songInfo.TimeSignature, songInfo.Feel, beats);
		}

		private static List<float> GetBeatPoints(float maxBeat, int feel)
		{
			var thisBeat = 0.0f;
			var beatPoints = new List<float>();
			while (thisBeat < maxBeat)
			{
				var seg = feel == 4
					? LengthSegments4[Randomizer.Next(LengthSegments4.Count)]
					: LengthSegments3[Randomizer.Next(LengthSegments3.Count)];
				foreach (var point in seg)
				{
					beatPoints.Add(thisBeat);
					thisBeat += point;
				}
			}

			return beatPoints;
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
			new List<float> { 0.5f, 1.5f },
			new List<float> { 1.5f, 1.5f, 1 },
			new List<float> { 0.5f, 0.5f, 1 },
			new List<float> { 1, 0.5f, 1, 0.5f, 1 }
		};

		private static List<List<float>> LengthSegments3 => new List<List<float>>
		{
			new List<float> { 2 },
			new List<float> { 2, 1 },
			new List<float> { 1, 2 },
			new List<float> { 1 },
			new List<float> { 1, 1 },
			new List<float> { 0.33f, 0.67f },
			new List<float> { 0.67f, 0.33f },
			new List<float> { 0.67f, 0.67f, 0.67f },
		};
	}
}
