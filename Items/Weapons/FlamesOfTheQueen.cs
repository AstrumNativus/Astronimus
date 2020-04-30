using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Weapons
{
    public class FlamesOfTheQueen : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flames of the Queen");
            Tooltip.SetDefault("You have shown your power time and time again\nDo not disappoint me now");
        }
        public override void SetDefaults()
        {
            item.damage = 125;
            item.magic = true;                     //this make the item do magic damage
            item.width = 32;
            item.height = 32;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 100;
            item.rare = ItemRarityID.Expert;
            item.mana = 10;             //mana use
            item.UseSound = SoundID.Item84;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("NativusFlame");  //this make the item shoot your projectile
            item.shootSpeed = 20f;    //projectile speed when shoot
            
        }
        public override void AddRecipes()
        {                                        //this is how to craft this item
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("NativusBreath"));
            recipe.AddIngredient(ItemID.FragmentSolar, 10);
            recipe.AddIngredient(ItemID.LastPrism, 1);
            recipe.AddTile(TileID.LunarCraftingStation);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(6); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }
}