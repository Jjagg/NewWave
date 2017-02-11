using System;

namespace NewWave.Core
{
	public class PercussionNote
	{
		/// <summary>
		/// The starting position of the note, in fractions of a beat.
		/// </summary>
		public readonly double Start;

		/// <summary>
		/// The identifier of the percussion voice played.
		/// </summary>
		public readonly int PercussionId;

		/// <summary>
		/// The Velocity of the note, 0-127.
		/// </summary>
		public readonly int Velocity;

		/// <summary>
		/// Creates a new percussion note instance.
		/// </summary>
		/// <param name="start">The starting position of the note, in ticks, with 0 as the beginning of the measure.</param>
		/// <param name="percussionId">The percussion voice played.</param>
		/// <param name="velocity">The Velocity of the note, 0-127.</param>
		public PercussionNote(double start, int percussionId, int velocity)
		{
			Start = start;
			PercussionId = percussionId;
			Velocity = velocity;

			if (velocity > 127 || velocity < 0)
				throw new Exception("Velocity must be between 0 and 127 inclusive.");
		}

		public int StartInTicks(int ticksPerBeat)
		{
			return (int)Math.Round(Start * ticksPerBeat);
		}
	}
}
