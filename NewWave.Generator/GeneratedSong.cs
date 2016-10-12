using System.Collections.Generic;
using NewWave.Core;
using NewWave.Midi;

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

		    var guitar = new InstrumentTrack(Instrument.DistortionGuitar, Pan.Center, new List<List<Note>>());
		    var bass = new InstrumentTrack(Instrument.ElectricBassFinger, Pan.Center, new List<List<Note>>());
			var drums = new PercussionTrack(new List<List<PercussionNote>>());

			for (var measure = 0; measure < measures; measure++)
			{
				guitar.Notes.Add(new List<Note>
				{
					new Note(0, _feel, Pitch.E2, Velocity.Fff),
					new Note(0, _feel, Pitch.B3, Velocity.Fff),
					new Note(0, _feel, Pitch.E3, Velocity.Fff)
				});
				bass.Notes.Add(new List<Note>
				{
					new Note(0, _feel, Pitch.E1, Velocity.Fff)
				});
				drums.Notes.Add(DrumBeat.GetMeasure(measure % 4 == 0, _time, _feel));
			}

			return new Score(measures,
				new Dictionary<int, TimeSignature> { { 0, _time } },
				new Dictionary<int, int> { { 0, _tempo } },
				new Dictionary<int, int> { { 0, _feel } },
				new List<InstrumentTrack> { guitar, bass },
				drums);
	    }

	    public override string DisplayName
	    {
		    get { return "Generated song"; }
	    }
    }
}
