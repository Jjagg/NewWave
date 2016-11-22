using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;

namespace NewWave.Test
{
	[TestClass]
	public class SimpleTests
	{
		[TestMethod]
		public void RenderTest()
		{
			Common.RenderAndPlay(new Parameters(), new TestSong(), "output.mid");
		}

		private class Parameters : IParameters { }
	}
}
