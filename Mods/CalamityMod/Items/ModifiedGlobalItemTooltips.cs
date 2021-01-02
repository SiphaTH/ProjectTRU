using System.Collections.Generic;
using System.Linq;
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
        public override void SetDefaults(Item item)
        {
            if (CoreCalamityTranslation.CalamityMod != null && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                if (Translation.IsRussianLanguage)
                {
                    foreach (var translation in RussianDictionaries.CalamitySetNameOverrideFurniture)
                    {
                        if (item.type == CoreCalamityTranslation.CalamityMod.ItemType(translation.Key))
                        {
                            item.SetNameOverride(translation.Value);
                        }
                    }
                }
            }
        }
        
        public override void ModifyTooltips(Item item, List < TooltipLine > tooltips)
        {
            if (CoreCalamityTranslation.CalamityMod != null && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AsgardianAegis"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip5")
                        {
                            tooltipLine.text = string.Format(Translation.KeyText("Calamity.ModifyItemTooltip.AsgardianAegis"), CoreCalamityTranslation.AegisHotKey);
                        }
                    }
                }
		            
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AstralArcanum"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip5")
                        {
                            tooltipLine.text = string.Format(Translation.KeyText("Calamity.ModifyItemTooltip.AstralArcanum"), CoreCalamityTranslation.AstralArcanumUiHotkey);
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("CelestialJewel"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip6")
                        {
                            tooltipLine.text = string.Format(Translation.KeyText("Calamity.ModifyItemTooltip.CelestialJewel"), CoreCalamityTranslation.AstralArcanumUiHotkey);
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("ElysianAegis"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip5")
                        {
                            tooltipLine.text = string.Format(Translation.KeyText("Calamity.ModifyItemTooltip.ElysianAegis"), CoreCalamityTranslation.AegisHotKey);
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("MomentumCapacitor"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip0")
                        {
                            tooltipLine.text = string.Format(Translation.KeyText("Calamity.ModifyItemTooltip.MomentumCapacitor"), CoreCalamityTranslation.MomentumCapacitatorHotkey);
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("Nanotech"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip8")
                        {
                            tooltipLine.text = tooltipLine.text.Replace("Rogue Crit Level", Translation.KeyText("Calamity.ModifyItemTooltip.Nanotech"));
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("ProfanedSoulCrystal"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (Translation.IsRussianLanguage)
                        {
                            foreach (var translation in RussianDictionaries.CalamityProfanedSoulCrystal)
                            {
                                tooltipLine.text = tooltipLine.text.Replace(translation.Key, translation.Value);
                            }
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("RaidersTalisman"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip3")
                        {
                            tooltipLine.text = tooltipLine.text.Replace("Rogue Crit Level", Translation.KeyText("Calamity.ModifyItemTooltip.RaidersTalisman"));
                        }
                    }
                }
		            
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("SandCloak"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = string.Format(Translation.KeyText("Calamity.ModifyItemTooltip.SandCloak"), CoreCalamityTranslation.SandCloakHotkey);
                        }
                    }
                }
		            
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("SpectralVeil"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = string.Format(Translation.KeyText("Calamity.ModifyItemTooltip.SpectralVeil"), CoreCalamityTranslation.SpectralVeilHotKey);
                        }
                    }
                }
		            
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("NormalityRelocator"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = string.Format(Translation.KeyText("Calamity.ModifyItemTooltip.NormalityRelocator"), CoreCalamityTranslation.NormalityRelocatorHotKey);
                        }
                    }
                }
		            
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("Eternity"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = tooltipLine.text.Replace("There's pictures of ponies in the book", Translation.KeyText("Calamity.ModifyItemTooltip.Eternity"));
                        }
                    }
                }
		            
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("PlaguedFuelPack"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip2")
                        {
                            tooltipLine.text = string.Format(Translation.KeyText("Calamity.ModifyItemTooltip.PlaguedFuelPack"), CoreCalamityTranslation.PlaguePackHotKey);
                        }
                    }
                }
		            
                if (ModLoader.GetMod("Fargowiltas") != null)
                {
                    if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("SunkenSeaFountain"))
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            if (tooltipLine.Name == "Tooltip0")
                            {
                                tooltipLine.text = Translation.KeyText("Calamity.ModifyItemTooltip.SunkenSeaFountain");
                            }
                        }
                    }
			            
                    if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("SulphurousFountainItem"))
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            if (tooltipLine.Name == "Tooltip0")
                            {
                                tooltipLine.text = Translation.KeyText("Calamity.ModifyItemTooltip.SulphurousFountainItem");
                            }
                        }
                    }
			            
                    if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AstralFountainItem"))
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            if (tooltipLine.Name == "Tooltip0")
                            {
                                tooltipLine.text = Translation.KeyText("Calamity.ModifyItemTooltip.AstralFountainItem");
                            }
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("Revenge"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = string.Format(Translation.KeyText("Calamity.ModifyItemTooltip.Revenge.tip1"), CoreCalamityTranslation.RageHotKey);
                        }
				            
                        if (tooltipLine.Name == "Tooltip3")
                        {
                            tooltipLine.text = string.Format(Translation.KeyText("Calamity.ModifyItemTooltip.Revenge.tip2"), CoreCalamityTranslation.AdrenalineHotKey);
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("CosmicWorm"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DownedFlag ? 
                                Translation.KeyText("Calamity.ModifyItemTooltip.CosmicWorm") : "";
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("BlunderBooster"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip2")
                        {
                            tooltipLine.text = string.Format(Translation.KeyText("Calamity.ModifyItemTooltip.BlunderBooster"), CoreCalamityTranslation.PlaguePackHotKey);
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("GrandGelatin"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = Main.player[Main.myPlayer].autoJump ? 
                                Translation.KeyText("Calamity.ModifyItemTooltip.GrandGelatin.AutoJump") : 
                                Translation.KeyText("Calamity.ModifyItemTooltip.GrandGelatin");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("VitalJelly"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = Main.player[Main.myPlayer].autoJump ? 
                                Translation.KeyText("Calamity.ModifyItemTooltip.VitalJelly.AutoJump") : 
                                Translation.KeyText("Calamity.ModifyItemTooltip.VitalJelly");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("KnowledgeKingSlime"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip2")
                        {
                            tooltipLine.text = Main.player[Main.myPlayer].autoJump ? 
                                Translation.KeyText("Calamity.ModifyItemTooltip.KnowledgeKingSlime.AutoJump") : 
                                Translation.KeyText("Calamity.ModifyItemTooltip.KnowledgeKingSlime");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AbandonedSlimeStaff"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip4")
                        {
                            tooltipLine.text = Main.player[Main.myPlayer].autoJump ? 
                                Translation.KeyText("Calamity.ModifyItemTooltip.AbandonedSlimeStaff.AutoJump") : 
                                Translation.KeyText("Calamity.ModifyItemTooltip.AbandonedSlimeStaff");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AeroStone"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = Main.player[Main.myPlayer].autoJump ? 
                                Translation.KeyText("Calamity.ModifyItemTooltip.AeroStone.AutoJump") : 
                                Translation.KeyText("Calamity.ModifyItemTooltip.AeroStone");
                        }
                    }
                }
		            
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("SunkenStew"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip0")
                        {
                            tooltipLine.text = Main.player[Main.myPlayer].pStone ? 
                                Translation.KeyText("Calamity.ModifyItemTooltip.SunkenStew.pStone") : 
                                Translation.KeyText("Calamity.ModifyItemTooltip.SunkenStew");
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
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("CelestialTracers"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip10")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.CelestialTracers.DeathMode") : 
                                Translation.KeyText("Calamity.Item.CelestialTracers");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("ElysianTracers"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip9")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.ElysianTracers.DeathMode") : 
                                Translation.KeyText("Calamity.Item.ElysianTracers");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("ElysianWings"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip5")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.ElysianWings.DeathMode") : 
                                Translation.KeyText("Calamity.Item.ElysianWings");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("SoulofCryogen"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip8")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.SoulofCryogen.DeathMode") : 
                                Translation.KeyText("Calamity.Item.SoulofCryogen");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("Popo"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.Popo.DeathMode") : 
                                Translation.KeyText("Calamity.Item.Popo");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AmbrosialAmpoule"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip5")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.AmbrosialAmpoule.DeathMode") : 
                                Translation.KeyText("Calamity.Item.AmbrosialAmpoule");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AngelTreads"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip5")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.AngelTreads.DeathMode") : 
                                Translation.KeyText("Calamity.Item.AngelTreads");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("BlazingCore"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip5")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.BlazingCore.DeathMode") : 
                                Translation.KeyText("Calamity.Item.BlazingCore");
                        }
                    }
                }
					
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("FrigidBulwark"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip4")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.FrigidBulwark.DeathMode") : 
                                Translation.KeyText("Calamity.Item.FrigidBulwark");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("FrostBarrier"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.FrostBarrier.DeathMode") : 
                                Translation.KeyText("Calamity.Item.FrostBarrier");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("FrostFlare"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip5")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.FrostFlare.DeathMode") : 
                                Translation.KeyText("Calamity.Item.FrostFlare");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("InfinityBoots"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip9")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.InfinityBoots.DeathMode") : 
                                Translation.KeyText("Calamity.Item.InfinityBoots");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("PermafrostsConcoction"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip4")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.PermafrostsConcoction.DeathMode") : 
                                Translation.KeyText("Calamity.Item.PermafrostsConcoction");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("RampartofDeities"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip9")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.RampartofDeities.DeathMode") : "";
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("Sponge"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip12")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.Sponge.DeathMode") : 
                                Translation.KeyText("Calamity.Item.Sponge");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("TheAmalgam"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip8")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.TheAmalgam.DeathMode") : 
                                Translation.KeyText("Calamity.Item.TheAmalgam");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("TheCamper"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip5")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.TheCamper.DeathMode") : 
                                Translation.KeyText("Calamity.Item.TheAmalgam.DeathMode");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("VoidofExtinction"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip4")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.VoidofExtinction.DeathMode") : 
                                Translation.KeyText("Calamity.Item.VoidofExtinction");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("YharimsInsignia"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip6")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.YharimsInsignia.DeathMode") : 
                            Translation.KeyText("Calamity.Item.YharimsInsignia");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaHeadgear"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.AtaxiaHeadgear.DeathMode") : 
                            Translation.KeyText("Calamity.Item.AtaxiaHeadgear");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaHelm"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip3")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.AtaxiaHelm.DeathMode") : 
                                Translation.KeyText("Calamity.Item.AtaxiaHelm");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaHelmet"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip2")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.AtaxiaHelmet.DeathMode") : 
                                Translation.KeyText("Calamity.Item.AtaxiaHelmet");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaHood"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip2")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.AtaxiaHood.DeathMode") : 
                                Translation.KeyText("Calamity.Item.AtaxiaHood");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaMask"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.AtaxiaMask.DeathMode") : 
                                Translation.KeyText("Calamity.Item.AtaxiaMask");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaBodyArmor"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip4")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.AuricTeslaBodyArmor.DeathMode") : 
                                Translation.KeyText("Calamity.Item.AuricTeslaBodyArmor");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareHelm"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.BloodflareHelm.DeathMode") : 
                                Translation.KeyText("Calamity.Item.BloodflareHelm");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareHelmet"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.BloodflareHelmet.DeathMode") : 
                                Translation.KeyText("Calamity.Item.BloodflareHelmet");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareHornedHelm"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.BloodflareHornedHelm.DeathMode") : 
                                Translation.KeyText("Calamity.Item.BloodflareHornedHelm");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareHornedMask"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.BloodflareHornedMask.DeathMode") : 
                                Translation.KeyText("Calamity.Item.BloodflareHornedMask");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareMask"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.BloodflareMask.DeathMode") : 
                                Translation.KeyText("Calamity.Item.BloodflareMask");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonHelm"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip4")
                        {
                            tooltipLine.text = tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.TarragonHelm.DeathMode") : 
                                Translation.KeyText("Calamity.Item.TarragonHelm");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonHelmet"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip3")
                        {
                            tooltipLine.text = tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.TarragonHelmet.DeathMode") : 
                                Translation.KeyText("Calamity.Item.TarragonHelmet");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonHornedHelm"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip2")
                        {
                            tooltipLine.text = tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.TarragonHornedHelm.DeathMode") : 
                                Translation.KeyText("Calamity.Item.TarragonHornedHelm");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonMask"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip3")
                        {
                            tooltipLine.text = tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.TarragonMask.DeathMode") : 
                                Translation.KeyText("Calamity.Item.TarragonMask");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonVisage"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip3")
                        {
                            tooltipLine.text = tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.TarragonVisage.DeathMode") : 
                                Translation.KeyText("Calamity.Item.TarragonVisage");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("XerocMask"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip2")
                        {
                            tooltipLine.text = tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.XerocMask.DeathMode") : 
                                Translation.KeyText("Calamity.Item.XerocMask");
                        }
                    }
                }
                
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("PurifiedJam"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip0")
                        {
                            tooltipLine.text = CoreCalamityTranslation.DeathMode ?
                                Translation.KeyText("Calamity.Item.PurifiedJam.DeathMode") : 
                                Translation.KeyText("Calamity.Item.PurifiedJam");
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("ColdDivinity"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        tooltipLine.text = tooltipLine.text.Replace("Provides heat and cold protection in Death Mode when in use\nRevengeance Drop", Translation.KeyText("Calamity.Item.ColdDivinity"));
                    }
                }
            }
        }
    }
    
    public class VanillaItems : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (CoreCalamityTranslation.CalamityMod != null && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                if (item.type == ItemID.LavaWaders)
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "Tooltip1")
                        {
                            tooltipLine.text = tooltipLine.text.Replace("Provides heat protection in Death Mode", Translation.KeyText("Calamity.VanillaItem.LavaWaders.DeathMode"));
                        }
                    }
                }

                foreach (TooltipLine tooltipLine in tooltips)
                {
                    tooltipLine.text = tooltipLine.text.Replace("Current Charge", Translation.KeyText("Calamity.VanillaItem.CalamityTip.CurrentCharge"));
                }
					
                if (item.prefix > 0)
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "PrefixSSDmg")
                        {
                            tooltipLine.text = tooltipLine.text.Replace("stealth strike damage", Translation.KeyText("Calamity.VanillaItem.PrefixSSDmg"));
                        }
						
                        if (tooltipLine.Name == "PrefixStealthGenBoost")
                        {
                            tooltipLine.text = tooltipLine.text.Replace("stealth generation", Translation.KeyText("Calamity.VanillaItem.PrefixStealthGenBoost"));
                        }
                    }
                }

                if (item.accessory)
                {
                    if (item.prefix == 67 || item.prefix == 68)
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            if (tooltipLine.Name == "PrefixAccCritChance")
                            {
                                tooltipLine.text = tooltipLine.text.Replace("critical strike chance", Translation.KeyText("Calamity.VanillaItem.PrefixAccCritChance"));
                            }
                        }
                    }

                    if (item.prefix == 62 || item.prefix == 63 || item.prefix == 64 || item.prefix == 65)
                    {
                        foreach (TooltipLine tooltipLine2 in tooltips)
                        {
                            tooltipLine2.text = tooltipLine2.text.Replace("defense", Translation.KeyText("Calamity.VanillaItem.Defense"));
                        }

                        foreach (TooltipLine tooltipLine3 in tooltips)
                        {
                            if (tooltipLine3.Name == "PrefixAccDefense")
                            {
                                tooltipLine3.text = tooltipLine3.text.Replace("damage reduction", Translation.KeyText("Calamity.VanillaItem.PrefixAccDefense"));
                            }
                        }
                    }
                }

                TooltipLine line1 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Tooltip0");
                if (line1 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.WarmthPotion:
                            line1.text = CoreCalamityTranslation.DeathMode ? 
                                Language.GetTextValue("ItemTooltip.WarmthPotion") + string.Format(Translation.KeyText("Calamity.VanillaItem.WarmthPotion.DeathMode"), RussianDictionaries.CalamityBuffs["GlacialState"].Item1) : 
                                Language.GetTextValue("ItemTooltip.WarmthPotion") + string.Format(Translation.KeyText("Calamity.VanillaItem.WarmthPotion"), RussianDictionaries.CalamityBuffs["GlacialState"].Item1);
                            break;
                        case ItemID.ObsidianSkinPotion:
                            line1.text = CoreCalamityTranslation.DeathMode ? 
                                Translation.KeyText("Calamity.VanillaItem.ObsidianSkinPotion.DeathMode") : 
                                Translation.KeyText("Calamity.VanillaItem.ObsidianSkinPotion");
                            break;
                        case ItemID.ObsidianRose:
                            line1.text = CoreCalamityTranslation.DeathMode ? 
                                Translation.KeyText("Calamity.VanillaItem.ObsidianRose.DeathMode") : 
                                Translation.KeyText("Calamity.VanillaItem.ObsidianRose");
                            break;
                        case ItemID.MagmaStone:
                            line1.text = CoreCalamityTranslation.DeathMode ? 
                                Language.GetTextValue("ItemTooltip.MagmaStone") + Translation.KeyText("Calamity.VanillaItem.MagmaStone.DeathMode") : 
                                Language.GetTextValue("ItemTooltip.MagmaStone");
                            break;
                        case ItemID.LavaCharm:
                            line1.text = CoreCalamityTranslation.DeathMode ? 
                                Language.GetTextValue("ItemTooltip.LavaCharm") + Translation.KeyText("Calamity.VanillaItem.LavaCharm.DeathMode") : 
                                Language.GetTextValue("ItemTooltip.LavaCharm");
                            break;
                        case ItemID.HandWarmer:
                            line1.text = CoreCalamityTranslation.DeathMode ? 
                                Translation.KeyText("Calamity.VanillaItem.HandWarmer.DeathMode") : 
                                Translation.KeyText("Calamity.VanillaItem.HandWarmer");
                            break;
                        case ItemID.Picksaw:
                            line1.text = Translation.KeyText("Calamity.VanillaItem.Picksaw");
                            break;
                        case ItemID.FlaskofVenom:
                            line1.text = Translation.KeyText("Calamity.VanillaItem.FlaskofVenom");
                            break;
                        case ItemID.FlaskofCursedFlames:
                            line1.text = Translation.KeyText("Calamity.VanillaItem.FlaskofCursedFlames");
                            break;
                        case ItemID.FlaskofFire:
                            line1.text = Translation.KeyText("Calamity.VanillaItem.FlaskofFire");
                            break;
                        case ItemID.FlaskofGold:
                            line1.text = Translation.KeyText("Calamity.VanillaItem.FlaskofGold");
                            break;
                        case ItemID.FlaskofIchor:
                            line1.text = Translation.KeyText("Calamity.VanillaItem.FlaskofIchor");
                            break;
                        case ItemID.FlaskofNanites:
                            line1.text = Translation.KeyText("Calamity.VanillaItem.FlaskofNanites");
                            break;
                        case ItemID.FlaskofParty:
                            line1.text = Translation.KeyText("Calamity.VanillaItem.FlaskofParty");
                            break;
                        case ItemID.FlaskofPoison:
                            line1.text = Translation.KeyText("Calamity.VanillaItem.FlaskofPoison");
                            break;
                        case ItemID.MiningHelmet:
                            line1.text = Language.GetTextValue("ItemTooltip.MiningHelmet") + Translation.KeyText("Calamity.VanillaItem.MiningHelmet");
                            break;
                        case ItemID.RodofDiscord:
                            line1.text = Language.GetTextValue("ItemTooltip.RodofDiscord") + Translation.KeyText("Calamity.VanillaItem.RodofDiscord");
                            break;
                        case ItemID.SuperAbsorbantSponge:
                            line1.text = Language.GetTextValue("ItemTooltip.SuperAbsorbantSponge") + Translation.KeyText("Calamity.VanillaItem.SuperAbsorbantSponge");
                            break;
                        case ItemID.CrimsonHeart:
                            line1.text = Language.GetTextValue("ItemTooltip.CrimsonHeart") + Translation.KeyText("Calamity.VanillaItem.CrimsonHeart");
                            break;
                        case ItemID.ShadowOrb:
                            line1.text = Language.GetTextValue("ItemTooltip.ShadowOrb") + Translation.KeyText("Calamity.VanillaItem.ShadowOrb");
                            break;
                        case ItemID.MagicLantern:
                            line1.text = Language.GetTextValue("ItemTooltip.MagicLantern") + Translation.KeyText("Calamity.VanillaItem.MagicLantern");
                            break;
                        case ItemID.JellyfishNecklace:
                            line1.text = Language.GetTextValue("ItemTooltip.JellyfishNecklace") + Translation.KeyText("Calamity.VanillaItem.JellyfishNecklace");
                            break;
                        case ItemID.FairyBell:
                            line1.text = Language.GetTextValue("ItemTooltip.FairyBell") + Translation.KeyText("Calamity.VanillaItem.FairyBell");
                            break;
                        case ItemID.DD2PetGhost:
                            line1.text = Language.GetTextValue("ItemTooltip.DD2PetGhost") + Translation.KeyText("Calamity.VanillaItem.DD2PetGhost");
                            break;
                        case ItemID.WispinaBottle:
                            line1.text = Language.GetTextValue("ItemTooltip.WispinaBottle") + Translation.KeyText("Calamity.VanillaItem.WispinaBottle");
                            break;
                        case ItemID.DivingHelmet:
                            line1.text = Language.GetTextValue("ItemTooltip.DivingHelmet") + Translation.KeyText("Calamity.VanillaItem.DivingHelmet");
                            break;
                        case ItemID.NeptunesShell:
                            line1.text = Language.GetTextValue("ItemTooltip.NeptunesShell") + Translation.KeyText("Calamity.VanillaItem.NeptunesShell");
                            break;
                        case ItemID.MoonShell:
                            line1.text = Language.GetTextValue("ItemTooltip.MoonShell") + Translation.KeyText("Calamity.VanillaItem.MoonShell");
                            break;
                        case ItemID.WormScarf:
                            line1.text = Translation.KeyText("Calamity.VanillaItem.WormScarf");
                            break;
                        case ItemID.TitanGlove:
                            line1.text = Language.GetTextValue("ItemTooltip.TitanGlove") + Translation.KeyText("Calamity.VanillaItem.TitanGlove");
                            break;
                        case ItemID.SpectreHood:
                            line1.text = Translation.KeyText("Calamity.VanillaItem.SpectreHood");
                            break;
                        case ItemID.MagicQuiver:
                            line1.text = Translation.KeyText("Calamity.VanillaItem.MagicQuiver");
                            break;
                        case ItemID.InvisibilityPotion:
                            line1.text = Language.GetTextValue("ItemTooltip.InvisibilityPotion") + Translation.KeyText("Calamity.VanillaItem.InvisibilityPotion");
                            break;
                    }
                }

                TooltipLine line2 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Defense");
                if (line2 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.EmptyBucket:
                            line2.text = Translation.KeyText("Calamity.VanillaItem.EmptyBucket");
                            break;
                        case ItemID.GladiatorHelmet:
                            line2.text = Translation.KeyText("Calamity.VanillaItem.GladiatorHelmet");
                            break;
                        case ItemID.GladiatorBreastplate:
                            line2.text = Translation.KeyText("Calamity.VanillaItem.GladiatorBreastplate");
                            break;
                        case ItemID.GladiatorLeggings:
                            line2.text = Translation.KeyText("Calamity.VanillaItem.GladiatorLeggings");
                            break;
                        case ItemID.ObsidianHelm:
                            line2.text = Translation.KeyText("Calamity.VanillaItem.ObsidianHelm");
                            break;
                        case ItemID.ObsidianShirt:
                            line2.text = Translation.KeyText("Calamity.VanillaItem.ObsidianShirt");
                            break;
                        case ItemID.ObsidianPants:
                            line2.text = Translation.KeyText("Calamity.VanillaItem.ObsidianPants");
                            break;
                    }
                }

                TooltipLine line3 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Tooltip1");
                if (line3 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.FireGauntlet:
                            line3.text = CoreCalamityTranslation.DeathMode ? 
                                Translation.KeyText("Calamity.VanillaItem.FireGauntlet.DeathMode") : 
                                Translation.KeyText("Calamity.VanillaItem.FireGauntlet");
                            break;
                        case ItemID.JellyfishDivingGear:
                            line3.text = Translation.KeyText("Calamity.VanillaItem.JellyfishDivingGear");
                            break;
                        case ItemID.ArcticDivingGear:
                            line3.text = Translation.KeyText("Calamity.VanillaItem.ArcticDivingGear");
                            break;
                        case ItemID.SuspiciousLookingTentacle:
                            line3.text = Translation.KeyText("Calamity.VanillaItem.SuspiciousLookingTentacle");
                            break;
                        case ItemID.CelestialShell:
                            line3.text = Translation.KeyText("Calamity.VanillaItem.CelestialShell");
                            break;
                        case ItemID.PowerGlove:
                            line3.text = Translation.KeyText("Calamity.VanillaItem.PowerGlove");
                            break;
                        case ItemID.MechanicalGlove:
                            line3.text = Translation.KeyText("Calamity.VanillaItem.MechanicalGlove");
                            break;
                    }
                }

                TooltipLine line4 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "BuffTime");
                if (line4 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.ShinePotion:
                            line4.text = Translation.KeyText("Calamity.VanillaItem.ShinePotion");
                            break;
                        case ItemID.GillsPotion:
                            line4.text = Translation.KeyText("Calamity.VanillaItem.GillsPotion");
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
                            line5.text = Translation.KeyText("Calamity.VanillaItem.SetBonus.Meteor");
                            break;
                        case ItemID.CopperGreaves:
                        case ItemID.CopperChainmail:
                        case ItemID.CopperHelmet:
                            line5.text = Translation.KeyText("Calamity.VanillaItem.SetBonus.Copper");
                            break;
                        case ItemID.TinHelmet:
                        case ItemID.TinChainmail:
                        case ItemID.TinGreaves:
                            line5.text = Translation.KeyText("Calamity.VanillaItem.SetBonus.Tin");
                            break;
                        case ItemID.IronGreaves:
                        case ItemID.IronChainmail:
                        case ItemID.IronHelmet:
                        case ItemID.AncientIronHelmet:
                            line5.text = Translation.KeyText("Calamity.VanillaItem.SetBonus.Iron");
                            break;
                        case ItemID.LeadHelmet:
                        case ItemID.LeadChainmail:
                        case ItemID.LeadGreaves:
                            line5.text = Translation.KeyText("Calamity.VanillaItem.SetBonus.Lead");
                            break;
                        case ItemID.SilverGreaves:
                        case ItemID.SilverChainmail:
                        case ItemID.SilverHelmet:
                            line5.text = Translation.KeyText("Calamity.VanillaItem.SetBonus.Silver");
                            break;
                        case ItemID.TungstenHelmet:
                        case ItemID.TungstenChainmail:
                        case ItemID.TungstenGreaves:
                            line5.text = Translation.KeyText("Calamity.VanillaItem.SetBonus.Tungsten");
                            break;
                        case ItemID.GoldGreaves:
                        case ItemID.GoldChainmail:
                        case ItemID.GoldHelmet:
                        case ItemID.AncientGoldHelmet:
                            line5.text = Translation.KeyText("Calamity.VanillaItem.SetBonus.Gold");
                            break;
                        case ItemID.PlatinumHelmet:
                        case ItemID.PlatinumChainmail:
                        case ItemID.PlatinumGreaves:
                            line5.text = Translation.KeyText("Calamity.VanillaItem.SetBonus.Platinum");
                            break;
                        case ItemID.MoltenHelmet:
                        case ItemID.MoltenBreastplate:
                        case ItemID.MoltenGreaves:
                            line5.text = CoreCalamityTranslation.DeathMode ? 
                                Translation.KeyText("Calamity.VanillaItem.SetBonus.Molten.DeathMode") : 
                                Translation.KeyText("Calamity.VanillaItem.SetBonus.Molten");
                            break;
                        case ItemID.FrostHelmet:
                        case ItemID.FrostBreastplate:
                        case ItemID.FrostLeggings:
                            line5.text = CoreCalamityTranslation.DeathMode ? 
                                string.Format(Translation.KeyText("Calamity.ModifyItemTooltip.SetBonus.Frost.DeathMode"), Language.GetTextValue("ArmorSetBonus.Frost")) : 
                                string.Format(Translation.KeyText("Calamity.ModifyItemTooltip.SetBonus.Frost"), Language.GetTextValue("ArmorSetBonus.Frost"));
                            break;
                    }
                }

                TooltipLine line6 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Equipable");
                if (line6 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.GrapplingHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.GrapplingHook");
                            break;
                        case ItemID.AmethystHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.AmethystHook");
                            break;
                        case ItemID.TopazHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.TopazHook");
                            break;
                        case ItemID.SapphireHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.SapphireHook");
                            break;
                        case ItemID.EmeraldHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.EmeraldHook");
                            break;
                        case ItemID.RubyHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.RubyHook");
                            break;
                        case ItemID.DiamondHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.DiamondHook");
                            break;
                        case ItemID.WebSlinger:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.WebSlinger");
                            break;
                        case ItemID.SkeletronHand:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.SkeletronHand");
                            break;
                        case ItemID.SlimeHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.SlimeHook");
                            break;
                        case ItemID.FishHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.FishHook");
                            break;
                        case ItemID.IvyWhip:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.IvyWhip");
                            break;
                        case ItemID.BatHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.BatHook");
                            break;
                        case ItemID.CandyCaneHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.CandyCaneHook");
                            break;
                        case ItemID.DualHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.DualHook");
                            break;
                        case ItemID.TendonHook:
                        case ItemID.ThornHook:
                        case ItemID.IlluminantHook:
                        case ItemID.WormHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.HookMix");
                            break;
                        case ItemID.AntiGravityHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.AntiGravityHook");
                            break;
                        case ItemID.SpookyHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.SpookyHook");
                            break;
                        case ItemID.ChristmasHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.ChristmasHook");
                            break;
                        case ItemID.LunarHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.LunarHook");
                            break;
                        case ItemID.StaticHook:
                            line6.text = Translation.KeyText("Calamity.VanillaItem.StaticHook");
                            break;
                    }
                }

                TooltipLine line7 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "NeedsBait");
                if (line7 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.GoldenFishingRod:
                            line7.text = Translation.KeyText("Calamity.VanillaItem.GoldenFishingRod");
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
                            line8.text = Translation.KeyText("Calamity.VanillaItem.PicaxeMix");
                            break;
                    }
                }

                TooltipLine line9 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "HealLife");
                if (line9 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.BottledHoney:
                            line9.text = Translation.KeyText("Calamity.VanillaItem.BottledHoney");
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
            if (CoreCalamityTranslation.CalamityMod != null && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                TooltipLine line1 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Tooltip0");
                if (line1 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.ButterflyWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.ButterflyWings");
                            break;
                        case ItemID.DemonWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.DemonWings");
                            break;
                        case ItemID.AngelWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.AngelWings");
                            break;
                        case ItemID.BeeWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.BeeWings");
                            break;
                        case ItemID.FairyWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.FairyWings");
                            break;
                        case ItemID.HarpyWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.HarpyWings");
                            break;
                        case ItemID.BoneWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.BoneWings");
                            break;
                        case ItemID.FlameWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.FlameWings");
                            break;
                        case ItemID.FrozenWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.FrozenWings");
                            break;
                        case ItemID.GhostWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.GhostWings");
                            break;
                        case ItemID.SteampunkWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.SteampunkWings");
                            break;
                        case ItemID.BatWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.BatWings");
                            break;
                        case ItemID.TatteredFairyWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.TatteredFairyWings");
                            break;
                        case ItemID.SpookyWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.SpookyWings");
                            break;
                        case ItemID.FestiveWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.FestiveWings");
                            break;
                        case ItemID.BeetleWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.BeetleWings");
                            break;
                        case ItemID.FinWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.FinWings");
                            break;
                        case ItemID.FishronWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.FishronWings");
                            break;
                        case ItemID.MothronWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.MothronWings");
                            break;
                        case ItemID.WingsSolar:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.WingsSolar");
                            break;
                        case ItemID.WingsVortex:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.WingsVortex");
                            break;
                        case ItemID.WingsStardust:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.WingsStardust");
                            break;
                        case ItemID.LeafWings:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.LeafWings");
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
                            line1.text = Translation.KeyText("Calamity.VanillaWings.Mix");
                            break;
                        case ItemID.WingsNebula:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.WingsNebula");
                            break;
                        case ItemID.Jetpack:
                            line1.text = Translation.KeyText("Calamity.VanillaWings.Jetpack");
                            break;
                    }
                }

                TooltipLine line2 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Tooltip1");
                if (line2 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.Hoverboard:
                            line2.text = Translation.KeyText("Calamity.VanillaWings.Hoverboard");
                            break;
                    }
                }

                TooltipLine line3 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Equipable");
                if (line3 != null)
                {
                    switch (item.type)
                    {
                        case ItemID.BetsyWings:
                            line3.text = Translation.KeyText("Calamity.VanillaWings.BetsyWings");
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
            if (CoreCalamityTranslation.CalamityMod != null && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("StatMeter"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (Translation.IsRussianLanguage)
                        {
                            foreach (var translation in RussianDictionaries.CalamityStatMeter)
                            {
                                tooltipLine.text = tooltipLine.text.Replace(translation.Key, translation.Value);
                            }
                        }
                    }
                }

                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("MeleeLevelMeter"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (Translation.IsRussianLanguage)
                        {
                            foreach (var translation in RussianDictionaries.CalamityMeleeLevelMeter)
                            {
                                tooltipLine.text = tooltipLine.text.Replace(translation.Key, translation.Value);
                            }
                        }
                    }
                }
					
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("MagicLevelMeter"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (Translation.IsRussianLanguage)
                        {
                            foreach (var translation in RussianDictionaries.CalamityMagicLevelMeter)
                            {
                                tooltipLine.text = tooltipLine.text.Replace(translation.Key, translation.Value);
                            }
                        }
                    }
                }
					
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("RangedLevelMeter"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (Translation.IsRussianLanguage)
                        {
                            foreach (var translation in RussianDictionaries.CalamityRangedLevelMeter)
                            {
                                tooltipLine.text = tooltipLine.text.Replace(translation.Key, translation.Value);
                            }
                        }
                    }
                }
					
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("RogueLevelMeter"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (Translation.IsRussianLanguage)
                        {
                            foreach (var translation in RussianDictionaries.CalamityRogueLevelMeter)
                            {
                                tooltipLine.text = tooltipLine.text.Replace(translation.Key, translation.Value);
                            }
                        }
                    }
                }
					
                if (item.type == CoreCalamityTranslation.CalamityMod.ItemType("SummonLevelMeter"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (Translation.IsRussianLanguage)
                        {
                            foreach (var translation in RussianDictionaries.CalamitySummonLevelMeter)
                            {
                                tooltipLine.text = tooltipLine.text.Replace(translation.Key, translation.Value);
                            }
                        }
                    }
                }
            }
        }
    }
}