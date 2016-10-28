using System.Collections.Generic;
using NewWave.Core;

namespace NewWave.Library.Grooves
{
    public static class GrooveLibrary
    {
        private static readonly List<Groove> Grooves = new List<Groove>
		{
			new Groove("simple rock", TimeSignature.CommonTime, 4, 2, new List<int> { 4, 12 }, new List<int> { 0, 8 }),
			new Groove("fast rock", TimeSignature.CommonTime, 4, 2, new List<int> { 2, 6, 10, 14 }, new List<int> { 0, 4, 8, 12 }),
			new Groove("simple punk", TimeSignature.CommonTime, 4, 2, new List<int> { 4, 12 }, new List<int> { 0, 6, 10 }),
			new Groove("funky", TimeSignature.CommonTime, 4, 2, new List<int> { 4, 12 }, new List<int> { 0, 2, 7, 9, 11 }),
			new Groove("backward rock", TimeSignature.CommonTime, 4, 2, new List<int> { 0, 4, 8, 12 }, new List<int> { 2, 6, 10, 14 }),
			new Groove("fake triplet", TimeSignature.CommonTime, 4, 2, new List<int> { 8, 14, 15 }, new List<int> { 0, 3, 6 }),
            new Groove("blast", TimeSignature.CommonTime, 4, 2, new List<int> { 1,3,5,7,9,11,13,15 }, new List<int> { 0, 2,4,6,8,10,12,14 }),
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
