using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Weapons
{
    public class HellsGaze : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hell's Gaze");
            Tooltip.SetDefault("It's a beautiful day outside\nbirds are singing\nflowers are blooming\non days like these\nkids like you\nSHOULD BE BURNING IT ALL");
        }
        public override void SetDefaults()
        {
            item.damage = 60;
            item.magic = true;                     //this make the item do magic damage
            item.width = 32;
            item.height = 32;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 100;
            item.rare = ItemRarityID.Expert;
            item.mana = 3;             //mana use
            item.UseSound = SoundID.Item84;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = ProjectileID.DemonScythe;  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }
        public override void AddRecipes()
        {                                        //this is how to craft this item
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemonScythe, 1);
            recipe.AddIngredient(ItemID.UnholyTrident, 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 30);
            recipe.AddTile(TileID.MythrilAnvil);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 3; // 3, 4, or 5 shots
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 1f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                type = Main.rand.Next(new int[] { type, ProjectileID.DemonScythe, ProjectileID.UnholyTridentFriendly});
            }
            return true;
            // Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.
            

        }
    }
}