﻿using System;

namespace NewWave.Core
{
	public class TimeSignature
	{
		public int BeatCount { get; }
		public int BeatUnit { get; }

		public TimeSignature(int beatCount, int beatUnit)
		{
			if (beatCount <= 0 || beatUnit <= 0)
			{
				throw new ArgumentException("Time signature values must be greater than zero.");
			}

			if (!IsPowerOfTwo(beatUnit))
			{
				throw new ArgumentException("Beat unit must be a power of two (1, 2, 4, 8 ...)");
			}

			BeatCount = beatCount;
			BeatUnit = beatUnit;
		}

		public static TimeSignature CommonTime => new TimeSignature(4, 4);

		public override string ToString()
		{
			return string.Format("{0}/{1}", BeatCount, BeatUnit);
		}

		private static bool IsPowerOfTwo(int x)
		{
			return (x & (x - 1)) == 0;
		}
	}
}
