using System.Linq;
using NewWave.Library.Chords;

namespace NewWave.Generator.Parameters
{
	public class MinorKeyParameterList : IParameter
	{
		public void Apply(ParameterListBase parameterListBase)
		{
			parameterListBase.ChordProgressionFilter = n =>
				n.Data.Quality != ChordQuality.Minor && n.Data.Quality != ChordQuality.Diminished
					? new MarkovChainNode<Chord>(n.Data, n.Probability * 0.25, n.ChildNodes?.Where(c => c.Probability > 0.08).ToList())
					: n;
		}
	}
}
