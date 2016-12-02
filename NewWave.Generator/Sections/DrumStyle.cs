using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Library.Grooves;
using NewWave.Midi;

namespace NewWave.Generator.Sections
{
	public class DrumStyle
	{
		private Percussion _timeKeeper;

		public DrumStyle(SectionType type)
		{
			_timeKeeper = GetTimeKeeper(type);
		}

		public List<PercussionNote> Notes(Groove groove)
		{
			switch (groove.Feel)
			{
				case 3:
					return ThreeGroove(groove);
				case 4:
					return FourGroove(groove);
			}

			return new List<PercussionNote>();
		}

		private List<PercussionNote> FourGroove(Groove groove)
		{
			var notes = new List<PercussionNote>();

			var hihats = Enumerable.Range(0, groove.TimeSignature.BeatCount * 2).Select(b => b / 2.0);
			var kicks = groove.Beats;
			var snares = new List<double>();

			switch (groove.TimeSignature.BeatCount)
			{
				case 3:
					snares = new List<double> { 0.75, 2.5 };
					break;
				case 4:
					snares = new List<double> { 1, 3 };
					break;
			}

			notes.AddRange(hihats.Select(h => new PercussionNote(h, _timeKeeper, Velocity.Fff)));
			notes.AddRange(kicks.Select(k => new PercussionNote(k, Percussion.BassDrum1, Velocity.Fff)));
			notes.AddRange(snares.Select(s => new PercussionNote(s, Percussion.SnareDrum1, Velocity.Fff)));

			return notes;
		}

		private List<PercussionNote> ThreeGroove(Groove groove)
		{
			var notes = new List<PercussionNote>();

			var hihats = Enumerable.Range(0, groove.TimeSignature.BeatCount * 3).Select(b => b / 3.0);
			var kicks = groove.Beats;
			var snares = new List<double>();

			switch (groove.TimeSignature.BeatCount)
			{
				case 3:
					snares = new List<double> { 1, 2 };
					break;
				case 4:
					snares = new List<double> { 1, 3 };
					break;
			}

			notes.AddRange(hihats.Select(h => new PercussionNote(h, _timeKeeper, Velocity.Fff)));
			notes.AddRange(kicks.Select(k => new PercussionNote(k, Percussion.BassDrum1, Velocity.Fff)));
			notes.AddRange(snares.Select(s => new PercussionNote(s, Percussion.SnareDrum1, Velocity.Fff)));

			return notes;
		}

		private static Percussion GetTimeKeeper(SectionType type)
		{
			List<Percussion> timeKeepers;
			switch (type)
			{
				case SectionType.Intro:
				case SectionType.Outro:
					timeKeepers = new List<Percussion> { Percussion.RideBell, Percussion.RideCymbal1, Percussion.LowTom1 };
					break;
				case SectionType.Chorus:
					timeKeepers = new List<Percussion> { Percussion.OpenHiHat, Percussion.CrashCymbal2 };
					break;
				case SectionType.Prechorus:
					timeKeepers = new List<Percussion> { Percussion.CrashCymbal2, Percussion.RideCymbal1, Percussion.HighTom1, Percussion.RideBell };
					break;
				case SectionType.Verse:
					timeKeepers = new List<Percussion> { Percussion.ClosedHiHat, Percussion.OpenHiHat };
					break;
				case SectionType.Bridge:
					timeKeepers = new List<Percussion> { Percussion.LowTom1, Percussion.RideCymbal1, Percussion.RideCymbal2 };
					break;
				default:
					timeKeepers = new List<Percussion> { Percussion.ClosedHiHat };
					break;
			}

			return timeKeepers[Randomizer.Next(timeKeepers.Count)];
		}
	}
}
