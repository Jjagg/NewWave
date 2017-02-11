namespace NewWave.Core.Pitches
{
	public static class PitchEx
	{
		public static OctavePitch AddOctave(this OctavePitch pitch, int octaves)
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

		public static string NoteName(this OctavePitch pitch)
		{
			var toString = pitch.ToString();
			var letter = toString.Substring(0, 1);
			var isSharp = toString.Contains("Sharp");
			return string.Format("{0}{1}", letter, isSharp ? "#" : "");
		}

		public static OctavePitch ToOctavePitch(this Pitch p, int octave)
		{
			var pitchDiff = ((int)p - (int)OctavePitch.CNeg1) % 12;
			return OctavePitch.CNeg1 + pitchDiff + 12 * (octave + 1);
		}

		public static Pitch FromOctavePitch(this OctavePitch p)
		{
			return (Pitch)((int)p % 12);
		}
		
		public static int OctaveOf(this OctavePitch p)
		{
			return (int)p / 12 - 1;
		}
	}
}
