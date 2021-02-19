using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ThoriumMod.Items
{
	public class ThoriumGlobalItem : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			
			if (thorium != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (ProjectTRuConfig.Instance.ThoriumTranslation)
				{
					// if (item.type == thorium.ItemType("HealerCard"))
					// {
					// 	foreach (TooltipLine tooltipLine in tooltips)
					// 	{
					// 		string resultG = tooltipLine.text
					// 			.Replace("'Gifted to truly dedicated healers'",
					// 				"'Дар истинно преданным делу целителям'")
					// 			.Replace("Total lives saved: ", "Всего жизней спасено: ")
					// 			.Replace("Total close calls: ", "На волоске от гибели: ")
					// 			.Replace("Total damage mitigated: ", "Всего урона снижено: ")
					// 			.Replace("Total healing done: ", "Общее количество исцеленного здоровья: ")
					// 			.Replace("Highest heal streak: ", "Наивысшая серия исцеления: ")
					// 			.Replace("Current Bonus Healing: ", "Текущий бонус лечения: ");
					// 		tooltipLine.text = resultG;
					// 	}
					// }

					if (item.type == thorium.ItemType("SoulLink"))
					{
						foreach (TooltipLine tooltipLine2 in tooltips)
						{
							string resultS = tooltipLine2.text.Replace("-Early Testing-", "-В разработке-")
								.Replace("Right click to throw a volley of acorns",
									"Правый клик, чтобы бросить залп желудей")
								.Replace("Left click to dash forward, damaging an enemy in the process",
									"Левый клик, чтобы совершить рывок, тараня врагов")
								.Replace(" symbiotic damage", " симбиозный урон")
								.Replace("Right click to release a toxic haze on either side of you",
									"Правый клик, чтобы выпустить по обе стороны от вас ядовитый смрад")
								.Replace(
									"Left click to spit a heavy bubble that deals increased damage to poisoned enemies",
									"Левый клик, чтобы выплюнуть плотный пузырь, наносящий повышенный урон врагам")
								.Replace("Right click to leave a trail of sticky napalm",
									"Правый клик, чтобы оставить след из липучего напалма")
								.Replace("Left click to spit a stream of burning lava",
									"Левый клик, чтобы выплюнуть поток жгучей лавы")
								.Replace(
									"Right click to blow a larger bubble that stuns enemies or replenishes ally breath",
									"Правый клик, чтобы выпустить более крупный пузырь, который оглушает врагов или пополняет запас воздуха союзника")
								.Replace("Left click to release a water-bound bubble stream",
									"Левый клик, чтобы выпустить поток пузырей")
								.Replace("Right click to spit a bouncing globule of blood at the cost of 4 life",
									"Правый клик, чтобы выплюнуть отскакивающую каплю крови ценой 4 очков здоровья")
								.Replace("Left click to fire pair of life stealing teeth",
									"Левый клик, чтобы выстрелить парой крадущих жизнь клыков")
								.Replace("Right click to belch a volley of coins",
									"Правый клик, чтобы извергнуть залп монет")
								.Replace("Left click to leap forward, damaging an enemy in the process",
									"Левый клик, чтобы совершить наносящий урон прыжок вперед")
								.Replace(
									"Right click to harden your carapace, giving you damage reduction and a thorns effect briefly",
									"Правый клик, чтобы ожесточить панцирь, давая вам сопротивление урону и эффект шипов")
								.Replace("Left click to release a storm of venomous beetle needles",
									"Левый клик, чтобы запустить бурю ядовитых игл")
								.Replace("Right click to drop a large scale timed explosive",
									"Правый клик, чтобы бросить большую взрывчатку с таймером")
								.Replace("Left click to place a timed explosive that boosts you upwards",
									"Левый клик, чтобы поместить взрывчатку с таймером, которая нанесет урон врагам и подбросит вас вверх")
								.Replace("Allows you to use unique abilities while transformed",
									"Дает доступ к уникальным способностям облика трансформации");
							tooltipLine2.text = resultS;
						}
					}

					if (item.type == thorium.ItemType("Accordion") || item.type == thorium.ItemType("Acoustic") || 
					    item.type == thorium.ItemType("Alphorn") || item.type == thorium.ItemType("AntlionMaraca") ||
					    item.type == thorium.ItemType("AquamarineWineGlass") ||
					    item.type == thorium.ItemType("Bagpipe") || item.type == thorium.ItemType("Bassoon") ||
					    item.type == thorium.ItemType("BloomerBell") || item.type == thorium.ItemType("BoneTrumpet") ||
					    item.type == thorium.ItemType("Bongos") || item.type == thorium.ItemType("Buisine") ||
					    item.type == thorium.ItemType("Calaveras") || item.type == thorium.ItemType("Chimes") ||
					    item.type == thorium.ItemType("Clarinet") || item.type == thorium.ItemType("Concertina") ||
					    item.type == thorium.ItemType("Cymbals") || item.type == thorium.ItemType("DragonsWail") ||
					    item.type == thorium.ItemType("DrumMallet") ||
					    item.type == thorium.ItemType("DukesRegalCarnyx") ||
					    item.type == thorium.ItemType("DynastyGuzheng") ||
					    item.type == thorium.ItemType("EbonWoodTambourine") ||
					    item.type == thorium.ItemType("EskimoBanjo") || item.type == thorium.ItemType("Fishbone") ||
					    item.type == thorium.ItemType("Flute") || item.type == thorium.ItemType("ForestOcarina") ||
					    item.type == thorium.ItemType("FrenchHorn") ||
					    item.type == thorium.ItemType("GoldenBugleHorn") ||
					    item.type == thorium.ItemType("GraniteBoomBox") ||
					    item.type == thorium.ItemType("GreenTambourine") ||
					    item.type == thorium.ItemType("HallowedMegaphone") ||
					    item.type == thorium.ItemType("Harmonica") ||
					    item.type == thorium.ItemType("HauntingBassDrum") ||
					    item.type == thorium.ItemType("HellBell") || item.type == thorium.ItemType("HoneyRecorder") ||
					    item.type == thorium.ItemType("HotHorn") || item.type == thorium.ItemType("IcyPiccolo") ||
					    item.type == thorium.ItemType("InfernalPiccolo") || item.type == thorium.ItemType("JarOMayo") ||
					    item.type == thorium.ItemType("JingleBells") || item.type == thorium.ItemType("Kazoo") ||
					    item.type == thorium.ItemType("Lullaby") || item.type == thorium.ItemType("Lute") ||
					    item.type == thorium.ItemType("Microphone") ||
					    item.type == thorium.ItemType("MidnightBassBooster") ||
					    item.type == thorium.ItemType("MythrilMelodica") || item.type == thorium.ItemType("Nocturne") ||
					    item.type == thorium.ItemType("Oboe") || item.type == thorium.ItemType("Ocarina") ||
					    item.type == thorium.ItemType("Organ") ||
					    item.type == thorium.ItemType("OrichalcumSlideWhistle") ||
					    item.type == thorium.ItemType("Panflute") || item.type == thorium.ItemType("Piano") ||
					    item.type == thorium.ItemType("PlatinumBugle") || item.type == thorium.ItemType("PrimeRoar") ||
					    item.type == thorium.ItemType("Pungi") || item.type == thorium.ItemType("RiffWeaver") ||
					    item.type == thorium.ItemType("RivetingTadpole") ||
					    item.type == thorium.ItemType("RockstarsDoubleBassBlastGuitar") ||
					    item.type == thorium.ItemType("Saxophone") || item.type == thorium.ItemType("ScholarsHarp") ||
					    item.type == thorium.ItemType("ScubaCurva") ||
					    item.type == thorium.ItemType("SeashellCastanettes") ||
					    item.type == thorium.ItemType("SerpentsCry") ||
					    item.type == thorium.ItemType("ShadeWoodTambourine") ||
					    item.type == thorium.ItemType("Sitar") || item.type == thorium.ItemType("SkywareLute") ||
					    item.type == thorium.ItemType("SongFireAndIce") ||
					    item.type == thorium.ItemType("SonicAmplifier") ||
					    item.type == thorium.ItemType("SteamFlute") || item.type == thorium.ItemType("SteelDrum") ||
					    item.type == thorium.ItemType("SummonerWarhorn") ||
					    item.type == thorium.ItemType("SunflareGuitar") ||
					    item.type == thorium.ItemType("Tambourine") || item.type == thorium.ItemType("TheMaw") ||
					    item.type == thorium.ItemType("Triangle") || item.type == thorium.ItemType("Trombone") ||
					    item.type == thorium.ItemType("Tuba") || item.type == thorium.ItemType("TuningFork") ||
					    item.type == thorium.ItemType("Turntable") || item.type == thorium.ItemType("Ukulele") ||
					    item.type == thorium.ItemType("VinylRecord") || item.type == thorium.ItemType("Violin") ||
					    item.type == thorium.ItemType("VuvuzelaBlue") ||
					    item.type == thorium.ItemType("VuvuzelaGreen") ||
					    item.type == thorium.ItemType("VuvuzelaRed") ||
					    item.type == thorium.ItemType("VuvuzelaYellow") ||
					    item.type == thorium.ItemType("WoodenWhistle") || item.type == thorium.ItemType("Xylophone") ||
					    item.type == thorium.ItemType("CadaverCornet") ||
					    item.type == thorium.ItemType("SirensAllure") || item.type == thorium.ItemType("Didgeridoo") ||
					    item.type == thorium.ItemType("ViciousMockery") ||
					    item.type == thorium.ItemType("BlackOtamatone") || item.type == thorium.ItemType("Roboboe") ||
					    item.type == thorium.ItemType("SonarCannon") || item.type == thorium.ItemType("ConchShell") ||
					    item.type == thorium.ItemType("TheBopper") ||
					    item.type == thorium.ItemType("StrawberryHeart") ||
					    item.type == thorium.ItemType("TurtleDrum") || item.type == thorium.ItemType("Holophonor") ||
					    item.type == thorium.ItemType("EdgeofImagination") ||
					    item.type == thorium.ItemType("Sousaphone") || item.type == thorium.ItemType("BlackMIDI") ||
					    item.type == thorium.ItemType("Drum"))
					{
						foreach (TooltipLine tooltipLine3 in tooltips)
						{
							string resultQ = tooltipLine3.text
								.Replace("Empowerment Prolongation ", "Продление эффектов вдохновения ")
								.Replace("Defense ", "Защита ").Replace("Damage Reduction ", "Сопротивление урону ")
								.Replace("Movement Speed ", "Скорость передвижения ")
								.Replace("Jump Height ", "Высота прыжка ").Replace("Flight Time ", "Время полета ")
								.Replace("Invincibility Frames ", "Фреймы неуязвимости ")
								.Replace("Flat Damage ", "Плоский урон ").Replace("Damage ", "Урон ")
								.Replace("Life Regeneration ", "Регенерация жизни ")
								.Replace("Aquatic Ability ", "Водные умения ")
								.Replace("Attack Speed ", "Скорость атаки ")
								.Replace("Critical Strike Chance ", "Шанс критического удара ")
								.Replace("Resource Consumption Chance ", "Шанс не использовать ресурс ")
								.Replace("Resource Maximum ", "Максимум ресурсов ")
								.Replace("Resource Regen ", "Регенерация ресурсов ").Replace("Resource Grab Range ",
									"Дальность захвата ресурсов ");
							tooltipLine3.text = resultQ;
						}
					}

					if (item.type == thorium.ItemType("MusiciansHandbook"))
					{
						foreach (TooltipLine tooltipLine4 in tooltips)
						{
							string resultB = tooltipLine4.text
								.Replace("Your instruments play ", "Ваши инструменты играют на ")
								.Replace("% faster", "% быстрее");
							tooltipLine4.text = resultB;
						}
					}

					if (item.type == thorium.ItemType("GraniteIonStaff"))
					{
						foreach (TooltipLine tooltipLine5 in tooltips)
						{
							string resultB2 = tooltipLine5.text
								.Replace("Shields ally life by ", "Защищает здоровье союзника на ")
								.Replace(" up to 50", ", максимум до 50");
							tooltipLine5.text = resultB2;
						}
					}

					if (item.type == thorium.ItemType("LargePopcorn"))
					{
						foreach (TooltipLine tooltipLine6 in tooltips)
						{
							string resultD = tooltipLine6.text.Replace("Throws out (", "Бросает (")
								.Replace(") eatable popcorn kernels", ") съедобных зерен попкорна")
								.Replace("Up to (", "Вплоть до (").Replace(") kernels may be out at once",
									") зерен может быть одновременно выброшено");
							tooltipLine6.text = resultD;
						}
					}

					if (item.type == thorium.ItemType("NecroticStaff"))
					{
						foreach (TooltipLine tooltipLine7 in tooltips)
						{
							string resultA = tooltipLine7.text.Replace("Uses 2.5% of your maximum life",
								"Использует 2.5% вашего максимального здоровья");
							tooltipLine7.text = resultA;
						}
					}

					if (item.type == thorium.ItemType("PheonixStaff"))
					{
						foreach (TooltipLine tooltipLine8 in tooltips)
						{
							string resultC = tooltipLine8.text
								.Replace("Additionally, nearby allies respawn with (",
									"Дополнительно, ближайшие союзники при возрождении восстанавливают на (")
								.Replace("%) more life", "%) больше здоровья").Replace(
									"Summons a mythical phoenix that decreases the respawn time of nearby allies by (",
									"Призывает мифического Феникса, который уменьшает время возрождения ближайших союзников на (");
							tooltipLine8.text = resultC;
						}
					}

					if (item.type == thorium.ItemType("Recuperate"))
					{
						foreach (TooltipLine tooltipLine9 in tooltips)
						{
							string resultC2 = tooltipLine9.text
								.Replace("Channel the tome, turning ", "Перенаправляет том, превращая ")
								.Replace(" mana into ", " ед. маны в ")
								.Replace(" life every second", " ед. жизней каждую секунду");
							tooltipLine9.text = resultC2;
						}
					}

					if (item.type == thorium.ItemType("Renew"))
					{
						foreach (TooltipLine tooltipLine10 in tooltips)
						{
							string resultB3 = tooltipLine10.text
								.Replace("Instantly recovers ", "Мгновенно восстанавливает ")
								.Replace(" life", " ед. жизни");
							tooltipLine10.text = resultB3;
						}
					}

					if (item.type == thorium.ItemType("ShieldDroneBeacon"))
					{
						foreach (TooltipLine tooltipLine11 in tooltips)
						{
							string resultC3 = tooltipLine11.text
								.Replace("Shields ally life equal to your bonus healing up to 25",
									"Защищает здоровье союзника в зависимости от вашего бонуса исцеления, до 25")
								.Replace("Shields ally life by ", "Защищает здоровье союзника на ")
								.Replace(" up to 25", ", максимум до 25");
							tooltipLine11.text = resultC3;
						}
					}

					if (item.type == thorium.ItemType("SnackLantern"))
					{
						foreach (TooltipLine tooltipLine12 in tooltips)
						{
							string resultB4 = tooltipLine12.text
								.Replace("After popping, all nearby allies are healed by ",
									"После выскакивания все ближайшие союзники исцеляются на ")
								.Replace(" life", " ед. здоровья");
							tooltipLine12.text = resultB4;
						}
					}

					if (item.type == thorium.ItemType("TulipStaff"))
					{
						foreach (TooltipLine tooltipLine13 in tooltips)
						{
							string resultB5 = tooltipLine13.text.Replace("Heals (", "Исцеляет (")
								.Replace(") ally life over 5 seconds", ") ед. здоровья союзника каждые 5 секунд");
							tooltipLine13.text = resultB5;
						}
					}

					if (item.type == thorium.ItemType("WarForger"))
					{
						foreach (TooltipLine tooltipLine14 in tooltips)
						{
							string resultB6 = tooltipLine14.text
								.Replace("Shields ally and player life by ", "Защищает здоровье союзника и игрока на ")
								.Replace(" up to 25", ", вплоть до 25");
							tooltipLine14.text = resultB6;
						}
					}

					if (item.type == thorium.ItemType("HoneyBlade"))
					{
						foreach (TooltipLine tooltipLine15 in tooltips)
						{
							string resultA2 = tooltipLine15.text.Replace("Fast speed", "Высокая скорость");
							tooltipLine15.text = resultA2;
						}
					}

					if (item.type == thorium.ItemType("LadyLight"))
					{
						foreach (TooltipLine tooltipLine16 in tooltips)
						{
							string resultA3 = tooltipLine16.text.Replace("5% critical strike chance",
								"5% шанс критического удара");
							tooltipLine16.text = resultA3;
						}
					}

					if (item.type == thorium.ItemType("AquaticDepthsBiomeKey"))
					{
						foreach (TooltipLine tooltipLine17 in tooltips)
						{
							string resultB7 = tooltipLine17.text
								.Replace("It has been cursed by a powerful Jungle creature",
									"Он был проклят могущественным существом джунглей").Replace(
									"Unlocks an Aquatic Depths Chest in the dungeon",
									"Открывает Мроской глубоководный сундук в подземелье");
							tooltipLine17.text = resultB7;
						}
					}

					if (item.type == thorium.ItemType("UnderworldBiomeKey"))
					{
						foreach (TooltipLine tooltipLine18 in tooltips)
						{
							string resultB8 = tooltipLine18.text
								.Replace("It has been cursed by a powerful Jungle creature",
									"Он был проклят могущественным существом джунглей").Replace(
									"Unlocks a Underworld Chest in the dungeon",
									"Открывает Адский сундук в подземелье");
							tooltipLine18.text = resultB8;
						}
					}
				}
			}
		}
	}
}
