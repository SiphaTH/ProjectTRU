using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ElementsAwoken.Items
{
	public class SetBonus : GlobalItem
	{
		public override string IsArmorSet(Item head, Item body, Item legs)
		{
			Mod elementsAwoken = ModLoader.GetMod("ElementsAwoken");

			if (elementsAwoken != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (head.type == elementsAwoken.ItemType("CosmicalusVisor") &&
				    body.type == elementsAwoken.ItemType("CosmicalusBreastplate") &&
				    legs.type == elementsAwoken.ItemType("CosmicalusLeggings"))
				{
					return "Cosmicalus";
				}

				if (head.type == elementsAwoken.ItemType("EnergyWeaversHelm") &&
				    body.type == elementsAwoken.ItemType("EnergyWeaversBreastplate") &&
				    legs.type == elementsAwoken.ItemType("EnergyWeaversLeggings"))
				{
					return "EnergyWeavers";
				}

				if (head.type == elementsAwoken.ItemType("VoidWalkersGreatmask") &&
				    body.type == elementsAwoken.ItemType("VoidWalkersBreastplate") &&
				    legs.type == elementsAwoken.ItemType("VoidWalkersLeggings"))
				{
					return "VoidWalkersGreatmask";
				}

				if (head.type == elementsAwoken.ItemType("VoidWalkersHelm") &&
				    body.type == elementsAwoken.ItemType("VoidWalkersBreastplate") &&
				    legs.type == elementsAwoken.ItemType("VoidWalkersLeggings"))
				{
					return "VoidWalkersHelm";
				}

				if (head.type == elementsAwoken.ItemType("VoidWalkersHood") &&
				    body.type == elementsAwoken.ItemType("VoidWalkersBreastplate") &&
				    legs.type == elementsAwoken.ItemType("VoidWalkersLeggings"))
				{
					return "VoidWalkersHood";
				}

				if (head.type == elementsAwoken.ItemType("VoidWalkersVisage") &&
				    body.type == elementsAwoken.ItemType("VoidWalkersBreastplate") &&
				    legs.type == elementsAwoken.ItemType("VoidWalkersLeggings"))
				{
					return "VoidWalkersVisage";
				}

				if (head.type == elementsAwoken.ItemType("MechMask") &&
				    body.type == elementsAwoken.ItemType("MechBreastplate") &&
				    legs.type == elementsAwoken.ItemType("MechLeggings"))
				{
					return "Mech";
				}

				if (head.type == elementsAwoken.ItemType("GelticConquerorHelmet") &&
				    body.type == elementsAwoken.ItemType("GelticConquerorBreastplate") &&
				    legs.type == elementsAwoken.ItemType("GelticConquerorLeggings"))
				{
					return "GelticConqueror";
				}

				if (head.type == elementsAwoken.ItemType("ForgedMask") &&
				    body.type == elementsAwoken.ItemType("ForgedBreastplate") &&
				    legs.type == elementsAwoken.ItemType("ForgedGreaves"))
				{
					return "Forged";
				}

				if (head.type == elementsAwoken.ItemType("CrowsGreathelm") &&
				    body.type == elementsAwoken.ItemType("CrowsGreatplate") &&
				    legs.type == elementsAwoken.ItemType("CrowsGreatpants"))
				{
					return "Crows";
				}

				if (head.type == elementsAwoken.ItemType("EoitesHood") &&
				    body.type == elementsAwoken.ItemType("EoitesRobes") &&
				    legs.type == elementsAwoken.ItemType("EoitesLeggings"))
				{
					return "Eoites";
				}

				if (head.type == elementsAwoken.ItemType("AwokenWoodHelmet") &&
				    body.type == elementsAwoken.ItemType("AwokenWoodBreastplate") &&
				    legs.type == elementsAwoken.ItemType("AwokenWoodGreaves"))
				{
					return "AwokenWood";
				}

				if (head.type == elementsAwoken.ItemType("FireDemonsHelm") &&
				    body.type == elementsAwoken.ItemType("FireDemonsBreastplate") &&
				    legs.type == elementsAwoken.ItemType("FireDemonsLeggings"))
				{
					return "FireDemons";
				}

				if (head.type == elementsAwoken.ItemType("AridFalconHelm") &&
				    body.type == elementsAwoken.ItemType("AridBreastplate") &&
				    legs.type == elementsAwoken.ItemType("AridLeggings"))
				{
					return "AridFalconHelm";
				}

				if (head.type == elementsAwoken.ItemType("AridHat") &&
				    body.type == elementsAwoken.ItemType("AridBreastplate") &&
				    legs.type == elementsAwoken.ItemType("AridLeggings"))
				{
					return "AridHat";
				}

				if (head.type == elementsAwoken.ItemType("AridHeadgear") &&
				    body.type == elementsAwoken.ItemType("AridBreastplate") &&
				    legs.type == elementsAwoken.ItemType("AridLeggings"))
				{
					return "AridHeadgear";
				}

				if (head.type == elementsAwoken.ItemType("AridHood") &&
				    body.type == elementsAwoken.ItemType("AridBreastplate") &&
				    legs.type == elementsAwoken.ItemType("AridLeggings"))
				{
					return "AridHood";
				}

				if (head.type == elementsAwoken.ItemType("AridWarriorMask") &&
				    body.type == elementsAwoken.ItemType("AridBreastplate") &&
				    legs.type == elementsAwoken.ItemType("AridLeggings"))
				{
					return "AridWarriorMask";
				}

				if (head.type == elementsAwoken.ItemType("ElementalMask") &&
				    body.type == elementsAwoken.ItemType("ElementalBreastplate") &&
				    legs.type == elementsAwoken.ItemType("ElementalLeggings"))
				{
					return "Elemental";
				}

				if (head.type == elementsAwoken.ItemType("EmpyreanHat") &&
				    body.type == elementsAwoken.ItemType("EmpyreanPlate") &&
				    legs.type == elementsAwoken.ItemType("EmpyreanLeggings"))
				{
					return "EmpyreanHat";
				}

				if (head.type == elementsAwoken.ItemType("EmpyreanHeadgear") &&
				    body.type == elementsAwoken.ItemType("EmpyreanPlate") &&
				    legs.type == elementsAwoken.ItemType("EmpyreanLeggings"))
				{
					return "EmpyreanHeadgear";
				}

				if (head.type == elementsAwoken.ItemType("EmpyreanHelmet") &&
				    body.type == elementsAwoken.ItemType("EmpyreanPlate") &&
				    legs.type == elementsAwoken.ItemType("EmpyreanLeggings"))
				{
					return "EmpyreanHelmet";
				}

				if (head.type == elementsAwoken.ItemType("EmpyreanMask") &&
				    body.type == elementsAwoken.ItemType("EmpyreanPlate") &&
				    legs.type == elementsAwoken.ItemType("EmpyreanLeggings"))
				{
					return "EmpyreanMask";
				}

				if (head.type == elementsAwoken.ItemType("EmpyreanVisage") &&
				    body.type == elementsAwoken.ItemType("EmpyreanPlate") &&
				    legs.type == elementsAwoken.ItemType("EmpyreanLeggings"))
				{
					return "EmpyreanVisage";
				}

				if (head.type == elementsAwoken.ItemType("VoidHelmet") &&
				    body.type == elementsAwoken.ItemType("VoidBreastplate") &&
				    legs.type == elementsAwoken.ItemType("VoidGreaves"))
				{
					return "Void";
				}

				if (head.type == elementsAwoken.ItemType("OceanicVisage") &&
				    body.type == elementsAwoken.ItemType("OceanicPlateMail") &&
				    legs.type == elementsAwoken.ItemType("OceanicLeggings"))
				{
					return "Oceanic";
				}

				if (head.type == elementsAwoken.ItemType("DragonmailGreathelm") &&
				    body.type == elementsAwoken.ItemType("DragonmailChestpiece") &&
				    legs.type == elementsAwoken.ItemType("DragonmailLeggings"))
				{
					return "DragonmailGreathelm";
				}

				if (head.type == elementsAwoken.ItemType("DragonmailHood") &&
				    body.type == elementsAwoken.ItemType("DragonmailChestpiece") &&
				    legs.type == elementsAwoken.ItemType("DragonmailLeggings"))
				{
					return "DragonmailHood";
				}

				if (head.type == elementsAwoken.ItemType("DragonmailMask") &&
				    body.type == elementsAwoken.ItemType("DragonmailChestpiece") &&
				    legs.type == elementsAwoken.ItemType("DragonmailLeggings"))
				{
					return "DragonmailMask";
				}

				if (head.type == elementsAwoken.ItemType("DragonmailVisage") &&
				    body.type == elementsAwoken.ItemType("DragonmailChestpiece") &&
				    legs.type == elementsAwoken.ItemType("DragonmailLeggings"))
				{
					return "DragonmailVisage";
				}

				if (head.type == elementsAwoken.ItemType("PutridMask") &&
				    body.type == elementsAwoken.ItemType("PutridBreastplate") &&
				    legs.type == elementsAwoken.ItemType("PutridLeggings"))
				{
					return "Putrid";
				}

				if (head.type == elementsAwoken.ItemType("ToyHelm") &&
				    body.type == elementsAwoken.ItemType("ToyBreastplate") &&
				    legs.type == elementsAwoken.ItemType("ToyLeggings"))
				{
					return "Toy";
				}

				if (head.type == elementsAwoken.ItemType("ComfyHood") &&
				    body.type == elementsAwoken.ItemType("ComfyShirt") &&
				    legs.type == elementsAwoken.ItemType("ComfyPants"))
				{
					return "Comfy";
				}
			}

			return "";
		}

		public override void UpdateArmorSet(Player player, string set)
		{
			if (ModLoader.GetMod("ElementsAwoken") == null ||
			    LanguageManager.Instance.ActiveCulture != GameCulture.Russian)
			{
				switch (set)
				{
					case "Cosmicalus":
						player.setBonus =
							"Призывает космическое кольцо, атакующее ближайших противников\nОстанавливает выкачивание рассудка в космосе";
						break;
					case "EnergyWeavers":
						player.setBonus = "Вы заряжаете энергию и запускаете ее в ближайших противников";
						break;
					case "VoidWalkersGreatmask":
						player.setBonus =
							"Нажмите клавишу 'Armour Ability', чтобы активировать ауру психоза\nАура психоза запутывает врагов и накладывает на них проклятие вымирания";
						break;
					case "VoidWalkersHelm":
						player.setBonus =
							"Нажмите клавишу 'Armour Ability', чтобы активировать ауру психоза\nАура психоза запутывает врагов и накладывает на них проклятие вымирания";
						break;
					case "VoidWalkersHood":
						player.setBonus =
							"Нажмите клавишу 'Armour Ability', чтобы активировать ауру психоза\nАура психоза запутывает врагов и накладывает на них проклятие вымирания";
						break;
					case "VoidWalkersVisage":
						player.setBonus =
							"Нажмите клавишу 'Armour Ability', чтобы активировать ауру психоза\nАура психоза запутывает врагов и накладывает на них проклятие вымирания";
						break;
					case "Mech":
						player.setBonus =
							"Урон повышен на 10%\nСкорость передвижения повышена на 35%\nШанс не потратить боеприпасы повышен на 17%\nПри ударе по вам, высвобождаются электрические дуги";
						break;
					case "GelticConqueror":
						player.setBonus =
							"Повышает высоту прыжка\nНейтрализует 75% урона от падения\nПри приземлении вы отскакиваете\nНажмите ВНИЗ, чтобы прекратить отскакивать - также это отменит нейтрализацию урона от падения";
						break;
					case "Forged":
						player.setBonus =
							"Дважды нажмите ВНИЗ, чтобы прикрепить себя к этому месту\nНажмите ВНИЗ еще раз, чтобы мгновенно вернуться к центру";
						break;
					case "Crows":
						player.setBonus = "При ударе по врагу его бьет зеленая молния\nМолния лечит игрока";
						break;
					case "Eoites":
						player.setBonus = "Магический урон повышен на 15%\nПолучаемый урон уменьшен еще на 10%";
						break;
					case "AwokenWood":
						player.setBonus =
							"После удара ваше восстановление здоровья сильно усиливается\nСтреляет в ближайших врагов листьями\nВраги с меньшей вероятностью атакуют вас\nДважды нажмите ВНИЗ, чтобы активировать 'ауру жизни', которая лечит союзников и городских жителей";
						break;
					case "FireDemons":
						player.setBonus = "Призывает демона, чтобы уничтожить ваших врагов";
						break;
					case "AridFalconHelm":
						player.setBonus = "Держа клавишу прыжка, дает небольшую левитацию";
						break;
					case "AridHat":
						player.setBonus = "Держа клавишу прыжка, дает небольшую левитацию";
						break;
					case "AridHeadgear":
						player.setBonus = "Держа клавишу прыжка, дает небольшую левитацию";
						break;
					case "AridHood":
						player.setBonus = "Держа клавишу прыжка, дает небольшую левитацию";
						break;
					case "AridWarriorMask":
						player.setBonus = "Держа клавишу прыжка, дает небольшую левитацию";
						break;
					case "Elemental":
						player.setBonus =
							"Если вас убили, то вы возрождаетесь с половиной здоровья\nПерезарядка этого эффекта занимает 45 секунд";
						break;
					case "EmpyreanHat":
						player.setBonus = "Вокруг вас бушуют бури";
						break;
					case "EmpyreanHeadgear":
						player.setBonus = "Вокруг вас бушуют бури";
						break;
					case "EmpyreanHelmet":
						player.setBonus = "Вокруг вас бушуют бури";
						break;
					case "EmpyreanMask":
						player.setBonus = "Вокруг вас бушуют бури";
						break;
					case "EmpyreanVisage":
						player.setBonus = "Вокруг вас бушуют бури";
						break;
					case "Void":
						player.setBonus = "Все снаряды имеют шанс немного исцелить вас";
						break;
					case "Oceanic":
						player.setBonus = "Получение более 25 урона разбрызгивает токсичную воду";
						break;
					case "DragonmailGreathelm":
						player.setBonus =
							"Атаки и снаряды ближнего боя накладывают драконий огонь\nМаксимальный запас здоровья увеличен на 50";
						break;
					case "DragonmailHood":
						player.setBonus =
							"Магические снаряды накладывают драконий огонь\nЧем меньше у вас здоровья. тем больше магический урон";
						break;
					case "DragonmailMask":
						player.setBonus =
							"Прислужники накладывают драконий огонь\nЧем больше у вас прислужников, тем меньше получаемый урон";
						break;
					case "DragonmailVisage":
						player.setBonus =
							"Стрелковые атаки накладывают драконий огонь\nСтрелковые атаки имеют шанс взорваться драконьим огнем";
						break;
					case "Putrid":
						player.setBonus =
							"Вы испускаете токсичную ауру\nНе двигаясь, вы испускаете больше ауры\nУвеличивает максимальное количество прислужников\nПрислужники имеют шанс отравить противника тяжелым ядом";
						break;
					case "Toy":
						player.setBonus = "При получении урона вы роняете кирпичи LEGO";
						break;
					case "Comfy":
						player.setBonus = "Пушистики больше не наносят вам урон";
						break;
				}
			}
		}
	}
}
