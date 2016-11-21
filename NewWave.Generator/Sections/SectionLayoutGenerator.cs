using System;
using System.Collections.Generic;
using System.Linq;

namespace NewWave.Generator.Sections
{
	internal static class SectionLayoutGenerator
	{
		internal static IEnumerable<SectionType> GetSectionLayout()
		{
			return FillChain(n => n).ToList();
		}

		private static List<MarkovChainNodeFunc<SectionType>> Chain => new List<MarkovChainNodeFunc<SectionType>>
		{
			new MarkovChainNodeFunc<SectionType>(SectionType.Intro, 0.7, JustVerseChain),
			new MarkovChainNodeFunc<SectionType>(SectionType.Verse, 0.3, VerseChain)
		};

		private static List<Func<MarkovChainNodeFunc<SectionType>>> JustVerseChain => new List<Func<MarkovChainNodeFunc<SectionType>>>
		{
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Verse, 1, VerseChain)
		};

		private static List<Func<MarkovChainNodeFunc<SectionType>>> VerseChain => new List<Func<MarkovChainNodeFunc<SectionType>>>
		{
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Verse, 0.2, VerseChain),
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Prechorus, 0.4, PrechorusChain),
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Chorus, 0.4, ChorusChain)
		};

		private static List<Func<MarkovChainNodeFunc<SectionType>>> PrechorusChain => new List<Func<MarkovChainNodeFunc<SectionType>>>
		{
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Chorus, 1, ChorusChain)
		};

		private static List<Func<MarkovChainNodeFunc<SectionType>>> ChorusChain => new List<Func<MarkovChainNodeFunc<SectionType>>>
		{
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Verse, 0.5, VerseChain),
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Bridge, 0.3, BridgeChain),
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Outro, 0.2, OutroChain)
		};

		private static List<Func<MarkovChainNodeFunc<SectionType>>> BridgeChain => new List<Func<MarkovChainNodeFunc<SectionType>>>
		{
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Verse, 0.3, VerseChain),
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Verse, 0.7, ChorusChain)
		};

		private static List<Func<MarkovChainNodeFunc<SectionType>>> OutroChain => new List<Func<MarkovChainNodeFunc<SectionType>>>
		{
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Verse, 1, OutroChain)
		};

		private static IEnumerable<SectionType> FillChain(Func<MarkovChainNodeFunc<SectionType>, MarkovChainNodeFunc<SectionType>> filterFunc)
		{
			var sections = new List<SectionType>();
			var chain = Chain;

			do
			{
				var section = MarkovChainNodeFunc<SectionType>.Choose(chain, filterFunc);
				if (section != null)
				{
					sections.Add(section.Data);
					chain = section.ChildNodes.Select(n => n()).ToList();
				}
			} while (chain != null && chain.Count > 0 && sections.Last() != SectionType.Outro);

			return sections;
		}
	}
}
