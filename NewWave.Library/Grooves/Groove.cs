using System.Collections.Generic;
using NewWave.Core;

namespace NewWave.Library.Grooves
{
	public class Groove
	{
		public readonly TimeSignature TimeSignature;
		public readonly List<double> Beats;
		public readonly int Feel;

		public Groove(TimeSignature timeSignature, int feel, List<double> beats)
		{
			TimeSignature = timeSignature;
			Feel = feel;
			Beats = beats;
		}
	}
}
