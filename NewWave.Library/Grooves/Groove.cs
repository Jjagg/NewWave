using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewWave.Core;
using NewWave.Midi;

namespace NewWave.Library.Grooves
{
	public class Groove
	{
		private readonly string _name;
		private readonly TimeSignature _timeSignature;
		private readonly int _feel;

		private readonly List<double> _hihat;
		private readonly List<double> _snare;
		private readonly List<double> _kick;

		public Groove(string name, TimeSignature timeSignature, int feel, int timekeepFreq, List<double> kick, List<double> snare)
		{
			_name = name;
			_timeSignature = timeSignature;
			_feel = feel;

			_hihat = Enumerable.Range(0, _timeSignature.BeatCount * feel).Where(i => i % timekeepFreq == 0).Select(d => (double)d / feel).ToList();
			_kick = kick;
			_snare = snare;
		}

		public List<PercussionNote> Notes(Percussion timekeeper, bool addCrash, TimeSignature timeSignature, bool addFill)
		{
			var lengthOfSection = timeSignature.BeatCount;
			var ratio = (double)timeSignature.BeatUnit / _timeSignature.BeatUnit;
			var notes = new List<PercussionNote>();

			if (addCrash)
			{
				notes.Add(new PercussionNote(0, Percussion.CrashCymbal1, Velocity.Fff));
			}

			notes.AddRange(_hihat.Select((hihatNote, i) => new PercussionNote(hihatNote * ratio, timekeeper, i % 2 == 1 ? Velocity.F : Velocity.Fff)));
			notes.AddRange(_snare.Select(snareNote => new PercussionNote(snareNote * ratio, Percussion.SnareDrum1, Velocity.Fff)));
			notes.AddRange(_kick.Select(kickNote => new PercussionNote(kickNote * ratio, Percussion.BassDrum1, Velocity.Fff)));

			// Trim leftover notes
			notes = notes.Where(n => n.Start < lengthOfSection).ToList();

			if (addFill)
			{
				const int fillLength = 2;
				var fill = GetFill(lengthOfSection - fillLength, fillLength);
				notes = notes.Where(n => n.Start < lengthOfSection - fillLength).Union(fill).ToList();
			}

			return notes;
		}

		private static IEnumerable<PercussionNote> GetFill(double delay, int fillLengthInBeats)
		{
			const double lengthOfNote = 0.25;
			return Enumerable.Range(0, (int)(fillLengthInBeats / lengthOfNote)).Select(i => new PercussionNote(delay + i * lengthOfNote, Percussion.SnareDrum1, Velocity.Ff));
		}

		public string AsTab()
		{
			var sb = new StringBuilder();

			foreach (var drumVoice in new List<Tuple<string, string, List<double>>>
			{
				new Tuple<string, string, List<double>>("H", "x", _hihat.Select(h => h * 4).ToList()),
				new Tuple<string, string, List<double>>("S", "o", _snare.Select(s => s * 4).ToList()),
				new Tuple<string, string, List<double>>("K", "o", _kick.Select(k => k * 4).ToList())
			})
			{
				sb.AppendLine(string.Format("{0}|{1}|", drumVoice.Item1,
					string.Join("", Enumerable.Range(0, _timeSignature.BeatCount * _feel).Select(i => drumVoice.Item3.Contains(i) ? drumVoice.Item2 : "-"))));
			}

			return sb.ToString();
		}

		public override string ToString()
		{
			return _name;
		}
	}
}
