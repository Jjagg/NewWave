namespace NewWave.Generator.Parameters
{
	public class FastSongParameterList : ParameterListBase
	{
		public FastSongParameterList()
		{
			TempoMean = 200;
			TempoStandardDeviation = 10;
		}
	}
	public class SlowSongParameterList : ParameterListBase
	{
		public SlowSongParameterList()
		{
			TempoMean = 100;
			TempoStandardDeviation = 5;
		}
	}
}
