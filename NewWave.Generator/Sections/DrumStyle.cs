using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Library.Grooves;
using NewWave.Midi;

namespace NewWave.Generator.Sections
{
	public class DrumStyle
	{
		public DrumStyle()
		{
		}

		public List<PercussionNote> Notes(Groove groove)
		{
			var notes = new List<PercussionNote>();

			var kicks = groove.Beats;
			var snares = new List<double>();

			notes.AddRange(kicks.Select(k => new PercussionNote(k, Percussion.BassDrum1, Velocity.Fff)));
			notes.AddRange(snares.Select(s => new PercussionNote(s, Percussion.SnareDrum1, Velocity.Fff)));

			return notes;
		}
	}
}
