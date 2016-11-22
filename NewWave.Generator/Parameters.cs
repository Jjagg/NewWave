using System;
using NewWave.Core;
using NewWave.Midi;

namespace NewWave.Generator
{
	public class Parameters : IParameters
	{
		public double TempoMean;
		public double TempoStandardDeviation;
		public Pitch MajorKey;
		public Func<TimeSignature> TimeSignatureFunc;
		public Func<TimeSignature, int> FeelFunc;
		public Pitch LowestPossibleNote;

		public Pitch MinorKey
		{
			get { return MajorKey - 3; }
			set { MajorKey = value + 3; }
		}

		public Func<Pitch> MajorKeyFunc
		{
			set { MajorKey = value(); }
		}

		public Func<Pitch> MinorKeyFunc
		{
			set { MinorKey = value(); }
		}

		public Parameters()
		{
			// Defaults (can be set manually after constructor)
			TempoMean = 120;
			TempoStandardDeviation = 0;
			MajorKeyFunc = () => Pitch.G0;
			TimeSignatureFunc = () => TimeSignature.CommonTime;
			FeelFunc = t => 4;
			LowestPossibleNote = Pitch.E2;
		}
	}
}
