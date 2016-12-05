using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;

namespace NewWave.Generator.Riffs
{
	public static class RiffGenerator
	{
		public static IEnumerable<double> Rhythm(TimeSignature timeSignature, List<double> hits, double resolution, int feel)
		{
			var targetBeatCount = Math.Max(1, resolution * hits.Count);
			return resolution < 1.0
				? ReduceRhythm(hits, targetBeatCount)
				: IncreaseRhythm(timeSignature, targetBeatCount, hits, feel);
		}

		private static IEnumerable<double> IncreaseRhythm(TimeSignature timeSignature, double targetBeatCount, List<double> hits, int feel)
		{
			var tryCount = 0;
			while (hits.Count < targetBeatCount && tryCount < 20)
			{
				tryCount = TryAddHit(timeSignature, tryCount, hits, feel);
			}
			return hits;
		}

		private static int TryAddHit(TimeSignature timeSignature, int tryCount, ICollection<double> hits, int feel)
		{
			var beatsWithNoHit = Enumerable.Range(0, timeSignature.BeatCount).Where(b => !hits.Contains(b)).ToList();
			if (beatsWithNoHit.Any())
			{
				var next = beatsWithNoHit[Randomizer.Next(beatsWithNoHit.Count)];
				hits.Add(next);
			}
			else if (feel == 4)
			{
				var halfBeatsWithNoHit = Enumerable.Range(0, timeSignature.BeatCount * 2).Where(b => !hits.Contains(b / 2.0)).ToList();
				if (halfBeatsWithNoHit.Any())
				{
					var next = halfBeatsWithNoHit[Randomizer.Next(halfBeatsWithNoHit.Count)];
					hits.Add(next / 2.0);
				}
				else
				{
					tryCount++;
				}
			}
			return tryCount;
		}

		private static IEnumerable<double> ReduceRhythm(ICollection<double> hits, double targetBeatCount)
		{
			var tryCount = 0;
			while (hits.Count > targetBeatCount && tryCount < 20)
			{
				var options = hits.Where(h => h > 0).ToList();
				hits.Remove(options[Randomizer.Next(options.Count)]);
				tryCount ++;
			}
			return hits;
		}
	}
}
