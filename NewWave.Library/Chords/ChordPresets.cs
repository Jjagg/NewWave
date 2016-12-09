using NewWave.Library.Pitches;

namespace NewWave.Library.Chords
{
	public static class ChordPresets
	{
		public static Chord C { get { return new Chord(Pitch.C); } }
		public static Chord F { get { return new Chord(Pitch.F); } }
		public static Chord am { get { return new Chord(Pitch.A, ChordQuality.Minor); } }
		public static Chord G { get { return new Chord(Pitch.G); } }
		public static Chord dm { get { return new Chord(Pitch.D, ChordQuality.Minor); } }
		public static Chord em { get { return new Chord(Pitch.E, ChordQuality.Minor); } }
		public static Chord am7 { get { return new Chord(Pitch.A, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord CE { get { return new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.None, Pitch.E); } }
		public static Chord dm7 { get { return new Chord(Pitch.D, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord Fmaj7 { get { return new Chord(Pitch.F, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord Bb { get { return new Chord(Pitch.CSharp); } }
		public static Chord CG { get { return new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.None, Pitch.G); } }
		public static Chord E { get { return new Chord(Pitch.E); } }
		public static Chord em7 { get { return new Chord(Pitch.E, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord GB { get { return new Chord(Pitch.G, ChordQuality.NotSpecified, ChordAdded.None, Pitch.B); } }
		public static Chord G7 { get { return new Chord(Pitch.G, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord Cmaj7 { get { return new Chord(Pitch.C, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord amE { get { return new Chord(Pitch.A, ChordQuality.Minor, ChordAdded.None, Pitch.E); } }
		public static Chord D { get { return new Chord(Pitch.D); } }
		public static Chord amC { get { return new Chord(Pitch.A, ChordQuality.Minor, ChordAdded.None, Pitch.C); } }
		public static Chord E7 { get { return new Chord(Pitch.E, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord FA { get { return new Chord(Pitch.F, ChordQuality.NotSpecified, ChordAdded.None, Pitch.A); } }
		public static Chord GD { get { return new Chord(Pitch.G, ChordQuality.NotSpecified, ChordAdded.None, Pitch.D); } }
		public static Chord am7G { get { return new Chord(Pitch.A, ChordQuality.Minor, ChordAdded.Seven, Pitch.G); } }
		public static Chord dmF { get { return new Chord(Pitch.D, ChordQuality.Minor, ChordAdded.None, Pitch.F); } }
		public static Chord Eb { get { return new Chord(Pitch.DSharp); } }
		public static Chord emG { get { return new Chord(Pitch.E, ChordQuality.Minor, ChordAdded.None, Pitch.G); } }
		public static Chord Ab { get { return new Chord(Pitch.GSharp); } }
		public static Chord D7 { get { return new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord emB { get { return new Chord(Pitch.E, ChordQuality.Minor, ChordAdded.None, Pitch.B); } }
		public static Chord fm { get { return new Chord(Pitch.F, ChordQuality.Minor); } }
		public static Chord Fmaj6 { get { return new Chord(Pitch.F, ChordQuality.Major, ChordAdded.Six); } }
		public static Chord G7F { get { return new Chord(Pitch.G, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.F); } }
		public static Chord Gmaj6 { get { return new Chord(Pitch.G, ChordQuality.Major, ChordAdded.Six); } }
		public static Chord A { get { return new Chord(Pitch.A); } }
		public static Chord A7 { get { return new Chord(Pitch.A, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord bdim { get { return new Chord(Pitch.B, ChordQuality.Diminished); } }
		public static Chord C7 { get { return new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord Cmaj6 { get { return new Chord(Pitch.C, ChordQuality.Major, ChordAdded.Six); } }
		public static Chord dmA { get { return new Chord(Pitch.D, ChordQuality.Minor, ChordAdded.None, Pitch.A); } }
		public static Chord dm7C { get { return new Chord(Pitch.D, ChordQuality.Minor, ChordAdded.Seven, Pitch.C); } }
		public static Chord B { get { return new Chord(Pitch.B); } }
		public static Chord bm { get { return new Chord(Pitch.B, ChordQuality.Minor); } }
		public static Chord Cmaj7B { get { return new Chord(Pitch.C, ChordQuality.Major, ChordAdded.Seven, Pitch.B); } }
		public static Chord EB { get { return new Chord(Pitch.E, ChordQuality.NotSpecified, ChordAdded.None, Pitch.B); } }
		public static Chord F7 { get { return new Chord(Pitch.F, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord gm { get { return new Chord(Pitch.G, ChordQuality.Minor); } }
		public static Chord FC { get { return new Chord(Pitch.F, ChordQuality.NotSpecified, ChordAdded.None, Pitch.C); } }
		public static Chord EAb { get { return new Chord(Pitch.E, ChordQuality.NotSpecified, ChordAdded.None, Pitch.GSharp); } }
		public static Chord Fmaj7E { get { return new Chord(Pitch.F, ChordQuality.Major, ChordAdded.Seven, Pitch.E); } }
		public static Chord gm7 { get { return new Chord(Pitch.G, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord cm { get { return new Chord(Pitch.C, ChordQuality.Minor); } }
		public static Chord fdim { get { return new Chord(Pitch.F, ChordQuality.Diminished); } }
		public static Chord gdim { get { return new Chord(Pitch.G, ChordQuality.Diminished); } }
		public static Chord gdimB { get { return new Chord(Pitch.G, ChordQuality.Diminished, ChordAdded.None, Pitch.B); } }
		public static Chord DGb { get { return new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.None, Pitch.FSharp); } }
		public static Chord AE { get { return new Chord(Pitch.A, ChordQuality.NotSpecified, ChordAdded.None, Pitch.E); } }
		public static Chord EmG { get { return new Chord(Pitch.E, ChordQuality.Minor, ChordAdded.None, Pitch.G); } }
		public static Chord BbF { get { return new Chord(Pitch.ASharp, ChordQuality.NotSpecified, ChordAdded.None, Pitch.F); } }
		public static Chord C7Bb { get { return new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.ASharp); } }
		public static Chord DF { get { return new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.None, Pitch.F); } }
		public static Chord C7E { get { return new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.E); } }
		public static Chord G7D { get { return new Chord(Pitch.G, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.D); } }
		public static Chord Cmaj7G { get { return new Chord(Pitch.C, ChordQuality.Major, ChordAdded.Seven, Pitch.G); } }
		public static Chord E7Ab { get { return new Chord(Pitch.E, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.GSharp); } }
		public static Chord bm7 { get { return new Chord(Pitch.B, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord BD { get { return new Chord(Pitch.B, ChordQuality.NotSpecified, ChordAdded.None, Pitch.D); } }
		public static Chord Cmaj7E { get { return new Chord(Pitch.C, ChordQuality.Major, ChordAdded.Seven, Pitch.E); } }
		public static Chord Emaj7 { get { return new Chord(Pitch.E, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord abdim { get { return new Chord(Pitch.GSharp, ChordQuality.Diminished); } }
		public static Chord fmAb { get { return new Chord(Pitch.F, ChordQuality.Minor, ChordAdded.None, Pitch.GSharp); } }
		public static Chord gmD { get { return new Chord(Pitch.G, ChordQuality.Minor, ChordAdded.None, Pitch.D); } }
		public static Chord Db { get { return new Chord(Pitch.CSharp); } }
		public static Chord em7D { get { return new Chord(Pitch.E, ChordQuality.Minor, ChordAdded.Seven, Pitch.D); } }
		public static Chord E7D { get { return new Chord(Pitch.E, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.D); } }
		public static Chord edim { get { return new Chord(Pitch.E, ChordQuality.Diminished); } }
		public static Chord am7E { get { return new Chord(Pitch.A, ChordQuality.Minor, ChordAdded.Seven, Pitch.E); } }
		public static Chord gbdim { get { return new Chord(Pitch.FSharp, ChordQuality.Diminished); } }
		public static Chord BbD { get { return new Chord(Pitch.ASharp, ChordQuality.NotSpecified, ChordAdded.None, Pitch.D); } }
		public static Chord Bb7 { get { return new Chord(Pitch.ASharp, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord Bbmaj6 { get { return new Chord(Pitch.ASharp, ChordQuality.Major, ChordAdded.Six); } }
		public static Chord cdimE { get { return new Chord(Pitch.C, ChordQuality.Diminished, ChordAdded.None, Pitch.E); } }
		public static Chord C7B { get { return new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.B); } }
		public static Chord adim { get { return new Chord(Pitch.A, ChordQuality.Diminished); } }
		public static Chord cmEb { get { return new Chord(Pitch.C, ChordQuality.Minor, ChordAdded.None, Pitch.DSharp); } }
		public static Chord Abmaj7 { get { return new Chord(Pitch.GSharp, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord G7B { get { return new Chord(Pitch.G, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.B); } }
		public static Chord D7Gb { get { return new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.FSharp); } }
		public static Chord C7G { get { return new Chord(Pitch.C, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.G); } }
		public static Chord cmG { get { return new Chord(Pitch.C, ChordQuality.Minor, ChordAdded.None, Pitch.G); } }
		public static Chord D7F { get { return new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.F); } }
		public static Chord D7C { get { return new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.C); } }
		public static Chord Fmaj7C { get { return new Chord(Pitch.F, ChordQuality.Major, ChordAdded.Seven, Pitch.C); } }
		public static Chord em7B { get { return new Chord(Pitch.E, ChordQuality.Minor, ChordAdded.Seven, Pitch.B); } }
		public static Chord ebm7 { get { return new Chord(Pitch.DSharp, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord ADb { get { return new Chord(Pitch.A, ChordQuality.NotSpecified, ChordAdded.None, Pitch.CSharp); } }
		public static Chord Bmaj7 { get { return new Chord(Pitch.B, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord gbm7 { get { return new Chord(Pitch.FSharp, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord E7B { get { return new Chord(Pitch.E, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.B); } }
		public static Chord D7A { get { return new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.A); } }
		public static Chord dbdim { get { return new Chord(Pitch.CSharp, ChordQuality.Diminished); } }
		public static Chord fm6 { get { return new Chord(Pitch.F, ChordQuality.Minor, ChordAdded.Six); } }
		public static Chord Ebmaj7 { get { return new Chord(Pitch.DSharp, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord Gb { get { return new Chord(Pitch.ASharp); } }
		public static Chord DA { get { return new Chord(Pitch.D, ChordQuality.NotSpecified, ChordAdded.None, Pitch.A); } }
		public static Chord ebm { get { return new Chord(Pitch.DSharp, ChordQuality.Minor); } }
		public static Chord B7 { get { return new Chord(Pitch.B, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord ebdim { get { return new Chord(Pitch.DSharp, ChordQuality.Diminished); } }
		public static Chord abm7 { get { return new Chord(Pitch.GSharp, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord gmBb { get { return new Chord(Pitch.G, ChordQuality.Minor, ChordAdded.None, Pitch.ASharp); } }
		public static Chord bdimD { get { return new Chord(Pitch.B, ChordQuality.Diminished, ChordAdded.None, Pitch.D); } }
	}
}
