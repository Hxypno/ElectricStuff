using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElectricStuff.Items
{
    public class ElectroAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Electro Axe");
            Tooltip.SetDefault("Burn the cut, it'll HAVE to fall!");
        }

        public override void SetDefaults()
        {
            item.damage = 45;
            item.melee = true;
            item.width = 32;
            item.height = 28;
            item.useTime = 15;
            item.useAnimation = 15;
            item.axe = 55;          //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = 12000000;
            item.rare = 6;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Rubber"), 15);
            recipe.AddIngredient(mod.ItemType("ElectricBall"), 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}