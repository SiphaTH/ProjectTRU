using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria;

namespace CalamityRuTranslate.Mods.FargowiltasSouls;

public class FargowiltasSoulsCombatText : ContentTranslation, ICombatText
{
    public override bool IsTranslationEnabled => ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;
    
    public override float Priority => 1f;
    
    public void CombatTextTranslation()
    {
        for (int i = 0; i < 100; i++)
        {
            if (Main.combatText[i].active)
            {
                Main.combatText[i].text = Main.combatText[i].text switch
                {
                    "CRINGE" => LangHelper.GetText("FargowiltasSouls.CombatTexts.1"),
                    "NOT POGGERS" => LangHelper.GetText("FargoSouls.CombatTexts.2"),
                    "MONKAS" => LangHelper.GetText("FargoSouls.CombatTexts.3"),
                    "SHOW WINGS" => LangHelper.GetText("FargoSouls.CombatTexts.4"),
                    "AERIAL BANE POG" => LangHelper.GetText("FargoSouls.CombatTexts.5"),
                    "REAL BOSS WHEN?" => LangHelper.GetText("FargoSouls.CombatTexts.6"),
                    "#NOTMYMASOMODE" => LangHelper.GetText("FargoSouls.CombatTexts.7"),
                    "OOA BAD ANYWAY" => LangHelper.GetText("FargoSouls.CombatTexts.8"),
                    "COPE MALD SEETHE" => LangHelper.GetText("FargoSouls.CombatTexts.9"),
                    "GET REAL" => LangHelper.GetText("FargoSouls.CombatTexts.10"),
                    "GET FAKE" => LangHelper.GetText("FargoSouls.CombatTexts.11"),
                    "POGGERS" => LangHelper.GetText("FargoSouls.CombatTexts.12"),
                    "ResidentSleeper" => LangHelper.GetText("FargoSouls.CombatTexts.13"),
                    "If you can read this say 22" => LangHelper.GetText("FargoSouls.CombatTexts.14"),
                    "GuraSit" => LangHelper.GetText("FargoSouls.CombatTexts.15"),
                    "play calamity" => LangHelper.GetText("FargoSouls.CombatTexts.16"),
                    "play thorium" => LangHelper.GetText("FargoSouls.CombatTexts.17"),
                    "hardcore 1hp challenge when?" => LangHelper.GetText("FargoSouls.CombatTexts.18"),
                    "now do it with a copper shortsword" => LangHelper.GetText("FargoSouls.CombatTexts.19"),
                    "Zenith Yoyo?" => LangHelper.GetText("FargoSouls.CombatTexts.20"),
                    "guys how do i beat moon lord" => LangHelper.GetText("FargoSouls.CombatTexts.21"),
                    "GUYS I GOT TERRAPRISMA" => LangHelper.GetText("FargoSouls.CombatTexts.22"),
                    "how do i install this update" => LangHelper.GetText("FargoSouls.CombatTexts.23"),
                    "Hi YouTube!" => LangHelper.GetText("FargoSouls.CombatTexts.24"),
                    "<Message was deleted by staff>" => LangHelper.GetText("FargoSouls.CombatTexts.25"),
                    _ => Main.combatText[i].text
                };
            }
        }
    }
}