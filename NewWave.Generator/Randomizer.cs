using System;
using System.Collections.Generic;
using System.Linq;

namespace NewWave.Generator
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

		public static double NextDouble()
		{
			return R.NextDouble();
		}

		public static double NextDouble(double minValue, double maxValue)
		{
			return R.NextDouble() * (maxValue - minValue) + minValue;
		}

		public static int GetWeightedIndex(List<double> input)
		{
			var sum = input.Sum();
			var target = NextDouble(0, sum);

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
	}
}
