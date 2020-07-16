using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader;

namespace QuodAstrum.Projectiles
{
    public class AncientLightRanged : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.damage = 400;
            projectile.width = 32;
            projectile.height = 22;
            projectile.friendly = true;
            projectile.penetrate = 5;                       //this is the projectile penetration
            projectile.hostile = false;
            projectile.magic = true;                        //this make the projectile do magic damage
            projectile.tileCollide = false;                 //this make that the projectile does not go thru walls
            projectile.ignoreWater = true;
        }

        public override void AI()
        {
            projectile.damage = 400;
            projectile.rotation += 0.1f;
            projectile.localAI[0] += 1f;

            if (projectile.localAI[0] > 1000f) //projectile time left before disappears
            {
                projectile.Kill();
            }
            if (projectile.ai[0] == 0f)
            {
                if (Main.rand.NextBool(5))
                {
                    int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height / 2, DustID.AncientLight);
                    Main.dust[dust].velocity.Y -= 1.2f;
                }
            }
            else
            {
                if (Main.rand.NextBool(3))
                {
                    Vector2 dustVel = projectile.velocity;
                    if (dustVel != Vector2.Zero)
                    {
                        dustVel.Normalize();
                    }
                    int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.AncientLight);
                    Main.dust[dust].velocity -= 1.2f * dustVel;
                }
            }
            Lighting.AddLight((int)(projectile.Center.X / 16f), (int)(projectile.Center.Y / 16f), 0.6f, 0.9f, 0.3f);
        }
    }
}