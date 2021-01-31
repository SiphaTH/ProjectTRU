using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.Projectiles
{
    internal static class ProjectilesTranslation
    {
        public static void SetupTranslation()
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