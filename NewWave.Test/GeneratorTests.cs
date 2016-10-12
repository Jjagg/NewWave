using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Generator;

namespace NewWave.Test
{
	[TestClass]
	public class GeneratorTests
	{
		[TestMethod]
		public void RenderTest()
		{
			Common.RenderAndPlay(new GeneratedSong(), "output.mid");
		}
	}
}
