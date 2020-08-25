using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ModOfRedemption.Projectiles
{
    public class Shout7 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Крик!");
        }

        public override void SetDefaults()
        {
            projectile.width = 303;
            projectile.height = 42;
            projectile.penetrate = -1;
            projectile.hostile = false;
            projectile.friendly = false;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.alpha = 255;
            projectile.timeLeft = 60;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            if (projectile.localAI[0] == 1f)
            {
                projectile.alpha += 10;
                if (projectile.alpha >= 255)
                {
                    projectile.Kill();
                    return;
                }
            }
            else
            {
                projectile.alpha -= 10;
                if (projectile.alpha <= 0)
                {
                    projectile.localAI[0] = 1f;
                }
            }
        }
    }
}