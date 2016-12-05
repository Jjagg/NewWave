using System.Collections.Generic;
using System.Linq;
using NewWave.Core;

namespace NewWave.Generator.Riffs
{
	public class RiffGenerator
	{
		private readonly TimeSignature _timeSignature;
		private readonly List<double> _hits;

		public RiffGenerator(TimeSignature timeSignature, IEnumerable<double> hits)
		{
			_timeSignature = timeSignature;
			_hits = hits.ToList();
		}

		public IEnumerable<double> Rhythm(double resolution, int feel)
		{
			var targetBeatCount = resolution * _hits.Count;
			return resolution < 1.0
				? ReduceRhythm(targetBeatCount)
				: IncreaseRhythm(targetBeatCount, feel);
		}

		private IEnumerable<double> IncreaseRhythm(double targetBeatCount, int feel)
		{
			var tryCount = 0;
			while (_hits.Count < targetBeatCount && tryCount < 20)
			{
				tryCount = TryAddHit(tryCount, feel);
			}
			return _hits;
		}

		private int TryAddHit(int tryCount, int feel)
		{
			var beatsWithNoHit = Enumerable.Range(0, _timeSignature.BeatCount).Where(b => !_hits.Contains(b)).ToList();
			if (beatsWithNoHit.Any())
			{
				var next = beatsWithNoHit[Randomizer.Next(beatsWithNoHit.Count)];
				_hits.Add(next);
			}
			else if (feel == 4)
			{
				var halfBeatsWithNoHit = Enumerable.Range(0, _timeSignature.BeatCount * 2).Where(b => !_hits.Contains(b / 2.0)).ToList();
				if (halfBeatsWithNoHit.Any())
				{
					var next = halfBeatsWithNoHit[Randomizer.Next(halfBeatsWithNoHit.Count)];
					_hits.Add(next / 2.0);
				}
				else
				{
					tryCount++;
				}
			}
			return tryCount;
		}

		private IEnumerable<double> ReduceRhythm(double targetBeatCount)
		{
			var tryCount = 0;
			while (_hits.Count > targetBeatCount && tryCount < 20)
			{
				var options = _hits.Where(h => h > 0).ToList();
				_hits.Remove(options[Randomizer.Next(options.Count)]);
				tryCount ++;
			}
			return _hits;
		}
	}
}
