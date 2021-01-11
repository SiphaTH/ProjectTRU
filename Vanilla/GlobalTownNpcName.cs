using CalamityRuTranslate.Dictionaries;
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
                if (Translation.GlobalTownNpcName(npc) && !Translation.CheckRussian(npc.GivenName))
                {
                    try
                    {
                        npc.GivenName = Translation.KeyText($"Global.TownNpcName.{GlobalDictionaries.GlobalTownNpcName[npc.GivenName]}");
                    }
                    catch
                    {
                        Main.NewText($"Ошибка загрузки имени {npc.GivenName}");
                    }
                }
            }
        }
    }
}