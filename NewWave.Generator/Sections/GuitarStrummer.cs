using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Library.Chords;
using NewWave.Midi;

namespace NewWave.Generator.Sections
{
	internal static class GuitarStrummer
	{
		public static void AddNotes(List<Tuple<double, double>> gNotes, InstrumentTrack track, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo, bool isBass = false)
		{
			var notes = new List<Note>();
			foreach (var tuple in gNotes)
			{
				var start = tuple.Item1;
				var noteLength = tuple.Item2;

				var pitches = chords.Last(c => c.Item1 <= measure * songInfo.TimeSignature.BeatCount + start).Item2.Pitches();

				var pitchCount = 100;
				if (isBass || gNotes.Count >= 6)
				{
					pitchCount = 1;
				}
				else if (gNotes.Count >= 4)
				{
					pitchCount = 2;
				}

				notes.AddRange(pitches.Take(pitchCount).Select(p => new Note(start, noteLength, isBass ? p.AddOctave(-1) : p, Velocity.F)));
			}
			track.Notes.Add(notes);
		}
	}
}
