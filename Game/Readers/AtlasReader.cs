using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Content;
using MonoGame.Extended.TextureAtlases;

namespace PipelineExtension.Readers
{
    class AtlasReader : ContentTypeReader<Atlas>
    {
        protected override Atlas Read(ContentReader reader, Atlas existingInstance) {
            string file = reader.ReadString();
            Texture2D t = reader.ContentManager.Load<Texture2D>(reader.GetRelativeAssetName(file));
            int regionCount = reader.ReadInt32();

            Dictionary<string, TextureRegion2D> objects = new Dictionary<string, TextureRegion2D>();

            for (int i = 0; i < regionCount; i++) {
                string name = reader.ReadString();
                int position_x = reader.ReadInt32();
                int position_y = reader.ReadInt32();
                int width = reader.ReadInt32();
                int height = reader.ReadInt32();

                TextureRegion2D region = new TextureRegion2D(t, position_x, position_y, width, height);
                objects.Add(name, region);
            }

            Atlas atlas = new Atlas(objects);
            return atlas;
        }
    }
}
