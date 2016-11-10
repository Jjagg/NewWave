using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator.Grooves;
using NewWave.Midi;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class FillTests
	{
		[TestMethod]
		public void GetFill()
		{
			const double lengthInBeats = 4.0;
			WriteAsTab(FillGenerator.GetFill(0, lengthInBeats).ToList(), lengthInBeats);
		}

		private static void WriteAsTab(List<PercussionNote> notes, double lengthInBeats)
		{
			var voices = notes.Select(n => n.Percussion).Distinct();
			const int spacesPerBeat = 4;
			var tabLength = (int)(lengthInBeats * spacesPerBeat);

			foreach (var percussion in voices)
			{
				var theseNotes = notes.Where(n => n.Percussion == percussion);
				var thisCode = PercussionCode(percussion);

				Console.WriteLine("{0}|{1}",
					thisCode.PadRight(2, ' '),
					string.Join("",
					Enumerable.Range(0, tabLength).Select(i => theseNotes.Any(n => n.Start * spacesPerBeat == i) ? "X" : "-")));
			}
		}

		private static string PercussionCode(Percussion p)
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
