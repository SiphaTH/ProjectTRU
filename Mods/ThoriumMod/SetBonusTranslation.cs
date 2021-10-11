using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.ThoriumMod
{
	public class SetBonusTranslation : GlobalItem
	{
		public override bool Autoload(ref string name) => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

		public override string IsArmorSet(Item head, Item body, Item legs)
		{
			if (head.type == ModsCall.Thorium.ItemType("WhisperingHood") &&
			    body.type == ModsCall.Thorium.ItemType("WhisperingTabard") &&
			    legs.type == ModsCall.Thorium.ItemType("WhisperingLeggings"))
			{
				return "Whispering";
			}

			// if (head.type == ModsCall.Thorium.ItemType("BulbHood") && body.type == ModsCall.Thorium.ItemType("BulbChestplate") &&
			//     legs.type == ModsCall.Thorium.ItemType("BulbLeggings"))
			// {
			// 	return "Bulb";
			// }

			if (head.type == ModsCall.Thorium.ItemType("DangerHelmet") && body.type == ModsCall.Thorium.ItemType("DangerMail") &&
			    legs.type == ModsCall.Thorium.ItemType("DangerGreaves"))
			{
				return "Danger";
			}

			if (head.type == ModsCall.Thorium.ItemType("FlightMask") && body.type == ModsCall.Thorium.ItemType("FlightMail") &&
			    legs.type == ModsCall.Thorium.ItemType("FlightBoots"))
			{
				return "Flight";
			}

			if (head.type == ModsCall.Thorium.ItemType("YewWoodaHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("YewWoodBreastgaurd") &&
			    legs.type == ModsCall.Thorium.ItemType("YewWoodLeggings"))
			{
				return "YewWood";
			}

			if (head.type == ModsCall.Thorium.ItemType("BerserkerMask") &&
			    body.type == ModsCall.Thorium.ItemType("BerserkerBreastplate") &&
			    legs.type == ModsCall.Thorium.ItemType("BerserkerGreaves"))
			{
				return "Berserker";
			}

			if (head.type == ModsCall.Thorium.ItemType("BronzeHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("BronzeBreastplate") &&
			    legs.type == ModsCall.Thorium.ItemType("BronzeGreaves"))
			{
				return "Bronze";
			}

			if (head.type == ModsCall.Thorium.ItemType("hDarksteelFaceGuard") &&
			    body.type == ModsCall.Thorium.ItemType("iDarksteelBreastPlate") &&
			    legs.type == ModsCall.Thorium.ItemType("jDarksteelGreaves"))
			{
				return "Darksteel";
			}

			if (head.type == ModsCall.Thorium.ItemType("DragonMask") &&
			    body.type == ModsCall.Thorium.ItemType("DragonBreastplate") &&
			    legs.type == ModsCall.Thorium.ItemType("DragonGreaves"))
			{
				return "Dragon";
			}

			if (head.type == ModsCall.Thorium.ItemType("GeodeHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("GeodeChestplate") &&
			    legs.type == ModsCall.Thorium.ItemType("GeodeGreaves"))
			{
				return "Geode";
			}

			if (head.type == ModsCall.Thorium.ItemType("GraniteHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("GraniteChestGuard") &&
			    legs.type == ModsCall.Thorium.ItemType("GraniteGreaves"))
			{
				return "Granite";
			}

			if (head.type == ModsCall.Thorium.ItemType("HarbingerHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("HarbingerChestGuard") &&
			    legs.type == ModsCall.Thorium.ItemType("HarbingerGreaves"))
			{
				return "Harbinger";
			}

			if (head.type == ModsCall.Thorium.ItemType("MagmaHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("MagmaChestGuard") &&
			    legs.type == ModsCall.Thorium.ItemType("MagmaGreaves"))
			{
				return "Magma";
			}

			if (head.type == ModsCall.Thorium.ItemType("hSandStoneHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("iSandStoneMail") &&
			    legs.type == ModsCall.Thorium.ItemType("jSandStoneGreaves"))
			{
				return "SandStone";
			}

			if (head.type == ModsCall.Thorium.ItemType("BlueKnightHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("BlueKnightArmor") &&
			    legs.type == ModsCall.Thorium.ItemType("BlueKnightGreaves"))
			{
				return "BlueKnight";
			}

			if (head.type == ModsCall.Thorium.ItemType("GlitteringHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("GlitteringChestplate") &&
			    legs.type == ModsCall.Thorium.ItemType("GlitteringGreaves"))
			{
				return "Glittering";
			}

			if (head.type == ModsCall.Thorium.ItemType("TideTurnerHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("TideTurnerBreastplate") &&
			    legs.type == ModsCall.Thorium.ItemType("TideTurnerGreaves"))
			{
				return "TideTurnerHelmet";
			}

			if (head.type == ModsCall.Thorium.ItemType("TideTurnersGaze") &&
			    body.type == ModsCall.Thorium.ItemType("TideTurnerBreastplate") &&
			    legs.type == ModsCall.Thorium.ItemType("TideTurnerGreaves"))
			{
				return "TideTurnersGaze";
			}

			if (head.type == ModsCall.Thorium.ItemType("PyromancerCowl") &&
			    body.type == ModsCall.Thorium.ItemType("PyromancerTabard") &&
			    legs.type == ModsCall.Thorium.ItemType("PyromancerLeggings"))
			{
				return "PyromancerCowl";
			}

			if (head.type == ModsCall.Thorium.ItemType("PyroSummonHat") &&
			    body.type == ModsCall.Thorium.ItemType("PyromancerTabard") &&
			    legs.type == ModsCall.Thorium.ItemType("PyromancerLeggings"))
			{
				return "PyroSummonHat";
			}

			if (head.type == ModsCall.Thorium.ItemType("IcyBandana") && body.type == ModsCall.Thorium.ItemType("IcyMail") &&
			    legs.type == ModsCall.Thorium.ItemType("IcyGreaves"))
			{
				return "Icy";
			}

			if (head.type == ModsCall.Thorium.ItemType("DurasteelHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("DurasteelChestplate") &&
			    legs.type == ModsCall.Thorium.ItemType("DurasteelGreaves"))
			{
				return "Durasteel";
			}

			if (head.type == ModsCall.Thorium.ItemType("SteelHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("SteelChestplate") &&
			    legs.type == ModsCall.Thorium.ItemType("SteelGreaves"))
			{
				return "Steel";
			}

			if (head.type == ModsCall.Thorium.ItemType("TitanHeadgear") &&
			    body.type == ModsCall.Thorium.ItemType("TitanBreastplate") &&
			    legs.type == ModsCall.Thorium.ItemType("TitanGreaves"))
			{
				return "TitanHeadgear";
			}

			if (head.type == ModsCall.Thorium.ItemType("TitanHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("TitanBreastplate") &&
			    legs.type == ModsCall.Thorium.ItemType("TitanGreaves"))
			{
				return "TitanHelmet";
			}

			if (head.type == ModsCall.Thorium.ItemType("TitanMask") &&
			    body.type == ModsCall.Thorium.ItemType("TitanBreastplate") &&
			    legs.type == ModsCall.Thorium.ItemType("TitanGreaves"))
			{
				return "TitanMask";
			}

			// if (head.type == ModsCall.Thorium.ItemType("FleshMask") && body.type == ModsCall.Thorium.ItemType("FleshBody") &&
			//     legs.type == ModsCall.Thorium.ItemType("FleshLegs"))
			// {
			// 	return "Flesh";
			// }

			if (head.type == ModsCall.Thorium.ItemType("ThoriumHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("ThoriumMail") && legs.type == ModsCall.Thorium.ItemType("ThoriumGreaves"))
			{
				return "ThoriumMod";
			}

			if (head.type == ModsCall.Thorium.ItemType("ValadiumHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("ValadiumBreastPlate") &&
			    legs.type == ModsCall.Thorium.ItemType("ValadiumGreaves"))
			{
				return "Valadium";
			}

			if (head.type == ModsCall.Thorium.ItemType("DemonBloodHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("DemonBloodBreastPlate") &&
			    legs.type == ModsCall.Thorium.ItemType("DemonBloodGreaves"))
			{
				return "DemonBlood";
			}

			if (head.type == ModsCall.Thorium.ItemType("LodeStoneFaceGuard") &&
			    body.type == ModsCall.Thorium.ItemType("LodeStoneChestGaurd") &&
			    legs.type == ModsCall.Thorium.ItemType("LodeStoneShinGaurds"))
			{
				return "LodeStone";
			}

			if (head.type == ModsCall.Thorium.ItemType("DreamWeaversHood") &&
			    body.type == ModsCall.Thorium.ItemType("DreamWeaversTabard") &&
			    legs.type == ModsCall.Thorium.ItemType("DreamWeaversTreads"))
			{
				return "DreamWeaversHood";
			}

			if (head.type == ModsCall.Thorium.ItemType("DreamWeaversHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("DreamWeaversTabard") &&
			    legs.type == ModsCall.Thorium.ItemType("DreamWeaversTreads"))
			{
				return "DreamWeaversHelmet";
			}

			if (head.type == ModsCall.Thorium.ItemType("OmniArablastHood") &&
			    body.type == ModsCall.Thorium.ItemType("OmniBody") && legs.type == ModsCall.Thorium.ItemType("OmniGreaves"))
			{
				return "OmniArablastHood";
			}

			if (head.type == ModsCall.Thorium.ItemType("OmniMarkHead") && body.type == ModsCall.Thorium.ItemType("OmniBody") &&
			    legs.type == ModsCall.Thorium.ItemType("OmniGreaves"))
			{
				return "OmniMarkHead";
			}

			if (head.type == ModsCall.Thorium.ItemType("BalladeerHat") &&
			    body.type == ModsCall.Thorium.ItemType("BalladeerShirt") &&
			    legs.type == ModsCall.Thorium.ItemType("BalladeerBoots"))
			{
				return "Balladeer";
			}

			if (head.type == ModsCall.Thorium.ItemType("BardCap") && body.type == ModsCall.Thorium.ItemType("BardChest") &&
			    legs.type == ModsCall.Thorium.ItemType("BardLeggings"))
			{
				return "Bard";
			}

			if (head.type == ModsCall.Thorium.ItemType("CyberPunkHeadset") &&
			    body.type == ModsCall.Thorium.ItemType("CyberPunkSuit") &&
			    legs.type == ModsCall.Thorium.ItemType("CyberPunkLeggings"))
			{
				return "CyberPunk";
			}

			if (head.type == ModsCall.Thorium.ItemType("JestersMask") && body.type == ModsCall.Thorium.ItemType("JestersShirt") &&
			    legs.type == ModsCall.Thorium.ItemType("JestersLeggings"))
			{
				return "JestersMask";
			}

			if (head.type == ModsCall.Thorium.ItemType("JestersMask2") &&
			    body.type == ModsCall.Thorium.ItemType("JestersShirt2") &&
			    legs.type == ModsCall.Thorium.ItemType("JestersLeggings2"))
			{
				return "JestersMask2";
			}

			if (head.type == ModsCall.Thorium.ItemType("MaestroWig") && body.type == ModsCall.Thorium.ItemType("MaestroSuit") &&
			    legs.type == ModsCall.Thorium.ItemType("MaestroLeggings"))
			{
				return "Maestro";
			}

			if (head.type == ModsCall.Thorium.ItemType("MarchingBandCap") &&
			    body.type == ModsCall.Thorium.ItemType("MarchingBandUniform") &&
			    legs.type == ModsCall.Thorium.ItemType("MarchingBandLeggings"))
			{
				return "Marching";
			}

			if (head.type == ModsCall.Thorium.ItemType("NoblesHat") && body.type == ModsCall.Thorium.ItemType("NoblesJerkin") &&
			    legs.type == ModsCall.Thorium.ItemType("NoblesLeggings"))
			{
				return "Nobles";
			}

			if (head.type == ModsCall.Thorium.ItemType("OrnateHat") && body.type == ModsCall.Thorium.ItemType("OrnateJerkin") &&
			    legs.type == ModsCall.Thorium.ItemType("OrnateLeggings"))
			{
				return "Ornate";
			}

			if (head.type == ModsCall.Thorium.ItemType("DepthDiverHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("DepthDiverChestplate") &&
			    legs.type == ModsCall.Thorium.ItemType("DepthDiverGreaves"))
			{
				return "DepthDiver";
			}

			if (head.type == ModsCall.Thorium.ItemType("NagaSkinMask") &&
			    body.type == ModsCall.Thorium.ItemType("NagaSkinSuit") && legs.type == ModsCall.Thorium.ItemType("NagaSkinTail"))
			{
				return "NagaSkin";
			}

			if (head.type == ModsCall.Thorium.ItemType("TideHunterCap") &&
			    body.type == ModsCall.Thorium.ItemType("TideHunterChestpiece") &&
			    legs.type == ModsCall.Thorium.ItemType("TideHunterLeggings"))
			{
				return "TideHunter";
			}

			if (head.type == ModsCall.Thorium.ItemType("CelestialCrown") &&
			    body.type == ModsCall.Thorium.ItemType("CelestialVestment") &&
			    legs.type == ModsCall.Thorium.ItemType("CelestialLeggings"))
			{
				return "Celestial";
			}

			if (head.type == ModsCall.Thorium.ItemType("DewBinderMask") &&
			    body.type == ModsCall.Thorium.ItemType("DewBinderBreastplate") &&
			    legs.type == ModsCall.Thorium.ItemType("DewBinderGreaves"))
			{
				return "DewBinder";
			}

			if (head.type == ModsCall.Thorium.ItemType("EbonHood") && body.type == ModsCall.Thorium.ItemType("EbonCloak") &&
			    legs.type == ModsCall.Thorium.ItemType("EbonLeggings"))
			{
				return "Ebon";
			}

			if (head.type == ModsCall.Thorium.ItemType("FallenPaladinFacegaurd") &&
			    body.type == ModsCall.Thorium.ItemType("FallenPaladinCuirass") &&
			    legs.type == ModsCall.Thorium.ItemType("FallenPaladinGreaves"))
			{
				return "FallenPaladin";
			}

			if (head.type == ModsCall.Thorium.ItemType("HallowedPaladinHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("HallowedPaladinBreastplate") &&
			    legs.type == ModsCall.Thorium.ItemType("HallowedPaladinLeggings"))
			{
				return "HallowedPaladin";
			}

			if (head.type == ModsCall.Thorium.ItemType("IridescentHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("IridescentMail") &&
			    legs.type == ModsCall.Thorium.ItemType("IridescentGreaves"))
			{
				return "Iridescent";
			}

			if (head.type == ModsCall.Thorium.ItemType("LifeWeaverHood") &&
			    body.type == ModsCall.Thorium.ItemType("LifeWeaverGarment") &&
			    legs.type == ModsCall.Thorium.ItemType("LifeWeaverLeggings"))
			{
				return "LifeWeaver";
			}

			if (head.type == ModsCall.Thorium.ItemType("NoviceClericCowl") &&
			    body.type == ModsCall.Thorium.ItemType("NoviceClericTabard") &&
			    legs.type == ModsCall.Thorium.ItemType("NoviceClericPants"))
			{
				return "NoviceCleric";
			}

			if (head.type == ModsCall.Thorium.ItemType("TemplarsCirclet") &&
			    body.type == ModsCall.Thorium.ItemType("TemplarsTabard") &&
			    legs.type == ModsCall.Thorium.ItemType("TemplarsLeggings"))
			{
				return "Templars";
			}

			if (head.type == ModsCall.Thorium.ItemType("WarlockHood") && body.type == ModsCall.Thorium.ItemType("WarlockGarb") &&
			    legs.type == ModsCall.Thorium.ItemType("WarlockLeggings"))
			{
				return "Warlock";
			}

			// if (head.type == ModsCall.Thorium.ItemType("MalignantCap") && body.type == ModsCall.Thorium.ItemType("MalignantRobe"))
			// {
			// 	return "Malignant";
			// }

			if (head.type == ModsCall.Thorium.ItemType("FungusHat") && body.type == ModsCall.Thorium.ItemType("FungusGuard") &&
			    legs.type == ModsCall.Thorium.ItemType("FungusLeggings"))
			{
				return "Fungus";
			}

			if (head.type == ModsCall.Thorium.ItemType("PlagueDoctersMask") &&
			    body.type == ModsCall.Thorium.ItemType("PlagueDoctersGarb") &&
			    legs.type == ModsCall.Thorium.ItemType("PlagueDoctersLeggings"))
			{
				return "PlagueDocters";
			}

			if (head.type == ModsCall.Thorium.ItemType("ShadeMasterMask") &&
			    body.type == ModsCall.Thorium.ItemType("ShadeMasterGarb") &&
			    legs.type == ModsCall.Thorium.ItemType("ShadeMasterTreads"))
			{
				return "ShadeMaster";
			}

			if (head.type == ModsCall.Thorium.ItemType("WhiteDwarfMask") &&
			    body.type == ModsCall.Thorium.ItemType("WhiteDwarfGuard") &&
			    legs.type == ModsCall.Thorium.ItemType("WhiteDwarfGreaves"))
			{
				return "WhiteDwarf";
			}

			// if (head.type == ModsCall.Thorium.ItemType("TerrariumHelmet") &&
			//     body.type == ModsCall.Thorium.ItemType("TerrariumBreastPlate") &&
			//     legs.type == ModsCall.Thorium.ItemType("TerrariumGreaves"))
			// {
			// 	return "Terrarium";
			// }

			if (head.type == ModsCall.Thorium.ItemType("LifeBloomMask") &&
			    body.type == ModsCall.Thorium.ItemType("LifeBloomMail") &&
			    legs.type == ModsCall.Thorium.ItemType("LifeBloomLeggings"))
			{
				return "LifeBloom";
			}

			if (head.type == ModsCall.Thorium.ItemType("LivingWoodMask") &&
			    body.type == ModsCall.Thorium.ItemType("LivingWoodChestguard") &&
			    legs.type == ModsCall.Thorium.ItemType("LivingWoodBoots"))
			{
				return "LivingWood";
			}

			if (head.type == ModsCall.Thorium.ItemType("MeteorMask") && body.type == ItemID.MeteorSuit && legs.type == ItemID.MeteorLeggings)
			{
				return "Meteor";
			}

			if (head.type == ModsCall.Thorium.ItemType("SpiritTrapperHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("SpiritTrapperCuirass") &&
			    legs.type == ModsCall.Thorium.ItemType("SpiritTrapperGreaves"))
			{
				return "SpiritTrapperHelmet";
			}

			if (head.type == ModsCall.Thorium.ItemType("OceanHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("OceanChestGuard") &&
			    legs.type == ModsCall.Thorium.ItemType("OceanGreaves"))
			{
				return "Ocean";
			}

			if (head.type == ModsCall.Thorium.ItemType("ConduitHelmet") &&
			    body.type == ModsCall.Thorium.ItemType("ConduitSuit") &&
			    legs.type == ModsCall.Thorium.ItemType("ConduitLeggings"))
			{
				return "Conduit";
			}

			if (head.type == ModsCall.Thorium.ItemType("CryomancersCrown") &&
			    body.type == ModsCall.Thorium.ItemType("CryomancersTabard") &&
			    legs.type == ModsCall.Thorium.ItemType("CryomancersLeggings"))
			{
				return "Cryomancers";
			}

			if (head.type == ModsCall.Thorium.ItemType("WhiteKnightMask") &&
			    body.type == ModsCall.Thorium.ItemType("WhiteKnightTabard") &&
			    legs.type == ModsCall.Thorium.ItemType("WhiteKnightLeggings"))
			{
				return "WhiteKnight";
			}

			if (head.type == ModsCall.Thorium.ItemType("LichCowl") && body.type == ModsCall.Thorium.ItemType("LichCarapace") &&
			    legs.type == ModsCall.Thorium.ItemType("LichTalon"))
			{
				return "Lich";
			}

			if (head.type == ModsCall.Thorium.ItemType("IllumiteMask") &&
			    body.type == ModsCall.Thorium.ItemType("IllumiteChestplate") &&
			    legs.type == ModsCall.Thorium.ItemType("IllumiteGreaves"))
			{
				return "Illumite";
			}

			if (head.type == ModsCall.Thorium.ItemType("RallyHat") &&
			    body.type == ModsCall.Thorium.ItemType("RhapsodistChestWoofer") &&
			    legs.type == ModsCall.Thorium.ItemType("RhapsodistBoots"))
			{
				return "RallyHat";
			}

			if (head.type == ModsCall.Thorium.ItemType("SoloistHat") &&
			    body.type == ModsCall.Thorium.ItemType("RhapsodistChestWoofer") &&
			    legs.type == ModsCall.Thorium.ItemType("RhapsodistBoots"))
			{
				return "SoloistHat";
			}

			if (head.type == ModsCall.Thorium.ItemType("SilkCap") && body.type == ModsCall.Thorium.ItemType("SilkTabard") &&
			    legs.type == ModsCall.Thorium.ItemType("SilkLeggings"))
			{
				return "SilkCap";
			}

			if (head.type == ModsCall.Thorium.ItemType("SilkHat") && body.type == ModsCall.Thorium.ItemType("SilkTabard") &&
			    legs.type == ModsCall.Thorium.ItemType("SilkLeggings"))
			{
				return "SilkHat";
			}

			if (head.type == ModsCall.Thorium.ItemType("DreadSkull") &&
			    body.type == ModsCall.Thorium.ItemType("DreadChestPlate") &&
			    legs.type == ModsCall.Thorium.ItemType("DreadGreaves"))
			{
				return "Dread";
			}

			if (head.type == ModsCall.Thorium.ItemType("FeralSkinHead") &&
			    body.type == ModsCall.Thorium.ItemType("FeralSkinChest") &&
			    legs.type == ModsCall.Thorium.ItemType("FeralSkinLegs"))
			{
				return "FeralSkin";
			}

			if (head.type == ModsCall.Thorium.ItemType("AstroHelmet") && body.type == ModsCall.Thorium.ItemType("AstroSuit") &&
			    legs.type == ModsCall.Thorium.ItemType("AstroBoots"))
			{
				return "Astro";
			}

			if (head.type == ModsCall.Thorium.ItemType("SpiritTrapperMask") &&
			    body.type == ModsCall.Thorium.ItemType("SpiritTrapperCuirass") &&
			    legs.type == ModsCall.Thorium.ItemType("SpiritTrapperGreaves"))
			{
				return "SpiritTrapperMask";
			}

			return "";
		}

		public override void UpdateArmorSet(Player player, string set)
		{
			switch (set)
			{
				case "Whispering":
					player.setBonus = "Вы иногда рождаете щупальце глубинной энергии, которая атакует ближайших врагов\nИх удары похищают у врага 1 единицу маны и здоровья\nВы можете иметь максимум 6 щупалец";
					break;
				// case "Bulb":
				// 	player.setBonus = "У ваших магических атак есть шанс отравить врага облаком спор";
				// 	break;
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
					player.setBonus = "Максимальный запас маны повышен на 50% и вы становитесь 'нестабильным', если у вас больше 75% маны\nВ нестабильном состоянии вы получаете значительное увеличение магического урона и шанса критического удара ценой здоровья";
					break;
				case "Magma":
					player.setBonus = "Пламя обволакивает вашу броню и оружие ближнего боя\nУдары по горящему врагу увеличивают силу горения";
					break;
				case "SandStone":
					player.setBonus = "Пустынные ветра даруют песчаный двойной прыжок";
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
					player.setBonus = "Вас окружает ледяная аура, замораживая врагов, которые остаются в ней слишком долго";
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
				// case "Flesh":
				// 	player.setBonus = "Урон по раненным врагам имеет 10% шанс выбить кусок плоти, который при подборе повышает урон и количество здоровья";
				// 	break;
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
					player.setBonus = "Ваш стрелковый урон имеет 10% шанс полностью дублировать себя и нанести на 15% больше урона";
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
					player.setBonus = "Нажмите клавишу 'Armor Ability', назначенную в настройках управления, чтобы создать вокруг вашего курсора большую ауру стоимостью 150 маны\nСоюзники, которых коснулась аура, получают увеличенный урон, сопротивление урону, защиту и регенерацию здоровья\nВраги, которых коснулась аура, страдают от священного блеска и получают на 15% больше урона от всех источников";
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
					player.setBonus = "Лучезарные атаки могут генерировать до 15 теневых сгустков\nНажатие клавиши 'Armor Ability' высвободит каждый сохраненный теневой сгусток в направлении вашего курсора";
					break;
				// case "Malignant":
				// 	player.setBonus = "Критические удары магией поджигают врагов пустотным пламенем\nТакже увеличивает скорость чтения заклинаний на 10%";
				// 	break;
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
				// case "Terrarium":
				// 	player.setBonus = "Энергия Террарии стремится защитить вас";
				// 	break;
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
					player.setBonus = "Лучезарный урон увеличивает до 20 единиц щита жизни, а щит жизни больше не разрушается на вас\nИсцеление союзника передаёт ему щит жизни";
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
					player.setBonus = "Увеличивает магический урон повышен на 12%, пока мана выше 90%";
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
