using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla
{
    public class TownNpcName : GlobalNPC
    {
        public override bool Autoload(ref string name) => TranslationHelper.IsRussianLanguage;

        public override void AI(NPC npc)
        {
            if (GlobalCatalog.TownNPCsName.ContainsKey(npc.GivenName))
            {
                npc.GivenName = LangHelper.GetText($"Global.TownNpcName.{GlobalCatalog.TownNPCsName[npc.GivenName]}");
            }
        }
    }
}