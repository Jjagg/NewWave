using System.Collections.Generic;
using NewWave.Library.Chords;

namespace NewWave.Generator.ChordProgressions
{
	// http://www.hooktheory.com/trends
	internal static class ChordProgressionLibrary
	{
		internal static List<MarkovChainNode<Chord>> Chain
		{
			get
			{
				return new List<MarkovChainNode<Chord>>
				{
					new MarkovChainNode<Chord>(ChordPresets.C, 0.15, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.G, 0.25, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.am, 0.34, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, .78)
								}),
								new MarkovChainNode<Chord>(ChordPresets.Ab, 0.01),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.01),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.66),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.01),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05),
								new MarkovChainNode<Chord>(ChordPresets.E7, 0.007),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.007),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.02),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.06)
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
							new MarkovChainNode<Chord>(ChordPresets.C, 0.14),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.10),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.02),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.007),
							new MarkovChainNode<Chord>(ChordPresets.E, 0.007),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.02),
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.008),
							new MarkovChainNode<Chord>(ChordPresets.D, 0.01),
							new MarkovChainNode<Chord>(ChordPresets.GB, 0.008),
							new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02),
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.19, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.32),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.12),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.30),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05)
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.1, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.11),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.23),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.32),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.08),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.09)
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.13),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.10),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.13),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.17),
							new MarkovChainNode<Chord>(ChordPresets.CE, 0.06)
						}),
						new MarkovChainNode<Chord>(ChordPresets.GB, 0.05, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.07),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.07),
							new MarkovChainNode<Chord>(ChordPresets.FA, 0.07),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.08)
						}),
					}),
					new MarkovChainNode<Chord>(ChordPresets.F, 0.15, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.G, 0.29, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.28),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.36),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05)
						}),
						new MarkovChainNode<Chord>(ChordPresets.C, 0.29, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.11),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.44),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.16),
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.1, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.17),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.45),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.14),
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.11),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.10),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.20),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
							new MarkovChainNode<Chord>(ChordPresets.E, 0.08),
						}),
					}),
					new MarkovChainNode<Chord>(ChordPresets.am, 0.14, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.C, .11, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, .09),
							new MarkovChainNode<Chord>(ChordPresets.am, .10),
							new MarkovChainNode<Chord>(ChordPresets.G, .31),
							new MarkovChainNode<Chord>(ChordPresets.em, .06),
							new MarkovChainNode<Chord>(ChordPresets.F, .28)
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, .06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, .14),
							new MarkovChainNode<Chord>(ChordPresets.am, .18),
							new MarkovChainNode<Chord>(ChordPresets.G, .27),
							new MarkovChainNode<Chord>(ChordPresets.em, .07),
							new MarkovChainNode<Chord>(ChordPresets.F, .13)
						}),
						new MarkovChainNode<Chord>(ChordPresets.em, .06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, .05),
							new MarkovChainNode<Chord>(ChordPresets.am, .21),
							new MarkovChainNode<Chord>(ChordPresets.G, .12),
							new MarkovChainNode<Chord>(ChordPresets.em, .45),
							new MarkovChainNode<Chord>(ChordPresets.dm, .06)
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, .24, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, .43),
							new MarkovChainNode<Chord>(ChordPresets.am, .05),
							new MarkovChainNode<Chord>(ChordPresets.G, .31),
							new MarkovChainNode<Chord>(ChordPresets.dm, .06),
						}),
						new MarkovChainNode<Chord>(ChordPresets.G, .2, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, .17),
							new MarkovChainNode<Chord>(ChordPresets.dm, .06),
							new MarkovChainNode<Chord>(ChordPresets.am, .15),
							new MarkovChainNode<Chord>(ChordPresets.F, .43),
							new MarkovChainNode<Chord>(ChordPresets.em, .05)
						})
					}),
					new MarkovChainNode<Chord>(ChordPresets.G, 0.14, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.C, .21, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, .06),
							new MarkovChainNode<Chord>(ChordPresets.GB, .05),
							new MarkovChainNode<Chord>(ChordPresets.am, .13),
							new MarkovChainNode<Chord>(ChordPresets.F, .29),
							new MarkovChainNode<Chord>(ChordPresets.G, .19)
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, .06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, .15),
							new MarkovChainNode<Chord>(ChordPresets.am, .22),
							new MarkovChainNode<Chord>(ChordPresets.G, .1),
							new MarkovChainNode<Chord>(ChordPresets.em, .07),
							new MarkovChainNode<Chord>(ChordPresets.F, .34)
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, .21, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, .3),
							new MarkovChainNode<Chord>(ChordPresets.am, .13),
							new MarkovChainNode<Chord>(ChordPresets.G, .28),
							new MarkovChainNode<Chord>(ChordPresets.em, .07),
							new MarkovChainNode<Chord>(ChordPresets.dm, .05)
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, .26, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, .11),
							new MarkovChainNode<Chord>(ChordPresets.G, .2),
							new MarkovChainNode<Chord>(ChordPresets.em, .07),
							new MarkovChainNode<Chord>(ChordPresets.F, .36)
						})
					}),
					new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
					new MarkovChainNode<Chord>(ChordPresets.em, 0.03),
					new MarkovChainNode<Chord>(ChordPresets.am7, 0.02),
					new MarkovChainNode<Chord>(ChordPresets.CE, 0.02),
					new MarkovChainNode<Chord>(ChordPresets.dm7, 0.02),
					new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.02),
					new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01),
					new MarkovChainNode<Chord>(ChordPresets.CG, 0.01),
					new MarkovChainNode<Chord>(ChordPresets.E, 0.01),
					new MarkovChainNode<Chord>(ChordPresets.em7, 0.01),
					new MarkovChainNode<Chord>(ChordPresets.GB, 0.01),
					new MarkovChainNode<Chord>(ChordPresets.G7, 0.01),
					new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.008),
					new MarkovChainNode<Chord>(ChordPresets.amE, 0.007),
					new MarkovChainNode<Chord>(ChordPresets.D, 0.007),
				};
			}
		}
	}
}
