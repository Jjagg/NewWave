﻿using NewWave.Core.Pitches;

namespace NewWave.Core.Chords
{
	public static class ChordPresets
	{
		public static Chord C => new Chord(Pitch.C);
	    public static Chord F => new Chord(Pitch.F);
	    public static Chord am => new Chord(Pitch.A, ChordQuality.Minor);
	    public static Chord G => new Chord(Pitch.G);
	    public static Chord dm => new Chord(Pitch.D, ChordQuality.Minor);
	    public static Chord em => new Chord(Pitch.E, ChordQuality.Minor);
	    public static Chord am7 => new Chord(Pitch.A, ChordQuality.Minor, ChordAdded.Seven);
	    public static Chord CE => new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.None, Pitch.E);
	    public static Chord dm7 => new Chord(Pitch.D, ChordQuality.Minor, ChordAdded.Seven);
	    public static Chord Fmaj7 => new Chord(Pitch.F, ChordQuality.Major, ChordAdded.Seven);
	    public static Chord Bb => new Chord(Pitch.CSharp);
	    public static Chord CG => new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.None, Pitch.G);
	    public static Chord E => new Chord(Pitch.E);
	    public static Chord em7 => new Chord(Pitch.E, ChordQuality.Minor, ChordAdded.Seven);
	    public static Chord GB => new Chord(Pitch.G, ChordQuality.NotSpecified, ChordAdded.None, Pitch.B);
	    public static Chord G7 => new Chord(Pitch.G, ChordQuality.NotSpecified, ChordAdded.Seven);
	    public static Chord Cmaj7 => new Chord(Pitch.C, ChordQuality.Major, ChordAdded.Seven);
	    public static Chord amE => new Chord(Pitch.A, ChordQuality.Minor, ChordAdded.None, Pitch.E);
	    public static Chord D => new Chord(Pitch.D);
	    public static Chord amC => new Chord(Pitch.A, ChordQuality.Minor, ChordAdded.None, Pitch.C);
	    public static Chord E7 => new Chord(Pitch.E, ChordQuality.NotSpecified, ChordAdded.Seven);
	    public static Chord FA => new Chord(Pitch.F, ChordQuality.NotSpecified, ChordAdded.None, Pitch.A);
	    public static Chord GD => new Chord(Pitch.G, ChordQuality.NotSpecified, ChordAdded.None, Pitch.D);
	    public static Chord am7G => new Chord(Pitch.A, ChordQuality.Minor, ChordAdded.Seven, Pitch.G);
	    public static Chord dmF => new Chord(Pitch.D, ChordQuality.Minor, ChordAdded.None, Pitch.F);
	    public static Chord Eb => new Chord(Pitch.DSharp);
	    public static Chord emG => new Chord(Pitch.E, ChordQuality.Minor, ChordAdded.None, Pitch.G);
	    public static Chord Ab => new Chord(Pitch.GSharp);
	    public static Chord D7 => new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.Seven);
	    public static Chord emB => new Chord(Pitch.E, ChordQuality.Minor, ChordAdded.None, Pitch.B);
	    public static Chord fm => new Chord(Pitch.F, ChordQuality.Minor);
	    public static Chord Fmaj6 => new Chord(Pitch.F, ChordQuality.Major, ChordAdded.Six);
	    public static Chord G7F => new Chord(Pitch.G, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.F);
	    public static Chord Gmaj6 => new Chord(Pitch.G, ChordQuality.Major, ChordAdded.Six);
	    public static Chord A => new Chord(Pitch.A);
	    public static Chord A7 => new Chord(Pitch.A, ChordQuality.NotSpecified, ChordAdded.Seven);
	    public static Chord bdim => new Chord(Pitch.B, ChordQuality.Diminished);
	    public static Chord C7 => new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.Seven);
	    public static Chord Cmaj6 => new Chord(Pitch.C, ChordQuality.Major, ChordAdded.Six);
	    public static Chord dmA => new Chord(Pitch.D, ChordQuality.Minor, ChordAdded.None, Pitch.A);
	    public static Chord dm7C => new Chord(Pitch.D, ChordQuality.Minor, ChordAdded.Seven, Pitch.C);
	    public static Chord B => new Chord(Pitch.B);
	    public static Chord bm => new Chord(Pitch.B, ChordQuality.Minor);
	    public static Chord Cmaj7B => new Chord(Pitch.C, ChordQuality.Major, ChordAdded.Seven, Pitch.B);
	    public static Chord EB => new Chord(Pitch.E, ChordQuality.NotSpecified, ChordAdded.None, Pitch.B);
	    public static Chord F7 => new Chord(Pitch.F, ChordQuality.NotSpecified, ChordAdded.Seven);
	    public static Chord gm => new Chord(Pitch.G, ChordQuality.Minor);
	    public static Chord FC => new Chord(Pitch.F, ChordQuality.NotSpecified, ChordAdded.None, Pitch.C);
	    public static Chord EAb => new Chord(Pitch.E, ChordQuality.NotSpecified, ChordAdded.None, Pitch.GSharp);
	    public static Chord Fmaj7E => new Chord(Pitch.F, ChordQuality.Major, ChordAdded.Seven, Pitch.E);
	    public static Chord gm7 => new Chord(Pitch.G, ChordQuality.Minor, ChordAdded.Seven);
	    public static Chord cm => new Chord(Pitch.C, ChordQuality.Minor);
	    public static Chord fdim => new Chord(Pitch.F, ChordQuality.Diminished);
	    public static Chord gdim => new Chord(Pitch.G, ChordQuality.Diminished);
	    public static Chord gdimB => new Chord(Pitch.G, ChordQuality.Diminished, ChordAdded.None, Pitch.B);
	    public static Chord DGb => new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.None, Pitch.FSharp);
	    public static Chord AE => new Chord(Pitch.A, ChordQuality.NotSpecified, ChordAdded.None, Pitch.E);
	    public static Chord EmG => new Chord(Pitch.E, ChordQuality.Minor, ChordAdded.None, Pitch.G);
	    public static Chord BbF => new Chord(Pitch.ASharp, ChordQuality.NotSpecified, ChordAdded.None, Pitch.F);
	    public static Chord C7Bb => new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.ASharp);
	    public static Chord DF => new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.None, Pitch.F);
	    public static Chord C7E => new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.E);
	    public static Chord G7D => new Chord(Pitch.G, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.D);
	    public static Chord Cmaj7G => new Chord(Pitch.C, ChordQuality.Major, ChordAdded.Seven, Pitch.G);
	    public static Chord E7Ab => new Chord(Pitch.E, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.GSharp);
	    public static Chord bm7 => new Chord(Pitch.B, ChordQuality.Minor, ChordAdded.Seven);
	    public static Chord BD => new Chord(Pitch.B, ChordQuality.NotSpecified, ChordAdded.None, Pitch.D);
	    public static Chord Cmaj7E => new Chord(Pitch.C, ChordQuality.Major, ChordAdded.Seven, Pitch.E);
	    public static Chord Emaj7 => new Chord(Pitch.E, ChordQuality.Major, ChordAdded.Seven);
	    public static Chord abdim => new Chord(Pitch.GSharp, ChordQuality.Diminished);
	    public static Chord fmAb => new Chord(Pitch.F, ChordQuality.Minor, ChordAdded.None, Pitch.GSharp);
	    public static Chord gmD => new Chord(Pitch.G, ChordQuality.Minor, ChordAdded.None, Pitch.D);
	    public static Chord Db => new Chord(Pitch.CSharp);
	    public static Chord em7D => new Chord(Pitch.E, ChordQuality.Minor, ChordAdded.Seven, Pitch.D);
	    public static Chord E7D => new Chord(Pitch.E, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.D);
	    public static Chord edim => new Chord(Pitch.E, ChordQuality.Diminished);
	    public static Chord am7E => new Chord(Pitch.A, ChordQuality.Minor, ChordAdded.Seven, Pitch.E);
	    public static Chord gbdim => new Chord(Pitch.FSharp, ChordQuality.Diminished);
	    public static Chord BbD => new Chord(Pitch.ASharp, ChordQuality.NotSpecified, ChordAdded.None, Pitch.D);
	    public static Chord Bb7 => new Chord(Pitch.ASharp, ChordQuality.NotSpecified, ChordAdded.Seven);
	    public static Chord Bbmaj6 => new Chord(Pitch.ASharp, ChordQuality.Major, ChordAdded.Six);
	    public static Chord cdimE => new Chord(Pitch.C, ChordQuality.Diminished, ChordAdded.None, Pitch.E);
	    public static Chord C7B => new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.B);
	    public static Chord adim => new Chord(Pitch.A, ChordQuality.Diminished);
	    public static Chord cmEb => new Chord(Pitch.C, ChordQuality.Minor, ChordAdded.None, Pitch.DSharp);
	    public static Chord Abmaj7 => new Chord(Pitch.GSharp, ChordQuality.Major, ChordAdded.Seven);
	    public static Chord G7B => new Chord(Pitch.G, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.B);
	    public static Chord D7Gb => new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.FSharp);
	    public static Chord C7G => new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.G);
	    public static Chord cmG => new Chord(Pitch.C, ChordQuality.Minor, ChordAdded.None, Pitch.G);
	    public static Chord D7F => new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.F);
	    public static Chord D7C => new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.C);
	    public static Chord Fmaj7C => new Chord(Pitch.F, ChordQuality.Major, ChordAdded.Seven, Pitch.C);
	    public static Chord em7B => new Chord(Pitch.E, ChordQuality.Minor, ChordAdded.Seven, Pitch.B);
	    public static Chord ebm7 => new Chord(Pitch.DSharp, ChordQuality.Minor, ChordAdded.Seven);
	    public static Chord ADb => new Chord(Pitch.A, ChordQuality.NotSpecified, ChordAdded.None, Pitch.CSharp);
	    public static Chord Bmaj7 => new Chord(Pitch.B, ChordQuality.Major, ChordAdded.Seven);
	    public static Chord gbm7 => new Chord(Pitch.FSharp, ChordQuality.Minor, ChordAdded.Seven);
	    public static Chord E7B => new Chord(Pitch.E, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.B);
	    public static Chord D7A => new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.A);
	    public static Chord dbdim => new Chord(Pitch.CSharp, ChordQuality.Diminished);
	    public static Chord fm6 => new Chord(Pitch.F, ChordQuality.Minor, ChordAdded.Six);
	    public static Chord Ebmaj7 => new Chord(Pitch.DSharp, ChordQuality.Major, ChordAdded.Seven);
	    public static Chord Gb => new Chord(Pitch.ASharp);
	    public static Chord DA => new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.None, Pitch.A);
	    public static Chord ebm => new Chord(Pitch.DSharp, ChordQuality.Minor);
	    public static Chord B7 => new Chord(Pitch.B, ChordQuality.NotSpecified, ChordAdded.Seven);
	    public static Chord ebdim => new Chord(Pitch.DSharp, ChordQuality.Diminished);
	    public static Chord abm7 => new Chord(Pitch.GSharp, ChordQuality.Minor, ChordAdded.Seven);
	    public static Chord gmBb => new Chord(Pitch.G, ChordQuality.Minor, ChordAdded.None, Pitch.ASharp);
	    public static Chord bdimD => new Chord(Pitch.B, ChordQuality.Diminished, ChordAdded.None, Pitch.D);
	}
}