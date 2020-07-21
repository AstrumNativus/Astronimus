using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader;

namespace QuodAstrum.Projectiles
{
    public class StarProjectile2 : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.damage = 20;
            projectile.width = 32;
            projectile.height = 22;
            projectile.friendly = true;
            projectile.penetrate = 5;                       //this is the projectile penetration
            projectile.hostile = false;                      //this make the projectile do magic damage
            projectile.tileCollide = true;                 //this make that the projectile does not go thru walls
            projectile.ignoreWater = true;
        }

        public override void AI()
        {
            projectile.rotation += 0.1f;
            projectile.localAI[0] += 1f;
            if (projectile.localAI[0] > 3600f) //projectile time left before disappears
            {
                projectile.Kill();
                
            }
            if (Main.rand.NextBool(3))
            {
                Vector2 dustVel = projectile.velocity;
                if (dustVel != Vector2.Zero)
                {
                    dustVel.Normalize();
                }
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.AmberBolt);
                Main.dust[dust].velocity -= 1.2f * dustVel;
            }
            Lighting.AddLight(projectile.Center, Color.White.ToVector3() * 0.78f);

        }
    }
}