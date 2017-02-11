using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Core.Pitches;
using Sanford.Multimedia.Midi;

namespace NewWave.Midi
{
    public static class MidiExtensions
    {
        
		// Misc MIDI stuff
		private const int StandardMidiTicksPerBeat = 24;
		// Shifts all MIDI events forward one tick so it plays better
		private const int TickBuffer = 1;

		/// <summary>
		/// Export the score to a MIDI file.
		/// </summary>
		/// <param name="filename">The .mid file to output data to.</param>
		public static void ExportMidi(this Score score, string filename)
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
			foreach (var instrumentTrack in score.InstrumentTracks)
			{
				renderedInstruments.Add(new RenderedInstrument
				{
					Channel = channel,
					Notes = score.Unroll(instrumentTrack.Notes).Select(n => new MidiNote(TickBuffer + n.StartInTicks(StandardMidiTicksPerBeat), n.LengthInTicks(StandardMidiTicksPerBeat), n.Pitch, (Velocity) n.Velocity)).ToList()
				});

				t.Insert(0, new ChannelMessage(ChannelCommand.ProgramChange, (int)channel, (int)instrumentTrack.Channel));
				t.Insert(0, new ChannelMessage(ChannelCommand.Controller, (int)channel, (int)Control.Pan, (int)instrumentTrack.Pan));

				channel++;
				if (channel == Channel.Channel10) channel++; // skip over percussion
			}

			for (var measure = 0; measure < score.MeasureCount; measure++)
			{
				// Create tempo change (if one exists)
				if (score.TempoChanges.ContainsKey(measure))
				{
					t.Insert(tickAtStartOfMeasure, new MetaMessage(MetaType.Tempo, GetTempoBytes(score.TempoChanges[measure])));
				}

				// Create events for percussion
				foreach (var note in score.PercussionTrack.Notes[measure])
				{
					t.Insert(tickAtStartOfMeasure + note.StartInTicks(StandardMidiTicksPerBeat), new ChannelMessage(ChannelCommand.NoteOn, (int)Channel.Channel10, (int)note.PercussionId, (int)note.Velocity));
				}

				tickAtStartOfMeasure += MeasureLengthInTicks(score, measure);
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
			var endingBuffer = score.TimeSignatureAtMeasure(score.MeasureCount - 1).BeatCount * StandardMidiTicksPerBeat;
			t.Insert(tickAtStartOfMeasure + endingBuffer, new ChannelMessage(ChannelCommand.NoteOff, (int)Channel.Channel10, 0));

			// End meta message
			t.Insert(tickAtStartOfMeasure + endingBuffer, new MetaMessage(MetaType.EndOfTrack, new byte[0]));

			s.Add(t);
			s.Save(filename);
		}

		private static int MeasureLengthInTicks(Score score, int measure)
		{
			return score.TimeSignatureAtMeasure(measure).BeatCount * StandardMidiTicksPerBeat;
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
			public readonly OctavePitch Pitch;
			public readonly Velocity Velocity;

			public MidiNote(int start, int length, OctavePitch pitch, Velocity velocity)
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