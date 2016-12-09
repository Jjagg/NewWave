﻿using NewWave.Midi;

namespace NewWave.Library.Chords
{
	public static class ChordPresets
	{
		public static Chord C { get { return new Chord(MidiPitch.C0); } }
		public static Chord F { get { return new Chord(MidiPitch.F0); } }
		public static Chord am { get { return new Chord(MidiPitch.A0, ChordQuality.Minor); } }
		public static Chord G { get { return new Chord(MidiPitch.G0); } }
		public static Chord dm { get { return new Chord(MidiPitch.D0, ChordQuality.Minor); } }
		public static Chord em { get { return new Chord(MidiPitch.E0, ChordQuality.Minor); } }
		public static Chord am7 { get { return new Chord(MidiPitch.A0, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord CE { get { return new Chord(MidiPitch.C0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.E0); } }
		public static Chord dm7 { get { return new Chord(MidiPitch.D0, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord Fmaj7 { get { return new Chord(MidiPitch.D0, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord Bb { get { return new Chord(MidiPitch.CSharp0); } }
		public static Chord CG { get { return new Chord(MidiPitch.CSharp0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.G0); } }
		public static Chord E { get { return new Chord(MidiPitch.E0); } }
		public static Chord em7 { get { return new Chord(MidiPitch.E0, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord GB { get { return new Chord(MidiPitch.G0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.B0); } }
		public static Chord G7 { get { return new Chord(MidiPitch.G0, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord Cmaj7 { get { return new Chord(MidiPitch.C0, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord amE { get { return new Chord(MidiPitch.A0, ChordQuality.Minor, ChordAdded.None, MidiPitch.E0); } }
		public static Chord D { get { return new Chord(MidiPitch.D0); } }
		public static Chord amC { get { return new Chord(MidiPitch.A0, ChordQuality.Minor, ChordAdded.None, MidiPitch.C0); } }
		public static Chord E7 { get { return new Chord(MidiPitch.E0, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord FA { get { return new Chord(MidiPitch.F0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.A0); } }
		public static Chord GD { get { return new Chord(MidiPitch.G0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.D0); } }
		public static Chord am7G { get { return new Chord(MidiPitch.A0, ChordQuality.Minor, ChordAdded.Seven, MidiPitch.G0); } }
		public static Chord dmF { get { return new Chord(MidiPitch.D0, ChordQuality.Minor, ChordAdded.None, MidiPitch.F0); } }
		public static Chord Eb { get { return new Chord(MidiPitch.DSharp0); } }
		public static Chord emG { get { return new Chord(MidiPitch.E0, ChordQuality.Minor, ChordAdded.None, MidiPitch.G0); } }
		public static Chord Ab { get { return new Chord(MidiPitch.GSharp0); } }
		public static Chord D7 { get { return new Chord(MidiPitch.GSharp0); } }
		public static Chord emB { get { return new Chord(MidiPitch.E0, ChordQuality.Minor, ChordAdded.None, MidiPitch.B0); } }
		public static Chord fm { get { return new Chord(MidiPitch.F0, ChordQuality.Minor); } }
		public static Chord Fmaj6 { get { return new Chord(MidiPitch.F0, ChordQuality.Major, ChordAdded.Six); } }
		public static Chord G7F { get { return new Chord(MidiPitch.G0, ChordQuality.NotSpecified, ChordAdded.Seven, MidiPitch.F0); } }
		public static Chord Gmaj6 { get { return new Chord(MidiPitch.G0, ChordQuality.Major, ChordAdded.Six); } }
		public static Chord A { get { return new Chord(MidiPitch.A0); } }
		public static Chord A7 { get { return new Chord(MidiPitch.A0, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord bdim { get { return new Chord(MidiPitch.B0, ChordQuality.Diminished); } }
		public static Chord C7 { get { return new Chord(MidiPitch.C0, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord Cmaj6 { get { return new Chord(MidiPitch.C0, ChordQuality.Major, ChordAdded.Six); } }
		public static Chord dmA { get { return new Chord(MidiPitch.D0, ChordQuality.Minor, ChordAdded.None, MidiPitch.A0); } }
		public static Chord dm7C { get { return new Chord(MidiPitch.D0, ChordQuality.Minor, ChordAdded.Seven, MidiPitch.C0); } }
		public static Chord B { get { return new Chord(MidiPitch.B0); } }
		public static Chord bm { get { return new Chord(MidiPitch.B0, ChordQuality.Minor); } }
		public static Chord Cmaj7B { get { return new Chord(MidiPitch.C0, ChordQuality.Major, ChordAdded.Seven, MidiPitch.B0); } }
		public static Chord EB { get { return new Chord(MidiPitch.E0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.B0); } }
		public static Chord F7 { get { return new Chord(MidiPitch.F0, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord gm { get { return new Chord(MidiPitch.G0, ChordQuality.Minor); } }
		public static Chord FC { get { return new Chord(MidiPitch.F0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.C0); } }
		public static Chord EAb { get { return new Chord(MidiPitch.E0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.GSharp0); } }
		public static Chord Fmaj7E { get { return new Chord(MidiPitch.D0, ChordQuality.Major, ChordAdded.Seven, MidiPitch.E0); } }
		public static Chord gm7 { get { return new Chord(MidiPitch.G0, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord cm { get { return new Chord(MidiPitch.C0, ChordQuality.Minor); } }
		public static Chord fdim { get { return new Chord(MidiPitch.F0, ChordQuality.Diminished); } }
		public static Chord gdim { get { return new Chord(MidiPitch.G0, ChordQuality.Diminished); } }
		public static Chord gdimB { get { return new Chord(MidiPitch.G0, ChordQuality.Diminished, ChordAdded.None, MidiPitch.B0); } }
		public static Chord DGb { get { return new Chord(MidiPitch.D0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.FSharp0); } }
		public static Chord AE { get { return new Chord(MidiPitch.A0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.E0); } }
		public static Chord EmG { get { return new Chord(MidiPitch.E0, ChordQuality.Minor, ChordAdded.None, MidiPitch.G0); } }
		public static Chord BbF { get { return new Chord(MidiPitch.ASharp0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.F0); } }
		public static Chord C7Bb { get { return new Chord(MidiPitch.C0, ChordQuality.NotSpecified, ChordAdded.Seven, MidiPitch.ASharp0); } }
		public static Chord DF { get { return new Chord(MidiPitch.D0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.F0); } }
		public static Chord C7E { get { return new Chord(MidiPitch.C0, ChordQuality.NotSpecified, ChordAdded.Seven, MidiPitch.E0); } }
		public static Chord G7D { get { return new Chord(MidiPitch.G0, ChordQuality.NotSpecified, ChordAdded.Seven, MidiPitch.D0); } }
		public static Chord Cmaj7G { get { return new Chord(MidiPitch.C0, ChordQuality.Major, ChordAdded.Seven, MidiPitch.G0); } }
		public static Chord E7Ab { get { return new Chord(MidiPitch.E0, ChordQuality.NotSpecified, ChordAdded.Seven, MidiPitch.GSharp0); } }
		public static Chord bm7 { get { return new Chord(MidiPitch.B0, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord BD { get { return new Chord(MidiPitch.B0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.D0); } }
		public static Chord Cmaj7E { get { return new Chord(MidiPitch.C0, ChordQuality.Major, ChordAdded.Seven, MidiPitch.E0); } }
		public static Chord Emaj7 { get { return new Chord(MidiPitch.E0, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord abdim { get { return new Chord(MidiPitch.GSharp0, ChordQuality.Diminished); } }
		public static Chord fmAb { get { return new Chord(MidiPitch.F0, ChordQuality.Minor, ChordAdded.None, MidiPitch.GSharp0); } }
		public static Chord gmD { get { return new Chord(MidiPitch.G0, ChordQuality.Minor, ChordAdded.None, MidiPitch.D0); } }
		public static Chord Db { get { return new Chord(MidiPitch.CSharp0); } }
		public static Chord em7D { get { return new Chord(MidiPitch.E0, ChordQuality.Minor, ChordAdded.Seven, MidiPitch.D0); } }
		public static Chord E7D { get { return new Chord(MidiPitch.E0, ChordQuality.NotSpecified, ChordAdded.Seven, MidiPitch.D0); } }
		public static Chord edim { get { return new Chord(MidiPitch.E0, ChordQuality.Diminished); } }
		public static Chord am7E { get { return new Chord(MidiPitch.A0, ChordQuality.Minor, ChordAdded.Seven, MidiPitch.E0); } }
		public static Chord gbdim { get { return new Chord(MidiPitch.FSharp0, ChordQuality.Diminished); } }
		public static Chord BbD { get { return new Chord(MidiPitch.ASharp0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.D0); } }
		public static Chord Bb7 { get { return new Chord(MidiPitch.ASharp0, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord Bbmaj6 { get { return new Chord(MidiPitch.ASharp0, ChordQuality.Major, ChordAdded.Six); } }
		public static Chord cdimE { get { return new Chord(MidiPitch.C0, ChordQuality.Diminished, ChordAdded.None, MidiPitch.E0); } }
		public static Chord C7B { get { return new Chord(MidiPitch.C0, ChordQuality.NotSpecified, ChordAdded.Seven, MidiPitch.B0); } }
		public static Chord adim { get { return new Chord(MidiPitch.A0, ChordQuality.Diminished); } }
		public static Chord cmEb { get { return new Chord(MidiPitch.C0, ChordQuality.Minor, ChordAdded.None, MidiPitch.DSharp0); } }
		public static Chord Abmaj7 { get { return new Chord(MidiPitch.GSharp0, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord G7B { get { return new Chord(MidiPitch.G0, ChordQuality.NotSpecified, ChordAdded.Seven, MidiPitch.B0); } }
		public static Chord D7Gb { get { return new Chord(MidiPitch.D0, ChordQuality.NotSpecified, ChordAdded.Seven, MidiPitch.FSharp0); } }
		public static Chord C7G { get { return new Chord(MidiPitch.C0, ChordQuality.NotSpecified, ChordAdded.Seven, MidiPitch.G0); } }
		public static Chord cmG { get { return new Chord(MidiPitch.C0, ChordQuality.Minor, ChordAdded.None, MidiPitch.G0); } }
		public static Chord D7F { get { return new Chord(MidiPitch.D0, ChordQuality.NotSpecified, ChordAdded.Seven, MidiPitch.F0); } }
		public static Chord D7C { get { return new Chord(MidiPitch.D0, ChordQuality.NotSpecified, ChordAdded.Seven, MidiPitch.C0); } }
		public static Chord Fmaj7C { get { return new Chord(MidiPitch.F0, ChordQuality.Major, ChordAdded.Seven, MidiPitch.C0); } }
		public static Chord em7B { get { return new Chord(MidiPitch.E0, ChordQuality.Minor, ChordAdded.Seven, MidiPitch.B0); } }
		public static Chord ebm7 { get { return new Chord(MidiPitch.DSharp0, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord ADb { get { return new Chord(MidiPitch.A0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.CSharp0); } }
		public static Chord Bmaj7 { get { return new Chord(MidiPitch.B0, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord gbm7 { get { return new Chord(MidiPitch.FSharp0, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord E7B { get { return new Chord(MidiPitch.E0, ChordQuality.NotSpecified, ChordAdded.Seven, MidiPitch.B0); } }
		public static Chord D7A { get { return new Chord(MidiPitch.D0, ChordQuality.NotSpecified, ChordAdded.Seven, MidiPitch.A0); } }
		public static Chord dbdim { get { return new Chord(MidiPitch.CSharp0, ChordQuality.Diminished); } }
		public static Chord fm6 { get { return new Chord(MidiPitch.F0, ChordQuality.Minor, ChordAdded.Six); } }
		public static Chord Ebmaj7 { get { return new Chord(MidiPitch.DSharp0, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord Gb { get { return new Chord(MidiPitch.ASharp0); } }
		public static Chord DA { get { return new Chord(MidiPitch.D0, ChordQuality.NotSpecified, ChordAdded.None, MidiPitch.A0); } }
		public static Chord ebm { get { return new Chord(MidiPitch.DSharp0, ChordQuality.Minor); } }
		public static Chord B7 { get { return new Chord(MidiPitch.B0, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord ebdim { get { return new Chord(MidiPitch.DSharp0, ChordQuality.Diminished); } }
		public static Chord abm7 { get { return new Chord(MidiPitch.GSharp0, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord gmBb { get { return new Chord(MidiPitch.G0, ChordQuality.Minor, ChordAdded.None, MidiPitch.ASharp0); } }
		public static Chord bdimD { get { return new Chord(MidiPitch.B0, ChordQuality.Diminished, ChordAdded.None, MidiPitch.D0); } }
	}
}
