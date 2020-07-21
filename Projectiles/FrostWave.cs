using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Projectiles
{
    public class FrostWave : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 112;
            projectile.height = 52;
            projectile.friendly = false;
            projectile.penetrate = 99999;                       //this is the projectile penetration
            projectile.hostile = true;
            projectile.magic = true;                        //this make the projectile do magic damage
            projectile.tileCollide = false;                 //this make that the projectile does not go thru walls
            projectile.ignoreWater = true;
            projectile.light = 2.5f;
        }

        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;

            if (projectile.localAI[0] > 600f) //projectile time left before disappears
            {
                projectile.Kill();
            }

        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {

            target.AddBuff(BuffID.Frostburn, 960);
            if (Main.rand.Next(2) == 0)
            {
                target.AddBuff(BuffID.Chilled, 960);
            }
            if (Main.rand.Next(5) == 0)
            {
                target.AddBuff(BuffID.Frozen, 180);
            }
        }
    }
}