using System;
using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.Projectiles
{
    internal static class ProjectileNames
    {
        public static void SetupTranslation()
        {
            foreach (var translation in RussianDictionaries.CalamityProjectiles)
            {
                try
                {
                    CoreCalamityTranslation.CalamityMod.GetProjectile(translation.Key).DisplayName.AddTranslation(GameCulture.Russian, translation.Value);
                }
                catch (NullReferenceException)
                {
                    throw new TranslationException(translation.Key, GameCulture.Russian);
                }
            }
        }
    }
}