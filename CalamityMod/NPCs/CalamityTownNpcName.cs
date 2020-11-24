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
			if (ModCompatibility.CalamityMod != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (CalamityRuTranslate.TRuConfig.CalamityTranslation)
				{
					if (npc.type == ModCompatibility.CalamityMod.NPCType("Polterghast"))
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

					if (npc.type == ModCompatibility.CalamityMod.NPCType("DILF"))
					{
						npc.GivenName = "Пермафрост";
					}

					if (npc.type == ModCompatibility.CalamityMod.NPCType("FAP"))
					{
						npc.GivenName = "Циррус";
					}

					if (npc.type == ModCompatibility.CalamityMod.NPCType("SEAHOE"))
					{
						npc.GivenName = "Амидиас";
					}

					if (npc.type == ModCompatibility.CalamityMod.NPCType("THIEF"))
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
							npc.GivenName = "СтрикистYT";
						}

						if (npc.GivenName == "Neoplasmatic")
						{
							npc.GivenName = "Неоплазматик";
						}

						if (npc.GivenName == "Devin")
						{
							npc.GivenName = "Девин";
						}

						if (npc.GivenName == "Woffle")
						{
							npc.GivenName = "Воффл";
						}

						if (npc.GivenName == "Cameron")
						{
							npc.GivenName = "Кэмерон";
						}

						if (npc.GivenName == "Ben Shapiro")
						{
							npc.GivenName = "Бен Шапиро";
						}

						if (npc.GivenName == "Lapp")
						{
							npc.GivenName = "Лапп";
						}
					}

					if (npc.type == NPCID.Nurse)
					{
						if (npc.GivenName == "Farsni")
						{
							npc.GivenName = "Фарсни";
						}
					}
					
					if (npc.type == NPCID.Dryad)
					{
						if (npc.GivenName == "Rythmi")
						{
							npc.GivenName = "Ритми";
						}

						if (npc.GivenName == "Izuna")
						{
							npc.GivenName = "Изуна";
						}
						
						if (npc.GivenName == "Jasmine")
						{
							npc.GivenName = "Жасмин";
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

						if (npc.GivenName == "Finchi")
						{
							npc.GivenName = "Финчи";
						}
					}

					if (npc.type == NPCID.Stylist)
					{
						if (npc.GivenName == "Amber")
						{
							npc.GivenName = "Эмбер";
						}
					}

					if (npc.type == NPCID.Angler)
					{
						if (npc.GivenName == "Dazren")
						{
							npc.GivenName = "Дазрен";
						}
					}
					
					if (npc.type == NPCID.WitchDoctor)
					{
						if (npc.GivenName == "Sok'ar")
						{
							npc.GivenName = "Сокар";
						}
						
						if (npc.GivenName == "Toxin")
						{
							npc.GivenName = "Токсин";
						}
					}

					if (npc.type == NPCID.Clothier)
					{
						if (npc.GivenName == "Joeseph Jostar")
						{
							npc.GivenName = "Джозеф Джостар";
						}
					}

					if (npc.type == NPCID.Wizard)
					{
						if (npc.GivenName == "Mage One-Trick")
						{
							npc.GivenName = "Маг Трюкач";
						}

						if (npc.GivenName == "Inorim, son of Ivukey")
						{
							npc.GivenName = "Инорим, сын Ивукея";
						}

						if (npc.GivenName == "Jensen")
						{
							npc.GivenName = "Дженсен";
						}
						
						if (npc.GivenName == "Merasmus")
						{
							npc.GivenName = "Мерасмус";
						}
						
						if (npc.GivenName == "Habolo")
						{
							npc.GivenName = "Хаболо";
						}
					}

					if (npc.type == NPCID.TaxCollector)
					{
						if (npc.GivenName == "Emmett")
						{
							npc.GivenName = "Эммет";
						}
					}
					
					if (npc.type == NPCID.Pirate)
					{
						if (npc.GivenName == "Tyler Van Hook")
						{
							npc.GivenName = "Тайлер Ван Хук";
						}
					}

					if (npc.type == NPCID.Steampunker)
					{
						if (npc.GivenName == "Vorbis")
						{
							npc.GivenName = "Ворбис";
						}

						if (npc.GivenName == "Angel")
						{
							npc.GivenName = "Энжел";
						}
					}
					
					if (npc.type == NPCID.Mechanic)
					{
						if (npc.GivenName == "Lilly")
						{
							npc.GivenName = "Лили";
						}

						if (npc.GivenName == "Daawn")
						{
							npc.GivenName = "Даан";
						}
						
						if (npc.GivenName == "Robin")
						{
							npc.GivenName = "Робин";
						}
					}
					
					if (npc.type == NPCID.GoblinTinkerer)
					{
						if (npc.GivenName == "Verth")
						{
							npc.GivenName = "Верт";
						}
						
						if (npc.GivenName == "Gormer")
						{
							npc.GivenName = "Кормер";
						}
					}
				}
			}
		}
	}
}
