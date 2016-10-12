using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewWave.Test
{
	[TestClass]
	public class SimpleTests
	{
		[TestMethod]
		public void ScoreTest()
		{
			Common.RenderAndPlay(new TestSong(), "output.mid");
		}
	}
}
