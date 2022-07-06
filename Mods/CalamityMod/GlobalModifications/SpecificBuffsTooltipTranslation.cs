using CalamityMod;
using CalamityMod.Buffs.StatBuffs;
using CalamityMod.Buffs.Summon;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications;

[JITWhenModsEnabled("CalamityMod")]
public class SpecificBuffsTooltipTranslation : GlobalBuff
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyBuffTip(int type, ref string tip, ref int rare)
    {
        if (type == ModContent.BuffType<BossEffects>())
        {
            tip = LangHelper.GetTextValue(CalamityConfig.Instance.BossZen ? "CalamityMod.Buffs.BossEffects.Description.BossZen" : "CalamityMod.Buffs.BossEffects.Description");
        }
        if (type == ModContent.BuffType<ProfanedBabs>())
        {
            tip = tip switch
            {
                "The Profaned Babs will accompany you!" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedBabs.Description.1"),
                "The Profaned Babs will fight for and defend you!" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedBabs.Description.2"),
                "The Defensive Duo will protect and heal you!" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedBabs.Description.3"),
                "The Offensive Duo will fight for and heal you!" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedBabs.Description.4"),
                _ => tip
            };
        }
        
        if (type == ModContent.BuffType<ProfanedCrystalBuff>())
        {
            tip = tip switch
            {
                "An ascended ice construct is suppressing your true potential.." => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.1"),
                "A magical hat overwhelms your senses, squandering your true potential.." => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.2"),
                "Your profaned soul is constrained by your insufficient summoning powers" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.3"),
                "You are an emissary of the profaned goddess now!\nThe light of the sun empowers your offensive capabilities" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.4"),
                "You are an emissary of the profaned goddess now!\nThe darkness of night cools your flames, empowering your defensive capabilities" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.5"),
                "You are an emissary of the profaned goddess now!\nThe water douses your flames, empowering your defensive capabilities" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.6"),
                "You are an emissary of the profaned goddess now!\nThe heat of the lava empowers your offensive capabilities" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.7"),
                "You are an emissary of the profaned goddess now!\nThe honey cools your flames, empowering your defensive capabilities" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.8"),
                "You are an emissary of the profaned goddess now!\nThe water douses your flames, empowering your defensive capabilities\nYour weakened life force fuels your desperate attacks" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.9"),
                "You are an emissary of the profaned goddess now!\nThe heat of the lava empowers your offensive capabilities\nYour weakened life force fuels your desperate attacks" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.10"),
                "You are an emissary of the profaned goddess now!\nThe light of the sun empowers your offensive capabilities\nYour weakened life force fuels your desperate attacks" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.11"),
                "You are an emissary of the profaned goddess now!\nThe honey cools your flames, empowering your defensive capabilities\nYour weakened life force fuels your desperate attacks" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.12"),
                "The soul within this crystal has been defiled by overwhelming energy waves from dangerous mechanations" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.13"),
                "The profaned soul within has been defiled by the powerful magic of a supreme witch" => LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.14"),
                _ => tip
            };
        }
    }
}