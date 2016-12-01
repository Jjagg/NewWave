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
}
