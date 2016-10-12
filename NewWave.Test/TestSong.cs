using System.Collections.Generic;
using NewWave.Core;
using NewWave.Midi;

namespace NewWave.Test
{
	internal class TestSong : Song
	{
		private int _feel;
		private TimeSignature _time;

		public override string Generate()
		{
			_time = new TimeSignature(4, 4);
			_feel = 4;

			return "Finished";
		}

		public override Score Render()
		{
			const int measures = 4;
			var drums = new PercussionTrack(new List<List<PercussionNote>>());

			for (var measure = 0; measure < measures; measure++)
			{
				drums.Notes.Add(new List<PercussionNote>());
				for (var beat = 0; beat < _time.BeatCount; beat++)
				{
					drums.Notes[measure].Add(new PercussionNote(beat * _feel, Percussion.SnareDrum1, Velocity.F));
				}
			}

			return new Score(measures,
				new Dictionary<int, TimeSignature> { { 0, _time } },
				new Dictionary<int, int> { { 0, 120 } },
				new Dictionary<int, int> { { 0, _feel } },
				new List<InstrumentTrack>(),
				drums);
		}

		public override string DisplayName
		{
			get { return "Test Song"; }
		}
	}
}
