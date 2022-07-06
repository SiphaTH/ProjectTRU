using CalamityRuTranslate.Common.Utilities;
using Terraria;

namespace CalamityRuTranslate.Mods.CalamityMod;

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
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.1");
                }
                if (Main.combatText[i].text == "The Community cracks...")
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.2");
                }
                if (Main.combatText[i].text == "The invasion hastens!")
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.3");
                }
                if (Main.combatText[i].text == "The ethereal invaders march ever-faster!")
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.4");
                }
                if (Main.combatText[i].text == "You learned how to create new things!")
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.5");
                }
                if (Main.combatText[i].text == "Parry!")
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.6");
                }
                if (Main.combatText[i].text == "Tock")
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.7");
                }
                if (Main.combatText[i].text == "Tick")
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.8");
                }
            }
        }
    }
}