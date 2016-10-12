using System.Collections.Generic;

namespace NewWave.Core
{
	public class PercussionTrack
	{
		/// <summary>
		/// The collection of notes played by this instrument.
		/// The outer lists are per-measure; the inner lists
		/// are per-tick.
		/// </summary>
		public readonly List<List<PercussionNote>> Notes;

		public PercussionTrack(List<List<PercussionNote>> notes)
		{
			Notes = notes;
		}
	}
}
