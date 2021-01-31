using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ThoriumMod.Items
{
	public class ThoriumTagItems : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (ModLoader.GetMod("ThoriumMod") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (ProjectTRuConfig.Instance.ThoriumTranslation)
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						if (tooltipLine.Name == "InstrumentTag")
						{
							string resultF = tooltipLine.text.Replace("-String Instrument-", "-Струнное-")
								.Replace("-Other Instrument-", "-Другое-").Replace("-Wind Instrument-", "-Духовое-")
								.Replace("-Brass Instrument-", "-Медное-")
								.Replace("-Percussion Instrument-", "-Ударное-")
								.Replace("-Electronic Instrument-", "-Электронное-");
							tooltipLine.text = resultF;
						}

						if (tooltipLine.Name == "InspirationCost")
						{
							string resultC = tooltipLine.text.Replace("Uses ", "Использует ")
								.Replace("1 inspiration", "1 вдохновение").Replace(" inspiration", " вдохновения");
							tooltipLine.text = resultC;
						}

						if (tooltipLine.Name == "BardTag")
						{
							string resultA5 = tooltipLine.text.Replace("-Bard Class-", "-Бард-");
							tooltipLine.text = resultA5;
						}

						if (tooltipLine.Name == "HealerAmount")
						{
							string resultQ = tooltipLine.text
								.Replace("The gateways can only be used by players every ",
									"Проход через врата можно использовать каждые ").Replace(" second(s)", " секунд(ы)")
								.Replace("Heals ally life", "Исцеляет здоровье союзников")
								.Replace("Heals player life", "Исцеляет здоровье игрока")
								.Replace("Heals ally and player life", "Исцеляет здоровье союзников и игрока")
								.Replace("Steals", "Крадет").Replace(" life", " ед. здоровья").Replace(" by ", " на ")
								.Replace(" (Max)", " (Макс)")
								.Replace(" equal to your bonus healing", " равное вашему бонусному исцелению")
								.Replace(" Max)", " Макс)").Replace(" every 2.5 seconds", " каждые 2.5 секунды")
								.Replace(
									"Right click to heal all nearby allies equal to the weapon's holy charges at twice the mana cost",
									"Нажмите Правую клавишу мыши, чтобы вылечить всех ближайших союзников на количество здоровья, равное всем святым зарядам при удвоенной стоимости маны")
								.Replace("Right click to heal all nearby allies by ",
									"Нажмите Правую клавишу мыши, чтобы вылечить всех ближайших союзников на ")
								.Replace(" life at twice the mana cost", " здоровья при удвоенной стоимости маны")
								.Replace(
									"Right click to heal all nearby allies by 20 life (Max) at twice the mana cost",
									"Нажмите Правую клавишу мыши, чтобы вылечить всех ближайших союзников на 20 здоровья (максимум) при удвоенной стоимости маны")
								.Replace("Right click to heal all nearby allies ",
									"Нажмите Правую клавишу мыши, чтобы вылечить всех ближайших союзников ");
							tooltipLine.text = resultQ;
						}

						if (tooltipLine.Name == "techText")
						{
							string resultAd = tooltipLine.text
								.Replace(
									"Press the 'Throwing Technique' key to freeze all enemies around your cursor briefly",
									"Нажмите клавишу 'Throwing Technique', чтобы ненадолго заморозить всех врагов вокруг курсора")
								.Replace(
									"Press the 'Throwing Technique' to dash forward, stunning nearby enemies in the process",
									"Нажмите клавишу 'Throwing Technique', чтобы броситься вперед, оглушая ближайших врагов")
								.Replace("Every knife heals you up to 10% of the damage dealt",
									"Каждый нож исцеляет до 10% от нанесенного урона")
								.Replace(
									"Press the 'Throwing Technique' key to stop in place and release a torrent of knives at the nearest enemy",
									"Нажмите клавишу 'Throwing Technique', чтобы остановиться на месте и выпустить поток ножей на ближайшего врага")
								.Replace("Weak knockback", "Слабое отбрасывание")
								.Replace("% critical strike chance", "% шанс критического удара")
								.Replace(" throwing damage", " урона при метании")
								.Replace(
									"Has a guaranteed chance to critically strike enemies that are poisoned or envenomed",
									"Имеет гарантированный шанс критического удара по врагам, которые отравлены или прокляты")
								.Replace(
									"Press the 'Throwing Technique' key to throw out a spread of toxic fangs, which envenom damaged enemies",
									"Нажмите клавишу 'Throwing Technique', чтобы бросить пучок ядовитых клыков, которые вызывают у врагов отравление")
								.Replace("Average knockback", "Среднее отбрасывание")
								.Replace("The decoy will attempt to grab the attention of nearby enemies",
									"Приманка попытается привлечь внимание ближайших врагов")
								.Replace("Press the 'Throwing Technique' key to call in an enemy decoy",
									"Нажмите клавишу 'Throwing Technique', чтобы привлечь внимание врагов")
								.Replace(
									"Press the 'Throwing Technique' key to summon a gravity well upon your cursor's position, sucking in nearby enemies",
									"Нажмите клавишу 'Throwing Technique', чтобы вызвать гравитационный колодец в позиции курсора, притягивающий ближайших врагов")
								.Replace(
									"Press the 'Throwing Technique' key to release a damaging hidden blade towards your cursor",
									"Нажмите клавишу 'Throwing Technique', чтобы выпустить к курсору мыши наносящее урон скрытое лезвие")
								.Replace(
									"While invulnerable, you gain 25% throwing speed & damage but die at the end of the duration",
									"Во время неуязвимости вы повышаете скорость метания и урон на 25%, но умираете после окончания неуязвимости")
								.Replace(
									"Automatically triggers when you take fatal damage, granting you 10 seconds of invulnerability",
									"Автоматически срабатывает, когда вы получаете смертельный урон, давая вам 10 секунд неуязвимости")
								.Replace("Prevents fall damage if used to land on a tile",
									"Нейтрализует урон от падения при приземлении на блок")
								.Replace(
									"Press the 'Throwing Technique' key to hurl yourself downwards, repelling enemies away in the process",
									"Нажмите клавишу 'Throwing Technique', чтобы броситься вниз, отталкивая от себя врагов")
								.Replace(
									"Press the 'Throwing Technique' key to throw out a sticky bomb, that explodes after a short delay",
									"Нажмите клавишу 'Throwing Technique', чтобы бросить липкую бомбу, которая после короткой задержки взорвется")
								.Replace(
									"Press the 'Throwing Technique' key to summon a shadowy ninja clone to briefly assault nearby enemies",
									"Нажмите клавишу 'Throwing Technique', чтобы вызвать теневого клона-ниндзя для краткой атаки ближайшего врага")
								.Replace("Press the 'Throwing Technique' key to teleport you to your cursor's position",
									"Нажмите клавишу 'Throwing Technique', чтобы телепортироваться к позиции курсора")
								.Replace(
									"Press the 'Throwing Technique' key to release a smoke bomb, briefly granting you damage immunity",
									"Нажмите клавишу 'Throwing Technique', чтобы выпустить дымовую шашку, ненадолго даровав вам невосприимчивость к урону")
								.Replace(
									"Press the 'Throwing Technique' key to release a soul pulse, sending nearby enemies flying away and confusing them",
									"Нажмите клавишу 'Throwing Technique', чтобы выпустить импульс души, отбрасывающий и ошеломляющий ближайших врагов")
								.Replace(
									"Press the 'Throwing Technique' key to throw out a stone hand, which briefly blocks incoming hostile projectiles",
									"Нажмите клавишу 'Throwing Technique', чтобы бросить каменную руку, которая на короткое время блокирует входящие вражеские снаряды")
								.Replace("Costs 1 technique point", "Стоимость 1 очко техники")
								.Replace("Costs 2 technique points", "Стоимость 2 очка техники")
								.Replace("Costs 3 technique points", "Стоимость 3 очка техники")
								.Replace("Costs 5 technique points", "Стоимость 5 очка техники")
								.Replace("Costs 2 technique point", "Стоимость 2 очка техники");
							tooltipLine.text = resultAd;
						}

						if (tooltipLine.Name == "techText2")
						{
							string resultB3 = tooltipLine.text.Replace("Technique Active", "Техника активна")
								.Replace("Sets your active technique on use",
									"Устанавливает вашу активную технику на использование");
							tooltipLine.text = resultB3;
						}
						

						if (tooltipLine.Name == "PrefixEmpowermentDuration")
						{
							string resultA6 = tooltipLine.text.Replace("s empowerment duration",
								" сек длительность эффектов вдохновения");
							tooltipLine.text = resultA6;
						}

						if (tooltipLine.Name == "EmpowermentTop")
						{
							string resultA7 = tooltipLine.text.Replace("Playing empowers players with bonus:",
								"Игра на этом инструменте дает игрокам бонус:");
							tooltipLine.text = resultA7;
						}

						if (tooltipLine.Name == "FoodFullDuration")
						{
							string resultA8 = tooltipLine.text.Replace("Eating the Cook's food will make you full for ",
								"Еда Повара насытит вас на ");
							tooltipLine.text = resultA8;
						}

						if (tooltipLine.Name == "FoodFullWarning")
						{
							string resultA9 = tooltipLine.text.Replace("You can't eat the Cook's food while full",
								"Вы не можете есть еду Повара на сытый желудок");
							tooltipLine.text = resultA9;
						}
					}
				}
			}
		}
	}
}
