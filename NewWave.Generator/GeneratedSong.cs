using System.Collections.Generic;
using NewWave.Core;

namespace NewWave.Generator
{
    public class GeneratedSong : Song
	{
		private int _tempo;
		private int _feel;
		private TimeSignature _time;

	    public override string Generate()
	    {
		    _tempo = 175;
			_time = new TimeSignature(4, 4);
			_feel = 4;

		    return "Finished";
	    }

	    public override Score Render()
		{
			const int measures = 16;
			var drums = new PercussionTrack(new List<List<PercussionNote>>());

			for (var measure = 0; measure < measures; measure++)
			{
				drums.Notes.Add(DrumBeat.GetMeasure(measure % 4 == 0, _time, _feel));
			}

			return new Score(measures,
				new Dictionary<int, TimeSignature> { { 0, _time } },
				new Dictionary<int, int> { { 0, _tempo } },
				new Dictionary<int, int> { { 0, _feel } },
				new List<InstrumentTrack>(),
				drums);
	    }

	    public override string DisplayName
	    {
		    get { return "Generated song"; }
	    }
    }
}
