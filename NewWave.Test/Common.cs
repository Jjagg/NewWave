using System;
using System.Diagnostics;
using System.IO;
using NewWave.Core;
using NewWave.Generator;
using NewWave.Generator.Parameters;
using NewWave.Midi;

namespace NewWave.Test
{
	internal static class Common
	{
		private static readonly string Dir = AppDomain.CurrentDomain.BaseDirectory;

		internal static MarkovGeneratorSong RenderAndPlay(MarkovGeneratorParameters parameterList, string fileName)
		{
		    var song = MarkovGeneratorSong.Generate(parameterList);
			Console.WriteLine(song.ToString());
			var score = song.Render();
			var outputPath = Path.Combine(Dir, fileName);
			score.ExportMidi(outputPath);
			Process.Start(outputPath);

		    return song;
		}
	}
}
