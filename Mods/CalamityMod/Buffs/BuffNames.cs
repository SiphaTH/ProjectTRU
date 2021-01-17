using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.Buffs
{
	internal static class BuffNames
	{
		public static void SetupTranslation()
		{
			foreach (var id in CalamityTranslationLists.CalamityBuffs)
			{
				try
				{
					CoreCalamityTranslation.CalamityMod.GetBuff(id).DisplayName.AddTranslation(GameCulture.Russian, Translation.KeyText($"Calamity.BuffName.{id}"));
					CoreCalamityTranslation.CalamityMod.GetBuff(id).Description.AddTranslation(GameCulture.Russian, Translation.KeyText($"Calamity.BuffDescription.{id}"));
				}
				catch(NullReferenceException)
				{
					throw new TranslationException(id);
				}
			}
		}
	}
}
