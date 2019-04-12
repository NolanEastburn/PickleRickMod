using Microsoft.Xna.Framework.Graphics;
using StardewModdingAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickleRickMod
{
    public class ModEntry : Mod, IAssetEditor
    {
        public bool CanEdit<T>(IAssetInfo asset)
        {
            if(asset.AssetNameEquals("Maps/springobjects"))
            {
                return true;
            }

            if(asset.AssetNameEquals("Data/ObjectInformation"))
            {
                return true;
            }

            if(asset.AssetNameEquals("Data/Fish"))
            {
                return true;
            }
            if(asset.AssetNameEquals("Data/Furniture"))
            {                
                return true;
            }

            if(asset.AssetNameEquals("TileSheets/furniture"))
            {
                return true;
            }
            return false;
        }

        public void Edit<T>(IAssetData asset)
        {
            if (asset.AssetNameEquals("Data/Furniture"))
            {
                //Monitor.Log($"Added asset in '{asset.AssetName}'.");
                IDictionary<int, string> data = asset.AsDictionary<int, string>().Data;
                data[1306] = "Pickle Rick Statue - Color 1969/decor/1 2/1 1/1/500";
                data[1305] = "Pickle Rick Statue/decor/1 2/1 1/1/500";


            }

            if (asset.AssetNameEquals("Data/Fish"))
            {
                //Monitor.Log($"Added asset in '{asset.AssetName}'.");
                IDictionary<int, string> data = asset.AsDictionary<int, string>().Data;
                data[154] = "Pickle Rick/40/sinker/3/20/600 1900/fall winter/both/683 .2 689 .4/3/.25/.25/0";
            }

                if (asset.AssetNameEquals("Data/ObjectInformation"))
                {
                    //Monitor.Log($"Added asset in '{asset.AssetName}'.");
                    IDictionary<int, string> data = asset.AsDictionary<int, string>().Data;
                    data[154] = "Pickle Rick/75/30/Fish -4/Pickle Rick/Hey Morty look, I'm a pickle!/Day^Fall Winter";
                    data[113] = "Pickle Rick Statue/50/-300/Arch/Pickle Rick Statue/It's a statue of pickle rick! What demoic cult made this?/Farm .1/Decor 5 31";
                }

                if (asset.AssetNameEquals("Maps/springobjects"))
                {
                    //Monitor.Log($"Added asset in '{asset.AssetName}'.");
                    Texture2D image = this.Helper.Content.Load<Texture2D>("assets/picklerick.png", ContentSource.ModFolder);
                    asset.AsImage().PatchImage(image, targetArea: new Microsoft.Xna.Framework.Rectangle(160, 96, 16, 16));

                    image = this.Helper.Content.Load<Texture2D>("assets/artifactpicklerickstatue.png", ContentSource.ModFolder);
                    asset.AsImage().PatchImage(image, targetArea: new Microsoft.Xna.Framework.Rectangle(272, 64, 16, 16));
                    //Monitor.Log("IT WORKED!!!");

                }

                if (asset.AssetNameEquals("TileSheets/furniture"))
                {
                    //Monitor.Log($"Added asset in '{asset.AssetName}'.");
                    Texture2D image = this.Helper.Content.Load<Texture2D>("assets/picklerickstatuecolor.png", ContentSource.ModFolder);
                    asset.AsImage().PatchImage(image, targetArea: new Microsoft.Xna.Framework.Rectangle(416, 640, 16, 32));

                    image = this.Helper.Content.Load<Texture2D>("assets/picklerickstatue.png", ContentSource.ModFolder);
                    asset.AsImage().PatchImage(image, targetArea: new Microsoft.Xna.Framework.Rectangle(401, 640, 16, 32));
            }
            }
        
           


        

        public override void Entry(IModHelper helper)
        {
            
        }

       
    }
}
