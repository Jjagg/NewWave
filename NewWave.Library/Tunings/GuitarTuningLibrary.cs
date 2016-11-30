using System.Linq;
using NewWave.Midi;

namespace NewWave.Library.Tunings
{
    public static class GuitarTuningLibrary
    {
        public static GuitarTuning StandardGuitarTuning => new GuitarTuning(Pitch.E2, Pitch.A2, Pitch.D3, Pitch.G3, Pitch.B3, Pitch.E4);
        public static GuitarTuning StandardSevenStringGuitarTuning => new GuitarTuning(Pitch.B1, Pitch.E2, Pitch.A2, Pitch.D3, Pitch.G3, Pitch.B3, Pitch.E4);

        public static GuitarTuning DropDGuitarTuning
        {
            get
            {
                var t = StandardGuitarTuning;
                t.Drop();
                return t;
            }
        }

        public static GuitarTuning StandardBassTuning => new GuitarTuning(StandardGuitarTuning.Pitches.Take(4).Select(t => t - 12).ToArray());
        public static GuitarTuning StandardFiveStringBassTuning => new GuitarTuning(StandardSevenStringGuitarTuning.Pitches.Take(5).Select(t => t - 12).ToArray());
    }
}
