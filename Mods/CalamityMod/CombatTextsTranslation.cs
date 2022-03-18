using CalamityRuTranslate.Common.Utilities;
using Terraria;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public static class CombatTextsTranslation
    {
        internal static void SetupTranslation()
        {
            for (int i = 0; i < 100; i++)
            {
                if (Main.combatText[i].active)
                {
                    if (Main.combatText[i].text == "No decryption computer installed")
                    {
                        Main.combatText[i].text = LangHelper.GetText("Calamity.CombatText.1");
                    }
                    if (Main.combatText[i].text == "The Community cracks...")
                    {
                        Main.combatText[i].text = LangHelper.GetText("Calamity.CombatText.2");
                    }
                    if (Main.combatText[i].text == "The invasion hastens!")
                    {
                        Main.combatText[i].text = LangHelper.GetText("Calamity.CombatText.3");
                    }
                    if (Main.combatText[i].text == "The ethereal invaders march ever-faster!")
                    {
                        Main.combatText[i].text = LangHelper.GetText("Calamity.CombatText.4");
                    }
                    if (Main.combatText[i].text == "You learned how to create new things!")
                    {
                        Main.combatText[i].text = LangHelper.GetText("Calamity.CombatText.5");
                    }
                    if (Main.combatText[i].text == "Parry!")
                    {
                        Main.combatText[i].text = LangHelper.GetText("Calamity.CombatText.6");
                    }
                }
            }
        }
    }
}