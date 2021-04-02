using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla
{
    public class GlobalTownNpcName : GlobalNPC
    {
        public override bool Autoload(ref string name) => TranslationUtils.IsRussianLanguage;

        public override void AI(NPC npc)
        {
            if (GlobalCatalog.TownNpcName.ContainsKey(npc.GivenName) && !Main.dedServ)
            {
                npc.GivenName = LangUtils.TranslationKey($"Global.TownNpcName.{GlobalCatalog.TownNpcName[npc.GivenName]}");
            }
        }
    }
}