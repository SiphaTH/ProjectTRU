using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Items
{
	public class DeathModeItems : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (ModCompatibility.CalamityMod != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (CalamityRuTranslate.TRuConfig.CalamityTranslation)
				{
					if (item.type == ModCompatibility.CalamityMod.ItemType("CelestialTracers"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip10")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Получив более 200 единиц урона сделает вас неуязвимым в течении длительного промежутка времени\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Получив более 200 единиц урона сделает вас неуязвимым в течении длительного промежутка времени";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("ElysianTracers"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip9")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Временная невосприимчивость к лаве\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Временная невосприимчивость к лаве";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("ElysianWings"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip5")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Временная невосприимчивость к лаве; увеличивает скорость передвижения на 40%\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Временная невосприимчивость к лаве; увеличивает скорость передвижения на 40%";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("SoulofCryogen"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip8")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Сосульки обрушиваются, пока вы летите\nОбеспечивает защитой от жары и холода в режиме Смерти" : 
									"Сосульки обрушиваются, пока вы летите";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("Popo"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip1")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Превращает носителя в снеговика\nОбеспечивает защитой от жары и холода в режиме Смерти" : 
									"Превращает носителя в снеговика";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("AmbrosialAmpoule"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip5")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Большинство пчёл/шершней и их снарядов наносят вам только 75% урона\nОбеспечивает защитой от холода в режиме Смерти" : 
									"Большинство пчёл/шершней и их снарядов наносят вам только 75% урона";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("AngelTreads"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip5")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Временная невосприимчивость к лаве\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Временная невосприимчивость к лаве";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("BlazingCore"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip5")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Обеспечивает умеренным количеством света в бездне\nОбеспечивает защитой от жары и холода в режиме Смерти" : 
									"Обеспечивает умеренным количеством света в бездне";
							}
						}
					}
					
					if (item.type == ModCompatibility.CalamityMod.ItemType("FrigidBulwark"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip4")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Панцирь становится сильнее и ещё больше снижает урон, когда здоровье ниже 15%\nОбеспечивает защитой от жары и холода в режиме Смерти" : 
									"Панцирь становится сильнее и ещё больше снижает урон, когда здоровье ниже 15%";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("FrostBarrier"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip1")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Вы невосприимчивы к дебаффу «Охлаждение»\nОбеспечивает защитой от жары и холода в режиме Смерти" : 
									"Вы невосприимчивы к дебаффу «Охлаждение»";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("FrostFlare"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip5")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Обеспечивает защитой от жары и холода в режиме Смерти\nПредмет режима Месть" : 
									"Предмет режима Месть";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("InfinityBoots"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip9")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Временная невосприимчивость к лаве\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Временная невосприимчивость к лаве";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("PermafrostsConcoction"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip4")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Вы находитесь в ледяном барьере в течение 3 секунд после возрождения\nОбеспечивает защитой от жары и холода в режиме Смерти" : 
									"Вы находитесь в ледяном барьере в течение 3 секунд после возрождения";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("RampartofDeities"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip9")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Обеспечивает защитой от жары и холода в режиме Смерти" : 
									"";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("Sponge"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip12")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Часть урона вражеских атак будет поглощена и использована для исцеления вас\nОбеспечивает защитой от холода в режиме Смерти" : 
									"Часть урона вражеских атак будет поглощена и использована для исцеления вас";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("TheAmalgam"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip8")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Увеличивает скорость передвижение в жидкостях, а также у вас есть разрушающая аура, которая отравляет ближайших врагов\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Увеличивает скорость передвижение в жидкостях, а также у вас есть разрушающая аура, которая отравляет ближайших врагов";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("TheCamper"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip5")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Обеспечивает небольшим количеством света в бездне\nОбеспечивает защитой от холода в режиме Смерти" : 
									"Обеспечивает небольшим количеством света в бездне";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("VoidofExtinction"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip4")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Временная невосприимчивость к лаве; значительно уменьшает урон от ожога лавы и увеличивает урон на 25%, находясь в лаве\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Временная невосприимчивость к лаве; значительно уменьшает урон от ожога лавы и увеличивает урон на 25%, находясь в лаве";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("YharimsInsignia"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip6")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Увеличивает отбрасывание ближнего боя\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Увеличивает отбрасывание ближнего боя";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("AtaxiaHeadgear"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip1")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"25% шанс не использовать боеприпасы; временная невосприимчивость к лаве и невосприимчивость к урону от огня\nОбеспечивает защитой от жары в режиме Смерти" : 
									"25% шанс не использовать боеприпасы; временная невосприимчивость к лаве и невосприимчивость к урону от огня";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("AtaxiaHelm"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip3")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Временная невосприимчивость к лаве и невосприимчивость к урону от огня\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Временная невосприимчивость к лаве и невосприимчивость к урону от огня";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("AtaxiaHelmet"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip2")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Временная невосприимчивость к лаве и невосприимчивость к урону от огня\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Временная невосприимчивость к лаве и невосприимчивость к урону от огня";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("AtaxiaHood"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip2")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Временная невосприимчивость к лаве и невосприимчивость к урону от огня\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Временная невосприимчивость к лаве и невосприимчивость к урону от огня";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("AtaxiaMask"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip1")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Увеличивает максимальный запас маны на 100; временная невосприимчивость к лаве и невосприимчивость к урону от огня\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Увеличивает максимальный запас маны на 100; временная невосприимчивость к лаве и невосприимчивость к урону от огня";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("AuricTeslaBodyArmor"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip4")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Вы будете замораживать врагов рядом с вами после получения удара\nОбеспечивает защитой от жары и холода в режиме Смерти" : 
									"Вы будете замораживать врагов рядом с вами после получения удара";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("BloodflareHelm"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip1")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Увеличивает разбойный урон и шанс критического удара на 10%, и скорость передвижения на 15%\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Увеличивает разбойный урон и шанс критического удара на 10%, и скорость передвижения на 15%";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("BloodflareHelmet"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip1")
							{
								tooltipLine.text = tooltipLine.text = ModCompatibility.DeathMode ?
									"Увеличивает максимальное число миньонов на 3\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Увеличивает максимальное число миньонов на 3";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("BloodflareHornedHelm"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip1")
							{
								tooltipLine.text = tooltipLine.text = ModCompatibility.DeathMode ?
									"Увеличивает стрелковый урон и шанс критического удара на 10%\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Увеличивает стрелковый урон и шанс критического удара на 10%";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("BloodflareHornedMask"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip1")
							{
								tooltipLine.text = tooltipLine.text = ModCompatibility.DeathMode ?
									"Увеличивает магический урон и шанс критического удара на 10%, максимальный запас маны на 100 и снижает расход маны на 17%\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Увеличивает магический урон и шанс критического удара на 10%, максимальный запас маны на 100 и снижает расход маны на 17%";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("BloodflareMask"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip1")
							{
								tooltipLine.text = tooltipLine.text = ModCompatibility.DeathMode ?
									"Увеличивает урон ближнего боя и шанс критического удара на 10%\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Увеличивает урон ближнего боя и шанс критического удара на 10%";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("TarragonHelm"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip4")
							{
								tooltipLine.text = tooltipLine.text = ModCompatibility.DeathMode ?
									"Увеличивает урон ближнего боя и шанс критического удара на 10%\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Увеличивает урон ближнего боя и шанс критического удара на 10%";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("TarragonHelmet"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip3")
							{
								tooltipLine.text = tooltipLine.text = ModCompatibility.DeathMode ?
									"Увеличивает сопротивление урону на 5%\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Увеличивает сопротивление урону на 5%";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("TarragonHornedHelm"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip2")
							{
								tooltipLine.text = tooltipLine.text = ModCompatibility.DeathMode ?
									"Увеличивает сопротивление урону на 5% и максимальное число миньонов на 3\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Увеличивает сопротивление урону на 5% и максимальное число миньонов на 3";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("TarragonMask"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip3")
							{
								tooltipLine.text = tooltipLine.text = ModCompatibility.DeathMode ?
									"Увеличивает сопротивление урону на 5%, максимальный запас маны на 100 и снижает расход маны на 15%\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Увеличивает сопротивление урону на 5%, максимальный запас маны на 100 и снижает расход маны на 15%";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("TarragonVisage"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip3")
							{
								tooltipLine.text = tooltipLine.text = ModCompatibility.DeathMode ?
									"Увеличивает сопротивление урону на 5%\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Увеличивает сопротивление урону на 5%";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("XerocMask"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip2")
							{
								tooltipLine.text = tooltipLine.text = ModCompatibility.DeathMode ?
									"Временная невосприимчивость к лаве\nОбеспечивает защитой от жары в режиме Смерти" : 
									"Временная невосприимчивость к лаве";
							}
						}
					}
					
					if (item.type == ModCompatibility.CalamityMod.ItemType("PurifiedJam"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "Tooltip0")
							{
								tooltipLine.text = ModCompatibility.DeathMode ?
									"Делает вас невосприимчивым ко всему урону и большинству дебаффов на 5 секунд" : 
									"Делает вас невосприимчивым ко всему урону и большинству дебаффов на 10 секунд";
							}
						}
					}

					if (item.type == ModCompatibility.CalamityMod.ItemType("ColdDivinity"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Provides heat and cold protection in Death Mode when in use\nRevengeance Drop", "Обеспечивает защитой от жары и холода в режиме Смерти\nПредмет режима Месть");
							tooltipLine.text = resultA;
						}
					}
				}
			}
		}
	}
}
