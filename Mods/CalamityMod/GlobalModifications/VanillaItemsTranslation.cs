using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications;

public class VanillaItemsTranslation : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (item.type == ItemID.CobaltSword)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Decreases enemy defense by 25% on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CobaltSword.Tooltip"));
            });
        }
        else if (item.type == ItemID.CobaltNaginata)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Decreases enemy defense by 25% on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CobaltNaginata.Tooltip"));
            });
        }
        else if (item.type == ItemID.PalladiumSword)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Increases life regen on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.PalladiumSword.Tooltip"));
            });
        }
        else if (item.type == ItemID.PalladiumPike)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Increases life regen on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.PalladiumPike.Tooltip"));
            });
        }
        else if (item.type == ItemID.MythrilSword)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Decreases enemy contact damage by 10% on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MythrilSword.Tooltip"));
            });
        }
        else if (item.type == ItemID.MythrilHalberd)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Decreases enemy contact damage by 10% on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MythrilHalberd.Tooltip"));
            });
        }
        else if (item.type == ItemID.OrichalcumSword)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Increases how frequently the Orichalcum set bonus triggers on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.OrichalcumSword.Tooltip"));
            });
        }
        else if (item.type == ItemID.OrichalcumHalberd)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Increases how frequently the Orichalcum set bonus triggers on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.OrichalcumHalberd.Tooltip"));
            });
        }
        else if (item.type == ItemID.AdamantiteSword)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Slows enemies on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.AdamantiteSword.Tooltip"));
            });
        }
        else if (item.type == ItemID.AdamantiteGlaive)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Slows enemies on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.AdamantiteGlaive.Tooltip"));
            });
        }
        else if (item.type == ItemID.TitaniumSword)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Deals increased damage to enemies with high knockback resistance",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TitaniumSword.Tooltip"));
            });
        }
        else if (item.type == ItemID.TitaniumTrident)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Deals increased damage to enemies with high knockback resistance",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TitaniumTrident.Tooltip"));
            });
        }
        else if (item.type == ItemID.Excalibur)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Inflicts Holy Flames\nDeals double damage to enemies above 75% life",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.Excalibur.Tooltip"));
            });
        }
        else if (item.type == ItemID.Gungnir)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Inflicts Holy Flames\nDeals double damage to enemies above 75% life",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.Gungnir.Tooltip"));
            });
        }
        else if (item.type == ItemID.TrueExcalibur)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Inflicts Holy Flames\nDeals double damage to enemies above 75% life",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TrueExcalibur.Tooltip"));
            });
        }
        else if (item.type == ItemID.CandyCaneSword)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Heals you on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CandyCaneSword.Tooltip"));
            });
        }
        else if (item.type == ItemID.FruitcakeChakram)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Heals you on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FruitcakeChakram.Tooltip"));
            });
        }
        else if (item.type == ItemID.StylistKilLaKillScissorsIWish)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.StylistKilLaKillScissorsIWish.Tooltip"));
            });
        }
        else if (item.type == ItemID.BluePhaseblade)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BluePhaseblade.Tooltip"));
            });
        }
        else if (item.type == ItemID.RedPhaseblade)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.RedPhaseblade.Tooltip"));
            });
        }
        else if (item.type == ItemID.GreenPhaseblade)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GreenPhaseblade.Tooltip"));
            });
        }
        else if (item.type == ItemID.PurplePhaseblade)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.PurplePhaseblade.Tooltip"));
            });
        }
        else if (item.type == ItemID.WhitePhaseblade)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.WhitePhaseblade.Tooltip"));
            });
        }
        else if (item.type == ItemID.YellowPhaseblade)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.YellowPhaseblade.Tooltip"));
            });
        }
        else if (item.type == ItemID.BluePhasesaber)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BluePhasesaber.Tooltip"));
            });
        }
        else if (item.type == ItemID.RedPhasesaber)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.RedPhasesaber.Tooltip"));
            });
        }
        else if (item.type == ItemID.GreenPhasesaber)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GreenPhasesaber.Tooltip"));
            });
        }
        else if (item.type == ItemID.PurplePhasesaber)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.PurplePhasesaber.Tooltip"));
            });
        }
        else if (item.type == ItemID.WhitePhasesaber)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.WhitePhasesaber.Tooltip"));
            });
        }
        else if (item.type == ItemID.YellowPhasesaber)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.YellowPhasesaber.Tooltip"));
            });
        }
        else if (item.type == ItemID.OrangePhaseblade)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.OrangePhaseblade.Tooltip"));
            });
        }
        else if (item.type == ItemID.OrangePhasesaber)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 100% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.OrangePhasesaber.Tooltip"));
            });
        }
        else if (item.type == ItemID.AntlionClaw)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 50% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.AntlionClaw.Tooltip"));
            });
        }
        else if (item.type == ItemID.BoneSword)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 50% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BoneSword.Tooltip"));
            });
        }
        else if (item.type == ItemID.BreakerBlade)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Ignores 50% of enemy defense",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BreakerBlade.Tooltip"));
            });
        }
        else if (item.type == ItemID.LightsBane)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Inflicts Shadowflame on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.LightsBane.Tooltip"));
            });
        }
        else if (item.type == ItemID.NightsEdge)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Inflicts Shadowflame on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.NightsEdge.Tooltip"));
            });
        }
        else if (item.type == ItemID.TrueNightsEdge)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Inflicts Shadowflame on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TrueNightsEdge.Tooltip"));
            });
        }
        else if (item.type == ItemID.BallOHurt)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Inflicts Shadowflame on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BallOHurt.Tooltip"));
            });
        }
        else if (item.type == ItemID.CorruptYoyo)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Inflicts Shadowflame on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CorruptYoyo.Tooltip"));
            });
        }
        else if (item.type == ItemID.BloodButcherer)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Inflicts Burning Blood on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BloodButcherer.Tooltip"));
            });
        }
        else if (item.type == ItemID.TheRottedFork)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Inflicts Burning Blood on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TheRottedFork.Tooltip"));
            });
        }
        else if (item.type == ItemID.TheMeatball)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Inflicts Burning Blood on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TheMeatball.Tooltip"));
            });
        }
        else if (item.type == ItemID.CrimsonYoyo)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Inflicts Burning Blood on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CrimsonYoyo.Tooltip"));
            });
        }
        else if (item.type == ItemID.CrimsonRod)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Inflicts Burning Blood on hit",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CrimsonRod.Tooltip"));
            });
        }
        else if (item.type == ItemID.SolarFlarePickaxe)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Can mine Uelibloom Ore",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SolarFlarePickaxe.Tooltip"));
            });
        }
        else if (item.type == ItemID.VortexPickaxe)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Can mine Uelibloom Ore",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.VortexPickaxe.Tooltip"));
            });
        }
        else if (item.type == ItemID.NebulaPickaxe)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Can mine Uelibloom Ore",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.NebulaPickaxe.Tooltip"));
            });
        }
        else if (item.type == ItemID.StardustPickaxe)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Can mine Uelibloom Ore",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.StardustPickaxe.Tooltip"));
            });
        }
        else if (item.type == ItemID.SolarFlareDrill)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Can mine Uelibloom Ore",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SolarFlareDrill.Tooltip"));
            });
        }
        else if (item.type == ItemID.VortexDrill)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Can mine Uelibloom Ore",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.VortexDrill.Tooltip"));
            });
        }
        else if (item.type == ItemID.NebulaDrill)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Can mine Uelibloom Ore",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.NebulaDrill.Tooltip"));
            });
        }
        else if (item.type == ItemID.StardustDrill)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Can mine Uelibloom Ore",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.StardustDrill.Tooltip"));
            });
        }
        else if (item.type == ItemID.FalconBlade)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Holding this item grants +20% increased movement speed",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FalconBlade.Tooltip"));
            });
        }
        else if (item.type == ItemID.FetidBaghnakhs)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Receives 25% benefit from melee speed bonuses",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FetidBaghnakhs.Tooltip"));
            });
        }
        else if (item.type == ItemID.BladedGlove)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Knockback", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Receives 50% benefit from melee speed bonuses",
                    LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BladedGlove.Tooltip"));
            });
        }

        if (item.prefix > 0)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "PrefixStealthGenBoost", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("stealth generation", LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TooltipTags.PrefixStealthGenBoost"));
            });
            
            ItemHelper.TranslateTooltip(item, tooltips, "PrefixStealthDamageBoost", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("stealth strike damage", LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TooltipTags.PrefixStealthDamageBoost"));
            });
        }
        
        if (item.accessory)
        {
            switch (item.prefix)
            {
                case 62:
                case 63:
                case 64:
                case 65:
                    ItemHelper.TranslateTooltip(item, tooltips, "PrefixAccDefense", tooltip =>
                    {
                        tooltip.Text = tooltip.Text.Replace("damage reduction", LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TooltipTags.PrefixAccDefense"));
                    });
                    break;
            }
        }
        
        ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
        {
            if (item.type == ItemID.Pwnhammer)
            {
                if (ModsCall.EarlyHardmodeProgressionRework)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.Vanilla.Pwnhammer.Tooltip");  
                }
            }
            else if (item.type == ItemID.Hammush)
            {
                if (ModsCall.EarlyHardmodeProgressionRework)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.Vanilla.Hammush.Tooltip");  
                }
            }
            tooltip.Text = item.type switch
            {
                ItemID.SlimeCrown => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SlimeCrown.Tooltip"),
                ItemID.BloodMoonStarter => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BloodMoonStarter.Tooltip"),
                ItemID.GoblinBattleStandard => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GoblinBattleStandard.Tooltip"),
                ItemID.PirateMap => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.PirateMap.Tooltip"),
                ItemID.SnowGlobe => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SnowGlobe.Tooltip"),
                ItemID.WarmthPotion => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.WarmthPotion.Tooltip"),
                ItemID.HandWarmer => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.HandWarmer.Tooltip"),
                ItemID.Picksaw => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.Picksaw.Tooltip"),
                ItemID.FlaskofVenom => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FlaskofVenom.Tooltip"),
                ItemID.FlaskofCursedFlames => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FlaskofCursedFlames.Tooltip"),
                ItemID.FlaskofFire => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FlaskofFire.Tooltip"),
                ItemID.FlaskofGold => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FlaskofGold.Tooltip"),
                ItemID.FlaskofIchor => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FlaskofIchor.Tooltip"),
                ItemID.FlaskofNanites => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FlaskofNanites.Tooltip"),
                ItemID.FlaskofParty => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FlaskofParty.Tooltip"),
                ItemID.FlaskofPoison => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FlaskofPoison.Tooltip"),
                ItemID.MiningHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MiningHelmet.Tooltip"),
                ItemID.UltrabrightHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.UltrabrightHelmet.Tooltip"),
                ItemID.RodofDiscord => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.RodofDiscord.Tooltip"),
                ItemID.SuperAbsorbantSponge => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SuperAbsorbantSponge.Tooltip"),
                ItemID.CrimsonHeart => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CrimsonHeart.Tooltip"),
                ItemID.ShadowOrb => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ShadowOrb.Tooltip"),
                ItemID.MagicLantern => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MagicLantern.Tooltip"),
                ItemID.JellyfishNecklace => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.JellyfishNecklace.Tooltip"),
                ItemID.FairyBell => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FairyBell.Tooltip"),
                ItemID.DD2PetGhost => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.DD2PetGhost.Tooltip"),
                ItemID.WispinaBottle => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.WispinaBottle.Tooltip"),
                ItemID.PumpkingPetItem => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.PumpkingPetItem.Tooltip"),
                ItemID.GolemPetItem => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GolemPetItem.Tooltip"),
                ItemID.FairyQueenPetItem => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FairyQueenPetItem.Tooltip"),
                ItemID.DivingHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.DivingHelmet.Tooltip"),
                ItemID.NeptunesShell => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.NeptunesShell.Tooltip"),
                ItemID.MoonShell => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MoonShell.Tooltip"),
                ItemID.TitanGlove => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TitanGlove.Tooltip"),
                ItemID.YoyoBag => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.YoyoBag.Tooltip"),
                ItemID.YoYoGlove => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.YoYoGlove.Tooltip"),
                ItemID.ArcheryPotion => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ArcheryPotion.Tooltip"),
                ItemID.SwiftnessPotion => Language.GetTextValue("ItemTooltip.SwiftnessPotion").Replace("25", "15"),
                ItemID.EndurancePotion => Language.GetTextValue("ItemTooltip.EndurancePotion").Replace("10", "5"),
                ItemID.DD2ElderCrystal => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.DD2ElderCrystal.Tooltip"),
                ItemID.BlackBelt => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BlackBelt.Tooltip"),
                ItemID.BrainOfConfusion => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BrainOfConfusion.Tooltip"),
                ItemID.MagicPowerPotion => Language.GetTextValue("ItemTooltip.MagicPowerPotion").Replace("20", "10"),
                ItemID.MagicHat => Language.GetTextValue("ItemTooltip.MagicHat").Replace("6", "5"),
                ItemID.WormScarf => Language.GetTextValue("ItemTooltip.WormScarf").Replace("17", "10"),
                ItemID.SquirePlating => Language.GetTextValue("ItemTooltip.SquirePlating").Replace("15", "10"),
                ItemID.SquireGreaves => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SquireGreaves.Tooltip"),
                ItemID.MonkBrows => Language.GetTextValue("ItemTooltip.MonkBrows").Replace("20", "10"),
                ItemID.MonkShirt => Language.GetTextValue("ItemTooltip.MonkShirt").Replace("20", "10"),
                ItemID.MonkPants => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MonkPants.Tooltip.0"),
                ItemID.HuntressJerkin => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.HuntressJerkin.Tooltip"),
                ItemID.ApprenticeTrousers => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ApprenticeTrousers.Tooltip"),
                ItemID.SquireAltShirt => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SquireAltShirt.Tooltip"),
                ItemID.SquireAltPants => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SquireAltPants.Tooltip"),
                ItemID.MonkAltHead => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MonkAltHead.Tooltip"),
                ItemID.MonkAltShirt => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MonkAltShirt.Tooltip"),
                ItemID.MonkAltPants => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MonkAltPants.Tooltip"),
                ItemID.HuntressAltShirt => Language.GetTextValue("ItemTooltip.HuntressAltShirt").Replace("25", "15"),
                ItemID.ApprenticeAltPants => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ApprenticeAltPants.Tooltip"),
                ItemID.FleshKnuckles => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FleshKnuckles.Tooltip"),
                ItemID.HeroShield => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.HeroShield.Tooltip"),
                ItemID.BerserkerGlove => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BerserkerGlove.Tooltip.0"),
                ItemID.DD2BetsyBow => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.DD2BetsyBow.Tooltip"),
                ItemID.Abeemination => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.Abeemination.Tooltip"),
                ItemID.BloodySpine => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BloodySpine.Tooltip"),
                ItemID.ClothierVoodooDoll => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ClothierVoodooDoll.Tooltip"),
                ItemID.DeerThing => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.DeerThing.Tooltip"),
                ItemID.GuideVoodooDoll => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GuideVoodooDoll.Tooltip"),
                ItemID.LihzahrdPowerCell => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.LihzahrdPowerCell.Tooltip"),
                ItemID.MechanicalEye => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MechanicalEye.Tooltip"),
                ItemID.NaughtyPresent => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.NaughtyPresent.Tooltip"),
                ItemID.PumpkinMoonMedallion => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.PumpkinMoonMedallion.Tooltip"),
                ItemID.SolarTablet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SolarTablet.Tooltip"),
                ItemID.CelestialSigil => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CelestialSigil.Tooltip"),
                ItemID.MechanicalSkull => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MechanicalSkull.Tooltip"),
                ItemID.MechanicalWorm => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MechanicalWorm.Tooltip"),
                ItemID.QueenSlimeCrystal => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.QueenSlimeCrystal.Tooltip"),
                ItemID.SuspiciousLookingEye => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SuspiciousLookingEye.Tooltip"),
                ItemID.WormFood => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.WormFood.Tooltip"),
                ItemID.DeathSickle => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.DeathSickle.Tooltip"),
                ItemID.CobaltHat => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CobaltHat.Tooltip"),
                ItemID.PalladiumBreastplate => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.PalladiumBreastplate.Tooltip"),
                ItemID.PalladiumLeggings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.PalladiumLeggings.Tooltip"),
                ItemID.MythrilHood => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MythrilHood.Tooltip"),
                ItemID.MythrilChainmail => Language.GetTextValue("ItemTooltip.MythrilChainmail").Replace("7", "12"),
                ItemID.MythrilGreaves => Language.GetTextValue("ItemTooltip.MythrilGreaves").Replace("10", "14"),
                ItemID.OrichalcumBreastplate => Language.GetTextValue("ItemTooltip.OrichalcumBreastplate").Replace("6", "10"),
                ItemID.AdamantiteHeadgear => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.AdamantiteHeadgear.Tooltip"),
                ItemID.ObsidianSkull => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ObsidianSkull.Tooltip"),
                ItemID.ObsidianSkullRose => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ObsidianSkullRose.Tooltip"),
                ItemID.MoltenCharm => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MoltenCharm.Tooltip"),
                ItemID.AnkhShield => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.AnkhShield.Tooltip.0"),
                ItemID.FrozenTurtleShell => Language.GetTextValue("ItemTooltip.FrozenTurtleShell").Replace("25", "15"),
                ItemID.Ale => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.Ale.Tooltip"),
                ItemID.Sake => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.Sake.Tooltip"),
                ItemID.ArmorPolish => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ArmorPolish.Tooltip"),
                ItemID.ArmorBracing => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ArmorBracing.Tooltip"),
                ItemID.ArcaneFlower => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ArcaneFlower.Tooltip"),
                ItemID.MagnetFlower => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MagnetFlower.Tooltip"),
                ItemID.Magiluminescence => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.Magiluminescence.Tooltip.0"),
                ItemID.EmpressFlightBooster => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.EmpressFlightBooster.Tooltip.0"),
                ItemID.MagicQuiver => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MagicQuiver.Tooltip"),
                ItemID.MoltenQuiver => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MoltenQuiver.Tooltip.0"),
                ItemID.FireGauntlet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FireGauntlet.Tooltip.0"),
                ItemID.MagmaStone => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MagmaStone.Tooltip"),
                ItemID.LavaSkull => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.LavaSkull.Tooltip.0"),
                ItemID.MoltenSkullRose => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MoltenSkullRose.Tooltip.0"),
                ItemID.CopperHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CopperHelmet.Tooltip"),
                ItemID.CopperChainmail => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CopperChainmail.Tooltip"),
                ItemID.CopperGreaves => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CopperGreaves.Tooltip"),
                ItemID.TinHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TinHelmet.Tooltip"),
                ItemID.TinChainmail => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TinChainmail.Tooltip"),
                ItemID.TinGreaves => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TinGreaves.Tooltip"),
                ItemID.IronHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.IronHelmet.Tooltip"),
                ItemID.AncientIronHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.AncientIronHelmet.Tooltip"),
                ItemID.IronChainmail => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.IronChainmail.Tooltip"),
                ItemID.IronGreaves => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.IronGreaves.Tooltip"),
                ItemID.LeadHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.LeadHelmet.Tooltip"),
                ItemID.LeadChainmail => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.LeadChainmail.Tooltip"),
                ItemID.LeadGreaves => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.LeadGreaves.Tooltip"),
                ItemID.SilverHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SilverHelmet.Tooltip"),
                ItemID.SilverChainmail => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SilverChainmail.Tooltip"),
                ItemID.SilverGreaves => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SilverGreaves.Tooltip"),
                ItemID.TungstenHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TungstenHelmet.Tooltip"),
                ItemID.TungstenChainmail => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TungstenChainmail.Tooltip"),
                ItemID.TungstenGreaves => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TungstenGreaves.Tooltip"),
                ItemID.GoldHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GoldHelmet.Tooltip"),
                ItemID.AncientGoldHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.AncientGoldHelmet.Tooltip"),
                ItemID.GoldChainmail => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GoldChainmail.Tooltip"),
                ItemID.GoldGreaves => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GoldGreaves.Tooltip"),
                ItemID.PlatinumHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.PlatinumHelmet.Tooltip"),
                ItemID.PlatinumChainmail => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.PlatinumChainmail.Tooltip"),
                ItemID.PlatinumGreaves => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.PlatinumGreaves.Tooltip"),
                ItemID.ShadowHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ShadowHelmet.Tooltip"),
                ItemID.AncientShadowHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.AncientShadowHelmet.Tooltip"),
                ItemID.ShadowScalemail => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ShadowScalemail.Tooltip"),
                ItemID.AncientShadowScalemail => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.AncientShadowScalemail.Tooltip"),
                ItemID.ShadowGreaves => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ShadowGreaves.Tooltip"),
                ItemID.AncientShadowGreaves => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.AncientShadowGreaves.Tooltip"),
                ItemID.CrimsonHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CrimsonHelmet.Tooltip"),
                ItemID.CrimsonScalemail => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CrimsonScalemail.Tooltip"),
                ItemID.CrimsonGreaves => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CrimsonGreaves.Tooltip"),
                ItemID.StarWrath => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.StarWrath.Tooltip"),
                ItemID.NorthPole => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.NorthPole.Tooltip"),
                ItemID.PsychoKnife => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.PsychoKnife.Tooltip"),
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(item, tooltips, "Defense", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.EmptyBucket => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.EmptyBucket.Tooltip"),
                ItemID.GladiatorHelmet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GladiatorHelmet.Tooltip"),
                ItemID.GladiatorBreastplate => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GladiatorBreastplate.Tooltip"),
                ItemID.GladiatorLeggings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GladiatorLeggings.Tooltip"),
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.FireGauntlet => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FireGauntlet.Tooltip.1"),
                ItemID.JellyfishDivingGear => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.JellyfishDivingGear.Tooltip"),
                ItemID.Magiluminescence => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.Magiluminescence.Tooltip.1"),
                ItemID.ArcticDivingGear => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ArcticDivingGear.Tooltip"),
                ItemID.SuspiciousLookingTentacle => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SuspiciousLookingTentacle.Tooltip"),
                ItemID.PowerGlove => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.PowerGlove.Tooltip"),
                ItemID.MechanicalGlove => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MechanicalGlove.Tooltip"),
                ItemID.AnkhShield => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.AnkhShield.Tooltip.1"),
                ItemID.MasterNinjaGear => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MasterNinjaGear.Tooltip"),
                ItemID.BerserkerGlove => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BerserkerGlove.Tooltip.1"),
                ItemID.MonkPants => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MonkPants.Tooltip.1"),
                ItemID.ObsidianHorseshoe => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ObsidianHorseshoe.Tooltip"),
                ItemID.ObsidianShield => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ObsidianShield.Tooltip"),
                ItemID.ObsidianWaterWalkingBoots => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ObsidianWaterWalkingBoots.Tooltip"),
                ItemID.LavaWaders => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.LavaWaders.Tooltip"),
                ItemID.LavaSkull => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.LavaSkull.Tooltip.1"),
                ItemID.MoltenSkullRose => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MoltenSkullRose.Tooltip.1"),
                ItemID.HellfireTreads => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.HellfireTreads.Tooltip.1"),
                ItemID.CelestialStone => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CelestialStone.Tooltip"),
                ItemID.EmpressFlightBooster => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.EmpressFlightBooster.Tooltip.1"),
                ItemID.SniperScope => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SniperScope.Tooltip"),
                ItemID.MoonStone => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MoonStone.Tooltip"),
                ItemID.SunStone => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SunStone.Tooltip"),
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(item, tooltips, "BuffTime", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.ShinePotion => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ShinePotion.Tooltip"),
                ItemID.GillsPotion => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GillsPotion.Tooltip"),
                _ => tooltip.Text
            };
        });

        ItemHelper.TranslateTooltip(item, tooltips, "SetBonus", tooltip =>
        {
            Player player = Main.player[Main.myPlayer];
            if (player.armor[0].type == ItemID.AdamantiteHelmet && player.armor[1].type == ItemID.AdamantiteBreastplate && player.armor[2].type == ItemID.AdamantiteLeggings)
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.AdamantiteMelee");
            }
            if (player.armor[0].type == ItemID.AdamantiteHeadgear && player.armor[1].type == ItemID.AdamantiteBreastplate && player.armor[2].type == ItemID.AdamantiteLeggings)
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.AdamantiteCaster");
            }
            if (player.armor[0].type == ItemID.AdamantiteMask && player.armor[1].type == ItemID.AdamantiteBreastplate && player.armor[2].type == ItemID.AdamantiteLeggings)
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.AdamantiteRanged");
            }
            if (player.armor[0].type == ItemID.CobaltHelmet && player.armor[1].type == ItemID.CobaltBreastplate && player.armor[2].type == ItemID.CobaltLeggings)
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.CobaltMelee");
            }
            if (player.armor[0].type == ItemID.CobaltHat && player.armor[1].type == ItemID.CobaltBreastplate && player.armor[2].type == ItemID.CobaltLeggings)
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.CobaltCaster");
            }
            if (player.armor[0].type == ItemID.CobaltMask && player.armor[1].type == ItemID.CobaltBreastplate && player.armor[2].type == ItemID.CobaltLeggings)
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.CobaltRanged");
            }
            if (player.armor[0].type == ItemID.MythrilHelmet && player.armor[1].type == ItemID.MythrilChainmail && player.armor[2].type == ItemID.MythrilGreaves)
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.MythrilMelee");
            }
            if (player.armor[0].type == ItemID.MythrilHood && player.armor[1].type == ItemID.MythrilChainmail && player.armor[2].type == ItemID.MythrilGreaves)
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.MythrilCaster");
            }
            if (player.armor[0].type == ItemID.MythrilHat && player.armor[1].type == ItemID.MythrilChainmail && player.armor[2].type == ItemID.MythrilGreaves)
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.MythrilRanged");
            }
            if (player.armor[0].type == ItemID.ShadowHelmet || player.armor[0].type == ItemID.AncientShadowHelmet &&
                player.armor[1].type == ItemID.ShadowScalemail || player.armor[1].type == ItemID.AncientShadowScalemail &&
                player.armor[2].type == ItemID.ShadowGreaves || player.armor[2].type == ItemID.AncientShadowGreaves)
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Shadow");
            }
            if (player.armor[0].type == ItemID.EskimoHood || player.armor[0].type == ItemID.PinkEskimoHood &&
                player.armor[1].type == ItemID.EskimoCoat || player.armor[1].type == ItemID.PinkEskimoCoat &&
                player.armor[2].type == ItemID.EskimoPants || player.armor[2].type == ItemID.PinkEskimoPants)
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Eskimo");
            }
            if (player.armor[0].type == ItemID.ChlorophyteHeadgear || player.armor[0].type == ItemID.ChlorophyteMask || player.armor[0].type == ItemID.ChlorophyteHelmet && player.armor[1].type == ItemID.ChlorophytePlateMail && player.armor[2].type == ItemID.ChlorophyteGreaves)
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Chlorophyte");
            }
            if (player.armor[0].type == ItemID.SpectreHood && player.armor[1].type == ItemID.SpectreRobe && player.armor[2].type == ItemID.SpectrePants)
            {
                tooltip.Text = $"{Language.GetText("LegacyTooltip.48").Value} {Language.GetText("ArmorSetBonus.SpectreHealing").Value.Replace("40%", "20%")}";
            }
            if (player.armor[0].type == ItemID.MiningHelmet || player.armor[0].type == ItemID.UltrabrightHelmet && player.armor[1].type == ItemID.MiningShirt && player.armor[2].type == ItemID.MiningPants)
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Mining");
            }

            switch (item.type)
            {
                case ItemID.MeteorHelmet:
                case ItemID.MeteorSuit:
                case ItemID.MeteorLeggings:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Meteor");
                    break;
                
                case ItemID.CopperGreaves:
                case ItemID.CopperChainmail:
                case ItemID.CopperHelmet:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Copper");
                    break;
                
                case ItemID.TinHelmet:
                case ItemID.TinChainmail:
                case ItemID.TinGreaves:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Tin");
                    break;
                
                case ItemID.IronGreaves:
                case ItemID.IronChainmail:
                case ItemID.IronHelmet:
                case ItemID.AncientIronHelmet:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Iron");
                    break;
                
                case ItemID.LeadHelmet:
                case ItemID.LeadChainmail:
                case ItemID.LeadGreaves:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Lead");
                    break;
                
                case ItemID.SilverGreaves:
                case ItemID.SilverChainmail:
                case ItemID.SilverHelmet:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Silver");
                    break;

                case ItemID.TungstenHelmet:
                case ItemID.TungstenChainmail:
                case ItemID.TungstenGreaves:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Tungsten", tooltip.Text.Split(' ')[42], tooltip.Text.Split(' ')[47]);
                    break;

                case ItemID.GoldGreaves:
                case ItemID.GoldChainmail:
                case ItemID.GoldHelmet:
                case ItemID.AncientGoldHelmet:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Gold");
                    break;
                
                case ItemID.PlatinumHelmet:
                case ItemID.PlatinumChainmail:
                case ItemID.PlatinumGreaves:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Platinum");
                    break;
                
                case ItemID.MoltenHelmet:
                case ItemID.MoltenBreastplate:
                case ItemID.MoltenGreaves:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Molten");
                    break;
                
                case ItemID.MonkBrows:
                case ItemID.MonkShirt:
                case ItemID.MonkPants:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.MonkTier2");
                    break;
                
                case ItemID.SquireGreatHelm:
                case ItemID.SquirePlating:
                case ItemID.SquireGreaves:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.SquireTier2");
                    break;
                
                case ItemID.HuntressWig:
                case ItemID.HuntressJerkin:
                case ItemID.HuntressPants:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.HuntressTier2");
                    break;
                
                case ItemID.ApprenticeHat:
                case ItemID.ApprenticeRobe:
                case ItemID.ApprenticeTrousers:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.ApprenticeTier2");
                    break;
                
                case ItemID.MonkAltHead:
                case ItemID.MonkAltShirt:
                case ItemID.MonkAltPants:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.MonkTier3");
                    break;
                
                case ItemID.SquireAltHead:
                case ItemID.SquireAltShirt:
                case ItemID.SquireAltPants:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.SquireTier3");
                    break;
                
                case ItemID.HuntressAltHead:
                case ItemID.HuntressAltShirt:
                case ItemID.HuntressAltPants:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.HuntressTier3");
                    break;
                
                case ItemID.ApprenticeAltHead:
                case ItemID.ApprenticeAltShirt:
                case ItemID.ApprenticeAltPants:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.ApprenticeTier3");
                    break;
                    
                case ItemID.GladiatorHelmet:
                case ItemID.GladiatorBreastplate:
                case ItemID.GladiatorLeggings:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Gladiator");
                    break;
                
                case ItemID.ObsidianHelm:
                case ItemID.ObsidianShirt:
                case ItemID.ObsidianPants:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Obsidian");
                    break;
                
                case ItemID.CrystalNinjaHelmet:
                case ItemID.CrystalNinjaChestplate:
                case ItemID.CrystalNinjaLeggings:
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.CrystalNinja");
                    break;
            }
        });

        ItemHelper.TranslateTooltip(item, tooltips, "NeedsBait", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.GoldenFishingRod => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GoldenFishingRod.Tooltip"),
                _ => tooltip.Text
            };
        });

        ItemHelper.TranslateTooltip(item, tooltips, "HealLife", tooltip =>
        {
            tooltip.Text = tooltip.Text
                .Replace("Restores", "Восстанавливает")
                .Replace("life", "ед. здоровья");
            
            tooltip.Text = item.type switch
            {
                ItemID.BottledHoney => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BottledHoney.Tooltip"),
                _ => tooltip.Text
            };
        });

        ItemHelper.TranslateTooltip(item, tooltips, "Consumable", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.TruffleWorm => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TruffleWorm.Tooltip"),
                _ => tooltip.Text
            };
        });

        ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.CelestialShell => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CelestialShell.Tooltip"),
                ItemID.FairyBoots => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FairyBoots.Tooltip"),
                ItemID.MoltenQuiver => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MoltenQuiver.Tooltip.2"),
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.HellfireTreads => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.HellfireTreads.Tooltip.3"),
                ItemID.TerrasparkBoots => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TerrasparkBoots.Tooltip"),
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(item, tooltips, "UseMana", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.SpaceGun => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SpaceGun.Tooltip", (int)(item.mana * Main.LocalPlayer.manaCost * 0.5f)),
                _ => tooltip.Text
            };
        });
    }
}