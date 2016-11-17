using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Library.Grooves;

namespace NewWave.Generator.Grooves
{
	internal static class GrooveGenerator
	{
		internal static Groove GenerateGroove(TimeSignature timeSignature, int feel)
		{
			var halfSize = false;
			var maxBeat = timeSignature.BeatCount;
			if (maxBeat % 2 == 0 && Randomizer.ProbabilityOfTrue(0.75))
			{
				halfSize = true;
				maxBeat = maxBeat / 2;
			}

			var beats = GetBeatPoints(maxBeat);
			if (halfSize)
			{
				beats = beats.Union(beats.Select(b => maxBeat + b)).ToList();
			}

			var snares = Randomizer.ProbabilityOfTrue(0.5)
				? new List<double> { 1, 3 }
				: new List<double> { 2 };
			var kicks = beats.Where(b => !snares.Contains(b)).ToList();

			var timeKeeperFreq = beats.Count > timeSignature.BeatCount || Randomizer.ProbabilityOfTrue(0.33) ? feel / 2 : feel;

			return new Groove("Generated groove", timeSignature, feel, timeKeeperFreq, kicks, snares);
		}

		private static List<double> GetBeatPoints(double maxBeat)
		{
			var beatSplitPoint = GetSplitPoint(maxBeat);
			
			var firstSectionLength = beatSplitPoint;
			var secondSectionLength = maxBeat - beatSplitPoint;

			var assignments1 = GetAssignments(firstSectionLength);
			var assignments2 = GetAssignments(secondSectionLength);

			return assignments1.Union(assignments2.Select(a => a + beatSplitPoint)).ToList();
		}

		private static List<double> GetAssignments(double sectionLength)
		{
			return sectionLength > 3 || (sectionLength > 1 && Randomizer.ProbabilityOfTrue(0.5))
				? GetBeatPoints(sectionLength)
				: new List<double> { 0 };
		}

		private static double GetSplitPoint(double maxValue)
		{
			if (maxValue <= 0.7 || Randomizer.ProbabilityOfTrue(0.8))
			{
				return maxValue / 2;
			}

			return GetSplitPoint(maxValue / 2) + (Randomizer.ProbabilityOfTrue(0.5) ? maxValue / 2 : 0);
		}
	}
}
