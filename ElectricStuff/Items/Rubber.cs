using Terraria.ID;
using Terraria.ModLoader;

namespace ElectricStuff.Items
{
	public class Rubber : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Unedible? Phew!");
		}
		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.value = 100;
			item.rare = 2;
            item.maxStack = 999;
            item.consumable = true;
            item.createTile = mod.TileType("RubberBlock");
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Lens, 2);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
