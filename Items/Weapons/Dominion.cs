using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Weapons
{
    public class Dominion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dominion");
            Tooltip.SetDefault("Drown yourself in the circle of life, death, the universe, and everything.\nFor you are now death, the destroyer of worlds");
            
        }
        public override void SetDefaults()
        {
            item.damage = 10000000;
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
            item.shoot = ProjectileID.FallingStar;  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }
        public override void AddRecipes()
        {                                        //this is how to craft this item
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("StarDestroyer"));
            recipe.AddIngredient(mod.ItemType("AstralGlyph"));
            recipe.AddIngredient(mod.ItemType("hellsCircle"));
            recipe.AddIngredient(ItemID.LunarBar, 396);
            recipe.AddTile(TileID.MythrilAnvil);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 300; // 3, 4, or 5 shots
            float rotation = MathHelper.ToRadians(359);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 359f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 1f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                type = Main.rand.Next(new int[] { type, ProjectileID.StarWrath, ProjectileID.Starfury, ProjectileID.FallingStar, ProjectileID.HallowStar, ProjectileID.LunarFlare, ProjectileID.Meowmere, ProjectileID.DemonScythe, ProjectileID.UnholyTridentFriendly, ProjectileID.LostSoulFriendly, ProjectileID.InfernoFriendlyBolt, ProjectileID.ShadowBeamFriendly, ProjectileID.SkyFracture });
            }
            return true;
            // Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.
            

        }
    }
}