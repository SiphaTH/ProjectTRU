using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.Projectiles
{
    public static class ProjectilesTranslation
    {
        internal static void SetupTranslation()
        {
            foreach (var id in CalamityTranslationLists.CalamityProjectiles)
            {
                try
                {
                    CoreCalamityTranslation.Calamity.GetProjectile(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"Calamity.ProjectileName.{id}"));
                }
                catch (NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
        }
    }
}