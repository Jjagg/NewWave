using System.Collections.Generic;

namespace NewWave.Core
{
	public class InstrumentTrack
	{
		/// <summary>
		/// Instrument identifier.
		/// </summary>
		public readonly int Channel;

		/// <summary>
		/// Panning. 0 = left, 64 = center, 127 = right.
		/// </summary>
		public readonly int Pan;

		/// <summary>
		/// The collection of notes played by this instrument.
		/// The outer lists are per-measure; the inner lists
		/// are per-tick.
		/// </summary>
		public readonly List<List<Note>> Notes;

		public InstrumentTrack(int channel, int pan, List<List<Note>> notes)
		{
			Channel = channel;
			Pan = pan;
			Notes = notes;
		}
	}
}
