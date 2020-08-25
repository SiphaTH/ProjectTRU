using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ShadowsOfAbaddon.NPCs
{
	internal class SacredToolsNpc
	{
		public static void Setup()
		{ 
			Npcs();
		}
		
		private static void Npcs()
		{
			Mod sacredTools = ModLoader.GetMod("SacredTools");
			
			sacredTools.GetNPC("Decorationist").DisplayName.AddTranslation(GameCulture.Russian, "Декоратор");
			sacredTools.GetNPC("Erazor").DisplayName.AddTranslation(GameCulture.Russian, "Падший монарх");
			sacredTools.GetNPC("FeatherShield").DisplayName.AddTranslation(GameCulture.Russian, "Перьевой щит");
			sacredTools.GetNPC("FeatherShieldExpert").DisplayName.AddTranslation(GameCulture.Russian, "Перьевой щит");
			sacredTools.GetNPC("Neil").DisplayName.AddTranslation(GameCulture.Russian, "Прикрытый плащом алхимик");
			sacredTools.GetNPC("Pandolar").DisplayName.AddTranslation(GameCulture.Russian, "Пандоларец, Спасатель");
			sacredTools.GetNPC("PandolarFrozen").DisplayName.AddTranslation(GameCulture.Russian, "Замороженный Пандоларец");
			sacredTools.GetNPC("PandolarUnconscious").DisplayName.AddTranslation(GameCulture.Russian, "Пандоларец без сознания");
			sacredTools.GetNPC("Scavenger").DisplayName.AddTranslation(GameCulture.Russian, "Мусорщица");
			sacredTools.GetNPC("Serpent_Minion").DisplayName.AddTranslation(GameCulture.Russian, "Сверкающий элементаль");
			sacredTools.GetNPC("ShadowWrath_Minion").DisplayName.AddTranslation(GameCulture.Russian, "Кошмарный хранитель");
			sacredTools.GetNPC("Soraniti").DisplayName.AddTranslation(GameCulture.Russian, "Соранити");
			sacredTools.GetNPC("Abaddon").DisplayName.AddTranslation(GameCulture.Russian, "Абаддон, корень страданий");
			sacredTools.GetNPC("NightmareClone").DisplayName.AddTranslation(GameCulture.Russian, "Отчаянный супостат");
			sacredTools.GetNPC("NightmareGuardian").DisplayName.AddTranslation(GameCulture.Russian, "Кошмарный хранитель");
			sacredTools.GetNPC("NightmareSoul").DisplayName.AddTranslation(GameCulture.Russian, "Кошмарная душа");
			sacredTools.GetNPC("NightmareSoul2").DisplayName.AddTranslation(GameCulture.Russian, "Кошмарная душа");
			sacredTools.GetNPC("NightmareWraithMinion").DisplayName.AddTranslation(GameCulture.Russian, "Кошмарный дух");
			sacredTools.GetNPC("AraghurBody").DisplayName.AddTranslation(GameCulture.Russian, "Арагур, змей яркого пламени");
			sacredTools.GetNPC("AraghurHead").DisplayName.AddTranslation(GameCulture.Russian, "Арагур, змей яркого пламени");
			sacredTools.GetNPC("AraghurMinion").DisplayName.AddTranslation(GameCulture.Russian, "Огненный спутник");
			sacredTools.GetNPC("AraghurTail").DisplayName.AddTranslation(GameCulture.Russian, "Арагур, змей яркого пламени");
			sacredTools.GetNPC("SerpentBody").DisplayName.AddTranslation(GameCulture.Russian, "Змеёныш");
			sacredTools.GetNPC("SerpentHead").DisplayName.AddTranslation(GameCulture.Russian, "Змеёныш");
			sacredTools.GetNPC("SerpentTail").DisplayName.AddTranslation(GameCulture.Russian, "Змеёныш");
			sacredTools.GetNPC("Araneas").DisplayName.AddTranslation(GameCulture.Russian, "Аранея");
			sacredTools.GetNPC("AraneasLeg").DisplayName.AddTranslation(GameCulture.Russian, "Аранея");
			sacredTools.GetNPC("Decree").DisplayName.AddTranslation(GameCulture.Russian, "Дикри, морозный хищник");
			sacredTools.GetNPC("DecreeFrozen2").DisplayName.AddTranslation(GameCulture.Russian, "Загадочное замороженное создание");
			sacredTools.GetNPC("DecreeRun").DisplayName.AddTranslation(GameCulture.Russian, "Дикри, морозный хищник");
			sacredTools.GetNPC("DecreeTransition").DisplayName.AddTranslation(GameCulture.Russian, "Дикри, морозный хищник");
			sacredTools.GetNPC("ErazorBoss").DisplayName.AddTranslation(GameCulture.Russian, "Ирейзор");
			sacredTools.GetNPC("ErazorEnergySphere").DisplayName.AddTranslation(GameCulture.Russian, "Сфера энергии тёмного пламени");
			sacredTools.GetNPC("SeekingShadow").DisplayName.AddTranslation(GameCulture.Russian, "Ищущая тень");
			sacredTools.GetNPC("Jensen").DisplayName.AddTranslation(GameCulture.Russian, "Дженсен, великолепная гарпия");
			sacredTools.GetNPC("Dustite").DisplayName.AddTranslation(GameCulture.Russian, "Пылид");
			sacredTools.GetNPC("Novaniel").DisplayName.AddTranslation(GameCulture.Russian, "Нованиэль, наследник престола");
			sacredTools.GetNPC("Nuba").DisplayName.AddTranslation(GameCulture.Russian, "Нуба");
			sacredTools.GetNPC("ShadowNuba").DisplayName.AddTranslation(GameCulture.Russian, "Тень Нубы");
			sacredTools.GetNPC("Solarius").DisplayName.AddTranslation(GameCulture.Russian, "Солярий");
			sacredTools.GetNPC("Voxa").DisplayName.AddTranslation(GameCulture.Russian, "Вихрина");
			sacredTools.GetNPC("DustiteDefeat").DisplayName.AddTranslation(GameCulture.Russian, "Пылид");
			sacredTools.GetNPC("NovanielDefeat").DisplayName.AddTranslation(GameCulture.Russian, "Нованиэль");
			sacredTools.GetNPC("NubaDefeat").DisplayName.AddTranslation(GameCulture.Russian, "Нуба");
			sacredTools.GetNPC("SolariusDefeat").DisplayName.AddTranslation(GameCulture.Russian, "Солярий");
			sacredTools.GetNPC("VoxaDefeat").DisplayName.AddTranslation(GameCulture.Russian, "Вихрина");
			sacredTools.GetNPC("DustiteClone").DisplayName.AddTranslation(GameCulture.Russian, "Звёздная проекция");
			sacredTools.GetNPC("DustiteDragonHead").DisplayName.AddTranslation(GameCulture.Russian, "Звёздный череп");
			sacredTools.GetNPC("DustiteStarReaver").DisplayName.AddTranslation(GameCulture.Russian, "Звёздный грабитель");
			sacredTools.GetNPC("DustiteStarstreamWyrmBody").DisplayName.AddTranslation(GameCulture.Russian, "Вирм потока звёзд");
			sacredTools.GetNPC("DustiteStarstreamWyrmBody2").DisplayName.AddTranslation(GameCulture.Russian, "Вирм потока звёзд");
			sacredTools.GetNPC("DustiteStarstreamWyrmBody3").DisplayName.AddTranslation(GameCulture.Russian, "Вирм потока звёзд");
			sacredTools.GetNPC("DustiteStarstreamWyrmHead").DisplayName.AddTranslation(GameCulture.Russian, "Вирм потока звёзд");
			sacredTools.GetNPC("DustiteStarstreamWyrmTail").DisplayName.AddTranslation(GameCulture.Russian, "Вирм потока звёзд");
			sacredTools.GetNPC("VoxaTrackingGrenade").DisplayName.AddTranslation(GameCulture.Russian, "Отслеживающая ракета");
			sacredTools.GetNPC("AbyssFlame2").DisplayName.AddTranslation(GameCulture.Russian, "Глубинный уголёк");
			sacredTools.GetNPC("AbyssFlame3").DisplayName.AddTranslation(GameCulture.Russian, "Глубинный уголёк");
			sacredTools.GetNPC("AbyssFlameStationary").DisplayName.AddTranslation(GameCulture.Russian, "Глубинный фонарь");
			sacredTools.GetNPC("RelicShieldNihilus").DisplayName.AddTranslation(GameCulture.Russian, "Аура подавления");
			sacredTools.GetNPC("Spookboi").DisplayName.AddTranslation(GameCulture.Russian, "Нигилус");
			sacredTools.GetNPC("SpookboiSpirit").DisplayName.AddTranslation(GameCulture.Russian, "Нигилус, Пламя Бездны");
			sacredTools.GetNPC("SpookboiSpiritHand").DisplayName.AddTranslation(GameCulture.Russian, "Коготь Нигилуса");
			sacredTools.GetNPC("Primordia").DisplayName.AddTranslation(GameCulture.Russian, "Ипостась");
			sacredTools.GetNPC("Primordia2").DisplayName.AddTranslation(GameCulture.Russian, "Ипостась");
			sacredTools.GetNPC("PrimordiaBody").DisplayName.AddTranslation(GameCulture.Russian, "Ипостась");
			sacredTools.GetNPC("PrimordiaShield").DisplayName.AddTranslation(GameCulture.Russian, "Щитовой спутник");
			sacredTools.GetNPC("DreadCore").DisplayName.AddTranslation(GameCulture.Russian, "Ужасное ядро");
			sacredTools.GetNPC("FlamePump").DisplayName.AddTranslation(GameCulture.Russian, "Пылающая тыква");
			sacredTools.GetNPC("PumpFlame").DisplayName.AddTranslation(GameCulture.Russian, "Тыквенное пламя");
			sacredTools.GetNPC("PumpFlame2").DisplayName.AddTranslation(GameCulture.Russian, "Тыквенное пламя");
			sacredTools.GetNPC("Pumpfly").DisplayName.AddTranslation(GameCulture.Russian, "Тыковка");
			sacredTools.GetNPC("Pumpslime").DisplayName.AddTranslation(GameCulture.Russian, "Тыкволизень");
			sacredTools.GetNPC("RalnekDefeat").DisplayName.AddTranslation(GameCulture.Russian, "Ралнек");
			sacredTools.GetNPC("RalnekPhase3").DisplayName.AddTranslation(GameCulture.Russian, "Дух тыквы");
			sacredTools.GetNPC("FeatherShieldShoot").DisplayName.AddTranslation(GameCulture.Russian, "Перо");
			sacredTools.GetNPC("Raynare").DisplayName.AddTranslation(GameCulture.Russian, "Рейнар, королева гарпий");
			sacredTools.GetNPC("RoyalHarpy").DisplayName.AddTranslation(GameCulture.Russian, "Королевская гарпия");
			sacredTools.GetNPC("Yofaress").DisplayName.AddTranslation(GameCulture.Russian, "Йофаресс");
			sacredTools.GetNPC("FlamingSpiritDefeat").DisplayName.AddTranslation(GameCulture.Russian, "Пламенный дух");
			sacredTools.GetNPC("BismuthElemental").DisplayName.AddTranslation(GameCulture.Russian, "Висмутный элементаль");
			sacredTools.GetNPC("BlazingSerpentBody").DisplayName.AddTranslation(GameCulture.Russian, "Пылающий змий");
			sacredTools.GetNPC("BlazingSerpentHead").DisplayName.AddTranslation(GameCulture.Russian, "Пылающий змий");
			sacredTools.GetNPC("BlazingSerpentTail").DisplayName.AddTranslation(GameCulture.Russian, "Пылающий змий");
			sacredTools.GetNPC("BlazingShrub").DisplayName.AddTranslation(GameCulture.Russian, "Пылающий кустарник");
			sacredTools.GetNPC("DarkLancer").DisplayName.AddTranslation(GameCulture.Russian, "Тёмный копейщик");
			sacredTools.GetNPC("DespairObserver").DisplayName.AddTranslation(GameCulture.Russian, "Немой наблюдатель");
			sacredTools.GetNPC("FlareElemental").DisplayName.AddTranslation(GameCulture.Russian, "Пламенный дух");
			sacredTools.GetNPC("FlareShark").DisplayName.AddTranslation(GameCulture.Russian, "Драконический дробитель");
			sacredTools.GetNPC("FlareSharkWaterBecauseRedcodeSucks").DisplayName.AddTranslation(GameCulture.Russian, "Драконический дробитель");
			sacredTools.GetNPC("Flarian").DisplayName.AddTranslation(GameCulture.Russian, "Фурия");
			sacredTools.GetNPC("FollowerofAbaddon").DisplayName.AddTranslation(GameCulture.Russian, "Теневой последователь");
			sacredTools.GetNPC("FrigidJelly").DisplayName.AddTranslation(GameCulture.Russian, "Леденящая медуза");
			sacredTools.GetNPC("FrigidSlime").DisplayName.AddTranslation(GameCulture.Russian, "Леденящий слизень");
			sacredTools.GetNPC("FrigidSpirit").DisplayName.AddTranslation(GameCulture.Russian, "Леденящий дух");
			sacredTools.GetNPC("FuriousSlime").DisplayName.AddTranslation(GameCulture.Russian, "Свирепый слизень");
			sacredTools.GetNPC("NebulaSlime").DisplayName.AddTranslation(GameCulture.Russian, "Слизень туманности");
			sacredTools.GetNPC("NightmareWraith").DisplayName.AddTranslation(GameCulture.Russian, "Кошмарный дух");
			sacredTools.GetNPC("PhantomStalker").DisplayName.AddTranslation(GameCulture.Russian, "Призрачный преследователь");
			sacredTools.GetNPC("PrimordialThrall").DisplayName.AddTranslation(GameCulture.Russian, "Извечный раб");
			sacredTools.GetNPC("QuasarSlime").DisplayName.AddTranslation(GameCulture.Russian, "Квазарный слизень");
			sacredTools.GetNPC("SolarSlime").DisplayName.AddTranslation(GameCulture.Russian, "Солнечный слизень");
			sacredTools.GetNPC("StarcellSlime").DisplayName.AddTranslation(GameCulture.Russian, "Слизень звёздных клеток");
			sacredTools.GetNPC("StardustSlime").DisplayName.AddTranslation(GameCulture.Russian, "Слизень звёздной пыли");
			sacredTools.GetNPC("TestEnemy").DisplayName.AddTranslation(GameCulture.Russian, "Тестовый противник");
			sacredTools.GetNPC("VortexSlime").DisplayName.AddTranslation(GameCulture.Russian, "Вихревой слизень");
			sacredTools.GetNPC("WingedFuria").DisplayName.AddTranslation(GameCulture.Russian, "Крылатая фурия");
			sacredTools.GetNPC("BabySpider").DisplayName.AddTranslation(GameCulture.Russian, "Паучок");
			sacredTools.GetNPC("BabySpiderWall").DisplayName.AddTranslation(GameCulture.Russian, "Паучок");
			sacredTools.GetNPC("NestWarden").DisplayName.AddTranslation(GameCulture.Russian, "Смотритель гнезда");
			sacredTools.GetNPC("NestWardenWall").DisplayName.AddTranslation(GameCulture.Russian, "Смотритель гнезда");
			sacredTools.GetNPC("VenomStalker").DisplayName.AddTranslation(GameCulture.Russian, "Ядовитый преследователь");
			sacredTools.GetNPC("VenomStalkerWall").DisplayName.AddTranslation(GameCulture.Russian, "Ядовитый преследователь");
			sacredTools.GetNPC("AcidCauldron").DisplayName.AddTranslation(GameCulture.Russian, "Кислотный котёл");
			sacredTools.GetNPC("BaneOfDokuro").DisplayName.AddTranslation(GameCulture.Russian, "Золотой слизень");
			sacredTools.GetNPC("FestiveFuria").DisplayName.AddTranslation(GameCulture.Russian, "Праздничная фурия");
			sacredTools.GetNPC("ParadoxSlime").DisplayName.AddTranslation(GameCulture.Russian, "Парадоксальный слизень");
			sacredTools.GetNPC("SolSpirit").DisplayName.AddTranslation(GameCulture.Russian, "Солнечный дух");
			sacredTools.GetNPC("SolStriker").DisplayName.AddTranslation(GameCulture.Russian, "Солнечный борец");
			sacredTools.GetNPC("ErodedCorruptor").DisplayName.AddTranslation(GameCulture.Russian, "Разъеденный искажатель");
			sacredTools.GetNPC("ErodedFlamingSpirit").DisplayName.AddTranslation(GameCulture.Russian, "Разъеденный пламенный дух");
			sacredTools.GetNPC("ErodedHarpy").DisplayName.AddTranslation(GameCulture.Russian, "Разъеденная гарпия");
			sacredTools.GetNPC("ErodedIchorSticker").DisplayName.AddTranslation(GameCulture.Russian, "Разъеденный распылитель ихора");
			sacredTools.GetNPC("ErodedLamia").DisplayName.AddTranslation(GameCulture.Russian, "Разъеденная ламия");
			sacredTools.GetNPC("ErodedTunnelerBody").DisplayName.AddTranslation(GameCulture.Russian, "Разъеденный туннельщик");
			sacredTools.GetNPC("ErodedTunnelerHead").DisplayName.AddTranslation(GameCulture.Russian, "Разъеденный туннельщик");
			sacredTools.GetNPC("ErodedTunnelerTail").DisplayName.AddTranslation(GameCulture.Russian, "Разъеденный туннельщик");
			sacredTools.GetNPC("ErodedWingedFuria").DisplayName.AddTranslation(GameCulture.Russian, "Разъеденная крылатая фурия");
			sacredTools.GetNPC("Blaze").DisplayName.AddTranslation(GameCulture.Russian, "Всполох");
			sacredTools.GetNPC("NetherPortal").DisplayName.AddTranslation(GameCulture.Russian, "Портал нижнего мира");
			sacredTools.GetNPC("PigmanBanner").DisplayName.AddTranslation(GameCulture.Russian, "Знамя пиглинов");
			sacredTools.GetNPC("SkeleChicken").DisplayName.AddTranslation(GameCulture.Russian, "Куриный наездник");
			sacredTools.GetNPC("WitherSkeletonStart").DisplayName.AddTranslation(GameCulture.Russian, "Иссушенный носильщик");
			sacredTools.GetNPC("ZombiePigmanBrute").DisplayName.AddTranslation(GameCulture.Russian, "Жестокий зомби-пиглин");
			sacredTools.GetNPC("ZombiePigmanCrossbow").DisplayName.AddTranslation(GameCulture.Russian, "Жестокий зомби-арбалетчик");
			sacredTools.GetNPC("ZombiePigmanSword").DisplayName.AddTranslation(GameCulture.Russian, "Жестокий зомби");
			
			sacredTools.GetNPC("AntiBlackCoat").DisplayName.AddTranslation(GameCulture.Russian, "Anti Black Coat Nightmare (ТЕСТОВЫЙ)");
			sacredTools.GetNPC("Ashit").DisplayName.AddTranslation(GameCulture.Russian, "Bonus 33% More Halls Triple Soothing Action Soothes Sore Throats Relieves Coughs Cools Nasal Passages (ТЕСТОВЫЙ)");
			sacredTools.GetNPC("Gote").DisplayName.AddTranslation(GameCulture.Russian, "Gote of Hyperdeath (ТЕСТОВЫЙ)");
			sacredTools.GetNPC("NihilusHint").DisplayName.AddTranslation(GameCulture.Russian, "??? (ТЕСТОВЫЙ)");
			sacredTools.GetNPC("ShuraTest").DisplayName.AddTranslation(GameCulture.Russian, "Shura (ТЕСТОВЫЙ)");
			sacredTools.GetNPC("TestWormBody").DisplayName.AddTranslation(GameCulture.Russian, "Test Worm (ТЕСТОВЫЙ)");
			sacredTools.GetNPC("TestWormHead").DisplayName.AddTranslation(GameCulture.Russian, "Test Worm (ТЕСТОВЫЙ)");
			sacredTools.GetNPC("TestWormTail").DisplayName.AddTranslation(GameCulture.Russian, "Test Worm (ТЕСТОВЫЙ)");
		}
	}
}
