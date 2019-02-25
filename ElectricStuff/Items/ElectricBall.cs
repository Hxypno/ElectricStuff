using Terraria.ID;
using Terraria.ModLoader;

namespace ElectricStuff.Items
{
    public class ElectricBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Electro Ball");
            Tooltip.SetDefault("This is shockingly cool. *ba dum tshhh*");
        }
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.value = 100;
            item.rare = 4;
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 20);
            recipe.AddIngredient(530, 40);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
