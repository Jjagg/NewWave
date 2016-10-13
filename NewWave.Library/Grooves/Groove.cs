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
		private readonly TimeSignature _timeSignature;
		private readonly int _feel;

		private readonly List<int> _crash;
		private readonly List<int> _hihat; 
		private readonly List<int> _snare; 
		private readonly List<int> _kick; 

		public Groove(TimeSignature timeSignature, int feel)
		{
			_timeSignature = timeSignature;
			_feel = feel;

			_crash = new List<int> { 0 };
			_hihat = new List<int> { 2, 4, 6, 8, 10, 12, 14 };
			_kick = new List<int> { 0, 8 };
			_snare = new List<int> { 4, 12 };
		}

		public List<PercussionNote> Notes()
		{
			var notes = new List<PercussionNote>();

			notes.AddRange(_crash.Select(crashNote => new PercussionNote(crashNote, Percussion.CrashCymbal1, Velocity.Fff)));
			notes.AddRange(_hihat.Select(hihatNote => new PercussionNote(hihatNote, Percussion.ClosedHiHat, Velocity.Fff)));
			notes.AddRange(_snare.Select(snareNote => new PercussionNote(snareNote, Percussion.SnareDrum1, Velocity.Fff)));
			notes.AddRange(_kick.Select(kickNote => new PercussionNote(kickNote, Percussion.BassDrum1, Velocity.Fff)));

			return notes;
		}

		public string AsTab()
		{
			var sb = new StringBuilder();

			foreach (var drumVoice in new List<Tuple<string, string, List<int>>>
			{
				new Tuple<string, string, List<int>>("C", "X", _crash),
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
	}
}
