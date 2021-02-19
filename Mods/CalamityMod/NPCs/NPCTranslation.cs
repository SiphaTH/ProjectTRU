using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.NPCs
{
	public static class NPCTranslation
	{
		internal static void SetupTranslation()
		{
			foreach (var id in CalamityTranslationLists.CalamityNpc)
			{
				try
				{
					CoreCalamityTranslation.Calamity.GetNPC(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"Calamity.NpcName.{id}"));
				}
				catch(NullReferenceException)
				{
					throw new TranslationException(id);
				}
			}
		}
	}
}
