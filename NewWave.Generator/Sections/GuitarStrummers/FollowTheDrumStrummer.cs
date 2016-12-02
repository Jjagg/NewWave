using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Library.Chords;
using NewWave.Midi;

namespace NewWave.Generator.Sections.GuitarStrummers
{
	internal class FollowTheDrumStrummer : IGuitarStrummer
	{
		public void AddGuitarNotes(InstrumentTrack track, List<Tuple<double, double>> gNotes, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo)
		{
			AddNotes(track, gNotes, chords, measure, songInfo);
		}

		public void AddBassNotes(InstrumentTrack track, List<Tuple<double, double>> gNotes, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo)
		{
			AddNotes(track, gNotes, chords, measure, songInfo, true);
		}

		private static void AddNotes(InstrumentTrack track, IReadOnlyCollection<Tuple<double, double>> gNotes, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo, bool isBass = false)
		{
			var notes = new List<Note>();
			foreach (var tuple in gNotes)
			{
				var start = tuple.Item1;
				var noteLength = Math.Min(tuple.Item2, songInfo.TimeSignature.BeatCount - start);

				var pitches = chords.Last(c => c.Item1 <= measure * songInfo.TimeSignature.BeatCount + start).Item2.Pitches();

				var pitchCount = 100;
				if (isBass)
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
