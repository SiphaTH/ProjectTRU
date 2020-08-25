using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityRuTranslate.CalamityMod.NPCs
{
	public class CalamityTownNpcName : GlobalNPC
	{
		public override void AI(NPC npc)
		{
			Mod calamity = ModLoader.GetMod("CalamityMod");
			if (calamity != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (npc.type == calamity.NPCType("Polterghast"))
				{
					if (npc.GivenName == "Necroghast")
					{
						npc.GivenName = "Некрогаст";
					}
					if (npc.GivenName == "Necroplasm")
					{
						npc.GivenName = "Некроплазм";
					}
				}

				if (npc.type == calamity.NPCType("DILF"))
				{
					npc.GivenName = "Пермафрост";
				}

				if (npc.type == calamity.NPCType("FAP"))
				{
					npc.GivenName = "Циррус";
				}

				if (npc.type == calamity.NPCType("SEAHOE"))
				{
					npc.GivenName = "Амидиас";
				}

				if (npc.type == calamity.NPCType("THIEF"))
				{
					if (npc.GivenName == "Laura")
					{
						npc.GivenName = "Лаура";
					}
					if (npc.GivenName == "Mie")
					{
						npc.GivenName = "Миэ";
					}
					if (npc.GivenName == "Bonnie")
					{
						npc.GivenName = "Бонни";
					}
					if (npc.GivenName == "Sarah")
					{
						npc.GivenName = "Сара";
					}
					if (npc.GivenName == "Diane")
					{
						npc.GivenName = "Диана";
					}
					if (npc.GivenName == "Kate")
					{
						npc.GivenName = "Кейт";
					}
					if (npc.GivenName == "Penelope")
					{
						npc.GivenName = "Пенелопа";
					}
					if (npc.GivenName == "Marisa")
					{
						npc.GivenName = "Мариса";
					}
					if (npc.GivenName == "Maribel")
					{
						npc.GivenName = "Марибель";
					}
					if (npc.GivenName == "Valerie")
					{
						npc.GivenName = "Валери";
					}
					if (npc.GivenName == "Jessica")
					{
						npc.GivenName = "Джессика";
					}
					if (npc.GivenName == "Rowan")
					{
						npc.GivenName = "Роуэн";
					}
					if (npc.GivenName == "Jessie")
					{
						npc.GivenName = "Джесси";
					}
					if (npc.GivenName == "Jade")
					{
						npc.GivenName = "Джейд";
					}
					if (npc.GivenName == "Hearn")
					{
						npc.GivenName = "Хин";
					}
					if (npc.GivenName == "Amber")
					{
						npc.GivenName = "Эмбер";
					}
					if (npc.GivenName == "Anne")
					{
						npc.GivenName = "Энн";
					}
					if (npc.GivenName == "Indiana")
					{
						npc.GivenName = "Индиана";
					}
					if (npc.GivenName == "Xplizzy")
					{
						npc.GivenName = "Иксплиззи";
					}
				}

				if (npc.type == NPCID.Guide)
				{
					if (npc.GivenName == "StreakistYT")
					{
						npc.GivenName = "СтрикистУАЙТИ";
					}
					if (npc.GivenName == "Neoplasmatic")
					{
						npc.GivenName = "Неоплазматик";
					}
					if (npc.GivenName == "Devin")
					{
						npc.GivenName = "Девин";
					}
					if (npc.GivenName == "Ben Shapiro")
					{
						npc.GivenName = "Бен Шапиро";
					}
					if (npc.GivenName == "Lapp")
					{
						npc.GivenName = "Лапп";
					}
					if (npc.GivenName == "Andrew")
					{
						npc.GivenName = "Эндрю";
					}
					if (npc.GivenName == "Asher")
					{
						npc.GivenName = "Ашер";
					}
					if (npc.GivenName == "Bradley")
					{
						npc.GivenName = "Брэдли";
					}
					if (npc.GivenName == "Brandon")
					{
						npc.GivenName = "Брэндон";
					}
					if (npc.GivenName == "Brian")
					{
						npc.GivenName = "Брайан";
					}
					if (npc.GivenName == "Brett")
					{
						npc.GivenName = "Бретт";
					}
					if (npc.GivenName == "Chris")
					{
						npc.GivenName = "Крис";
					}
					if (npc.GivenName == "Cody")
					{
						npc.GivenName = "Коди";
					}
					if (npc.GivenName == "Cole")
					{
						npc.GivenName = "Коул";
					}
					if (npc.GivenName == "Colin")
					{
						npc.GivenName = "Колин";
					}
					if (npc.GivenName == "Connor")
					{
						npc.GivenName = "Коннор";
					}
					if (npc.GivenName == "Daniel")
					{
						npc.GivenName = "Даниил";
					}
					if (npc.GivenName == "Dylan")
					{
						npc.GivenName = "Дилан";
					}
					if (npc.GivenName == "David")
					{
						npc.GivenName = "Дэвид";
					}
					if (npc.GivenName == "Fabian")
					{
						npc.GivenName = "Фабиан";
					}
					if (npc.GivenName == "Garrett")
					{
						npc.GivenName = "Гарретт";
					}
					if (npc.GivenName == "Harley")
					{
						npc.GivenName = "Харли";
					}
					if (npc.GivenName == "Jack")
					{
						npc.GivenName = "Джек";
					}
					if (npc.GivenName == "Jacob")
					{
						npc.GivenName = "Джейкоб";
					}
					if (npc.GivenName == "Jake")
					{
						npc.GivenName = "Джейк";
					}
					if (npc.GivenName == "Jeff")
					{
						npc.GivenName = "Джефф";
					}
					if (npc.GivenName == "Jeffrey")
					{
						npc.GivenName = "Джеффри";
					}
					if (npc.GivenName == "Joe")
					{
						npc.GivenName = "Джо";
					}
					if (npc.GivenName == "Joost")
					{
						npc.GivenName = "Джуст";
					}
					if (npc.GivenName == "Kevin")
					{
						npc.GivenName = "Кевин";
					}
					if (npc.GivenName == "Kyle")
					{
						npc.GivenName = "Кайл";
					}
					if (npc.GivenName == "Levi")
					{
						npc.GivenName = "Леви";
					}
					if (npc.GivenName == "Luke")
					{
						npc.GivenName = "Люк";
					}
					if (npc.GivenName == "Logan")
					{
						npc.GivenName = "Логан";
					}
					if (npc.GivenName == "Marty")
					{
						npc.GivenName = "Марти";
					}
					if (npc.GivenName == "Maxwell")
					{
						npc.GivenName = "Максвелл";
					}
					if (npc.GivenName == "Scott")
					{
						npc.GivenName = "Скот";
					}
					if (npc.GivenName == "Seth")
					{
						npc.GivenName = "Сет";
					}
					if (npc.GivenName == "Steve")
					{
						npc.GivenName = "Стив";
					}
					if (npc.GivenName == "Ryan")
					{
						npc.GivenName = "Райан";
					}
					if (npc.GivenName == "Tanner")
					{
						npc.GivenName = "Таннер";
					}
					if (npc.GivenName == "Trent")
					{
						npc.GivenName = "Трент";
					}
					if (npc.GivenName == "Wyatt")
					{
						npc.GivenName = "Уайт";
					}
					if (npc.GivenName == "Vlad")
					{
						npc.GivenName = "Влад";
					}
					if (npc.GivenName == "Zach")
					{
						npc.GivenName = "Зак";
					}
					if (npc.GivenName == "Rup")
					{
						npc.GivenName = "Руп";
					}
				}
				
				if (npc.type == NPCID.Merchant)
				{
					if (npc.GivenName == "Alfred")
					{
						npc.GivenName = "Альфред";
					}
					if (npc.GivenName == "Barney")
					{
						npc.GivenName = "Барни";
					}
					if (npc.GivenName == "Calvin")
					{
						npc.GivenName = "Кальвин";
					}
					if (npc.GivenName == "Edmund")
					{
						npc.GivenName = "Эдмунд";
					}
					if (npc.GivenName == "Edwin")
					{
						npc.GivenName = "Эдвин";
					}
					if (npc.GivenName == "Eugene")
					{
						npc.GivenName = "Юджин";
					}
					if (npc.GivenName == "Finn")
					{
						npc.GivenName = "Финн";
					}
					if (npc.GivenName == "Frank")
					{
						npc.GivenName = "Франк";
					}
					if (npc.GivenName == "Frederick")
					{
						npc.GivenName = "Фредерик";
					}
					if (npc.GivenName == "Gilbert")
					{
						npc.GivenName = "Гилберт";
					}
					if (npc.GivenName == "Gus")
					{
						npc.GivenName = "Гас";
					}
					if (npc.GivenName == "Harold")
					{
						npc.GivenName = "Гарольд";
					}
					if (npc.GivenName == "Howard")
					{
						npc.GivenName = "Говард";
					}
					if (npc.GivenName == "Humphrey")
					{
						npc.GivenName = "Хамфри";
					}
					if (npc.GivenName == "Isaac")
					{
						npc.GivenName = "Исаак";
					}
					if (npc.GivenName == "Joseph")
					{
						npc.GivenName = "Джозеф";
					}
					if (npc.GivenName == "Louis")
					{
						npc.GivenName = "Лойс";
					}
					if (npc.GivenName == "Milton")
					{
						npc.GivenName = "Милтон";
					}
					if (npc.GivenName == "Mortimer")
					{
						npc.GivenName = "Мортимер";
					}
					if (npc.GivenName == "Ralph")
					{
						npc.GivenName = "Ральф";
					}
					if (npc.GivenName == "Seymour")
					{
						npc.GivenName = "Сеймур";
					}
					if (npc.GivenName == "Walter")
					{
						npc.GivenName = "Волтер";
					}
					if (npc.GivenName == "Wilbur")
					{
						npc.GivenName = "Вилбур";
					}
				}

				if (npc.type == NPCID.Nurse)
				{
					if (npc.GivenName == "Farsni")
					{
						npc.GivenName = "Фарси";
					}
					if (npc.GivenName == "Abigail")
					{
						npc.GivenName = "Эбигейл";
					}
					if (npc.GivenName == "Allison")
					{
						npc.GivenName = "Элисон";
					}
					if (npc.GivenName == "Amy")
					{
						npc.GivenName = "Эмми";
					}
					if (npc.GivenName == "Caitlin")
					{
						npc.GivenName = "Кэйтлин";
					}
					if (npc.GivenName == "Carly")
					{
						npc.GivenName = "Карли";
					}
					if (npc.GivenName == "Claire")
					{
						npc.GivenName = "Клэр";
					}
					if (npc.GivenName == "Emily")
					{
						npc.GivenName = "Эмили";
					}
					if (npc.GivenName == "Emma")
					{
						npc.GivenName = "Эмма";
					}
					if (npc.GivenName == "Hannah")
					{
						npc.GivenName = "Ханна";
					}
					if (npc.GivenName == "Heather")
					{
						npc.GivenName = "Хезер";
					}
					if (npc.GivenName == "Helen")
					{
						npc.GivenName = "Хелен";
					}
					if (npc.GivenName == "Holly")
					{
						npc.GivenName = "Холли";
					}
					if (npc.GivenName == "Jenna")
					{
						npc.GivenName = "Дженна";
					}
					if (npc.GivenName == "Kaitlin")
					{
						npc.GivenName = "Кэтлин";
					}
					if (npc.GivenName == "Kaitlyn")
					{
						npc.GivenName = "Кейтлин";
					}
					if (npc.GivenName == "Katelyn")
					{
						npc.GivenName = "Кетелин";
					}
					if (npc.GivenName == "Katherine")
					{
						npc.GivenName = "Катерина";
					}
					if (npc.GivenName == "Kathryn")
					{
						npc.GivenName = "Катрин";
					}
					if (npc.GivenName == "Katie")
					{
						npc.GivenName = "Кэти";
					}
					if (npc.GivenName == "Kayla")
					{
						npc.GivenName = "Кэйл";
					}
					if (npc.GivenName == "Lisa")
					{
						npc.GivenName = "Лиза";
					}
					if (npc.GivenName == "Lorraine")
					{
						npc.GivenName = "Лорэйн";
					}
					if (npc.GivenName == "Madeline")
					{
						npc.GivenName = "Маделина";
					}
					if (npc.GivenName == "Molly")
					{
						npc.GivenName = "Молли";
					}
				}

				if (npc.type == NPCID.Demolitionist)
				{
					if (npc.GivenName == "Bazdin")
					{
						npc.GivenName = "Баздин";
					}
					if (npc.GivenName == "Beldin")
					{
						npc.GivenName = "Белдин";
					}
					if (npc.GivenName == "Boften")
					{
						npc.GivenName = "Бофтен";
					}
					if (npc.GivenName == "Darur")
					{
						npc.GivenName = "Дарур";
					}
					if (npc.GivenName == "Dias")
					{
						npc.GivenName = "Диас";
					}
					if (npc.GivenName == "Dolbere")
					{
						npc.GivenName = "Долбер";
					}
					if (npc.GivenName == "Dolgen")
					{
						npc.GivenName = "Долген";
					}
					if (npc.GivenName == "Dolgrim")
					{
						npc.GivenName = "Долгрим";
					}
					if (npc.GivenName == "Duerthen")
					{
						npc.GivenName = "Дьюртен";
					}
					if (npc.GivenName == "Durim")
					{
						npc.GivenName = "Дьюрим";
					}
					if (npc.GivenName == "Fikod")
					{
						npc.GivenName = "Фикод";
					}
					if (npc.GivenName == "Garval")
					{
						npc.GivenName = "Гарваль";
					}
					if (npc.GivenName == "Gimli")
					{
						npc.GivenName = "Гимли";
					}
					if (npc.GivenName == "Gimut")
					{
						npc.GivenName = "Гимут";
					}
					if (npc.GivenName == "Jarut")
					{
						npc.GivenName = "Ярут";
					}
					if (npc.GivenName == "Morthal")
					{
						npc.GivenName = "Мортал";
					}
					if (npc.GivenName == "Norkas")
					{
						npc.GivenName = "Норкас";
					}
					if (npc.GivenName == "Norsun")
					{
						npc.GivenName = "Норсан";
					}
					if (npc.GivenName == "Oten")
					{
						npc.GivenName = "Отен";
					}
					if (npc.GivenName == "Ovbere")
					{
						npc.GivenName = "Овбир";
					}
					if (npc.GivenName == "Tordak")
					{
						npc.GivenName = "Тордак";
					}
					if (npc.GivenName == "Urist")
					{
						npc.GivenName = "Арист";
					}
				}

				if (npc.type == NPCID.DyeTrader)
				{
					if (npc.GivenName == "Abdosir")
					{
						npc.GivenName = "Абдосир";
					}
					if (npc.GivenName == "Ahinadab")
					{
						npc.GivenName = "Ахинадаб";
					}
					if (npc.GivenName == "Ahirom")
					{
						npc.GivenName = "Ахиром";
					}
					if (npc.GivenName == "Akbar")
					{
						npc.GivenName = "Акбар";
					}
					if (npc.GivenName == "Batnoam")
					{
						npc.GivenName = "Батноам";
					}
					if (npc.GivenName == "Bodashtart")
					{
						npc.GivenName = "Бодаштарт";
					}
					if (npc.GivenName == "Danel")
					{
						npc.GivenName = "Данель";
					}
					if (npc.GivenName == "Hannibal")
					{
						npc.GivenName = "Ганнибал";
					}
					if (npc.GivenName == "Hanno")
					{
						npc.GivenName = "Ханно";
					}
					if (npc.GivenName == "Hiram")
					{
						npc.GivenName = "Хирам";
					}
					if (npc.GivenName == "Kanmi")
					{
						npc.GivenName = "Канми";
					}
					if (npc.GivenName == "Philosir")
					{
						npc.GivenName = "Филосир";
					}
					if (npc.GivenName == "Sikarbaal")
					{
						npc.GivenName = "Сикобаль";
					}
					if (npc.GivenName == "Tabnit")
					{
						npc.GivenName = "Табнит";
					}
					if (npc.GivenName == "Yehomilk")
					{
						npc.GivenName = "Йегомилк";
					}
					if (npc.GivenName == "Yutpan")
					{
						npc.GivenName = "Ютпан";
					}
				}

				if (npc.type == NPCID.Dryad)
				{
					if (npc.GivenName == "Alalia")
					{
						npc.GivenName = "Алалия";
					}
					if (npc.GivenName == "Alura")
					{
						npc.GivenName = "Алура";
					}
					if (npc.GivenName == "Ariella")
					{
						npc.GivenName = "Ариэлла";
					}
					if (npc.GivenName == "Caelia")
					{
						npc.GivenName = "Келия";
					}
					if (npc.GivenName == "Calista")
					{
						npc.GivenName = "Калиста";
					}
					if (npc.GivenName == "Celestia")
					{
						npc.GivenName = "Селестия";
					}
					if (npc.GivenName == "Chryseis")
					{
						npc.GivenName = "Крисейс";
					}
					if (npc.GivenName == "Elysia")
					{
						npc.GivenName = "Элисия";
					}
					if (npc.GivenName == "Emerenta")
					{
						npc.GivenName = "Эмерента";
					}
					if (npc.GivenName == "Evvie")
					{
						npc.GivenName = "Эвви";
					}
					if (npc.GivenName == "Faye")
					{
						npc.GivenName = "Фэй";
					}
					if (npc.GivenName == "Felicitae")
					{
						npc.GivenName = "Фелисити";
					}
					if (npc.GivenName == "Isis")
					{
						npc.GivenName = "Исида";
					}
					if (npc.GivenName == "Lunette")
					{
						npc.GivenName = "Лунетт";
					}
					if (npc.GivenName == "Nata")
					{
						npc.GivenName = "Ната";
					}
					if (npc.GivenName == "Nissa")
					{
						npc.GivenName = "Нисса";
					}
					if (npc.GivenName == "Rosalva")
					{
						npc.GivenName = "Розалва";
					}
					if (npc.GivenName == "Shea")
					{
						npc.GivenName = "Ши";
					}
					if (npc.GivenName == "Tania")
					{
						npc.GivenName = "Таня";
					}
					if (npc.GivenName == "Tatiana")
					{
						npc.GivenName = "Татьяна";
					}
					if (npc.GivenName == "Xylia")
					{
						npc.GivenName = "Ксилия";
					}
					if (npc.GivenName == "Rythmi")
					{
						npc.GivenName = "Ритми";
					}
					if (npc.GivenName == "Izuna")
					{
						npc.GivenName = "Изуна";
					}
				}

				if (npc.type == NPCID.DD2Bartender)
				{
					if (npc.GivenName == "Blacksmith")
					{
						npc.GivenName = "Кузнец";
					}
				}

				if (npc.type == NPCID.ArmsDealer)
				{
					if (npc.GivenName == "Drifter")
					{
						npc.GivenName = "Дрифтер";
					}
					if (npc.GivenName == "Drifter")
					{
						npc.GivenName = "Finchi";
					}
					if (npc.GivenName == "Финчи")
					{
						npc.GivenName = "Андре";
					}
					if (npc.GivenName == "Brimst")
					{
						npc.GivenName = "Бримст";
					}
					if (npc.GivenName == "Bronson")
					{
						npc.GivenName = "Бронсон";
					}
					if (npc.GivenName == "Dante")
					{
						npc.GivenName = "Данте";
					}
					if (npc.GivenName == "Darius")
					{
						npc.GivenName = "Дарий";
					}
					if (npc.GivenName == "Darnell")
					{
						npc.GivenName = "Дарнелл";
					}
					if (npc.GivenName == "Darryl")
					{
						npc.GivenName = "Дэррил";
					}
					if (npc.GivenName == "DeAndre")
					{
						npc.GivenName = "ДеАндре";
					}
					if (npc.GivenName == "Demetrius")
					{
						npc.GivenName = "Димитрий";
					}
					if (npc.GivenName == "DeShawn")
					{
						npc.GivenName = "ДеШон";
					}
					if (npc.GivenName == "Dominique")
					{
						npc.GivenName = "Доминик";
					}
					if (npc.GivenName == "Jalen")
					{
						npc.GivenName = "Джален";
					}
					if (npc.GivenName == "Jamal")
					{
						npc.GivenName = "Джамаль";
					}
					if (npc.GivenName == "Malik")
					{
						npc.GivenName = "Малик";
					}
					if (npc.GivenName == "Marquis")
					{
						npc.GivenName = "Маркиз";
					}
					if (npc.GivenName == "Maurice")
					{
						npc.GivenName = "Маврикий";
					}
					if (npc.GivenName == "Reginald")
					{
						npc.GivenName = "Реджинальд";
					}
					if (npc.GivenName == "Terrance")
					{
						npc.GivenName = "Терранс";
					}
					if (npc.GivenName == "Terrell")
					{
						npc.GivenName = "Террелл";
					}
					if (npc.GivenName == "Tony")
					{
						npc.GivenName = "Тони";
					}
					if (npc.GivenName == "Trevon")
					{
						npc.GivenName = "Тревон";
					}
					if (npc.GivenName == "Tyrone")
					{
						npc.GivenName = "Тайрон";
					}
					if (npc.GivenName == "Willie")
					{
						npc.GivenName = "Вилли";
					}
					if (npc.GivenName == "Xavier")
					{
						npc.GivenName = "Ксавье";
					}
				}

				if (npc.type == NPCID.Stylist)
				{
					if (npc.GivenName == "Amber")
					{
						npc.GivenName = "Эмбер";
					}
					if (npc.GivenName == "Annabel")
					{
						npc.GivenName = "Аннабель";
					}
					if (npc.GivenName == "Biah")
					{
						npc.GivenName = "Биа";
					}
					if (npc.GivenName == "Bri")
					{
						npc.GivenName = "Бри";
					}
					if (npc.GivenName == "Brianne")
					{
						npc.GivenName = "Брианна";
					}
					if (npc.GivenName == "Esmeralda")
					{
						npc.GivenName = "Эсмеральда";
					}
					if (npc.GivenName == "Flora")
					{
						npc.GivenName = "Флора";
					}
					if (npc.GivenName == "Hazel")
					{
						npc.GivenName = "Хейзел";
					}
					if (npc.GivenName == "Iris")
					{
						npc.GivenName = "Ирида";
					}
					if (npc.GivenName == "Kati")
					{
						npc.GivenName = "Кати";
					}
					if (npc.GivenName == "Kylie")
					{
						npc.GivenName = "Кайли";
					}
					if (npc.GivenName == "Lola")
					{
						npc.GivenName = "Лола";
					}
					if (npc.GivenName == "Meliyah")
					{
						npc.GivenName = "Мелийя";
					}
					if (npc.GivenName == "Pearl")
					{
						npc.GivenName = "Перл";
					}
					if (npc.GivenName == "Petra")
					{
						npc.GivenName = "Петра";
					}
					if (npc.GivenName == "Rox")
					{
						npc.GivenName = "Рокс";
					}
					if (npc.GivenName == "Roxanne")
					{
						npc.GivenName = "Роксана";
					}
					if (npc.GivenName == "Ruby")
					{
						npc.GivenName = "Руби";
					}
					if (npc.GivenName == "Scarlett")
					{
						npc.GivenName = "Скарлетт";
					}
					if (npc.GivenName == "Stella")
					{
						npc.GivenName = "Стелла";
					}
					if (npc.GivenName == "Tallulah")
					{
						npc.GivenName = "Таллула";
					}
				}

				if (npc.type == NPCID.Painter)
				{
					if (npc.GivenName == "Bruno")
					{
						npc.GivenName = "Бруно";
					}
					if (npc.GivenName == "Carlo")
					{
						npc.GivenName = "Карло";
					}
					if (npc.GivenName == "Darren")
					{
						npc.GivenName = "Даррен";
					}
					if (npc.GivenName == "Enzo")
					{
						npc.GivenName = "Энзо";
					}
					if (npc.GivenName == "Esreadel")
					{
						npc.GivenName = "Эреадель";
					}
					if (npc.GivenName == "Guido")
					{
						npc.GivenName = "Гвидо";
					}
					if (npc.GivenName == "Leonardo")
					{
						npc.GivenName = "Леонардо";
					}
					if (npc.GivenName == "Lorenzo")
					{
						npc.GivenName = "Лоренцо";
					}
					if (npc.GivenName == "Luca")
					{
						npc.GivenName = "Лука";
					}
					if (npc.GivenName == "Luciano")
					{
						npc.GivenName = "Лучано";
					}
					if (npc.GivenName == "Ludo")
					{
						npc.GivenName = "Людо";
					}
					if (npc.GivenName == "Luigi")
					{
						npc.GivenName = "Луиджи";
					}
					if (npc.GivenName == "Marco")
					{
						npc.GivenName = "Марко";
					}
					if (npc.GivenName == "Mario")
					{
						npc.GivenName = "Марио";
					}
					if (npc.GivenName == "Martino")
					{
						npc.GivenName = "Мартино";
					}
					if (npc.GivenName == "Mauro")
					{
						npc.GivenName = "Мауро";
					}
					if (npc.GivenName == "Raphael")
					{
						npc.GivenName = "Рафаил";
					}
					if (npc.GivenName == "Stefano")
					{
						npc.GivenName = "Стефано";
					}
				}

				if (npc.type == NPCID.Angler)
				{
					if (npc.GivenName == "Adam")
					{
						npc.GivenName = "Адам";
					}
					if (npc.GivenName == "Bart")
					{
						npc.GivenName = "Барт";
					}
					if (npc.GivenName == "Billy")
					{
						npc.GivenName = "Билли";
					}
					if (npc.GivenName == "Bobby")
					{
						npc.GivenName = "Бобби";
					}
					if (npc.GivenName == "Bryce")
					{
						npc.GivenName = "Брайс";
					}
					if (npc.GivenName == "Charles")
					{
						npc.GivenName = "Чарльз";
					}
					if (npc.GivenName == "Danny")
					{
						npc.GivenName = "Дэнни";
					}
					if (npc.GivenName == "Grayson")
					{
						npc.GivenName = "Грейсон";
					}
					if (npc.GivenName == "Ivan")
					{
						npc.GivenName = "Иван";
					}
					if (npc.GivenName == "Izzy")
					{
						npc.GivenName = "Иззи";
					}
					if (npc.GivenName == "Jey")
					{
						npc.GivenName = "Джей";
					}
					if (npc.GivenName == "Jimmy")
					{
						npc.GivenName = "Джимми";
					}
					if (npc.GivenName == "Johnny")
					{
						npc.GivenName = "Джонни";
					}
					if (npc.GivenName == "Matty")
					{
						npc.GivenName = "Мэтти";
					}
					if (npc.GivenName == "Miles")
					{
						npc.GivenName = "Майлз";
					}
					if (npc.GivenName == "Nathan")
					{
						npc.GivenName = "Натан";
					}
					if (npc.GivenName == "Phillip")
					{
						npc.GivenName = "Филлип";
					}
					if (npc.GivenName == "Sammy")
					{
						npc.GivenName = "Сэмми";
					}
					if (npc.GivenName == "Simon")
					{
						npc.GivenName = "Саймон";
					}
					if (npc.GivenName == "Spencer")
					{
						npc.GivenName = "Спенсер";
					}
					if (npc.GivenName == "Timmy")
					{
						npc.GivenName = "Тимми";
					}
					if (npc.GivenName == "Tyler")
					{
						npc.GivenName = "Тайлер";
					}
					if (npc.GivenName == "Dazren")
					{
						npc.GivenName = "Дазрен";
					}
				}

				if (npc.type == NPCID.GoblinTinkerer)
				{
					if (npc.GivenName == "Arback")
					{
						npc.GivenName = "Арбек";
					}
					if (npc.GivenName == "Dalek")
					{
						npc.GivenName = "Далек";
					}
					if (npc.GivenName == "Darz")
					{
						npc.GivenName = "Дарз";
					}
					if (npc.GivenName == "Durnok")
					{
						npc.GivenName = "Дурнок";
					}
					if (npc.GivenName == "Fahd")
					{
						npc.GivenName = "Фахд";
					}
					if (npc.GivenName == "Fjell")
					{
						npc.GivenName = "Фьелл";
					}
					if (npc.GivenName == "Gnudar")
					{
						npc.GivenName = "Гнудар";
					}
					if (npc.GivenName == "Grodax")
					{
						npc.GivenName = "Гродак";
					}
					if (npc.GivenName == "Knogs")
					{
						npc.GivenName = "Кногз";
					}
					if (npc.GivenName == "Knub")
					{
						npc.GivenName = "Кнуб";
					}
					if (npc.GivenName == "Mobart")
					{
						npc.GivenName = "Мобарт";
					}
					if (npc.GivenName == "Mrunok")
					{
						npc.GivenName = "Мрунок";
					}
					if (npc.GivenName == "Negurk")
					{
						npc.GivenName = "Негурк";
					}
					if (npc.GivenName == "Nort")
					{
						npc.GivenName = "Норт";
					}
					if (npc.GivenName == "Nuxatk")
					{
						npc.GivenName = "Нуксатк";
					}
					if (npc.GivenName == "Ragz")
					{
						npc.GivenName = "Рагз";
					}
					if (npc.GivenName == "Sarx")
					{
						npc.GivenName = "Саркс";
					}
					if (npc.GivenName == "Smador")
					{
						npc.GivenName = "Смадор";
					}
					if (npc.GivenName == "Stazen")
					{
						npc.GivenName = "Стазен";
					}
					if (npc.GivenName == "Stezom")
					{
						npc.GivenName = "Стезом";
					}
					if (npc.GivenName == "Tgerd")
					{
						npc.GivenName = "Тгерд";
					}
					if (npc.GivenName == "Tkanus")
					{
						npc.GivenName = "Тканус";
					}
					if (npc.GivenName == "Trogem")
					{
						npc.GivenName = "Трогем";
					}
					if (npc.GivenName == "Xanos")
					{
						npc.GivenName = "Ханос";
					}
					if (npc.GivenName == "Xon")
					{
						npc.GivenName = "Кон";
					}
				}

				if (npc.type == NPCID.WitchDoctor)
				{
					if (npc.GivenName == "Abibe")
					{
						npc.GivenName = "Абибе";
					}
					if (npc.GivenName == "Gboto")
					{
						npc.GivenName = "Гбото";
					}
					if (npc.GivenName == "Jamundi")
					{
						npc.GivenName = "Джамунди";
					}
					if (npc.GivenName == "Kogi-ghi")
					{
						npc.GivenName = "Коги-хи";
					}
					if (npc.GivenName == "Konah")
					{
						npc.GivenName = "Кона";
					}
					if (npc.GivenName == "Opuni")
					{
						npc.GivenName = "Окуни";
					}
					if (npc.GivenName == "Tairona")
					{
						npc.GivenName = "Тайрона";
					}
					if (npc.GivenName == "Sok'ar")
					{
						npc.GivenName = "Сокар";
					}
					if (npc.GivenName == "U'wa")
					{
						npc.GivenName = "У'ва";
					}
					if (npc.GivenName == "Xirigua")
					{
						npc.GivenName = "Сиригуа";
					}
					if (npc.GivenName == "Zop'a")
					{
						npc.GivenName = "Зоп'а";
					}
				}

				if (npc.type == NPCID.Clothier)
				{
					if (npc.GivenName == "Joeseph Jostar")
					{
						npc.GivenName = "Джозеф Джостар";
					}
					if (npc.GivenName == "Alfred")
					{
						npc.GivenName = "Альфред";
					}
					if (npc.GivenName == "Arthur")
					{
						npc.GivenName = "Артур";
					}
					if (npc.GivenName == "Benjamin")
					{
						npc.GivenName = "Бенджамин";
					}
					if (npc.GivenName == "Cedric")
					{
						npc.GivenName = "Седрик";
					}
					if (npc.GivenName == "Clive")
					{
						npc.GivenName = "Клайв";
					}
					if (npc.GivenName == "Cyril")
					{
						npc.GivenName = "Сирил";
					}
					if (npc.GivenName == "Edgar")
					{
						npc.GivenName = "Эдгар";
					}
					if (npc.GivenName == "Edmund")
					{
						npc.GivenName = "Эдмунд";
					}
					if (npc.GivenName == "Edward")
					{
						npc.GivenName = "Эдуард";
					}
					if (npc.GivenName == "Eustace")
					{
						npc.GivenName = "Юстас";
					}
					if (npc.GivenName == "Fitz")
					{
						npc.GivenName = "Фитц";
					}
					if (npc.GivenName == "Graham")
					{
						npc.GivenName = "Грэм";
					}
					if (npc.GivenName == "Henry")
					{
						npc.GivenName = "Генри";
					}
					if (npc.GivenName == "Herald")
					{
						npc.GivenName = "Геральд";
					}
					if (npc.GivenName == "James")
					{
						npc.GivenName = "Джеймс";
					}
					if (npc.GivenName == "Lincoln")
					{
						npc.GivenName = "Линкольн";
					}
					if (npc.GivenName == "Lloyd")
					{
						npc.GivenName = "Ллойд";
					}
					if (npc.GivenName == "Mervyn")
					{
						npc.GivenName = "Мервин";
					}
					if (npc.GivenName == "Nigel")
					{
						npc.GivenName = "Найджел";
					}
					if (npc.GivenName == "Pip")
					{
						npc.GivenName = "Пип";
					}
					if (npc.GivenName == "Rodney")
					{
						npc.GivenName = "Родни";
					}
					if (npc.GivenName == "Rodrick")
					{
						npc.GivenName = "Родрик";
					}
					if (npc.GivenName == "Roland")
					{
						npc.GivenName = "Роланд";
					}
					if (npc.GivenName == "Rupert")
					{
						npc.GivenName = "Руперт";
					}
					if (npc.GivenName == "Sebastian")
					{
						npc.GivenName = "Себастьян";
					}
				}

				if (npc.type == NPCID.Mechanic)
				{
					if (npc.GivenName == "Amy")
					{
						npc.GivenName = "Эми";
					}
					if (npc.GivenName == "Autumn")
					{
						npc.GivenName = "Отум";
					}
					if (npc.GivenName == "Brooke")
					{
						npc.GivenName = "Брук";
					}
					if (npc.GivenName == "Dawn")
					{
						npc.GivenName = "Дан";
					}
					if (npc.GivenName == "Ella")
					{
						npc.GivenName = "Элла";
					}
					if (npc.GivenName == "Ellen")
					{
						npc.GivenName = "Эллен";
					}
					if (npc.GivenName == "Ginger")
					{
						npc.GivenName = "Джинджер";
					}
					if (npc.GivenName == "Jenny")
					{
						npc.GivenName = "Дженни";
					}
					if (npc.GivenName == "Kayla")
					{
						npc.GivenName = "Кайла";
					}
					if (npc.GivenName == "Korrie")
					{
						npc.GivenName = "Корри";
					}
					if (npc.GivenName == "Lauren")
					{
						npc.GivenName = "Лорен";
					}
					if (npc.GivenName == "Marshanna")
					{
						npc.GivenName = "Маршанна";
					}
					if (npc.GivenName == "Meredith")
					{
						npc.GivenName = "Мередит";
					}
					if (npc.GivenName == "Nancy")
					{
						npc.GivenName = "Нэнси";
					}
					if (npc.GivenName == "Sally")
					{
						npc.GivenName = "Салли";
					}
					if (npc.GivenName == "Selah")
					{
						npc.GivenName = "Селах";
					}
					if (npc.GivenName == "Selene")
					{
						npc.GivenName = "Селена";
					}
					if (npc.GivenName == "Shayna")
					{
						npc.GivenName = "Шайна";
					}
					if (npc.GivenName == "Sheena")
					{
						npc.GivenName = "Шина";
					}
					if (npc.GivenName == "Shirlena")
					{
						npc.GivenName = "Ширена";
					}
					if (npc.GivenName == "Sophia")
					{
						npc.GivenName = "София";
					}
					if (npc.GivenName == "Susana")
					{
						npc.GivenName = "Сюзана";
					}
					if (npc.GivenName == "Terra")
					{
						npc.GivenName = "Терра";
					}
					if (npc.GivenName == "Trisha")
					{
						npc.GivenName = "Триша";
					}
				}

				if (npc.type == NPCID.PartyGirl)
				{
					if (npc.GivenName == "Bailey")
					{
						npc.GivenName = "Бейли";
					}
					if (npc.GivenName == "Bambi")
					{
						npc.GivenName = "Бамби";
					}
					if (npc.GivenName == "Bunny")
					{
						npc.GivenName = "Банни";
					}
					if (npc.GivenName == "Candy")
					{
						npc.GivenName = "Кэнди";
					}
					if (npc.GivenName == "Cherry")
					{
						npc.GivenName = "Чери";
					}
					if (npc.GivenName == "Dazzle")
					{
						npc.GivenName = "Дазл";
					}
					if (npc.GivenName == "Destiny")
					{
						npc.GivenName = "Дэстини";
					}
					if (npc.GivenName == "Fantasia")
					{
						npc.GivenName = "Фантазия";
					}
					if (npc.GivenName == "Fantasy")
					{
						npc.GivenName = "Фантази";
					}
					if (npc.GivenName == "Glitter")
					{
						npc.GivenName = "Глиттер";
					}
					if (npc.GivenName == "Isis")
					{
						npc.GivenName = "Исида";
					}
					if (npc.GivenName == "Lexus")
					{
						npc.GivenName = "Лексус";
					}
					if (npc.GivenName == "Paris")
					{
						npc.GivenName = "Парис";
					}
					if (npc.GivenName == "Sparkle")
					{
						npc.GivenName = "Спаркл";
					}
					if (npc.GivenName == "Star")
					{
						npc.GivenName = "Стар";
					}
					if (npc.GivenName == "Sugar")
					{
						npc.GivenName = "Шугар";
					}
					if (npc.GivenName == "Trixy")
					{
						npc.GivenName = "Трикси";
					}
				}
				if (npc.type == NPCID.Wizard)
				{
					if (npc.GivenName == "Abram")
					{
						npc.GivenName = "Авраам";
					}
					if (npc.GivenName == "Alasdair")
					{
						npc.GivenName = "Аласдэйр";
					}
					if (npc.GivenName == "Arddun")
					{
						npc.GivenName = "Арддун";
					}
					if (npc.GivenName == "Arwyn")
					{
						npc.GivenName = "Арвин";
					}
					if (npc.GivenName == "Berwyn")
					{
						npc.GivenName = "Бервин";
					}
					if (npc.GivenName == "Dalamar")
					{
						npc.GivenName = "Даламар";
					}
					if (npc.GivenName == "Dulais")
					{
						npc.GivenName = "Далез";
					}
					if (npc.GivenName == "Elric")
					{
						npc.GivenName = "Элрик";
					}
					if (npc.GivenName == "Fizban")
					{
						npc.GivenName = "Физбан";
					}
					if (npc.GivenName == "Gearroid")
					{
						npc.GivenName = "Гирроид";
					}
					if (npc.GivenName == "Greum")
					{
						npc.GivenName = "Греум";
					}
					if (npc.GivenName == "Gwentor")
					{
						npc.GivenName = "Гвентор";
					}
					if (npc.GivenName == "Hirael")
					{
						npc.GivenName = "Хираэль";
					}
					if (npc.GivenName == "Leomund")
					{
						npc.GivenName = "Леомунд";
					}
					if (npc.GivenName == "Maelor")
					{
						npc.GivenName = "Мэлор";
					}
					if (npc.GivenName == "Magius")
					{
						npc.GivenName = "Магиус";
					}
					if (npc.GivenName == "Merlyn")
					{
						npc.GivenName = "Мерлин";
					}
					if (npc.GivenName == "Ningauble")
					{
						npc.GivenName = "Нижаубле";
					}
					if (npc.GivenName == "Sargon")
					{
						npc.GivenName = "Саргон";
					}
					if (npc.GivenName == "Seonag")
					{
						npc.GivenName = "Сонаг";
					}
					if (npc.GivenName == "Tagar")
					{
						npc.GivenName = "Тагар";
					}
					if (npc.GivenName == "Xanadu")
					{
						npc.GivenName = "Шанаду";
					}
					if (npc.GivenName == "Mage One-Trick")
					{
						npc.GivenName = "Маг Один-трюк";
					}
					if (npc.GivenName == "Inorim, son of Ivukey")
					{
						npc.GivenName = "Инорим, сын Ивуки";
					}
					if (npc.GivenName == "Jensen")
					{
						npc.GivenName = "Дженсен";
					}
				}

				if (npc.type == NPCID.TaxCollector)
				{
					if (npc.GivenName == "McKinley")
					{
						npc.GivenName = "МакКинли";
					}
					if (npc.GivenName == "Millard")
					{
						npc.GivenName = "Миллард";
					}
					if (npc.GivenName == "Fillmore")
					{
						npc.GivenName = "Филлмор";
					}
					if (npc.GivenName == "Rutherford")
					{
						npc.GivenName = "Резерфорд";
					}
					if (npc.GivenName == "Chester")
					{
						npc.GivenName = "Честер";
					}
					if (npc.GivenName == "Grover")
					{
						npc.GivenName = "Гровер";
					}
					if (npc.GivenName == "Cleveland")
					{
						npc.GivenName = "Кливленд";
					}
					if (npc.GivenName == "Theodore")
					{
						npc.GivenName = "Теодор";
					}
					if (npc.GivenName == "Herbert")
					{
						npc.GivenName = "Герберт";
					}
					if (npc.GivenName == "Warren")
					{
						npc.GivenName = "Уоррен";
					}
					if (npc.GivenName == "Emmett")
					{
						npc.GivenName = "Эммет";
					}
					if (npc.GivenName == "McKinly")
					{
						npc.GivenName = "МакКинли";
					}
					if (npc.GivenName == "Lyndon")
					{
						npc.GivenName = "Линдон";
					}
					if (npc.GivenName == "Ronald")
					{
						npc.GivenName = "Рональд";
					}
					if (npc.GivenName == "Harrison")
					{
						npc.GivenName = "Харрисон";
					}
					if (npc.GivenName == "Woodrow")
					{
						npc.GivenName = "Вудро";
					}
					if (npc.GivenName == "Tweed")
					{
						npc.GivenName = "Твид";
					}
					if (npc.GivenName == "Blanton")
					{
						npc.GivenName = "Блантон";
					}
					if (npc.GivenName == "Dwyer")
					{
						npc.GivenName = "Дуайер";
					}
					if (npc.GivenName == "Carroll")
					{
						npc.GivenName = "Кэрролл";
					}
					if (npc.GivenName == "Agnew")
					{
						npc.GivenName = "Агнью";
					}
				}

				if (npc.type == NPCID.Truffle)
				{
					if (npc.GivenName == "Agaric")
					{
						npc.GivenName = "Агарик";
					}
					if (npc.GivenName == "Amanita")
					{
						npc.GivenName = "Аманита";
					}
					if (npc.GivenName == "Chanterelle")
					{
						npc.GivenName = "Лисичка";
					}
					if (npc.GivenName == "Cremini")
					{
						npc.GivenName = "Крмини";
					}
					if (npc.GivenName == "Enoki")
					{
						npc.GivenName = "Эноки";
					}
					if (npc.GivenName == "Maitake")
					{
						npc.GivenName = "Майтаке";
					}
					if (npc.GivenName == "Morel")
					{
						npc.GivenName = "Морель";
					}
					if (npc.GivenName == "Muscaria")
					{
						npc.GivenName = "Мускария";
					}
					if (npc.GivenName == "Porcini")
					{
						npc.GivenName = "Порчини";
					}
					if (npc.GivenName == "Reishi")
					{
						npc.GivenName = "Рейши";
					}
					if (npc.GivenName == "Shiitake")
					{
						npc.GivenName = "Шиитаке";
					}
					if (npc.GivenName == "Shimeji")
					{
						npc.GivenName = "Шимедзи";
					}
				}

				if (npc.type == NPCID.Pirate)
				{
					if (npc.GivenName == "Black Beard")
					{
						npc.GivenName = "Черная Борода";
					}
					if (npc.GivenName == "Captain Bullywort")
					{
						npc.GivenName = "Капитан Булливорт";
					}
					if (npc.GivenName == "Captain Morgan")
					{
						npc.GivenName = "Капитан Морган";
					}
					if (npc.GivenName == "Captain Stoney Dirt")
					{
						npc.GivenName = "Капитан Каменная грязь";
					}
					if (npc.GivenName == "David")
					{
						npc.GivenName = "Дэвид";
					}
					if (npc.GivenName == "Gunpowder Garry")
					{
						npc.GivenName = "Порох Гарри";
					}
					if (npc.GivenName == "Jack")
					{
						npc.GivenName = "Джек";
					}
					if (npc.GivenName == "Jake")
					{
						npc.GivenName = "Джейк";
					}
					if (npc.GivenName == "James T. Beard")
					{
						npc.GivenName = "Джеймс Т. Боард";
					}
					if (npc.GivenName == "Red Beard")
					{
						npc.GivenName = "Красная Борода";
					}
					if (npc.GivenName == "Wet Beard")
					{
						npc.GivenName = "Влажная Борода";
					}
					if (npc.GivenName == "Tyler Van Hook")
					{
						npc.GivenName = "Тайлер Ван Хук";
					}
				}

				if (npc.type == NPCID.Steampunker)
				{
					if (npc.GivenName == "Angel")
					{
						npc.GivenName = "Ангел";
					}
					if (npc.GivenName == "Vorbis")
					{
						npc.GivenName = "Ворбис";
					}
					if (npc.GivenName == "Ada")
					{
						npc.GivenName = "Ада";
					}
					if (npc.GivenName == "Cornelia")
					{
						npc.GivenName = "Корнелия";
					}
					if (npc.GivenName == "Cynthia")
					{
						npc.GivenName = "Синтия";
					}
					if (npc.GivenName == "Emeline")
					{
						npc.GivenName = "Эмелин";
					}
					if (npc.GivenName == "Fidelia")
					{
						npc.GivenName = "Фиделия";
					}
					if (npc.GivenName == "Hope")
					{
						npc.GivenName = "Хоуп";
					}
					if (npc.GivenName == "Isabella")
					{
						npc.GivenName = "Изабелла";
					}
					if (npc.GivenName == "Judith")
					{
						npc.GivenName = "Джудит";
					}
					if (npc.GivenName == "Leila")
					{
						npc.GivenName = "Лейла";
					}
					if (npc.GivenName == "Lilly")
					{
						npc.GivenName = "Лили";
					}
					if (npc.GivenName == "Lydia")
					{
						npc.GivenName = "Лидия";
					}
					if (npc.GivenName == "Minerva")
					{
						npc.GivenName = "Минерва";
					}
					if (npc.GivenName == "Phoebe")
					{
						npc.GivenName = "Фиби";
					}
					if (npc.GivenName == "Savannah")
					{
						npc.GivenName = "Саванна";
					}
					if (npc.GivenName == "Selina")
					{
						npc.GivenName = "Селина";
					}
					if (npc.GivenName == "Verity")
					{
						npc.GivenName = "Верити";
					}
					if (npc.GivenName == "Vivian")
					{
						npc.GivenName = "Вивиан";
					}
					if (npc.GivenName == "Whitney")
					{
						npc.GivenName = "Уитни";
					}
					if (npc.GivenName == "Zelda")
					{
						npc.GivenName = "Зельда";
					}
					if (npc.GivenName == "Zylphia")
					{
						npc.GivenName = "Зилфия";
					}
				}

				if (npc.type == NPCID.Cyborg)
				{
					if (npc.GivenName == "Alpha")
					{
						npc.GivenName = "Альфа";
					}
					if (npc.GivenName == "Beta")
					{
						npc.GivenName = "Бета";
					}
					if (npc.GivenName == "Gamma")
					{
						npc.GivenName = "Гамма";
					}
					if (npc.GivenName == "Delta")
					{
						npc.GivenName = "Дельта";
					}
					if (npc.GivenName == "Zeta")
					{
						npc.GivenName = "Дзета";
					}
					if (npc.GivenName == "Theta")
					{
						npc.GivenName = "Ита";
					}
					if (npc.GivenName == "Kappa")
					{
						npc.GivenName = "Каппа";
					}
					if (npc.GivenName == "Lambda")
					{
						npc.GivenName = "Лямбда";
					}
					if (npc.GivenName == "Mu")
					{
						npc.GivenName = "Мю";
					}
					if (npc.GivenName == "Nu")
					{
						npc.GivenName = "Ню";
					}
					if (npc.GivenName == "Omicron")
					{
						npc.GivenName = "Омикрон";
					}
					if (npc.GivenName == "Rho")
					{
						npc.GivenName = "Ро";
					}
					if (npc.GivenName == "Sigma")
					{
						npc.GivenName = "Сигма";
					}
					if (npc.GivenName == "Upsilon")
					{
						npc.GivenName = "Ипсилон";
					}
					if (npc.GivenName == "Phi")
					{
						npc.GivenName = "Фи";
					}
					if (npc.GivenName == "Ci")
					{
						npc.GivenName = "Си";
					}
					if (npc.GivenName == "Omega")
					{
						npc.GivenName = "Омега";
					}
					if (npc.GivenName == "Fender")
					{
						npc.GivenName = "Фендер";
					}
					if (npc.GivenName == "T-3E0")
					{
						npc.GivenName = "Т-3Е0";
					}
					if (npc.GivenName == "Niner-7")
					{
						npc.GivenName = "Номер-7";
					}
					if (npc.GivenName == "A.N.D.Y")
					{
						npc.GivenName = "А.Н.Д.И.";
					}
					if (npc.GivenName == "Syn-X")
					{
						npc.GivenName = "Син-Х";
					}
				}

				if (npc.type == NPCID.TravellingMerchant)
				{
					if (npc.GivenName == "Abraham")
					{
						npc.GivenName = "Абрахам";
					}
					if (npc.GivenName == "Aedan")
					{
						npc.GivenName = "Эйдан";
					}
					if (npc.GivenName == "Aphraim")
					{
						npc.GivenName = "Афраим";
					}
					if (npc.GivenName == "Bohemas")
					{
						npc.GivenName = "Богемас";
					}
					if (npc.GivenName == "Eladon")
					{
						npc.GivenName = "Эладон";
					}
					if (npc.GivenName == "Gallius")
					{
						npc.GivenName = "Галлиус";
					}
					if (npc.GivenName == "Llewellyn")
					{
						npc.GivenName = "Лэвллин";
					}
					if (npc.GivenName == "Mercer")
					{
						npc.GivenName = "Мерсер";
					}
					if (npc.GivenName == "Rawleigh")
					{
						npc.GivenName = "Роулейгх";
					}
					if (npc.GivenName == "Riley")
					{
						npc.GivenName = "Райли";
					}
					if (npc.GivenName == "Romeo")
					{
						npc.GivenName = "Ромео";
					}
					if (npc.GivenName == "Shipton")
					{
						npc.GivenName = "Шиптон";
					}
					if (npc.GivenName == "Willy")
					{
						npc.GivenName = "Вилли";
					}
				}
				
				if (npc.type == NPCID.SkeletonMerchant)
				{
					if (npc.GivenName == "Billy Marrows")
					{
						npc.GivenName = "Билли Мэрроус";
					}
					if (npc.GivenName == "Bones McGee")
					{
						npc.GivenName = "Кости МакГи";
					}
					if (npc.GivenName == "Gloomy Mays")
					{
						npc.GivenName = "Глуми Мэйс";
					}
					if (npc.GivenName == "Jack Sellington")
					{
						npc.GivenName = "Джек Селлингтон";
					}
					if (npc.GivenName == "Mandible Calavera")
					{
						npc.GivenName = "Мэндибл Кэлавера";
					}
					if (npc.GivenName == "Mika")
					{
						npc.GivenName = "Мики";
					}
					if (npc.GivenName == "No-Eyed Wiley")
					{
						npc.GivenName = "Безглазый Вилли";
					}
					if (npc.GivenName == "Rattles Magoo")
					{
						npc.GivenName = "Рэттлс Магу";
					}
					if (npc.GivenName == "Skellington")
					{
						npc.GivenName = "Скеллингтон";
					}
					if (npc.GivenName == "Tom")
					{
						npc.GivenName = "Том";
					}
				}
			}
		}
	}
}
