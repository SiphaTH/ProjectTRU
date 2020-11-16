using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Items
{
	public class Meters : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			Mod calamity = ModLoader.GetMod("CalamityMod");
			
			if (calamity != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (CalamityRuTranslate.TRuConfig.CalamityTranslation)
				{
					if (item.type == calamity.ItemType("StatMeter"))
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

					if (item.type == calamity.ItemType("MeleeLevelMeter"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Tells you how high your melee proficiency is", "Показывает вам ваше мастерство воина");
							string resultB = resultA.Replace("While equipped you will gain melee proficiency faster", "Пока экипирован, ускоряет получение мастерства воина");
							string resultC = resultB.Replace("The higher your melee level the higher your melee damage, speed, and critical strike chance", "Чем выше мастерство воина, тем выше урон ближнего боя, скорость атаки ближнего боя и шанс критического удара");
							string resultD = resultC.Replace("Melee proficiency (max of 12500)", "Мастерство воина (максимум 12500)");
							string resultE = resultD.Replace("Melee level (max of 15)", "Уровень воина (максимум 15)");
							string resultF = resultE.Replace("Melee damage increase", "Увеличивает урон ближнего боя на");
							string resultG = resultF.Replace("Melee speed increase", "Увеличивает скорость атаки ближнего боя на");
							string resultH = resultG.Replace("Melee crit increase", "Увеличивает шанс критического удара ближнего боя на");
							tooltipLine.text = resultH;
						}
					}
					
					if (item.type == calamity.ItemType("MagicLevelMeter"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Tells you how high your magic proficiency is", "Показывает вам ваше мастерство мага");
							string resultB = resultA.Replace("While equipped you will gain magic proficiency faster", "Пока экипирован, ускоряет получение мастерства мага");
							string resultC = resultB.Replace("The higher your magic level the higher your magic damage, critical strike chance, and the lower your mana cost", "Чем выше мастерство мага, тем выше магический урон, шанс критического удара и меньший расход маны");
							string resultD = resultC.Replace("Magic proficiency (max of 12500)", "Мастерство мага (максимум 12500)");
							string resultE = resultD.Replace("Magic level (max of 15)", "Уровень мага (максимум 15)");
							string resultF = resultE.Replace("Magic damage increase", "Увеличивает магический урон на");
							string resultG = resultF.Replace("Mana usage decrease", "Снижает расход маны на");
							string resultH = resultG.Replace("Magic crit increase", "Увеличивает магический шанс критического удара на");
							tooltipLine.text = resultH;
						}
					}
					
					if (item.type == calamity.ItemType("RangedLevelMeter"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Tells you how high your ranged proficiency is", "Показывает вам ваше мастерство стрелка");
							string resultB = resultA.Replace("While equipped you will gain ranged proficiency faster", "Пока экипирован, ускоряет получение мастерства стрелка");
							string resultC = resultB.Replace("The higher your ranged level the higher your ranged damage, critical strike chance, and movement speed", "Чем выше мастерство стрелка, тем выше стрелковый урон, шанс критического удара и скорость передвижения");
							string resultD = resultC.Replace("Ranged proficiency (max of 12500)", "Мастерство стрелка (максимум 12500)");
							string resultE = resultD.Replace("Ranged level (max of 15)", "Уровень стрелка (максимум 15)");
							string resultF = resultE.Replace("Ranged damage increase", "Увеличивает стрелковый урон на");
							string resultG = resultF.Replace("Movement speed increase", "Увеличивает скорость передвижения на");
							string resultH = resultG.Replace("Ranged crit increase", "Увеличивает стрелковый шанс критического удара на");
							tooltipLine.text = resultH;
						}
					}
					
					if (item.type == calamity.ItemType("RogueLevelMeter"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Tells you how high your rogue proficiency is", "Показывает вам ваше мастерство разбойника");
							string resultB = resultA.Replace("While equipped you will gain rogue proficiency faster", "Пока экипирован, ускоряет получение мастерства разбойника");
							string resultC = resultB.Replace("The higher your rogue level the higher your rogue damage, critical strike chance, and velocity", "Чем выше мастерство разбойника, тем выше разбойный урон, шанс критического удара и скорость снарядов");
							string resultD = resultC.Replace("Rogue proficiency (max of 12500)", "Мастерство разбойника (максимум 12500)");
							string resultE = resultD.Replace("Rogue level (max of 15)", "Уровень разбойника (максимум 15)");
							string resultF = resultE.Replace("Rogue damage increase", "Увеличивает разбойный урон на");
							string resultG = resultF.Replace("Rogue velocity increase", "Увеличивает скорость снарядов разбойника на");
							string resultH = resultG.Replace("Rogue crit increase", "Увеличивает разбойный шанс критического удара на");
							tooltipLine.text = resultH;
						}
					}
					
					if (item.type == calamity.ItemType("SummonLevelMeter"))
					{
						foreach (TooltipLine tooltipLine in tooltips)
						{
							string str = tooltipLine.text;
							string resultA = str.Replace("Tells you how high your summon proficiency is", "Показывает вам ваше мастерство призывателя");
							string resultB = resultA.Replace("While equipped you will gain summon proficiency faster", "Пока экипирован, ускоряет получение мастерства призывателя");
							string resultC = resultB.Replace("The higher your summon level the higher your minion damage, knockback, and slots", "Чем выше мастерство призывателя, тем выше урон миньонов, отбрасывание миньонов и миньон-слотов");
							string resultD = resultC.Replace("Summon proficiency (max of 12500)", "Мастерство призывателя (максимум 12500)");
							string resultE = resultD.Replace("Summon level (max of 15)", "Уровень призывателя (максимум 15)");
							string resultF = resultE.Replace("Minion damage increase", "Увеличивает урон миньонов на");
							string resultG = resultF.Replace("Minion knockback increase", "Увеличивает отбрасывание миньонов на");
							string resultH = resultG.Replace("Minion slot increase", "Увеличивает миньон-слоты на");
							tooltipLine.text = resultH;
						}
					}
				}
			}
		}
	}
}
