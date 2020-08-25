using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Buffs
{
    public class VanillaBuffs: GlobalBuff
	{
		public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            Mod calamity = ModLoader.GetMod("CalamityMod");
            if (calamity != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                switch (type)
                {
                case 179:
					tip = "Увеличенный урон на 7.5%";
					break;
				case 180:
					tip = "Увеличенный урон на 15%";
					break;
				case 181:
					tip = "Увеличенный урон на 22.5%";
					break;
				case 95:
					tip = "Получаемый урон снижен на 10%";
					break;
				case 96:
					tip = "Получаемый урон снижен на 20%";
					break;
				case 97:
					tip = "Получаемый урон снижен на 30%";
					break;
				case 71:
					tip = "Разбойные и ближние атаки накладывают на ваших врагов «Яд»";
					break;
				case 73:
					tip = "Разбойные и ближние атаки накладывают на врагов «Проклятый огонь»";
					break;
				case 74:
					tip = "Разбойные и ближние атаки поджигают врагов";
					break;
				case 75:
					tip = "При разбойных и ближних атаках враги оставляют больше золота";
					break;
				case 76:
					tip = "Разбойные и ближние атаки снижают защиту врагов";
					break;
				case 77:
					tip = "Разбойные и ближние атаки накладывают на врагов «Запутанность»";
					break;
				case 78:
					tip = "Разбойные и ближние атаки вызывают появление конфетти";
					break;
				case 79:
					tip = "Разбойные и ближние атаки отравляют врагов";
					break;
				case 62:
					tip = "Получаемый урон снижен на 15%";
					break;
				case 88:
					tip = "Телепорты жезла раздора отключены";
					break;
				case 39:
					if (tip == "Теряет жизнь. All damage taken increased by 20%")
					{
						tip = "Теряет жизнь. Весь получаемый урон увеличен на 20%";
					}
					break;
				case 124:
					if (tip == "Снижает урон от источников холода. Immunity to the Chilled, Frozen, and Glacial State debuffs")
					{
						tip = "Снижает урон от источников холода. Невосприимчивость к «Охлаждению», «Заморозке», и «Ледниковому состоянию»";
					}
					if (tip == "Снижает урон от источников холода. Immunity to the Chilled, Frozen, and Glacial State debuffs. Provides cold protection in Death Mode")
					{
						tip = "Снижает урон от источников холода. Невосприимчивость к «Охлаждению», «Заморозке», и «Ледниковому состоянию». Обеспечивает защитой от холода в режиме Смерти";
					}
					break;
				case 10:
					tip = "Даёт невидимость. Дарует разбойные бонусы, держа в руках определённое разбойное оружие";
					break;
				case 1:
					if (tip == "Невосприимчивость к лаве. Provides heat protection in Death Mode")
					{
						tip = "Невосприимчивость к лаве. Обеспечивает защитой от жары в режиме Смерти";
					}
					break;
				case 116:
					if (tip == "враги поблизости воспламеняются. Provides cold protection in Death Mode")
					{
						tip = "враги поблизости воспламеняются. Обеспечивает защитой от холода в режиме Смерти";
					}
					break;
				case 87:
					if (tip == "Восстановление жизни немного ускорено. Provides cold protection in Death Mode")
					{
						tip = "Восстановление жизни немного ускорено. Обеспечивает защитой от холода в режиме Смерти";
					}
					break;
				case 189:
					tip = "Сжигается солнечными лучами";
					break;
				}
                
                if (type == calamity.BuffType("Molten"))
                {
                    if (tip == "Сопротивление к эффектам холода. Provides cold protection in Death Mode")
                    {
                        tip = "Сопротивление к эффектам холода. Обеспечивает защитой от холода в режиме Смерти";
                    }
                }
                
                if (type == calamity.BuffType("ProfanedBabs"))
                {
	                if (tip == "The Profaned Babs will accompany you!")
	                {
		                tip = "Осквернённые малыши будут сопровождать вас!";
	                }
	                if (tip == "The Profaned Babs will fight for and defend you!")
	                {
		                tip = "Осквернённые малыши будут сражаться и защищать вас";
	                }
	                if (tip == "The Defensive Duo will protect and heal you!")
	                {
		                tip = "Защитный дуэт будет защищать и исцелять вас!";
	                }
	                if (tip == "The Offensive Duo will fight for and heal you!")
	                {
		                tip = "Атакующий дуэт будет сражаться и исцелять вас!";
	                }
                }
                
                if (type == calamity.BuffType("ProfanedCrystalBuff"))
                {
                    if (tip == "An ascended ice construct is suppressing your true potential..")
					{
						tip = "Вознесённая ледяная конструкция подавляет ваш истинный потенциал..";
					}
					if (tip == "A magical hat overwhelms your senses, squandering your true potential..")
					{
						tip = "Волшебная шляпа подавляет ваши чувства, растрачивая ваш истинный потенциал..";
					}
					if (tip == "Your profaned soul is constrained by your insufficient summoning powers")
					{
						tip = "Ваша осквернённая душа скована вашей недостаточной силой призыва";
					}
					if (tip == "You are an emissary of the profaned goddess now!\nThe light of the sun empowers your offensive capabilities")
					{
						tip = "Теперь вы эмиссар осквернённой богини!\nСвет солнца усиливает ваши атакующие способности";
					}
					if (tip == "You are an emissary of the profaned goddess now!\nThe darkness of night cools your flames, empowering your defensive capabilities")
					{
						tip = "Теперь вы эмиссар осквернённой богини!\nНочная тьма охлаждает ваше пламя, усиливая ваши защитные способности";
					}
					if (tip == "You are an emissary of the profaned goddess now!\nThe water douses your flames, empowering your defensive capabilities")
					{
						tip = "Теперь вы эмиссар осквернённой богини!\nВода гасит ваше пламя, усиливая ваши защитные способности";
					}
					if (tip == "You are an emissary of the profaned goddess now!\nThe heat of the lava empowers your offensive capabilities")
					{
						tip = "Теперь вы эмиссар осквернённой богини!\nЖар лавы усиливает ваши атакующие способности";
					}
					if (tip == "You are an emissary of the profaned goddess now!\nThe honey cools your flames, empowering your defensive capabilities")
					{
						tip = "Теперь вы эмиссар осквернённой богини!\nМёд охлаждает ваше пламя, усиливая ваши защитные способности";
					}
					if (tip == "You are an emissary of the profaned goddess now!\nThe water douses your flames, empowering your defensive capabilities\nYour weakened life force fuels your desperate attacks")
					{
						tip = "Теперь вы эмиссар осквернённой богини!\nВода гасит ваше пламя, усиливая ваши защитные способности\nВаша ослабленная жизненная сила подпитывает ваши отчаянные атаки";
					}
					if (tip == "You are an emissary of the profaned goddess now!\nThe heat of the lava empowers your offensive capabilities\nYour weakened life force fuels your desperate attacks")
					{
						tip = "Теперь вы эмиссар осквернённой богини!\nЖар лавы усиливает ваши атакующие способности\nВаша ослабленная жизненная сила подпитывает ваши отчаянные атаки";
					}
					if (tip == "You are an emissary of the profaned goddess now!\nThe light of the sun empowers your offensive capabilities\nYour weakened life force fuels your desperate attacks")
					{
						tip = "Теперь вы эмиссар осквернённой богини!\nСвет солнца усиливает ваши атакующие способности\nВаша ослабленная жизненная сила подпитывает ваши отчаянные атаки";
					}
					if (tip == "You are an emissary of the profaned goddess now!\nThe honey cools your flames, empowering your defensive capabilities\nYour weakened life force fuels your desperate attacks")
					{
						tip = "Теперь вы эмиссар осквернённой богини!\nМёд охлаждает ваше пламя, усиливая ваши защитные способности\nВаша ослабленная жизненная сила подпитывает ваши отчаянные атаки";
					}
                }
                
                if (type == calamity.BuffType("Horror"))
                {
                    if (tip == "The horror fuels your strength")
                    {
                        tip = "Ужас подпитывает вашу силу";
                    }
                }
            }
        }
    }
}
