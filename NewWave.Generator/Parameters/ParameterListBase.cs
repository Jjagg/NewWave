using System;
using NewWave.Core;
using NewWave.Generator.Sections;
using NewWave.Generator.Sections.GuitarStrummers;
using NewWave.Library.Chords;
using NewWave.Library.Tunings;
using NewWave.Midi;

namespace NewWave.Generator.Parameters
{
	public class ParameterListBase : IParameterList
	{
		public double TempoMean;
		public double TempoStandardDeviation;
		public double LengthInSecondsMean;
		public double LengthInSecondsStandardDeviation;
		public Pitch MajorKey;
		public Func<TimeSignature> TimeSignatureFunc;
		public Func<TimeSignature, int> FeelFunc;
		public Func<MarkovChainNode<Chord>, MarkovChainNode<Chord>> ChordProgressionFilter;
		public Func<SectionType, int> MeasuresPerSection;
		public Func<SectionType, int, int> RepeatsPerSection;
		public GuitarTuning GuitarTuning;
		public GuitarTuning BassTuning;
		public Func<SectionType, IGuitarStrummer> GuitarStrummer;
		public Func<DrumStyle> DrumStyle;

		public Pitch MinorKey
		{
			get { return MajorKey - 3; }
			private set { MajorKey = value + 3; }
		}

		public Func<Pitch> MajorKeyFunc
		{
			set { MajorKey = value(); }
		}

		public Func<Pitch> MinorKeyFunc
		{
			set { MinorKey = value(); }
		}

		public ParameterListBase()
		{
			// Defaults (can be set manually in child constructors)
			TempoMean = 120;
			TempoStandardDeviation = 0;
			LengthInSecondsMean = 180;
			LengthInSecondsStandardDeviation = 0;
			MajorKeyFunc = () => Pitch.G3;
			TimeSignatureFunc = () => TimeSignature.CommonTime;
			FeelFunc = t => 4;
			ChordProgressionFilter = node => node;
			MeasuresPerSection = type => 4;
			RepeatsPerSection = RepeatsPerSectionFunc;
			GuitarTuning = GuitarTuningLibrary.StandardGuitarTuning;
			BassTuning = GuitarTuningLibrary.StandardBassTuning;
			GuitarStrummer = t => new ChugStrummer();
			DrumStyle = () => new DrumStyle();
		}

		private static int RepeatsPerSectionFunc(SectionType type, int measures)
		{
			var multiplier = measures < 2 ? 2 : 1;
			var returnVal = 1;
			switch (type)
			{
				case SectionType.Verse:
				case SectionType.Chorus:
					returnVal = Randomizer.ProbabilityOfTrue(0.5) ? 4 : 2;
					break;
				case SectionType.Intro:
				case SectionType.Outro:
				case SectionType.Prechorus:
					returnVal = 1;
					break;
				case SectionType.Bridge:
					returnVal = Randomizer.ProbabilityOfTrue(0.5) ? 2 : 1;
					break;
			}

			return multiplier * returnVal;
		}

		internal ParameterListBase Apply(IParameter parameter)
		{
			parameter.Apply(this);
			return this;
		}
	}
}
