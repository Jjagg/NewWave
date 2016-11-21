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
									new MarkovChainNode<Chord>(ChordPresets.C, 0.78, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.69),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.23),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.08)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.cm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.gm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Ab, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.38, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.54, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.gm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.fdim, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.26, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.78),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.06)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.004),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.19),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.65)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.46, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.amE, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.65),
									}),
									new MarkovChainNode<Chord>(ChordPresets.gdim, 0.008, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.008, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1),
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.69, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.83),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.66, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.009, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.29)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EB, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.26),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.61)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.007, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.38),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.83, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.93),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.007)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.83)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.gdimB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.61, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.36),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.45)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.4)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.64, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.23),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75),
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E7, 0.007, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.007, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.44, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.13)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.19, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.44, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.006),
									new MarkovChainNode<Chord>(ChordPresets.emB, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.71, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.76),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.78),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.DGb, 0.11)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.25, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.74, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.B, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.B, 0.05)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bdim, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.16, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.44),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.44)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.71),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.AE, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.007, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.93),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.42, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.58, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.57),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.43)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.2, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.32),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.23),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.35)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.16),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.26),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.47)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.A7, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.65, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.86),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.009),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.018),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.009),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.009),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.02)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dmF, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EmG, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.78, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.A, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.3),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.02),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.36, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.3),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dmA, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.02),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dmA, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.38, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E7, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7C, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.71),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.14)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.48, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.4)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.007, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.19),
										new MarkovChainNode<Chord>(ChordPresets.emB, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.38),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.19),
										new MarkovChainNode<Chord>(ChordPresets.A, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.D7, 0.06)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.8, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.006),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.81),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.006),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.19),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.65)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.008, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.fm, 0.29)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.C, 0.14, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.77, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Eb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.BbF, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.35, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.71)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E7, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.57, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.39, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.C7Bb, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.DGb, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.32),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.21)
									}),
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.DF, 0.33) // Listed as "D/F?"
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.23),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.65)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.008, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.54, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.77),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.C7E, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.G7D, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.35, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dmA, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.008, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.19),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.12),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj6, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.62)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Cmaj6, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.68, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bdim, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.76),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.008)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.41, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.52, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.86)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.0, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.83, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.8),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.fdim, 0.2) // Listed as "f?°"
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.A, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.26, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.35, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.10, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.19, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.8),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7G, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.78, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.79),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.02),
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.26, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E7Ab, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7G, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.38),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.54)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.amE, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.83)
									}),
									new MarkovChainNode<Chord>(ChordPresets.BD, 0.02, new List<MarkovChainNode<Chord>>
									{ // Listed as "B/D?"
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.63, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emB, 0.01)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.46, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.amE, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.85, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.007),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.007),
										new MarkovChainNode<Chord>(ChordPresets.gm, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.91),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.007),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.007),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.01)
									}),
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.02, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.14, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.63, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.6)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.76, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.83, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.86),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.03)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.007, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.18, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Emaj7, 0.01), // Listed as "E?maj7"
								new MarkovChainNode<Chord>(ChordPresets.D, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.abdim, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.53, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.93, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.92),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.E, 0.007, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.65, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7G, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.36, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.83),
										new MarkovChainNode<Chord>(ChordPresets.DGb, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.03),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.DF, 1) // Listed as "D/F?"
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.27, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.43, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.57, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.02, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.3, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bm, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.59, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.86, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.14)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.32, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.62, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.91),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.09)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D7, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.6, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.008, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.FA, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.fmAb, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Gmaj6, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.13, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.fmAb, 0.25),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Gmaj6, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.34, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.37, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.42, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.24, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.71, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gm, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.D, 0.01, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.A, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.B, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.cm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.24, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.73, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.71)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.A, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.33)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.D, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em7, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dmF, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2)
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.24, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.91),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.09)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.bm7, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.GB, 0.008, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.01),
								new MarkovChainNode<Chord>(ChordPresets.gmD, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.gm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dmF, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FC, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.EB, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.86, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.96, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.96)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.gm, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.62, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.gm, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.DGb, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.66, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.91),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.04)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Eb, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.8, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.Db, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GD, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em7D, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.19, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.D, 0.05),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.73, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									})
								})
							})
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.19, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.32, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C7, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.57, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.14)
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.35, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.04),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.26, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.01)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Gmaj6, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.01)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.42)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.fm, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.A, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.82),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.12)
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.3, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.008, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bdim, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.54),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.D7, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.01)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.19, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.82)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.008, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.59, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.008),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.008),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.79),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.008),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.008),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.47, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.55),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.27),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.008, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.008, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.A, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.19),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.22),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.47)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.008, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.A, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.008, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.69)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.71, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.007),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.15),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.7),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.007),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.007),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.007),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.007)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.B, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.32, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.007, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E7D, 0.08),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.fm, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.25),
									}),
									new MarkovChainNode<Chord>(ChordPresets.E7, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1),
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.2),
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.02),
									new MarkovChainNode<Chord>(ChordPresets.gm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.edim, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.02),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33),
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1),
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.37, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.D7, 0.33),
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.42, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1),
									}),
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.07),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.E7, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7E, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.01),
									})
								}),
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.12, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.006, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FA, 0.006, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Ab, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.25),
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.55, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.006, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.3)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.006, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.BbF, 0.006),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.3)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.006, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.006, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.71, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.94),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.009),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.009)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.14, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.76, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.92),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.08)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.78, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D7, 0.006, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1),
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.59, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88),
										new MarkovChainNode<Chord>(ChordPresets.bdim, 0.13)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.14, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.86, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.81),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.12),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.04)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67)
									}),
								}),
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.30, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.44, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.44, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.29, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bm, 0.009, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.BbD, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.009, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.DF, 0.05), // Listed as "D/F?"
										new MarkovChainNode<Chord>(ChordPresets.DGb, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.44),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.38)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.56),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.26)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.13)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.47, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.02)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb7, 0.03),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.19, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.47, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.86),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.43)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.14, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.009, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.26, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bbmaj6, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.19),
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.27),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.42)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.009, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.cdimE, 0.33), // Listed as "c*/E?"
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.G7D, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.56, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.86),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.02)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em7, 0.007, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7F, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.A, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am7G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.82, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.007, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.83, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.8),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.A, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.77, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.28),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.56)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.02)
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.B, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.39, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.86)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.42, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.C7B, 0.25) // Listed as "C7/B?"
									}),
									new MarkovChainNode<Chord>(ChordPresets.emB, 0.006, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.A, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.12),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.35),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.12),
										new MarkovChainNode<Chord>(ChordPresets.amE, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.12),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.18)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.48),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.24),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.19)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.74, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.77),
										new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.008),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.009, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C7, 0.006, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.75, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.25)
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.A, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.24, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.73, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.94),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.06)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.adim, 0.008, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CG, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.abdim, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.31, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7F, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.01),
									new MarkovChainNode<Chord>(ChordPresets.cmEb, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Abmaj7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.64, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.91),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.04)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.33)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.71, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.82, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.emG, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GD, 0.008, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.amC, 0.008, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.gdimB, 1, new List<MarkovChainNode<Chord>> // Listed as "g?*/B"
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bdim, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.42, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7C, 0.008, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7C, 1) // Listed as "dm7b5/C"
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.CG, 0.01, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FA, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7B, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.emG, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.71, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.18, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.64, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.35, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.55, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.83),
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.36, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.G7, 0.01, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.14, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.DGb, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7E, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FC, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.72, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.A7, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.fmAb, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.02),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.49, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.D7Gb, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C7G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C7, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj6, 0.5)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.006, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.cdimE, 1, new List<MarkovChainNode<Chord>> // Listed as "c*/E?"
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.72, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.13)
									}),
									new MarkovChainNode<Chord>(ChordPresets.abdim, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EAb, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.17, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.33)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.006, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.17, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.EAb, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7G, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.6),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.4)
								}),
								new MarkovChainNode<Chord>(ChordPresets.fdim, 0.06, new List<MarkovChainNode<Chord>> // Listed as "f?*"
								{
									new MarkovChainNode<Chord>(ChordPresets.cmG, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D7Gb, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.22, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emG, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em7, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.D7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.11, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.03, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.37, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.26, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.83)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.A, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.fm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.6, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
								}),
								new MarkovChainNode<Chord>(ChordPresets.dmF, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.45, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Eb, 0.01),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.59, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb7, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.75, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.em7, 0.007, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gm7, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.25, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.8, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.3, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FA, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.67)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.25, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.02)
							}),
							new MarkovChainNode<Chord>(ChordPresets.E, 0.01, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.gm7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.68, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.61, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.92),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.08)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.33)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.6, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Gmaj6, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.B, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.BD, 1) // Listed as "B/D?"
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.amC, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.CE, 0.04, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7Gb, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.47, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D7F, 0.009, new List<MarkovChainNode<Chord>> // Listed as "D7/F?"
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.B, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.45, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.4)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.cmEb, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D7, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.26, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bdim, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.cm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C7, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67),
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.38, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm7, 0.1), // Listed as "bm7b5"
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.8)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.17, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.3, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.2)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GD, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.6, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7C, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.12, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.68, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.63),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.31)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FC, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.2, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.86, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.43, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.72, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.9),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E7, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.67)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.D, 0.007, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.12, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.74, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.07),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.63, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C7, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.Db, 0.02),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dmA, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.A, 0.009),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Ab, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Db, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Eb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.71, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.38, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.04),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.04),
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Db, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.77, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.7),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Eb, 0.16, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C7, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									})
								})
							}),
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.1, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.52, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.4)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.46),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.31)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.A, 0.006, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.29),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.29),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.36)
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7G, 0.006, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.21, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.35, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.46, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.58),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.008, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.006, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.52, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.006, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.83, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.8)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FC, 0.006, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.006, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.006, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.gm, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.23, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.18, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bdim, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.93)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.23),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.23),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.54)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.33)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.bdim, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.amE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.41, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.57, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.83)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.008, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.43)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.8, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.88),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.007),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.007),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.007)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.74, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.65),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FC, 0.007, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.32, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.06),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.47, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FA, 0.006, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Ab, 0.008, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.88, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em7B, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E7Ab, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.43, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.am7G, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.008, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.fm, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.13)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.8)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.77, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.79),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.008),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.008),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.008)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7F, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.82, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.fm, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.48, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.A, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.31, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.7, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.A, 0.1),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.006, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.D, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.1),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.7, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.38, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.009, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.97),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.009),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.02)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.46),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.35)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.27),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.27),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.44, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.25, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.85, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Gmaj6, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.52, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.69),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.31)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7E, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.008),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.53, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.71),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.16),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.06)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em7D, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
									new MarkovChainNode<Chord>(ChordPresets.fm, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.85, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.82),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.18)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.09, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.04),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.7, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.88)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EAb, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.75, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.25)
								}),
								new MarkovChainNode<Chord>(ChordPresets.A, 0.007, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.emG, 0.007, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.91, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C7B, 0.13), // Listed as "C7/B?"
										new MarkovChainNode<Chord>(ChordPresets.am, 0.63),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.13)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.5, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.008),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.85, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm7, 0.02), // Listed as "bm7b5"
										new MarkovChainNode<Chord>(ChordPresets.C7Bb, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.85),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.02)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.38, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.71),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.fm, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
								}),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E7, 0.007, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D7Gb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.57, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.14)
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G7F, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Db, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.ebm7, 0.5),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.5)
								}),
								new MarkovChainNode<Chord>(ChordPresets.ADb, 0.007, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.GB, 0.01, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.G, 0.16, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.73, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.35, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.DGb, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.04),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7C, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.bdim, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.FA, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.gm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bmaj7, 0.5, new List<MarkovChainNode<Chord>> // Listed as "B?maj7"
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Ab, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.86, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.amE, 0.14)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.18, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Db, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.Eb, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.21, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.14, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.edim, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.CG, 0.009, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.gbm7, 0.07, new List<MarkovChainNode<Chord>> // Listed as "f#m7b5"
								{
									new MarkovChainNode<Chord>(ChordPresets.D7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.52, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.6, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.fm, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.2, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.14, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.5)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.E, 0.02, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.EAb, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.fm, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.fm, 0.01),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.72, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.03),
									new MarkovChainNode<Chord>(ChordPresets.amE, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7E, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.77, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.E7B, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.79),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.07)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.amE, 0.006, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.2, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.amE, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.4, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.cmEb, 0.75, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7F, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FA, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.3, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GD, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.D, 0.009, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.03),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.18, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.18, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.fm, 0.31, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.02, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.24, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.86, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.6, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.06),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.66, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.9),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.EAb, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.03, new List<MarkovChainNode<Chord>> // Listed as "dm7?5"
								{
									new MarkovChainNode<Chord>(ChordPresets.em7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FC, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bm7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.01)
							})
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.13, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.45, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.36, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.emB, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D7A, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.bdim, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.bm, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.43, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.43, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.13, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bmaj7, 0.33), // Listed as "B?maj7"
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.31, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.25)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.fm, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Eb, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.42, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.dbdim, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.37, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em7, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.07),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7D, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.52, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bdim, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.009),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.02, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.72, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.79)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.25, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.62, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.bdim, 0.01, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.B, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.bm, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.abdim, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7G, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.2, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.6),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.01),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.28, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.48, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.37, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.04, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.03, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.89, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.bdim, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.12),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.03),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.76)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.42, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.03, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.EB, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EAb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.54, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.amE, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.31, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.EB, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.04, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.fm6, 0.05),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.53, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emB, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.6)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GD, 0.009, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.13, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.02),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.89, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.79),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.08)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.amC, 0.02, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									})
								})
							}),
							// From this point on, any nodes under an "other" node on Hooktheory will be omitted and marked here with a comment
							new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.29, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.abdim, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Abmaj7, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.39, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.13)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.19, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.6)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.emB, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Abmaj7, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ebmaj7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.22, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.56, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.7),
										new MarkovChainNode<Chord>(ChordPresets.A, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.75, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.13, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.66, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gm, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.38, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bdim, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.31, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.64, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.G7D, 0.4)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.58, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.24),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.63),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.07)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.15),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.38),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.31),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.15)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.63)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.75, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.17, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.25, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.58, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.84),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.83),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.3, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.3),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.58, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.91)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.amC, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.78, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.22, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.7, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.96),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj6, 0.04)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.CE, 0.06, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.75, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.dmA, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.74, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.34, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.64),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.18)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7Gb, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.56),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.8),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.2)
									})
									// other
								})
								// other
							}),
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.GB, 0.05, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.07, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.14, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FA, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.43, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.37, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.54, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.16, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.57, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.84, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.92),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.16, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.76, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.32)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.21, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.05),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.63, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emB, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.8)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.FA, 0.07, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.8, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.64, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1),
								new MarkovChainNode<Chord>(ChordPresets.emG, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.DGb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.75, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.46, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.D7Gb, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D7, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.84, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.62),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.5, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm7, 1) // Listed as "bm7b5"
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.65, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.87)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.56, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.9),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.7, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.83, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.72),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.06)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.fm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.0, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7E, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.24, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.88),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.fm, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7E, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.12),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.05)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.15),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.54),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.15),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.15)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.3, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.19, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.78)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.69, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.74)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gm7, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.fm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.31, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.08, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.24, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.31, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.31, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7E, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.31, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.41, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.8),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.44, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.22),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.78)
									})
								})
								// other
							})
							// other
						})
						// other
					}),
					new MarkovChainNode<Chord>(ChordPresets.F, 0.15, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.G, 0.29, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.28, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bm7, 0.07, new List<MarkovChainNode<Chord>> // Listed as "bm7b5"
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.B, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.71),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.43, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.66, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.emG, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.37),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.42)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.17, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.78, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.4)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.2, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.64),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.49, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.74),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.48),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.35)
										// other
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.28, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.72, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.15),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.7)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.41),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.47)
										// other
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.36, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.16, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.66, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.08)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.22, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.66),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.28, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.8, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.58),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.15),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.BD, 0.11), // Listed as "B?/D"
										new MarkovChainNode<Chord>(ChordPresets.F, 0.89)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.81, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.81),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05)
										// other
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.21, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.em7B, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.45, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.42),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.54)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.amE, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.BD, 0.13) // Listed as "B/D?"
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.69, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.84),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.47, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.86),
										new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.Gb, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.fm, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.03)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.3, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.91),
										new MarkovChainNode<Chord>(ChordPresets.F7, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.02)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.2, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.6, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.83)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.57),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.DA, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.47, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.8),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.51, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.54, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.81)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.28),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.24),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.1)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.28),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.38),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.06)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07)
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.45, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.25, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.9, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.71, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.57),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.3, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.77, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.19),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.57),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.08)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.18)
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.C, 0.29, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.emG, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.19, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05)
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.46, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.EB, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.71)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.01, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.96)
										// other
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.14, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.A7, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.38, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.22),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.78)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.45, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.3),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.58, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.64)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.77, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm7, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.27)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.G, 0.39, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.89, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.91)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.33, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.89, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.68),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.15)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.86, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.77),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emG, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.56, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.16),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.79)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.44, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.23, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.78, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.83),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.08)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.59),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.27),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.21),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.45)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.86, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.87)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.38)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.43, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.84, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.92),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.84),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.13, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.58),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.22)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.55, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.83),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.16)
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.1, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.17, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.G, 0.43, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.38)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.73, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.98)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.64),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.27)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.26, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.68, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.89),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.17)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.83)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.12, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.7, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.45, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.19, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.3),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.19, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.37, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.6, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.86),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.36),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.28),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.32)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.19),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.ebm, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.31)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.52),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.88, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.83),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.13)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.75, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.84),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.26, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.85)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.69, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.85),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.07)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.1)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.14, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.24, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.93)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.8)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.45, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.59, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.15),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.64),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.54),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.15),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.15)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.43, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bdim, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.3),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.3),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6)
									})
									// other
								})
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.56, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.18, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.44, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.32, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.56, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.64),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.5)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.14, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.55, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.dm7C, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.36, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.10, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.13, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bm, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.bm7, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.DF, 1) // Listed as "D/F?"
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Gb, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.8, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.3, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.36, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.41)
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.25, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.05),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.68, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.28, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.9, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.9)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.21, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.68, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.91),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.21)
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.2, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.41, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7G, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.8),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.63, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.76),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.06)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.abdim, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.25)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.3, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7C, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05)
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.33)
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.26, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.66, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.81),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.12, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7G, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.41, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 0.36, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.64, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.21, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.3, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.33, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.45, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.78)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.E, 0.08, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.8, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.bm7, 0.5) // Listed as "bm7b5"
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.2)
								}),
								new MarkovChainNode<Chord>(ChordPresets.EAb, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.5) // Listed as "b?m"
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.14, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.43),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.43),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.14)
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.67, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.69, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.77)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
								// other
							})
							// other
						})
						// other
					}),
					new MarkovChainNode<Chord>(ChordPresets.am, 0.14, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.09, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.64, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.23, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.66, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.89)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.54, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.57),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.43)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.31, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.34, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.57, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.92),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.04)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.13)
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.10, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.G, 0.18, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.A, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.39, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.33)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.44, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.74, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.77)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.14, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.34, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.Abmaj7, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.71, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.14)
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.B7, 0.11),
									new MarkovChainNode<Chord>(ChordPresets.fm, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.37, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.31, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.A, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.45, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.36),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj6, 0.36)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.24, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.43, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.83)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.74),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.19)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.76)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.3),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.2)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.32, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emB, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.38),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.13)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.74, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.96),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.04)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.92),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.08)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.23, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.44),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.22)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.71, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.77)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.56),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.71)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.06, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.88, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.13, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.38, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.05),
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.5, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.6, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.3, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.73),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.18)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.18, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.79, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.91)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.28, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.12, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.31),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.38),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.15)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.34, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.94),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.06)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.27),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.55),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.09)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.81, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.22),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.44)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.42, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.55),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.36)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.75, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.81),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.05)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.B, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.55),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.18)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.83, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.47),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.91, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.89),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.06)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.11)
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.14, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.32, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.83),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.55, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.56)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.bdim, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.79, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.82),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.18)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.33, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.22),
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.22),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.42, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.63),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.57),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.07),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.29)
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.18, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.34, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.64, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.58),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.12),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.09)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.8, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.43)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.47, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.21, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.78),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.07)
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dmA, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.bm, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.65, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E7D, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.38, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.27, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.64, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.88)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.36, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.91)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm7, 0.08), // Listed as "bm7b5"
										new MarkovChainNode<Chord>(ChordPresets.G, 0.28),
										new MarkovChainNode<Chord>(ChordPresets.ebdim, 0.12),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.16),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.12)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.47, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.56),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.22)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emG, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.62, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.61, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.26, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.8, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.cm, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.56),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.22)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.48, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.61, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.76),
										new MarkovChainNode<Chord>(ChordPresets.em7D, 0.06)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.em7B, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.44, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.56, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.13, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.21, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7C, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emB, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.89)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7G, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.gbm7, 1) // Listed as "f#m7b5"
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.35, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.43)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.42, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.71),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.21)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.17, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.06),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.94)
								})
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.em, 0.06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.43, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GD, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.33, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.64, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.33, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.38, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.DF, 0.15, new List<MarkovChainNode<Chord>> // Listed as "D/F?"
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.fdim, 0.05, new List<MarkovChainNode<Chord>> // Listed as "f?*"
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.fdim, 1)// Listed as "f?*"
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.21, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.B, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.82, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.91),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.04)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.42, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.37, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.19, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.89)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.56, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.6),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.65, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.9)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.44),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.11)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.12, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.25, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D7, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.85, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.38, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.74, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.68),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.21),
										new MarkovChainNode<Chord>(ChordPresets.emG, 0.07)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.14, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.36, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.11, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.45, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.8)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.45, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.29, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.21),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.53),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.16)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.36, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.92),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.08)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.58),
										new MarkovChainNode<Chord>(ChordPresets.abm7, 0.11), // Listed as "g#m7b5"
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.79),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.78, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.96),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.04)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.36, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.15),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.15),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.22),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.62, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.73)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.78),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Cmaj6, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.50)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.36, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.77),
										new MarkovChainNode<Chord>(ChordPresets.am7G, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.08)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.3, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.3, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.52, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.86),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.23, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.38, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.25)
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.12, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.8, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.25)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.05)
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.24, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.43, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.77, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.81)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.25)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.84, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.97),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.02)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.92, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.94)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.56, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.53),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.83, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.96),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.008),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.02)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.05, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emB, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.B, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.25, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.6),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.39, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.amE, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.82)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.36),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.45, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.ADb, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.66, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.64),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.31, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.29, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.emB, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.86)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.78)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.41, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.93)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.16),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.69)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.39, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.28),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.39),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.06)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.63),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.66, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.91),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.01),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.04)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.54),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.08)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.66, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.82)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.86),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.61, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.98),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.02)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.64),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.09)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.E, 0.16, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.83, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.95)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.bdim, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gmBb, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.46, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.3, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.78, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.82),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.am7G, 0.08)
									}),
									new MarkovChainNode<Chord>(ChordPresets.abdim, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.16, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.66, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.63),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.13, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.26, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.32, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.abdim, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.19, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								})
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.G, 0.2, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.17, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.43, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.11, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.77, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.79),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.43, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.73),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.31, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.fm6, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.4, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.56, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.95)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.07)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1)
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.61, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.81),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.21, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.82, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.16),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.68),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.1)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.19, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.47, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.94)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.ADb, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.36, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.37, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.71),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.56, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.97),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.03)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.08)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.64, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.38),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.38),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.13)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emB, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.15, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.12, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.55),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09)
									}),
									new MarkovChainNode<Chord>(ChordPresets.bdim, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.88)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.44, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.71),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.08)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.5, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bdimD, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.Db, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.3),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.69, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.82)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.13)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.38, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.94),
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.06)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.63)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.37, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.89)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.37, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.gm, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.13)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.32, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.57),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.43)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.8)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.43, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.24, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.48, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.99),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.007),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.007)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.27),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.53)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.32),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.21),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.47)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.92)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.16, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.22),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.44)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.83, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.85),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.21),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.26, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.52),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.19),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08)
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.45, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.88)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.27),
										new MarkovChainNode<Chord>(ChordPresets.bdim, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.Gmaj6, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.07)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.22),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.3),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.07)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.19),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.38),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.05)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.43, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.83)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.55),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.56),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.22)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.8)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.05)
							// other
						})
						// other
					}),
					new MarkovChainNode<Chord>(ChordPresets.G, 0.14, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.C, 0.21, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.86, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.D7Gb, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.42)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.57),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.18, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.29)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.63, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.73),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.07)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.26, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.17, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.18),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.64)
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.24, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.93, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.85)
										// other
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.GB, 0.05, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.64, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.83),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.17)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.19, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7G, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gm, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.19, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.64, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.76),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.12),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.12),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.55),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.12)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.8),
										new MarkovChainNode<Chord>(ChordPresets.fm, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.63),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.FA, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.13, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.16, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.83, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.86),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.62, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.21),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.55),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.44, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.83, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.8),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.07)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.66, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.93),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.17)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.29, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.24, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.59),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.28)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.58, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.77),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.36, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.61, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.81),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.41),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.05)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.22),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.56),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.11)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.47, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.72),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.06)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.84, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.79),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.09)
										// other
									})
									// other
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.19, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.28, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.28),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.48),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.08)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.69, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.24, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.55),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.18)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.19)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.43, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.23),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.77),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.15)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.33, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.26, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.77)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.91)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.49, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.8),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.06)
										// other
									})
									// other
								})
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.15, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.36, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.15, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.26, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.8),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.68, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.53, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.69, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.83)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7F, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7E, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.1, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.22, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.35, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.9, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.85),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.18, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.BD, 0.29), // Listed as "B/D?"
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.cm, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.56, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.81),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.29, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.6)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.73, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.9),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.42, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.6),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.19, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.ADb, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.34, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C7G, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.41, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.35, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.05, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.emB, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.49, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.83, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.7),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.09)
										// other
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.77, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.57),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.43)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.65, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.26),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.61)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.09, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.4, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.34, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.5, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.88, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.95)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.17, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.92, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.73),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.19),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.22, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.44),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.38),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.46, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88)
										// other
									})
									// other
								})
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.21, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.3, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.13, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.34, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.54),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.3)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7C, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.44),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.52, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.12),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.76),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.17, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.44),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.22)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.86, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.94)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.51, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.79),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.07)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.12, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.3),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.55)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.73, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.82),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.07)
										// other
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.13, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.27, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.87, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.09)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.51, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.emB, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.63),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.78, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.69),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.13)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.24),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.31),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.37)
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.28, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.27, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.27),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.62)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.57, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.8)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.32, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.3)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.61, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.84)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.76),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.16)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.26, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.3),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.3),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.D7C, 0.05)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.55),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.18)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.67, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.72),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13)
										// other
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.21, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.28, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.38, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.8),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.29, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.67),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.82, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.95),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.02)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.52, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.71)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.41, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.33)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.19, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.19, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.29)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.dmA, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.32, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.21, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.14)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.3, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.45),
										new MarkovChainNode<Chord>(ChordPresets.G7F, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.18)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.15, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.83),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.29, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.bm7, 0.67)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.14, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.48, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.8)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.23, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.16, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.6),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.46, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.77),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.15),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.08)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.16, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.39, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.57),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.29)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.34, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7C, 0.29),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.43)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.31, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.8, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.96)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.08, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.61, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.2)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.22, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.26, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.25)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.8)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.24, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.6),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.2)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.27, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.7),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.59, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.21),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.47),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.16),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.42, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.36),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.45),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.84)
										// other
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.2, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.38)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.43, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.64),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.21)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.31, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.84),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.31, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.19),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.56)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.62, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.72),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.42, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.18, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.18),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.65)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.53, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.76)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.21),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.42)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.36),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.43),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.61, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.23, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.19),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.44),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.06)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.55, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.72),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.22),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.22),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.44)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.12, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.5),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.7)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.27, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.3, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.12, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.7, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.76),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.05)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.05, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.36, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.53, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.89, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.08),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.84)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.32, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.17, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.12),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.61),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.12)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.65, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.71)
										// other
									})
									// other
								})
								// other
							})
							// other
						})
					}),
					new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.C, 0.13, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.18),
							new MarkovChainNode<Chord>(ChordPresets.GB, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.12),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.13),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.28)
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.16, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.34),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.16),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06)
						}),
						new MarkovChainNode<Chord>(ChordPresets.G, 0.16, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.4),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.17),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.09),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.1)
						}),
						new MarkovChainNode<Chord>(ChordPresets.em, 0.09, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.21),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.49),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.09)
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.18, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.18),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.12),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.18),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.21),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07)
						})
					}),
					new MarkovChainNode<Chord>(ChordPresets.em, 0.03, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.11),
							new MarkovChainNode<Chord>(ChordPresets.GB, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.16),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.16),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.18),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.11)
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.08, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.17),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.16),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.19),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.24),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.12)
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.33, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.19),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.14),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.34),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.12),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06)
						}),
						new MarkovChainNode<Chord>(ChordPresets.G, 0.08, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.23),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.34),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.14),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.07)
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.26, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.08),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.16),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.21),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.23),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.15)
						})
					}),
					new MarkovChainNode<Chord>(ChordPresets.am7, 0.02, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.C, 0.05, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05)
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm7, 0.09, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.F, 0.47),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.09),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.15),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7E, 0.09)
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.06),
							new MarkovChainNode<Chord>(ChordPresets.FA, 0.06),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.44),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.12)
						}),
						new MarkovChainNode<Chord>(ChordPresets.em7, 0.06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.1),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.2),
							new MarkovChainNode<Chord>(ChordPresets.gm7, 0.07),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.19),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.22)
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.13, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.33),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.1),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.28)
						}),
						new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.05, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.1),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.06),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.1),
							new MarkovChainNode<Chord>(ChordPresets.G7, 0.11),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.em7, 0.23)
						}),
						new MarkovChainNode<Chord>(ChordPresets.G, 0.15, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.15),
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.16),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.11),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.32),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05)
						})
					})
					//new MarkovChainNode<Chord>(ChordPresets.CE, 0.02),
					//new MarkovChainNode<Chord>(ChordPresets.dm7, 0.02),
					//new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.02),
					//new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01),
					//new MarkovChainNode<Chord>(ChordPresets.CG, 0.01),
					//new MarkovChainNode<Chord>(ChordPresets.E, 0.01),
					//new MarkovChainNode<Chord>(ChordPresets.em7, 0.01),
					//new MarkovChainNode<Chord>(ChordPresets.GB, 0.01),
					//new MarkovChainNode<Chord>(ChordPresets.G7, 0.01),
					//new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.008),
					//new MarkovChainNode<Chord>(ChordPresets.amE, 0.007),
					//new MarkovChainNode<Chord>(ChordPresets.D, 0.007)
				};
			}
		}
	}
}
