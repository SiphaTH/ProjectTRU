using System;
using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.Items
{
    internal static class PrefixNames
	{
		public static void SetupTranslation()
		{
			foreach (var translation in RussianDictionaries.CalamityPrefixes)
			{
				try
				{
					CoreCalamityTranslation.CalamityMod.GetPrefix(translation.Key).DisplayName.AddTranslation(GameCulture.Russian, translation.Value);
				}
				catch(NullReferenceException)
				{
					throw new TranslationException(translation.Key);
				}
			}
		}
	}
}