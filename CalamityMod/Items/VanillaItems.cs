using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityRuTranslate.CalamityMod.Items
{
	public class VanillaItems : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (ModLoader.GetMod("CalamityMod") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (CalamityRuTranslate.TRuConfig.CalamityTranslation)
				{
					if (item.type == ItemID.WarmthPotion)
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Makes you immune to the Chilled, Frozen, and Glacial State debuffs", "Делает вас невосприимчивым к дебаффам «Охлаждение», «Заморозка», и «Ледниковое состояние»");
							string resultB = resultA.Replace("Provides cold protection in Death Mode", "Обеспечивает защитой от холода в режиме Смерти");
							tooltipLine.text = resultB;
						}
					}

					if (item.type == ItemID.FireGauntlet)
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("14% increased melee damage and speed", "Увеличивает урон и скорость атаки ближнего боя на 14%");
							string resultB = resultA.Replace("10% increased true melee damage", "Увеличивает истинный урон ближнего боя на 10%");
							string resultC = resultB.Replace("Provides heat and cold protection in Death Mode", "Обеспечивает защитой жары от холода в режиме Смерти");
							tooltipLine.text = resultC;
						}
					}

					if (item.type == ItemID.ObsidianSkinPotion)
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Provides immunity to direct damage from touching lava", "Обеспечивает иммунитетом к прямым повреждениям от соприкосновения с лавой");
							string resultB = resultA.Replace("Provides temporary immunity to lava burn damage", "Обеспечивает временным иммунитетом к ожогу от лавы");
							string resultC = resultB.Replace("Reduces lava burn damage", "Снижает урон от ожога лавы");
							string resultD = resultC.Replace("Provides heat protection in Death Mode", "Обеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultD;
						}
					}

					if (item.type == ItemID.ObsidianRose)
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Reduced direct damage from touching lava", "Снижает прямой урон от соприкосновения с лавой");
							string resultB = resultA.Replace("Greatly reduces lava burn damage", "Значительно снижает урон от ожога лавы");
							string resultC = resultB.Replace("Provides heat protection in Death Mode", "Обеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultC;
						}
					}

					if (item.type == ItemID.MagmaStone)
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Provides heat and cold protection in Death Mode", "Обеспечивает защитой от жары и холода в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == ItemID.LavaCharm)
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Provides heat protection in Death Mode", "Обеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == ItemID.LavaWaders)
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Provides heat protection in Death Mode", "Обеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == ItemID.HandWarmer)
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Provides immunity to chilling and freezing effects", "Обеспечивает невосприимчивостью к ледяным и замораживающим эффектам");
							string resultB = resultA.Replace("Provides a regeneration boost while wearing the Eskimo armor", "Обеспечивает повышенной регенерацией пока на вас надет комплект эскимоса");
							string resultC = resultB.Replace("Provides cold protection in Death Mode", "Обеспечивает защитой от холода в режиме Смерти");
							tooltipLine.text = resultC;
						}
					}
					
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Current Charge", "Текущий заряд");
						tooltipLine.text = resultA;
					}
					
					if (item.prefix > 0)
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							if (tooltipLine.Name == "PrefixSSDmg")
							{
								string str = tooltipLine.text;
								string resultA = str.Replace("stealth strike damage", "урона при скрытном ударе");
								tooltipLine.text = resultA;
							}
						
							if (tooltipLine.Name == "PrefixStealthGenBoost")
							{
								string str = tooltipLine.text;
								string resultA = str.Replace("stealth generation", "регенерации скрытности");
								tooltipLine.text = resultA;
							}
						}
					}

					if (item.accessory)
					{
						if (item.prefix == 67 || item.prefix == 68)
						{
							foreach (TooltipLine tooltipLine in tooltips)
							{
								if (tooltipLine.Name == "PrefixAccCritChance")
								{
									string str = tooltipLine.text;
									string resultA = str.Replace("critical strike chance", "шанс критического удара");
									tooltipLine.text = resultA;
								}
							}
						}

						if (item.prefix == 62 || item.prefix == 63 || item.prefix == 64 || item.prefix == 65)
						{
							foreach (TooltipLine tooltipLine2 in tooltips)
							{
								string str = tooltipLine2.text;
								string resultA = str.Replace("defense", "защиты");
								tooltipLine2.text = resultA;
							}

							foreach (TooltipLine tooltipLine3 in tooltips)
							{
								if (tooltipLine3.Name == "PrefixAccDefense")
								{
									string str = tooltipLine3.text;
									string resultA = str.Replace("damage reduction", "сопротивление урону");
									tooltipLine3.text = resultA;
								}
							}
						}
					}

					TooltipLine line1 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Tooltip0");
					if (line1 != null)
					{
						switch (item.type)
						{
							case 1294:
								line1.text = "Может добывать кирпич ящщеров и магматитовую руду";
								return;
							case 1340:
								line1.text = "Ближние и разбойные атаки накладывают на противников дебафф «Яд»";
								return;
							case 1353:
								line1.text = "Ближние и разбойные атаки накладывают на врагов дебафф «Проклятое пламя»";
								return;
							case 1354:
								line1.text = "Ближние и разбойные атаки накладывают на врагов дебафф «В Огне!»";
								return;
							case 1355:
								line1.text = "При ближних и разбойных атаках враги оставляют больше золота";
								return;
							case 1356:
								line1.text = "Ближние и разбойные атаки снижают защиту врагов";
								return;
							case 1357:
								line1.text = "Ближние и разбойные атаки накладывают на врагов дебафф «Запутанность»";
								return;
							case 1358:
								line1.text = "Все атаки вызывают появление конфетти";
								return;
							case 1359:
								line1.text = "Ближние и разбойные атаки накладывают дебафф «Отравление»";
								return;
							case 88:
								line1.text = Language.GetTextValue("ItemTooltip.MiningHelmet") + "\nОбеспечивает небольшим количеством света в бездне";
								return;
							case 1326:
								line1.text = Language.GetTextValue("ItemTooltip.RodofDiscord") + "\nТелепортация отключена пока активен дебафф «Состояние хаоса»";
								return;
							case 3032:
								line1.text = Language.GetTextValue("ItemTooltip.SuperAbsorbantSponge") + "\nНельзя использовать в бездне";
								return;
							case 3062:
								line1.text = Language.GetTextValue("ItemTooltip.CrimsonHeart") + "\nОбеспечивает небольшим количеством света в бездне";
								return;
							case 115:
								line1.text = Language.GetTextValue("ItemTooltip.ShadowOrb") + "\nОбеспечивает небольшим количеством света в бездне";
								return;
							case 3043:
								line1.text = Language.GetTextValue("ItemTooltip.MagicLantern") + "\nОбеспечивает небольшим количеством света в бездне";
								return;
							case 1303:
								line1.text = Language.GetTextValue("ItemTooltip.JellyfishNecklace") + "\nОбеспечивает небольшим количеством света в бездне";
								return;
							case 425:
								line1.text = Language.GetTextValue("ItemTooltip.FairyBell") + "\nОбеспечивает умеренным количеством света в бездне";
								return;
							case 3856:
								line1.text = Language.GetTextValue("ItemTooltip.DD2PetGhost") + "\nОбеспечивает умеренным количеством света в бездне";
								return;
							case 1183:
								line1.text = Language.GetTextValue("ItemTooltip.WispinaBottle") + "\nОбеспечивает большим количеством света в бездне";
								return;
							case 268:
								line1.text = Language.GetTextValue("ItemTooltip.DivingHelmet") + "\nУмеренно снижает потерю дыхания в бездне";
								return;
							case 497:
								line1.text = Language.GetTextValue("ItemTooltip.NeptunesShell") + "\nЗначительно снижает потерю дыхания в бездне";
								return;
							case 861:
								line1.text = Language.GetTextValue("ItemTooltip.MoonShell") + "\nЗначительно снижает потерю дыхания в бездне";
								return;
							case 3224:
								line1.text = "Получаемый урон снижен на 10%";
								return;
							case 536:
								line1.text = Language.GetTextValue("ItemTooltip.TitanGlove") + "\nУвеличивает истинный урон ближнего боя на 10%";
								return;
							case 1503:
								line1.text = "Снижает магический урон на 20%";
								return;
							case 1321:
								line1.text = "Увеличивает урон стрел на 10% и значительно увеличивает скорость стрел";
								return;
							case 297:
								line1.text = Language.GetTextValue("ItemTooltip.InvisibilityPotion") + "\nУсиливает определённые характеристики, держа в руках определённый тип разбойного оружия";
								return;
						}
					}

					TooltipLine line2 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Defense");
					if (line2 != null)
					{
						switch (item.type)
						{
							case 205:
								line2.text = "1 единица защиты\nНельзя использовать в бездне";
								return;
							case 3187:
								line2.text = "3 единицы защиты\nУвеличивает разбойный урон на 3%";
								return;
							case 3188:
								line2.text = "5 единиц защиты\nУвеличивает разбойный шанс критического удара на 3%";
								return;
							case 3189:
								line2.text = "4 единицы защиты\nУвеличивает скорость снарядов разбойника на 3%";
								return;
							case 3266:
								line2.text = "4 единицы защиты\nУвеличивает разбойный урон на 3%";
								return;
							case 3267:
								line2.text = "5 единиц защиты\nУвеличивает разбойный шанс критического удара на 3%";
								return;
							case 3268:
								line2.text = "4 единицы защиты\nУвеличивает скорость снарядов разбойника на 3%";
								return;
						}
					}

					TooltipLine line3 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Tooltip1");
					if (line3 != null)
					{
						switch (item.type)
						{
							case 1860:
								line3.text = "Дает свет под водой\nОбеспечивает небольшим количеством света в бездне";
								return;
							case 1861:
								line3.text = "Дает свет под водой и увеличивает подвижность на льду\nОбеспечивает небольшим количеством света в бездне\nУмеренно снижает потерю дыхания в бездне";
								return;
							case 3577:
								line3.text = "'Я знаю, о чем ты думаешь...'\nОбеспечивает большим количеством света в бездне";
								return;
							case 3110:
								line3.text = "Немного увеличивает все характеристики\nЗначительно снижает потерю дыхания в бездне";
								return;
							case 897:
								line3.text = "Увеличивает скорость атаки ближнего боя на 12%\nУвеличивает истинный урон ближнего боя на 10%";
								return;
							case 936:
								line3.text = "Увеличивает урон и скорость атаки ближнего боя на 12%\nУвеличивает истинный урон ближнего боя на 10%";
								return;
						}
					}

					TooltipLine line4 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "BuffTime");
					if (line4 != null)
					{
						switch (item.type)
						{
							case 298:
								line4.text = "Длительность 5 мин.\nОбеспечивает умеренным количеством света в бездне";
								return;
							case 291:
								line4.text = "Длительность 2 мин.\nЗначительно снижает потерю дыхания в бездне";
								return;
						}
					}

					TooltipLine line5 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "SetBonus");
					if (line5 != null)
					{
						switch (item.type)
						{
							case 123:
							case 124:
							case 125:
								line5.text = "Бонус комплекта: Космический пистолет потребляет на 50% меньше маны";
								return;
							case 76:
							case 80:
							case 89:
								line5.text = "Бонус комплекта: +2 единицы защиты и увеличивает скорость добычи на 15%";
								return;
							case 687:
							case 688:
							case 689:
								line5.text = "Бонус комплекта: +2 единицы защиты и увеличивает скорость добычи на 10%";
								return;
							case 77:
							case 81:
							case 90:
							case 954:
								line5.text = "Бонус комплекта: +2 единицы защиты и увеличивает скорость добычи на 25%";
								return;
							case 690:
							case 691:
							case 692:
								line5.text = "Бонус комплекта: +3 единицы защиты и увеличивает скорость добычи на 20%";
								return;
							case 78:
							case 82:
							case 91:
								line5.text = "Бонус комплекта: +3 единицы защиты и увеличивает скорость добычи на 35%";
								return;
							case 693:
							case 694:
							case 695:
								line5.text = "Бонус комплекта: +3 единицы защиты и увеличивает скорость добычи на 30%";
								return;
							case 79:
							case 83:
							case 92:
							case 955:
								line5.text = "Бонус комплекта: +3 единицы защиты и увеличивает скорость добычи на 45%";
								return;
							case 696:
							case 697:
							case 698:
								line5.text = "Бонус комплекта: +4 единицы защиты и увеличивает скорость добычи на 40%";
								return;
						}
					}

					TooltipLine line6 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Equipable");
					if (line6 != null)
					{
						switch (item.type)
						{
							case 84:
								line6.text = "Можно надеть\nДальность: 18.75\nСкорость вылета: 11.5\nСкорость притягивания: 11";
								return;
							case 1236:
								line6.text = "Можно надеть\nДальность: 18.75\nСкорость вылета: 10\nСкорость притягивания: 11";
								return;
							case 1237:
								line6.text = "Можно надеть\nДальность: 20.625\nСкорость вылета: 10.5\nСкорость притягивания: 11.75";
								return;
							case 1238:
								line6.text = "Можно надеть\nДальность: 22.5\nСкорость вылета: 11\nСкорость притягивания: 12.5";
								return;
							case 1239:
								line6.text = "Можно надеть\nДальность: 24.375\nСкорость вылета: 11.5\nСкорость притягивания: 13.25";
								return;
							case 1240:
								line6.text = "Можно надеть\nДальность: 26.25\nСкорость вылета: 12\nСкорость притягивания: 14";
								return;
							case 1241:
								line6.text = "Можно надеть\nДальность: 28.125\nСкорость вылета: 12.5\nСкорость притягивания: 14.75";
								return;
							case 939:
								line6.text = "Можно надеть\nДальность: 15.625\nСкорость вылета: 10\nСкорость притягивания: 11";
								return;
							case 1273:
								line6.text = "Можно надеть\nДальность: 21.875\nСкорость вылета: 15\nСкорость притягивания: 11";
								return;
							case 2585:
								line6.text = "Можно надеть\nДальность: 18.75\nСкорость вылета: 13\nСкорость притягивания: 11";
								return;
							case 2360:
								line6.text = "Можно надеть\nДальность: 25\nСкорость вылета: 13\nСкорость притягивания: 11";
								return;
							case 185:
								line6.text = "Можно надеть\nДальность: 25\nСкорость вылета: 13\nСкорость притягивания: 15";
								return;
							case 1800:
								line6.text = "Можно надеть\nДальность: 31.25\nСкорость вылета: 15.5\nСкорость притягивания: 20";
								return;
							case 1915:
								line6.text = "Можно надеть\nДальность: 25\nСкорость вылета: 11.5\nСкорость притягивания: 11";
								return;
							case 437:
								line6.text = "Можно надеть\nДальность: 27.5\nСкорость вылета: 14\nСкорость притягивания: 17";
								return;
							case 3020:
							case 3021:
							case 3022:
							case 3023:
								line6.text = "Можно надеть\nДальность: 30\nСкорость вылета: 15\nСкорость притягивания: 18";
								return;
							case 2800:
								line6.text = "Можно надеть\nДальность: 31.25\nСкорость вылета: 14\nСкорость притягивания: 20";
								return;
							case 1829:
								line6.text = "Можно надеть\nДальность: 34.375\nСкорость вылета: 15.5\nСкорость притягивания: 22";
								return;
							case 1916:
								line6.text = "Можно надеть\nДальность: 34.375\nСкорость вылета: 15.5\nСкорость притягивания: 17";
								return;
							case 3572:
								line6.text = "Можно надеть\nДальность: 34.375\nСкорость вылета: 16\nСкорость притягивания: 24";
								return;
							case 3623:
								line6.text = "Можно надеть\nДальность: 37.5\nСкорость вылета: 16\nСкорость притягивания: 24";
								return;
						}
					}

					TooltipLine line7 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "NeedsBait");
					if (line7 != null)
					{
						switch (item.type)
						{
							case 2294:
								line7.text = "Для ловли рыбы нужна наживка\nЛеска никогда не порвётся";
								return;
						}
					}

					TooltipLine line8 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "Material");
					if (line8 != null)
					{
						switch (item.type)
						{
							case 2776:
							case 2781:
							case 2786:
							case 3466:
								line8.text = "Материал\nМожет добывать руду буйного цветения";
								return;
						}
					}

					TooltipLine line9 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "HealLife");
					if (line9 != null)
					{
						switch (item.type)
						{
							case 1134:
								line9.text = "Восстанавливает 80 ед. здоровья\nДарует бафф «Мёд» на 2 минуты";
								return;
						}
					}
				}
			}
		}
	}
}