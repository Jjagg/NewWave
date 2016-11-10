using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Midi;

namespace NewWave.Library.Grooves
{
	public class Groove
	{
		private readonly string _name;
		private readonly TimeSignature _timeSignature;

		private readonly List<double> _hihat;
		private readonly List<double> _snare;
		private readonly List<double> _kick;

		public Groove(string name, TimeSignature timeSignature, int feel, int timekeepFreq, List<double> kick, List<double> snare)
		{
			_name = name;
			_timeSignature = timeSignature;

			_hihat = Enumerable.Range(0, _timeSignature.BeatCount * feel).Where(i => i % timekeepFreq == 0).Select(d => (double)d / feel).ToList();
			_kick = kick;
			_snare = snare;
		}

		public List<PercussionNote> Notes(Percussion timekeeper, bool addCrash, TimeSignature timeSignature)
		{
			var lengthOfSection = timeSignature.BeatCount;
			var ratio = (double)timeSignature.BeatUnit / _timeSignature.BeatUnit;
			var notes = new List<PercussionNote>();

			if (addCrash)
			{
				notes.Add(new PercussionNote(0, Percussion.CrashCymbal1, Velocity.Fff));
			}

			notes.AddRange(_hihat.Select((hihatNote, i) => new PercussionNote(hihatNote * ratio, timekeeper, i % 2 == 1 ? Velocity.F : Velocity.Fff)).Where(p => p.Start == 0 ? !addCrash : true));
			notes.AddRange(_snare.Select(snareNote => new PercussionNote(snareNote * ratio, Percussion.SnareDrum1, Velocity.Fff)));
			notes.AddRange(_kick.Select(kickNote => new PercussionNote(kickNote * ratio, Percussion.BassDrum1, Velocity.Fff)));

			// Trim leftover notes
			return notes.Where(n => n.Start < lengthOfSection).ToList();
		}

		public override string ToString()
		{
			return _name;
		}
	}
}
