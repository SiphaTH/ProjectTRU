using Microsoft.Xna.Framework;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ElementsAwoken.Tiles
{
	internal class ElementsAwokenTiles
	{
		public static void Setup()
		{
			Tiles();
		}

		private static void Tiles()
		{
			Mod elementsAwoken = ModLoader.GetMod("ElementsAwoken");
			
			ModTile tile = TileLoader.GetTile(elementsAwoken.TileType("Altar"));
			ModTranslation altar = tile.CreateMapEntryName();
			altar.AddTranslation(GameCulture.Russian, "Алтарь");
			tile.AddMapEntry(new Color(141, 11, 156), altar);

			ModTile tile2 = TileLoader.GetTile(elementsAwoken.TileType("Firebrick"));
			ModTranslation firebrick = tile2.CreateMapEntryName();
			firebrick.AddTranslation(GameCulture.Russian, "Пустотный кирпич");
			tile2.AddMapEntry(new Color(255, 127, 227), firebrick);

			ModTile tile3 = TileLoader.GetTile(elementsAwoken.TileType("HiveCratePlaced"));
			ModTranslation hiveCratePlaced = tile3.CreateMapEntryName();
			hiveCratePlaced.AddTranslation(GameCulture.Russian, "Ящик улья");
			tile3.AddMapEntry(new Color(200, 200, 200), hiveCratePlaced);

			ModTile tile4 = TileLoader.GetTile(elementsAwoken.TileType("Voidite"));
			ModTranslation voidite = tile4.CreateMapEntryName();
			voidite.AddTranslation(GameCulture.Russian, "Пустотная руда");
			tile4.AddMapEntry(new Color(255, 127, 227), voidite);

			ModTile tile5 = TileLoader.GetTile(elementsAwoken.TileType("MonsterBanner"));
			ModTranslation monsterBanner = tile5.CreateMapEntryName();
			monsterBanner.AddTranslation(GameCulture.Russian, "Знамя");
			tile5.AddMapEntry(new Color(13, 88, 130), monsterBanner);

			ModTile tile6 = TileLoader.GetTile(elementsAwoken.TileType("MortemiteBanners"));
			ModTranslation mortemiteBanners = tile6.CreateMapEntryName();
			mortemiteBanners.AddTranslation(GameCulture.Russian, "Знамя");
			tile6.AddMapEntry(new Color(13, 88, 130), mortemiteBanners);

			ModTile tile7 = TileLoader.GetTile(elementsAwoken.TileType("PebleerBanner"));
			ModTranslation pebleerBanner = tile7.CreateMapEntryName();
			pebleerBanner.AddTranslation(GameCulture.Russian, "Знамя");
			tile7.AddMapEntry(new Color(13, 88, 130), pebleerBanner);

			ModTile tile8 = TileLoader.GetTile(elementsAwoken.TileType("EtherealHunterBanner"));
			ModTranslation etherealHunterBanner = tile8.CreateMapEntryName();
			etherealHunterBanner.AddTranslation(GameCulture.Russian, "Знамя");
			tile8.AddMapEntry(new Color(13, 88, 130), etherealHunterBanner);

			ModTile tile9 = TileLoader.GetTile(elementsAwoken.TileType("ImmolatorBanner"));
			ModTranslation immolatorBanner = tile9.CreateMapEntryName();
			immolatorBanner.AddTranslation(GameCulture.Russian, "Знамя");
			tile9.AddMapEntry(new Color(13, 88, 130), immolatorBanner);

			ModTile tile10 = TileLoader.GetTile(elementsAwoken.TileType("ReaverSlimeBanner"));
			ModTranslation reaverSlimeBanner = tile10.CreateMapEntryName();
			reaverSlimeBanner.AddTranslation(GameCulture.Russian, "Знамя");
			tile10.AddMapEntry(new Color(13, 88, 130), reaverSlimeBanner);

			ModTile tile11 = TileLoader.GetTile(elementsAwoken.TileType("VoidCrawlerBanner"));
			ModTranslation voidCrawlerBanner = tile11.CreateMapEntryName();
			voidCrawlerBanner.AddTranslation(GameCulture.Russian, "Знамя");
			tile11.AddMapEntry(new Color(13, 88, 130), voidCrawlerBanner);

			ModTile tile12 = TileLoader.GetTile(elementsAwoken.TileType("VoidGolemBanner"));
			ModTranslation voidGolemBanner = tile12.CreateMapEntryName();
			voidGolemBanner.AddTranslation(GameCulture.Russian, "Знамя");
			tile12.AddMapEntry(new Color(13, 88, 130), voidGolemBanner);

			ModTile tile13 = TileLoader.GetTile(elementsAwoken.TileType("VoidKnightBanner"));
			ModTranslation voidKnightBanner = tile13.CreateMapEntryName();
			voidKnightBanner.AddTranslation(GameCulture.Russian, "Знамя");
			tile13.AddMapEntry(new Color(13, 88, 130), voidKnightBanner);

			ModTile tile14 = TileLoader.GetTile(elementsAwoken.TileType("ZergCasterBanner"));
			ModTranslation zergCasterBanner = tile14.CreateMapEntryName();
			zergCasterBanner.AddTranslation(GameCulture.Russian, "Знамя");
			tile14.AddMapEntry(new Color(13, 88, 130), zergCasterBanner);

			ModTile tile15 = TileLoader.GetTile(elementsAwoken.TileType("ChaoticCrucible"));
			ModTranslation chaoticCrucible = tile15.CreateMapEntryName();
			chaoticCrucible.AddTranslation(GameCulture.Russian, "Тигель Хаотрона");
			tile15.AddMapEntry(new Color(217, 137, 85), chaoticCrucible);

			ModTile tile16 = TileLoader.GetTile(elementsAwoken.TileType("CrystalCracker"));
			ModTranslation crystalCracker = tile16.CreateMapEntryName();
			crystalCracker.AddTranslation(GameCulture.Russian, "Разрушитель кристаллов");
			tile16.AddMapEntry(new Color(133, 133, 133), crystalCracker);

			ModTile tile17 = TileLoader.GetTile(elementsAwoken.TileType("ElementalForge"));
			ModTranslation elementalForge = tile17.CreateMapEntryName();
			elementalForge.AddTranslation(GameCulture.Russian, "Элементальная кузня");
			tile17.AddMapEntry(new Color(133, 133, 133), elementalForge);

			ModTile tile18 = TileLoader.GetTile(elementsAwoken.TileType("Putrifier"));
			ModTranslation putrifier = tile18.CreateMapEntryName();
			putrifier.AddTranslation(GameCulture.Russian, "Машина гниения");
			tile18.AddMapEntry(new Color(39, 78, 96), putrifier);

			ModTile tile19 = TileLoader.GetTile(elementsAwoken.TileType("DarkstoneBed"));
			ModTranslation darkstoneBed = tile19.CreateMapEntryName();
			darkstoneBed.AddTranslation(GameCulture.Russian, "Кровать из тёмного камня");
			tile19.AddMapEntry(new Color(51, 51, 51), darkstoneBed);

			ModTile tile20 = TileLoader.GetTile(elementsAwoken.TileType("DarkstoneCandle"));
			ModTranslation darkstoneCandle = tile20.CreateMapEntryName();
			darkstoneCandle.AddTranslation(GameCulture.Russian, "Свеча из тёмного камня");
			tile20.AddMapEntry(new Color(51, 51, 51), darkstoneCandle);

			ModTile tile21 = TileLoader.GetTile(elementsAwoken.TileType("DarkstoneChair"));
			ModTranslation darkstoneChair = tile21.CreateMapEntryName();
			darkstoneChair.AddTranslation(GameCulture.Russian, "Стул из тёмного камня");
			tile21.AddMapEntry(new Color(51, 51, 51), darkstoneChair);

			ModTile tile22 = TileLoader.GetTile(elementsAwoken.TileType("DarkstoneChandelier"));
			ModTranslation darkstoneChandelier = tile22.CreateMapEntryName();
			darkstoneChandelier.AddTranslation(GameCulture.Russian, "Люстра из тёмного камня");
			tile22.AddMapEntry(new Color(51, 51, 51), darkstoneChandelier);

			ModTile tile23 = TileLoader.GetTile(elementsAwoken.TileType("DarkstoneDoorClosed"));
			ModTranslation darkstoneDoorClosed = tile23.CreateMapEntryName();
			darkstoneDoorClosed.AddTranslation(GameCulture.Russian, "Дверь из тёмного камня");
			tile23.AddMapEntry(new Color(51, 51, 51), darkstoneDoorClosed);

			ModTile tile24 = TileLoader.GetTile(elementsAwoken.TileType("DarkstoneDoorOpen"));
			ModTranslation darkstoneDoorOpen = tile24.CreateMapEntryName();
			darkstoneDoorOpen.AddTranslation(GameCulture.Russian, "Дверь из тёмного камня");
			tile24.AddMapEntry(new Color(51, 51, 51), darkstoneDoorOpen);

			ModTile tile25 = TileLoader.GetTile(elementsAwoken.TileType("DarkstoneLantern"));
			ModTranslation darkstoneLantern = tile25.CreateMapEntryName();
			darkstoneLantern.AddTranslation(GameCulture.Russian, "Светильник из тёмного камня");
			tile25.AddMapEntry(new Color(51, 51, 51), darkstoneLantern);

			ModTile tile26 = TileLoader.GetTile(elementsAwoken.TileType("DarkstoneSofa"));
			ModTranslation darkstoneSofa = tile26.CreateMapEntryName();
			darkstoneSofa.AddTranslation(GameCulture.Russian, "Диван из тёмного камня");
			tile26.AddMapEntry(new Color(51, 51, 51), darkstoneSofa);

			ModTile tile27 = TileLoader.GetTile(elementsAwoken.TileType("DarkstoneTable"));
			ModTranslation darkstoneTable = tile27.CreateMapEntryName();
			darkstoneTable.AddTranslation(GameCulture.Russian, "Стол из тёмного камня");
			tile27.AddMapEntry(new Color(51, 51, 51), darkstoneTable);

			ModTile tile28 = TileLoader.GetTile(elementsAwoken.TileType("DarkstoneWorkBench"));
			ModTranslation darkstoneWorkBench = tile28.CreateMapEntryName();
			darkstoneWorkBench.AddTranslation(GameCulture.Russian, "Верстак из тёмного камня");
			tile28.AddMapEntry(new Color(51, 51, 51), darkstoneWorkBench);

			ModTile tile29 = TileLoader.GetTile(elementsAwoken.TileType("Desk"));
			ModTranslation desk = tile29.CreateMapEntryName();
			desk.AddTranslation(GameCulture.Russian, "Стол");
			tile29.AddMapEntry(new Color(98, 214, 177), desk);

			ModTile tile30 = TileLoader.GetTile(elementsAwoken.TileType("LabBench"));
			ModTranslation labBench = tile30.CreateMapEntryName();
			labBench.AddTranslation(GameCulture.Russian, "Лабораторная скамейка");
			tile30.AddMapEntry(new Color(98, 214, 177), labBench);

			ModTile tile31 = TileLoader.GetTile(elementsAwoken.TileType("Locker"));
			ModTranslation locker = tile31.CreateMapEntryName();
			locker.AddTranslation(GameCulture.Russian, "Шкафчик");
			tile31.AddMapEntry(new Color(98, 214, 177), locker);

			ModTile tile32 = TileLoader.GetTile(elementsAwoken.TileType("OfficeChair"));
			ModTranslation officeChair = tile32.CreateMapEntryName();
			officeChair.AddTranslation(GameCulture.Russian, "Офисное кресло");
			tile32.AddMapEntry(new Color(98, 214, 177), officeChair);

			ModTile tile33 = TileLoader.GetTile(elementsAwoken.TileType("OfficeChairPlayer"));
			ModTranslation officeChairPlayer = tile33.CreateMapEntryName();
			officeChairPlayer.AddTranslation(GameCulture.Russian, "Офисное кресло");
			tile33.AddMapEntry(new Color(98, 214, 177), officeChairPlayer);

			ModTile tile34 = TileLoader.GetTile(elementsAwoken.TileType("PuffTorch"));
			ModTranslation puffTorch = tile34.CreateMapEntryName();
			puffTorch.AddTranslation(GameCulture.Russian, "Факел");
			tile34.AddMapEntry(new Color(239, 162, 229), puffTorch);

			ModTile tile35 = TileLoader.GetTile(elementsAwoken.TileType("AqueousTrophy"));
			ModTranslation aqueousTrophy = tile35.CreateMapEntryName();
			aqueousTrophy.AddTranslation(GameCulture.Russian, "Трофей Аквауса");
			tile35.AddMapEntry(new Color(120, 85, 60), aqueousTrophy);

			ModTile tile36 = TileLoader.GetTile(elementsAwoken.TileType("AzanaTrophy"));
			ModTranslation azanaTrophy = tile36.CreateMapEntryName();
			azanaTrophy.AddTranslation(GameCulture.Russian, "Трофей Азаны");
			tile36.AddMapEntry(new Color(120, 85, 60), azanaTrophy);

			ModTile tile37 = TileLoader.GetTile(elementsAwoken.TileType("InfernaceTrophy"));
			ModTranslation infernaceTrophy = tile37.CreateMapEntryName();
			infernaceTrophy.AddTranslation(GameCulture.Russian, "Трофей Инфернэйса");
			tile37.AddMapEntry(new Color(120, 85, 60), infernaceTrophy);

			ModTile tile38 = TileLoader.GetTile(elementsAwoken.TileType("ObsidiousTrophy"));
			ModTranslation obsidiousTrophy = tile38.CreateMapEntryName();
			obsidiousTrophy.AddTranslation(GameCulture.Russian, "Трофей Обсидиуса");
			tile38.AddMapEntry(new Color(120, 85, 60), obsidiousTrophy);

			ModTile tile39 = TileLoader.GetTile(elementsAwoken.TileType("PermafrostTrophy"));
			ModTranslation permafrostTrophy = tile39.CreateMapEntryName();
			permafrostTrophy.AddTranslation(GameCulture.Russian, "Трофей Пермафроста");
			tile39.AddMapEntry(new Color(120, 85, 60), permafrostTrophy);

			ModTile tile40 = TileLoader.GetTile(elementsAwoken.TileType("RegarothTrophy"));
			ModTranslation regarothTrophy = tile40.CreateMapEntryName();
			regarothTrophy.AddTranslation(GameCulture.Russian, "Трофей Регатота");
			tile40.AddMapEntry(new Color(120, 85, 60), regarothTrophy);

			ModTile tile41 = TileLoader.GetTile(elementsAwoken.TileType("ScourgeFighterTrophy"));
			ModTranslation scourgeFighterTrophy = tile41.CreateMapEntryName();
			scourgeFighterTrophy.AddTranslation(GameCulture.Russian, "Трофей Карающего война");
			tile41.AddMapEntry(new Color(120, 85, 60), scourgeFighterTrophy);

			ModTile tile42 = TileLoader.GetTile(elementsAwoken.TileType("TheCelestialTrophy"));
			ModTranslation theCelestialTrophy = tile42.CreateMapEntryName();
			theCelestialTrophy.AddTranslation(GameCulture.Russian, "Трофей Целестиала");
			tile42.AddMapEntry(new Color(120, 85, 60), theCelestialTrophy);

			ModTile tile43 = TileLoader.GetTile(elementsAwoken.TileType("TheGuardianTrophy"));
			ModTranslation theGuardianTrophy = tile43.CreateMapEntryName();
			theGuardianTrophy.AddTranslation(GameCulture.Russian, "Трофей Хранителя");
			tile43.AddMapEntry(new Color(120, 85, 60), theGuardianTrophy);

			ModTile tile44 = TileLoader.GetTile(elementsAwoken.TileType("VoidLeviathanTrophy"));
			ModTranslation voidLeviathanTrophy = tile44.CreateMapEntryName();
			voidLeviathanTrophy.AddTranslation(GameCulture.Russian, "Трофей Пустотного левиафана");
			tile44.AddMapEntry(new Color(120, 85, 60), voidLeviathanTrophy);

			ModTile tile45 = TileLoader.GetTile(elementsAwoken.TileType("VolcanoxTrophy"));
			ModTranslation volcanoxTrophy = tile45.CreateMapEntryName();
			volcanoxTrophy.AddTranslation(GameCulture.Russian, "Трофей Вулканокса");
			tile45.AddMapEntry(new Color(120, 85, 60), volcanoxTrophy);

			ModTile tile46 = TileLoader.GetTile(elementsAwoken.TileType("WastelandTrophy"));
			ModTranslation wastelandTrophy = tile46.CreateMapEntryName();
			wastelandTrophy.AddTranslation(GameCulture.Russian, "Трофей Картула");
			tile46.AddMapEntry(new Color(120, 85, 60), wastelandTrophy);

			ModTile tile47 = TileLoader.GetTile(elementsAwoken.TileType("VoidBed"));
			ModTranslation voidBed = tile47.CreateMapEntryName();
			voidBed.AddTranslation(GameCulture.Russian, "Пустотная кровать");
			tile47.AddMapEntry(new Color(51, 51, 51), voidBed);

			ModTile tile48 = TileLoader.GetTile(elementsAwoken.TileType("VoidBookshelf"));
			ModTranslation voidBookshelf = tile48.CreateMapEntryName();
			voidBookshelf.AddTranslation(GameCulture.Russian, "Пустотная книжная полка");
			tile48.AddMapEntry(new Color(51, 51, 51), voidBookshelf);

			ModTile tile49 = TileLoader.GetTile(elementsAwoken.TileType("VoidCandelabra"));
			ModTranslation voidCandelabra = tile49.CreateMapEntryName();
			voidCandelabra.AddTranslation(GameCulture.Russian, "Пустотный канделябр");
			tile49.AddMapEntry(new Color(51, 51, 51), voidCandelabra);

			ModTile tile50 = TileLoader.GetTile(elementsAwoken.TileType("VoidCandle"));
			ModTranslation voidCandle = tile50.CreateMapEntryName();
			voidCandle.AddTranslation(GameCulture.Russian, "Пустотная свечка");
			tile50.AddMapEntry(new Color(51, 51, 51), voidCandle);

			ModTile tile51 = TileLoader.GetTile(elementsAwoken.TileType("VoidChair"));
			ModTranslation voidChair = tile51.CreateMapEntryName();
			voidChair.AddTranslation(GameCulture.Russian, "Пустотный стул");
			tile51.AddMapEntry(new Color(51, 51, 51), voidChair);

			ModTile tile52 = TileLoader.GetTile(elementsAwoken.TileType("VoidChandelier"));
			ModTranslation voidChandelier = tile52.CreateMapEntryName();
			voidChandelier.AddTranslation(GameCulture.Russian, "Пустотная люстра");
			tile52.AddMapEntry(new Color(51, 51, 51), voidChandelier);

			ModTile tile53 = TileLoader.GetTile(elementsAwoken.TileType("VoidChest"));
			ModTranslation voidChest = tile53.CreateMapEntryName();
			voidChest.AddTranslation(GameCulture.Russian, "Пустотный сундук");
			tile53.AddMapEntry(new Color(51, 51, 51), voidChest);

			ModTile tile54 = TileLoader.GetTile(elementsAwoken.TileType("VoidDoorClosed"));
			ModTranslation voidDoorClosed = tile54.CreateMapEntryName();
			voidDoorClosed.AddTranslation(GameCulture.Russian, "Пустотная дверь");
			tile54.AddMapEntry(new Color(51, 51, 51), voidDoorClosed);

			ModTile tile55 = TileLoader.GetTile(elementsAwoken.TileType("VoidDoorOpen"));
			ModTranslation voidDoorOpen = tile55.CreateMapEntryName();
			voidDoorOpen.AddTranslation(GameCulture.Russian, "Пустотная дверь");
			tile55.AddMapEntry(new Color(51, 51, 51), voidDoorOpen);

			ModTile tile56 = TileLoader.GetTile(elementsAwoken.TileType("VoidDresser"));
			ModTranslation voidDresser = tile56.CreateMapEntryName();
			voidDresser.AddTranslation(GameCulture.Russian, "Пустотный комод");
			tile56.AddMapEntry(new Color(51, 51, 51), voidDresser);

			ModTile tile57 = TileLoader.GetTile(elementsAwoken.TileType("VoidLantern"));
			ModTranslation voidLantern = tile57.CreateMapEntryName();
			voidLantern.AddTranslation(GameCulture.Russian, "Пустотный светильник");
			tile57.AddMapEntry(new Color(51, 51, 51), voidLantern);

			ModTile tile58 = TileLoader.GetTile(elementsAwoken.TileType("VoidSofa"));
			ModTranslation voidSofa = tile58.CreateMapEntryName();
			voidSofa.AddTranslation(GameCulture.Russian, "Пустотный диван");
			tile58.AddMapEntry(new Color(51, 51, 51), voidSofa);

			ModTile tile59 = TileLoader.GetTile(elementsAwoken.TileType("VoidTable"));
			ModTranslation voidTable = tile59.CreateMapEntryName();
			voidTable.AddTranslation(GameCulture.Russian, "Пустотный стол");
			tile59.AddMapEntry(new Color(51, 51, 51), voidTable);

			ModTile tile60 = TileLoader.GetTile(elementsAwoken.TileType("VoidWorkBench"));
			ModTranslation voidWorkBench = tile60.CreateMapEntryName();
			voidWorkBench.AddTranslation(GameCulture.Russian, "Пустотный верстак");
			tile60.AddMapEntry(new Color(51, 51, 51), voidWorkBench);
		}
	}
}
