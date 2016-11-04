using System.Collections.Generic;
using NewWave.Core;

namespace NewWave.Library.Grooves
{
    public static class GrooveLibrary
    {
        private static readonly List<Groove> Grooves = new List<Groove>
		{
			new Groove("simple rock", TimeSignature.CommonTime, 4, 2, new List<double> { 0, 2 }, new List<double> { 1, 3 }),
			new Groove("fast rock", TimeSignature.CommonTime, 4, 2, new List<double> { 0, 1, 2, 3 }, new List<double> { 0.5, 1.5, 2.5, 3.5 }),
			new Groove("simple punk", TimeSignature.CommonTime, 4, 2, new List<double> { 0, 1.5, 2.5 }, new List<double> { 1, 3 }),
			new Groove("funky", TimeSignature.CommonTime, 4, 2, new List<double> { 0, 0.5, 1.75, 2.25, 2.75 }, new List<double> { 1, 3 }),
			//new Groove("backward rock", TimeSignature.CommonTime, 4, 2, new List<double> { 0.5, 1.5, 2.5, 3.5 }, new List<double> { 0, 1, 2, 3 }),
			new Groove("fake triplet", TimeSignature.CommonTime, 4, 2, new List<double> { 0, 0.75, 1.5 }, new List<double> { 2, 3.5, 3.75 }),
			new Groove("blastbeat", TimeSignature.CommonTime, 4, 2, new List<double> { 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5 }, new List<double> { 0.25, 0.75, 1.25, 1.75, 2.25, 2.75, 3.25, 3.75 }),
		};

        public static Groove GetGroove()
        {
            return Grooves[0];
        }

        public static List<Groove> AllGrooves
        {
            get { return Grooves; }
        }
    }
}
