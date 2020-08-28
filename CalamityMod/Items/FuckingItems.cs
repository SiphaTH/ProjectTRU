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
            Mod calamity = ModLoader.GetMod("CalamityMod");
            if (calamity != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                if (item.type == calamity.ItemType("OccultBathtub"))
				{
					item.SetNameOverride("Потусторонняя ванна");
				}
                if (item.type == calamity.ItemType("OccultBed"))
				{
					item.SetNameOverride("Потусторонняя кровать");
				}
                if (item.type == calamity.ItemType("OccultBookcase"))
				{
					item.SetNameOverride("Потусторонний книжный шкаф");
				}
                if (item.type == calamity.ItemType("OccultCandelabra"))
				{
					item.SetNameOverride("Потусторонний канделябр");
				}
                if (item.type == calamity.ItemType("OccultCandle"))
				{
					item.SetNameOverride("Потусторонняя свеча");
				}
                if (item.type == calamity.ItemType("OccultChair"))
				{
					item.SetNameOverride("Потусторонний стул");
				}
                if (item.type == calamity.ItemType("OccultChandelier"))
				{
					item.SetNameOverride("Потусторонняя люстра");
				}
                if (item.type == calamity.ItemType("OccultChest"))
				{
					item.SetNameOverride("Потусторонний сундук");
				}
                if (item.type == calamity.ItemType("OccultClock"))
				{
					item.SetNameOverride("Потусторонние часы");
				}
                if (item.type == calamity.ItemType("OccultDoor"))
				{
					item.SetNameOverride("Потусторонняя дверь");
				}
                if (item.type == calamity.ItemType("OccultDresser"))
				{
					item.SetNameOverride("Потусторонний комод");
				}
                if (item.type == calamity.ItemType("OccultLamp"))
				{
					item.SetNameOverride("Потусторонняя лампа");
				}
                if (item.type == calamity.ItemType("OccultLantern"))
				{
					item.SetNameOverride("Потусторонний фонарь");
				}
                if (item.type == calamity.ItemType("OccultPiano"))
				{
					item.SetNameOverride("Потустороннее пианино");
				}
                if (item.type == calamity.ItemType("OccultPlatform"))
				{
					item.SetNameOverride("Потусторонняя платформа");
				}
                if (item.type == calamity.ItemType("OccultSink"))
				{
					item.SetNameOverride("Потусторонняя раковина");
				}
                if (item.type == calamity.ItemType("OccultSofa"))
				{
					item.SetNameOverride("Потусторонний диван");
				}
                if (item.type == calamity.ItemType("OccultStone"))
				{
					item.SetNameOverride("Потусторонний камень");
				}
                if (item.type == calamity.ItemType("OccultTable"))
				{
					item.SetNameOverride("Потусторонний стол");
				}
                if (item.type == calamity.ItemType("OccultWorkBench"))
				{
					item.SetNameOverride("Потусторонний верстак");
				}
                if (item.type == calamity.ItemType("OccultStoneWall"))
				{
					item.SetNameOverride("Стена из потустороннего камня");
				}
                if (item.type == calamity.ItemType("StratusWorkbench"))
				{
					item.SetNameOverride("Слоистый верстак");
				}
                if (item.type == calamity.ItemType("StatigelWorkbench"))
				{
					item.SetNameOverride("Статиджеловый верстак");
				}
                if (item.type == calamity.ItemType("StatigelBath"))
				{
					item.SetNameOverride("Статиджеловая ванна");
				}
                if (item.type == calamity.ItemType("ProfanedWorkbench"))
				{
					item.SetNameOverride("Осквернённый верстак");
				}
                if (item.type == calamity.ItemType("ProfanedBath"))
				{
					item.SetNameOverride("Осквернённая ванна");
				}
                if (item.type == calamity.ItemType("VoidWorkbench"))
				{
					item.SetNameOverride("Пустотный верстак");
				}
                if (item.type == calamity.ItemType("VoidClock"))
				{
					item.SetNameOverride("Пустотный обелиск");
				}
                if (item.type == calamity.ItemType("VoidBath"))
				{
					item.SetNameOverride("Пустотная ванна");
				}
                if (item.type == calamity.ItemType("PlaguedPlateWorkbench"))
				{
					item.SetNameOverride("Чумной верстак");
				}
                if (item.type == calamity.ItemType("CosmiliteWorkbench"))
				{
					item.SetNameOverride("Космилитовый верстак");
				}
                if (item.type == calamity.ItemType("CosmiliteBath"))
				{
					item.SetNameOverride("Космилитовая ванна");
				}
                if (item.type == calamity.ItemType("AshenPiano"))
				{
					item.SetNameOverride("Пепельный трубный орган");
				}
                if (item.type == calamity.ItemType("AshenWorkbench"))
				{
					item.SetNameOverride("Пепельный верстак");
				}
                if (item.type == calamity.ItemType("EutrophicCrafting"))
				{
					item.SetNameOverride("Эвтрофная полка");
				}
				if (item.type == calamity.ItemType("MonolithCrafting"))
				{
					item.SetNameOverride("Монолитная амальгама");
				}
                if (item.type == calamity.ItemType("ProfanedBasin"))
				{
					item.SetNameOverride("Осквернённый тигель");
				}
                if (item.type == calamity.ItemType("SilvaBasin"))
				{
					item.SetNameOverride("Лучезарный манипулятор");
				}
                if (item.type == calamity.ItemType("AbyssBath"))
				{
					item.SetNameOverride("Ванна бездны");
				}
                if (item.type == calamity.ItemType("AbyssWorkbench"))
				{
					item.SetNameOverride("Верстак бездны");
				}
                if (item.type == calamity.ItemType("AbyssPiano"))
				{
					item.SetNameOverride("Синтезатор бездны");
				}
                if (item.type == calamity.ItemType("AncientBath"))
				{
					item.SetNameOverride("Древняя ванна");
				}
                if (item.type == calamity.ItemType("AshenBath"))
				{
					item.SetNameOverride("Пепельная ванна");
				}
                if (item.type == calamity.ItemType("AncientWorkbench"))
				{
					item.SetNameOverride("Древний верстак");
				}
                if (item.type == calamity.ItemType("AncientPiano"))
				{
					item.SetNameOverride("Древний трубный орган");
				}
				if (item.type == calamity.ItemType("MonolithBathtub"))
				{
					item.SetNameOverride("Монолитная ванна");
				}
				if (item.type == calamity.ItemType("MonolithBed"))
				{
					item.SetNameOverride("Монолитная кровать");
				}
				if (item.type == calamity.ItemType("MonolithBench"))
				{
					item.SetNameOverride("Монолитная скамья");
				}
				if (item.type == calamity.ItemType("MonolithBookcase"))
				{
					item.SetNameOverride("Монолитный книжный шкаф");
				}
				if (item.type == calamity.ItemType("MonolithCandelabra"))
				{
					item.SetNameOverride("Монолитный канделябр");
				}
				if (item.type == calamity.ItemType("MonolithCandle"))
				{
					item.SetNameOverride("Монолитная свеча");
				}
				if (item.type == calamity.ItemType("MonolithChair"))
				{
					item.SetNameOverride("Монолитный стул");
				}
				if (item.type == calamity.ItemType("MonolithChandelier"))
				{
					item.SetNameOverride("Монолитная люстра");
				}
				if (item.type == calamity.ItemType("MonolithChest"))
				{
					item.SetNameOverride("Монолитный сундук");
				}
				if (item.type == calamity.ItemType("MonolithClock"))
				{
					item.SetNameOverride("Монолитные часы");
				}
				if (item.type == calamity.ItemType("MonolithDoor"))
				{
					item.SetNameOverride("Монолитная дверь");
				}
				if (item.type == calamity.ItemType("MonolithDresser"))
				{
					item.SetNameOverride("Монолитный комод");
				}
				if (item.type == calamity.ItemType("MonolithLamp"))
				{
					item.SetNameOverride("Монолитная лампа");
				}
				if (item.type == calamity.ItemType("MonolithLantern"))
				{
					item.SetNameOverride("Монолитный фонарь");
				}
				if (item.type == calamity.ItemType("MonolithPiano"))
				{
					item.SetNameOverride("Монолитное пианино");
				}
				if (item.type == calamity.ItemType("MonolithPlatform"))
				{
					item.SetNameOverride("Монолитная платформа");
				}
				if (item.type == calamity.ItemType("MonolithSink"))
				{
					item.SetNameOverride("Монолитная раковина");
				}
				if (item.type == calamity.ItemType("MonolithTable"))
				{
					item.SetNameOverride("Монолитный стол");
				}
				if (item.type == calamity.ItemType("MonolithWorkBench"))
				{
					item.SetNameOverride("Монолитный верстак");
				}
            }
        }
		public override void ModifyTooltips(Item item, List < TooltipLine > tooltips)
        {
            Mod calamity = ModLoader.GetMod("CalamityMod");
            if (calamity != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                if (item.type == calamity.ItemType("AsgardianAegis"))
                {
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Press ", "Нажмите ");
						string resultB = resultA.Replace(" to activate buffs to all damage, crit chance, and defense", ", чтобы активировать баффы увеличивающий весь урон, шанс критического удара и защиту");
						tooltipLine.text = resultB;
					}
				}

				if (item.type == calamity.ItemType("AstralArcanum"))
                {
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Press ", "Нажмите ");
						string resultB = resultA.Replace(" to toggle teleportation UI", ", чтобы открыть меню телепортации");
						tooltipLine.text = resultB;
					}
				}

				if (item.type == calamity.ItemType("CelestialJewel"))
                {
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Press ", "Нажмите ");
						string resultB = resultA.Replace(" to teleport to a random location", ", чтобы телепортироваться в случайное место");
						tooltipLine.text = resultB;
					}
				}

				if (item.type == calamity.ItemType("ElysianAegis"))
                {
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Press ", "Нажмите ");
						string resultB = resultA.Replace(" to activate buffs to all damage, crit chance, and defense", ", чтобы активировать баффы увеличивающий весь урон, шанс критического удара и защиту");
						tooltipLine.text = resultB;
					}
				}

				if (item.type == calamity.ItemType("MomentumCapacitor"))
                {
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Press ", "Нажатие ");
						string resultB = resultA.Replace(" to consume 30% of your maximum stealth to create an energy field at the cursor position", ", приводит к появлению энергетического поля в позиции курсора, стоимость которого составляет 30% от максимальной скрытности");
						tooltipLine.text = resultB;
					}
				}

                if (item.type == calamity.ItemType("Nanotech"))
                {
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Rogue Crit Level: ", "Количество разбойных критических ударов: ");
						tooltipLine.text = resultA;
					}
				}

				if (item.type == calamity.ItemType("ProfanedSoulCrystal"))
                {
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Transforms you into an emissary of the profaned goddess", "Превращает вас в эмиссара осквернённой богини");
						string resultB = resultA.Replace("Requires 10 minion slots to use in order to grant the following effects", "Требуется 10 миньон-слотов, чтобы использовать следующие эффекты");
						string resultC = resultB.Replace("All non-summon weapons are converted into powerful summon variations", "Всё оружие не призывателя преобразуется в мощные вариации призыва");
						string resultD = resultC.Replace("Falling below 50% life will empower these attacks", "При падении здоровья ниже 50% усилит эти атаки");
						string resultE = resultD.Replace("Transforms Melee attacks into a barrage of spears", "Превращает атаки ближнего боя в шквал копий");
						string resultF = resultE.Replace("Transforms Magic attacks into a powerful splitting fireball", "Превращает магические атаки в мощный раскалывающийся огненный шар");
						string resultG = resultF.Replace("Transforms Ranged attacks into a flurry of fireballs and meteors", "Превращает стрелковые атаки в порыв огненных шаров и метеоров");
						string resultH = resultG.Replace("Transforms Rogue attacks into a deadly crystalline spiral", "Превращает разбойные атаки в смертельную кристаллическую спираль");
						string resultI = resultH.Replace("Summons and empowers the profaned babs to fight alongside you", "Призывает и разрешает осквернённым малышам сражаться бок о бок с вами");
						string resultJ = resultI.Replace("You are no longer affected by burn out when hit", "Вы больше не подвержены к горению когда вас бьют");
						string resultK = resultJ.Replace("Provides buffs depending on the time of day", "Дарует баффы в зависимости от времени суток");
						string resultL = resultK.Replace("Provides heat and cold protection in Death Mode", "Обеспечивает защитой от жары и холода в режиме Смерти");
						string resultM = resultL.Replace("Thinking back, it was a boring life", "Вспоминая, я понимаю, что это была скучная жизнь");
						string resultN = resultM.Replace("And so we burn it all in the name of purity", "И поэтому мы сжигаем всё это во имя чистоты");
						string resultO = resultN.Replace("The soul within this crystal has been defiled by the powerful magic of a supreme witch", "Душа в этом кристалле была осквернена могущественной магией высшей ведьмы");
						string resultP = resultO.Replace("Merchants will reject a defiled soul such as this.", "Торговцы отвергнут осквернённую душу, такую как эта");
						string resultQ = resultP.Replace("Transforms Magic attacks into a powerful splitting fireball for ", "Превращает магические атаки в мощный раскалывающийся огненный шар за ");
						string resultR = resultQ.Replace(" mana per cast", " маны");
						tooltipLine.text = resultR;
					}
				}

				if (item.type == calamity.ItemType("RaidersTalisman"))
                {
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Rogue Crit Level: ", "Количество разбойных критических ударов: ");
						tooltipLine.text = resultA;
					}
				}

				if (item.type == calamity.ItemType("SandCloak"))
                {
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Press ", "Нажмите ");
						string resultB = resultA.Replace(" to consume 25% of your maximum stealth to create a protective dust veil which provides +6 defense and +2 life regen", ", чтобы израсходовать 25% от максимальной скрытности, для создания защитной завесы пыли, которая увеличивает защиту на 6 и регенерацию здоровья на 2");
						tooltipLine.text = resultB;
					}
				}

                if (item.type == calamity.ItemType("SpectralVeil"))
                {
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Press ", "Нажмите ");
						string resultB = resultA.Replace(" to consume 25% of your maximum stealth to perform a short range teleport and render you momentarily invulnerable", ", чтобы израсходовать 25% от вашей максимальной скрытности и выполнить телепортацию на короткое расстояние, что делает вас на мгновение неуязвимым");
						tooltipLine.text = resultB;
					}
				}

				if (item.type == calamity.ItemType("NormalityRelocator"))
                {
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Press ", "Нажмите ");
						string resultB = resultA.Replace(" to teleport to the position of the mouse", ", чтобы телепортироваться в положение курсора мыши");
						tooltipLine.text = resultB;
					}
				}

				if (item.type == calamity.ItemType("Eternity"))
                {
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("There's pictures of ponies in the book", "В книге есть изображения пони");
						tooltipLine.text = resultA;
					}
				}

                if (item.type == calamity.ItemType("PlaguedFuelPack"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        string str = tooltipLine.text;
                        string resultA = str.Replace("Press ", "Нажмите ");
                        string resultB = resultA.Replace(" to consume 25% of your maximum stealth to perform a swift upwards/diagonal dash which leaves a trail of plagued clouds", ", чтобы израсходовать 25% от максимальной скрытности, для стремительного рывка вверх/по диагонали, который оставляет за собой след чумных облаков");
						tooltipLine.text = resultB;
                    }
                }

				if (item.type == calamity.ItemType("SunkenSeaFountain"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        string str = tooltipLine.text;
                        string resultA = str.Replace("Forces surrounding biome state to Sunken Sea upon activation", "Превращает состояние окружающего биома в затерянное море при активации");
                        tooltipLine.text = resultA;
                    }
                }

                if (item.type == calamity.ItemType("SulphurousFountainItem"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        string str = tooltipLine.text;
                        string resultA = str.Replace("Forces surrounding biome state to Sulphurous Sea upon activation", "Превращает состояние окружающего биома в сернистое море при активации");
                        tooltipLine.text = resultA;
                    }
                }

                if (item.type == calamity.ItemType("AstralFountainItem"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        string str = tooltipLine.text;
                        string resultA = str.Replace("Forces surrounding biome state to Astral upon activation", "Превращает состояние окружающего биома в астрал при активации");
                        tooltipLine.text = resultA;
                    }
                }

				if (item.type == calamity.ItemType("Revenge"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        string str = tooltipLine.text;
                        string resultA = str.Replace("Activates rage. When rage is maxed press ", "Активирует ярость. Когда шкала ярости заполнена, нажмите ");
                        string resultB = resultA.Replace(" to activate rage mode.", ", чтобы активировать режим ярости");
                        string resultC = resultB.Replace("Activates adrenaline. When adrenaline is maxed press ", "Активирует адреналин. Когда шкала адреналина заполнена, нажмите ");
                        string resultD = resultC.Replace(" to activate adrenaline mode.", ", чтобы активировать режим адреналина");
						tooltipLine.text = resultD;
                    }
                }

				if (item.type == calamity.ItemType("CosmicWorm"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        string str = tooltipLine.text;
                        string resultA = str.Replace("WARNING! Some sentinels have not been truly defeated yet and will spawn at full power during this fight!", "ПРЕДУПРЕЖДЕНИЕ! Некоторые приспешники ещё не были по-настоящему побеждены и появятся на полную силу во время этой битвы!");
                        tooltipLine.text = resultA;
                    }
                }

				if (item.type == calamity.ItemType("BlunderBooster"))
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        string str = tooltipLine.text;
                        string resultA = str.Replace("Press ", "Нажмите ");
                        string resultB = resultA.Replace(" to consume 25% of your maximum stealth to perform a swift upwards/diagonal dash which leaves a trail of lightning bolts", ", чтобы израсходовать 25% от вашей максимальной скрытности и выполнить стремительный рывок вверх/по диагонали, который оставляет след молнии");
                        tooltipLine.text = resultB;
                    }
                }
				
				if (item.type == calamity.ItemType("GrandGelatin"))
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("10% increased jump speed", "Увеличивает скорость прыжка на 10%");
						string resultB = resultA.Replace("40% increased jump speed", "Увеличивает скорость прыжка на 40%");
						tooltipLine.text = resultB;
					}
				}

				if (item.type == calamity.ItemType("VitalJelly"))
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("6% increased jump speed", "Увеличивает скорость прыжка на 6%");
						string resultB = resultA.Replace("24% increased jump speed", "Увеличивает скорость прыжка на 24%");
						tooltipLine.text = resultB;
					}
				}

				if (item.type == calamity.ItemType("KnowledgeKingSlime"))
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Favorite this item to gain 5% increased movement speed and 2% increased jump speed.", "Пометьте как избранное, чтобы увеличить скорость передвижения на 5% и скорость прыжка на 2%");
						string resultB = resultA.Replace("Favorite this item to gain 5% increased movement speed.", "Пометьте как избранное, чтобы увеличить скорость передвижения на 5%");
						tooltipLine.text = resultB;
					}
				}

				if (item.type == calamity.ItemType("AbandonedSlimeStaff"))
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Holding this weapon grants ", "Держание этого оружие в руках, ");
						string resultB = resultA.Replace("5% increased jump speed", "увеличивает скорость прыжка на 5%");
						string resultC = resultB.Replace("20% increased jump speed", "увеличивает скорость прыжка на 20%");
						tooltipLine.text = resultC;
					}
				}

				if (item.type == calamity.ItemType("AeroStone"))
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Increases movement speed by 10%, jump speed by ", "Увеличивает скорость передвижения на 10%, скорость прыжка на ");
						string resultB = resultA.Replace("%, and all damage by 3%", "% и весь урон на 3%");
						tooltipLine.text = resultB;
					}
				}
			}
		}
    }
}
