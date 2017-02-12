using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Core.Grooves;
using NewWave.Generator.Common;
using NewWave.Midi;

namespace NewWave.Generator.Sections
{
	public class DrumStyle
	{
		private readonly Percussion _timeKeeper;
		private readonly bool _blast;
		private readonly bool _floatKick;

		public List<PercussionNote> Notes { get; }

		public DrumStyle(SectionType type, float probabilityOfBlastbeats = 0)
		{
			_timeKeeper = GetTimeKeeper(type);
			Notes = new List<PercussionNote>();

			if (Randomizer.ProbabilityOfTrue(probabilityOfBlastbeats) && (type == SectionType.Chorus || type == SectionType.Verse))
			{
				_blast = true;
			}
			else if (Randomizer.ProbabilityOfTrue(probabilityOfBlastbeats))
			{
				_floatKick = true;
			}
		}

		public void Generate(Groove groove)
		{
			Notes.Clear();
			IEnumerable<float> kicks;
			IEnumerable<float> hihats;
			IEnumerable<float> snares;

			if (_blast)
			{
				GenerateBlast(groove.TimeSignature, groove.Feel, out kicks, out hihats, out snares);
			}
			else if (_floatKick)
			{
				GenerateDoubleKick(groove.TimeSignature, groove.Feel, out kicks, out hihats, out snares);
			}
			else
			{
				GenerateBasicGroove(groove, out kicks, out hihats, out snares);
			}

			Notes.AddRange(hihats.Select(h => new PercussionNote(h, (int) _timeKeeper, (int) Velocity.Fff)));
			Notes.AddRange(kicks.Select(k => new PercussionNote(k, (int) Percussion.BassDrum1, (int) Velocity.Fff)));
			Notes.AddRange(snares.Select(s => new PercussionNote(s, (int) Percussion.SnareDrum1, (int) Velocity.Fff)));
		}

		private static void GenerateBasicGroove(Groove groove, out IEnumerable<float> kicks, out IEnumerable<float> hihats, out IEnumerable<float> snares)
		{
			hihats = new List<float>();
			var snareList = new List<float>();

			switch (groove.Feel)
			{
				case 3:
					hihats = Enumerable.Range(0, groove.TimeSignature.BeatCount * 3).Select(b => b / 3.0f);
					break;
				case 4:
					hihats = Enumerable.Range(0, groove.TimeSignature.BeatCount * 2).Select(b => b / 2.0f);
					break;
			}

			if (groove.TimeSignature.BeatCount % 4 == 0)
			{
				snareList = EveryNthOfBeat(groove.TimeSignature.BeatCount, groove.Feel / 2.0f, 1).ToList();
			}
			else if (groove.TimeSignature.BeatCount % 3 == 0)
			{
				if (groove.TimeSignature.BeatCount == 3 && Randomizer.ProbabilityOfTrue(0.5f) && groove.Feel == 4)
				{
					snareList = new[]
					{
						new List<float> { 1, 2.5f },
						new List<float> { 1, 2.25f },
						new List<float> { 0.75f, 2 }
					}[Randomizer.Next(3)];
				}
				else
				{
					snareList = EveryNthOfBeat(groove.TimeSignature.BeatCount, 1.5f, 1).ToList();
				}
			}

			kicks = groove.Beats.Where(b => !snareList.Contains(b));
			snares = snareList;
		}

		private static void GenerateBlast(TimeSignature timeSignature, int feel, out IEnumerable<float> kicks, out IEnumerable<float> hihats, out IEnumerable<float> snares)
		{
			if (feel % 2 == 0)
			{
				kicks = EveryNthOfBeat(timeSignature.BeatCount, 0.5f);
				snares = EveryNthOfBeat(timeSignature.BeatCount, 0.5f, 0.25f);
				hihats = kicks;
			}
			else
			{
				GenerateDoubleKick(timeSignature, feel, out kicks, out hihats, out snares);
			}
		}

		private static void GenerateDoubleKick(TimeSignature timeSignature, int feel, out IEnumerable<float> kicks, out IEnumerable<float> hihats, out IEnumerable<float> snares)
		{
			kicks = EveryNthOfBeat(timeSignature.BeatCount, 1.0f / feel);
			snares = EveryNthOfBeat(timeSignature.BeatCount, feel / 2.0f, 1);
			hihats = EveryNthOfBeat(timeSignature.BeatCount, 2.0f / feel);
		}

		private static IEnumerable<float> EveryNthOfBeat(int numberOfBeats, float fractionOfBeat, float offset = 0)
		{
			return Enumerable.Range(0, (int)(numberOfBeats * 1 / fractionOfBeat)).Select(b => b * fractionOfBeat + offset);
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
