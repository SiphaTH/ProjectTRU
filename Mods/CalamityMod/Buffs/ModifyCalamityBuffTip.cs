using CalamityRuTranslate.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.Buffs
{
    public class ModifiedCalamityBuffTip : GlobalBuff
    {
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && 
                CalamityRuTranslate.Config.CalamityTranslation)
            {
                if (type == CoreCalamityTranslation.CalamityMod.BuffType("Molten") && CoreCalamityTranslation.DeathMode) 
                    tip = Translation.KeyText2("Calamity.BuffDescription.Molten.DeathMode");

                if (type == CoreCalamityTranslation.CalamityMod.BuffType("ProfanedBabs"))
                {
                    switch (tip)
                    {
                        case "The Profaned Babs will accompany you!":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedBabs.1");
                            break;
                        case "The Profaned Babs will fight for and defend you!":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedBabs.2");
                            break;
                        case "The Defensive Duo will protect and heal you!":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedBabs.3");
                            break;
                        case "The Offensive Duo will fight for and heal you!":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedBabs.4");
                            break;
                    }
                }

                if (type == CoreCalamityTranslation.CalamityMod.BuffType("ProfanedCrystalBuff"))
                {
                    switch (tip)
                    {
                        case "An ascended ice construct is suppressing your true potential..":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedCrystalBuff.1");
                            break;
                        case "A magical hat overwhelms your senses, squandering your true potential..":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedCrystalBuff.2");
                            break;
                        case "Your profaned soul is constrained by your insufficient summoning powers":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedCrystalBuff.3");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe light of the sun empowers your offensive capabilities":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedCrystalBuff.4");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe darkness of night cools your flames, empowering your defensive capabilities":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedCrystalBuff.5");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe water douses your flames, empowering your defensive capabilities":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedCrystalBuff.6");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe heat of the lava empowers your offensive capabilities":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedCrystalBuff.7");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe honey cools your flames, empowering your defensive capabilities":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedCrystalBuff.8");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe water douses your flames, empowering your defensive capabilities\nYour weakened life force fuels your desperate attacks":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedCrystalBuff.9");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe heat of the lava empowers your offensive capabilities\nYour weakened life force fuels your desperate attacks":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedCrystalBuff.10");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe light of the sun empowers your offensive capabilities\nYour weakened life force fuels your desperate attacks":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedCrystalBuff.11");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe honey cools your flames, empowering your defensive capabilities\nYour weakened life force fuels your desperate attacks":
                            tip = Translation.KeyText2("Calamity.BuffDescription.ProfanedCrystalBuff.12");
                            break;
                    }
                }
            }
        }
    }
}