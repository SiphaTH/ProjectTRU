using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications
{
    public class VanillaItemsTranslation : CalamityGlobalItemBase
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.CobaltSword)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Decreases enemy defense by 25% on hit",
                        LangHelper.GetTextValue("Calamity.VanillaItem.CobaltSword"));
                }
            }
            else if (item.type == ItemID.CobaltNaginata)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Decreases enemy defense by 25% on hit",
                        LangHelper.GetTextValue("Calamity.VanillaItem.CobaltNaginata"));
                }
            }
            else if (item.type == ItemID.PalladiumSword)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Increases life regen on hit",
                        LangHelper.GetTextValue("Calamity.VanillaItem.PalladiumSword"));
                }
            }
            else if (item.type == ItemID.PalladiumPike)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Increases life regen on hit",
                        LangHelper.GetTextValue("Calamity.VanillaItem.PalladiumPike"));
                }
            }
            else if (item.type == ItemID.MythrilSword)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Decreases enemy contact damage by 10% on hit",
                        LangHelper.GetTextValue("Calamity.VanillaItem.MythrilSword"));
                }
            }
            else if (item.type == ItemID.MythrilHalberd)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Decreases enemy contact damage by 10% on hit",
                        LangHelper.GetTextValue("Calamity.VanillaItem.MythrilHalberd"));
                }
            }
            else if (item.type == ItemID.OrichalcumSword)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Increases how frequently the Orichalcum set bonus triggers on hit",
                            LangHelper.GetTextValue("Calamity.VanillaItem.OrichalcumSword"));
                }
            }
            else if (item.type == ItemID.OrichalcumHalberd)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Increases how frequently the Orichalcum set bonus triggers on hit", LangHelper.GetTextValue("Calamity.VanillaItem.OrichalcumHalberd"));
                }
            }
            else if (item.type == ItemID.AdamantiteSword)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Slows enemies on hit",
                        LangHelper.GetTextValue("Calamity.VanillaItem.AdamantiteSword"));
                }
            }
            else if (item.type == ItemID.AdamantiteGlaive)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Slows enemies on hit",
                        LangHelper.GetTextValue("Calamity.VanillaItem.AdamantiteGlaive"));
                }
            }
            else if (item.type == ItemID.TitaniumSword)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Deals increased damage to enemies with high knockback resistance",
                            LangHelper.GetTextValue("Calamity.VanillaItem.TitaniumSword"));
                }
            }
            else if (item.type == ItemID.TitaniumTrident)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Deals increased damage to enemies with high knockback resistance",
                            LangHelper.GetTextValue("Calamity.VanillaItem.TitaniumTrident"));
                }
            }
            else if (item.type == ItemID.Excalibur)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Inflicts Holy Flames\nDeals double damage to enemies above 75% life",
                            LangHelper.GetTextValue("Calamity.VanillaItem.Excalibur"));
                }
            }
            else if (item.type == ItemID.Gungnir)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Inflicts Holy Flames\nDeals double damage to enemies above 75% life",
                            LangHelper.GetTextValue("Calamity.VanillaItem.Gungnir"));
                }
            }
            else if (item.type == ItemID.TrueExcalibur)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Inflicts Holy Flames\nDeals double damage to enemies above 75% life",
                            LangHelper.GetTextValue("Calamity.VanillaItem.TrueExcalibur"));
                }
            }
            else if (item.type == ItemID.CandyCaneSword)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Heals you on hit",
                        LangHelper.GetTextValue("Calamity.VanillaItem.CandyCaneSword"));
                }
            }
            else if (item.type == ItemID.FruitcakeChakram)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Heals you on hit",
                        LangHelper.GetTextValue("Calamity.VanillaItem.FruitcakeChakram"));
                }
            }
            else if (item.type == ItemID.StylistKilLaKillScissorsIWish ||
                     (item.type >= ItemID.BluePhaseblade && item.type <= ItemID.YellowPhaseblade) ||
                     (item.type >= ItemID.BluePhasesaber && item.type <= ItemID.YellowPhasesaber))
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Ignores 100% of enemy defense",
                        LangHelper.GetTextValue("Calamity.VanillaItem.FullIgnoreDefense"));
                }
            }
            else if (item.type == ItemID.AntlionClaw ||
                     item.type == ItemID.BoneSword ||
                     item.type == ItemID.BreakerBlade)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Ignores 50% of enemy defense",
                        LangHelper.GetTextValue("Calamity.VanillaItem.HalfIgnoreDefense"));
                }
            }
            else if (item.type == ItemID.LightsBane || item.type == ItemID.NightsEdge ||
                     item.type == ItemID.TrueNightsEdge || item.type == ItemID.BallOHurt ||
                     item.type == ItemID.CorruptYoyo)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Inflicts Shadowflame on hit",
                        LangHelper.GetTextValue("Calamity.VanillaItem.ShadowflameDebuff"));
                }
            }
            else if (item.type == ItemID.BloodButcherer || item.type == ItemID.TheRottedFork ||
                     item.type == ItemID.TheMeatball || item.type == ItemID.CrimsonYoyo ||
                     item.type == ItemID.CrimsonRod)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Inflicts Burning Blood on hit",
                        LangHelper.GetTextValue("Calamity.VanillaItem.BurningBloodDebuff"));
                }
            }
            else if (item.type == ItemID.SlimeCrown || item.type == ItemID.GoblinBattleStandard ||
                     item.type == ItemID.PirateMap || item.type == ItemID.SnowGlobe ||
                     item.type == ItemID.NaughtyPresent || item.type == ItemID.PumpkinMoonMedallion ||
                     item.type == ItemID.SolarTablet || item.type == ItemID.CelestialSigil)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    tooltip.text = tooltip.text.Replace("Not consumable",
                        LangHelper.GetTextValue("Calamity.VanillaItem.NotConsumable"));
                }
            }

            if (item.prefix > 0)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "PrefixSSDmg", tooltip =>
                {
                    tooltip.text = tooltip.text.Replace("stealth strike damage",
                        LangHelper.GetTextValue("Calamity.VanillaItem.PrefixSSDmg"));
                });
                ItemHelper.TranslateTooltip(item, tooltips, "PrefixStealthGenBoost", tooltip =>
                {
                    tooltip.text = tooltip.text.Replace("stealth generation",
                        LangHelper.GetTextValue("Calamity.VanillaItem.PrefixStealthGenBoost"));
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
                            tooltip.text = tooltip.text.Replace("damage reduction",
                                LangHelper.GetTextValue("Calamity.VanillaItem.PrefixAccDefense"));
                        });
                        break;
                }
            }

            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                switch (item.type)
                {
                    case ItemID.WarmthPotion:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.WarmthPotion");
                        break;

                    case ItemID.HandWarmer:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.HandWarmer");
                        break;

                    case ItemID.Picksaw:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.Picksaw");
                        break;

                    case ItemID.FlaskofVenom:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.FlaskofVenom");
                        break;

                    case ItemID.FlaskofCursedFlames:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.FlaskofCursedFlames");
                        break;

                    case ItemID.FlaskofFire:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.FlaskofFire");
                        break;

                    case ItemID.FlaskofGold:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.FlaskofGold");
                        break;

                    case ItemID.FlaskofIchor:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.FlaskofIchor");
                        break;

                    case ItemID.FlaskofNanites:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.FlaskofNanites");
                        break;

                    case ItemID.FlaskofParty:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.FlaskofParty");
                        break;

                    case ItemID.FlaskofPoison:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.FlaskofPoison");
                        break;

                    case ItemID.MiningHelmet:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.MiningHelmet");
                        break;

                    case ItemID.RodofDiscord:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.RodofDiscord");
                        break;

                    case ItemID.SuperAbsorbantSponge:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SuperAbsorbantSponge");
                        break;

                    case ItemID.CrimsonHeart:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.CrimsonHeart");
                        break;

                    case ItemID.ShadowOrb:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.ShadowOrb");
                        break;

                    case ItemID.MagicLantern:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.MagicLantern");
                        break;

                    case ItemID.JellyfishNecklace:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.JellyfishNecklace");
                        break;

                    case ItemID.FairyBell:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.FairyBell");
                        break;

                    case ItemID.DD2PetGhost:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.DD2PetGhost");
                        break;

                    case ItemID.WispinaBottle:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.WispinaBottle");
                        break;

                    case ItemID.DivingHelmet:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.DivingHelmet");
                        break;

                    case ItemID.NeptunesShell:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.NeptunesShell");
                        break;

                    case ItemID.MoonShell:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.MoonShell");
                        break;

                    case ItemID.TitanGlove:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.TitanGlove");
                        break;

                    case ItemID.YoyoBag:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.YoyoBag");
                        break;

                    case ItemID.YoYoGlove:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.YoYoGlove");
                        break;

                    case ItemID.MagicQuiver:
                        tooltip.text = tooltip.text.Replace("урон", "урон стрел");
                        break;

                    case ItemID.InvisibilityPotion:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.InvisibilityPotion");
                        break;

                    case ItemID.MagicMirror:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.MagicMirror");
                        break;

                    case ItemID.IceMirror:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.IceMirror");
                        break;

                    case ItemID.RecallPotion:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.RecallPotion");
                        break;

                    case ItemID.Pwnhammer:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.Pwnhammer");
                        break;

                    case ItemID.Hammush:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.Hammush");
                        break;

                    case ItemID.ArcheryPotion:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.ArcheryPotion");
                        break;

                    case ItemID.SwiftnessPotion:
                        tooltip.text = Language.GetTextValue("ItemTooltip.SwiftnessPotion").Replace("25", "15");
                        break;

                    case ItemID.EndurancePotion:
                        tooltip.text = Language.GetTextValue("ItemTooltip.EndurancePotion").Replace("10", "5");
                        break;

                    case ItemID.DD2ElderCrystal:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.DD2ElderCrystal");
                        break;

                    case ItemID.BlackBelt:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.BlackBelt");
                        break;

                    case ItemID.MagicPowerPotion:
                        tooltip.text = Language.GetTextValue("ItemTooltip.MagicPowerPotion").Replace("20", "10");
                        break;

                    case ItemID.MagicHat:
                        tooltip.text = Language.GetTextValue("ItemTooltip.MagicHat").Replace("7", "5");
                        break;

                    case ItemID.WizardHat:
                        tooltip.text = Language.GetTextValue("ItemTooltip.WizardHat").Replace("15", "5");
                        break;

                    case ItemID.SquirePlating:
                        tooltip.text = Language.GetTextValue("ItemTooltip.SquirePlating").Replace("15", "10");
                        break;

                    case ItemID.SquireGreaves:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SquireGreaves");
                        break;

                    case ItemID.MonkBrows:
                        tooltip.text = Language.GetTextValue("ItemTooltip.MonkBrows").Replace("20", "10");
                        break;

                    case ItemID.MonkShirt:
                        tooltip.text = Language.GetTextValue("ItemTooltip.MonkShirt").Replace("20", "10");
                        break;

                    case ItemID.MonkPants:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.MonkPants.1");
                        break;

                    case ItemID.HuntressJerkin:
                        tooltip.text = Language.GetTextValue("ItemTooltip.HuntressJerkin").Replace("20", "10") +
                                       LangHelper.GetTextValue("Calamity.VanillaItem.HuntressJerkin");
                        break;

                    case ItemID.ApprenticeTrousers:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.ApprenticeTrousers");
                        break;

                    case ItemID.SquireAltShirt:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SquireAltShirt");
                        break;

                    case ItemID.SquireAltPants:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SquireAltPants");
                        break;

                    case ItemID.MonkAltHead:
                        tooltip.text = Language.GetTextValue("ItemTooltip.MonkAltHead").Replace("20", "10");
                        break;

                    case ItemID.MonkAltShirt:
                        tooltip.text = Language.GetTextValue("ItemTooltip.MonkAltShirt").Replace("20", "10") +
                                       LangHelper.GetTextValue("Calamity.VanillaItem.MonkAltShirt");
                        break;

                    case ItemID.MonkAltPants:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.MonkAltPants");
                        break;

                    case ItemID.HuntressAltShirt:
                        tooltip.text = Language.GetTextValue("ItemTooltip.HuntressAltShirt").Replace("25", "15") +
                                       LangHelper.GetTextValue("Calamity.VanillaItem.HuntressAltShirt");
                        break;

                    case ItemID.ApprenticeAltPants:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.ApprenticeAltPants");
                        break;
                    
                    case ItemID.FleshKnuckles:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.FleshKnuckles");
                        break;
                    
                    case ItemID.DD2BetsyBow:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.DD2BetsyBow");
                        break;
                    
                    case ItemID.Abeemination:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.Abeemination");
                        break;
                    
                    case ItemID.BloodySpine:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.BloodySpine");
                        break;
                    
                    case ItemID.ClothierVoodooDoll:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.ClothierVoodooDoll");
                        break;
                    
                    case ItemID.GuideVoodooDoll:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.GuideVoodooDoll");
                        break;
                    
                    case ItemID.LihzahrdPowerCell:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.LihzahrdPowerCell");
                        break;
                    
                    case ItemID.MechanicalEye:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.MechanicalEye");
                        break;
                    
                    case ItemID.MechanicalSkull:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.MechanicalSkull");
                        break;
                    
                    case ItemID.MechanicalWorm:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.MechanicalWorm");
                        break;
                    
                    case ItemID.SuspiciousLookingEye:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SuspiciousLookingEye");
                        break;
                    
                    case ItemID.WormFood:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.WormFood");
                        break;
                    
                    case ItemID.DeathSickle:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.DeathSickle");
                        break;
                    
                    case ItemID.CobaltHat:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.CobaltHat");
                        break;
                    
                    case ItemID.PalladiumBreastplate:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.PalladiumBreastplate");
                        break;
                    
                    case ItemID.PalladiumLeggings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.PalladiumLeggings");
                        break;
                    
                    case ItemID.MythrilHood:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.MythrilHood");
                        break;
                    
                    case ItemID.MythrilChainmail:
                        tooltip.text = Language.GetTextValue("ItemTooltip.MythrilChainmail").Replace("5", "12");
                        break;
                    
                    case ItemID.MythrilGreaves:
                        tooltip.text = Language.GetTextValue("ItemTooltip.MythrilGreaves").Replace("3", "14");
                        break;
                    
                    case ItemID.OrichalcumBreastplate:
                        tooltip.text = Language.GetTextValue("ItemTooltip.OrichalcumBreastplate").Replace("6", "10");
                        break;
                    
                    case ItemID.AdamantiteHeadgear:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.AdamantiteHeadgear");
                        break;
                    
                    case ItemID.ObsidianSkull:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.ObsidianSkull");
                        break;
                    
                    case ItemID.AnkhShield:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.AnkhShield.Tooltip0");
                        break;
                }
            });

            ItemHelper.TranslateTooltip(item, tooltips, "Defense", tooltip =>
            {
                switch (item.type)
                {
                    case ItemID.EmptyBucket:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.EmptyBucket");
                        break;
                    
                    case ItemID.GladiatorHelmet:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.GladiatorHelmet");
                        break;
                    
                    case ItemID.GladiatorBreastplate:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.GladiatorBreastplate");
                        break;
                    
                    case ItemID.GladiatorLeggings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.GladiatorLeggings");
                        break;
                    
                    case ItemID.ObsidianHelm:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.ObsidianHelm");
                        break;
                    
                    case ItemID.ObsidianShirt:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.ObsidianShirt");
                        break;
                    
                    case ItemID.ObsidianPants:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.ObsidianPants");
                        break;
                }
            });

            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
            {
                switch (item.type)
                {
                    case ItemID.FireGauntlet:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.FireGauntlet");
                        break;

                    case ItemID.JellyfishDivingGear:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.JellyfishDivingGear");
                        break;

                    case ItemID.ArcticDivingGear:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.ArcticDivingGear");
                        break;

                    case ItemID.SuspiciousLookingTentacle:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SuspiciousLookingTentacle");
                        break;

                    case ItemID.CelestialShell:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.CelestialShell");
                        break;

                    case ItemID.PowerGlove:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.PowerGlove");
                        break;

                    case ItemID.MechanicalGlove:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.MechanicalGlove");
                        break;

                    case ItemID.CellPhone:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.CellPhone");
                        break;

                    case ItemID.AnkhShield:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.AnkhShield.Tooltip1");
                        break;

                    case ItemID.MasterNinjaGear:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.MasterNinjaGear");
                        break;

                    case ItemID.MonkPants:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.MonkPants.2");
                        break;
                    
                    case ItemID.ObsidianHorseshoe:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.ObsidianHorseshoe");
                        break;
                    
                    case ItemID.ObsidianShield:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.ObsidianShield");
                        break;
                    
                    case ItemID.ObsidianWaterWalkingBoots:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.ObsidianWaterWalkingBoots");
                        break;
                    
                    case ItemID.LavaWaders:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.LavaWaders");
                        break;
                }
            });

            ItemHelper.TranslateTooltip(item, tooltips, "BuffTime", tooltip =>
            {
                switch (item.type)
                {
                    case ItemID.ShinePotion:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.ShinePotion");
                        break;

                    case ItemID.GillsPotion:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.GillsPotion");
                        break;
                }
            });

            ItemHelper.TranslateTooltip(item, tooltips, "SetBonus", tooltip =>
            {
                switch (item.type)
                {
                    case ItemID.MeteorHelmet:
                    case ItemID.MeteorSuit:
                    case ItemID.MeteorLeggings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.Meteor");
                        break;

                    case ItemID.CopperGreaves:
                    case ItemID.CopperChainmail:
                    case ItemID.CopperHelmet:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.Copper");
                        break;

                    case ItemID.TinHelmet:
                    case ItemID.TinChainmail:
                    case ItemID.TinGreaves:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.Tin");
                        break;

                    case ItemID.IronGreaves:
                    case ItemID.IronChainmail:
                    case ItemID.IronHelmet:
                    case ItemID.AncientIronHelmet:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.Iron");
                        break;

                    case ItemID.LeadHelmet:
                    case ItemID.LeadChainmail:
                    case ItemID.LeadGreaves:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.Lead");
                        break;

                    case ItemID.SilverGreaves:
                    case ItemID.SilverChainmail:
                    case ItemID.SilverHelmet:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.Silver");
                        break;

                    case ItemID.TungstenHelmet:
                    case ItemID.TungstenChainmail:
                    case ItemID.TungstenGreaves:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.Tungsten");
                        break;

                    case ItemID.GoldGreaves:
                    case ItemID.GoldChainmail:
                    case ItemID.GoldHelmet:
                    case ItemID.AncientGoldHelmet:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.Gold");
                        break;

                    case ItemID.PlatinumHelmet:
                    case ItemID.PlatinumChainmail:
                    case ItemID.PlatinumGreaves:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.Platinum");
                        break;

                    case ItemID.MoltenHelmet:
                    case ItemID.MoltenBreastplate:
                    case ItemID.MoltenGreaves:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.Molten");
                        break;

                    case ItemID.MonkBrows:
                    case ItemID.MonkShirt:
                    case ItemID.MonkPants:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.MonkTier2");
                        break;

                    case ItemID.SquireGreatHelm:
                    case ItemID.SquirePlating:
                    case ItemID.SquireGreaves:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.SquireTier2");
                        break;

                    case ItemID.HuntressWig:
                    case ItemID.HuntressJerkin:
                    case ItemID.HuntressPants:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.HuntressTier2");
                        break;

                    case ItemID.ApprenticeHat:
                    case ItemID.ApprenticeRobe:
                    case ItemID.ApprenticeTrousers:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.ApprenticeTier2");
                        break;

                    case ItemID.MonkAltHead:
                    case ItemID.MonkAltShirt:
                    case ItemID.MonkAltPants:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.MonkTier3");
                        break;

                    case ItemID.SquireAltHead:
                    case ItemID.SquireAltShirt:
                    case ItemID.SquireAltPants:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.SquireTier3");
                        break;

                    case ItemID.HuntressAltHead:
                    case ItemID.HuntressAltShirt:
                    case ItemID.HuntressAltPants:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.HuntressTier3");
                        break;

                    case ItemID.ApprenticeAltHead:
                    case ItemID.ApprenticeAltShirt:
                    case ItemID.ApprenticeAltPants:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.ApprenticeTier3");
                        break;
                    
                    case ItemID.GladiatorHelmet:
                    case ItemID.GladiatorBreastplate:
                    case ItemID.GladiatorLeggings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.Gladiator") +
                                       (TRuConfig.Instance.CalamityStealthDescription ? LangHelper.GetTextValue("Calamity.SetBonus.RogueStealthDescription") : "");
                        break;
                    
                    case ItemID.ObsidianHelm:
                    case ItemID.ObsidianShirt:
                    case ItemID.ObsidianPants:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.SetBonus.Obsidian") +
                                       (TRuConfig.Instance.CalamityStealthDescription ? LangHelper.GetTextValue("Calamity.SetBonus.RogueStealthDescription") : "");
                        break;
                }
            });

            ItemHelper.TranslateTooltip(item, tooltips, "NeedsBait", tooltip =>
            {
                switch (item.type)
                {
                    case ItemID.GoldenFishingRod:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.GoldenFishingRod");
                        break;
                }
            });

            ItemHelper.TranslateTooltip(item, tooltips, "Material", tooltip =>
            {
                switch (item.type)
                {
                    case ItemID.VortexPickaxe:
                    case ItemID.NebulaPickaxe:
                    case ItemID.SolarFlarePickaxe:
                    case ItemID.StardustPickaxe:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.PicaxeMix");
                        break;
                }
            });

            ItemHelper.TranslateTooltip(item, tooltips, "HealLife", tooltip =>
            {
                switch (item.type)
                {
                    case ItemID.BottledHoney:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.BottledHoney");
                        break;
                }
            });
            
            ItemHelper.TranslateTooltip(item, tooltips, "Placeable", tooltip =>
            {
                switch (item.type)
                {
                    case ItemID.Teleporter:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.Teleporter");
                        break;
                }
            });
            
            ItemHelper.TranslateTooltip(item, tooltips, "Consumable", tooltip =>
            {
                switch (item.type)
                {
                    case ItemID.TruffleWorm:
                        tooltip.text = LangHelper.GetTextValue("Calamity.VanillaItem.TruffleWorm");
                        break;
                }
            });
        }
    }
}