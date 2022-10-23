using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityMod;
using CalamityMod.Items.Armor.Vanity;
using CalamityMod.Items.LoreItems;
using CalamityMod.Items.Materials;
using CalamityMod.Items.Pets;
using CalamityMod.Items.Placeables.Furniture;
using CalamityMod.Items.Placeables.Furniture.CraftingStations;
using CalamityMod.Items.Placeables.Furniture.DevPaintings;
using CalamityMod.Items.Placeables.Furniture.Trophies;
using CalamityMod.Items.Potions.Alcohol;
using CalamityMod.Items.SummonItems;
using CalamityMod.Items.SummonItems.Invasion;
using CalamityMod.NPCs.AcidRain;
using CalamityMod.NPCs.AdultEidolonWyrm;
using CalamityMod.NPCs.AquaticScourge;
using CalamityMod.NPCs.AstrumAureus;
using CalamityMod.NPCs.AstrumDeus;
using CalamityMod.NPCs.BrimstoneElemental;
using CalamityMod.NPCs.Bumblebirb;
using CalamityMod.NPCs.Calamitas;
using CalamityMod.NPCs.CeaselessVoid;
using CalamityMod.NPCs.Crabulon;
using CalamityMod.NPCs.Cryogen;
using CalamityMod.NPCs.DesertScourge;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.ExoMechs.Ares;
using CalamityMod.NPCs.ExoMechs.Artemis;
using CalamityMod.NPCs.ExoMechs.Thanatos;
using CalamityMod.NPCs.GreatSandShark;
using CalamityMod.NPCs.HiveMind;
using CalamityMod.NPCs.Leviathan;
using CalamityMod.NPCs.OldDuke;
using CalamityMod.NPCs.Perforator;
using CalamityMod.NPCs.PlaguebringerGoliath;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.ProfanedGuardians;
using CalamityMod.NPCs.Providence;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.Signus;
using CalamityMod.NPCs.SlimeGod;
using CalamityMod.NPCs.StormWeaver;
using CalamityMod.NPCs.SunkenSea;
using CalamityMod.NPCs.SupremeCalamitas;
using CalamityMod.NPCs.TownNPCs;
using CalamityMod.NPCs.Yharon;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class WeakReferenceSupportAddCalamityBosses : OnPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && ModsCall.BossChecklist != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModsCall.Calamity?.Code.GetType("CalamityMod.WeakReferenceSupport")
        ?.GetMethod("AddCalamityBosses", BindingFlags.Static | BindingFlags.NonPublic);

    private delegate void AddCalamityBossesDelegate(Mod bossChecklist, Mod calamity);

    public override Delegate Delegate { get; } = (AddCalamityBossesDelegate orig, Mod bosschecklist, Mod calamity) =>
    {
        AddBoss(
            bosschecklist,
            calamity,
            "Пустынный бич",
            1.6f,
            new List<int>
            {
                ModContent.NPCType<DesertScourgeHead>(),
                ModContent.NPCType<DesertScourgeBody>(),
                ModContent.NPCType<DesertScourgeTail>()
            },
            () => DownedBossSystem.downedDesertScourge,
            ModContent.ItemType<DesertMedallion>(),
            new List<int>
            {
                ModContent.ItemType<DesertScourgeTrophy>(),
                ModContent.ItemType<DesertScourgeMask>(),
                ModContent.ItemType<KnowledgeDesertScourge>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<DesertMedallion>()}] в пустыне.",
            CalamityUtils.ColorMessage("Пустынный бич погружается назад в песок.", new Color(238, 232, 170)),
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/DesertScourge/DesertScourge_BossChecklist", AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value, new Vector2(rect.Center.X - value.Width / 2, rect.Center.Y - value.Height / 2), color);
            }
        );

        AddMiniBoss(
            bosschecklist,
            calamity,
            "Гигантский моллюск",
            1.61f,
            ModContent.NPCType<GiantClam>(),
            () => DownedBossSystem.downedCLAM,
            null,
            null,
            "Может естественно появится в затерянном море.",
            CalamityUtils.ColorMessage("Гигантский моллюск скрывается в своём гроте.", new Color(127, 255, 212)),
            () => true
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Крабулон",
            2.7f,
            ModContent.NPCType<Crabulon>(),
            () => DownedBossSystem.downedCrabulon,
            ModContent.ItemType<DecapoditaSprout>(),
            new List<int>
            {
                ModContent.ItemType<CrabulonTrophy>(),
                ModContent.ItemType<CrabulonMask>(),
                ModContent.ItemType<KnowledgeCrabulon>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<DecapoditaSprout>()}] в грибном биоме.",
            CalamityUtils.ColorMessage("Мицелиевый краб потерял интерес.", new Color(100, 149, 237)),
            () => true
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Разум Улья",
            3.98f,
            ModContent.NPCType<HiveMind>(),
            () => DownedBossSystem.downedHiveMind,
            ModContent.ItemType<Teratoma>(),
            new List<int>
            {
                ModContent.ItemType<HiveMindTrophy>(),
                ModContent.ItemType<HiveMindMask>(),
                ModContent.ItemType<KnowledgeHiveMind>(),
                ModContent.ItemType<RottingEyeball>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Убейте кисту или используйте [i:{ModContent.ItemType<Teratoma>()}] в искажении.",
            CalamityUtils.ColorMessage("Искажённая стая начала поиски нового места для размножения.", new Color(148, 0, 211)),
            () => true,
            null,
            "CalamityMod/NPCs/HiveMind/HiveMindP2_Head_Boss"
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Перфораторы",
            3.99f,
            ModContent.NPCType<PerforatorHive>(),
            () => DownedBossSystem.downedPerforator,
            ModContent.ItemType<BloodyWormFood>(),
            new List<int>
            {
                ModContent.ItemType<PerforatorTrophy>(),
                ModContent.ItemType<PerforatorMask>(),
                ModContent.ItemType<KnowledgePerforators>(),
                ModContent.ItemType<BloodyVein>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Убейте кисту или используйте [i:{ModContent.ItemType<BloodyWormFood>()}] в багрянце.",
            CalamityUtils.ColorMessage("Паразитический улей начал искать нового носителя.", new Color(220, 20, 60)),
            () => true
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Бог слизней",
            6.5f,
            new List<int>
            {
                ModContent.NPCType<SlimeGodCore>(),
                ModContent.NPCType<EbonianSlimeGod>(),
                ModContent.NPCType<CrimulanSlimeGod>()
            },
            () => DownedBossSystem.downedSlimeGod,
            ModContent.ItemType<OverloadedSludge>(),
            new List<int>
            {
                ModContent.ItemType<SlimeGodTrophy>(),
                ModContent.ItemType<SlimeGodMask>(),
                ModContent.ItemType<SlimeGodMask2>(),
                ModContent.ItemType<KnowledgeSlimeGod>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<OverloadedSludge>()}].",
            CalamityUtils.ColorMessage("Желеподобное чудовище отомстило за своих собратьев.", new Color(186, 85, 51)),
            () => true
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Криоген",
            8.5f,
            ModContent.NPCType<Cryogen>(),
            () => DownedBossSystem.downedCryogen,
            ModContent.ItemType<CryoKey>(),
            new List<int>
            {
                ModContent.ItemType<CryogenTrophy>(),
                ModContent.ItemType<CryogenMask>(),
                ModContent.ItemType<KnowledgeCryogen>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<CryoKey>()}] в снегах.",
            CalamityUtils.ColorMessage("Криоген уносится прочь ледяным ветром.", new Color(0, 255, 255)),
            () => true,
            null,
            "CalamityMod/NPCs/Cryogen/Cryogen_Phase1_Head_Boss"
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Акватический бич",
            9.5f,
            new List<int>
            {
                ModContent.NPCType<AquaticScourgeHead>(),
                ModContent.NPCType<AquaticScourgeBody>(),
                ModContent.NPCType<AquaticScourgeBodyAlt>(),
                ModContent.NPCType<AquaticScourgeTail>()
            },
            () => DownedBossSystem.downedAquaticScourge,
            ModContent.ItemType<Seafood>(),
            new List<int>
            {
                ModContent.ItemType<AquaticScourgeTrophy>(),
                ModContent.ItemType<AquaticScourgeMask>(),
                ModContent.ItemType<KnowledgeAquaticScourge>(),
                ModContent.ItemType<KnowledgeSulphurSea>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<Seafood>()}] или подождите его появление в сернистом море.",
            CalamityUtils.ColorMessage("Акватический бич уплыл обратно в открытый океан.", new Color(240, 230, 140)),
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/AquaticScourge/AquaticScourge_BossChecklist", AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value, new Vector2(rect.Center.X - value.Width / 2, rect.Center.Y - value.Height / 2), color);
            },
            "CalamityMod/NPCs/AquaticScourge/AquaticScourgeHead_Head_Boss"
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Серный элементаль",
            10.5f,
            ModContent.NPCType<BrimstoneElemental>(),
            () => DownedBossSystem.downedBrimstoneElemental,
            ModContent.ItemType<CharredIdol>(),
            new List<int>
            {
                ModContent.ItemType<BrimstoneElementalTrophy>(),
                ModContent.ItemType<BrimstoneWaifuMask>(),
                ModContent.ItemType<KnowledgeBrimstoneCrag>(),
                ModContent.ItemType<KnowledgeBrimstoneElemental>(),
                ModContent.ItemType<CharredRelic>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<CharredIdol>()}] в серной скале.",
            CalamityUtils.ColorMessage("Серный элементаль отступает к руинам своей святыни.", new Color(220, 20, 60)),
            () => true
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Клон Каламитас",
            11.7f,
            ModContent.NPCType<CalamitasClone>(),
            () => DownedBossSystem.downedCalamitas,
            ModContent.ItemType<EyeofDesolation>(),
            new List<int>
            {
                ModContent.ItemType<CalamitasTrophy>(),
                ModContent.ItemType<CataclysmTrophy>(),
                ModContent.ItemType<CatastropheTrophy>(),
                ModContent.ItemType<CalamitasMask>(),
                ModContent.ItemType<HoodOfCalamity>(),
                ModContent.ItemType<RobesOfCalamity>(),
                ModContent.ItemType<KnowledgeCalamitasClone>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<EyeofDesolation>()}] ночью.",
            CalamityUtils.ColorMessage("Если вы хотели драки, вы должны были прийти более подготовленными.", new Color(255, 165, 0)),
            () => true
        );

        AddMiniBoss(
            bosschecklist,
            calamity,
            "Великая песчаная акула",
            12.09f,
            ModContent.NPCType<GreatSandShark>(),
            () => DownedBossSystem.downedGSS,
            ModContent.ItemType<SandstormsCore>(),
            new List<int>
            {
                3796
            },
            $"Убейте 10 песчаных акул после победы над Плантерой или используйте [i:{ModContent.ItemType<SandstormsCore>()}] в пустыне.",
            CalamityUtils.ColorMessage("Высший хищник песков исчезает в дюнах...", new Color(218, 165, 32)),
            () => true
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Левиафан",
            12.8f,
            new List<int>
            {
                ModContent.NPCType<Leviathan>(),
                ModContent.NPCType<Anahita>()
            },
            () => DownedBossSystem.downedLeviathan,
            null,
            new List<int>
            {
                ModContent.ItemType<LeviathanTrophy>(),
                ModContent.ItemType<AnahitaTrophy>(),
                ModContent.ItemType<LeviathanMask>(),
                ModContent.ItemType<AnahitaMask>(),
                ModContent.ItemType<KnowledgeOcean>(),
                ModContent.ItemType<KnowledgeLeviathanAnahita>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            "Убейте неизвестное существо в океане.",
            CalamityUtils.ColorMessage("Водные существа возвращаются в глубины океана.", new Color(127, 255, 212)),
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/Leviathan/AnahitaLevi_BossChecklist", AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value, new Vector2(rect.Center.X - value.Width / 2, rect.Center.Y - value.Height / 2), color);
            }
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Аструм Ареус",
            12.81f,
            ModContent.NPCType<AstrumAureus>(),
            () => DownedBossSystem.downedAstrumAureus,
            ModContent.ItemType<AstralChunk>(),
            new List<int>
            {
                ModContent.ItemType<AstrumAureusTrophy>(),
                ModContent.ItemType<AstrumAureusMask>(),
                ModContent.ItemType<KnowledgeAstrumAureus>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<AstralChunk>()}] ночью в астральном биоме.",
            CalamityUtils.ColorMessage("Программа Аструм Ареуса выполнена. Инициирую возврат.", new Color(255, 215, 0)),
            () => true,
            null,
            "CalamityMod/NPCs/AstrumAureus/AstrumAureus_Head_Boss"
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Разносчица чумы, Голиаф",
            14.5f,
            ModContent.NPCType<PlaguebringerGoliath>(),
            () => DownedBossSystem.downedPlaguebringer,
            ModContent.ItemType<Abombination>(),
            new List<int>
            {
                ModContent.ItemType<PlaguebringerGoliathTrophy>(),
                ModContent.ItemType<PlaguebringerGoliathMask>(),
                ModContent.ItemType<KnowledgePlaguebringerGoliath>(),
                ModContent.ItemType<PlagueCaller>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<Abombination>()}] в джунглях.",
            CalamityUtils.ColorMessage("ВРАЖДЕБНЫЕ СУЩНОСТИ УНИЧТОЖЕНЫ. ИНИЦИИРУЮ ВОЗВРАТ НА БАЗУ.", new Color(0, 255, 0)),
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/PlaguebringerGoliath/PlaguebringerGoliath_BossChecklist", AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value, new Vector2(rect.Center.X - value.Width / 2, rect.Center.Y - value.Height / 2), color);
            },
            "CalamityMod/NPCs/PlaguebringerGoliath/PlaguebringerGoliath_Head_Boss"
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Разрушитель",
            16.5f,
            new List<int>
            {
                ModContent.NPCType<RavagerBody>(),
                ModContent.NPCType<RavagerClawLeft>(),
                ModContent.NPCType<RavagerClawRight>(),
                ModContent.NPCType<RavagerHead>(),
                ModContent.NPCType<RavagerLegLeft>(),
                ModContent.NPCType<RavagerLegRight>()
            },
            () => DownedBossSystem.downedRavager,
            ModContent.ItemType<DeathWhistle>(),
            new List<int>
            {
                ModContent.ItemType<RavagerTrophy>(),
                ModContent.ItemType<RavagerMask>(),
                ModContent.ItemType<KnowledgeRavager>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<DeathWhistle>()}].",
            CalamityUtils.ColorMessage("Машина бесформенных жертв отправилась на поиски истинного нарушителя.", new Color(178, 34, 34)),
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/Ravager/Ravager_BossChecklist", AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value, new Vector2(rect.Center.X - value.Width / 2, rect.Center.Y - value.Height / 2), color);
            },
            "CalamityMod/NPCs/Ravager/RavagerBody_Head_Boss"
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Аструм Деус",
            17.5f,
            new List<int>
            {
                ModContent.NPCType<AstrumDeusHead>(),
                ModContent.NPCType<AstrumDeusBody>(),
                ModContent.NPCType<AstrumDeusTail>()
            },
            () => DownedBossSystem.downedAstrumDeus,
            new List<int>
            {
                ModContent.ItemType<TitanHeart>(),
                ModContent.ItemType<Starcore>()
            },
            new List<int>
            {
                ModContent.ItemType<AstrumDeusTrophy>(),
                ModContent.ItemType<AstrumDeusMask>(),
                ModContent.ItemType<KnowledgeAstrumDeus>(),
                ModContent.ItemType<KnowledgeAstralInfection>(),
                ModContent.ItemType<ChromaticOrb>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<TitanHeart>()}] или [i:{ModContent.ItemType<Starcore>()}] в качестве подношения на [i:{ModContent.ItemType<AstralBeaconItem>()}].",
            CalamityUtils.ColorMessage("Заражённое божество отступает к небесам.", new Color(255, 215, 0)),
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/AstrumDeus/AstrumDeus_BossChecklist", AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value, new Vector2(rect.Center.X - value.Width / 2, rect.Center.Y - value.Height / 2), color);
            },
            "CalamityMod/NPCs/AstrumDeus/AstrumDeusHead_Head_Boss"
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Осквернённые стражи",
            18.5f,
            ModContent.NPCType<ProfanedGuardianCommander>(),
            () => DownedBossSystem.downedGuardians,
            ModContent.ItemType<ProfanedShard>(),
            new List<int>
            {
                ModContent.ItemType<ProfanedGuardianTrophy>(),
                ModContent.ItemType<ProfanedGuardianMask>(),
                ModContent.ItemType<KnowledgeProfanedGuardians>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<ProfanedShard>()}] в освящении или в аду.",
            CalamityUtils.ColorMessage("Стражи должны защищать свою богиню любой ценой.", new Color(255, 165, 0)),
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/ProfanedGuardians/ProfanedGuardians_BossChecklist", AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value, new Vector2(rect.Center.X - value.Width / 2, rect.Center.Y - value.Height / 2), color);
            },
            "CalamityMod/NPCs/ProfanedGuardians/ProfanedGuardianCommander_Head_Boss"
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Псевдодракон",
            18.6f,
            ModContent.NPCType<Bumblefuck>(),
            () => DownedBossSystem.downedDragonfolly,
            ModContent.ItemType<ExoticPheromones>(),
            new List<int>
            {
                ModContent.ItemType<DragonfollyTrophy>(),
                ModContent.ItemType<BumblefuckMask>(),
                ModContent.ItemType<KnowledgeDragonfolly>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<ExoticPheromones>()}] в джунглях.",
            CalamityUtils.ColorMessage("Неудачный эксперимент вернулся к своему репродуктивному распорядку.", new Color(255, 215, 0)),
            () => true
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Провиденс",
            19.01f,
            ModContent.NPCType<Providence>(),
            () => DownedBossSystem.downedProvidence,
            ModContent.ItemType<ProfanedCore>(),
            new List<int>
            {
                ModContent.ItemType<ProvidenceTrophy>(),
                ModContent.ItemType<ProvidenceMask>(),
                ModContent.ItemType<KnowledgeProvidence>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<ProfanedCore>()}] в освящении или в аду.",
            CalamityUtils.ColorMessage("Осквернённая богиня исчезает в горящем пламени.", new Color(255, 165, 0)),
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/Providence/Providence_BossChecklist", AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value, new Vector2(rect.Center.X - value.Width / 2, rect.Center.Y - value.Height / 2), color);
            },
            "CalamityMod/NPCs/Providence/Providence_Head_Boss"
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Нескончаемая пустота",
            19.5f,
            new List<int>
            {
                ModContent.NPCType<CeaselessVoid>(),
                ModContent.NPCType<DarkEnergy>()
            },
            () => DownedBossSystem.downedCeaselessVoid,
            ModContent.ItemType<RuneofKos>(),
            new List<int>
            {
                ModContent.ItemType<CeaselessVoidTrophy>(),
                ModContent.ItemType<CeaselessVoidMask>(),
                ModContent.ItemType<AncientGodSlayerHelm>(),
                ModContent.ItemType<AncientGodSlayerChestplate>(),
                ModContent.ItemType<AncientGodSlayerLeggings>(),
                ModContent.ItemType<KnowledgeSentinels>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<RuneofKos>()}] в Темнице.",
            CalamityUtils.ColorMessage("Разлом во времени и пространстве удалился вдаль.", new Color(75, 0, 130)),
            () => true
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Штормовой ткач",
            19.51f,
            new List<int>
            {
                ModContent.NPCType<StormWeaverHead>(),
                ModContent.NPCType<StormWeaverBody>(),
                ModContent.NPCType<StormWeaverTail>()
            },
            () => DownedBossSystem.downedStormWeaver,
            ModContent.ItemType<RuneofKos>(),
            new List<int>
            {
                ModContent.ItemType<WeaverTrophy>(),
                ModContent.ItemType<StormWeaverMask>(),
                ModContent.ItemType<AncientGodSlayerHelm>(),
                ModContent.ItemType<AncientGodSlayerChestplate>(),
                ModContent.ItemType<AncientGodSlayerLeggings>(),
                ModContent.ItemType<KnowledgeSentinels>(),
                ModContent.ItemType<LittleLight>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<RuneofKos>()}] в космосе.",
            CalamityUtils.ColorMessage("Штормовой ткач снова спрятался в грозовом фронте.", new Color(238, 130, 238)),
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/StormWeaver/StormWeaver_BossChecklist", AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value, new Vector2(rect.Center.X - value.Width / 2, rect.Center.Y - value.Height / 2), color);
            },
            "CalamityMod/NPCs/StormWeaver/StormWeaverHead_Head_Boss"
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Сигнус",
            19.52f,
            ModContent.NPCType<Signus>(),
            () => DownedBossSystem.downedSignus,
            ModContent.ItemType<RuneofKos>(),
            new List<int>
            {
                ModContent.ItemType<SignusTrophy>(),
                ModContent.ItemType<SignusMask>(),
                ModContent.ItemType<AncientGodSlayerHelm>(),
                ModContent.ItemType<AncientGodSlayerChestplate>(),
                ModContent.ItemType<AncientGodSlayerLeggings>(),
                ModContent.ItemType<KnowledgeSentinels>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<RuneofKos>()}] в аду.",
            CalamityUtils.ColorMessage("Убийца Пожирателя выполнил свою лёгкую задачу.", new Color(186, 85, 211)),
            () => true
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Полтергаст",
            20f,
            new List<int>
            {
                ModContent.NPCType<Polterghast>(),
                ModContent.NPCType<PolterPhantom>()
            },
            () => DownedBossSystem.downedPolterghast,
            ModContent.ItemType<NecroplasmicBeacon>(),
            new List<int>
            {
                ModContent.ItemType<PolterghastTrophy>(),
                ModContent.ItemType<PolterghastMask>(),
                ModContent.ItemType<KnowledgePolterghast>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Убейте 30 фантомных духов или используйте [i:{ModContent.ItemType<NecroplasmicBeacon>()}] в Темнице.",
            CalamityUtils.ColorMessage("Нестабильные духи разбредаются по темнице.", new Color(176, 224, 230)),
            () => true
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Старый герцог",
            20.5f,
            new List<int>
            {
                ModContent.NPCType<OldDuke>()
            },
            () => DownedBossSystem.downedBoomerDuke,
            ModContent.ItemType<BloodwormItem>(),
            new List<int>
            {
                ModContent.ItemType<OldDukeTrophy>(),
                ModContent.ItemType<OldDukeMask>(),
                ModContent.ItemType<KnowledgeOldDuke>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Одолейте событие «Кислотный дождь» после победы над Полтергастом или выловите с помощью [i:{ModContent.ItemType<BloodwormItem>()}] в сернистом море.",
            CalamityUtils.ColorMessage("Старый герцог исчезает посреди кислотного ливня.", new Color(240, 230, 140)),
            () => true
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Пожиратель богов",
            21f,
            ModContent.NPCType<DevourerofGodsHead>(),
            () => DownedBossSystem.downedDoG,
            ModContent.ItemType<CosmicWorm>(),
            new List<int>
            {
                ModContent.ItemType<DevourerofGodsTrophy>(),
                ModContent.ItemType<DevourerofGodsMask>(),
                ModContent.ItemType<KnowledgeDevourerofGods>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<CosmicWorm>()}].",
            CalamityUtils.ColorMessage("Пожиратель богов убил всех и пировал их сущностью.", new Color(0, 255, 255)),
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/DevourerofGods/DevourerofGods_BossChecklist", AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value, new Vector2(rect.Center.X - value.Width / 2, rect.Center.Y - value.Height / 2), color);
            },
            "CalamityMod/NPCs/DevourerofGods/DevourerofGodsHead_Head_Boss"
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Ярон",
            22f,
            ModContent.NPCType<Yharon>(),
            () => DownedBossSystem.downedYharon,
            ModContent.ItemType<JungleDragonEgg>(),
            new List<int>
            {
                ModContent.ItemType<YharonTrophy>(),
                ModContent.ItemType<YharonMask>(),
                ModContent.ItemType<KnowledgeYharon>(),
                ModContent.ItemType<ForgottenDragonEgg>(),
                ModContent.ItemType<McNuggets>(),
                ModContent.ItemType<FoxDrive>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<JungleDragonEgg>()}] в джунглях.",
            CalamityUtils.ColorMessage("Ярон считает вас слишком слабым, чтобы оставаться с вашим надгробием.", new Color(255, 165, 0)),
            () => true,
            null,
            "CalamityMod/NPCs/Yharon/Yharon_Head_Boss"
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Экзо-механизмы",
            22.5f,
            new List<int>
            {
                ModContent.NPCType<Apollo>(),
                ModContent.NPCType<AresBody>(),
                ModContent.NPCType<Artemis>(),
                ModContent.NPCType<ThanatosHead>()
            },
            () => DownedBossSystem.downedExoMechs,
            null,
            new List<int>
            {
                ModContent.ItemType<AresTrophy>(),
                ModContent.ItemType<ThanatosTrophy>(),
                ModContent.ItemType<ArtemisTrophy>(),
                ModContent.ItemType<ApolloTrophy>(),
                ModContent.ItemType<DraedonMask>(),
                ModContent.ItemType<AresMask>(),
                ModContent.ItemType<ThanatosMask>(),
                ModContent.ItemType<ArtemisMask>(),
                ModContent.ItemType<ApolloMask>(),
                ModContent.ItemType<KnowledgeExoMechs>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            "При использовании высокотехнологичного компьютера.",
            CalamityUtils.ColorMessage("Несовершенство... какой позор.", new Color(127, 255, 212)),
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/ExoMechs/ExoMechs_BossChecklist", AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value, new Vector2(rect.Center.X - value.Width * 0.7f / 2f, rect.Center.Y - value.Height * 0.7f / 2f), null, color, 0f, Vector2.Zero, 0.7f, 0, 0f);
            }
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Высшая Каламитас",
            23f,
            ModContent.NPCType<SupremeCalamitas>(),
            () => DownedBossSystem.downedSCal,
            new List<int>
            {
                ModContent.ItemType<AshesofCalamity>(),
                ModContent.ItemType<CeremonialUrn>()
            },
            new List<int>
            {
                ModContent.ItemType<SupremeCalamitasTrophy>(),
                ModContent.ItemType<SupremeCataclysmTrophy>(),
                ModContent.ItemType<SupremeCatastropheTrophy>(),
                ModContent.ItemType<AshenHorns>(),
                ModContent.ItemType<SCalMask>(),
                ModContent.ItemType<SCalRobes>(),
                ModContent.ItemType<SCalBoots>(),
                ModContent.ItemType<KnowledgeCalamitas>(),
                ModContent.ItemType<BrimstoneJewel>(),
                ModContent.ItemType<Levi>(),
                ModContent.ItemType<ThankYouPainting>()
            },
            $"Используйте [i:{ModContent.ItemType<AshesofCalamity>()}] или [i:{ModContent.ItemType<CeremonialUrn>()}] в качестве подношения на [i:{ModContent.ItemType<AltarOfTheAccursedItem>()}].",
            CalamityUtils.ColorMessage("Пожалуйста, не трать моё время.", new Color(255, 165, 0)),
            () => true,
            null,
            "CalamityMod/NPCs/SupremeCalamitas/HoodedHeadIcon"
        );

        AddBoss(
            bosschecklist,
            calamity,
            "Эйдолонский змей",
            23.5f,
            ModContent.NPCType<AdultEidolonWyrmHead>(),
            () => DownedBossSystem.downedAdultEidolonWyrm,
            1326,
            new List<int> {ModContent.ItemType<ThankYouPainting>()},
            "Находясь в бездне, используйте предмет, который накладывает дебафф «Хаотичность».",
            CalamityUtils.ColorMessage("...", new Color(127, 255, 212)),
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/AdultEidolonWyrm/AdultEidolonWyrm_BossChecklist", AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value, new Vector2(rect.Center.X - value.Width / 2, rect.Center.Y - value.Height / 2), color);
            },
            "CalamityMod/NPCs/AdultEidolonWyrm/AdultEidolonWyrmHead_Head_Boss"
        );
    };

    private static void AddBoss(Mod bossChecklist, Mod hostMod, string name, float difficulty, List<int> npcTypes,
        Func<bool> downed, object summon, List<int> collection, string instructions, string despawn,
        Func<bool> available, Action<SpriteBatch, Rectangle, Color> portrait = null, string bossHeadTex = null)
    {
        bossChecklist.Call("AddBoss", hostMod, name, npcTypes, difficulty, downed, available, collection, summon, instructions, despawn, portrait, bossHeadTex);
    }

    private static void AddBoss(Mod bossChecklist, Mod hostMod, string name, float difficulty, int npcType, Func<bool> downed,
        object summon, List<int> collection, string instructions, string despawn, Func<bool> available,
        Action<SpriteBatch, Rectangle, Color> portrait = null, string bossHeadTex = null)
    {
        bossChecklist.Call("AddBoss", hostMod, name, npcType, difficulty, downed, available, collection, summon, instructions, despawn, portrait, bossHeadTex);
    }

    private static void AddMiniBoss(Mod bossChecklist, Mod hostMod, string name, float difficulty, int npcType,
        Func<bool> downed, object summon, List<int> collection, string instructions, string despawn,
        Func<bool> available, Action<SpriteBatch, Rectangle, Color> portrait = null, string bossHeadTex = null)
    {
        bossChecklist.Call("AddMiniBoss", hostMod, name, npcType, difficulty, downed, available, collection, summon, instructions, despawn, portrait, bossHeadTex);
    }
}

