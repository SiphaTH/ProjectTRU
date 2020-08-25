using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityRuTranslate.ModOfRedemption.Items
{
	public class SetBonus : GlobalItem
	{
		public override string IsArmorSet(Item head, Item body, Item legs)
		{
			Mod redemption = ModLoader.GetMod("Redemption");
			if (redemption != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (head.type == redemption.ItemType("AncientWoodGarland") &&
				    body.type == redemption.ItemType("AncientWoodBody") &&
				    legs.type == redemption.ItemType("AncientWoodLeggings"))
				{
					return "AncientWoodGarland";
				}

				if (head.type == redemption.ItemType("AncientWoodHelm") &&
				    body.type == redemption.ItemType("AncientWoodBody") &&
				    legs.type == redemption.ItemType("AncientWoodLeggings"))
				{
					return "AncientWoodHelm";
				}

				if (head.type == redemption.ItemType("BloomDruidHood") &&
				    body.type == redemption.ItemType("BloomDruidBody") &&
				    legs.type == redemption.ItemType("BloomDruidLeggings"))
				{
					return "BloomDruidHood";
				}

				if (head.type == redemption.ItemType("CorruptedXenomiteHead") &&
				    body.type == redemption.ItemType("CorruptedXenomiteBody") &&
				    legs.type == redemption.ItemType("CorruptedXenomiteLeggings"))
				{
					return "CorruptedXenomiteHead";
				}

				if (head.type == redemption.ItemType("CreatorHead") &&
				    body.type == redemption.ItemType("CreatorBody") && 
				    legs.type == redemption.ItemType("CreatorLegs"))
				{
					return "CreatorHead";
				}

				if (head.type == redemption.ItemType("DragonLeadHelm") &&
				    body.type == redemption.ItemType("DragonLeadBody") &&
				    legs.type == redemption.ItemType("DragonLeadLeggings"))
				{
					return "DragonLeadHelm";
				}

				if (head.type == redemption.ItemType("DruidHood") && 
				    body.type == redemption.ItemType("DruidBody") &&
				    legs.type == redemption.ItemType("DruidLeggings"))
				{
					return "DruidHood";
				}

				if (head.type == redemption.ItemType("DryadGarland") &&
				    body.type == redemption.ItemType("DryadChestplate") &&
				    legs.type == redemption.ItemType("DryadLeggings"))
				{
					return "DryadGarland";
				}

				if (head.type == redemption.ItemType("EbonwoodDruidGarland") &&
				    body.type == redemption.ItemType("EbonwoodDruidBreastplate") &&
				    legs.type == redemption.ItemType("EbonwoodDruidLeggings"))
				{
					return "EbonwoodDruidGarland";
				}

				if (head.type == redemption.ItemType("GirusHeavyHead") &&
				    body.type == redemption.ItemType("GirusHeavyBody") &&
				    legs.type == redemption.ItemType("GirusHeavyLeggings"))
				{
					return "GirusHeavyHead";
				}

				if (head.type == redemption.ItemType("GirusHeavyHead2") &&
				    body.type == redemption.ItemType("GirusHeavyBody2") &&
				    legs.type == redemption.ItemType("GirusHeavyLeggings2"))
				{
					return "GirusHeavyHead2";
				}

				if (head.type == redemption.ItemType("GirusHeavyHead3") &&
				    body.type == redemption.ItemType("GirusHeavyBody3") &&
				    legs.type == redemption.ItemType("GirusHeavyLeggings3"))
				{
					return "GirusHeavyHead3";
				}

				if (head.type == redemption.ItemType("GirusHeavyHead4") &&
				    body.type == redemption.ItemType("GirusHeavyBody4") &&
				    legs.type == redemption.ItemType("GirusHeavyLeggings4"))
				{
					return "GirusHeavyHead4";
				}

				if (head.type == redemption.ItemType("GloomDruidCap") &&
				    body.type == redemption.ItemType("GloomDruidCapplate") &&
				    legs.type == redemption.ItemType("GloomDruidLeggings"))
				{
					return "GloomDruidCap";
				}

				if (head.type == redemption.ItemType("GodArmorHelm") && 
				    body.type == redemption.ItemType("GodArmor") &&
				    legs.type == redemption.ItemType("GodArmorLeggings"))
				{
					return "GodArmorHelm";
				}

				if (head.type == redemption.ItemType("IceDruidGarland") &&
				    body.type == redemption.ItemType("IceDruidBody") &&
				    legs.type == redemption.ItemType("IceDruidLeggings"))
				{
					return "IceDruidGarland";
				}

				if (head.type == redemption.ItemType("KaniteHelm") && 
				    body.type == redemption.ItemType("KaniteBody") &&
				    legs.type == redemption.ItemType("KaniteLeggings"))
				{
					return "KaniteHelm";
				}

				if (head.type == redemption.ItemType("KeepersCrown") &&
				    body.type == redemption.ItemType("KeepersChestplate") &&
				    legs.type == redemption.ItemType("KeepersLeggings"))
				{
					return "KeepersCrown";
				}

				if (head.type == redemption.ItemType("KeepersHelmet") &&
				    body.type == redemption.ItemType("KeepersChestplate") &&
				    legs.type == redemption.ItemType("KeepersLeggings"))
				{
					return "KeepersHelmet";
				}

				if (head.type == redemption.ItemType("KeepersMask") &&
				    body.type == redemption.ItemType("KeepersChestplate") &&
				    legs.type == redemption.ItemType("KeepersLeggings"))
				{
					return "KeepersMask";
				}

				if (head.type == redemption.ItemType("KeepersVisor") &&
				    body.type == redemption.ItemType("KeepersChestplate") &&
				    legs.type == redemption.ItemType("KeepersLeggings"))
				{
					return "KeepersVisor";
				}

				if (head.type == redemption.ItemType("LightSteelHelm1") &&
				    body.type == redemption.ItemType("LightSteelBody1") &&
				    legs.type == redemption.ItemType("LightSteelLeggings1"))
				{
					return "LightSteelHelm1";
				}

				if (head.type == redemption.ItemType("LightSteelHelm2") &&
				    body.type == redemption.ItemType("LightSteelBody2") &&
				    legs.type == redemption.ItemType("LightSteelLeggings2"))
				{
					return "LightSteelHelm2";
				}

				if (head.type == redemption.ItemType("LivingWoodGarland") &&
				    body.type == redemption.ItemType("LivingWoodBody") &&
				    legs.type == redemption.ItemType("LivingWoodLeggings"))
				{
					return "LivingWoodGarland";
				}

				if (head.type == redemption.ItemType("LivingWoodHelmet") &&
				    body.type == redemption.ItemType("LivingWoodBody") &&
				    legs.type == redemption.ItemType("LivingWoodLeggings"))
				{
					return "LivingWoodHelmet";
				}

				if (head.type == redemption.ItemType("OldXenomiteHead") &&
				    body.type == redemption.ItemType("OldXenomiteBody") &&
				    legs.type == redemption.ItemType("OldXenomiteLeggings"))
				{
					return "OldXenomiteHead";
				}

				if (head.type == redemption.ItemType("OldXenomiteHead") &&
				    body.type == redemption.ItemType("XenomiteBody") &&
				    legs.type == redemption.ItemType("XenomiteLeggings"))
				{
					return "OldXenomiteHead";
				}

				if (head.type == redemption.ItemType("PureIronHelm") &&
				    body.type == redemption.ItemType("PureIronArmour") &&
				    legs.type == redemption.ItemType("PureIronLeggings"))
				{
					return "PureIronHelm";
				}

				if (head.type == redemption.ItemType("ShadewoodDruidGarland") &&
				    body.type == redemption.ItemType("ShadewoodDruidBreastplate") &&
				    legs.type == redemption.ItemType("ShadewoodDruidLeggings"))
				{
					return "ShadewoodDruidGarland";
				}

				if (head.type == redemption.ItemType("Soul2Head") && 
				    body.type == redemption.ItemType("Soul2Body") &&
				    legs.type == redemption.ItemType("Soul2Leggings"))
				{
					return "Soul2Head";
				}

				if (head.type == redemption.ItemType("SoulHead") && 
				    body.type == redemption.ItemType("SoulBody") &&
				    legs.type == redemption.ItemType("SoulLeggings"))
				{
					return "SoulHead";
				}

				if (head.type == redemption.ItemType("UVHead") && 
				    body.type == redemption.ItemType("UVBody") &&
				    legs.type == redemption.ItemType("UVLeggings"))
				{
					return "UVHead";
				}

				if (head.type == redemption.ItemType("NightshadeHead") &&
				    body.type == redemption.ItemType("NightshadeBody") &&
				    legs.type == redemption.ItemType("NightshadeLegs"))
				{
					return "NightshadeHead";
				}

				if (head.type == redemption.ItemType("FlowerCrowns7_1") && 
				    body.type == ItemID.GoldChainmail && 
				    legs.type == ItemID.GoldGreaves)
				{
					return "FlowerCrowns7_1";
				}

				if (head.type == redemption.ItemType("FlowerCrowns7_2") && 
				    body.type == ItemID.GoldChainmail && 
				    legs.type == ItemID.GoldGreaves)
				{
					return "FlowerCrowns7_2";
				}

				if (head.type == redemption.ItemType("FlowerCrowns7_3") && 
				    body.type == ItemID.GoldChainmail && 
				    legs.type == ItemID.GoldGreaves)
				{
					return "FlowerCrowns7_3";
				}

				if (head.type == redemption.ItemType("FlowerCrowns8_1") && 
				    body.type == ItemID.PlatinumChainmail && 
				    legs.type == ItemID.PlatinumGreaves)
				{
					return "FlowerCrowns8_1";
				}

				if (head.type == redemption.ItemType("FlowerCrowns8_2") && 
				    body.type == ItemID.PlatinumChainmail && 
				    legs.type == ItemID.PlatinumGreaves)
				{
					return "FlowerCrowns8_2";
				}

				if (head.type == redemption.ItemType("FlowerCrowns8_3") && 
				    body.type == ItemID.PlatinumChainmail && 
				    legs.type == ItemID.PlatinumGreaves)
				{
					return "FlowerCrowns8_3";
				}

				if (head.type == redemption.ItemType("Garland1") && 
				    body.type == ItemID.CobaltBreastplate && 
				    legs.type == ItemID.CobaltLeggings)
				{
					return "Garland1";
				}

				if (head.type == redemption.ItemType("Garland2") && 
				    body.type == ItemID.PalladiumBreastplate && 
				    legs.type == ItemID.PalladiumLeggings)
				{
					return "Garland2";
				}

				if (head.type == redemption.ItemType("Garland3") && 
				    body.type == ItemID.MythrilChainmail && 
				    legs.type == ItemID.MythrilGreaves)
				{
					return "Garland3";
				}

				if (head.type == redemption.ItemType("Garland4") && 
				    body.type == ItemID.OrichalcumBreastplate && 
				    legs.type == ItemID.OrichalcumLeggings)
				{
					return "Garland4";
				}

				if (head.type == redemption.ItemType("Garland5") && 
				    body.type == ItemID.AdamantiteBreastplate && 
				    legs.type == ItemID.AdamantiteLeggings)
				{
					return "Garland5";
				}

				if (head.type == redemption.ItemType("Garland6") && 
				    body.type == ItemID.TitaniumBreastplate && 
				    legs.type == ItemID.TitaniumLeggings)
				{
					return "Garland6";
				}

				if (head.type == redemption.ItemType("AncientPowerSurgeHead") &&
				    body.type == redemption.ItemType("AncientPowerSurgeBody") &&
				    legs.type == redemption.ItemType("AncientPowerSurgeLeggings"))
				{
					return "AncientPowerSurgeHead";
				}

				if (head.type == redemption.ItemType("BloodShinkiteHead") &&
				    body.type == redemption.ItemType("BloodShinkiteBody") &&
				    legs.type == redemption.ItemType("BloodShinkiteLeggings"))
				{
					return "BloodShinkiteHead";
				}

				if (head.type == redemption.ItemType("CursedShinkiteHead") &&
				    body.type == redemption.ItemType("CursedShinkiteBody") &&
				    legs.type == redemption.ItemType("CursedShinkiteLeggings"))
				{
					return "CursedShinkiteHead";
				}

				if (head.type == redemption.ItemType("CursedThornHead") &&
				    body.type == redemption.ItemType("CursedThornBody") &&
				    legs.type == redemption.ItemType("CursedThornLeggings"))
				{
					return "CursedThornHead";
				}

				if (head.type == redemption.ItemType("ShadeHead") && 
				    body.type == redemption.ItemType("ShadeBody") &&
				    legs.type == redemption.ItemType("ShadeLeggings"))
				{
					return "ShadeHead";
				}

				if (head.type == redemption.ItemType("SmallShadeHead") && 
				    body.type == redemption.ItemType("SmallShadeBody") && 
				    legs.type == redemption.ItemType("SmallShadeLeggings"))
				{
					return "SmallShadeHead";
				}

				if (head.type == redemption.ItemType("XeniumCap") && 
				    body.type == redemption.ItemType("XeniumBody") && 
				    legs.type == redemption.ItemType("XeniumLeggings"))
				{
					return "XeniumCap";
				}

				if (head.type == redemption.ItemType("XeniumGarland") && 
				    body.type == redemption.ItemType("XeniumBody") && 
				    legs.type == redemption.ItemType("XeniumLeggings"))
				{
					return "XeniumGarland";
				}

				if (head.type == redemption.ItemType("XeniumHelm") && 
				    body.type == redemption.ItemType("XeniumBody") && 
				    legs.type == redemption.ItemType("XeniumLeggings"))
				{
					return "XeniumHelm";
				}

				if (head.type == redemption.ItemType("XeniumMask") && 
				    body.type == redemption.ItemType("XeniumBody") && 
				    legs.type == redemption.ItemType("XeniumLeggings"))
				{
					return "XeniumMask";
				}

				if (head.type == redemption.ItemType("XeniumVisor") && 
				    body.type == redemption.ItemType("XeniumBody") && 
				    legs.type == redemption.ItemType("XeniumLeggings"))
				{
					return "XeniumVisor";
				}
			}

			return "";
		}

		public override void UpdateArmorSet(Player player, string set)
		{
			if (ModLoader.GetMod("Redemption") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				switch (set)
				{
					case "AncientWoodGarland":
						player.setBonus = "Урон друида повышен на 8%, взмахи шестами ускорены, вы невосприимчивы к отравлению";
						break;
					case "AncientWoodHelm":
						player.setBonus = "Максимальное количество прислужников увеличено, вы невосприимчивы к отравлению";
						break;
					case "BloomDruidHood":
						player.setBonus = "При получении урона есть шанс выпустить взрывное семечко";
						break;
					case "CorruptedXenomiteHead":
						player.setBonus = "Максимальный запас маны увеличен на 50, скорость передвижения значительно повышена\nКритические удары выпускают призрачный кинжал, направляемый вашим курсором";
						break;
					case "CreatorHead":
						player.setBonus = "Вы окружены аурой природы, усиливающей союзников и ослабляющей противников";
						break;
					case "DragonLeadHelm":
						player.setBonus =
							"Вы невосприимчивы к лаве\nВас окружает кольцо огня, поджигающее противников при контакте";
						break;
					case "DruidHood":
						player.setBonus = "Духи самонаводятся на противников";
						break;
					case "DryadGarland":
						player.setBonus = "Взмахи шестами ускорены";
						break;
					case "EbonwoodDruidGarland":
						player.setBonus =
							"Метание из мешочков с семенами ускорено и эффект шипов\nВ Искажении срок жизни растения повышается на 10%";
						break;
					case "GirusHeavyHead":
						player.setBonus =
							"Противники с большей вероятностью атакуют вас, скорость передвижения снижена\nСопротивление урону повышается на 8%\nПризывает маленького щитового дрона, который появляется, когда снаряд противника летит в игрока\nКогда снаряд попадает в щит, он выпускает разряд и отражает его\nЩит имеет 500 здоровья. Если его разрушили, то он вновь активируется через 10 секунд";
						break;
					case "GirusHeavyHead2":
						player.setBonus =
							"Противники с большей вероятностью атакуют вас, позволяет скрыться\nСопротивление урону повышается на 8%\nПризывает маленького снайперского дрона, который, при приближении противника, будет стрелять пулями из вашего инвентаря в направление курсора";
						break;
					case "GirusHeavyHead3":
						player.setBonus =
							"Противники с большей вероятностью атакуют вас, усиливает характеристики маны\nСопротивление урону повышается на 8%\nПризывает медузного дрона\nЛюбого противника внутри ауры бьёт током, наносящим урон и оглушающим на одну секунду\nБоссы и противники, не получающие отбрасывание, не подвержены этому";
						break;
					case "GirusHeavyHead4":
						player.setBonus =
							"Противники с большей вероятностью атакуют вас, максимальное количество прислужников увеличивается на 1\nСопротивление урону повышается на 8%\nПризывает маленький штурмовой везделёт, атакующий противников";
						break;
					case "GloomDruidCap":
						player.setBonus = "Вы невосприимчивы к отбрасыванию\nЗрение в темноте улучшено";
						break;
					case "GodArmorHelm":
						player.setBonus =
							"'Ойсус наделил вас силой'\nВы испускаете ауру света\nПробивание брони увеличивается на 50\nПротивники с большей вероятностью атакуют вас\nВы невосприимчивы к отбрасыванию\nВы невосприимчивы к большинству отрицательных эффектов";
						break;
					case "IceDruidGarland":
						player.setBonus =
							"Мешочки с семенами накладывают ледяной огонь и дополнительная подвижность на льду";
						break;
					case "KaniteHelm":
						player.setBonus = "Защита увеличена на 1";
						break;
					case "KeepersCrown":
						player.setBonus = "Максимальное количество прислужников увеличено на 1";
						break;
					case "KeepersHelmet":
						player.setBonus = "Скорость оружия ближнего боя повышена на 6%";
						break;
					case "KeepersMask":
						player.setBonus = "Максимальный запас маны увеличен на 40 и затраты маны снижены на 8%";
						break;
					case "KeepersVisor":
						player.setBonus = "Стрелковый урон повышен на 6%";
						break;
					case "LightSteelHelm1":
						player.setBonus = "Значительно повышает скорость и повышает сопротивление урону на 4%";
						break;
					case "LightSteelHelm2":
						player.setBonus = "Значительно повышает скорость и повышает сопротивление урону на 4%";
						break;
					case "LivingWoodGarland":
						player.setBonus = "Урон друида повышен на 7%, вы невосприимчивы к отравлению";
						break;
					case "LivingWoodHelmet":
						player.setBonus = "Вы невосприимчивы к отравлению, за вас сражается призванная птица";
						break;
					case "OldXenomiteHead":
						player.setBonus =
							"Вы невосприимчивы к ксеномитной инфекции и радиоактивным осадкам\nБроня излучает свет\nКритические удары имеют шанс выпустить в направление вашего курсора взрыв ксеномитных осколков";
						break;
					case "PureIronHelm":
						player.setBonus = "Вы невосприимчивы к большинству отрицательных эффектов, связанных с холодом";
						break;
					case "ShadewoodDruidGarland":
						player.setBonus =
							"Метание из мешочков с семенами ускорено и эффект шипов\nВ Багрянце срок жизни растения повышается на 10%";
						break;
					case "Soul2Head":
						player.setBonus =
							"Увеличивает максимальное количество призываемых духов на 1\nВы излучаете ауру света";
						break;
					case "SoulHead":
						player.setBonus = "Увеличивает максимальное количество призываемых духов на 1";
						break;
					case "UVHead":
						player.setBonus =
							"Во время дня броня переходит в защитный режим - значительно повышается защита и сопротивление урону\nВо время ночи броня переходит в наступательный режим - значительно повышается урон и шанс критического удара друида";
						break;
					case "NightshadeHead":
						player.setBonus =
							"Неподвижность дает вам невидимость, повышая стрелковые способности и снижая агрессию противников";
						break;
					case "FlowerCrowns7_1":
						player.setBonus = "Урон друида повышен на 15%";
						break;
					case "FlowerCrowns7_2":
						player.setBonus = "Урон друида повышен на 15%";
						break;
					case "FlowerCrowns7_3":
						player.setBonus = "Урон друида повышен на 15%";
						break;
					case "FlowerCrowns8_1":
						player.setBonus = "Урон друида повышен на 15%";
						break;
					case "FlowerCrowns8_2":
						player.setBonus = "Урон друида повышен на 15%";
						break;
					case "FlowerCrowns8_3":
						player.setBonus = "Урон друида повышен на 15%";
						break;
					case "Garland1":
						player.setBonus = "Запуск заклинаний шестов ускорен";
						break;
					case "Garland2":
						player.setBonus =
							"Запуск заклинаний шестов ускорен\nВосстановление здоровья значительно усилено";
						break;
					case "Garland3":
						player.setBonus = "Запуск заклинаний шестов ускорен, метание из мешочков с семенами ускорено";
						break;
					case "Garland4":
						player.setBonus =
							"Запуск заклинаний шестов ускорен, метание из мешочков с семенами ускорено\nНа вашу цель, для дополнительного урона, падают цветочные лепестки";
						break;
					case "Garland5":
						player.setBonus =
							"Запуск заклинаний шестов ускорен, метание из мешочков с семенами ускорено, скорость стрельбы духов повышена";
						break;
					case "Garland6":
						player.setBonus =
							"Запуск заклинаний шестов ускорен, метание из мешочков с семенами ускорено, скорость стрельбы духов повышена\nBriefly become invulnerable after striking an enemy";
						break;
					case "AncientPowerSurgeHead":
						player.setBonus =
							"Нанесение урона имеет 10% шанс запустить в противников самонаводящуюся сферу энергии\nУрон прислужников и магии повышены на 8% (пока не в режиме силового всплеска)\nШанс критического магического удара повышен на 6%\nПри получении урона вы накапливаете в своей броне энергию\nПри достижении заряда в 300 единиц, вы на 7 секунд перейдёте в режим силового всплеска\n--Во время силового всплеска--\nУрон прислужников и магии повышены на 25%\nВаше магическое оружие не потребляет ману\nПериод неуязвимости после получения урона дольше";
						break;
					case "BloodShinkiteHead":
						player.setBonus =
							"Нанесение урона противникам имеет шанс сгенерировать целебные кровавые сферы\nИгроки, коснувшиеся сферы, восстановят здоровье";
						break;
					case "CursedShinkiteHead":
						player.setBonus = "Нанесение урона имеет шанс поджечь противников проклятым пламенем";
						break;
					case "CursedThornHead":
						player.setBonus =
							"Когда у вас более 30% здоровья, сопротивление урону повышается на 10%\nКогда у вас менее 30% здоровья, сопротивление урону повышается на 15%\nУрон ближнего боя и стрелковый повышены на 8%\nШансы критического удара ближнего боя и стрелкового повышены а 6%\nСкорость оружия ближнего боя повышена на 10%\nКритические удары вызывают у цели поднимающийся шип";
						break;
					case "ShadeHead":
						player.setBonus =
							"При получении урона есть шанс высвободить теневые души, наносящие противникам урон и накладывающие на союзников положительные эффекты";
						break;
					case "SmallShadeHead":
						player.setBonus = "Атаки накладывают 'бездушность'";
						break;
					case "XeniumCap":
						player.setBonus =
							"Вы невосприимчивы к заражению, радиоактивный осадкам и зараженной воде\nМаксимальное количество прислужников увеличено на 3\nЧем больше призвано прислужников тем мощнее восстановление здоровья, максимум до 10";
						break;
					case "XeniumGarland":
						player.setBonus =
							"Вы невосприимчивы к заражению, радиоактивный осадкам и зараженной воде\nПри необходимости вы автоматически используете зелья маны";
						break;
					case "XeniumHelm":
						player.setBonus =
							"Вы невосприимчивы к заражению, радиоактивный осадкам и зараженной воде\nКогда вы близки к смерти, формируется барьер, повышающий сопротивление урону на 14%";
						break;
					case "XeniumMask":
						player.setBonus =
							"Вы невосприимчивы к заражению, радиоактивный осадкам и зараженной воде\nУвеличивает максимальный запас маны на 100\nУвеличивает радиус подбора звезд маны\nЧем меньше у вас здоровья, тем выше шанс критического магического удара";
						break;
					case "XeniumVisor":
						player.setBonus =
							"Вы невосприимчивы к заражению, радиоактивный осадкам и зараженной воде\nПока у вас полное здоровье, шанс критического стрелкового удара повышается на 50%";
						break;
				}
			}
		}
	}
}