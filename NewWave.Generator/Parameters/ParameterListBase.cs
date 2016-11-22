using System;
using NewWave.Core;
using NewWave.Library.Chords;
using NewWave.Midi;

namespace NewWave.Generator.Parameters
{
	public abstract class ParameterListBase : IParameterList
	{
		public double TempoMean;
		public double TempoStandardDeviation;
		public Pitch MajorKey;
		public Func<TimeSignature> TimeSignatureFunc;
		public Func<TimeSignature, int> FeelFunc;
		public Pitch LowestPossibleNote;
		public Func<MarkovChainNode<Chord>, MarkovChainNode<Chord>> ChordProgressionFilter;

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

		protected ParameterListBase()
		{
			// Defaults (can be set manually after constructor)
			TempoMean = 120;
			TempoStandardDeviation = 0;
			MajorKeyFunc = () => Pitch.G0;
			TimeSignatureFunc = () => TimeSignature.CommonTime;
			FeelFunc = t => 4;
			LowestPossibleNote = Pitch.E2;
			ChordProgressionFilter = node => node;
		}
	}
}
