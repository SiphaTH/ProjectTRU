using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications;

public class VanillaBuffsTranslation : GlobalBuff
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyBuffTip(int type, ref string tip, ref int rare)
    {
        tip = type switch
        {
            BuffID.Ironskin => tip.Replace("Increase defense by", "Защита увеличена на"),
            BuffID.MagicPower => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.MagicPower.Description"),
            BuffID.Archery => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.Archery.Description"),
            BuffID.Swiftness => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.Swiftness.Description"),
            BuffID.SugarRush => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.SugarRush.Description"),
            BuffID.LeafCrystal => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.LeafCrystal.Description"),
            BuffID.NebulaUpDmg1 => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.NebulaUpDmg1.Description"),
            BuffID.NebulaUpDmg2 => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.NebulaUpDmg2.Description"),
            BuffID.NebulaUpDmg3 => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.NebulaUpDmg3.Description"),
            BuffID.BeetleEndurance1 => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleEndurance1.Description"),
            BuffID.BeetleEndurance2 => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleEndurance2.Description"),
            BuffID.BeetleEndurance3 => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleEndurance3.Description"),
            BuffID.WeaponImbueVenom => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueVenom.Description"),
            BuffID.WeaponImbueCursedFlames => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueCursedFlames.Description"),
            BuffID.WeaponImbueFire => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueFire.Description"),
            BuffID.WeaponImbueGold => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueGold.Description"),
            BuffID.WeaponImbueIchor => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueIchor.Description"),
            BuffID.WeaponImbueNanites => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueNanites.Description"),
            BuffID.WeaponImbueConfetti => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueConfetti.Description"),
            BuffID.WeaponImbuePoison => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbuePoison.Description"),
            BuffID.IceBarrier => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.IceBarrier.Description"),
            BuffID.ChaosState => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.ChaosState.Description"),
            BuffID.Warmth => LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.Warmth.Description"),
            BuffID.WellFed => Language.GetTextValue("BuffDescription.WellFed"),
            BuffID.WellFed2 => Language.GetTextValue("BuffDescription.WellFed2"),
            BuffID.WellFed3 => Language.GetTextValue("BuffDescription.WellFed3"),
            _ => tip
        };
    }
}