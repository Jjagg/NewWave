using System;
using NewWave.Generator.Sections;
using NewWave.Generator.Sections.GuitarStrummers;

namespace NewWave.Generator.Parameters
{
	public class SongLengthParameter : IParameter
	{
		private readonly int _mean;
		private readonly int _standardDeviation;

		public SongLengthParameter(int mean, int standardDeviation)
		{
			_mean = mean;
			_standardDeviation = standardDeviation;
		}

		public void Apply(ParameterListBase parameterListBase)
		{
			parameterListBase.LengthInSecondsMean = _mean;
			parameterListBase.LengthInSecondsStandardDeviation = _standardDeviation;
		}
	}

	public class GuitarStrummerParameter : IParameter
	{
		private readonly Func<SectionType, IGuitarStrummer> _func;

		public GuitarStrummerParameter(Func<SectionType, IGuitarStrummer> func)
		{
			_func = func;
		}

		public void Apply(ParameterListBase parameterListBase)
		{
			parameterListBase.GuitarStrummer = _func;
		}
	}
}
