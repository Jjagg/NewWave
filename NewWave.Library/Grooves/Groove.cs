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

		private readonly List<int> _hihat; 
		private readonly List<int> _snare; 
		private readonly List<int> _kick; 

		public Groove(string name, TimeSignature timeSignature, int feel, int timekeepFreq, List<int> snare, List<int> kick)
		{
			_name = name;
			_timeSignature = timeSignature;
			_feel = feel;

			_hihat = Enumerable.Range(0, _timeSignature.BeatCount * feel).Where(i => i % timekeepFreq == 0).ToList();
			_snare = snare;
			_kick = kick;
		}

		public List<PercussionNote> Notes(Percussion timekeeper, bool addCrash)
		{
			var notes = new List<PercussionNote>();

		    if (addCrash)
		    {
                notes.Add(new PercussionNote(0, Percussion.CrashCymbal1, Velocity.Fff));
		    }

            notes.AddRange(_hihat.Skip(addCrash ? 1 : 0).Select(hihatNote => new PercussionNote(hihatNote, timekeeper, Velocity.Fff)));
			notes.AddRange(_snare.Select(snareNote => new PercussionNote(snareNote, Percussion.SnareDrum1, Velocity.Fff)));
			notes.AddRange(_kick.Select(kickNote => new PercussionNote(kickNote, Percussion.BassDrum1, Velocity.Fff)));

			return notes;
		}

		public string AsTab()
		{
			var sb = new StringBuilder();

			foreach (var drumVoice in new List<Tuple<string, string, List<int>>>
			{
				new Tuple<string, string, List<int>>("H", "x", _hihat),
				new Tuple<string, string, List<int>>("S", "o", _snare),
				new Tuple<string, string, List<int>>("K", "o", _kick)
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
