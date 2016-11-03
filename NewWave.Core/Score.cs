using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Midi;
using Sanford.Multimedia.Midi;

namespace NewWave.Core
{
	/// <summary>
	/// The "rendered" version of a song, with explicit instructions for time signatures /
	/// instruments / measures / etc. An "unrolled" version. Kind of like a raster image file.
	/// </summary>
	public class Score
	{
		// General data about measures
		private readonly int _measureCount;
		private readonly Dictionary<int, TimeSignature> _timeSignatures;
		private readonly Dictionary<int, int> _tempoChanges;

		// Data about instrument tracks
		private readonly IEnumerable<InstrumentTrack> _instrumentTracks;
		private readonly PercussionTrack _percussionTrack;

		// Misc MIDI stuff
		private const int StandardMidiTicksPerBeat = 24;
		// Shifts all MIDI events forward one tick so it plays better
		private const int TickBuffer = 1;

		public Score(int measureCount, Dictionary<int, TimeSignature> timeSignatures, Dictionary<int, int> tempoChanges,
			IReadOnlyCollection<InstrumentTrack> instrumentTracks, PercussionTrack percussionTrack)
		{
			_measureCount = measureCount;

			_timeSignatures = timeSignatures;
			_tempoChanges = tempoChanges;

			ValidateInitial(_timeSignatures, "time signature");
			ValidateInitial(_tempoChanges, "tempo");

			if (instrumentTracks.Count > 15)
			{
				throw new Exception("Too many instruments. MIDI is limited to 16 channels: 15 instrument and 1 percussion.");
			}

			_instrumentTracks = instrumentTracks;
			_percussionTrack = percussionTrack;

			foreach (var instrumentTrack in _instrumentTracks)
			{
				ValidateInstrumentTrackLength(instrumentTrack, _measureCount);
			}

			ValidatePercussionTrackLength(_percussionTrack, _measureCount);
		}

		/// <summary>
		/// Export the score to a MIDI file.
		/// </summary>
		/// <param name="filename">The .mid file to output data to.</param>
		public void ExportMidi(string filename)
		{
			// Info about MIDI specifications can be found here:
			// http://www.fileformat.info/format/midi/corion.htm

			var s = new Sequence();
			var t = new Track();

			var tickAtStartOfMeasure = TickBuffer;

			// Set up instruments and panning; unroll instrument tracks
			// (we don't need to unroll percussion because it
			// doesn't have any issue with overlapping notes)
			var channel = Channel.Channel1;
			var unrolledInstruments = new List<UnrolledInstrument>();
			foreach (var instrumentTrack in _instrumentTracks)
			{
				unrolledInstruments.Add(new UnrolledInstrument
				{
					Channel = channel,
					Notes = Unroll(instrumentTrack.Notes).ToList()
				});

				t.Insert(0, new ChannelMessage(ChannelCommand.ProgramChange, (int)channel, (int)instrumentTrack.Instrument));
				t.Insert(0, new ChannelMessage(ChannelCommand.Controller, (int)channel, (int)Control.Pan, (int)instrumentTrack.Pan));

				channel++;
				if (channel == Channel.Channel10) channel++; // skip over percussion
			}

			for (var measure = 0; measure < _measureCount; measure++)
			{
				// Create tempo change (if one exists)
				if (_tempoChanges.ContainsKey(measure))
				{
					t.Insert(tickAtStartOfMeasure, new MetaMessage(MetaType.Tempo, GetTempoBytes(_tempoChanges[measure])));
				}

				// Create events for percussion
				foreach (var note in _percussionTrack.Notes[measure])
				{
					t.Insert(tickAtStartOfMeasure + note.StartInTicks(StandardMidiTicksPerBeat), new ChannelMessage(ChannelCommand.NoteOn, (int)Channel.Channel10, (int)note.Percussion, (int)note.Velocity));
				}

				tickAtStartOfMeasure += MeasureLengthInTicks(measure);
			}

			// Create events for unrolled instrument tracks
			foreach (var unrolledInstrument in unrolledInstruments)
			{
				foreach (var note in unrolledInstrument.Notes)
				{
					var noteStartInTicks = note.StartInTicks(StandardMidiTicksPerBeat);
					var noteLengthInTicks = note.LengthInTicks(StandardMidiTicksPerBeat);

					t.Insert(TickBuffer + noteStartInTicks, new ChannelMessage(ChannelCommand.NoteOn, (int)unrolledInstrument.Channel, (int)note.Pitch, (int)note.Velocity));

					// NOTE: You cannot have NoteOff and NoteOn events for the same pitch
					// on the same tick. NoteOff gets priority and the second note will not
					// be played. So move the end of the last note back by a tick.
					// We could check each note individually, but that takes extra time that's
					// not really worth saving.
					t.Insert(TickBuffer + noteStartInTicks + noteLengthInTicks - 1, new ChannelMessage(ChannelCommand.NoteOff, (int)unrolledInstrument.Channel, (int)note.Pitch, (int)note.Velocity));
				}
			}

			t.Insert(tickAtStartOfMeasure, new MetaMessage(MetaType.EndOfTrack, new byte[0]));

			s.Add(t);
			s.Save(filename);
		}

