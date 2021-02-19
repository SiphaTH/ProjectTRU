using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.Items
{
    internal static class PrefixesTranslation
	{
		internal static void SetupTranslation()
		{
			foreach (var id in CalamityTranslationLists.CalamityPrefix)
			{
				try
				{
					CoreCalamityTranslation.Calamity.GetPrefix(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"Calamity.PrefixName.{id}"));
				}
				catch(NullReferenceException)
				{
					throw new TranslationException(id);
				}
			}
		}
	}
}