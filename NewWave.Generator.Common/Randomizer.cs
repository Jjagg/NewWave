using System;
using System.Collections.Generic;
using System.Linq;

namespace NewWave.Generator.Common
{
	public static class Randomizer
	{
		private static readonly Random R = new Random();

		public static int Next()
		{
			return R.Next();
		}

		public static int Next(int maxValue)
		{
			return R.Next(0, maxValue);
		}

		public static int Next(int minValue, int maxValue)
		{
			return R.Next(minValue, maxValue);
		}

		public static float NextSingle()
		{
			return (float) R.NextDouble();
		}

		public static float NextSingle(float minValue, float maxValue)
		{
			return (float) R.NextDouble() * (maxValue - minValue) + minValue;
		}

		public static int GetWeightedIndex(List<float> input)
		{
			var sum = input.Sum();
			var target = NextSingle(0, sum);

			for (var i = 0; i < input.Count; i++)
			{
				var t = input[i];
				target -= t;
				if (target <= 0)
				{
					return i;
				}
			}

			return input.Count - 1;
		}

		public static float NextNormalized(float mean, float standardDeviation)
		{
			// Box–Muller transform
			// http://stackoverflow.com/a/2751988/436282
			var u1 = NextSingle();
			var u2 = NextSingle();
			var normal = (float) (Math.Sqrt(-2 * Math.Log(u1)) * Math.Cos(2 * Math.PI * u2));
			return normal * standardDeviation + mean;
		}

		public static int Clamp(float value, int min, int max)
		{
			return value < min
				? min
				: value > max
					? max
					: (int)value;
		}

		public static bool ProbabilityOfTrue(float probability)
		{
			return NextSingle() < probability;
		}
	}
}
