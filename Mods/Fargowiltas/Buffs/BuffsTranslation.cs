using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.Fargowiltas.Buffs
{
    public static class BuffsTranslation
    {
        internal static void SetupTranslation()
        {
            foreach (var id in FargoTranslationLists.FargoBuffs)
            {
                try
                {
                    CoreFargowiltasTranslation.Fargo.GetBuff(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"Fargo.BuffName.{id}"));
                    CoreFargowiltasTranslation.Fargo.GetBuff(id).Description.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"Fargo.BuffDescription.{id}"));
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
        }
    }
}