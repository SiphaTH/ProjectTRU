using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.Buffs
{
    public static class BuffsTranslation
    {
        internal static void SetupTranslation()
        {
            foreach (var id in FargoSoulsTranslationLists.FargoSoulsBuffs)
            {
                try
                {
                    CoreFargowiltasSoulsTranslation.FargoSouls.GetBuff(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"FargoSouls.BuffName.{id}"));
                    CoreFargowiltasSoulsTranslation.FargoSouls.GetBuff(id).Description.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"FargoSouls.BuffDescription.{id}"));
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
        }
    }
}