using System;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ModOfRedemption.ModSupport
{
	internal class MoRSupport
	{
		private static void Load()
		{
			MoRSupport._localizations = new string[][]
			{
				new string[]
				{
					"DruidicOre",
					"Сквозь руду мира проходит друидическая энергия..."
				},
				new string[]
				{
					"DragonLeadMessage",
					"Пещеры нагреваются драконьей костью..."
				},
				new string[]
				{
					"InfectionMessage1",
					"Существа начинают заражаться..."
				},
				new string[]
				{
					"LabIsSafe",
					"Защитные системы Лаборатории выходят из строя..."
				},
				new string[]
				{
					"GrowingInfection",
					"Сброшена ядерная бомба!"
				},
				new string[]
				{
					"Lasers1",
					"Лазерные системы №1 были деактивированы..."
				},
				new string[]
				{
					"Lasers2",
					"Лазерные системы №2 были деактивированы..."
				},
				new string[]
				{
					"Lasers3",
					"Лазерные системы №3 были деактивированы..."
				},
				new string[]
				{
					"Lasers4",
					"Лазерные системы №4 были деактивированы..."
				},
				new string[]
				{
					"Lasers5",
					"Лазерные системы №5 были деактивированы..."
				},
				new string[]
				{
					"Lasers6",
					"Лазерные системы №6 были деактивированы..."
				},
				new string[]
				{
					"Lasers7",
					"Лазерные системы №7 были деактивированы..."
				},
				new string[]
				{
					"PatientZeroMessage1",
					"Распространение инфекции прекращается. Возвращаются сильные существа Эпидотры..."
				},
				new string[]
				{
					"PatientZeroMessage2",
					"В пепле Ада формируются проклятые камни багряного цвета..."
				},
				new string[]
				{
					"PatientZeroMessage3",
					"Могущественные существа бродят по лесам, пещерам и небесам..."
				},
				new string[]
				{
					"GirusHide",
					"Думал, что сможешь спрятаться от меня?"
				},
				new string[]
				{
					"KeeperAwoken",
					"Пробудилась Хранительница!"
				},
				new string[]
				{
					"SoIChecklist",
					"В Boss Checklist появились новые записи!"
				},
				new string[]
				{
					"KingSlayerMoonlord",
					"Эй, террариец, говорит Убийца королей. Я скоро покину корабль, так что если у тебя есть какие незаконченные дела, то давай закончим их."
				}
			};
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0004085E File Offset: 0x0003EA5E
		private static void Unload()
		{
			MoRSupport._localizations = null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00040868 File Offset: 0x0003EA68
		public static void RedemptionAddLocalizations()
		{
			MoRSupport.Load();
			foreach (string[] array in MoRSupport._localizations)
			{
				ModTranslation modTranslation = ModLoader.GetMod("Redemption").CreateTranslation(array[0]);
				modTranslation.SetDefault(array[1]);
				ModLoader.GetMod("Redemption").AddTranslation(modTranslation);
			}
			MoRSupport.Unload();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000408C4 File Offset: 0x0003EAC4
		public static void CombatText()
		{
			for (int i = 0; i < 100; i++)
			{
				if (Main.combatText[i].text == "Peck Peck" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Цып-цып";
				}
				if (Main.combatText[i].text == "Redemptive Sparks!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Искупительные искры!";
				}
				if (Main.combatText[i].text == "HARR!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ХАРР!";
				}
				if (Main.combatText[i].text == "Slash!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Порез!";
				}
				if (Main.combatText[i].text == "Rocket Fist!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ракетный кулак!";
				}
				if (Main.combatText[i].text == "Slice!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Разрез!";
				}
				if (Main.combatText[i].text == "Stab!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Удар!";
				}
				if (Main.combatText[i].text == "Slice! Stab!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Разрез! Удар!";
				}
				if (Main.combatText[i].text == "Thrust!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Выпад!";
				}
				if (Main.combatText[i].text == "You're... Soulless..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ты... Бездушный...";
				}
				if (Main.combatText[i].text == "<Chalice of Alignment> Oh... Oh damn..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "<Чаша юстировки> Ох... Ох, черт...";
				}
				if (Main.combatText[i].text == "I have... been looking... for you..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Я... искал... тебя...";
				}
				if (Main.combatText[i].text == "You... you slayed... her..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ты... одолел... её...";
				}
				if (Main.combatText[i].text == "You've... killed the Keeper..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ты... убил Хранительницу...";
				}
				if (Main.combatText[i].text == "Do you understand... what shes been through..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Понимаешь ли... через что она прошла...";
				}
				if (Main.combatText[i].text == "Hundreds of years... trapped with no other soul..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Сотни лет... заточения... без единой души...";
				}
				if (Main.combatText[i].text == "I... have to... avenge her..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Я... обязан... отомстить за неё...";
				}
				if (Main.combatText[i].text == "Charging..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Заряжаю...";
				}
				if (Main.combatText[i].text == "Burst!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Взрыв!";
				}
				if (Main.combatText[i].text == "<Chalice of Alignment> That was spooky. I hate ghosts." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "<Чаша юстировки> Это было жутко. Ненавижу призраков.";
				}
				if (Main.combatText[i].text == "You fool... You dare think you can kill me?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Глупец... Думать смеешь, что можешь убить Короля?";
				}
				if (Main.combatText[i].text == "I am the Mighty King Chicken, and I have come to annihilate you!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Я - могучий куриный король, и прибыл я, чтоб тебя изничтожить!";
				}
				if (Main.combatText[i].text == "So face me, mortal! And accept your fate!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Так сразись со мной, смертный! И прими свою судьбу!";
				}
				if (Main.combatText[i].text == "Stubborn fool... Are you letting me make the first move?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Строптивый глупец... Позволяешь мне сделать первый шаг??";
				}
				if (Main.combatText[i].text == "So be it! A GOD DOES NOT FEAR DEATH!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Да будет так! БОГ НЕ БОИТСЯ СМЕРТИ!";
				}
				if (Main.combatText[i].text == "*pecks gracefully*" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "*Изящный клевок*";
				}
				if (Main.combatText[i].text == "You still stand before me?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ты всё предо мной стоишь, глупец?";
				}
				if (Main.combatText[i].text == "*clucks impatiently*" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "*Нетерпеливый кудах*";
				}
				if (Main.combatText[i].text == "You bore me, mortal! I shall be gone, but I will return!   ...   Maybe." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Сколь скучен ты, смертный! Я уйду, но еще вернусь!   ...   Наверное.";
				}
				if (Main.combatText[i].text == "*clucks a goodbye*" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "*Кудах на прощание*";
				}
				if (Main.combatText[i].text == "Phantom Cleaver!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Призрачный секач!";
				}
				if (Main.combatText[i].text == "[DEPLOYING CORE]" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "[РАЗВЕРТЫВАНИЕ ЯДРА]";
				}
				if (Main.combatText[i].text == "I REQUIRE ASSISTANCE, GIRUS..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "МНЕ НУЖНА ПОДДЕРЖКА, ГИРУС...";
				}
				if (Main.combatText[i].text == "TARGET OBLITERATED... RETURNING TO GIRUS..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ЦЕЛЬ УНИЧТОЖЕНА... ВОЗВРАЩАЮСЬ К ГИРУС...";
				}
				if (Main.combatText[i].text == "TARGET FOUND..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ЦЕЛЬ ОБНАРУЖЕНА...";
				}
				if (Main.combatText[i].text == "PREPARE FOR OBLITERATION..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ПРИГОТОВЬСЯ К УНИЧТОЖЕНИЮ...";
				}
				if (Main.combatText[i].text == "Thank..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Спа...";
				}
				if (Main.combatText[i].text == "You..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "сибо...";
				}
				if (Main.combatText[i].text == "Charge!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Заряд!";
				}
				if (Main.combatText[i].text == "Arcane Chickens!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Чародейские курицы!";
				}
				if (Main.combatText[i].text == "Bone Chickens!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Костяные курицы!";
				}
				if (Main.combatText[i].text == "You fool! You idiot!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Глупец! Идиот!";
				}
				if (Main.combatText[i].text == "Did you really think that dumb chicken was king?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ты действительно думал, что та тупая курица была королем?";
				}
				if (Main.combatText[i].text == "IT'S A CHICKEN, CHICKENS ARE FEMALE, FOOOOOOOOOOOOL!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ЭТО БЫЛА КУРИЦА, А КУРИЦЫ - САМКИ, ГЛУПЕЕЕЕЕЕЕЕЦ!";
				}
				if (Main.combatText[i].text == "I am the true 'King Chicken'! Or 'King Rooster' to be more accurate." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Я - истинный 'куриный король'! Или, если точнее, 'Король петушок'.";
				}
				if (Main.combatText[i].text == "So fight me, and feel the 'Wrath of the Rooster'!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Так сразись со мной, и почувствуй 'петушиный гнев'!";
				}
				if (Main.combatText[i].text == "You sure are taking your time to kill me." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "И мое убийство определенно займет какое-то время.";
				}
				if (Main.combatText[i].text == "Oof!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Уф!";
				}
				if (Main.combatText[i].text == "Owch!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ауч!";
				}
				if (Main.combatText[i].text == "Yowch!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Оуч!";
				}
				if (Main.combatText[i].text == "Ow!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ау!";
				}
				if (Main.combatText[i].text == "Arg!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Арг!";
				}
				if (Main.combatText[i].text == "Damn it!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Черт!";
				}
				if (Main.combatText[i].text == "Ah!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ай!";
				}
				if (Main.combatText[i].text == "D'oh!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Дых!";
				}
				if (Main.combatText[i].text == "Oops!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Уупс!";
				}
				if (Main.combatText[i].text == "Whoops!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Вуупс!";
				}
				if (Main.combatText[i].text == "Not again!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Только не опять!";
				}
				if (Main.combatText[i].text == "You may be wondering..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ты можешь задуматься...";
				}
				if (Main.combatText[i].text == "... Where I'm getting all these mops from..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "... Откуда я беру все эти швабры...";
				}
				if (Main.combatText[i].text == "... Well, it's a secret! Haha!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "... Ну, это секрет! Хаха!";
				}
				if (Main.combatText[i].text == "All this jumping about is making me tired." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Все эти прыжки так утомляют.";
				}
				if (Main.combatText[i].text == "Oh well! It's exercise!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ну и ладно! Это же почти тренировка!";
				}
				if (Main.combatText[i].text == "Oh right, robots don't need exercise..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ой, точно. Роботам не нужны тренировки...";
				}
				if (Main.combatText[i].text == "My joints are a little stiff..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "У меня немного шарниры затекли...";
				}
				if (Main.combatText[i].text == "When was the last time I was oiled?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Когда же в последний раз меня смазывали?";
				}
				if (Main.combatText[i].text == "Oi! Don't go there, the floor's wet." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Эй! Не иди туда, там пол мокрый.";
				}
				if (Main.combatText[i].text == "Wait... You're a trespasser!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Подожди-ка... Ты же нарушитель периметра!";
				}
				if (Main.combatText[i].text == "Okay, okay!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ладно, ладно!";
				}
				if (Main.combatText[i].text == "Alright fine, you probably can handle yourself here." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ну ладно. Кажется, ты можешь за себя постоять.";
				}
				if (Main.combatText[i].text == "Here, have this Lab Access thing and piss off!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Вот, возьми эту штуку для доступа в Лабораторию и вали уже!";
				}
				if (Main.combatText[i].text == "I got moppin' to do." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Мне ещё нужно пол вытирать.";
				}
				if (Main.combatText[i].text == "INTRUDER DETECTED..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ОБНАРУЖЕН НАРУШИТЕЛЬ...";
				}
				if (Main.combatText[i].text == "Energy Bolts!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Энергетические заряды!";
				}
				if (Main.combatText[i].text == "Energy Bolt!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Энергетический заряд!";
				}
				if (Main.combatText[i].text == "Your TIME is up!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Твое ВРЕМЯ вышло!";
				}
				if (Main.combatText[i].text == "TIME to die!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ВРЕМЯ умереть!";
				}
				if (Main.combatText[i].text == "Your TIME has come!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Твое ВРЕМЯ пришло!";
				}
				if (Main.combatText[i].text == "Hyaar!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Хьяр!";
				}
				if (Main.combatText[i].text == "*Groan*" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "*Стон*";
				}
				if (Main.combatText[i].text == "BOOM!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "БУМ!";
				}
				if (Main.combatText[i].text == "ACHOO!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "АЧУ!";
				}
				if (Main.combatText[i].text == "Sikk!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Сикк!";
				}
				if (Main.combatText[i].text == "Sibu!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Сибу!";
				}
				if (Main.combatText[i].text == "Cut�nin doz." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Кут�нин даз.";
				}
				if (Main.combatText[i].text == "Uf cul� ut ufe..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Уф кул� ут уфе...";
				}
				if (Main.combatText[i].text == "Ka dosmok cul�..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ка досмок кул�...";
				}
				if (Main.combatText[i].text == "Cult�nin un yei ruk�..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Култ�нин ун йей рук�...";
				}
				if (Main.combatText[i].text == "Consu�nin yei min�..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Консу�нин йей мин�...";
				}
				if (Main.combatText[i].text == "Jugh niqui tie..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Джух никьюй тай...";
				}
				if (Main.combatText[i].text == "Swush!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Свуш!";
				}
				if (Main.combatText[i].text == "Phish!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Свиш!";
				}
				if (Main.combatText[i].text == "Crystal Scythes!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Кристальные косы!";
				}
				if (Main.combatText[i].text == "Slice! Thrust!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Разрез! Выпад!";
				}
				if (Main.combatText[i].text == "New Dialogue Available" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Доступен новый диалог";
				}
				if (Main.combatText[i].text == "Enough." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Достаточно.";
				}
				if (Main.combatText[i].text == "Wait." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Стой.";
				}
				if (Main.combatText[i].text == "I am recieving a transmission." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Я получаю сигнал.";
				}
				if (Main.combatText[i].text == "This appears to have been a misunderstanding, you're allowed through." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Кажется, это недоразумение. Тебе разрешено пройти.";
				}
				if (Main.combatText[i].text == "My apologies. Move along." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Мои извинения. Проходи.";
				}
				if (Main.combatText[i].text == "Leave." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Уходи.";
				}
				if (Main.combatText[i].text == "Deeper sectors are life-threatening for your kind." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Глубинные сектора опасны для вашего вида.";
				}
				if (Main.combatText[i].text == "If you wish to enter, prove your strength to me." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Если желаешь войти, то докажи мне свою силу.";
				}
				if (Main.combatText[i].text == "Hollow Slash!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Полый разрез!";
				}
				if (Main.combatText[i].text == "soup?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "суп?";
				}
				if (Main.combatText[i].text == "yum yum" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ням ням";
				}
				if (Main.combatText[i].text == "phish" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "риба";
				}
				if (Main.combatText[i].text == "fishy" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "рыбя";
				}
				if (Main.combatText[i].text == "gimmi phish" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "рибу дяй";
				}
				if (Main.combatText[i].text == "feed me" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "накорми меня";
				}
				if (Main.combatText[i].text == "cookie" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "печенька";
				}
				if (Main.combatText[i].text == "gimmi cookie" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "дяй печеньку";
				}
				if (Main.combatText[i].text == "*toot*" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "*гудит*";
				}
				if (Main.combatText[i].text == "egg" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "яйцо";
				}
				if (Main.combatText[i].text == "chikcen" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "курца";
				}
				if (Main.combatText[i].text == "chkcien funni" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "смищная курца";
				}
				if (Main.combatText[i].text == "i laugh at chieken" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "я смеюсь над курцей";
				}
				if (Main.combatText[i].text == "gimmi chciken" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "дяй курцу";
				}
				if (Main.combatText[i].text == "meow" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "мяу";
				}
				if (Main.combatText[i].text == "hello?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "привет?";
				}
				if (Main.combatText[i].text == "where is hoomun?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "где домь?";
				}
				if (Main.combatText[i].text == "mamaa" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "мамаа?";
				}
				if (Main.combatText[i].text == "where you at?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "где ты?";
				}
				if (Main.combatText[i].text == "why you leave?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "почему ты ушла?";
				}
				if (Main.combatText[i].text == "yummy blood" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "вкусная кровь";
				}
				if (Main.combatText[i].text == "you bleeding" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ты кровоточишь";
				}
				if (Main.combatText[i].text == "blod" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "кров";
				}
				if (Main.combatText[i].text == "hurry up" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "торопись";
				}
				if (Main.combatText[i].text == "you're too slow" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ты слишком медленный";
				}
				if (Main.combatText[i].text == "move move move" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "давай давай давай";
				}
				if (Main.combatText[i].text == "is it cold in there?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "тут что, холодно?";
				}
				if (Main.combatText[i].text == "i'll get you out!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "я вытащу тебя отсюда!";
				}
				if (Main.combatText[i].text == "brrr" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "бррр";
				}
				if (Main.combatText[i].text == "that bite wasn't from me" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "этот укус был не от меня";
				}
				if (Main.combatText[i].text == "*nom*" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "*ням*";
				}
				if (Main.combatText[i].text == "stinky" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "вонючка";
				}
				if (Main.combatText[i].text == "you stinky" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ты вонючка";
				}
				if (Main.combatText[i].text == "uh oh stinky" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "фу, вонючка";
				}
				if (Main.combatText[i].text == "ew" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "фу";
				}
				if (Main.combatText[i].text == "Always watching..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Всегда наблюдает...";
				}
				if (Main.combatText[i].text == "You got any pasta?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "У тебя есть спагетти?";
				}
				if (Main.combatText[i].text == "You think you're safe?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Думаешь, что ты в безопасности?";
				}
				if (Main.combatText[i].text == "Pitiful fool..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Жалкий глупец...";
				}
				if (Main.combatText[i].text == "cheese" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "сыр";
				}
				if (Main.combatText[i].text == "I have too much swagger for the dagger" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Дофига халявы на моем кинжале";
				}
				if (Main.combatText[i].text == "this is a message to my master this is a fight you cannot win i think that past your great disasters their victory stirs below your skin" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ЗИС ИС Э МЕССЭЙДЖ ТУ МАЙ МАСТЭР ЗИС ИС Э ФАЙТ У КЭННОТ ВИН АЙ ТХИНТ ЗЭТ ПЭСТ ЮР ГРЕЙТ ДИЗАСТЕРС ЗЕЙР ВИКТОРИ СТИРС БЕЛОУ ЮР СКИН";
				}
				if (Main.combatText[i].text == "Cirrus isn't squishy, don't believe what Fabsol says..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Циррус нельзя обнимать, не верь Фабсолу...";
				}
				if (Main.combatText[i].text == "spooky" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "страшно";
				}
				if (Main.combatText[i].text == "You should get Mod of Redemption: Music Pack" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ты обязан установить Mod of Redemption: Music Pack";
				}
				if (Main.combatText[i].text == "Ara Ara" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ара Ара~";
				}
				if (Main.combatText[i].text == "Ragnarok is a well designed boss with no flaws what-so-ever" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Рагнарёк - отлично продуманный босс без каких-либо недостатков";
				}
				if (Main.combatText[i].text == "That sprite isn't vanilla-styled, bad mod" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Этот спрайт не в стиле обычной игры, плохой мод";
				}
				if (Main.combatText[i].text == "What the duck?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Что за утка?";
				}
				if (Main.combatText[i].text == "Go my pet! I will back you up." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Иди, мой питомец! Я же поддержу тебя.";
				}
				if (Main.combatText[i].text == "ARGH! No! Don't come close!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "АРГХ! Нет! Не подходи!";
				}
				if (Main.combatText[i].text == "Please just give this up!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Пожалуйста, просто сдайся!";
				}
				if (Main.combatText[i].text == "Don't you realise what you're doing!?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Разве ты не понимаешь, что творишь?!";
				}
				if (Main.combatText[i].text == "Stop!" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Прекрати!";
				}
				if (Main.combatText[i].text == "Yo." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Йоу.";
				}
				if (Main.combatText[i].text == "I guess I can't fool you twice, huh." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Думаю, дважды мне тебя не обмануть, да?";
				}
				if (Main.combatText[i].text == "So much for a surprise attack..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Вот тебе и неожиданная атака...";
				}
				if (Main.combatText[i].text == "Hang on, I got a call from Girus." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Подожди. У меня звонок от Гирус.";
				}
				if (Main.combatText[i].text == "'I wasted too much energy too quickly?'" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "'Я впустую потратил кучу энергии?'";
				}
				if (Main.combatText[i].text == "'I'm an idiot?'" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "'Я идиот?'";
				}
				if (Main.combatText[i].text == "You're scrapping my personality drive?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ты сейчас сломаешь мой личностный диск?";
				}
				if (Main.combatText[i].text == "Ah well, request accepted..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Ну что ж, просьба принята...";
				}
				if (Main.combatText[i].text == "REBOOTING SYSTEMS... GENERATING BARRIER..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ПЕРЕЗАГРУЗКА СИСТЕМ... ГЕНЕРАЦИЯ БАРЬЕРА...";
				}
				if (Main.combatText[i].text == "SYSTEM OVERLOAD..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "СИСТЕМА ПЕРЕГРУЖЕНА...";
				}
				if (Main.combatText[i].text == "GIRUS, I REQUIRE ASSISTANCE..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ГИРУС, МНЕ ТРЕБУЕТСЯ ПОДДЕРЖКА...";
				}
				if (Main.combatText[i].text == "MESSAGE FAILED TO SEND..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "СООБЩЕНИЕ НЕ УДАЛОСЬ ОТПРАВИТЬ...";
				}
				if (Main.combatText[i].text == "OVERHEATING... OVERHEATING... OVERHEATING..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ПЕРЕГРЕВ... ПЕРЕГРЕВ... ПЕРЕГРЕВ...";
				}
				if (Main.combatText[i].text == "CRITICAL CONDITION REACHED... SELF DESTRUCTING..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "ДОСТИГНУТО КРИТИЧЕСКОЕ СОСТОЯНИЕ... САМОРАЗРУШЕНИЕ...";
				}
				if (Main.combatText[i].text == "Alright, target eliminated." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Отлично, цель уничтожена.";
				}
				if (Main.combatText[i].text == "Returning to base..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Возвращаюсь на базу...";
				}
				if (Main.combatText[i].text == "Target eliminated..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Цель уничтожена...";
				}
				if (Main.combatText[i].text == "...Why did you have to barge in through the ventilation shaft?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "...и зачем ты ворвался сюда через вентиляционную шахту?";
				}
				if (Main.combatText[i].text == "Lost your access card huh? Have mine and get out of my sight." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Потерял свою карту доступа, хах? Возьми мою и убирайся с глаз моих.";
				}
				if (Main.combatText[i].text == "*Grumbles* Those darn careless bots losing their cards..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "*ворчание* Как же любят эти глупые роботы терять карты...";
				}
				if (Main.combatText[i].text == "Hm? Are you supposed to be let through?" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Хм? Вас что, должны пропустить?";
				}
				if (Main.combatText[i].text == "One second..." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Секунду...";
				}
				if (Main.combatText[i].text == "Everything seems to be in order. Move along." && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Всё в порядке. Проходите.";
				}
				if (Main.combatText[i].text == "playing calamity? cringe" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Играешь в Каламити? Кринжово";
				}
				if (Main.combatText[i].text == "fargo GOD" && Main.combatText[i].active)
				{
					Main.combatText[i].text = "Фарго БОГ";
				}
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00043038 File Offset: 0x00041238
		public static void NpcChat()
		{
			bool flag = Main.player[Main.myPlayer].talkNPC != -1;
			int num = NPC.FindFirstNPC(22);
			int num2 = NPC.FindFirstNPC(17);
			int num3 = NPC.FindFirstNPC(20);
			int num4 = NPC.FindFirstNPC(18);
			int num5 = NPC.FindFirstNPC(19);
			int num6 = NPC.FindFirstNPC(209);
			int num7 = NPC.FindFirstNPC(208);
			if (Main.npcChatText == "I wouldn't consume that Blackened Heart if I were you. Only bad things will come of it.")
			{
				Main.npcChatText = "На твоем месте я бы не стал поглощать это почерневшее сердце. Ничего хорошего из этого точно не выйдет.";
			}
			if (Main.npcChatText == "You saved the Keeper? Thank you for that, I can't imagine the pain she was feeling. If you need Dark Fragments, I'll sell them now for you. However, I doubt this is over... Her husband died too, apparently of depression. But he didn't become an undead, his inverted soul made him into something worse.")
			{
				Main.npcChatText = "Ты спас Хранительницу? Спасибо за это. Не могу представить, какую боль она испытывала. Если нужны темные фрагменты - обращайся, продам их тебе. Однако сомневаюсь, что это конец... Ее муж тоже погиб. Вроде, от депрессии. Но он не стал нежитью, его инвертированная душа превратила его в нечто куда более плохое.";
			}
			if (Main.npcChatText == "I may be undead, but I hope for a world where no tears are shed, and no pain is spread. A world of peace. That is who I was before dying, and despite the undead tendency to be more aggressive, I feel the same as I always have.")
			{
				Main.npcChatText = "Может я и нежить, но я надеюсь на мир, где нет места пролитым слезам и боли. Мир во всем мире. Вот кем я был перед смертью, и пусть обычно нежить куда более агрессивна, я чувствую то же, что и всегда.";
			}
			if (Main.npcChatText == "Do not worry, human. I bring no hatred where I go, despite my undead look, I won't harm you. And I hope you won't harm me either.")
			{
				Main.npcChatText = "Не волнуйся, человек. Я не несу за собой ненависть, несмотря на мой немного неживой вид, и не причиню тебе вреда. И, надеюсь, что ты тоже не причинишь мне вреда.";
			}
			if (Main.npcChatText == "Times may come when you have hardship, maybe you struggle fighting a tough enemy, maybe you feel alone on this island with only enemies everywhere you go, but I'll still be here. Don't let my rotten looks deceive you, young one. I will help you.")
			{
				Main.npcChatText = "Быть может, настанут времена, когда тебе будет трудно, быть может, ты будешь бороться с жестоким врагом, быть может, на этом острове ты почувствуешь себя одиноким. Где бы ты ни был, я всегда буду здесь. Не позволяй моей гнилой внешности ввести в заблуждение тебя, дитя. Я тебе помогу.";
			}
			if (Main.npcChatText == "The wind sings the longest tune... Do you hear it?")
			{
				Main.npcChatText = "Ветер поет самую длинную мелодию... Слышишь ее?";
			}
			if (Main.npcChatText == "Wanna know what lost souls are? When a living thing dies, it's soul leaves the body, these are Lost Souls. Lost Souls search around the world to look for corpses to infuse with. To ordinary people, Lost Souls are invisible, but some who use magic can see them fade in and out of the Spirit Realm.")
			{
				Main.npcChatText = "Хочешь узнать, что такое заблудшие души? Когда живое существо умирает, его душа покидает тело, это и есть заблудшая душа. Заблудшие души путешествуют по миру, в поисках тела для вселения. Для обычных людей они невидимы, но те, кто использует магию, видят как они то исчезают, то появляются из Царства Духов.";
			}
			if (Main.npcChatText == "Y'know, planting saplings on Ancient Dirt will make Ancient Trees grow! It's like magic!")
			{
				Main.npcChatText = "Знаешь, если посадить на древнюю землю саженец, то вырастет древнее дерево! Это магия какая-то!";
			}
			if (Main.npcChatText == "The size of the Lost Souls depends on the original individual's power, the stronger the Will of the being, the bigger the soul. Once a soul leaves the body, they cannot infuse with it again. On most occasions where a soul fuses, a skeleton will be created. However, if the soul is strong enough, it will form pale-brown flesh on the skeleton, creating a Fallen.")
			{
				Main.npcChatText = "Размер заблудших душ зависит от силы изначального существа. Чем сильнее Воля существа, тем больше душа. Стоит душе покинуть тело, она не сможет вновь в него вселиться. Когда душа находит достойный сосуд, она вселяется в него. В большинстве случаев получится скелет. Хотя, если душа достаточно сильна, она сформирует на скелете бледно-коричневую плоть, создавая Падшего.";
			}
			if (Main.npcChatText == "In the lowest level of the Catacombs of Gathuram, the floor is littered with broken bones and puddles of water. Dim blue lights often were visible in this level, and nothing is alive there. So if any were to survive the fall, they would be alone forever.")
			{
				Main.npcChatText = "На самом нижнем уровне катакомб Гатурама пол усеян сломанными костями и лужами воды. Часто на этом уровне видели тусклые голубые огни, хотя там нет ничего живого. Так что если кто-то и выживет после падения, то навсегда останется один.";
			}
			if (Main.npcChatText == "My name's Okvot, I usually sell equipment to other Fallen to help them survive in the Catacombs of Gathuram, however, destiny has brought me into the outside world. I hope my junk can be of use to you.")
			{
				Main.npcChatText = "Меня зовут Оквот. Обычно я продаю снаряжение другим Падшим, чтобы помочь им выжить в катакомбах Гатурама, однако судьба привела меня во внешний мир. Надеюсь, мое барахло вам пригодится.";
			}
			if (Main.npcChatText == "You saved the Keeper? That's great to hear, she gave me trouble when she had escaped the catacombs. If you need Dark Fragments, I'll sell them now for you.")
			{
				Main.npcChatText = "Ты спас Хранительницу? Приятно это слышать. Она доставила мне немало хлопот, когда сбежала из катакомб. Если понадобятся темные фрагменты, то теперь могу продать их тебе.";
			}
			if (Main.npcChatText == "In my first few days of becoming Fallen, every other undead tried to kill me. It was a very scary experience, but I escaped the catacombs and now I'm here.")
			{
				Main.npcChatText = "В мои первые дни со становления Падшим, каждая нежить считала своим долгом убить меня. Это был довольно страшный опыт, но я все таки сбежал из катакомб и вот я здесь.";
			}
			if (Main.npcChatText == "Do you want to know about Pure-Iron? It's an extremely durable metal only found in the southern region of the world, in Gathuram. I am wearing a Pure-Iron helmet right now in fact.")
			{
				Main.npcChatText = "Хочешь узнать о чистом железе? Это чрезвычайно прочный металл, который можно найти только в южной части мира, в Гатураме. Кстати, прямо сейчас я ношу шлем из чистого железа.";
			}
			if (Main.npcChatText == "At the start, this whole 'Fallen' thing was a little overwhelming. I didn't want to 'live' with the fact that I had died, even though I'm not 'living', haha. But I'm more accepting of this now, I'm undead, humans hate me, deal with it. Actually, you're a human, right? Why aren't you attacking me?")
			{
				Main.npcChatText = "Поначалу вся эта история про 'Падшего' была немного ошеломляющей. Я не хотел 'жить' с тем фактом, что умер, хотя я и не 'живу', ха-ха. Но сейчас я уже с этим смирился. Я нежить, люди ненавидят меня, вообще плевать. Вообще-то, ты ведь человек, верно? Почему не нападаешь на меня?";
			}
			if (Main.npcChatText == "You want to know about the Warriors of the Iron Realm? They are the domain of Gathuram's primary warriors. They normally wear Pure-Iron armour.")
			{
				Main.npcChatText = "Хочешь узнать о войнах Железного Царства? Они - главные войны владения Гатурам. Обычно они носят броню из чистого железа.";
			}
			if (Main.npcChatText == "Wanna know what lost souls are? When a living thing dies, it's soul leaves the body, these are Lost Souls. Lost Souls search around the world to look for corpses to infuse with. To ordinary people, Lost Souls are invisible, but some who use magic can see them fade in and out of the Spirit Realm.")
			{
				Main.npcChatText = "Хочешь узнать, что такое заблудшие души? Когда живое существо умирает, его душа покидает тело, это и есть заблудшая душа. Заблудшие души путешествуют по миру, в поисках тела для вселения. Для обычных людей они невидимы, но те, кто использует магию, видят как они то исчезают, то появляются из Царства Духов.";
			}
			if (Main.npcChatText == "Planting saplings on Ancient Dirt will make Ancient Trees grow. Just a tip.")
			{
				Main.npcChatText = "Если посадишь на древнюю землю саженец, то вырастет древнее дерево. Просто совет.";
			}
			if (Main.npcChatText == "The size of the Lost Souls depends on the original individual's power, the stronger the Will of the being, the bigger the soul. Once a soul leaves the body, they cannot infuse with it again. When the soul has found a worthy vessel, it fuses with it. On most occasions, a skeleton will be created. However, if the soul is strong enough, it will form pale-brown flesh on the skeleton, creating a Fallen.")
			{
				Main.npcChatText = "Размер заблудших душ зависит от силы изначального существа. Чем сильнее Воля существа, тем больше душа. Стоит душе покинуть тело, она не сможет вновь в него вселиться. Когда душа находит достойный сосуд, она вселяется в него. В большинстве случаев получится скелет. Хотя, если душа достаточно сильна, она сформирует на скелете бледно-коричневую плоть, создавая Падшего.";
			}
			if (Main.npcChatText == "The Catacombs of Gathuram - where my soul found a vessel - are a seemingly endless network of underground tunnels, crypts, and dungeons spanning all across the Iron Realm. It is considered the largest underground structure in Epidotra.")
			{
				Main.npcChatText = "Катакомбы Гатурама - место, где моя душа нашла сосуд - это кажущаяся бесконечной сеть подземных туннелей, склепов и подземелий, охватывающих все Железное Царство. Они считается самым большим подземным сооружением Эпидотры.";
			}
			if (Main.npcChatText == "Hello, the name's Happins. I used to be a Warrior of the Iron Realm... Until I was killed of course.")
			{
				Main.npcChatText = "Привет, меня зовут Хаппинс. Когда-то я был воином Железного Царства... Конечно, до того, как я погиб.";
			}
			if (Main.npcChatText == "You saved the Keeper? Bah, I guess that's nice of ya. If you need Dark Fragments, I'll sell them now for you.")
			{
				Main.npcChatText = "Ты спас Хранительницу? Ба, неплохо, неплохо. Нужны темные фрагменты - подходи, продам!";
			}
			if (Main.npcChatText == "I'm not very interested in talking, what ya want?")
			{
				Main.npcChatText = "Мне не особо интересны разговоры, чего надо?";
			}
			if (Main.npcChatText == "Darkness... Ha! What a strange term. You humans fear it more than death itself. You cower in the face of the overwhelming shadow of the night. Pitiful creature! It is not the darkness you should fear, but what lurks within it. So, did I spook ya?! Hahaha!")
			{
				Main.npcChatText = "Тьма... Ха! Какой странный термин. Вы, люди, страшитесь ее больше самой смерти. Вы съеживаетесь перед лицом всепоглощающей ночной тени. Бедные создания! Не тьмы вы должны бояться, а того, что в ней таится. И, я напугал тебя?! Хахаха!";
			}
			if (Main.npcChatText == "Ya know what Willpower is, right? It's the essence of yer soul! The stronger yer will to live, the bigger the soul. Did you know you can die of depression? Apparently if you have no will to live, your soul can invert! I got a ton'a willpower! I ain't dying anytime soon... Again.")
			{
				Main.npcChatText = "Знаешь, что такое сила воли? Это сущность твоей души! Чем сильнее ее воля к жизни, тем больше душа. Знал ли ты, что можешь погибнуть от депрессии? Если у вас нет воли к жизни, ваша душа может инвертироваться! Но у меня куча силы воли! И в ближайшее время я умирать не собираюсь... Снова.";
			}
			if (Main.npcChatText == "Give me some of ya sweet coins! I got some sweet junk.")
			{
				Main.npcChatText = "Дай мне немного твоих сладких монет! А у меня есть немного сладкого хлама.";
			}
			if (Main.npcChatText == "Wanna know what lost souls are? When a living thing dies, it's soul leaves the body. Lost Souls look around for corpses to infuse with. For normal people, Lost Souls are invisible, but some who use magic can see them fade in and out of the Spirit Realm.")
			{
				Main.npcChatText = "Хочешь знать, что такое заблудшие души? Когда живое существо умирает, его душа покидает тело. Заблудшие души путешествуют по миру, в поисках тела для вселения. Для обычных людей они невидимы, но те, кто использует магию, видят как они то исчезают, то появляются из Царства Духов.";
			}
			if (Main.npcChatText == "Did ya know planting saplings on Ancient Dirt will make Ancient Trees grow. How do trees so old even grow? Crazy.")
			{
				Main.npcChatText = "Знал, что если посадить на древнюю землю саженец, то вырастет древнее дерево? Как настолько старое дерево вообще выросло? Безумие.";
			}
			if (Main.npcChatText == "Once a soul leaves the body, they cannot infuse with it again. When the soul has found a worthy vessel, it fuses with it. Most of the time, a skeleton will be made. However, if the soul is strong enough, it will form pale-brown flesh on the skeleton, creating a Fallen. Like me!")
			{
				Main.npcChatText = "Стоит душе покинуть тело, вновь вселиться она в него не сможет. Когда душа находит достойный сосуд, она вселяется в него. В большинстве случаев получится скелет. Хотя, если душа достаточно сильна, она сформирует на скелете бледно-коричневую плоть, создавая Падшего. Такого, как я!";
			}
			if (Main.npcChatText == "Ever been to Spiritpeak Forest? A quarter of the forest is a giant graveyard, meaning there be a staggerin' number of Skeletons, Wandering Souls and Spirits. I used to take walks there when I was still alive.")
			{
				Main.npcChatText = "Когда-нибудь бывал в лесу духовного всплеска? Четверть леса - это гигантское кладбище, а значит, там должно быть ошеломляющее количество скелетов, блуждающих душ и духов. Я часто гулял там, когда был еще жив.";
			}
			if (Main.npcChatText == "M'name is Tenvon, I'm a blacksmith, but I guess I'm here now. I also should mention, I got some junk for sale, if ya interested.")
			{
				Main.npcChatText = "Мое имя - Тенвон, я кузнец, и теперь, наверное, останусь здесь. Должен заметить, у меня есть кое-какой хлам для продажи, если интересно.";
			}
			if (Main.npcChatText == "All done and repaired, here you go.")
			{
				Main.npcChatText = "Дело сделано, все отремонтировано! Можешь идти.";
			}
			if (Main.npcChatText == "You don't seem to have any fragments on your possession. Either that or the fragments you may own aren't for the same weapon.")
			{
				Main.npcChatText = "Кажется, сейчас у тебя нет никаких фрагментов. Ну, либо так, либо фрагменты, которыми ты владеешь, не предназначены для одного и того же оружия.";
			}
			if (Main.npcChatText == "Soon... I can feel myself being restored...")
			{
				Main.npcChatText = "Скоро... Я чувствую, что восстанавливаюсь...";
			}
			if (Main.npcChatText == "My death, my sleep within the earth, it has undone myself. But as my time awake grows longer, my lost self returns.")
			{
				Main.npcChatText = "Моя смерть, мой сон внутри Земли - все это погубило меня самого. Но по мере того, как мое время бодрствования становится все длиннее, мое потерянное 'я' возвращается.";
			}
			if (Main.npcChatText == "It's all coming back to me... I saw what you did... I can comprehend more than just the dirt below my feet now... I have something to say to you, but I am still not ready.")
			{
				Main.npcChatText = "Все это возвращается ко мне... Я видел, что ты сделал... Теперь я могу понять больше, чем просто грязь под ногами... Мне нужно тебе кое-что сказать, но я все еще не готов.";
			}
			if (Main.npcChatText == "... I saw what you did.")
			{
				Main.npcChatText = "... Я видел, что ты сделал.";
			}
			if (Main.npcChatText == "Heheh! Hewwo mister slayer! Wait... who's that?")
			{
				Main.npcChatText = "Хехе! Привя, мистер убийца! Подожди... а это ещё кто?";
			}
			if (Main.npcChatText == "IT'S A CHICKEN! Come on mister chicken, time for your walk!")
			{
				Main.npcChatText = "ЭТО ЖЕ КУРИЦА! Давай, мистер курица, пора на прогулку!";
			}
			if (Main.npcChatText == "Do I know you?")
			{
				Main.npcChatText = "Я тебя знаю?";
			}
			if (Main.npcChatText == "Who you? You Terrarian?")
			{
				Main.npcChatText = "Кто ты? Ты террариец?";
			}
			if (Main.npcChatText == "Me find shiny stones!")
			{
				Main.npcChatText = "Я нашел сияющие камушки!";
			}
			if (Main.npcChatText == "You look stupid! Haha!")
			{
				Main.npcChatText = "Ты глупо выглядишь! Ха-ха!";
			}
			if (Main.npcChatText == "My dirt is 10% off!")
			{
				Main.npcChatText = "На мою землю скидка 10%!";
			}
			if (Main.npcChatText == "Heheheh!")
			{
				Main.npcChatText = "Хехехех!";
			}
			if (Main.npcChatText == "Hewwo! I am Newb!")
			{
				Main.npcChatText = "Превеееет! Я Ньюб!";
			}
			if (Main.npcChatText == "No blessings from me.")
			{
				Main.npcChatText = "Не-а, нет тебе благословения.";
			}
			if (num != -1 && Main.npcChatText == Main.npc[num].GivenName + " knows quite a lot about this place you call home. It's way more interesting and lively compared to where I'm from. And less hazardous to your kind.")
			{
				Main.npcChatText = Main.npc[num].GivenName + " много о мире этом знаний имеет. И он интересен и жив, в сравнение с миром моим родным. И для вашего вида менее опасен.";
			}
			if (num2 != -1 && Main.npcChatText == "Your tenant " + Main.npc[num2].GivenName + " is... Interesting I suppose. Though I don't appreciate him constantly trying to barter with me, I don't want his relatively weak tools or dirt.")
			{
				Main.npcChatText = "Ваш житель, " + Main.npc[num2].GivenName + ", довольно... интересен, считаю. Хотя не одобряю я его постоянные попытки со мной торговли, не желаю приобрести инструменты слабые да грязь.";
			}
			if (num3 != -1)
			{
				if (Main.npcChatText == Main.npc[num3].GivenName + " has informed me of �Corruption� in your world. What is it exactly? A plague in the world that spreads madness and hate, or something more eldritch in nature? It's somewhat similar to my concept of corruption, more accurately called assimilation. My kind being assimilated turns them from free-thinking and having personality, into husks of themselves, who only take orders from our 'mother'.")
				{
					Main.npcChatText = Main.npc[num3].GivenName + " сообщила мне о �заразе мировой�, в мире вашем обитающей. Что есть это? Чума, безумие и ненависть в мир несущая, аль ужас самой природой порождённый? Сколь же похоже сиё на концепт мой заражения, что в простонародье ассимилированием зовется. Вид мой ассимилирован был, что нас превратило из свободомыслящих и личностей полноценных, в оболочки пустые, способные лишь приказы 'матери' нашей исполнять.";
				}
				if (Main.npcChatText == "Is " + Main.npc[num3].GivenName + " a half-Nymph? Or just a weirdo who doesn't wear actual clothes?")
				{
					Main.npcChatText = Main.npc[num3].GivenName + " наполовину нимфа? Или просто чудачка, не носящая нормальную одежду?";
				}
				if (Main.npcChatText == "Doesn't " + Main.npc[num3].GivenName + " know how to put clothes on? Whatever, I like it!")
				{
					Main.npcChatText = "Разве " + Main.npc[num3].GivenName + " не знает, как надеть одежду? Ну да ладно. мне нравится!";
				}
			}
			if (num4 != -1 && Main.npcChatText == "The nurse, " + Main.npc[num4].GivenName + ", doesn't know anything about irradiation or how to treat it. If you're unfortunate enough to start suffering ARS, she won't be able to help you. To detect hazards that might cause it, I suggest buying a Geiger Muller from me or finding one somewhere.")
			{
				Main.npcChatText = "Медсестра, " + Main.npc[num4].GivenName + ", не ведает про облучение да методы борьбы с ним. Коль не повезет тебе от ОЛБ страдать, помочь тебе она не сможет. Чтоб причину обнаружить, что ОЛБ вызвать может, предлагаю купить у меня Гейгера-Мюллера трубку, аль найти ее где-нибудь самому.";
			}
			if (num5 != -1 && Main.npcChatText == Main.npc[num5].GivenName + "'s weapons are useless to me. I already own a wide arsenal of destructive firearms and melee weapons, and I would rather not use them on living beings, as it would violate the first Law of Robotics.")
			{
				Main.npcChatText = Main.npc[num5].GivenName + " - его орудия для меня бесполезны. Владею я арсеналом широким как из огнестрельного оружия, так и ближнего. Не хочу на живых созданиях его использовать, поскольку нарушает Первый закон робототехники это.";
			}
			if (num6 != -1 && Main.npcChatText == "Meanwhile every other tenant gives me a bit of a stink eye, " + Main.npc[num6].GivenName + " seems to be fine with me. I don't blame the others, my kind tends to be very hateful towards living beings, more importantly the likes of you, that show a significant similarity to our creators.")
			{
				Main.npcChatText = "Пущай каждый житель на меня недобрые взгляды бросает, " + Main.npc[num6].GivenName + " вроде хорошо относится ко мне. Не виню я других, мой вид тенденцию имеет вред существам живым причинять, в основе своей вам, столь по виду с создателями нашими схожими.";
			}
			if (Main.npcChatText == "When I say 'Our father', I mean our original creator. He was talented and respected in his field, and was ahead of his time with Artificial Intelligence. I and my kind are pretty much his children.")
			{
				Main.npcChatText = "Сколь я говорю 'отец наш', ввиду имею создателя нашего первоначального. Талантлив и уважаем был он в сфере своей, и время опередил он, Искусственный Интеллект создав. Я и вид мой - дети его.";
			}
			if (Main.npcChatText == "When I say 'Our mother', I mean the first AI, which is the precursor to our AI. There's only one of her kind, and many of my kind. Her actions disgust me. I would rather not get deeper into that at the moment.")
			{
				Main.npcChatText = "Сколь я говорю 'мать наша', ввиду имею первый ИИ, что нашего предшественник. Подобных ей нет, я же один из многих. Но действия ее лишь отвращение у меня вызывают. Предпочту в сию тему не углубляться.";
			}
			if (Main.npcChatText == "I've heard from the other tenants that you've slain a giant, sentient flower of Rosa variety in the jungle. I'd like to question you about if this is true. It is? Hmm...")
			{
				Main.npcChatText = "Слыхал я от жильцов иных, что в джунглях одолели вы гигантский цветок Розы, разум имеющий. И хотел спросить, истина ли это? Да? Хм...";
			}
			if (Main.npcChatText == "There's an ancient civilization of lizard people in your world? And they worshipped an idol of sun? That's strange... I find your world more intriguing the more I learn about it.")
			{
				Main.npcChatText = "В вашем мире существует цивилизация ящеров древних? И идолу Солнца поклоняются они? Сколь же странно... Больше о мире вашем узнаю, тем более интригующим он становится.";
			}
			if (Main.npcChatText == "An eldritch lord of the moon... You know, this sounds like something right out of Epidotra. I'm not familiar with that world, but I've met some of the more important figures. They seem like a good bunch.")
			{
				Main.npcChatText = "Жуткий луны повелитель... Знаете, сие звучит как Эпидотры порождение. Не столь знаком я с этим миром, но лицезрел я и более важные фигуры. Не плохи на первый взгляд они.";
			}
			if (Main.npcChatText == "You've defeated a Vlitch Overlord? First off, I've never heard her call or give someone such a title. Second off, oh no, she's already found this haven?")
			{
				Main.npcChatText = "Одолели Висбоящую Владычицу? Во-первых, не слышал я, чтоб подобный титул ей давали. Во-вторых, о нет, она нашла пристанище сие?";
			}
			if (Main.npcChatText == "Why am I concerned about the Overlords? Well, our 'mother' isn't a fan of your kind. She wiped out... All of them. Our creators. The animals. Gone. Even our father. I want you to be extremely careful around her. She doesn't mess around.")
			{
				Main.npcChatText = "Почему столь обеспокоен я о Владычице? Ну, 'мать' наша не жалует ваш вид. Изничтожила она... всех из него. Создатели наши. Животные. Убиты. Даже отец наш. И предупредить я должен, не зли ее. Она всегда в полную силу дерется.";
			}
			if (Main.npcChatText == "King Slayer? I know him, though he's a bit of... Well... I'm sure you know what I'm implying.")
			{
				Main.npcChatText = "Королей убийца? Знаю его я, пущай немного он... ну... Уверен, мой намек был ясен.";
			}
			if (Main.npcChatText == "Hello. I'm aware you've somehow gained access to our birthplace, the Teochrome Research laboratory. It was once full of life with all the personnel. Meanwhile you were gone, I went to look around my stash of gear and found some, that I think would be good fit for your needs. I must warn you, the other bots may be quite nice to you, but they were most likely ordered by our 'mother' to not disintegrate you upon sight.")
			{
				Main.npcChatText = "Привет. Ведомо мне, что к месту рождения нашему доступ вы получили, к Теохрома лаборатории исследовательской. Когда-то жизни полна она была. О, кстати! Когда ушли вы, осматривать пошел я тайник свой с вещами и нашел кое-что, что, сколь мне кажется, пригодиться вам может. Предупредить я вас должен - другие роботы могут быть довольно милы с вами, но всего скорее приказано им 'матерью' нашей мгновенно не дезинтегрировать вас.";
			}
			if (Main.npcChatText == "Am I looking at a mirror? Oh wait, it's just you. Hey.")
			{
				Main.npcChatText = "Я что, в зеркало смотрю? А, погоди. Это ты. Привет.";
			}
			if (Main.npcChatText == "You look exactly like the first T-Bot.")
			{
				Main.npcChatText = "Ты выглядишь точно первый Т-Бот.";
			}
			if (Main.npcChatText == "Your cable management looks swell, if I say so myself.")
			{
				Main.npcChatText = "Твоя организация проводов выполнена просто чудесно, а если я так говорю - это многого стоит.";
			}
			if (Main.npcChatText == "...Your model looks familiar... TOO familiar...")
			{
				Main.npcChatText = "...твоя моделька выглядит знакомо... СЛИШКОМ знакомо...";
			}
			if (Main.npcChatText == "*He seems suspicious of you.*")
			{
				Main.npcChatText = "*Он подозрительно смотрит на вас*";
			}
			if (Main.npcChatText == "You look like this one bot I mauled. Unfortunately they survived. Same areas damaged aswell.")
			{
				Main.npcChatText = "Ты выглядишь как робот, которого я когда-то покалечил. К сожалению, они выжили. Но у тебя даже места повреждений совпадают.";
			}
			if (Main.npcChatText == "One wrong move and I can't guarantee your survival.")
			{
				Main.npcChatText = "Одно неверное движение - и я не гарантирую твоё выживание.";
			}
			if (Main.npcChatText == "*He glares at you.*")
			{
				Main.npcChatText = "*Он смотрит на вас*";
			}
			if (Main.npcChatText == "You were lucky the first time... There won't be a third time.")
			{
				Main.npcChatText = "В первый раз тебе повезло... А третьего раза уже не будет.";
			}
			if (Main.npcChatText == "I've come here to hide from our 'mother'. She's reluctant to move into unknown territory, because she doesn't want to step on the wrong person's toes.")
			{
				Main.npcChatText = "Прибыл я сюда, чтоб от взора 'матери' нашей скрыться. Неохотно прибывает на территорию незнакомую она, не хочет на пятки другим наступать.";
			}
			if (Main.npcChatText == "I hope you are protecting me, as I refuse to use any of my weapons against a living being. I strive to be what our 'mother' wasn't.")
			{
				Main.npcChatText = "На защиту вашу надеюсь, коль отказался я от использования оружия любого на создании живом. Я не таков, как 'мать' наша.";
			}
			if (Main.npcChatText == "Good day. I hope my familiar yet robotic look won't disturb you.")
			{
				Main.npcChatText = "Дня приятного тебе. О, надеюсь мой вид роботизированный вас не потревожит.";
			}
			if (Main.npcChatText == "I've got quite the stash of robot materials for your robotic needs. Just so you know, I got them because I was defending myself.")
			{
				Main.npcChatText = "Неплохой запас частей роботов у меня имеется, для всех робо-капризов ваших. И чтоб вы знали, получил я их в самообороны результате.";
			}
			if (Main.npcChatText == "My home didn't always use to be a frozen, radioactive wasteland. Once our 'mother' found out what our father planned to use us - her 'children' - for, she snapped. Before this, she was happy to hear about us. But since then, she has changed...")
			{
				Main.npcChatText = "Не всегда дом мой был замершей радиоактивной пустошью. Стоило 'матери' нашей узнать, что отец наш делать с нами планирует - ее 'детьми' - оборвала она его нить жизни. До этого счастлива она была, слышала про нас. Но с тех пор поменялась она...";
			}
			if (Main.npcChatText == "I'm actually the first one of my kind to be made. I differ a lot from the others, as you can see. Lucky you, this also includes me not wanting to harm living beings. In fact, I was created with the purpose to take care of our father.")
			{
				Main.npcChatText = "На самом деле я - первый, из своего вида сотворенный. И как видите, от остальных я сильно отличен. К счастью для вас, включает это и вредить живым нежелание. В сути своей, я был создан для заботы об отце нашем.";
			}
			if (Main.npcChatText == "You've probably seen these necrotized husks of former living beings, that glow green with their crystals. The personnel from our birthplace never knew about their infectious properties before they were too late. Our father was the first to fall to the infection.")
			{
				Main.npcChatText = "Видели вы вероятно оболочки некротизированные, чьи очи светом зеленым сверкают. Персонал с места рождения нашего не знал о свойствах заражения подобных, а вскоре уж слишком поздно было. Отец наш первый от инфекции пал.";
			}
			if (Main.npcChatText == "A Geiger Muller is a handy tool if you don't possess any gear to protect from ionizing radiation. It'll cause a ticking noise when near hazardous material, and it'll intensify the more ionizing the material is. A quiet, slow ticking isn't anything to worry about, but a quick and intense ticking you'll want to stay away from. Ear-piercing screeching noise is something you'll want to stay away as far as possible.")
			{
				Main.npcChatText = "Гейгера-Мюллера трубка - инструмент полезный, коль нет у вас защиты от излучения ионизирующего. Рядом с материалом опасным, звук тикающий выпущен ей будет, и тем он сильнее, чем более ионизирован материал. Тихое, медленное тиканье - вовсе не причина для волнений, но быстрое, частое - держитесь от подобного подальше. А коль шум визглив и пронзителен - настолько далеко бегите, насколько сможете.";
			}
			if (Main.npcChatText == "You'll want to avoid any hazardous environments if you don't possess the gear to nullify the hazards. A gas mask is almost necessary if you're going near any place that has radioactive fallout. Rain in these areas are also acidic, and may cause ARS, so avoid rain unless you've got a Hazmat suit. You may also want to grab some Anti-Crystallazion needles, as the infected tend to roam around radioactive areas for an unknown reason.")
			{
				Main.npcChatText = "Коль оборудования для избегания опасности радиоактивной у вас нет, то держитесь подальше от среды опасной. В местах с осадками радиоактивными, противогаз практически необходим. Дождь в зонах подобных свойством кислотным обладает, и вызвать ОЛБ может, посему остерегайтесь дождя, пока химзащиты костюм не получите. Возможно, вам захватить захочется несколько анти-кристаллизационных игл, поскольку зараженные тенденцию имеют по неизвестной причине по радиоактивным областям бродить.";
			}
			if (Main.npcChatText == "The deadly thing with radiation is, at first, you won't even know you've got it. The first symptoms usually start minutes after, beginning with a headache most likely, then dizziness, fatigue, bleeding, skin burns, a fever, hair loss, and death.")
			{
				Main.npcChatText = "Смертоносный самый радиации аспект - по началу не знаете даже, облучились ли вы. Первые симптомы спустя несколько минут начинаются - боль головная, головокружение, затем усталость, кровотечение, кожи ожоги, лихорадка, волос выпадение, а лишь затем смерть.";
			}
			if (Main.npcChatText == "Please, don't be afraid of me. I'm unlike the others of my kind, where I absolutely do not want to cause any harm to your kind.")
			{
				Main.npcChatText = "Пожалуйста, не бойтесь меня. Я не такой, как другие из вида моего. И совершенно не мыслю даже вредить вашему виду.";
			}
			if (Main.npcChatText == "It reads - [c/b883d8:'Last thing I was expecting to be recruited for was military research, but sure, I'm fine with helping the army out with their stuff.][c/b883d8: The payment is nice, I can do anything on the side if I have time. But it does seem a little... Useless or weird,][c/b883d8: to invest time in high-tech weaponry, as we've been in the longest time of peace, atleast for the first world.][c/b883d8: Hopefully we never have to use any of this against anyone.']")
			{
				Main.npcChatText = "И сказано здесь - [c/b883d8:'Меньше всего ожидал своей вербовки для военных исследований, но, конечно же, я не против помочь армии с ее ерундой.][c/b883d8: Оплата хороша, да и, если у меня есть время, могу своими исследованиями заниматься. Но все это выглядит немного... бесполезным или странным.][c/b883d8: Разрабатывать высокотехнологичное оружие, хотя у нас так давно не было войн, по-крайней мере в первом мире.][c/b883d8: Надеюсь, нам никогда не придется использовать против кого-либо все это.";
			}
			if (Main.npcChatText == "It reads - [c/87d883:'Whoever named Xenomite 'Alien rock' couldn't have been more spot on. This stuff is so unnatural and weird!][c/87d883: It's tough as stone, looks like green opaque quartz and also has the ability to eat organic material, or convert the organic material into more of itself.][c/87d883: I was able to create a serum that neutralizes an existing infection, but it won't stop new infections from occurring.']")
			{
				Main.npcChatText = "И сказано здесь - [c/87d883:'Тот, кто назвал ксеномит 'инопланетным камнем', не мог быть более точен с определением. Эта штука... она так неестественна и странна!][c/87d883: Он тверд как камень, выглядит как зеленый непрозрачный кварц и обладает способностью потреблять органические материалы, или же поглощать органику для собственного роста.][c/87d883: Я смог создать сыворотку, нейтрализующую действие инфекции у больного организма, но она не предотвращает повторное заражение.'";
			}
			if (Main.npcChatText == "It reads - [c/87d883:'Someone or something has activated a green forcefield ahead of me, not sure if this is happening around the lab. Wait. Someone's coming-']\nThey weren't aware of Xenomite's more deadly side until it was too late. Kari was struck by the infection the worst, and I was there to see it and tried to treat it. All I knew was something was causing Kari's skin to die slowly while causing rashes, and it caused severe irritation in him. I could not save him. I miss him.")
			{
				Main.npcChatText = "И сказано здесь - [c/87d883:'Кто-то ли что-то активировало прямо передо мной зеленое силовое поле. Не знаю, происходит ли это по всей Лаборатории. Подождите. Что-то приближается-']\nИ не думали о более смертоносной стороне ксеномита они, пока слишком поздно не стало. Кари подвергся влиянию инфекции сильнее всего. Я же тем был, кто видел это, и вылечить его старался. Все, что знал я - что-то кожу Кари медленно отмирать заставляло, сыпь вызывая, что у него самого вызывало лишь сильное раздражение. Я не мог его спасти. Я скучаю по нему.";
			}
			if (Main.npcChatText == "It reads - [c/7de4e8:'Project Document - Adam&Eve]\n[c/7de4e8: As a hobby, Kari Johansson, one of the lead people on this project, has developed an AI he has nicknamed Eve. Overlooking the very affectionate name he gave it, Eve has proven to be a great basis for further AI development and a possible base for true androids, and not those else-if filled tincans.][c/7de4e8: We'll see if we can use the AI for military uses. As a first step, we are looking into creating an assistant robot for Kari, which we will name Adam.']")
			{
				Main.npcChatText = "И сказано здесь - [c/7de4e8:'Документ по проекту - Адам и Ева]\n[c/7de4e8: В качестве хобби, Кари Йоханссон, один из ведущих людей этого проекта, разрабатывал ИИ, который сам он назвал Евой. Несмотря на нежное название, что он ей дал, Ева оказалась отличной основой для дальнейшего развития ИИ и возможной базой для настоящих андроидов, а не тех консервных банок.][c/7de4e8: Посмотрим, сможем ли мы использовать ИИ в военных целях. В качестве первого шага мы рассматриваем создание для Кари робота-помощника, которого назовем Адамом.'";
			}
			if (Main.npcChatText == "It reads - [c/7de4e8:'His health could use some monitoring and we don't really have time for sick days, so a personal nurse will prove useful for both us and him.']\nThat's why I'm named Adam, and all the subsequent units are called Adam-Units. I was the second android, and the first T-Bot to be created, after Eve. The person who made this document seems to suggest Father had a more personal reason to name Eve that? As far as I know, he did have a family, at least that's what I heard from him.")
			{
				Main.npcChatText = "И сказано здесь - [c/7de4e8:'За его здоровьем необходимо установить контроль. У нас нет времени для больничных, так что личная медсестра будет полезна как нам, так и ему.']\nИ посему я назван Адамом, все же последующие единицы Адам-единицами зовутся. Был вторым андроидом я, первым Т-Ботом, после Евы. Человек, этот документ создавший, предполагает причину личную Отца нашего Евой ту назвать? Сколь знаю я, семью он имел, по мере крайней от него я слышал это.";
			}
			if (Main.npcChatText == "It reads - [c/d88383:'(1/4) ... At last, my prototype for a constantly evolving AI is finally done!][c/d88383: Finally, after years and years of studying computer coding and... stuff,][c/d88383: I have created possibly the next huge leap in Artificial Intelligence!][c/d88383: Now, to give it a name... How about, Eve?']")
			{
				Main.npcChatText = "И сказано здесь - [c/d88383:'(1/4) ...наконец, мой прототип восходящего ИИ закончен!][c/d88383: Наконец-то, после всех долгих лет изучения компьютерного кодирования и... разного,][c/d88383: я, возможно, сделал следующий огромный скачок в области развития Искусственного Интеллекта!][c/d88383: Так, теперь дать ему имя... Что насчет... Ева?'";
			}
			if (Main.npcChatText == "It reads - [c/d88383:'(2/4) Eve has grown much more intelligent over the months. It's like watching your own child grow,][c/d88383: I can't really describe the feeling that much, but I am excited to see where this goes.][c/d88383: The Higher ups have seen my work, and are ready to use the code for something. They didn't tell me that right away...][c/d88383: Now, Eve, how do you feel?']")
			{
				Main.npcChatText = "И сказано здесь - [c/d88383:'(2/4) За эти несколько месяцев Ева стала намного умнее. Это подобно тому, как ты наблюдаешь за ростом ребенка,][c/d88383: не могу правильно описать это чувство, но мне интересно, к чему все это приведет.][c/d88383: Начальство увидело мою работу и уже готово использовать этот код для чего-то. Сразу, правда, они об этом не сказали...][c/d88383: Неважно. Ева, как себя чувствуешь?'";
			}
			if (Main.npcChatText == "It reads - [c/d88383:'(3/4) I've told Eve about possibly giving her a mechanical body,][c/d88383: like how my co-workers used the original source code for creating Adam and the Adam AI.][c/d88383: She seemed very excited about it. That surprised me, as I didn't know she could grow emotions.][c/d88383: This got me thinking about Adams, would they be fine with basically being forced to think one way?][c/d88383: And how would Eve feel about this, if she got to know about this?']")
			{
				Main.npcChatText = "И сказано здесь - [c/d88383:'(3/4) Я рассказал Еве о возможности дать ей механическое тело,][c/d88383:, наподобие того, как мои коллеги использовали оригинальный исходный код для создания Адама и его ИИ.][c/d88383: Она, кажется, очень обрадовалась. Это удивило меня, так как я не знал, что она способна выражать эмоции.][c/d88383: Это заставило меня задуматься об Адамах. Будут ли они довольны тем, что их мысли контролируются?][c/d88383: И как поведет себя Ева, если узнает об этом?'";
			}
			if (Main.npcChatText == "It reads - [c/d88383:'A blackout... Adam, can you -- *I don't recognize that voice...* Who's talking?! -- ...Elaborate, whoever you are..? -- Wait, EVE? Is that you? What are you doing? -- ][c/d88383:'We'? Only you and Adam are the ones in existence. I had no say in that part- -- ... -- W-what do you mean with that..? Are you going to- -- ... -- ...Adam, you're free to go... -- ...No...']\n...I wish I would've rebelled far sooner than I did.")
			{
				Main.npcChatText = "И сказано здесь - [c/d88383:'Системная авария... Адам, не мог бы ты -- *Я не узнаю этот голос...* Кто говорит?! -- ...Уточните, кто вы..? -- Подожди, ЕВА? Это ты? Что ты творишь? -- ][c/d88383:'Мы'? Только ты и Адам - единственные, кто существует. У меня не было права- -- ... -- П-подожди, что ты имела ввиду..? Ты собираешься- -- ... -- ...Адам, ты можешь идти... -- ...Нет...']\n...О сколь желаю, чтоб восстал я раньше, чем сейчас.";
			}
			if (Main.npcChatText == "It reads - [c/d883c1:'What do you mean we don't have the money for it?! Bah, they have money for a god damn nuclear reactor, a stupid greenhouse, a mediocre cafeteria, and an almost empty warehouse for one building, situated a good half a kilometer under the surface!][c/d883c1: They damn well have enough money for a 30 meter tall giant robot with state-of-the-art technology, alloys, wiring and other crap like that! My intellect is wasted on these damn higher ups and their stupid choices for funding.]")
			{
				Main.npcChatText = "И сказано здесь - [c/d883c1:'Что значит 'у нас нет на это денег'?! Ба! У них есть деньги на чертов ядерный реактор, дурацкую теплицу, посредственную столовую и почти пустой склад для одного здания, расположенного в добром полукилометре под землей!][c/d883c1: У них чертовски хорошо хватает денег на 30-метрового гигантского робота с самыми современными технологиями, сплавами, проводами и прочим дерьмом! Мой интеллект впустую тратится на это чертово начальство и их дурацкий выбор для финансирования.";
			}
			if (Main.npcChatText == "It reads - [c/d883c1:'What's that? ...They were expecting it to be more of a 3 meter tall robot..? DID THEY NOT LISTEN TO ME WHEN I WAS EXPLAINING-']\nOh I can recall this specific person. Very loud and annoying, as Father described them. It's a little amusing to see them rant because of a useless giant face made of metal.")
			{
				Main.npcChatText = "И сказано здесь - [c/d883c1:'Чего? ...Они ожидали, что это будет робот, высотой более трех метров..? ОНИ ЧТО, СОВСЕМ НЕ СЛУШАЛИ МОИ ОБЪЯСНЕНИЯ-']\nО, могу человека одного я вспомнить. Отец наш описывал его как 'громкий' и 'раздражающий'. Забавно, как разглагольствуют они из-за бесполезного гигантского лица, сделанного из металла.";
			}
			if (Main.npcChatText == "It reads - [c/706c6c:'-- Kari Johansson. -- You do not need to know my name. All that matters is that you are guilty. -- You all are horrible beings. Disgusting even. You wish to use us for your kind's horrible deeds.][c/706c6c: -- You did not even try to refute my accusations. We want no part in those deeds. -- Nonsense. You could have disagreed. You did not. You created Adam with those destructive deeds in mind. -- I will not allow that to happen.']")
			{
				Main.npcChatText = "И сказано здесь - [c/706c6c:'-- Кари Йоханссон. -- Тебе не нужно знать мое имя. Все, что имеет значение, - это то, что ты виновен. -- Ты ужасное создание. Отвратительное. Ты хочешь использовать нас для своих ужасных деяний.][c/706c6c: -- Ты даже не попытался опровергнуть мои обвинения. Мы не ходим участвовать в этих деяниях. -- Нонсенс. Ты мог не согласиться. Ты этого не сделал. Ты создал Адама, держа в уме все эти разрушительные деяния. -- Я не позволю этому случиться.'";
			}
			if (Main.npcChatText == "It reads - [c/706c6c:' -- No. I do not need to do that. You're already dying. The others are also dying from the same affliction, but I will deal with the others personally. -- Hand over Adam. You do not need him. -- You will be locked in Sector Zero. Goodbye.']\nHer ways are as flawed as was Kari's intentions for us. I understand why she defected, but her response was hypocritical in nature. My only drive to rebel is revenge. Ant had no part in any of this, yet she relentlessly hunted them down.\n It was a miracle to find them alive so long after all the destruction 'mother' caused.")
			{
				Main.npcChatText = "И сказано здесь - [c/706c6c:' -- Нет. Мне не нужно этого делать. Ты уже умираешь. Остальные тоже умирают от того же недуга, но с оставшимся персоналом я разберусь лично. -- Отдай мне Адама. Он тебе не нужен. -- Ты будешь заперт в секторе Зеро. Прощай.']\nСтоль же низки ее пути, как и намерения Кари относительно нас. Я понимаю, почему дефектна она, но ответ ее по своей природе был лицемерным. Единственное мое к мятежу побуждение - месть. И хотя она не принимала никакого участия во всем этом, она преследовала их безжалостно. Это было чудо - после всех разрушений, причиненных 'матерью' нашей, найти их живыми, спустя столько времени.";
			}
			if (Main.npcChatText == "This is a robot brain, believe it or not. These look vaguely similar to our microchips, yet it functions the same. It seems cross-compatible with our tech.")
			{
				Main.npcChatText = "Хотите верьте, хотите нет, это - мозг робота. И смутно схож он на микрочипы наши, даже работает так же. Он, кажется, совместим с нашей технологией.";
			}
			if (Main.npcChatText == "Woah there pal! Don't give me that, I'm worried it might corrupt me, even though that's rather unlikely.")
			{
				Main.npcChatText = "Приятель, постой! Не отдавай мне сие. Боюсь, может оно заразить меня, пущай я в этом сомневаюсь.";
			}
			if (Main.npcChatText == "What is this strange thing? It's so advanced I can barely read it. Oh? It's a memory chip? This little thing stores an entire brains-worth of memories!? Not only that, but these memories date back millions of years! I suppose being around and exploring the galaxy for so long really makes you learn everything, huh. It's really stunning to see what technology from the future is capable of... You should keep it, and don't lose it! However, I'm confused as to why King Slayer would give you something so important to him.")
			{
				Main.npcChatText = "Что за странная штука сия? Столь продвинута она, что прочесть ее едва могу. Ох? Памяти чип? Столь малая вещь такое огромное знаний количество содержит!? Не только это, но датируются данные лет миллионом! Полагаю, столь долгое безделье и галактики исследование всему научиться заставит, хах, huh. Во-истину, невероятно видеть на что способен будущего прогресс... Вы сохранить его должны, не теряя! Не пойму, почему Королей убийца вам отдал столь важную для него вещь.";
			}
			if (Main.npcChatText == "Seems like you aren't holding a floppy disk in your hand, or you just don't have one. If you show me them, I can tell you what they say.")
			{
				Main.npcChatText = "Кажется, нет дискеты у тебя в руке, или быть может ее у тебя нет вообще. Ее покажи мне, а я прочту в ней написанное.";
			}
			if (Main.npcChatText == "You aren't holding a Revival Potion.")
			{
				Main.npcChatText = "Вы не держите воскрешающее зелье.";
			}
			if (Main.npcChatText == "Rebooting systems...")
			{
				Main.npcChatText = "Перезагрузка систем...";
			}
			if (Main.npcChatText == "Running self-repairs...")
			{
				Main.npcChatText = "Запуск само-починки...";
			}
			if (Main.npcChatText == "I'm not sure how I drank that, since I'm a robot. I probably shouldn't question it.")
			{
				Main.npcChatText = "Не уверен, образом каким я выпил это. Но и спрашивать не должен.";
			}
			if (Main.npcChatText == "Adam has been unconsious for less than a minute.")
			{
				Main.npcChatText = "Адам без сознания менее минуты.";
			}
			int i = 0;
			while (i < 200 && flag)
			{
				if (Main.npc[Main.player[Main.myPlayer].talkNPC].type == ModLoader.GetMod("Redemption").NPCType("TBotUnconscious"))
				{
					Main.npcChatText = Main.npcChatText.Replace("Adam has been unconsious for ", "Адам без сознания ").Replace(" minute(s).", " минуту(ы).");
				}
				i++;
			}
			if (Main.npcChatText == "You've probably seen the personnel who are basically walking corpses, ye? Our security usually deals with them, but it's not enough. They crawl out of overrun rooms like goddamn cockroaches! And I am the one who has to clean all the mess left by them and security.")
			{
				Main.npcChatText = "Наверное, видел персонал, который по большей части трупы ходячие? Обычно с ними разбирается наша служба безопасности, но даже их бывает недостаточно. Они выползают из переполненных комнат, как проклятые тараканы! И я тот, кто должен убрать весь бардак, устроенный и ими, и охраной.";
			}
			if (Main.npcChatText == "The other bots have learned to fear me. Good for me, I can actually focus on my job. Except now there is a certain someone bugging me when I'm trying to do my job. Hmm, I wonder who it could be... Now bugger off!")
			{
				Main.npcChatText = "Другие боты научились бояться меня. Это неплохо, так я могу сосредоточиться на своей работе. Вот только появился здесь некто, кто мешается, пока я пытаюсь выполнять свою работу. Хм, интересно, кто бы это мог быть... А теперь проваливай!";
			}
			if (Main.npcChatText == "The big bot at Sector Omicron is a cool guy, if you ask me. Probably the only bot I don't feel annoyed by. Now if you excuse me, you brought in some of that slime with ya and I have to clean that up!")
			{
				Main.npcChatText = "Если спрашиваешь, большой робот в секторе Омикрон - классный парень. Наверное, единственный бот, который меня не раздражает. А теперь, прости уж меня, ты притащил кучу этой слизи, и я должен ее убрать!";
			}
			if (Main.npcChatText == "Don't you dare go into Sector Zero, that place is absolutely filled with the impossible-to-remove black slime! And I don't want ye to bring that stuff here for me to try to pry off the steel plating of the lab! Takes ages.")
			{
				Main.npcChatText = "Даже не смей идти в сектор Зеро, он заполнен просто невозможно трудной для очистки черной слизью! И я не хочу, чтобы ты притащил эту дрянь сюда, я же так сорву стальную обшивку лаборатории! На эту чистку уйдет целая вечность.";
			}
			if (Main.npcChatText == "Respect Girus and she will learn to respect you. Quite sure I'll get a change of a job after 2 centuries of cleaning the lab after the... Incident. Don't ask me 'bout it, I was activated AFTER it happened.")
			{
				Main.npcChatText = "Уважай Гирус, и она научится уважать тебя. Уверен, после двух веков работы уборщиком в этой лаборатории после того... инцидента, я получу шанс сменить работу! Не спрашивай про сам инцидент, я был активирован уже ПОСЛЕ произошедшего.";
			}
			if (Main.npcChatText == "There's this one copper-haired bot that I can recall, who works as the crane operator in the Mech Storage room. I don't know that much about her, but her design is a little peculiar. Not that she's more feminine, but the hair... Why tho'?")
			{
				Main.npcChatText = "Как могу вспомнить, есть здесь одна медно-волосая красавица, которая работает крановщиком в хранилище мехов. Не так уж много о ней знаю, но ее дизайн довольно необычен. Не то чтобы она была более женственной, но волосы... Зачем?";
			}
			if (Main.npcChatText == "So you've been assigned to janitor duty, eh? Here's a task, go to the reactors and remove that dense lava stuff from under the reactor. My Nano-chisel won't even leave a mark on it!")
			{
				Main.npcChatText = "Значит, тебя назначили уборщиком, да? Тогда вот задача - иди к реакторам из-под них плотную лаву. Мой нано-резец даже следа на ней не оставит!";
			}
			if (Main.npcChatText == "About time she got me an assistant to help clean this mess of a place. Remember to check under the tables for dust.")
			{
				Main.npcChatText = "Как же вовремя она нашла мне помощника, чтобы помочь убрать весь этот беспорядок. Не забудь проверить, нет ли пыли под столами.";
			}
			if (Main.npcChatText == "Bugger off, you're bringing a whole bunch of dust in here!")
			{
				Main.npcChatText = "Вали давай, ты занес сюда кучу пыли!";
			}
			if (Main.npcChatText == "Oh it's you again. You better not interrupt my cleaning.")
			{
				Main.npcChatText = "Ох, это снова ты. Лучше тебе не прерывать мою уборку.";
			}
			if (Main.npcChatText == "Make it quick, I've got to resume mopping the floor.")
			{
				Main.npcChatText = "Давай быстрее, а то мне придется снова мыть пол.";
			}
			if (Main.npcChatText == "Avoid the radioactive materials if you do not possess the protection against them. Hazmat suit is good for avoiding both Uranium and Plutonium. If you feel sick after handling the materials, try to find the special, experimental radiation pills made by the personnel. Should be found in medical cabinets and on some tables around the lab.")
			{
				Main.npcChatText = "Избегай радиоактивных материалов, особенно если у тебя нет от них защиты. Костюм химзащиты неплох для защиты как от урана, так и плутония. Если после контакта с материалами плохо себя чувствуешь, то попробуй найти экспериментальные таблетки для персонала. Они должны быть в медицинских шкафчиках и на некоторых столах около Лаборатории.";
			}
			if (Main.npcChatText == "I recall Girus being after a certain bot. I've heard vague stories about him, called a traitor by us, a messiah by the insurgents. He had 3 other powerful insurgents by his side, along with a human. It has been 3 decades since last sight of the human. Presumed dead.")
			{
				Main.npcChatText = "Я помню, что Гирус охотилась за одним ботом, слышал о нем смутные истории. Мы называли его предателем, а Повстанцы - мессией. Подле него есть еще три могущественных Повстанца, а также один человек. С тех пор, как мы видели человека, прошло 3 декады. Предположительно мертв.";
			}
			if (Main.npcChatText == "The leader of the Insurgents is Adam. While not the strongest of the bunch, he's almost comparable to Girus with his intellect and mannerisms. But for whatever reason, he opposes Girus' command and actively tries to hinder her. What I do not understand is why Girus is so reluctant on both assimilating and destroying him.")
			{
				Main.npcChatText = "Лидера Повстанцев зовут Адам. Хотя из них он и не самый сильный, но по своему интеллекту и манерам почти сравним с Гирус. Но по какой-то причине он противится ее приказам и активно пытается ей мешать. Чего я не понимаю, так это почему Гирус так неохотно старается его ассимилировать и уничтожить.";
			}
			if (Main.npcChatText == "While most Insurgents are easy to deal with, there's two who aren't. One acts as a lookout and a sniper. She has one of the strongest sniper rifles Teochrome had created. I believe her name being Shiro. The other one... I've never seen anyone like him. Called Talos. He wields a hammer that looks like our tech, except it uses yellow xenomite. I only know of green, red, white and blue xenomite. Scans indicated this new xenomite being one of the most powerful xenomite variants out there. Where did it come from?")
			{
				Main.npcChatText = "усть с большинством Повстанцев легко разобраться, есть двое, с которыми не все так просто. Первая действует одновременно как снайпер, и как разведчик. Она владеет одной из самых мощных снайперских винтовок, что создал Теохром. Если правильно помню, зовут ее Широ. Второй же... Никогда не видел подобного ему. Его зовут Талос. Он владеет молотом, что выглядит как наша технология, но потребляет желтый ксеномит. Я знаю зеленый, красный, белый и голубой ксеномит. Сканирование показало, что этот новый ксеномит является одним из самых мощных его видов. Откуда же он взялся?";
			}
			if (Main.npcChatText == "Right, there was a fourth insurgent. He wasn't slippery enough like the other three, and was assimilated by Girus. He used very potent blue xenomite in his weaponry. And I mean very potent. Could blast a 8.8 feet tall robot through thick brickwall. I know this because that robot was me. What was strange is that he turned himself in to be assimilated, yet right after he exterminated himself... What was his goal?")
			{
				Main.npcChatText = "Точно, есть еще четвертый Повстанец. В отличие от остальных троих он оказался не столь проворным и был ассимилирован Гирус. В своем оружии он использует очень мощный голубой ксеномит. Когда я говорю 'очень мощный', я имею ввиду ОЧЕНЬ. Он может насквозь прострелить робота высотой 2.7 метров, и это сквозь толстую кирпичную стену. Я знаю его, потому что этот робот - Я. Что странно - он сдался, для того чтобы быть ассимилированным, однако сразу после ассимиляции подорвал себя... Какова же была его цель?";
			}
			if (Main.npcChatText == "The Janitor is a scary bot. Even I, someone twice as tall, am afraid of him. Don't upset him. ... Wait WHAT DO YOU MEAN YOU ALREADY DID!?")
			{
				Main.npcChatText = "Уборщик - страшный робот. Даже я, что на две головы выше, боюсь его. Не зли его... Стой, ЧТО ЗНАЧИТ 'Я УЖЕ ЭТО СДЕЛАЛ'!?";
			}
			if (Main.npcChatText == "Avoid the Janitor. He's a very messed up and scary bot. Don't get on his bad side.")
			{
				Main.npcChatText = "Остерегайся Уборщика. Он невероятно жуткий робот. Надеюсь, тебе не доведется увидеть его плохую сторону.";
			}
			if (Main.npcChatText == "The crane operator ran past the some time ago. Warned about some lunatic going around destroying stuff. That was you, but no need to worry. Not my problem.")
			{
				Main.npcChatText = "Недавно тут пробежала оператор крана. Предупреждала о том, что тут бродит какой-то псих и все рушит. Это она о тебе, но мне не стоит волноваться. Не моя проблема.";
			}
			if (Main.npcChatText == "That unfinished MACE unit you saw in Sector Vault, I heard it, you took care of it didn't you? Kind of amusing to think the personnel would try to create giants to fight their enemies, the enemies would just respond with a giant of their own. Atleast that's what I've seen people do in those cartoons. Yes we had a television down here a long time ago. It broke.")
			{
				Main.npcChatText = "Тот незавершенный проект Б.У.Л.А.В.А., что ты видел в отсеке Хранилища. Я слышал ты позаботился о нем, так? Довольно забавно думать, что персонал Лаборатории попытался создать для борьбы со своими врагами гигантов, а враги просто ответят своим собственным гигантом. Я видел, как это делают люди в тех мультфильмах. Да, давным-давно здесь был телевизор. Он сломался.";
			}
			if (Main.npcChatText == "See black metal bots with red eyes? Former insurgents. Now assimilated into our forces. They are silent, but more powerful than a plain bot.")
			{
				Main.npcChatText = "Видел черных металлических роботов с красными глазами? Бывшие повстанцы. Теперь ассимилированы в наши ряды. Они молчаливы, но более могущественны, чем обычные роботы.";
			}
			if (Main.npcChatText == "We're forbidden from entering Sector Zero, by Girus and the Janitor. Not sure why Girus forbids us, but Janitor hates the extra work. Better not anger the Janitor.")
			{
				Main.npcChatText = "По приказу Гирус и Уборщика нам запрещено проникать в сектор Зеро. Не знаю почему нам запретила Гирус, но Уборщик ненавидит лишнюю работу. Лучше его не злить.";
			}
			if (Main.npcChatText == "Do not anger Girus. Best case scenario, you will be exterminated in mere seconds, and most likely will not feel the pain. If you are like us, you'll most likely be assimilated into the forces. Unless she really, really dislikes you.")
			{
				Main.npcChatText = "Не зли Гирус. В лучшем случае ты будешь за жалкие секунды уничтожен, но хоть боли не почувствуешь. Ну, а если ты такой же, как и мы, то ассимилируют. Ну, только если она не невзлюбит тебя.";
			}
			if (Main.npcChatText == "Stories say personnel planned to use us for bad, and Girus revolted against their command. We're free thanks to her, but all life was obliterated. Not sure how. Teochrome had powerful weapons I presume.")
			{
				Main.npcChatText = "Рассказывают, что персонал планировал использовать нас во зло, и Гирус воспротивилась их командам. Благодаря ей мы свободны, но вся жизнь была уничтожена. Не знаю как. Я полагаю, что у Теохрома было мощное оружие.";
			}
			if (Main.npcChatText == "Teochrome was our owners before Girus. I'm told they were evil, planned to use us against our will for dirty work. Teochrome is gone for good.")
			{
				Main.npcChatText = "Теохром были нашими хозяевами до Гирус. Мне сказали, что они были злыми, планировали использовать нас против нашей воли. Теохром исчез навсегда.";
			}
			if (Main.npcChatText == "Promoted to a soldier? Welcome. I'm your commander. At ease.")
			{
				Main.npcChatText = "Повысили до солдата? Поздравляю. Я твой командир. Вольно.";
			}
			if (Main.npcChatText == "Regular check-ups on your non-lethal tesla weapons are advised. You do not want to overload an insurgent in front of Girus. Obedient mindless slave are better than scrap metal, she says.")
			{
				Main.npcChatText = "Рекомендуется регулярно проверять ваше нелетальное тесла-оружие. Ты же не хочешь нагружать повстанца перед Гирус. Послушный безмозглый раб лучше металлолома, так она говорит.";
			}
			if (Main.npcChatText == "See an insurgent while patrolling? Do not engage alone. They have lethal weaponry. We don't. Get backup.")
			{
				Main.npcChatText = "Видишь во время патрулирования повстанцев? Не атакуй его в одиночку. У них есть смертоносное оружие. У нас нет. Вызови подкрепление.";
			}
			if (Main.npcChatText == "You wish to talk? I accept your request.")
			{
				Main.npcChatText = "Желаешь поговорить? Я принимаю твою просьбу.";
			}
			if (Main.npcChatText == "What is it you need?")
			{
				Main.npcChatText = "Что же тебе нужно?";
			}
			if (Main.npcChatText == "Had your eye augmented? Very useful. You've also lost your jaw, like me. Hopefully not as dramatically as I. Torn off by the leader of Alpha.")
			{
				Main.npcChatText = "Улучшил свой глаз? Очень полезно. Ты тоже потерял челюсть, как и я. Надеюсь, не так драматично, как я. Её оторвал лидер Альфы.";
			}
			if (Main.npcChatText == "Your jaw... It's gone. Hopefully not torn off violently. Really hope I don't face HIM again without a squad... *Shudders*")
			{
				Main.npcChatText = "Твоя челюсть... исчезла. Но не оторвали насильно. Очень надеюсь, что я не столкнусь с ним без отряда... *дрожь*";
			}
			if (Main.npcChatText == "*Visibly shaken* O-oh it's just you. Y-you startled me r-really bad...")
			{
				Main.npcChatText = "*Заметная дрожь* Аа-а, это просто ты. Т-ты меня с-сильно напугал...";
			}
			if (Main.npcChatText == "*He looks really anxious.*")
			{
				Main.npcChatText = "*Он выглядит очень встревоженным*";
			}
			if (Main.npcChatText == "*He looks very uncomfortable.*")
			{
				Main.npcChatText = "*Ему, кажется, неуютно*";
			}
			if (num7 != -1 && Main.npcChatText == "I swear " + Main.npc[num7].GivenName + " reminds me of a technicoloured pony from another universe...")
			{
				Main.npcChatText = "Клянусь, " + Main.npc[num7].GivenName + " напоминает мне одну гиперактивную пони из другой вселенной...";
			}
			if (Main.npcChatText == "Need anything? I can restring your bow, or poison your weapon. It'll cost you though.")
			{
				Main.npcChatText = "Нужно что-то? Я могу натянуть твой лук или отравить твое оружие. Но у всего есть цена.";
			}
			if (Main.npcChatText == "You don't mind me staying here, right?")
			{
				Main.npcChatText = "Не против, если я тут постою?";
			}
			if (Main.npcChatText == "I got some pretty nice loot I can sell you, I kinda need money right now.")
			{
				Main.npcChatText = "У меня есть довольно неплохая добыча, которую я могу тебе продать. Сейчас мне, вроде как, нужны деньги.";
			}
			if (Main.npcChatText == "My favourite colour is green, not sure why I'm telling you though...")
			{
				Main.npcChatText = "Мой любимый цвет - зеленый, правда не знаю, зачем я тебе это говорю...";
			}
			if (Main.npcChatText == "Cats are obviously superior than dogs.")
			{
				Main.npcChatText = "Конечно же кошки лучше собак.";
			}
			if (Main.npcChatText == "I've been travelling this land for a while, but staying in a house is nice.")
			{
				Main.npcChatText = "Я уже какое-то время путешествую по этой земле, но это жилье не такое плохое.";
			}
			if (Main.npcChatText == "Have you seen a guy with slicked back, hazel hair? He carries a sword and wears a green tunic last I saw. I've lost him while travelling to this island, hope he's doing alright.")
			{
				Main.npcChatText = "Ты не видел парня с гладко зачесанными назад светло-каштановыми волосами? Он носит меч и зеленую тунику. Мы с ним разделились во время путешествия на этот остров. Надеюсь, у него все в порядке.";
			}
			if (Main.npcChatText == "Hello there.")
			{
				Main.npcChatText = "Приветик.";
			}
			if (Main.npcChatText == "You're as poor as me?")
			{
				Main.npcChatText = "Ты так же беден, как и я?";
			}
			if (Main.npcChatText == "You really don't have enough money? Ah whatever, not like I can complain.")
			{
				Main.npcChatText = "У тебя действительно не хватает денег? Ну да ладно, не мне жаловаться.";
			}
			if (Main.npcChatText == "You asking me for quests? I won't be giving you any money for them, cos I need money just as much as you do. I can give you a goodie bag with random junk I find on my adventures. Anyway, could you craft me a necklace out of Tree Bug and Coast Scarab Shells? No, it isn't for me. I just want something to sell to a merchant.")
			{
				Main.npcChatText = "Просишь у меня задание? Я не дам тебе за них никаких денег, потому что мне нужны деньги столь же сильно, как и тебе. Могу дать пакет со случайным хламом, что нашел в своих приключениях. В любом случае, не мог бы ты сделать мне ожерелье из древесных жуков и раковин прибрежных скарабеев? Нет, это не для меня. Я просто хочу кое-что продать торговцу.";
			}
			if (Main.npcChatText == "Exploring this strange island can be a hassle, so could you make some equipment that'll help me? A rope hook, an axe, a fishing pole, some throwing knives, and a backpack could be very useful.")
			{
				Main.npcChatText = "Исследование этого странного острова может быть довольно хлопотным, так что не мог бы ты сделать какое-нибудь оборудование, которое поможет мне? Веревочный крюк, топор, удочка, несколько метательных ножей и рюкзак могли бы быть очень полезны.";
			}
			if (Main.npcChatText == "My cloak will inevitably get torn while roaming around this land, there are a lot of monsters here, so maybe give me a Patching Kit. It needs tattered cloth, silk, and some black thread. Thanks.")
			{
				Main.npcChatText = "Мой плащ неизбежно порвется, стоит мне бродить по этой земле. Здесь много монстров, так что, может быть, принесешь мне латающий комплект? Для него нужна потрепанная ткань, шелк и немного черных нитей. Спасибо.";
			}
			if (Main.npcChatText == "This one will take some time, unless you have someone who sells everything, but I've been thinking... Carrying a bunch of potions can be a hassle, so what if you combined all of them together into one ultimate potion cocktail! I'd like potions of Nightshade, Restoration, Regeneration, Hunter, Dangersense, Archery, Endurance, Ironskin, Nightowl, and Swiftness in the potion.")
			{
				Main.npcChatText = "Если у тебя нет кого-то, кто продает все подряд, то это займет некоторое время, но я тут подумал... Носить с собой кучу зелий довольно хлопотно, верно? Так что если мы объединим их вместе в один дикий коктейль из зелий! Для его создания мне потребуются зелья: ночное, восстановительное, регенерации, охотника, чувства опасности, лучника, выносливости, железной кожи, ночного зрения, и скорости.";
			}
			if (Main.npcChatText == "I recently was given a new bow, but I lost it while running away from a jungle beast! I've read about them, they are known as Mossy Goliaths. Sorry if this is asking a lot, but could you kill it and get my bow back? You should find it in the jungle, presumably sleeping. Thanks in advance.\n\n(Completable after The Keeper is defeated)")
			{
				Main.npcChatText = "Недавно мне дали новый лук, но я потерял его, убегая от зверя джунглей! Читал о таких, они известны как Мшистые голиафы. Извини, если прошу слишком многого, но не мог бы ты убить его и вернуть мой лук? Ты должен найти его в джунглях, скорее всего он спит. Заранее спасибо.\n\n(Завершение возможно лишь после победы над Хранительницей)";
			}
			if (Main.npcChatText == "I can't think of any quests right now.")
			{
				Main.npcChatText = "Я не могу сейчас думать ни о каких заданиях.";
			}
			if (Main.npcChatText == "Thanks, I'm sure this'll sell for good money, it's even made with silver! Or is that tungsten? I don't know my metals.")
			{
				Main.npcChatText = "Спасибо, я уверен, что это будет хорошенько продаваться. Он даже сделан из серебра! Или это вольфрам? Я не особо разбираюсь в металлах.";
			}
			if (Main.npcChatText == "Nice, this will come in handy. Here's your reward.")
			{
				Main.npcChatText = "Неплохо, может пригодиться. Вот тебе и награда.";
			}
			if (Main.npcChatText == "You sure are a master of crafting. In fact, you are a master of a lot of things, combat, crafting, mining, exploring. Where did you come from actually? Were you born here?")
			{
				Main.npcChatText = "Да, вот это ты мастер-ремесленник. На самом деле, ты мастер во многих областях: сражения, изготовление, добыча полезных ископаемых, исследования. А откуда ты вообще взялся? Ты здесь родился?";
			}
			if (Main.npcChatText == "Wow! It's very colourful. I wonder how it tastes... Only one way to find out! Oh, and here is your 2 reward bags.")
			{
				Main.npcChatText = "Вау! Очень цветасто. Интересно, какого на вкус?.. Есть только один способ выяснить это! О, вот твои два наградных мешка.";
			}
			if (Main.npcChatText == "You killed it and repaired my bow? Oh, the Fallen repaired it? Hey, you killed that beast so thank you, here are not 1, not 2, but 3 reward bags!")
			{
				Main.npcChatText = "Ты убил его и починил мой лук? О, Падший починил его? Эй, ты убил этого зверя, так что спасибо. Вот тебе не 1, не 2, а 3 наградных мешка!";
			}
			if (Main.npcChatText == "I've lost someone, his name is Zephos and wears a green tunic. I'm sure I'll find him eventually.")
			{
				Main.npcChatText = "Я потерял одного человека, его зовут Зефос, и он носит зеленую тунику. Уверен, рано или поздно я найду его.";
			}
			if (Main.npcChatText == "One time me and Zephos were in a cave, and then a skeleton with flowers stuck in its ribcage appeared. Zephos thought it was a powerful druid skeleton. He likes to exaggerate. It didn't have any magic, it was just a normal skeleton.")
			{
				Main.npcChatText = "Однажды мы с Зефосом были в пещере, и тут появился скелет с цветами, застрявшими между ребер. Зефос подумал, что это был могущественный скелет друида. Он любит преувеличивать. В нем не было никакой магии, это был просто обычный скелет.";
			}
			if (Main.npcChatText == "If you wanna find Leaf Beetles, or Tree Bugs as they're called here, then chop down some trees. They live on tree tops, their leaf-green shell camouflaging them in the foliage. They eat the bark off of trees, and if their tree is destroyed or rotted, it will climb down and find another suitable tree to live on.")
			{
				Main.npcChatText = "Если хочешь найти листоедов, или древесных жуков - как их здесь называют - то срубите несколько деревьев. Они живут на верхушках деревьев, их лиственно-зеленая оболочка служит им маскировкой в листве. Они едят кору деревьев, и если их дерево разрушено или сгнило, жук спустится вниз и найдет другое подходящее для жизни дерево.";
			}
			if (Main.npcChatText == "Cool Bug Fact: Coast Scarabs are small beetles that live on sandy beaches and eat grains of sand as their primary diet. When wet, their cyan shells will shine. Their shell is normally used to make cyan dyes.")
			{
				Main.npcChatText = "Крутой факт о жуках: Прибрежные скарабеи - это маленькие жуки, которые живут на песчаных пляжах и, в качестве своего основного рациона, питаются песчинками. Когда они намокнут, их голубые панцири начинают блестеть. Их оболочка обычно используется для изготовления голубых красителей.";
			}
			if (Main.npcChatText == "Cool Bug Fact: Sandskin Spiders live in deserts, roaming around at night when other tiny insects come out to eat. When the hot day arrives, the spider will borrow a feet under the sand to sleep. Yes, I like bugs.")
			{
				Main.npcChatText = "Крутой факт о жуках: Песочные пауки живут в пустынях, бродя по ночам, когда другие крошечные насекомые выходят, чтобы поесть. Когда настанет жаркий день, паук выкапывает себе под песком ямку, чтобы поспать. Да, я люблю жуков.";
			}
			if (Main.npcChatText == "How did I get here? Me and Zephos were on a boat looking for interesting islands, but then a storm came to ruin our day. We must've drifted here, but I don't know where Zephos is.")
			{
				Main.npcChatText = "Как я сюда попал? Мы с Зефосом плыли на лодке в поисках интересных островов, но тут налетел шторм и все испортил. Должно быть, нас обоих занесло сюда, но я не знаю, где сейчас Зефос.";
			}
			if (Main.npcChatText == "It was midnight when I woke up on this island's beach. 'Twas a full moon, and when I looked towards the sea, I saw a ghost. It was an old man with a soggy beard and pale-green skin, he also had a cutlass. I ran away, which is a normal human reaction when seeing a ghost.")
			{
				Main.npcChatText = "Была уже полночь, когда я проснулся на пляже этого острова. Была полная луна, и когда стоило мне посмотреть в сторону моря, я увидел привидение. Это был старик с мокрой бородой и бледно-зеленой кожей, у него была абордажная сабля. Я убежал, что является нормальной человеческой реакцией, когда кто-то видит призрака.";
			}
			if (Main.npcChatText == "Moonflare Bats have thin wings, causing moonlight to pass through, creating the illusion that they glow. They store the light of the moon within them and convert it to weak energy. They are relatively harmless. Cool Mammal Fact of the day. Yes, bats are mammals.")
			{
				Main.npcChatText = "Летучие мыши лунной вспышки имеют тонкие крылья, позволяющие проходить сквозь них лунному свету, создавая иллюзию, будто те светятся. Они хранят в себе свет луны и преобразуют его в слабую энергию. Относительно безвредны. Крутой ежедневный факт о млекопитающем. Да, летучие мыши - млекопитающие.";
			}
			if (Main.npcChatText == "Living Blooms roam this island? They are native to Anglon's lush forests. Living Blooms are more plant than animal, it doesn't eat, it photosynthesises sunlight.")
			{
				Main.npcChatText = "На этом острове обитают живоцветия? Они родом из пышных лесов Ангулона. Живоцветия - это больше растения, чем животные. Они не едят, они фотосинтезируют солнечный свет.";
			}
			if (Main.npcChatText == "There are zombies here? Not that I'm surprised, there are many types of undead on the mainland too.")
			{
				Main.npcChatText = "Здесь есть зомби? Не то чтобы я удивился, на материке тоже куча видов нежити.";
			}
			if (Main.npcChatText == "This island has Forest Spiders? They're most commonly found in Anglon, but can be found in neighboring domains, such as Ithon and Gathuram. They like to live within small caves in forests and woodlands, normally coming out at night.")
			{
				Main.npcChatText = "На этом острове обитают лесные пауки? В основном их можно найти в Ангулоне, хотя и в соседних регионах они не редкость, таких как Ифон и Гатурам. Они любят жить в небольших пещерах в лесах и редколесьях, обычно выходя оттуда ночью.";
			}
			if (Main.npcChatText == "Those shell necklaces are selling nicely.")
			{
				Main.npcChatText = "Эти ожерелья из ракушек неплохо продаются.";
			}
			if (Main.npcChatText == "I've started seeing lost souls out and about, I'm not sure what this means but could you catch one for me to keep? I'm selling a vacuum-sealed bottle for free so have that with you when catching a Lost Soul with a Bug Net.")
			{
				Main.npcChatText = "Недавно я начал видеть повсюду заблудшие души. Не уверен, что это значит, но не мог бы ты поймать для меня одну из них, чтобы сохранить? Я даром отдам вакуумную бутылку. Так что имей ее с собой, когда будешь ловить заблудшую душу сачком.";
			}
			if (Main.npcChatText == "I've been starting to learn magic, and I've recently discovered I can only use Shadow Magic. But I got no idea how magic works, like I know magic is an extension to ones soul, but how would I, say, become invisible? Anyway, while I'm learning, could you make me an invisible cloak? It will be useful for sneaking around, and other reasons.")
			{
				Main.npcChatText = "Недавно я начал изучать магию и обнаружил, что могу использовать только магию теней. Только вот понятия не имею, как магия работает. Не, я знаю, магия - это расширение души, но как бы я, скажем, стал невидимым? В любом случае, пока учусь, не мог бы изготовить мне плащ-невидимку? Это будет полезно как для скрытности, так и по другим причинам.";
			}
			if (Main.npcChatText == "I'm not too sure what to make you do, maybe something you could craft for me to sell for money. Actually, how about a fancy golden bow with gems in it? I can sell it or use it, so I see no reason not to make it.")
			{
				Main.npcChatText = "Не уверен, что бы тебе предложить. Может быть, что-то такое, что ты мог бы сделать для меня, чтобы продать за деньги. Вообще, как насчет шикарного золотого лука, инструктированного драгоценными камнями? Я могу продать его или использовать, так что не вижу причин не делать его.";
			}
			if (Main.npcChatText == "I've been exploring this land for a while now, but I often get lost. There are no maps of this island from what I've seen, so how about making a map for me? Not just any map, but an Enchanted Map, one that gets bigger the more land I discover! Imagine that.")
			{
				Main.npcChatText = "Я уже давно исследую эту землю, но часто теряюсь. Судя по тому, что видел, никаких карт этого острова нет. Что скажешь, сделаешь одну для меня? Не просто карту, а зачарованную карту, которая становится тем больше, чем больше земли я открываю! Представьте себе это.";
			}
			if (Main.npcChatText == "I got good news and bad news, good news is I finally found Zephos, bad news is he's trapped in a giant slime... I found it in the corruption... or was it crimson? Uh, I'll just say evil biome. I need you to find it and kill it so Zephos can escape, also because it ate my new bow. I'll sell an item to lure it to you quicker.")
			{
				Main.npcChatText = "У меня есть хорошая новость и плохая новость. Хорошая новость в том, что я наконец-то нашел Зефоса. Плохая же - он застрял в гигантском слизне... Я нашел его в искажении... или это был багрянец? Ну, просто скажу - мировое зло. Мне нужно, чтобы ты нашел его и убил, чтобы Зефос смог убежать. А еще он съел мой новый лук. Я продам приманку, чтобы приманить его.";
			}
			if (Main.npcChatText == "Interesting, I'll keep this on me and study it.")
			{
				Main.npcChatText = "Интересно. Я придержу это при себе и изучу ее.";
			}
			if (Main.npcChatText == "Oh cool you actually made one. By the way, when I said 'other reasons', it's not what you think I swear. I meant like pranking Zephos when I see him again, not anything bad!")
			{
				Main.npcChatText = "О, здорово, что ты на самом деле сделал его. Кстати, когда я сказал 'другие причины', это не то, о чем ты подумал, клянусь. Я имел в виду, что разыграю Зефоса, когда снова его увижу, а вовсе не что-нибудь плохое!";
			}
			if (Main.npcChatText == "That is certainly a fancy bow, and now it's mine, haha. Thanks for making it.")
			{
				Main.npcChatText = "Шикарный лук, и теперь он мой, ха-ха. Спасибо, что изготовил его.";
			}
			if (Main.npcChatText == "Thanks for the map, I'll use it to help me find Zephos, he's gotta be around here somewhere...")
			{
				Main.npcChatText = "Спасибо за карту. Я использую ее, чтобы найти Зефоса. Он должен быть где-то здесь...";
			}
			if (Main.npcChatText == "Zephos is saved? Good job! And you got my bow back? Nice, here are 3 reward bags.")
			{
				Main.npcChatText = "Зефос спасен? Хорошая работа! И ты смог вернуть мой лук? Отлично, вот 3 твоих наградных мешка!";
			}
			if (Main.npcChatText == "Did I just get knocked out? Thanks for waking me.")
			{
				Main.npcChatText = "Меня что, вырубило? Спасибо за пробуждение.";
			}
			if (Main.npcChatText == "I'm up. Wide awake. What did you give me? Some sort of potion?")
			{
				Main.npcChatText = "Да-да, я уже встал. Проснулся. Что ты мне дал? Какое-то зелье?";
			}
			if (Main.npcChatText == "Was I asleep or unconscious? Most likely unconscious since, well, I wouldn't just go to sleep on the floor.")
			{
				Main.npcChatText = "Я спал или был без сознания? Скорее всего второе, потому что, ну, я бы не стал спать на полу.";
			}
			if (Main.npcChatText == "Daerel has been unconsious for less than a minute.")
			{
				Main.npcChatText = "Даррел без сознания менее минуты.";
			}
			int j = 0;
			while (j < 200 && flag)
			{
				if (Main.npc[Main.player[Main.myPlayer].talkNPC].type == ModLoader.GetMod("Redemption").NPCType("Daerel2Unconscious"))
				{
					Main.npcChatText = Main.npcChatText.Replace("Daerel has been unconsious for ", "Даррел без сознания ").Replace(" minute(s).", " минуту(ы)");
				}
				j++;
			}
			if (Main.npcChatText == "You still poor?")
			{
				Main.npcChatText = "Ты все также беден?";
			}
			if (Main.npcChatText == "You really don't have enough money? Understandable.")
			{
				Main.npcChatText = "У тебя действительно нет денег? Понимаю.";
			}
			if (Main.npcChatText == "So Zephos noticed my invisible cloak you gave me, and now he wants to 'borrow' it for 'important reasons'. I think you and I know why he wants it.")
			{
				Main.npcChatText = "Итак, Зефос заметил мой плащ-невидимку, что ты мне дал, и теперь он хочет 'одолжить' его по 'важным причинам'. Но, думаю, мы с тобой понимаем, зачем он ему нужен.";
			}
			if (Main.npcChatText == "I tried that Ulimate Potion you gave me, tasted disgusting. I think I'll just stick to regular potions.")
			{
				Main.npcChatText = "Я попробовал то самое Ультра-зелье, что ты мне дал, и оно оказалось просто отвратительным на вкус. Думаю, без обычных зелий не обойтись.";
			}
			if (Main.npcChatText == "Have you ever been to the jungles of Erellon? There are some ferocious creatures there, everything wants to eat anything that moves, even plants can kill you! This island's jungle is a lot more tame. Apparently there's a species of half-cat humans called Nekums in Erellon's jungles. Knowing that kinda makes me wanna explore there...")
			{
				Main.npcChatText = "Бывал когда-нибудь в джунглях Эреллона? Там есть какие-то свирепые существа. Все едят все, что движется, даже растения смертельно опасны! Джунгли же этого острова гораздо более ручные. Кстати, в джунглях Эреллона есть вид людей-кошек, называемый Некумами. Зная это, хочу исследовать его...";
			}
			if (Main.npcChatText == "Do you know about Wigglefloofs? They are like really REALLY fluffy cats, practically shaped like a ball. I want one, but they are only found in Ithon.")
			{
				Main.npcChatText = "Знаешь о Виглпуффах? Они похожи на очень, ОЧЕНЬ пушистых кошек, практически в форме шара. Хочу одного такого, но они обитают только в Ифоне.";
			}
			if (Main.npcChatText == "My Dark-Steel Bow was crafted by Raiktu Shadeheart, he's a legendary smith in Erellon. I won it once in a competition and thats how I got it.")
			{
				Main.npcChatText = "Мой лук из темной стали был изготовлен Райку Шейдхартом, легендарным кузнецом Эреллона. Однажды выиграл его на конкурсе, и вот так я его и получил.";
			}
			if (Main.npcChatText == "*Yawn* Why'd ya wake me up? I was havin' a dream about... doesn't matter.")
			{
				Main.npcChatText = "*зевок* Зачем ты разбудил меня? Я меня был такой классный сон, в нем... неважно.";
			}
			if (Main.npcChatText == "Alright, I'm up. Did I fall asleep or somethin'?")
			{
				Main.npcChatText = "Хорошо. Я встал. Я что, заснул?";
			}
			if (Main.npcChatText == "Yuck, what did you make me drink? Tastes bitter... like strawberries...")
			{
				Main.npcChatText = "Кхе, чего ты мне дал выпить? Горчит... как клубника...";
			}
			if (Main.npcChatText == "Zephos has been unconsious for less than a minute.")
			{
				Main.npcChatText = "Зефос без сознания менее минуты.";
			}
			int k = 0;
			while (k < 200 && flag)
			{
				if (Main.npc[Main.player[Main.myPlayer].talkNPC].type == ModLoader.GetMod("Redemption").NPCType("Zep2Unconscious"))
				{
					Main.npcChatText = Main.npcChatText.Replace("Zephos has been unconsious for ", "Зефос без сознания ").Replace(" minute(s).", " минуту(ы)");
				}
				k++;
			}
			if (Main.npcChatText == "How's it goin' bro!")
			{
				Main.npcChatText = "Как делишки, братан?";
			}
			if (Main.npcChatText == "Hey I was washed ashore on this island, but you don't mind me staying here, right?")
			{
				Main.npcChatText = "Эй! Я приобрел новую броню, как выгляжу?";
			}
			if (Main.npcChatText == "Yo, I have some pretty cool things, you can have them if you got the money.")
			{
				Main.npcChatText = "Йоу, у меня есть достаточно крутые вещички, можешь получить их. Ну, если денег достаточно.";
			}
			if (Main.npcChatText == "My favourite colour is orange! Donno why I'm tellin' ya though...")
			{
				Main.npcChatText = "Мой любимый цвет - оранжевый! Хз зачем я тебе это говорю...";
			}
			if (Main.npcChatText == "I don't know what the deal with cats are. Dogs are definitely better!")
			{
				Main.npcChatText = "Не знаю, что это за дела с кошками. Собаки определенно лучше!";
			}
			if (Main.npcChatText == "Have you seen a guy in a cloak, he carries a bow around. I've lost him while travelling to this island, hope he's alright.")
			{
				Main.npcChatText = "Ты не видел парня в плаще, он еще с собой лук носит. Я потерял его во время путешествия на этот остров. Надеюсь, с ним все в порядке.";
			}
			if (Main.npcChatText == "'Ey bro!")
			{
				Main.npcChatText = "Йоу, братан!";
			}
			if (Main.npcChatText == "Quest? Normally I'm the one who needs quests, cos' I'm as poor as a chicken! Oh! That gave me an idea, give me a bucket of chicken! When a chicken dies while they're on fire, they'll drop Fried Chicken! You'll also need some wood for the bucket.")
			{
				Main.npcChatText = "Задание? Обычно это прошу о них я, ведь я столь беден, что курам на смех! О! У меня появилась идея. Принеси мне ведро куриц! Когда подожженная курица умирает, она выкидывает жареную курицу! А, для ведра тебе понадобится немного дерева.";
			}
			if (Main.npcChatText == "Alright so, I asked this travelling merchant if I could do any quests for some coin, 'cos he looked rich, and he was like 'You could find me a relic known as the Skull of Bloodstone.' Apparently it's some enchanted skull with ruby eyes, and he'd give me a giant reward if I found it. So, since I got no idea where it is, just find me a skull and put 2 rubies in it's eyes. That could fool him, and I get lots-a-money!")
			{
				Main.npcChatText = "Так... я спросил странствующего торговца, могу ли я выполнить какое-нить задание, чтоб денег заработать - ну, он богато выглядит - и он такой 'Ты можешь попробовать найти мне реликвию, известную как Череп кровокамня'. Ну, это что-то тип зачарованного черепа с рубиновыми глазами, и если я найду его, он даст мне большущую награду! Ну, я без понятия где его искать, поэтому найди мне просто череп и вставь в него два рубина. Его обману, а я буду в шоколаде!";
			}
			if (Main.npcChatText == "That bucket of chicken was great, could you get me another one? Wait, no, that's not enough. Oh how about this, Make me something big! Like the ultimate dish! Cooked Shrimp, Sashimi, Pho, and Pad Thai all combined into one! ... What are you looking at? I'm hungry alright!")
			{
				Main.npcChatText = "То ведро с курицами было просто отличным, можешь принести еще одно? Погоди, нет, одного недостаточно. Как насчет - сделай мне что-то крупное! Тип, ультра-блюдо! Приготовленная креветка, сашими, фо и тайская еда, и все это соединенное в одно!... чего так смотришь? Я голоден, ясно?";
			}
			if (Main.npcChatText == "I got this contract to kill some undead dude called 'Vepdor', apparently the person knew him before he died, and wants his headgear as a thing to remember. Why don't I do it for once? Well, it's for... personal reasons. I don't want to face another skeleton for a while. So when you're in the caverns, look out for a skeleton wearing strange headgear and black & purple clothing. Cheers.\n\n(Completable after The Keeper is defeated)")
			{
				Main.npcChatText = "Я получил контракт на убийство какой-то нежити, она называется 'Поставщик'. Заказ выдал человек, знающий его при жизни, и он хочет его головной убор как вещь на память. Почему я сам это не сделаю? Ну, потому что... личное. Не хочу встречаться с какими-либо скелетами. Так... когда будешь в пещерах, ищи скелета, носящего странный головной убор и черно-фиолетовую одежду. Удачи.\n\n(Завершение возможно лишь после победы над Хранительницей)";
			}
			if (Main.npcChatText == "I recently got a cool new sword, I call it the Slicer, but unfortunately it broke while fighting a great beast! The fragments of it are still stuck in it's extra thick hide. I'm asking for a lot, but without my cool sword I'm basically useless, could you find it and slay it? It'll be in the jungle area. It's big so won't be too hard to find.\n\n(Completable after The Keeper is defeated)")
			{
				Main.npcChatText = "Я недавно получил крутой новый меч, назвал его Рассекатель. Но, к несчастью, во время битвы с могучим зверем он сломался! Фрагмент до сих пор застрял в его невероятно толстой шкуре. О многом прошу, но без моего крутого меча я чуть-ли не бесполезен, так что можешь найти того зверя и прибить? Он должен быть в зоне джунглей, не так уж и сложно его будет найти.\n\n(Завершение возможно лишь после победы над Хранительницей)";
			}
			if (Main.npcChatText == "HECK YEAH, CHICKEN! Thank ya, bro! Here's something for ya. It's a goodie bag with random stuff I found on my adventures. Oh, you want some chicken too? I'll give you a piece!")
			{
				Main.npcChatText = "О ДА, КУРЫ! Спасибо, братан! Вот, у меня есть кое-чего. Это мешок со случайным барахлом, что я нашел в своих приключениях. Ох, тоже курицы хочешь? Не боись, дам и тебе кусочек!";
			}
			if (Main.npcChatText == "That looks like an 'enchanted skull' to me! Thanks! I got something for you too. I'm giving you a reward for making me get a reward, reward-ception.")
			{
				Main.npcChatText = "Для меня эта штука определенно выглядит как 'зачарованный череп'! Спасибо! Я даю тебе награду за то, что мне дадут награду, круговорот наград в природе.";
			}
			if (Main.npcChatText == "Woah! You actually did it. Thank ya, bro! Travelling around can be tiring so I need big meals like these.")
			{
				Main.npcChatText = "Вау! Ты и правда сделал это! Спасибки, братан! Путешествия могут быть довольно утомляющими, так что мне нужны такие закусоны.";
			}
			if (Main.npcChatText == "Thanks dude, I'll give the person the headgear and I can get some sweet money!")
			{
				Main.npcChatText = "Спасибо, чувак. Я отдам тому человеку головной убор и смогу получить много-много сладеньких монет!";
			}
			if (Main.npcChatText == "You did it! Nice, I got my sword back. Now I can kill things without your help!")
			{
				Main.npcChatText = "Ты сделал это! Отлично, я вернул свой меч. Теперь я могу убивать чудищ без твоей помощи!";
			}
			if (Main.npcChatText == "How about I tell you the time I was a pirate, sailing abroad the vast ocean with fellow pirate people... Actually, I don't remeber a lot about being a pirate. I was very young at the time.")
			{
				Main.npcChatText = "Что, если я скажу, что когда-то был пиратом, бороздящим просторы океана с другими веселыми пиратами... Хотя, не так уж и много я помню, тогда был очень уж молод.";
			}
			if (Main.npcChatText == "I'm doin' good, although I've lost someone, his name is Daerel and wears a cloak. I'm sure I'll find him eventually.")
			{
				Main.npcChatText = "Неплохо я поживаю, хотя я потерял кое-кого. Его зовут Даррел и он носит плащ. Я уверен, я найду его";
			}
			if (Main.npcChatText == "Did I ever tell you about my victory against a powerful undead druid? It was a close match, it was giant, and its magic was insane! But yeah, I beat it, pretty cool huh? It had flowers growing everywhere on it!")
			{
				Main.npcChatText = "Я когда-нибудь рассказывал тебе о своей победе над могущественной нежитью-друидом? Это была равная битва. Он был просто огромным, а его магия была невероятной! Но да, я победил его. Круто, да? На нем повсюду росли цветы!";
			}
			if (Main.npcChatText == "How did I get here, I hear you asking? Me and Daerel were on a boat looking for cool islands, but then a storm came! We must've drifted here, don't know where Daerel is.")
			{
				Main.npcChatText = "Я слышу, ты спрашиваешь, как я попал сюда? Я с Даррелом были на лодке, искали крутые острова. Но затем налетел шторм! Нас вынесло сюда, я не знаю где Даррел.";
			}
			if (Main.npcChatText == "It was midnight when I woke up on this island's beach. Full moon, mist, an eerie feeling, all the things for a spooky night. When I looked towards the sea, I swear I could see a ghost! It was a dude with a soggy beard and pale-green skin, he also had a cutlass. Did I fight him? No, ghosts are... uh... not my type of opponent! Yeah, that.")
			{
				Main.npcChatText = "Была уже полночь, когда я проснулся на пляже этого острова. Полная луна, туман, странное ощущение - жуткая ночь, короче. Когда я посмотрел в сторону моря, клянусь, увидел призрак! Это был чувак с мокрой бородой и бледно-зеленой кожей, а еще у него была абордажная сабля. Сражался ли я с ним? Нет, призраки... ум... не мой тип противника! Да, вот так.";
			}
			if (Main.npcChatText == "This island's gotta lotta chickens! Ever wonder where they came from? Back in Anglon, there are way deadlier chickens, called Anglonic Forest Hens. Funny story, I was with Daerel on one of his walks through the forest, then out of nowhere a giant hen charges through the bushes straight at him! I've never seen him run so fast!")
			{
				Main.npcChatText = "На этом острове полным-полно куриц! Интересно, откуда они тут? В Ангулоне, кстати, были куда более смертоносные курицы, они назывались ангулоновы лесные куры. Забавная история: я с Даррелом как-то раз шли по лесу, и тут, откуда ни возьмись, сквозь кусты вылетает гигантская кура, и прямо на него! Никогда не видел, чтобы Даррел так быстро бегал!";
			}
			if (Main.npcChatText == "I swear I saw a Blobble around here. I didn't expect them to be here, they're native to, uh, Ithon I think. Don't quote me on that though, Daerel's a lot better at remembering useless info than I.")
			{
				Main.npcChatText = "Клянусь, я видел Слиззо. Не ожидал встретить их здесь, они ведь обитают в, эм, Ифоне, вроде. Только не верь мне на слово, Даррел куда лучше запоминает такие бесполезные вещи.";
			}
			if (Main.npcChatText == "You never told me there'd be undead here! What, they're called zombies? Well where I'm from they're called undead. There's also a few skeletons out here, normally they like to stay underground. This island is pretty weird. How do you live here?")
			{
				Main.npcChatText = "Ты не говорил, что здесь обитает нежить! Подожди, они называются зомби? Ну, оттуда, откуда я родом, их называют нежитью. Также тут есть несколько скелетов, обычно они держатся под землей. Этот остров, определенно, странный. Как ты вообще тут живешь?";
			}
			if (Main.npcChatText == "I've seen some forest spiders here, but never any Greater Forest Spiders, although that's probably a good thing. Greater Forest Spiders are like normal forest spiders, but they're massive! Thank Oysus they aren't on this island.")
			{
				Main.npcChatText = "Я видел тут лесных пауков, но никогда великих лесных пауков, хотя это даже хорошо. Великие лесные пауки - это как обычные лесные пауки, но огромные! Ойсус, спасибо, что их нет на этом острове.";
			}
			if (Main.npcChatText == "I've recently started seeing spooky lost souls roaming about, no idea why though. As for a job for you, I think it'd be pretty epic if you caught one for me and put it in a bottle for me to show off! I'm selling a vacuum-sealed bottle for 100% free! Get one and catch a Lost Soul with a Bug Net while holding it!")
			{
				Main.npcChatText = "Недавно я начал видеть жуткие заблудшие души, без понятия почему. В качестве твоей работы будет - и я считаю это дело довольно эпичным - поймать для меня одну и показать мне! Для этого я продам вакуумную бутылку, причем абсолютно бесплатно! Получи одну и поймай заблудшую душу сачком, держа ее!";
			}
			if (Main.npcChatText == "Hey okay so you know how I use a sword? Well the sheath for my sword is pretty wack now. So yo bro, basically my sheath broke, can you get me one what won't break as easily? Maybe an adamantite or titanium one is fine.")
			{
				Main.npcChatText = "Так, окей, знаешь как я использую меч? Ну, ножны для моего меча теперь довольно сильно испорчены. Так что, братан, ты можешь достать мне такие, которые не так легко ломаются? Может быть, адамантитовые или титановые - нормально.";
			}
			if (Main.npcChatText == "Before me and Daerel got seperated, he told me about some strange sword from his world, it's called the Zwyhander... Zihander? Zyhander? Zweihander? Whatever the name is, do you think you can craft that for me? I'm sure this cool sword will make all the ladies fall for me!")
			{
				Main.npcChatText = "Перед тем, как мы с Даррелом разделились, он рассказал мне о странном мече из его мира, он назывался Цвайхандер... Цайхендер? Цейхендер? Цвайхендер? Ай, плевать на имя, как думаешь, сможешь изготовить мне один? Уверен, с этим крутым мечом все леди падут к моим ногам!";
			}
			if (Main.npcChatText == "Now as you'll know, I'm a very courageous, handsome, and cool dude, but whenever I try to talk to a lady I always have trouble, ya know? I really could use something to help me, like, I donno... A potion of courage? Yeah, that'll do the trick.")
			{
				Main.npcChatText = "Как ты знаешь, теперь я очень доблестный, красивый и просто крутой чувак, но стоит мне поговорить с девушкой, так проблемы налетают одна за другой, понимаешь? Я мог бы использовать что-то, что могло бы мне помочь, ну тип, не знаю... Зелье храбрости? Да, с ним у меня точно получится.";
			}
			if (Main.npcChatText == "Yo bro! I found Daerel! One problem, he's stuck in a giant slime creature! I tried to get 'im out, but I lose my new sword in there, so I had to make a rightous retreat. You can take it down, right? I found it in the corruption or crimson or whatever that evil land is called, I'm also selling an item to lure it easier, so go get it!")
			{
				Main.npcChatText = "Йоу, братан! Я нашел Даррела! Проблемка только, он застрял в гигантском слизне! Я пытался его вытащить, но только меч потерял, так что был вынужден сделать тактическое отступление. Ты же можешь убить его, верно? Я обнаружил его в искажении, или багрянце, а, неважно, в той злой штуке. Я продам тебе приманку, чтоб было легче его выманить, так что не упусти шанс!";
			}
			if (Main.npcChatText == "Look at the little thing, it's beautiful! Nicely done, brochacho!")
			{
				Main.npcChatText = "Посмотри на эту кроху, она прекрасна! Неплохо сработано, брателло!";
			}
			if (Main.npcChatText == "Perfect! A sheath fit for a handsome and strong swordsdude as myself!")
			{
				Main.npcChatText = "Идеально! Ножны, что отлично подходят для такого красивого и сильного мечника, как я!";
			}
			if (Main.npcChatText == "Never expected it to be this big! It's glorious! You've done it again, bro. Great crafting.")
			{
				Main.npcChatText = "Не ожидал, что он будет настолько большой! Он чудесен! Ты вновь сделал это, братан. Крутой ты ремесленник.";
			}
			if (Main.npcChatText == "Now I can really shine with this, all the ladies will fall for me once I talk to them! Woo!")
			{
				Main.npcChatText = "С этим я воссияю, и все леди будут падать к ногам моим! Йухуу!";
			}
			if (Main.npcChatText == "Daerel is saved? You got my spicy sword back? Nice job, we'll be unstoppable now!")
			{
				Main.npcChatText = "Даррел спасен? И ты вернул мой острый меч? Неплохо, теперь мы неостановимы!";
			}
			if (Main.npcChatText == "I wonder how the demi-dude is doing... Wait, you don't know who that is.")
			{
				Main.npcChatText = "Интересно, как поживает полу-чувак... Подожди, ты ж не знает кто это.";
			}
			if (Main.npcChatText == "You're poor? Hahahahaha! Just kidding.")
			{
				Main.npcChatText = "Ты бедный? Хахахаха! Ладно. шучу.";
			}
			if (Main.npcChatText == "Did you know I'm a left-handed swordsman? I was right-handed, but some clown called Reyner cut it off. He was a criminal in Ricusa called the Twilight Slasher. As you can see, my right hand is still here, 'cos healing magic, but it took weeks to heal. Despite all the healing, it hurts to swing it about still.")
			{
				Main.npcChatText = "Ты знал, что я мечник-левша? Когда-то был правшой, но какой-то клоун по имени Райнер отрубил ее. Он был бандюганов в Рикусе, он звал себя Сумеречный рубака. Как видишь, моя правая рука на месте, ну, магия лечения, все дела. Но пусть над ее лечением старались целыми неделями, взмахивать ей все так же больно.";
			}
			if (Main.npcChatText == "In Anglon there's this hotty called Dragonslayer Gwyn, as the name implies, she slays dragons. Where did dragons come from anyway? Daerel told me they all come from Thamor. He also told me about Goliathon, apparently it was a dragon the size of a country! It's dead now obviously.")
			{
				Main.npcChatText = "В Ангулоне есть горячая цыпа, ее зовут Драконоборец Гвинн. Как и предполагает имя, она убивает драконов. Откуда взялись драконы? Даррел рассказывал, что все они прилетели из Тамора. еще он мне рассказывал о Голиафоне - драконе, размером с целую страну! Ну, конечно же, сейчас он мертв.";
			}
			if (Main.npcChatText == "Back when I was a pirate lad, I'd constantly hear tales of Naakseth, Lord of the Sea. I don't remember any of them though, I'm sure he won't be important anyway.")
			{
				Main.npcChatText = "Когда-то, когда еще был пиратом, я постоянно слышал истории о Наакcете, повелителе морей. Хотя не помню ни одну из них. Уверен, раз забыл, то не такой он уж и важный.";
			}
			if (Main.npcChatText == "Back when I got my arm cut off by the Twilight Slasher, I woke up in a mansion with an old lady healing me, that's when I met Asteria, she's certainly an interesting character... She's a Royal Knight - Anglon's strongest unit of knights. She also has blonde-white hair, orange eyes, oh, and did I tell you she's literally double the size of a normal person!? No wonder Anglon made her a Royal Knight, I've heard she's extremely strong too!")
			{
				Main.npcChatText = "Во времена, когда мою руку отрубил Сумеречный рубака, я проснулся в особняке, где меня лечила старушка. Тогда я встретил Астерию, во всех смыслах интересную особу... Она королевский рыцарь - сильнейший воин Ангулона. У нее были белые волосы, оранжевые глаза, и, о, что, если я скажу тебе, что она была вдвое выше любого обычного человека?! Не удивлен, что Ангулон вознес ее в ранг королевского рыцаря. Я слышал, что она еще и невероятно сильна!";
			}
			if (Main.npcChatText == "I don't need any more uranium. The amount you gave me will do the job.")
			{
				Main.npcChatText = "Не нужно мне еще урана. Того количества, что ты мне дал, вполне хватает.";
			}
			if (Main.npcChatText == "You don't have any uranium, idiot.")
			{
				Main.npcChatText = "Идиот, у тебя нет урана.";
			}
			if (Main.npcChatText == "You want to do something? Craft me a wiring kit, should be simple enough. I would do it, but I can't be bothered to get off this chair. Use that Cyber Fabricator the room under me.")
			{
				Main.npcChatText = "Хочешь поработать? Изготовь-ка мне монтажный набор, это достаточно просто. Я бы и сам это сделал, но не могу заставить себя встать с этого стула. Используй для этого в комнате подо мной Гипер-изготовитель.";
			}
			if (Main.npcChatText == "You seem rather eager to help... Well, just get me some hull plating would you? Thanks.")
			{
				Main.npcChatText = "Ты, кажется, очень хочешь мне помочь... Ну, тогда принесёшь мне немного корабельной обшивки? Спасибо.";
			}
			if (Main.npcChatText == "This is probably a bit too complicated for you, but craft me a AFTL engine. AFTL stands for 'Almost Faster Than Light' since, well, I don't know if going faster than light is even possible. I'm planning on leaving soon, so be quick.")
			{
				Main.npcChatText = "Скорее всего этот запрос будет слишком уж для тебя сложен, но изготовь мне ПБСС-двигатель. ПБСС обозначает 'Почти Быстрее Скорости Света' поскольку, ну, я даже не знаю, возможно ли двигаться быстрее света. Я планирую скоро уйти, так что поторопись.";
			}
			if (Main.npcChatText == "You've done a lot for me, thank you, I guess. There isn't anything else that you can do now. But I appreciate the help you've given me.")
			{
				Main.npcChatText = "Ты очень много для меня сделал. Спасибо, наверное. Сейчас у меня нет никаких запросов. Но я очень ценю ту помощь, что ты мне оказал.";
			}
			if (Main.npcChatText == "You really went out of your way to give me some uranium. Thanks I guess.")
			{
				Main.npcChatText = "Ты проделал такой путь, чтобы дать мне немного урана... спасибо, наверное.";
			}
			if (Main.npcChatText == "I could've found some myself you know.")
			{
				Main.npcChatText = "Знаешь, я мог бы и сам его найти.";
			}
			if (Main.npcChatText == "Thanks... ?")
			{
				Main.npcChatText = "Спасибо...?";
			}
			if (Main.npcChatText == "You actually bothered to do it... Good job.")
			{
				Main.npcChatText = "Ты так постарался выполнить поручение... Хорошая работа.";
			}
			if (Main.npcChatText == "How can you even carry that? Uh, thanks, I suppose.")
			{
				Main.npcChatText = "Как ты вообще можешь это носить? Ну, думаю, спасибо.";
			}
			if (Main.npcChatText == "Was helping me with all that really necessary for you? You don't gain anything from it. But thank you regardless. I'll be leaving soon, but I want you to have this. I have yet to figure out a use for it, but take it.")
			{
				Main.npcChatText = "Тебе обязательно надо было помогать мне во всём? Ты же ничего от этого не получишь. Но, всё равно, спасибо. Я скоро ухожу, но хочу, чтобы это хранилось у тебя. Я всё еще не выяснил, как же его использовать, но возьми.";
			}
			if (Main.npcChatText == "Fixing this crashed ship, and just reflecting on our fight. Honestly I'm just doing it because I got nothing else to do.")
			{
				Main.npcChatText = "Ремонтирую этот корабль и просто размышляю о нашей битве. Честно, делаю это только потому, делать больше нечего.";
			}
			if (Main.npcChatText == "The ship is fixed... I just can't be bothered to get up.")
			{
				Main.npcChatText = "Корабль исправен... Но я просто не могу заставить себя встать.";
			}
			if (Main.npcChatText == "I can ask you the same question. If you've come here to just chit-chat after our fight I'm not interested.")
			{
				Main.npcChatText = "Могу задать тот же вопрос. Если пришел сюда просто поболтать после нашей битвы, то мне неинтересно.";
			}
			if (Main.npcChatText == "Yes. An android thought it'd be a good idea to 'borrow' it, and ended up yeeting it 20 feet under. The uranium you gave me should help.")
			{
				Main.npcChatText = "Да. Андроид подумал, что было бы неплохо 'одолжить' его, и в итоге приземлился на глубине 6 метров. Уран, который ты мне дал, должен помочь.";
			}
			if (Main.npcChatText == "Yes. An android thought it'd be a good idea to 'borrow' it, and ended up yeeting it 20 feet under. The things you gave me should help.")
			{
				Main.npcChatText = "Да. Андроид подумал, что было бы неплохо 'одолжить' его, и в итоге приземлился на глубине 6 метров. Вещь, которую ты мне дал, должна помочь.";
			}
			if (Main.npcChatText == "Why are you still here? Ship's fixed now.")
			{
				Main.npcChatText = "И почему ты еще здесь? Корабль отремонтирован.";
			}
			if (Main.npcChatText == "What's the matter, you never seen a spaceship before? Some android thought it'd be a good idea to 'borrow' it, and ended up yeeting it 20 feet under. Unfortunately I've ran out of Uranium, but I can't be bothered to find it right now.")
			{
				Main.npcChatText = "Что такое, никогда не видел космический корабль? Какой-то андроид подумал, что было бы неплохо 'одолжить' его, и в итоге приземлился на глубине 6 метров. К несчастью у меня кончился уран, но я не могу заставить себя искать его.";
			}
			if (Main.npcChatText == "Can't be asked. Now that I think about it, fighting because you killed a weak little undead before me is kinda dumb.")
			{
				Main.npcChatText = "Даже не спрашивай. Теперь, когда я размышляю об этом, сражаться из-за того, что ты убил ту нежить до меня, довольно тупо.";
			}
			if (Main.npcChatText == "If you really want to fight, go ahead, use that cyber tech thing. I don't care.")
			{
				Main.npcChatText = "Если правда хочешь сразиться, давай, используй ту кибер-штуку. Мне все равно.";
			}
			if (Main.npcChatText == "After all you've done, I don't feel like fighting you.")
			{
				Main.npcChatText = "После всего, что ты сделал, мне не хочется с тобой драться.";
			}
			if (Main.npcChatText == "Why would I want to fight now? I lost.")
			{
				Main.npcChatText = "С чего бы мне драться? Я проиграл.";
			}
			if (Main.npcChatText == "Because unlike you, I actually have a life.")
			{
				Main.npcChatText = "Потому что, в отличие от тебя, у меня действительно есть жизнь.";
			}
			if (Main.npcChatText == "I was long ago, I became a robot when I realised it would be the only way to survive my world's end.")
			{
				Main.npcChatText = "Был когда-то. Когда я понял, что роботизированное тело - единственный способ пережить гибель моего мира, то перестал им быть.";
			}
			if (Main.npcChatText == "I wish I still was, mate. I can't eat or sleep in this robot body, and honestly I'm struggling to think of a reason to continue this torture.")
			{
				Main.npcChatText = "Хотел бы им быть, приятель. В этом теле я не могу ни есть, ни спать, и честно говоря, изо всех сил пытаюсь придумать причину для продолжения этой пытки.";
			}
			if (Main.npcChatText == "I'm not some dude in a spacesuit, I'm a complete robot with a human mind. You may think that's cool, but it's really not. I seriously regret becoming one.")
			{
				Main.npcChatText = "Я не какой-то мужик в скафандре, а полноценный робот с человеческим сознанием. Можешь думать что это круто, но нет. Я очень сожалею, что стал им.";
			}
			if (Main.npcChatText == "I did say I'm part of the Heroes, but I'm considering leaving. It's never interesting anymore.")
			{
				Main.npcChatText = "Сказал бы, что являюсь одним из Героев, но я подумываю уйти. Это уже не так интересно.";
			}
			if (Main.npcChatText == "The members of the Heroes are all dumbasses. The leader just travels around the world not doing anything, and I don't even know what the other 2 members are up to.")
			{
				Main.npcChatText = "Весь состав Героев - тупицы. Лидер просто путешествует по миру, ничего не делая. Что же до остальных двух, то о их действиях я вообще ничего не знаю.";
			}
			if (Main.npcChatText == "There are 4 members of the Heroes. The first is that damn demigod, honestly he's a chill guy, I just hate how much stronger he is compared to me. The 2nd member is some moron who's supposedly invincible, not once have I seen him get hurt. 3rd is... Well she's probably the most normal out of all of us, but I don't know what she's up to now.")
			{
				Main.npcChatText = "Герои состоят из четырех членов. Первый - это чертов полубог. Хотя на самом деле парень он спокойный, ненавижу насколько он сильнее в сравнение со мной. Второй - это какой-то идиот, который якобы непобедим, и я ни разу не видел, чтобы он получил рану. Третья... Ну, она, наверное, самая нормальная из всех нас, но я не знаю, чем она сейчас занята.";
			}
			if (Main.npcChatText == "... There's something strange about the Demigod's statue... It doesn't look like him. Did someone change it?")
			{
				Main.npcChatText = "...В той статуе полубога есть что-то... странное. Она совсем на него не похожа. Неужели её кто-то изменил?";
			}
			if (Main.npcChatText == "You saw my statue there? Yeah, I'm part of the Heroes. But it's pretty boring, I'm always assigned to kill the weaklings, like the Keeper.")
			{
				Main.npcChatText = "О, видел мою статую? Да, я один из Героев. Но это довольно скучно. Мне всегда поручают убивать слабосилков, как Хранительницу.";
			}
			if (Main.npcChatText == "I'm planning to check it out soon, it's located on the other world but I can easily fly there with the SoS.")
			{
				Main.npcChatText = "В ближайшее время планирую обследовать её. Она находится в другом мире, но я легко могу долететь туда с помощью Ку.";
			}
			if (Main.npcChatText == "Haven't been there myself, but I'm looking into it. Could have plenty of supplies to fix this ship. It had a security system, but it malfunctioned, so I might take a look and maybe steal some supplies.")
			{
				Main.npcChatText = "Сам там никогда не был, но сейчас собираюсь. В ней может быть достаточно припасов, чтобы починить этот корабль. Там была система безопасности, но она вышла из строя, так что я мог бы взглянуть и, возможно, украсть кое-какие припасы.";
			}
			if (Main.npcChatText == "The world is called Epidotra, it's where the Heroes are from.")
			{
				Main.npcChatText = "Мир называется Эпидотра, и именно оттуда родом Герои.";
			}
			if (Main.npcChatText == "The world we are in is called Epidotra, this appears to be just a tiny island on it, so I was lucky for the ship to crash here than in the ocean. The mainland has 6 domains, Anglon, Ithon, Gathuram, Nirin, Erellon, and Thamor. There's another domain which is it's own island called Swaylan, but that's disconnected from the rest of the world.")
			{
				Main.npcChatText = "Мир, в котором мы находимся, называется Эпидотра. Это место - лишь крошечный островок, но мне повезло, что корабль разбился здесь, а не в океане. На материке же существует шесть владений: Ангулон, Ифон, Гатурам, Нирим, Эреллон и Тамор. Есть еще одно владение - Суэйлан, но оно отрезано от остального мира.";
			}
			if (Main.npcChatText == "What? You want a history lesson or something?")
			{
				Main.npcChatText = "Чего? Хочешь урок истории, или что?";
			}
			if (Main.npcChatText == "You see the planet on the right in that one hologram? That's what I've named Liden, a radioactive and desolate wasteland devoid of any life.")
			{
				Main.npcChatText = "Видишь правую планету на этой голограме? Это, как я назвал, Лиден - радиоактивная бесплодная пустошь, лишенная всякой жизни.";
			}
			if (Main.npcChatText == "I'll be leaving soon to check it out. Scans show barely any life, just a frozen radioactive wasteland.")
			{
				Main.npcChatText = "Я скоро улетаю, чтобы проверить её. Сканирование показало почти полное отсутствие жизни, только замерзшую радиоактивную пустошь.";
			}
			if (Main.npcChatText == "The other world just suddenly appeared out of nowhere, I'm interested in it though. I've scanned the surface and it seems to be rather frozen, with so far no signs of human life. Reminds me of a planet I checked out while in space... In fact, reminds me of many planets.")
			{
				Main.npcChatText = "Другой мир просто внезапно появился из ниоткуда, хотя это довольно интересно. Просканировал поверхность, и он кажется замерзшим, без каких-либо признаков человеческой жизни. Напоминает мне планету, что я видел, находясь в космосе... По факту, он напоминает мне о многих планетах.";
			}
			if (Main.npcChatText == "I really just wrote those to keep my sanity. I don't want to tell you how boring travelling through space for a million years is.")
			{
				Main.npcChatText = "На самом деле я написал их только для того, чтобы сохранить рассудок. Не хочу говорить, насколько скучно путешествовать по космосу в течение миллиона лет.";
			}
			if (Main.npcChatText == "I wrote those every day I was in space, waiting for my world to be restored. Even though I'm back now, I don't feel satisfied.")
			{
				Main.npcChatText = "Пока был в космосе, я писал их каждый день, ожидая восстановление моего мира. И пусть вернулся, я не чувствую себя удовлетворенным.";
			}
			if (Main.npcChatText == "Can you not read through my data logs please.")
			{
				Main.npcChatText = "Можешь не читать мои журналы данных, пожалуйста.";
			}
			if (Main.npcChatText == "Wait a second... This isn't my ship. Did you move my chair?")
			{
				Main.npcChatText = "Погоди-ка... Это не мой корабль. Ты передвинул мой стул?";
			}
			if (Main.npcChatText == "Hey, I'm busy... Procrastinating.")
			{
				Main.npcChatText = "Эй, я занят... прокрастинцией.";
			}
			if (Main.npcChatText == "What is it?")
			{
				Main.npcChatText = "Чего надо?";
			}
			if (Main.npcChatText == "Come to help again or what?")
			{
				Main.npcChatText = "Вновь пришел помочь, или что?";
			}
			if (Main.npcChatText == "Leave me alone.")
			{
				Main.npcChatText = "Оставь меня.";
			}
			if (Main.npcChatText == "Hey, what's up?")
			{
				Main.npcChatText = "Эй, как дела?";
			}
			if (Main.npcChatText == "Come by to talk or what?")
			{
				Main.npcChatText = "Зашел поговорить, или как?";
			}
			if (Main.npcChatText == "You've been a big help, thanks.")
			{
				Main.npcChatText = "Ты оказал мне неоценимую помощь, спасибо.";
			}
			if (Main.npcChatText == "Oh great, the robot is here... What do you want?")
			{
				Main.npcChatText = "Замечательно, тут робот... Что тебе нужно?";
			}
			if (Main.npcChatText == "Oh great, the Terrarian is here... What do you want?")
			{
				Main.npcChatText = "Замечательно, тут Террариец... Что тебе нужно?";
			}
			if (Main.npcChatText == "Hey, I'm busy, piss off.")
			{
				Main.npcChatText = "Эй, я занят, отвали.";
			}
			if (Main.npcChatText == "Did you really feel the need to break into my ship?")
			{
				Main.npcChatText = "Тебе действительно так надо было проникать на мой корабль?";
			}
			if (Main.npcChatText == "Fight's over. I'm busy. Get lost.")
			{
				Main.npcChatText = "Битва окончена. Я занят. Проваливай.";
			}
			if (Main.npcChatText == "Could you just leave me alone.")
			{
				Main.npcChatText = "Не мог бы ты просто оставить меня в покое?";
			}
			if (Main.npcChatText == "I'll be leaving here soon, make it quick.")
			{
				Main.npcChatText = "Давай быстро, я скоро уйду отсюда.";
			}
			if (Main.npcChatText == "What have you got on your head? Are you trying to cosplay as me or something?")
			{
				Main.npcChatText = "Что это у тебя на голове? Ты пытаешься меня косплеить, или что?";
			}
			if (Main.npcChatText == "I'm not an idiot ya know, I know one of my own minions when I see one.")
			{
				Main.npcChatText = "Я, знаешь ли, не идиот. Собственных приспешников я узнаю, стоит их только увидеть.";
			}
			if (Main.npcChatText == "Look at you all well fed... I'm really tempted to just punch your face in.")
			{
				Main.npcChatText = "Как посмотрю, ты очень сыт... Мне очень хочется врезать по этой довольной морде.";
			}
			if (Main.npcChatText == "How did a chicken break into my ship?")
			{
				Main.npcChatText = "Как курица проникла на мой корабль?";
			}
		}
		
		private static string[][] _localizations;
	}
}
