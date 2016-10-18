using System.Collections.Generic;
using System.Linq;

namespace NewWave.Generator.ChordProgressions
{
	internal class MarkovChainNode<T>
	{
		internal readonly T Data;
		internal readonly List<MarkovChainNode<T>> ChildNodes;
		private readonly double _probability;

		public MarkovChainNode(T data, double probability, List<MarkovChainNode<T>> childNodes)
		{
			Data = data;
			_probability = probability;
			ChildNodes = childNodes;
		}

		internal static MarkovChainNode<T> Choose(List<MarkovChainNode<T>> nodes)
		{
			return nodes.Count == 0
				? null
				: nodes[Randomizer.GetWeightedIndex(nodes.Select(n => n._probability).ToList())];
		}
	}
}
