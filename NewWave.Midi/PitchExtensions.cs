namespace NewWave.Midi
{
	public static class PitchExtensions
	{
		public static Pitch AddOctave(this Pitch pitch, int octaves)
		{
			return pitch + 12 * octaves;
		}

		public static Pitch LowestAbovePitch(this Pitch source, Pitch target)
		{
			// Return a pitch of the same note value as source, but above target.
			while (source < target)
			{
				source = source.AddOctave(1);
			}

			return source;
		}

		public static string NoteName(this Pitch pitch)
		{
			var toString = pitch.ToString();
			var letter = toString.Substring(0, 1);
			var isSharp = toString.Contains("Sharp");
			return string.Format("{0}{1}", letter, isSharp ? "#" : "");
		}
	}
}
