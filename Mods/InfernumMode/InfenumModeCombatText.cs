using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfenumModeCombatText : ContentTranslation, ICombatText
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
                    "Infernum must be enabled to enter the Colosseum!" => LangHelper.GetText("InfernumMode.CombatTexts.1"),
                    "Gate not set!" => LangHelper.GetText("InfernumMode.CombatTexts.2"),
                    _ => Main.combatText[i].text
                };
            }
        }
    }
}