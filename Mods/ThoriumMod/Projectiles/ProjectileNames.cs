using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Exceptions;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.ThoriumMod.Projectiles
{
    internal static class ProjectileNames
    {
        public static void SetupTranslation()
        {
            foreach (var translation in ThoriumRussianDictionaries.ThoriumProjectiles)
            {
                try
                {
                    ModsCall.Thorium.GetProjectile(translation.Key).DisplayName.AddTranslation(GameCulture.Russian, translation.Value);
                }
                catch (NullReferenceException)
                {
                    throw new IDTypeException(translation.Key);
                }
            }
        }
    }
}