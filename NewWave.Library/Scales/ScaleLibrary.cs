using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Library.Pitches;

namespace NewWave.Library.Scales
{
	public static class ScaleLibrary
	{
		public static IEnumerable<Pitch> GetScale(Pitch root, ScaleType type)
		{
			return GetIntervals(type).Select(i => root + i);
		}

		private static IEnumerable<int> GetIntervals(ScaleType type)
		{
			switch (type)
			{
				case ScaleType.Major:
					return MajorScale;
				case ScaleType.Minor:
					return MinorScale;
				case ScaleType.MajorPentatonic:
					return MajorPentatonicScale;
				case ScaleType.MinorPentatonic:
					return MinorPentatonicScale;
				default:
					throw new ArgumentOutOfRangeException(nameof(type), type, null);
			}
		}

		private static IEnumerable<int> MajorPentatonicScale => new[] { 0, 2, 4, 7, 9 };
		private static IEnumerable<int> MinorPentatonicScale => new[] { 0, 3, 5, 7, 10 };
		private static IEnumerable<int> MajorScale => new[] { 0, 2, 4, 5, 7, 9, 11 };
		private static IEnumerable<int> MinorScale => new[] { 0, 2, 3, 5, 7, 8, 10 };
	}
}
