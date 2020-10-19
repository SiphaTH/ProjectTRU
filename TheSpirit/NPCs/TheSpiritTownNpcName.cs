using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.TheSpirit.NPCs
{
    public class TheSpiritTownNpcName : GlobalNPC
    {
        public override void AI(NPC npc)
        {
            Mod spirit = ModLoader.GetMod("SpiritMod");

            if (spirit != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                if (CalamityRuTranslate.TRuConfig.SpiritTranslation)
                {
                    if (npc.type == spirit.NPCType("Adventurer"))
                    {
                        if (npc.GivenName == "Morgan")
                        {
                            npc.GivenName = "Морган";
                        }

                        if (npc.GivenName == "Adam")
                        {
                            npc.GivenName = "Адам";
                        }
                        
                        if (npc.GivenName == "Aziz")
                        {
                            npc.GivenName = "Азиз";
                        }
                        
                        if (npc.GivenName == "Temir")
                        {
                            npc.GivenName = "Темир";
                        }
                        
                        if (npc.GivenName == "Evan")
                        {
                            npc.GivenName = "Эван";
                        }
                        
                        if (npc.GivenName == "Senzen")
                        {
                            npc.GivenName = "Сензен";
                        }
                        
                        if (npc.GivenName == "Johanovic")
                        {
                            npc.GivenName = "Йоханович";
                        }
                        
                        if (npc.GivenName == "Adrian")
                        {
                            npc.GivenName = "Адриан";
                        }
                        
                        if (npc.GivenName == "Christopher")
                        {
                            npc.GivenName = "Кристофер";
                        }
                    }

                    if (npc.type == spirit.NPCType("Gambler"))
                    {
                        if (npc.GivenName == "Yumeko")
                        {
                            npc.GivenName = "Юмеко";
                        }
                        
                        if (npc.GivenName == "Vanessa")
                        {
                            npc.GivenName = "Ванесса";
                        }
                        
                        if (npc.GivenName == "Gray")
                        {
                            npc.GivenName = "Грей";
                        }
                        
                        if (npc.GivenName == "Alexandra")
                        {
                            npc.GivenName = "Александра";
                        }
                        
                        if (npc.GivenName == "Sasha")
                        {
                            npc.GivenName = "Саша";
                        }
                        
                        if (npc.GivenName == "Celine")
                        {
                            npc.GivenName = "Селин";
                        }
                        
                        if (npc.GivenName == "Aleksa")
                        {
                            npc.GivenName = "Алекса";
                        }
                    }

                    if (npc.type == spirit.NPCType("LoneTrapper"))
                    {
                        if (npc.GivenName == "Jace")
                        {
                            npc.GivenName = "Джейс";
                        }
                        
                        if (npc.GivenName == "Moral")
                        {
                            npc.GivenName = "Морал";
                        }
                        
                        if (npc.GivenName == "Benei")
                        {
                            npc.GivenName = "Беней";
                        }
                        
                        if (npc.GivenName == "Castiel")
                        {
                            npc.GivenName = "Кастиэль";
                        }
                    }
                    
                    if (npc.type == spirit.NPCType("Martian"))
                    {
                        if (npc.GivenName == "Marvin")
                        {
                            npc.GivenName = "Марвин";
                        }
                        
                        if (npc.GivenName == "Grunk")
                        {
                            npc.GivenName = "Гранк";
                        }
                        
                        if (npc.GivenName == "24-x3888")
                        {
                            npc.GivenName = "24-x3888";
                        }
                        
                        if (npc.GivenName == "Dr. Quagnar")
                        {
                            npc.GivenName = "Доктор Квагнар";
                        }
                        
                        if (npc.GivenName == "Dr. Boidzerg")
                        {
                            npc.GivenName = "Доктор Бойдцерг";
                        }
                        
                        if (npc.GivenName == "Zorgnax")
                        {
                            npc.GivenName = "Zorgnax";
                        }
                        
                        if (npc.GivenName == "Gazorp")
                        {
                            npc.GivenName = "Газорп";
                        }
                        
                        if (npc.GivenName == "Xanthor")
                        {
                            npc.GivenName = "Ксантор";
                        }
                    }
                    
                    if (npc.type == spirit.NPCType("Rogue"))
                    {
                        if (npc.GivenName == "Zane")
                        {
                            npc.GivenName = "Зейн";
                        }
                        
                        if (npc.GivenName == "Carlos")
                        {
                            npc.GivenName = "Карлос";
                        }
                        
                        if (npc.GivenName == "Tycho")
                        {
                            npc.GivenName = "Тихо";
                        }
                        
                        if (npc.GivenName == "Damien")
                        {
                            npc.GivenName = "Дэмиен";
                        }
                        
                        if (npc.GivenName == "Shane")
                        {
                            npc.GivenName = "Шейн";
                        }
                        
                        if (npc.GivenName == "Daryl")
                        {
                            npc.GivenName = "Дэрил";
                        }
                        
                        if (npc.GivenName == "Shepard")
                        {
                            npc.GivenName = "Шепард";
                        }
                        
                        if (npc.GivenName == "Sly")
                        {
                            npc.GivenName = "Слай";
                        }
                    }
                    
                    if (npc.type == spirit.NPCType("RuneWizard"))
                    {
                        if (npc.GivenName == "Malachai")
                        {
                            npc.GivenName = "Малачай";
                        }
                        
                        if (npc.GivenName == "Nisarmah")
                        {
                            npc.GivenName = "Нисарма";
                        }
                        
                        if (npc.GivenName == "Moneque")
                        {
                            npc.GivenName = "Монек";
                        }
                        
                        if (npc.GivenName == "Tosalah")
                        {
                            npc.GivenName = "Тосала";
                        }
                        
                        if (npc.GivenName == "Kentremah")
                        {
                            npc.GivenName = "Кентрема";
                        }
                        
                        if (npc.GivenName == "Salqueeh")
                        {
                            npc.GivenName = "Салки";
                        }
                        
                        if (npc.GivenName == "Oarno")
                        {
                            npc.GivenName = "Оарно";
                        }
                        
                        if (npc.GivenName == "Cosimo")
                        {
                            npc.GivenName = "Косимо";
                        }
                    }
                }
            }
        }
    }
}