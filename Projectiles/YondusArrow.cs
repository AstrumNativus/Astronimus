using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader;
using System.Media;

namespace QuodAstrum.Projectiles
{
    public class YondusArrow : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 50;
            projectile.friendly = false;
            projectile.penetrate = 5;                       //this is the projectile penetration
            projectile.hostile = true;
            projectile.magic = true;                        //this make the projectile do magic damage
            projectile.tileCollide = false;                 //this make that the projectile does not go thru walls
            projectile.ignoreWater = true;
            projectile.damage = 20;
            projectile.alpha = 360;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y + 1f, (double)projectile.velocity.X) + 1f;
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height / 3, DustID.Vortex);
            Dust.NewDust(projectile.position, projectile.width, projectile.height / 2, DustID.Vortex);
            Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Vortex);
            Main.dust[dust].velocity.Y -= 1.2f;
        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            if (Main.rand.Next(10) == 0)
            {
                target.AddBuff(BuffID.Slow, 1920);
            }
            if (Main.rand.Next(25) == 0)
            {
                target.AddBuff(BuffID.Chilled, 960);
            }
            if (Main.rand.Next(50) == 0)
            {
                target.AddBuff(mod.BuffType("IcarusFolly"), 480);
            }
            if (Main.rand.Next(75) == 0)
            {
                target.AddBuff(BuffID.Confused, 240);
            }
            if (Main.rand.Next(1000) == 0)
            {
                target.AddBuff(BuffID.Stoned, 60);
            }
        }
    }
}