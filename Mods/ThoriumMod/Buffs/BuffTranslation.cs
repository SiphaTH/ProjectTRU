using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.ThoriumMod.Buffs
{
    public static class BuffTranslation
    {
        internal static void SetupTranslation()
        {
            foreach (var translation in ThoriumRussianDictionaries.ThoriumBuffs)
            {
                try
                {
                    CoreThoriumTranslation.ThoriumMod.GetBuff(translation.Key).DisplayName.AddTranslation(GameCulture.Russian, translation.Value.Item1);
                    CoreThoriumTranslation.ThoriumMod.GetBuff(translation.Key).Description.AddTranslation(GameCulture.Russian, translation.Value.Item2);
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(translation.Key);
                }
            }
        }
    }
}