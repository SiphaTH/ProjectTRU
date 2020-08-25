using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ShadowsOfAbaddon.ModSupport
{
	internal class SacredToolsLocalization
	{
		private static void Load()
		{
			SacredToolsLocalization._localizations = new string[][]
			{
				new string[]
				{
					"AbaddonDeathMessage",
					"Тёмная энергия Абаддона была выпущена на волю..."
				},
				new string[]
				{
					"MoonLordMessage",
					"Самый яркий свет отбрасывает самые тёмные и глубокие тени."
				},
				new string[]
				{
					"QueenBeeMessage",
					"Слабое пламя ночь освещает..."
				},
				new string[]
				{
					"FlameMessage",
					"...и реальность изменяется."
				},
				new string[]
				{
					"FrostMessage",
					"В мир высвобождены духи мороза!"
				},
				new string[]
				{
					"FlariumMessage",
					"Сила пламени ослабла."
				},
				new string[]
				{
					"CerniumMessage",
					"В глубине пещер образовались кристаллы церния"
				},
				new string[]
				{
					"TempleMessage",
					"Джунгли окутаны ослепительным светом..."
				},
				new string[]
				{
					"NovanielMessage1",
					"Я ещё не закончил..."
				},
				new string[]
				{
					"NovanielMessage10",
					"Ничего личного, но более не стой у нас на пути."
				},
				new string[]
				{
					"RVGMessage",
					"Существа иного измерения входят в наш слой реальности!"
				},
				new string[]
				{
					"fragmentMessage",
					"Мир осветило сияние праздничных лун."
				},
				new string[]
				{
					"piglinDefeat",
					"Армия пиглинов повержена!"
				},
				new string[]
				{
					"nihilusHint1",
					"Сказать, что ЭТА жалкая демонстрация была всем, на что я способен, было бы несправедливо, Смертный."
				},
				new string[]
				{
					"nihilusHint2",
					"Истинная битва только начинается. Ты будешь страдать. Страдать лишь за то, что помог этим... чужакам, которых зовёшь друзьями."
				},
				new string[]
				{
					"nihilusHint3",
					"Ты заплатишь своей кровью, своей душой, своей жизнью и смертью. Я не позволю вмешиваться в свои планы. Вот тебе одно предупреждение, Смертный... Не спи."
				},
				new string[]
				{
					"nihilusHint4",
					"Ведь любой сон, если он затягивается надолго, превращается в кошмар."
				}
			};
		}
		
		private static void Unload()
		{
			SacredToolsLocalization._localizations = null;
		}
		
		public static void SacredToolsAddLocalizations()
		{
			SacredToolsLocalization.Load();
			foreach (string[] array in SacredToolsLocalization._localizations)
			{
				ModTranslation modTranslation = ModLoader.GetMod("SacredTools").CreateTranslation(array[0]);
				modTranslation.SetDefault(array[1]);
				ModLoader.GetMod("SacredTools").AddTranslation(modTranslation);
			}
			SacredToolsLocalization.Unload();
		}
		
		public static void NpcChat()
		{
			if (Main.npcChatText == "This party is goin' a rockin! All we need now is some of my top tier paintings!")
			{
				Main.npcChatText = "Эта вечеринка будет просто потрясающей! Всё, что нам сейчас нужно, - это несколько моих лучших картин!";
			}
			if (Main.npcChatText == "Ever heard of a place called Hallownest? I'd really like to go there someday.")
			{
				Main.npcChatText = "Когда-нибудь слышал о месте под названием Халлоунест? Мне бы очень хотелось когда-нибудь туда отправиться.";
			}
			if (Main.npcChatText == "Bapanada.")
			{
				Main.npcChatText = "Бапанада.";
			}
			if (Main.npcChatText == "I have enough wares for all your needs.")
			{
				Main.npcChatText = "У меня достаточно товаров для всех твоих нужд.";
			}
			if (Main.npcChatText == "Don't underestimate nails, they can be quite powerful if used right.")
			{
				Main.npcChatText = "Не стоит недооценивать гвозди, в правильных руках они способны на многое.";
			}
			if (Main.npcChatText == "I swear I have seen this place somewhere before...")
			{
				Main.npcChatText = "Клянусь, я уже где-то видел это место...";
			}
			if (Main.npcChatText == "Wanna take a look at my wares?")
			{
				Main.npcChatText = "Хочешь взглянуть на мои товары?";
			}
			if (Main.npcChatText == "This one decoration here, it fits right into your room")
			{
				Main.npcChatText = "Вот, посмотри на эту декорацию. Она просто замечательно впишется в твою комнату.";
			}
			if (Main.npcChatText == "This place could use some decorations...")
			{
				Main.npcChatText = "Этому месту явно не хватает декораций...";
			}
			if (Main.npcChatText == "You remind me of someone I know... but who...")
			{
				Main.npcChatText = "Ты напоминаешь мне кого-то, кого я знаю... но кого?..";
			}
			if (Main.npcChatText == "Looks like you came for another decoration huh?")
			{
				Main.npcChatText = "За очередной декорацией, ха?";
			}
			if (Main.npcChatText == "Supsies again, want to buy a painting?")
			{
				Main.npcChatText = "Cнова-здорово, картины не хочешь купить?";
			}
			if (Main.npcChatText == "I really love Pandolars, they are such a cute species.")
			{
				Main.npcChatText = "Я очень люблю Пандоларов, они такие милые.";
			}
			if (Main.npcChatText == "It looks like you are ready young one. Abaddon has already begun with his plans, so get that relic ready and stop him!")
			{
				Main.npcChatText = "Кажется, ты готово, дитя. Абаддон уже начал исполнение своих планов, так что приготовь эту реликвию и останови его!";
			}
			if (Main.npcChatText == "Make sure to take that relic with you, warrior. It is the only way to break through the defense of these beings.")
			{
				Main.npcChatText = "Не забудь взять эту реликвию с собой, воин. Это единственный способ прорваться сквозь защиту этих существ.";
			}
			if (Main.npcChatText == "The first step is done, but you will need a relic if you want to finish these beings off.")
			{
				Main.npcChatText = "Первый шаг сделан, но, если хочешь покончить с этими существами, тебе понадобится реликвия.";
			}
			if (Main.npcChatText == "Without a relic you won't be able to do much harm to these beings.")
			{
				Main.npcChatText = "Без реликвии ты не сможешь причинить этим существам серьёзный урон.";
			}
			if (Main.npcChatText == "You have bested me, but you are not ready quite yet. You need to train more and acquire a full suit of Asthraltite for your protection.")
			{
				Main.npcChatText = "Ты одолел меня, но ещё не совсем готов. Тебе нужно больше тренироваться и получить для своей защиты полный костюм из азралтита.";
			}
			if (Main.npcChatText == "If you want to stop Abaddon's plans you will need Asthraltite armor, it is the only way to withstand the destructive energy created by these beings.")
			{
				Main.npcChatText = "Если хочешь остановить планы Абаддона, тебе понадобится азралтитовая броня. Это единственный способ противостоять разрушительной энергии, порождаемой этими существами.";
			}
			if (Main.npcChatText == "That girl, Nuba, I can sense a lot of kindness in her, something you don't come across very often unfortunately.")
			{
				Main.npcChatText = "Эта девушка, Небу, я чувствую в ней много доброты, с которой, к сожалению, нечасто сталкиваешься.";
			}
			if (Main.npcChatText == "Being a warrior isn't all about strength; you'll need defense and agility as well to survive in these lands.")
			{
				Main.npcChatText = "Бытие воином - это не одна лишь сила; чтобы выжить в этих землях, тебе понадобится защита и ловкость.";
			}
			if (Main.npcChatText == "The blood of a true warrior surely flows through your veins.")
			{
				Main.npcChatText = "В твоих жилах, несомненно, течёт кровь истинного воина.";
			}
			if (Main.npcChatText == "When the two crystal guardians along with their homes disappeared from the map, I decided to investigate, and I stumbled across a dimensional rift created by a powerful being. It connects this realm with mine, and that's why I am here.")
			{
				Main.npcChatText = "Когда два кристальных хранителя вместе со своими домами исчезли с карты, я решил расследовать это и наткнулся на пространственный разлом, созданный могущественным существом. Он соединяет это царство с моим, и именно поэтому я здесь.";
			}
			if (Main.npcChatText == "Would you consider yourself to be master of this world? If so, what makes you so sure you’ve earned that title?")
			{
				Main.npcChatText = "Считаешь себя хозяином этого мира? Если да, то почему так уверен, что заслужил этот титул?";
			}
			if (Main.npcChatText == "Make sure to keep some of the samples for later use, I could make use of the data and create new kinds of weapons using it.")
			{
				Main.npcChatText = "Не забудь сохранить несколько образцов для дальнейшего использования. Я мог бы использовать данные и создать новые виды оружия, используя их.";
			}
			if (Main.npcChatText == "I can create a multitude of weapons and armor from Asthraltite plating. If you prove to me you’re worth it, I could make you some.")
			{
				Main.npcChatText = "Я способен создавать из азралтита множество оружия и доспехов. Если докажешь мне, что достоин, я могу изготовить немного и тебе.";
			}
			if (Main.npcChatText == "Those creatures flying around deep below us are no members of the species of demons I belong to. An insult to the name, really; they’re closer to crude beasts than real demons.")
			{
				Main.npcChatText = "Те существа, летающие в глубинах под нами, не та же разновидность демонов, к которой принадлежу я. Жалкая пародия, оскорбление оригинала. Они куда ближе к животным, нежели к настоящим демонам.";
			}
			if (Main.npcChatText == "Antheé.. my old friend.. I need to free you of your torment.")
			{
				Main.npcChatText = "Анте.. мой давний друг.. Я должен освободить тебя от твоих мучений.";
			}
			if (Main.npcChatText == "Why is it that I never see you blink? It’s... disconcerting. Coming from me, that’s impressive.")
			{
				Main.npcChatText = "Почему я никогда не вижу, как ты моргаешь? Это... приводит в замешательство. Но впечатляет.";
			}
			if (Main.npcChatText == "This sword I carry... it is named after my daughter, which I lost in a tragic event approximately 50 years ago. Yaria was her name..")
			{
				Main.npcChatText = "Меч, что я ношу с собой... он назван в честь моей дочери, которую я потерял в результате трагического события примерно 50 лет назад. Её звали Ярия...";
			}
			if (Main.npcChatText == "I've noted several powerful beings with the telltale signs of an infliction brought on by asthral erosion. If you're feeling risky and want to find some erosion samples, I suppose you could seek them out. As a general rule, the more... magically dynamic places in this world are likely to hold more of these eroded beings.")
			{
				Main.npcChatText = "Я заметил несколько могущественных существ с явными признаками болезни, вызванной азралтитовой эрозией. Если хочешь рискнуть и найти образцы эрозии, полагаю, ты мог бы их найти. Как правило, более... магически динамичные места содержат много этих разъеденных существ.";
			}
			if (Main.npcChatText == "Turn off autopause or I'll break your nico nico kneecaps")
			{
				Main.npcChatText = "Выруби автопаузу или омаева моу...";
			}
			if (Main.npcChatText == "You're too weak to train with me yet, come back when you can stand your ground against eroded beings. \n\n(10 samples required.)")
			{
				Main.npcChatText = "Дитя, ты ещё слишком слабо, чтобы тренироваться со мной. Возвращайся, когда сможешь устоять против разъеденных существ. \n\n(требуется 10 образцов)";
			}
			if (Main.npcChatText == "Looks like you don't have enough samples in your pockets, thus I have no business fighting you. \n\n(10 samples required.)")
			{
				Main.npcChatText = "Кажется тебе не хватает образцов. Что же, тогда не вижу смысла в битве. \n\n(требуется 10 образцов)";
			}
			if (Main.npcChatText == "You're too weak to train with me yet, come back when you can stand your ground against eroded beings. \n\n(10 samples required.)")
			{
				Main.npcChatText = "Дитя, ты ещё слишком слабо, чтобы тренироваться со мной. Возвращайся, когда сможешь устоять против разъеденных существ. \n\n(требуется 10 образцов)";
			}
			if (Main.npcChatText == "Looks like you don't have enough samples in your pockets, thus I have no business fighting you. \n\n(10 samples required.)")
			{
				Main.npcChatText = "Кажется тебе не хватает образцов. Что же, тогда не вижу смысла в битве. \n\n(требуется 10 образцов)";
			}
			if (Main.npcChatText == "Shrooms? Shrooooooooooms. Shrooooooooooooooooooooooooms.")
			{
				Main.npcChatText = "Грибы? Грибыыыыыыыыыыыыыыыы. Грибыыыыыыыыыыыыыыыыыыыыыыыы.";
			}
			if (Main.npcChatText == "You now breathe manually, also your nose just floated away")
			{
				Main.npcChatText = "Ты дышишь сам? И да, твой нос только что улетел";
			}
			if (Main.npcChatText == "How high am I? Uh, 6 foot I think")
			{
				Main.npcChatText = "Насколько я хорош? Ну на 6 футов я думаю";
			}
			if (Main.npcChatText == "Tell that talking rock behind you to shut up")
			{
				Main.npcChatText = "Скажи тому болтающему камню позади тебя заткнуться.";
			}
			if (Main.npcChatText == "Ever seen giant red-eyed cyborg chickens around here? Good, thank me for that")
			{
				Main.npcChatText = "Видел здесь когда-нибудь гигантских красноглазых куриц-киборгов? Отлично, за это благодари меня.";
			}
			if (Main.npcChatText == "Is it liz-ack-hurd or.. lih-zak-ard?")
			{
				Main.npcChatText = "Это ящехеры или яхерещеры?";
			}
			if (Main.npcChatText == "despaircito")
			{
				Main.npcChatText = "отсасито";
			}
			if (Main.npcChatText == "You probably wonder what I do with all these ingredients huh? Well, I am not sure myself")
			{
				Main.npcChatText = "Хех, интересно, что я буду делать со всеми этими ингредиентами? Ну, я и сам не уверен.";
			}
			if (Main.npcChatText == "I am not sure if I am hallucinating or not, but earlier I saw some flying eyeballs outside, right after saying hi to the rocket-powered icecream man with oversized jeans")
			{
				Main.npcChatText = "Может у меня галюны были, или же нет, но недавно я видел снаружи несколько летающих глазных яблок. Это было сразу после приветствия с ракетным мороженщиком в больших джинсах.";
			}
			if (Main.npcChatText == "Hey man there's an uhh.... hand on your shoulder")
			{
				Main.npcChatText = "Эй, чувак, там это, э-э-э... у тебя на плече рука держится.";
			}
			if (Main.npcChatText == "Ya might think us demons have a hard time with doors, but... dude, that ain't true. Don't believe their lies.")
			{
				Main.npcChatText = "Можете подумать, что у нас, демонов, проблемы с дверьми, но... чувак, это неправда. Не верь их лжи.";
			}
			if (Main.npcChatText == "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH")
			{
				Main.npcChatText = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХ";
			}
			if (Main.npcChatText == "Open the door, get on the floor, everybody do the stegosaurus")
			{
				Main.npcChatText = "Открывай дверь, ложись на пол, играем в стегозавров.";
			}
			if (Main.npcChatText == "Since when do you have 20 eyes and 7 mouths? Get that fixed.")
			{
				Main.npcChatText = "С каких пор у тебя 20 глаз и 7 ртов? Исправь это.";
			}
			if (Main.npcChatText == "New potion who dis")
			{
				Main.npcChatText = "Дисреспект новому зелью";
			}
			if (Main.npcChatText == "GAAAA ZING PEW PEW POW BAM BAM BOOM AAAAAAAHHHHH- oh hi.")
			{
				Main.npcChatText = "ГРАААА ДЗИНЬ ПИУ ПИУ ПАУ БАМ БАМ БУМ ААААААХХХХХ- ой, привет.";
			}
			if (Main.npcChatText == "Am I a number of the alphabet? Are YOU a number of the alphabet?! ARE WE ALL NUMBERS OF THE ALPHABET?!?!?!?")
			{
				Main.npcChatText = "Я буква? Или ты буква?! МЫ ВСЕ БУКВЫ?!?!?!?";
			}
			if (Main.npcChatText == "h. hhhh. hhhhhhh. hhhhhhhhhhhh.")
			{
				Main.npcChatText = "х. хххх. ххххххх. хххххххххххх.";
			}
			if (Main.npcChatText == "They call me the drug machine- No they don't stop lying")
			{
				Main.npcChatText = "Они называют меня торчем - Ну и лжецы";
			}
			if (Main.npcChatText == "I have seven tongues in the back of my head.")
			{
				Main.npcChatText = "У меня на затылке есть семь языков.";
			}
			if (Main.npcChatText == "Yeah I am currently on a heavy dosage of wednesdays")
			{
				Main.npcChatText = "Да, на данный момент я под тяжелой дозой сред";
			}
			if (Main.npcChatText == "I studied alchemy in the highest academy on Syrus, so I can get a drink whenever I feel like it.")
			{
				Main.npcChatText = "В высшей академии на Сайрусе я изучал алхимия, так что могу выпить, когда того хочу.";
			}
			if (Main.npcChatText == "No I am not high, you are high! How did you even get into my room?")
			{
				Main.npcChatText = "Нет, я не под кайфом, сам такой! Как ты вообще попал в мою комнату?";
			}
			if (Main.npcChatText == "THE LIGHT, IT BURNS, AAAAAAAAHHHHHHHH")
			{
				Main.npcChatText = "СВЕТ, ОН ЖЖЕТ, ААААААААХХХХХХХ";
			}
			if (Main.npcChatText == "My hair? Oh yeah it's a scythe. I saw it work in an anime once.")
			{
				Main.npcChatText = "Моя прическа? А, да, это коса. Видел в одной анимехе.";
			}
			if (Main.npcChatText == "F to my mans hair noodle cherry boi")
			{
				Main.npcChatText = "F моим мужским вишневым дредам";
			}
			if (Main.npcChatText == "*Poses menacingly*")
			{
				Main.npcChatText = "*ГРОЗНАЯ ПОЗА*";
			}
			if (Main.npcChatText == "Hey so uuuuuuuuuhhhhh the funny nightmare man is making people have goodn�t dreams again")
			{
				Main.npcChatText = "Воуууууу этот дурацкий кошмарный чел снова делает нехорошие сны";
			}
			if (Main.npcChatText == "No I don't have a war face stop screaming at me")
			{
				Main.npcChatText = "Да нету у меня этого боевого лица или как его там";
			}
			if (Main.npcChatText == "I think the uh... purple retired for today.. Ask me again after my nap.")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "Y'know rocky place? Well, there are crystal-y worms. Yes, worms. wORMS. WORMS.")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "Rainbows... Unicorns... Purple... Wait, purple? PURPLE PLACE JUST GOT MORE PURPLE")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "Purple eyeballs... Purple teeth... purple flesh... ew.")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "The purple stuff is higher than me! It pierced the heaveeeeeeeeeeeeeeeens!!!")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "So that place... With sand that defies gravity... It uhhhhh got infected with purple I think. If ya hear screams just nut and bolt")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "Y'know, dude, I always loved the flame razed forest. Good thing you have one here... Oh wait, it's infected with erosion. Why would I go there? It's just a bigger hassle to get ingredients now!")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "Fell down that heckhole earlier. I think I saw some not-demons get infected with a the purple. Get me some heckplants while you're down there.")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "Parties are great. Balloons, blinking lights, music... the only thing that it’s missing is a giant ice statue.")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "I was about to return to Ariketik, to bring back the captured Decree, when suddenly the sky above Syrus turned dark and I found myself in a strange world, I was not able to land in time and crashed into the tundra")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "Along with me a couple other people from Syrus were thrown into the rift. We should find them to figure out how to return")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "Novaniel and his siblings, the lost siblings and children of Nahlaár. I see that they have fallen into the rift as well. Not sure what they are up to here, but it seems to have to do with this world's moon.")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "It's nice to see Nuba has finally accepted that there is yet no way to bring their father back, she'll help us a lot in trying to find a way back to Syrus.")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "IT'S TIME FOR A TEA PARTYYY!")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "Ariketik is a place that's very hostile for life to develop, it only really hosts us Pandolars and the feared Howling Deaths and Decrees. There might be other species but the constant blizzards and fog make it hard to really find anything.")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "You got some spare ice blocks? It’s really hot right now...")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "My old home looked way better than this.")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "Sometimes I think about licking ice cubes...")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "You wanna buy something??")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
		}
		
		private static string[][] _localizations;
	}
}
