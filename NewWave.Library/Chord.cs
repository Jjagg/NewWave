using System.Collections.Generic;
using NewWave.Midi;

namespace NewWave.Library
{
	public class Chord
	{
		private readonly Pitch _basePitch;
		private readonly ChordQuality _quality;
		private readonly ChordAdded _added;

		public Chord(Pitch basePitch, ChordQuality quality, ChordAdded added)
		{
			_basePitch = basePitch;
			_quality = quality;
			_added = added;
		}

		public IEnumerable<Pitch> Pitches()
		{
			var pitches = new List<Pitch> { _basePitch };

			// Second note
			if (_quality == ChordQuality.Minor || _quality == ChordQuality.Diminished)
			{
				pitches.Add(_basePitch + 3);
			}
			else
			{
				pitches.Add(_basePitch + 4);
			}

			// Third note
			pitches.Add(_basePitch + 7);

			// Fourth note
			if (_added != ChordAdded.None)
			{
				switch (_added)
				{
					case ChordAdded.Six:
						pitches.Add(_basePitch + 9);
						break;
					case ChordAdded.Seven:
						pitches.Add(_basePitch + (_quality == ChordQuality.Major ? 11 : 10));
						break;
					case ChordAdded.Nine:
					case ChordAdded.Eleven:
						// Not implemented yet
						break;
				}
			}

			return pitches;
		}

		public override string ToString()
		{
			var quality = string.Empty;
			switch (_quality)
			{
				case ChordQuality.Major:
					quality = "maj";
					break;
				case ChordQuality.Minor:
					quality = "min";
					break;
				case ChordQuality.Augmented:
					quality = "aug";
					break;
				case ChordQuality.Diminished:
					quality = "dim";
					break;
			}

			var added = string.Empty;
			switch (_added)
			{
				case ChordAdded.Six:
					quality = "6";
					break;
				case ChordAdded.Seven:
					quality = "7";
					break;
				case ChordAdded.Nine:
					quality = "9";
					break;
				case ChordAdded.Eleven:
					quality = "11";
					break;
			}

			return string.Format("{0}{1}{2}", _basePitch.NoteName(), quality, added);
		}
	}

	public enum ChordQuality
	{
		NotSpecified,
		Major,
		Minor,
		Augmented,
		Diminished
	}

	public enum ChordAdded
	{
		None,
		Six,
		Seven,
		Nine,
		Eleven
	}
}
