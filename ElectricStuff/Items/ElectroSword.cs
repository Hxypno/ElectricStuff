using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElectricStuff.Items
{
    public class ElectroSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Electro Sword");
            Tooltip.SetDefault("This is strong. Shocker! *ba dum tshhh*");  //The (English) text shown below your weapon's name
        }

        public override void SetDefaults()
        {
            item.damage = 300;           //The damage of your weapon
            item.melee = true;          //Is your weapon a melee weapon?
            item.width = 43;            //Weapon's texture's width
            item.height = 40;           //Weapon's texture's height
            item.useTime = 20;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
            item.useAnimation = 20;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
            item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
            item.knockBack = 10;         //The force of knockback of the weapon. Maximum is 20
            item.value = Item.buyPrice(gold: 10);           //The value of the weapon
            item.rare = 6;              //The rarity of the weapon, from -1 to 13
            item.UseSound = SoundID.Item2;      //The sound when the weapon is using
            item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Rubber"), 10);
            recipe.AddIngredient(mod.ItemType("ElectricBall"), 20);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            // Add Onfire buff to the NPC for 1 second
            // 60 frames = 1 second
            target.AddBuff(BuffID.Electrified, 600);
        }
    }
}