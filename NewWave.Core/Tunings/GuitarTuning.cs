using NewWave.Core.Pitches;

namespace NewWave.Core.Tunings
{
	public class GuitarTuning
	{
		public readonly OctavePitch[] Pitches;
		public bool IsDropTuning { get; private set; }

		public GuitarTuning(params OctavePitch[] pitches)
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
