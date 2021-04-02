﻿using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common.Exceptions;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.ThoriumMod.Items
{
    internal static class PrefixNames
    {
        public static void SetupTranslation()
        {
            foreach (var translation in ThoriumRussianDictionaries.ThoriumPrefixes)
            {
                try
                {
                    CoreThoriumTranslation.ThoriumMod.GetPrefix(translation.Key).DisplayName.AddTranslation(GameCulture.Russian, translation.Value);
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(translation.Key);
                }
            }
        }
    }
}