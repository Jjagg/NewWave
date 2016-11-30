using NewWave.Midi;

namespace NewWave.Library.Tunings
{
    public class GuitarTuning
    {
        public readonly Pitch[] Pitches;

        public GuitarTuning(params Pitch[] pitches)
        {
            Pitches = pitches;
        }

        public void Retune(int stepsUp)
        {
            for (var i = 0; i < Pitches.Length; i++)
            {
                Pitches[i] += stepsUp;
            }
        }

        public void Drop()
        {
            Pitches[0] -= 2;
        }
    }
}
