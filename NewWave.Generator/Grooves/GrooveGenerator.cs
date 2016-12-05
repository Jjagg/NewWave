using System.Collections.Generic;
using System.Linq;
using NewWave.Library.Grooves;

namespace NewWave.Generator.Grooves
{
	internal static class GrooveGenerator
	{
		internal static Groove GenerateGroove(SongInfo songInfo)
		{
			var halfSize = false;
			var maxBeat = songInfo.TimeSignature.BeatCount;
			if (maxBeat % 2 == 0 && Randomizer.ProbabilityOfTrue(0.75))
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

		private static List<double> GetBeatPoints(double maxBeat, int feel)
		{
			var thisBeat = 0.0;
			var beatPoints = new List<double>();
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
			new List<double> { 0.5, 1.5 },
			new List<double> { 1.5, 1.5, 1 },
			new List<double> { 0.5, 0.5, 1 },
			new List<double> { 1, 0.5, 1, 0.5, 1 }
		};

		private static List<List<double>> LengthSegments3 => new List<List<double>>
		{
			new List<double> { 2 },
			new List<double> { 2, 1 },
			new List<double> { 1, 2 },
			new List<double> { 1 },
			new List<double> { 1, 1 },
			new List<double> { 0.33, 0.67 },
			new List<double> { 0.67, 0.33 },
			new List<double> { 0.67, 0.67, 0.67 },
		};
	}
}
