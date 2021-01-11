using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using CalamityMod;
using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.Items
{
    public class FuckingItems : GlobalItem
    {
        public override void ModifyTooltips(Item item, List < TooltipLine > tooltips)
        {
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && 
                CalamityRuTranslate.Config.CalamityTranslation)
            {
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AsgardianAegis"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip5");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.AsgardianAegis.Tooltip5"),
                            CoreCalamityTranslation.AegisHotKey);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AstralArcanum"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip6");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.AstralArcanum.Tooltip6"),
                            CoreCalamityTranslation.AstralArcanumUiHotkey);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("CelestialJewel"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip2");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.CelestialJewel.Tooltip2"),
                            CoreCalamityTranslation.AstralArcanumUiHotkey);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("ElysianAegis"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip5");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.ElysianAegis.Tooltip5"),
                            CoreCalamityTranslation.AegisHotKey);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("MomentumCapacitor"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.MomentumCapacitor.Tooltip0"),
                                CoreCalamityTranslation.MomentumCapacitatorHotkey);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("Nanotech"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip7");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.RaidersTalismanOrNanotech"),
                            tooltipLine.text.Split(' ')[3]);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("RaidersTalisman"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip3");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.RaidersTalismanOrNanotech"),
                            tooltipLine.text.Split(' ')[3]);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("ProfanedSoulCrystal"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = Translation.KeyText("Calamity.ItemTooltip.ProfanedSoulCrystal.Tooltip1");
                    }

                    if (Main.player[Main.myPlayer].Calamity().profanedCrystalBuffs)
                    {
                        TooltipLine tooltipLine5 = tooltips.FirstOrDefault(x => x.Name == "Tooltip5");
                        if (tooltipLine5 != null)
                        {
                            tooltipLine5.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.ProfanedSoulCrystal.Tooltip5"),
                                    tooltipLine5.text.Split(' ')[9]);
                        }
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("SandCloak"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.SandCloak.Tooltip1"),
                            CoreCalamityTranslation.SandCloakHotkey);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("SpectralVeil"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.SpectralVeil.Tooltip1"),
                            CoreCalamityTranslation.SpectralVeilHotKey);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("NormalityRelocator"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.NormalityRelocator.Tooltip1"),
                            CoreCalamityTranslation.NormalityRelocatorHotKey);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("Eternity"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.Eternity.Tooltip1"),
                            CoreCalamityTranslation.EternityDiscoHex);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("PlaguedFuelPack"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip2");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.PlaguedFuelPack.Tooltip2"),
                            CoreCalamityTranslation.PlaguePackHotKey);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("Revenge"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        switch (tooltipLine.Name)
                        {
                            case "Tooltip1":
                                tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.Revenge.Tooltip1"),
                                    CoreCalamityTranslation.RageHotKey);
                                break;
                            case "Tooltip3":
                                tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.Revenge.Tooltip3"), 
                                    CoreCalamityTranslation.AdrenalineHotKey);
                                break;
                        }
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("CosmicWorm"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltipLine != null && CoreCalamityTranslation.DownedFlag)
                    {
                        tooltipLine.text = Translation.KeyText("Calamity.ItemTooltip.CosmicWorm.Tooltip1");
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("BlunderBooster"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip2");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.BlunderBooster.Tooltip2"),
                            CoreCalamityTranslation.PlaguePackHotKey);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("GrandGelatin"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.GrandGelatin.Tooltip1"),
                            Main.player[Main.myPlayer].autoJump ? 10 : 40);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("VitalJelly"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.VitalJelly.Tooltip1"),
                            Main.player[Main.myPlayer].autoJump ? 6 : 24);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("KnowledgeKingSlime"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip2");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = Main.player[Main.myPlayer].autoJump
                            ? Translation.KeyText("Calamity.ItemTooltip.KnowledgeKingSlime.Tooltip2.AutoJump")
                            : Translation.KeyText("Calamity.ItemTooltip.KnowledgeKingSlime.Tooltip2");
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AbandonedSlimeStaff"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip4");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.AbandonedSlimeStaff.Tooltip4"),
                                Main.player[Main.myPlayer].autoJump ? 5 : 20);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AeroStone"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.AeroStone.Tooltip1"),
                            Main.player[Main.myPlayer].autoJump ? 5 : 20);
                    }
                }
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("SunkenStew"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.SunkenStew.Tooltip0"),
                            Main.player[Main.myPlayer].pStone ? 37 : 50);
                    }
                }
		            
                if (ModLoader.GetMod("Fargowiltas") != null)
                {
                    if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("SunkenSeaFountain"))
                    {
                        TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                        if (tooltipLine != null)
                        {
                            tooltipLine.text = Translation.KeyText("Calamity.ModifyItemTooltip.SunkenSeaFountain");
                        }
                    }
                    else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("SulphurousFountainItem"))
                    {
                        TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                        if (tooltipLine != null)
                        {
                            tooltipLine.text = Translation.KeyText("Calamity.ModifyItemTooltip.SulphurousFountainItem");
                        }
                    }
                    else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AstralFountainItem"))
                    {
                        TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                        if (tooltipLine != null)
                        {
                            tooltipLine.text = Translation.KeyText("Calamity.ModifyItemTooltip.AstralFountainItem");
                        }
                    }
                }
            }
        }
    }
    
    public class DeathModeItems : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && 
                CalamityRuTranslate.Config.CalamityTranslation)
            {
                foreach (var translation in CalamityTranslationDictionaries.CalamityDeathModeItems)
                {
                    if (item.type == CoreCalamityTranslation.CalamityMod.ItemType(translation.Key))
                    {
                        TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == translation.Value.TooltipLineNumber);
                        if (tooltipLine != null)
                        {
                            tooltipLine.text = Translation.KeyText(translation.Value.NormalTextKey) +
                                               (CoreCalamityTranslation.DeathMode
                                                   ? Translation.KeyText(translation.Value.DeathModeTextKey)
                                                   : "");
                        }
                        
                        return;
                    }
                }
                
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("PurifiedJam"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltipLine != null)
                    {
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.PurifiedJam.Tooltip0"),
                            CoreCalamityTranslation.DeathMode ? 5 : 10);
                    }
                }
            }
        }
    }
    
    public class VanillaItems : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && 
                CalamityRuTranslate.Config.CalamityTranslation)
            {
                if (item.type == ItemID.LavaWaders)
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltipLine != null && CoreCalamityTranslation.DeathMode)
                    {
                        tooltipLine.text = Translation.KeyText2("Calamity.VanillaItem.LavaWaders");
                    }
                }

                foreach (TooltipLine tooltipLine in tooltips)
                {
                    if (tooltipLine.Name == "Tooltip0")
                    {
                        tooltipLine.text = tooltipLine.text.Replace("Current Charge",
                            Translation.KeyText("Calamity.VanillaItem.CalamityTip.CurrentCharge"));
                    }
                }
					
                if (item.prefix > 0)
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "PrefixSSDmg")
                        {
                            tooltipLine.text = tooltipLine.text.Replace("stealth strike damage",
                                Translation.KeyText("Calamity.VanillaItem.PrefixSSDmg"));
                        }
						
                        if (tooltipLine.Name == "PrefixStealthGenBoost")
                        {
                            tooltipLine.text = tooltipLine.text.Replace("stealth generation",
                                Translation.KeyText("Calamity.VanillaItem.PrefixStealthGenBoost"));
                        }
                    }
                }

                if (item.accessory)
                {
                    switch (item.prefix)
                    {
                        case 67:
                        case 68:
                            TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "PrefixAccCritChance");
                            if(tooltipLine != null)
                                tooltipLine.text = tooltipLine.text.Replace("critical strike chance",
                                    Translation.KeyText("Calamity.VanillaItem.PrefixAccCritChance"));
                            break;
                        case 62:
                        case 63:
                        case 64:
                        case 65:
                        {
                            TooltipLine tooltipLine2 = tooltips.FirstOrDefault(x => x.Name == "PrefixAccDefense");
                            if(tooltipLine2 != null)
                                tooltipLine2.text = tooltipLine2.text
                                    .Replace("defense", Translation.KeyText("Calamity.VanillaItem.Defense"))
                                    .Replace("damage reduction", Translation.KeyText("Calamity.VanillaItem.PrefixAccDefense"));
                            break;
                        }
                    }
                }

                TooltipLine line1 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Tooltip0");
                if (line1 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.WarmthPotion:
                            line1.text = CoreCalamityTranslation.DeathMode 
                                ? Translation.KeyText2("Calamity.VanillaItem.WarmthPotion.DeathMode")
                                : Translation.KeyText2("Calamity.VanillaItem.WarmthPotion");
                            break;
                        case ItemID.ObsidianSkinPotion:
                            line1.text = CoreCalamityTranslation.DeathMode 
                                ? Translation.KeyText2("Calamity.VanillaItem.ObsidianSkinPotion.DeathMode") 
                                : Translation.KeyText2("Calamity.VanillaItem.ObsidianSkinPotion");
                            break;
                        case ItemID.ObsidianRose:
                            line1.text = CoreCalamityTranslation.DeathMode 
                                ? Translation.KeyText2("Calamity.VanillaItem.ObsidianRose.DeathMode") 
                                : Translation.KeyText2("Calamity.VanillaItem.ObsidianRose");
                            break;
                        case ItemID.MagmaStone:
                            if (CoreCalamityTranslation.DeathMode)
                                line1.text = Language.GetTextValue("ItemTooltip.MagmaStone") +
                                             Translation.KeyText2("Calamity.DeathMode.HeatAndCold");
                            break;
                        case ItemID.LavaCharm:
                            if (CoreCalamityTranslation.DeathMode)
                                line1.text = Language.GetTextValue("ItemTooltip.LavaCharm") +
                                             Translation.KeyText2("Calamity.DeathMode.Heat");
                            break;
                        case ItemID.HandWarmer:
                            line1.text = CoreCalamityTranslation.DeathMode ? 
                                Translation.KeyText2("Calamity.VanillaItem.HandWarmer.DeathMode") : 
                                Translation.KeyText2("Calamity.VanillaItem.HandWarmer");
                            break;
                        case ItemID.Picksaw:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.Picksaw");
                            break;
                        case ItemID.FlaskofVenom:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.FlaskofVenom");
                            break;
                        case ItemID.FlaskofCursedFlames:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.FlaskofCursedFlames");
                            break;
                        case ItemID.FlaskofFire:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.FlaskofFire");
                            break;
                        case ItemID.FlaskofGold:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.FlaskofGold");
                            break;
                        case ItemID.FlaskofIchor:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.FlaskofIchor");
                            break;
                        case ItemID.FlaskofNanites:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.FlaskofNanites");
                            break;
                        case ItemID.FlaskofParty:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.FlaskofParty");
                            break;
                        case ItemID.FlaskofPoison:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.FlaskofPoison");
                            break;
                        case ItemID.MiningHelmet:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.MiningHelmet");
                            break;
                        case ItemID.RodofDiscord:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.RodofDiscord");
                            break;
                        case ItemID.SuperAbsorbantSponge:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.SuperAbsorbantSponge");
                            break;
                        case ItemID.CrimsonHeart:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.CrimsonHeart");
                            break;
                        case ItemID.ShadowOrb:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.ShadowOrb");
                            break;
                        case ItemID.MagicLantern:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.MagicLantern");
                            break;
                        case ItemID.JellyfishNecklace:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.JellyfishNecklace");
                            break;
                        case ItemID.FairyBell:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.FairyBell");
                            break;
                        case ItemID.DD2PetGhost:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.DD2PetGhost");
                            break;
                        case ItemID.WispinaBottle:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.WispinaBottle");
                            break;
                        case ItemID.DivingHelmet:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.DivingHelmet");
                            break;
                        case ItemID.NeptunesShell:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.NeptunesShell");
                            break;
                        case ItemID.MoonShell:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.MoonShell");
                            break;
                        case ItemID.WormScarf:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.WormScarf");
                            break;
                        case ItemID.TitanGlove:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.TitanGlove");
                            break;
                        case ItemID.SpectreHood:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.SpectreHood");
                            break;
                        case ItemID.MagicQuiver:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.MagicQuiver");
                            break;
                        case ItemID.InvisibilityPotion:
                            line1.text = Translation.KeyText2("Calamity.VanillaItem.InvisibilityPotion");
                            break;
                    }
                }

                TooltipLine line2 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Defense");
                if (line2 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.EmptyBucket:
                            line2.text = Translation.KeyText2("Calamity.VanillaItem.EmptyBucket");
                            break;
                        case ItemID.GladiatorHelmet:
                            line2.text = Translation.KeyText2("Calamity.VanillaItem.GladiatorHelmet");
                            break;
                        case ItemID.GladiatorBreastplate:
                            line2.text = Translation.KeyText2("Calamity.VanillaItem.GladiatorBreastplate");
                            break;
                        case ItemID.GladiatorLeggings:
                            line2.text = Translation.KeyText2("Calamity.VanillaItem.GladiatorLeggings");
                            break;
                        case ItemID.ObsidianHelm:
                            line2.text = Translation.KeyText2("Calamity.VanillaItem.ObsidianHelm");
                            break;
                        case ItemID.ObsidianShirt:
                            line2.text = Translation.KeyText2("Calamity.VanillaItem.ObsidianShirt");
                            break;
                        case ItemID.ObsidianPants:
                            line2.text = Translation.KeyText2("Calamity.VanillaItem.ObsidianPants");
                            break;
                    }
                }

                TooltipLine line3 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Tooltip1");
                if (line3 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.FireGauntlet:
                            line3.text = CoreCalamityTranslation.DeathMode
                                ? Translation.KeyText2("Calamity.VanillaItem.FireGauntlet.DeathMode")
                                : Translation.KeyText2("Calamity.VanillaItem.FireGauntlet");
                            break;
                        case ItemID.JellyfishDivingGear:
                            line3.text = Translation.KeyText2("Calamity.VanillaItem.JellyfishDivingGear");
                            break;
                        case ItemID.ArcticDivingGear:
                            line3.text = Translation.KeyText2("Calamity.VanillaItem.ArcticDivingGear");
                            break;
                        case ItemID.SuspiciousLookingTentacle:
                            line3.text = Translation.KeyText2("Calamity.VanillaItem.SuspiciousLookingTentacle");
                            break;
                        case ItemID.CelestialShell:
                            line3.text = Translation.KeyText2("Calamity.VanillaItem.CelestialShell");
                            break;
                        case ItemID.PowerGlove:
                            line3.text = Translation.KeyText2("Calamity.VanillaItem.PowerGlove");
                            break;
                        case ItemID.MechanicalGlove:
                            line3.text = Translation.KeyText2("Calamity.VanillaItem.MechanicalGlove");
                            break;
                    }
                }

                TooltipLine line4 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "BuffTime");
                if (line4 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.ShinePotion:
                            line4.text = Translation.KeyText2("Calamity.VanillaItem.ShinePotion");
                            break;
                        case ItemID.GillsPotion:
                            line4.text = Translation.KeyText2("Calamity.VanillaItem.GillsPotion");
                            break;
                    }
                }

                TooltipLine line5 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "SetBonus");
                if (line5 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.MeteorHelmet:
                        case ItemID.MeteorSuit:
                        case ItemID.MeteorLeggings:
                            line5.text = Translation.KeyText2("Calamity.VanillaItem.SetBonus.Meteor");
                            break;
                        case ItemID.CopperGreaves:
                        case ItemID.CopperChainmail:
                        case ItemID.CopperHelmet:
                            line5.text = Translation.KeyText2("Calamity.VanillaItem.SetBonus.Copper");
                            break;
                        case ItemID.TinHelmet:
                        case ItemID.TinChainmail:
                        case ItemID.TinGreaves:
                            line5.text = Translation.KeyText2("Calamity.VanillaItem.SetBonus.Tin");
                            break;
                        case ItemID.IronGreaves:
                        case ItemID.IronChainmail:
                        case ItemID.IronHelmet:
                        case ItemID.AncientIronHelmet:
                            line5.text = Translation.KeyText2("Calamity.VanillaItem.SetBonus.Iron");
                            break;
                        case ItemID.LeadHelmet:
                        case ItemID.LeadChainmail:
                        case ItemID.LeadGreaves:
                            line5.text = Translation.KeyText2("Calamity.VanillaItem.SetBonus.Lead");
                            break;
                        case ItemID.SilverGreaves:
                        case ItemID.SilverChainmail:
                        case ItemID.SilverHelmet:
                            line5.text = Translation.KeyText2("Calamity.VanillaItem.SetBonus.Silver");
                            break;
                        case ItemID.TungstenHelmet:
                        case ItemID.TungstenChainmail:
                        case ItemID.TungstenGreaves:
                            line5.text = Translation.KeyText2("Calamity.VanillaItem.SetBonus.Tungsten");
                            break;
                        case ItemID.GoldGreaves:
                        case ItemID.GoldChainmail:
                        case ItemID.GoldHelmet:
                        case ItemID.AncientGoldHelmet:
                            line5.text = Translation.KeyText2("Calamity.VanillaItem.SetBonus.Gold");
                            break;
                        case ItemID.PlatinumHelmet:
                        case ItemID.PlatinumChainmail:
                        case ItemID.PlatinumGreaves:
                            line5.text = Translation.KeyText2("Calamity.VanillaItem.SetBonus.Platinum");
                            break;
                        case ItemID.MoltenHelmet:
                        case ItemID.MoltenBreastplate:
                        case ItemID.MoltenGreaves:
                            line5.text = CoreCalamityTranslation.DeathMode
                                ? Translation.KeyText2("Calamity.VanillaItem.SetBonus.Molten.DeathMode")
                                : Translation.KeyText2("Calamity.VanillaItem.SetBonus.Molten");
                            break;
                        case ItemID.FrostHelmet:
                        case ItemID.FrostBreastplate:
                        case ItemID.FrostLeggings:
                            if (CoreCalamityTranslation.DeathMode)
                                line5.text = Translation.KeyText2("Calamity.ModifyItemTooltip.SetBonus.Frost.DeathMode");
                            break;
                    }
                }

                TooltipLine line6 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Equipable");
                if (line6 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.GrapplingHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.GrapplingHook");
                            break;
                        case ItemID.AmethystHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.AmethystHook");
                            break;
                        case ItemID.TopazHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.TopazHook");
                            break;
                        case ItemID.SapphireHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.SapphireHook");
                            break;
                        case ItemID.EmeraldHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.EmeraldHook");
                            break;
                        case ItemID.RubyHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.RubyHook");
                            break;
                        case ItemID.DiamondHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.DiamondHook");
                            break;
                        case ItemID.WebSlinger:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.WebSlinger");
                            break;
                        case ItemID.SkeletronHand:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.SkeletronHand");
                            break;
                        case ItemID.SlimeHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.SlimeHook");
                            break;
                        case ItemID.FishHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.FishHook");
                            break;
                        case ItemID.IvyWhip:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.IvyWhip");
                            break;
                        case ItemID.BatHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.BatHook");
                            break;
                        case ItemID.CandyCaneHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.CandyCaneHook");
                            break;
                        case ItemID.DualHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.DualHook");
                            break;
                        case ItemID.TendonHook:
                        case ItemID.ThornHook:
                        case ItemID.IlluminantHook:
                        case ItemID.WormHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.HookMix");
                            break;
                        case ItemID.AntiGravityHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.AntiGravityHook");
                            break;
                        case ItemID.SpookyHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.SpookyHook");
                            break;
                        case ItemID.ChristmasHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.ChristmasHook");
                            break;
                        case ItemID.LunarHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.LunarHook");
                            break;
                        case ItemID.StaticHook:
                            line6.text = Translation.KeyText2("Calamity.VanillaItem.StaticHook");
                            break;
                    }
                }

                TooltipLine line7 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "NeedsBait");
                if (line7 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.GoldenFishingRod:
                            line7.text = Translation.KeyText2("Calamity.VanillaItem.GoldenFishingRod");
                            break;
                    }
                }

                TooltipLine line8 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Material");
                if (line8 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.VortexPickaxe:
                        case ItemID.NebulaPickaxe:
                        case ItemID.SolarFlarePickaxe:
                        case ItemID.StardustPickaxe:
                            line8.text = Translation.KeyText2("Calamity.VanillaItem.PicaxeMix");
                            break;
                    }
                }

                TooltipLine line9 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "HealLife");
                if (line9 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.BottledHoney:
                            line9.text = Translation.KeyText2("Calamity.VanillaItem.BottledHoney");
                            break;
                    }
                }
            }
        }
    }
    
    public class VanillaWings : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && 
                CalamityRuTranslate.Config.CalamityTranslation)
            {
                TooltipLine line1 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Tooltip0");
                if (line1 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.ButterflyWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.ButterflyWings");
                            break;
                        case ItemID.DemonWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.DemonWings");
                            break;
                        case ItemID.AngelWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.AngelWings");
                            break;
                        case ItemID.BeeWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.BeeWings");
                            break;
                        case ItemID.FairyWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.FairyWings");
                            break;
                        case ItemID.HarpyWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.HarpyWings");
                            break;
                        case ItemID.BoneWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.BoneWings");
                            break;
                        case ItemID.FlameWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.FlameWings");
                            break;
                        case ItemID.FrozenWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.FrozenWings");
                            break;
                        case ItemID.GhostWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.GhostWings");
                            break;
                        case ItemID.SteampunkWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.SteampunkWings");
                            break;
                        case ItemID.BatWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.BatWings");
                            break;
                        case ItemID.TatteredFairyWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.TatteredFairyWings");
                            break;
                        case ItemID.SpookyWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.SpookyWings");
                            break;
                        case ItemID.FestiveWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.FestiveWings");
                            break;
                        case ItemID.BeetleWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.BeetleWings");
                            break;
                        case ItemID.FinWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.FinWings");
                            break;
                        case ItemID.FishronWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.FishronWings");
                            break;
                        case ItemID.MothronWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.MothronWings");
                            break;
                        case ItemID.WingsSolar:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.WingsSolar");
                            break;
                        case ItemID.WingsVortex:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.WingsVortex");
                            break;
                        case ItemID.WingsStardust:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.WingsStardust");
                            break;
                        case ItemID.LeafWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.LeafWings");
                            break;
                        case ItemID.RedsWings:
                        case ItemID.DTownsWings:
                        case ItemID.WillsWings:
                        case ItemID.CrownosWings:
                        case ItemID.CenxsWings:
                        case ItemID.BejeweledValkyrieWing:
                        case ItemID.Yoraiz0rWings:
                        case ItemID.JimsWings:
                        case ItemID.SkiphsWings:
                        case ItemID.LokisWings:
                        case ItemID.ArkhalisWings:
                        case ItemID.LeinforsWings:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.Mix");
                            break;
                        case ItemID.WingsNebula:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.WingsNebula");
                            break;
                        case ItemID.Jetpack:
                            line1.text = Translation.KeyText2("Calamity.Vanilla.Wings.Jetpack");
                            break;
                    }
                }

                TooltipLine line2 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Tooltip1");
                if (line2 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.Hoverboard:
                            line2.text = Translation.KeyText2("Calamity.Vanilla.Wings.Hoverboard");
                            break;
                    }
                }

                TooltipLine line3 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Equipable");
                if (line3 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.BetsyWings:
                            line3.text = Translation.KeyText2("Calamity.Vanilla.Wings.BetsyWings");
                            break;
                    }
                }
            }
        }
    }
    
    public class Meters : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && 
                CalamityRuTranslate.Config.CalamityTranslation)
            {
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("StatMeter"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltipLine != null)
                    {
                        string[] array = Regex.Split(tooltipLine.text, "\n\n");
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i].Contains("Adrenaline"))
                            {
                                array[i] = string.Format(Translation.KeyText("Calamity.ItemTooltip.StatMeter.RevStats"),
                                    array[i].Split(' ')[3], 
                                    array[i].Split(' ')[8], 
                                    array[i].Split(' ')[13]);
                            }
                            else if (array[i].Contains("Displays"))
                            {
                                array[i] = Translation.KeyText("Calamity.ItemTooltip.StatMeter");
                            }
                            else if (array[i].Contains("Defense: "))
                            {
                                array[i] = string.Format(Translation.KeyText("Calamity.ItemTooltip.StatMeter.DefStats"),
                                    array[i].Split(' ')[1],
                                    array[i].Split(' ')[4],
                                    array[i].Split(' ')[8].Split('\n')[0],
                                    array[i].Split(' ')[10],
                                    array[i].Split(' ')[15],
                                    array[i].Split(' ')[19],
                                    array[i].Split(' ')[24]);
                            }
                            else if (array[i].Contains("True Melee Damage: "))
                            {
                                array[i] = string.Format(Translation.KeyText("Calamity.ItemTooltip.StatMeter.MeleeStats"),
                                    array[i].Split(' ')[2],
                                    array[i].Split(' ')[7],
                                    array[i].Split(' ')[12].Split('\n')[0],
                                    array[i].Split(' ')[15]);
                            }
                            else if (array[i].Contains("Ranged Damage: "))
                            {
                                array[i] = string.Format(Translation.KeyText("Calamity.ItemTooltip.StatMeter.RangedStats"),
                                    array[i].Split(' ')[2],
                                    array[i].Split(' ')[7].Split('\n')[0],
                                    array[i].Split(' ')[10]);
                            }
                            else if (array[i].Contains("Magic Damage: "))
                            {
                                array[i] = string.Format(Translation.KeyText("Calamity.ItemTooltip.StatMeter.MagicStats"),
                                    array[i].Split(' ')[2],
                                    array[i].Split(' ')[7].Split('\n')[0],
                                    array[i].Split(' ')[9],
                                    array[i].Split(' ')[13]);
                            }
                            else if (array[i].Contains("Minion Damage: "))
                            {
                                array[i] = string.Format(Translation.KeyText("Calamity.ItemTooltip.StatMeter.MinionStats"),
                                    array[i].Split(' ')[2],
                                    array[i].Split(' ')[6]);
                            }
                            else if (array[i].Contains("Rogue Damage: "))
                            {
                                array[i] = string.Format(Translation.KeyText("Calamity.ItemTooltip.StatMeter.RogueStats"),
                                    array[i].Split(' ')[2],
                                    array[i].Split(' ')[7].Split('\n')[0],
                                    array[i].Split(' ')[10],
                                    array[i].Split(' ')[16].Split('\n')[0],
                                    array[i].Split(' ')[18],
                                    array[i].Split(' ')[22],
                                    array[i].Split(' ')[28]);
                            }
                            else if (array[i].Contains("Light Strength"))
                            {
                                array[i] = CoreCalamityTranslation.DeathMode
                                    ? string.Format(Translation.KeyText("Calamity.ItemTooltip.StatMeter.CaveLightStrength"),
                                        array[i].Split(' ')[3])
                                    : string.Format(Translation.KeyText("Calamity.ItemTooltip.StatMeter.AbyssLightStrength"),
                                        array[i].Split(' ')[3]);
                            }
                            else if (array[i].Contains("Other Abyss"))
                            {
                                array[i] = (bool)CoreCalamityTranslation.CalamityMod.Call("GetInZone", 
                                    Main.player[Main.myPlayer], "abyss")
                                    ? string.Format(Translation.KeyText("Calamity.ItemTooltip.StatMeter.AbyssStats"),
                                        array[i].Split(' ')[6],
                                        array[i].Split(' ')[11].Split('\n')[0],
                                        array[i].Split(' ')[18].Split('\n')[0],
                                        array[i].Split(' ')[20])
                                    : Translation.KeyText("Calamity.ItemTooltip.StatMeter.AbyssZone");
                            }
                        }
                        
                        tooltipLine.text = string.Join("\n\n", array);
                    }
                }
    
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("MeleeLevelMeter"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltipLine != null)
                    {
                        string[] array = Regex.Split(tooltipLine.text, "\n");
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.MeleeLevelMeter"), 
                            Regex.Split(array[3], ": ")[1],
                            Regex.Split(array[4], ": ")[1],
                            Regex.Split(array[5], ": ")[1],
                            Regex.Split(array[6], ": ")[1],
                            Regex.Split(array[7], ": ")[1]);
                    }
                }

                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("MagicLevelMeter"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltipLine != null)
                    {
                        string[] array = Regex.Split(tooltipLine.text, "\n");
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.MagicLevelMeter"), 
                            Regex.Split(array[3], ": ")[1],
                            Regex.Split(array[4], ": ")[1],
                            Regex.Split(array[5], ": ")[1],
                            Regex.Split(array[6], ": ")[1],
                            Regex.Split(array[7], ": ")[1]);
                    }
                }

                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("RangedLevelMeter"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltipLine != null)
                    {
                        string[] array = Regex.Split(tooltipLine.text, "\n");
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.RangedLevelMeter"), 
                            Regex.Split(array[3], ": ")[1],
                            Regex.Split(array[4], ": ")[1],
                            Regex.Split(array[5], ": ")[1],
                            Regex.Split(array[6], ": ")[1],
                            Regex.Split(array[7], ": ")[1]);
                    }
                }
					
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("RogueLevelMeter"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltipLine != null)
                    {
                        string[] array = Regex.Split(tooltipLine.text, "\n");
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.RogueLevelMeter"), 
                            Regex.Split(array[3], ": ")[1],
                            Regex.Split(array[4], ": ")[1],
                            Regex.Split(array[5], ": ")[1],
                            Regex.Split(array[6], ": ")[1],
                            Regex.Split(array[7], ": ")[1]);
                    }
                }
                
                else if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("SummonLevelMeter"))
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltipLine != null)
                    {
                        string[] array = Regex.Split(tooltipLine.text, "\n");
                        tooltipLine.text = string.Format(Translation.KeyText("Calamity.ItemTooltip.SummonLevelMeter"), 
                            Regex.Split(array[3], ": ")[1], 
                            Regex.Split(array[4], ": ")[1],
                            Regex.Split(array[5], ": ")[1], 
                            Regex.Split(array[6], ": ")[1],
                            Regex.Split(array[7], ": ")[1]);
                    }
                }
            }
        }
    }
}