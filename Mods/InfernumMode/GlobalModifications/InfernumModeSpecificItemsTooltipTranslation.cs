using System.Collections.Generic;
using CalamityMod.Events;
using CalamityMod.Items.SummonItems;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using InfernumMode.Items.Relics;
using InfernumMode.Systems;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.GlobalModifications;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class InfernumModeSpecificItemsTooltipTranslation : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Calamity != null && ModsCall.Infernum != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        bool flag = !BossRushEvent.BossRushActive && WorldSaveSystem.InfernumMode;
        if (item.type == ItemID.CelestialSigil)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.Vanilla.CelestialSigil.Tooltip");
            });
        }
        
        else if (item.type == ModContent.ItemType<ProvidenceRelic>())
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "The first major hurdle following the defeat of the Moon Lord. Your triumph over her was by no means a small feat.\nPerhaps consider fighting her again during the night for a special challenge?", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.ProvidenceRelic.Tooltip.0");
            });
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "Bruh? What the heck? Are you OK?\nYou were supposed to fight her at night AFTER beating her during the day first!", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.ProvidenceRelic.Tooltip.HasBeatedInfernumNightProvBeforeDay");
            });
        }
        else if (item.type == ModContent.ItemType<ProfanedShard>())
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "Summons the Profaned Guardians when used in the profaned garden at the far right of the underworld", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.ProfanedShard.Tooltip");
            });
            
            ItemHelper.TranslateTooltip(item, tooltips, "Warning", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.ProfanedShard.Tooltip.Warning");
            });
        }
        else if (item.type == ModContent.ItemType<ProfanedCore>())
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "Summons Providence when used at the alter in the profaned temple at the far right of the underworld", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.ProfanedCore.Tooltip");
            });
        }
        else if (item.type == ItemID.LihzahrdPowerCell)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                if (flag)
                    tooltip.Text += "\n" + LangHelper.GetTextValue("InfernumMode.Items.Vanilla.LihzahrdPowerCell.Tooltip");
            });
        }
        else if (item.type == ModContent.ItemType<EyeOfCthulhuRelic>())
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "Remember to not force yourself too much in the pursuit of victory. Take breaks if you need to.\nThe most important thing is fun.", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.EyeOfCthulhuRelic.Tooltip.0");
            });
        }
        else if (item.type == ModContent.ItemType<EmpressOfLightRelic>())
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "The optional foes may at times be the most formidable. So too may they yield the greatest rewards.", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.EmpressOfLightRelic.Tooltip.0");
            });
        }
        else if (item.type == ModContent.ItemType<EmpressOfLightRelic>())
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "The optional foes may at times be the most formidable. So too may they yield the greatest rewards.", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.EmpressOfLightRelic.Tooltip.0");
            });
        }
        else if (item.type == ModContent.ItemType<GolemRelic>())
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "Simple methodical planning goes a long way. It will be invaluable against future obstacles.", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.GolemRelic.Tooltip.0");
            });
        }
        else if (item.type == ModContent.ItemType<KingSlimeRelic>())
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "Even seasoned players may struggle somewhat in the face of something new and unfamiliar. Adaptability is key.", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.KingSlimeRelic.Tooltip.0");
            });
        }
        else if (item.type == ModContent.ItemType<MoonLordRelic>())
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "You have done very well thus far.\nMay your tenacity guide you through the remaining challenges.", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.MoonLordRelic.Tooltip.0");
            });
        }
        else if (item.type == ModContent.ItemType<OldDukeRelic>())
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "Difficult as the fight may be, you were wise to endure and overcome the challenge it brings.\nYou will find that the mechanics it tested will be relevant again soon.", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.OldDukeRelic.Tooltip.0");
            });
        }
        else if (item.type == ModContent.ItemType<PlanteraRelic>())
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "Be proud of your death count!\nThe more you die, the more you're learning. Keep going!", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.PlanteraRelic.Tooltip.0");
            });
        }
        else if (item.type == ModContent.ItemType<SkeletronRelic>())
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "The first major roadblock. You are better now than before you faced it. Did you have fun learning its patterns?", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.SkeletronRelic.Tooltip.0");
            });
        }
        else if (item.type == ModContent.ItemType<DevourerOfGodsRelic>())
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "Sometimes pure reaction skill is the most valuable thing to cultivate.\nYou are in the final stretch. Your determination has proven invaluable up to this point.\nMay it guide you through the last challenges.", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.DevourerOfGodsRelic.Tooltip.0");
            });
        }
    }
}