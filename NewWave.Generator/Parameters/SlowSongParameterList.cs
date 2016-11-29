namespace NewWave.Generator.Parameters
{
	public class SlowSongParameterList : IParameter
	{
		public void Apply(ParameterListBase parameterListBase)
		{
			parameterListBase.TempoMean = 100;
			parameterListBase.TempoStandardDeviation = 5;
		}
	}
}
