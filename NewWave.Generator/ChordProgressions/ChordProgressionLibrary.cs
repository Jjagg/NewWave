using System.Collections.Generic;
using NewWave.Core.Chords;

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
					new MarkovChainNode<Chord>(ChordPresets.C, 0.15f, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.G, 0.25f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.am, 0.34f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.78f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.69f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.23f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.08f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.cm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.gm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Ab, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.38f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.54f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.gm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.fdim, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.26f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.78f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.004f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.19f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.65f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.46f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.amE, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.65f),
									}),
									new MarkovChainNode<Chord>(ChordPresets.gdim, 0.008f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.008f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1),
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.69f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.83f),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.66f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.009f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.29f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EB, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.26f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.61f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.007f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.38f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.83f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.93f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.007f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.83f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.gdimB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.61f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.36f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.45f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.4f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.64f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.23f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75f),
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E7, 0.007f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.007f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.44f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.13f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.19f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.44f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.006f),
									new MarkovChainNode<Chord>(ChordPresets.emB, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.71f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.76f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.1f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.78f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.DGb, 0.11f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.25f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.74f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.B, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.B, 0.05f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bdim, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.16f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.44f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.44f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.71f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.AE, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.007f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.93f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.42f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.58f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.57f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.43f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.2f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.32f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.23f),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.35f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.16f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.26f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.47f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.A7, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.65f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.86f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.009f),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.018f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.009f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.009f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.02f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dmF, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EmG, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.78f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.A, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.3f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.02f),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.36f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.3f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dmA, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.02f),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dmA, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.38f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E7, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7C, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.71f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.14f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.48f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.4f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.007f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.19f),
										new MarkovChainNode<Chord>(ChordPresets.emB, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.38f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.19f),
										new MarkovChainNode<Chord>(ChordPresets.A, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.D7, 0.06f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.8f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.006f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.81f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.006f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.19f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.65f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.008f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.fm, 0.29f)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.C, 0.14f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.77f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Eb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.BbF, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.35f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.71f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E7, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.57f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.39f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.C7Bb, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.DGb, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.32f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.21f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.DF, 0.33f) // Listed as "D/F?"
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.23f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.65f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.008f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.54f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.77f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.C7E, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.G7D, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.35f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dmA, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.008f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.19f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.12f),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj6, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.62f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Cmaj6, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.68f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bdim, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.76f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.008f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.41f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.52f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.86f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.0f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.83f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.8f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.fdim, 0.2f) // Listed as "f?°"
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.A, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.26f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.35f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.10f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.19f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.8f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7G, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.78f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.79f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.02f),
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.26f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E7Ab, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7G, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.38f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.54f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.amE, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.83f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.BD, 0.02f, new List<MarkovChainNode<Chord>>
									{ // Listed as "B/D?"
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.63f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emB, 0.01f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.46f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.amE, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.85f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.007f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.007f),
										new MarkovChainNode<Chord>(ChordPresets.gm, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.91f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.007f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.007f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.01f)
									}),
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.02f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.14f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.63f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.6f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.76f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.83f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.86f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.03f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.007f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.18f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Emaj7, 0.01f), // Listed as "E?maj7"
								new MarkovChainNode<Chord>(ChordPresets.D, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.abdim, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.53f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.93f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.92f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.E, 0.007f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.65f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7G, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.36f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.83f),
										new MarkovChainNode<Chord>(ChordPresets.DGb, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.03f),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.DF, 1) // Listed as "D/F?"
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.27f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.43f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.57f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.02f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.3f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bm, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.59f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.86f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.14f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.32f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.62f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.91f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.09f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D7, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.6f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.008f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.FA, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.fmAb, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Gmaj6, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.13f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.fmAb, 0.25f),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Gmaj6, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.34f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.37f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.42f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.24f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.71f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gm, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.D, 0.01f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.A, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.B, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.cm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.24f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.73f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.71f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.A, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.33f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.D, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em7, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dmF, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.24f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.91f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.09f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.bm7, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.GB, 0.008f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.01f),
								new MarkovChainNode<Chord>(ChordPresets.gmD, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.gm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dmF, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FC, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.EB, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.86f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.96f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.96f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.gm, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.62f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.gm, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.DGb, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.66f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.91f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.04f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Eb, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.8f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.Db, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GD, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em7D, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.19f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.D, 0.05f),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.73f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									})
								})
							})
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.19f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.32f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C7, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.57f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.14f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.35f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.04f),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.26f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.01f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Gmaj6, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.01f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.42f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.fm, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.A, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.1f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.82f),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06f),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.12f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.3f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.008f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bdim, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.54f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.D7, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.01f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.19f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.82f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.008f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.59f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.008f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.008f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.79f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.008f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.008f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.47f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.55f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.27f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.008f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.008f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.A, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.19f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.22f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.47f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.008f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.A, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.008f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.69f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.71f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.007f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.15f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.7f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.007f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.007f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.007f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.007f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.B, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.32f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.007f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E7D, 0.08f),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08f),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.fm, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.25f),
									}),
									new MarkovChainNode<Chord>(ChordPresets.E7, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1),
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.2f),
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.02f),
									new MarkovChainNode<Chord>(ChordPresets.gm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.edim, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.02f),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f),
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1),
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.37f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.D7, 0.33f),
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.42f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1),
									}),
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.07f),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.E7, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7E, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1),
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.01f),
									})
								}),
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.12f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.006f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FA, 0.006f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Ab, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25f),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f),
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.55f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.006f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.3f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.006f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.BbF, 0.006f),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.3f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.006f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.006f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.71f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.94f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.009f),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.009f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.14f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.76f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.92f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.08f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.78f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D7, 0.006f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1),
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.59f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88f),
										new MarkovChainNode<Chord>(ChordPresets.bdim, 0.13f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.14f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.86f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.81f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.12f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.04f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f)
									}),
								}),
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.30f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.44f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.44f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.29f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bm, 0.009f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.BbD, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.009f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.DF, 0.05f), // Listed as "D/F?"
										new MarkovChainNode<Chord>(ChordPresets.DGb, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.44f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.38f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.56f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.26f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.13f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.47f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.02f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb7, 0.03f),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.19f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.47f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.86f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.43f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.14f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.009f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.26f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bbmaj6, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.19f),
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.27f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.42f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.009f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.cdimE, 0.33f), // Listed as "c*/E?"
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.G7D, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.56f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.86f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.02f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em7, 0.007f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7F, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.A, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am7G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.82f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.007f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.83f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.8f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.A, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.77f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.28f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.56f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.B, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.39f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.86f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.42f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.C7B, 0.25f) // Listed as "C7/B?"
									}),
									new MarkovChainNode<Chord>(ChordPresets.emB, 0.006f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.A, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.12f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.35f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.12f),
										new MarkovChainNode<Chord>(ChordPresets.amE, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.12f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.18f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.48f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.24f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.19f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.74f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.77f),
										new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.008f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.009f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C7, 0.006f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.75f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.25f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.A, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.24f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.73f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.94f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.06f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.adim, 0.008f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CG, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.abdim, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.31f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7F, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.01f),
									new MarkovChainNode<Chord>(ChordPresets.cmEb, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Abmaj7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.64f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.91f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.04f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.33f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.71f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.82f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.emG, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GD, 0.008f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.amC, 0.008f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.gdimB, 1, new List<MarkovChainNode<Chord>> // Listed as "g?*/B"
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bdim, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.42f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7C, 0.008f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7C, 1) // Listed as "dm7b5/C"
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.CG, 0.01f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FA, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7B, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.emG, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.71f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.18f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.64f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.35f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.55f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.83f),
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.36f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.G7, 0.01f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.14f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.DGb, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7E, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FC, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.72f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.A7, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.fmAb, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.02f),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.49f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.D7Gb, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C7G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C7, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj6, 0.5f)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.006f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.cdimE, 1, new List<MarkovChainNode<Chord>> // Listed as "c*/E?"
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.72f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.13f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.abdim, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EAb, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.17f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.33f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.006f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.17f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.EAb, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7G, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.6f),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.4f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.fdim, 0.06f, new List<MarkovChainNode<Chord>> // Listed as "f?*"
								{
									new MarkovChainNode<Chord>(ChordPresets.cmG, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D7Gb, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.22f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emG, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em7, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.D7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.11f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.03f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.37f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.26f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.83f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.A, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.fm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.6f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
								}),
								new MarkovChainNode<Chord>(ChordPresets.dmF, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.45f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Eb, 0.01f),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.59f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb7, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.75f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.em7, 0.007f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gm7, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.25f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.8f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.3f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FA, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.67f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.25f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.02f)
							}),
							new MarkovChainNode<Chord>(ChordPresets.E, 0.01f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.gm7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.68f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.61f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.92f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.08f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.33f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.6f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Gmaj6, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.B, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.BD, 1) // Listed as "B/D?"
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.amC, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.CE, 0.04f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7Gb, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.47f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06f),
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D7F, 0.009f, new List<MarkovChainNode<Chord>> // Listed as "D7/F?"
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.B, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.45f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.4f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.cmEb, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D7, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.26f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bdim, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.cm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C7, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f),
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.38f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm7, 0.1f), // Listed as "bm7b5"
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.8f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.17f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.3f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.2f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GD, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.6f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7C, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.12f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.68f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.63f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.31f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FC, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.2f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.86f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.43f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.72f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.9f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.1f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E7, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.67f)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.D, 0.007f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.12f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.74f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.07f),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.63f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C7, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.Db, 0.02f),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dmA, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.A, 0.009f),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Ab, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Db, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Eb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.71f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.38f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.04f),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.04f),
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Db, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.77f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.7f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Eb, 0.16f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C7, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									})
								})
							}),
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.1f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.52f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.4f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.46f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.31f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.A, 0.006f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07f),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.29f),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.29f),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.36f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7G, 0.006f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.21f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.35f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.46f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.58f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.008f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.006f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.52f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.006f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.83f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.8f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FC, 0.006f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.006f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.006f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.gm, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.23f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.18f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bdim, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.93f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.23f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.23f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.54f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.33f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.bdim, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.amE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.41f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.57f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.83f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.008f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.43f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.8f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.88f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.007f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.007f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.007f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.74f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.65f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FC, 0.007f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.32f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.06f),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.47f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FA, 0.006f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Ab, 0.008f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.88f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em7B, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E7Ab, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.43f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.am7G, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.008f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.fm, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.13f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.8f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.77f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.79f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.008f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.008f),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.008f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7F, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.82f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.fm, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.48f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.A, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08f),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.31f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.7f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.A, 0.1f),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.006f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.D, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.1f),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.7f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.38f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.009f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.97f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.009f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.02f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.46f),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.35f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.27f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.27f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11f),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.44f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.25f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.85f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Gmaj6, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.52f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.69f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.31f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7E, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.008f),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.53f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.71f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.16f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em7D, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
									new MarkovChainNode<Chord>(ChordPresets.fm, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.85f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.82f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.18f)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.04f),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.7f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.88f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EAb, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.75f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.25f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.A, 0.007f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.emG, 0.007f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.91f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C7B, 0.13f), // Listed as "C7/B?"
										new MarkovChainNode<Chord>(ChordPresets.am, 0.63f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.13f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.5f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.008f),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.85f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm7, 0.02f), // Listed as "bm7b5"
										new MarkovChainNode<Chord>(ChordPresets.C7Bb, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.85f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.02f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.38f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.71f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.fm, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E7, 0.007f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D7Gb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.57f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.14f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G7F, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Db, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.ebm7, 0.5f),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.5f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.ADb, 0.007f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.GB, 0.01f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.G, 0.16f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.11f),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.73f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.35f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.DGb, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.04f),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7C, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.bdim, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.FA, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.gm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bmaj7, 0.5f, new List<MarkovChainNode<Chord>> // Listed as "B?maj7"
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Ab, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.86f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.amE, 0.14f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.18f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Db, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.Eb, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.21f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.14f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.edim, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.CG, 0.009f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.gbm7, 0.07f, new List<MarkovChainNode<Chord>> // Listed as "f#m7b5"
								{
									new MarkovChainNode<Chord>(ChordPresets.D7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.52f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.6f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.fm, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.2f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.14f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.5f)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.E, 0.02f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.EAb, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.fm, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.fm, 0.01f),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.72f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.03f),
									new MarkovChainNode<Chord>(ChordPresets.amE, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7E, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.77f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.E7B, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.79f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.07f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.amE, 0.006f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.2f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.amE, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.4f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.cmEb, 0.75f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7F, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FA, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.3f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GD, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.D, 0.009f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.03f),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.18f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.18f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.fm, 0.31f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.02f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.24f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.86f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.6f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.06f),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.66f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.9f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.EAb, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.03f, new List<MarkovChainNode<Chord>> // Listed as "dm7?5"
								{
									new MarkovChainNode<Chord>(ChordPresets.em7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.FC, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bm7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.01f)
							})
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.13f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.45f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.36f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.emB, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D7A, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.bdim, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.bm, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.43f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.43f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.13f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bmaj7, 0.33f), // Listed as "B?maj7"
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.31f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.25f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.fm, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Eb, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.42f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.dbdim, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.37f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em7, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.07f),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7D, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.52f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bdim, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.009f),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.02f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.72f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.79f)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.25f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.62f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.bdim, 0.01f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.B, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.bm, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.abdim, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7G, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.2f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.6f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.01f),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.28f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.48f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.37f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.04f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.03f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.89f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.bdim, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.12f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.03f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.76f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.42f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.03f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.EB, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EAb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.54f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.amE, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.31f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.EB, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.fm6, 0.05f),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.53f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emB, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.6f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GD, 0.009f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.13f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.02f),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.89f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.79f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.08f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.amC, 0.02f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									})
								})
							}),
							// From this point on, any nodes under an "other" node on Hooktheory will be omitted and marked here with a comment
							new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.29f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.abdim, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Abmaj7, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.39f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.13f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.19f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.6f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.emB, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Abmaj7, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ebmaj7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.22f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.56f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.7f),
										new MarkovChainNode<Chord>(ChordPresets.A, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.75f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.13f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.66f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gm, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.38f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bdim, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.31f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.64f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.G7D, 0.4f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.58f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.24f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.63f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.07f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.15f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.38f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.31f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.15f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.63f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.75f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.17f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.25f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.58f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.84f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.83f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.3f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.3f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.58f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.91f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.amC, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.78f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.22f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.7f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.96f),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj6, 0.04f)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.CE, 0.06f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.75f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.dmA, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.74f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.34f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.64f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.18f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7Gb, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.56f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.8f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.2f)
									})
									// other
								})
								// other
							}),
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.07f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.14f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FA, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.43f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.37f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.54f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.16f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.57f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.84f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.92f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.16f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.76f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.32f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.21f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.05f),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.63f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emB, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.8f)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.FA, 0.07f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Eb, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.8f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.64f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1f),
								new MarkovChainNode<Chord>(ChordPresets.emG, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.DGb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.75f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.46f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.D7Gb, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D7, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.84f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.62f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.5f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm7, 1) // Listed as "bm7b5"
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.65f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.87f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.56f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.9f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.7f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.83f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.72f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.06f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.fm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.0f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7E, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.24f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.88f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.fm, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7E, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.12f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.05f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.15f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.54f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.15f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.15f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.3f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.19f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.78f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.69f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.74f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gm7, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.fm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.31f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.08f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm7, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.24f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.31f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.31f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7E, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.31f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G7, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.41f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.8f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.44f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.22f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.78f)
									})
								})
								// other
							})
							// other
						})
						// other
					}),
					new MarkovChainNode<Chord>(ChordPresets.F, 0.15f, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.G, 0.29f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.28f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bm7, 0.07f, new List<MarkovChainNode<Chord>> // Listed as "bm7b5"
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.B, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.71f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.43f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.66f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.emG, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.37f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.42f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.17f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.78f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.4f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.2f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.64f),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.49f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.74f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.48f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.35f)
										// other
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.28f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.72f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.15f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.7f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.41f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.47f)
										// other
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.36f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.16f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.66f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.08f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.22f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09f),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.66f),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.28f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.8f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.58f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.15f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.BD, 0.11f), // Listed as "B?/D"
										new MarkovChainNode<Chord>(ChordPresets.F, 0.89f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.81f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.81f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f)
										// other
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.21f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.em7B, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.45f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.42f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.54f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.amE, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.BD, 0.13f) // Listed as "B/D?"
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.69f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.84f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.47f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.86f),
										new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.Gb, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.fm, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.03f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.3f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.91f),
										new MarkovChainNode<Chord>(ChordPresets.F7, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.02f)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.2f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.6f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.83f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.57f),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.DA, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.47f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.8f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.51f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.54f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.81f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.28f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.24f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.1f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.28f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.38f),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.06f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07f)
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.45f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.25f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.9f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.71f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.57f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.3f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.77f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.19f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.57f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.08f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.18f)
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.C, 0.29f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.emG, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.19f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.46f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.EB, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.71f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.01f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.96f)
										// other
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.14f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.A7, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.38f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.22f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.78f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.45f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.3f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.58f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.64f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.77f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm7, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.27f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.G, 0.39f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.89f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.91f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.33f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.89f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.68f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.15f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.86f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.77f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emG, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.56f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.16f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.79f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.44f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.23f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.78f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.83f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.08f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.59f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.27f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.21f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.45f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.86f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.87f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.38f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.43f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.84f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.92f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.84f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.13f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.58f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.22f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.55f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.83f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1f)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.16f)
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.1f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.17f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.G, 0.43f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.38f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.73f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.98f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.64f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.27f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.26f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.68f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.89f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.17f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.83f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.12f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.7f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.45f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.19f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.3f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.19f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.37f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.6f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.86f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.36f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.28f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.32f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.19f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.ebm, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.31f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.52f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.88f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.83f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.13f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.75f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.84f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.26f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.85f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.69f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.85f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.07f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.1f)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.14f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.24f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.93f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.8f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.45f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.59f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.15f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.64f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.54f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.15f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.15f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.43f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bdim, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.3f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.3f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.1f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6f)
									})
									// other
								})
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.56f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.18f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.44f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.32f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.56f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.64f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.5f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.14f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.55f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.dm7C, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.36f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.10f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.13f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.bm, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.bm7, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.DF, 1) // Listed as "D/F?"
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Gb, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.8f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.3f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.36f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.41f)
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.25f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.05f),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.68f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.28f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.9f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.9f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.21f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.68f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.91f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.21f)
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.2f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.41f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7G, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.8f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.63f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.76f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.06f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.abdim, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.25f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.3f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7C, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.33f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.26f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.66f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.81f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17f)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.12f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am7G, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.41f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 0.36f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.64f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.21f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.3f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.45f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.78f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.E, 0.08f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.8f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.bm7, 0.5f) // Listed as "bm7b5"
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.2f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.EAb, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.5f) // Listed as "b?m"
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.14f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.43f),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.43f),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.14f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.67f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.69f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.77f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06f, new List<MarkovChainNode<Chord>>
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
					new MarkovChainNode<Chord>(ChordPresets.am, 0.14f, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.64f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.23f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.66f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.89f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.54f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.57f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.43f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.31f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.34f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.57f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.92f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.04f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.13f)
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.10f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.G, 0.18f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.A, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.39f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.33f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.44f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.74f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.77f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.14f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.34f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.Abmaj7, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.71f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.14f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.B7, 0.11f),
									new MarkovChainNode<Chord>(ChordPresets.fm, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.37f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.31f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.A, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.45f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.36f),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj6, 0.36f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.24f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.43f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.83f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.74f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.19f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.76f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.3f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.2f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.32f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emB, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.38f),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.13f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.74f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.96f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.04f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.92f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.08f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.23f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.44f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.22f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.71f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.77f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.56f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.71f)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.06f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13f),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.88f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.13f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.38f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.05f),
									new MarkovChainNode<Chord>(ChordPresets.Ab, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.5f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.6f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.3f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.73f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.18f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.18f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.79f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.91f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.28f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.12f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.31f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.38f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.15f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.34f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.94f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.06f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.27f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.55f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.81f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.22f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.44f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.42f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.55f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.36f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.75f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.81f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.05f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.B, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.55f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.18f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.83f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.47f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.91f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.89f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.06f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f)
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.14f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.32f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.83f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.55f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.56f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.bdim, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.79f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.82f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.18f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.33f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.22f),
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.22f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.42f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.63f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.57f),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.07f),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07f),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.29f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.18f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.34f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.64f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.58f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.12f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.09f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.8f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.43f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.47f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.21f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.06f),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.78f),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.07f)
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dmA, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.bm, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.65f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E7D, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.38f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.27f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.64f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.88f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.36f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.91f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bm7, 0.08f), // Listed as "bm7b5"
										new MarkovChainNode<Chord>(ChordPresets.G, 0.28f),
										new MarkovChainNode<Chord>(ChordPresets.ebdim, 0.12f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.16f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.12f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.amC, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.47f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.56f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.22f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emG, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.62f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.61f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.26f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.8f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.cm, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.56f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.22f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.48f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.61f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.76f),
										new MarkovChainNode<Chord>(ChordPresets.em7D, 0.06f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.em7B, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.44f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.56f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.13f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.21f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7C, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emB, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.89f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7G, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.gbm7, 1) // Listed as "f#m7b5"
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.35f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.43f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.42f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.71f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.21f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.17f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.06f),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.94f)
								})
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.em, 0.06f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.43f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.GD, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.emB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.CG, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.33f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.64f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.33f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.38f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.DF, 0.15f, new List<MarkovChainNode<Chord>> // Listed as "D/F?"
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.fdim, 0.05f, new List<MarkovChainNode<Chord>> // Listed as "f?*"
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.fdim, 1)// Listed as "f?*"
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.21f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.B, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.82f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.91f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.04f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.04f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.42f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.37f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GD, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.19f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.89f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.56f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.6f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.65f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.9f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.44f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.11f)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.12f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.25f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D7, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.85f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.38f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FA, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.74f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.68f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.21f),
										new MarkovChainNode<Chord>(ChordPresets.emG, 0.07f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.14f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.36f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.45f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.8f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.45f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.29f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.21f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.53f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.16f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.36f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.92f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.08f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.58f),
										new MarkovChainNode<Chord>(ChordPresets.abm7, 0.11f), // Listed as "g#m7b5"
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.79f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.78f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.96f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.04f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.36f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.15f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.15f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.22f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.62f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.73f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.78f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Cmaj6, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.50f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.36f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.77f),
										new MarkovChainNode<Chord>(ChordPresets.am7G, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.08f)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 1, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.3f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.3f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.52f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.86f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.23f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.38f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.25f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.12f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.8f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.25f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.05f)
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.24f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.43f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.77f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.81f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.25f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.GB, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.84f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.97f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.02f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.92f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.94f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.56f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.53f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.83f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.96f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.008f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.02f)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.05f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emB, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.B, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.25f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.6f),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.39f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.amE, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.82f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.36f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.45f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.ADb, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.66f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.64f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.31f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.29f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.emB, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.86f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.78f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.41f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.93f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.16f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.69f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.39f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.28f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.39f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.63f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.66f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.91f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.01f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.04f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.54f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.08f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.66f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.82f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.86f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.61f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.98f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.02f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.64f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.09f)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.E, 0.16f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.83f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.95f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.bdim, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gmBb, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.46f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.3f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.78f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.82f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.am7G, 0.08f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.abdim, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.16f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.66f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.63f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.13f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.26f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.32f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.abdim, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.19f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								})
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.G, 0.2f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.17f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.43f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dmF, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.11f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.77f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.79f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.43f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.73f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.31f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.fm6, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.4f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.56f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.95f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.07f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1f)
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.61f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.81f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.am, 0.21f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.82f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.16f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.68f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.1f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.19f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.47f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.94f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.ADb, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.36f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f)
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.37f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.71f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.56f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.97f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.03f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.64f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.38f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.38f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.13f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.emB, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.15f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.12f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.55f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.bdim, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.88f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.44f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.71f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.5f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.bdimD, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.Db, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.3f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.69f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.82f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.13f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.38f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.94f),
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.06f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.FA, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.63f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.37f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.89f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.37f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.gm, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.13f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.32f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.57f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.43f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.8f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.43f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.24f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.48f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.99f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.007f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.007f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.27f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.53f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.32f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.21f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.47f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.92f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.16f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.22f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.44f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.83f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.85f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.21f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.26f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.52f),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.19f),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08f)
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.45f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.88f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.27f),
										new MarkovChainNode<Chord>(ChordPresets.bdim, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.Gmaj6, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.gbdim, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.07f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.22f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.3f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.07f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.19f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.38f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.05f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.43f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.83f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.55f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.EAb, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.56f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.22f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.8f)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.05f)
							// other
						})
						// other
					}),
					new MarkovChainNode<Chord>(ChordPresets.G, 0.14f, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.C, 0.21f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.CE, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.FC, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.86f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.CG, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.D7Gb, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.42f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.57f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.18f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.29f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.63f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.73f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.07f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.26f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.17f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.18f),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.64f)
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.24f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.93f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.85f)
										// other
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.64f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.83f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.17f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm7, 0.19f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.G7, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am7G, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.gm, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.19f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Bb, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D7, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.64f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.76f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.12f),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.12f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.55f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.12f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.emG, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.8f),
										new MarkovChainNode<Chord>(ChordPresets.fm, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.63f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.FA, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CG, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.13f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.16f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dmF, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.83f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.86f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.62f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.21f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.55f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.44f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.83f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.8f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.07f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.66f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.93f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.Ab, 0.17f)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.29f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.24f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.59f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.28f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.58f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.77f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.36f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.61f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.81f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.41f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.05f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.22f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.56f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.11f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G7, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.47f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.72f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.06f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.84f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.79f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.09f)
										// other
									})
									// other
								})
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.19f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.28f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.28f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.48f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.69f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.24f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.55f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.18f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.19f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.43f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.23f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.77f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.15f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.33f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.26f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.77f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.91f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.49f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.8f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.06f)
										// other
									})
									// other
								})
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.15f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.36f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.25f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.15f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.26f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.8f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.68f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.53f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.69f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.83f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G7F, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7E, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.1f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.22f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.35f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.9f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.85f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.1f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.18f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.BD, 0.29f), // Listed as "B/D?"
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.cm, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.56f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.81f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.29f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.6f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.73f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.9f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.17f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.42f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.6f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.19f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.ADb, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.34f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.bm, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C7G, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.41f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.35f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.67f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am7, 0.05f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.E, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.25f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.emB, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.5f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.49f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.83f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.7f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.09f)
										// other
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.77f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.57f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.43f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.65f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.26f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.61f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.09f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.4f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 1)
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.34f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.5f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.88f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.95f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.17f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.92f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.73f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.19f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.22f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.09f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.44f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.38f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.46f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88f)
										// other
									})
									// other
								})
								// other
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.21f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.3f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.13f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.34f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.54f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.3f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7C, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.44f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.52f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.12f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.76f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.17f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.44f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.22f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.86f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.94f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.51f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.79f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.07f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.12f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.3f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.55f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.73f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.82f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.07f)
										// other
									})
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.13f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.27f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.87f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.88f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.51f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.emB, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.63f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.11f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.78f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.69f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.13f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.07f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.24f),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.31f),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.37f)
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.28f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.27f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.27f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.62f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.57f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.8f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.32f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.3f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.61f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.84f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.76f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.16f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.26f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.3f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.3f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.D7C, 0.05f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.55f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.18f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.67f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.72f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13f)
										// other
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.21f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.28f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.38f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.8f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.29f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.F, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.67f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.82f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.95f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.02f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.02f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07f),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.52f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.71f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.41f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.amC, 0.33f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.19f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.19f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.GB, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.29f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.dmA, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.abdim, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.32f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.CE, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.33f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.21f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.14f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.3f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.am7, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.45f),
										new MarkovChainNode<Chord>(ChordPresets.G7F, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.18f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.11f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.E, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.15f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.83f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17f)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.em, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.29f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.bm7, 0.67f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.14f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.EAb, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.48f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.8f)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.23f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em7, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.16f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.6f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.4f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.46f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.77f),
										new MarkovChainNode<Chord>(ChordPresets.dm7, 0.15f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.13f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.16f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.am, 0.39f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.57f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.29f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.34f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm7C, 0.29f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.43f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.C, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									})
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.31f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.Bb, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.8f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.96f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.08f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.61f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.6f),
										new MarkovChainNode<Chord>(ChordPresets.Bb, 0.2f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.22f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
								})
							})
							// other
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.26f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.em, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.75f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.25f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.Fmaj6, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.8f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.24f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.6f),
										new MarkovChainNode<Chord>(ChordPresets.Eb, 0.2f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.27f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.7f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.59f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.33f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.33f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.2f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.21f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.47f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.16f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.42f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.36f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.45f),
										new MarkovChainNode<Chord>(ChordPresets.Cmaj7B, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.09f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 0.84f)
										// other
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.2f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.11f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.CE, 0.38f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.43f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.64f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.21f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.31f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 0.84f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.08f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.75f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.31f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.19f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.17f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.56f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.62f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.72f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.13f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.42f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.18f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.18f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.06f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.65f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.53f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.09f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.76f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.FC, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.21f),
										new MarkovChainNode<Chord>(ChordPresets.E, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.D, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.42f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.36f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.43f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.07f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.14f)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.F, 0.61f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.23f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.19f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.44f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.25f),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.06f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.55f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.13f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.72f),
										new MarkovChainNode<Chord>(ChordPresets.em, 0.1f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.22f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.22f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.44f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.am, 0.12f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.07f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.E7, 0.5f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.5f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.G, 0.33f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.2f),
										new MarkovChainNode<Chord>(ChordPresets.GD, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.7f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.27f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.em, 0.3f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.11f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.67f)
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.12f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.am, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.7f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.em, 0.76f),
										new MarkovChainNode<Chord>(ChordPresets.C, 0.14f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.em7, 0.05f)
									}),
									new MarkovChainNode<Chord>(ChordPresets.F, 0.08f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.G, 1)
									}),
									new MarkovChainNode<Chord>(ChordPresets.D, 0.05f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 1)
									})
									// other
								})
								// other
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.36f, new List<MarkovChainNode<Chord>>
							{
								new MarkovChainNode<Chord>(ChordPresets.C, 0.53f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.G, 0.89f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.F, 0.08f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.84f)
										// other
									})
									// other
								}),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.32f, new List<MarkovChainNode<Chord>>
								{
									new MarkovChainNode<Chord>(ChordPresets.C, 0.17f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.D, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.12f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.61f),
										new MarkovChainNode<Chord>(ChordPresets.am, 0.12f)
										// other
									}),
									new MarkovChainNode<Chord>(ChordPresets.am, 0.65f, new List<MarkovChainNode<Chord>>
									{
										new MarkovChainNode<Chord>(ChordPresets.C, 0.05f),
										new MarkovChainNode<Chord>(ChordPresets.G, 0.1f),
										new MarkovChainNode<Chord>(ChordPresets.F, 0.71f)
										// other
									})
									// other
								})
								// other
							})
							// other
						})
					}),
					new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.C, 0.13f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.18f),
							new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.12f),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.13f),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.28f)
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.16f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.34f),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.16f),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.25f),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.05f),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f)
						}),
						new MarkovChainNode<Chord>(ChordPresets.G, 0.16f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.4f),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.17f),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.09f),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.1f)
						}),
						new MarkovChainNode<Chord>(ChordPresets.em, 0.09f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.05f),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.21f),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.49f),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.09f)
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.18f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.18f),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.12f),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.18f),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.21f),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07f)
						})
					}),
					new MarkovChainNode<Chord>(ChordPresets.em, 0.03f, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.11f),
							new MarkovChainNode<Chord>(ChordPresets.GB, 0.05f),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.16f),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.16f),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.18f),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.11f)
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.08f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.17f),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.16f),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.19f),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.24f),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.12f)
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.33f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.19f),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.14f),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.34f),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.12f),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.06f)
						}),
						new MarkovChainNode<Chord>(ChordPresets.G, 0.08f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.23f),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.34f),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.14f),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.07f),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.07f)
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.26f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.08f),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.16f),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.21f),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.23f),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.15f)
						})
					}),
					new MarkovChainNode<Chord>(ChordPresets.am7, 0.02f, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.C, 0.05f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f)
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm7, 0.09f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.F, 0.47f),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.09f),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.15f),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7E, 0.09f)
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.06f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.05f),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.06f),
							new MarkovChainNode<Chord>(ChordPresets.FA, 0.06f),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.44f),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.12f)
						}),
						new MarkovChainNode<Chord>(ChordPresets.em7, 0.06f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.1f),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.2f),
							new MarkovChainNode<Chord>(ChordPresets.gm7, 0.07f),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.19f),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.22f)
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.13f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.33f),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.1f),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.28f)
						}),
						new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.05f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.05f),
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.1f),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.06f),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.1f),
							new MarkovChainNode<Chord>(ChordPresets.G7, 0.11f),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.05f),
							new MarkovChainNode<Chord>(ChordPresets.em7, 0.23f)
						}),
						new MarkovChainNode<Chord>(ChordPresets.G, 0.15f, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.15f),
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.16f),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.11f),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.32f),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05f)
						})
					})
					//new MarkovChainNode<Chord>(ChordPresets.CE, 0.02f),
					//new MarkovChainNode<Chord>(ChordPresets.dm7, 0.02f),
					//new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.02f),
					//new MarkovChainNode<Chord>(ChordPresets.Bb, 0.01f),
					//new MarkovChainNode<Chord>(ChordPresets.CG, 0.01f),
					//new MarkovChainNode<Chord>(ChordPresets.E, 0.01f),
					//new MarkovChainNode<Chord>(ChordPresets.em7, 0.01f),
					//new MarkovChainNode<Chord>(ChordPresets.GB, 0.01f),
					//new MarkovChainNode<Chord>(ChordPresets.G7, 0.01f),
					//new MarkovChainNode<Chord>(ChordPresets.Cmaj7, 0.008f),
					//new MarkovChainNode<Chord>(ChordPresets.amE, 0.007f),
					//new MarkovChainNode<Chord>(ChordPresets.D, 0.007f)
				};
			}
		}
	}
}
