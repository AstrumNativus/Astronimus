using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Weapons
{
    public class Magnerias : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magnerias");
            Tooltip.SetDefault("Deviation of Newton's Laws may result in the following \n Headaches, \n Nausea, \n Drowsiness, \n Blurred Vision, \n Sever Back Pain, \n Death");
        }
        public override void SetDefaults()
        {
            item.damage = 400;
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
            item.UseSound = SoundID.Item28;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("Magnerias");  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 5 + 10; // 3, 4, or 5 shots
            float rotation = MathHelper.ToRadians(360);
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