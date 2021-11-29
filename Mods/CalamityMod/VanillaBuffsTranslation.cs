using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class VanillaBuffsTranslation : GlobalBuff
    {
        public override bool Autoload(ref string name) => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;
        
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            switch (type)
            {
                case BuffID.Endurance:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.Endurance");
                    break;
                
                case BuffID.MagicPower:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.MagicPower");
                    break;
                
                case BuffID.Archery:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.Archery");
                    break;
                
                case BuffID.Swiftness:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.Swiftness");
                    break;
                
                case BuffID.SugarRush:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.SugarRush");
                    break;
                
                case BuffID.NebulaUpDmg1:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.NebulaUpDmg1");
                    break;
                
                case BuffID.NebulaUpDmg2:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.NebulaUpDmg2");
                    break;
                
                case BuffID.NebulaUpDmg3:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.NebulaUpDmg3");
                    break;
                
                case BuffID.BeetleMight1:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.BeetleMight1");
                    break;
                
                case BuffID.BeetleMight2:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.BeetleMight2");
                    break;
                
                case BuffID.BeetleMight3:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.BeetleMight3");
                    break;
                
                case BuffID.BeetleEndurance1:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.BeetleEndurance1");
                    break;
                
                case BuffID.BeetleEndurance2:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.BeetleEndurance2");
                    break;
                
                case BuffID.BeetleEndurance3:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.BeetleEndurance3");
                    break;
                
                case BuffID.WeaponImbueVenom:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbueVenom");
                    break;
                
                case BuffID.WeaponImbueCursedFlames:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbueCursedFlames");
                    break;
                
                case BuffID.WeaponImbueFire:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbueFire");
                    break;
                
                case BuffID.WeaponImbueGold:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbueGold");
                    break;
                
                case BuffID.WeaponImbueIchor:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbueIchor");
                    break;
                
                case BuffID.WeaponImbueNanites:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbueNanites");
                    break;
                
                case BuffID.WeaponImbueConfetti:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbueConfetti");
                    break;
                
                case BuffID.WeaponImbuePoison:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbuePoison");
                    break;
                
                case BuffID.IceBarrier:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.IceBarrier");
                    break;
                
                case BuffID.ChaosState:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.ChaosState");
                    break;
                
                case BuffID.CursedInferno:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.CursedInferno");
                    break;
                
                case BuffID.Warmth:
                    tip = ModsCall.DeathMode
                        ? LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.Warmth.DeathMode")
                        : LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.Warmth");
                    break;
                
                case BuffID.Invisibility:
                    tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.Invisibility");
                    break;
                
                case BuffID.ObsidianSkin:
                    if (ModsCall.DeathMode)
                        tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.ObsidianSkin.DeathMode");
                    break;
                
                case BuffID.Inferno:
                    if (ModsCall.DeathMode)
                        tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.Inferno.DeathMode");
                    break;
                
                case BuffID.Campfire:
                    if (ModsCall.DeathMode)
                        tip = LangUtils.GetTextValue("Calamity", "Vanilla.BuffDescription.Campfire.DeathMode");
                    break;
                
                case BuffID.Daybreak:
                    tip = Language.GetTextValue("BuffDescription.Daybreak");
                    break;
            }
        }
    }
}