using NewWave.Midi;

namespace NewWave.Library.Chords
{
	public static class ChordPresets
	{
		public static Chord C { get { return new Chord(Pitch.C0); } }
		public static Chord F { get { return new Chord(Pitch.F0); } }
		public static Chord am { get { return new Chord(Pitch.A0, ChordQuality.Minor); } }
		public static Chord G { get { return new Chord(Pitch.G0); } }
		public static Chord dm { get { return new Chord(Pitch.D0, ChordQuality.Minor); } }
		public static Chord em { get { return new Chord(Pitch.E0, ChordQuality.Minor); } }
		public static Chord am7 { get { return new Chord(Pitch.A0, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord CE { get { return new Chord(Pitch.C0, ChordQuality.NotSpecified, ChordAdded.None, Pitch.E0); } }
		public static Chord dm7 { get { return new Chord(Pitch.D0, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord Fmaj7 { get { return new Chord(Pitch.D0, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord Bb { get { return new Chord(Pitch.CSharp0); } }
		public static Chord CG { get { return new Chord(Pitch.CSharp0, ChordQuality.NotSpecified, ChordAdded.None, Pitch.G0); } }
		public static Chord E { get { return new Chord(Pitch.E0); } }
		public static Chord em7 { get { return new Chord(Pitch.E0, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord GB { get { return new Chord(Pitch.G0, ChordQuality.NotSpecified, ChordAdded.None, Pitch.B0); } }
		public static Chord G7 { get { return new Chord(Pitch.G0, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord Cmaj7 { get { return new Chord(Pitch.C0, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord amE { get { return new Chord(Pitch.A0, ChordQuality.Minor, ChordAdded.None, Pitch.E0); } }
		public static Chord D { get { return new Chord(Pitch.D0); } }
		public static Chord amC { get { return new Chord(Pitch.A0, ChordQuality.Minor, ChordAdded.None, Pitch.C0); } }
		public static Chord E7 { get { return new Chord(Pitch.E0, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord FA { get { return new Chord(Pitch.F0, ChordQuality.NotSpecified, ChordAdded.None, Pitch.A0); } }
		public static Chord GD { get { return new Chord(Pitch.G0, ChordQuality.NotSpecified, ChordAdded.None, Pitch.D0); } }
		public static Chord am7G { get { return new Chord(Pitch.A0, ChordQuality.Minor, ChordAdded.Seven, Pitch.G0); } }
		public static Chord dmF { get { return new Chord(Pitch.D0, ChordQuality.Minor, ChordAdded.None, Pitch.F0); } }
		public static Chord Eb { get { return new Chord(Pitch.DSharp0); } }
		public static Chord emG { get { return new Chord(Pitch.E0, ChordQuality.Minor, ChordAdded.None, Pitch.G0); } }
		public static Chord Ab { get { return new Chord(Pitch.GSharp0); } }
		public static Chord D7 { get { return new Chord(Pitch.GSharp0); } }
		public static Chord emB { get { return new Chord(Pitch.E0, ChordQuality.Minor, ChordAdded.None, Pitch.B0); } }
		public static Chord fm { get { return new Chord(Pitch.F0, ChordQuality.Minor); } }
		public static Chord Fmaj6 { get { return new Chord(Pitch.F0, ChordQuality.Major, ChordAdded.Six); } }
		public static Chord G7F { get { return new Chord(Pitch.G0, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.F0); } }
		public static Chord Gmaj6 { get { return new Chord(Pitch.G0, ChordQuality.Major, ChordAdded.Six); } }
		public static Chord A { get { return new Chord(Pitch.A0); } }
		public static Chord A7 { get { return new Chord(Pitch.A0, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord bdim { get { return new Chord(Pitch.B0, ChordQuality.Diminished); } }
		public static Chord C7 { get { return new Chord(Pitch.C0, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord Cmaj6 { get { return new Chord(Pitch.C0, ChordQuality.Major, ChordAdded.Six); } }
		public static Chord dmA { get { return new Chord(Pitch.D0, ChordQuality.Minor, ChordAdded.None, Pitch.A0); } }
		public static Chord dm7C { get { return new Chord(Pitch.D0, ChordQuality.Minor, ChordAdded.Seven, Pitch.C0); } }
		public static Chord B { get { return new Chord(Pitch.B0); } }
		public static Chord bm { get { return new Chord(Pitch.B0, ChordQuality.Minor); } }
		public static Chord Cmaj7B { get { return new Chord(Pitch.C0, ChordQuality.Major, ChordAdded.Seven, Pitch.B0); } }
		public static Chord EB { get { return new Chord(Pitch.E0, ChordQuality.NotSpecified, ChordAdded.None, Pitch.B0); } }
		public static Chord F7 { get { return new Chord(Pitch.F0, ChordQuality.NotSpecified, ChordAdded.Seven); } }
		public static Chord gm { get { return new Chord(Pitch.G0, ChordQuality.Minor); } }
		public static Chord FC { get { return new Chord(Pitch.F0, ChordQuality.NotSpecified, ChordAdded.None, Pitch.C0); } }
		public static Chord EAb { get { return new Chord(Pitch.E0, ChordQuality.NotSpecified, ChordAdded.None, Pitch.GSharp0); } }
		public static Chord Fmaj7E { get { return new Chord(Pitch.D0, ChordQuality.Major, ChordAdded.Seven, Pitch.E0); } }
		public static Chord gm7 { get { return new Chord(Pitch.G0, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord cm { get { return new Chord(Pitch.C0, ChordQuality.Minor); } }
		public static Chord fdim { get { return new Chord(Pitch.F0, ChordQuality.Diminished); } }
		public static Chord gdim { get { return new Chord(Pitch.G0, ChordQuality.Diminished); } }
		public static Chord gdimB { get { return new Chord(Pitch.G0, ChordQuality.Diminished, ChordAdded.None, Pitch.B0); } }
		public static Chord DGb { get { return new Chord(Pitch.D0, ChordQuality.NotSpecified, ChordAdded.None, Pitch.FSharp0); } }
		public static Chord AE { get { return new Chord(Pitch.A0, ChordQuality.NotSpecified, ChordAdded.None, Pitch.E0); } }
		public static Chord EmG { get { return new Chord(Pitch.E0, ChordQuality.Minor, ChordAdded.None, Pitch.G0); } }
		public static Chord BbF { get { return new Chord(Pitch.ASharp0, ChordQuality.NotSpecified, ChordAdded.None, Pitch.F0); } }
		public static Chord C7Bb { get { return new Chord(Pitch.C0, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.ASharp0); } }
		public static Chord DF { get { return new Chord(Pitch.D0, ChordQuality.NotSpecified, ChordAdded.None, Pitch.F0); } }
		public static Chord C7E { get { return new Chord(Pitch.C0, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.E0); } }
		public static Chord G7D { get { return new Chord(Pitch.G0, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.D0); } }
		public static Chord Cmaj7G { get { return new Chord(Pitch.C0, ChordQuality.Major, ChordAdded.Seven, Pitch.G0); } }
		public static Chord E7Ab { get { return new Chord(Pitch.E0, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.GSharp0); } }
		public static Chord bm7 { get { return new Chord(Pitch.B0, ChordQuality.Minor, ChordAdded.Seven); } }
		public static Chord BD { get { return new Chord(Pitch.B0, ChordQuality.NotSpecified, ChordAdded.None, Pitch.D0); } }
		public static Chord Cmaj7E { get { return new Chord(Pitch.C0, ChordQuality.Major, ChordAdded.Seven, Pitch.E0); } }
		public static Chord Emaj7 { get { return new Chord(Pitch.E0, ChordQuality.Major, ChordAdded.Seven); } }
		public static Chord abdim { get { return new Chord(Pitch.GSharp0, ChordQuality.Diminished); } }
		public static Chord fmAb { get { return new Chord(Pitch.F0, ChordQuality.Minor, ChordAdded.None, Pitch.GSharp0); } }
		public static Chord gmD { get { return new Chord(Pitch.G0, ChordQuality.Minor, ChordAdded.None, Pitch.D0); } }
		public static Chord Db { get { return new Chord(Pitch.CSharp0); } }
		public static Chord em7D { get { return new Chord(Pitch.E0, ChordQuality.Minor, ChordAdded.Seven, Pitch.D0); } }
		public static Chord E7D { get { return new Chord(Pitch.E0, ChordQuality.NotSpecified, ChordAdded.Seven, Pitch.D0); } }
		public static Chord edim { get { return new Chord(Pitch.E0, ChordQuality.Diminished); } }
		public static Chord am7E { get { return new Chord(Pitch.A0, ChordQuality.Minor, ChordAdded.Seven, Pitch.E0); } }
		public static Chord gbdim { get { return new Chord(Pitch.FSharp0, ChordQuality.Diminished); } }
	}
}
