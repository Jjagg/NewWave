using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator;
using NewWave.Generator.Parameters;
using NewWave.Generator.Sections;

namespace NewWave.Test.GeneratorTests
{
	[TestClass]
	public class ParameterizedGenerators
	{
		[TestMethod]
		public void Default()
		{
			RenderAndPlay(new ParameterListBase());
		}

		[TestMethod]
		public void MinorFastSong()
		{
			var parameters = new ParameterListBase()
				.Apply(new MinorKeyParameterList())
				.Apply(new TempoParameter(200, 10))
				.Apply(new SongLengthParameter(180, 30))
				.Apply(new SectionLengthParameter(LongSections));
			RenderAndPlay(parameters);
		}

		private static Func<SectionType, int> LongSections
		{
			get { return type => type == SectionType.Verse || type == SectionType.Chorus ? 16 : 8; }
		}

		private static Func<SectionType, int> ShortSections
		{
			get { return type => type == SectionType.Verse ? 1 : 2; }
		}

		[TestMethod]
		public void SlowSong()
		{
			RenderAndPlay(new ParameterListBase()
				.Apply(new TempoParameter(100, 5)));
		}

		private static void RenderAndPlay(IParameterList parameterList)
		{
			var song = new GeneratedSong();
			Common.RenderAndPlay(parameterList, song, "output.mid");
			foreach (var section in song.Sections)
			{
				Console.WriteLine("{0}: {1} meas, {2}", section.Type, section.Measures, string.Join(" - ", section.Chords.Select(c => c.Item2)));
			}
		}
	}
}
