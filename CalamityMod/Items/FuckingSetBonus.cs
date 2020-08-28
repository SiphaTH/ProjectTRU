using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityRuTranslate.CalamityMod.Items
{
	public class FuckingSetBonus : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			Mod calamity = ModLoader.GetMod("CalamityMod");
			if (calamity != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ItemID.AncientBattleArmorHat || 
					    item.type == ItemID.AncientBattleArmorShirt || 
					    item.type == ItemID.AncientBattleArmorPants || 
					    item.type == calamity.ItemType("ForbiddenCirclet"))
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Press ", "Нажмите ");
						string resultB = resultA.Replace(" to call an ancient storm to the cursor location\nThe ancient storm costs ", ", для призыва древнего шторма в место, указанное мышью\nДревний шторм стоит ");
						string resultC = resultB.Replace(" mana and benefits from both summon and rogue bonuses\nRogue stealth strikes spawn homing eaters on enemy hits\nMinions deal full damage while wielding rogue weapons\nRogue and summon attacks will scale off of the stat with a higher boost\nRogue stealth builds while not attacking and slower while moving, up to a max of 100\nOnce you have built max stealth, you will be able to perform a Stealth Strike\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed", " маны и получает бонусы как от призывателя, так и от разбойника\nРазбойные скрытые удары порождают самонаводящихся пожирателей при попадании во врага\nМиньоны наносят полный урон, пока вы держите разбойное оружие\nАтаки разбойника и призывателя зависят от характеристик с самым большим бонусом\nСкрытность разбойника накапливается быстрее, пока вы не атакуете и медленнее, пока вы движетесь, максимум до 100\nПосле заполнения шкалы скрытности вы сможете выполнить скрытый удар\nСкрытность расходуется только при атаке и не расходуется при движении\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения");
						
						string resultD = resultC.Replace("Set Bonus: Double tap ", "Бонус комплекта: Нажмите дважды ");
						string resultE = resultD.Replace("UP", "ВВЕРХ");
						string resultF = resultE.Replace("DOWN", "ВНИЗ");
						string resultG = resultF.Replace(" to call an ancient storm to the cursor location\nThe minion damage nerf is reduced while wielding magic weapons", " для призыва древнего шторма в место, указанное мышью\nПонижение урона миньонов при использовании оружия другого класса снижено");
						tooltipLine.text = resultG;
					}
					
					if (item.type == calamity.ItemType("FearmongerGreathelm") || 
					    item.type == calamity.ItemType("FearmongerPlateMail") || 
					    item.type == calamity.ItemType("FearmongerGreaves"))
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("30% increased minion damage\nThe minion damage nerf while wielding weaponry is reduced\nImmunity to all forms of frost and flame\nAll minion attacks grant colossal life regeneration\n15% increased damage reduction during the Pumpkin and Frost Moons\nThis extra damage reduction ignores the soft cap", "Увеличивает урон миньонов на 30%\nПонижение урона миньонов при использовании оружия другого класса снижено\nНевосприимчивость ко всем формам мороза и огня\nВсе атаки миньонов даруют колоссальную регенерацию здоровья\nУвеличивает сопротивление урону на 15% во время тыквенной и ледяной луны\nЭто дополнительное сопротивление урону игнорирует ванильный передел");
						string resultB = resultA.Replace("Provides cold protection in Death Mode", "Обеспечивает защитой от холода в режиме Смерти");
						tooltipLine.text = resultB;
					}
					
					if (item.type == calamity.ItemType("PrismaticHelmet") || 
					    item.type == calamity.ItemType("PrismaticRegalia") || 
					    item.type == calamity.ItemType("PrismaticGreaves"))
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("+40 max mana and 15% reduced mana cost\nIncreased mana regeneration rate\nPress ", "Увеличивает максимальный запас маны на 40 и снижает расход маны на 15%\nУвеличивает скорость регенерации маны\nНажмите ");
						string resultB = resultA.Replace(" to unleash a barrage of death lasers at the cursor for the next 5 seconds\nThis has a 30 second cooldown", ", чтобы выпустить шквал смертоносных лазеров в позицию курсора мыши в течение следующих 5 секунд\nИмеет 30 секунд перезарядки");
						tooltipLine.text = resultB;
					}
					
					if (item.type == calamity.ItemType("BloodflareHornedHelm") || 
					    item.type == calamity.ItemType("BloodflareBodyArmor") || 
					    item.type == calamity.ItemType("BloodflareCuisses"))
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Greatly increases life regen\nEnemies below 50% life have a chance to drop hearts when struck\nEnemies above 50% life have a chance to drop mana stars when struck\nEnemies killed during a Blood Moon have a much higher chance to drop Blood Orbs\nPress ", "Значительно увеличивает регенерацию здоровья\nУ врагов с уровнем здоровья ниже 50% может выпасть сердце при ударе\nУ врагов с уровнем здоровья выше 50% может выпасть кристалл маны при ударе\nУ врагов, убитых во время кровавой луны, выше шанс выпадения Кровавой сферы\nНажмите ");
						string resultB = resultA.Replace(" to unleash the lost souls of polterghast to destroy your enemies\nThis effect has a 30 second cooldown\nRanged weapons have a chance to fire bloodsplosion orbs", ", чтобы высвободить потерянные души полтергаста, чтобы уничтожить ваших врагов\nЭтот эффект имеет 30 секунд перезарядки\nУ стрелкового оружия есть шанс выстрелить кровавыми взрывными сферами");
						tooltipLine.text = resultB;
					}
					
					if (item.type == calamity.ItemType("BrimflameScowl") || 
					    item.type == calamity.ItemType("BrimflameRobes") || 
					    item.type == calamity.ItemType("BrimflameBoots"))
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Grants an additional 15% increased damage and magic crit\nPress ", "Дополнительно дарует увеличенный урон и шанс критического удара на 15%\nНажмите ");
						string resultB = resultA.Replace(" to trigger a brimflame frenzy effect\nWhile under this effect, your damage is significantly boosted\nHowever, this comes at the cost of rapid life loss and no mana regeneration\nThis can be toggled off, however, a brimstone frenzy has a 30 second cooldown", ", чтобы вызвать эффект «Неистовства серного пламени»\nВо время действия этого эффекта ваш урон значительно увеличивается\nОднако это происходит ценой быстрой потери здоровья и отсутствием регенерации маны\nЭффект можно отключить, однако у «Неистовства серного пламени» есть 30 секундная перезарядка");
						tooltipLine.text = resultB;
					}
					
					if (item.type == calamity.ItemType("DemonshadeHelm") || 
					    item.type == calamity.ItemType("DemonshadeBreastplate") || 
					    item.type == calamity.ItemType("DemonshadeGreaves"))
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("100% increased minion damage\nAll attacks inflict the demon flame debuff\nShadowbeams and demon scythes will fire down when you are hit\nA friendly red devil follows you around\nPress ", "Увеличивает урон миньонов на 100%\nВсе атаки накладывают «Пламя демона»\nТеневые лучи и демонические косы обрушатся на врагов, когда вас ранили\nДружелюбный красный дьявол следует за вами\nНажмите ");
						string resultB = resultA.Replace(" to enrage nearby enemies with a dark magic spell for 10 seconds\nThis makes them do 25% more damage but they also take 125% more damage", ", чтобы разозлить ближайших врагов заклинанием тёмной магии на 10 секунд\nЭто заставит их наносить на 25% больше урона, но также получать его на 125% больше");
						tooltipLine.text = resultB;
					}
					
					if (item.type == calamity.ItemType("OmegaBlueHelmet") || 
					    item.type == calamity.ItemType("OmegaBlueChestplate") || 
					    item.type == calamity.ItemType("OmegaBlueLeggings"))
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Increases armor penetration by 50\n10% increased damage and critical strike chance\nShort-ranged tentacles heal you by sucking enemy life\nPress ", "Увеличивает пробивание брони на 50\nУвеличивает урон и шанс критического удара на 10%\nКороткие щупальца исцеляют вас, высасывая жизнь врага\nНажмите ");
						string resultB = resultA.Replace(" to activate abyssal madness for 5 seconds\nAbyssal madness increases damage, critical strike chance, and tentacle aggression/range\nThis effect has a 25 second cooldown", ", чтобы активировать «Безумие бездны» на 5 секунд\n«Безумие бездны» увеличивает урон, шанс критического удара и агрессивность/дистанцию атаки щупалец\nЭтот эффект имеет 25 секунд перезарядки");
						tooltipLine.text = resultB;
					}
					
					if (item.type == calamity.ItemType("PlagueReaperMask") || 
					    item.type == calamity.ItemType("PlagueReaperVest") || 
					    item.type == calamity.ItemType("PlagueReaperStriders"))
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("25% reduced ammo usage and 5% increased flight time\nEnemies receive 10% more damage from ranged projectiles when afflicted by the Plague\nGetting hit causes the plague cinders to rain from above\nPress ", "Уменьшает использование боеприпасов на 25% и увеличивает время полёта на 5%\nВраги получают на 10% больше урона от стрелковых снарядов, когда они поражены «Чумой»\nПолучая удар, приводит к падению с неба чумного пепла\nНажмите");
						string resultB = resultA.Replace(" to blind yourself for 5 seconds but massively boost your ranged damage\nThis has a 25 second cooldown.", ", чтобы ослепить себя в течение 5 секунд, но значительно увеличив свой стрелковый урон\nИмеет 25 секунд перезарядки");
						tooltipLine.text = resultB;
					}
					
					if (item.type == calamity.ItemType("TarragonHelm") || 
					    item.type == calamity.ItemType("TarragonBreastplate") || 
					    item.type == calamity.ItemType("TarragonLeggings"))
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Increased heart pickup range\nEnemies have a chance to drop extra hearts on death\nYou have a 25% chance to gain a life regen buff when you take damage\nPress ", "Увеличивает дальность подбора сердец\nПосле смерти врагов может выпасть больше сердец\nУ вас есть 25% шанс получить бафф регенерации здоровья при получении урона\nНажмите ");
						string resultB = resultA.Replace(" to cloak yourself in life energy that heavily reduces enemy contact damage for 10 seconds\nThis has a 30 second cooldown", ", чтобы покрыть себя жизненной энергией, которая значительно снижает урон при контакте с врагом в течение 10 секунд\nИмеет 30 секунд перезарядки");
						tooltipLine.text = resultB;
					}
				}
			}
		}
	}
}
