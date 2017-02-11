using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Midi;

namespace NewWave.Generator.Grooves
{
	public static class FillGenerator
	{
		public static IEnumerable<PercussionNote> GetFill(double delay, double fillLengthInBeats, int feel)
		{
			var lengthOfNote = 1.0 / feel;
			var chain = FillChain(n => n, fillLengthInBeats).ToList();
			var hits = new List<PercussionNote>();
			foreach (var c in chain)
			{
				var theseHits = Enumerable.Range(0, (int)(c.Length / lengthOfNote)).Select(n => new PercussionNote(delay + n * lengthOfNote, (int) c.Note, (int) (n == 0 ? Velocity.Fff : Velocity.F))).ToList();
				hits.AddRange(theseHits);
				delay += c.Length;
			}
			
			return hits;
		}

		private static List<MarkovChainNodeFunc<FillSection>> Chain => new List<MarkovChainNodeFunc<FillSection>>
		{
			new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.SnareDrum1, 1), 0.5, SnareChain),
			new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.SnareDrum1, 1), 0.3, HiTomChain),
			new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.HighTom1, 1), 0.2, MidTomChain)
		};

		private static List<Func<MarkovChainNodeFunc<FillSection>>> SnareChain => new List<Func<MarkovChainNodeFunc<FillSection>>>
		{
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.HighTom1, 0.5), 0.5, HiTomChain),
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.MidTom1, 0.5), 0.3, MidTomChain),
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.SnareDrum1, 0.5), 0.2, SnareChain)
		};

		private static List<Func<MarkovChainNodeFunc<FillSection>>> HiTomChain => new List<Func<MarkovChainNodeFunc<FillSection>>>
		{
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.MidTom1, 0.5), 0.5, MidTomChain),
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.SnareDrum1, 0.5), 0.5, SnareChain)
		};

		private static List<Func<MarkovChainNodeFunc<FillSection>>> MidTomChain => new List<Func<MarkovChainNodeFunc<FillSection>>>
		{
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.LowTom1, 0.5), 0.5, LowTomChain),
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.SnareDrum1, 0.5), 0.5, SnareChain)
		};

		private static List<Func<MarkovChainNodeFunc<FillSection>>> LowTomChain => new List<Func<MarkovChainNodeFunc<FillSection>>>
		{
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.LowTom1, 0.5), 0.5, LowTomChain),
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.SnareDrum1, 0.5), 0.5, SnareChain)
		};

		private static IEnumerable<FillSection> FillChain(Func<MarkovChainNodeFunc<FillSection>, MarkovChainNodeFunc<FillSection>> filterFunc, double fillLengthInBeats)
		{
			var chains = new List<FillSection>();
			var chain = Chain;

			do
			{
				var section = MarkovChainNodeFunc<FillSection>.Choose(chain, filterFunc);
				if (section != null)
				{
					chains.Add(section.Data);
					chain = section.ChildNodes.Select(n => n()).ToList();
				}
			} while (chain != null && chain.Count > 0 && chains.Sum(c => c.Length) < fillLengthInBeats);

			return chains;
		}

		private struct FillSection
		{
			public readonly Percussion Note;
			public readonly double Length;

			public FillSection(Percussion note, double length)
			{
				Note = note;
				Length = length;
			}
		}
	}
}
