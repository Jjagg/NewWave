namespace NewWave.Midi
{
	public static class PitchExtensions
	{
		public static Pitch AddOctave(this Pitch pitch, int octaves)
		{
			return pitch + 12 * octaves;
		}

		public static string NoteName(this Pitch pitch)
		{
			return pitch.ToString().Substring(0, 1);
		}
	}
}
