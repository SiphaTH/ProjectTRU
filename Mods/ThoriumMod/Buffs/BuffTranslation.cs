using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Exceptions;
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
                    ModsCall.Thorium.GetBuff(translation.Key).DisplayName.AddTranslation(GameCulture.Russian, translation.Value.Item1);
                    ModsCall.Thorium.GetBuff(translation.Key).Description.AddTranslation(GameCulture.Russian, translation.Value.Item2);
                }
                catch(NullReferenceException)
                {
                    throw new IDTypeException(translation.Key);
                }
            }
        }
    }
}