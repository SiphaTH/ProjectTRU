using System.Collections.Generic;
using System.Linq;
using CalamityMod.Items;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.DifficultyItems;
using CalamityMod.Items.Mounts;
using CalamityMod.Items.Placeables.Furniture.Fountains;
using CalamityMod.Items.Potions;
using CalamityMod.Items.SummonItems;
using CalamityMod.Items.Weapons.Magic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications
{
    public class SpecificItemsTooltipTranslation : CalamityGlobalItemBase
    {
        // Удаляет SetNameOverride со ВСЕХ предметов в игре включая модовые. Влияет на производительность. С ней убирается IL перевода фурнитуры.
        //!TODO: Найти способ сделать условие которое удаляет SetNameOverride только в ModItem в Каламити
        public override void SetDefaults(Item item)
         {
             item.ClearNameOverride();
         }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ModContent.ItemType<AsgardianAegis>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.AsgardianAegis.Tooltip5", ModsCall.AegisHotKey);
                });
            }
            else if (item.type == ModContent.ItemType<AstralArcanum>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip7", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.AstralArcanum.Tooltip7", ModsCall.AstralArcanumUiHotkey);
                });

            }
            else if (item.type == ModContent.ItemType<CelestialJewel>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.CelestialJewel.Tooltip2", ModsCall.AstralArcanumUiHotkey);
                });
            }
            else if (item.type == ModContent.ItemType<ElysianAegis>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.ElysianAegis.Tooltip5", ModsCall.AegisHotKey);
                });
            }
            else if (item.type == ModContent.ItemType<MomentumCapacitor>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.MomentumCapacitor.Tooltip0",
                        ModsCall.MomentumCapacitatorHotkey);
                });
            }
            else if (item.type == ModContent.ItemType<Nanotech>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip7", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.Nanotech.Tooltip7",
                        tooltip.text.Split(' ')[3]);
                });
            }
            else if (item.type == ModContent.ItemType<RaidersTalisman>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.RaidersTalisman.Tooltip3",
                        tooltip.text.Split(' ')[3]);
                });
            }
            else if (item.type == ModContent.ItemType<ProfanedSoulCrystal>())
            {
                ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Name == "Tooltip1" && l.text == "[c/f05a5a:The soul within this crystal has been defiled by overwhelming energy waves from dangerous mechanations]\nMerchants will reject a defiled soul such as this.", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.ProfanedSoulCrystal.Tooltip1_2");
                });
                ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Name == "Tooltip1" && l.text == "[c/f05a5a:The soul within this crystal has been defiled by the powerful magic of a supreme witch]\nMerchants will reject a defiled soul such as this.", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.ProfanedSoulCrystal.Tooltip1");
                });

                if (ModsCall.ProfanedCrystalBuffs)
                {
                    ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                    {
                        tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.ProfanedSoulCrystal.Tooltip5",
                            tooltip.text.Split(' ')[9]);
                    });
                }
            }
            else if (item.type == ModContent.ItemType<SandCloak>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.SandCloak.Tooltip1", ModsCall.SandCloakHotkey);
                });
            }
            else if (item.type == ModContent.ItemType<SpectralVeil>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.SpectralVeil.Tooltip1", ModsCall.SpectralVeilHotKey);
                });
            }
            else if (item.type == ModContent.ItemType<NormalityRelocator>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.NormalityRelocator.Tooltip1",
                        ModsCall.NormalityRelocatorHotKey);
                });
            }
            else if (item.type == ModContent.ItemType<Eternity>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.Eternity.Tooltip1", ModsCall.EternityDiscoHex);
                });
            }
            else if (item.type == ModContent.ItemType<PlaguedFuelPack>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.PlaguedFuelPack.Tooltip2", ModsCall.PlaguePackHotKey);
                });
            }
            else if (item.type == ModContent.ItemType<Revenge>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.Revenge.Tooltip1", ModsCall.RageHotKey);
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.Revenge.Tooltip3", ModsCall.AdrenalineHotKey);
                });
            }
            else if (item.type == ModContent.ItemType<CosmicWorm>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.CosmicWorm.Tooltip1");
                });
            }
            else if (item.type == ModContent.ItemType<BlunderBooster>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.BlunderBooster.Tooltip3", ModsCall.PlaguePackHotKey);
                });
            }
            else if (item.type == ModContent.ItemType<SunkenStew>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.SunkenStew.Tooltip0",
                        Main.player[Main.myPlayer].pStone ? 37 : 50);
                });
            }
            else if (item.type == ModContent.ItemType<AngelicAlliance>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.AngelicAlliance.Tooltip4", ModsCall.AngelicAllianceHotKey);
                });
            }
            else if (item.type == ModContent.ItemType<ExoThrone>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.ExoThrone.Tooltip1",
                        ModsCall.ExoChairSpeedupHotkey);
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.ExoThrone.Tooltip2",
                        ModsCall.ExoChairSlowdownHotkey);
                });
            }
            else if (item.type == ModContent.ItemType<ShatteredCommunity>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip6", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.ShatteredCommunity.Tooltip6",
                        tooltip.text.Split(' ')[2], tooltip.text.Split(' ')[3]);
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip7", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.ShatteredCommunity.Tooltip7",
                        tooltip.text.Split(' ')[4]);
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip8", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.ShatteredCommunity.Tooltip8",
                        tooltip.text.Split(' ')[4]);
                });
            }

            ItemHelper.TranslateTooltip(item, tooltips, "SchematicKnowledge1", tooltip =>
            {
                tooltip.text = LangHelper.GetTextValue("Calamity.TooltipName.SchematicKnowledge1");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "SchematicKnowledge2", tooltip =>
            {
                tooltip.text = LangHelper.GetTextValue("Calamity.TooltipName.SchematicKnowledge2");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "FireWeapon", tooltip =>
            {
                tooltip.text = LangHelper.GetTextValue("Calamity.TooltipName.FireWeapon");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "IceWeapon", tooltip =>
            {
                tooltip.text = LangHelper.GetTextValue("Calamity.TooltipName.IceWeapon");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "NatureWeapon", tooltip =>
            {
                tooltip.text = LangHelper.GetTextValue("Calamity.TooltipName.NatureWeapon");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "PointBlankShot", tooltip =>
            {
                tooltip.text = LangHelper.GetTextValue("Calamity.TooltipName.PointBlankShot");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityCharge", tooltip =>
            {
                tooltip.text = LangHelper.GetTextValue("Calamity.TooltipName.CalamityCharge", tooltip.text.Split(' ')[2]);
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityDonor", tooltip =>
            {
                tooltip.text = LangHelper.GetTextValue("Calamity.TooltipName.CalamityDonor");
                tooltip.overrideColor = new Color(139, 0, 0);
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityDev", tooltip =>
            {
                tooltip.text = LangHelper.GetTextValue("Calamity.TooltipName.CalamityDev");
                tooltip.overrideColor = new Color(255, 0, 255);
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityChallengeDrop", tooltip =>
            {
                if (tooltip.text == "- Legendary Challenge Drop -")
                    tooltip.text = LangHelper.GetTextValue("Calamity.TooltipName.LegendaryChallengeDrop");

                else if (tooltip.text == "- Challenge Drop -")
                    tooltip.text = LangHelper.GetTextValue("Calamity.TooltipName.ChallengeDrop");
            });

             if (ModsCall.Fargo != null)
             {
                 if (item.type == ModContent.ItemType<SunkenSeaFountain>())
                 {
                     ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                     {
                         tooltip.text = LangHelper.GetTextValue("Calamity.ModifyItemTooltip.SunkenSeaFountain");
                     });
                 }
                 else if (item.type == ModContent.ItemType<SulphurousFountainItem>())
                 {
                     ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                     {
                         tooltip.text = LangHelper.GetTextValue("Calamity.ModifyItemTooltip.SulphurousFountainItem");
                     });
                 }
                 else if (item.type == ModContent.ItemType<AstralFountainItem>())
                 {
                     ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                     {
                         tooltip.text = LangHelper.GetTextValue("Calamity.ModifyItemTooltip.AstralFountainItem");
                     });
                 }
             }
        }
    }
}