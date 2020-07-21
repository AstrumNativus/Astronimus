using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Projectiles
{
    public class FrostShard : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 15;
            projectile.height = 24;
            projectile.hostile = true;
            projectile.penetrate = 99999;                       //this is the projectile penetration
            projectile.magic = true;                        //this make the projectile do magic damage
            projectile.tileCollide = true;                 //this make that the projectile does not go thru walls
            projectile.ignoreWater = true;
        }

        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y + 1f, (double)projectile.velocity.X) + 1f;
            projectile.localAI[0] += 1f;

            if (projectile.localAI[0] > 390f) //projectile time left before disappears
            {
                projectile.Kill();
            }
            projectile.ai[0] += 0.5f; // Use a timer to wait 15 ticks before applying gravity.
            if (projectile.ai[0] >= 20f)
            {
                projectile.ai[0] = 20f;
                projectile.velocity.Y = projectile.velocity.Y + 0.2f;
            }
            if (projectile.velocity.Y > 20f)
            {
                projectile.velocity.Y = 20f;
            }
            if (Main.rand.NextBool(3))
            {
                Vector2 dustVel = projectile.velocity;
                if (dustVel != Vector2.Zero)
                {
                    dustVel.Normalize();
                }
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Ice);
                Main.dust[dust].velocity -= 1.2f * dustVel;
            }
        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {

            target.AddBuff(BuffID.Frostburn, 960);
            if (Main.rand.Next(10) == 0)
            {
                target.AddBuff(BuffID.Chilled, 960);
            }
            if (Main.rand.Next(25) == 0)
            {
                target.AddBuff(BuffID.Frozen, 180);
            }
        }
    }
}