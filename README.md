# NewWave
NewWave is a .NET music generation engine. It uses procedural generation and customized algorithms to create full instrumental songs.

## Usage
Create a test in the unit test project (there are several examples already there) that calls the `RenderAndPlay` function. It will save a MIDI file to the `NewWave.Test\bin\Debug` directory and open it up with whatever music player you have set to default.

## Projects

* **NewWave.Core**
  * Contains an interface for the `Song` class which is implemented by the Generator library
  * Contains the `Score` class, a "rendered" song that can be saved as a MIDI file
  * Contains common classes like instrument tracks and `TimeSignature`
* **NewWave.Generator**
  * Where the magic happens. Generates chord progressions, drum grooves, arrangements, etc. and layers it all together
* **NewWave.Library**
  * Contains the `Chord` class
  * Contains the `GrooveLibrary` class (currently only used for testing) and methods for printing drum tabs when testing
  * Mostly unused in general, but will probably eventually contain more common functionality
* **NewWave.Midi**
  * Enums for MIDI generation
* **NewWave.Test**
  * As NewWave currently has no executable, unit tests are used for testing and executing all functionality, including full-stack custom song generation.

## Dependencies

* `Sanford.Multimedia.Midi`
  * Leslie Sanford's MIDI toolkit, used for MIDI file generation
  * https://github.com/tebjan/Sanford.Multimedia.Midi
  * http://www.codeproject.com/Articles/6228/C-MIDI-Toolkit
* `Microsoft.Net.Compilers`
  * NewWave uses C# 6 features, so this is needed so work can be done with versions of Visual Studio that don't natively support it (2013 and older).

## Git branching structure

* `master` — "production"-quality code; currently NewWave is nowhere close to being ready for this.
* `develop` — main development branch. Extra work on the `NewWave.Core` project should go here. As stable and feature-complete as possible.
* `generator` — active branch for the `NewWave.Generator` project, where most of the work is currently happening. Merges back into `develop`.
