using System;
using NewWave.Generator.Sections;

namespace NewWave.Generator.Parameters
{
	public class SectionLengthParameter : IParameter
	{
		private readonly Func<SectionType, int> _measuresPerSection;
		private readonly Func<SectionType, int, int> _repeatsPerSection;

		public SectionLengthParameter(Func<SectionType, int> measuresPerSection, Func<SectionType, int, int> repeatsPerSection)
		{
			_measuresPerSection = measuresPerSection;
			_repeatsPerSection = repeatsPerSection;
		}

		public void Apply(ParameterListBase parameterListBase)
		{
			parameterListBase.MeasuresPerSection = _measuresPerSection;
			parameterListBase.RepeatsPerSection = _repeatsPerSection;
		}
	}
}
