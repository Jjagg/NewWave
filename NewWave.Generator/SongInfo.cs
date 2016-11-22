using NewWave.Core;

namespace NewWave.Generator
{
	public class SongInfo
	{
		public readonly TimeSignature TimeSignature;
		public readonly int Feel;

		public int Tempo;

		private Parameters _parameters;
		public Parameters Parameters
		{
			get { return _parameters; }
			set
			{
				_parameters = value;
				if (_parameters != null)
				{
					Tempo = (int)Randomizer.NextNormalized(value.TempoMean, value.TempoStandardDeviation);
				}
			}
		}

		public SongInfo(TimeSignature timeSignature, int feel)
		{
			TimeSignature = timeSignature;
			Feel = feel;

			// Defaults (can be set manually after constructor)
			Tempo = 150;
			Parameters = new Parameters();
		}
	}
}
