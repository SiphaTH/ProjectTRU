using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Items
{
	public class DeathModItems : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			Mod calamity = ModLoader.GetMod("CalamityMod");
			
			if (calamity != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (CalamityRuTranslate.TRuConfig.CalamityTranslation)
				{
					if (item.type == calamity.ItemType("CelestialTracers"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Being hit for over 200 damage will make you immune for an extended period of time\nProvides heat protection in Death Mode", "Получив более 200 единиц урона сделает вас неуязвимым в течении длительного промежутка времени\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("ElysianTracers"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Temporary immunity to lava\nProvides heat protection in Death Mode", "Временная невосприимчивость к лаве\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("ElysianWings"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Temporary immunity to lava and 40% increased movement speed\nProvides heat protection in Death Mode", "Временная невосприимчивость к лаве; увеличивает скорость передвижения на 40%\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("SoulofCryogen"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Icicles rain down as you fly\nProvides heat and cold protection in Death Mode", "Сосульки обрушиваются, пока вы летите\nОбеспечивает защитой от жары и холода в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("Popo"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Transforms the holder into a snowman\nProvides heat and cold protection in Death Mode", "Превращает носителя в снеговика\nОбеспечивает защитой от жары и холода в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("AmbrosialAmpoule"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Most bee/hornet enemies and projectiles do 75% damage to you\nProvides cold protection in Death Mode", "Большинство пчёл/шершней и их снарядов наносят вам только 75% урона\nОбеспечивает защитой от холода в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("AngelTreads"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Temporary immunity to lava\nProvides heat protection in Death Mode", "Временная невосприимчивость к лаве\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("BlazingCore"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Provides a moderate amount of light in the Abyss\nProvides heat and cold protection in Death Mode", "Обеспечивает умеренным количеством света в бездне\nОбеспечивает защитой от жары и холода в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}
					
					if (item.type == calamity.ItemType("FrigidBulwark"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("The shell becomes more powerful when below 15% life and reduces damage even further\nProvides heat and cold protection in Death Mode", "Панцирь становится сильнее и ещё больше снижает урон, когда здоровье ниже 15%\nОбеспечивает защитой от жары и холода в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("FrostBarrier"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("You are immune to the chilled debuff\nProvides heat and cold protection in Death Mode", "Вы невосприимчивы к дебаффу «Охлаждение»\nОбеспечивает защитой от жары и холода в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("FrostFlare"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Provides heat and cold protection in Death Mode\nRevengeance drop", "Обеспечивает защитой от жары и холода в режиме Смерти\nПредмет режима Месть");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("InfinityBoots"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Temporary immunity to lava\nProvides heat protection in Death Mode", "Временная невосприимчивость к лаве\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("PermafrostsConcoction"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("You are encased in an ice barrier for 3 seconds when revived\nProvides heat and cold protection in Death Mode", "Вы находитесь в ледяном барьере в течение 3 секунд после возрождения\nОбеспечивает защитой от жары и холода в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("RampartofDeities"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("The shell becomes more powerful when below 15% life and reduces damage even further\nProvides heat and cold protection in Death Mode", "Панцирь становится сильнее и ещё больше снижает урон, когда здоровье ниже 15%\nОбеспечивает защитой от жары и холода в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("Sponge"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Enemy attacks will have part of their damage absorbed and used to heal you\nProvides cold protection in Death Mode", "Часть урона вражеских атак будет поглощена и использована для исцеления вас\nОбеспечивает защитой от холода в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("TheAmalgam"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("You have a damaging aura that envenoms nearby enemies and increased movement in liquids\nProvides heat protection in Death Mode", "Увеличивает скорость передвижение в жидкостях, а также у вас есть разрушающая аура, которая отравляет ближайших врагов\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("TheCamper"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Provides a small amount of light in the Abyss\nProvides cold protection in Death Mode", "Обеспечивает небольшим количеством света в бездне\nОбеспечивает защитой от холода в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("VoidofExtinction"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Temporary immunity to lava, greatly reduces lava burn damage, and 25% increased damage while in lava\nProvides heat protection in Death Mode", "Временная невосприимчивость к лаве; значительно уменьшает урон от ожога лавы и увеличивает урон на 25%, находясь в лаве\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("YharimsInsignia"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Increased melee knockback\nProvides heat protection in Death Mode", "Увеличивает отбрасывание ближнего боя\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("AtaxiaHeadgear"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Reduces ammo usage by 25%, temporary immunity to lava, and immunity to fire damage\nProvides heat protection in Death Mode", "25% шанс не использовать боеприпасы; временная невосприимчивость к лаве и невосприимчивость к урону от огня\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("AtaxiaHelm"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Temporary immunity to lava and immunity to fire damage\nProvides heat protection in Death Mode", "Временная невосприимчивость к лаве и невосприимчивость к урону от огня\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("AtaxiaHelmet"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Temporary immunity to lava and immunity to fire damage\nProvides heat protection in Death Mode", "Временная невосприимчивость к лаве и невосприимчивость к урону от огня\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("AtaxiaHood"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Temporary immunity to lava and immunity to fire damage\nProvides heat protection in Death Mode", "Временная невосприимчивость к лаве и невосприимчивость к урону от огня\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("AtaxiaMask"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Temporary immunity to lava and immunity to fire damage\nProvides heat protection in Death Mode", "Увеличивает максимальный запас маны на 100; временная невосприимчивость к лаве и невосприимчивость к урону от огня\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("AuricTeslaBodyArmor"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("You will freeze enemies near you when you are struck\nProvides heat and cold protection in Death Mode", "Вы будете замораживать врагов рядом с вами после получения удара\nОбеспечивает защитой от жары и холода в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("BloodflareHelm"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("10% increased rogue damage and critical strike chance, 15% increased movement speed\nProvides heat protection in Death Mode", "Увеличивает разбойный урон и шанс критического удара на 10%, и скорость передвижения на 15%\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("BloodflareHelmet"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("+3 max minions\nProvides heat protection in Death Mode", "Увеличивает максимальное число миньонов на 3\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("BloodflareHornedHelm"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("10% increased ranged damage and critical strike chance\nProvides heat protection in Death Mode", "Увеличивает стрелковый урон и шанс критического удара на 10%\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("BloodflareHornedMask"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("10% increased magic damage and critical strike chance, +100 max mana, and 17% reduced mana usage\nProvides heat protection in Death Mode", "Увеличивает магический урон и шанс критического удара на 10%, максимальный запас маны на 100 и снижает расход маны на 17%\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("BloodflareMask"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("10% increased melee damage and critical strike chance\nProvides heat protection in Death Mode", "Увеличивает урон ближнего боя и шанс критического удара на 10%\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("TarragonHelm"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("10% increased melee damage and critical strike chance\nProvides heat protection in Death Mode", "Увеличивает урон ближнего боя и шанс критического удара на 10%\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("TarragonHelmet"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("5% increased damage reduction\nProvides heat protection in Death Mode", "Увеличивает сопротивление урону на 5%\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("TarragonHornedHelm"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("5% increased damage reduction and +3 max minions\nProvides heat protection in Death Mode", "Увеличивает сопротивление урону на 5% и максимальное число миньонов на 3\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("TarragonMask"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("5% increased damage reduction, +100 max mana, and 15% reduced mana usage\nProvides heat protection in Death Mode", "Увеличивает сопротивление урону на 5%, максимальный запас маны на 100 и снижает расход маны на 15%\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("TarragonVisage"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("5% increased damage reduction\nProvides heat protection in Death Mode", "Увеличивает сопротивление урону на 5%\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("XerocMask"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Temporary immunity to lava\nProvides heat protection in Death Mode", "Временная невосприимчивость к лаве\nОбеспечивает защитой от жары в режиме Смерти");
							tooltipLine.text = resultA;
						}
					}

					if (item.type == calamity.ItemType("RampartofDeities"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Taking damage grants boosted movement speed for a short time", "Получение урона увеличивает скорость передвижения на короткое время");
							string resultB = resultA.Replace("Causes stars to fall and gives increased immune time when damaged", "Заставляет падать звёзды и увеличивает время неуязвимости после получения урона");
							string resultC = resultB.Replace("Increases armor penetration by 20 and reduces the cooldown of healing potions", "Увеличивает пробивание брони на 20 и уменьшает перезарядку лечебных зелий");
							string resultD = resultC.Replace("Provides light underwater and provides a small amount of light in the abyss", "Обеспечивает светом под водой и небольшим количеством света в бездне");
							string resultE = resultD.Replace("Absorbs 25% of damage done to players on your team", "Поглощает 25% урона, нанесённого игрокам в вашей команде");
							string resultF = resultE.Replace("This effect is only active above 25% life", "Активно, только если здоровье выше 25%");
							string resultG = resultF.Replace("Grants immunity to knockback", "Дарует невосприимчивость к отбрасыванию");
							string resultH = resultG.Replace("Puts a shell around the owner when below 50% life that reduces damage", "Облачает владельца в панцирь, который снижает урон, когда здоровье ниже 50%");
							string resultI = resultH.Replace("The shell becomes more powerful when below 15% life and reduces damage even further", "Панцирь становится сильнее и ещё больше снижает урон, когда здоровье ниже 15%");
							string resultJ = resultI.Replace("Provides heat and cold protection in Death Mode", "Обеспечивает защитой от жары и холода в режиме Смерти");
							tooltipLine.text = resultJ;
						}
					}
					
					if (item.type == calamity.ItemType("PurifiedJam"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Makes you immune to all damage and most debuffs for 5 seconds", "Делает вас невосприимчивым ко всему урону и большинству дебаффов на 5 секунд");
							tooltipLine.text = resultA;
						}
					}
					
					if (item.type == calamity.ItemType("SunkenStew"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Only gives 37 seconds of Potion Sickness", "Накладывает дебафф «Послезельевая болезнь» на 37 секунд");
							tooltipLine.text = resultA;
						}
					}
					
					if (item.type == calamity.ItemType("ColdDivinity"))
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
