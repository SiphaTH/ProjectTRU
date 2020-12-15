using System;
using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.Items
{
	internal static class ItemTooltips
	{
		public static void SetupTranslation()
		{
			foreach (var translation in RussianDictionaries.CalamityItemTooltip)
			{
				try
				{
					CoreCalamityTranslation.CalamityMod.GetItem(translation.Key).Tooltip.AddTranslation(GameCulture.Russian, translation.Value);
				}
				catch(NullReferenceException)
				{
					throw new TranslationException(translation.Key, GameCulture.Russian);
				}
			}
		}
	}
}
