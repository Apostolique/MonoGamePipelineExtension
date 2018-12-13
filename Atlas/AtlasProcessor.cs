using System;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace MonoGameContentPipelineExamples.Atlas
{
    /// <summary>
    /// This class will be instantiated by the XNA Framework Content Pipeline
    /// to apply custom processing to content data, converting an object of
    /// type TInput to TOutput. The input and output types may be the same if
    /// the processor wishes to alter data without changing its type.
    ///
    /// This should be part of a Content Pipeline Extension Library project.
    ///
    /// TODO: change the ContentProcessor attribute to specify the correct
    /// display name for this processor.
    /// </summary>
    [ContentProcessor(DisplayName = "MonoGameContentPipelineExamples - Atlas Processor")]
    public class AtlasProcessor : ContentProcessor<AtlasFile, AtlasProcessorResult>
    {
        public override AtlasProcessorResult Process(AtlasFile input, ContentProcessorContext context) {
            try {
                var output = new AtlasProcessorResult { Data = input };
                return output;
            } catch (Exception ex) {
                context.Logger.LogMessage("Error {0}", ex);
                throw;
            }
        }
    }
}