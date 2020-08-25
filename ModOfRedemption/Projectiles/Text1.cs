using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ModOfRedemption.Projectiles
{
    public class Text1 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Текст");
        }

        public override void SetDefaults()
        {
            projectile.width = 722;
            projectile.height = 48;
            projectile.penetrate = -1;
            projectile.hostile = false;
            projectile.friendly = false;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.alpha = 255;
            projectile.timeLeft = 230;
        }

        public override void AI()
        {
			projectile.velocity.Y = 0f;
            projectile.velocity.X = 0f;
            Player player = Main.player[projectile.owner];
            projectile.position.X = player.Center.X - 361f - 60f;
            projectile.position.Y = player.Center.Y - 24f - 300f;
            if (projectile.localAI[0] == 1f)
            {
                float[] localAI = projectile.localAI;
                int num = 1;
                float num2 = localAI[num] + 1f;
                localAI[num] = num2;
                if (num2 > 120f)
                {
                    projectile.alpha += 10;
                    if (projectile.alpha >= 255)
                    {
                        projectile.Kill();
                        return;
                    }
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