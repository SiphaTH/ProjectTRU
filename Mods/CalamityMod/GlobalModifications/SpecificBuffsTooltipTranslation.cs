using CalamityMod.Buffs.StatBuffs;
using CalamityMod.Buffs.Summon;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications
{
    public class SpecificBuffsTooltipTranslation : CalamityGlobalBuffBase
    {
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            if (type == ModContent.BuffType<ProfanedBabs>())
            {
                switch (tip)
                {
                    case "The Profaned Babs will accompany you!":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedBabs.1");
                        break;

                    case "The Profaned Babs will fight for and defend you!":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedBabs.2");
                        break;

                    case "The Defensive Duo will protect and heal you!":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedBabs.3");
                        break;

                    case "The Offensive Duo will fight for and heal you!":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedBabs.4");
                        break;
                }
            }

            if (type == ModContent.BuffType<ProfanedCrystalBuff>())
            {
                switch (tip)
                {
                    case "An ascended ice construct is suppressing your true potential..":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedCrystalBuff.1");
                        break;

                    case "A magical hat overwhelms your senses, squandering your true potential..":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedCrystalBuff.2");
                        break;

                    case "Your profaned soul is constrained by your insufficient summoning powers":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedCrystalBuff.3");
                        break;

                    case "You are an emissary of the profaned goddess now!\nThe light of the sun empowers your offensive capabilities":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedCrystalBuff.4");
                        break;

                    case "You are an emissary of the profaned goddess now!\nThe darkness of night cools your flames, empowering your defensive capabilities":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedCrystalBuff.5");
                        break;

                    case "You are an emissary of the profaned goddess now!\nThe water douses your flames, empowering your defensive capabilities":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedCrystalBuff.6");
                        break;

                    case "You are an emissary of the profaned goddess now!\nThe heat of the lava empowers your offensive capabilities":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedCrystalBuff.7");
                        break;

                    case "You are an emissary of the profaned goddess now!\nThe honey cools your flames, empowering your defensive capabilities":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedCrystalBuff.8");
                        break;

                    case "You are an emissary of the profaned goddess now!\nThe water douses your flames, empowering your defensive capabilities\nYour weakened life force fuels your desperate attacks":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedCrystalBuff.9");
                        break;

                    case "You are an emissary of the profaned goddess now!\nThe heat of the lava empowers your offensive capabilities\nYour weakened life force fuels your desperate attacks":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedCrystalBuff.10");
                        break;

                    case "You are an emissary of the profaned goddess now!\nThe light of the sun empowers your offensive capabilities\nYour weakened life force fuels your desperate attacks":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedCrystalBuff.11");
                        break;

                    case "You are an emissary of the profaned goddess now!\nThe honey cools your flames, empowering your defensive capabilities\nYour weakened life force fuels your desperate attacks":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedCrystalBuff.12");
                        break;

                    case "The soul within this crystal has been defiled by overwhelming energy waves from dangerous mechanations":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedCrystalBuff.13");
                        break;

                    case "The profaned soul within has been defiled by the powerful magic of a supreme witch":
                        tip = LangHelper.GetTextValue("Calamity.BuffDescription.ProfanedCrystalBuff.14");
                        break;
                }
            }

            if (type == ModContent.BuffType<BossZen>()) 
                tip = LangHelper.GetTextValue("Calamity.BuffDescription.BossZen");
        }
    }
}