using System.Collections.Generic;
using CalamityMod.CalPlayer;
using CalamityMod.CustomRecipes;
using CalamityMod.Items;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Accessories.Wings;
using CalamityMod.Items.DraedonMisc;
using CalamityMod.Items.Mounts;
using CalamityMod.Items.PermanentBoosters;
using CalamityMod.Items.Placeables.Furniture.Fountains;
using CalamityMod.Items.Potions;
using CalamityMod.Items.SummonItems;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Items.Weapons.Melee;
using CalamityMod.Items.Weapons.Ranged;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications;

public class SpecificItemsTooltipTranslation : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    }

     public override void SetDefaults(Item item)
     {
         if (item.ModItem?.Mod == ModsCall.Calamity)
         {
             item.ClearNameOverride();
         }
     }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        CalamityGlobalItem calamityGlobalItem = item.GetGlobalItem<CalamityGlobalItem>();
        CalamityPlayer calamityPlayer = Main.LocalPlayer.GetModPlayer<CalamityPlayer>();

        if (calamityGlobalItem.canFirePointBlankShots)
        {
            int pointBlankShotIndex = tooltips.FindLastIndex(x => x.Mod.Equals("CalamityMod") && x.Name.Equals("PointBlankShot"));
            int tooltipIndex = tooltips.FindLastIndex(x => x.Mod.Equals("Terraria") && x.Name.StartsWith("Tooltip"));
            int knockbackIndex = tooltips.FindLastIndex(x => x.Mod.Equals("Terraria") && x.Name.StartsWith("Knockback"));
            if (pointBlankShotIndex != -1)
            {
                tooltips.RemoveAt(pointBlankShotIndex);
            }
            if (tooltipIndex != -1)
            {
                tooltips.Insert(++tooltipIndex, new TooltipLine(ModsCall.Calamity, "PointBlankShot", LangHelper.GetTextValue("CalamityMod.Items.TooltipTags.PointBlankShot")));
            }
            else
            {
                tooltips.Insert(++knockbackIndex, new TooltipLine(ModsCall.Calamity, "PointBlankShot", LangHelper.GetTextValue("CalamityMod.Items.TooltipTags.PointBlankShot")));
            }
        }

        if (item.type == ModContent.ItemType<AsgardianAegis>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.AsgardianAegis.Tooltip.5", ModsCall.AegisHotKey);
            });
        }
        else if (item.type == ModContent.ItemType<AstralArcanum>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.AstralArcanum.Tooltip.3", ModsCall.AstralArcanumUiHotkey);
            });
        
        }
        else if (item.type == ModContent.ItemType<CelestialJewel>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.CelestialJewel.Tooltip.2", ModsCall.AstralTeleportHotKey);
            });
        }
        else if (item.type == ModContent.ItemType<ElysianAegis>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ElysianAegis.Tooltip.5", ModsCall.AegisHotKey);
            });
        }
        else if (item.type == ModContent.ItemType<ProfanedSoulCrystal>())
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Name == "Tooltip1" && l.Text == "The soul within this crystal has been defiled by overwhelming energy waves from dangerous mechanations", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ProfanedSoulCrystal.Tooltip.NoDownedCondition.1");
            });
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Name == "Tooltip1" && l.Text == "The soul within this crystal has been defiled by the powerful magic of a supreme witch", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ProfanedSoulCrystal.Tooltip.NoDownedCondition.2");
            });
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Name == "Tooltip1" && l.Text == "Requires 10 minion slots to use in order to grant the following effects\nAll non-summon weapons are converted into powerful summon variations\nFalling below 50% life will empower these attacks", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ProfanedSoulCrystal.Tooltip.1");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RejectLine", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ProfanedSoulCrystal.Tooltip.RejectLine");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:MeleeAttack", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ProfanedSoulCrystal.Tooltip.MeleeAttack");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:MageAttack", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ProfanedSoulCrystal.Tooltip.MageAttack", (int)(100f * Main.player[Main.myPlayer].manaCost));
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RangedAttack", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ProfanedSoulCrystal.Tooltip.RangedAttack");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RogueAttack", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ProfanedSoulCrystal.Tooltip.RogueAttack");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RemainingTip", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ProfanedSoulCrystal.Tooltip.RemainingTip");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:PurityTip", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ProfanedSoulCrystal.Tooltip.PurityTip");
            });
        }
        else if (item.type == ModContent.ItemType<SandCloak>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SandCloak.Tooltip.1", ModsCall.SandCloakHotkey);
            });
        }
        else if (item.type == ModContent.ItemType<SpectralVeil>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SpectralVeil.Tooltip.1", ModsCall.SpectralVeilHotKey);
            });
        }
        if (item.type == ModContent.ItemType<NormalityRelocator>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.NormalityRelocator.Tooltip.1",
                    ModsCall.NormalityRelocatorHotKey);
            });
        }
        else if (item.type == ModContent.ItemType<Eternity>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.Eternity.Tooltip.1", ModsCall.EternityDiscoHex);
            });
        }
        else if (item.type == ModContent.ItemType<PlaguedFuelPack>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.PlaguedFuelPack.Tooltip.2", ModsCall.PlaguePackHotKey);
            });
        }
        else if (item.type == ModContent.ItemType<BlunderBooster>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.BlunderBooster.Tooltip.3", ModsCall.PlaguePackHotKey);
            });
        }
        else if (item.type == ModContent.ItemType<HadalStew>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.HadalStew.Tooltip.0",
                    Main.player[Main.myPlayer].pStone ? 37 : 50);
            });
        }
        else if (item.type == ModContent.ItemType<AngelicAlliance>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.AngelicAlliance.Tooltip.4", ModsCall.AngelicAllianceHotKey);
            });
        }
        else if (item.type == ModContent.ItemType<ExoThrone>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ExoThrone.Tooltip.1",
                    ModsCall.ExoChairSlowdownHotkey);
            });
        }
        else if (item.type == ModContent.ItemType<ShatteredCommunity>())
        {
            if (!ModsCall.Revenge)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ShatteredCommunity.Tooltip.NotRevenge.1");
                });
            }
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip6", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ShatteredCommunity.Tooltip.6",
                    tooltip.Text.Split(' ')[2], tooltip.Text.Split(' ')[3]);
            });
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip7", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ShatteredCommunity.Tooltip.7",
                    tooltip.Text.Split(' ')[4]);
            });
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip8", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ShatteredCommunity.Tooltip.8",
                    tooltip.Text.Split(' ')[4]);
            });
        }
        else if (item.type == ModContent.ItemType<FracturedArk>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.FracturedArk.Tooltip.0");
            });
        }
        else if (item.type == ModContent.ItemType<TrueArkoftheAncients>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.TrueArkoftheAncients.Tooltip.0");
            });
        }
        else if (item.type == ModContent.ItemType<ArkoftheCosmos>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ArkoftheCosmos.Tooltip.0");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ArkoftheCosmos.Tooltip.1");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ArkoftheCosmos.Tooltip.2");
            });
        }
        else if (item.type == ModContent.ItemType<ArkoftheElements>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ArkoftheElements.Tooltip.0");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ArkoftheElements.Tooltip.1");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ArkoftheElements.Tooltip.2");
            });
        }
        else if (item.type == ModContent.ItemType<DraedonsHeart>())
        {
            if (!ModsCall.Revenge)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.DraedonsHeart.Tooltip.NotRevenge.2");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.DraedonsHeart.Tooltip.NotRevenge.3");
                });
            }
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.DraedonsHeart.Tooltip.5");
            });
        }
        else if (item.type == ModContent.ItemType<BrokenBiomeBlade>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Does nothing..yet", "Ничего не делает... пока");
            });

            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
            {
                tooltip.Text = tooltip.Text
                    .Replace("Main Attunement", "Основная настройка")
                    .Replace("None", "Нет");
            });

            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
            {
                tooltip.Text = tooltip.Text
                    .Replace("Secondary Attunement", "Вторичная настройка")
                    .Replace("None", "Нет");
            });
        }
        else if (item.type == ModContent.ItemType<FourSeasonsGalaxia>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Active Attunement", "Активная настройка");
            });

            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Passive Blessing", "Пассивное благословение");
            });
        }
        else if (item.type == ModContent.ItemType<OmegaBiomeBlade>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Does nothing..yet\nIt seems that upgrading the blade expanded the scope of the previous attunements", "Ничего не делает... пока\nПохоже, что улучшение клинка расширило возможности предыдущих настроек");
            });

            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Your secondary attunement can now provide passive bonuses", "Ваша вторичная настройка теперь может давать пассивные бонусы");
            });

            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
            {
                tooltip.Text = tooltip.Text
                    .Replace("Active Attunement", "Активная настройка")
                    .Replace("None", "Нет");
            });

            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
            {
                tooltip.Text = tooltip.Text
                    .Replace("Passive Attunement", "Пассивная настройка")
                    .Replace("None", "Нет");
            });
        }
        else if (item.type == ModContent.ItemType<TrueBiomeBlade>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("Does nothing..yet\nRepairing the blade seems to have improved its attuning capacities", "Ничего не делает... пока\nПохоже, что восстановление клинка улучшило его возможности настройки");
            });

            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
            {
                tooltip.Text = tooltip.Text
                    .Replace("Main Attunement", "Основная настройка")
                    .Replace("None", "Нет");
            });

            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
            {
                tooltip.Text = tooltip.Text
                    .Replace("Secondary Attunement", "Вторичная настройка")
                    .Replace("None", "Нет");
            });
        }
        else if (item.type == ModContent.ItemType<RuneofKos>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
            {
                if (Main.LocalPlayer.ZoneDungeon)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.RuneofKos.Tooltip.ZoneDungeon");
                }
                else if (Main.LocalPlayer.ZoneSkyHeight)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.RuneofKos.Tooltip.ZoneSkyHeight");
                }
                else if (Main.LocalPlayer.ZoneUnderworldHeight)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.RuneofKos.Tooltip.ZoneUnderworldHeight");
                }
            });
        }
        else if (item.type == ModContent.ItemType<TheCommunity>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
            {
                tooltip.Text = tooltip.Text
                    .Replace("Max health increased by", "Увеличивает максимальный запас здоровья на")
                    .Replace("Melee speed increased by", "Увеличивает скорость атаки ближнего боя на")
                    .Replace("Life regeneration increased by", "Увеличивает регенерацию здоровья на")
                    .Replace("Critical strike chance increased by", "Увеличивает шанс критического удара на")
                    .Replace("Damage increased by", "Увеличивает урон на")
                    .Replace("Damage reduction increased by", "Увеличивает сопротивление урону на")
                    .Replace("Defense increased by", "Увеличивает защиту на")
                    .Replace("Minion knockback increased by", "Увеличивает отбрасывание призывателя на")
                    .Replace("Movement speed increased by", "Увеличивает скорость передвижения на")
                    .Replace("Flight time increased by", "Увеличивает время полёта на");
            });
        }
        else if (item.type == ModContent.ItemType<BloodOrange>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
            {
                if (calamityPlayer.bOrange)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.BloodOrange.Tooltip.Consumed");
                }
            });
        }
        else if (item.type == ModContent.ItemType<CometShard>())
        {
            int tooltipIndex = tooltips.FindLastIndex(x => x.Mod.Equals("Terraria") && x.Name.StartsWith("Tooltip"));
            if (tooltipIndex != -1 && calamityPlayer.cShard)
            {
                tooltips.Insert(++tooltipIndex, new TooltipLine(Mod, $"{Mod.Name}:Tooltip1", LangHelper.GetTextValue("CalamityMod.Items.CometShard.Tooltip.Consumed")));
            }
        }
        else if (item.type == ModContent.ItemType<Dragonfruit>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
            {
                if (calamityPlayer.dFruit)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.Dragonfruit.Tooltip.Consumed");
                }
            });
        }
        else if (item.type == ModContent.ItemType<Elderberry>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
            {
                if (calamityPlayer.eBerry)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.Elderberry.Tooltip.Consumed");
                }
            });
        }
        else if (item.type == ModContent.ItemType<EtherealCore>())
        {
            int tooltipIndex = tooltips.FindLastIndex(x => x.Mod.Equals("Terraria") && x.Name.StartsWith("Tooltip"));
            if (tooltipIndex != -1 && calamityPlayer.eCore)
            {
                tooltips.Insert(++tooltipIndex, new TooltipLine(Mod, $"{Mod.Name}:Tooltip1", LangHelper.GetTextValue("CalamityMod.Items.EtherealCore.Tooltip.Consumed")));
            }
        }
        else if (item.type == ModContent.ItemType<MiracleFruit>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
            {
                if (calamityPlayer.mFruit)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.MiracleFruit.Tooltip.Consumed");
                }
            });
        }
        else if (item.type == ModContent.ItemType<PhantomHeart>())
        {
            int tooltipIndex = tooltips.FindLastIndex(x => x.Mod.Equals("Terraria") && x.Name.StartsWith("Tooltip"));
            if (tooltipIndex != -1 && calamityPlayer.pHeart)
            {
                tooltips.Insert(++tooltipIndex, new TooltipLine(Mod, $"{Mod.Name}:Tooltip1", LangHelper.GetTextValue("CalamityMod.Items.PhantomHeart.Tooltip.Consumed")));
            }
        }
        else if (item.type == ModContent.ItemType<HadarianWings>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue(Player.Settings.HoverControl == 0
                    ? "CalamityMod.Items.HadarianWings.Tooltip.1.HoverControl"
                    : "CalamityMod.Items.HadarianWings.Tooltip.1.NotHoverControl");
            });
        }
        else if (item.type == ModContent.ItemType<MidasPrime>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:HiddenTooltip", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.MidasPrime.Tooltip.HiddenTooltip");
            });
        }
        else if (item.type == ModContent.ItemType<EncryptedSchematicHell>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                if (RecipeUnlockHandler.HasUnlockedT4ArsenalRecipes)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicHell.Tooltip.Unlocked");
                }
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:MeleeDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicHell.Tooltip.MeleeDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RangedDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicHell.Tooltip.RangedDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:MageDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicHell.Tooltip.MageDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:SummonDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicHell.Tooltip.SummonDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RogueDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicHell.Tooltip.RogueDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:CodeDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicHell.Tooltip.CodeDisplay");
            });
        }
        else if (item.type == ModContent.ItemType<EncryptedSchematicIce>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                if (RecipeUnlockHandler.HasUnlockedT5ArsenalRecipes)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicIce.Tooltip.Unlocked");
                }
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:MeleeDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicIce.Tooltip.MeleeDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RangedDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicIce.Tooltip.RangedDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RangedDisplay2", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicIce.Tooltip.RangedDisplay2");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:MageDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicIce.Tooltip.MageDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:SummonDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicIce.Tooltip.SummonDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RogueDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicIce.Tooltip.RogueDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:CodeDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicIce.Tooltip.CodeDisplay");
            });
        }
        else if (item.type == ModContent.ItemType<EncryptedSchematicJungle>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                if (RecipeUnlockHandler.HasUnlockedT3ArsenalRecipes)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicJungle.Tooltip.Unlocked");
                }
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:MeleeDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicJungle.Tooltip.MeleeDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RangedDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicJungle.Tooltip.RangedDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:MageDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicJungle.Tooltip.MageDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:SummonDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicJungle.Tooltip.SummonDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RogueDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicJungle.Tooltip.RogueDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:CodeDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicJungle.Tooltip.CodeDisplay");
            });
        }
        else if (item.type == ModContent.ItemType<EncryptedSchematicPlanetoid>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                if (RecipeUnlockHandler.HasUnlockedT2ArsenalRecipes)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicPlanetoid.Tooltip.Unlocked");
                }
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:MeleeDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicPlanetoid.Tooltip.MeleeDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RangedDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicPlanetoid.Tooltip.RangedDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:MageDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicPlanetoid.Tooltip.MageDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:SummonDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicPlanetoid.Tooltip.SummonDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RogueDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicPlanetoid.Tooltip.RogueDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:CodeDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicPlanetoid.Tooltip.CodeDisplay");
            });
        }
        else if (item.type == ModContent.ItemType<EncryptedSchematicSunkenSea>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:MeleeDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicSunkenSea.Tooltip.MeleeDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RangedDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicSunkenSea.Tooltip.RangedDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:MageDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicSunkenSea.Tooltip.MageDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:SummonDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicSunkenSea.Tooltip.SummonDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:RogueDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicSunkenSea.Tooltip.RogueDisplay");
            });
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:CodeDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicSunkenSea.Tooltip.CodeDisplay");
            });
        }
        
        ItemHelper.TranslateTooltip(item, tooltips, "SchematicKnowledge1", tooltip =>
        {
            tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.TooltipTags.SchematicKnowledge1");
        });
        ItemHelper.TranslateTooltip(item, tooltips, "SchematicKnowledge2", tooltip =>
        {
            tooltip.Text = 
                tooltip.Text.Replace("A specific schematic must be deciphered first", "Сначала необходимо расшифровать конкретную схему")
                .Replace("The Sunken Sea schematic must be deciphered first", "Сначала необходимо расшифровать схему затерянного моря")
                .Replace("The Planetoid schematic must be deciphered first", "Сначала необходимо расшифровать схему планетоида")
                .Replace("The Jungle schematic must be deciphered first", "Сначала необходимо расшифровать схему джунглей")
                .Replace("The Underworld schematic must be deciphered first", "Сначала необходимо расшифровать схему преисподней")
                .Replace("The Ice biome schematic must be deciphered first", "Сначала необходимо расшифровать схему льдов");
        });
        ItemHelper.TranslateTooltip(item, tooltips, "CalamityCharge", tooltip =>
        {
            tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.TooltipTags.CalamityCharge", tooltip.Text.Split(' ')[2]);
        });
        ItemHelper.TranslateTooltip(item, tooltips, "CalamityDonor", tooltip =>
        {
            tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.TooltipTags.CalamityDonor");
            tooltip.OverrideColor = new Color(139, 0, 0);
        });
        ItemHelper.TranslateTooltip(item, tooltips, "CalamityDev", tooltip =>
        {
            tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.TooltipTags.CalamityDev");
            tooltip.OverrideColor = new Color(255, 0, 255);
        });
        ItemHelper.TranslateTooltip(item, tooltips, "BestiaryNotes", tooltip =>
        {
            tooltip.Text = tooltip.Text switch
            {
                "Drops only on the first kill" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.FirstKillText"),
                "Drops during the Blood Moon" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.BloodMoonText"),
                "Drops on the first kill of the final Mechanical Boss" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.MechBossText"),
                "Drops on the first kill of the final Sentinel of the Devourer" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.SentinelText"),
                "Drops if Providence was summoned in the Hallow\nor if Providence is only attacked during nighttime" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.ProvidenceHallowText"),
                "Drops if Providence was summoned in the Underworld\nor if Providence is only attacked during nighttime" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.ProvidenceUnderworldText"),
                "Drops if Providence is only attacked during nighttime" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.ProvidenceNightText"),
                "Drops if fed to a Trasher" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.TrasherText"),
                "This is a Revengeance Mode drop rate" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.RevNoMaster"),
                "Drops after defeating King Slime" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostKS"),
                "Drops after defeating the Desert Scourge" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostDS"),
                "Drops after defeating the Eye of Cthulhu" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostEoC"),
                "Drops after defeating Crabulon" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostCrab"),
                "Drops after defeating the Brain of Cthulhu" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostEvil1"),
                "Drops after defeating the Eater of Worlds" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostEvil2"),
                "Drops after defeating the Hive Mind" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostHM"),
                "Drops after defeating the Perforators" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostPerfs"),
                "Drops after defeating the Queen Bee" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostQB"),
                "Drops after defeating Deerclops" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostDeer"),
                "Drops after defeating Skeletron" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostSkele"),
                "Drops after defeating the Slime God" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostSG"),
                "Drops in Hardmode" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Hardmode"),
                "Drops after defeating Queen Slime" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostQS"),
                "Drops after defeating Cryogen" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostCryo"),
                "Drops after defeating the Aquatic Scourge" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostAS"),
                "Drops after defeating the Brimstone Elemental" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostBrim"),
                "Drops after defeating the Destroyer" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostDest"),
                "Drops after defeating the Twins" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostTwins"),
                "Drops after defeating Skeletron Prime" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostSP"),
                "Drops after defeating a Mechanical Boss" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Post1Mech"),
                "Drops after defeating all three Mechanical Bosses" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Post3Mechs"),
                "Drops after defeating Calamitas" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostCal"),
                "Drops after defeating Plantera" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostPlant"),
                "Drops after defeating Calamitas or Plantera" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostCalPlant"),
                "Drops after defeating the Leviathan and Anahita" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostLevi"),
                "Drops after defeating Astrum Aureus" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostAureus"),
                "Drops after defeating Golem" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostGolem"),
                "Drops after defeating the Plaguebringer Goliath" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostPBG"),
                "Drops after defeating the Empress of Light" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostEoL"),
                "Drops after defeating Duke Fishron" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostFish"),
                "Drops after defeating the Ravager" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostRav"),
                "Drops after defeating the Lunatic Cultist" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostLC"),
                "Drops after defeating Astrum Deus" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostAD"),
                "Drops after defeating the Moon Lord" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostML"),
                "Drops after defeating the Profaned Guardian" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostGuard"),
                "Drops after defeating the Dragonfolly" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostBirb"),
                "Drops after defeating Providence" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostProv"),
                "Drops after defeating Signus" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostSig"),
                "Drops after defeating the Storm Weaver" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostSW"),
                "Drops after defeating the Ceaseless Void" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostCV"),
                "Drops after defeating the Polterghast" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostPolter"),
                "Drops after defeating the Old Duke" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostOD"),
                "Drops after defeating the Devourer of Gods" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostDoG"),
                "Drops after defeating Yharon" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostYharon"),
                "Drops after defeating the Exo Mechs" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostExos"),
                "Drops after defeating Supreme Calamitas" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostSCal"),
                "Drops after defeating the Adult Eidolon Wyrm" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostAEW"),
                "Drops after defeating the Giant Clam" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostClam"),
                "Drops after defeating the Giant Clam in Hardmode" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostClamHM"),
                "Drops after defeating the Great Sand Shark" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostGSS"),
                "Drops after defeating Betsy" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostBetsy"),
                "Drops after defeating the first tier of Acid Rain" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostT1AR"),
                "Drops after defeating the second tier of Acid Rain" => LangHelper.GetTextValue("CalamityMod.BestiaryNotes.PostT2AR"),
                _ => tooltip.Text
            };

            if (tooltip.Text == $"Drops if Providence was defeated only with the [i:{ModContent.ItemType<ProfanedSoulArtifact>()}] Profaned Soul Artifact\nThis is an Expert Mode drop rate")
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.BestiaryNotes.ProvidenceChallengeText");
            }
        });
        
        if (ModsCall.Fargo != null)
        {
            if (item.type == ModContent.ItemType<SunkenSeaFountain>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SunkenSeaFountain.Tooltip");
                });
            }
            else if (item.type == ModContent.ItemType<SulphurousFountainItem>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SulphurousFountainItem.Tooltip");
                });
            }
            else if (item.type == ModContent.ItemType<AstralFountainItem>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.AstralFountainItem.Tooltip");
                });
            }
        }
    }
}