		/// <summary>
		/// Takes a measure-by-measure list of notes and
		/// unrolls it out into a single list.
		/// </summary>
		/// <param name="notes"></param>
		/// <returns></returns>
		private IEnumerable<Note> Unroll(IReadOnlyList<List<Note>> notes)
		{
			var retVal = new List<Note>();
			for (var m = 0; m < notes.Count; m++)
			{
				var beatAtMeasureStart = m * TimeSignatureAtMeasure(m).BeatCount;
				retVal.AddRange(notes[m].Select(note => new Note(beatAtMeasureStart + note.Start, note.Length, note.Pitch, note.Velocity)));
			}
			return retVal;
		}

		#region Validation

		private static void ValidateInitial<T>(IReadOnlyDictionary<int, T> dictionary, string itemName)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException(nameof(dictionary));
			}

			if (!dictionary.ContainsKey(0))
			{
				throw new ArgumentException(string.Format("No initial {0}.", itemName));
			}
		}

		private static void ValidateInstrumentTrackLength(InstrumentTrack track, int length)
		{
			if (track == null)
			{
				throw new ArgumentNullException(nameof(track));
			}

			if (track.Notes.Count != length)
			{
				throw new ArgumentException(string.Format("Instrument track must be {0} measures long.", length));
			}
		}

		private static void ValidatePercussionTrackLength(PercussionTrack track, int length)
		{
			if (track == null)
			{
				throw new ArgumentNullException(nameof(track));
			}

			if (track.Notes.Count != length)
			{
				throw new ArgumentException(string.Format("Percussion track must be {0} measures long.", length));
			}
		}

		#endregion

		private TimeSignature TimeSignatureAtMeasure(int measure)
		{
			return _timeSignatures.Last(t => t.Key <= measure).Value;
		}

		private int MeasureLengthInTicks(int measure)
		{
			// For the sake of our calculations, one "beat" always equals one quarter note.
			return (int)(TimeSignatureAtMeasure(measure).TotalBeatsPerMeasure * StandardMidiTicksPerBeat);
		}

		/// <summary>
		/// Returns the MIDI byte indicator for tempo, given a particular tempo.
		/// </summary>
		/// <param name="tempo">The tempo in BPM.</param>
		/// <returns></returns>
		private static byte[] GetTempoBytes(int tempo)
		{
			// http://home.roadrunner.com/~jgglatt/tech/midifile/ppqn.htm
			// tt tt tt = 60,000,000 / BPM
			var retval = new byte[3];

			var conv = (int)(60000000.0 / tempo);
			var temparray = BitConverter.GetBytes(conv);

			retval[0] = temparray[2];
			retval[1] = temparray[1];
			retval[2] = temparray[0];

			return retval;
		}

		#region Private classes

		private struct UnrolledInstrument
		{
			public Channel Channel;
			public List<Note> Notes;
		}

		#endregion
	}
}
