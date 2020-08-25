using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ModOfRedemption.Items
{
	public class RedemptionTags : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			Mod redemption = ModLoader.GetMod("Redemption");
			if (redemption != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (item.type == redemption.ItemType("ZoneAccessPanel1A") || 
				    item.type == redemption.ItemType("ZoneAccessPanel2A") || 
				    item.type == redemption.ItemType("ZoneAccessPanel3A") || 
				    item.type == redemption.ItemType("ZoneAccessPanel4A") || 
				    item.type == redemption.ItemType("ZoneAccessPanel5A") || 
				    item.type == redemption.ItemType("ZoneAccessPanel6A") || 
				    item.type == redemption.ItemType("ZoneAccessPanel7A"))
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Opens up the alpha sector of the lab", "Открывает Альфа сектор лаборатории");
						string resultB = resultA.Replace("Opens up the beta sector of the lab", "Открывает Бета сектор лаборатории");
						string resultC = resultB.Replace("Opens up the gamma sector of the lab", "Открывает Гамма сектор лаборатории");
						string resultD = resultC.Replace("Opens up the sigma sector of the lab", "Открывает Сигма сектор лаборатории");
						string resultE = resultD.Replace("Opens up the omicron sector of the lab", "Открывает Омикрон сектор лаборатории");
						string resultF = resultE.Replace("Opens up the vault sector of the lab", "Открывает сектор хранилища лаборатории");
						string resultG = resultF.Replace("Opens up all sectors of the lab", "Открывает все сектора лаборатории");
						tooltipLine.text = resultG;
					}
				}
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (tooltipLine.Name == "PrefixLifeTime")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("guardian time", "ко времени поддержки стража");
						string resultB = resultA.Replace("plant lifetime", "к сроку жизни растения");
						tooltipLine.text = resultB;
					}
					if (tooltipLine.Name == "ItemName")
					{
						string resultR = tooltipLine.text.Replace("Mother  Nature's", "Природный").Replace("Blighted", "Чумной").Replace("Blooming", "Цветущий").Replace("Dryad's", "Дриадский").Replace("Dry", "Сухой").Replace("Enchanted", "Зачарованный").Replace("Exotic", "Экзотичный").Replace("Forgotten", "Забытый").Replace("Fruitful", "Плодоносный").Replace("Lively", "Живой").Replace("Mesmerizing", "Завораживающий").Replace("Blessed", "Благословенный").Replace("Old", "Старый").Replace("Plentiful", "Плодородный").Replace("Precious", "Красивый").Replace("Prickly", "Колючий").Replace("Rotten", "Гнилой").Replace("Wild", "Дикий");
						tooltipLine.text = resultR;
					}
					if (tooltipLine.Name == "text1")
					{
						string resultH = tooltipLine.text.Replace("Charge: ", "Заряд: ").Replace("No doses of radiation detected on self, nothing to note.", "У вас обнаружен нулевой уровень облучения, ничего примечательного.").Replace("Low doses of radiation detected on self, nothing to note.", "У вас обнаружен низкий уровень облучения радиацией, ничего примечательного.").Replace("Medium doses of radiation detected on self, have teochrome-issued pills on hand just in case.", "У вас обнаружен средний уровень облучения радиацией, на всякий случай имейте под рукой таблетки, выпущенные теохромом.").Replace("High doses of radiation detected on self, have teochrome-issued pills on hand just in case.", "У вас обнаружен высокий уровень облучения радиацией, на всякий случай имейте под рукой таблетки, выпущенные теохромом.").Replace("Very high doses of radiation detected on self, high chance of irradiation and suffering ARS.", "Невероятно высокая доля облучения радиацией, высокий шанс облучения и острой лучевой болезни.").Replace("Extreme doses of radiation detected on self, Acute Radiation Syndrome detected.", "У вас обнаружен смертельный уровень облучения радиацией, обнаружена острая лучевая болезнь.");
						tooltipLine.text = resultH;
					}
					if (tooltipLine.Name == "IsDruid")
					{
						string resultA = tooltipLine.text.Replace("Druid Class", "Друид");
						tooltipLine.text = resultA;
					}
					if (tooltipLine.Name == "MinSpiritLevel")
					{
						string resultA2 = tooltipLine.text.Replace("[c/c0bdff:Minimum Spirit Level: ]", "[c/c0bdff:Минимальный спиритический уровень: ]");
						tooltipLine.text = resultA2;
					}
					if (tooltipLine.Name == "MaxSpiritLevel")
					{
						string resultA3 = tooltipLine.text.Replace("[c/bdffe4:Maximum Spirit Level: ]", "[c/bdffe4:Максимальный спиритический уровень: ]");
						tooltipLine.text = resultA3;
					}
					if (tooltipLine.Name == "NativeTerrain")
					{
						string resultT = tooltipLine.text.Replace("[c/91dc16:Native Terain: ]", "[c/91dc16:Родная местность: ]").Replace("Ores", "Руды").Replace("Dirt", "Земля").Replace("Blood Moon", "Кровавая луна").Replace("Crimson", "Багрянец").Replace("Forest (Ceiling)", "Лес (подвесное)").Replace("Corruption/Crimson", "Искажение/Багрянец").Replace("Desert/Underworld", "Пустыня/Ад").Replace("Forest/Jungle", "Лес/Джунгли").Replace("Underworld", "Ад").Replace("Mud/Bones", "Грязь/Кости").Replace("Glowing Mushroom", "Светящиеся грибы").Replace("Forest (Night)", "Ночной лес").Replace("Jungle", "Джунгли").Replace("Forest", "Лес").Replace("Snow", "Снег").Replace("Cloud", "Облака").Replace("Corruption", "Искажение").Replace("Desert", "Пустыня").Replace("None", "Нет");
						tooltipLine.text = resultT;
					}
					if (tooltipLine.Name == "GuardianInfo")
					{
						string resultA4 = tooltipLine.text.Replace("[c/71ee8d: -Guardian Info-]", "[c/71ee8d:- Информация о Страже -]");
						tooltipLine.text = resultA4;
					}
					if (tooltipLine.Name == "GuardianType")
					{
						string resultF = tooltipLine.text.Replace("[c/a0db98:Type:] ", "[c/a0db98:Вид:] ").Replace("Pixie", "Пикси").Replace("Guardian", "Страж").Replace("Fairy", "Фея").Replace("Other", "Другое").Replace("Mystic", "Мистический");
						tooltipLine.text = resultF;
					}
					if (tooltipLine.Name == "SpecialAbilities")
					{
						string resultAa = tooltipLine.text.Replace("[c/98dbc3:Special Ability:] ", "[c/98dbc3:Особая способность:] ").Replace("Swift-Cast", "Ускорение").Replace("Druidic Embrace", "Объятие друида").Replace("Dryad's Blessing", "Благословение Дриады").Replace("Crimson Aura", "Багряная аура").Replace("Corrupt Aura", "Искажённая аура").Replace("Ironbone Aura", "Аура железной кости").Replace("Stream-Shot", "Паровой выстрел").Replace("Marble Aura", "Мраморная аура").Replace("Ring of Thorns", "Кольцо шипов").Replace("Scatter-Shot", "Рассеянный выстрел").Replace("Holy Aura", "Святая аура").Replace("Molten Eruption", "Ярость недр").Replace("Warmth", "Обогрев").Replace("Triple-Shot", "Тройной выстрел").Replace("Nightshade's Embrace", "Объятия беладонны").Replace("Glow", "Свечение").Replace("Healing Aura", "Аура лечения").Replace("Quad-Shot", "Четверной выстрел").Replace("Creation's Embrace", "Объятие созидания").Replace("Terra's Embrace", "Объятие земли").Replace("True Holy Aura", "Истинная святая аура").Replace("Sapphiron Soul Aura", "Аура души Сапфирона").Replace("Blood Pulse Aura", "Аура кровавого импульса").Replace("Ancient Embrace", "Древнее объятие").Replace("Ice Shield", "Ледяной щит").Replace("Phantasmal Flames", "Призрачные огни");
						tooltipLine.text = resultAa;
					}
					if (tooltipLine.Name == "Effects")
					{
						string resultAd = tooltipLine.text.Replace("[c/98c1db:Effects:] ", "[c/98c1db:Эффекты:] ").Replace("Staves cast a lot faster", "Запуск заклинаний шестов намного ускорен").Replace("Defence Boost", "Повышение защиты").Replace("Druidic Enhancement", "Улучшение друида").Replace("Mobility Enhancement while in Crimson", "Улучшение подвижности (пока вы в Багрянце)").Replace("Mobility Enhancement while in Corruption", "Улучшение подвижности (пока вы в Искажении)").Replace("Defence Enhancement", "Улучшение защиты").Replace("Staves have a chance to shoot 2 extra projectiles", "Шесты имеют шанс выстрелить двумя дополнительными снарядами").Replace("Life & Mana Enhancement", "Улучшение здоровья и маны").Replace("Petrification Immunity", "Иммунитет к окаменению").Replace("Mana Enhancement", "Улучшение маны").Replace("Thorns", "Шипы").Replace("Staves that shoot a single projectile will instead shoot a cluster", "Шесты, запускающие один снаряд, запускают залп таких же").Replace("Improved Sight", "Улучшенное зрение").Replace("Mobility Enhancement at day", "Улучшение подвижности днём").Replace("Staves swing a lot faster", "Взмахи шестами намного быстрее").Replace("Hitting an enemy has a chance to cast rising flames", "Попадая по противнику, есть шанс запустить столб огня").Replace("Combined effects of all pixies", "Комбинированный эффект всех пикси").Replace("Staves that shoot a single projectile will shoot 2 more in an arc", "Шесты, запускающие один снаряд, запускают ещё два по дуге").Replace("Mobility Enhancement at night", "Улучшение подвижности ночью").Replace("Improved vision", "Улучшенное зрение").Replace("Reduces damage from cold sources", "Сниженный урон от источников холода").Replace("Life Boost", "Повышение здоровья").Replace("Staves that shoot a single projectile will shoot 4 more in an arc", "Шесты, запускающие один снаряд, запускают ещё четыре по дуге").Replace("Life Enhancement", "Улучшение здоровья").Replace("Life-Steal", "Кража здоровья").Replace("lethal hits will be ignored", "Смертельные удары будут нейтрализованы").Replace("Mobility Enhancement", "Улучшение подвижности").Replace("Defense Enhancement", "Улучшение защиты").Replace("Stave casts will ignite targets with defense-reducing Phantasmal Flames", "Снаряды шеста поджигают противников призрачными огнями, снижающими защиту");
						tooltipLine.text = resultAd;
					}
					if (tooltipLine.Name == "GuardianIntro")
					{
						string resultAd2 = tooltipLine.text.Replace("Right-clicking will summon a ", "Нажатие правой клавиши мыши призывает существо: ").Replace("  [c/bee7c9:(", " [c/bee7c9:(на ").Replace(" Second Duration)]", " секунд)]").Replace("Nature Pixie", "Природная пикси").Replace("Nature Guardian", "Природный страж").Replace("Ancient Pixie", "Древняя пикси").Replace("Icy Pixie", "Ледовая пикси").Replace("Crimson Fairy", "Багряная фея").Replace("Corrupt Fairy", "Искаженная фея").Replace("Skeletal Guardian", "Страж-скелет").Replace("Corrupt Pixie", "Искаженная пикси").Replace("Marble King Piece", "Осколок мраморного короля").Replace("Mud Guardian", "Грязевой страж").Replace("Holy Statuette", "Святая статуэтка").Replace("Lava Guardian", "Лавовый страж").Replace("Pixie Trinity", "Троица пикси").Replace("Lunar Statuette", "Лунная статуэтка").Replace("Spore Pixie", "Споровая пикси").Replace("Moonflare", "Лунная вспышка").Replace("Sunny Pixie", "Солнечная пикси").Replace("Hallowed Guardian", "Освященный страж").Replace("Crimson Pixie", "Багряная пикси").Replace("Tree of Creation", "Древо созидания").Replace("Terra Guardian", "Терра-страж").Replace("True Holy Statuette", "Истинная святая статуэтка").Replace("True Lunar Statuette", "Истинная лунная статуэтка").Replace("Sapphiron Spirit", "Дух Сапфирона").Replace("Scarlion Spirit", "Дух Шрамольва").Replace("Ancient Statue", "Древняя статуя").Replace("Boreal Statuette", "Северная статуэтка");
						tooltipLine.text = resultAd2;
					}
				}
			}
		}
	}
}
