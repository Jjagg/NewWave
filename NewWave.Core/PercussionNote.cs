using System;
using NewWave.Midi;

namespace NewWave.Core
{
	public class PercussionNote
	{
		/// <summary>
		/// The starting position of the note, in fractions of a beat.
		/// </summary>
		public readonly double Start;

		/// <summary>
		/// The percussion voice played.
		/// </summary>
		public readonly Percussion Percussion;

		/// <summary>
		/// The Velocity of the note, 0-127.
		/// </summary>
		public readonly Velocity Velocity;

		/// <summary>
		/// Creates a new percussion note instance.
		/// </summary>
		/// <param name="start">The starting position of the note, in ticks, with 0 as the beginning of the measure.</param>
		/// <param name="percussion">The percussion voice played.</param>
		/// <param name="velocity">The Velocity of the note, 0-127.</param>
		public PercussionNote(double start, Percussion percussion, Velocity velocity)
		{
			Start = start;
			Percussion = percussion;
			Velocity = velocity;

			if ((int)velocity > 127 || (int)velocity < 0)
			{
				throw new Exception("Velocity must be between 0 and 127 inclusive.");
			}
		}

		public int StartInTicks(int ticksPerBeat)
		{
			return (int)Math.Round(Start * ticksPerBeat);
		}
	}
}
