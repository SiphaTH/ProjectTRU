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

[JITWhenModsEnabled("CalamityMod")]
public class SpecificItemsTooltipTranslation : GlobalItem
{
    CalamityPlayer CalamityPlayer => Main.LocalPlayer.GetModPlayer<CalamityPlayer>();
    bool HasUnlockedT4ArsenalRecipes => RecipeUnlockHandler.HasUnlockedT4ArsenalRecipes;
    bool HasUnlockedT5ArsenalRecipess => RecipeUnlockHandler.HasUnlockedT5ArsenalRecipes;
    bool HasUnlockedT3ArsenalRecipes => RecipeUnlockHandler.HasUnlockedT3ArsenalRecipes;
    bool HasUnlockedT2ArsenalRecipes => RecipeUnlockHandler.HasUnlockedT2ArsenalRecipes;
    
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    }

     //Удаляет SetNameOverride со ВСЕХ предметов в игре включая модовые. Влияет на производительность.
     //!TODO: Найти способ сделать условие которое удаляет SetNameOverride только в ModItem в Каламити
     public override void SetDefaults(Item item)
     {
         item.ClearNameOverride();
     }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        CalamityGlobalItem calamityGlobalItem = item.GetGlobalItem<CalamityGlobalItem>();

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
        else if (item.type == ModContent.ItemType<Nanotech>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip7", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.Nanotech.Tooltip.7", tooltip.Text.Split(' ')[3]);
            });
        }
        else if (item.type == ModContent.ItemType<RaidersTalisman>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.RaidersTalisman.Tooltip.3", tooltip.Text.Split(' ')[3]);
            });
        }
        else if (item.type == ModContent.ItemType<ProfanedSoulCrystal>())
        {
            if (!ModsCall.DownedSCal || !ModsCall.DownedExoMechs)
            {
                ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Name == "Tooltip1" && l.Text == "[c/f05a5a:The soul within this crystal has been defiled by overwhelming energy waves from dangerous mechanations]\nMerchants will reject a defiled soul such as this.", tooltip =>
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ProfanedSoulCrystal.Tooltip.NoDownedCondition.1");
                });
                ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Name == "Tooltip1" && l.Text == "[c/f05a5a:The soul within this crystal has been defiled by the powerful magic of a supreme witch]\nMerchants will reject a defiled soul such as this.", tooltip =>
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ProfanedSoulCrystal.Tooltip.NoDownedCondition.2");
                });
            }
            else
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ProfanedSoulCrystal.Tooltip.1", (int)(100f * Main.player[Main.myPlayer].manaCost));
                });
            }
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
                    ModsCall.ExoChairSpeedupHotkey);
            });
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.ExoThrone.Tooltip.2",
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
                if (CalamityPlayer.bOrange)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.BloodOrange.Tooltip.Consumed");
                }
            });
        }
        else if (item.type == ModContent.ItemType<CometShard>())
        {
            int tooltipIndex = tooltips.FindLastIndex(x => x.Mod.Equals("Terraria") && x.Name.StartsWith("Tooltip"));
            if (tooltipIndex != -1 && CalamityPlayer.cShard)
            {
                tooltips.Insert(++tooltipIndex, new TooltipLine(Mod, $"{Mod.Name}:Tooltip1", LangHelper.GetTextValue("CalamityMod.Items.CometShard.Tooltip.Consumed")));
            }
        }
        else if (item.type == ModContent.ItemType<Dragonfruit>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
            {
                if (CalamityPlayer.dFruit)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.Dragonfruit.Tooltip.Consumed");
                }
            });
        }
        else if (item.type == ModContent.ItemType<Elderberry>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
            {
                if (CalamityPlayer.eBerry)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.Elderberry.Tooltip.Consumed");
                }
            });
        }
        else if (item.type == ModContent.ItemType<EtherealCore>())
        {
            int tooltipIndex = tooltips.FindLastIndex(x => x.Mod.Equals("Terraria") && x.Name.StartsWith("Tooltip"));
            if (tooltipIndex != -1 && CalamityPlayer.eCore)
            {
                tooltips.Insert(++tooltipIndex, new TooltipLine(Mod, $"{Mod.Name}:Tooltip1", LangHelper.GetTextValue("CalamityMod.Items.EtherealCore.Tooltip.Consumed")));
            }
        }
        else if (item.type == ModContent.ItemType<MiracleFruit>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
            {
                if (CalamityPlayer.mFruit)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.MiracleFruit.Tooltip.Consumed");
                }
            });
        }
        else if (item.type == ModContent.ItemType<PhantomHeart>())
        {
            int tooltipIndex = tooltips.FindLastIndex(x => x.Mod.Equals("Terraria") && x.Name.StartsWith("Tooltip"));
            if (tooltipIndex != -1 && CalamityPlayer.pHeart)
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
                if (HasUnlockedT4ArsenalRecipes)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicHell.Tooltip.Unlocked");
                }
            });
        }
        else if (item.type == ModContent.ItemType<EncryptedSchematicIce>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                if (HasUnlockedT5ArsenalRecipess)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicIce.Tooltip.Unlocked");
                }
            });
        }
        else if (item.type == ModContent.ItemType<EncryptedSchematicJungle>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                if (HasUnlockedT3ArsenalRecipes)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicJungle.Tooltip.Unlocked");
                }
            });
        }
        else if (item.type == ModContent.ItemType<EncryptedSchematicPlanetoid>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                if (HasUnlockedT2ArsenalRecipes)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.EncryptedSchematicPlanetoid.Tooltip.Unlocked");
                }
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
                .Replace("The Underworld schematic must be deciphered first", "Сначала необходимо расшифровать схему ада")
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