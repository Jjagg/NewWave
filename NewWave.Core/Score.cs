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
			var renderedInstruments = new List<RenderedInstrument>();
			foreach (var instrumentTrack in _instrumentTracks)
			{
				renderedInstruments.Add(new RenderedInstrument
				{
					Channel = channel,
					Notes = Unroll(instrumentTrack.Notes).Select(n => new MidiNote(TickBuffer + n.StartInTicks(StandardMidiTicksPerBeat), n.LengthInTicks(StandardMidiTicksPerBeat), n.Pitch, n.Velocity)).ToList()
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
			foreach (var renderedInstrument in renderedInstruments)
			{
				foreach (var note in renderedInstrument.Notes)
				{
					t.Insert(note.Start, new ChannelMessage(ChannelCommand.NoteOn, (int)renderedInstrument.Channel, (int)note.Pitch, (int)note.Velocity));

					if (!renderedInstrument.Notes.Any(e => e.Pitch == note.Pitch && e.Start == note.End))
					{
						// NOTE: You cannot have NoteOff and NoteOn events for the same pitch
						// on the same tick. NoteOff gets priority and the second note will not
						// be played. So if two notes collide, don't write the NoteOff command
						// for the first one.
						t.Insert(note.End, new ChannelMessage(ChannelCommand.NoteOff, (int)renderedInstrument.Channel, (int)note.Pitch, (int)note.Velocity));
					}
				}
			}

			// Add an empty note one measure after the actual end of the song, just for some extra buffer
			var endingBuffer = TimeSignatureAtMeasure(_measureCount - 1).BeatCount * StandardMidiTicksPerBeat;
			t.Insert(tickAtStartOfMeasure + endingBuffer, new ChannelMessage(ChannelCommand.NoteOff, (int)Channel.Channel10, 0));

			// End meta message
			t.Insert(tickAtStartOfMeasure + endingBuffer, new MetaMessage(MetaType.EndOfTrack, new byte[0]));

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
				throw new ArgumentNullException("dictionary");
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
				throw new ArgumentNullException("track");
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
				throw new ArgumentNullException("track");
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
			return TimeSignatureAtMeasure(measure).BeatCount * StandardMidiTicksPerBeat;
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

		private struct RenderedInstrument
		{
			public Channel Channel;
			public List<MidiNote> Notes;
		}

		private struct MidiNote
		{
			public readonly int Start;
			public readonly int End;
			public readonly MidiPitch Pitch;
			public readonly Velocity Velocity;

			public MidiNote(int start, int length, MidiPitch pitch, Velocity velocity)
			{
				Start = start;
				End = start + length;
				Velocity = velocity;
				Pitch = pitch;
			}
		}

		#endregion
	}
}
