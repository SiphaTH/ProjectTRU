using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ElementsAwoken.NPCs
{
    public class ElementsAwokenNpcName : GlobalNPC
    {
        public override void AI(NPC npc)
        {
            Mod elementsAwoken = ModLoader.GetMod("ElementsAwoken");
            
            if (elementsAwoken != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                if (npc.type == elementsAwoken.NPCType("Alchemist"))
                {
                    if (npc.GivenName == "Saul")
                    {
                        npc.GivenName = "Саул";
                    }
                    if (npc.GivenName == "Darius")
                    {
                        npc.GivenName = "Дарий";
                    }
                    if (npc.GivenName == "Eliseo")
                    {
                        npc.GivenName = "Элизео";
                    }
                    if (npc.GivenName == "Cadmus")
                    {
                        npc.GivenName = "Кадмус";
                    }
                }
                if (npc.type == elementsAwoken.NPCType("Alchemist"))
                {
                    if (npc.GivenName == "Drew")
                    {
                        npc.GivenName = "Дрю";
                    }
                    if (npc.GivenName == "Sam")
                    {
                        npc.GivenName = "Сэм";
                    }
                    if (npc.GivenName == "Alex")
                    {
                        npc.GivenName = "Алекс";
                    }
                    if (npc.GivenName == "Dan")
                    {
                        npc.GivenName = "Дэн";
                    }
                }
                if (npc.type == elementsAwoken.NPCType("Storyteller"))
                {
                    if (npc.GivenName == "Amadis")
                    {
                        npc.GivenName = "Амадис";
                    }
                    if (npc.GivenName == "Neivirk")
                    {
                        npc.GivenName = "Нейвирк";
                    }
                    if (npc.GivenName == "Herckeus")
                    {
                        npc.GivenName = "Херкеус";
                    }
                    if (npc.GivenName == "Nornex")
                    {
                        npc.GivenName = "Норнекс";
                    }
                    if (npc.GivenName == "Zairis")
                    {
                        npc.GivenName = "Зайрис";
                    }
                }
            }
        }
    }
}