using System.Collections.Generic;
using System.Linq;
using NewWave.Library.Chords;
using NewWave.Library.Pitches;
using NewWave.Library.Scales;
using NewWave.Midi;

namespace NewWave.Generator.SoloLead
{
	internal static class PitchSequenceGenerator
	{
		internal static List<MidiPitch> GetPitches(Chord chord, ScaleType scaleType, int count, int octave)
		{
			var interval = 0;
			var pitchesInChord = chord.Pitches(octave).Select(p => p.FromMidiPitch()).ToList();
			var basePitch = chord.BasePitch.ToMidiPitch(octave);
			var pitches = new List<MidiPitch>();
			var stdDev = 0.5;

			for (var i = 0; i < count; i++)
			{
				interval = Randomizer.Clamp(interval + Randomizer.Clamp(Randomizer.NextNormalized(0, stdDev), -4, 4), -7, 7);
				var pitch = ScaleLibrary.Step(chord.BasePitch, scaleType, basePitch, interval);
				pitches.Add(pitch);
				stdDev = pitchesInChord.Contains(pitch.FromMidiPitch()) ? 0.75 : 2;
			}

			return pitches;
		}
	}
}
