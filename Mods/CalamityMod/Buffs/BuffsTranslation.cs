using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.Buffs
{
	public static class BuffsTranslation
	{
		internal static void SetupTranslation()
		{
			foreach (var id in CalamityTranslationLists.CalamityBuffs)
			{
				try
				{
					CoreCalamityTranslation.Calamity.GetBuff(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"Calamity.BuffName.{id}"));
					CoreCalamityTranslation.Calamity.GetBuff(id).Description.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"Calamity.BuffDescription.{id}"));
				}
				catch(NullReferenceException)
				{
					throw new TranslationException(id);
				}
			}
		}
	}
}
