﻿using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityRuTranslate.CalamityMod.Items
{
    public class SetBonus: GlobalItem
    {
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            Mod calamity = ModLoader.GetMod("CalamityMod");

            if (calamity != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                if (CalamityRuTranslate.TRuConfig.CalamityTranslation)
                {
                    if (head.type == calamity.ItemType("ShroomiteVisage") &&
                        body.type == ItemID.ShroomiteBreastplate &&
                        legs.type == ItemID.ShroomiteLeggings)
                    {
                        return "Shroomite";
                    }

                    if (head.type == ItemID.GladiatorHelmet &&
                        body.type == ItemID.GladiatorBreastplate &&
                        legs.type == ItemID.GladiatorLeggings)
                    {
                        return "Gladiator";
                    }

                    if (head.type == calamity.ItemType("AerospecHat") &&
                        body.type == calamity.ItemType("AerospecBreastplate") &&
                        legs.type == calamity.ItemType("AerospecLeggings"))
                    {
                        return "AerospecMagic";
                    }

                    if (head.type == calamity.ItemType("AerospecHeadgear") &&
                        body.type == calamity.ItemType("AerospecBreastplate") &&
                        legs.type == calamity.ItemType("AerospecLeggings"))
                    {
                        return "AerospecRogue";
                    }

                    if (head.type == calamity.ItemType("AerospecHelm") &&
                        body.type == calamity.ItemType("AerospecBreastplate") &&
                        legs.type == calamity.ItemType("AerospecLeggings"))
                    {
                        return "AerospecMelee";
                    }

                    if (head.type == calamity.ItemType("AerospecHelmet") &&
                        body.type == calamity.ItemType("AerospecBreastplate") &&
                        legs.type == calamity.ItemType("AerospecLeggings"))
                    {
                        return "AerospecSummoner";
                    }

                    if (head.type == calamity.ItemType("AerospecHood") &&
                        body.type == calamity.ItemType("AerospecBreastplate") &&
                        legs.type == calamity.ItemType("AerospecLeggings"))
                    {
                        return "AerospecRanged";
                    }

                    if (head.type == calamity.ItemType("AstralHelm") &&
                        body.type == calamity.ItemType("AstralBreastplate") &&
                        legs.type == calamity.ItemType("AstralLeggings"))
                    {
                        return "Astral";
                    }

                    if (head.type == calamity.ItemType("AtaxiaHeadgear") &&
                        body.type == calamity.ItemType("AtaxiaArmor") &&
                        legs.type == calamity.ItemType("AtaxiaSubligar"))
                    {
                        return "AtaxiaRanged";
                    }

                    if (head.type == calamity.ItemType("AtaxiaHelm") &&
                        body.type == calamity.ItemType("AtaxiaArmor") &&
                        legs.type == calamity.ItemType("AtaxiaSubligar"))
                    {
                        return "AtaxiaMelee";
                    }

                    if (head.type == calamity.ItemType("AtaxiaHelmet") &&
                        body.type == calamity.ItemType("AtaxiaArmor") &&
                        legs.type == calamity.ItemType("AtaxiaSubligar"))
                    {
                        return "AtaxiaSummoner";
                    }

                    if (head.type == calamity.ItemType("AtaxiaHood") &&
                        body.type == calamity.ItemType("AtaxiaArmor") &&
                        legs.type == calamity.ItemType("AtaxiaSubligar"))
                    {
                        return "AtaxiaRogue";
                    }

                    if (head.type == calamity.ItemType("AtaxiaMask") &&
                        body.type == calamity.ItemType("AtaxiaArmor") &&
                        legs.type == calamity.ItemType("AtaxiaSubligar"))
                    {
                        return "AtaxiaMagic";
                    }

                    if (head.type == calamity.ItemType("AuricTeslaHelm") &&
                        body.type == calamity.ItemType("AuricTeslaBodyArmor") &&
                        legs.type == calamity.ItemType("AuricTeslaCuisses"))
                    {
                        return "AuricTeslaMelee";
                    }

                    if (head.type == calamity.ItemType("AuricTeslaHoodedFacemask") &&
                        body.type == calamity.ItemType("AuricTeslaBodyArmor") &&
                        legs.type == calamity.ItemType("AuricTeslaCuisses"))
                    {
                        return "AuricTeslaRanged";
                    }

                    if (head.type == calamity.ItemType("AuricTeslaPlumedHelm") &&
                        body.type == calamity.ItemType("AuricTeslaBodyArmor") &&
                        legs.type == calamity.ItemType("AuricTeslaCuisses"))
                    {
                        return "AuricTeslaRogue";
                    }

                    if (head.type == calamity.ItemType("AuricTeslaSpaceHelmet") &&
                        body.type == calamity.ItemType("AuricTeslaBodyArmor") &&
                        legs.type == calamity.ItemType("AuricTeslaCuisses"))
                    {
                        return "AuricTeslaSummoner";
                    }

                    if (head.type == calamity.ItemType("AuricTeslaWireHemmedVisage") &&
                        body.type == calamity.ItemType("AuricTeslaBodyArmor") &&
                        legs.type == calamity.ItemType("AuricTeslaCuisses"))
                    {
                        return "AuricTeslaMagic";
                    }

                    if (head.type == calamity.ItemType("BloodflareHelm") &&
                        body.type == calamity.ItemType("BloodflareBodyArmor") &&
                        legs.type == calamity.ItemType("BloodflareCuisses"))
                    {
                        return "BloodflareRogue";
                    }

                    if (head.type == calamity.ItemType("BloodflareHelmet") &&
                        body.type == calamity.ItemType("BloodflareBodyArmor") &&
                        legs.type == calamity.ItemType("BloodflareCuisses"))
                    {
                        return "BloodflareSummoner";
                    }

                    if (head.type == calamity.ItemType("BloodflareHornedMask") &&
                        body.type == calamity.ItemType("BloodflareBodyArmor") &&
                        legs.type == calamity.ItemType("BloodflareCuisses"))
                    {
                        return "BloodflareMagic";
                    }

                    if (head.type == calamity.ItemType("BloodflareMask") &&
                        body.type == calamity.ItemType("BloodflareBodyArmor") &&
                        legs.type == calamity.ItemType("BloodflareCuisses"))
                    {
                        return "BloodflareMelee";
                    }

                    if (head.type == calamity.ItemType("DaedalusHat") &&
                        body.type == calamity.ItemType("DaedalusBreastplate") &&
                        legs.type == calamity.ItemType("DaedalusLeggings"))
                    {
                        return "DaedalusMagic";
                    }

                    if (head.type == calamity.ItemType("DaedalusHeadgear") &&
                        body.type == calamity.ItemType("DaedalusBreastplate") &&
                        legs.type == calamity.ItemType("DaedalusLeggings"))
                    {
                        return "DaedalusSummoner";
                    }

                    if (head.type == calamity.ItemType("DaedalusHelm") &&
                        body.type == calamity.ItemType("DaedalusBreastplate") &&
                        legs.type == calamity.ItemType("DaedalusLeggings"))
                    {
                        return "DaedalusMelee";
                    }

                    if (head.type == calamity.ItemType("DaedalusHelmet") &&
                        body.type == calamity.ItemType("DaedalusBreastplate") &&
                        legs.type == calamity.ItemType("DaedalusLeggings"))
                    {
                        return "DaedalusRanged";
                    }

                    if (head.type == calamity.ItemType("DaedalusVisor") &&
                        body.type == calamity.ItemType("DaedalusBreastplate") &&
                        legs.type == calamity.ItemType("DaedalusLeggings"))
                    {
                        return "DaedalusRogue";
                    }

                    if (head.type == calamity.ItemType("DesertProwlerHat") &&
                        body.type == calamity.ItemType("DesertProwlerShirt") &&
                        legs.type == calamity.ItemType("DesertProwlerPants"))
                    {
                        return "DesertProwler";
                    }

                    if (head.type == calamity.ItemType("FathomSwarmerVisage") &&
                        body.type == calamity.ItemType("FathomSwarmerBreastplate") &&
                        legs.type == calamity.ItemType("FathomSwarmerBoots"))
                    {
                        return "FathomSwarmer";
                    }

                    if (head.type == calamity.ItemType("GodSlayerHelm") &&
                        body.type == calamity.ItemType("GodSlayerChestplate") &&
                        legs.type == calamity.ItemType("GodSlayerLeggings"))
                    {
                        return "GodSlayerMelee";
                    }

                    if (head.type == calamity.ItemType("GodSlayerHelmet") &&
                        body.type == calamity.ItemType("GodSlayerChestplate") &&
                        legs.type == calamity.ItemType("GodSlayerLeggings"))
                    {
                        return "GodSlayerRanged";
                    }

                    if (head.type == calamity.ItemType("GodSlayerHornedHelm") &&
                        body.type == calamity.ItemType("GodSlayerChestplate") &&
                        legs.type == calamity.ItemType("GodSlayerLeggings"))
                    {
                        return "GodSlayerSummoner";
                    }

                    if (head.type == calamity.ItemType("GodSlayerMask") &&
                        body.type == calamity.ItemType("GodSlayerChestplate") &&
                        legs.type == calamity.ItemType("GodSlayerLeggings"))
                    {
                        return "GodSlayerRogue";
                    }

                    if (head.type == calamity.ItemType("GodSlayerVisage") &&
                        body.type == calamity.ItemType("GodSlayerChestplate") &&
                        legs.type == calamity.ItemType("GodSlayerLeggings"))
                    {
                        return "GodSlayerMagic";
                    }

                    if (head.type == calamity.ItemType("MolluskShellmet") &&
                        body.type == calamity.ItemType("MolluskShellplate") &&
                        legs.type == calamity.ItemType("MolluskShelleggings"))
                    {
                        return "Mollusk";
                    }

                    if (head.type == calamity.ItemType("PlaguebringerVisor") &&
                        body.type == calamity.ItemType("PlaguebringerCarapace") &&
                        legs.type == calamity.ItemType("PlaguebringerPistons"))
                    {
                        return "Plaguebringer";
                    }

                    if (head.type == calamity.ItemType("ReaverCap") &&
                        body.type == calamity.ItemType("ReaverScaleMail") &&
                        legs.type == calamity.ItemType("ReaverCuisses"))
                    {
                        return "ReaverRogue";
                    }

                    if (head.type == calamity.ItemType("ReaverHelm") &&
                        body.type == calamity.ItemType("ReaverScaleMail") &&
                        legs.type == calamity.ItemType("ReaverCuisses"))
                    {
                        return "ReaverMelee";
                    }

                    if (head.type == calamity.ItemType("ReaverHelmet") &&
                        body.type == calamity.ItemType("ReaverScaleMail") &&
                        legs.type == calamity.ItemType("ReaverCuisses"))
                    {
                        return "ReaverSummoner";
                    }

                    if (head.type == calamity.ItemType("ReaverMask") &&
                        body.type == calamity.ItemType("ReaverScaleMail") &&
                        legs.type == calamity.ItemType("ReaverCuisses"))
                    {
                        return "ReaverMagic";
                    }

                    if (head.type == calamity.ItemType("ReaverVisage") &&
                        body.type == calamity.ItemType("ReaverScaleMail") &&
                        legs.type == calamity.ItemType("ReaverCuisses"))
                    {
                        return "ReaverRanged";
                    }

                    if (head.type == calamity.ItemType("SilvaHelm") &&
                        body.type == calamity.ItemType("SilvaArmor") &&
                        legs.type == calamity.ItemType("SilvaLeggings"))
                    {
                        return "SilvaMelee";
                    }

                    if (head.type == calamity.ItemType("SilvaHelmet") &&
                        body.type == calamity.ItemType("SilvaArmor") &&
                        legs.type == calamity.ItemType("SilvaLeggings"))
                    {
                        return "SilvaSummoner";
                    }

                    if (head.type == calamity.ItemType("SilvaHornedHelm") &&
                        body.type == calamity.ItemType("SilvaArmor") &&
                        legs.type == calamity.ItemType("SilvaLeggings"))
                    {
                        return "SilvaRanged";
                    }

                    if (head.type == calamity.ItemType("SilvaMask") &&
                        body.type == calamity.ItemType("SilvaArmor") &&
                        legs.type == calamity.ItemType("SilvaLeggings"))
                    {
                        return "SilvaRogue";
                    }

                    if (head.type == calamity.ItemType("SilvaMaskedCap") &&
                        body.type == calamity.ItemType("SilvaArmor") &&
                        legs.type == calamity.ItemType("SilvaLeggings"))
                    {
                        return "SilvaMagic";
                    }

                    if (head.type == calamity.ItemType("SnowRuffianMask") &&
                        body.type == calamity.ItemType("SnowRuffianChestplate") &&
                        legs.type == calamity.ItemType("SnowRuffianGreaves"))
                    {
                        return "SnowRuffian";
                    }

                    if (head.type == calamity.ItemType("StatigelCap") &&
                        body.type == calamity.ItemType("StatigelArmor") &&
                        legs.type == calamity.ItemType("StatigelGreaves"))
                    {
                        return "StatigelMagic";
                    }

                    if (head.type == calamity.ItemType("StatigelHeadgear") &&
                        body.type == calamity.ItemType("StatigelArmor") &&
                        legs.type == calamity.ItemType("StatigelGreaves"))
                    {
                        return "StatigelRanged";
                    }

                    if (head.type == calamity.ItemType("StatigelHelm") &&
                        body.type == calamity.ItemType("StatigelArmor") &&
                        legs.type == calamity.ItemType("StatigelGreaves"))
                    {
                        return "StatigelMelee";
                    }

                    if (head.type == calamity.ItemType("StatigelHood") &&
                        body.type == calamity.ItemType("StatigelArmor") &&
                        legs.type == calamity.ItemType("StatigelGreaves"))
                    {
                        return "StatigelSummoner";
                    }

                    if (head.type == calamity.ItemType("StatigelMask") &&
                        body.type == calamity.ItemType("StatigelArmor") &&
                        legs.type == calamity.ItemType("StatigelGreaves"))
                    {
                        return "StatigelRogue";
                    }

                    if (head.type == calamity.ItemType("SulfurHelmet") &&
                        body.type == calamity.ItemType("SulfurBreastplate") &&
                        legs.type == calamity.ItemType("SulfurLeggings"))
                    {
                        return "Sulfur";
                    }

                    if (head.type == calamity.ItemType("TarragonHelmet") &&
                        body.type == calamity.ItemType("TarragonBreastplate") &&
                        legs.type == calamity.ItemType("TarragonLeggings"))
                    {
                        return "TarragonRogue";
                    }

                    if (head.type == calamity.ItemType("TarragonHornedHelm") &&
                        body.type == calamity.ItemType("TarragonBreastplate") &&
                        legs.type == calamity.ItemType("TarragonLeggings"))
                    {
                        return "TarragonSummoner";
                    }

                    if (head.type == calamity.ItemType("TarragonMask") &&
                        body.type == calamity.ItemType("TarragonBreastplate") &&
                        legs.type == calamity.ItemType("TarragonLeggings"))
                    {
                        return "TarragonMagic";
                    }

                    if (head.type == calamity.ItemType("TarragonVisage") &&
                        body.type == calamity.ItemType("TarragonBreastplate") &&
                        legs.type == calamity.ItemType("TarragonLeggings"))
                    {
                        return "TarragonRanged";
                    }

                    if (head.type == calamity.ItemType("TitanHeartMask") &&
                        body.type == calamity.ItemType("TitanHeartMantle") &&
                        legs.type == calamity.ItemType("TitanHeartBoots"))
                    {
                        return "TitanHeart";
                    }

                    if (head.type == calamity.ItemType("UmbraphileHood") &&
                        body.type == calamity.ItemType("UmbraphileRegalia") &&
                        legs.type == calamity.ItemType("UmbraphileBoots"))
                    {
                        return "Umbraphile";
                    }

                    if (head.type == calamity.ItemType("VictideHeadgear") &&
                        body.type == calamity.ItemType("VictideBreastplate") &&
                        legs.type == calamity.ItemType("VictideLeggings"))
                    {
                        return "VictideRogue";
                    }

                    if (head.type == calamity.ItemType("VictideHelm") &&
                        body.type == calamity.ItemType("VictideBreastplate") &&
                        legs.type == calamity.ItemType("VictideLeggings"))
                    {
                        return "VictideMelee";
                    }

                    if (head.type == calamity.ItemType("VictideHelmet") &&
                        body.type == calamity.ItemType("VictideBreastplate") &&
                        legs.type == calamity.ItemType("VictideLeggings"))
                    {
                        return "VictideSummoner";
                    }

                    if (head.type == calamity.ItemType("VictideMask") &&
                        body.type == calamity.ItemType("VictideBreastplate") &&
                        legs.type == calamity.ItemType("VictideLeggings"))
                    {
                        return "VictideMagic";
                    }

                    if (head.type == calamity.ItemType("VictideVisage") &&
                        body.type == calamity.ItemType("VictideBreastplate") &&
                        legs.type == calamity.ItemType("VictideLeggings"))
                    {
                        return "VictideRanged";
                    }

                    if (head.type == calamity.ItemType("WulfrumHeadgear") &&
                        body.type == calamity.ItemType("WulfrumArmor") &&
                        legs.type == calamity.ItemType("WulfrumLeggings"))
                    {
                        return "WulfrumRanged";
                    }

                    if (head.type == calamity.ItemType("WulfrumHelm") &&
                        body.type == calamity.ItemType("WulfrumArmor") &&
                        legs.type == calamity.ItemType("WulfrumLeggings"))
                    {
                        return "WulfrumMelee";
                    }

                    if (head.type == calamity.ItemType("WulfrumHelmet") &&
                        body.type == calamity.ItemType("WulfrumArmor") &&
                        legs.type == calamity.ItemType("WulfrumLeggings"))
                    {
                        return "WulfrumSummoner";
                    }

                    if (head.type == calamity.ItemType("WulfrumHood") &&
                        body.type == calamity.ItemType("WulfrumArmor") &&
                        legs.type == calamity.ItemType("WulfrumLeggings"))
                    {
                        return "WulfrumMagic";
                    }

                    if (head.type == calamity.ItemType("WulfrumMask") &&
                        body.type == calamity.ItemType("WulfrumArmor") &&
                        legs.type == calamity.ItemType("WulfrumLeggings"))
                    {
                        return "WulfrumRogue";
                    }

                    if (head.type == calamity.ItemType("XerocMask") &&
                        body.type == calamity.ItemType("XerocPlateMail") &&
                        legs.type == calamity.ItemType("XerocCuisses"))
                    {
                        return "Xeroc";
                    }
                }
            }

            return "";
        }

        public override void UpdateArmorSet(Player player, string set)
        {
            Mod calamity = ModLoader.GetMod("CalamityMod");
            
            if (calamity != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                if (CalamityRuTranslate.TRuConfig.CalamityTranslation)
                {
                    switch (set)
                    {
                        case "Shroomite":
                            player.setBonus = "Пока вы не двигаетесь, вы входите в режим скрытности\nСкрытность увеличивает дальность атак и уменьшает шанс быть обнаруженным врагами";
                            return;
                        case "Gladiator":
                            player.setBonus = "Увеличивает защиту на 5\nУвеличивает разбойный урон и скорость снарядов на 10%\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 70\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "AerospecMagic":
                            player.setBonus = "Увеличивает скорость передвижения и шанс критического удара на 5%\nПолучение более 25 единиц урона за один удар приведёт к падению множества самонаводящихся перьев\nПозволяет вам быстрее падать и нейтрализует урон от падения";
                            return;
                        case "AerospecRogue":
                            player.setBonus = "Увеличивает скорость передвижения и шанс критического удара на 5%\nПолучение более 25 единиц урона за один удар приведёт к падению множества самонаводящихся перьев\nПозволяет вам быстрее падать и нейтрализует урон от падения\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 100\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "AerospecMelee":
                            player.setBonus = "Увеличивает скорость передвижения и шанс критического удара ближнего боя на 5%\nПолучение более 25 единиц урона за один удар приведёт к падению множества самонаводящихся перьев\nПозволяет вам быстрее падать и нейтрализует урон от падения";
                            return;
                        case "AerospecSummoner":
                            player.setBonus = "Увеличивает урон миньонов на 16%\nПризывает валькирию защищать вас\nПолучение более 25 единиц урона за один удар приведёт к падению множества самонаводящихся перьев\nПозволяет вам быстрее падать и нейтрализует урон от падения";
                            return;
                        case "AerospecRanged":
                            player.setBonus = "Увеличивает скорость передвижения и стрелковый шанс критического удара на 5%\nПолучение более 25 единиц урона за один удар приведёт к падению множества самонаводящихся перьев\nПозволяет вам быстрее падать и нейтрализует урон от падения";
                            return;
                        case "Astral":
                            player.setBonus = "Увеличивает скорость передвижения на 25%\nУвеличивает урон на 28% и шанс критического удара на 21%\nВсякий раз, когда вы наносите критический удар врагу, с неба падают святые и астральные звёзды\nЭтот эффект имеет 1 секунду перезарядки, прежде чем сработает повторно";
                            return;
                        case "AtaxiaRanged":
                            player.setBonus = "Увеличивает стрелковый урон на 5%\nВы получите ауру «Инферно», когда здоровье ниже 50%\nУ вас есть 50% шанс выстрелить самонаводящейся вспышкой хаоса при использовании стрелкового оружия\nУ вас есть 20% шанс испустить пылающий взрыв при ранении";
                            return;
                        case "AtaxiaMelee":
                            player.setBonus = "Увеличивает урон ближнего боя на 5%\nВы получите ауру «Инферно», когда здоровье ниже 50%\nАтаки и снаряды ближнего боя вызывают извержение пламени хаоса при попадании во врага\nУ вас есть 20% шанс испустить пылающий взрыв при ранении";
                            return;
                        case "AtaxiaSummoner":
                            player.setBonus = "Увеличивает урон миньонов на 40%\nВы получите ауру «Инферно», когда здоровье ниже 50%\nПризывает гидротермическое жерло защищать вас\nУ вас есть 20% шанс испустить пылающий взрыв при ранении";
                            return;
                        case "AtaxiaRogue":
                            player.setBonus = "Увеличивает разбойный урон на 5%\nВы получите ауру «Инферно», когда здоровье ниже 50%\nРазбойное оружие с 10% шансом может высвободить залп пламени хаоса вокруг игрока, который преследует врагов\nУ вас есть 20% шанс испустить пылающий взрыв при ранении\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 110\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "AtaxiaMagic":
                            player.setBonus = "Увеличивает магический урон на 5%\nВы получите ауру «Инферно», когда здоровье ниже 50%\nМагические атаки призывают разрушающие и исцеляющие сферы при попадании\nУ вас есть 20% шанс испустить пылающий взрыв при ранении";
                            return;
                        case "AuricTeslaMelee":
                            player.setBonus = "Бонусы от комплектов брони ближнего боя: таррагона, кровавой вспышки, богоубийцы и сильвы\nВсе снаряды создают исцеляющие золотосодержащие сферы при попадании во врага\nМаксимальная скорость бега и ускорение увеличены на 10%\nВаш урон ближнего боя умножается в зависимости от вашего уровня здоровья; при полном здоровье этот эффект на максимуме";
                            return;
                        case "AuricTeslaRanged":
                            player.setBonus = "Бонусы от комплектов брони стрелка: таррагона, кровавой вспышки, богоубийцы и сильвы\nВсе снаряды создают исцеляющие золотосодержащие сферы при попадании во врага\nМаксимальная скорость бега и ускорение увеличены на 10%";
                            return;
                        case "AuricTeslaRogue":
                            player.setBonus = "Бонусы от комплектов брони разбойника: таррагона, кровавой вспышки, богоубийцы и сильвы\nВсе снаряды создают исцеляющие золотосодержащие сферы при попадании во врага\nМаксимальная скорость бега и ускорение увеличены на 10%\nКритические удары из оружия разбойника нанесут в 1.25 раза больше урона, пока ваше здоровье выше 50%\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 130\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "AuricTeslaSummoner":
                            player.setBonus = "Бонусы от комплектов брони призывателя: таррагона, кровавой вспышки, богоубийцы и сильвы\nВсе снаряды создают исцеляющие золотосодержащие сферы при попадании во врага\nМаксимальная скорость бега и ускорение увеличены на 10%\nУвеличивает максимальное число миньонов на 1 и урон миньонов на 120%";
                            return;
                        case "AuricTeslaMagic":
                            player.setBonus = "Бонусы от комплектов брони мага: таррагона, кровавой вспышки, богоубийцы и сильвы\nВсе снаряды создают исцеляющие золотосодержащие сферы при попадании во врага\nМаксимальная скорость бега и ускорение увеличены на 10%";
                            return;
                        case "BloodflareRogue":
                            player.setBonus = "Значительно увеличивает регенерацию здоровья\nУ врагов с уровнем здоровья ниже 50% может выпасть сердце при ударе\nУ врагов с уровнем здоровья выше 50% может выпасть кристалл маны при ударе\nУ врагов, убитых во время кровавой луны, выше шанс выпадения кровавой сферы\nПока здоровье выше 80% увеличивает вашу защиту на 30 и шанс критического удара на 5%\nПока здоровье ниже 80% увеличивает разбойный урон на 10%\nРазбойные критические удары с 50% шансом могут исцелить вас\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 120\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "BloodflareSummoner":
                            player.setBonus = "Увеличивает урон миньонов на 55%\nЗначительно увеличивает регенерацию здоровья\nУ врагов с уровнем здоровья ниже 50% может выпасть сердце при ударе\nУ врагов с уровнем здоровья выше 50% может выпасть кристалл маны при ударе\nУ врагов, убитых во время кровавой луны, выше шанс выпадения кровавой сферы\nПризывает мины полтергаста кружиться вокруг вас\nПри 90% здоровья и выше вы получаете 10% увеличение урона миньонов\nПри 50% здоровья и ниже вы получаете 20 защиты и 2 единицы регенерации здоровья";
                            return;
                        case "BloodflareMagic":
                            player.setBonus = "Значительно увеличивает регенерацию здоровья\nУ врагов с уровнем здоровья ниже 50% может выпасть сердце при ударе\nУ врагов с уровнем здоровья выше 50% может выпасть кристалл маны при ударе\nУ врагов, убитых во время кровавой луны, выше шанс выпадения кровавой сферы\nМагическое оружие иногда стреляет призрачными зарядами\nМагические критические удары вызывают взрыв пламени каждые 2 секунды";
                            return;
                        case "BloodflareMelee":
                            player.setBonus = "Значительно увеличивает регенерацию здоровья\nВраги чаще выбирают вас в качестве цели\nУ врагов с уровнем здоровья ниже 50% может выпасть сердце при ударе\nУ врагов с уровнем здоровья выше 50% может выпасть кристалл маны при ударе\nУ врагов, убитых во время кровавой луны, выше шанс выпадения кровавой сферы\nИстинные удары ближнего боя будут исцелять вас\nПосле того как вы нанесёте 15 истинных ударов врагу, вы впадёте в «Кровавое неистовство» на 5 секунд\nВо время этого вы получите 25% увеличение урона ближнего боя и шанса критического удара, а контактный урон будет снижен вдвое\nЭтот эффект имеет 30 секунд перезарядки";
                            return;
                        case "DaedalusMagic":
                            player.setBonus = "Увеличивает магический урон на 5%\nУ вас есть 10% шанс поглотить физические атаки и снаряды которые попали в вас\nЕсли вы поглощаете атаку, вы исцеляетесь на 1/2 от урона этой атаки";
                            return;
                        case "DaedalusSummoner":
                            player.setBonus = "Увеличивает урон миньонов на 20%\nКристалл Дедала парит над вами и защищает вас";
                            return;
                        case "DaedalusMelee":
                            player.setBonus = "Увеличивает урон ближнего боя на 5%\nУ вас есть 33% шанс отразить снаряды обратно во врагов\nЕсли вы отражаете снаряд, вы исцеляетесь на 1/5 от урона этого снаряда";
                            return;
                        case "DaedalusRanged":
                            player.setBonus = "Увеличивает стрелковый урон на 5%\nПолучив удар, заставит вас испускать взрыв кристальных осколков";
                            return;
                        case "DaedalusRogue":
                            player.setBonus = "Увеличивает разбойный урон на 5%\nРазбойные снаряды выбрасывают кристальные осколки во время полёта\nСкрытность разбойника накапливается, когда вы атакуете и не двигаетесь, максимум до 105\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "DesertProwler":
                            player.setBonus = "Стрелковые атаки наносят дополнительно 1 единицу фиксированного урона\nСтрелковые критические удары редко могут поднять песчаную бурю";
                            return;
                        case "FathomSwarmer":
                            player.setBonus = "Увеличивает урон миньонов на 10% и максимальное число миньонов на 1\nДарует способность лазить по стенам\nУвеличивает урон миньонов на 30%, находясь в жидкостях\nОбеспечивает умеренным количеством света в бездне и умеренно снижает потерю дыхания в бездне";
                            return;
                        case "GodSlayerMelee":
                            player.setBonus = "Вы переживёте смертельный урон и будете исцелены на 150 единиц здоровья, если атака убила бы вас\nЭтот эффект может срабатывать только один раз каждые 45 секунд\nПока перезарядка для этого эффекта активна, все регенерации здоровья снижены вдвое\nПолучив больше 80 единиц урона за один удар, вы выпустите рой дротиков богоубийц с высоким уроном\nВраги получают много урона, когда бьют вас\nАтака, которая нанесёт 80 или меньше урона будет снижена до 1 единицы";
                            return;
                        case "GodSlayerRanged":
                            player.setBonus = "Вы переживёте смертельный урон и будете исцелены на 150 единиц здоровья, если атака убила бы вас\nЭтот эффект может срабатывать только один раз каждые 45 секунд\nПока перезарядка для этого эффекта активна, все регенерации здоровья снижены вдвое\nВаши стрелковые критические удары могут нанести критический удар с 4-кратным уроном\nУ вас есть шанс выстрелить шрапнелью богоубийцы при стрельбе из стрелкового оружия";
                            return;
                        case "GodSlayerSummoner":
                            player.setBonus = "Увеличивает урон миньонов на 65%\nВы переживёте смертельный урон и будете исцелены на 150 единиц здоровья, если атака убила бы вас\nЭтот эффект может срабатывать только один раз каждые 45 секунд\nПока перезарядка для этого эффекта активна, все регенерации здоровья снижены вдвое\nУдар по врагам призывает фантомов богоубийцы\nПризывает пожирающего богов механического червя сражаться за вас";
                            return;
                        case "GodSlayerRogue":
                            player.setBonus = "Вы переживёте смертельный урон и будете исцелены на 150 единиц здоровья, если атака убила бы вас\nЭтот эффект может срабатывать только один раз каждые 45 секунд\nПока перезарядка для этого эффекта активна, все регенерации здоровья снижены вдвое\nПри полном здоровье все ваши разбойные характеристики увеличены на 10%\nЕсли вы получите более 80 единиц урона за один удар, вам будут предоставлены дополнительные кадры неуязвимости\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 120\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "GodSlayerMagic":
                            player.setBonus = "Вы переживёте смертельный урон и будете исцелены на 150 единиц здоровья, если атака убила бы вас\nЭтот эффект может срабатывать только один раз каждые 45 секунд\nПока перезарядка для этого эффекта активна, все регенерации здоровья снижены вдвое\nВраги будут выпускать пламя богоубийцы и исцеляющее пламя при попадании магическими атаками\nПри получении урон вы будете высвобождать магический взрыв богоубийцы";
                            return;
                        case "Mollusk":
                            player.setBonus = "Два моллюска помогают вам в бою\nУвеличивает урон на 10%\nВаше горизонтальное движение замедлено";
                            return;
                        case "Plaguebringer":
                            player.setBonus = "Дарует чумной рывок, чтобы таранить врагов и накладывать на них дебафф «Чума»\nПризывает маленькую разносчицу чумы защищать вас и наделять силой ближайших миньонов";
                            return;
                        case "ReaverRogue":
                            player.setBonus = "Увеличивает разбойный урон на 5%\nВы излучаете облако спор при ранении\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 110\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "ReaverMelee":
                            player.setBonus = "Увеличивает урон ближнего боя на 5%\nСнаряды ближнего боя взрываются при попадании\nШипы разорителя\nЯрость активируется при ранении";
                            return;
                        case "ReaverSummoner":
                            player.setBonus = "Увеличивает урон миньонов на 16%\nПризывает сферу разорителя, которая испускает споровый газ когда враги рядом";
                            return;
                        case "ReaverMagic":
                            player.setBonus = "Увеличивает магический урон на 5%\nВаши магические атаки испускают взрыв спорового газа при попадании во врага";
                            return;
                        case "ReaverRanged":
                            player.setBonus = "Увеличивает стрелковый урон на 5%\nПри использовании стрелкового оружия у вас есть 10% шанс выстрелить мощной ракетой";
                            return;
                        case "SilvaMelee":
                            player.setBonus = "Все снаряды создают целительные лиственные сферы при попадании во врага\nМаксимальная скорость бега и ускорение увеличены на 5%\nЕсли ваше здоровье опустилось до 1 единицы, вы не умрёте от любого дальнейшего урона в течение 10 секунд\nЕсли ваше здоровье повторно опустилось до 1 единицы пока активен этот эффект, вы потеряете 100 единиц максимального здоровья\nЭтот эффект срабатывает только один раз за жизнь, и если ваше максимальное здоровье опустилось до 400 единиц, эффект неуязвимости прекратится\nВаше максимальное здоровье вернётся в норму, если вы умрёте\nИстинные удары ближнего боя с 25% шансом нанесут 5 кратный урон\nПосле того, как бафф «Неуязвимость леса» закончится, вы получите на 20% меньше контактного урона\nСнаряды ближнего боя с вероятностью 25% оглушат врагов на короткий миг";
                            return;
                        case "SilvaSummoner":
                            player.setBonus = "Увеличивает урон миньонов на 75%\nВсе снаряды создают целительные лиственные сферы при попадании во врага\nМаксимальная скорость бега и ускорение увеличены на 5%\nЕсли ваше здоровье опустилось до 1 единицы, вы не умрёте от любого дальнейшего урона в течение 10 секунд\nЕсли ваше здоровье повторно опустилось до 1 единицы пока активен этот эффект, вы потеряете 100 единиц максимального здоровья\nЭтот эффект срабатывает только один раз за жизнь, и если ваше максимальное здоровье опустилось до 400 единиц, эффект неуязвимости прекратится\nВаше максимальное здоровье вернётся в норму, если вы умрёте\nПризывает древнюю призму листьев, чтобы взорвать ваших врагов жизненной энергией\nПо истечении времени баффа «Неуязвимость леса» ваши миньоны будут наносить на 10% больше урона";
                            return;
                        case "SilvaRanged":
                            player.setBonus = "Все снаряды создают целительные лиственные сферы при попадании во врага\nМаксимальная скорость бега и ускорение увеличены на 5%\nЕсли ваше здоровье опустилось до 1 единицы, вы не умрёте от любого дальнейшего урона в течение 10 секунд\nЕсли ваше здоровье повторно опустилось до 1 единицы пока активен этот эффект, вы потеряете 100 единиц максимального здоровья\nЭтот эффект срабатывает только один раз за жизнь, и если ваше максимальное здоровье опустилось до 400 единиц, эффект неуязвимости прекратится\nВаше максимальное здоровье вернётся в норму, если вы умрёте\nУвеличивает скорость стрельбы всего стрелкового оружия\nПосле действия баффа «Неуязвимость леса» ваше стрелковое оружие будет наносить на 10% больше урона";
                            return;
                        case "SilvaRogue":
                            player.setBonus = "Все снаряды создают целительные лиственные сферы при попадании во врага\nМаксимальная скорость бега и ускорение увеличены на 5%\nЕсли ваше здоровье опустилось до 1 единицы, вы не умрёте от любого дальнейшего урона в течение 10 секунд\nЕсли ваше здоровье повторно опустилось до 1 единицы пока активен этот эффект, вы потеряете 100 единиц максимального здоровья\nЭтот эффект срабатывает только один раз за жизнь, и если ваше максимальное здоровье опустилось до 400 единиц, эффект неуязвимости прекратится\nВаше максимальное здоровье вернётся в норму, если вы умрёте\nРазбойное оружие имеет более быструю скорость броска, пока здоровье выше 50%\nПо истечении времени баффа «Неуязвимость леса» ваше разбойное оружие будет наносить на 10% больше урона\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 125\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "SilvaMagic":
                            player.setBonus = "Все снаряды создают целительные лиственные сферы при попадании во врага\nМаксимальная скорость бега и ускорение увеличены на 5%\nЕсли ваше здоровье опустилось до 1 единицы, вы не умрёте от любого дальнейшего урона в течение 10 секунд\nЕсли ваше здоровье повторно опустилось до 1 единицы пока активен этот эффект, вы потеряете 100 единиц максимального здоровья\nЭтот эффект срабатывает только один раз за жизнь, и если ваше максимальное здоровье опустилось до 400 единиц, эффект неуязвимости прекратится\nВаше максимальное здоровье вернётся в норму, если вы умрёте\nМагические снаряды с 10% шансом могут вызвать массивный взрыв при попадании во врага\nПо истечении времени баффа «Неуязвимость леса» ваше магическое оружие будет наносить на 10% больше урона";
                            return;
                        case "SnowRuffian":
                            player.setBonus = "Увеличивает разбойный урон на 5%\nВы можете скользить нейтрализуя урон от падения\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 50\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "StatigelMagic":
                            player.setBonus = "Когда вы получаете более 100 единиц урона за один удар, вы становитесь неуязвимым к урону в течение длительного времени\nДарует дополнительный прыжок и увеличенную высоту прыжка\nУвеличивает скорость прыжка на 30%";
                            return;
                        case "StatigelRanged":
                            player.setBonus = "Когда вы получаете более 100 единиц урона за один удар, вы становитесь неуязвимым к урону в течение длительного времени\nДарует дополнительный прыжок и увеличенную высоту прыжка\nУвеличивает скорость прыжка на 30%";
                            return;
                        case "StatigelMelee":
                            player.setBonus = "Когда вы получаете более 100 единиц урона за один удар, вы становитесь неуязвимым к урону в течение длительного времени\nДарует дополнительный прыжок и увеличенную высоту прыжка\nУвеличивает скорость прыжка на 30%";
                            return;
                        case "StatigelSummoner":
                            player.setBonus = "Увеличивает урон миньонов на 18%\nПризывает мини бога слизней сражаться за вас. Тип слизня зависит от того, какое мировое зло в вашем мире\nКогда вы получаете более 100 единиц урона за один удар, вы становитесь неуязвимым к урону в течение длительного времени\nДарует дополнительный прыжок и увеличенную высоту прыжка\nУвеличивает скорость прыжка на 30%";
                            return;
                        case "StatigelRogue":
                            player.setBonus = "Когда вы получаете более 100 единиц урона за один удар, вы становитесь неуязвимым к урону в течение длительного времени\nДарует дополнительный прыжок и увеличенную высоту прыжка\nУвеличивает скорость прыжка на 30%\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 100\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "Sulfur":
                            player.setBonus = "Атакуя врагов и получая удар от врагов, накладывает на них дебафф «Отравление»\nДарует дополнительный прыжок, который вызывает сернистый пузырь\nОбеспечивает повышенной подводной мобильностью и уменьшает воздействие сернистых вод\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 100\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "TarragonRogue":
                            player.setBonus = "Уменьшает скорость появления врагов\nУвеличивает дальность подбора сердец\nПосле смерти врагов может выпасть больше сердец\nПосле каждых 25 разбойных критических ударов вы получаете неуязвимость к урону на 5 секунд\nЭтот эффект может срабатывать только раз в 30 секунд\nНаходясь под действием дебаффа, вы получаете 10% увеличенный разбойный урон\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 115\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "TarragonSummoner":
                            player.setBonus = "Увеличивает урон миньонов на 55%\nУменьшает скорость появления врагов\nУвеличивает дальность подбора сердец\nПосле смерти врагов может выпасть больше сердец\nПризывает вокруг вас ауру жизни, которая наносит урон ближайшим врагам";
                            return;
                        case "TarragonMagic":
                            player.setBonus = "Уменьшает скорость появления врагов\nУвеличивает дальность подбора сердец\nПосле смерти врагов может выпасть больше сердец\nПри каждом 5 критическом ударе вы будете стрелять вихрем листьев\nМагические снаряды исцеляют вас при попадании во врага\nКоличество восстанавливаемого здоровья основано на уроне снаряда";
                            return;
                        case "TarragonRanged":
                            player.setBonus = "Уменьшает скорость появления врагов\nУвеличивает дальность подбора сердец\nПосле смерти врагов может выпасть больше сердец\nСтрелковые критические удары вызовут взрыв листьев\nСтрелковые снаряды могут разделиться на жизненную энергию при попадании во врага";
                            return;
                        case "TitanHeart":
                            player.setBonus = "Увеличивает разбойный урон и отбрасывание на 20%\nСкрытные удары наносят двойное отбрасывание и вызывают астральный взрыв\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 100\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "Umbraphile":
                            player.setBonus = "У разбойного оружия есть шанс создать взрывы при попадании\nСкрытные удары всегда создают взрыв\nЗелье полутени всегда накапливает скрытность с максимальной эффективностью\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 110\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "VictideRogue":
                            player.setBonus = "Находясь в жидкостях увеличивает регенерацию здоровья и разбойный урон\nПри использовании любого оружия у вас есть 10% шанс метнуть морскую ракушку\nМорская ракушка наносит чистый урон и не получает дополнительного урона от любого класса\nОбеспечивает повышенной подводной мобильностью и слегка снижает потерю дыхания в бездне\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 90\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "VictideMelee":
                            player.setBonus = "Находясь в жидкостях увеличивает регенерацию здоровья и урон ближнего боя\nПри использовании любого оружия у вас есть 10% шанс метнуть морскую ракушку\nМорская ракушка наносит чистый урон и не получает дополнительного урона от любого класса\nОбеспечивает повышенной подводной мобильностью и слегка снижает потерю дыхания в бездне";
                            return;
                        case "VictideSummoner":
                            player.setBonus = "Находясь в жидкостях увеличивает регенерацию здоровья и урон миньонов\nПризывает морского ежа сражаться за вас\nПри использовании любого оружия у вас есть 10% шанс метнуть морскую ракушку\nМорская ракушка наносит чистый урон и не получает дополнительного урона от любого класса\nОбеспечивает повышенной подводной мобильностью и слегка снижает потерю дыхания в бездне";
                            return;
                        case "VictideMagic":
                            player.setBonus = "Находясь в жидкостях увеличивает регенерацию здоровья и магический урон\nПри использовании любого оружия у вас есть 10% шанс метнуть морскую ракушку\nМорская ракушка наносит чистый урон и не получает дополнительного урона от любого класса\nОбеспечивает повышенной подводной мобильностью и слегка снижает потерю дыхания в бездне";
                            return;
                        case "VictideRanged":
                            player.setBonus = "Находясь в жидкостях увеличивает регенерацию здоровья и стрелковый урон\nПри использовании любого оружия у вас есть 10% шанс метнуть морскую ракушку\nМорская ракушка наносит чистый урон и не получает дополнительного урона от любого класса\nОбеспечивает повышенной подводной мобильностью и слегка снижает потерю дыхания в бездне";
                            return;
                        case "WulfrumRanged":
                            player.setBonus = "Увеличивает защиту на 3\nУвеличивает защиту на 5 когда здоровье ниже 50%";
                            return;
                        case "WulfrumMelee":
                            player.setBonus = "Увеличивает защиту на 3\nУвеличивает защиту на 5 когда здоровье ниже 50%";
                            return;
                        case "WulfrumSummoner":
                            player.setBonus = "Увеличивает защиту на 3\nУвеличивает защиту на 5 когда здоровье ниже 50%";
                            return;
                        case "WulfrumMagic":
                            player.setBonus = "Увеличивает защиту на 3\nУвеличивает защиту на 5 когда здоровье ниже 50%";
                            return;
                        case "WulfrumRogue":
                            player.setBonus = "Увеличивает защиту на 3\nУвеличивает защиту на 5 когда здоровье ниже 50%\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 50\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                        case "Xeroc":
                            player.setBonus = "Увеличивает разбойный урон и скорость снарядов на 9%\nРазбойные снаряды имеют особые эффекты при попадании во врага\nВы переполняетесь космическим гневом и яростью при получении урона\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 115\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения";
                            return;
                    }
                }
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            Mod calamity = ModLoader.GetMod("CalamityMod");

            if (calamity != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                if (CalamityRuTranslate.TRuConfig.CalamityTranslation)
                {
                    if (item.type == ItemID.AncientBattleArmorHat ||
                        item.type == ItemID.AncientBattleArmorShirt ||
                        item.type == ItemID.AncientBattleArmorPants ||
                        item.type == calamity.ItemType("ForbiddenCirclet"))
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            string str = tooltipLine.text;
							string resultA = str.Replace("Press ", "Нажмите ");
							string resultB = resultA.Replace(" to call an ancient storm to the cursor location\nThe ancient storm costs ", ", для призыва древнего шторма в место, указанное мышью\nДревний шторм стоит ");
							string resultC = resultB.Replace(" mana and benefits from both summon and rogue bonuses\nRogue stealth strikes spawn homing eaters on enemy hits\nMinions deal full damage while wielding rogue weapons\nRogue and summon attacks will scale off of the stat with a higher boost\nRogue stealth builds while not attacking and slower while moving, up to a max of 100\nOnce you have built max stealth, you will be able to perform a Stealth Strike\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed", " маны и получает бонусы как от призывателя, так и от разбойника\nРазбойные скрытные удары создают самонаводящихся пожирателей при попадании во врага\nМиньоны наносят полный урон, пока вы держите разбойное оружие\nАтаки разбойника и призывателя зависят от характеристик с самым большим бонусом\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 100\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения");

							string resultD = resultC.Replace("Set Bonus: Double tap ", "Бонус комплекта: Нажмите дважды ");
							string resultE = resultD.Replace("UP", "ВВЕРХ");
							string resultF = resultE.Replace("DOWN", "ВНИЗ");
							string resultG = resultF.Replace(" to call an ancient storm to the cursor location\nThe minion damage nerf is reduced while wielding magic weapons", " для призыва древнего шторма в место, указанное мышью\nПонижение урона миньонов при использовании оружия другого класса снижено");
							tooltipLine.text = resultG;
                        }
                    }
                    
                    if (item.type == calamity.ItemType("FearmongerGreathelm") ||
                        item.type == calamity.ItemType("FearmongerPlateMail") ||
                        item.type == calamity.ItemType("FearmongerGreaves"))
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            string str = tooltipLine.text;
                            string resultA = str.Replace("30% increased minion damage\nThe minion damage nerf while wielding weaponry is reduced\nImmunity to all forms of frost and flame\nAll minion attacks grant colossal life regeneration\n15% increased damage reduction during the Pumpkin and Frost Moons\nThis extra damage reduction ignores the soft cap", "Увеличивает урон миньонов на 30%\nПонижение урона миньонов при использовании оружия другого класса снижено\nНевосприимчивость ко всем формам мороза и огня\nВсе атаки миньонов даруют колоссальную регенерацию здоровья\nУвеличивает сопротивление урону на 15% во время тыквенной и ледяной луны\nЭто дополнительное сопротивление урону игнорирует ванильный передел");
                            string resultB = resultA.Replace("Provides cold protection in Death Mode", "Обеспечивает защитой от холода в режиме Смерти");
                            tooltipLine.text = resultB;
                        }
                    }
                    
                    if (item.type == calamity.ItemType("PrismaticHelmet") ||
                        item.type == calamity.ItemType("PrismaticRegalia") ||
                        item.type == calamity.ItemType("PrismaticGreaves"))
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            string str = tooltipLine.text;
                            string resultA = str.Replace("+40 max mana and 15% reduced mana cost\nIncreased mana regeneration rate\nPress ", "Увеличивает максимальный запас маны на 40 и снижает расход маны на 15%\nУвеличивает скорость регенерации маны\nНажатие ");
                            string resultB = resultA.Replace(" to unleash a barrage of death lasers at the cursor for the next 5 seconds\nThis has a 30 second cooldown", ", выпустит шквал смертоносных лазеров в позицию курсора мыши в течение следующих 5 секунд\nИмеет 30 секунд перезарядки");
                            tooltipLine.text = resultB;
                        }
                    }
                    
                    if (item.type == calamity.ItemType("BloodflareHornedHelm") ||
                        item.type == calamity.ItemType("BloodflareBodyArmor") ||
                        item.type == calamity.ItemType("BloodflareCuisses"))
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            string str = tooltipLine.text;
                            string resultA = str.Replace("Greatly increases life regen\nEnemies below 50% life have a chance to drop hearts when struck\nEnemies above 50% life have a chance to drop mana stars when struck\nEnemies killed during a Blood Moon have a much higher chance to drop Blood Orbs\nPress ", "Значительно увеличивает регенерацию здоровья\nУ врагов с уровнем здоровья ниже 50% может выпасть сердце при ударе\nУ врагов с уровнем здоровья выше 50% может выпасть кристалл маны при ударе\nУ врагов, убитых во время кровавой луны, выше шанс выпадения кровавой сферы\nНажатие ");
                            string resultB = resultA.Replace(" to unleash the lost souls of polterghast to destroy your enemies\nThis effect has a 30 second cooldown\nRanged weapons have a chance to fire bloodsplosion orbs", ", высвободит уничтожающие ваших врагов души полтергаста\nЭтот эффект имеет 30 секунд перезарядки\nУ стрелкового оружия есть шанс выстрелить кровавыми взрывными сферами");
                            tooltipLine.text = resultB;
                        }
                    }
                    
                    if (item.type == calamity.ItemType("BrimflameScowl") ||
                        item.type == calamity.ItemType("BrimflameRobes") ||
                        item.type == calamity.ItemType("BrimflameBoots"))
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            string str = tooltipLine.text;
                            string resultA = str.Replace("Grants an additional 15% increased damage and magic crit\nPress ", "Дополнительно дарует увеличенный урон и шанс критического удара на 15%\nНажатие ");
                            string resultB = resultA.Replace(" to trigger a brimflame frenzy effect\nWhile under this effect, your damage is significantly boosted\nHowever, this comes at the cost of rapid life loss and no mana regeneration\nThis can be toggled off, however, a brimstone frenzy has a 30 second cooldown", ", чтобы активирует эффект «Серное неистовство»\nВо время действия этого эффекта ваш урон значительно увеличивается\nОднако это происходит ценой быстрой потери здоровья и отсутствием регенерации маны\nЭффект можно отключить, однако у «Серного неистовства» есть 30 секундная перезарядка");
                            tooltipLine.text = resultB;
                        }
                    }
                    
                    if (item.type == calamity.ItemType("DemonshadeHelm") ||
                        item.type == calamity.ItemType("DemonshadeBreastplate") ||
                        item.type == calamity.ItemType("DemonshadeGreaves"))
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            string str = tooltipLine.text;
                            string resultA = str.Replace("100% increased minion damage\nAll attacks inflict the demon flame debuff\nShadowbeams and demon scythes will fire down when you are hit\nA friendly red devil follows you around\nPress ", "Увеличивает урон миньонов на 100%\nВсе атаки накладывают дебафф «Пламя демона»\nТеневые лучи и демонические косы обрушатся на врагов, когда вас ранили\nДружелюбный красный дьявол следует за вами\nНажатие ");
                            string resultB = resultA.Replace(" to enrage nearby enemies with a dark magic spell for 10 seconds\nThis makes them do 25% more damage but they also take 125% more damage", ", разозлит ближайших врагов заклинанием тёмной магии на 10 секунд\nЭто заставит их наносить на 25% больше урона, но также получать его на 125% больше");
                            tooltipLine.text = resultB;
                        }
                    }
                    
                    if (item.type == calamity.ItemType("OmegaBlueHelmet") ||
                        item.type == calamity.ItemType("OmegaBlueChestplate") ||
                        item.type == calamity.ItemType("OmegaBlueLeggings"))
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            string str = tooltipLine.text;
                            string resultA = str.Replace("Increases armor penetration by 50\n10% increased damage and critical strike chance\nShort-ranged tentacles heal you by sucking enemy life\nPress ", "Увеличивает пробивание брони на 50\nУвеличивает урон и шанс критического удара на 10%\nКороткие щупальца исцеляют вас, высасывая жизнь врага\nНажатие ");
                            string resultB = resultA.Replace(" to activate abyssal madness for 5 seconds\nAbyssal madness increases damage, critical strike chance, and tentacle aggression/range\nThis effect has a 25 second cooldown", ", активирует «Безумие бездны» на 5 секунд\n«Безумие бездны» увеличивает урон, шанс критического удара и агрессивность/дистанцию атаки щупалец\nЭтот эффект имеет 25 секунд перезарядки");
                            tooltipLine.text = resultB;
                        }
                    }
                    
                    if (item.type == calamity.ItemType("PlagueReaperMask") ||
                        item.type == calamity.ItemType("PlagueReaperVest") ||
                        item.type == calamity.ItemType("PlagueReaperStriders"))
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            string str = tooltipLine.text;
                            string resultA = str.Replace("25% reduced ammo usage and 5% increased flight time\nEnemies receive 10% more damage from ranged projectiles when afflicted by the Plague\nGetting hit causes the plague cinders to rain from above\nPress ", "Уменьшает использование боеприпасов на 25% и увеличивает время полёта на 5%\nВраги получают на 10% больше урона от стрелковых снарядов, когда они поражены дебаффом «Чума»\nПолучая удар, приводит к падению с неба чумного пепла\nНажатие ");
                            string resultB = resultA.Replace(" to blind yourself for 5 seconds but massively boost your ranged damage\nThis has a 25 second cooldown.", ", ослепит вас в течение 5 секунд, но значительно увеличив свой стрелковый урон\nИмеет 25 секунд перезарядки");
                            tooltipLine.text = resultB;
                        }
                    }
                    
                    if (item.type == calamity.ItemType("TarragonHelm") ||
                        item.type == calamity.ItemType("TarragonBreastplate") ||
                        item.type == calamity.ItemType("TarragonLeggings"))
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            string str = tooltipLine.text;
                            string resultA = str.Replace("Increased heart pickup range\nEnemies have a chance to drop extra hearts on death\nYou have a 25% chance to gain a life regen buff when you take damage\nPress ", "Увеличивает дальность подбора сердец\nПосле смерти врагов может выпасть больше сердец\nУ вас есть 25% шанс получить бафф регенерации здоровья при получении урона\nНажатие ");
                            string resultB = resultA.Replace(" to cloak yourself in life energy that heavily reduces enemy contact damage for 10 seconds\nThis has a 30 second cooldown", ", покроет вас жизненной энергией, которая значительно снизит урон при контакте с врагом в течение 10 секунд\nИмеет 30 секунд перезарядки");
                            tooltipLine.text = resultB;
                        }
                    }
                    
                    if (item.type == ItemID.MoltenHelmet ||
                        item.type == ItemID.MoltenBreastplate ||
                        item.type == ItemID.MoltenGreaves)
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            string str = tooltipLine.text;
                            string resultA = str.Replace("Set Bonus: 17% extra melee damage", "Бонус комплекта: Увеличивает урон ближнего боя на 17%");
                            string resultB = resultA.Replace("20% extra true melee damage", "Увеличивает истинный урон ближнего боя на 20%");
                            string resultC = resultB.Replace("Grants immunity to fire blocks, and temporary immunity to lava", "Дарует невосприимчивость к огненным блокам и временную невосприимчивость к лаве");
                            string resultD = resultC.Replace("Provides heat and cold protection in Death Mode", "Обеспечивает защитой от жары и холода в режиме Смерти");
                            tooltipLine.text = resultD;
                        }
                    }
                    
                    if (item.type == ItemID.FrostHelmet ||
                        item.type == ItemID.FrostBreastplate ||
                        item.type == ItemID.FrostLeggings)
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            string str = tooltipLine.text;
                            string resultA = str.Replace("Provides heat and cold protection in Death Mode", "Обеспечивает защитой от жары и холода в режиме Смерти");
                            tooltipLine.text = resultA;
                        }
                    }
                    
                    if (item.type == ItemID.ObsidianHelm ||
                        item.type == ItemID.ObsidianShirt ||
                        item.type == ItemID.ObsidianPants)
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            string str = tooltipLine.text;
                            string resultA = str.Replace("+2 defense\n5% increased rogue damage and critical strike chance\nGrants immunity to fire blocks and temporary immunity to lava\nRogue stealth builds while not attacking and not moving, up to a max of 80\nOnce you have built max stealth, you will be able to perform a Stealth Strike\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed", "Увеличивает защиту на 2\nУвеличивает разбойный урон и шанс критического удара на 5%\nДарует невосприимчивость к огненным блокам и временную невосприимчивость к лаве\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 80\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения");
                            string resultB = resultA.Replace("Provides heat protection in Death Mode", "Обеспечивает защитой от жары в режиме Смерти");
                            tooltipLine.text = resultB;
                        }
                    }
                    
                    if (item.type == ItemID.EskimoHood ||
                        item.type == ItemID.PinkEskimoHood ||
                        item.type == ItemID.EskimoCoat ||
                        item.type == ItemID.PinkEskimoCoat ||
                        item.type == ItemID.EskimoPants ||
                        item.type == ItemID.PinkEskimoPants)
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            string str = tooltipLine.text;
                            string resultA = str.Replace("All ice-themed weapons receive a 10% damage bonus\nCold enemies will deal reduced contact damage to the player\nProvides immunity to the Frostburn and Glacial State debuffs", "Урон оружий, связанных со льдом увеличен на 10%\nВраги, связанные со льдом наносят сниженный урон\nОбеспечивает невосприимчивостью к дебаффам «Ледяной ожог» и «Ледниковое состояние»");
                            string resultB = resultA.Replace("Provides cold protection in Death Mode", "Обеспечивает защитой от холода в режиме Смерти");
                            tooltipLine.text = resultB;
                        }
                    }
                }
            }
        }
    }
}
