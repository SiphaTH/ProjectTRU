using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class CalamityCombatText : ContentTranslation, ICombatText
{
    public override bool IsTranslationEnabled => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override float Priority => 1f;
    
    public void CombatTextTranslation()
    {
        for (int i = 0; i < 100; i++)
        {
            if (Main.combatText[i].active)
            {
                Main.combatText[i].text = Main.combatText[i].text switch
                {
                    "No decryption computer installed" => LangHelper.GetText("CalamityMod.CombatTexts.1"),
                    "The Community cracks..." => LangHelper.GetText("CalamityMod.CombatTexts.2"),
                    "The invasion hastens!" => LangHelper.GetText("CalamityMod.CombatTexts.3"),
                    "The ethereal invaders march ever-faster!" => LangHelper.GetText("CalamityMod.CombatTexts.4"),
                    "You learned how to create new things!" => LangHelper.GetText("CalamityMod.CombatTexts.5"),
                    "Parry!" => LangHelper.GetText("CalamityMod.CombatTexts.6"),
                    "Tock" => LangHelper.GetText("CalamityMod.CombatTexts.7"),
                    "Tick" => LangHelper.GetText("CalamityMod.CombatTexts.8"),
                    "Insufficient space!" => LangHelper.GetText("CalamityMod.CombatTexts.9"),
                    "Cannot Deploy" => LangHelper.GetText("CalamityMod.CombatTexts.10"),
                    "Jackpot!!!" => LangHelper.GetText("CalamityMod.CombatTexts.11"),
                    "Triples!" => LangHelper.GetText("CalamityMod.CombatTexts.12"),
                    "Doubles!" => LangHelper.GetText("CalamityMod.CombatTexts.13"),
                    "Bust!" => LangHelper.GetText("CalamityMod.CombatTexts.14"),
                    _ => Main.combatText[i].text
                };
            }
        }
    }
}