public class WeakReferenceSupportCensusSupport : OnPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && ModsCall.Census != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModsCall.Calamity?.Code.GetType("CalamityMod.WeakReferenceSupport")
        ?.GetMethod("CensusSupport", BindingFlags.Static | BindingFlags.NonPublic);

    private delegate void CensusSupportDelegate();

    public override Delegate Delegate { get; } = (CensusSupportDelegate orig) =>
    {
        ModsCall.Census.Call(
            "TownNPCCondition",
            ModContent.NPCType<SEAHOE>(),
            "Одолейте Гигантского моллюска после победы над Пустынным бичом"
        );
        ModsCall.Census.Call(
            "TownNPCCondition",
            ModContent.NPCType<THIEF>(),
            "В инвентаре должна находится [i:74] после победы над Скелетроном"
        );
        ModsCall.Census.Call(
            "TownNPCCondition",
            ModContent.NPCType<FAP>(),
            $"В инвентаре должна находится [i:{ModContent.ItemType<FabsolsVodka>()}] в Хардмоде"
        );
        ModsCall.Census.Call(
            "TownNPCCondition",
            ModContent.NPCType<DILF>(),
            "Одолейте Криогена"
        );
        ModsCall.Census.Call(
            "TownNPCCondition",
            ModContent.NPCType<WITCH>(),
            "Одолейте Высшую Каламитас"
        );
    };
}

