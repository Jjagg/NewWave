using System.Linq;
using NewWave.Midi;

namespace NewWave.Library.Tunings
{
	public static class GuitarTuningLibrary
	{
		public static GuitarTuning StandardGuitarTuning => new GuitarTuning(Pitch.E2, Pitch.A2, Pitch.D3, Pitch.G3, Pitch.B3, Pitch.E4);
		public static GuitarTuning StandardSevenStringGuitarTuning => new GuitarTuning(Pitch.B1, Pitch.E2, Pitch.A2, Pitch.D3, Pitch.G3, Pitch.B3, Pitch.E4);
		public static GuitarTuning DropDGuitarTuning => StandardGuitarTuning.Drop();
		public static GuitarTuning StandardBassTuning => new GuitarTuning(StandardGuitarTuning.Retune(-12).Pitches.Take(4).ToArray());
		public static GuitarTuning StandardFiveStringBassTuning => new GuitarTuning(StandardSevenStringGuitarTuning.Retune(-12).Pitches.Take(5).ToArray());
	}
}
