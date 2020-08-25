using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Items
{
	public class StatMeter : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (ModLoader.GetMod("CalamityMod") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatMeter"))
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Displays almost all player stats", "Отображает почти все характеристики игрока");
						string resultB = resultA.Replace("Offensive stats displayed vary with held item", "Атакующая характеристика отображается в зависимости от удерживаемого предмета");
						string resultC = resultB.Replace("Adrenaline Charge Time", "Время зарядки адреналина");
						string resultD = resultC.Replace("Rage Damage Boost", "Увеличение урона от ярости");
						string resultE = resultD.Replace("True Melee Damage", "Истинный урон ближнего боя");
						string resultF = resultE.Replace("Melee Damage", "Урон ближнего боя");
						string resultG = resultF.Replace("Melee Crit Chance", "Шанс критического удара ближнего боя");
						string resultH = resultG.Replace("Melee Speed Boost", "Скорость атаки ближнего боя");
						string resultI = resultH.Replace("Ranged Damage", "Стрелковый урон");
						string resultJ = resultI.Replace("Ranged Crit Chance", "Стрелковый шанс критического удара");
						string resultK = resultJ.Replace("Ammo Consumption Chance", "Шанс использовать боеприпасы");
						string resultL = resultK.Replace("Magic Damage", "Магический урон");
						string resultM = resultL.Replace("Magic Crit Chance", "Магический шанс критического удара");
						string resultN = resultM.Replace("Mana Usage", "Расход маны");
						string resultO = resultN.Replace("Mana Regen", "Регенерация маны");
						string resultP = resultO.Replace("Minion Damage", "Урон миньонов");
						string resultQ = resultP.Replace("Minion Slots", "Миньон-слотов");
						string resultR = resultQ.Replace("Rogue Damage", "Разбойный урон");
						string resultS = resultR.Replace("Rogue Crit Chance", "Разбойный шанс критического удара");
						string resultT = resultS.Replace("Rogue Velocity Boost", "Увеличение скорости снарядов разбойника");
						string resultU = resultT.Replace("Rogue Weapon Consumption Chance", "Вероятность потребления разбойного оружия");
						string resultV = resultU.Replace("Max Stealth", "Максимальная скрытность");
						string resultW = resultV.Replace("Standing Regen", "Стоячая регенерация");
						string resultX = resultW.Replace("seconds", "секунд");
						string resultZ = resultX.Replace("Moving Regen", "Подвижная регенерация");
						string resultAa = resultZ.Replace("Defense Lost", "Потерянная защита");
						string resultAb = resultAa.Replace("DR", "Сопротивление урону");
						string resultAc = resultAb.Replace("Life Regen", "Регенерация здоровья");
						string resultAd = resultAc.Replace("Armor Penetration", "Пробивание брони");
						string resultAe = resultAd.Replace("sec", "сек");
						string resultAf = resultAe.Replace("Wing Flight Time", "Время полёта крыльев");
						string resultAg = resultAf.Replace("Jump Speed Boost", "Увеличение скорости прыжка");
						string resultAh = resultAg.Replace("Movement Speed Boost", "Увеличение скорости передвижения");
						string resultAi = resultAh.Replace("Abyss/Cave Light Strength", "Сила света в бездне/пещере");
						string resultAj = resultAi.Replace("Abyss Light Strength", "Сила света в бездне");
						string resultAk = resultAj.Replace("Other Abyss Stats", "Другие характеристики бездны");
						string resultAl = resultAk.Replace("Breath Lost Per Tick", "Потеря дыхания за тик");
						string resultAm = resultAl.Replace("Breath Loss Rate", "Скорость потери дыхания");
						string resultAn = resultAm.Replace("Defense", "Защита");
						string resultAo = resultAn.Replace("Life Lost Per Tick at Zero Breath", "Потеря здоровья за тик при нулевом дыхании");
						string resultAp = resultAo.Replace("Abyss stats only displayed while in the Abyss", "Характеристики бездны отображаются только во время нахождения в бездне");
						tooltipLine.text = resultAp;

					}
				}
			}
		}
	}
}
