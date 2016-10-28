using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Generator.ChordProgressions;
using NewWave.Library.Chords;
using NewWave.Library.Grooves;
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
		    _tempo = 150;
			_time = new TimeSignature(4, 4);
			_feel = 4;

		    return "Finished";
	    }

	    public override Score Render()
        {
            var guitar = new InstrumentTrack(Instrument.DistortionGuitar, Pan.Center, new List<List<Note>>());
            var bass = new InstrumentTrack(Instrument.ElectricBassFinger, Pan.Center, new List<List<Note>>());
            var drums = new PercussionTrack(new List<List<PercussionNote>>());

	        var sections = new[] { 1, 2, 3 }.Select(i => RenderSection(guitar, bass, drums));

	        return new Score(sections.Sum(s => s),
				new Dictionary<int, TimeSignature> { { 0, _time } },
				new Dictionary<int, int> { { 0, _tempo } },
				new Dictionary<int, int> { { 0, _feel } },
				new List<InstrumentTrack> { guitar, bass },
				drums);
	    }

        private int RenderSection(InstrumentTrack guitar, InstrumentTrack bass, PercussionTrack drums)
        {
            const int measures = 8;
            var timeKeepers = new List<Percussion> { Percussion.ClosedHiHat, Percussion.OpenHiHat, Percussion.RideCymbal1 };
            var timeKeeper = timeKeepers[Randomizer.Next(timeKeepers.Count)];

            var chords = ChordProgressionGenerator.ChordProgression(Pitch.E0, MinorOrDiminshedFilter);
            if (chords.Count == 3)
            {
                chords.Add(chords[2]);
            }

            var groove = GrooveLibrary.AllGrooves[Randomizer.Next(GrooveLibrary.AllGrooves.Count)];

            for (var measure = 0; measure < measures; measure++)
            {
                var chordIndex = measure % chords.Count;
                var pitches = chords[chordIndex].Pitches();

                var g = new List<Note>();
                var b = new List<Note>();
                for (var beat = 0; beat < _time.BeatCount; beat++)
                {
                    g.AddRange(pitches.Select(p => new Note(beat * _feel, _feel, p, Velocity.Fff)));
                    b.Add(new Note(beat * _feel, _feel, pitches[0].AddOctave(-1), Velocity.Fff));
                }

                guitar.Notes.Add(g);
                bass.Notes.Add(b);
                drums.Notes.Add(groove.Notes(timeKeeper));
            }
            return measures;
        }

        public override string DisplayName
	    {
		    get { return "Generated song"; }
	    }

        private static Func<MarkovChainNode<Chord>, MarkovChainNode<Chord>> MinorOrDiminshedFilter
        {
            get
            {
                return n =>
                    n.Data.Quality != ChordQuality.Minor && n.Data.Quality != ChordQuality.Diminished
                        ? new MarkovChainNode<Chord>(n.Data, n.Probability / 4.0)
                        : n;
            }
        }
    }
}
