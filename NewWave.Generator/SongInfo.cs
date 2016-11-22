using NewWave.Core;
using NewWave.Midi;

namespace NewWave.Generator
{
	public class SongInfo
	{
		public readonly TimeSignature TimeSignature;
		public readonly int Feel;

		public Pitch MajorKey { get; set; }

		public Pitch MinorKey
		{
			get { return MajorKey - 3; }
			set { MajorKey = value + 3; }
		}

		public SongInfo(TimeSignature timeSignature, int feel)
		{
			TimeSignature = timeSignature;
			Feel = feel;

			// Defaults (can be set manually after constructor)
			MajorKey = Pitch.A0;
		}
	}
}
