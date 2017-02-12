using System;
using System.Collections.Generic;
using System.Linq;
using NewWave.Core;
using NewWave.Midi;

namespace NewWave.Generator.Grooves
{
	public static class FillGenerator
	{
		public static IEnumerable<PercussionNote> GetFill(float delay, float fillLengthInBeats, int feel)
		{
			var lengthOfNote = 1.0f / feel;
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
			new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.SnareDrum1, 1), 0.5f, SnareChain),
			new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.SnareDrum1, 1), 0.3f, HiTomChain),
			new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.HighTom1, 1), 0.2f, MidTomChain)
		};

		private static List<Func<MarkovChainNodeFunc<FillSection>>> SnareChain => new List<Func<MarkovChainNodeFunc<FillSection>>>
		{
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.HighTom1, 0.5f), 0.5f, HiTomChain),
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.MidTom1, 0.5f), 0.3f, MidTomChain),
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.SnareDrum1, 0.5f), 0.2f, SnareChain)
		};

		private static List<Func<MarkovChainNodeFunc<FillSection>>> HiTomChain => new List<Func<MarkovChainNodeFunc<FillSection>>>
		{
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.MidTom1, 0.5f), 0.5f, MidTomChain),
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.SnareDrum1, 0.5f), 0.5f, SnareChain)
		};

		private static List<Func<MarkovChainNodeFunc<FillSection>>> MidTomChain => new List<Func<MarkovChainNodeFunc<FillSection>>>
		{
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.LowTom1, 0.5f), 0.5f, LowTomChain),
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.SnareDrum1, 0.5f), 0.5f, SnareChain)
		};

		private static List<Func<MarkovChainNodeFunc<FillSection>>> LowTomChain => new List<Func<MarkovChainNodeFunc<FillSection>>>
		{
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.LowTom1, 0.5f), 0.5f, LowTomChain),
			() => new MarkovChainNodeFunc<FillSection>(new FillSection(Percussion.SnareDrum1, 0.5f), 0.5f, SnareChain)
		};

		private static IEnumerable<FillSection> FillChain(Func<MarkovChainNodeFunc<FillSection>, MarkovChainNodeFunc<FillSection>> filterFunc, float fillLengthInBeats)
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
			public readonly float Length;

			public FillSection(Percussion note, float length)
			{
				Note = note;
				Length = length;
			}
		}
	}
}
