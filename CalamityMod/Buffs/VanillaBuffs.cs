using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Buffs
{
    public class VanillaBuffs: GlobalBuff
	{
		public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
	        if (ModCompatibility.CalamityMod != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
	            if (CalamityRuTranslate.TRuConfig.CalamityTranslation)
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
				            if (ModCompatibility.Revenge)
				            {
					            tip = Language.GetTextValue("BuffDescription.CursedInferno") + ". Весь получаемый урон увеличен на 20%";
				            }
				            break;
			            case 124:
				            tip = ModCompatibility.DeathMode ? 
					            Language.GetTextValue("BuffDescription.Warmth") + "\nНевосприимчивость к дебаффам «Охлаждение», «Заморозка», и «Ледниковое состояние»\nОбеспечивает защитой от холода в режиме Смерти" : 
					            Language.GetTextValue("BuffDescription.Warmth") + "\nНевосприимчивость к дебаффам «Охлаждение», «Заморозка», и «Ледниковое состояние»";
				            break;
			            case 10:
				            tip = Language.GetTextValue("BuffDescription.Invisibility") + ". Дарует разбойные бонусы, держа в руках определённое разбойное оружие";
				            break;
			            case 1:
				            if (ModCompatibility.DeathMode)
				            {
					            tip = Language.GetTextValue("BuffDescription.ObsidianSkin") + ". Обеспечивает защитой от жары в режиме Смерти";
				            }
				            break;
			            case 116:
				            if (ModCompatibility.DeathMode)
				            {
					            tip = Language.GetTextValue("BuffDescription.Inferno") + ". Обеспечивает защитой от холода в режиме Смерти";
				            }
				            break;
			            case 87:
				            if (ModCompatibility.DeathMode)
				            {
					            tip = Language.GetTextValue("BuffDescription.Campfire") + ". Обеспечивает защитой от холода в режиме Смерти";
				            }
				            break;
			            case 189:
				            tip = Language.GetTextValue("BuffDescription.Daybreak");
				            break;
		            }

		            if (type == ModCompatibility.CalamityMod.BuffType("Molten"))
		            {
			            if (ModCompatibility.DeathMode)
			            {
				            tip = "Сопротивление к эффектам холода. Обеспечивает защитой от холода в режиме Смерти";
			            }
		            }

		            if (type == ModCompatibility.CalamityMod.BuffType("ProfanedBabs"))
		            {
			            if (tip == "The Profaned Babs will accompany you!")
			            {
				            tip = "Осквернённые малыши будут сопровождать вас!";
			            }

			            if (tip == "The Profaned Babs will fight for and defend you!")
			            {
				            tip = "Осквернённые малыши будут сражаться за вас и защищать вас!";
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

		            if (type == ModCompatibility.CalamityMod.BuffType("ProfanedCrystalBuff"))
		            {
			            if (tip == "An ascended ice construct is suppressing your true potential..")
			            {
				            tip = "Возвышенная ледяная конструкция подавляет ваш истинный потенциал";
			            }

			            if (tip == "A magical hat overwhelms your senses, squandering your true potential..")
			            {
				            tip = "Волшебная шляпа переполняет ваши чувства, растрачивая ваш истинный потенциал";
			            }

			            if (tip == "Your profaned soul is constrained by your insufficient summoning powers")
			            {
				            tip = "Ваша осквернённая душа скована вашей недостаточной силой призыва";
			            }

			            if (tip == "You are an emissary of the profaned goddess now!\nThe light of the sun empowers your offensive capabilities")
			            {
				            tip = "Теперь вы посланник осквернённой богини!\nСвет солнца усиливает ваши атакующие способности";
			            }

			            if (tip == "You are an emissary of the profaned goddess now!\nThe darkness of night cools your flames, empowering your defensive capabilities")
			            {
				            tip = "Теперь вы посланник осквернённой богини!\nНочная тьма охлаждает ваше пламя, усиливая ваши защитные способности";
			            }

			            if (tip == "You are an emissary of the profaned goddess now!\nThe water douses your flames, empowering your defensive capabilities")
			            {
				            tip = "Теперь вы посланник осквернённой богини!\nВода гасит ваше пламя, усиливая ваши защитные способности";
			            }

			            if (tip == "You are an emissary of the profaned goddess now!\nThe heat of the lava empowers your offensive capabilities")
			            {
				            tip = "Теперь вы посланник осквернённой богини!\nЖар лавы усиливает ваши атакующие способности";
			            }

			            if (tip == "You are an emissary of the profaned goddess now!\nThe honey cools your flames, empowering your defensive capabilities")
			            {
				            tip = "Теперь вы посланник осквернённой богини!\nМёд охлаждает ваше пламя, усиливая ваши защитные способности";
			            }

			            if (tip == "You are an emissary of the profaned goddess now!\nThe water douses your flames, empowering your defensive capabilities\nYour weakened life force fuels your desperate attacks")
			            {
				            tip = "Теперь вы посланник осквернённой богини!\nВода гасит ваше пламя, усиливая ваши защитные способности\nВаша ослабленная жизненная сила подпитывает ваши отчаянные атаки";
			            }

			            if (tip == "You are an emissary of the profaned goddess now!\nThe heat of the lava empowers your offensive capabilities\nYour weakened life force fuels your desperate attacks")
			            {
				            tip = "Теперь вы посланник осквернённой богини!\nЖар лавы усиливает ваши атакующие способности\nВаша ослабленная жизненная сила подпитывает ваши отчаянные атаки";
			            }

			            if (tip == "You are an emissary of the profaned goddess now!\nThe light of the sun empowers your offensive capabilities\nYour weakened life force fuels your desperate attacks")
			            {
				            tip = "Теперь вы посланник осквернённой богини!\nСвет солнца усиливает ваши атакующие способности\nВаша ослабленная жизненная сила подпитывает ваши отчаянные атаки";
			            }

			            if (tip == "You are an emissary of the profaned goddess now!\nThe honey cools your flames, empowering your defensive capabilities\nYour weakened life force fuels your desperate attacks")
			            {
				            tip = "Теперь вы посланник осквернённой богини!\nМёд охлаждает ваше пламя, усиливая ваши защитные способности\nВаша ослабленная жизненная сила подпитывает ваши отчаянные атаки";
			            }
		            }
	            }
            }
        }
    }
}
