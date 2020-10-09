using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ThoriumMod.NPCs
{
	public class ThoriumTownNpcName : GlobalNPC
	{
		public override void AI(NPC npc)
		{
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			
			if (thorium != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (CalamityRuTranslate.TRuConfig.ThoriumTranslation)
				{
					if (npc.type == thorium.NPCType("Blacksmith"))
					{
						if (npc.GivenName == "Gregory")
						{
							npc.GivenName = "Грегор";
						}

						if (npc.GivenName == "Paul")
						{
							npc.GivenName = "Пол";
						}

						if (npc.GivenName == "Kilbas")
						{
							npc.GivenName = "Килбас";
						}

						if (npc.GivenName == "Hagan")
						{
							npc.GivenName = "Хоган";
						}

						if (npc.GivenName == "Hedrick")
						{
							npc.GivenName = "Генри";
						}

						if (npc.GivenName == "Vicktor")
						{
							npc.GivenName = "Виктор";
						}

						if (npc.GivenName == "Wayland")
						{
							npc.GivenName = "Вэйленд";
						}

						if (npc.GivenName == "George")
						{
							npc.GivenName = "Георг";
						}
					}

					if (npc.type == thorium.NPCType("Cobbler"))
					{
						if (npc.GivenName == "Alfred")
						{
							npc.GivenName = "Альфред";
						}

						if (npc.GivenName == "Desmond")
						{
							npc.GivenName = "Дезмонд";
						}

						if (npc.GivenName == "Barney")
						{
							npc.GivenName = "Барни";
						}

						if (npc.GivenName == "Fred")
						{
							npc.GivenName = "Фред";
						}

						if (npc.GivenName == "Louis")
						{
							npc.GivenName = "Льюис";
						}

						if (npc.GivenName == "Jonathan")
						{
							npc.GivenName = "Джонатан";
						}

						if (npc.GivenName == "Griswald")
						{
							npc.GivenName = "Грисвальд";
						}

						if (npc.GivenName == "Calvin")
						{
							npc.GivenName = "Кельвин";
						}
					}

					if (npc.type == thorium.NPCType("ConfusedZombie"))
					{
						if (npc.GivenName == "Leech")
						{
							npc.GivenName = "Лич";
						}

						if (npc.GivenName == "Bile")
						{
							npc.GivenName = "Бил";
						}

						if (npc.GivenName == "Bloat")
						{
							npc.GivenName = "Блот";
						}

						if (npc.GivenName == "Fester")
						{
							npc.GivenName = "Фестер";
						}

						if (npc.GivenName == "Richter")
						{
							npc.GivenName = "Рихтер";
						}

						if (npc.GivenName == "Salem")
						{
							npc.GivenName = "Салем";
						}

						if (npc.GivenName == "Grimm")
						{
							npc.GivenName = "Гримм";
						}

						if (npc.GivenName == "Mort")
						{
							npc.GivenName = "Морт";
						}
					}

					if (npc.type == thorium.NPCType("Cook"))
					{
						if (npc.GivenName == "Emeril")
						{
							npc.GivenName = "Эмерил";
						}

						if (npc.GivenName == "Guy")
						{
							npc.GivenName = "Гай";
						}

						if (npc.GivenName == "Gordan")
						{
							npc.GivenName = "Гордон";
						}

						if (npc.GivenName == "Alton")
						{
							npc.GivenName = "Алтон";
						}

						if (npc.GivenName == "Éric")
						{
							npc.GivenName = "Эрик";
						}

						if (npc.GivenName == "Jamie")
						{
							npc.GivenName = "Джейми";
						}

						if (npc.GivenName == "Jacques")
						{
							npc.GivenName = "Жак";
						}

						if (npc.GivenName == "Flay")
						{
							npc.GivenName = "Флай";
						}
					}

					if (npc.type == thorium.NPCType("DesertTraveler"))
					{
						if (npc.GivenName == "Karoo")
						{
							npc.GivenName = "Кару";
						}

						if (npc.GivenName == "Waiouru")
						{
							npc.GivenName = "Уэйауру";
						}

						if (npc.GivenName == "Rangi")
						{
							npc.GivenName = "Ранги";
						}

						if (npc.GivenName == "Aalim")
						{
							npc.GivenName = "Аалим";
						}

						if (npc.GivenName == "Maaz")
						{
							npc.GivenName = "Ма'аз";
						}

						if (npc.GivenName == "Munzir")
						{
							npc.GivenName = "Мунзир";
						}

						if (npc.GivenName == "Laiq")
						{
							npc.GivenName = "Лайку";
						}

						if (npc.GivenName == "Namib")
						{
							npc.GivenName = "Намиб";
						}
					}

					if (npc.type == thorium.NPCType("Diverman"))
					{
						if (npc.GivenName == "Calder")
						{
							npc.GivenName = "Колдер";
						}

						if (npc.GivenName == "Sam")
						{
							npc.GivenName = "Сэм";
						}

						if (npc.GivenName == "Elijah")
						{
							npc.GivenName = "Элияху";
						}

						if (npc.GivenName == "Zane")
						{
							npc.GivenName = "Зейн";
						}

						if (npc.GivenName == "Stephen")
						{
							npc.GivenName = "Стефен";
						}

						if (npc.GivenName == "Adin")
						{
							npc.GivenName = "Адин";
						}

						if (npc.GivenName == "Nolen")
						{
							npc.GivenName = "Нолен";
						}

						if (npc.GivenName == "Maxwell")
						{
							npc.GivenName = "Максвелл";
						}
					}

					if (npc.type == thorium.NPCType("Druid"))
					{
						if (npc.GivenName == "Folium")
						{
							npc.GivenName = "Фолиум";
						}

						if (npc.GivenName == "Lignum")
						{
							npc.GivenName = "Лигнум";
						}

						if (npc.GivenName == "Viridis")
						{
							npc.GivenName = "Вермонт";
						}

						if (npc.GivenName == "Lilly")
						{
							npc.GivenName = "Лилия";
						}

						if (npc.GivenName == "Rose")
						{
							npc.GivenName = "Роза";
						}

						if (npc.GivenName == "Yarrow")
						{
							npc.GivenName = "Тысячелистник";
						}

						if (npc.GivenName == "Camellia")
						{
							npc.GivenName = "Камелия";
						}

						if (npc.GivenName == "Ligna")
						{
							npc.GivenName = "Лигна";
						}
					}

					if (npc.type == thorium.NPCType("Spiritualist"))
					{
						if (npc.GivenName == "Balthasar")
						{
							npc.GivenName = "Бальтазар";
						}

						if (npc.GivenName == "Pax")
						{
							npc.GivenName = "Пакс";
						}

						if (npc.GivenName == "Bodhi")
						{
							npc.GivenName = "Бодхи";
						}

						if (npc.GivenName == "Nix")
						{
							npc.GivenName = "Никс";
						}

						if (npc.GivenName == "Algalon")
						{
							npc.GivenName = "Алгалон";
						}

						if (npc.GivenName == "Zen")
						{
							npc.GivenName = "Зен";
						}

						if (npc.GivenName == "Dhruv")
						{
							npc.GivenName = "Друв";
						}

						if (npc.GivenName == "Titus")
						{
							npc.GivenName = "Титус";
						}
					}

					if (npc.type == thorium.NPCType("Tracker"))
					{
						if (npc.GivenName == "Atlas")
						{
							npc.GivenName = "Атлас";
						}

						if (npc.GivenName == "Daston")
						{
							npc.GivenName = "Дастон";
						}

						if (npc.GivenName == "Guts")
						{
							npc.GivenName = "Гатс";
						}

						if (npc.GivenName == "Dalton")
						{
							npc.GivenName = "Далтон";
						}

						if (npc.GivenName == "Cyris")
						{
							npc.GivenName = "Цирис";
						}

						if (npc.GivenName == "Aaron")
						{
							npc.GivenName = "Аарон";
						}

						if (npc.GivenName == "Kwan")
						{
							npc.GivenName = "Кван";
						}

						if (npc.GivenName == "Garm")
						{
							npc.GivenName = "Гарм";
						}
					}

					if (npc.type == thorium.NPCType("WeaponMaster"))
					{
						if (npc.GivenName == "Flatoom")
						{
							npc.GivenName = "Флатум";
						}

						if (npc.GivenName == "Helnos")
						{
							npc.GivenName = "Гелнос";
						}

						if (npc.GivenName == "Targup")
						{
							npc.GivenName = "Таргуп";
						}

						if (npc.GivenName == "Glib'tok")
						{
							npc.GivenName = "Глиб'ток";
						}

						if (npc.GivenName == "Fuzgrom")
						{
							npc.GivenName = "Фузгром";
						}

						if (npc.GivenName == "Greth'zek")
						{
							npc.GivenName = "Грех'зек";
						}

						if (npc.GivenName == "Sera'noth")
						{
							npc.GivenName = "Сера'нотх";
						}

						if (npc.GivenName == "Hro'grak")
						{
							npc.GivenName = "Хро'грак";
						}
					}
				}
			}
		}
	}
}
