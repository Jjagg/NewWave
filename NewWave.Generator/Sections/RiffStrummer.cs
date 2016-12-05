using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Library.Chords;
using NewWave.Library.Tunings;
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

		public void AddGuitarNotes(IEnumerable<InstrumentTrack> tracks, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo)
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

			for (var i = 0; i < _riff.Count; i++)
			{
				var start = _riff[i];
				var noteLength = i < _riff.Count - 1
					? _riff[i + 1] - start
					: songInfo.TimeSignature.BeatCount - start;
				var chord = chords.Last(c => c.Item1 <= measure * songInfo.TimeSignature.BeatCount + start).Item2;
				var pitches = isBass
					? new[] { chord.Pitches()[0] }
					: PlayableNotes(chord, songInfo.Parameters.GuitarTuning);

				var pitchCount = 100;
				if (isBass)
				{
					pitchCount = 1;
				}

				notes.AddRange(pitches.Take(pitchCount).Select(p => new Note(start, noteLength, isBass ? p.AddOctave(-1) : p, Velocity.F)));
			}

			foreach (var track in tracks)
			{
				track.Notes.Add(notes);
			}
		}

		private static IEnumerable<Pitch> PlayableNotes(Chord chord, GuitarTuning tuning)
		{
			var chordPitches = chord.Pitches();
			chordPitches.Add(chordPitches[0] + 7);
			chordPitches.Add(chordPitches[0] + 12);
			var root = chordPitches[0];
			var pitches = new List<Pitch> { root };

			// Bottom string is the highest string in the tuning whose open pitch is lower than root
			var bottomStringIndex = 0;
			for (var i = tuning.Pitches.Length - 1; i >= 0; i--)
			{
				if (tuning.Pitches[i] < root)
				{
					bottomStringIndex = i;
					break;
				}
			}
			
			var bottomStringFingering = root - tuning.Pitches[bottomStringIndex];

			var openPitchesAboveBottomString = Enumerable.Range(bottomStringIndex + 1, tuning.Pitches.Length - 1 - bottomStringIndex).Select(i => tuning.Pitches[i]).ToList();
			var pitchesWeCanPlay = openPitchesAboveBottomString.SelectMany(p =>
			{
				var pitchesAroundFinger = Enumerable.Range(bottomStringFingering - 2, 5).Where(f => f >= 0).Select(f => p + f);
				return new[] { p }.Union(pitchesAroundFinger).ToList();
			}).ToList();
			pitches.AddRange(pitchesWeCanPlay.Where(p => chordPitches.Contains(p)));

			return pitches;
		}
	}
}
