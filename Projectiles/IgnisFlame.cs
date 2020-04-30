using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Projectiles
{
    public class IgnisFlame : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;
            projectile.magic = true;
            projectile.penetrate = 1;
            projectile.hostile = true;
            projectile.friendly = false;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.alpha = 0;
            projectile.timeLeft = 200;
        }
        public override void AI()
        {
            if (projectile.localAI[0] == 0f)
            {
                Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 20);
                projectile.localAI[0] = 1f;
            }
        }
    }
}