using System.Linq;
using NewWave.Core.Pitches;

namespace NewWave.Core.Tunings
{
	public static class GuitarTuningLibrary
	{
		public static GuitarTuning StandardGuitarTuning => new GuitarTuning(OctavePitch.E2, OctavePitch.A2, OctavePitch.D3, OctavePitch.G3, OctavePitch.B3, OctavePitch.E4);
		public static GuitarTuning StandardSevenStringGuitarTuning => new GuitarTuning(OctavePitch.B1, OctavePitch.E2, OctavePitch.A2, OctavePitch.D3, OctavePitch.G3, OctavePitch.B3, OctavePitch.E4);
		public static GuitarTuning DropDGuitarTuning => StandardGuitarTuning.Drop();
		public static GuitarTuning StandardBassTuning => new GuitarTuning(StandardGuitarTuning.Retune(-12).Pitches.Take(4).ToArray());
		public static GuitarTuning StandardFiveStringBassTuning => new GuitarTuning(StandardSevenStringGuitarTuning.Retune(-12).Pitches.Take(5).ToArray());
	}
}
