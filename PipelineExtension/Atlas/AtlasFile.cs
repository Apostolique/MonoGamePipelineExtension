using System.Collections.Generic;

namespace PipelineExtension.Atlas
{
    public class AtlasFile
    {
        public string file;
        public List<JsonAtlas> atlas;

        public class JsonAtlas
        {
            public string name;
            public int position_x;
            public int position_y;
            public int width;
            public int height;
        }
    }
}
