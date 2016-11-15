using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewWave.Core;
using NewWave.Generator.Grooves;
using NewWave.Library.Grooves;
using NewWave.Midi;

namespace NewWave.Test.GeneratorTests
{
    [TestClass]
    public class GrooveTests
    {
        [TestMethod]
        public void GenerateGroove()
        {
            var timeSignature = TimeSignature.CommonTime;
            var groove = GrooveGenerator.GenerateGroove(timeSignature);
            Console.WriteLine(TabWriter.AsTab(groove.Feel, groove.Notes(Percussion.RideCymbal1, false, timeSignature), timeSignature.BeatCount));
        }
    }
}