public class WeakReferenceSupportAddCalamityInvasions : OnPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && ModsCall.BossChecklist != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModsCall.Calamity?.Code.GetType("CalamityMod.WeakReferenceSupport")
        ?.GetMethod("AddCalamityInvasions", BindingFlags.Static | BindingFlags.NonPublic);

    private delegate void AddCalamityInvasionsDelegate(Mod bossChecklist, Mod calamity);

    public override Delegate Delegate { get; } = (AddCalamityInvasionsDelegate orig, Mod bossChecklist, Mod calamity) =>
    {
        AddInvasion(
            bossChecklist,
            calamity,
            "Кислотный дождь",
            2.67f,
            new List<int>
            {
                ModContent.NPCType<NuclearToad>(),
                ModContent.NPCType<AcidEel>(),
                ModContent.NPCType<Radiator>(),
                ModContent.NPCType<Skyfin>(),
            },
            () => DownedBossSystem.downedEoCAcidRain,
            ModContent.ItemType<CausticTear>(),
            new List<int> {ModContent.ItemType<RadiatingCrystal>()},
            $"Используйте [i:{ModContent.ItemType<CausticTear>()}] или дождитесь, пока событие произойдёт естественным образом после победы над глазом Ктулху.",
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/Events/AcidRainT1_BossChecklist",
                    AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value,
                    new Vector2(rect.Center.X - value.Width * 1.3f / 2f, rect.Center.Y - value.Height * 1.3f / 2f),
                    null, color, 0f, Vector2.Zero, 1.3f, 0, 0f);
            },
            "CalamityMod/UI/MiscTextures/AcidRainIcon"
        );

        AddInvasion(
            bossChecklist,
            calamity,
            "Кислотный дождь (Пост-Аб)",
            9.51f,
            new List<int>
            {
                ModContent.NPCType<Radiator>(),
                ModContent.NPCType<AcidEel>(),
                ModContent.NPCType<NuclearToad>(),
                ModContent.NPCType<FlakCrab>(),
                ModContent.NPCType<Orthocera>(),
                ModContent.NPCType<Skyfin>(),
                ModContent.NPCType<Trilobite>(),
                ModContent.NPCType<SulphurousSkater>(),
                ModContent.NPCType<IrradiatedSlime>(),
                ModContent.NPCType<CragmawMire>(),
            },
            () => DownedBossSystem.downedAquaticScourgeAcidRain,
            new List<int> {ModContent.ItemType<CausticTear>()},
            new List<int> {ModContent.ItemType<RadiatingCrystal>()},
            $"Используйте [i:{ModContent.ItemType<CausticTear>()}] или дождитесь, пока событие произойдёт естественным образом после победы над Акватическим бичом.",
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/Events/AcidRainT2_BossChecklist", AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value, new Vector2(rect.Center.X - value.Width * 0.9f / 2f, rect.Center.Y - value.Height * 0.9f / 2f), null, color, 0f, Vector2.Zero, 0.9f, 0, 0f);
            },
            "CalamityMod/UI/MiscTextures/AcidRainIcon"
        );

        AddInvasion(
            bossChecklist,
            calamity,
            "Кислотный дождь (Пост-Полтер)",
            20.49f,
            new List<int>
            {
                ModContent.NPCType<Radiator>(),
                ModContent.NPCType<AcidEel>(),
                ModContent.NPCType<NuclearToad>(),
                ModContent.NPCType<FlakCrab>(),
                ModContent.NPCType<Orthocera>(),
                ModContent.NPCType<Skyfin>(),
                ModContent.NPCType<Trilobite>(),
                ModContent.NPCType<SulphurousSkater>(),
                ModContent.NPCType<GammaSlime>(),
                ModContent.NPCType<CragmawMire>(),
                ModContent.NPCType<Mauler>(),
                ModContent.NPCType<NuclearTerror>(),
            },
            () => DownedBossSystem.downedBoomerDuke,
            new List<int> {ModContent.ItemType<CausticTear>()},
            new List<int> {ModContent.ItemType<RadiatingCrystal>()},
            $"Используйте [i:{ModContent.ItemType<CausticTear>()}] или дождитесь, пока событие произойдёт естественным образом после победы над Полтергастом.",
            () => true,
            delegate(SpriteBatch sb, Rectangle rect, Color color)
            {
                Texture2D value = ModContent.Request<Texture2D>("CalamityMod/Events/AcidRainT3_BossChecklist", AssetRequestMode.ImmediateLoad).Value;
                sb.Draw(value, new Vector2(rect.Center.X - value.Width * 0.9f / 2f, rect.Center.Y - value.Height * 0.9f / 2f), null, color, 0f, Vector2.Zero, 0.9f, 0, 0f);
            },
            "CalamityMod/UI/MiscTextures/AcidRainIcon"
        );
    };

    private static void AddInvasion(Mod bossChecklist, Mod hostMod, string name, float difficulty, List<int> npcTypes,
        Func<bool> downed, object summon, List<int> collection, string instructions, Func<bool> available,
        Action<SpriteBatch, Rectangle, Color> portrait = null, string bossHeadTex = null)
    {
        bossChecklist.Call("AddEvent", hostMod, name, npcTypes, difficulty, downed, available, collection, summon, instructions, portrait, bossHeadTex);
    }
}