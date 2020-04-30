using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Projectiles
{
    public class BookOfBookers : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 22;
            projectile.friendly = true;
            projectile.penetrate = 99999;                       //this is the projectile penetration
            projectile.hostile = false;
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
            projectile.ai[0] += 1f; // Use a timer to wait 15 ticks before applying gravity.
            if (projectile.ai[0] >= 20f)
            {
                projectile.ai[0] = 20f;
                projectile.velocity.Y = projectile.velocity.Y + 0.5f;
            }
            if (projectile.velocity.Y > 16f)
            {
                projectile.velocity.Y = 16f;
            }
        }
    }
}