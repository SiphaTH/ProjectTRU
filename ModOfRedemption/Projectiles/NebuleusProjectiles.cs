using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ModOfRedemption.Projectiles
{
    public class NebuleusProjectiles : GlobalProjectile
    {
        public override void AI(Projectile projectile)
        {
            Mod redemption = ModLoader.GetMod("Redemption");
            if (redemption != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                if (projectile.type == redemption.ProjectileType("Shout1"))
                {
                    projectile.type = mod.ProjectileType("Shout1");
                }
                if (projectile.type == redemption.ProjectileType("Shout2"))
                {
                    projectile.type = mod.ProjectileType("Shout2");
                }
                if (projectile.type == redemption.ProjectileType("Shout3"))
                {
                    projectile.type = mod.ProjectileType("Shout3");
                }
                if (projectile.type == redemption.ProjectileType("Shout4"))
                {
                    projectile.type = mod.ProjectileType("Shout4");
                }
                if (projectile.type == redemption.ProjectileType("Shout5"))
                {
                    projectile.type = mod.ProjectileType("Shout5");
                }
                if (projectile.type == redemption.ProjectileType("Shout6"))
                {
                    projectile.type = mod.ProjectileType("Shout6");
                }
                if (projectile.type == redemption.ProjectileType("Shout7"))
                {
                    projectile.type = mod.ProjectileType("Shout7");
                }
                if (projectile.type == redemption.ProjectileType("Shout8"))
                {
                    projectile.type = mod.ProjectileType("Shout8");
                }
                if (projectile.type == redemption.ProjectileType("Shout9"))
                {
                    projectile.type = mod.ProjectileType("Shout9");
                }
                if (projectile.type == redemption.ProjectileType("Shout10"))
                {
                    projectile.type = mod.ProjectileType("Shout10");
                }
                if (projectile.type == redemption.ProjectileType("Shout11"))
                {
                    projectile.type = mod.ProjectileType("Shout11");
                }
                if (projectile.type == redemption.ProjectileType("Text1"))
                {
                    projectile.type = mod.ProjectileType("Text1");
                }
                if (projectile.type == redemption.ProjectileType("Text2"))
                {
                    projectile.type = mod.ProjectileType("Text2");
                }
                if (projectile.type == redemption.ProjectileType("Text3"))
                {
                    projectile.type = mod.ProjectileType("Text3");
                }
            }
        }
    }
}
