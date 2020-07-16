using QuodAstrum.Projectiles;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Weapons
{
    public class MagnetCannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magnet Cannon");
            Tooltip.SetDefault("Warning: intense gravity \n may lead to \n extreme dwarfism");
        }
        public override void SetDefaults()
        {
            item.damage = 400;
            item.ranged = true;                     //this make the item do magic damage
            item.width = 32;
            item.height = 32;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 100;
            item.rare = ItemRarityID.Expert;             //mana use
            item.UseSound = SoundID.Item120;            //this is the sound when you use the item
            item.autoReuse = true;
            item.useAmmo = AmmoID.Bullet;
            item.shoot = mod.ProjectileType("AncientLightRanged");  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Main.projectile[type].noDropItem = true;
            if (type == ProjectileID.Bullet) //remove this line if you want it to override all projectile instead of just wooden arrows, which i do not recommend
            {
                type = ModContent.ProjectileType<AncientLightRanged>();
            }
            float numberProjectiles = 6; // 3, 4, or 5 shots
            float rotation = MathHelper.ToRadians(3);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 1f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }
}