using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace QuodAstrum.Items.Weapons        //The directory for your .cs and .png; Example: Mod Sources/TutorialMOD/Items
{
    public class SerenadeSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mercury");
            Tooltip.SetDefault("The Final Staff");
        }
        public override void SetDefaults()
        {
            
            item.damage = 150;     //The damage stat for the Weapon.
            item.melee = false;      //This defines if it does Melee damage and if its effected by Melee increasing Armor/Accessories.
            item.width = 75;   //The size of the width of the hitbox in pixels.
            item.height = 75;  //The size of the height of the hitbox in pixels.
            item.useTime = 20;   //How fast the Weapon is used.
            item.useAnimation = 20;     //How long the Weapon is used for.
            item.useStyle = 5;            //The way your Weapon will be used, 1 is the regular sword swing for example
            item.knockBack = 10;  //The knockback stat of your Weapon.
            item.value = Item.buyPrice(0, 0, 0, 0); // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = ItemRarityID.Expert;    //The color the title of your Weapon when hovering over it ingame
            item.shoot = ProjectileID.RubyBolt;
            item.shootSpeed = 6f;
            item.autoReuse = true; //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
        }

        public override void AddRecipes()
        {                                        //this is how to craft this item
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RubyStaff, 1);
            recipe.AddIngredient(ItemID.TopazStaff, 1);
            recipe.AddIngredient(ItemID.AmberStaff, 1);
            recipe.AddIngredient(ItemID.EmeraldStaff, 1);
            recipe.AddIngredient(ItemID.SapphireStaff, 1);
            recipe.AddIngredient(ItemID.AmethystStaff, 1);
            recipe.AddIngredient(ItemID.DiamondStaff, 1);
            recipe.AddTile(TileID.LunarCraftingStation);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 7; // 3, 4, or 5 shots
            float rotation = MathHelper.ToRadians(1);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 1f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 1f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                type = Main.rand.Next(new int[] { type, ProjectileID.EmeraldBolt, ProjectileID.AmberBolt, ProjectileID.SapphireBolt, ProjectileID.AmethystBolt, ProjectileID.TopazBolt, ProjectileID.DiamondBolt});
            }
            return true;
            // Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.


        }
    }
}