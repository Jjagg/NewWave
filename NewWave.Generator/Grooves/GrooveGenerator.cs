using System.Collections.Generic;
using NewWave.Core;
using NewWave.Library.Grooves;

namespace NewWave.Generator.Grooves
{
    internal static class GrooveGenerator
    {
        internal static Groove GenerateGroove(TimeSignature timeSignature)
        {
            return new Groove("Generated groove", timeSignature, 4, 4, new List<double>(), new List<double>());
        }
    }
}
