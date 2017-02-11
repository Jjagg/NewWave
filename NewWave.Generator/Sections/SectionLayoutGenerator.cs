using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Generator.Common;

namespace NewWave.Generator.Sections
{
	internal class SectionLayoutGenerator
	{
		private double _idealMeasures;
		private int _estimatedMeasures;

		internal IEnumerable<SectionType> GetSectionLayout(SongInfo songInfo)
		{
			return FillChain(songInfo, n => n).ToList();
		}

		private List<MarkovChainNodeFunc<SectionType>> Chain => new List<MarkovChainNodeFunc<SectionType>>
		{
			new MarkovChainNodeFunc<SectionType>(SectionType.Intro, 0.7, JustVerseChain),
			new MarkovChainNodeFunc<SectionType>(SectionType.Verse, 0.3, VerseChain)
		};

		private List<Func<MarkovChainNodeFunc<SectionType>>> JustVerseChain => new List<Func<MarkovChainNodeFunc<SectionType>>>
		{
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Verse, 1, VerseChain)
		};

		private List<Func<MarkovChainNodeFunc<SectionType>>> VerseChain => new List<Func<MarkovChainNodeFunc<SectionType>>>
		{
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Verse, 0.2, VerseChain),
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Prechorus, 0.4, PrechorusChain),
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Chorus, 0.4, ChorusChain)
		};

		private List<Func<MarkovChainNodeFunc<SectionType>>> PrechorusChain => new List<Func<MarkovChainNodeFunc<SectionType>>>
		{
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Chorus, 1, ChorusChain)
		};

		private List<Func<MarkovChainNodeFunc<SectionType>>> ChorusChain => new List<Func<MarkovChainNodeFunc<SectionType>>>
		{
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Verse, _estimatedMeasures > _idealMeasures ? 0 : 0.6, VerseChain),
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Bridge, _estimatedMeasures > _idealMeasures ? 0 : 0.4, BridgeChain),
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Outro, _estimatedMeasures > _idealMeasures ? 1 : 0, OutroChain)
		};

		private List<Func<MarkovChainNodeFunc<SectionType>>> BridgeChain => new List<Func<MarkovChainNodeFunc<SectionType>>>
		{
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Verse, 0.3, VerseChain),
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Verse, 0.7, ChorusChain)
		};

		private List<Func<MarkovChainNodeFunc<SectionType>>> OutroChain => new List<Func<MarkovChainNodeFunc<SectionType>>>
		{
			() => new MarkovChainNodeFunc<SectionType>(SectionType.Verse, 1, OutroChain)
		};

		private IEnumerable<SectionType> FillChain(SongInfo songInfo, Func<MarkovChainNodeFunc<SectionType>, MarkovChainNodeFunc<SectionType>> filterFunc)
		{
			_idealMeasures = songInfo.Tempo * (songInfo.LengthInSeconds / 60) / songInfo.TimeSignature.BeatCount;

			var sections = new List<SectionType>();
			var chain = Chain;

			do
			{
				var section = MarkovChainNodeFunc<SectionType>.Choose(chain, filterFunc);
				if (section != null)
				{
					sections.Add(section.Data);
					_estimatedMeasures += 16;
					chain = section.ChildNodes.Select(n => n()).ToList();
				}
			} while (chain != null && chain.Count > 0 && sections.Last() != SectionType.Outro);

			return sections;
		}
	}
}
