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
									},
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
								},
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
								}1),
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
								new MarkovChainNode<Chord>(ChordPresets.C, 0.19),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.26),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.46)
							}),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.02),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.007),
							new MarkovChainNode<Chord>(ChordPresets.E, 0.007),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.02),
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.008),
							new MarkovChainNode<Chord>(ChordPresets.D, 0.01),
							new MarkovChainNode<Chord>(ChordPresets.GB, 0.008),
							new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02)
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.19, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.32, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.11),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.44),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.16)
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.12, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.17),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.45),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.14)
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.30, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.28),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.36),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05)
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.11),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.08),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.1)
							})
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.1, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.52),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.09),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.21)
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.23, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.18),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.05),
								new MarkovChainNode<Chord>(ChordPresets.F, 57),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.09)
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.32, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.38),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.43)
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.08, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.11),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.25),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.52)
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.09, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.09),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.5),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.15),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.09)
							})
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.13, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.52),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.05),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.06),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.13),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.09)
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.25, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.13),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.37)
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.1, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.29),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.19),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.05),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.22),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05)
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.13, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.11),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.1),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.64),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.06)
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.17, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.25),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.3),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.07),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.22)
							}),
							new MarkovChainNode<Chord>(ChordPresets.CE, 0.06, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.08),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.74),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.04),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.03),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.02),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.007),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.04),
								new MarkovChainNode<Chord>(ChordPresets.FC, 0.03)
							})
						}),
						new MarkovChainNode<Chord>(ChordPresets.GB, 0.05, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.07, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.14),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.37),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.16)
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.07, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.57),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.16),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.21)
							}),
							new MarkovChainNode<Chord>(ChordPresets.FA, 0.07, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.09),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.1),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.08),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1),
								new MarkovChainNode<Chord>(ChordPresets.emG, 0.08),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.46)
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.5, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.06),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.05),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.7),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.06),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.24),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.3),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05)
							}),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.08, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.07),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.24),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.05),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.41)
							})
						})
					}),
					new MarkovChainNode<Chord>(ChordPresets.F, 0.15, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.G, 0.29, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.28, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.05),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.17),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.28)
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.36, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.16),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.22),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.28),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08)
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.21),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.69)
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.11, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.2),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.05),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.51),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07)
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.09),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.05),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.3),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.18)
							})
						}),
						new MarkovChainNode<Chord>(ChordPresets.C, 0.29, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.11),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.44),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.16)
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.1, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.17),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.45),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.14)
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.11),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.10),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.25),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.20),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.11),
							new MarkovChainNode<Chord>(ChordPresets.E, 0.08)
						})
					}),
					new MarkovChainNode<Chord>(ChordPresets.am, 0.14, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.C, 0.11, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.09),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.10),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.31),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.06),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.28)
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.14),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.18),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.27),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.13)
						}),
						new MarkovChainNode<Chord>(ChordPresets.em, 0.06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.21),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.12),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.45),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06)
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.24, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.43),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.31),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06)
						}),
						new MarkovChainNode<Chord>(ChordPresets.G, 0.2, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.17),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.15),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.43),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.05)
						})
					}),
					new MarkovChainNode<Chord>(ChordPresets.G, 0.14, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.C, 0.21, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06),
							new MarkovChainNode<Chord>(ChordPresets.GB, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.13),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.29),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.19)
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.15),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.22),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.1),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.34)
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.21, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.3),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.13),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.28),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05)
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.26, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.11),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.2),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.36)
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
							new MarkovChainNode<Chord>(ChordPresets.C, 0.05),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.21),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.49),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.09)
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
