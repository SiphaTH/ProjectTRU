using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla
{
    public class GlobalTownNpcName : GlobalNPC
    {
        public override bool Autoload(ref string name) => Translation.IsRussianLanguage;

        public override void AI(NPC npc)
        {
            if (GlobalDictionaries.GlobalTownNpcName.ContainsKey(npc.GivenName) && !Main.dedServ)
            {
                npc.GivenName = LangUtilities.TranslationKey($"Global.TownNpcName.{GlobalDictionaries.GlobalTownNpcName[npc.GivenName]}");
            }
        }
    }
}