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
			foreach (var id in CalamityTranslationLists.CalamityNpc)
			{
				try
				{
					CoreCalamityTranslation.CalamityMod.GetNPC(id).DisplayName.AddTranslation(GameCulture.Russian, Translation.KeyText($"Calamity.NpcName.{id}"));
				}
				catch(NullReferenceException)
				{
					throw new TranslationException(id);
				}
			}
		}
	}
}
