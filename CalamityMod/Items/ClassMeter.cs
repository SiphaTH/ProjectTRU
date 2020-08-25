using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Items
{
	public class ClassMeter : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			Mod calamity = ModLoader.GetMod("CalamityMod");
			if (calamity != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (item.type == calamity.ItemType("MeleeLevelMeter"))
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						if (tooltipLine.Name == "Tooltip0")
						{
							string[] array = Regex.Split(tooltipLine.text, "\n");
							string[] waitArray = Regex.Split(array[3], ": ");
							string[] waitArray2 = Regex.Split(array[4], ": ");
							string[] waitArray3 = Regex.Split(array[5], ": ");
							string[] waitArray4 = Regex.Split(array[6], ": ");
							string[] array2 = Regex.Split(array[7], ": ");
							string str = waitArray[1];
							string str2 = waitArray2[1];
							string str3 = waitArray3[1];
							string str4 = waitArray4[1];
							string str5 = array2[1];
							tooltipLine.text = string.Concat(new object[]
							{
								"Показывает вам ваше мастерство воина\nПока экипирован, ускоряет получение мастерства воина\nЧем выше мастерство воина, тем выше урон ближнего боя, скорость атаки ближнего боя и шанс критического удара\nМастерство воина (максимум 12500): ",
								str,
								"\nУровень воина (максимум 15): ",
								str2,
								"\nУвеличивает урон ближнего боя на: ",
								str3,
								"\nУвеличивает скорость атаки ближнего боя на: ",
								str4,
								"\nУвеличивает шанс критического удара ближнего боя на: ",
								str5
							});
						}
					}
				}
				if (item.type == calamity.ItemType("MagicLevelMeter"))
				{
					foreach (TooltipLine tooltipLine2 in tooltips)
					{
						if (tooltipLine2.Name == "Tooltip0")
						{
							string[] array3 = Regex.Split(tooltipLine2.text, "\n");
							string[] waitArray5 = Regex.Split(array3[3], ": ");
							string[] waitArray6 = Regex.Split(array3[4], ": ");
							string[] waitArray7 = Regex.Split(array3[5], ": ");
							string[] waitArray8 = Regex.Split(array3[6], ": ");
							string[] array4 = Regex.Split(array3[7], ": ");
							string str6 = waitArray5[1];
							string str7 = waitArray6[1];
							string str8 = waitArray7[1];
							string str9 = waitArray8[1];
							string str10 = array4[1];
							tooltipLine2.text = string.Concat(new object[]
							{
								"Показывает вам ваше мастерство мага\nПока экипирован, ускоряет получение мастерства мага\nЧем выше мастерство мага, тем выше магический урон, шанс критического удара и меньший расход маны\nМастерство мага (максимум 12500): ",
								str6,
								"\nУровень мага (максимум 15): ",
								str7,
								"\nУвеличивает магический урон на: ",
								str8,
								"\nСнижает расход маны на: ",
								str9,
								"\nУвеличивает магический шанс критического удара на: ",
								str10
							});
						}
					}
				}
				if (item.type == calamity.ItemType("RangedLevelMeter"))
				{
					foreach (TooltipLine tooltipLine3 in tooltips)
					{
						if (tooltipLine3.Name == "Tooltip0")
						{
							string[] array5 = Regex.Split(tooltipLine3.text, "\n");
							string[] waitArray9 = Regex.Split(array5[3], ": ");
							string[] waitArray10 = Regex.Split(array5[4], ": ");
							string[] waitArray11 = Regex.Split(array5[5], ": ");
							string[] waitArray12 = Regex.Split(array5[6], ": ");
							string[] array6 = Regex.Split(array5[7], ": ");
							string str11 = waitArray9[1];
							string str12 = waitArray10[1];
							string str13 = waitArray11[1];
							string str14 = waitArray12[1];
							string str15 = array6[1];
							tooltipLine3.text = string.Concat(new object[]
							{
								"Показывает вам ваше мастерство стрелка\nПока экипирован, ускоряет получение мастерства стрелка\nЧем выше мастерство стрелка, тем выше стрелковый урон, шанс критического удара и скорость передвижения\nМастерство стрелка (максимум 12500): ",
								str11,
								"\nУровень стрелка (максимум 15): ",
								str12,
								"\nУвеличивает стрелковый урон на: ",
								str13,
								"\nУвеличивает скорость передвижения на: ",
								str14,
								"\nУвеличивает стрелковый шанс критического удара на: ",
								str15
							});
						}
					}
				}
				if (item.type == calamity.ItemType("RogueLevelMeter"))
				{
					foreach (TooltipLine tooltipLine4 in tooltips)
					{
						if (tooltipLine4.Name == "Tooltip0")
						{
							string[] array7 = Regex.Split(tooltipLine4.text, "\n");
							string[] waitArray13 = Regex.Split(array7[3], ": ");
							string[] waitArray14 = Regex.Split(array7[4], ": ");
							string[] waitArray15 = Regex.Split(array7[5], ": ");
							string[] waitArray16 = Regex.Split(array7[6], ": ");
							string[] array8 = Regex.Split(array7[7], ": ");
							string str16 = waitArray13[1];
							string str17 = waitArray14[1];
							string str18 = waitArray15[1];
							string str19 = waitArray16[1];
							string str20 = array8[1];
							tooltipLine4.text = string.Concat(new object[]
							{
								"Показывает вам ваше мастерство разбойника\nПока экипирован, ускоряет получение мастерства разбойника\nЧем выше мастерство разбойника, тем выше разбойный урон, шанс критического удара и скорость снарядов\nМастерство разбойника (максимум 12500): ",
								str16,
								"\nУровень разбойника (максимум 15): ",
								str17,
								"\nУвеличивает разбойный урон на: ",
								str18,
								"\nУвеличивает скорость снарядов разбойника на: ",
								str19,
								"\nУвеличивает разбойный шанс критического удара на: ",
								str20
							});
						}
					}
				}
				if (item.type == calamity.ItemType("SummonLevelMeter"))
				{
					foreach (TooltipLine tooltipLine5 in tooltips)
					{
						if (tooltipLine5.Name == "Tooltip0")
						{
							string[] array9 = Regex.Split(tooltipLine5.text, "\n");
							string[] waitArray17 = Regex.Split(array9[3], ": ");
							string[] waitArray18 = Regex.Split(array9[4], ": ");
							string[] waitArray19 = Regex.Split(array9[5], ": ");
							string[] waitArray20 = Regex.Split(array9[6], ": ");
							string[] array10 = Regex.Split(array9[7], ": ");
							string str21 = waitArray17[1];
							string str22 = waitArray18[1];
							string str23 = waitArray19[1];
							string str24 = waitArray20[1];
							string str25 = array10[1];
							tooltipLine5.text = string.Concat(new object[]
							{
								"Показывает вам ваше мастерство призывателя\nПока экипирован, ускоряет получение мастерства призывателя\nЧем выше мастерство призывателя, тем выше урон миньонов, отбрасывание миньонов и миньон-слотов\nМастерство призывателя (максимум 12500): ",
								str21,
								"\nУровень призывателя (максимум 15): ",
								str22,
								"\nУвеличивает урон миньонов на: ",
								str23,
								"\nУвеличивает отбрасывание миньонов на: ",
								str24,
								"\nУвеличивает миньон-слоты на: ",
								str25
							});
						}
					}
				}
			}
		}
	}
}
