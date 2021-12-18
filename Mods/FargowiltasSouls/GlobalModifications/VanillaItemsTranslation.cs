using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.GlobalModifications
{
    public class VanillaItemsTranslation : FargoSoulsGlobalItemBase
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.RodofDiscord)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.RodofDiscord");
                });
            }
            else if (item.type == ItemID.ArcheryPotion || item.type == ItemID.MagicQuiver ||
                     item.type == ItemID.ShroomiteHelmet || item.type == ItemID.ShroomiteHeadgear ||
                     item.type == ItemID.ShroomiteMask)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.ComboItems");
                });
            }
            else if (item.type == ItemID.CrystalBullet || item.type == ItemID.HolyArrow)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.CrystalBullet.HolyArrow");
                });
            }
            else if (item.type == ItemID.ChlorophyteBullet)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.ChlorophyteBullet");
                });
            }
            else if (item.type == ItemID.WaterBolt && !NPC.downedBoss3)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.WaterBolt");
                });
            }
            else if (item.type >= ItemID.TitaniumMask && item.type <= ItemID.TitaniumLeggings)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.TitaniumPieces");
                });
            }
            else if (item.type == ItemID.StardustCellStaff)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.StardustCellStaff");
                });
            }
            else if (item.type == ItemID.DD2BetsyBow || item.type == ItemID.Uzi || item.type == ItemID.PhoenixBlaster ||
                     item.type == ItemID.LastPrism || item.type == ItemID.OnyxBlaster || item.type == ItemID.SkyFracture ||
                     item.type == ItemID.Handgun || item.type == ItemID.SpikyBall || item.type == ItemID.SDMG ||
                     item.type == ItemID.Xenopopper || item.type == ItemID.NebulaArcanum || item.type == ItemID.PainterPaintballGun ||
                     item.type == ItemID.MoltenFury || item.type == ItemID.Phantasm)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.ComboItems2");
                });
            }
            else if (item.type == ItemID.SkyFracture || item.type == ItemID.SnowmanCannon)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.SkyFracture");
                });
            }
            else if (item.type == ItemID.Tsunami || item.type == ItemID.Flairon || item.type == ItemID.ChlorophyteShotbow ||
                     item.type == ItemID.HellwingBow || item.type == ItemID.DartPistol || item.type == ItemID.DartRifle ||
                     item.type == ItemID.Megashark || item.type == ItemID.BatScepter || item.type == ItemID.ChainGun ||
                     item.type == ItemID.VortexBeater || item.type == ItemID.SnowmanCannon || item.type == ItemID.RavenStaff ||
                     item.type == ItemID.XenoStaff || item.type == ItemID.StardustDragonStaff)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.ComboItems4");
                });
            }
            else if (item.type == ItemID.StarCannon || item.type == ItemID.ElectrosphereLauncher || item.type == ItemID.BeesKnees ||
                     item.type == ItemID.DaedalusStormbow || item.type == ItemID.LaserMachinegun)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.ComboItems3");
                });
            }
            else if (item.type == ItemID.Beenade || item.type == ItemID.Razorpine)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.ComboItems6.masoNerf");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.ComboItems6.masoNerf2");
                });
            }
            else if (item.type == ItemID.BeeGun || item.type == ItemID.Grenade || item.type == ItemID.StickyGrenade ||
                     item.type == ItemID.BouncyGrenade)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.ComboItems10");
                });
            }
            else if (item.type == ItemID.DD2BallistraTowerT1Popper || item.type == ItemID.DD2BallistraTowerT2Popper ||
                     item.type == ItemID.DD2BallistraTowerT3Popper || item.type == ItemID.DD2ExplosiveTrapT1Popper ||
                     item.type == ItemID.DD2ExplosiveTrapT2Popper || item.type == ItemID.DD2ExplosiveTrapT3Popper ||
                     item.type == ItemID.DD2FlameburstTowerT1Popper || item.type == ItemID.DD2FlameburstTowerT2Popper ||
                     item.type == ItemID.DD2FlameburstTowerT3Popper || item.type == ItemID.DD2LightningAuraT1Popper ||
                     item.type == ItemID.DD2LightningAuraT2Popper || item.type == ItemID.DD2LightningAuraT3Popper)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.ComboItems7");
                });
            }
            else if (item.type == ItemID.SpiderStaff || item.type == ItemID.OpticStaff || item.type == ItemID.DeadlySphereStaff)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoBuff", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.ComboItems8");
                });
            }
            else if (item.type == ItemID.SpectreHood)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.SpectreHood");
                });
            }
            else if (item.type == ItemID.FrozenTurtleShell)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.FrozenTurtleShell");
                });
            }
            else if (item.type == ItemID.VampireKnives)
            {
                ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Name == "masoNerf" && l.text == "[c/ff0000:Eternity Mode:] Reduced damage by 25%", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.VampireKnives");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.VampireKnives2");
                });
                ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Name== "masoNerf" && l.text == "[c/ff0000:Eternity Mode:] Reduced attack speed by 25%", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.VampireKnives3");
                });
            }
            else if (item.type == ItemID.BlizzardStaff || item.type == ItemID.Razorpine)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.ComboItems5.masoNerf");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "masoNerf2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.ComboItems5.masoNerf2");
                });
            }
            else if (item.type == ItemID.DemonScythe)
            {
                if (NPC.downedBoss2)
                {
                    ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                    {
                        tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.DemonScythe2");
                    });
                }
                else
                {
                    ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                    {
                        tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.DemonScythe");
                    });
                    ItemHelper.TranslateTooltip(item, tooltips, "masoNerf2", tooltip =>
                    {
                        tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.DemonScythe3");
                    });
                }
            }
            else if (item.type == ItemID.SpaceGun)
            {
                if (NPC.downedBoss2)
                {
                    ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                    {
                        tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.SpaceGun");
                    });
                }
                else
                {
                    ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Name == "masoNerf" && l.text == "[c/ff0000:Eternity Mode:] Reduced damage by 25% until an evil boss is defeated", tooltip =>
                    {
                        tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.SpaceGun2");
                    });
                    ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Name == "masoNerf" && l.text == "[c/ff0000:Eternity Mode:] Reduced attack speed by 25% until an evil boss is defeated", tooltip =>
                    {
                        tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.SpaceGun3");
                    });
                }
            }
            else if (item.type == ItemID.DD2SquireBetsySword)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoBuff", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.DD2SquireBetsySword");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "masoBuff2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.DD2SquireBetsySword2");
                });
            }
            else if (item.type == ItemID.MonkStaffT3)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoBuff", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.MonkStaffT3");
                });
            }
            else if (item.type == ItemID.SlimeStaff)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoBuff", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.SlimeStaff");
                });
            }
            else if (item.type == ItemID.MonkAltHead || item.type == ItemID.MonkAltPants || item.type == ItemID.MonkAltShirt ||
                     item.type == ItemID.MonkBrows || item.type == ItemID.MonkPants || item.type == ItemID.MonkShirt ||
                     item.type == ItemID.SquireAltHead || item.type == ItemID.SquireAltPants || item.type == ItemID.SquireAltShirt ||
                     item.type == ItemID.SquireGreatHelm || item.type == ItemID.SquireGreaves || item.type == ItemID.SquirePlating ||
                     item.type == ItemID.HuntressAltHead || item.type == ItemID.HuntressAltPants || item.type == ItemID.HuntressAltShirt ||
                     item.type == ItemID.HuntressJerkin || item.type == ItemID.HuntressPants || item.type == ItemID.HuntressWig ||
                     item.type == ItemID.ApprenticeAltHead || item.type == ItemID.ApprenticeAltPants || item.type == ItemID.ApprenticeAltShirt ||
                     item.type == ItemID.ApprenticeHat || item.type == ItemID.ApprenticeRobe || item.type == ItemID.ApprenticeTrousers ||
                     item.type == ItemID.AncientBattleArmorHat || item.type == ItemID.AncientBattleArmorPants || item.type == ItemID.AncientBattleArmorShirt)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoBuff", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.ComboItems9");
                });
            }
            if (item.ammo != AmmoID.None && item.damage > 0)
            {
                if (item.ammo == AmmoID.Arrow || item.ammo == AmmoID.Bullet || item.ammo == AmmoID.Dart)
                {
                    ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                    {
                        tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.Ammos");
                    });
                }
                else if (!(item.type >= ItemID.CopperCoin && item.type <= ItemID.PlatinumCoin))
                {
                    ItemHelper.TranslateTooltip(item, tooltips, "masoNerf", tooltip =>
                    {
                        tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.Rockets");
                    });
                }
            }

            if (item.summon)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "masoMinionNerf", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.VanillaItem.SummonItems");
                });
            }

            ItemHelper.TranslateTooltip(item, tooltips, "help", tooltip =>
            {
                tooltip.text = LangHelper.GetTextValue("FargoSouls.TooltipName.Help");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "FargowiltasSouls:Eternity", tooltip =>
            {
                tooltip.text = LangHelper.GetTextValue("FargoSouls.TooltipName.Eternity");
            });
        }
    }
}