using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElectricStuff.Items
{
    public class ElectroPick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Electro Pick");
            Tooltip.SetDefault("Zap the ores into your inventory!");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 10;
            item.useAnimation = 10;
            item.pick = 270;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000000;
            item.rare = 6;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Rubber"), 10);
            recipe.AddIngredient(mod.ItemType("ElectricBall"), 22);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}