using System.Collections.Generic;
using NewWave.Midi;

namespace NewWave.Library.Chords
{
	public struct Chord
	{
		private Pitch _basePitch;
	    public readonly ChordQuality Quality;
		private readonly ChordAdded _added;
		private Pitch _inversion;
		private readonly bool _isInverted;

		public Chord(Pitch basePitch, ChordQuality quality = ChordQuality.NotSpecified, ChordAdded added = ChordAdded.None)
		{
			_basePitch = basePitch;
			Quality = quality;
			_added = added;
			_isInverted = false;
			_inversion = Pitch.ANeg1;
		}

		public Chord(Pitch basePitch, ChordQuality quality, ChordAdded added, Pitch inversion)
		{
			_basePitch = basePitch;
			Quality = quality;
			_added = added;
			_inversion = inversion;
			_isInverted = true;
		}

		public List<Pitch> Pitches()
		{
			var pitches = new List<Pitch> { _isInverted ? _inversion : _basePitch };

			// Second note
			if (Quality == ChordQuality.Minor || Quality == ChordQuality.Diminished)
			{
				pitches.Add(_basePitch + 3);
			}
			else if (Quality == ChordQuality.Suspended)
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
						pitches.Add(_basePitch + (Quality == ChordQuality.Major ? 11 : 10));
						break;
					case ChordAdded.Nine:
						pitches.Add(_basePitch + (Quality == ChordQuality.Major ? 11 : 10));
						pitches.Add(_basePitch + (Quality == ChordQuality.Minor ? 13 : 14));
						break;
					case ChordAdded.Eleven:
						pitches.Add(_basePitch + (Quality == ChordQuality.Major ? 11 : 10));
						pitches.Add(_basePitch + (Quality == ChordQuality.Minor ? 13 : 14));
						pitches.Add(_basePitch + (Quality == ChordQuality.Diminished ? 16 : 17));
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

		public override bool Equals(object obj)
		{
			if (!(obj is Chord)) return false;

			var other = (Chord)obj;
			return
				_basePitch == other._basePitch &&
				_added == other._added &&
				_isInverted == other._isInverted &&
				(!_isInverted || _inversion == other._inversion) &&
				Quality == other.Quality;
		}

		public override string ToString()
		{
			var quality = string.Empty;
			switch (Quality)
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
					added = "6";
					break;
				case ChordAdded.Seven:
					added = "7";
					break;
				case ChordAdded.Nine:
					added = "9";
					break;
				case ChordAdded.Eleven:
					added = "11";
					break;
			}

			var inverted = _isInverted ? string.Format("/{0}", _inversion.NoteName()) : string.Empty;

			return string.Format("{0}{1}{2}{3}", _basePitch.NoteName(), quality, added, inverted);
		}
	}
}
