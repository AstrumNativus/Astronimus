using QuodAstrum.Projectiles;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Weapons
{
    public class StarlightLyre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starlight Lyre");
            Tooltip.SetDefault("\nDamage outputs are randomized\nStrum to the tune of the Song of Time\nAnd watch your enemies fall");
        }
        public override void SetDefaults()
        {
            item.damage = 30;
            item.magic = true;                     //this make the item do magic damage
            item.width = 38;
            item.height = 42;
            item.knockBack = 20;
            item.crit = 15;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.value = 10;
            item.rare = ItemRarityID.Expert;             //mana use
            item.UseSound = SoundID.Item4;            //this is the sound when you use the item
            item.autoReuse = true;
            item.mana = 15;
            item.shoot = ProjectileID.TiedEighthNote;//this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 2; // 3, 4, or 5 shots
            float rotation = MathHelper.ToRadians(5);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 5f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles))) * 1f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage * Main.rand.Next(1, 3), knockBack, player.whoAmI);
                type = Main.rand.Next(new int[] { type, ProjectileID.QuarterNote, ProjectileID.QuarterNote, ProjectileID.StarWrath });
            }
            return true;

        }
    }
}