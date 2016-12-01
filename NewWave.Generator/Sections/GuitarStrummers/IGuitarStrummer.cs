using System;
using System.Collections.Generic;
using NewWave.Core;
using NewWave.Library.Chords;

namespace NewWave.Generator.Sections.GuitarStrummers
{
	public interface IGuitarStrummer
	{
		void AddGuitarNotes(InstrumentTrack track, List<Tuple<double, double>> gNotes, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo);
		void AddBassNotes(InstrumentTrack track, List<Tuple<double, double>> gNotes, List<Tuple<int, Chord>> chords, int measure, SongInfo songInfo);
	}
}
