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
									new MarkovChainNode<Chord>(ChordPresets.E, .78, null)
								}),
								new MarkovChainNode<Chord>(ChordPresets.Ab, 0.01, null),
								new MarkovChainNode<Chord>(ChordPresets.G, 0.1, null),
								new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.01, null),
								new MarkovChainNode<Chord>(ChordPresets.F, 0.66, null),
								new MarkovChainNode<Chord>(ChordPresets.E, 0.01, null),
								new MarkovChainNode<Chord>(ChordPresets.em, 0.05, null),
								new MarkovChainNode<Chord>(ChordPresets.E7, 0.007, null),
								new MarkovChainNode<Chord>(ChordPresets.D, 0.007, null),
								new MarkovChainNode<Chord>(ChordPresets.dm, 0.02, null),
								new MarkovChainNode<Chord>(ChordPresets.C, 0.06, null)
							}),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.25, null),
							new MarkovChainNode<Chord>(ChordPresets.C, 0.14, null),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.10, null),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.02, null),
							new MarkovChainNode<Chord>(ChordPresets.Fmaj7, 0.007, null),
							new MarkovChainNode<Chord>(ChordPresets.E, 0.007, null),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.02, null),
							new MarkovChainNode<Chord>(ChordPresets.dm7, 0.008, null),
							new MarkovChainNode<Chord>(ChordPresets.D, 0.01, null),
							new MarkovChainNode<Chord>(ChordPresets.GB, 0.008, null),
							new MarkovChainNode<Chord>(ChordPresets.Bb, 0.02, null),
						}),
						new MarkovChainNode<Chord>(ChordPresets.F, 0.19, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.32, null),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.12, null),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.30, null),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, null)
						}),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.1, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.11, null),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.23, null),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.32, null),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.08, null),
							new MarkovChainNode<Chord>(ChordPresets.dm, 0.09, null)
						}),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.06, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.13, null),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.25, null),
							new MarkovChainNode<Chord>(ChordPresets.G, 0.10, null),
							new MarkovChainNode<Chord>(ChordPresets.em, 0.13, null),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.17, null),
							new MarkovChainNode<Chord>(ChordPresets.CE, 0.06, null)
						}),
						new MarkovChainNode<Chord>(ChordPresets.GB, 0.05, new List<MarkovChainNode<Chord>>
						{
							new MarkovChainNode<Chord>(ChordPresets.C, 0.07, null),
							new MarkovChainNode<Chord>(ChordPresets.F, 0.07, null),
							new MarkovChainNode<Chord>(ChordPresets.FA, 0.07, null),
							new MarkovChainNode<Chord>(ChordPresets.am, 0.5, null),
							new MarkovChainNode<Chord>(ChordPresets.am7, 0.08, null)
						}),
					}),
					new MarkovChainNode<Chord>(ChordPresets.F, 0.15, new List<MarkovChainNode<Chord>>
					{
						new MarkovChainNode<Chord>(ChordPresets.G, 0.29, null),
						new MarkovChainNode<Chord>(ChordPresets.C, 0.29, null),
						new MarkovChainNode<Chord>(ChordPresets.am, 0.1, null),
						new MarkovChainNode<Chord>(ChordPresets.dm, 0.05, null),
					})
				};
			}
		}
	}
}
