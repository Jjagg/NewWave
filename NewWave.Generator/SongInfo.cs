﻿using NewWave.Core;
using NewWave.Generator.Parameters;

namespace NewWave.Generator
{
	public class SongInfo
	{
		public readonly TimeSignature TimeSignature;
		public readonly int Feel;

		public int Tempo;

		private ParameterListBase _parameters;
		public ParameterListBase Parameters
		{
			get { return _parameters; }
			set
			{
				_parameters = value;
				if (_parameters != null)
				{
					Tempo = (int)Randomizer.NextNormalized(value.TempoMean, value.TempoStandardDeviation);
				}
			}
		}

		public SongInfo(TimeSignature timeSignature, int feel)
		{
			TimeSignature = timeSignature;
			Feel = feel;
		}
	}
}
