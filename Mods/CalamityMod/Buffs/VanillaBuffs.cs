using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Utilities;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.Buffs
{
    public class VanillaBuffs : GlobalBuff
    {
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            if (CoreCalamityTranslation.CalamityMod != null && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                switch (type)
                {
                    case BuffID.NebulaUpDmg1:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.NebulaUpDmg1");
                        break;
                    case BuffID.NebulaUpDmg2:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.NebulaUpDmg2");
                        break;
                    case BuffID.NebulaUpDmg3:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.NebulaUpDmg3");
                        break;
                    case BuffID.BeetleEndurance1:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.BeetleEndurance1");
                        break;
                    case BuffID.BeetleEndurance2:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.BeetleEndurance2");
                        break;
                    case BuffID.BeetleEndurance3:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.BeetleEndurance3");
                        break;
                    case BuffID.WeaponImbueVenom:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.WeaponImbueVenom");
                        break;
                    case BuffID.WeaponImbueCursedFlames:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.WeaponImbueCursedFlames");
                        break;
                    case BuffID.WeaponImbueFire:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.WeaponImbueFire");
                        break;
                    case BuffID.WeaponImbueGold:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.WeaponImbueGold");
                        break;
                    case BuffID.WeaponImbueIchor:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.WeaponImbueIchor");
                        break;
                    case BuffID.WeaponImbueNanites:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.WeaponImbueNanites");
                        break;
                    case BuffID.WeaponImbueConfetti:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.WeaponImbueConfetti");
                        break;
                    case BuffID.WeaponImbuePoison:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.WeaponImbuePoison");
                        break;
                    case BuffID.IceBarrier:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.IceBarrier");
                        break;
                    case BuffID.ChaosState:
                        tip = Translation.KeyText("Calamity.VanillaBuffs.ChaosState");
                        break;
                    case BuffID.CursedInferno:
                        if (CoreCalamityTranslation.Revenge)
                            tip = Language.GetTextValue("BuffDescription.CursedInferno") + Translation.KeyText("Calamity.VanillaBuffs.CursedInferno");
                        break;
                    case BuffID.Warmth:
                        tip = CoreCalamityTranslation.DeathMode ? 
                            Language.GetTextValue("BuffDescription.Warmth") + string.Format(Translation.KeyText("Calamity.VanillaBuffs.Warmth.DeathMode"), RussianDictionaries.CalamityBuffs["GlacialState"].Item1) : 
                            Language.GetTextValue("BuffDescription.Warmth") + string.Format(Translation.KeyText("Calamity.VanillaBuffs.Warmth"), RussianDictionaries.CalamityBuffs["GlacialState"].Item1);
                        break;
                    case BuffID.Invisibility:
                        tip = Language.GetTextValue("BuffDescription.Invisibility") + Translation.KeyText("Calamity.VanillaBuffs.Invisibility");
                        break;
                    case BuffID.ObsidianSkin:
                        if (CoreCalamityTranslation.DeathMode)
                            tip = Language.GetTextValue("BuffDescription.ObsidianSkin") + Translation.KeyText("Calamity.VanillaBuffs.ObsidianSkin.DeathMode");
                        break;
                    case BuffID.Inferno:
                        if (CoreCalamityTranslation.DeathMode)
                            tip = Language.GetTextValue("BuffDescription.Inferno") + Translation.KeyText("Calamity.VanillaBuffs.Inferno.DeathMode");
                        break;
                    case BuffID.Campfire:
                        if (CoreCalamityTranslation.DeathMode)
                            tip = Language.GetTextValue("BuffDescription.Campfire") + Translation.KeyText("Calamity.VanillaBuffs.Campfire.DeathMode");
                        break;
                    case BuffID.Daybreak:
                        tip = Language.GetTextValue("BuffDescription.Daybreak");
                        break;
                }

                if (type == CoreCalamityTranslation.CalamityMod.BuffType("Molten") && CoreCalamityTranslation.DeathMode) 
                    tip = Translation.KeyText("Calamity.Buffs.Molten.DeathMode");

                if (type == CoreCalamityTranslation.CalamityMod.BuffType("ProfanedBabs"))
                {
                    switch (tip)
                    {
                        case "The Profaned Babs will accompany you!":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedBabs.tip1");
                            break;
                        case "The Profaned Babs will fight for and defend you!":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedBabs.tip2");
                            break;
                        case "The Defensive Duo will protect and heal you!":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedBabs.tip3");
                            break;
                        case "The Offensive Duo will fight for and heal you!":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedBabs.tip4");
                            break;
                    }
                }

                if (type == CoreCalamityTranslation.CalamityMod.BuffType("ProfanedCrystalBuff"))
                {
                    switch (tip)
                    {
                        case "An ascended ice construct is suppressing your true potential..":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedCrystalBuff.tip1");
                            break;
                        case "A magical hat overwhelms your senses, squandering your true potential..":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedCrystalBuff.tip2");
                            break;
                        case "Your profaned soul is constrained by your insufficient summoning powers":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedCrystalBuff.tip3");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe light of the sun empowers your offensive capabilities":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedCrystalBuff.tip4");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe darkness of night cools your flames, empowering your defensive capabilities":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedCrystalBuff.tip5");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe water douses your flames, empowering your defensive capabilities":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedCrystalBuff.tip6");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe heat of the lava empowers your offensive capabilities":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedCrystalBuff.tip7");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe honey cools your flames, empowering your defensive capabilities":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedCrystalBuff.tip8");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe water douses your flames, empowering your defensive capabilities\nYour weakened life force fuels your desperate attacks":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedCrystalBuff.tip9");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe heat of the lava empowers your offensive capabilities\nYour weakened life force fuels your desperate attacks":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedCrystalBuff.tip10");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe light of the sun empowers your offensive capabilities\nYour weakened life force fuels your desperate attacks":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedCrystalBuff.tip11");
                            break;
                        case "You are an emissary of the profaned goddess now!\nThe honey cools your flames, empowering your defensive capabilities\nYour weakened life force fuels your desperate attacks":
                            tip = Translation.KeyText("Calamity.Buffs.ProfanedCrystalBuff.tip12");
                            break;
                    }
                }
            }
        }
    }
}