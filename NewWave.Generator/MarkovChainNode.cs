using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Generator.Common;

namespace NewWave.Generator
{
    public class MarkovChainNode<T>
    {
        internal readonly T Data;
        internal readonly List<MarkovChainNode<T>> ChildNodes;
        internal readonly double Probability;

        public MarkovChainNode(T data, double probability, List<MarkovChainNode<T>> childNodes = null)
        {
            Data = data;
            Probability = probability;
            ChildNodes = childNodes;
        }

        internal static MarkovChainNode<T> Choose(IEnumerable<MarkovChainNode<T>> nodes, Func<MarkovChainNode<T>, MarkovChainNode<T>> filterFunc)
        {
            var filteredNodes = nodes.Select(filterFunc).ToList();

            return filteredNodes.Count == 0
				? null
                : filteredNodes[Randomizer.GetWeightedIndex(filteredNodes.Select(n => n.Probability).ToList())];
		}
    }
}
