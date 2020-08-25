using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ModOfRedemption.NPCs
{
    public class TownNpcName : GlobalNPC
    {
        public override void AI(NPC npc)
        {
            Mod mor = ModLoader.GetMod("Redemption");
            if (mor != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                if (npc.type == mor.NPCType("Fallen"))
                {
                    if (npc.GivenName == "Happins")
                    {
                        npc.GivenName = "Хаппинс";
                    }
                    if (npc.GivenName == "Okvot")
                    {
                        npc.GivenName = "Оквот";
                    }
                    if (npc.GivenName == "Tenvon")
                    {
                        npc.GivenName = "Тенвон";
                    }
                }
                if (npc.type == mor.NPCType("Newb"))
                {
                    if (npc.GivenName == "Bob")
                    {
                        npc.GivenName = "Боб";
                    }
                    if (npc.GivenName == "Bort")
                    {
                        npc.GivenName = "Борт";
                    }
                    if (npc.GivenName == "Dylan")
                    {
                        npc.GivenName = "Дилан";
                    }
                    if (npc.GivenName == "Nerty")
                    {
                        npc.GivenName = "Нирти";
                    }
                    if (npc.GivenName == "Filbert")
                    {
                        npc.GivenName = "Филберт";
                    }
                    if (npc.GivenName == "Nerp")
                    {
                        npc.GivenName = "Нерп";
                    }
                }
                if (npc.type == mor.NPCType("TBot"))
                {
                    if (npc.GivenName == "Adam")
                    {
                        npc.GivenName = "Адам";
                    }
                }
                if (npc.type == mor.NPCType("Daerel1"))
                {
                    if (npc.GivenName == "Daerel")
                    {
                        npc.GivenName = "Даррел";
                    }
                }
                if (npc.type == mor.NPCType("Daerel2"))
                {
                    if (npc.GivenName == "Daerel")
                    {
                        npc.GivenName = "Даррел";
                    }
                }
                if (npc.type == mor.NPCType("Daerel3"))
                {
                    if (npc.GivenName == "Daerel")
                    {
                        npc.GivenName = "Даррел";
                    }
                }
                if (npc.type == mor.NPCType("Zephos1"))
                {
                    if (npc.GivenName == "Zephos")
                    {
                        npc.GivenName = "Зефос";
                    }
                }
                if (npc.type == mor.NPCType("Zephos2"))
                {
                    if (npc.GivenName == "Zephos")
                    {
                        npc.GivenName = "Зефос";
                    }
                }
                if (npc.type == mor.NPCType("Zephos3"))
                {
                    if (npc.GivenName == "Zephos")
                    {
                        npc.GivenName = "Зефос";
                    }
                }
            }
        }
    }
}

