using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Generator.Common;

namespace NewWave.Generator
{
	public class MarkovChainNodeFunc<T>
	{
		internal readonly T Data;
		internal readonly List<Func<MarkovChainNodeFunc<T>>> ChildNodes;
		private readonly double _probability;

		public MarkovChainNodeFunc(T data, double probability, List<Func<MarkovChainNodeFunc<T>>> childNodes = null)
		{
			Data = data;
			_probability = probability;
			ChildNodes = childNodes;
		}

		internal static MarkovChainNodeFunc<T> Choose(IEnumerable<MarkovChainNodeFunc<T>> nodes, Func<MarkovChainNodeFunc<T>, MarkovChainNodeFunc<T>> filterFunc)
		{
			var filteredNodes = nodes.Select(filterFunc).ToList();

			return filteredNodes.Count == 0
				? null
				: filteredNodes[Randomizer.GetWeightedIndex(filteredNodes.Select(n => n._probability).ToList())];
		}
	}
}
