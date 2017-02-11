using NewWave.Core;

namespace NewWave.Generator.Common
{
	public class SongInfo
	{
		public readonly TimeSignature TimeSignature;
		public readonly int Feel;

		public int Tempo;
		public double LengthInSeconds;

	    public SongInfo(TimeSignature timeSignature, int feel, int tempo = 100, double length = 60)
	    {
			TimeSignature = timeSignature;
			Feel = feel;
	        Tempo = tempo;
	        LengthInSeconds = length;
	    }
	}
}
