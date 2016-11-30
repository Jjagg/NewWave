using NewWave.Midi;

namespace NewWave.Library.Tunings
{
	public class GuitarTuning
	{
		public readonly Pitch[] Pitches;
		public bool IsDropTuning { get; private set; }

		public GuitarTuning(params Pitch[] pitches)
		{
			Pitches = pitches;
		}

		public GuitarTuning Retune(int stepsUp)
		{
			for (var i = 0; i < Pitches.Length; i++)
			{
				Pitches[i] += stepsUp;
			}
			return this;
		}

		public GuitarTuning Drop()
		{
			Pitches[0] -= 2;
			IsDropTuning = true;
			return this;
		}
	}
}
