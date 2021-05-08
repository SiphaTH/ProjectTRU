using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class FuckingItems : CalamityAutoLoad
    {
        public override void ModifyTooltips(Item item, List <TooltipLine> tooltips)
        {
            if (item.type == ModsCall.Calamity.ItemType("AsgardianAegis"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip5");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.AsgardianAegis.Tooltip5", ModsCall.AegisHotKey);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("AstralArcanum"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip6");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.AstralArcanum.Tooltip6", ModsCall.AstralArcanumUiHotkey);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("CelestialJewel"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip2");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.CelestialJewel.Tooltip2", ModsCall.AstralArcanumUiHotkey);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("ElysianAegis"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip5");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.ElysianAegis.Tooltip5", ModsCall.AegisHotKey);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("MomentumCapacitor"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.MomentumCapacitor.Tooltip0", ModsCall.MomentumCapacitatorHotkey);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("Nanotech"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip7");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.RaidersTalismanOrNanotech", tooltip.text.Split(' ')[3]);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("RaidersTalisman"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip3");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.RaidersTalismanOrNanotech", tooltip.text.Split(' ')[3]);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("ProfanedSoulCrystal"))
            {
                TooltipLine tooltip1 = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                if (tooltip1 != null)
                {
                    tooltip1.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.ProfanedSoulCrystal.Tooltip1");
                }
            
                if (ModsCall.ProfanedCrystalBuffs)
                {
                    TooltipLine tooltip5 = tooltips.FirstOrDefault(x => x.Name == "Tooltip5");
                    if (tooltip5 != null)
                    {
                        tooltip5.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.ProfanedSoulCrystal.Tooltip5", tooltip5.text.Split(' ')[9]);
                    }
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("SandCloak"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.SandCloak.Tooltip1", ModsCall.SandCloakHotkey);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("SpectralVeil"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.SpectralVeil.Tooltip1", ModsCall.SpectralVeilHotKey);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("NormalityRelocator"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.NormalityRelocator.Tooltip1", ModsCall.NormalityRelocatorHotKey);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("Eternity"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.Eternity.Tooltip1", ModsCall.EternityDiscoHex);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("PlaguedFuelPack"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip2");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.PlaguedFuelPack.Tooltip2", ModsCall.PlaguePackHotKey);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("Revenge"))
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    switch (tooltip.Name)
                    {
                        case "Tooltip1":
                            tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.Revenge.Tooltip1", ModsCall.RageHotKey);
                            break;
                        case "Tooltip3":
                            tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.Revenge.Tooltip3", ModsCall.AdrenalineHotKey);
                            break;
                    }
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("CosmicWorm"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                if (tooltip != null && ModsCall.DownedFlag)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.CosmicWorm.Tooltip1");
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("BlunderBooster"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip2");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.BlunderBooster.Tooltip2", ModsCall.PlaguePackHotKey);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("GrandGelatin"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.GrandGelatin.Tooltip1", Main.player[Main.myPlayer].autoJump ? 10 : 40);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("VitalJelly"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.VitalJelly.Tooltip1", Main.player[Main.myPlayer].autoJump ? 6 : 24);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("KnowledgeKingSlime"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip2");
                if (tooltip != null)
                {
                    tooltip.text = Main.player[Main.myPlayer].autoJump
                        ? LangUtils.GetTextValue("Calamity", "ItemTooltip.KnowledgeKingSlime.Tooltip2.AutoJump")
                        : LangUtils.GetTextValue("Calamity", "ItemTooltip.KnowledgeKingSlime.Tooltip2");
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("AbandonedSlimeStaff"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip4");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.AbandonedSlimeStaff.Tooltip4", Main.player[Main.myPlayer].autoJump ? 5 : 20);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("AeroStone"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.AeroStone.Tooltip1", Main.player[Main.myPlayer].autoJump ? 5 : 20);
                }
            }
            else if (item.type == ModsCall.Calamity.ItemType("SunkenStew"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.SunkenStew.Tooltip0", Main.player[Main.myPlayer].pStone ? 37 : 50);
                }
            }
            
            if (ModLoader.GetMod("Fargowiltas") != null)
            {
                if (item.type == ModsCall.Calamity.ItemType("SunkenSeaFountain"))
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltip != null)
                    {
                        tooltip.text = LangUtils.GetTextValue("Calamity", "ModifyItemTooltip.SunkenSeaFountain");
                    }
                }
                else if (item.type == ModsCall.Calamity.ItemType("SulphurousFountainItem"))
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltip != null)
                    {
                        tooltip.text = LangUtils.GetTextValue("Calamity", "ModifyItemTooltip.SulphurousFountainItem");
                    }
                }
                else if (item.type == ModsCall.Calamity.ItemType("AstralFountainItem"))
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltip != null)
                    {
                        tooltip.text = LangUtils.GetTextValue("Calamity", "ModifyItemTooltip.AstralFountainItem");
                    }
                }
            }
        }
    }
    
    public class DeathModeItems : CalamityAutoLoad
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (var translation in CalamityCatalog.DeathModeItem)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == translation.Value.TooltipLineNumber);
                
                if (item.type == ModsCall.Calamity.ItemType(translation.Key) && tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", translation.Value.NormalTextKey) + (ModsCall.DeathMode ? LangUtils.GetTextValue("Calamity", translation.Value.DeathModeTextKey) : "");
                    return;
                }
            }
            
            if (item.type == ModsCall.Calamity.ItemType("PurifiedJam"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.PurifiedJam.Tooltip0", ModsCall.DeathMode ? 5 : 10);
                }
            }
        }
    }
    
    public class VanillaItems : CalamityAutoLoad
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.LavaWaders)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                if (tooltip != null && ModsCall.DeathMode)
                {
                    tooltip.text = LangUtils.GetTextValue("Calamity", "VanillaItem.LavaWaders");
                }
            }

            foreach (TooltipLine tooltip in tooltips)
            {
                if (tooltip.Name == "Tooltip0")
                {
                    tooltip.text = tooltip.text.Replace("Current Charge", LangUtils.GetTextValue("Calamity", "VanillaItem.CalamityTip.CurrentCharge"));
                }
            }
					
            if (item.prefix > 0)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    if (tooltip.Name == "PrefixSSDmg")
                    {
                        tooltip.text = tooltip.text.Replace("stealth strike damage", LangUtils.GetTextValue("Calamity", "VanillaItem.PrefixSSDmg"));
                    }
						
                    if (tooltip.Name == "PrefixStealthGenBoost")
                    {
                        tooltip.text = tooltip.text.Replace("stealth generation", LangUtils.GetTextValue("Calamity", "VanillaItem.PrefixStealthGenBoost"));
                    }
                }
            }

            if (item.accessory)
            {
                switch (item.prefix)
                {
                    case 67:
                    case 68:
                        TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "PrefixAccCritChance");
                        if(tooltip != null)
                            tooltip.text = tooltip.text.Replace("critical strike chance", LangUtils.GetTextValue("Calamity", "VanillaItem.PrefixAccCritChance"));
                        break;
                    case 62:
                    case 63:
                    case 64:
                    case 65:
                        TooltipLine tooltip2 = tooltips.FirstOrDefault(x => x.Name == "PrefixAccDefense");
                        if(tooltip2 != null)
                            tooltip2.text = tooltip2.text
                                .Replace("defense", LangUtils.GetTextValue("Calamity", "VanillaItem.Defense"))
                                .Replace("damage reduction", LangUtils.GetTextValue("Calamity", "VanillaItem.PrefixAccDefense"));
                        break;
                }
            }

            TooltipLine line1 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Tooltip0");
            if (line1 != null)
            {
                switch (item.type)
                {
                    case ItemID.WarmthPotion:
                        line1.text = ModsCall.DeathMode
                            ? LangUtils.GetTextValue("Calamity", "VanillaItem.WarmthPotion.DeathMode")
                            : LangUtils.GetTextValue("Calamity", "VanillaItem.WarmthPotion");
                        break;
                    
                    case ItemID.ObsidianSkinPotion:
                        line1.text = ModsCall.DeathMode
                            ? LangUtils.GetTextValue("Calamity", "VanillaItem.ObsidianSkinPotion.DeathMode")
                            : LangUtils.GetTextValue("Calamity", "VanillaItem.ObsidianSkinPotion");
                        break;
                    
                    case ItemID.ObsidianRose:
                        line1.text = ModsCall.DeathMode
                            ? LangUtils.GetTextValue("Calamity", "VanillaItem.ObsidianRose.DeathMode")
                            : LangUtils.GetTextValue("Calamity", "VanillaItem.ObsidianRose");
                        break;
                    
                    case ItemID.MagmaStone:
                        if (ModsCall.DeathMode)
                            line1.text = Language.GetTextValue("ItemTooltip.MagmaStone") + LangUtils.GetTextValue("Calamity", "DeathMode.HeatAndCold");
                        break;
                    
                    case ItemID.LavaCharm:
                        if (ModsCall.DeathMode)
                            line1.text = Language.GetTextValue("ItemTooltip.LavaCharm") + LangUtils.GetTextValue("Calamity", "DeathMode.Heat");
                        break;
                    
                    case ItemID.HandWarmer:
                        line1.text = ModsCall.DeathMode
                            ? LangUtils.GetTextValue("Calamity", "VanillaItem.HandWarmer.DeathMode")
                            : LangUtils.GetTextValue("Calamity", "VanillaItem.HandWarmer");
                        break;
                    
                    case ItemID.Picksaw:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.Picksaw");
                        break;
                    
                    case ItemID.FlaskofVenom:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.FlaskofVenom");
                        break;
                    
                    case ItemID.FlaskofCursedFlames:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.FlaskofCursedFlames");
                        break;
                    
                    case ItemID.FlaskofFire:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.FlaskofFire");
                        break;
                    
                    case ItemID.FlaskofGold:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.FlaskofGold");
                        break;
                    
                    case ItemID.FlaskofIchor:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.FlaskofIchor");
                        break;
                    
                    case ItemID.FlaskofNanites:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.FlaskofNanites");
                        break;
                    
                    case ItemID.FlaskofParty:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.FlaskofParty");
                        break;
                    
                    case ItemID.FlaskofPoison:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.FlaskofPoison");
                        break;
                    
                    case ItemID.MiningHelmet:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.MiningHelmet");
                        break;
                    
                    case ItemID.RodofDiscord:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.RodofDiscord");
                        break;
                    
                    case ItemID.SuperAbsorbantSponge:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SuperAbsorbantSponge");
                        break;
                    
                    case ItemID.CrimsonHeart:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.CrimsonHeart");
                        break;
                    
                    case ItemID.ShadowOrb:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.ShadowOrb");
                        break;
                    
                    case ItemID.MagicLantern:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.MagicLantern");
                        break;
                    
                    case ItemID.JellyfishNecklace:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.JellyfishNecklace");
                        break;
                    
                    case ItemID.FairyBell:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.FairyBell");
                        break;
                    
                    case ItemID.DD2PetGhost:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.DD2PetGhost");
                        break;
                    
                    case ItemID.WispinaBottle:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.WispinaBottle");
                        break;
                    
                    case ItemID.DivingHelmet:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.DivingHelmet");
                        break;
                    
                    case ItemID.NeptunesShell:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.NeptunesShell");
                        break;
                    
                    case ItemID.MoonShell:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.MoonShell");
                        break;
                    
                    case ItemID.WormScarf:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.WormScarf");
                        break;
                    
                    case ItemID.TitanGlove:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.TitanGlove");
                        break;
                    
                    case ItemID.SpectreHood:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SpectreHood");
                        break;
                    
                    case ItemID.MagicQuiver:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.MagicQuiver");
                        break;
                    
                    case ItemID.InvisibilityPotion:
                        line1.text = LangUtils.GetTextValue("Calamity", "VanillaItem.InvisibilityPotion");
                        break;
                }
            }

            TooltipLine line2 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Defense");
            if (line2 != null)
            {
                switch (item.type)
                {
                    case ItemID.EmptyBucket:
                        line2.text = LangUtils.GetTextValue("Calamity", "VanillaItem.EmptyBucket");
                        break;
                    
                    case ItemID.GladiatorHelmet:
                        line2.text = LangUtils.GetTextValue("Calamity", "VanillaItem.GladiatorHelmet");
                        break;
                    
                    case ItemID.GladiatorBreastplate:
                        line2.text = LangUtils.GetTextValue("Calamity", "VanillaItem.GladiatorBreastplate");
                        break;
                    
                    case ItemID.GladiatorLeggings:
                        line2.text = LangUtils.GetTextValue("Calamity", "VanillaItem.GladiatorLeggings");
                        break;
                    
                    case ItemID.ObsidianHelm:
                        line2.text = LangUtils.GetTextValue("Calamity", "VanillaItem.ObsidianHelm");
                        break;
                    
                    case ItemID.ObsidianShirt:
                        line2.text = LangUtils.GetTextValue("Calamity", "VanillaItem.ObsidianShirt");
                        break;
                    
                    case ItemID.ObsidianPants:
                        line2.text = LangUtils.GetTextValue("Calamity", "VanillaItem.ObsidianPants");
                        break;
                }
            }

            TooltipLine line3 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Tooltip1");
            if (line3 != null)
            {
                switch (item.type)
                {
                    case ItemID.FireGauntlet:
                        line3.text = ModsCall.DeathMode
                            ? LangUtils.GetTextValue("Calamity", "VanillaItem.FireGauntlet.DeathMode")
                            : LangUtils.GetTextValue("Calamity", "VanillaItem.FireGauntlet");
                        break;
                    
                    case ItemID.JellyfishDivingGear:
                        line3.text = LangUtils.GetTextValue("Calamity", "VanillaItem.JellyfishDivingGear");
                        break;
                    
                    case ItemID.ArcticDivingGear:
                        line3.text = LangUtils.GetTextValue("Calamity", "VanillaItem.ArcticDivingGear");
                        break;
                    
                    case ItemID.SuspiciousLookingTentacle:
                        line3.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SuspiciousLookingTentacle");
                        break;
                    
                    case ItemID.CelestialShell:
                        line3.text = LangUtils.GetTextValue("Calamity", "VanillaItem.CelestialShell");
                        break;
                    
                    case ItemID.PowerGlove:
                        line3.text = LangUtils.GetTextValue("Calamity", "VanillaItem.PowerGlove");
                        break;
                    
                    case ItemID.MechanicalGlove:
                        line3.text = LangUtils.GetTextValue("Calamity", "VanillaItem.MechanicalGlove");
                        break;
                }
            }

            TooltipLine line4 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "BuffTime");
            if (line4 != null)
            {
                switch (item.type)
                {
                    case ItemID.ShinePotion:
                        line4.text = LangUtils.GetTextValue("Calamity", "VanillaItem.ShinePotion");
                        break;
                    
                    case ItemID.GillsPotion:
                        line4.text = LangUtils.GetTextValue("Calamity", "VanillaItem.GillsPotion");
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
                        line5.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SetBonus.Meteor");
                        break;
                    
                    case ItemID.CopperGreaves:
                    case ItemID.CopperChainmail:
                    case ItemID.CopperHelmet:
                        line5.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SetBonus.Copper");
                        break;
                    
                    case ItemID.TinHelmet:
                    case ItemID.TinChainmail:
                    case ItemID.TinGreaves:
                        line5.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SetBonus.Tin");
                        break;
                    
                    case ItemID.IronGreaves:
                    case ItemID.IronChainmail:
                    case ItemID.IronHelmet:
                    case ItemID.AncientIronHelmet:
                        line5.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SetBonus.Iron");
                        break;
                    
                    case ItemID.LeadHelmet:
                    case ItemID.LeadChainmail:
                    case ItemID.LeadGreaves:
                        line5.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SetBonus.Lead");
                        break;
                    
                    case ItemID.SilverGreaves:
                    case ItemID.SilverChainmail:
                    case ItemID.SilverHelmet:
                        line5.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SetBonus.Silver");
                        break;
                    
                    case ItemID.TungstenHelmet:
                    case ItemID.TungstenChainmail:
                    case ItemID.TungstenGreaves:
                        line5.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SetBonus.Tungsten");
                        break;
                    
                    case ItemID.GoldGreaves:
                    case ItemID.GoldChainmail:
                    case ItemID.GoldHelmet:
                    case ItemID.AncientGoldHelmet:
                        line5.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SetBonus.Gold");
                        break;
                    
                    case ItemID.PlatinumHelmet:
                    case ItemID.PlatinumChainmail:
                    case ItemID.PlatinumGreaves:
                        line5.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SetBonus.Platinum");
                        break;
                    
                    case ItemID.MoltenHelmet:
                    case ItemID.MoltenBreastplate:
                    case ItemID.MoltenGreaves:
                        line5.text = ModsCall.DeathMode
                            ? LangUtils.GetTextValue("Calamity", "VanillaItem.SetBonus.Molten.DeathMode")
                            : LangUtils.GetTextValue("Calamity", "VanillaItem.SetBonus.Molten");
                        break;
                    
                    case ItemID.FrostHelmet:
                    case ItemID.FrostBreastplate:
                    case ItemID.FrostLeggings:
                        if (ModsCall.DeathMode)
                            line5.text = LangUtils.GetTextValue("Calamity", "ModifyItemTooltip.SetBonus.Frost.DeathMode");
                        break;
                }
            }

            TooltipLine line6 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Equipable");
            if (line6 != null)
            {
                switch (item.type)
                {
                    case ItemID.GrapplingHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.GrapplingHook");
                        break;
                    
                    case ItemID.AmethystHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.AmethystHook");
                        break;
                        
                    case ItemID.TopazHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.TopazHook");
                        break;
                        
                    case ItemID.SapphireHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SapphireHook");
                        break;
                        
                    case ItemID.EmeraldHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.EmeraldHook");
                        break;
                        
                    case ItemID.RubyHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.RubyHook");
                        break;
                        
                    case ItemID.DiamondHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.DiamondHook");
                        break;
                        
                    case ItemID.WebSlinger:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.WebSlinger");
                        break;
                        
                    case ItemID.SkeletronHand:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SkeletronHand");
                        break;
                        
                    case ItemID.SlimeHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SlimeHook");
                        break;
                        
                    case ItemID.FishHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.FishHook");
                        break;
                    
                    case ItemID.IvyWhip:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.IvyWhip");
                        break;
                    
                    case ItemID.BatHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.BatHook");
                        break;
                    
                    case ItemID.CandyCaneHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.CandyCaneHook");
                        break;
                    
                    case ItemID.DualHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.DualHook");
                        break;
                    
                    case ItemID.TendonHook:
                    case ItemID.ThornHook:
                    case ItemID.IlluminantHook:
                    case ItemID.WormHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.HookMix");
                        break;
                    
                    case ItemID.AntiGravityHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.AntiGravityHook");
                        break;
                    
                    case ItemID.SpookyHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.SpookyHook");
                        break;
                    
                    case ItemID.ChristmasHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.ChristmasHook");
                        break;
                    
                    case ItemID.LunarHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.LunarHook");
                        break;
                    
                    case ItemID.StaticHook:
                        line6.text = LangUtils.GetTextValue("Calamity", "VanillaItem.StaticHook");
                        break;
                }
            }

            TooltipLine line7 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "NeedsBait");
            if (line7 != null)
            {
                switch (item.type)
                {
                    case ItemID.GoldenFishingRod:
                        line7.text = LangUtils.GetTextValue("Calamity", "VanillaItem.GoldenFishingRod");
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
                        line8.text = LangUtils.GetTextValue("Calamity", "VanillaItem.PicaxeMix");
                        break;
                }
            }

            TooltipLine line9 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "HealLife");
            if (line9 != null)
            {
                switch (item.type)
                {
                    case ItemID.BottledHoney:
                        line9.text = LangUtils.GetTextValue("Calamity", "VanillaItem.BottledHoney");
                        break;
                }
            }
        }
    }
    
    public class VanillaWings : CalamityAutoLoad
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            TooltipLine line1 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Tooltip0");
            if (line1 != null)
            {
                switch (item.type)
                {
                    case ItemID.ButterflyWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.ButterflyWings");
                        break;
                    
                    case ItemID.DemonWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.DemonWings");
                        break;
                    
                    case ItemID.AngelWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.AngelWings");
                        break;
                    
                    case ItemID.BeeWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.BeeWings");
                        break;
                    
                    case ItemID.FairyWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.FairyWings");
                        break;
                    
                    case ItemID.HarpyWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.HarpyWings");
                        break;
                    
                    case ItemID.BoneWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.BoneWings");
                        break;
                    
                    case ItemID.FlameWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.FlameWings");
                        break;
                    
                    case ItemID.FrozenWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.FrozenWings");
                        break;
                    
                    case ItemID.GhostWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.GhostWings");
                        break;
                    
                    case ItemID.SteampunkWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.SteampunkWings");
                        break;
                    
                    case ItemID.BatWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.BatWings");
                        break;
                    
                    case ItemID.TatteredFairyWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.TatteredFairyWings");
                        break;
                    
                    case ItemID.SpookyWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.SpookyWings");
                        break;
                    
                    case ItemID.FestiveWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.FestiveWings");
                        break;
                    
                    case ItemID.BeetleWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.BeetleWings");
                        break;
                    
                    case ItemID.FinWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.FinWings");
                        break;
                    
                    case ItemID.FishronWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.FishronWings");
                        break;
                    
                    case ItemID.MothronWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.MothronWings");
                        break;
                    
                    case ItemID.WingsSolar:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.WingsSolar");
                        break;
                    
                    case ItemID.WingsVortex:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.WingsVortex");
                        break;
                    
                    case ItemID.WingsStardust:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.WingsStardust");
                        break;
                    
                    case ItemID.LeafWings:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.LeafWings");
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
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.Mix");
                        break;
                    
                    case ItemID.WingsNebula:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.WingsNebula");
                        break;
                    
                    case ItemID.Jetpack:
                        line1.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.Jetpack");
                        break;
                }
            }

            TooltipLine line2 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Tooltip1");
            if (line2 != null)
            {
                switch (item.type)
                {
                    case ItemID.Hoverboard:
                        line2.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.Hoverboard");
                        break;
                }
            }

            TooltipLine line3 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Equipable");
            if (line3 != null)
            {
                switch (item.type)
                {
                    case ItemID.BetsyWings:
                        line3.text = LangUtils.GetTextValue("Calamity", "Vanilla.Wings.BetsyWings");
                        break;
                }
            }
        }
    }
    
    public class Meters : CalamityAutoLoad
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ModsCall.Calamity.ItemType("StatMeter"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                if (tooltip != null)
                {
                    string[] array = Regex.Split(tooltip.text, "\n\n");
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i].Contains("Adrenaline"))
                        {
                            array[i] = LangUtils.GetTextValue("Calamity", "ItemTooltip.StatMeter.RevStats", 
                                array[i].Split(' ')[3], 
                                array[i].Split(' ')[8], 
                                array[i].Split(' ')[13]);
                        }
                        else if (array[i].Contains("Displays"))
                        {
                            array[i] = LangUtils.GetTextValue("Calamity", "ItemTooltip.StatMeter");
                        }
                        else if (array[i].Contains("Defense: "))
                        {
                            array[i] = LangUtils.GetTextValue("Calamity", "ItemTooltip.StatMeter.DefStats",
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
                            array[i] = LangUtils.GetTextValue("Calamity", "ItemTooltip.StatMeter.MeleeStats",
                                array[i].Split(' ')[2],
                                array[i].Split(' ')[7],
                                array[i].Split(' ')[12].Split('\n')[0],
                                array[i].Split(' ')[15]);
                        }
                        else if (array[i].Contains("Ranged Damage: "))
                        {
                            array[i] = LangUtils.GetTextValue("Calamity", "ItemTooltip.StatMeter.RangedStats",
                                array[i].Split(' ')[2],
                                array[i].Split(' ')[7].Split('\n')[0],
                                array[i].Split(' ')[10]);
                        }
                        else if (array[i].Contains("Magic Damage: "))
                        {
                            array[i] = LangUtils.GetTextValue("Calamity", "ItemTooltip.StatMeter.MagicStats",
                                array[i].Split(' ')[2],
                                array[i].Split(' ')[7].Split('\n')[0],
                                array[i].Split(' ')[9],
                                array[i].Split(' ')[13]);
                        }
                        else if (array[i].Contains("Minion Damage: "))
                        {
                            array[i] = LangUtils.GetTextValue("Calamity", "ItemTooltip.StatMeter.MinionStats",
                                array[i].Split(' ')[2],
                                array[i].Split(' ')[6]);
                        }
                        else if (array[i].Contains("Rogue Damage: "))
                        {
                            array[i] = LangUtils.GetTextValue("Calamity", "ItemTooltip.StatMeter.RogueStats",
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
                            array[i] = ModsCall.DeathMode
                                ? LangUtils.GetTextValue("Calamity", "ItemTooltip.StatMeter.CaveLightStrength", array[i].Split(' ')[3])
                                : LangUtils.GetTextValue("Calamity", "ItemTooltip.StatMeter.AbyssLightStrength", array[i].Split(' ')[3]);
                        }
                        else if (array[i].Contains("Other Abyss"))
                        {
                            array[i] = ModsCall.CalamityGetInZone
                                ? LangUtils.GetTextValue("Calamity", "ItemTooltip.StatMeter.AbyssStats",
                                    array[i].Split(' ')[6],
                                    array[i].Split(' ')[11].Split('\n')[0],
                                    array[i].Split(' ')[18].Split('\n')[0],
                                    array[i].Split(' ')[20])
                                : LangUtils.GetTextValue("Calamity", "ItemTooltip.StatMeter.AbyssZone");
                        }
                    }
                    
                    tooltip.text = string.Join("\n\n", array);
                }
            }

            else if (item.type == ModsCall.Calamity.ItemType("MeleeLevelMeter"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                if (tooltip != null)
                {
                    string[] array = Regex.Split(tooltip.text, "\n");
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.MeleeLevelMeter",
                        Regex.Split(array[3], ": ")[1],
                        Regex.Split(array[4], ": ")[1],
                        Regex.Split(array[5], ": ")[1],
                        Regex.Split(array[6], ": ")[1],
                        Regex.Split(array[7], ": ")[1]);
                }
            }

            else if (item.type == ModsCall.Calamity.ItemType("MagicLevelMeter"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                if (tooltip != null)
                {
                    string[] array = Regex.Split(tooltip.text, "\n");
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.MagicLevelMeter",
                        Regex.Split(array[3], ": ")[1],
                        Regex.Split(array[4], ": ")[1],
                        Regex.Split(array[5], ": ")[1],
                        Regex.Split(array[6], ": ")[1],
                        Regex.Split(array[7], ": ")[1]);
                }
            }

            else if (item.type == ModsCall.Calamity.ItemType("RangedLevelMeter"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                if (tooltip != null)
                {
                    string[] array = Regex.Split(tooltip.text, "\n");
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.RangedLevelMeter",
                        Regex.Split(array[3], ": ")[1],
                        Regex.Split(array[4], ": ")[1],
                        Regex.Split(array[5], ": ")[1],
                        Regex.Split(array[6], ": ")[1],
                        Regex.Split(array[7], ": ")[1]);
                }
            }
				
            else if (item.type == ModsCall.Calamity.ItemType("RogueLevelMeter"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                if (tooltip != null)
                {
                    string[] array = Regex.Split(tooltip.text, "\n");
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.RogueLevelMeter",
                        Regex.Split(array[3], ": ")[1],
                        Regex.Split(array[4], ": ")[1],
                        Regex.Split(array[5], ": ")[1],
                        Regex.Split(array[6], ": ")[1],
                        Regex.Split(array[7], ": ")[1]);
                }
            }
            
            else if (item.type == ModsCall.Calamity.ItemType("SummonLevelMeter"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                if (tooltip != null)
                {
                    string[] array = Regex.Split(tooltip.text, "\n");
                    tooltip.text = LangUtils.GetTextValue("Calamity", "ItemTooltip.SummonLevelMeter",
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