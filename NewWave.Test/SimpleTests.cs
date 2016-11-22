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
			Common.RenderAndPlay(new ParameterList(), new TestSong(), "output.mid");
		}

		private class ParameterList : IParameterList { }
	}
}
