using System;
using NewWave.Core;
using NewWave.Midi;

namespace NewWave.Generator
{
	public class Parameters
	{
		public double TempoMean;
		public double TempoStandardDeviation;
		public Pitch MajorKey;
		public Func<TimeSignature> TimeSignatureFunc;
		public Func<TimeSignature, int> FeelFunc;

		public Pitch MinorKey
		{
			get { return MajorKey - 3; }
			set { MajorKey = value + 3; }
		}

		public Parameters()
		{
			// Defaults (can be set manually after constructor)
			MajorKey = Pitch.A0;
			TimeSignatureFunc = () => TimeSignature.CommonTime;
			FeelFunc = t => 4;
		}
	}
}
