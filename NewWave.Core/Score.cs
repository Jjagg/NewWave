using System;
using System.Collections.Generic;
using System.Linq;

namespace NewWave.Core
{
	/// <summary>
	/// The "rendered" version of a song, with explicit instructions for time signatures /
	/// instruments / measures / etc. An "unrolled" version. Kind of like a raster image file.
	/// </summary>
	public class Score
	{
		// General data about measures
		public int MeasureCount { get; }
		public Dictionary<int, TimeSignature> TimeSignatures { get; }
		public Dictionary<int, int> TempoChanges { get; }

		// Data about instrument tracks
		public IEnumerable<InstrumentTrack> InstrumentTracks { get; }
		public PercussionTrack PercussionTrack { get; }

		public Score(int measureCount, Dictionary<int, TimeSignature> timeSignatures, Dictionary<int, int> tempoChanges,
			IReadOnlyCollection<InstrumentTrack> instrumentTracks, PercussionTrack percussionTrack)
		{
			MeasureCount = measureCount;

			TimeSignatures = timeSignatures;
			TempoChanges = tempoChanges;

			ValidateInitial(TimeSignatures, "time signature");
			ValidateInitial(TempoChanges, "tempo");

			if (instrumentTracks.Count > 15)
			{
				throw new Exception("Too many instruments. MIDI is limited to 16 channels: 15 instrument and 1 percussion.");
			}

			InstrumentTracks = instrumentTracks;
			PercussionTrack = percussionTrack;

			foreach (var instrumentTrack in InstrumentTracks)
			{
				ValidateInstrumentTrackLength(instrumentTrack, MeasureCount);
			}

			ValidatePercussionTrackLength(PercussionTrack, MeasureCount);
		}

	    /// <summary>
		/// Takes a measure-by-measure list of notes and
		/// unrolls it out into a single list.
		/// </summary>
		/// <param name="notes"></param>
		/// <returns></returns>
		public IEnumerable<Note> Unroll(IReadOnlyList<List<Note>> notes)
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

	    public TimeSignature TimeSignatureAtMeasure(int measure)
		{
			return TimeSignatures.Last(t => t.Key <= measure).Value;
		}

	}
}
