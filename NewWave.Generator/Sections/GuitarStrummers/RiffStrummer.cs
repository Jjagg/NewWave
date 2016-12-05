using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Generator.Riffs;
using NewWave.Library.Chords;
using NewWave.Midi;

namespace NewWave.Generator.Sections.GuitarStrummers
{
	internal class RiffStrummer : IGuitarStrummer
	{
		public void AddGuitarNotes(InstrumentTrack[] tracks, List<Tuple<double, double>> gNotes, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo)
		{
			AddNotes(tracks, gNotes, chords, measure, songInfo);
		}

		public void AddBassNotes(InstrumentTrack track, List<Tuple<double, double>> gNotes, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo)
		{
			AddNotes(new[] { track }, gNotes, chords, measure, songInfo, true);
		}

		private void AddNotes(InstrumentTrack[] tracks, List<Tuple<double, double>> gNotes, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo, bool isBass = false)
		{
			var notes = new List<Note>();
			var hits = new RiffGenerator(songInfo.TimeSignature, gNotes.Select(n => n.Item1)).Rhythm(2.0, songInfo.Feel).ToList();

			for (var i = 0; i < hits.Count; i++)
			{
				var start = hits[i];
				var noteLength = i < hits.Count - 1
					? hits[i + 1] - start
					: songInfo.TimeSignature.BeatCount - start;
				var pitches = chords.Last(c => c.Item1 <= measure * songInfo.TimeSignature.BeatCount + start).Item2.Pitches();

				var pitchCount = 100;
				if (isBass)
				{
					pitchCount = 1;
				}
				//else if (notesPerBeat >= 2)
				//{
				//	pitchCount = 2;
				//}

				notes.AddRange(pitches.Take(pitchCount).Select(p => new Note(start, noteLength, isBass ? p.AddOctave(-1) : p, Velocity.F)));
			}

			foreach (var track in tracks)
			{
				track.Notes.Add(notes);
			}
		}
	}
}
