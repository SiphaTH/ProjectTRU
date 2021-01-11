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
            foreach (var id in CalamityTranslationLists.CalamityProjectiles)
            {
                try
                {
                    CoreCalamityTranslation.CalamityMod.GetProjectile(id).DisplayName.AddTranslation(GameCulture.Russian, Translation.KeyText($"Calamity.ProjectileName.{id}"));
                }
                catch (NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
        }
    }
}