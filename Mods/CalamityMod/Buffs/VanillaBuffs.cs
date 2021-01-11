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
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && 
                CalamityRuTranslate.Config.CalamityTranslation)
            {
                switch (type)
                {
                    case BuffID.NebulaUpDmg1:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.NebulaUpDmg1");
                        break;
                    case BuffID.NebulaUpDmg2:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.NebulaUpDmg2");
                        break;
                    case BuffID.NebulaUpDmg3:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.NebulaUpDmg3");
                        break;
                    case BuffID.BeetleEndurance1:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.BeetleEndurance1");
                        break;
                    case BuffID.BeetleEndurance2:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.BeetleEndurance2");
                        break;
                    case BuffID.BeetleEndurance3:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.BeetleEndurance3");
                        break;
                    case BuffID.WeaponImbueVenom:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.WeaponImbueVenom");
                        break;
                    case BuffID.WeaponImbueCursedFlames:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.WeaponImbueCursedFlames");
                        break;
                    case BuffID.WeaponImbueFire:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.WeaponImbueFire");
                        break;
                    case BuffID.WeaponImbueGold:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.WeaponImbueGold");
                        break;
                    case BuffID.WeaponImbueIchor:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.WeaponImbueIchor");
                        break;
                    case BuffID.WeaponImbueNanites:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.WeaponImbueNanites");
                        break;
                    case BuffID.WeaponImbueConfetti:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.WeaponImbueConfetti");
                        break;
                    case BuffID.WeaponImbuePoison:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.WeaponImbuePoison");
                        break;
                    case BuffID.IceBarrier:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.IceBarrier");
                        break;
                    case BuffID.ChaosState:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.ChaosState");
                        break;
                    case BuffID.CursedInferno:
                        if (CoreCalamityTranslation.Revenge)
                            tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.CursedInferno");
                        break;
                    case BuffID.Warmth:
                        tip = CoreCalamityTranslation.DeathMode
                            ? Translation.KeyText2("Calamity.Vanilla.BuffDescription.Warmth.DeathMode")
                            : Translation.KeyText2("Calamity.Vanilla.BuffDescription.Warmth");
                        break;
                    case BuffID.Invisibility:
                        tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.Invisibility");
                        break;
                    case BuffID.ObsidianSkin:
                        if (CoreCalamityTranslation.DeathMode)
                            tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.ObsidianSkin.DeathMode");
                        break;
                    case BuffID.Inferno:
                        if (CoreCalamityTranslation.DeathMode)
                            tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.Inferno.DeathMode");
                        break;
                    case BuffID.Campfire:
                        if (CoreCalamityTranslation.DeathMode)
                            tip = Translation.KeyText2("Calamity.Vanilla.BuffDescription.Campfire.DeathMode");
                        break;
                    case BuffID.Daybreak:
                        tip = Language.GetTextValue("BuffDescription.Daybreak");
                        break;
                }
            }
        }
    }
}