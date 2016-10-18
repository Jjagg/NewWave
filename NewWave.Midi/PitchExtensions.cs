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

		public static Pitch HighestBelowPitch(this Pitch source, Pitch target)
		{
			// Return a pitch of the same note value as source, but below target.
			while (source > target)
			{
				source = source.AddOctave(-1);
			}

			return source;
		}

		public static string NoteName(this Pitch pitch)
		{
			return pitch.ToString().Substring(0, 1);
		}
	}
}
