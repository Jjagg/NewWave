using System;
using NewWave.Midi;

namespace NewWave.Core
{
	public class Note
	{
		/// <summary>
		/// The starting position of the note, in ticks.
		/// </summary>
		public readonly int Start;

		/// <summary>
		/// The length of the note, in ticks.
		/// </summary>
		public readonly int Length;

		/// <summary>
		/// The pitch of the note.
		/// </summary>
		public readonly Pitch Pitch;

		/// <summary>
		/// The Velocity of the note, 0-127.
		/// </summary>
		public readonly Velocity Velocity;

		/// <summary>
		/// Creates a new note instance.
		/// </summary>
		/// <param name="start">The starting position of the note, in ticks.</param>
		/// <param name="length">The length of the note, in ticks.</param>
		/// <param name="pitch">The pitch of the note.</param>
		/// <param name="velocity">The Velocity of the note, 0-127.</param>
		public Note(int start, int length, Pitch pitch, Velocity velocity)
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

		public override string ToString()
		{
			return string.Format("{0} s={1} l={2} ({3})", Pitch, Start, Length, Velocity);
		}
	}
}
