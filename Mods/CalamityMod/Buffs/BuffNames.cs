using System;
using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.Buffs
{
	internal static class BuffNames
	{
		public static void SetupTranslation()
		{
			foreach (var translation in RussianDictionaries.CalamityBuffs)
			{
				try
				{
					CoreCalamityTranslation.CalamityMod.GetBuff(translation.Key).DisplayName.AddTranslation(GameCulture.Russian, translation.Value.Item1);
					CoreCalamityTranslation.CalamityMod.GetBuff(translation.Key).Description.AddTranslation(GameCulture.Russian, translation.Value.Item2);
				}
				catch(NullReferenceException)
				{
					throw new TranslationException(translation.Key, GameCulture.Russian);
				}
			}
		}
		
    }
}
