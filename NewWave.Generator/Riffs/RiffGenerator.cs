using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Library.Chords;
using NewWave.Midi;

namespace NewWave.Generator.Riffs
{
	internal static class RiffGenerator
	{
		internal static IEnumerable<Note> GetRiff(int length, List<Tuple<int, Chord>> chordProgression)
		{
			return Enumerable.Range(0, length).Select(n => new Note(n, 1, chordProgression[0].Item2.Pitches().First() + 12, Velocity.Ff));
		} 
	}
}
