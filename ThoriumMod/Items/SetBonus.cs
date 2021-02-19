using CalamityRuTranslate.Mods.ThoriumMod;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ThoriumMod.Items
{
	public class SetBonus : GlobalItem
	{
		public override string IsArmorSet(Item head, Item body, Item legs)
		{
			if (CoreThoriumTranslation.ThoriumMod != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian && ProjectTRuConfig.Instance.ThoriumTranslation)
			{
				if (ProjectTRuConfig.Instance.ThoriumTranslation)
				{
					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("WhisperingHood") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("WhisperingTabard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("WhisperingLeggings"))
					{
						return "Whispering";
					}

					// if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("BulbHood") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("BulbChestplate") &&
					//     legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("BulbLeggings"))
					// {
					// 	return "Bulb";
					// }

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("DangerHelmet") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("DangerMail") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("DangerGreaves"))
					{
						return "Danger";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("FlightMask") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("FlightMail") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("FlightBoots"))
					{
						return "Flight";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("YewWoodaHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("YewWoodBreastgaurd") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("YewWoodLeggings"))
					{
						return "YewWood";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("BerserkerMask") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("BerserkerBreastplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("BerserkerGreaves"))
					{
						return "Berserker";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("BronzeHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("BronzeBreastplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("BronzeGreaves"))
					{
						return "Bronze";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("hDarksteelFaceGuard") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("iDarksteelBreastPlate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("jDarksteelGreaves"))
					{
						return "Darksteel";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("DragonMask") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("DragonBreastplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("DragonGreaves"))
					{
						return "Dragon";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("GeodeHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("GeodeChestplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("GeodeGreaves"))
					{
						return "Geode";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("GraniteHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("GraniteChestGuard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("GraniteGreaves"))
					{
						return "Granite";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("HarbingerHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("HarbingerChestGuard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("HarbingerGreaves"))
					{
						return "Harbinger";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("MagmaHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("MagmaChestGuard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("MagmaGreaves"))
					{
						return "Magma";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("hSandStoneHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("iSandStoneMail") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("jSandStoneGreaves"))
					{
						return "SandStone";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("BlueKnightHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("BlueKnightArmor") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("BlueKnightGreaves"))
					{
						return "BlueKnight";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("GlitteringHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("GlitteringChestplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("GlitteringGreaves"))
					{
						return "Glittering";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("TideTurnerHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("TideTurnerBreastplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("TideTurnerGreaves"))
					{
						return "TideTurnerHelmet";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("TideTurnersGaze") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("TideTurnerBreastplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("TideTurnerGreaves"))
					{
						return "TideTurnersGaze";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("PyromancerCowl") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("PyromancerTabard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("PyromancerLeggings"))
					{
						return "PyromancerCowl";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("PyroSummonHat") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("PyromancerTabard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("PyromancerLeggings"))
					{
						return "PyroSummonHat";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("IcyBandana") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("IcyMail") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("IcyGreaves"))
					{
						return "Icy";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("DurasteelHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("DurasteelChestplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("DurasteelGreaves"))
					{
						return "Durasteel";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("SteelHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("SteelChestplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("SteelGreaves"))
					{
						return "Steel";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("TitanHeadgear") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("TitanBreastplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("TitanGreaves"))
					{
						return "TitanHeadgear";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("TitanHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("TitanBreastplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("TitanGreaves"))
					{
						return "TitanHelmet";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("TitanMask") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("TitanBreastplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("TitanGreaves"))
					{
						return "TitanMask";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("FleshMask") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("FleshBody") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("FleshLegs"))
					{
						return "Flesh";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("ThoriumHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("ThoriumMail") && legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("ThoriumGreaves"))
					{
						return "ThoriumMod";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("ValadiumHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("ValadiumBreastPlate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("ValadiumGreaves"))
					{
						return "Valadium";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("DemonBloodHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("DemonBloodBreastPlate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("DemonBloodGreaves"))
					{
						return "DemonBlood";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("LodeStoneFaceGuard") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("LodeStoneChestGaurd") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("LodeStoneShinGaurds"))
					{
						return "LodeStone";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("DreamWeaversHood") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("DreamWeaversTabard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("DreamWeaversTreads"))
					{
						return "DreamWeaversHood";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("DreamWeaversHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("DreamWeaversTabard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("DreamWeaversTreads"))
					{
						return "DreamWeaversHelmet";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("OmniArablastHood") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("OmniBody") && legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("OmniGreaves"))
					{
						return "OmniArablastHood";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("OmniMarkHead") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("OmniBody") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("OmniGreaves"))
					{
						return "OmniMarkHead";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("BalladeerHat") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("BalladeerShirt") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("BalladeerBoots"))
					{
						return "Balladeer";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("BardCap") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("BardChest") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("BardLeggings"))
					{
						return "Bard";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("CyberPunkHeadset") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("CyberPunkSuit") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("CyberPunkLeggings"))
					{
						return "CyberPunk";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("JestersMask") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("JestersShirt") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("JestersLeggings"))
					{
						return "JestersMask";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("JestersMask2") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("JestersShirt2") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("JestersLeggings2"))
					{
						return "JestersMask2";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("MaestroWig") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("MaestroSuit") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("MaestroLeggings"))
					{
						return "Maestro";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("MarchingBandCap") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("MarchingBandUniform") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("MarchingBandLeggings"))
					{
						return "Marching";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("NoblesHat") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("NoblesJerkin") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("NoblesLeggings"))
					{
						return "Nobles";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("OrnateHat") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("OrnateJerkin") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("OrnateLeggings"))
					{
						return "Ornate";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("DepthDiverHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("DepthDiverChestplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("DepthDiverGreaves"))
					{
						return "DepthDiver";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("NagaSkinMask") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("NagaSkinSuit") && legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("NagaSkinTail"))
					{
						return "NagaSkin";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("TideHunterCap") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("TideHunterChestpiece") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("TideHunterLeggings"))
					{
						return "TideHunter";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("CelestialCrown") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("CelestialVestment") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("CelestialLeggings"))
					{
						return "Celestial";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("DewBinderMask") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("DewBinderBreastplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("DewBinderGreaves"))
					{
						return "DewBinder";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("EbonHood") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("EbonCloak") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("EbonLeggings"))
					{
						return "Ebon";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("FallenPaladinFacegaurd") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("FallenPaladinCuirass") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("FallenPaladinGreaves"))
					{
						return "FallenPaladin";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("HallowedPaladinHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("HallowedPaladinBreastplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("HallowedPaladinLeggings"))
					{
						return "HallowedPaladin";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("IridescentHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("IridescentMail") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("IridescentGreaves"))
					{
						return "Iridescent";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("LifeWeaverHood") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("LifeWeaverGarment") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("LifeWeaverLeggings"))
					{
						return "LifeWeaver";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("NoviceClericCowl") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("NoviceClericTabard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("NoviceClericPants"))
					{
						return "NoviceCleric";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("TemplarsCirclet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("TemplarsTabard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("TemplarsLeggings"))
					{
						return "Templars";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("WarlockHood") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("WarlockGarb") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("WarlockLeggings"))
					{
						return "Warlock";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("MalignantCap") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("MalignantRobe"))
					{
						return "Malignant";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("FungusHat") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("FungusGuard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("FungusLeggings"))
					{
						return "Fungus";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("PlagueDoctersMask") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("PlagueDoctersGarb") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("PlagueDoctersLeggings"))
					{
						return "PlagueDocters";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("ShadeMasterMask") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("ShadeMasterGarb") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("ShadeMasterTreads"))
					{
						return "ShadeMaster";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("WhiteDwarfMask") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("WhiteDwarfGuard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("WhiteDwarfGreaves"))
					{
						return "WhiteDwarf";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("TerrariumHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("TerrariumBreastPlate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("TerrariumGreaves"))
					{
						return "Terrarium";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("LifeBloomMask") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("LifeBloomMail") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("LifeBloomLeggings"))
					{
						return "LifeBloom";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("LivingWoodMask") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("LivingWoodChestguard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("LivingWoodBoots"))
					{
						return "LivingWood";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("MeteorMask") && body.type == 124 && legs.type == 125)
					{
						return "Meteor";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("SpiritTrapperHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("SpiritTrapperCuirass") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("SpiritTrapperGreaves"))
					{
						return "SpiritTrapperHelmet";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("OceanHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("OceanChestGuard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("OceanGreaves"))
					{
						return "Ocean";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("ConduitHelmet") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("ConduitSuit") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("ConduitLeggings"))
					{
						return "Conduit";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("CryomancersCrown") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("CryomancersTabard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("CryomancersLeggings"))
					{
						return "Cryomancers";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("WhiteKnightMask") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("WhiteKnightTabard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("WhiteKnightLeggings"))
					{
						return "WhiteKnight";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("LichCowl") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("LichCarapace") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("LichTalon"))
					{
						return "Lich";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("IllumiteMask") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("IllumiteChestplate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("IllumiteGreaves"))
					{
						return "Illumite";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("RallyHat") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("RhapsodistChestWoofer") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("RhapsodistBoots"))
					{
						return "RallyHat";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("SoloistHat") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("RhapsodistChestWoofer") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("RhapsodistBoots"))
					{
						return "SoloistHat";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("SilkCap") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("SilkTabard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("SilkLeggings"))
					{
						return "SilkCap";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("SilkHat") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("SilkTabard") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("SilkLeggings"))
					{
						return "SilkHat";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("DreadSkull") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("DreadChestPlate") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("DreadGreaves"))
					{
						return "Dread";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("FeralSkinHead") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("FeralSkinChest") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("FeralSkinLegs"))
					{
						return "FeralSkin";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("AstroHelmet") && body.type == CoreThoriumTranslation.ThoriumMod.ItemType("AstroSuit") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("AstroBoots"))
					{
						return "Astro";
					}

					if (head.type == CoreThoriumTranslation.ThoriumMod.ItemType("SpiritTrapperMask") &&
					    body.type == CoreThoriumTranslation.ThoriumMod.ItemType("SpiritTrapperCuirass") &&
					    legs.type == CoreThoriumTranslation.ThoriumMod.ItemType("SpiritTrapperGreaves"))
					{
						return "SpiritTrapperMask";
					}
				}
			}

			return "";
		}

		public override void UpdateArmorSet(Player player, string set)
		{
			if ((CoreThoriumTranslation.ThoriumMod != null || LanguageManager.Instance.ActiveCulture != GameCulture.Russian) && ProjectTRuConfig.Instance.ThoriumTranslation)
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
						player.setBonus = "Максимальный запас маны повышен на 50%\nЕсли у вас более 75% маны, вы становитесь нестабильным";
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
