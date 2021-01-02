using System;
using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.NPCs
{
	internal static class NpcNames
	{
		public static void SetupTranslation()
		{
			foreach (var translation in RussianDictionaries.CalamityNpc)
			{
				try
				{
					CoreCalamityTranslation.CalamityMod.GetNPC(translation.Key).DisplayName.AddTranslation(GameCulture.Russian, translation.Value);
				}
				catch(NullReferenceException)
				{
					throw new TranslationException(translation.Key);
				}
			}
		}
	}
}
