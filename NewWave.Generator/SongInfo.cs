using NewWave.Core;

namespace NewWave.Generator
{
	public struct SongInfo
	{
		public readonly TimeSignature TimeSignature;
		public readonly int Feel;

		public SongInfo(TimeSignature timeSignature, int feel)
		{
			TimeSignature = timeSignature;
			Feel = feel;
		}
	}
}
