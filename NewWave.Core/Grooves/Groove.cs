using System.Collections.Generic;
using System.Linq;

namespace NewWave.Core.Grooves
{
	public class Groove
	{
		public readonly TimeSignature TimeSignature;
		public readonly IEnumerable<float> Beats;
		public readonly int Feel;

		public Groove(TimeSignature timeSignature, int feel, IEnumerable<float> beats)
		{
			TimeSignature = timeSignature;
			Feel = feel;
			Beats = beats.Where(b => b < TimeSignature.BeatCount);
		}
	}
}
