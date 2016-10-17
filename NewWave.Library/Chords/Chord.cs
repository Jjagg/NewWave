using System.Collections.Generic;
using NewWave.Midi;

namespace NewWave.Library.Chords
{
	public class Chord
	{
		private Pitch _basePitch;
		private readonly ChordQuality _quality;
		private readonly ChordAdded _added;
		private Pitch _inversion;
		private readonly bool _isInverted;

		public Chord(Pitch basePitch, ChordQuality quality = ChordQuality.NotSpecified, ChordAdded added = ChordAdded.None)
		{
			_basePitch = basePitch;
			_quality = quality;
			_added = added;
			_isInverted = false;
		}

		public Chord(Pitch basePitch, ChordQuality quality, ChordAdded added, Pitch inversion)
		{
			_basePitch = basePitch;
			_quality = quality;
			_added = added;
			_inversion = inversion;
			_isInverted = true;
		}

		public IEnumerable<Pitch> Pitches()
		{
			var pitches = new List<Pitch> { _isInverted ? _inversion : _basePitch };

			// Second note
			if (_quality == ChordQuality.Minor || _quality == ChordQuality.Diminished)
			{
				pitches.Add(_basePitch + 3);
			}
			else if (_quality == ChordQuality.Suspended)
			{
				pitches.Add(_basePitch + 5);
			}
			else
			{
				pitches.Add(_basePitch + 4);
			}

			// Third note
			pitches.Add(_basePitch + 7);

			// Additional notes
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
						pitches.Add(_basePitch + (_quality == ChordQuality.Major ? 11 : 10));
						pitches.Add(_basePitch + (_quality == ChordQuality.Minor ? 13 : 14));
						break;
					case ChordAdded.Eleven:
						pitches.Add(_basePitch + (_quality == ChordQuality.Major ? 11 : 10));
						pitches.Add(_basePitch + (_quality == ChordQuality.Minor ? 13 : 14));
						pitches.Add(_basePitch + (_quality == ChordQuality.Diminished ? 16 : 17));
						break;
				}
			}

			return pitches;
		}

		public void Transpose(int halfsteps)
		{
			_basePitch += halfsteps;
			_inversion += halfsteps;
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

			var inverted = _isInverted ? string.Format("/{0}", _inversion.NoteName()) : string.Empty;

			return string.Format("{0}{1}{2}{3}", _basePitch.NoteName(), quality, added, inverted);
		}
	}
}
