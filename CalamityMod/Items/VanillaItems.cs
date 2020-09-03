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
			if (ModLoader.GetMod("CalamityMod") != null &&
			    LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (item.type == ItemID.WarmthPotion)
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Makes you immune to the Chilled, Frozen, and Glacial State debuffs", "Делает вас невосприимчивым к «Охлаждению», «Заморозке», и «Ледниковому состоянию»");
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
						string resultA = str.Replace("Provides immunity to direct damage from touching lava", "Обеспечивает иммунитетом к прямым повреждениям от прикосновения с лавой");
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
						string resultA = str.Replace("Reduced direct damage from touching lava", "Обеспечивает иммунитетом к прямым повреждениям от прикосновения с лавой");
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

				if (item.type == ItemID.MoltenHelmet ||
				    item.type == ItemID.MoltenBreastplate ||
				    item.type == ItemID.MoltenGreaves)
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Set Bonus: 17% extra melee damage\n20% extra true melee damage\nGrants immunity to fire blocks, and temporary immunity to lava\nProvides heat and cold protection in Death Mode", "Бонус комплекта: Увеличивает урон ближнего боя на 17%\nНаносит 20% дополнительного истинного урона ближнего боя\nДарует невосприимчивость к огненным блокам и временную невосприимчивость к лаве\nОбеспечивает защитой от жары и холода в режиме Смерти");
						tooltipLine.text = resultA;
					}
				}

				if (item.type == ItemID.FrostHelmet ||
				    item.type == ItemID.FrostBreastplate ||
				    item.type == ItemID.FrostLeggings)
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Provides heat and cold protection in Death Mode", "Обеспечивает защитой от жары и холода в режиме Смерти");
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

				if (item.type == ItemID.EskimoHood ||
				    item.type == ItemID.PinkEskimoHood ||
				    item.type == ItemID.EskimoCoat ||
				    item.type == ItemID.PinkEskimoCoat ||
				    item.type == ItemID.EskimoPants ||
				    item.type == ItemID.PinkEskimoPants)
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("All ice-themed weapons receive a 10% damage bonus\nCold enemies will deal reduced contact damage to the player\nProvides immunity to the Frostburn and Glacial State debuffs", "Всё оружие ледяной тематики получает 10% бонусный урон\nВсе враги ледяной тематики будут наносить сниженный контактный урон игроку\nОбеспечивает невосприимчивостью к «Ледяному ожогу» и «Ледниковому состоянию»");
						string resultB = resultA.Replace("Provides cold protection in Death Mode", "Обеспечивает защитой от холода в режиме Смерти");
						tooltipLine.text = resultB;
					}
				}

				if (item.type == ItemID.ObsidianHelm ||
				    item.type == ItemID.ObsidianShirt ||
				    item.type == ItemID.ObsidianPants)
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("+2 defense\n5% increased rogue damage and critical strike chance\nGrants immunity to fire blocks and temporary immunity to lava\nRogue stealth builds while not attacking and not moving, up to a max of 80\nOnce you have built max stealth, you will be able to perform a Stealth Strike\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed", "Увеличивает защиту на 2\nУвеличивает разбойный урон и шанс критического удара на 5%\nДарует невосприимчивость к огненным блокам и временную невосприимчивость к лаве\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 80\nПосле заполнения шкалы скрытности вы сможете выполнить скрытый удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения");
						tooltipLine.text = resultA;
					}
				}

				foreach (TooltipLine tooltipLine in tooltips)
				{
					string str = tooltipLine.text;
					string resultA = str.Replace("Current Charge: ", "Текущий заряд: ");
					tooltipLine.text = resultA;
				}

				foreach (TooltipLine tooltipLine2 in tooltips)
				{
					if (tooltipLine2.Name == "PrefixSSDmg")
					{
						string str = tooltipLine2.text;
						string resultA = str.Replace("% stealth strike damage", "% урона при скрытном ударе");
						tooltipLine2.text = resultA;
					}

					if (tooltipLine2.Name == "PrefixStealthGenBoost")
					{
						string str = tooltipLine2.text;
						string resultA = str.Replace("% stealth generation", "% регенерации скрытности");
						tooltipLine2.text = resultA;
					}

					if (item.prefix == 67)
					{
						if (tooltipLine2.Name == "PrefixAccCritChance")
						{
							tooltipLine2.text = "+1% шанс критического удара";
						}
					}

					if (item.prefix == 68)
					{
						if (tooltipLine2.Name == "PrefixAccCritChance")
						{
							tooltipLine2.text = "+3% шанс критического удара";
						}
					}
					
					if (item.accessory)
					{
						if (tooltipLine2.text == "+1 defense\n+0.25% damage reduction")
						{
							tooltipLine2.text = "+1 защиты\n+0.25% сопротивление урону";
						}

						if (tooltipLine2.text == "+2 defense\n+0.25% damage reduction")
						{
							tooltipLine2.text = "+2 защиты\n+0.25% сопротивление урону";
						}

						if (tooltipLine2.text == "+3 defense\n+0.25% damage reduction")
						{
							tooltipLine2.text = "+3 защиты\n+0.25% сопротивление урону";
						}

						if (tooltipLine2.text == "+2 defense\n+0.5% damage reduction")
						{
							tooltipLine2.text = "+2 защиты\n+0.5% сопротивление урону";
						}

						if (tooltipLine2.text == "+3 defense\n+0.5% damage reduction")
						{
							tooltipLine2.text = "+3 защиты\n+0.5% сопротивление урону";
						}

						if (tooltipLine2.text == "+4 defense\n+0.5% damage reduction")
						{
							tooltipLine2.text = "+4 защиты\n+0.5% сопротивление урону";
						}

						if (tooltipLine2.text == "+3 defense\n+0.75% damage reduction")
						{
							tooltipLine2.text = "+3 защиты\n+0.75% сопротивление урону";
						}

						if (tooltipLine2.text == "+4 defense\n+0.75% damage reduction")
						{
							tooltipLine2.text = "+4 защиты\n+0.75% сопротивление урону";
						}

						if (tooltipLine2.text == "+6 defense\n+0.75% damage reduction")
						{
							tooltipLine2.text = "+6 защиты\n+0.75% сопротивление урону";
						}

						if (tooltipLine2.text == "+4 defense\n+1% damage reduction")
						{
							tooltipLine2.text = "+4 защиты\n+1% сопротивление урону";
						}

						if (tooltipLine2.text == "+6 defense\n+1% damage reduction")
						{
							tooltipLine2.text = "+6 защиты\n+1% сопротивление урону";
						}

						if (tooltipLine2.text == "+8 defense\n+1% damage reduction")
						{
							tooltipLine2.text = "+8 защиты\n+1% сопротивление урону";
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
								line1.text = "Ближние и разбойные атаки накладывают на противников эффект «Яд»";
								return;
							case 1353:
								line1.text = "Ближние и разбойные атаки накладывают на врагов проклятый огонь";
								return;
							case 1354:
								line1.text = "Ближние и разбойные атаки поджигают врагов";
								return;
							case 1355:
								line1.text = "При ближних и разбойных атаках враги оставляют больше золота";
								return;
							case 1356:
								line1.text = "Ближние и разбойные атаки снижают защиту врагов";
								return;
							case 1357:
								line1.text = "Ближние и разбойные атаки накладывают на врагов запутанность";
								return;
							case 1358:
								line1.text = "Ближние и разбойные атаки вызывают появление конфетти";
								return;
							case 1359:
								line1.text = "Ближние и разбойные атаки отравляют врагов";
								return;
							case 88:
								line1.text = "Обеспечивает светом при ношении\nОбеспечивает небольшим количеством света в бездне";
								return;
							case 1326:
								line1.text = "Телепортирует на позицию мыши\nТелепортация отключена пока активен эффект состояния хаоса";
								return;
							case 3032:
								line1.text = "Возможность впитывать бесконечное количество воды\nНельзя использовать в бездне";
								return;
							case 3062:
								line1.text = "Призывает сердце, которое даёт свет\nОбеспечивает небольшим количеством света в бездне";
								return;
							case 115:
								line1.text = "Создаёт магическую теневую светящуюся сферу\nОбеспечивает небольшим количеством света в бездне";
								return;
							case 3043:
								line1.text = "Призывает волшебный фонарь, который показывает ближайшее сокровище\nОбеспечивает небольшим количеством света в бездне";
								return;
							case 1303:
								line1.text = "Даёт свет под водой\nОбеспечивает небольшим количеством света в бездне";
								return;
							case 425:
								line1.text = "Призывает фею\nОбеспечивает умеренным количеством света в бездне";
								return;
							case 3856:
								line1.text = "Призывает огонёк, который даёт свет\nОбеспечивает умеренным количеством света в бездне";
								return;
							case 1183:
								line1.text = "Призывает духа, который даёт свет\nОбеспечивает большим количеством света в бездне";
								return;
							case 268:
								line1.text = "Значительно увеличивает возможность дыхания под водой\nУмеренно уменьшает потерю дыхания в бездне";
								return;
							case 497:
								line1.text = "При входе в воду превращает владельца в амфибию\nЗначительно уменьшает потерю дыхания в бездне";
								return;
							case 861:
								line1.text = "Ночью превращает владельца в оборотня, а в воде - в амфибию\nЗначительно уменьшает потерю дыхания в бездне";
								return;
							case 3224:
								line1.text = "Получаемый урон снижен на 10%";
								return;
							case 536:
								line1.text = "Увеличивает отбрасывание в ближнем бою\nУвеличивает истинный урон ближнего боя на 10%";
								return;
							case 1503:
								line1.text = "Снижает магический урон на 20%";
								return;
							case 3797:
								line1.text = "Увеличивает ваше максимальное количество стражников и снижает использование маны на 10%\nУвеличивает урон миньонов на 30%";
								return;
							case 3798:
								line1.text = "Увеличивает магический урон на 10%";
								return;
							case 3799:
								line1.text = "Увеличивает скорость передвижения на 20%";
								return;
							case 3800:
								line1.text = "Увеличивает ваше максимальное количество стражников и ускоряет регенерацию здоровья\nУвеличивает урон миньонов на 30% и шанс критического удара ближнего боя на 20%";
								return;
							case 3801:
								line1.text = "Увеличивает урон ближнего боя на 15%";
								return;
							case 3802:
								line1.text = "Увеличивает скорость передвижения на 20%";
								return;
							case 3803:
								line1.text = "Увеличивает ваше максимальное количество стражников и увеличивает шанс критического стрелкового удара на 10%\nУвеличивает урон миньонов на 30%";
								return;
							case 3804:
								line1.text = "Увеличивает стрелковый урон на 20%";
								return;
							case 3805:
								line1.text = "Увеличивает скорость передвижения на 20%";
								return;
							case 3806:
								line1.text = "Увеличивает ваше максимальное количество стражников и скорость атаки ближнего боя на 20%\nУвеличивает урон миньонов на 30% и шанс критического удара ближнего боя на 10%";
								return;
							case 3807:
								line1.text = "Увеличивает урон ближнего боя на 20%";
								return;
							case 3808:
								line1.text = "Увеличивает скорость передвижения на 20%";
								return;
							case 3880:
								line1.text = "Увеличивает ваше максимальное количество стражников\nУвеличивает урон ближнего боя, скорость атаки ближнего боя и шанс критического удара ближнего боя на 20%\nУвеличивает урон миньонов на 60%";
								return;
							case 3882:
								line1.text = "Увеличивает скорость передвижения на 20%";
								return;
							case 3879:
								line1.text = "Увеличивает скорость передвижения на 20%";
								return;
							case 3871:
								line1.text = "Увеличивает ваше максимальное количество стражников и увеличивает урон миньонов на 60%\nНа 20% увеличивается шанс критического удара ближнего боя";
								return;
							case 3872:
								line1.text = "Значительно ускоряет регенерацию здоровья";
								return;
							case 3873:
								line1.text = "Увеличивает скорость передвижения на 30%";
								return;
							case 1321:
								line1.text = "Увеличивает урон стрел на 10% и значительно увеличивает скорость стрел";
								return;
							case 297:
								line1.text = "Дарует невидимость\nУсиливает определённые характеристики при использовании определённых видов разбойного оружия";
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
								line2.text = "5 единицы защиты\nУвеличивает разбойный шанс критического удара на 3%";
								return;
							case 3189:
								line2.text = "4 единицы защиты\nУвеличивает скорость снарядов разбойника на 3%";
								return;
							case 3266:
								line2.text = "4 единицы защиты\nУвеличивает разбойный урон на 3%";
								return;
							case 3267:
								line2.text = "5 единицы защиты\nУвеличивает разбойный шанс критического удара на 3%";
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
								line3.text = "Даёт свет под водой\nОбеспечивает небольшим количеством света в бездне";
								return;
							case 1861:
								line3.text = "Даёт свет под водой и увеличивает подвижность на льду\nОбеспечивает небольшим количеством света в бездне\nУмеренно снижает потерю дыхания в бездне";
								return;
							case 3577:
								line3.text = "'Я знаю, о чём ты думаешь…'\nОбеспечивает большим количеством света в бездне";
								return;
							case 3110:
								line3.text = "Немного увеличивает все характеристики\nЗначительно уменьшает потерю дыхания в бездне";
								return;
							case 3874:
								line3.text = "Увеличивает урон миньонов на 60%, магический урон и шанс критического удара на 25%";
								return;
							case 3877:
								line3.text = "Увеличивает урон миньонов на 60% и увеличивает стрелковый шанс критического удара на 10%\nУвеличивает стрелковый урон на 25%";
								return;
							case 897:
								line3.text = "Увеличивает отбрасывание в ближнем бою\nУвеличивает скорость ближнего боя на 12%\nУвеличивает урон ближнего боя на 10%";
								return;
							case 936:
								line3.text = "Увеличивает отбрасывание в ближнем бою\nУвеличивает урон и скорость ближнего боя на 12%\nУвеличивает урон ближнего боя на 10%";
								return;
						}
					}

					TooltipLine line4 = tooltips.FirstOrDefault(tooltip =>
						tooltip.mod == "Terraria" && tooltip.Name == "BuffTime");
					if (line4 != null)
					{
						switch (item.type)
						{
							case 298:
								line4.text = "Длительность 5 мин.\nОбеспечивает умеренным количеством света в бездне";
								return;
							case 291:
								line4.text = "Длительность 2 мин.\nЗначительно уменьшает потерю дыхания в бездне";
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
								line6.text = "Можно надеть\nДальность: 18.87\nСкорость вылета: 13\nСкорость притягивания: 11";
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
								line8.text = "Материал\nМожет добывать улиблумовую руду";
								return;
						}
					}

					TooltipLine line9 = tooltips.FirstOrDefault(tooltip => tooltip.mod == "Terraria" && tooltip.Name == "HealLife");
					if (line9 != null)
					{
						switch (item.type)
						{
							case 1134:
								line9.text = "Восстанавливает 80 ед. здоровья\nДарует бафф Мёд на 2 минуты";
								return;
						}
					}
				}
			}
		}
	}
}
