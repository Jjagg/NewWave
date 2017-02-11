using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewWave.Core;

namespace NewWave.Midi
{
    public static class TabWriter
    {
        public static string AsTab(int feel, List<PercussionNote> notes, int lengthInBeats)
        {
            var sb = new StringBuilder();

            var voices = notes.Select(n => n.PercussionId).Distinct().OrderBy(SortValue);
            var spacesPerBeat = feel;
            var tabLength = lengthInBeats * spacesPerBeat;

            foreach (var percussionId in voices)
            {
                var percussion = (Percussion) percussionId;
                var theseNotes = notes.Where(n => n.PercussionId == percussionId);
                var thisCode = percussion.ToCode();

                sb.AppendLine(string.Format("{0}|{1}|",
                    thisCode.PadRight(2, ' '),
                    string.Join("", Enumerable.Range(0, tabLength)
                            .Select(i => theseNotes.Any(n => n.Start * spacesPerBeat == i) ? percussion.ToSymbol() : "-"))));
            }

            return sb.ToString();
        }

        private static int SortValue(int p)
        {
            switch ((Percussion) p)
            {
                case Percussion.CrashCymbal1:
                case Percussion.CrashCymbal2:
                    return 1;

                case Percussion.RideCymbal1:
                case Percussion.RideCymbal2:
                    return 2;

                case Percussion.ClosedHiHat:
                case Percussion.OpenHiHat:
                case Percussion.PedalHiHat:
                    return 3;

                case Percussion.HighTom1:
                case Percussion.HighTom2:
                    return 4;

                case Percussion.MidTom1:
                case Percussion.MidTom2:
                    return 5;

                case Percussion.LowTom1:
                case Percussion.LowTom2:
                    return 6;

                case Percussion.SnareDrum1:
                case Percussion.SnareDrum2:
                    return 7;

                case Percussion.BassDrum1:
                case Percussion.BassDrum2:
                    return 8;
            }

            return 100;
        }
    }

    internal static class PercussionExtensions
    {
        public static string ToSymbol(this Percussion p)
        {
            switch (p)
            {
                case Percussion.BassDrum1:
                case Percussion.BassDrum2:
                case Percussion.SnareDrum1:
                case Percussion.SnareDrum2:
                case Percussion.HighTom1:
                case Percussion.HighTom2:
                case Percussion.MidTom1:
                case Percussion.MidTom2:
                case Percussion.LowTom1:
                case Percussion.LowTom2:
                case Percussion.OpenHiHat:
                    return "o";
                case Percussion.CrashCymbal1:
                case Percussion.CrashCymbal2:
                case Percussion.RideCymbal1:
                case Percussion.RideCymbal2:
                case Percussion.ClosedHiHat:
                    return "x";
            }

            return "?";
        }

        public static string ToCode(this Percussion p)
        {
            switch (p)
            {
                case Percussion.BassDrum1:
                case Percussion.BassDrum2:
                    return "B";
                case Percussion.SnareDrum1:
                case Percussion.SnareDrum2:
                    return "S";
                case Percussion.CrashCymbal1:
                case Percussion.CrashCymbal2:
                    return "C";
                case Percussion.RideCymbal1:
                case Percussion.RideCymbal2:
                    return "R";
                case Percussion.ClosedHiHat:
                case Percussion.OpenHiHat:
                case Percussion.PedalHiHat:
                    return "H";
                case Percussion.HighTom1:
                case Percussion.HighTom2:
                    return "Th";
                case Percussion.MidTom1:
                case Percussion.MidTom2:
                    return "Tm";
                case Percussion.LowTom1:
                case Percussion.LowTom2:
                    return "Tl";
            }

            return "?";
        }
    }
}
