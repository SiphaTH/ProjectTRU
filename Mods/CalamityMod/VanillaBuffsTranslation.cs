using CalamityRuTranslate.Common;
using CalamityRuTranslate.Utilities;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class VanillaBuffsTranslation : GlobalBuff
    {
        public override bool Autoload(ref string name) => ModsCall.Calamity != null && Translation.IsRussianLanguage;
        
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            switch (type)
            {
                case BuffID.NebulaUpDmg1:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.NebulaUpDmg1");
                    break;
                
                case BuffID.NebulaUpDmg2:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.NebulaUpDmg2");
                    break;
                
                case BuffID.NebulaUpDmg3:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.NebulaUpDmg3");
                    break;
                
                case BuffID.BeetleEndurance1:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.BeetleEndurance1");
                    break;
                
                case BuffID.BeetleEndurance2:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.BeetleEndurance2");
                    break;
                
                case BuffID.BeetleEndurance3:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.BeetleEndurance3");
                    break;
                
                case BuffID.WeaponImbueVenom:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbueVenom");
                    break;
                
                case BuffID.WeaponImbueCursedFlames:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbueCursedFlames");
                    break;
                
                case BuffID.WeaponImbueFire:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbueFire");
                    break;
                
                case BuffID.WeaponImbueGold:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbueGold");
                    break;
                
                case BuffID.WeaponImbueIchor:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbueIchor");
                    break;
                
                case BuffID.WeaponImbueNanites:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbueNanites");
                    break;
                
                case BuffID.WeaponImbueConfetti:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbueConfetti");
                    break;
                
                case BuffID.WeaponImbuePoison:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.WeaponImbuePoison");
                    break;
                
                case BuffID.IceBarrier:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.IceBarrier");
                    break;
                
                case BuffID.ChaosState:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.ChaosState");
                    break;
                
                case BuffID.CursedInferno:
                    if (ModsCall.Revenge)
                        tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.CursedInferno");
                    break;
                
                case BuffID.Warmth:
                    tip = ModsCall.DeathMode
                        ? LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.Warmth.DeathMode")
                        : LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.Warmth");
                    break;
                
                case BuffID.Invisibility:
                    tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.Invisibility");
                    break;
                
                case BuffID.ObsidianSkin:
                    if (ModsCall.DeathMode)
                        tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.ObsidianSkin.DeathMode");
                    break;
                
                case BuffID.Inferno:
                    if (ModsCall.DeathMode)
                        tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.Inferno.DeathMode");
                    break;
                
                case BuffID.Campfire:
                    if (ModsCall.DeathMode)
                        tip = LangUtilities.GetTextValue("Calamity", "Vanilla.BuffDescription.Campfire.DeathMode");
                    break;
                
                case BuffID.Daybreak:
                    tip = Language.GetTextValue("BuffDescription.Daybreak");
                    break;
            }
        }
    }
}