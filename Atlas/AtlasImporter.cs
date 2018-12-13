using System.IO;
using Microsoft.Xna.Framework.Content.Pipeline;
using Newtonsoft.Json;

namespace MonoGameContentPipelineExamples.Atlas
{
    /// <summary>
    /// This class will be instantiated by the XNA Framework Content Pipeline
    /// to import a file from disk into the specified type, TImport.
    ///
    /// This should be part of a Content Pipeline Extension Library project.
    ///
    /// TODO: change the ContentImporter attribute to specify the correct file
    /// extension, display name, and default processor for this importer.
    /// </summary>

    [ContentImporter(".json", DisplayName = "MonoGameContentPipelineExamples - Atlas Importer", DefaultProcessor = "AtlasProcessor")]
    public class AtlasImporter : ContentImporter<AtlasFile>
    {
        public override AtlasFile Import(string filename, ContentImporterContext context) {
            context.Logger.LogMessage("Importing Atlas: {0}", filename);
            // Process the input object, and return the modified data.
            using (var streamReader = new StreamReader(filename)) {
                string jsonRaw = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<AtlasFile>(jsonRaw);
            }
        }
    }
}
