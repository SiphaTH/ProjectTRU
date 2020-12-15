using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla
{
    public class VanillaTownNpcName : GlobalNPC
    {
        public override void AI(NPC npc)
        {
            if (Translation.CheckVanillaNpc(npc) && Translation.IsRussianLanguage)
            {
                if (npc.GivenName == "" || npc.GivenName == " ") npc.GivenName = "Фабсол гей";
                
                if (!Translation.CheckRussian(npc.GivenName))
                {
                    npc.GivenName = VanillaDictionaries.VanillaTownNpcName[npc.GivenName];
                }
            }
        }
    }
}