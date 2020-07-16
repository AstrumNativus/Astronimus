using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Projectiles
{
    public class Magnesarias : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.damage = 400;
            projectile.width = 32;
            projectile.height = 22;
            projectile.friendly = true;                       
            projectile.hostile = false;
            projectile.melee = true;                        //this make the projectile do magic damage
            projectile.tileCollide = false;                 //this make that the projectile does not go thru walls
            projectile.ignoreWater = true;
        }

        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y + 1f, (double)projectile.velocity.X) + 1f;
            projectile.localAI[0] += 1f;

            if (projectile.localAI[0] > 180f) //projectile time left before disappears
            {
                projectile.Kill();
                Vector2 offset = new Vector2(0, 0);

                Projectile.NewProjectile(projectile.Center + offset, new Vector2(0 + ((float)Main.rand.Next(20) / 10) - 1, -3 + ((float)Main.rand.Next(20) / 10) - 1), ModContent.ProjectileType<AncientLightRanged>(), 6, 1f, Main.myPlayer);
                Projectile.NewProjectile(projectile.Center, projectile.velocity.RotatedByRandom(MathHelper.Pi / 3) * (Main.rand.NextFloat() + 1), ModContent.ProjectileType<AncientLightRanged>(), projectile.damage, projectile.knockBack, projectile.owner);
            }
           
            projectile.ai[0] += 1f; // Use a timer to wait 15 ticks before applying gravity.
            if (projectile.ai[0] >= 20f)
            {
                projectile.ai[0] = 20f;
                projectile.velocity.X *= 0.95f;
                projectile.velocity.Y *= 0.95f;
            }
            if (projectile.velocity.Y > 16f)
            {
                projectile.velocity.Y = 16f;
            }
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Vector2 offset = new Vector2(0, 0);

            Projectile.NewProjectile(projectile.Center + offset, new Vector2(0 + ((float)Main.rand.Next(20) / 10) - 1, -3 + ((float)Main.rand.Next(20) / 10) - 1), ModContent.ProjectileType<AncientLightRanged>(), 6, 1f, Main.myPlayer);
            Projectile.NewProjectile(projectile.Center, projectile.velocity.RotatedByRandom(MathHelper.Pi / 3) * (Main.rand.NextFloat() + 1), ModContent.ProjectileType<AncientLightRanged>(), projectile.damage, projectile.knockBack, projectile.owner);
            return true;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            projectile.Kill();
            Vector2 offset = new Vector2(0, 0);

            Projectile.NewProjectile(projectile.Center + offset, new Vector2(0 + ((float)Main.rand.Next(20) / 10) - 1, -3 + ((float)Main.rand.Next(20) / 10) - 1), ModContent.ProjectileType<AncientLightRanged>(), 6, 1f, Main.myPlayer);
            Projectile.NewProjectile(projectile.Center, projectile.velocity.RotatedByRandom(MathHelper.Pi / 3) * (Main.rand.NextFloat() + 1), ModContent.ProjectileType<AncientLightRanged>(), projectile.damage, projectile.knockBack, projectile.owner);
        }
    }
}