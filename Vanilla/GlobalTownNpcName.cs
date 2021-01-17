using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla
{
    public class GlobalTownNpcName : GlobalNPC
    {
        public override void AI(NPC npc)
        {
            if (Translation.IsRussianLanguage)
            {
                if (!npc.GivenName.CheckRussian() && Translation.GlobalTownNpcName(npc))
                {
                    npc.GivenName = Translation.KeyText($"Global.TownNpcName.{GlobalDictionaries.GlobalTownNpcName[npc.GivenName]}");
                }
            }
        }
    }
}