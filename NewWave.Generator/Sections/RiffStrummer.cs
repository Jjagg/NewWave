using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Library.Chords;
using NewWave.Library.Pitches;
using NewWave.Midi;

namespace NewWave.Generator.Sections
{
	internal class RiffStrummer
	{
		private readonly List<double> _riff;

		public RiffStrummer(List<double> riff)
		{
			_riff = riff;
		}

		public void AddGuitarNotes(InstrumentTrack[] tracks, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo)
		{
			AddNotes(tracks, chords, measure, songInfo);
		}

		public void AddBassNotes(InstrumentTrack track, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo)
		{
			AddNotes(new[] { track }, chords, measure, songInfo, true);
		}

		private void AddNotes(IEnumerable<InstrumentTrack> tracks, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo, bool isBass = false)
		{
			var notes = new List<Note>();
			var octave = isBass
				? songInfo.Parameters.BassTuning.Pitches[0].OctaveOf()
				: songInfo.Parameters.GuitarTuning.Pitches[0].OctaveOf();

			for (var i = 0; i < _riff.Count; i++)
			{
				var start = _riff[i];
				var noteLength = i < _riff.Count - 1
					? _riff[i + 1] - start
					: songInfo.TimeSignature.BeatCount - start;
				var pitches = chords.Last(c => c.Item1 <= measure * songInfo.TimeSignature.BeatCount + start).Item2.Pitches(octave);

				var pitchCount = 100;
				if (isBass)
				{
					pitchCount = 1;
				}

				notes.AddRange(pitches.Take(pitchCount).Select(p => new Note(start, noteLength, p, Velocity.F)));
			}

			foreach (var track in tracks)
			{
				track.Notes.Add(notes);
			}
		}
	}
}
