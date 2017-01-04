using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Generator.SoloLead;
using NewWave.Library.Chords;
using NewWave.Library.Tunings;
using NewWave.Library.Pitches;
using NewWave.Library.Scales;
using NewWave.Midi;

namespace NewWave.Generator.Sections
{
	internal class RiffStrummer
	{
		private readonly List<double> _rhythm;
		private readonly List<Tuple<int, Chord>> _chords;
		private readonly List<Note> _notes;

		public RiffStrummer(List<double> rhythm, List<Tuple<int, Chord>> chords, TimeSignature timeSignature, int measures)
		{
			_rhythm = rhythm;
			_chords = chords;
			_notes = new List<Note>();

			for (var measure = 0; measure < measures; measure++)
			{
				var chord = chords.Last(c => c.Item1 <= measure * timeSignature.BeatCount).Item2;
				var scaleType = chord.Quality == ChordQuality.Minor ? ScaleType.MinorPentatonic : ScaleType.MajorPentatonic;
				var pitches = PitchSequenceGenerator.GetPitches(chord, scaleType, _rhythm.Count, 3);
				for (var hitIndex = 0; hitIndex < rhythm.Count; hitIndex++)
				{
					var start = rhythm[hitIndex];
					var totalStart = measure * timeSignature.BeatCount + start;

					var chordHere = chords.Last(c => c.Item1 <= totalStart).Item2;
					if (!chordHere.Equals(chord))
					{
						chord = chordHere;
						pitches = PitchSequenceGenerator.GetPitches(chord, scaleType, _rhythm.Count, 3);
					}

					var length = hitIndex < rhythm.Count - 1
						? rhythm[hitIndex + 1] - rhythm[hitIndex]
						: timeSignature.BeatCount - start;
					if (length > 0)
					{
						_notes.Add(new Note(totalStart, length, pitches[hitIndex], Velocity.Fff));
					}
				}
			}
		}

		public void AddGuitarNotes(IEnumerable<InstrumentTrack> tracks, int measure, SongInfo songInfo)
		{
			AddNotes(tracks, measure, songInfo);
		}

		public void AddBassNotes(InstrumentTrack track, int measure, SongInfo songInfo)
		{
			AddNotes(new[] { track }, measure, songInfo, true);
		}

		private void AddNotes(IEnumerable<InstrumentTrack> tracks, int measure, SongInfo songInfo, bool isBass = false)
		{
			var notes = new List<Note>();
			var octave = isBass
				? songInfo.Parameters.BassTuning.Pitches[0].OctaveOf()
				: songInfo.Parameters.GuitarTuning.Pitches[0].OctaveOf();

			for (var i = 0; i < _rhythm.Count; i++)
			{
				var pitch = _notes.Last(n => n.Start <= _rhythm[i] + measure * songInfo.TimeSignature.BeatCount);
				var pitches = NotesToPlayAt(songInfo, _chords, measure, _rhythm[i], isBass, octave).ToList();


				if (isBass)
				{
					notes.Add(new Note(pitch.Start, pitch.Length, pitches[0], Velocity.Fff));
				}
				else
				{
					notes.Add(pitch);
				}
			}

			foreach (var track in tracks)
			{
				track.Notes.Add(notes);
			}
		}

		private static IEnumerable<MidiPitch> NotesToPlayAt(SongInfo songInfo, List<Tuple<int, Chord>> chords, int measure, double start, bool isBass, int octave)
		{
			var chord = chords.Last(c => c.Item1 <= measure * songInfo.TimeSignature.BeatCount + start).Item2;
			return isBass
					? new[] { chord.Pitches(octave).ToList()[0] }
					: PlayableNotes(chord, songInfo.Parameters.GuitarTuning);
		}

		private static IEnumerable<MidiPitch> PlayableNotes(Chord chord, GuitarTuning tuning)
		{
			var chordPitches = chord.PitchesHigherThan(tuning.Pitches[0]).ToList();
			chordPitches.Add(chordPitches[0] + 7);
			chordPitches.Add(chordPitches[0] + 12);
			var root = chordPitches[0];
			var pitches = new List<MidiPitch> { root };

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
