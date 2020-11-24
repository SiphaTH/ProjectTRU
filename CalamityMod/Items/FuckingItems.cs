using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Items
{
	public class FuckingItems : GlobalItem
	{
        public override void SetDefaults(Item item)
        {
	        if (ModCompatibility.CalamityMod != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
	            if (CalamityRuTranslate.TRuConfig.CalamityTranslation)
	            {
		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultBathtub"))
		            {
			            item.SetNameOverride("Потусторонняя ванна");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultBed"))
		            {
			            item.SetNameOverride("Потусторонняя кровать");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultBookcase"))
		            {
			            item.SetNameOverride("Потусторонний книжный шкаф");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultCandelabra"))
		            {
			            item.SetNameOverride("Потусторонний канделябр");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultCandle"))
		            {
			            item.SetNameOverride("Потусторонняя свеча");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultChair"))
		            {
			            item.SetNameOverride("Потусторонний стул");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultChandelier"))
		            {
			            item.SetNameOverride("Потусторонняя люстра");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultChest"))
		            {
			            item.SetNameOverride("Потусторонний сундук");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultClock"))
		            {
			            item.SetNameOverride("Потусторонние часы");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultDoor"))
		            {
			            item.SetNameOverride("Потусторонняя дверь");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultDresser"))
		            {
			            item.SetNameOverride("Потусторонний комод");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultLamp"))
		            {
			            item.SetNameOverride("Потусторонняя лампа");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultLantern"))
		            {
			            item.SetNameOverride("Потусторонний фонарь");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultPiano"))
		            {
			            item.SetNameOverride("Потустороннее пианино");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultPlatform"))
		            {
			            item.SetNameOverride("Потусторонняя платформа");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultSink"))
		            {
			            item.SetNameOverride("Потусторонняя раковина");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultSofa"))
		            {
			            item.SetNameOverride("Потусторонний диван");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultStone"))
		            {
			            item.SetNameOverride("Потусторонний камень");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultTable"))
		            {
			            item.SetNameOverride("Потусторонний стол");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultWorkBench"))
		            {
			            item.SetNameOverride("Потусторонний верстак");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("OccultStoneWall"))
		            {
			            item.SetNameOverride("Стена из потустороннего камня");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("StratusWorkbench"))
		            {
			            item.SetNameOverride("Слоистый верстак");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("StatigelWorkbench"))
		            {
			            item.SetNameOverride("Статиджеловый верстак");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("StatigelBath"))
		            {
			            item.SetNameOverride("Статиджеловая ванна");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("ProfanedWorkbench"))
		            {
			            item.SetNameOverride("Осквернённый верстак");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("ProfanedBath"))
		            {
			            item.SetNameOverride("Осквернённая ванна");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("VoidWorkbench"))
		            {
			            item.SetNameOverride("Пустотный верстак");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("VoidClock"))
		            {
			            item.SetNameOverride("Пустотный обелиск");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("VoidBath"))
		            {
			            item.SetNameOverride("Пустотная ванна");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("PlaguedPlateWorkbench"))
		            {
			            item.SetNameOverride("Чумной верстак");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("CosmiliteWorkbench"))
		            {
			            item.SetNameOverride("Космилитовый верстак");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("CosmiliteBath"))
		            {
			            item.SetNameOverride("Космилитовая ванна");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("AshenPiano"))
		            {
			            item.SetNameOverride("Пепельный трубный орган");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("AshenWorkbench"))
		            {
			            item.SetNameOverride("Пепельный верстак");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("EutrophicCrafting"))
		            {
			            item.SetNameOverride("Эвтрофная полка");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithCrafting"))
		            {
			            item.SetNameOverride("Монолитное слияние");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("ProfanedBasin"))
		            {
			            item.SetNameOverride("Осквернённый тигель");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("SilvaBasin"))
		            {
			            item.SetNameOverride("Лучезарный манипулятор");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("AbyssBath"))
		            {
			            item.SetNameOverride("Ванна бездны");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("AbyssWorkbench"))
		            {
			            item.SetNameOverride("Верстак бездны");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("AbyssPiano"))
		            {
			            item.SetNameOverride("Синтезатор бездны");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("AncientBath"))
		            {
			            item.SetNameOverride("Древняя ванна");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("AshenBath"))
		            {
			            item.SetNameOverride("Пепельная ванна");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("AncientWorkbench"))
		            {
			            item.SetNameOverride("Древний верстак");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("AncientPiano"))
		            {
			            item.SetNameOverride("Древний трубный орган");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithBathtub"))
		            {
			            item.SetNameOverride("Монолитная ванна");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithBed"))
		            {
			            item.SetNameOverride("Монолитная кровать");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithBench"))
		            {
			            item.SetNameOverride("Монолитная скамья");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithBookcase"))
		            {
			            item.SetNameOverride("Монолитный книжный шкаф");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithCandelabra"))
		            {
			            item.SetNameOverride("Монолитный канделябр");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithCandle"))
		            {
			            item.SetNameOverride("Монолитная свеча");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithChair"))
		            {
			            item.SetNameOverride("Монолитный стул");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithChandelier"))
		            {
			            item.SetNameOverride("Монолитная люстра");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithChest"))
		            {
			            item.SetNameOverride("Монолитный сундук");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithClock"))
		            {
			            item.SetNameOverride("Монолитные часы");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithDoor"))
		            {
			            item.SetNameOverride("Монолитная дверь");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithDresser"))
		            {
			            item.SetNameOverride("Монолитный комод");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithLamp"))
		            {
			            item.SetNameOverride("Монолитная лампа");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithLantern"))
		            {
			            item.SetNameOverride("Монолитный фонарь");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithPiano"))
		            {
			            item.SetNameOverride("Монолитное пианино");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithPlatform"))
		            {
			            item.SetNameOverride("Монолитная платформа");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithSink"))
		            {
			            item.SetNameOverride("Монолитная раковина");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithTable"))
		            {
			            item.SetNameOverride("Монолитный стол");
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MonolithWorkBench"))
		            {
			            item.SetNameOverride("Монолитный верстак");
		            }
	            }
            }
        }
        
		public override void ModifyTooltips(Item item, List < TooltipLine > tooltips)
		{
			if (ModCompatibility.CalamityMod != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
	            if (CalamityRuTranslate.TRuConfig.CalamityTranslation)
	            {
		            if (item.type == ModCompatibility.CalamityMod.ItemType("AsgardianAegis"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip5")
				            {
					            tooltipLine.text = "Нажмите " + ModCompatibility.AegisHotKey + ", для активации баффов увеличивающий весь урон, шанс критического удара и защиту";
				            }
			            }
		            }
		            
		            if (item.type == ModCompatibility.CalamityMod.ItemType("AstralArcanum"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip5")
				            {
					            tooltipLine.text = "Нажмите " + ModCompatibility.AstralArcanumUIHotkey + ", для открытия меню телепортации";
				            }
			            }
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("CelestialJewel"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip6")
				            {
					            tooltipLine.text = "Нажмите " + ModCompatibility.AstralArcanumUIHotkey + ", для телепортации в случайное место";
				            }
			            }
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("ElysianAegis"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip5")
				            {
					            tooltipLine.text = "Нажмите " + ModCompatibility.AegisHotKey + ", для активации баффов увеличивающий весь урон, шанс критического удара и защиту";
				            }
			            }
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("MomentumCapacitor"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip0")
				            {
					            tooltipLine.text = "Нажатие " + ModCompatibility.MomentumCapacitatorHotkey + ", создаёт энергетическое поле в позиции курсора мыши при этом затрачивает 30% от максимальной скрытности";
				            }
			            }
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("Nanotech"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            string str = tooltipLine.text;
				            string resultA = str.Replace("Rogue Crit Level: ", "Количество разбойных критических ударов: ");
				            tooltipLine.text = resultA;
			            }
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("ProfanedSoulCrystal"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            string str = tooltipLine.text;
				            string resultA = str.Replace("Transforms you into an emissary of the profaned goddess", "Превращает вас в эмиссара осквернённой богини");
				            string resultB = resultA.Replace("Requires 10 minion slots to use in order to grant the following effects", "Требуется 10 миньон-слотов, чтобы использовать следующие эффекты");
				            string resultC = resultB.Replace("All non-summon weapons are converted into powerful summon variations", "Всё оружие не призывателя преобразуется в мощные вариации призыва");
				            string resultD = resultC.Replace("Falling below 50% life will empower these attacks", "Падение здоровья ниже 50% усилит эти атаки");
				            string resultE = resultD.Replace("Transforms Melee attacks into a barrage of spears", "Превращает атаки ближнего боя в шквал копий");
				            string resultF = resultE.Replace("Transforms Magic attacks into a powerful splitting fireball", "Превращает магические атаки в мощный разделяющийся огненный шар");
				            string resultG = resultF.Replace("Transforms Ranged attacks into a flurry of fireballs and meteors", "Превращает стрелковые атаки в порыв огненных шаров и метеоров");
				            string resultH = resultG.Replace("Transforms Rogue attacks into a deadly crystalline spiral", "Превращает разбойные атаки в смертельную кристаллическую спираль");
				            string resultI = resultH.Replace("Summons and empowers the profaned babs to fight alongside you", "Призывает и разрешает осквернённым малышам сражаться бок о бок с вами");
				            string resultJ = resultI.Replace("You are no longer affected by burn out when hit", "Вы больше не подвержены к горению когда вас бьют");
				            string resultK = resultJ.Replace("Provides buffs depending on the time of day", "Дарует баффы в зависимости от времени суток");
				            string resultL = resultK.Replace("Provides heat and cold protection in Death Mode", "Обеспечивает защитой от жары и холода в режиме Смерти");
				            string resultM = resultL.Replace("Thinking back, it was a boring life", "Вспоминая, я понимаю, что это была скучная жизнь");
				            string resultN = resultM.Replace("And so we burn it all in the name of purity", "И поэтому мы сжигаем всё это во имя чистоты");
				            string resultO = resultN.Replace("The soul within this crystal has been defiled by the powerful magic of a supreme witch", "Душа в этом кристалле была развращена могущественной магией высшей ведьмы");
				            string resultP = resultO.Replace("Merchants will reject a defiled soul such as this.", "Торговцы отвергнут осквернённую душу, такую как эта");
				            string resultQ = resultP.Replace("Transforms Magic attacks into a powerful splitting fireball for ", "Превращает магические атаки в мощный разделяющийся огненный шар за ");
				            string resultR = resultQ.Replace(" mana per cast", " маны");
				            tooltipLine.text = resultR;
			            }
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("RaidersTalisman"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            string str = tooltipLine.text;
				            string resultA = str.Replace("Rogue Crit Level: ", "Количество разбойных критических ударов: ");
				            tooltipLine.text = resultA;
			            }
		            }
		            
		            if (item.type == ModCompatibility.CalamityMod.ItemType("SandCloak"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip1")
				            {
					            tooltipLine.text = "Нажатие " + ModCompatibility.SandCloakHotkey + ", создаёт защитную завесу пыли, увеличивающую защиту на 6 и регенерацию здоровья на 2, при этом затрачивает 25% от максимальной скрытности";
				            }
			            }
		            }
		            
		            if (item.type == ModCompatibility.CalamityMod.ItemType("SpectralVeil"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip1")
				            {
					            tooltipLine.text = "Нажатие " + ModCompatibility.SpectralVeilHotKey + ", выполняет телепортацию на короткое расстояние, делая вас на мгновение неуязвимым, при этом затрачивает 25% от максимальной скрытности";
				            }
			            }
		            }
		            
		            if (item.type == ModCompatibility.CalamityMod.ItemType("NormalityRelocator"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip1")
				            {
					            tooltipLine.text = "Нажмите " + ModCompatibility.NormalityRelocatorHotKey + ", для телепортации в положение курсора мыши";
				            }
			            }
		            }
		            
		            if (item.type == ModCompatibility.CalamityMod.ItemType("Eternity"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            string str = tooltipLine.text;
				            string resultA = str.Replace("There's pictures of ponies in the book", "В книге изображены пони");
				            tooltipLine.text = resultA;
			            }
		            }
		            
		            if (item.type == ModCompatibility.CalamityMod.ItemType("PlaguedFuelPack"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip2")
				            {
					            tooltipLine.text = "Нажатие " + ModCompatibility.PlaguePackHotKey + ", выполняет стремительный рывок вверх/по диагонали, который оставляет за собой след чумных облаков, при этом затрачивает 25% от максимальной скрытности";
				            }
			            }
		            }
		            
		            if (ModLoader.GetMod("Fargowiltas") != null)
		            {
			            if (item.type == ModCompatibility.CalamityMod.ItemType("SunkenSeaFountain"))
			            {
				            foreach (TooltipLine tooltipLine in tooltips)
				            {
					            if (tooltipLine.Name == "Tooltip0")
					            {
						            tooltipLine.text = "Ваше окружение меняется на затерянное море при активации";
					            }
				            }
			            }
			            
			            if (item.type == ModCompatibility.CalamityMod.ItemType("SulphurousFountainItem"))
			            {
				            foreach (TooltipLine tooltipLine in tooltips)
				            {
					            if (tooltipLine.Name == "Tooltip0")
					            {
						            tooltipLine.text = "Ваше окружение меняется на сернистое море при активации";
					            }
				            }
			            }
			            
			            if (item.type == ModCompatibility.CalamityMod.ItemType("AstralFountainItem"))
			            {
				            foreach (TooltipLine tooltipLine in tooltips)
				            {
					            if (tooltipLine.Name == "Tooltip0")
					            {
						            tooltipLine.text = "Ваше окружение меняется на астрал при активации";
					            }
				            }
			            }
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("Revenge"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip1")
				            {
					            tooltipLine.text = "Активирует ярость. Когда шкала ярости заполнена, нажмите " + ModCompatibility.RageHotKey + ", для активации ярости";
				            }
				            
				            if (tooltipLine.Name == "Tooltip3")
				            {
					            tooltipLine.text = "Активирует адреналин. Когда шкала адреналина заполнена, нажмите " + ModCompatibility.AdrenalineHotKey + ", для активации адреналина";
				            }
			            }
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("CosmicWorm"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip1")
				            {
					            tooltipLine.text = ModCompatibility.DownedFlag
						            ? "Внимание! Некоторые стражи ещё не были по-настоящему побеждены и будут сражаться в полную силу во время этой битвы!"
						            : "";
				            }
			            }
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("BlunderBooster"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip2")
				            {
					            tooltipLine.text = "Нажатие" + ModCompatibility.PlaguePackHotKey + ", выполняет стремительный рывок вверх/по диагонали, который оставляет за собой след молний, при этом затрачивает 25% от максимальной скрытности";
				            }
			            }
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("GrandGelatin"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip1")
				            {
					            tooltipLine.text = Main.player[Main.myPlayer].autoJump ? 
						            "Увеличивает скорость прыжка на 10%" : 
						            "Увеличивает скорость прыжка на 40%";
				            }
			            }
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("VitalJelly"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip1")
				            {
					            tooltipLine.text = Main.player[Main.myPlayer].autoJump ? 
						            "Увеличивает скорость прыжка на 6%" : 
						            "Увеличивает скорость прыжка на 24%";
				            }
			            }
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("KnowledgeKingSlime"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip2")
				            {
					            tooltipLine.text = Main.player[Main.myPlayer].autoJump ? 
						            "Пометьте как избранное, чтобы увеличить скорость передвижения на 5%" : 
						            "Пометьте как избранное, чтобы увеличить скорость передвижения на 5% и скорость прыжка на 2%";
				            }
			            }
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("AbandonedSlimeStaff"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip4")
				            {
					            tooltipLine.text = Main.player[Main.myPlayer].autoJump ? 
						            "Пока этот предмет в ваших руках увеличивает скорость прыжка на 5%" : 
						            "Пока этот предмет в ваших руках увеличивает скорость прыжка на 20%";
				            }
			            }
		            }

		            if (item.type == ModCompatibility.CalamityMod.ItemType("AeroStone"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip1")
				            {
					            tooltipLine.text = Main.player[Main.myPlayer].autoJump ? 
						            "Увеличивает скорость передвижения на 10%, скорость прыжка на 5% и весь урон на 3%" : 
						            "Увеличивает скорость передвижения на 10%, скорость прыжка на 20% и весь урон на 3%";
				            }
			            }
		            }
		            
		            if (item.type == ModCompatibility.CalamityMod.ItemType("SunkenStew"))
		            {
			            foreach (TooltipLine tooltipLine in tooltips)
			            {
				            if (tooltipLine.Name == "Tooltip0")
				            {
					            tooltipLine.text = Main.player[Main.myPlayer].pStone ? 
						            "Накладывает дебафф «Послезельевая болезнь» на 37 секунд" : 
						            "Накладывает дебафф «Послезельевая болезнь» на 50 секунд";
				            }
			            }
		            }
	            }
            }
        }
    }
}
