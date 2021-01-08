using System.Collections.Generic;
using MonoGame.Extended.TextureAtlases;

namespace PipelineExtension.Readers
{
    class Atlas
    {
        public Atlas(Dictionary<string, TextureRegion2D> iRegions) {
            regions = iRegions;
        }

        public Dictionary<string, TextureRegion2D> regions;
    }
}
