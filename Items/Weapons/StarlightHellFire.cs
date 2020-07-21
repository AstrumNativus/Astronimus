using QuodAstrum.Projectiles;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Weapons
{
    public class StarlightHellFire : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starlight Hell Fire");
            Tooltip.SetDefault("\nDamage outputs are randomized\nPlease stand clear of the door\nAs this bow is trying to destroy");
        }
        public override void SetDefaults()
        {
            item.damage = 30;
            item.ranged = true;
            item.knockBack = 20;
            item.crit = 15; //this make the item do magic damage
            item.width = 22;
            item.height = 52;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.value = 10;
            item.rare = ItemRarityID.Expert;             //mana use
            item.UseSound = SoundID.Item4;            //this is the sound when you use the item
            item.autoReuse = true;
            item.useAmmo = AmmoID.Arrow;
            item.shoot = ProjectileID.StarWrath;  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }
        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .75f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Main.projectile[type].noDropItem = true;
            type = ProjectileID.StarWrath;
            float numberProjectiles = 3; // 3, 4, or 5 shots
            float rotation = MathHelper.ToRadians(15);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 15f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(45));
                speedX = perturbedSpeed.X;
                speedY = perturbedSpeed.Y;
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage * Main.rand.Next(1, 3), knockBack, player.whoAmI);
            }
            return true;

        }
    }
}