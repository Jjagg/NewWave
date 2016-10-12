using System.Collections.Generic;
using NewWave.Core;
using NewWave.Midi;

namespace NewWave.Generator
{
	internal class DrumBeat
	{
		internal static List<PercussionNote> GetMeasure(bool isImportantMeasure, TimeSignature timeSignature, int feel)
		{
			var notes = new List<PercussionNote>();

			for (var beat = 0; beat < timeSignature.BeatCount; beat++)
			{
				notes.Add(new PercussionNote(beat * feel, isImportantMeasure && beat == 0
					? Percussion.CrashCymbal1
					: Percussion.OpenHiHat, Velocity.Fff));
				notes.Add(new PercussionNote(beat * feel, beat % 2 == 0 ? Percussion.BassDrum1 : Percussion.SnareDrum1, Velocity.Fff));
			}

			return notes;
		}
	}
}
