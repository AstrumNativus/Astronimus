using QuodAstrum.Projectiles;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Weapons
{
    public class BoredBananaSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bored's Banana Sword");
            Tooltip.SetDefault("Banana Sword\nDedicated to LordBored\nIt would seem I've lost the concept of reality\nBut who gives a shit?");
        }
        public override void SetDefaults()
        {
            item.damage = 200;
            item.melee = true;
            item.knockBack = 20;
            item.crit = 20;//this make the item do magic damage
            item.width = 46;
            item.height = 46;
            item.useTime = 7;
            item.useAnimation = 7;
            item.useStyle = 1;        //this is how the item is holded
            item.noMelee = false;
            item.value = 10;
            item.rare = ItemRarityID.Expert;             //mana use
            item.UseSound = SoundID.Item60;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = ProjectileID.NightBeam;  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
            float ceilingLimit = target.Y;
            if (ceilingLimit > player.Center.Y - 200f)
            {
                ceilingLimit = player.Center.Y - 200f;
            }
            for (int i = 0; i < 800; i++)
            {
                position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
                position.Y -= (50 * i);
                Vector2 heading = target - position;
                if (heading.Y < 0f)
                {
                    heading.Y *= -1f;
                }
                if (heading.Y < 20f)
                {
                    heading.Y = 20f;
                }
                heading.Normalize();
                heading *= new Vector2(speedX, speedY).Length();
                speedX = heading.X + Main.rand.Next(-40, 41) * 0.5f;
                speedY = heading.Y + Main.rand.Next(-40, 41) * 0.5f;
                Projectile.NewProjectile(position.X, position.Y, speedX * 5, speedY * 5, type, damage * 300, knockBack * 1000, player.whoAmI, 0f, ceilingLimit);
                type = Main.rand.Next(new int[] { type, ProjectileID.NightBeam, ProjectileID.Bananarang});
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TrueNightsEdge);
            recipe.AddIngredient(ItemID.Bananarang, 5);
            recipe.AddIngredient(ItemID.LunarBar, 100);
            recipe.AddIngredient(mod.ItemType("CygmaCrystal"), 500);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}