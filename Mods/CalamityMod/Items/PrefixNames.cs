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
			foreach (var id in CalamityTranslationLists.CalamityPrefix)
			{
				try
				{
					CoreCalamityTranslation.CalamityMod.GetPrefix(id).DisplayName.AddTranslation(GameCulture.Russian, Translation.KeyText($"Calamity.PrefixName.{id}"));
				}
				catch(NullReferenceException)
				{
					throw new TranslationException(id);
				}
			}
		}
	}
}