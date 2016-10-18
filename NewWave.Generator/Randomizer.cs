using System;
using System.Collections.Generic;
using System.Linq;

namespace NewWave.Generator
{
	public static class Randomizer
	{
		private static Random _r = new Random();

		public static int Next()
		{
			return _r.Next();
		}

		public static int Next(int minValue, int maxValue)
		{
			return _r.Next(minValue, maxValue);
		}

		public static double NextDouble()
		{
			return _r.NextDouble();
		}

		public static double NextDouble(double minValue, double maxValue)
		{
			return _r.NextDouble() * (maxValue - minValue) + minValue;
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
