using System.Linq;
using NewWave.Midi;

namespace NewWave.Library.Tunings
{
	public static class GuitarTuningLibrary
	{
		public static GuitarTuning StandardGuitarTuning => new GuitarTuning(MidiPitch.E2, MidiPitch.A2, MidiPitch.D3, MidiPitch.G3, MidiPitch.B3, MidiPitch.E4);
		public static GuitarTuning StandardSevenStringGuitarTuning => new GuitarTuning(MidiPitch.B1, MidiPitch.E2, MidiPitch.A2, MidiPitch.D3, MidiPitch.G3, MidiPitch.B3, MidiPitch.E4);
		public static GuitarTuning DropDGuitarTuning => StandardGuitarTuning.Drop();
		public static GuitarTuning StandardBassTuning => new GuitarTuning(StandardGuitarTuning.Retune(-12).Pitches.Take(4).ToArray());
		public static GuitarTuning StandardFiveStringBassTuning => new GuitarTuning(StandardSevenStringGuitarTuning.Retune(-12).Pitches.Take(5).ToArray());
	}
}
