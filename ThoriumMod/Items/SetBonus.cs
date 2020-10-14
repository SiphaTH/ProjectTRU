using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ThoriumMod.Items
{
	public class SetBonus : GlobalItem
	{
		public override string IsArmorSet(Item head, Item body, Item legs)
		{
			Mod thorium = ModLoader.GetMod("ThoriumMod");

			if (thorium != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (CalamityRuTranslate.TRuConfig.ThoriumTranslation)
				{
					if (head.type == thorium.ItemType("WhisperingHood") &&
					    body.type == thorium.ItemType("WhisperingTabard") &&
					    legs.type == thorium.ItemType("WhisperingLeggings"))
					{
						return "Whispering";
					}

					if (head.type == thorium.ItemType("BulbHood") && body.type == thorium.ItemType("BulbChestplate") &&
					    legs.type == thorium.ItemType("BulbLeggings"))
					{
						return "Bulb";
					}

					if (head.type == thorium.ItemType("DangerHelmet") && body.type == thorium.ItemType("DangerMail") &&
					    legs.type == thorium.ItemType("DangerGreaves"))
					{
						return "Danger";
					}

					if (head.type == thorium.ItemType("FlightMask") && body.type == thorium.ItemType("FlightMail") &&
					    legs.type == thorium.ItemType("FlightBoots"))
					{
						return "Flight";
					}

					if (head.type == thorium.ItemType("YewWoodaHelmet") &&
					    body.type == thorium.ItemType("YewWoodBreastgaurd") &&
					    legs.type == thorium.ItemType("YewWoodLeggings"))
					{
						return "YewWood";
					}

					if (head.type == thorium.ItemType("BerserkerMask") &&
					    body.type == thorium.ItemType("BerserkerBreastplate") &&
					    legs.type == thorium.ItemType("BerserkerGreaves"))
					{
						return "Berserker";
					}

					if (head.type == thorium.ItemType("BronzeHelmet") &&
					    body.type == thorium.ItemType("BronzeBreastplate") &&
					    legs.type == thorium.ItemType("BronzeGreaves"))
					{
						return "Bronze";
					}

					if (head.type == thorium.ItemType("hDarksteelFaceGuard") &&
					    body.type == thorium.ItemType("iDarksteelBreastPlate") &&
					    legs.type == thorium.ItemType("jDarksteelGreaves"))
					{
						return "Darksteel";
					}

					if (head.type == thorium.ItemType("DragonMask") &&
					    body.type == thorium.ItemType("DragonBreastplate") &&
					    legs.type == thorium.ItemType("DragonGreaves"))
					{
						return "Dragon";
					}

					if (head.type == thorium.ItemType("GeodeHelmet") &&
					    body.type == thorium.ItemType("GeodeChestplate") &&
					    legs.type == thorium.ItemType("GeodeGreaves"))
					{
						return "Geode";
					}

					if (head.type == thorium.ItemType("GraniteHelmet") &&
					    body.type == thorium.ItemType("GraniteChestGuard") &&
					    legs.type == thorium.ItemType("GraniteGreaves"))
					{
						return "Granite";
					}

					if (head.type == thorium.ItemType("HarbingerHelmet") &&
					    body.type == thorium.ItemType("HarbingerChestGuard") &&
					    legs.type == thorium.ItemType("HarbingerGreaves"))
					{
						return "Harbinger";
					}

					if (head.type == thorium.ItemType("MagmaHelmet") &&
					    body.type == thorium.ItemType("MagmaChestGuard") &&
					    legs.type == thorium.ItemType("MagmaGreaves"))
					{
						return "Magma";
					}

					if (head.type == thorium.ItemType("hSandStoneHelmet") &&
					    body.type == thorium.ItemType("iSandStoneMail") &&
					    legs.type == thorium.ItemType("jSandStoneGreaves"))
					{
						return "SandStone";
					}

					if (head.type == thorium.ItemType("BlueKnightHelmet") &&
					    body.type == thorium.ItemType("BlueKnightArmor") &&
					    legs.type == thorium.ItemType("BlueKnightGreaves"))
					{
						return "BlueKnight";
					}

					if (head.type == thorium.ItemType("GlitteringHelmet") &&
					    body.type == thorium.ItemType("GlitteringChestplate") &&
					    legs.type == thorium.ItemType("GlitteringGreaves"))
					{
						return "Glittering";
					}

					if (head.type == thorium.ItemType("TideTurnerHelmet") &&
					    body.type == thorium.ItemType("TideTurnerBreastplate") &&
					    legs.type == thorium.ItemType("TideTurnerGreaves"))
					{
						return "TideTurnerHelmet";
					}

					if (head.type == thorium.ItemType("TideTurnersGaze") &&
					    body.type == thorium.ItemType("TideTurnerBreastplate") &&
					    legs.type == thorium.ItemType("TideTurnerGreaves"))
					{
						return "TideTurnersGaze";
					}

					if (head.type == thorium.ItemType("PyromancerCowl") &&
					    body.type == thorium.ItemType("PyromancerTabard") &&
					    legs.type == thorium.ItemType("PyromancerLeggings"))
					{
						return "PyromancerCowl";
					}

					if (head.type == thorium.ItemType("PyroSummonHat") &&
					    body.type == thorium.ItemType("PyromancerTabard") &&
					    legs.type == thorium.ItemType("PyromancerLeggings"))
					{
						return "PyroSummonHat";
					}

					if (head.type == thorium.ItemType("IcyBandana") && body.type == thorium.ItemType("IcyMail") &&
					    legs.type == thorium.ItemType("IcyGreaves"))
					{
						return "Icy";
					}

					if (head.type == thorium.ItemType("DurasteelHelmet") &&
					    body.type == thorium.ItemType("DurasteelChestplate") &&
					    legs.type == thorium.ItemType("DurasteelGreaves"))
					{
						return "Durasteel";
					}

					if (head.type == thorium.ItemType("SteelHelmet") &&
					    body.type == thorium.ItemType("SteelChestplate") &&
					    legs.type == thorium.ItemType("SteelGreaves"))
					{
						return "Steel";
					}

					if (head.type == thorium.ItemType("TitanHeadgear") &&
					    body.type == thorium.ItemType("TitanBreastplate") &&
					    legs.type == thorium.ItemType("TitanGreaves"))
					{
						return "TitanHeadgear";
					}

					if (head.type == thorium.ItemType("TitanHelmet") &&
					    body.type == thorium.ItemType("TitanBreastplate") &&
					    legs.type == thorium.ItemType("TitanGreaves"))
					{
						return "TitanHelmet";
					}

					if (head.type == thorium.ItemType("TitanMask") &&
					    body.type == thorium.ItemType("TitanBreastplate") &&
					    legs.type == thorium.ItemType("TitanGreaves"))
					{
						return "TitanMask";
					}

					if (head.type == thorium.ItemType("FleshMask") && body.type == thorium.ItemType("FleshBody") &&
					    legs.type == thorium.ItemType("FleshLegs"))
					{
						return "Flesh";
					}

					if (head.type == thorium.ItemType("ThoriumHelmet") &&
					    body.type == thorium.ItemType("ThoriumMail") && legs.type == thorium.ItemType("ThoriumGreaves"))
					{
						return "Thorium";
					}

					if (head.type == thorium.ItemType("ValadiumHelmet") &&
					    body.type == thorium.ItemType("ValadiumBreastPlate") &&
					    legs.type == thorium.ItemType("ValadiumGreaves"))
					{
						return "Valadium";
					}

					if (head.type == thorium.ItemType("DemonBloodHelmet") &&
					    body.type == thorium.ItemType("DemonBloodBreastPlate") &&
					    legs.type == thorium.ItemType("DemonBloodGreaves"))
					{
						return "DemonBlood";
					}

					if (head.type == thorium.ItemType("LodeStoneFaceGuard") &&
					    body.type == thorium.ItemType("LodeStoneChestGaurd") &&
					    legs.type == thorium.ItemType("LodeStoneShinGaurds"))
					{
						return "LodeStone";
					}

					if (head.type == thorium.ItemType("DreamWeaversHood") &&
					    body.type == thorium.ItemType("DreamWeaversTabard") &&
					    legs.type == thorium.ItemType("DreamWeaversTreads"))
					{
						return "DreamWeaversHood";
					}

					if (head.type == thorium.ItemType("DreamWeaversHelmet") &&
					    body.type == thorium.ItemType("DreamWeaversTabard") &&
					    legs.type == thorium.ItemType("DreamWeaversTreads"))
					{
						return "DreamWeaversHelmet";
					}

					if (head.type == thorium.ItemType("OmniArablastHood") &&
					    body.type == thorium.ItemType("OmniBody") && legs.type == thorium.ItemType("OmniGreaves"))
					{
						return "OmniArablastHood";
					}

					if (head.type == thorium.ItemType("OmniMarkHead") && body.type == thorium.ItemType("OmniBody") &&
					    legs.type == thorium.ItemType("OmniGreaves"))
					{
						return "OmniMarkHead";
					}

					if (head.type == thorium.ItemType("BalladeerHat") &&
					    body.type == thorium.ItemType("BalladeerShirt") &&
					    legs.type == thorium.ItemType("BalladeerBoots"))
					{
						return "Balladeer";
					}

					if (head.type == thorium.ItemType("BardCap") && body.type == thorium.ItemType("BardChest") &&
					    legs.type == thorium.ItemType("BardLeggings"))
					{
						return "Bard";
					}

					if (head.type == thorium.ItemType("CyberPunkHeadset") &&
					    body.type == thorium.ItemType("CyberPunkSuit") &&
					    legs.type == thorium.ItemType("CyberPunkLeggings"))
					{
						return "CyberPunk";
					}

					if (head.type == thorium.ItemType("JestersMask") && body.type == thorium.ItemType("JestersShirt") &&
					    legs.type == thorium.ItemType("JestersLeggings"))
					{
						return "JestersMask";
					}

					if (head.type == thorium.ItemType("JestersMask2") &&
					    body.type == thorium.ItemType("JestersShirt2") &&
					    legs.type == thorium.ItemType("JestersLeggings2"))
					{
						return "JestersMask2";
					}

					if (head.type == thorium.ItemType("MaestroWig") && body.type == thorium.ItemType("MaestroSuit") &&
					    legs.type == thorium.ItemType("MaestroLeggings"))
					{
						return "Maestro";
					}

					if (head.type == thorium.ItemType("MarchingBandCap") &&
					    body.type == thorium.ItemType("MarchingBandUniform") &&
					    legs.type == thorium.ItemType("MarchingBandLeggings"))
					{
						return "Marching";
					}

					if (head.type == thorium.ItemType("NoblesHat") && body.type == thorium.ItemType("NoblesJerkin") &&
					    legs.type == thorium.ItemType("NoblesLeggings"))
					{
						return "Nobles";
					}

					if (head.type == thorium.ItemType("OrnateHat") && body.type == thorium.ItemType("OrnateJerkin") &&
					    legs.type == thorium.ItemType("OrnateLeggings"))
					{
						return "Ornate";
					}

					if (head.type == thorium.ItemType("DepthDiverHelmet") &&
					    body.type == thorium.ItemType("DepthDiverChestplate") &&
					    legs.type == thorium.ItemType("DepthDiverGreaves"))
					{
						return "DepthDiver";
					}

					if (head.type == thorium.ItemType("NagaSkinMask") &&
					    body.type == thorium.ItemType("NagaSkinSuit") && legs.type == thorium.ItemType("NagaSkinTail"))
					{
						return "NagaSkin";
					}

					if (head.type == thorium.ItemType("TideHunterCap") &&
					    body.type == thorium.ItemType("TideHunterChestpiece") &&
					    legs.type == thorium.ItemType("TideHunterLeggings"))
					{
						return "TideHunter";
					}

					if (head.type == thorium.ItemType("CelestialCrown") &&
					    body.type == thorium.ItemType("CelestialVestment") &&
					    legs.type == thorium.ItemType("CelestialLeggings"))
					{
						return "Celestial";
					}

					if (head.type == thorium.ItemType("DewBinderMask") &&
					    body.type == thorium.ItemType("DewBinderBreastplate") &&
					    legs.type == thorium.ItemType("DewBinderGreaves"))
					{
						return "DewBinder";
					}

					if (head.type == thorium.ItemType("EbonHood") && body.type == thorium.ItemType("EbonCloak") &&
					    legs.type == thorium.ItemType("EbonLeggings"))
					{
						return "Ebon";
					}

					if (head.type == thorium.ItemType("FallenPaladinFacegaurd") &&
					    body.type == thorium.ItemType("FallenPaladinCuirass") &&
					    legs.type == thorium.ItemType("FallenPaladinGreaves"))
					{
						return "FallenPaladin";
					}

					if (head.type == thorium.ItemType("HallowedPaladinHelmet") &&
					    body.type == thorium.ItemType("HallowedPaladinBreastplate") &&
					    legs.type == thorium.ItemType("HallowedPaladinLeggings"))
					{
						return "HallowedPaladin";
					}

					if (head.type == thorium.ItemType("IridescentHelmet") &&
					    body.type == thorium.ItemType("IridescentMail") &&
					    legs.type == thorium.ItemType("IridescentGreaves"))
					{
						return "Iridescent";
					}

					if (head.type == thorium.ItemType("LifeWeaverHood") &&
					    body.type == thorium.ItemType("LifeWeaverGarment") &&
					    legs.type == thorium.ItemType("LifeWeaverLeggings"))
					{
						return "LifeWeaver";
					}

					if (head.type == thorium.ItemType("NoviceClericCowl") &&
					    body.type == thorium.ItemType("NoviceClericTabard") &&
					    legs.type == thorium.ItemType("NoviceClericPants"))
					{
						return "NoviceCleric";
					}

					if (head.type == thorium.ItemType("TemplarsCirclet") &&
					    body.type == thorium.ItemType("TemplarsTabard") &&
					    legs.type == thorium.ItemType("TemplarsLeggings"))
					{
						return "Templars";
					}

					if (head.type == thorium.ItemType("WarlockHood") && body.type == thorium.ItemType("WarlockGarb") &&
					    legs.type == thorium.ItemType("WarlockLeggings"))
					{
						return "Warlock";
					}

					if (head.type == thorium.ItemType("MalignantCap") && body.type == thorium.ItemType("MalignantRobe"))
					{
						return "Malignant";
					}

					if (head.type == thorium.ItemType("FungusHat") && body.type == thorium.ItemType("FungusGuard") &&
					    legs.type == thorium.ItemType("FungusLeggings"))
					{
						return "Fungus";
					}

					if (head.type == thorium.ItemType("PlagueDoctersMask") &&
					    body.type == thorium.ItemType("PlagueDoctersGarb") &&
					    legs.type == thorium.ItemType("PlagueDoctersLeggings"))
					{
						return "PlagueDocters";
					}

					if (head.type == thorium.ItemType("ShadeMasterMask") &&
					    body.type == thorium.ItemType("ShadeMasterGarb") &&
					    legs.type == thorium.ItemType("ShadeMasterTreads"))
					{
						return "ShadeMaster";
					}

					if (head.type == thorium.ItemType("WhiteDwarfMask") &&
					    body.type == thorium.ItemType("WhiteDwarfGuard") &&
					    legs.type == thorium.ItemType("WhiteDwarfGreaves"))
					{
						return "WhiteDwarf";
					}

					if (head.type == thorium.ItemType("TerrariumHelmet") &&
					    body.type == thorium.ItemType("TerrariumBreastPlate") &&
					    legs.type == thorium.ItemType("TerrariumGreaves"))
					{
						return "Terrarium";
					}

					if (head.type == thorium.ItemType("LifeBloomMask") &&
					    body.type == thorium.ItemType("LifeBloomMail") &&
					    legs.type == thorium.ItemType("LifeBloomLeggings"))
					{
						return "LifeBloom";
					}

					if (head.type == thorium.ItemType("LivingWoodMask") &&
					    body.type == thorium.ItemType("LivingWoodChestguard") &&
					    legs.type == thorium.ItemType("LivingWoodBoots"))
					{
						return "LivingWood";
					}

					if (head.type == thorium.ItemType("MeteorMask") && body.type == 124 && legs.type == 125)
					{
						return "Meteor";
					}

					if (head.type == thorium.ItemType("SpiritTrapperHelmet") &&
					    body.type == thorium.ItemType("SpiritTrapperCuirass") &&
					    legs.type == thorium.ItemType("SpiritTrapperGreaves"))
					{
						return "SpiritTrapperHelmet";
					}

					if (head.type == thorium.ItemType("OceanHelmet") &&
					    body.type == thorium.ItemType("OceanChestGuard") &&
					    legs.type == thorium.ItemType("OceanGreaves"))
					{
						return "Ocean";
					}

					if (head.type == thorium.ItemType("ConduitHelmet") &&
					    body.type == thorium.ItemType("ConduitSuit") &&
					    legs.type == thorium.ItemType("ConduitLeggings"))
					{
						return "Conduit";
					}

					if (head.type == thorium.ItemType("CryomancersCrown") &&
					    body.type == thorium.ItemType("CryomancersTabard") &&
					    legs.type == thorium.ItemType("CryomancersLeggings"))
					{
						return "Cryomancers";
					}

					if (head.type == thorium.ItemType("WhiteKnightMask") &&
					    body.type == thorium.ItemType("WhiteKnightTabard") &&
					    legs.type == thorium.ItemType("WhiteKnightLeggings"))
					{
						return "WhiteKnight";
					}

					if (head.type == thorium.ItemType("LichCowl") && body.type == thorium.ItemType("LichCarapace") &&
					    legs.type == thorium.ItemType("LichTalon"))
					{
						return "Lich";
					}

					if (head.type == thorium.ItemType("IllumiteMask") &&
					    body.type == thorium.ItemType("IllumiteChestplate") &&
					    legs.type == thorium.ItemType("IllumiteGreaves"))
					{
						return "Illumite";
					}

					if (head.type == thorium.ItemType("RallyHat") &&
					    body.type == thorium.ItemType("RhapsodistChestWoofer") &&
					    legs.type == thorium.ItemType("RhapsodistBoots"))
					{
						return "RallyHat";
					}

					if (head.type == thorium.ItemType("SoloistHat") &&
					    body.type == thorium.ItemType("RhapsodistChestWoofer") &&
					    legs.type == thorium.ItemType("RhapsodistBoots"))
					{
						return "SoloistHat";
					}

					if (head.type == thorium.ItemType("SilkCap") && body.type == thorium.ItemType("SilkTabard") &&
					    legs.type == thorium.ItemType("SilkLeggings"))
					{
						return "SilkCap";
					}

					if (head.type == thorium.ItemType("SilkHat") && body.type == thorium.ItemType("SilkTabard") &&
					    legs.type == thorium.ItemType("SilkLeggings"))
					{
						return "SilkHat";
					}

					if (head.type == thorium.ItemType("DreadSkull") &&
					    body.type == thorium.ItemType("DreadChestPlate") &&
					    legs.type == thorium.ItemType("DreadGreaves"))
					{
						return "Dread";
					}

					if (head.type == thorium.ItemType("FeralSkinHead") &&
					    body.type == thorium.ItemType("FeralSkinChest") &&
					    legs.type == thorium.ItemType("FeralSkinLegs"))
					{
						return "FeralSkin";
					}

					if (head.type == thorium.ItemType("AstroHelmet") && body.type == thorium.ItemType("AstroSuit") &&
					    legs.type == thorium.ItemType("AstroBoots"))
					{
						return "Astro";
					}

					if (head.type == thorium.ItemType("SpiritTrapperMask") &&
					    body.type == thorium.ItemType("SpiritTrapperCuirass") &&
					    legs.type == thorium.ItemType("SpiritTrapperGreaves"))
					{
						return "SpiritTrapperMask";
					}
				}
			}

			return "";
		}

		public override void UpdateArmorSet(Player player, string set)
		{
			if (ModLoader.GetMod("ThoriumMod") == null || LanguageManager.Instance.ActiveCulture != GameCulture.Russian)
			{
				if (CalamityRuTranslate.TRuConfig.ThoriumTranslation)
				{
					switch (set)
					{
						case "Whispering":
							player.setBonus = "Вы иногда рождаете щупальце глубинной энергии, которая атакует ближайших врагов\nИх удары похищают у врага 1 единицу маны и здоровья\nВы можете иметь максимум 6 щупалец";
							break;
						case "Bulb":
							player.setBonus = "У ваших магических атак есть шанс отравить врага облаком спор";
							break;
						case "Danger":
							player.setBonus = "Вы невосприимчивы к большинству наносящих урон эффектов";
							break;
						case "Flight":
							player.setBonus = "Вы можете недолго летать";
							break;
						case "YewWood":
							player.setBonus = "После четырех некритических ударов, ваша следующая атака дальнего боя нанесет 150% урона";
							break;
						case "Berserker":
							player.setBonus = "Урон увеличивается на 15% за каждые 25% потерянного здоровья";
							break;
						case "Bronze":
							player.setBonus = "Метательный урон имеет 20% шанс нанести пронзающий удар молнией";
							break;
						case "Darksteel":
							player.setBonus = "Ничто не сможет вас остановить! Позволяет делать рывки, просто дважды нажмите в нужном направлении!";
							break;
						case "Dragon":
							player.setBonus = "Ваши атаки имеют шанс высвободить взрыв драконьего огня";
							break;
						case "Geode":
							player.setBonus = "Вы можете обнаруживать руду, сундуки и прочие сокровища";
							break;
						case "Granite":
							player.setBonus = "Вы невосприимчивы к сильному жару и отбрасыванию, но ваша скорость передвижения значительно снижена";
							break;
						case "Harbinger":
							player.setBonus = "Максимальный запас маны повышен на 50%\nЕсли у вас более 75% маны, вы становитесь нестабильным";
							break;
						case "Magma":
							player.setBonus = "Пламя обволакивает вашу броню и оружие ближнего боя\nУдары по горящему врагу увеличивают силу горения";
							break;
						case "SandStone":
							player.setBonus = "Ветра пустынь окутывают ваши ботинки, даруя песчаный двойной прыжок";
							break;
						case "BlueKnight":
							player.setBonus = "Неплохо выглядишь!";
							break;
						case "Glittering":
							player.setBonus = "Неплохо выглядишь!";
							break;
						case "TideTurnerHelmet":
							player.setBonus = "Нажатие клавиши 'Armor Ability' окутает вас непроницаемым пузырем\nПока пузырь активен, весь получаемый урон трансформируется в лечение";
							break;
						case "TideTurnersGaze":
							player.setBonus = "Метательный урон имеет шанс 20% выпустить вокруг вас водные самонаводящиеся кинжалы";
							break;
						case "PyromancerCowl":
							player.setBonus = "Ваши магические атаки сильно поджигают врагов и обладают перекидывающимся эффектом";
							break;
						case "PyroSummonHat":
							player.setBonus = "Весь урон призванных существ оставляют продолжительный ожог, который наносит значительный урон с течением времени";
							break;
						case "Icy":
							player.setBonus = "Вас окружает льдистая аура, которая на короткое время замораживает ближайших врагов";
							break;
						case "Durasteel":
							player.setBonus = "Получаемый урон снижен на 10%";
							break;
						case "Steel":
							player.setBonus = "Получаемый урон снижен на 8%";
							break;
						case "TitanHeadgear":
							player.setBonus = "Увеличивает наносимый урон на 18%!";
							break;
						case "TitanHelmet":
							player.setBonus = "Увеличивает наносимый урон на 18%!";
							break;
						case "TitanMask":
							player.setBonus = "Увеличивает наносимый урон на 18%!";
							break;
						case "Flesh":
							player.setBonus = "Урон по раненным врагам имеет 10% шанс выбить кусок плоти, который при подборе повышает урон и количество здоровья";
							break;
						case "Thorium":
							player.setBonus = "Урон повышен на 10%";
							break;
						case "Valadium":
							player.setBonus = "Измените гравитацию, нажав ВВЕРХ. Пока вы перевернуты, стрелковый урон повышается на 15%!";
							break;
						case "DemonBlood":
							player.setBonus = "Максимальный запас здоровья увеличен на 100";
							break;
						case "LodeStone":
							player.setBonus = "Сопротивление урону повышается на 6% за каждые 25% потерянного здоровья";
							break;
						case "DreamWeaversHood":
							player.setBonus = "Нажатие клавиши 'Armor Ability' затратит 200 маны и переместит вас в Сновидение\nНаходясь в Сновидении, исцеленные союзники ненадолго станут неуязвимыми и будут излечены от всех негативных эффектов";
							break;
						case "DreamWeaversHelmet":
							player.setBonus = "Нажатие клавиши 'Armor Ability' затратит 200 маны и прогнет саму ткань реальности\nВраги сильно замедляются и получают на 15% больше урона\nСоюзники получают значительно увеличенную скорость передвижения и атаки";
							break;
						case "OmniArablastHood":
							player.setBonus = "Ваш урон имеет 10% шанс полностью дублировать себя и нанести на 15% больше урона";
							break;
						case "OmniMarkHead":
							player.setBonus = "Ваш стрелковый урон имеет 5% шанс уничтожить пораженную цель\nБоссы не подвержены этому эффекту, пока их здоровье более 5% от максимального";
							break;
						case "Balladeer":
							player.setBonus = "Увеличивает длительность эффектов вдохновения на 6 секунд\nКаждый уникальный имеющийся у вас эффект вдохновения увеличивает ваш симфонический урон на 5%\nКаждый уникальный имеющийся эффект вдохновения повышает восстановления вдохновения на 2%";
							break;
						case "Bard":
							player.setBonus = "Ваши эффекты вдохновения продержатся на 3 секунды дольше";
							break;
						case "CyberPunk":
							player.setBonus = "Нажатие клавиши 'Armor Ability' проведет вас сквозь 4 состояния, дающие усиления:\nКрасный - Вы и ближайшие союзники получаете 'Плоский урон II' и 'Урон II'\nЗеленый - Вы и ближайшие союзники получаете 'Скорость передвижения II' и 'Время полета II'\nФиолетовый - Вы и ближайшие союзники получаете 'Максимум ресурсов II' и 'Регенерация ресурсов II'\nСиний - Вы и ближайшие союзники получаете 'Защиту II' и 'Сопротивление урону II'";
							break;
						case "JestersMask":
							player.setBonus = "Симфонические критические удары вызывают над вашей головой звон колокольчика, ненадолго замедляя всех ближайших врагов";
							break;
						case "JestersMask2":
							player.setBonus = "Симфонические критические удары вызывают над вашей головой звон колокольчика, ненадолго замедляя всех ближайших врагов";
							break;
						case "Maestro":
							player.setBonus = "Нажатие клавиши 'Armor Ability' вызывает хор играющих музыку призраков\nПризраки быстро наносят урон ближайшим врагам с помощью медных, духовых, струнных и ударных инструментов";
							break;
						case "Marching":
							player.setBonus = "Во время битвы за вами будет следовать цепочка из радужных символов и оглушать врагов";
							break;
						case "Nobles":
							player.setBonus = "Ноты вдохновения восстанавливают в два раза больше вдохновения и ненадолго увеличивают симфонический урон";
							break;
						case "Ornate":
							player.setBonus = "Симфонические критические удары поднимают уровень эффектов вдохновения до 4-ого\nЭтот эффект может быть активирован только раз в 5 секунд";
							break;
						case "DepthDiver":
							player.setBonus = "Эффекты вещей комплекта также применяются и на вас";
							break;
						case "NagaSkin":
							player.setBonus = "Каждые 75 потраченной маны на короткое время резко увеличат ваш магический урон и скорость чтения заклинаний";
							break;
						case "TideHunter":
							player.setBonus = "Критические выстрелы выпускают всплеск пены, замедляющий ближайших врагов";
							break;
						case "Celestial":
							player.setBonus = "Нажмите клавишу 'Armor Ability', назначенную в настройках управления, чтобы создать вокруг вашего курсора невероятно мощную ауру лечения\nСоздание этой ауры стоит 150 маны";
							break;
						case "DewBinder":
							player.setBonus = "Заклинания исцеления на короткое время увеличивают максимальное здоровье исцеленного игрока на 50";
							break;
						case "Ebon":
							player.setBonus = "Усиливает лучезарные атаки с помощью темной энергии, заставляя их принять темную форму и наносить различные дебаффы";
							break;
						case "FallenPaladin":
							player.setBonus = "Получение удара лечит ближайших союзников на 15% от полученного урона";
							break;
						case "HallowedPaladin":
							player.setBonus = "Исцеляющие заклинания лечат дополнительные 5 очков здоровья";
							break;
						case "Iridescent":
							player.setBonus = "Ваш лучезарный урон имеет 15% шанс выпустить ослепительную вспышку света\nВспышка запутывает врагов и лечит ближайших союзников в зависимости от вашего бонуса лечения";
							break;
						case "LifeWeaver":
							player.setBonus = "Биотехнический дрон будет помогать вам в лечении союзников\nЛечит союзников равносильно вашей дополнительной регенерации от заклинаний";
							break;
						case "NoviceCleric":
							player.setBonus = "Каждые 5 секунд вы генерируете до 3 священных крестов\nКогда вы читаете лечащее заклинание, вместо маны используется крест";
							break;
						case "Templars":
							player.setBonus = "Если здоровье союзника ниже 50%, вы получаете повышенные способности к исцелению";
							break;
						case "Warlock":
							player.setBonus = "Лучезарные критические удары генерируют до 15 теневых сгустков\nНажатие клавиши 'Armor Ability' высвободит каждый сохраненный теневой сгусток в направлении вашего курсора";
							break;
						case "Malignant":
							player.setBonus = "Критические удары магией поджигают врагов пустотным пламенем\nТакже увеличивает скорость чтения заклинаний на 10%";
							break;
						case "Fungus":
							player.setBonus = "Урон, нанесенный врагам зараженным мицелием, повышен на 10%\nНанесение урона врагам, зараженным мицелием, ненадолго увеличивает скорость метания на 10%";
							break;
						case "PlagueDocters":
							player.setBonus = "Ваш чумной газ рассеивается в воздухе вдвое медленнее; ваши чумные реактивы наносят на 20% больше урона";
							break;
						case "ShadeMaster":
							player.setBonus = "Половина от получаемого урона размазывается на последующие 10 секунд";
							break;
						case "WhiteDwarf":
							player.setBonus = "Критические удары высвобождают вспышки цвета слоновой кости из космоса\nЭти вспышки наносят 0.1% от максимального показателя жизней цели в качестве урона";
							break;
						case "Terrarium":
							player.setBonus = "Энергия Террарии стремится защитить вас";
							break;
						case "LifeBloom":
							player.setBonus = "25% шанс, что атаки ваших прислужников слегка вылечат вас\nВы не можете вылечить более 50 единиц здоровья за 10 секунд";
							break;
						case "LivingWood":
							player.setBonus = "Увеличивает максимальное число прислужников на 1\nАтаки саженца живого дерева будут самонаводится на врагов";
							break;
						case "Meteor":
							player.setBonus = "Атаки призываемых существ имеют шанс высвободить плазму";
							break;
						case "SpiritTrapperHelmet":
							player.setBonus = "Увеличивает максимальное количество прислужников на 1\nУбийство врагов или продолжительное нанесение урона боссам, генерирует пучок душ\nПосле генерации 5 таких пучков, они моментально расходуются и лечат вас на 10 здоровья";
							break;
						case "Ocean":
							player.setBonus = "Позволяет дышать под водой";
							break;
						case "Conduit":
							player.setBonus = "Движение по кругу генерирует до 5 статических колец, каждое из которых генерирует защиту здоровья\nКогда кольцо полностью готово, энергетический пузырь защитит вас от 1 удара\nКогда пузырь блокирует атаку, электрический разряд атакует ближайших врагов";
							break;
						case "Cryomancers":
							player.setBonus = "Ваши магические атаки на 2 секунды замораживают врагов";
							break;
						case "WhiteKnight":
							player.setBonus = "Ваши магические удары имеют 33% шанс восполнить часть недостающей маны\nВы не можете восполнять более чем 100 маны каждые 10 секунд";
							break;
						case "Lich":
							player.setBonus = "Убитые враги оставляют фрагменты души\nКасание фрагмента душ на некоторое время сильно увеличит ваши скорости движения и броска";
							break;
						case "Illumite":
							player.setBonus = "Большая часть вашего оружия дальнего боя, приобретает особые свойства\nКаждые 5 выпущенных пуль, будут выпускают мульти-ударную иллюмитовую пулю\nКаждые 4 выпущенные стрелы, выпускают шквал иллюмитовой энергии\nКаждые 3 выпущенные ракеты, будут выпускают иллюмитовую ракету";
							break;
						case "RallyHat":
							player.setBonus = "Нажатие клавиши 'Armor Ability' дарует всем ближайшим союзникам каждый эффект вдохновения третьего уровня\nИспользование способности требует 20 вдохновения и перезаряжается 1 минуту";
							break;
						case "SoloistHat":
							player.setBonus = "Нажатие клавиши 'Armor Ability' дарует вам бесконечное вдохновение, сильно повышая симфонический урон и скорость игры на инструментах\nЭтот эффект действует 10 секунд, а затем 1 минуту перезаряжается";
							break;
						case "SilkCap":
							player.setBonus = "Магический урон повышен на 7%";
							break;
						case "SilkHat":
							player.setBonus = "Магический урон повышен на 7%";
							break;
						case "Dread":
							player.setBonus = "Ваши ботинки с невообразимой скоростью вибрируют, значительно повышая скорость передвижения\nВо время движения, урон ближнего боя и шанс критического удара возрастают";
							break;
						case "FeralSkin":
							player.setBonus = "Хорошо выглядишь!";
							break;
						case "Astro":
							player.setBonus = "Урон прислужников при попадании имеет шанс высвободить взрыв наносящей урон плазмы";
							break;
						case "SpiritTrapperMask":
							player.setBonus = "Увеличивает максимальное количество прислужников на 1\nУбийство противников, или продолжительное нанесение урона боссам, производит виспов\nПосле создания пяти виспов, они мгновенно поглощаются, исцеляя вам 10 единиц здоровья";
							break;
					}
				}
			}
		}
	}
}
