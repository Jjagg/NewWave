using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Library.Chords;
using NewWave.Midi;

namespace NewWave.Generator.Sections.GuitarStrummers
{
	internal class ChugStrummer : IGuitarStrummer
	{
		public void AddGuitarNotes(InstrumentTrack[] tracks, List<Tuple<double, double>> gNotes, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo)
		{
			AddNotes(tracks, chords, measure, songInfo);
		}

		public void AddBassNotes(InstrumentTrack track, List<Tuple<double, double>> gNotes, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo)
		{
			AddNotes(new[] { track }, chords, measure, songInfo, true);
		}

		private static void AddNotes(IEnumerable<InstrumentTrack> tracks, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo, bool isBass = false)
		{
			var notes = new List<Note>();
			var beats = Enumerable.Range(0, songInfo.TimeSignature.BeatCount).Select(b => new Tuple<double, double>(b, 0.5));
			foreach (var tuple in beats)
			{
				var start = tuple.Item1;
				var length = tuple.Item2;
				var root = chords.Last(c => c.Item1 <= measure * songInfo.TimeSignature.BeatCount + start).Item2.Pitches()[0];
				if (isBass)
				{
					notes.Add(new Note(start, length, root.AddOctave(-1), Velocity.Fff));
				}
				else
				{
					notes.AddRange(PowerChord(root).Select(p => new Note(start, length, p, Velocity.F)));
				}
			}

			foreach (var track in tracks)
			{
				track.Notes.Add(notes);
			}
		}

		private static IEnumerable<Pitch> PowerChord(Pitch root)
		{
			return new[] { root, root + 7, root + 12 };
		}
	}
}
