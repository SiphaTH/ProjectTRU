using Microsoft.Xna.Framework;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ModOfRedemption.Tiles
{
    internal class RedemptionTiles
    {
        public static void Setup()
        {
            Tiles();
        }

        private static void Tiles()
        {
            Mod redemption = ModLoader.GetMod("Redemption");

            ModTile tile1 = TileLoader.GetTile(redemption.TileType("AkanKirvesTrophyTile"));
            ModTranslation akanKirvesTrophyTile = tile1.CreateMapEntryName();
            akanKirvesTrophyTile.AddTranslation(GameCulture.Russian, "Топорище Акка - трофей");
            tile1.AddMapEntry(new Color(120, 85, 60), akanKirvesTrophyTile);

            ModTile tile2 = TileLoader.GetTile(redemption.TileType("AncientSapling"));
            ModTranslation ancientSapling = tile2.CreateMapEntryName();
            ancientSapling.AddTranslation(GameCulture.Russian, "Древний саженец");
            tile2.AddMapEntry(new Color(200, 200, 200), ancientSapling);

            ModTile tile3 = TileLoader.GetTile(redemption.TileType("AncientWoodBedTile"));
            ModTranslation ancientWoodBedTile = tile3.CreateMapEntryName();
            ancientWoodBedTile.AddTranslation(GameCulture.Russian, "Кровать из древней древесины");
            tile3.AddMapEntry(new Color(200, 200, 200), ancientWoodBedTile);

            ModTile tile4 = TileLoader.GetTile(redemption.TileType("AncientWoodChairTile"));
            ModTranslation ancientWoodChairTile = tile4.CreateMapEntryName();
            ancientWoodChairTile.AddTranslation(GameCulture.Russian, "Стул из древней древесины");
            tile4.AddMapEntry(new Color(200, 200, 200), ancientWoodChairTile);

            ModTile tile5 = TileLoader.GetTile(redemption.TileType("AncientWoodChestTile"));
            ModTranslation ancientWoodChestTile = tile5.CreateMapEntryName();
            ancientWoodChestTile.AddTranslation(GameCulture.Russian, "Сундук из древней древесины");
            tile5.AddMapEntry(new Color(200, 200, 200), ancientWoodChestTile);

            ModTile tile6 = TileLoader.GetTile(redemption.TileType("AncientWoodClockTile"));
            ModTranslation ancientWoodClockTile = tile6.CreateMapEntryName();
            ancientWoodClockTile.AddTranslation(GameCulture.Russian, "Часы из древней древесины");
            tile6.AddMapEntry(new Color(200, 200, 200), ancientWoodClockTile);

            ModTile tile7 = TileLoader.GetTile(redemption.TileType("AncientWoodDoorClosed"));
            ModTranslation ancientWoodDoorClosed = tile7.CreateMapEntryName();
            ancientWoodDoorClosed.AddTranslation(GameCulture.Russian, "Дверь из древней древесины");
            tile7.AddMapEntry(new Color(200, 200, 200), ancientWoodDoorClosed);

            ModTile tile8 = TileLoader.GetTile(redemption.TileType("AncientWoodDoorOpen"));
            ModTranslation ancientWoodDoorOpen = tile8.CreateMapEntryName();
            ancientWoodDoorOpen.AddTranslation(GameCulture.Russian, "Дверь из древней древесины");
            tile8.AddMapEntry(new Color(200, 200, 200), ancientWoodDoorOpen);

            ModTile tile9 = TileLoader.GetTile(redemption.TileType("AncientWoodTableTile"));
            ModTranslation ancientWoodTableTile = tile9.CreateMapEntryName();
            ancientWoodTableTile.AddTranslation(GameCulture.Russian, "Стол из древней древесины");
            tile9.AddMapEntry(new Color(200, 200, 200), ancientWoodTableTile);

            ModTile tile10 = TileLoader.GetTile(redemption.TileType("AncientWoodWorkbenchTile"));
            ModTranslation ancientWoodWorkbenchTile = tile10.CreateMapEntryName();
            ancientWoodWorkbenchTile.AddTranslation(GameCulture.Russian, "Верстак из древней древесины");
            tile10.AddMapEntry(new Color(200, 200, 200), ancientWoodWorkbenchTile);

            ModTile tile110 = TileLoader.GetTile(redemption.TileType("AnglonicMysticBlossomTile"));
            ModTranslation anglonicMysticBlossomTile = tile110.CreateMapEntryName();
            anglonicMysticBlossomTile.AddTranslation(GameCulture.Russian, "Ангулонов мистический цветок");
            tile110.AddMapEntry(new Color(144, 148, 144), anglonicMysticBlossomTile);

            ModTile tile11 = TileLoader.GetTile(redemption.TileType("BotanistStationTile"));
            ModTranslation botanistStationTile = tile11.CreateMapEntryName();
            botanistStationTile.AddTranslation(GameCulture.Russian, "Ботаническая станция");
            tile11.AddMapEntry(new Color(200, 200, 200), botanistStationTile);

            ModTile tile12 = TileLoader.GetTile(redemption.TileType("BrothersPaintingTile"));
            ModTranslation brothersPaintingTile = tile12.CreateMapEntryName();
            brothersPaintingTile.AddTranslation(GameCulture.Russian, "Картина 'Братья?'");
            tile12.AddMapEntry(new Color(120, 85, 60), brothersPaintingTile);

            ModTile tile13 = TileLoader.GetTile(redemption.TileType("BrothersPaintingTileBig"));
            ModTranslation brothersPaintingTileBig = tile13.CreateMapEntryName();
            brothersPaintingTileBig.AddTranslation(GameCulture.Russian, "'Братья?'");
            tile13.AddMapEntry(new Color(56, 36, 59), brothersPaintingTileBig);

            ModTile tile14 = TileLoader.GetTile(redemption.TileType("ChickenInvasionBoxTile"));
            ModTranslation chickenInvasionBoxTile = tile14.CreateMapEntryName();
            chickenInvasionBoxTile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile14.AddMapEntry(new Color(200, 200, 200), chickenInvasionBoxTile);

            ModTile tile15 = TileLoader.GetTile(redemption.TileType("CorruptorTile"));
            ModTranslation corruptorTile = tile15.CreateMapEntryName();
            corruptorTile.AddTranslation(GameCulture.Russian, "Гирус-заражатель");
            tile15.AddMapEntry(new Color(200, 70, 70), corruptorTile);

            ModTile tile16 = TileLoader.GetTile(redemption.TileType("DeadSapling"));
            ModTranslation deadSapling = tile16.CreateMapEntryName();
            deadSapling.AddTranslation(GameCulture.Russian, "Окаменевший саженец");
            tile16.AddMapEntry(new Color(200, 200, 200), deadSapling);

            ModTile tile17 = TileLoader.GetTile(redemption.TileType("DeadWoodBedTile"));
            ModTranslation deadWoodBedTile = tile17.CreateMapEntryName();
            deadWoodBedTile.AddTranslation(GameCulture.Russian, "Кровать из окаменевшей древесины");
            tile17.AddMapEntry(new Color(200, 200, 200), deadWoodBedTile);

            ModTile tile18 = TileLoader.GetTile(redemption.TileType("DeadWoodChairTile"));
            ModTranslation deadWoodChairTile = tile18.CreateMapEntryName();
            deadWoodChairTile.AddTranslation(GameCulture.Russian, "Стул из окаменевшей древесины");
            tile18.AddMapEntry(new Color(200, 200, 200), deadWoodChairTile);

            ModTile tile19 = TileLoader.GetTile(redemption.TileType("DeadWoodChestTile"));
            ModTranslation deadWoodChestTile = tile19.CreateMapEntryName();
            deadWoodChestTile.AddTranslation(GameCulture.Russian, "Сундук из окаменевшей древесины");
            tile19.AddMapEntry(new Color(200, 200, 200), deadWoodChestTile);

            ModTile tile20 = TileLoader.GetTile(redemption.TileType("DeadWoodClockTile"));
            ModTranslation deadWoodClockTile = tile20.CreateMapEntryName();
            deadWoodClockTile.AddTranslation(GameCulture.Russian, "Часы из окаменевшей древесины");
            tile20.AddMapEntry(new Color(200, 200, 200), deadWoodClockTile);

            ModTile tile21 = TileLoader.GetTile(redemption.TileType("DeadWoodDoorClosed"));
            ModTranslation deadWoodDoorClosed = tile21.CreateMapEntryName();
            deadWoodDoorClosed.AddTranslation(GameCulture.Russian, "Дверь из окаменевшей древесины");
            tile21.AddMapEntry(new Color(200, 200, 200), deadWoodDoorClosed);

            ModTile tile22 = TileLoader.GetTile(redemption.TileType("DeadWoodDoorOpen"));
            ModTranslation deadWoodDoorOpen = tile22.CreateMapEntryName();
            deadWoodDoorOpen.AddTranslation(GameCulture.Russian, "Дверь из окаменевшей древесины");
            tile22.AddMapEntry(new Color(200, 200, 200), deadWoodDoorOpen);

            ModTile tile23 = TileLoader.GetTile(redemption.TileType("DeadWoodDresserTile"));
            ModTranslation deadWoodDresserTile = tile23.CreateMapEntryName();
            deadWoodDresserTile.AddTranslation(GameCulture.Russian, "Комод из окаменевшей древесины");
            tile23.AddMapEntry(new Color(200, 200, 200), deadWoodDresserTile);

            ModTile tile24 = TileLoader.GetTile(redemption.TileType("DeadWoodTableTile"));
            ModTranslation deadWoodTableTile = tile24.CreateMapEntryName();
            deadWoodTableTile.AddTranslation(GameCulture.Russian, "Стол из окаменевшей древесины");
            tile24.AddMapEntry(new Color(200, 200, 200), deadWoodTableTile);

            ModTile tile25 = TileLoader.GetTile(redemption.TileType("DragonLeadOreTile"));
            ModTranslation dragonLeadOreTile = tile25.CreateMapEntryName();
            dragonLeadOreTile.AddTranslation(GameCulture.Russian, "Кусок драконьего свинца");
            tile25.AddMapEntry(new Color(251, 177, 81), dragonLeadOreTile);

            ModTile tile26 = TileLoader.GetTile(redemption.TileType("DruidicAltarTile"));
            ModTranslation druidicAltarTile = tile26.CreateMapEntryName();
            druidicAltarTile.AddTranslation(GameCulture.Russian, "Друидский алтарь");
            tile26.AddMapEntry(new Color(200, 200, 200), druidicAltarTile);

            ModTile tile27 = TileLoader.GetTile(redemption.TileType("ForestBossBox2Tile"));
            ModTranslation forestBossBox2Tile = tile27.CreateMapEntryName();
            forestBossBox2Tile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile27.AddMapEntry(new Color(200, 200, 200), forestBossBox2Tile);

            ModTile tile28 = TileLoader.GetTile(redemption.TileType("ForestBossBoxTile"));
            ModTranslation forestBossBoxTile = tile28.CreateMapEntryName();
            forestBossBoxTile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile28.AddMapEntry(new Color(200, 200, 200), forestBossBoxTile);

            ModTile tile29 = TileLoader.GetTile(redemption.TileType("ForestGolemPaintingTile"));
            ModTranslation forestGolemPaintingTile = tile29.CreateMapEntryName();
            forestGolemPaintingTile.AddTranslation(GameCulture.Russian, "Картина с лесным големом");
            tile29.AddMapEntry(new Color(120, 85, 60), forestGolemPaintingTile);

            ModTile tile30 = TileLoader.GetTile(redemption.TileType("GathicCryoFurnaceTile"));
            ModTranslation gathicCryoFurnaceTile = tile30.CreateMapEntryName();
            gathicCryoFurnaceTile.AddTranslation(GameCulture.Russian, "Гатуранова крио-печь");
            tile30.AddMapEntry(new Color(200, 200, 200), gathicCryoFurnaceTile);

            ModTile tile31 = TileLoader.GetTile(redemption.TileType("HallOfHeroesBoxTile"));
            ModTranslation hallOfHeroesBoxTile = tile31.CreateMapEntryName();
            hallOfHeroesBoxTile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile31.AddMapEntry(new Color(200, 200, 200), hallOfHeroesBoxTile);

            ModTile tile32 = TileLoader.GetTile(redemption.TileType("HardenedSludge2Tile"));
            ModTranslation hardenedSludge2Tile = tile32.CreateMapEntryName();
            hardenedSludge2Tile.AddTranslation(GameCulture.Russian, "Затвердевшая слякоть");
            tile32.AddMapEntry(new Color(170, 255, 100), hardenedSludge2Tile);

            ModTile tile33 = TileLoader.GetTile(redemption.TileType("HardenedSludge3Tile"));
            ModTranslation hardenedSludge3Tile = tile33.CreateMapEntryName();
            hardenedSludge3Tile.AddTranslation(GameCulture.Russian, "Затвердевшая слякоть");
            tile33.AddMapEntry(new Color(20, 50, 20), hardenedSludge3Tile);

            ModTile tile34 = TileLoader.GetTile(redemption.TileType("HardenedSludgeTile"));
            ModTranslation hardenedSludgeTile = tile34.CreateMapEntryName();
            hardenedSludgeTile.AddTranslation(GameCulture.Russian, "Затвердевшая слякоть");
            tile34.AddMapEntry(new Color(100, 255, 100), hardenedSludgeTile);

            ModTile tile35 = TileLoader.GetTile(redemption.TileType("InfectedEyeBoxTile"));
            ModTranslation infectedEyeBoxTile = tile35.CreateMapEntryName();
            infectedEyeBoxTile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile35.AddMapEntry(new Color(200, 200, 200), infectedEyeBoxTile);

            ModTile tile36 = TileLoader.GetTile(redemption.TileType("InfectedEyeTrophyBlock"));
            ModTranslation infectedEyeTrophyBlock = tile36.CreateMapEntryName();
            infectedEyeTrophyBlock.AddTranslation(GameCulture.Russian, "Трофей Зараженного глаза");
            tile36.AddMapEntry(new Color(120, 85, 60), infectedEyeTrophyBlock);

            ModTile tile37 = TileLoader.GetTile(redemption.TileType("KaniteOreTile"));
            ModTranslation kaniteOreTile = tile37.CreateMapEntryName();
            kaniteOreTile.AddTranslation(GameCulture.Russian, "Канит");
            tile37.AddMapEntry(new Color(116, 138, 153), kaniteOreTile);

            ModTile tile38 = TileLoader.GetTile(redemption.TileType("KeeperBoxTile"));
            ModTranslation keeperBoxTile = tile38.CreateMapEntryName();
            keeperBoxTile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile38.AddMapEntry(new Color(200, 200, 200), keeperBoxTile);

            ModTile tile39 = TileLoader.GetTile(redemption.TileType("KingChickenTrophyTile"));
            ModTranslation kingChickenTrophyTile = tile39.CreateMapEntryName();
            kingChickenTrophyTile.AddTranslation(GameCulture.Russian, "Трофей куриного короля");
            tile39.AddMapEntry(new Color(120, 85, 60), kingChickenTrophyTile);

            ModTile tile40 = TileLoader.GetTile(redemption.TileType("KSBoxTile"));
            ModTranslation ksBoxTile = tile40.CreateMapEntryName();
            ksBoxTile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile40.AddMapEntry(new Color(200, 200, 200), ksBoxTile);

            ModTile tile41 = TileLoader.GetTile(redemption.TileType("LabBossMusicBoxTile"));
            ModTranslation labBossMusicBoxTile = tile41.CreateMapEntryName();
            labBossMusicBoxTile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile41.AddMapEntry(new Color(200, 200, 200), labBossMusicBoxTile);

            ModTile tile42 = TileLoader.GetTile(redemption.TileType("LabMusicBoxTile"));
            ModTranslation labMusicBoxTile = tile42.CreateMapEntryName();
            labMusicBoxTile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile42.AddMapEntry(new Color(200, 200, 200), labMusicBoxTile);

            ModTile tile43 = TileLoader.GetTile(redemption.TileType("LilyBannerTile"));
            ModTranslation lilyBannerTile = tile43.CreateMapEntryName();
            lilyBannerTile.AddTranslation(GameCulture.Russian, "Рунное знамя лилии");
            tile43.AddMapEntry(new Color(200, 200, 200), lilyBannerTile);

            ModTile tile44 = TileLoader.GetTile(redemption.TileType("LotusBannerTile"));
            ModTranslation lotusBannerTile = tile44.CreateMapEntryName();
            lotusBannerTile.AddTranslation(GameCulture.Russian, "Рунное знамя лотоса");
            tile44.AddMapEntry(new Color(200, 200, 200), lotusBannerTile);

            ModTile tile45 = TileLoader.GetTile(redemption.TileType("NebBox2Tile"));
            ModTranslation nebBox2Tile = tile45.CreateMapEntryName();
            nebBox2Tile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile45.AddMapEntry(new Color(200, 200, 200), nebBox2Tile);

            ModTile tile46 = TileLoader.GetTile(redemption.TileType("NebBoxTile"));
            ModTranslation nebBoxTile = tile46.CreateMapEntryName();
            nebBoxTile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile46.AddMapEntry(new Color(200, 200, 200), nebBoxTile);

            ModTile tile47 = TileLoader.GetTile(redemption.TileType("NebuleusTrophyTile"));
            ModTranslation nebuleusTrophyTile = tile47.CreateMapEntryName();
            nebuleusTrophyTile.AddTranslation(GameCulture.Russian, "Трофей Небулеуса");
            tile47.AddMapEntry(new Color(120, 85, 60), nebuleusTrophyTile);

            ModTile tile48 = TileLoader.GetTile(redemption.TileType("PlantMatterTile"));
            ModTranslation plantMatterTile = tile48.CreateMapEntryName();
            plantMatterTile.AddTranslation(GameCulture.Russian, "Растительная материя");
            tile48.AddMapEntry(new Color(60, 200, 60), plantMatterTile);

            ModTile tile49 = TileLoader.GetTile(redemption.TileType("PZMusicBoxTile"));
            ModTranslation pzMusicBoxTile = tile49.CreateMapEntryName();
            pzMusicBoxTile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile49.AddMapEntry(new Color(200, 200, 200), pzMusicBoxTile);

            ModTile tile50 = TileLoader.GetTile(redemption.TileType("PZTrophyTile"));
            ModTranslation pzTrophyTile = tile50.CreateMapEntryName();
            pzTrophyTile.AddTranslation(GameCulture.Russian, "Трофей Нулевого пациента");
            tile50.AddMapEntry(new Color(120, 85, 60), pzTrophyTile);

            ModTile tile51 = TileLoader.GetTile(redemption.TileType("SapphironOreTile"));
            ModTranslation sapphironOreTile = tile51.CreateMapEntryName();
            sapphironOreTile.AddTranslation(GameCulture.Russian, "Сапфирон");
            tile51.AddMapEntry(new Color(50, 50, 100), sapphironOreTile);

            ModTile tile52 = TileLoader.GetTile(redemption.TileType("ScarlionOreTile"));
            ModTranslation scarlionOreTile = tile52.CreateMapEntryName();
            scarlionOreTile.AddTranslation(GameCulture.Russian, "Скарлион");
            tile52.AddMapEntry(new Color(100, 50, 50), scarlionOreTile);

            ModTile tile53 = TileLoader.GetTile(redemption.TileType("SeedOfInfectionTrophyTile"));
            ModTranslation seedOfInfectionTrophyTile = tile53.CreateMapEntryName();
            seedOfInfectionTrophyTile.AddTranslation(GameCulture.Russian, "Трофей Семени заражения");
            tile53.AddMapEntry(new Color(120, 85, 60), seedOfInfectionTrophyTile);

            ModTile tile54 = TileLoader.GetTile(redemption.TileType("ShinkiteTile"));
            ModTranslation shinkiteTile = tile54.CreateMapEntryName();
            shinkiteTile.AddTranslation(GameCulture.Russian, "Необработанный шинкит");
            tile54.AddMapEntry(new Color(41, 24, 32), shinkiteTile);

            ModTile tile55 = TileLoader.GetTile(redemption.TileType("SlayerTrophyTile"));
            ModTranslation slayerTrophyTile = tile55.CreateMapEntryName();
            slayerTrophyTile.AddTranslation(GameCulture.Russian, "Трофей Убийцы королей");
            tile55.AddMapEntry(new Color(120, 85, 60), slayerTrophyTile);

            ModTile tile56 = TileLoader.GetTile(redemption.TileType("StarliteOreTile"));
            ModTranslation starliteOreTile = tile56.CreateMapEntryName();
            starliteOreTile.AddTranslation(GameCulture.Russian, "Старлит");
            tile56.AddMapEntry(new Color(50, 120, 160), starliteOreTile);

            ModTile tile57 = TileLoader.GetTile(redemption.TileType("TheKeeperTrophyTile"));
            ModTranslation theKeeperTrophyTile = tile57.CreateMapEntryName();
            theKeeperTrophyTile.AddTranslation(GameCulture.Russian, "Сердце Хранительницы");
            tile57.AddMapEntry(new Color(120, 85, 60), theKeeperTrophyTile);

            ModTile tile58 = TileLoader.GetTile(redemption.TileType("ThornTrophyTile"));
            ModTranslation thornTrophyTile = tile58.CreateMapEntryName();
            thornTrophyTile.AddTranslation(GameCulture.Russian, "Трофей Терна");
            tile58.AddMapEntry(new Color(120, 85, 60), thornTrophyTile);

            ModTile tile59 = TileLoader.GetTile(redemption.TileType("UkonKirvesTrophyTile"));
            ModTranslation ukonKirvesTrophyTile = tile59.CreateMapEntryName();
            ukonKirvesTrophyTile.AddTranslation(GameCulture.Russian, "Топорище Укко - трофей");
            tile59.AddMapEntry(new Color(120, 85, 60), ukonKirvesTrophyTile);

            ModTile tile60 = TileLoader.GetTile(redemption.TileType("UltraVioletPlatingTile"));
            ModTranslation ultraVioletPlatingTile = tile60.CreateMapEntryName();
            ultraVioletPlatingTile.AddTranslation(GameCulture.Russian, "Ультрафиолетовое покрытие");
            tile60.AddMapEntry(new Color(200, 0, 200), ultraVioletPlatingTile);

            ModTile tile61 = TileLoader.GetTile(redemption.TileType("VlitchBoxTile"));
            ModTranslation vlitchBoxTile = tile61.CreateMapEntryName();
            vlitchBoxTile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile61.AddMapEntry(new Color(200, 200, 200), vlitchBoxTile);

            ModTile tile62 = TileLoader.GetTile(redemption.TileType("VlitchBoxTile2"));
            ModTranslation vlitchBoxTile2 = tile62.CreateMapEntryName();
            vlitchBoxTile2.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile62.AddMapEntry(new Color(200, 200, 200), vlitchBoxTile2);

            ModTile tile63 = TileLoader.GetTile(redemption.TileType("VlitchPlatingTile"));
            ModTranslation vlitchPlatingTile = tile63.CreateMapEntryName();
            vlitchPlatingTile.AddTranslation(GameCulture.Russian, "Висбоящее покрытие");
            tile63.AddMapEntry(new Color(200, 0, 0), vlitchPlatingTile);

            ModTile tile64 = TileLoader.GetTile(redemption.TileType("VlitchTrophyTile"));
            ModTranslation vlitchTrophyTile = tile64.CreateMapEntryName();
            vlitchTrophyTile.AddTranslation(GameCulture.Russian, "Трофей Висбоящего владыки");
            tile64.AddMapEntry(new Color(120, 85, 60), vlitchTrophyTile);

            ModTile tile65 = TileLoader.GetTile(redemption.TileType("WastelandBoxTile"));
            ModTranslation wastelandBoxTile = tile65.CreateMapEntryName();
            wastelandBoxTile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile65.AddMapEntry(new Color(200, 200, 200), wastelandBoxTile);

            ModTile tile66 = TileLoader.GetTile(redemption.TileType("XenoForgeTile"));
            ModTranslation xenoForgeTile = tile66.CreateMapEntryName();
            xenoForgeTile.AddTranslation(GameCulture.Russian, "Ксенопечь");
            tile66.AddMapEntry(new Color(200, 200, 200), xenoForgeTile);

            ModTile tile67 = TileLoader.GetTile(redemption.TileType("XenomiteCrystalBoxTile"));
            ModTranslation xenomiteCrystalBoxTile = tile67.CreateMapEntryName();
            xenomiteCrystalBoxTile.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
            tile67.AddMapEntry(new Color(200, 200, 200), xenomiteCrystalBoxTile);

            ModTile tile68 = TileLoader.GetTile(redemption.TileType("XenomiteCrystalTrophyTile"));
            ModTranslation xenomiteCrystalTrophyTile = tile68.CreateMapEntryName();
            xenomiteCrystalTrophyTile.AddTranslation(GameCulture.Russian, "Трофей Ксеномитного кристалла");
            tile68.AddMapEntry(new Color(120, 85, 60), xenomiteCrystalTrophyTile);

            ModTile tile69 = TileLoader.GetTile(redemption.TileType("XenomiteOreBlock"));
            ModTranslation xenomiteOreBlock = tile69.CreateMapEntryName();
            xenomiteOreBlock.AddTranslation(GameCulture.Russian, "Ксеномит");
            tile69.AddMapEntry(new Color(120, 100, 255), xenomiteOreBlock);

            ModTile tile70 = TileLoader.GetTile(redemption.TileType("BotHangerEmptyTile"));
            ModTranslation botHangerEmptyTile = tile70.CreateMapEntryName();
            botHangerEmptyTile.AddTranslation(GameCulture.Russian, "Держатель ботов");
            tile70.AddMapEntry(new Color(100, 150, 100), botHangerEmptyTile);

            ModTile tile71 = TileLoader.GetTile(redemption.TileType("BotHangerOccupiedTile"));
            ModTranslation botHangerOccupiedTile = tile71.CreateMapEntryName();
            botHangerOccupiedTile.AddTranslation(GameCulture.Russian, "Держатель ботов");
            tile71.AddMapEntry(new Color(100, 150, 100), botHangerOccupiedTile);

            ModTile tile72 = TileLoader.GetTile(redemption.TileType("CeilingMonitorTile"));
            ModTranslation ceilingMonitorTile = tile72.CreateMapEntryName();
            ceilingMonitorTile.AddTranslation(GameCulture.Russian, "Потолочный монитор");
            tile72.AddMapEntry(new Color(150, 150, 200), ceilingMonitorTile);

            ModTile tile73 = TileLoader.GetTile(redemption.TileType("ComputerTile"));
            ModTranslation computerTile = tile73.CreateMapEntryName();
            computerTile.AddTranslation(GameCulture.Russian, "Компьютер");
            tile73.AddMapEntry(new Color(150, 170, 150), computerTile);

            ModTile tile74 = TileLoader.GetTile(redemption.TileType("Corpse1"));
            ModTranslation corpse1 = tile74.CreateMapEntryName();
            corpse1.AddTranslation(GameCulture.Russian, "Труп");
            tile74.AddMapEntry(new Color(40, 80, 50), corpse1);

            ModTile tile75 = TileLoader.GetTile(redemption.TileType("Corpse2"));
            ModTranslation corpse2 = tile75.CreateMapEntryName();
            corpse2.AddTranslation(GameCulture.Russian, "Труп");
            tile75.AddMapEntry(new Color(40, 80, 50), corpse2);

            ModTile tile76 = TileLoader.GetTile(redemption.TileType("Corpse3"));
            ModTranslation corpse3 = tile76.CreateMapEntryName();
            corpse3.AddTranslation(GameCulture.Russian, "Труп");
            tile76.AddMapEntry(new Color(40, 80, 50), corpse3);

            ModTile tile77 = TileLoader.GetTile(redemption.TileType("IntercomTile"));
            ModTranslation intercomTile = tile77.CreateMapEntryName();
            intercomTile.AddTranslation(GameCulture.Russian, "Интерком");
            tile77.AddMapEntry(new Color(120, 120, 120), intercomTile);

            ModTile tile78 = TileLoader.GetTile(redemption.TileType("LabBedTile"));
            ModTranslation labBedTile = tile78.CreateMapEntryName();
            labBedTile.AddTranslation(GameCulture.Russian, "Медицинская кровать");
            tile78.AddMapEntry(new Color(120, 120, 200), labBedTile);

            ModTile tile79 = TileLoader.GetTile(redemption.TileType("LabBookshelfTile"));
            ModTranslation labBookshelfTile = tile79.CreateMapEntryName();
            labBookshelfTile.AddTranslation(GameCulture.Russian, "Сервер");
            tile79.AddMapEntry(new Color(140, 170, 120), labBookshelfTile);

            ModTile tile111 = TileLoader.GetTile(redemption.TileType("LabCeilingLampTile"));
            ModTranslation labCeilingLampTile = tile111.CreateMapEntryName();
            labCeilingLampTile.AddTranslation(GameCulture.Russian, "Потолочная лампа");
            tile111.AddMapEntry(new Color(150, 150, 200), labCeilingLampTile);

            ModTile tile80 = TileLoader.GetTile(redemption.TileType("LabChairTile"));
            ModTranslation labChairTile = tile80.CreateMapEntryName();
            labChairTile.AddTranslation(GameCulture.Russian, "Лабораторное кресло");
            tile80.AddMapEntry(new Color(210, 220, 210), labChairTile);

            ModTile tile112 = TileLoader.GetTile(redemption.TileType("LabChestTile"));
            ModTranslation labChestTile = tile112.CreateMapEntryName();
            labChestTile.AddTranslation(GameCulture.Russian, "Лабораторный сундук");
            tile112.AddMapEntry(new Color(70, 120, 180), labChestTile);

            ModTile tile81 = TileLoader.GetTile(redemption.TileType("LabChestTileLocked"));
            ModTranslation labChestTileLocked = tile81.CreateMapEntryName();
            labChestTileLocked.AddTranslation(GameCulture.Russian, "Лабораторный сундук");
            tile81.AddMapEntry(new Color(0, 0, 255), labChestTileLocked);

            ModTile tile82 = TileLoader.GetTile(redemption.TileType("LabChestTileLocked2"));
            ModTranslation labChestTileLocked2 = tile82.CreateMapEntryName();
            labChestTileLocked2.AddTranslation(GameCulture.Russian, "Лабораторный сундук");
            tile82.AddMapEntry(new Color(0, 0, 255), labChestTileLocked2);

            ModTile tile83 = TileLoader.GetTile(redemption.TileType("LabDoor3TileClosed"));
            ModTranslation labDoor3TileClosed = tile83.CreateMapEntryName();
            labDoor3TileClosed.AddTranslation(GameCulture.Russian, "Маленькая лабораторная дверь");
            tile83.AddMapEntry(new Color(100, 70, 0), labDoor3TileClosed);

            ModTile tile84 = TileLoader.GetTile(redemption.TileType("LabDoor3TileOpen"));
            ModTranslation labDoor3TileOpen = tile84.CreateMapEntryName();
            labDoor3TileOpen.AddTranslation(GameCulture.Russian, "Маленькая лабораторная дверь");
            tile84.AddMapEntry(new Color(200, 200, 200), labDoor3TileOpen);

            ModTile tile85 = TileLoader.GetTile(redemption.TileType("LabFanTile1"));
            ModTranslation labFanTile1 = tile85.CreateMapEntryName();
            labFanTile1.AddTranslation(GameCulture.Russian, "Лабораторный вентилятор");
            tile85.AddMapEntry(new Color(80, 80, 80), labFanTile1);

            ModTile tile86 = TileLoader.GetTile(redemption.TileType("LabForgeTile"));
            ModTranslation labForgeTile = tile86.CreateMapEntryName();
            labForgeTile.AddTranslation(GameCulture.Russian, "Ксеноплав");
            tile86.AddMapEntry(new Color(120, 170, 120), labForgeTile);

            ModTile tile87 = TileLoader.GetTile(redemption.TileType("LabTableTile"));
            ModTranslation labTableTile = tile87.CreateMapEntryName();
            labTableTile.AddTranslation(GameCulture.Russian, "Лабораторный стол");
            tile87.AddMapEntry(new Color(210, 220, 205), labTableTile);

            ModTile tile88 = TileLoader.GetTile(redemption.TileType("LabTubesTile"));
            ModTranslation labTubesTile = tile88.CreateMapEntryName();
            labTubesTile.AddTranslation(GameCulture.Russian, "Тестовые трубы");
            tile88.AddMapEntry(new Color(150, 170, 150), labTubesTile);

            ModTile tile89 = TileLoader.GetTile(redemption.TileType("LabWorkbenchTile"));
            ModTranslation labWorkbenchTile = tile89.CreateMapEntryName();
            labWorkbenchTile.AddTranslation(GameCulture.Russian, "Лабораторный верстак");
            tile89.AddMapEntry(new Color(210, 205, 210), labWorkbenchTile);

            ModTile tile90 = TileLoader.GetTile(redemption.TileType("MossyLabTableTile"));
            ModTranslation mossyLabTableTile = tile90.CreateMapEntryName();
            mossyLabTableTile.AddTranslation(GameCulture.Russian, "Замшелый лабораторный стол");
            tile90.AddMapEntry(new Color(210, 220, 205), mossyLabTableTile);

            ModTile tile91 = TileLoader.GetTile(redemption.TileType("ReceptionDeskMonitorsTile"));
            ModTranslation receptionDeskMonitorsTile = tile91.CreateMapEntryName();
            receptionDeskMonitorsTile.AddTranslation(GameCulture.Russian, "Мониторы приемной");
            tile91.AddMapEntry(new Color(150, 150, 200), receptionDeskMonitorsTile);

            ModTile tile92 = TileLoader.GetTile(redemption.TileType("Sign1Tile"));
            ModTranslation sign1Tile = tile92.CreateMapEntryName();
            sign1Tile.AddTranslation(GameCulture.Russian, "Знак опасности");
            tile92.AddMapEntry(new Color(90, 90, 50), sign1Tile);

            ModTile tile93 = TileLoader.GetTile(redemption.TileType("SignBoiTile"));
            ModTranslation signBoiTile = tile93.CreateMapEntryName();
            signBoiTile.AddTranslation(GameCulture.Russian, "Знак биологической опасности");
            tile93.AddMapEntry(new Color(90, 90, 40), signBoiTile);

            ModTile tile94 = TileLoader.GetTile(redemption.TileType("SignDeathTile"));
            ModTranslation signDeathTile = tile94.CreateMapEntryName();
            signDeathTile.AddTranslation(GameCulture.Russian, "Знак с черепом");
            tile94.AddMapEntry(new Color(90, 90, 40), signDeathTile);

            ModTile tile95 = TileLoader.GetTile(redemption.TileType("SignElectricTile"));
            ModTranslation signElectricTile = tile95.CreateMapEntryName();
            signElectricTile.AddTranslation(GameCulture.Russian, "Знак электричества");
            tile95.AddMapEntry(new Color(90, 90, 40), signElectricTile);

            ModTile tile96 = TileLoader.GetTile(redemption.TileType("SignRadioactiveTile"));
            ModTranslation signRadioactiveTile = tile96.CreateMapEntryName();
            signRadioactiveTile.AddTranslation(GameCulture.Russian, "Знак радиации");
            tile96.AddMapEntry(new Color(90, 90, 40), signRadioactiveTile);

            ModTile tile97 = TileLoader.GetTile(redemption.TileType("XenoTank1"));
            ModTranslation xenoTank1 = tile97.CreateMapEntryName();
            xenoTank1.AddTranslation(GameCulture.Russian, "Ксено-обрабатыватель");
            tile97.AddMapEntry(new Color(120, 170, 120), xenoTank1);

            ModTile tile98 = TileLoader.GetTile(redemption.TileType("LabBossDoorTile1"));
            ModTranslation labBossDoorTile1 = tile98.CreateMapEntryName();
            labBossDoorTile1.AddTranslation(GameCulture.Russian, "Армированная дверь");
            tile98.AddMapEntry(new Color(80, 100, 80), labBossDoorTile1);

            ModTile tile99 = TileLoader.GetTile(redemption.TileType("LabBossDoorTile1H"));
            ModTranslation labBossDoorTile1H = tile99.CreateMapEntryName();
            labBossDoorTile1H.AddTranslation(GameCulture.Russian, "Армированная дверь");
            tile99.AddMapEntry(new Color(80, 100, 80), labBossDoorTile1H);

            ModTile tile100 = TileLoader.GetTile(redemption.TileType("HolochestTile"));
            ModTranslation holochestTile = tile100.CreateMapEntryName();
            holochestTile.AddTranslation(GameCulture.Russian, "Голосундук");
            tile100.AddMapEntry(new Color(150, 150, 255), holochestTile);

            ModTile tile101 = TileLoader.GetTile(redemption.TileType("SlayerFabricatorTile"));
            ModTranslation slayerFabricatorTile = tile101.CreateMapEntryName();
            slayerFabricatorTile.AddTranslation(GameCulture.Russian, "Гипер-изготовитель");
            tile101.AddMapEntry(new Color(190, 190, 230), slayerFabricatorTile);

            ModTile tile102 = TileLoader.GetTile(redemption.TileType("GrubNestTile"));
            ModTranslation grubNestTile = tile102.CreateMapEntryName();
            grubNestTile.AddTranslation(GameCulture.Russian, "Гнездо личинок");
            tile102.AddMapEntry(new Color(40, 60, 40), grubNestTile);

            ModTile tile103 = TileLoader.GetTile(redemption.TileType("PlutoniumTile"));
            ModTranslation plutoniumTile = tile103.CreateMapEntryName();
            plutoniumTile.AddTranslation(GameCulture.Russian, "Плутоний");
            tile103.AddMapEntry(new Color(133, 253, 255), plutoniumTile);

            ModTile tile104 = TileLoader.GetTile(redemption.TileType("SolidCoriumTile"));
            ModTranslation solidCoriumTile = tile104.CreateMapEntryName();
            solidCoriumTile.AddTranslation(GameCulture.Russian, "Кориум");
            tile104.AddMapEntry(new Color(156, 75, 53), solidCoriumTile);

            ModTile tile105 = TileLoader.GetTile(redemption.TileType("StarliteGemOreTile"));
            ModTranslation starliteGemOreTile = tile105.CreateMapEntryName();
            starliteGemOreTile.AddTranslation(GameCulture.Russian, "Старлит");
            tile105.AddMapEntry(new Color(30, 65, 25), starliteGemOreTile);

            ModTile tile106 = TileLoader.GetTile(redemption.TileType("StarliteGemTile"));
            ModTranslation starliteGemTile = tile106.CreateMapEntryName();
            starliteGemTile.AddTranslation(GameCulture.Russian, "Старлит");
            tile106.AddMapEntry(new Color(30, 180, 90), starliteGemTile);

            ModTile tile107 = TileLoader.GetTile(redemption.TileType("UraniumTile"));
            ModTranslation uraniumTile = tile107.CreateMapEntryName();
            uraniumTile.AddTranslation(GameCulture.Russian, "Уран");
            tile107.AddMapEntry(new Color(77, 240, 107), uraniumTile);

            ModTile tile108 = TileLoader.GetTile(redemption.TileType("XenomiteCrystalBigTile"));
            ModTranslation xenomiteCrystalBigTile = tile108.CreateMapEntryName();
            xenomiteCrystalBigTile.AddTranslation(GameCulture.Russian, "Кристаллы ксеномита");
            tile108.AddMapEntry(new Color(50, 220, 50), xenomiteCrystalBigTile);

            ModTile tile109 = TileLoader.GetTile(redemption.TileType("XenomiteCrystalTile"));
            ModTranslation xenomiteCrystalTile = tile109.CreateMapEntryName();
            xenomiteCrystalTile.AddTranslation(GameCulture.Russian, "Ксеномит");
            tile109.AddMapEntry(new Color(54, 193, 59), xenomiteCrystalTile);
        }
    }
}
