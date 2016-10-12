using System.Collections.Generic;
using NewWave.Core;

namespace NewWave.Test
{
	internal class TestSong : Song
	{
		public override string Generate()
		{
			return "Finished";
		}

		public override Score Render()
		{
			return new Score(1,
				new Dictionary<int, TimeSignature> { { 0, new TimeSignature() } },
				new Dictionary<int, int> { { 0, 120 } },
				new Dictionary<int, int> { { 0, 4 } },
				new List<InstrumentTrack>(),
				new PercussionTrack(new List<List<PercussionNote>> { new List<PercussionNote>() }));
		}

		public override string DisplayName
		{
			get { return "Test Song"; }
		}
	}
}
