# MonoGamePipelineExtension
Examples for content pipeline extensions in MonoGame.

## Atlas

Atlas is a custom json file with information about how a single texture is split into many different textures within it.

* The `PipelineExtension/Atlas` folder contains all the classes that will be included in the Content Pipeline Extension dll.
* The `Game/Readers` folder contains the classes that would be present on the Game's side.
* `Game/Content/example_atlas.json` shows an example file that can be processed using the MonoGame Content Pipeline Extension.

## Build

To build the extension:

1. Run `dotnet build PipelineExtension -c Release`
2. Add `PipelineExtension\bin\Release\netstandard2.0\PipelineExtension.dll` as a reference in the MonoGame pipeline.
3. Add `PipelineExtension\bin\Release\netstandard2.0\System.Text.Json.dll` as a reference in the MonoGame pipeline.
