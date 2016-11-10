using System.Collections.Generic;
using NewWave.Core;
using NewWave.Library.Grooves;
using NewWave.Midi;

namespace NewWave.Test
{
	internal class TestSong : Song
	{
		private int _tempo;
		private TimeSignature _time;

		public override string Generate()
		{
			_time = new TimeSignature(4, 4);
			_tempo = 150;
			return "Finished";
		}

		public override Score Render()
		{
			const int measures = 4;
			var drums = new PercussionTrack(new List<List<PercussionNote>>());
			var groove = GrooveLibrary.GetGroove();

			for (var measure = 0; measure < measures; measure++)
			{
				drums.Notes.Add(new List<PercussionNote>());

				foreach (var percussionNote in groove.Notes(Percussion.ClosedHiHat, false, _time, false))
				{
					drums.Notes[measure].Add(percussionNote);
				}
			}

			return new Score(measures,
				new Dictionary<int, TimeSignature> { { 0, _time } },
				new Dictionary<int, int> { { 0, _tempo } },
				new List<InstrumentTrack>(),
				drums);
		}

		public override string DisplayName
		{
			get { return "Test Song"; }
		}
	}
}
