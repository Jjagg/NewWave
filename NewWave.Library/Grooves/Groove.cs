using System.Collections.Generic;
using System.Linq;
using NewWave.Core;

namespace NewWave.Library.Grooves
{
	public class Groove
	{
		public readonly TimeSignature TimeSignature;
		public readonly IEnumerable<double> Beats;
		public readonly int Feel;

		public Groove(TimeSignature timeSignature, int feel, IEnumerable<double> beats)
		{
			TimeSignature = timeSignature;
			Feel = feel;
			Beats = beats.Where(b => b < TimeSignature.BeatCount);
		}
	}
}
