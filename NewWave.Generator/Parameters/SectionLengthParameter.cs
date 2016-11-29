using System;
using NewWave.Generator.Sections;

namespace NewWave.Generator.Parameters
{
	public class SectionLengthParameter : IParameter
	{
		private readonly Func<SectionType, int> _func;

		public SectionLengthParameter(Func<SectionType, int> func)
		{
			_func = func;
		}

		public void Apply(ParameterListBase parameterListBase)
		{
			parameterListBase.MeasuresPerSection = _func;
		}
	}
}
