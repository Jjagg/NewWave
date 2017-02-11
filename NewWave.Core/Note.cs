using System;
using NewWave.Core.Pitches;

namespace NewWave.Core
{
	public class Note
	{
		/// <summary>
		/// The starting position of the note, in beats.
		/// </summary>
		public readonly float Start;

		/// <summary>
		/// The length of the note, as a fraction of the beat (usually quarter note).
		/// </summary>
		public readonly float Length;

		/// <summary>
		/// The pitch of the note.
		/// </summary>
		public readonly OctavePitch Pitch;

		/// <summary>
		/// The Velocity of the note, 0-127.
		/// </summary>
		public readonly int Velocity;

		/// <summary>
		/// Creates a new note instance.
		/// </summary>
		/// <param name="start">The starting position of the note, in ticks.</param>
		/// <param name="length">The length of the note, in ticks.</param>
		/// <param name="pitch">The pitch of the note.</param>
		/// <param name="velocity">The Velocity of the note, 0-127.</param>
		public Note(float start, float length, OctavePitch pitch, int velocity)
		{
			Start = start;
			Length = length;
			Pitch = pitch;
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

		public int LengthInTicks(int ticksPerBeat)
		{
			return (int)Math.Round(Length * ticksPerBeat);
		}

		public override string ToString()
		{
			return string.Format("{0} s={1} l={2} ({3})", Pitch, Start, Length, Velocity);
		}
	}
}
