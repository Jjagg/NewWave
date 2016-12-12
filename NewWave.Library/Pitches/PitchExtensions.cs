using NewWave.Midi;

namespace NewWave.Library.Pitches
{
	public static class PitchExtensions
	{
		public static MidiPitch AddOctave(this MidiPitch pitch, int octaves)
		{
			return pitch + 12 * octaves;
		}

		public static string NoteName(this Pitch pitch)
		{
			var toString = pitch.ToString();
			var letter = toString.Substring(0, 1);
			var isSharp = toString.Contains("Sharp");
			return string.Format("{0}{1}", letter, isSharp ? "#" : "");
		}

		public static string NoteName(this MidiPitch pitch)
		{
			var toString = pitch.ToString();
			var letter = toString.Substring(0, 1);
			var isSharp = toString.Contains("Sharp");
			return string.Format("{0}{1}", letter, isSharp ? "#" : "");
		}

		public static MidiPitch ToMidiPitch(this Pitch p, int octave)
		{
			var pitchDiff = ((int)p - (int)MidiPitch.CNeg1) % 12;
			return MidiPitch.CNeg1 + pitchDiff + 12 * (octave + 1);
		}

		public static Pitch FromMidiPitch(this MidiPitch p)
		{
			return (Pitch)((int)p % 12);
		}
		
		public static int OctaveOf(this MidiPitch p)
		{
			return (int)p / 12 - 1;
		}
	}
}
