using Microsoft.Xna.Framework;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Tiles
{
	internal class CalamityTiles
	{
		public static void Setup()
		{
			Tiles();
		}
		private static void Tiles()
		{
			Mod calamity = ModLoader.GetMod("CalamityMod");
			
			ModTile tile = TileLoader.GetTile(calamity.TileType("ArenaTile"));
			ModTranslation arenaTile = tile.CreateMapEntryName();
			arenaTile.AddTranslation(GameCulture.Russian, "Арена");
			tile.AddMapEntry(new Color(128, 0, 0), arenaTile);
			
			ModTile tile2 = TileLoader.GetTile(calamity.TileType("AgedSecurityChestTile"));
			ModTranslation agedSecurityChestTile = tile2.CreateMapEntryName();
			agedSecurityChestTile.AddTranslation(GameCulture.Russian, "Старый охранный сундук");
			tile2.AddMapEntry(new Color(130, 119, 115), agedSecurityChestTile);
			
			ModTile tile3 = TileLoader.GetTile(calamity.TileType("ChaoticBrick"));
			ModTranslation chaoticBrick = tile3.CreateMapEntryName();
			chaoticBrick.AddTranslation(GameCulture.Russian, "Хаотический кирпич");
			tile3.AddMapEntry(new Color(255, 0, 0), chaoticBrick);
			
			ModTile tile4 = TileLoader.GetTile(calamity.TileType("DraedonFactoryFieldGenerator"));
			ModTranslation draedonFactoryFieldGenerator = tile4.CreateMapEntryName();
			draedonFactoryFieldGenerator.AddTranslation(GameCulture.Russian, "Генератор поля");
			tile4.AddMapEntry(new Color(53, 49, 52), draedonFactoryFieldGenerator);
			
			ModTile tile5 = TileLoader.GetTile(calamity.TileType("DraedonFuelFactory"));
			ModTranslation draedonFuelFactory = tile5.CreateMapEntryName();
			draedonFuelFactory.AddTranslation(GameCulture.Russian, "Топливная фабрика");
			tile5.AddMapEntry(new Color(67, 72, 81), draedonFuelFactory);
			
			ModTile tile6 = TileLoader.GetTile(calamity.TileType("DraedonItemCharger"));
			ModTranslation draedonItemCharger = tile6.CreateMapEntryName();
			draedonItemCharger.AddTranslation(GameCulture.Russian, "Зарядное устройство");
			tile6.AddMapEntry(new Color(67, 72, 81), draedonItemCharger);
			
			ModTile tile7 = TileLoader.GetTile(calamity.TileType("DraedonTurretTile"));
			ModTranslation draedonTurretTile = tile7.CreateMapEntryName();
			draedonTurretTile.AddTranslation(GameCulture.Russian, "Турель");
			tile7.AddMapEntry(new Color(67, 72, 81), draedonTurretTile);
			
			ModTile tile8 = TileLoader.GetTile(calamity.TileType("InactiveDraedonFuelFactory"));
			ModTranslation inactiveDraedonFuelFactory = tile8.CreateMapEntryName();
			inactiveDraedonFuelFactory.AddTranslation(GameCulture.Russian, "Бездействующая топливная фабрика");
			tile8.AddMapEntry(new Color(67, 72, 81), inactiveDraedonFuelFactory);
			
			ModTile tile9 = TileLoader.GetTile(calamity.TileType("SecurityChestTile"));
			ModTranslation securityChestTile = tile9.CreateMapEntryName();
			securityChestTile.AddTranslation(GameCulture.Russian, "Охранный сундук");
			tile9.AddMapEntry(new Color(130, 119, 115), securityChestTile);
			
			ModTile tile10 = TileLoader.GetTile(calamity.TileType("MonsterBanner"));
			ModTranslation monsterBanner = tile10.CreateMapEntryName();
			monsterBanner.AddTranslation(GameCulture.Russian, "Знамя");
			tile10.AddMapEntry(new Color(255, 0, 0), monsterBanner);
			
			ModTile tile11 = TileLoader.GetTile(calamity.TileType("RoxTile"));
			ModTranslation roxTile = tile11.CreateMapEntryName();
			roxTile.AddTranslation(GameCulture.Russian, "Рокскалибур");
			tile11.AddMapEntry(new Color(13, 88, 130), roxTile);

			ModTile tile12 = TileLoader.GetTile(calamity.TileType("AbyssalCrateTile"));
			ModTranslation abyssalCrateTile = tile12.CreateMapEntryName();
			abyssalCrateTile.AddTranslation(GameCulture.Russian, "Ящик бездны");
			tile12.AddMapEntry(new Color(47, 79, 79), abyssalCrateTile);

			ModTile tile13 = TileLoader.GetTile(calamity.TileType("AbyssalPots"));
			ModTranslation abyssalPots = tile13.CreateMapEntryName();
			abyssalPots.AddTranslation(GameCulture.Russian, "Горшок");
			tile13.AddMapEntry(new Color(47, 79, 79), abyssalPots);

			ModTile tile14 = TileLoader.GetTile(calamity.TileType("AcidWoodTreeSapling"));
			ModTranslation acidWoodTreeSapling = tile14.CreateMapEntryName();
			acidWoodTreeSapling.AddTranslation(GameCulture.Russian, "Саженец");
			tile14.AddMapEntry(new Color(113, 90, 71), acidWoodTreeSapling);

			ModTile tile15 = TileLoader.GetTile(calamity.TileType("LumenylCrystals"));
			ModTranslation lumenylCrystals = tile15.CreateMapEntryName();
			lumenylCrystals.AddTranslation(GameCulture.Russian, "Люменил");
			tile15.AddMapEntry(new Color(0, 150, 200), lumenylCrystals);

			ModTile tile16 = TileLoader.GetTile(calamity.TileType("PlantyMush"));
			ModTranslation plantyMush = tile16.CreateMapEntryName();
			plantyMush.AddTranslation(GameCulture.Russian, "Мох");
			tile16.AddMapEntry(new Color(0, 120, 0), plantyMush);

			ModTile tile17 = TileLoader.GetTile(calamity.TileType("RustyChestTile"));
			ModTranslation rustyChestTile = tile17.CreateMapEntryName("chestRusty");
			rustyChestTile.AddTranslation(GameCulture.Russian, "Ржавый сундук");
			tile17.AddMapEntry(new Color(0, 120, 0), rustyChestTile);

			ModTile tile18 = TileLoader.GetTile(calamity.TileType("SteamGeyser"));
			ModTranslation steamGeyser = tile18.CreateMapEntryName();
			steamGeyser.AddTranslation(GameCulture.Russian, "Гейзер");
			tile18.AddMapEntry(new Color(150, 100, 50), steamGeyser);

			ModTile tile19 = TileLoader.GetTile(calamity.TileType("SulphuricFossil1"));
			ModTranslation sulphuricFossil = tile19.CreateMapEntryName();
			sulphuricFossil.AddTranslation(GameCulture.Russian, "Ископаемое");
			tile19.AddMapEntry(new Color(113, 90, 71), sulphuricFossil);

			ModTile tile20 = TileLoader.GetTile(calamity.TileType("SulphuricFossil2"));
			ModTranslation sulphuricFossil2 = tile20.CreateMapEntryName();
			sulphuricFossil2.AddTranslation(GameCulture.Russian, "Ископаемое");
			tile20.AddMapEntry(new Color(113, 90, 71), sulphuricFossil2);

			ModTile tile21 = TileLoader.GetTile(calamity.TileType("SulphuricFossil3"));
			ModTranslation sulphuricFossil3 = tile21.CreateMapEntryName();
			sulphuricFossil3.AddTranslation(GameCulture.Russian, "Ископаемое");
			tile21.AddMapEntry(new Color(113, 90, 71), sulphuricFossil3);

			ModTile tile22 = TileLoader.GetTile(calamity.TileType("SulphurousColumn"));
			ModTranslation sulphurousColumn = tile22.CreateMapEntryName();
			sulphurousColumn.AddTranslation(GameCulture.Russian, "Столб");
			tile22.AddMapEntry(new Color(150, 100, 50), sulphurousColumn);

			ModTile tile23 = TileLoader.GetTile(calamity.TileType("SulphurousPots"));
			ModTranslation sulphurousPots = tile23.CreateMapEntryName();
			sulphurousPots.AddTranslation(GameCulture.Russian, "Горшок");
			tile23.AddMapEntry(new Color(226, 205, 101), sulphurousPots);

			ModTile tile24 = TileLoader.GetTile(calamity.TileType("SulphurousRib1"));
			ModTranslation sulphurousRib = tile24.CreateMapEntryName();
			sulphurousRib.AddTranslation(GameCulture.Russian, "Рёбра");
			tile24.AddMapEntry(new Color(57, 48, 83), sulphurousRib);

			ModTile tile25 = TileLoader.GetTile(calamity.TileType("SulphurousRib2"));
			ModTranslation sulphurousRib2 = tile25.CreateMapEntryName();
			sulphurousRib2.AddTranslation(GameCulture.Russian, "Рёбра");
			tile25.AddMapEntry(new Color(57, 48, 83), sulphurousRib2);

			ModTile tile26 = TileLoader.GetTile(calamity.TileType("SulphurousRib3"));
			ModTranslation sulphurousRib3 = tile26.CreateMapEntryName();
			sulphurousRib3.AddTranslation(GameCulture.Russian, "Рёбра");
			tile26.AddMapEntry(new Color(57, 48, 83), sulphurousRib3);

			ModTile tile27 = TileLoader.GetTile(calamity.TileType("SulphurousRib4"));
			ModTranslation sulphurousRib4 = tile27.CreateMapEntryName();
			sulphurousRib4.AddTranslation(GameCulture.Russian, "Рёбра");
			tile27.AddMapEntry(new Color(57, 48, 83), sulphurousRib4);

			ModTile tile393 = TileLoader.GetTile(calamity.TileType("SulphurousRib5"));
			ModTranslation sulphurousRib5 = tile393.CreateMapEntryName();
			sulphurousRib5.AddTranslation(GameCulture.Russian, "Рёбра");
			tile393.AddMapEntry(new Color(57, 48, 83), sulphurousRib5);

			ModTile tile29 = TileLoader.GetTile(calamity.TileType("SulphurousVines"));
			ModTranslation sulphurousVines = tile29.CreateMapEntryName();
			sulphurousVines.AddTranslation(GameCulture.Russian, "Серные лозы");
			tile29.AddMapEntry(new Color(0, 50, 0), sulphurousVines);

			ModTile tile30 = TileLoader.GetTile(calamity.TileType("Tenebris"));
			ModTranslation tenebris = tile30.CreateMapEntryName();
			tenebris.AddTranslation(GameCulture.Russian, "Тенебрис");
			tile30.AddMapEntry(new Color(0, 100, 100), tenebris);

			ModTile tile31 = TileLoader.GetTile(calamity.TileType("ViperVines"));
			ModTranslation viperVines = tile31.CreateMapEntryName();
			viperVines.AddTranslation(GameCulture.Russian, "Змеиная лоза");
			tile31.AddMapEntry(new Color(0, 50, 0), viperVines);

			ModTile tile32 = TileLoader.GetTile(calamity.TileType("SulphurousStalacmite1"));
			ModTranslation sulphurousStalacmite = tile32.CreateMapEntryName();
			sulphurousStalacmite.AddTranslation(GameCulture.Russian, "Сталакмит");
			tile32.AddMapEntry(new Color(57, 48, 83), sulphurousStalacmite);

			ModTile tile33 = TileLoader.GetTile(calamity.TileType("SulphurousStalacmite2"));
			ModTranslation sulphurousStalacmite2 = tile33.CreateMapEntryName();
			sulphurousStalacmite2.AddTranslation(GameCulture.Russian, "Сталакмит");
			tile33.AddMapEntry(new Color(57, 48, 83), sulphurousStalacmite2);

			ModTile tile34 = TileLoader.GetTile(calamity.TileType("SulphurousStalacmite3"));
			ModTranslation sulphurousStalacmite3 = tile34.CreateMapEntryName();
			sulphurousStalacmite3.AddTranslation(GameCulture.Russian, "Сталакмит");
			tile34.AddMapEntry(new Color(57, 48, 83), sulphurousStalacmite3);

			ModTile tile35 = TileLoader.GetTile(calamity.TileType("SulphurousStalacmite4"));
			ModTranslation sulphurousStalacmite4 = tile35.CreateMapEntryName();
			sulphurousStalacmite4.AddTranslation(GameCulture.Russian, "Сталакмит");
			tile35.AddMapEntry(new Color(57, 48, 83), sulphurousStalacmite4);

			ModTile tile36 = TileLoader.GetTile(calamity.TileType("SulphurousStalacmite5"));
			ModTranslation sulphurousStalacmite5 = tile36.CreateMapEntryName();
			sulphurousStalacmite5.AddTranslation(GameCulture.Russian, "Сталакмит");
			tile36.AddMapEntry(new Color(57, 48, 83), sulphurousStalacmite5);

			ModTile tile37 = TileLoader.GetTile(calamity.TileType("SulphurousStalacmite6"));
			ModTranslation sulphurousStalacmite6 = tile37.CreateMapEntryName();
			sulphurousStalacmite6.AddTranslation(GameCulture.Russian, "Сталакмит");
			tile37.AddMapEntry(new Color(57, 48, 83), sulphurousStalacmite6);

			ModTile tile38 = TileLoader.GetTile(calamity.TileType("SulphurousStalactite1"));
			ModTranslation sulphurousStalactite = tile38.CreateMapEntryName();
			sulphurousStalactite.AddTranslation(GameCulture.Russian, "Сталактит");
			tile38.AddMapEntry(new Color(57, 48, 83), sulphurousStalactite);

			ModTile tile39 = TileLoader.GetTile(calamity.TileType("SulphurousStalactite2"));
			ModTranslation sulphurousStalactite2 = tile39.CreateMapEntryName();
			sulphurousStalactite2.AddTranslation(GameCulture.Russian, "Сталактит");
			tile39.AddMapEntry(new Color(57, 48, 83), sulphurousStalactite2);

			ModTile tile40 = TileLoader.GetTile(calamity.TileType("SulphurousStalactite3"));
			ModTranslation sulphurousStalactite3 = tile40.CreateMapEntryName();
			sulphurousStalactite3.AddTranslation(GameCulture.Russian, "Сталактит");
			tile40.AddMapEntry(new Color(57, 48, 83), sulphurousStalactite3);

			ModTile tile41 = TileLoader.GetTile(calamity.TileType("SulphurousStalactite4"));
			ModTranslation sulphurousStalactite4 = tile41.CreateMapEntryName();
			sulphurousStalactite4.AddTranslation(GameCulture.Russian, "Сталактит");
			tile41.AddMapEntry(new Color(57, 48, 83), sulphurousStalactite4);

			ModTile tile42 = TileLoader.GetTile(calamity.TileType("SulphurousStalactite5"));
			ModTranslation sulphurousStalactite5 = tile42.CreateMapEntryName();
			sulphurousStalactite5.AddTranslation(GameCulture.Russian, "Сталактит");
			tile42.AddMapEntry(new Color(57, 48, 83), sulphurousStalactite5);

			ModTile tile43 = TileLoader.GetTile(calamity.TileType("SulphurousStalactite6"));
			ModTranslation sulphurousStalactite6 = tile43.CreateMapEntryName();
			sulphurousStalactite6.AddTranslation(GameCulture.Russian, "Сталактит");
			tile43.AddMapEntry(new Color(57, 48, 83), sulphurousStalactite6);

			ModTile tile44 = TileLoader.GetTile(calamity.TileType("AstralBeacon"));
			ModTranslation astralBeacon = tile44.CreateMapEntryName();
			astralBeacon.AddTranslation(GameCulture.Russian, "Астральный маяк");
			tile44.AddMapEntry(new Color(128, 128, 158), astralBeacon);

			ModTile tile45 = TileLoader.GetTile(calamity.TileType("AstralChestLocked"));
			ModTranslation astralChest = tile45.CreateMapEntryName("chestAstral");
			astralChest.AddTranslation(GameCulture.Russian, "Астральный сундук");
			tile45.AddMapEntry(new Color(174, 129, 92), astralChest);

			ModTile tile46 = TileLoader.GetTile(calamity.TileType("AstralCrateTile"));
			ModTranslation astralCrateTile = tile46.CreateMapEntryName();
			astralCrateTile.AddTranslation(GameCulture.Russian, "Астральный ящик");
			tile46.AddMapEntry(new Color(47, 66, 90), astralCrateTile);

			ModTile tile47 = TileLoader.GetTile(calamity.TileType("AstralFossil"));
			ModTranslation astralFossil = tile47.CreateMapEntryName();
			astralFossil.AddTranslation(GameCulture.Russian, "Небесные останки");
			tile47.AddMapEntry(new Color(59, 50, 77), astralFossil);

			ModTile tile48 = TileLoader.GetTile(calamity.TileType("AstralPalmSapling"));
			ModTranslation astralPalmSapling = tile48.CreateMapEntryName();
			astralFossil.AddTranslation(GameCulture.Russian, "Саженец");
			tile48.AddMapEntry(new Color(200, 200, 200), astralPalmSapling);

			ModTile tile49 = TileLoader.GetTile(calamity.TileType("AstralSnowTreeSapling"));
			ModTranslation astralSnowTreeSapling = tile49.CreateMapEntryName();
			astralSnowTreeSapling.AddTranslation(GameCulture.Russian, "Саженец");
			tile49.AddMapEntry(new Color(200, 200, 200), astralSnowTreeSapling);

			ModTile tile50 = TileLoader.GetTile(calamity.TileType("BrimstoneCrateTile"));
			ModTranslation brimstoneCrateTile = tile50.CreateMapEntryName();
			brimstoneCrateTile.AddTranslation(GameCulture.Russian, "Серный ящик");
			tile50.AddMapEntry(new Color(128, 0, 0), brimstoneCrateTile);

			ModTile tile51 = TileLoader.GetTile(calamity.TileType("AgedLaboratoryConsole"));
			ModTranslation agedLaboratoryConsole = tile51.CreateMapEntryName();
			agedLaboratoryConsole.AddTranslation(GameCulture.Russian, "Старая консоль");
			tile51.AddMapEntry(new Color(82, 67, 66), agedLaboratoryConsole);

			ModTile tile52 = TileLoader.GetTile(calamity.TileType("AgedLaboratoryContainmentBox"));
			ModTranslation agedLaboratoryContainmentBox = tile52.CreateMapEntryName();
			agedLaboratoryContainmentBox.AddTranslation(GameCulture.Russian, "Старая коробка лаборатории для хранения");
			tile52.AddMapEntry(new Color(82, 67, 66), agedLaboratoryContainmentBox);

			ModTile tile53 = TileLoader.GetTile(calamity.TileType("AgedLaboratoryDisplay"));
			ModTranslation agedLaboratoryDisplay = tile53.CreateMapEntryName();
			agedLaboratoryDisplay.AddTranslation(GameCulture.Russian, "Старый дисплей");
			tile53.AddMapEntry(Color.DarkSlateGray, agedLaboratoryDisplay);

			ModTile tile54 = TileLoader.GetTile(calamity.TileType("AgedLaboratoryDoorClosed"));
			ModTranslation agedLaboratoryDoorClosed = tile54.CreateMapEntryName();
			agedLaboratoryDoorClosed.AddTranslation(GameCulture.Russian, "Дверь лаборатории");
			tile54.AddMapEntry(Color.DarkSlateGray, agedLaboratoryDoorClosed);

			ModTile tile55 = TileLoader.GetTile(calamity.TileType("AgedLaboratoryDoorOpen"));
			ModTranslation agedLaboratoryDoorOpen = tile55.CreateMapEntryName();
			agedLaboratoryDoorOpen.AddTranslation(GameCulture.Russian, "Дверь лаборатории");
			tile55.AddMapEntry(Color.DarkSlateGray, agedLaboratoryDoorOpen);

			ModTile tile56 = TileLoader.GetTile(calamity.TileType("AgedLaboratoryElectricPanel"));
			ModTranslation agedLaboratoryElectricPanel = tile56.CreateMapEntryName();
			agedLaboratoryElectricPanel.AddTranslation(GameCulture.Russian, "Старая электрическая панель");
			tile56.AddMapEntry(Color.DimGray, agedLaboratoryElectricPanel);

			ModTile tile57 = TileLoader.GetTile(calamity.TileType("AgedLaboratoryScreen"));
			ModTranslation agedLaboratoryScreen = tile57.CreateMapEntryName();
			agedLaboratoryScreen.AddTranslation(GameCulture.Russian, "Старый экран");
			tile57.AddMapEntry(Color.DarkGray, agedLaboratoryScreen);

			ModTile tile58 = TileLoader.GetTile(calamity.TileType("AgedLaboratoryServer"));
			ModTranslation agedLaboratoryServer = tile58.CreateMapEntryName();
			agedLaboratoryServer.AddTranslation(GameCulture.Russian, "Старый сервер");
			tile58.AddMapEntry(new Color(82, 67, 66), agedLaboratoryServer);

			ModTile tile59 = TileLoader.GetTile(calamity.TileType("AgedLaboratoryTerminal"));
			ModTranslation agedLaboratoryTerminal = tile59.CreateMapEntryName();
			agedLaboratoryTerminal.AddTranslation(GameCulture.Russian, "Старый терминал");
			tile59.AddMapEntry(Color.DarkSlateGray, agedLaboratoryTerminal);

			ModTile tile60 = TileLoader.GetTile(calamity.TileType("AgedReinforcedCrate"));
			ModTranslation agedReinforcedCrate = tile60.CreateMapEntryName();
			agedReinforcedCrate.AddTranslation(GameCulture.Russian, "Старый укреплённый ящик");
			tile60.AddMapEntry(Color.DimGray, agedReinforcedCrate);

			ModTile tile61 = TileLoader.GetTile(calamity.TileType("LaboratoryConsole"));
			ModTranslation laboratoryConsole = tile61.CreateMapEntryName();
			laboratoryConsole.AddTranslation(GameCulture.Russian, "Консоль");
			tile61.AddMapEntry(new Color(82, 67, 66), laboratoryConsole);

			ModTile tile62 = TileLoader.GetTile(calamity.TileType("LaboratoryContainmentBox"));
			ModTranslation laboratoryContainmentBox = tile62.CreateMapEntryName();
			laboratoryContainmentBox.AddTranslation(GameCulture.Russian, "Коробка лаборатории для хранения");
			tile62.AddMapEntry(new Color(82, 67, 66), laboratoryContainmentBox);

			ModTile tile63 = TileLoader.GetTile(calamity.TileType("LaboratoryDisplay"));
			ModTranslation laboratoryDisplay = tile63.CreateMapEntryName();
			laboratoryDisplay.AddTranslation(GameCulture.Russian, "Дисплей");
			tile63.AddMapEntry(Color.DarkSlateGray, laboratoryDisplay);

			ModTile tile64 = TileLoader.GetTile(calamity.TileType("LaboratoryDoorClosed"));
			ModTranslation laboratoryDoorClosed = tile64.CreateMapEntryName();
			laboratoryDoorClosed.AddTranslation(GameCulture.Russian, "Дверь лаборатории");
			tile64.AddMapEntry(Color.DarkSlateGray, laboratoryDoorClosed);

			ModTile tile65 = TileLoader.GetTile(calamity.TileType("LaboratoryDoorOpen"));
			ModTranslation laboratoryDoorOpen = tile65.CreateMapEntryName();
			laboratoryDoorOpen.AddTranslation(GameCulture.Russian, "Дверь лаборатории");
			tile65.AddMapEntry(Color.DarkSlateGray, laboratoryDoorOpen);

			ModTile tile66 = TileLoader.GetTile(calamity.TileType("LaboratoryElectricPanel"));
			ModTranslation laboratoryElectricPanel = tile66.CreateMapEntryName();
			laboratoryElectricPanel.AddTranslation(GameCulture.Russian, "Электрическая панель");
			tile66.AddMapEntry(Color.DimGray, laboratoryElectricPanel);

			ModTile tile67 = TileLoader.GetTile(calamity.TileType("LaboratoryScreen"));
			ModTranslation laboratoryScreen = tile67.CreateMapEntryName();
			laboratoryScreen.AddTranslation(GameCulture.Russian, "Экран");
			tile67.AddMapEntry(Color.DarkGray, laboratoryScreen);

			ModTile tile68 = TileLoader.GetTile(calamity.TileType("LaboratoryServer"));
			ModTranslation laboratoryServer = tile68.CreateMapEntryName();
			laboratoryServer.AddTranslation(GameCulture.Russian, "Сервер");
			tile68.AddMapEntry(new Color(82, 67, 66), laboratoryServer);

			ModTile tile69 = TileLoader.GetTile(calamity.TileType("LaboratoryTerminal"));
			ModTranslation laboratoryTerminal = tile69.CreateMapEntryName();
			laboratoryTerminal.AddTranslation(GameCulture.Russian, "Терминал");
			tile69.AddMapEntry(Color.DarkSlateGray, laboratoryTerminal);

			ModTile tile70 = TileLoader.GetTile(calamity.TileType("ReinforcedCrate"));
			ModTranslation reinforcedCrate = tile70.CreateMapEntryName();
			reinforcedCrate.AddTranslation(GameCulture.Russian, "Укреплённый ящик");
			tile70.AddMapEntry(Color.DimGray, reinforcedCrate);

			ModTile tile71 = TileLoader.GetTile(calamity.TileType("AuricToiletTile"));
			ModTranslation auricToiletTile = tile71.CreateMapEntryName();
			auricToiletTile.AddTranslation(GameCulture.Russian, "Золотоносный туалет");
			tile71.AddMapEntry(new Color(191, 142, 111), auricToiletTile);

			ModTile tile72 = TileLoader.GetTile(calamity.TileType("BabyFlakHermitCageTile"));
			ModTranslation babyFlakHermitCageTile = tile72.CreateMapEntryName();
			babyFlakHermitCageTile.AddTranslation(GameCulture.Russian, "Клетка с маленьким артиреллйским крабом");
			tile72.AddMapEntry(new Color(175, 238, 238), babyFlakHermitCageTile);

			ModTile tile73 = TileLoader.GetTile(calamity.TileType("BabyGhostBellJarTile"));
			ModTranslation babyGhostBellJarTile = tile73.CreateMapEntryName();
			babyGhostBellJarTile.AddTranslation(GameCulture.Russian, "Банка с маленьким призрачным колокольчиком");
			tile73.AddMapEntry(new Color(64, 224, 208), babyGhostBellJarTile);

			ModTile tile74 = TileLoader.GetTile(calamity.TileType("BlueCandle"));
			ModTranslation blueCandle = tile74.CreateMapEntryName();
			blueCandle.AddTranslation(GameCulture.Russian, "Невесомая свеча");
			tile74.AddMapEntry(new Color(238, 145, 105), blueCandle);

			ModTile tile75 = TileLoader.GetTile(calamity.TileType("BossTrophy"));
			ModTranslation bossTrophy = tile75.CreateMapEntryName();
			bossTrophy.AddTranslation(GameCulture.Russian, "Трофей");
			tile75.AddMapEntry(new Color(120, 85, 60), bossTrophy);

			ModTile tile76 = TileLoader.GetTile(calamity.TileType("ChaosCandle"));
			ModTranslation chaosCandle = tile76.CreateMapEntryName();
			chaosCandle.AddTranslation(GameCulture.Russian, "Свечка хаоса");
			tile76.AddMapEntry(new Color(238, 145, 105), chaosCandle);

			ModTile tile77 = TileLoader.GetTile(calamity.TileType("CorruptionEffigy"));
			ModTranslation corruptionEffigy = tile77.CreateMapEntryName();
			corruptionEffigy.AddTranslation(GameCulture.Russian, "Чучело искажения");
			tile77.AddMapEntry(new Color(238, 145, 105), corruptionEffigy);

			ModTile tile78 = TileLoader.GetTile(calamity.TileType("CrimsonEffigy"));
			ModTranslation crimsonEffigy = tile78.CreateMapEntryName();
			crimsonEffigy.AddTranslation(GameCulture.Russian, "Чучело багрянца");
			tile78.AddMapEntry(new Color(238, 145, 105), crimsonEffigy);

			ModTile tile79 = TileLoader.GetTile(calamity.TileType("EffigyOfDecayPlaceable"));
			ModTranslation effigyOfDecayPlaceable = tile79.CreateMapEntryName();
			effigyOfDecayPlaceable.AddTranslation(GameCulture.Russian, "Чучело разложения");
			tile79.AddMapEntry(new Color(113, 90, 71), effigyOfDecayPlaceable);

			ModTile tile80 = TileLoader.GetTile(calamity.TileType("PiggyCageTile"));
			ModTranslation piggyCageTile = tile80.CreateMapEntryName();
			piggyCageTile.AddTranslation(GameCulture.Russian, "Клетка с поросёнком");
			tile80.AddMapEntry(new Color(175, 238, 238), piggyCageTile);

			ModTile tile81 = TileLoader.GetTile(calamity.TileType("PinkCandle"));
			ModTranslation pinkCandle = tile81.CreateMapEntryName();
			pinkCandle.AddTranslation(GameCulture.Russian, "Энергичная свеча");
			tile81.AddMapEntry(new Color(238, 145, 105), pinkCandle);

			ModTile tile82 = TileLoader.GetTile(calamity.TileType("PurpleCandle"));
			ModTranslation purpleCandle = tile82.CreateMapEntryName();
			purpleCandle.AddTranslation(GameCulture.Russian, "Устойчивая свеча");
			tile82.AddMapEntry(new Color(238, 145, 105), purpleCandle);

			ModTile tile83 = TileLoader.GetTile(calamity.TileType("SeaMinnowJarTile"));
			ModTranslation seaMinnowJarTile = tile83.CreateMapEntryName();
			seaMinnowJarTile.AddTranslation(GameCulture.Russian, "Банка с морским пескарём");
			tile83.AddMapEntry(new Color(175, 238, 238), seaMinnowJarTile);

			ModTile tile84 = TileLoader.GetTile(calamity.TileType("TranquilityCandle"));
			ModTranslation tranquilityCandle = tile84.CreateMapEntryName();
			tranquilityCandle.AddTranslation(GameCulture.Russian, "Свеча спокойствия");
			tile84.AddMapEntry(new Color(238, 145, 105), tranquilityCandle);

			ModTile tile85 = TileLoader.GetTile(calamity.TileType("TwinklerInABottleTile"));
			ModTranslation twinklerInABottleTile = tile85.CreateMapEntryName();
			twinklerInABottleTile.AddTranslation(GameCulture.Russian, "Мерцатель в бутылке");
			tile85.AddMapEntry(new Color(255, 99, 71), twinklerInABottleTile);

			ModTile tile86 = TileLoader.GetTile(calamity.TileType("YellowCandle"));
			ModTranslation yellowCandle = tile86.CreateMapEntryName();
			yellowCandle.AddTranslation(GameCulture.Russian, "Злорадная свеча");
			tile86.AddMapEntry(new Color(238, 145, 105), yellowCandle);

			ModTile tile87 = TileLoader.GetTile(calamity.TileType("AncientAltar"));
			ModTranslation ancientAltar = tile87.CreateMapEntryName();
			ancientAltar.AddTranslation(GameCulture.Russian, "Древний алтарь");
			tile87.AddMapEntry(new Color(191, 142, 111), ancientAltar);

			ModTile tile88 = TileLoader.GetTile(calamity.TileType("AshenAltar"));
			ModTranslation ashenAltar = tile88.CreateMapEntryName();
			ashenAltar.AddTranslation(GameCulture.Russian, "Пепельный алтарь");
			tile88.AddMapEntry(new Color(191, 142, 111), ashenAltar);

			ModTile tile89 = TileLoader.GetTile(calamity.TileType("BotanicPlanter"));
			ModTranslation botanicPlanter = tile89.CreateMapEntryName();
			botanicPlanter.AddTranslation(GameCulture.Russian, "Ботаническая сеялка");
			tile89.AddMapEntry(new Color(191, 142, 111), botanicPlanter);

			ModTile tile90 = TileLoader.GetTile(calamity.TileType("DraedonsForge"));
			ModTranslation draedonsForge = tile90.CreateMapEntryName();
			draedonsForge.AddTranslation(GameCulture.Russian, "Кузня Дрэйдона");
			tile90.AddMapEntry(new Color(0, 255, 0), draedonsForge);

			ModTile tile91 = TileLoader.GetTile(calamity.TileType("EutrophicCrafting"));
			ModTranslation eutrophicCrafting = tile91.CreateMapEntryName();
			eutrophicCrafting.AddTranslation(GameCulture.Russian, "Эвтрофная полка");
			tile91.AddMapEntry(new Color(191, 142, 111), eutrophicCrafting);

			ModTile tile92 = TileLoader.GetTile(calamity.TileType("MonolithCrafting"));
			ModTranslation monolithCrafting = tile92.CreateMapEntryName();
			monolithCrafting.AddTranslation(GameCulture.Russian, "Монолитная амальгама");
			tile92.AddMapEntry(new Color(191, 142, 111), monolithCrafting);

			ModTile tile93 = TileLoader.GetTile(calamity.TileType("PlagueInfuser"));
			ModTranslation plagueInfuser = tile93.CreateMapEntryName();
			plagueInfuser.AddTranslation(GameCulture.Russian, "Чумной инфузер");
			tile93.AddMapEntry(new Color(191, 142, 111), plagueInfuser);

			ModTile tile94 = TileLoader.GetTile(calamity.TileType("ProfanedBasin"));
			ModTranslation profanedBasin = tile94.CreateMapEntryName();
			profanedBasin.AddTranslation(GameCulture.Russian, "Осквернённый тигель");
			tile94.AddMapEntry(new Color(191, 142, 111), profanedBasin);

			ModTile tile95 = TileLoader.GetTile(calamity.TileType("SilvaBasin"));
			ModTranslation silvaBasin = tile95.CreateMapEntryName();
			silvaBasin.AddTranslation(GameCulture.Russian, "Лучезарный манипулятор");
			tile95.AddMapEntry(new Color(191, 142, 111), silvaBasin);

			ModTile tile96 = TileLoader.GetTile(calamity.TileType("StaticRefiner"));
			ModTranslation staticRefiner = tile96.CreateMapEntryName();
			staticRefiner.AddTranslation(GameCulture.Russian, "Статический рафинёр");
			tile96.AddMapEntry(new Color(191, 142, 111), staticRefiner);

			ModTile tile97 = TileLoader.GetTile(calamity.TileType("VoidCondenser"));
			ModTranslation voidCondenser = tile97.CreateMapEntryName();
			voidCondenser.AddTranslation(GameCulture.Russian, "Конденсатор пустоты");
			tile97.AddMapEntry(new Color(191, 142, 111), voidCondenser);

			ModTile tile98 = TileLoader.GetTile(calamity.TileType("AbyssFountainTile"));
			ModTranslation abyssFountainTile = tile98.CreateMapEntryName();
			abyssFountainTile.AddTranslation(GameCulture.Russian, "Фонтан воды бездны");
			tile98.AddMapEntry(new Color(71, 93, 107), abyssFountainTile);

			ModTile tile99 = TileLoader.GetTile(calamity.TileType("AstralFountainTile"));
			ModTranslation astralFountainTile = tile99.CreateMapEntryName();
			astralFountainTile.AddTranslation(GameCulture.Russian, "Астральный фонтан воды");
			tile99.AddMapEntry(new Color(59, 50, 77), astralFountainTile);

			ModTile tile101 = TileLoader.GetTile(calamity.TileType("SulphurousFountainTile"));
			ModTranslation sulphurousFountainTile = tile101.CreateMapEntryName();
			sulphurousFountainTile.AddTranslation(GameCulture.Russian, "Серный фонтан воды");
			tile101.AddMapEntry(new Color(104, 195, 255), sulphurousFountainTile);

			ModTile tile102 = TileLoader.GetTile(calamity.TileType("SunkenSeaFountainTile"));
			ModTranslation sunkenSeaFountainTile = tile102.CreateMapEntryName();
			sunkenSeaFountainTile.AddTranslation(GameCulture.Russian, "Затерянный фонтан воды");
			tile102.AddMapEntry(new Color(104, 195, 255), sunkenSeaFountainTile);

			ModTile tile103 = TileLoader.GetTile(calamity.TileType("AbyssBath"));
			ModTranslation abyssBath = tile103.CreateMapEntryName();
			abyssBath.AddTranslation(GameCulture.Russian, "Ванна бездны");
			tile103.AddMapEntry(new Color(191, 142, 111), abyssBath);

			ModTile tile104 = TileLoader.GetTile(calamity.TileType("AbyssBed"));
			ModTranslation abyssBed = tile104.CreateMapEntryName();
			abyssBed.AddTranslation(GameCulture.Russian, "Кровать бездны");
			tile104.AddMapEntry(new Color(191, 142, 111), abyssBed);

			ModTile tile105 = TileLoader.GetTile(calamity.TileType("AbyssBookcase"));
			ModTranslation abyssBookcase = tile105.CreateMapEntryName();
			abyssBookcase.AddTranslation(GameCulture.Russian, "Книжный шкаф бездны");
			tile105.AddMapEntry(new Color(191, 142, 111), abyssBookcase);

			ModTile tile106 = TileLoader.GetTile(calamity.TileType("AbyssCandelabra"));
			ModTranslation abyssCandelabra = tile106.CreateMapEntryName();
			abyssCandelabra.AddTranslation(GameCulture.Russian, "Канделябр бездны");
			tile106.AddMapEntry(new Color(191, 142, 111), abyssCandelabra);

			ModTile tile107 = TileLoader.GetTile(calamity.TileType("AbyssCandle"));
			ModTranslation abyssCandle = tile107.CreateMapEntryName();
			abyssCandle.AddTranslation(GameCulture.Russian, "Свеча бездны");
			tile107.AddMapEntry(new Color(191, 142, 111), abyssCandle);

			ModTile tile108 = TileLoader.GetTile(calamity.TileType("AbyssChair"));
			ModTranslation abyssChair = tile108.CreateMapEntryName();
			abyssChair.AddTranslation(GameCulture.Russian, "Стул бездны");
			tile108.AddMapEntry(new Color(191, 142, 111), abyssChair);

			ModTile tile109 = TileLoader.GetTile(calamity.TileType("AbyssChandelier"));
			ModTranslation abyssChandelier = tile109.CreateMapEntryName();
			abyssChandelier.AddTranslation(GameCulture.Russian, "Люстра бездны");
			tile109.AddMapEntry(new Color(191, 142, 111), abyssChandelier);

			ModTile tile110 = TileLoader.GetTile(calamity.TileType("AbyssChest"));
			ModTranslation abyssChest = tile110.CreateMapEntryName();
			abyssChest.AddTranslation(GameCulture.Russian, "Сундук бездны");
			tile110.AddMapEntry(new Color(191, 142, 111), abyssChest);

			ModTile tile111 = TileLoader.GetTile(calamity.TileType("AbyssClock"));
			ModTranslation abyssClock = tile111.CreateMapEntryName();
			abyssClock.AddTranslation(GameCulture.Russian, "Часы бездны");
			tile111.AddMapEntry(new Color(191, 142, 111), abyssClock);

			ModTile tile112 = TileLoader.GetTile(calamity.TileType("AbyssDoorClosed"));
			ModTranslation abyssDoorClosed = tile112.CreateMapEntryName();
			abyssDoorClosed.AddTranslation(GameCulture.Russian, "Дверь бездны");
			tile112.AddMapEntry(new Color(191, 142, 111), abyssDoorClosed);

			ModTile tile113 = TileLoader.GetTile(calamity.TileType("AbyssDoorOpen"));
			ModTranslation abyssDoorOpen = tile113.CreateMapEntryName();
			abyssDoorOpen.AddTranslation(GameCulture.Russian, "Дверь бездны");
			tile113.AddMapEntry(new Color(191, 142, 111), abyssDoorOpen);

			ModTile tile114 = TileLoader.GetTile(calamity.TileType("AbyssDresser"));
			ModTranslation abyssDresser = tile114.CreateMapEntryName();
			abyssDresser.AddTranslation(GameCulture.Russian, "Комод бездны");
			tile114.AddMapEntry(new Color(191, 142, 111), abyssDresser);

			ModTile tile115 = TileLoader.GetTile(calamity.TileType("AbyssLamp"));
			ModTranslation abyssLamp = tile115.CreateMapEntryName();
			abyssLamp.AddTranslation(GameCulture.Russian, "Лампа бездны");
			tile115.AddMapEntry(new Color(191, 142, 111), abyssLamp);

			ModTile tile116 = TileLoader.GetTile(calamity.TileType("AbyssLantern"));
			ModTranslation abyssLantern = tile116.CreateMapEntryName();
			abyssLantern.AddTranslation(GameCulture.Russian, "Фонарь бездны");
			tile116.AddMapEntry(new Color(191, 142, 111), abyssLantern);

			ModTile tile117 = TileLoader.GetTile(calamity.TileType("AbyssPiano"));
			ModTranslation abyssPiano = tile117.CreateMapEntryName();
			abyssPiano.AddTranslation(GameCulture.Russian, "Синтезатор бездны");
			tile117.AddMapEntry(new Color(191, 142, 111), abyssPiano);

			ModTile tile118 = TileLoader.GetTile(calamity.TileType("AbyssSink"));
			ModTranslation abyssSink = tile118.CreateMapEntryName();
			abyssSink.AddTranslation(GameCulture.Russian, "Раковина бездны");
			tile118.AddMapEntry(new Color(191, 142, 111), abyssSink);

			ModTile tile119 = TileLoader.GetTile(calamity.TileType("AbyssSofa"));
			ModTranslation abyssSofa = tile119.CreateMapEntryName();
			abyssSofa.AddTranslation(GameCulture.Russian, "Диван бездны");
			tile119.AddMapEntry(new Color(191, 142, 111), abyssSofa);

			ModTile tile120 = TileLoader.GetTile(calamity.TileType("AbyssTable"));
			ModTranslation abyssTable = tile120.CreateMapEntryName();
			abyssTable.AddTranslation(GameCulture.Russian, "Стол бездны");
			tile120.AddMapEntry(new Color(191, 142, 111), abyssTable);

			ModTile tile121 = TileLoader.GetTile(calamity.TileType("AbyssWorkbench"));
			ModTranslation abyssWorkbench = tile121.CreateMapEntryName();
			abyssWorkbench.AddTranslation(GameCulture.Russian, "Верстак бездны");
			tile121.AddMapEntry(new Color(191, 142, 111), abyssWorkbench);

			ModTile tile122 = TileLoader.GetTile(calamity.TileType("AncientBasin"));
			ModTranslation ancientBasin = tile122.CreateMapEntryName();
			ancientBasin.AddTranslation(GameCulture.Russian, "Древний костёр");
			tile122.AddMapEntry(new Color(191, 142, 111), ancientBasin);

			ModTile tile123 = TileLoader.GetTile(calamity.TileType("AncientBath"));
			ModTranslation ancientBath = tile123.CreateMapEntryName();
			ancientBath.AddTranslation(GameCulture.Russian, "Древняя ванна");
			tile123.AddMapEntry(new Color(191, 142, 111), ancientBath);

			ModTile tile124 = TileLoader.GetTile(calamity.TileType("AncientBed"));
			ModTranslation ancientBed = tile124.CreateMapEntryName();
			ancientBed.AddTranslation(GameCulture.Russian, "Древняя кровать");
			tile124.AddMapEntry(new Color(191, 142, 111), ancientBed);

			ModTile tile125 = TileLoader.GetTile(calamity.TileType("AncientBookcase"));
			ModTranslation ancientBookcase = tile125.CreateMapEntryName();
			ancientBookcase.AddTranslation(GameCulture.Russian, "Древний книжный шкаф");
			tile125.AddMapEntry(new Color(191, 142, 111), ancientBookcase);

			ModTile tile126 = TileLoader.GetTile(calamity.TileType("AncientChair"));
			ModTranslation ancientChair = tile126.CreateMapEntryName();
			ancientChair.AddTranslation(GameCulture.Russian, "Древний стул");
			tile126.AddMapEntry(new Color(191, 142, 111), ancientChair);

			ModTile tile127 = TileLoader.GetTile(calamity.TileType("AncientChandelier"));
			ModTranslation ancientChandelier = tile127.CreateMapEntryName();
			ancientChandelier.AddTranslation(GameCulture.Russian, "Древняя люстра");
			tile127.AddMapEntry(new Color(191, 142, 111), ancientChandelier);

			ModTile tile128 = TileLoader.GetTile(calamity.TileType("AncientDoorClosed"));
			ModTranslation ancientDoorClosed = tile128.CreateMapEntryName();
			ancientDoorClosed.AddTranslation(GameCulture.Russian, "Древняя дверь");
			tile128.AddMapEntry(new Color(191, 142, 111), ancientDoorClosed);

			ModTile tile129 = TileLoader.GetTile(calamity.TileType("AncientDoorOpen"));
			ModTranslation ancientDoorOpen = tile129.CreateMapEntryName();
			ancientDoorOpen.AddTranslation(GameCulture.Russian, "Древняя дверь");
			tile129.AddMapEntry(new Color(191, 142, 111), ancientDoorOpen);

			ModTile tile130 = TileLoader.GetTile(calamity.TileType("AncientDresser"));
			ModTranslation ancientDresser = tile130.CreateMapEntryName();
			ancientDresser.AddTranslation(GameCulture.Russian, "Древний комод");
			tile130.AddMapEntry(new Color(191, 142, 111), ancientDresser);

			ModTile tile131 = TileLoader.GetTile(calamity.TileType("AncientLamp"));
			ModTranslation ancientLamp = tile131.CreateMapEntryName();
			ancientLamp.AddTranslation(GameCulture.Russian, "Древняя лампа");
			tile131.AddMapEntry(new Color(191, 142, 111), ancientLamp);

			ModTile tile132 = TileLoader.GetTile(calamity.TileType("AncientLantern"));
			ModTranslation ancientLantern = tile132.CreateMapEntryName();
			ancientLantern.AddTranslation(GameCulture.Russian, "Древний фонарь");
			tile132.AddMapEntry(new Color(191, 142, 111), ancientLantern);

			ModTile tile133 = TileLoader.GetTile(calamity.TileType("AncientMonolith"));
			ModTranslation ancientMonolith = tile133.CreateMapEntryName();
			ancientMonolith.AddTranslation(GameCulture.Russian, "Древний монолит");
			tile133.AddMapEntry(new Color(191, 142, 111), ancientMonolith);

			ModTile tile134 = TileLoader.GetTile(calamity.TileType("AncientPiano"));
			ModTranslation ancientPiano = tile134.CreateMapEntryName();
			ancientPiano.AddTranslation(GameCulture.Russian, "Древний трубный орган");
			tile134.AddMapEntry(new Color(191, 142, 111), ancientPiano);

			ModTile tile135 = TileLoader.GetTile(calamity.TileType("AncientSink"));
			ModTranslation ancientSink = tile135.CreateMapEntryName();
			ancientSink.AddTranslation(GameCulture.Russian, "Древняя раковина");
			tile135.AddMapEntry(new Color(191, 142, 111), ancientSink);

			ModTile tile136 = TileLoader.GetTile(calamity.TileType("AncientTable"));
			ModTranslation ancientTable = tile136.CreateMapEntryName();
			ancientTable.AddTranslation(GameCulture.Russian, "Древний стол");
			tile136.AddMapEntry(new Color(191, 142, 111), ancientTable);

			ModTile tile137 = TileLoader.GetTile(calamity.TileType("AncientWorkbench"));
			ModTranslation ancientWorkbench = tile137.CreateMapEntryName();
			ancientWorkbench.AddTranslation(GameCulture.Russian, "Древний верстак");
			tile137.AddMapEntry(new Color(191, 142, 111), ancientWorkbench);

			ModTile tile138 = TileLoader.GetTile(calamity.TileType("AshenBasin"));
			ModTranslation ashenBasin = tile138.CreateMapEntryName();
			ashenBasin.AddTranslation(GameCulture.Russian, "Пепельный костёр");
			tile138.AddMapEntry(new Color(191, 142, 111), ashenBasin);

			ModTile tile139 = TileLoader.GetTile(calamity.TileType("AshenBath"));
			ModTranslation ashenBath = tile139.CreateMapEntryName();
			ashenBath.AddTranslation(GameCulture.Russian, "Пепельная ванна");
			tile139.AddMapEntry(new Color(191, 142, 111), ashenBath);

			ModTile tile140 = TileLoader.GetTile(calamity.TileType("AshenBed"));
			ModTranslation ashenBed = tile140.CreateMapEntryName();
			ashenBed.AddTranslation(GameCulture.Russian, "Пепельная кровать");
			tile140.AddMapEntry(new Color(191, 142, 111), ashenBed);

			ModTile tile141 = TileLoader.GetTile(calamity.TileType("AshenBookcase"));
			ModTranslation ashenBookcase = tile141.CreateMapEntryName();
			ashenBookcase.AddTranslation(GameCulture.Russian, "Пепельный книжный шкаф");
			tile141.AddMapEntry(new Color(191, 142, 111), ashenBookcase);

			ModTile tile142 = TileLoader.GetTile(calamity.TileType("AshenCandelabra"));
			ModTranslation ashenCandelabra = tile142.CreateMapEntryName();
			ashenCandelabra.AddTranslation(GameCulture.Russian, "Пепельный канделябр");
			tile142.AddMapEntry(new Color(191, 142, 111), ashenCandelabra);

			ModTile tile143 = TileLoader.GetTile(calamity.TileType("AshenCandle"));
			ModTranslation ashenCandle = tile143.CreateMapEntryName();
			ashenCandle.AddTranslation(GameCulture.Russian, "Пепельная свеча");
			tile143.AddMapEntry(new Color(191, 142, 111), ashenCandle);

			ModTile tile144 = TileLoader.GetTile(calamity.TileType("AshenChair"));
			ModTranslation ashenChair = tile144.CreateMapEntryName();
			ashenChair.AddTranslation(GameCulture.Russian, "Пепельный стул");
			tile144.AddMapEntry(new Color(191, 142, 111), ashenChair);

			ModTile tile145 = TileLoader.GetTile(calamity.TileType("AshenChandelier"));
			ModTranslation ashenChandelier = tile145.CreateMapEntryName();
			ashenChandelier.AddTranslation(GameCulture.Russian, "Пепельная люстра");
			tile145.AddMapEntry(new Color(191, 142, 111), ashenChandelier);

			ModTile tile146 = TileLoader.GetTile(calamity.TileType("AshenChest"));
			ModTranslation ashenChest = tile146.CreateMapEntryName();
			ashenChest.AddTranslation(GameCulture.Russian, "Пепельный сундук");
			tile146.AddMapEntry(new Color(174, 129, 92), ashenChest);

			ModTile tile147 = TileLoader.GetTile(calamity.TileType("AshenChest"));
			ModTranslation ashenChestLocked = tile147.CreateMapEntryName(tile147.Name + "_Locked");
			ashenChestLocked.AddTranslation(GameCulture.Russian, "Закрытый пепельный сундук");
			tile147.AddMapEntry(new Color(174, 129, 92), ashenChestLocked);

			ModTile tile148 = TileLoader.GetTile(calamity.TileType("AshenDoorClosed"));
			ModTranslation ashenDoorClosed = tile148.CreateMapEntryName();
			ashenDoorClosed.AddTranslation(GameCulture.Russian, "Пепельная дверь");
			tile148.AddMapEntry(new Color(191, 142, 111), ashenDoorClosed);

			ModTile tile149 = TileLoader.GetTile(calamity.TileType("AshenDoorOpen"));
			ModTranslation ashenDoorOpen = tile149.CreateMapEntryName();
			ashenDoorOpen.AddTranslation(GameCulture.Russian, "Пепельная дверь");
			tile149.AddMapEntry(new Color(191, 142, 111), ashenDoorOpen);

			ModTile tile150 = TileLoader.GetTile(calamity.TileType("AshenDresser"));
			ModTranslation ashenDresser = tile150.CreateMapEntryName();
			ashenDresser.AddTranslation(GameCulture.Russian, "Пепельный комод");
			tile150.AddMapEntry(new Color(191, 142, 111), ashenDresser);

			ModTile tile151 = TileLoader.GetTile(calamity.TileType("AshenLamp"));
			ModTranslation ashenLamp = tile151.CreateMapEntryName();
			ashenLamp.AddTranslation(GameCulture.Russian, "Пепельная лампа");
			tile151.AddMapEntry(new Color(191, 142, 111), ashenLamp);

			ModTile tile152 = TileLoader.GetTile(calamity.TileType("AshenLantern"));
			ModTranslation ashenLantern = tile152.CreateMapEntryName();
			ashenLantern.AddTranslation(GameCulture.Russian, "Пепельный фонарь");
			tile152.AddMapEntry(new Color(191, 142, 111), ashenLantern);

			ModTile tile153 = TileLoader.GetTile(calamity.TileType("AshenMonolith"));
			ModTranslation ashenMonolith = tile153.CreateMapEntryName();
			ashenMonolith.AddTranslation(GameCulture.Russian, "Пепельный монолит");
			tile153.AddMapEntry(new Color(191, 142, 111), ashenMonolith);

			ModTile tile154 = TileLoader.GetTile(calamity.TileType("AshenPiano"));
			ModTranslation ashenPiano = tile154.CreateMapEntryName();
			ashenPiano.AddTranslation(GameCulture.Russian, "Пепельный трубный орган");
			tile154.AddMapEntry(new Color(191, 142, 111), ashenPiano);

			ModTile tile155 = TileLoader.GetTile(calamity.TileType("AshenSink"));
			ModTranslation ashenSink = tile155.CreateMapEntryName();
			ashenSink.AddTranslation(GameCulture.Russian, "Пепельная раковина");
			tile155.AddMapEntry(new Color(191, 142, 111), ashenSink);

			ModTile tile156 = TileLoader.GetTile(calamity.TileType("AshenSofa"));
			ModTranslation ashenSofa = tile156.CreateMapEntryName();
			ashenSofa.AddTranslation(GameCulture.Russian, "Пепельный диван");
			tile156.AddMapEntry(new Color(191, 142, 111), ashenSofa);

			ModTile tile157 = TileLoader.GetTile(calamity.TileType("AshenTable"));
			ModTranslation ashenTable = tile157.CreateMapEntryName();
			ashenTable.AddTranslation(GameCulture.Russian, "Пепельный стол");
			tile157.AddMapEntry(new Color(191, 142, 111), ashenTable);

			ModTile tile158 = TileLoader.GetTile(calamity.TileType("AshenWorkbench"));
			ModTranslation ashenWorkbench = tile158.CreateMapEntryName();
			ashenWorkbench.AddTranslation(GameCulture.Russian, "Пепельный верстак");
			tile158.AddMapEntry(new Color(191, 142, 111), ashenWorkbench);

			ModTile tile159 = TileLoader.GetTile(calamity.TileType("MonolithBathtub"));
			ModTranslation monolithBathtub = tile159.CreateMapEntryName();
			monolithBathtub.AddTranslation(GameCulture.Russian, "Монолитная ванна");
			tile159.AddMapEntry(new Color(191, 142, 111), monolithBathtub);

			ModTile tile160 = TileLoader.GetTile(calamity.TileType("MonolithBed"));
			ModTranslation monolithBed = tile160.CreateMapEntryName();
			monolithBed.AddTranslation(GameCulture.Russian, "Монолитная кровать");
			tile160.AddMapEntry(new Color(191, 142, 111), monolithBed);

			ModTile tile161 = TileLoader.GetTile(calamity.TileType("MonolithBench"));
			ModTranslation monolithBench = tile161.CreateMapEntryName();
			monolithBench.AddTranslation(GameCulture.Russian, "Монолитная скамья");
			tile161.AddMapEntry(new Color(191, 142, 111), monolithBench);

			ModTile tile162 = TileLoader.GetTile(calamity.TileType("MonolithBookcase"));
			ModTranslation monolithBookcase = tile162.CreateMapEntryName();
			monolithBookcase.AddTranslation(GameCulture.Russian, "Монолитный книжный шкаф");
			tile162.AddMapEntry(new Color(191, 142, 111), monolithBookcase);

			ModTile tile163 = TileLoader.GetTile(calamity.TileType("MonolithCandelabra"));
			ModTranslation monolithCandelabra = tile163.CreateMapEntryName();
			monolithCandelabra.AddTranslation(GameCulture.Russian, "Монолитный канделябр");
			tile163.AddMapEntry(new Color(191, 142, 111), monolithCandelabra);

			ModTile tile164 = TileLoader.GetTile(calamity.TileType("MonolithCandle"));
			ModTranslation monolithCandle = tile164.CreateMapEntryName();
			monolithCandle.AddTranslation(GameCulture.Russian, "Монолитная свеча");
			tile164.AddMapEntry(new Color(191, 142, 111), monolithCandle);

			ModTile tile165 = TileLoader.GetTile(calamity.TileType("MonolithChair"));
			ModTranslation monolithChair = tile165.CreateMapEntryName();
			monolithChair.AddTranslation(GameCulture.Russian, "Монолитный стул");
			tile165.AddMapEntry(new Color(191, 142, 111), monolithChair);

			ModTile tile166 = TileLoader.GetTile(calamity.TileType("MonolithChandelier"));
			ModTranslation monolithChandelier = tile166.CreateMapEntryName();
			monolithChandelier.AddTranslation(GameCulture.Russian, "Монолитная люстра");
			tile166.AddMapEntry(new Color(191, 142, 111), monolithChandelier);

			ModTile tile167 = TileLoader.GetTile(calamity.TileType("MonolithChest"));
			ModTranslation monolithChest = tile167.CreateMapEntryName();
			monolithChest.AddTranslation(GameCulture.Russian, "Монолитный сундук");
			tile167.AddMapEntry(new Color(191, 142, 111), monolithChest);

			ModTile tile168 = TileLoader.GetTile(calamity.TileType("MonolithClock"));
			ModTranslation monolithClock = tile168.CreateMapEntryName();
			monolithClock.AddTranslation(GameCulture.Russian, "Монолитные часы");
			tile168.AddMapEntry(new Color(191, 142, 111), monolithClock);

			ModTile tile169 = TileLoader.GetTile(calamity.TileType("MonolithDoorClosed"));
			ModTranslation monolithDoorClosed = tile169.CreateMapEntryName();
			monolithDoorClosed.AddTranslation(GameCulture.Russian, "Монолитная дверь");
			tile169.AddMapEntry(new Color(191, 142, 111), monolithDoorClosed);

			ModTile tile170 = TileLoader.GetTile(calamity.TileType("MonolithDoorOpen"));
			ModTranslation monolithDoorOpen = tile170.CreateMapEntryName();
			monolithDoorOpen.AddTranslation(GameCulture.Russian, "Монолитная дверь");
			tile170.AddMapEntry(new Color(191, 142, 111), monolithDoorOpen);

			ModTile tile171 = TileLoader.GetTile(calamity.TileType("MonolithDresser"));
			ModTranslation monolithDresser = tile171.CreateMapEntryName();
			monolithDresser.AddTranslation(GameCulture.Russian, "Монолитный комод");
			tile171.AddMapEntry(new Color(191, 142, 111), monolithDresser);

			ModTile tile172 = TileLoader.GetTile(calamity.TileType("MonolithLamp"));
			ModTranslation monolithLamp = tile172.CreateMapEntryName();
			monolithLamp.AddTranslation(GameCulture.Russian, "Монолитная лампа");
			tile172.AddMapEntry(new Color(191, 142, 111), monolithLamp);

			ModTile tile173 = TileLoader.GetTile(calamity.TileType("MonolithLantern"));
			ModTranslation monolithLantern = tile173.CreateMapEntryName();
			monolithLantern.AddTranslation(GameCulture.Russian, "Монолитный фонарь");
			tile173.AddMapEntry(new Color(191, 142, 111), monolithLantern);

			ModTile tile174 = TileLoader.GetTile(calamity.TileType("MonolithPiano"));
			ModTranslation monolithPiano = tile174.CreateMapEntryName();
			monolithPiano.AddTranslation(GameCulture.Russian, "Монолитное пианино");
			tile174.AddMapEntry(new Color(191, 142, 111), monolithPiano);

			ModTile tile175 = TileLoader.GetTile(calamity.TileType("MonolithSink"));
			ModTranslation monolithSink = tile175.CreateMapEntryName();
			monolithSink.AddTranslation(GameCulture.Russian, "Монолитная раковина");
			tile175.AddMapEntry(new Color(191, 142, 111), monolithSink);

			ModTile tile176 = TileLoader.GetTile(calamity.TileType("MonolithTable"));
			ModTranslation monolithTable = tile176.CreateMapEntryName();
			monolithTable.AddTranslation(GameCulture.Russian, "Монолитный стол");
			tile176.AddMapEntry(new Color(191, 142, 111), monolithTable);

			ModTile tile177 = TileLoader.GetTile(calamity.TileType("MonolithWorkBench"));
			ModTranslation monolithWorkBench = tile177.CreateMapEntryName();
			monolithWorkBench.AddTranslation(GameCulture.Russian, "Монолитный верстак");
			tile177.AddMapEntry(new Color(191, 142, 111), monolithWorkBench);

			ModTile tile178 = TileLoader.GetTile(calamity.TileType("BotanicBathtub"));
			ModTranslation botanicBathtub = tile178.CreateMapEntryName();
			botanicBathtub.AddTranslation(GameCulture.Russian, "Ботаническая ванна");
			tile178.AddMapEntry(new Color(191, 142, 111), botanicBathtub);

			ModTile tile179 = TileLoader.GetTile(calamity.TileType("BotanicBed"));
			ModTranslation botanicBed = tile179.CreateMapEntryName();
			botanicBed.AddTranslation(GameCulture.Russian, "Ботаническая кровать");
			tile179.AddMapEntry(new Color(191, 142, 111), botanicBed);

			ModTile tile180 = TileLoader.GetTile(calamity.TileType("BotanicBench"));
			ModTranslation botanicBench = tile180.CreateMapEntryName();
			botanicBench.AddTranslation(GameCulture.Russian, "Ботаническая скамья");
			tile180.AddMapEntry(new Color(191, 142, 111), botanicBench);

			ModTile tile181 = TileLoader.GetTile(calamity.TileType("BotanicBookcase"));
			ModTranslation botanicBookcase = tile181.CreateMapEntryName();
			botanicBookcase.AddTranslation(GameCulture.Russian, "Ботанический книжный шкаф");
			tile181.AddMapEntry(new Color(191, 142, 111), botanicBookcase);

			ModTile tile182 = TileLoader.GetTile(calamity.TileType("BotanicCandelabra"));
			ModTranslation botanicCandelabra = tile182.CreateMapEntryName();
			botanicCandelabra.AddTranslation(GameCulture.Russian, "Ботанический канделябр");
			tile182.AddMapEntry(new Color(191, 142, 111), botanicCandelabra);

			ModTile tile183 = TileLoader.GetTile(calamity.TileType("BotanicCandle"));
			ModTranslation botanicCandle = tile183.CreateMapEntryName();
			botanicCandle.AddTranslation(GameCulture.Russian, "Ботаническая свеча");
			tile183.AddMapEntry(new Color(191, 142, 111), botanicCandle);

			ModTile tile184 = TileLoader.GetTile(calamity.TileType("BotanicChair"));
			ModTranslation botanicChair = tile184.CreateMapEntryName();
			botanicChair.AddTranslation(GameCulture.Russian, "Ботанический стул");
			tile184.AddMapEntry(new Color(191, 142, 111), botanicChair);

			ModTile tile185 = TileLoader.GetTile(calamity.TileType("BotanicChandelier"));
			ModTranslation botanicChandelier = tile185.CreateMapEntryName();
			botanicChandelier.AddTranslation(GameCulture.Russian, "Ботаническая люстра");
			tile185.AddMapEntry(new Color(191, 142, 111), botanicChandelier);

			ModTile tile186 = TileLoader.GetTile(calamity.TileType("BotanicChest"));
			ModTranslation botanicChest = tile186.CreateMapEntryName();
			botanicChest.AddTranslation(GameCulture.Russian, "Ботанический сундук");
			tile186.AddMapEntry(new Color(191, 142, 111), botanicChest);

			ModTile tile187 = TileLoader.GetTile(calamity.TileType("BotanicClock"));
			ModTranslation botanicClock = tile187.CreateMapEntryName();
			botanicClock.AddTranslation(GameCulture.Russian, "Ботанические часы");
			tile187.AddMapEntry(new Color(191, 142, 111), botanicClock);

			ModTile tile188 = TileLoader.GetTile(calamity.TileType("BotanicDoorClosed"));
			ModTranslation botanicDoorClosed = tile188.CreateMapEntryName();
			botanicDoorClosed.AddTranslation(GameCulture.Russian, "Ботаническая дверь");
			tile188.AddMapEntry(new Color(191, 142, 111), botanicDoorClosed);

			ModTile tile189 = TileLoader.GetTile(calamity.TileType("BotanicDoorOpen"));
			ModTranslation botanicDoorOpen = tile189.CreateMapEntryName();
			botanicDoorOpen.AddTranslation(GameCulture.Russian, "Ботаническая дверь");
			tile189.AddMapEntry(new Color(191, 142, 111), botanicDoorOpen);

			ModTile tile190 = TileLoader.GetTile(calamity.TileType("BotanicDresser"));
			ModTranslation botanicDresser = tile190.CreateMapEntryName();
			botanicDresser.AddTranslation(GameCulture.Russian, "Ботанический комод");
			tile190.AddMapEntry(new Color(191, 142, 111), botanicDresser);

			ModTile tile191 = TileLoader.GetTile(calamity.TileType("BotanicLamp"));
			ModTranslation botanicLamp = tile191.CreateMapEntryName();
			botanicLamp.AddTranslation(GameCulture.Russian, "Ботаническая лампа");
			tile191.AddMapEntry(new Color(191, 142, 111), botanicLamp);

			ModTile tile192 = TileLoader.GetTile(calamity.TileType("BotanicLantern"));
			ModTranslation botanicLantern = tile192.CreateMapEntryName();
			botanicLantern.AddTranslation(GameCulture.Russian, "Ботанический фонарь");
			tile192.AddMapEntry(new Color(191, 142, 111), botanicLantern);

			ModTile tile193 = TileLoader.GetTile(calamity.TileType("BotanicPiano"));
			ModTranslation botanicPiano = tile193.CreateMapEntryName();
			botanicPiano.AddTranslation(GameCulture.Russian, "Ботаническое пианино");
			tile193.AddMapEntry(new Color(191, 142, 111), botanicPiano);

			ModTile tile194 = TileLoader.GetTile(calamity.TileType("BotanicSink"));
			ModTranslation botanicSink = tile194.CreateMapEntryName();
			botanicSink.AddTranslation(GameCulture.Russian, "Ботаническая раковина");
			tile194.AddMapEntry(new Color(191, 142, 111), botanicSink);

			ModTile tile195 = TileLoader.GetTile(calamity.TileType("BotanicTable"));
			ModTranslation botanicTable = tile195.CreateMapEntryName();
			botanicTable.AddTranslation(GameCulture.Russian, "Ботанический стол");
			tile195.AddMapEntry(new Color(191, 142, 111), botanicTable);

			ModTile tile196 = TileLoader.GetTile(calamity.TileType("BotanicWorkBench"));
			ModTranslation botanicWorkBench = tile196.CreateMapEntryName();
			botanicWorkBench.AddTranslation(GameCulture.Russian, "Ботанический верстак");
			tile196.AddMapEntry(new Color(191, 142, 111), botanicWorkBench);

			ModTile tile197 = TileLoader.GetTile(calamity.TileType("CosmiliteBasinTile"));
			ModTranslation cosmiliteBasinTile = tile197.CreateMapEntryName();
			cosmiliteBasinTile.AddTranslation(GameCulture.Russian, "Космилитовый костёр");
			tile197.AddMapEntry(new Color(238, 145, 105), cosmiliteBasinTile);

			ModTile tile198 = TileLoader.GetTile(calamity.TileType("CosmiliteBath"));
			ModTranslation cosmiliteBath = tile198.CreateMapEntryName();
			cosmiliteBath.AddTranslation(GameCulture.Russian, "Космилитовая ванна");
			tile198.AddMapEntry(new Color(191, 142, 111), cosmiliteBath);

			ModTile tile199 = TileLoader.GetTile(calamity.TileType("CosmiliteBed"));
			ModTranslation cosmiliteBed = tile199.CreateMapEntryName();
			cosmiliteBed.AddTranslation(GameCulture.Russian, "Космилитовая кровать");
			tile199.AddMapEntry(new Color(191, 142, 111), cosmiliteBed);

			ModTile tile200 = TileLoader.GetTile(calamity.TileType("CosmiliteBookcase"));
			ModTranslation cosmiliteBookcase = tile200.CreateMapEntryName();
			cosmiliteBookcase.AddTranslation(GameCulture.Russian, "Космилитовый книжный шкаф");
			tile200.AddMapEntry(new Color(191, 142, 111), cosmiliteBookcase);

			ModTile tile201 = TileLoader.GetTile(calamity.TileType("CosmiliteCandelabra"));
			ModTranslation cosmiliteCandelabra = tile201.CreateMapEntryName();
			cosmiliteCandelabra.AddTranslation(GameCulture.Russian, "Космилитовый канделябр");
			tile201.AddMapEntry(new Color(191, 142, 111), cosmiliteCandelabra);

			ModTile tile202 = TileLoader.GetTile(calamity.TileType("CosmiliteCandle"));
			ModTranslation cosmiliteCandle = tile202.CreateMapEntryName();
			cosmiliteCandle.AddTranslation(GameCulture.Russian, "Космилитовая свеча");
			tile202.AddMapEntry(new Color(191, 142, 111), cosmiliteCandle);

			ModTile tile203 = TileLoader.GetTile(calamity.TileType("CosmiliteChair"));
			ModTranslation cosmiliteChair = tile203.CreateMapEntryName();
			cosmiliteChair.AddTranslation(GameCulture.Russian, "Космилитовый стул");
			tile203.AddMapEntry(new Color(191, 142, 111), cosmiliteChair);

			ModTile tile204 = TileLoader.GetTile(calamity.TileType("CosmiliteChandelier"));
			ModTranslation cosmiliteChandelier = tile204.CreateMapEntryName();
			cosmiliteChandelier.AddTranslation(GameCulture.Russian, "Космилитовая люстра");
			tile204.AddMapEntry(new Color(191, 142, 111), cosmiliteChandelier);

			ModTile tile205 = TileLoader.GetTile(calamity.TileType("CosmiliteChest"));
			ModTranslation cosmiliteChest = tile205.CreateMapEntryName();
			cosmiliteChest.AddTranslation(GameCulture.Russian, "Космилитовый сундук");
			tile205.AddMapEntry(new Color(191, 142, 111), cosmiliteChest);

			ModTile tile206 = TileLoader.GetTile(calamity.TileType("CosmiliteClock"));
			ModTranslation cosmiliteClock = tile206.CreateMapEntryName();
			cosmiliteClock.AddTranslation(GameCulture.Russian, "Космилитовые часы");
			tile206.AddMapEntry(new Color(191, 142, 111), cosmiliteClock);

			ModTile tile207 = TileLoader.GetTile(calamity.TileType("CosmiliteDoorClosed"));
			ModTranslation cosmiliteDoorClosed = tile207.CreateMapEntryName();
			cosmiliteDoorClosed.AddTranslation(GameCulture.Russian, "Космилитовая дверь");
			tile207.AddMapEntry(new Color(191, 142, 111), cosmiliteDoorClosed);

			ModTile tile208 = TileLoader.GetTile(calamity.TileType("CosmiliteDoorOpen"));
			ModTranslation cosmiliteDoorOpen = tile208.CreateMapEntryName();
			cosmiliteDoorOpen.AddTranslation(GameCulture.Russian, "Космилитовая дверь");
			tile208.AddMapEntry(new Color(191, 142, 111), cosmiliteDoorOpen);

			ModTile tile209 = TileLoader.GetTile(calamity.TileType("CosmiliteDresser"));
			ModTranslation cosmiliteDresser = tile209.CreateMapEntryName();
			cosmiliteDresser.AddTranslation(GameCulture.Russian, "Космилитовый комод");
			tile209.AddMapEntry(new Color(191, 142, 111), cosmiliteDresser);

			ModTile tile210 = TileLoader.GetTile(calamity.TileType("CosmiliteLamp"));
			ModTranslation cosmiliteLamp = tile210.CreateMapEntryName();
			cosmiliteLamp.AddTranslation(GameCulture.Russian, "Космилитовая лампа");
			tile210.AddMapEntry(new Color(191, 142, 111), cosmiliteLamp);

			ModTile tile211 = TileLoader.GetTile(calamity.TileType("CosmiliteLantern"));
			ModTranslation cosmiliteLantern = tile211.CreateMapEntryName();
			cosmiliteLantern.AddTranslation(GameCulture.Russian, "Космилитовый фонарь");
			tile211.AddMapEntry(new Color(191, 142, 111), cosmiliteLantern);

			ModTile tile212 = TileLoader.GetTile(calamity.TileType("CosmilitePiano"));
			ModTranslation cosmilitePiano = tile212.CreateMapEntryName();
			cosmilitePiano.AddTranslation(GameCulture.Russian, "Космилитовое пианино");
			tile212.AddMapEntry(new Color(191, 142, 111), cosmilitePiano);

			ModTile tile213 = TileLoader.GetTile(calamity.TileType("CosmiliteSconce"));
			ModTranslation cosmiliteSconce = tile213.CreateMapEntryName();
			cosmiliteSconce.AddTranslation(GameCulture.Russian, "Космилитовая бра");
			tile213.AddMapEntry(new Color(191, 142, 111), cosmiliteSconce);

			ModTile tile214 = TileLoader.GetTile(calamity.TileType("CosmiliteSink"));
			ModTranslation cosmiliteSink = tile214.CreateMapEntryName();
			cosmiliteSink.AddTranslation(GameCulture.Russian, "Космилитовая раковина");
			tile214.AddMapEntry(new Color(191, 142, 111), cosmiliteSink);

			ModTile tile215 = TileLoader.GetTile(calamity.TileType("CosmiliteSofa"));
			ModTranslation cosmiliteSofa = tile215.CreateMapEntryName();
			cosmiliteSofa.AddTranslation(GameCulture.Russian, "Космилитовый диван");
			tile215.AddMapEntry(new Color(191, 142, 111), cosmiliteSofa);

			ModTile tile216 = TileLoader.GetTile(calamity.TileType("CosmiliteTable"));
			ModTranslation cosmiliteTable = tile216.CreateMapEntryName();
			cosmiliteTable.AddTranslation(GameCulture.Russian, "Космилитовый стол");
			tile216.AddMapEntry(new Color(191, 142, 111), cosmiliteTable);

			ModTile tile217 = TileLoader.GetTile(calamity.TileType("CosmiliteWorkbench"));
			ModTranslation cosmiliteWorkbench = tile217.CreateMapEntryName();
			cosmiliteWorkbench.AddTranslation(GameCulture.Russian, "Космилитовый верстак");
			tile217.AddMapEntry(new Color(191, 142, 111), cosmiliteWorkbench);

			ModTile tile218 = TileLoader.GetTile(calamity.TileType("EutrophicBathtub"));
			ModTranslation eutrophicBathtub = tile218.CreateMapEntryName();
			eutrophicBathtub.AddTranslation(GameCulture.Russian, "Эвтрофная ванна");
			tile218.AddMapEntry(new Color(191, 142, 111), eutrophicBathtub);

			ModTile tile219 = TileLoader.GetTile(calamity.TileType("EutrophicBed"));
			ModTranslation eutrophicBed = tile219.CreateMapEntryName();
			eutrophicBed.AddTranslation(GameCulture.Russian, "Эвтрофная кровать");
			tile219.AddMapEntry(new Color(191, 142, 111), eutrophicBed);

			ModTile tile220 = TileLoader.GetTile(calamity.TileType("EutrophicBench"));
			ModTranslation eutrophicBench = tile220.CreateMapEntryName();
			eutrophicBench.AddTranslation(GameCulture.Russian, "Эвтрофная скамья");
			tile220.AddMapEntry(new Color(191, 142, 111), eutrophicBench);

			ModTile tile221 = TileLoader.GetTile(calamity.TileType("EutrophicBookcase"));
			ModTranslation eutrophicBookcase = tile221.CreateMapEntryName();
			eutrophicBookcase.AddTranslation(GameCulture.Russian, "Эвтрофный книжный шкаф");
			tile221.AddMapEntry(new Color(191, 142, 111), eutrophicBookcase);

			ModTile tile222 = TileLoader.GetTile(calamity.TileType("EutrophicCandelabra"));
			ModTranslation eutrophicCandelabra = tile222.CreateMapEntryName();
			eutrophicCandelabra.AddTranslation(GameCulture.Russian, "Эвтрофный канделябр");
			tile222.AddMapEntry(new Color(191, 142, 111), eutrophicCandelabra);

			ModTile tile223 = TileLoader.GetTile(calamity.TileType("EutrophicCandle"));
			ModTranslation eutrophicCandle = tile223.CreateMapEntryName();
			eutrophicCandle.AddTranslation(GameCulture.Russian, "Эвтрофная свеча");
			tile223.AddMapEntry(new Color(191, 142, 111), eutrophicCandle);

			ModTile tile224 = TileLoader.GetTile(calamity.TileType("EutrophicChair"));
			ModTranslation eutrophicChair = tile224.CreateMapEntryName();
			eutrophicChair.AddTranslation(GameCulture.Russian, "Эвтрофный стул");
			tile224.AddMapEntry(new Color(191, 142, 111), eutrophicChair);

			ModTile tile225 = TileLoader.GetTile(calamity.TileType("EutrophicChandelier"));
			ModTranslation eutrophicChandelier = tile225.CreateMapEntryName();
			eutrophicChandelier.AddTranslation(GameCulture.Russian, "Эвтрофная люстра");
			tile225.AddMapEntry(new Color(191, 142, 111), eutrophicChandelier);

			ModTile tile226 = TileLoader.GetTile(calamity.TileType("EutrophicChest"));
			ModTranslation eutrophicChest = tile226.CreateMapEntryName();
			eutrophicChest.AddTranslation(GameCulture.Russian, "Эвтрофный сундук");
			tile226.AddMapEntry(new Color(191, 142, 111), eutrophicChest);

			ModTile tile227 = TileLoader.GetTile(calamity.TileType("EutrophicClock"));
			ModTranslation eutrophicClock = tile227.CreateMapEntryName();
			eutrophicClock.AddTranslation(GameCulture.Russian, "Эвтрофные часы");
			tile227.AddMapEntry(new Color(191, 142, 111), eutrophicClock);

			ModTile tile228 = TileLoader.GetTile(calamity.TileType("EutrophicDoorClosed"));
			ModTranslation eutrophicDoorClosed = tile228.CreateMapEntryName();
			eutrophicDoorClosed.AddTranslation(GameCulture.Russian, "Эвтрофная дверь");
			tile228.AddMapEntry(new Color(191, 142, 111), eutrophicDoorClosed);

			ModTile tile229 = TileLoader.GetTile(calamity.TileType("EutrophicDoorOpen"));
			ModTranslation eutrophicDoorOpen = tile229.CreateMapEntryName();
			eutrophicDoorOpen.AddTranslation(GameCulture.Russian, "Эвтрофная дверь");
			tile229.AddMapEntry(new Color(191, 142, 111), eutrophicDoorOpen);

			ModTile tile230 = TileLoader.GetTile(calamity.TileType("EutrophicDresser"));
			ModTranslation eutrophicDresser = tile230.CreateMapEntryName();
			eutrophicDresser.AddTranslation(GameCulture.Russian, "Эвтрофный комод");
			tile230.AddMapEntry(new Color(191, 142, 111), eutrophicDresser);

			ModTile tile231 = TileLoader.GetTile(calamity.TileType("EutrophicLamp"));
			ModTranslation eutrophicLamp = tile231.CreateMapEntryName();
			eutrophicLamp.AddTranslation(GameCulture.Russian, "Эвтрофная лампа");
			tile231.AddMapEntry(new Color(191, 142, 111), eutrophicLamp);

			ModTile tile232 = TileLoader.GetTile(calamity.TileType("EutrophicLantern"));
			ModTranslation eutrophicLantern = tile232.CreateMapEntryName();
			eutrophicLantern.AddTranslation(GameCulture.Russian, "Эвтрофный фонарь");
			tile232.AddMapEntry(new Color(191, 142, 111), eutrophicLantern);

			ModTile tile233 = TileLoader.GetTile(calamity.TileType("EutrophicPiano"));
			ModTranslation eutrophicPiano = tile233.CreateMapEntryName();
			eutrophicPiano.AddTranslation(GameCulture.Russian, "Эвтрофное пианино");
			tile233.AddMapEntry(new Color(191, 142, 111), eutrophicPiano);

			ModTile tile234 = TileLoader.GetTile(calamity.TileType("EutrophicSink"));
			ModTranslation eutrophicSink = tile234.CreateMapEntryName();
			eutrophicSink.AddTranslation(GameCulture.Russian, "Эвтрофная раковина");
			tile234.AddMapEntry(new Color(191, 142, 111), eutrophicSink);

			ModTile tile235 = TileLoader.GetTile(calamity.TileType("EutrophicTable"));
			ModTranslation eutrophicTable = tile235.CreateMapEntryName();
			eutrophicTable.AddTranslation(GameCulture.Russian, "Эвтрофный стол");
			tile235.AddMapEntry(new Color(191, 142, 111), eutrophicTable);

			ModTile tile236 = TileLoader.GetTile(calamity.TileType("EutrophicWorkBench"));
			ModTranslation eutrophicWorkBench = tile236.CreateMapEntryName();
			eutrophicWorkBench.AddTranslation(GameCulture.Russian, "Эвтрофный верстак");
			tile236.AddMapEntry(new Color(191, 142, 111), eutrophicWorkBench);

			ModTile tile237 = TileLoader.GetTile(calamity.TileType("OccultBathtub"));
			ModTranslation occultBathtub = tile237.CreateMapEntryName();
			occultBathtub.AddTranslation(GameCulture.Russian, "Потусторонняя ванна");
			tile237.AddMapEntry(new Color(191, 142, 111), occultBathtub);

			ModTile tile238 = TileLoader.GetTile(calamity.TileType("OccultBed"));
			ModTranslation occultBed = tile238.CreateMapEntryName();
			occultBed.AddTranslation(GameCulture.Russian, "Потусторонняя кровать");
			tile238.AddMapEntry(new Color(191, 142, 111), occultBed);

			ModTile tile239 = TileLoader.GetTile(calamity.TileType("OccultBookcase"));
			ModTranslation occultBookcase = tile239.CreateMapEntryName();
			occultBookcase.AddTranslation(GameCulture.Russian, "Потусторонний книжный шкаф");
			tile239.AddMapEntry(new Color(191, 142, 111), occultBookcase);

			ModTile tile240 = TileLoader.GetTile(calamity.TileType("OccultCandelabra"));
			ModTranslation occultCandelabra = tile240.CreateMapEntryName();
			occultCandelabra.AddTranslation(GameCulture.Russian, "Потусторонний канделябр");
			tile240.AddMapEntry(new Color(191, 142, 111), occultCandelabra);

			ModTile tile241 = TileLoader.GetTile(calamity.TileType("OccultCandle"));
			ModTranslation occultCandle = tile241.CreateMapEntryName();
			occultCandle.AddTranslation(GameCulture.Russian, "Потусторонняя свеча");
			tile241.AddMapEntry(new Color(191, 142, 111), occultCandle);

			ModTile tile242 = TileLoader.GetTile(calamity.TileType("OccultChair"));
			ModTranslation occultChair = tile242.CreateMapEntryName();
			occultChair.AddTranslation(GameCulture.Russian, "Потусторонний стул");
			tile242.AddMapEntry(new Color(191, 142, 111), occultChair);

			ModTile tile243 = TileLoader.GetTile(calamity.TileType("OccultChandelier"));
			ModTranslation occultChandelier = tile243.CreateMapEntryName();
			occultChandelier.AddTranslation(GameCulture.Russian, "Потусторонняя люстра");
			tile243.AddMapEntry(new Color(191, 142, 111), occultChandelier);

			ModTile tile244 = TileLoader.GetTile(calamity.TileType("OccultChest"));
			ModTranslation occultChest = tile244.CreateMapEntryName();
			occultChest.AddTranslation(GameCulture.Russian, "Потусторонний сундук");
			tile244.AddMapEntry(new Color(191, 142, 111), occultChest);

			ModTile tile245 = TileLoader.GetTile(calamity.TileType("OccultClock"));
			ModTranslation occultClock = tile245.CreateMapEntryName();
			occultClock.AddTranslation(GameCulture.Russian, "Потусторонние часы");
			tile245.AddMapEntry(new Color(191, 142, 111), occultClock);

			ModTile tile246 = TileLoader.GetTile(calamity.TileType("OccultDoorClosed"));
			ModTranslation occultDoorClosed = tile246.CreateMapEntryName();
			occultDoorClosed.AddTranslation(GameCulture.Russian, "Потусторонняя дверь");
			tile246.AddMapEntry(new Color(191, 142, 111), occultDoorClosed);

			ModTile tile247 = TileLoader.GetTile(calamity.TileType("OccultDoorOpen"));
			ModTranslation occultDoorOpen = tile247.CreateMapEntryName();
			occultDoorOpen.AddTranslation(GameCulture.Russian, "Потусторонняя дверь");
			tile247.AddMapEntry(new Color(191, 142, 111), occultDoorOpen);

			ModTile tile248 = TileLoader.GetTile(calamity.TileType("OccultDresser"));
			ModTranslation occultDresser = tile248.CreateMapEntryName();
			occultDresser.AddTranslation(GameCulture.Russian, "Потусторонний комод");
			tile248.AddMapEntry(new Color(191, 142, 111), occultDresser);

			ModTile tile249 = TileLoader.GetTile(calamity.TileType("OccultLamp"));
			ModTranslation occultLamp = tile249.CreateMapEntryName();
			occultLamp.AddTranslation(GameCulture.Russian, "Потусторонняя лампа");
			tile249.AddMapEntry(new Color(191, 142, 111), occultLamp);

			ModTile tile250 = TileLoader.GetTile(calamity.TileType("OccultLantern"));
			ModTranslation occultLantern = tile250.CreateMapEntryName();
			occultLantern.AddTranslation(GameCulture.Russian, "Потусторонний фонарь");
			tile250.AddMapEntry(new Color(191, 142, 111), occultLantern);

			ModTile tile251 = TileLoader.GetTile(calamity.TileType("OccultPiano"));
			ModTranslation occultPiano = tile251.CreateMapEntryName();
			occultPiano.AddTranslation(GameCulture.Russian, "Потустороннее пианино");
			tile251.AddMapEntry(new Color(191, 142, 111), occultPiano);

			ModTile tile252 = TileLoader.GetTile(calamity.TileType("OccultSink"));
			ModTranslation occultSink = tile252.CreateMapEntryName();
			occultSink.AddTranslation(GameCulture.Russian, "Потусторонняя раковина");
			tile252.AddMapEntry(new Color(191, 142, 111), occultSink);

			ModTile tile253 = TileLoader.GetTile(calamity.TileType("OccultSofa"));
			ModTranslation occultSofa = tile253.CreateMapEntryName();
			occultSofa.AddTranslation(GameCulture.Russian, "Потусторонний диван");
			tile253.AddMapEntry(new Color(191, 142, 111), occultSofa);

			ModTile tile254 = TileLoader.GetTile(calamity.TileType("OccultTable"));
			ModTranslation occultTable = tile254.CreateMapEntryName();
			occultTable.AddTranslation(GameCulture.Russian, "Потусторонний стол");
			tile254.AddMapEntry(new Color(191, 142, 111), occultTable);

			ModTile tile255 = TileLoader.GetTile(calamity.TileType("OccultWorkBench"));
			ModTranslation occultWorkBench = tile255.CreateMapEntryName();
			occultWorkBench.AddTranslation(GameCulture.Russian, "Потусторонний верстак");
			tile255.AddMapEntry(new Color(191, 142, 111), occultWorkBench);

			ModTile tile256 = TileLoader.GetTile(calamity.TileType("PlaguedPlateBasin"));
			ModTranslation plaguedPlateBasin = tile256.CreateMapEntryName();
			plaguedPlateBasin.AddTranslation(GameCulture.Russian, "Сломанная чумная 'кровать'");
			tile256.AddMapEntry(new Color(191, 142, 111), plaguedPlateBasin);

			ModTile tile257 = TileLoader.GetTile(calamity.TileType("PlaguedPlateBathtub"));
			ModTranslation plaguedPlateBathtub = tile257.CreateMapEntryName();
			plaguedPlateBathtub.AddTranslation(GameCulture.Russian, "Чумная ванна");
			tile257.AddMapEntry(new Color(191, 142, 111), plaguedPlateBathtub);

			ModTile tile258 = TileLoader.GetTile(calamity.TileType("PlaguedPlateBed"));
			ModTranslation plaguedPlateBed = tile258.CreateMapEntryName();
			plaguedPlateBed.AddTranslation(GameCulture.Russian, "Чумная 'кровать'");
			tile258.AddMapEntry(new Color(191, 142, 111), plaguedPlateBed);

			ModTile tile259 = TileLoader.GetTile(calamity.TileType("PlaguedPlateBookcase"));
			ModTranslation plaguedPlateBookcase = tile259.CreateMapEntryName();
			plaguedPlateBookcase.AddTranslation(GameCulture.Russian, "Чумной книжный шкаф");
			tile259.AddMapEntry(new Color(191, 142, 111), plaguedPlateBookcase);

			ModTile tile260 = TileLoader.GetTile(calamity.TileType("PlaguedPlateCandelabra"));
			ModTranslation plaguedPlateCandelabra = tile260.CreateMapEntryName();
			plaguedPlateCandelabra.AddTranslation(GameCulture.Russian, "Чумной канделябр");
			tile260.AddMapEntry(new Color(191, 142, 111), plaguedPlateCandelabra);

			ModTile tile261 = TileLoader.GetTile(calamity.TileType("PlaguedPlateCandle"));
			ModTranslation plaguedPlateCandle = tile261.CreateMapEntryName();
			plaguedPlateCandle.AddTranslation(GameCulture.Russian, "Чумная свеча");
			tile261.AddMapEntry(new Color(191, 142, 111), plaguedPlateCandle);

			ModTile tile262 = TileLoader.GetTile(calamity.TileType("PlaguedPlateChair"));
			ModTranslation plaguedPlateChair = tile262.CreateMapEntryName();
			plaguedPlateChair.AddTranslation(GameCulture.Russian, "Чумной стул");
			tile262.AddMapEntry(new Color(191, 142, 111), plaguedPlateChair);

			ModTile tile263 = TileLoader.GetTile(calamity.TileType("PlaguedPlateChandelier"));
			ModTranslation plaguedPlateChandelier = tile263.CreateMapEntryName();
			plaguedPlateChandelier.AddTranslation(GameCulture.Russian, "Чумная люстра");
			tile263.AddMapEntry(new Color(191, 142, 111), plaguedPlateChandelier);

			ModTile tile264 = TileLoader.GetTile(calamity.TileType("PlaguedPlateChest"));
			ModTranslation plaguedPlateChest = tile264.CreateMapEntryName();
			plaguedPlateChest.AddTranslation(GameCulture.Russian, "Чумной сундук");
			tile264.AddMapEntry(new Color(191, 142, 111), plaguedPlateChest);

			ModTile tile265 = TileLoader.GetTile(calamity.TileType("PlaguedPlateClock"));
			ModTranslation plaguedPlateClock = tile265.CreateMapEntryName();
			plaguedPlateClock.AddTranslation(GameCulture.Russian, "Чумные часы");
			tile265.AddMapEntry(new Color(191, 142, 111), plaguedPlateClock);

			ModTile tile266 = TileLoader.GetTile(calamity.TileType("PlaguedPlateDoorClosed"));
			ModTranslation plaguedPlateDoorClosed = tile266.CreateMapEntryName();
			plaguedPlateDoorClosed.AddTranslation(GameCulture.Russian, "Чумная дверь");
			tile266.AddMapEntry(new Color(191, 142, 111), plaguedPlateDoorClosed);

			ModTile tile267 = TileLoader.GetTile(calamity.TileType("PlaguedPlateDoorOpen"));
			ModTranslation plaguedPlateDoorOpen = tile267.CreateMapEntryName();
			plaguedPlateDoorOpen.AddTranslation(GameCulture.Russian, "Чумная дверь");
			tile267.AddMapEntry(new Color(191, 142, 111), plaguedPlateDoorOpen);

			ModTile tile268 = TileLoader.GetTile(calamity.TileType("PlaguedPlateDresser"));
			ModTranslation plaguedPlateDresser = tile268.CreateMapEntryName();
			plaguedPlateDresser.AddTranslation(GameCulture.Russian, "Чумной комод");
			tile268.AddMapEntry(new Color(191, 142, 111), plaguedPlateDresser);

			ModTile tile269 = TileLoader.GetTile(calamity.TileType("PlaguedPlateLamp"));
			ModTranslation plaguedPlateLamp = tile269.CreateMapEntryName();
			plaguedPlateLamp.AddTranslation(GameCulture.Russian, "Чумная лампа");
			tile269.AddMapEntry(new Color(191, 142, 111), plaguedPlateLamp);

			ModTile tile270 = TileLoader.GetTile(calamity.TileType("PlaguedPlateLantern"));
			ModTranslation plaguedPlateLantern = tile270.CreateMapEntryName();
			plaguedPlateLantern.AddTranslation(GameCulture.Russian, "Чумной фонарь");
			tile270.AddMapEntry(new Color(191, 142, 111), plaguedPlateLantern);

			ModTile tile271 = TileLoader.GetTile(calamity.TileType("PlaguedPlatePiano"));
			ModTranslation plaguedPlatePiano = tile271.CreateMapEntryName();
			plaguedPlatePiano.AddTranslation(GameCulture.Russian, "Чумное пианино");
			tile271.AddMapEntry(new Color(191, 142, 111), plaguedPlatePiano);

			ModTile tile272 = TileLoader.GetTile(calamity.TileType("PlaguedPlateSink"));
			ModTranslation plaguedPlateSink = tile272.CreateMapEntryName();
			plaguedPlateSink.AddTranslation(GameCulture.Russian, "Чумная раковина");
			tile272.AddMapEntry(new Color(191, 142, 111), plaguedPlateSink);

			ModTile tile273 = TileLoader.GetTile(calamity.TileType("PlaguedPlateSofa"));
			ModTranslation plaguedPlateSofa = tile273.CreateMapEntryName();
			plaguedPlateSofa.AddTranslation(GameCulture.Russian, "Чумной диван");
			tile273.AddMapEntry(new Color(191, 142, 111), plaguedPlateSofa);

			ModTile tile274 = TileLoader.GetTile(calamity.TileType("PlaguedPlateTable"));
			ModTranslation plaguedPlateTable = tile274.CreateMapEntryName();
			plaguedPlateTable.AddTranslation(GameCulture.Russian, "Чумной стол");
			tile274.AddMapEntry(new Color(191, 142, 111), plaguedPlateTable);

			ModTile tile275 = TileLoader.GetTile(calamity.TileType("PlaguedPlateWorkbench"));
			ModTranslation plaguedPlateWorkbench = tile275.CreateMapEntryName();
			plaguedPlateWorkbench.AddTranslation(GameCulture.Russian, "Чумной верстак");
			tile275.AddMapEntry(new Color(191, 142, 111), plaguedPlateWorkbench);

			ModTile tile276 = TileLoader.GetTile(calamity.TileType("ProfanedBath"));
			ModTranslation profanedBath = tile276.CreateMapEntryName();
			profanedBath.AddTranslation(GameCulture.Russian, "Осквернённая ванна");
			tile276.AddMapEntry(new Color(191, 142, 111), profanedBath);

			ModTile tile277 = TileLoader.GetTile(calamity.TileType("ProfanedBed"));
			ModTranslation profanedBed = tile277.CreateMapEntryName();
			profanedBed.AddTranslation(GameCulture.Russian, "Осквернённая кровать");
			tile277.AddMapEntry(new Color(191, 142, 111), profanedBed);

			ModTile tile278 = TileLoader.GetTile(calamity.TileType("ProfanedBench"));
			ModTranslation profanedBench = tile278.CreateMapEntryName();
			profanedBench.AddTranslation(GameCulture.Russian, "Осквернённая скамья");
			tile278.AddMapEntry(new Color(191, 142, 111), profanedBench);

			ModTile tile279 = TileLoader.GetTile(calamity.TileType("ProfanedBookcase"));
			ModTranslation profanedBookcase = tile279.CreateMapEntryName();
			profanedBookcase.AddTranslation(GameCulture.Russian, "Осквернённый книжный шкаф");
			tile279.AddMapEntry(new Color(191, 142, 111), profanedBookcase);

			ModTile tile280 = TileLoader.GetTile(calamity.TileType("ProfanedCandelabra"));
			ModTranslation profanedCandelabra = tile280.CreateMapEntryName();
			profanedCandelabra.AddTranslation(GameCulture.Russian, "Осквернённый канделябр");
			tile280.AddMapEntry(new Color(191, 142, 111), profanedCandelabra);

			ModTile tile281 = TileLoader.GetTile(calamity.TileType("ProfanedCandle"));
			ModTranslation profanedCandle = tile281.CreateMapEntryName();
			profanedCandle.AddTranslation(GameCulture.Russian, "Осквернённая свеча");
			tile281.AddMapEntry(new Color(191, 142, 111), profanedCandle);

			ModTile tile282 = TileLoader.GetTile(calamity.TileType("ProfanedChair"));
			ModTranslation profanedChair = tile282.CreateMapEntryName();
			profanedChair.AddTranslation(GameCulture.Russian, "Осквернённый стул");
			tile282.AddMapEntry(new Color(191, 142, 111), profanedChair);

			ModTile tile283 = TileLoader.GetTile(calamity.TileType("ProfanedChandelier"));
			ModTranslation profanedChandelier = tile283.CreateMapEntryName();
			profanedChandelier.AddTranslation(GameCulture.Russian, "Осквернённая люстра");
			tile283.AddMapEntry(new Color(191, 142, 111), profanedChandelier);

			ModTile tile284 = TileLoader.GetTile(calamity.TileType("ProfanedChest"));
			ModTranslation profanedChest = tile284.CreateMapEntryName();
			profanedChest.AddTranslation(GameCulture.Russian, "Осквернённый сундук");
			tile284.AddMapEntry(new Color(191, 142, 111), profanedChest);

			ModTile tile285 = TileLoader.GetTile(calamity.TileType("ProfanedClock"));
			ModTranslation profanedClock = tile285.CreateMapEntryName();
			profanedClock.AddTranslation(GameCulture.Russian, "Осквернённые часы");
			tile285.AddMapEntry(new Color(191, 142, 111), profanedClock);

			ModTile tile286 = TileLoader.GetTile(calamity.TileType("ProfanedDoorClosed"));
			ModTranslation profanedDoorClosed = tile286.CreateMapEntryName();
			profanedDoorClosed.AddTranslation(GameCulture.Russian, "Осквернённая дверь");
			tile286.AddMapEntry(new Color(191, 142, 111), profanedDoorClosed);

			ModTile tile287 = TileLoader.GetTile(calamity.TileType("ProfanedDoorOpen"));
			ModTranslation profanedDoorOpen = tile287.CreateMapEntryName();
			profanedDoorOpen.AddTranslation(GameCulture.Russian, "Осквернённая дверь");
			tile287.AddMapEntry(new Color(191, 142, 111), profanedDoorOpen);

			ModTile tile288 = TileLoader.GetTile(calamity.TileType("ProfanedDresser"));
			ModTranslation profanedDresser = tile288.CreateMapEntryName();
			profanedDresser.AddTranslation(GameCulture.Russian, "Осквернённый комод");
			tile288.AddMapEntry(new Color(191, 142, 111), profanedDresser);

			ModTile tile289 = TileLoader.GetTile(calamity.TileType("ProfanedLamp"));
			ModTranslation profanedLamp = tile289.CreateMapEntryName();
			profanedLamp.AddTranslation(GameCulture.Russian, "Осквернённая лампа");
			tile289.AddMapEntry(new Color(191, 142, 111), profanedLamp);

			ModTile tile290 = TileLoader.GetTile(calamity.TileType("ProfanedLantern"));
			ModTranslation profanedLantern = tile290.CreateMapEntryName();
			profanedLantern.AddTranslation(GameCulture.Russian, "Осквернённый фонарь");
			tile290.AddMapEntry(new Color(191, 142, 111), profanedLantern);

			ModTile tile291 = TileLoader.GetTile(calamity.TileType("ProfanedPiano"));
			ModTranslation profanedPiano = tile291.CreateMapEntryName();
			profanedPiano.AddTranslation(GameCulture.Russian, "Осквернённое пианино");
			tile291.AddMapEntry(new Color(191, 142, 111), profanedPiano);

			ModTile tile292 = TileLoader.GetTile(calamity.TileType("ProfanedSink"));
			ModTranslation profanedSink = tile292.CreateMapEntryName();
			profanedSink.AddTranslation(GameCulture.Russian, "Осквернённая раковина");
			tile292.AddMapEntry(new Color(191, 142, 111), profanedSink);

			ModTile tile293 = TileLoader.GetTile(calamity.TileType("ProfanedTable"));
			ModTranslation profanedTable = tile293.CreateMapEntryName();
			profanedTable.AddTranslation(GameCulture.Russian, "Осквернённый стол");
			tile293.AddMapEntry(new Color(191, 142, 111), profanedTable);

			ModTile tile294 = TileLoader.GetTile(calamity.TileType("ProfanedWorkbench"));
			ModTranslation profanedWorkbench = tile294.CreateMapEntryName();
			profanedWorkbench.AddTranslation(GameCulture.Russian, "Осквернённый верстак");
			tile294.AddMapEntry(new Color(191, 142, 111), profanedWorkbench);

			ModTile tile295 = TileLoader.GetTile(calamity.TileType("SilvaBathtub"));
			ModTranslation silvaBathtub = tile295.CreateMapEntryName();
			silvaBathtub.AddTranslation(GameCulture.Russian, "Лесная ванна");
			tile295.AddMapEntry(new Color(191, 142, 111), silvaBathtub);

			ModTile tile296 = TileLoader.GetTile(calamity.TileType("SilvaBed"));
			ModTranslation silvaBed = tile296.CreateMapEntryName();
			silvaBed.AddTranslation(GameCulture.Russian, "Лесная кровать");
			tile296.AddMapEntry(new Color(191, 142, 111), silvaBed);

			ModTile tile297 = TileLoader.GetTile(calamity.TileType("SilvaBench"));
			ModTranslation silvaBench = tile297.CreateMapEntryName();
			silvaBench.AddTranslation(GameCulture.Russian, "Лесная скамья");
			tile297.AddMapEntry(new Color(191, 142, 111), silvaBench);

			ModTile tile298 = TileLoader.GetTile(calamity.TileType("SilvaBookcase"));
			ModTranslation silvaBookcase = tile298.CreateMapEntryName();
			silvaBookcase.AddTranslation(GameCulture.Russian, "Лесной книжный шкаф");
			tile298.AddMapEntry(new Color(191, 142, 111), silvaBookcase);

			ModTile tile299 = TileLoader.GetTile(calamity.TileType("SilvaCandelabra"));
			ModTranslation silvaCandelabra = tile299.CreateMapEntryName();
			silvaCandelabra.AddTranslation(GameCulture.Russian, "Лесной канделябр");
			tile299.AddMapEntry(new Color(191, 142, 111), silvaCandelabra);

			ModTile tile300 = TileLoader.GetTile(calamity.TileType("SilvaCandle"));
			ModTranslation silvaCandle = tile300.CreateMapEntryName();
			silvaCandle.AddTranslation(GameCulture.Russian, "Лесная свеча");
			tile300.AddMapEntry(new Color(191, 142, 111), silvaCandle);

			ModTile tile301 = TileLoader.GetTile(calamity.TileType("SilvaChair"));
			ModTranslation silvaChair = tile301.CreateMapEntryName();
			silvaChair.AddTranslation(GameCulture.Russian, "Лесной стул");
			tile301.AddMapEntry(new Color(191, 142, 111), silvaChair);

			ModTile tile302 = TileLoader.GetTile(calamity.TileType("SilvaChandelier"));
			ModTranslation silvaChandelier = tile302.CreateMapEntryName();
			silvaChandelier.AddTranslation(GameCulture.Russian, "Лесная люстра");
			tile302.AddMapEntry(new Color(191, 142, 111), silvaChandelier);

			ModTile tile303 = TileLoader.GetTile(calamity.TileType("SilvaChest"));
			ModTranslation silvaChest = tile303.CreateMapEntryName();
			silvaChest.AddTranslation(GameCulture.Russian, "Лесной сундук");
			tile303.AddMapEntry(new Color(191, 142, 111), silvaChest);

			ModTile tile304 = TileLoader.GetTile(calamity.TileType("SilvaClock"));
			ModTranslation silvaClock = tile304.CreateMapEntryName();
			silvaClock.AddTranslation(GameCulture.Russian, "Лесные часы");
			tile304.AddMapEntry(new Color(191, 142, 111), silvaClock);

			ModTile tile305 = TileLoader.GetTile(calamity.TileType("SilvaDoorClosed"));
			ModTranslation silvaDoorClosed = tile305.CreateMapEntryName();
			silvaDoorClosed.AddTranslation(GameCulture.Russian, "Лесная дверь");
			tile305.AddMapEntry(new Color(191, 142, 111), silvaDoorClosed);

			ModTile tile306 = TileLoader.GetTile(calamity.TileType("SilvaDoorOpen"));
			ModTranslation silvaDoorOpen = tile306.CreateMapEntryName();
			silvaDoorOpen.AddTranslation(GameCulture.Russian, "Лесная дверь");
			tile306.AddMapEntry(new Color(191, 142, 111), silvaDoorOpen);

			ModTile tile307 = TileLoader.GetTile(calamity.TileType("SilvaDresser"));
			ModTranslation silvaDresser = tile307.CreateMapEntryName();
			silvaDresser.AddTranslation(GameCulture.Russian, "Лесной комод");
			tile307.AddMapEntry(new Color(191, 142, 111), silvaDresser);

			ModTile tile308 = TileLoader.GetTile(calamity.TileType("SilvaLamp"));
			ModTranslation silvaLamp = tile308.CreateMapEntryName();
			silvaLamp.AddTranslation(GameCulture.Russian, "Лесная лампа");
			tile308.AddMapEntry(new Color(191, 142, 111), silvaLamp);

			ModTile tile309 = TileLoader.GetTile(calamity.TileType("SilvaLantern"));
			ModTranslation silvaLantern = tile309.CreateMapEntryName();
			silvaLantern.AddTranslation(GameCulture.Russian, "Лесной фонарь");
			tile309.AddMapEntry(new Color(191, 142, 111), silvaLantern);

			ModTile tile310 = TileLoader.GetTile(calamity.TileType("SilvaPiano"));
			ModTranslation silvaPiano = tile310.CreateMapEntryName();
			silvaPiano.AddTranslation(GameCulture.Russian, "Лесное пианино");
			tile310.AddMapEntry(new Color(191, 142, 111), silvaPiano);

			ModTile tile311 = TileLoader.GetTile(calamity.TileType("SilvaSink"));
			ModTranslation silvaSink = tile311.CreateMapEntryName();
			silvaSink.AddTranslation(GameCulture.Russian, "Лесная раковина");
			tile311.AddMapEntry(new Color(191, 142, 111), silvaSink);

			ModTile tile312 = TileLoader.GetTile(calamity.TileType("SilvaTable"));
			ModTranslation silvaTable = tile312.CreateMapEntryName();
			silvaTable.AddTranslation(GameCulture.Russian, "Лесной стол");
			tile312.AddMapEntry(new Color(191, 142, 111), silvaTable);

			ModTile tile313 = TileLoader.GetTile(calamity.TileType("SilvaWorkBench"));
			ModTranslation silvaWorkBench = tile313.CreateMapEntryName();
			silvaWorkBench.AddTranslation(GameCulture.Russian, "Лесной верстак");
			tile313.AddMapEntry(new Color(191, 142, 111), silvaWorkBench);

			ModTile tile314 = TileLoader.GetTile(calamity.TileType("StatigelBath"));
			ModTranslation statigelBath = tile314.CreateMapEntryName();
			statigelBath.AddTranslation(GameCulture.Russian, "Статиджеловая ванна");
			tile314.AddMapEntry(new Color(191, 142, 111), statigelBath);

			ModTile tile315 = TileLoader.GetTile(calamity.TileType("StatigelBed"));
			ModTranslation statigelBed = tile315.CreateMapEntryName();
			statigelBed.AddTranslation(GameCulture.Russian, "Статиджеловая кровать");
			tile315.AddMapEntry(new Color(191, 142, 111), statigelBed);

			ModTile tile316 = TileLoader.GetTile(calamity.TileType("StatigelBlock"));
			ModTranslation statigelBlock = tile316.CreateMapEntryName();
			statigelBlock.AddTranslation(GameCulture.Russian, "Статиджеловый блок");
			tile316.AddMapEntry(new Color(191, 142, 111), statigelBlock);

			ModTile tile317 = TileLoader.GetTile(calamity.TileType("StatigelBookcase"));
			ModTranslation statigelBookcase = tile317.CreateMapEntryName();
			statigelBookcase.AddTranslation(GameCulture.Russian, "Статиджеловый книжный шкаф");
			tile317.AddMapEntry(new Color(191, 142, 111), statigelBookcase);

			ModTile tile318 = TileLoader.GetTile(calamity.TileType("StatigelCandelabra"));
			ModTranslation statigelCandelabra = tile318.CreateMapEntryName();
			statigelCandelabra.AddTranslation(GameCulture.Russian, "Статиджеловый канделябр");
			tile318.AddMapEntry(new Color(191, 142, 111), statigelCandelabra);

			ModTile tile319 = TileLoader.GetTile(calamity.TileType("StatigelCandle"));
			ModTranslation statigelCandle = tile319.CreateMapEntryName();
			statigelCandle.AddTranslation(GameCulture.Russian, "Статиджеловая свеча");
			tile319.AddMapEntry(new Color(191, 142, 111), statigelCandle);

			ModTile tile320 = TileLoader.GetTile(calamity.TileType("StatigelChair"));
			ModTranslation statigelChair = tile320.CreateMapEntryName();
			statigelChair.AddTranslation(GameCulture.Russian, "Статиджеловый стул");
			tile320.AddMapEntry(new Color(191, 142, 111), statigelChair);

			ModTile tile321 = TileLoader.GetTile(calamity.TileType("StatigelChandelier"));
			ModTranslation statigelChandelier = tile321.CreateMapEntryName();
			statigelChandelier.AddTranslation(GameCulture.Russian, "Статиджеловая люстра");
			tile321.AddMapEntry(new Color(191, 142, 111), statigelChandelier);

			ModTile tile322 = TileLoader.GetTile(calamity.TileType("StatigelChest"));
			ModTranslation statigelChest = tile322.CreateMapEntryName();
			statigelChest.AddTranslation(GameCulture.Russian, "Статиджеловый сундук");
			tile322.AddMapEntry(new Color(191, 142, 111), statigelChest);

			ModTile tile323 = TileLoader.GetTile(calamity.TileType("StatigelClock"));
			ModTranslation statigelClock = tile323.CreateMapEntryName();
			statigelClock.AddTranslation(GameCulture.Russian, "Статиджеловые часы");
			tile323.AddMapEntry(new Color(191, 142, 111), statigelClock);

			ModTile tile324 = TileLoader.GetTile(calamity.TileType("StatigelDoorClosed"));
			ModTranslation statigelDoorClosed = tile324.CreateMapEntryName();
			statigelDoorClosed.AddTranslation(GameCulture.Russian, "Статиджеловая дверь");
			tile324.AddMapEntry(new Color(191, 142, 111), statigelDoorClosed);

			ModTile tile325 = TileLoader.GetTile(calamity.TileType("StatigelDoorOpen"));
			ModTranslation statigelDoorOpen = tile325.CreateMapEntryName();
			statigelDoorOpen.AddTranslation(GameCulture.Russian, "Статиджеловая дверь");
			tile325.AddMapEntry(new Color(191, 142, 111), statigelDoorOpen);

			ModTile tile392 = TileLoader.GetTile(calamity.TileType("StatigelDresser"));
			ModTranslation statigelDresser = tile392.CreateMapEntryName();
			statigelDresser.AddTranslation(GameCulture.Russian, "Статиджеловый комод");
			tile392.AddMapEntry(new Color(191, 142, 111), statigelDresser);

			ModTile tile326 = TileLoader.GetTile(calamity.TileType("StatigelLamp"));
			ModTranslation statigelLamp = tile326.CreateMapEntryName();
			statigelLamp.AddTranslation(GameCulture.Russian, "Статиджеловая лампа");
			tile326.AddMapEntry(new Color(191, 142, 111), statigelLamp);

			ModTile tile327 = TileLoader.GetTile(calamity.TileType("StatigelLantern"));
			ModTranslation statigelLantern = tile327.CreateMapEntryName();
			statigelLantern.AddTranslation(GameCulture.Russian, "Статиджеловый фонарь");
			tile327.AddMapEntry(new Color(191, 142, 111), statigelLantern);

			ModTile tile328 = TileLoader.GetTile(calamity.TileType("StatigelPiano"));
			ModTranslation statigelPiano = tile328.CreateMapEntryName();
			statigelPiano.AddTranslation(GameCulture.Russian, "Статиджеловое пианино");
			tile328.AddMapEntry(new Color(191, 142, 111), statigelPiano);

			ModTile tile329 = TileLoader.GetTile(calamity.TileType("StatigelSink"));
			ModTranslation statigelSink = tile329.CreateMapEntryName();
			statigelSink.AddTranslation(GameCulture.Russian, "Статиджеловая раковина");
			tile329.AddMapEntry(new Color(191, 142, 111), statigelSink);

			ModTile tile330 = TileLoader.GetTile(calamity.TileType("StatigelSofa"));
			ModTranslation statigelSofa = tile330.CreateMapEntryName();
			statigelSofa.AddTranslation(GameCulture.Russian, "Статиджеловый комод");
			tile330.AddMapEntry(new Color(191, 142, 111), statigelSofa);

			ModTile tile331 = TileLoader.GetTile(calamity.TileType("StatigelTable"));
			ModTranslation statigelTable = tile331.CreateMapEntryName();
			statigelTable.AddTranslation(GameCulture.Russian, "Статиджеловый стол");
			tile331.AddMapEntry(new Color(191, 142, 111), statigelTable);

			ModTile tile332 = TileLoader.GetTile(calamity.TileType("StatigelWorkbench"));
			ModTranslation statigelWorkbench = tile332.CreateMapEntryName();
			statigelWorkbench.AddTranslation(GameCulture.Russian, "Статиджеловый верстак");
			tile332.AddMapEntry(new Color(191, 142, 111), statigelWorkbench);

			ModTile tile333 = TileLoader.GetTile(calamity.TileType("StratusBathtub"));
			ModTranslation stratusBathtub = tile333.CreateMapEntryName();
			stratusBathtub.AddTranslation(GameCulture.Russian, "Слоистая ванна");
			tile333.AddMapEntry(new Color(191, 142, 111), stratusBathtub);

			ModTile tile334 = TileLoader.GetTile(calamity.TileType("StratusBed"));
			ModTranslation stratusBed = tile334.CreateMapEntryName();
			stratusBed.AddTranslation(GameCulture.Russian, "Слоистая кровать");
			tile334.AddMapEntry(new Color(191, 142, 111), stratusBed);

			ModTile tile335 = TileLoader.GetTile(calamity.TileType("StratusBookcase"));
			ModTranslation stratusBookcase = tile335.CreateMapEntryName();
			stratusBookcase.AddTranslation(GameCulture.Russian, "Слоистый книжный шкаф");
			tile335.AddMapEntry(new Color(191, 142, 111), stratusBookcase);

			ModTile tile336 = TileLoader.GetTile(calamity.TileType("StratusCandelabra"));
			ModTranslation stratusCandelabra = tile336.CreateMapEntryName();
			stratusCandelabra.AddTranslation(GameCulture.Russian, "Слоистый канделябр");
			tile336.AddMapEntry(new Color(191, 142, 111), stratusCandelabra);

			ModTile tile337 = TileLoader.GetTile(calamity.TileType("StratusCandle"));
			ModTranslation stratusCandle = tile337.CreateMapEntryName();
			stratusCandle.AddTranslation(GameCulture.Russian, "Слоистая свеча");
			tile337.AddMapEntry(new Color(191, 142, 111), stratusCandle);

			ModTile tile338 = TileLoader.GetTile(calamity.TileType("StratusChair"));
			ModTranslation stratusChair = tile338.CreateMapEntryName();
			stratusChair.AddTranslation(GameCulture.Russian, "Слоистый стул");
			tile338.AddMapEntry(new Color(191, 142, 111), stratusChair);

			ModTile tile339 = TileLoader.GetTile(calamity.TileType("StratusChandelier"));
			ModTranslation stratusChandelier = tile339.CreateMapEntryName();
			stratusChandelier.AddTranslation(GameCulture.Russian, "Слоистая люстра");
			tile339.AddMapEntry(new Color(191, 142, 111), stratusChandelier);

			ModTile tile340 = TileLoader.GetTile(calamity.TileType("StratusChest"));
			ModTranslation stratusChest = tile340.CreateMapEntryName();
			stratusChest.AddTranslation(GameCulture.Russian, "Слоистый сундук");
			tile340.AddMapEntry(new Color(191, 142, 111), stratusChest);

			ModTile tile341 = TileLoader.GetTile(calamity.TileType("StratusClock"));
			ModTranslation stratusClock = tile341.CreateMapEntryName();
			stratusClock.AddTranslation(GameCulture.Russian, "Слоистые часы");
			tile341.AddMapEntry(new Color(191, 142, 111), stratusClock);

			ModTile tile342 = TileLoader.GetTile(calamity.TileType("StratusDoorClosed"));
			ModTranslation stratusDoorClosed = tile342.CreateMapEntryName();
			stratusDoorClosed.AddTranslation(GameCulture.Russian, "Слоистая дверь");
			tile342.AddMapEntry(new Color(191, 142, 111), stratusDoorClosed);

			ModTile tile343 = TileLoader.GetTile(calamity.TileType("StratusDoorOpen"));
			ModTranslation stratusDoorOpen = tile343.CreateMapEntryName();
			stratusDoorOpen.AddTranslation(GameCulture.Russian, "Слоистая дверь");
			tile343.AddMapEntry(new Color(191, 142, 111), stratusDoorOpen);

			ModTile tile344 = TileLoader.GetTile(calamity.TileType("StratusDresser"));
			ModTranslation stratusDresser = tile344.CreateMapEntryName();
			stratusDresser.AddTranslation(GameCulture.Russian, "Слоистый комод");
			tile344.AddMapEntry(new Color(191, 142, 111), stratusDresser);

			ModTile tile345 = TileLoader.GetTile(calamity.TileType("StratusLamp"));
			ModTranslation stratusLamp = tile345.CreateMapEntryName();
			stratusLamp.AddTranslation(GameCulture.Russian, "Слоистая лампа");
			tile345.AddMapEntry(new Color(191, 142, 111), stratusLamp);

			ModTile tile346 = TileLoader.GetTile(calamity.TileType("StratusLantern"));
			ModTranslation stratusLantern = tile346.CreateMapEntryName();
			stratusLantern.AddTranslation(GameCulture.Russian, "Слоистый фонарь");
			tile346.AddMapEntry(new Color(191, 142, 111), stratusLantern);

			ModTile tile347 = TileLoader.GetTile(calamity.TileType("StratusPiano"));
			ModTranslation stratusPiano = tile347.CreateMapEntryName();
			stratusPiano.AddTranslation(GameCulture.Russian, "Слоистое пианино");
			tile347.AddMapEntry(new Color(191, 142, 111), stratusPiano);

			ModTile tile348 = TileLoader.GetTile(calamity.TileType("StratusSink"));
			ModTranslation stratusSink = tile348.CreateMapEntryName();
			stratusSink.AddTranslation(GameCulture.Russian, "Слоистая раковина");
			tile348.AddMapEntry(new Color(191, 142, 111), stratusSink);

			ModTile tile349 = TileLoader.GetTile(calamity.TileType("StratusSofa"));
			ModTranslation stratusSofa = tile349.CreateMapEntryName();
			stratusSofa.AddTranslation(GameCulture.Russian, "Слоистый диван");
			tile349.AddMapEntry(new Color(191, 142, 111), stratusSofa);

			ModTile tile350 = TileLoader.GetTile(calamity.TileType("StratusTable"));
			ModTranslation stratusTable = tile350.CreateMapEntryName();
			stratusTable.AddTranslation(GameCulture.Russian, "Слоистый стол");
			tile350.AddMapEntry(new Color(191, 142, 111), stratusTable);

			ModTile tile351 = TileLoader.GetTile(calamity.TileType("StratusWorkbench"));
			ModTranslation stratusWorkbench = tile351.CreateMapEntryName();
			stratusWorkbench.AddTranslation(GameCulture.Russian, "Слоистый верстак");
			tile351.AddMapEntry(new Color(191, 142, 111), stratusWorkbench);

			ModTile tile352 = TileLoader.GetTile(calamity.TileType("VoidBath"));
			ModTranslation voidBath = tile352.CreateMapEntryName();
			voidBath.AddTranslation(GameCulture.Russian, "Пустотная ванна");
			tile352.AddMapEntry(new Color(191, 142, 111), voidBath);
			
			ModTile tile353 = TileLoader.GetTile(calamity.TileType("VoidBed"));
			ModTranslation voidBed = tile353.CreateMapEntryName();
			voidBed.AddTranslation(GameCulture.Russian, "Пустотная кровать");
			tile353.AddMapEntry(new Color(191, 142, 111), voidBed);
			
			ModTile tile354 = TileLoader.GetTile(calamity.TileType("VoidBookcase"));
			ModTranslation voidBookcase = tile354.CreateMapEntryName();
			voidBookcase.AddTranslation(GameCulture.Russian, "Пустотный книжный шкаф");
			tile354.AddMapEntry(new Color(191, 142, 111), voidBookcase);
			
			ModTile tile355 = TileLoader.GetTile(calamity.TileType("VoidCandelabra"));
			ModTranslation voidCandelabra = tile355.CreateMapEntryName();
			voidCandelabra.AddTranslation(GameCulture.Russian, "Пустотный канделябр");
			tile355.AddMapEntry(new Color(191, 142, 111), voidCandelabra);
			
			ModTile tile356 = TileLoader.GetTile(calamity.TileType("VoidCandle"));
			ModTranslation voidCandle = tile356.CreateMapEntryName();
			voidCandle.AddTranslation(GameCulture.Russian, "Пустотная свеча");
			tile356.AddMapEntry(new Color(191, 142, 111), voidCandle);
			
			ModTile tile357 = TileLoader.GetTile(calamity.TileType("VoidChair"));
			ModTranslation voidChair = tile357.CreateMapEntryName();
			voidChair.AddTranslation(GameCulture.Russian, "Пустотный стул");
			tile357.AddMapEntry(new Color(191, 142, 111), voidChair);
			
			ModTile tile358 = TileLoader.GetTile(calamity.TileType("VoidChandelier"));
			ModTranslation voidChandelier = tile358.CreateMapEntryName();
			voidChandelier.AddTranslation(GameCulture.Russian, "Пустотная люстра");
			tile358.AddMapEntry(new Color(191, 142, 111), voidChandelier);
			
			ModTile tile359 = TileLoader.GetTile(calamity.TileType("VoidChest"));
			ModTranslation voidChest = tile359.CreateMapEntryName();
			voidChest.AddTranslation(GameCulture.Russian, "Пустотный сундук");
			tile359.AddMapEntry(new Color(191, 142, 111), voidChest);
			
			ModTile tile360 = TileLoader.GetTile(calamity.TileType("VoidClock"));
			ModTranslation voidClock = tile360.CreateMapEntryName();
			voidClock.AddTranslation(GameCulture.Russian, "Пустотный обелиск");
			tile360.AddMapEntry(new Color(191, 142, 111), voidClock);
			
			ModTile tile361 = TileLoader.GetTile(calamity.TileType("VoidDoorClosed"));
			ModTranslation doorClosed = tile361.CreateMapEntryName();
			doorClosed.AddTranslation(GameCulture.Russian, "Пустотная дверь");
			tile361.AddMapEntry(new Color(191, 142, 111), doorClosed);
			
			ModTile tile362 = TileLoader.GetTile(calamity.TileType("VoidDoorOpen"));
			ModTranslation voidDoorOpen = tile362.CreateMapEntryName();
			voidDoorOpen.AddTranslation(GameCulture.Russian, "Пустотная дверь");
			tile362.AddMapEntry(new Color(191, 142, 111), voidDoorOpen);
			
			ModTile tile363 = TileLoader.GetTile(calamity.TileType("VoidDresser"));
			ModTranslation voidDresser = tile363.CreateMapEntryName();
			voidDresser.AddTranslation(GameCulture.Russian, "Пустотный комод");
			tile363.AddMapEntry(new Color(191, 142, 111), voidDresser);
			
			ModTile tile364 = TileLoader.GetTile(calamity.TileType("VoidLamp"));
			ModTranslation voidLamp = tile364.CreateMapEntryName();
			voidLamp.AddTranslation(GameCulture.Russian, "Пустотная лампа");
			tile364.AddMapEntry(new Color(191, 142, 111), voidLamp);
			
			ModTile tile365 = TileLoader.GetTile(calamity.TileType("VoidLantern"));
			ModTranslation voidLantern = tile365.CreateMapEntryName();
			voidLantern.AddTranslation(GameCulture.Russian, "Пустотный фонарь");
			tile365.AddMapEntry(new Color(191, 142, 111), voidLantern);
			
			ModTile tile366 = TileLoader.GetTile(calamity.TileType("VoidPiano"));
			ModTranslation voidPiano = tile366.CreateMapEntryName();
			voidPiano.AddTranslation(GameCulture.Russian, "Пустотное пианино");
			tile366.AddMapEntry(new Color(191, 142, 111), voidPiano);
			
			ModTile tile367 = TileLoader.GetTile(calamity.TileType("VoidSink"));
			ModTranslation voidSink = tile367.CreateMapEntryName();
			voidSink.AddTranslation(GameCulture.Russian, "Пустотная раковина");
			tile367.AddMapEntry(new Color(191, 142, 111), voidSink);
			
			ModTile tile368 = TileLoader.GetTile(calamity.TileType("VoidSofa"));
			ModTranslation voidSofa = tile368.CreateMapEntryName();
			voidSofa.AddTranslation(GameCulture.Russian, "Пустотный диван");
			tile368.AddMapEntry(new Color(191, 142, 111), voidSofa);
			
			ModTile tile369 = TileLoader.GetTile(calamity.TileType("VoidTable"));
			ModTranslation voidTable = tile369.CreateMapEntryName();
			voidTable.AddTranslation(GameCulture.Russian, "Пустотный стол");
			tile369.AddMapEntry(new Color(191, 142, 111), voidTable);
			
			ModTile tile370 = TileLoader.GetTile(calamity.TileType("VoidWorkbench"));
			ModTranslation voidWorkbench = tile370.CreateMapEntryName();
			voidWorkbench.AddTranslation(GameCulture.Russian, "Пустотный верстак");
			tile370.AddMapEntry(new Color(191, 142, 111), voidWorkbench);
			
			ModTile tile371 = TileLoader.GetTile(calamity.TileType("AerialiteOre"));
			ModTranslation aerialiteOre = tile371.CreateMapEntryName();
			aerialiteOre.AddTranslation(GameCulture.Russian, "Аэриалитовая руда");
			tile371.AddMapEntry(new Color(0, 255, 255), aerialiteOre);
			
			ModTile tile372 = TileLoader.GetTile(calamity.TileType("AstralOre"));
			ModTranslation astralOre = tile372.CreateMapEntryName();
			astralOre.AddTranslation(GameCulture.Russian, "Астральная руда");
			tile372.AddMapEntry(new Color(255, 153, 255), astralOre);
			
			ModTile tile373 = TileLoader.GetTile(calamity.TileType("AuricOre"));
			ModTranslation auricOre = tile373.CreateMapEntryName();
			auricOre.AddTranslation(GameCulture.Russian, "Золотоносная руда");
			tile373.AddMapEntry(new Color(255, 200, 0), auricOre);
			
			ModTile tile374 = TileLoader.GetTile(calamity.TileType("ChaoticOre"));
			ModTranslation chaoticOre = tile374.CreateMapEntryName();
			chaoticOre.AddTranslation(GameCulture.Russian, "Магматитовая руда");
			tile374.AddMapEntry(new Color(255, 0, 0), chaoticOre);
			
			ModTile tile375 = TileLoader.GetTile(calamity.TileType("CharredOre"));
			ModTranslation charredOre = tile375.CreateMapEntryName();
			charredOre.AddTranslation(GameCulture.Russian, "Обугленная руда");
			tile375.AddMapEntry(new Color(17, 16, 26), charredOre);
			
			ModTile tile376 = TileLoader.GetTile(calamity.TileType("CryonicOre"));
			ModTranslation cryonicOre = tile376.CreateMapEntryName();
			cryonicOre.AddTranslation(GameCulture.Russian, "Крионическая руда");
			tile376.AddMapEntry(new Color(0, 0, 150), cryonicOre);
			
			ModTile tile377 = TileLoader.GetTile(calamity.TileType("ExodiumOre"));
			ModTranslation exodiumOre = tile377.CreateMapEntryName();
			exodiumOre.AddTranslation(GameCulture.Russian, "Кластер Экзодиума");
			tile377.AddMapEntry(new Color(51, 48, 68), exodiumOre);
			
			ModTile tile378 = TileLoader.GetTile(calamity.TileType("PerennialOre"));
			ModTranslation perennialOre = tile378.CreateMapEntryName();
			perennialOre.AddTranslation(GameCulture.Russian, "Многолетняя руда");
			tile378.AddMapEntry(new Color(200, 250, 100), perennialOre);
			
			ModTile tile379 = TileLoader.GetTile(calamity.TileType("UelibloomOre"));
			ModTranslation uelibloomOre = tile379.CreateMapEntryName();
			uelibloomOre.AddTranslation(GameCulture.Russian, "Улиблумовая руда");
			tile379.AddMapEntry(new Color(0, 255, 0), uelibloomOre);
			
			ModTile tile380 = TileLoader.GetTile(calamity.TileType("BrainCoral"));
			ModTranslation brainCoral = tile380.CreateMapEntryName();
			brainCoral.AddTranslation(GameCulture.Russian, "Мозговой коралл");
			tile380.AddMapEntry(new Color(0, 0, 80), brainCoral);
			
			ModTile tile381 = TileLoader.GetTile(calamity.TileType("EutrophicSand"));
			ModTranslation eutrophicSand = tile381.CreateMapEntryName();
			eutrophicSand.AddTranslation(GameCulture.Russian, "Эвтрофный песок");
			tile381.AddMapEntry(new Color(100, 100, 150), eutrophicSand);
			
			ModTile tile382 = TileLoader.GetTile(calamity.TileType("FanCoral"));
			ModTranslation fanCoral = tile382.CreateMapEntryName();
			fanCoral.AddTranslation(GameCulture.Russian, "Воздушный коралл");
			tile382.AddMapEntry(new Color(0, 0, 80), fanCoral);
			
			ModTile tile383 = TileLoader.GetTile(calamity.TileType("Navystone"));
			ModTranslation navystone = tile383.CreateMapEntryName();
			navystone.AddTranslation(GameCulture.Russian, "Морской камень");
			tile383.AddMapEntry(new Color(0, 50, 50), navystone);
			
			ModTile tile384 = TileLoader.GetTile(calamity.TileType("SeaAnemone"));
			ModTranslation seaAnemone = tile384.CreateMapEntryName();
			seaAnemone.AddTranslation(GameCulture.Russian, "Актиния");
			tile384.AddMapEntry(new Color(0, 0, 80), seaAnemone);
			
			ModTile tile385 = TileLoader.GetTile(calamity.TileType("SeaPrism"));
			ModTranslation seaPrism = tile385.CreateMapEntryName();
			seaPrism.AddTranslation(GameCulture.Russian, "Морская призма");
			tile385.AddMapEntry(new Color(0, 150, 200), seaPrism);
			
			ModTile tile386 = TileLoader.GetTile(calamity.TileType("SeaPrismCrystals"));
			ModTranslation seaPrismCrystals = tile386.CreateMapEntryName();
			seaPrismCrystals.AddTranslation(GameCulture.Russian, "Кристалл морской призмы");
			tile386.AddMapEntry(new Color(0, 150, 200), seaPrismCrystals);
			
			ModTile tile387 = TileLoader.GetTile(calamity.TileType("SmallBrainCoral"));
			ModTranslation smallBrainCoral = tile387.CreateMapEntryName();
			smallBrainCoral.AddTranslation(GameCulture.Russian, "Маленький мозговой коралл");
			tile387.AddMapEntry(new Color(0, 0, 80), smallBrainCoral);
			
			ModTile tile388 = TileLoader.GetTile(calamity.TileType("SmallTubeCoral"));
			ModTranslation smallTubeCoral = tile388.CreateMapEntryName();
			smallTubeCoral.AddTranslation(GameCulture.Russian, "Маленький трубчатый коралл");
			tile388.AddMapEntry(new Color(0, 0, 80), smallTubeCoral);
			
			ModTile tile389 = TileLoader.GetTile(calamity.TileType("SunkenCrateTile"));
			ModTranslation sunkenCrateTile = tile389.CreateMapEntryName();
			sunkenCrateTile.AddTranslation(GameCulture.Russian, "Затерянный ящик");
			tile389.AddMapEntry(new Color(106, 218, 230), sunkenCrateTile);
			
			ModTile tile390 = TileLoader.GetTile(calamity.TileType("TableCoral"));
			ModTranslation tableCoral = tile390.CreateMapEntryName();
			tableCoral.AddTranslation(GameCulture.Russian, "Пластинчатый коралл");
			tile390.AddMapEntry(new Color(0, 0, 80), tableCoral);
			
			ModTile tile391 = TileLoader.GetTile(calamity.TileType("TubeCoral"));
			ModTranslation tubeCoral = tile391.CreateMapEntryName();
			tubeCoral.AddTranslation(GameCulture.Russian, "Трубчатый коралл");
			tile391.AddMapEntry(new Color(0, 0, 80), tubeCoral);
		}
	}
}
