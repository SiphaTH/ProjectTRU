using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.NPCs
{
	public class TownNpcName : GlobalNPC
	{
		public override void AI(NPC npc)
		{
			if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && 
			    CalamityRuTranslate.TRuConfig.CalamityTranslation)
			{
				if (Translation.CheckCalamityVanillaNpc(npc) && RussianDictionaries.CalamityTownNpcName.ContainsKey(npc.GivenName))
				{
					npc.GivenName = RussianDictionaries.CalamityTownNpcName[npc.GivenName];
				}
			}
		}
	}
}
