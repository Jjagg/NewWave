namespace NewWave.Generator.Parameters
{
	public class TempoParameter : IParameter
	{
		private readonly int _mean;
		private readonly int _standardDeviation;

		public TempoParameter(int mean, int standardDeviation)
		{
			_mean = mean;
			_standardDeviation = standardDeviation;
		}

		public void Apply(ParameterListBase parameterListBase)
		{
			parameterListBase.TempoMean = _mean;
			parameterListBase.TempoStandardDeviation = _standardDeviation;
		}
	}
}
