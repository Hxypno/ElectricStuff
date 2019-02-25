using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ElectricStuff.Blocks
{
    public class RubberBlock : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBouncy[Type] = true;
            dustType = mod.DustType("Sparkle");
            drop = mod.ItemType("Rubber");
            // Set other values here
        }
    }
}