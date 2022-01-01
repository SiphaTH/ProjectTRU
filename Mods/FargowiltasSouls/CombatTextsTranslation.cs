using CalamityRuTranslate.Common.Utilities;
using Terraria;

namespace CalamityRuTranslate.Mods.FargowiltasSouls
{
    public static class CombatTextsTranslation
    {
        internal static void SetupTranslation()
        {
            for (int i = 0; i < 100; i++)
            {
                if (Main.combatText[i].active)
                {
                    if (Main.combatText[i].text == "CRINGE")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.1");
                    }
                    if (Main.combatText[i].text == "NOT POGGERS")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.2");
                    }
                    if (Main.combatText[i].text == "SHOW WINGS")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.3");
                    }
                    if (Main.combatText[i].text == "AERIAL BANE POG")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.4");
                    }
                    if (Main.combatText[i].text == "REAL BOSS WHEN?")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.5");
                    }
                    if (Main.combatText[i].text == "#NOTMYMASOMODE")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.6");
                    }
                    if (Main.combatText[i].text == "OOA BAD ANYWAY")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.7");
                    }
                    if (Main.combatText[i].text == "COPE MALD SEETHE")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.8");
                    }
                    if (Main.combatText[i].text == "GET REAL")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.9");
                    }
                    if (Main.combatText[i].text == "GET FAKE")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.10");
                    }
                    if (Main.combatText[i].text == "If you can read this say 22")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.11");
                    }
                    if (Main.combatText[i].text == "play calamity")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.12");
                    }
                    if (Main.combatText[i].text == "play thorium")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.13");
                    }
                    if (Main.combatText[i].text == "hardcore 1hp challenge when?")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.14");
                    }
                    if (Main.combatText[i].text == "now do it with a copper shortsword")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.15");
                    }
                    if (Main.combatText[i].text == "Zenith Yoyo?")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.16");
                    }
                    if (Main.combatText[i].text == "guys how do i beat moon lord")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.17");
                    }
                    if (Main.combatText[i].text == "GUYS I GOT TERRAPRISMA")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.18");
                    }
                    if (Main.combatText[i].text == "how do i install this update")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.19");
                    }
                    if (Main.combatText[i].text == "Hi YouTube!")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.20");
                    }
                    if (Main.combatText[i].text == "<Message was deleted by staff>")
                    {
                        Main.combatText[i].text = LangHelper.GetText("FargoSouls.CombatText.21");
                    }
                }
            }
        }
    }
}