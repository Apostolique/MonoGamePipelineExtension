using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;

namespace MonoGameContentPipelineExamples.Atlas
{
    [ContentTypeWriter]
    class AtlasWriter : ContentTypeWriter<AtlasProcessorResult>
    {
        protected override void Write(ContentWriter writer, AtlasProcessorResult result) {
            writer.Write(result.Data.file);
            writer.Write(result.Data.atlas.Count);
            foreach (AtlasFile.JsonAtlas ja in result.Data.atlas) {
                writer.Write(ja.name);
                writer.Write(ja.position_x);
                writer.Write(ja.position_y);
                writer.Write(ja.width);
                writer.Write(ja.height);
            }
        }
        public override string GetRuntimeType(TargetPlatform targetPlatform) {
            return "MonoGameContentPipelineExamples.Readers.Atlas, MonoGameContentPipelineExamples";
        }
        public override string GetRuntimeReader(TargetPlatform targetPlatform) {
            return "MonoGameContentPipelineExamples.Readers.AtlasReader, MonoGameContentPipelineExamples";
        }
    }
}
