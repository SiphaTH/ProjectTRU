using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ID;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications
{
    public class VanillaBuffsTranslation : CalamityGlobalBuffBase
    {
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            switch (type)
            {
                case BuffID.Endurance:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.Endurance");
                    break;

                case BuffID.MagicPower:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.MagicPower");
                    break;

                case BuffID.Archery:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.Archery");
                    break;

                case BuffID.Swiftness:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.Swiftness");
                    break;

                case BuffID.SugarRush:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.SugarRush");
                    break;

                case BuffID.NebulaUpDmg1:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.NebulaUpDmg1");
                    break;

                case BuffID.NebulaUpDmg2:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.NebulaUpDmg2");
                    break;

                case BuffID.NebulaUpDmg3:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.NebulaUpDmg3");
                    break;

                case BuffID.BeetleMight1:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.BeetleMight1");
                    break;

                case BuffID.BeetleMight2:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.BeetleMight2");
                    break;

                case BuffID.BeetleMight3:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.BeetleMight3");
                    break;

                case BuffID.BeetleEndurance1:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.BeetleEndurance1");
                    break;

                case BuffID.BeetleEndurance2:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.BeetleEndurance2");
                    break;

                case BuffID.BeetleEndurance3:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.BeetleEndurance3");
                    break;

                case BuffID.WeaponImbueVenom:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.WeaponImbueVenom");
                    break;

                case BuffID.WeaponImbueCursedFlames:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.WeaponImbueCursedFlames");
                    break;

                case BuffID.WeaponImbueFire:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.WeaponImbueFire");
                    break;

                case BuffID.WeaponImbueGold:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.WeaponImbueGold");
                    break;

                case BuffID.WeaponImbueIchor:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.WeaponImbueIchor");
                    break;

                case BuffID.WeaponImbueNanites:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.WeaponImbueNanites");
                    break;

                case BuffID.WeaponImbueConfetti:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.WeaponImbueConfetti");
                    break;

                case BuffID.WeaponImbuePoison:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.WeaponImbuePoison");
                    break;

                case BuffID.IceBarrier:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.IceBarrier");
                    break;

                case BuffID.ChaosState:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.ChaosState");
                    break;

                case BuffID.CursedInferno:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.CursedInferno");
                    break;

                case BuffID.Warmth:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.Warmth") +
                          (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Cold") : "");
                    break;

                case BuffID.Invisibility:
                    tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.Invisibility");
                    break;

                case BuffID.ObsidianSkin:
                    if (ModsCall.DeathMode)
                        tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.ObsidianSkin.DeathMode");
                    break;

                case BuffID.Inferno:
                    if (ModsCall.DeathMode)
                        tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.Inferno.DeathMode");
                    break;

                case BuffID.Campfire:
                    if (ModsCall.DeathMode)
                        tip = LangHelper.GetTextValue("Calamity.Vanilla.BuffDescription.Campfire.DeathMode");
                    break;

                case BuffID.Daybreak:
                    tip = Language.GetTextValue("BuffDescription.Daybreak");
                    break;
            }
        }
    }
}