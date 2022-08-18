using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class CalamityCombatText : ContentTranslation
{
    public override bool IsTranslationEnabled => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override void LoadTranslation()
    {
        for (int i = 0; i < 100; i++)
        {
            if (Main.combatText[i].active)
            {
                if (Main.combatText[i].text.Equals("No decryption computer installed"))
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.1");
                }
                if (Main.combatText[i].text.Equals("The Community cracks..."))
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.2");
                }
                if (Main.combatText[i].text.Equals("The invasion hastens!"))
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.3");
                }
                if (Main.combatText[i].text.Equals("The ethereal invaders march ever-faster!"))
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.4");
                }
                if (Main.combatText[i].text.Equals("You learned how to create new things!"))
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.5");
                }
                if (Main.combatText[i].text.Equals("Parry!"))
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.6");
                }
                if (Main.combatText[i].text.Equals("Tock"))
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.7");
                }
                if (Main.combatText[i].text.Equals("Tick"))
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.8");
                }
                if (Main.combatText[i].text.Equals("Insufficient space!"))
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.9");
                }
                if (Main.combatText[i].text.Equals("Cannot Deploy"))
                {
                    Main.combatText[i].text = LangHelper.GetText("CalamityMod.CombatTexts.10");
                }
            }
        }
    }
}