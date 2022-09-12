using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria;

namespace CalamityRuTranslate.Mods.FargowiltasSouls;

public class FargowiltasSoulsCombatText : ContentTranslation
{
    public override bool IsTranslationEnabled => ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;
    
    public override float Priority => 1f;
    
    public override void ModifyModCombatText()
    {
        for (int i = 0; i < 100; i++)
        {
            if (Main.combatText[i].active)
            {
                if (Main.combatText[i].text.Equals("CRINGE"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargowiltasSouls.CombatTexts.1");
                }
                if (Main.combatText[i].text.Equals("NOT POGGERS"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.2");
                }
                if (Main.combatText[i].text.Equals("MONKAS"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.3");
                }
                if (Main.combatText[i].text.Equals("SHOW WINGS"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.4");
                }
                if (Main.combatText[i].text.Equals("AERIAL BANE POG"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.5");
                }
                if (Main.combatText[i].text.Equals("REAL BOSS WHEN?"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.6");
                }
                if (Main.combatText[i].text.Equals("#NOTMYMASOMODE"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.7");
                }

                if (Main.combatText[i].text.Equals("OOA BAD ANYWAY"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.8");
                }
                if (Main.combatText[i].text.Equals("COPE MALD SEETHE"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.9");
                }
                if (Main.combatText[i].text.Equals("GET REAL"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.10");
                }
                if (Main.combatText[i].text.Equals("GET FAKE"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.11");
                }
                if (Main.combatText[i].text.Equals("POGGERS"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.12");
                }
                if (Main.combatText[i].text.Equals("ResidentSleeper"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.13");
                }
                if (Main.combatText[i].text.Equals("If you can read this say 22"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.14");
                }
                if (Main.combatText[i].text.Equals("GuraSit"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.15");
                }
                if (Main.combatText[i].text.Equals("play calamity"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.16");
                }
                if (Main.combatText[i].text.Equals("play thorium"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.17");
                }
                if (Main.combatText[i].text.Equals("hardcore 1hp challenge when?"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.18");
                }
                if (Main.combatText[i].text.Equals("now do it with a copper shortsword"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.19");
                }
                if (Main.combatText[i].text.Equals("Zenith Yoyo?"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.20");
                }
                if (Main.combatText[i].text.Equals("guys how do i beat moon lord"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.21");
                }
                if (Main.combatText[i].text.Equals("GUYS I GOT TERRAPRISMA"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.22");
                }
                if (Main.combatText[i].text.Equals("how do i install this update"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.23");
                }
                if (Main.combatText[i].text.Equals("Hi YouTube!"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.24");
                }
                if (Main.combatText[i].text.Equals("<Message was deleted by staff>"))
                {
                    Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatTexts.25");
                }
            }
        }
    }
}