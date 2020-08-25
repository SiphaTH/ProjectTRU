using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ElementsAwoken.Items
{
	public class ElementsAwokenTagItems : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (ModLoader.GetMod("ElementsAwoken") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (item.type == ModLoader.GetMod("ElementsAwoken").ItemType("ProcWand"))
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						if (tooltipLine.mod == "Terraria" && tooltipLine.Name.Contains("ItemName"))
						{
							tooltipLine.text = "Огненный жезл";
						}
					}
				}
				if (item.type == ModLoader.GetMod("ElementsAwoken").ItemType("MysteriousPotion"))
				{
					foreach (TooltipLine tooltipLine2 in tooltips)
					{
						if (tooltipLine2.mod == "Terraria" && tooltipLine2.Name.Contains("ItemName"))
						{
							string resultT = tooltipLine2.text.Replace("Instant Health Potion", "Мгновенное зелье здоровья").Replace("Instant Damage Potion", "Мгновенно зелье урона").Replace("Toxic Potion", "Токсичное зелье").Replace("Healthy Potion", "Зелье здоровья").Replace("Invincibility Potion", "Зелье неуязвимости").Replace("Bright Potion", "Зелье яркости").Replace("Poison Potion", "Ядовитое зелье").Replace("Snail Potion", "Зелье улитки").Replace("Intensity Potion", "Зелье интенсивности").Replace("Red Potion", "Красное зелье").Replace("Cyan Potion", "Сине-зеленое зелье").Replace("Lime Potion", "Лаймовое зелье").Replace("Fuschia Potion", "Пурпурное зелье").Replace("Pink Potion", "Розовое зелье").Replace("Brown Potion", "Коричневое зелье").Replace("Orange Potion", "Оранжевое зелье").Replace("Yellow Potion", "Желтое зелье").Replace("Blue Potion", "Синие зелье").Replace("Purple Potion", "Фиолетовое зелье").Replace("Red Potion", "Красное зелье");
							tooltipLine2.text = resultT;
						}
					}
				}
				if (item.type == ModLoader.GetMod("ElementsAwoken").ItemType("MysteriousPotion"))
				{
					foreach (TooltipLine tooltipLine4 in tooltips)
					{
						string resultK = tooltipLine4.text.Replace("It has a foul smell about it", "От него исходит отвратительный запах").Replace("Heals you for 20% of your total health", "Исцеляет вас на 20% от вашего общего здоровья").Replace("Damages you for 20% of your total health", "Наносит вам урон на 20% от вашего общего здоровья").Replace("Reduces your maximum health by 10%", "Уменьшает ваш максимальный запас здоровья на 10%").Replace("Increases your maximum health by 10%", "Увеличивает ваш максимальный запас здоровья на 10%").Replace("Makes you invincible for 10 seconds", "Делает вас неуязвимым на 10 секунд").Replace("Increases damage by 10%", "Повышает урон на 10%").Replace("Makes you release blinding light", "Заставляет вас выпустить ослепляющий свет").Replace("Poisons you", "Отравляет вас").Replace("Makes you move very slowly", "Заставляет вас двигаться очень медленно").Replace("Makes you move at uncontrollable speeds", "Заставляет вас двигаться с неконтролируемой скоростью");
						tooltipLine4.text = resultK;
					}
				}
				if (item.type == ModLoader.GetMod("ElementsAwoken").ItemType("ElementalCapsule"))
				{
					foreach (TooltipLine tooltipLine5 in tooltips)
					{
						string resultF = tooltipLine5.text.Replace("Forces bend around this capsule...", "Силы вокруг этой капсулы преломляются...").Replace("Can only be used in Expert Mode", "Может быть использовано только в Эксперте").Replace("Only use if you are up for a challenge", "Используйте, только если хотите бросить вызов своим способностям").Replace("Activates [c/f442aa:Awakened Mode] and sanity ", "Активирует [c/f442aa:режим Пробуждения] и рассудок ").Replace("  -75% more enemy life, defence and damage", "  -У противников на 75% больше здоровья, защиты и урона").Replace("  -New harder boss AI's and stats", "  -Боссы получают более трудные ИИ и характеристики");
						tooltipLine5.text = resultF;
					}
				}
				if (item.type == ModLoader.GetMod("ElementsAwoken").ItemType("GiftOfTheArchaic"))
				{
					foreach (TooltipLine tooltipLine6 in tooltips)
					{
						string resultC = tooltipLine6.text.Replace("Press ", "Нажмите ").Replace(" to encase the player in a crystal that knocks enemies away from the player and prevents damage", ", чтобы заключить персонажа в отбрасывающий противников и наносящий урон кристалл").Replace("Hover over the item while equipped and press ctrl + key to rebind", "Наведите курсор на предмет, пока он экипирован,\nи нажмите клавишу Ctrl + нужная клавиша, чтобы переназначить активацию на нее");
						tooltipLine6.text = resultC;
					}
				}
				if (item.type == ModLoader.GetMod("ElementsAwoken").ItemType("VoidLeviathansAegis"))
				{
					foreach (TooltipLine tooltipLine7 in tooltips)
					{
						string resultG = tooltipLine7.text.Replace("Life increased by 50", "Максимальный запас здоровья увеличен на 50").Replace("When under half health, defense is increased by 5%", "Когда у вас менее половины здоровья, защита повышается на 5%").Replace("Allows the player to perform a secondary dash using the ", "Позволяет игроку нажатием клавиши ").Replace(" key", ", использовать дополнительный рывок").Replace("For 15 seconds after taking 500 total damage:", "После получения в сумме 500 урона, на 15 секунд:").Replace("40% increased movement speed", "Повышает скорость передвижения на 40%").Replace("20% increased damage", "Повышает урон на 20%");
						tooltipLine7.text = resultG;
					}
				}
				if (item.type == ModLoader.GetMod("ElementsAwoken").ItemType("GreatLens"))
				{
					foreach (TooltipLine tooltipLine8 in tooltips)
					{
						string resultC2 = tooltipLine8.text.Replace("Pressing the special ability key (", "Нажатие клавиши (").Replace(") will encase the player in a giant lens which reflects 20% of the damage from projectiles and enemies", ") заключит персонажа в гигантскую линзу, отражающую 20% урона от врагов и снарядов").Replace("If the player is hit by an enemy the damage is reflected to them", "Если игрок получил от противника удар, то на него перенаправляется урон");
						tooltipLine8.text = resultC2;
					}
				}
				if (item.type == ModLoader.GetMod("ElementsAwoken").ItemType("InfinityGauntlet"))
				{
					foreach (TooltipLine tooltipLine9 in tooltips)
					{
						string resultI = tooltipLine9.text.Replace("The forces of the elements combined...", "Силы элементов слились воедино...").Replace("Has the effects of all the infinity stones", "Обладает эффектами всех камней бесконечности").Replace("Right Click to switch modes", "Правый клик для смены режимов").Replace("Desert: Rains desert shards", "Пустыня: дождем осыпает пустынные осколки").Replace("Fire: Fires a fireball", "Огонь: запускает огненный шар").Replace("Sky: Teleport to a discovered location on the map", "Небо: телепортирует к изведанному месту на карте").Replace("Frost: Summons a shield around the player", "Мороз: призывает вокруг игрока щит").Replace("Water: Turns projectiles into bubbles", "Вода: превращает снаряды в пузыри").Replace("Void: Kills half of all non boss monsters with under 10000 life", "Пустота: убивает половину не-босс монстров, у которых менее 10000 здоровья");
						tooltipLine9.text = resultI;
					}
				}
				if (item.type == ModLoader.GetMod("ElementsAwoken").ItemType("HoneyCocoon"))
				{
					foreach (TooltipLine tooltipLine10 in tooltips)
					{
						string resultG2 = tooltipLine10.text.Replace("Pressing the special ability key (", "Нажатие клавиши (").Replace(") will encase the player in a honey cocoon for 15 seconds", ") на 15 секунд заключит игрока в медовый кокон").Replace("The cocoon can absorb up to 100 damage before breaking", "Кокон может принять 100 урона, прежде чем сломаться").Replace("Press (", "Нажмите (").Replace(") again to get out", ") снова, чтобы выбраться").Replace("Being in the cocoon prevents movement", "Пока вы в коконе, вы не можете двигаться").Replace("1 minute cooldown", "Имеет минутную перезарядку");
						tooltipLine10.text = resultG2;
					}
				}
				if (item.type == ModLoader.GetMod("ElementsAwoken").ItemType("ToySlimeClaw"))
				{
					foreach (TooltipLine tooltipLine11 in tooltips)
					{
						string resultD = tooltipLine11.text.Replace("Allows the ability to slide down walls", "Дает способность скользить по стенам").Replace("Pressing the special ability key (", "Нажатие клавиши (").Replace(") key will throw slime at the cursor", ") запустит по направлению курсора слизня").Replace("If it is thrown down, the player will get launched up into the air and throw multiple projectiles down", "Если он кинут вниз, игрок будет запущен в воздух и запустит вниз несколько снарядов");
						tooltipLine11.text = resultD;
					}
				}
				if (item.type == ModLoader.GetMod("ElementsAwoken").ItemType("BoostDrive"))
				{
					foreach (TooltipLine tooltipLine12 in tooltips)
					{
						string resultC3 = tooltipLine12.text.Replace("Pressing the special ability key (", "Нажатие клавиши (").Replace(") will speed up the player for 5 seconds", ") на 5 секунд ускорит игрока").Replace("Activating it will take consume energy", "Активация этого умения потребляет немного энергии");
						tooltipLine12.text = resultC3;
					}
				}
				if (item.type == ModLoader.GetMod("ElementsAwoken").ItemType("HyperDrive"))
				{
					foreach (TooltipLine tooltipLine13 in tooltips)
					{
						string resultD2 = tooltipLine13.text.Replace("Pressing the special ability key (", "Нажатие клавиши (").Replace(") will greatly speed up the player for 5 seconds", ") на 5 секунд значительно ускорит игрока").Replace("WARNING: travelling at such high speeds can be damaging", "ОСТОРОЖНО: высокие скорости могут быть опасными").Replace("Activating it will consume 150 energy", "Активация этого умения потребляет 150 энергии");
						tooltipLine13.text = resultD2;
					}
				}
				foreach (TooltipLine tooltipLine3 in tooltips)
				{
					if (tooltipLine3.Name == "Elements Awoken:Energy")
					{
						string resultB = tooltipLine3.text.Replace("Uses ", "Использует ").Replace(" energy", " энергии");
						tooltipLine3.text = resultB;
					}
					if (tooltipLine3.Name == "Elements Awoken:Tooltip")
					{
						string resultE = tooltipLine3.text.Replace("-Donator Item-", "-Предмет спонсора-").Replace("-Artifact Item-", "-Артефакт-").Replace("-Developer Item-", "-Предмет разработчика-").Replace("-Youtuber Item-", "-Предмет ютубера-").Replace("Awakened", "Пробужденный");
						tooltipLine3.text = resultE;
					}
					if (tooltipLine3.Name == "Elements Awoken:Tooltip")
					{
						string resultI2 = tooltipLine3.text.Replace("Gravity: ", "Гравитация: ").Replace("Enabled", "Включено").Replace("Disabled", "Выключено").Replace("WARNING: At high gravity there may be undesired effects", "ОСТОРОЖНО: При высокой гравитации возможны неблагоприятные эффекты");
						tooltipLine3.text = resultI2;
					}
					if (tooltipLine3.Name == "Elements Awoken:Tooltip")
					{
						string resultS = tooltipLine3.text.Replace("Produces ", "Производит ").Replace(" energy every ", " энергии каждые ").Replace(" seconds", " секунд").Replace("Fuel Type: ", "Вид топлива: ").Replace("Fuel: ", "Топливо:").Replace("Strength: ", "Сила: ").Replace("Inactive", "Неактивный").Replace("Wind speed: ", "Скорость ветра: ").Replace("Production Rate: 1 energy every ", "Частота производства: 1 единица энергии каждые ").Replace("Power Output: ", "Выходная мощность:");
						tooltipLine3.text = resultS;
					}
				}
			}
		}
	}
}
