using QuodAstrum.Projectiles;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Weapons
{
    public class StarStorm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star Storm");
            Tooltip.SetDefault("Is it too much to ask?\nFor me to enjoy my little balance?\nI mean like honestly.\nWhat the fuck, man?");
        }
        public override void SetDefaults()
        {
            item.damage = 30;
            item.melee = true;
            item.knockBack = 20;
            item.crit = 20;//this make the item do magic damage
            item.width = 46;
            item.height = 46;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;        //this is how the item is holded
            item.noMelee = false;
            item.value = 10;
            item.rare = ItemRarityID.Expert;             //mana use
            item.UseSound = SoundID.Item4;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("StarProjectile2");  //this make the item shoot your projectile
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
            for (int i = 0; i < 3; i++)
            {
                position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
                position.Y -= (100 * i);
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
                speedX = heading.X;
                speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 400, knockBack, player.whoAmI, 0f, ceilingLimit);
            }
            return false;
        }
    }
}