namespace NewWave.Generator.Parameters
{
	public class FastSongParameterList : IParameter
	{
		public void Apply(ParameterListBase parameterListBase)
		{
			parameterListBase.TempoMean = 200;
			parameterListBase.TempoStandardDeviation = 10;
		}
	}
}
