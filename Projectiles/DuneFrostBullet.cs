using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Projectiles
{
    public class DuneFrostBullet : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 28;
            projectile.height = 6;
            projectile.friendly = true;
            projectile.penetrate = 2;                       //this is the projectile penetration
            projectile.hostile = false;
            projectile.ranged = true;                        //this make the projectile do magic damage
            projectile.tileCollide = true;                 //this make that the projectile does not go thru walls
            projectile.ignoreWater = true;
            projectile.light = 2.5f;
        }

        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;
            Vector2 dustVel = projectile.velocity;
            if (dustVel != Vector2.Zero)
            {
                dustVel.Normalize();
            }
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Ice);
            int dust2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.AmberBolt);
            Main.dust[dust].velocity -= 1.2f * dustVel;
            Main.dust[dust2].velocity -= 1.2f * dustVel;
            if (projectile.localAI[0] > 130f) //projectile time left before disappears
            {
                projectile.Kill();
            }

        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Vector2 dustVel = projectile.velocity;
            if (dustVel != Vector2.Zero)
            {
                dustVel.Normalize();
            }
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Ice);
            int dust2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.AmberBolt);
            Main.dust[dust].velocity = 0f * dustVel;
            Main.dust[dust2].velocity = 0f * dustVel;
            return true;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 180);
            target.AddBuff(BuffID.Frostburn, 180);
            projectile.Kill();
            Vector2 dustVel = projectile.velocity;
            if (dustVel != Vector2.Zero)
            {
                dustVel.Normalize();
            }
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Ice);
            int dust2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.AmberBolt);
            Main.dust[dust].velocity = 0f * dustVel;
            Main.dust[dust2].velocity = 0f * dustVel;
        }
    }
}