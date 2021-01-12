using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ThoriumMod.ModSupport
{
	public class ThoriumSupport
	{
		private static void Load()
		{
			ThoriumSupport._translations = new string[][]
			{
				new string[]
				{
					"LodestoneWarning1",
					"Ваш мир был благословлен Магнетитом!"
				},
				new string[]
				{
					"LodestoneWarning2",
					"Ваш мир был благословлен изобилием Магнетита!"
				},
				new string[]
				{
					"ValadiumWarning1",
					"Ваш мир был благословлен Валадиумом!"
				},
				new string[]
				{
					"ValadiumWarning2",
					"Ваш мир был благословлен изобилием Валадиума!"
				},
				new string[]
				{
					"GraniteMarbleWarning",
					"Мраморные и гранитные зоны вашего мира дрожат..."
				},
				new string[]
				{
					"IllumiteWarning",
					"Люминесцентная энергия Плантеры проносится сквозь землю..."
				},
				new string[]
				{
					"AbyssionWarning",
					"В акватических глубинах что-то шевелится..."
				},
				new string[]
				{
					"JellyWarning",
					"Водная глубина пузырится под поверхностью океанов!"
				},
				new string[]
				{
					"ExpertAbyssion1",
					"От панциря Абиссиона слышен сильный хруст!"
				},
				new string[]
				{
					"ExpertAbyssion2",
					"Абиссион вырвался из своей древней тюрьмы!"
				},
				new string[]
				{
					"AbyssionDefeat",
					"Ядовитая мгла глубин была развеяна..."
				},
				new string[]
				{
					"SpiderDefeat",
					"Арктический страйдер был побежден!"
				},
				new string[]
				{
					"SpiderWarning",
					"Паучьи гнезда шуршат от гнева..."
				},
				new string[]
				{
					"SpiderAppear",
					"Восьминогая угроза бродит по ледяным просторам..."
				},
				new string[]
				{
					"PatchDefeat",
					"Ужасающий Лоскутик был изгнан из этого мира!"
				},
				new string[]
				{
					"BloomDefeat",
					"Неуловимый Трупоцвет увядает..."
				},
				new string[]
				{
					"IllusionistDefeat",
					"Загадочный иллюзионист разлетается на куски..."
				},
				new string[]
				{
					"BuriedAppear",
					"Освободился погребенный Чемпион!"
				},
				new string[]
				{
					"GraniteAppear",
					"Был выпущен Энергетический гранитный шторм!"
				},
				new string[]
				{
					"DiverFree",
					"Из этой водной гадости кто-то выпал!"
				},
				new string[]
				{
					"RagStart",
					"Террария дрожит..."
				},
				new string[]
				{
					"RagVictory",
					"Реальность возвращается к своему спокойному состоянию..."
				},
				new string[]
				{
					"outdatedBossChecklist",
					"Ваш мод boss checklist устарел. Вы должны обновить его!"
				}
			};
		}
		
		private static void Unload()
		{
			_translations = null;
		}
		
		public static void ThoriumAddLocalizations()
		{
			Load();
			foreach (string[] array in _translations)
			{
				ModTranslation modTranslation = ModLoader.GetMod("ThoriumMod").CreateTranslation(array[0]);
				modTranslation.SetDefault(array[1]);
				ModLoader.GetMod("ThoriumMod").AddTranslation(modTranslation);
			}
			Unload();
		}
		
		public static void ThoriumNpcChat()
		{
			int num = NPC.FindFirstNPC(38);
			int num2 = NPC.FindFirstNPC(17);
			if (num != -1 && Main.npcChatText == "The short one, " + Main.npc[num].GivenName + ", gives me an ample supply of ore. I wonder where he gets it...")
			{
				Main.npcChatText = "Тот коротышка, " + Main.npc[num].GivenName + ", дал мне приличный запас руды. Интересно, откуда он её взял...";
			}
			if (num2 != -1 && Main.npcChatText == "That old con man, " + Main.npc[num2].GivenName + ", keeps trying to sell me trashy tools. As if I couldn't make my own!")
			{
				Main.npcChatText = "Тот старик в кожаном пальто, " + Main.npc[num2].GivenName + ", все пытается продать мне свои бесполезные инструменты. Будто я не могу сделать их сам!";
			}
			if (Main.npcChatText == "Even a broken clock is right every week! Or was it a day...?")
			{
				Main.npcChatText = "Даже сломанные часы показывают верное время раз в неделю! Или там говорилось в день..?";
			}
			if (Main.npcChatText == "Always strike while the iron is hot! Don't let a good opportunity pass you by...")
			{
				Main.npcChatText = "Бей железо, пока оно горячее! Не позволяй хорошим возможностям проходить мимо...";
			}
			if (Main.npcChatText == "You won't find a better blacksmith in all of Terraria! What's that, you're a smith too? Oh...")
			{
				Main.npcChatText = "Во всей Террарии не найдешь кузнеца лучше меня! Погоди, ты тоже кузнец? Ох...";
			}
			if (Main.npcChatText == "I'm always trying to make the perfect armor. Perhaps you can help me out?")
			{
				Main.npcChatText = "Долгое время я пытаюсь создать идеальную броню. Не хочешь помочь?";
			}
			Player localPlayer = Main.LocalPlayer;
			int num3 = NPC.FindFirstNPC(208);
			int num4 = NPC.FindFirstNPC(108);
			int num5 = NPC.FindFirstNPC(22);
			if (num3 != -1 && Main.npcChatText == "Can you believe that " + Main.npc[num3].GivenName + " wanted to throw me a birthday party? I haven't had one in so long!")
			{
				Main.npcChatText = "Ты можешь поверить? " + Main.npc[num3].GivenName + " и остальные хотели устроить вечеринку на мой день рождения! У меня их не было так давно!";
			}
			if (num4 != -1 && Main.npcChatText == "Oh my... I think " + Main.npc[num4].GivenName + " might be even older than I am!")
			{
				Main.npcChatText = "О мой... Я думаю " + Main.npc[num4].GivenName + " может быть даже старше меня!";
			}
			if (num5 != -1 && Main.npcChatText == "Ah, so " + Main.npc[num5].GivenName + " has been giving you advice this whole time? It's always nice to see a young man appreciate his studies.")
			{
				Main.npcChatText = "А, так " + Main.npc[num5].GivenName + " все это время помогал тебе советами? Всегда приятно видеть, как молодой человек ценит свою учебу.";
			}
			if (Main.npcChatText == "In my younger years, I myself was a hero. But after a bad fall, I've since retired. Perhaps if I had better boots back then I would still be a hero today...")
			{
				Main.npcChatText = "В молодые годы я сам был героем. Но после неудачного падения я ушел на пенсию. Возможно, если бы у меня были ботинки получше чем тогда, я все еще был бы героем...";
			}
			if (Main.npcChatText == "Worry not young hero. While the journey may be tough, I have full confidence in your ability!")
			{
				Main.npcChatText = "Не беспокойся, молодой герой. Хотя путешествие может быть трудным, я полностью уверен в твоих способностях!";
			}
			if (Main.npcChatText == "Having proper footwear is no joke, " + localPlayer.name + ". Always make sure your shoes are polished and ready for adventure!")
			{
				Main.npcChatText = "Правильный подбор обуви никакая не шутка, " + localPlayer.name + ". Всегда убеждайся, что твоя обувь как следует отполирована и готова к приключениям!";
			}
			if (Main.npcChatText == "You can learn a lot by walking a mile in someone else's boots. If only some of these townsfolk would walk a mile in yours, then they could understand...")
			{
				Main.npcChatText = "Ты можешь многому научиться, пройдя милю в чужих сапогах. Если бы только некоторые из наших горожан прошли бы вашу милю, то они могли бы понять...";
			}
			if (Main.npcChatText == "How are you doing, " + localPlayer.name + "? Are you staying safe out there in the wilds?")
			{
				Main.npcChatText = "Как дела, " + localPlayer.name + "? Там, в этих дебрях, ты в безопасности?";
			}
			if (Main.npcChatText == "There we go, good as new! Make sure to stay safe out there, hero.")
			{
				Main.npcChatText = "Вот так, как новенький! Убедись, что ты там в безопасности, герой.";
			}
			if (Main.npcChatText == "I'm afraid I can't make them any more shiny than they already are... Come back later when you get a little more dirt on them!")
			{
				Main.npcChatText = "Боюсь, я не смогу сделать их более блестящими, чем они уже есть... Возвращайся позже, когда на них появится немного грязи!";
			}
			int num6 = NPC.FindFirstNPC(22);
			int num7 = NPC.FindFirstNPC(208);
			if (num6 != -1 && Main.npcChatText == "I bet " + Main.npc[num6].GivenName + " has a big juicy brain... not that I would wanna... uh... did you need something?")
			{
				Main.npcChatText = "Уверен " + Main.npc[num6].GivenName + " имеет большой сочный мозг... ну, не то чтобы я хотел... э... тебе что-то нужно?";
			}
			if (num7 != -1 && Main.npcChatText == Main.npc[num7].GivenName + "'s brain would surely taste like candy... Oh uh, hello there!")
			{
				Main.npcChatText = Main.npc[num7].GivenName + " точно должен по вкусу напоминать конфету... Э, ох, привет тебе!";
			}
			if (Main.npcChatText == "I can't remember much about my past life... Chemicals and the like were my passion I think; I only get fragments and pieces of the truth. It's saddening at times...")
			{
				Main.npcChatText = "Я немного помню из своей прошлой жизни... Думаю, разные химические вещества и тому подобное были моей страстью. Единственное что у меня есть, это фрагменты и кусочки памяти. Порой это довольно грустно...";
			}
			if (Main.npcChatText == "Why am I not like the others...? Oh, I'm sorry, did you need something friend?")
			{
				Main.npcChatText = "Почему я не такой как другие..? О, извиняюсь. Тебе что-то нужно, друг?";
			}
			if (Main.npcChatText == "Most people don't have the stomach to handle the things I sell. The trick is to not have a stomach at all!")
			{
				Main.npcChatText = "Большинство людей не обладают достаточно сильным желудком для выдержки вещей, что я продаю. Трюк в том, чтобы не иметь желудка вообще!";
			}
			if (Main.npcChatText == "I gotta thank you for letting me stick around. Only coming out at night is pretty boring...")
			{
				Main.npcChatText = "Я должен поблагодарить за то, что ты вытащил меня наружу. Выходить только по ночам довольно скучно...";
			}
			if (Main.npcChatText == "Looks like you're a bit short on funds. Come back to me when you have a little more coin in your pocket!")
			{
				Main.npcChatText = "Похоже тебе немного не достает монет. Возвращайся, когда в твоем кошельке будет хоть немного денег!";
			}
			if (Main.npcChatText == "I just whipped up the perfect recipe to deter bats from bothering you; no more tiny nibbles!")
			{
				Main.npcChatText = "Я только что вывел новый рецепт от летучих мышей; скажем нет маленьким укусам!";
			}
			if (Main.npcChatText == "If this turned out correctly, you'll smell just like a zombie. Hopefully your nights will be a tad more calm!")
			{
				Main.npcChatText = "Если я все сделал как надо, то ты теперь пахнешь как самый настоящий зомби. Надеюсь твоя ночь станет чуточку спокойнее";
			}
			if (Main.npcChatText == "Getting this stuff to work underwater was a huge hassle... Either way, hungry fish shouldn't attempt to eat you with this.")
			{
				Main.npcChatText = "Сделать так, чтобы эта штука работала под водой, было непросто... Ну, зато с этим тебя не будут пытаться сожрать рыбы.";
			}
			if (Main.npcChatText == "I'll be honest, this is just a bottle of pure liquid calcium. Don't question it, the skeletons surely won't.")
			{
				Main.npcChatText = "Если честно, то это обычная бутылка с жидким кальцием. Даже не спрашивай как это работает.";
			}
			if (Main.npcChatText == "With this nasty concoction, insects will associate your scent with their queen! Neat, huh?")
			{
				Main.npcChatText = "С помощью этого мерзкого варева насекомые будут считать тебя своей королевой! Четко, да?";
			}
			if (Main.npcChatText == "I'm afraid you'll have to give me some more time to prepare the next repellent. This stuff can get pretty complicated...")
			{
				Main.npcChatText = "Боюсь тебе придется еще немного подождать, изготовление репеллентов довольно сложное занятие...";
			}
			int num8 = NPC.FindFirstNPC(369);
			int num9 = NPC.FindFirstNPC(20);
			int num10 = NPC.FindFirstNPC(228);
			if (num8 != -1 && Main.npcChatText == "That kid " + Main.npc[num8].GivenName + " is so stingy with his fish. He has a million of them and he can't spare a single one for some fish fillet?")
			{
				Main.npcChatText = "Этот ребенок, " + Main.npc[num8].GivenName + ", так скуп со своей рыбой. У него их миллион, и он не может даже одну отдать на рыбное филе?";
			}
			if (num9 != -1 && Main.npcChatText == "Cooking for " + Main.npc[num9].GivenName + " is no easy task. She simply refuses to eat any form of meat!")
			{
				Main.npcChatText = "Эта дриада, " + Main.npc[num9].GivenName + ", требует от меня много работы. Она отказывается есть любой вид мяса!";
			}
			if (num10 != -1 && Main.npcChatText == "The last time " + Main.npc[num10].GivenName + " asked me to cook for him, he requested bugs! This truly is a strange place...")
			{
				Main.npcChatText = "В последний раз когда " + Main.npc[num10].GivenName + " попросил приготовить для него блюдо, он попросил жуков! Что за странный город...";
			}
			if (Main.npcChatText == "I've got a lot of orders from the other townsfolk right now, make it quick!")
			{
				Main.npcChatText = "У меня сейчас много заказов от других горожан, давай в темпе!";
			}
			if (Main.npcChatText == "How did any of you survive before I arrived? What could you have possibly been eating, dirt?")
			{
				Main.npcChatText = "Как кто-нибудь из вас жил до моего приезда? Что вы могли есть, грязь?";
			}
			if (Main.npcChatText == "I'm stuck with dull knives while you wield weapons of unimaginable power? Give me a break...")
			{
				Main.npcChatText = "Я застрял тут с тупыми ножами, а ты владеешь оружием невероятной силы? Дай мне перерыв...";
			}
			if (Main.npcChatText == "No one should go adventuring on an empty stomach. Eat well, hero!")
			{
				Main.npcChatText = "Никто не должен отправляться на приключения с пустым желудком. Ешь хорошо, герой!";
			}
			if (Main.npcChatText == "Supply me with the proper ingredients, and I can make some truly powerful foods for you, hero!")
			{
				Main.npcChatText = "Предоставь мне подходящие ингредиенты, и я смогу приготовить для тебя действительно великолепную еду, герой!";
			}
			if (Main.npcChatText == "Ah, just enough blueberries to start making blueberry salad. Please enjoy, " + localPlayer.name + "!")
			{
				Main.npcChatText = "Ах, идеальное количество черники для черничного салата. Пожалуйста, " + localPlayer.name + ", наслаждайся!";
			}
			if (Main.npcChatText == "This crisp morel was just asking to be put in a dish. I hope it's to your liking!")
			{
				Main.npcChatText = "Этот свежий сморчок так и просит стать блюдом. Надеюсь тебе понравится!";
			}
			if (Main.npcChatText == "Pink pears can be problematic if prepared improperly. Good thing I'm a professional pear pickler!")
			{
				Main.npcChatText = "Собранные неправильным способом розовые груши могут стать неприятной проблемой. Но как удачно, что я профессиональный собиратель груш!";
			}
			if (Main.npcChatText == "Well uh... I DID cook it, though I'm not entirely sure you should eat this stuff.")
			{
				Main.npcChatText = "Эм, ну... я ПРИГОТОВИЛ это. Но я не уверен, что ты должен это есть.";
			}
			if (Main.npcChatText == "With just the right amount of green, this dish gets real mean. Be careful eating it!")
			{
				Main.npcChatText = "При достаточном количестве зеленого, это блюдо становится очень грубым. Будешь есть это, будь осторожен!";
			}
			if (Main.npcChatText == "Not a single wheat stalk in sight... I guess kelp can suffice as a noodle, if prepared correctly at least.")
			{
				Main.npcChatText = "Тут нет ни одного колоска пшеницы... думаю водоросли тоже сойдут в качестве лапши, по крайней мере если правильно приготовить.";
			}
			if (Main.npcChatText == "When I was younger, my mother would always greet me with some ice cold lemonade after a day of playing in the sun... I miss the simpler times.")
			{
				Main.npcChatText = "Когда я был моложе, после долгих прогулок на солнце мать всегда встречала меня ледяным лимонадом... я скучаю по этим временам.";
			}
			if (Main.npcChatText == "Yunno, it's not just called a 'Sky Blue Flower' because of its color. Some say they've fallen from the sky islands themselves long ago.")
			{
				Main.npcChatText = "Знаешь, он не зовется 'небесно-голубым цветком' не только из-за цвета. Некоторые говорят, что давным давно он упал с самих небесных островов.";
			}
			if (Main.npcChatText == "Last time I took a swig of this stuff, I started thinking everything was out to get me... but hey, maybe that's what you're looking for?")
			{
				Main.npcChatText = "Когда я в прошлом сделал глоток этой штуки, то все будто ополчились против меня... но, быть может, ты этого и хочешь?";
			}
			if (Main.npcChatText == "Ah, glowing mushrooms, a staple in the diet of a terrarian! Hopefully this recipe offers a little more 'pizazz' to its taste.")
			{
				Main.npcChatText = "Ах, светящиеся грибы, главный продукт в рационе террарийца! Надеюсь это блюдо имеет более выраженный вкус 'стиля'";
			}
			if (Main.npcChatText == "I'm honored that you'd trust me with such rare commodities. Hopefully this new recipe suits your fancy!")
			{
				Main.npcChatText = "Для меня большая честь, что ты доверишь мне такие редкие продукты. Надеюсь этот новый рецепт придется тебе по вкусу!";
			}
			if (Main.npcChatText == "I myself don't know much about the Hallow, it's a rather strange place... but berries are berries, right?")
			{
				Main.npcChatText = "Я не так много знаю про Освящение, это определенно странное место... но ягоды есть ягоды, верно?";
			}
			if (Main.npcChatText == "So the legends are true... The kitchen scholars thought this recipe was lost to time, but it's right in front of me. I can barely contain my excitement to try it out!")
			{
				Main.npcChatText = "Так легенды не врали... Многие повара думали, что этот рецепт утерян во времени, но вот он, прямо передо мной. Я едва сдерживаю волнение!";
			}
			if (Main.npcChatText == "I can tell this was written by an ogre... still, the pictures give me a clear idea on how to brew this. Be careful with this stuff, it's highly potent!")
			{
				Main.npcChatText = "Этот рецепт определенно написан огром... тем не менее, по картинкам становится понятен способ готовки. Будь осторожен с этой штукой, больно она крепкая!";
			}
			if (Main.npcChatText == "Leaves? You want me to cook some food... with leaves? Well, I don't think these would really work in a salad, so how about some tea instead? I'm sure it will calm you down if you're stressed.")
			{
				Main.npcChatText = "Листья? Ты хочешь, чтобы я приготовил блюдо с... листьями? Не думаю что они будут хороши в салате, так что как насчет чая? Он обладает успокаивающим эффектом.";
			}
			if (Main.npcChatText == "These were exactly what I was missing for my special hot chocolate recipe! If you're planning on going somewhere a little chilly, these will warm you right up for sure.")
			{
				Main.npcChatText = "Это именно то, чего так не хватало моему рецепту горячего шоколада! В прохладных местах он всегда сможет согреть тебя";
			}
			if (Main.npcChatText == "Looks like you don't have any ingredients in your bag. If you can find enough of an ingredient I'm looking for, I can supply you with new purchasable foods. Some of these dishes will be far more powerful than my usual wares, so keep your eyes peeled for unique ingredients!")
			{
				Main.npcChatText = "Похоже в твоей сумке нет никаких ингредиентов. Если найдешь мне достаточно нужных продуктов, то я смогу снабжать тебя великолепной едой! Некоторые из этих блюд намного мощнее, чем обычные, так что ищите уникальные ингредиенты!";
			}
			int num11 = NPC.FindFirstNPC(207);
			int num12 = NPC.FindFirstNPC(19);
			if (num11 != -1 && Main.npcChatText == Main.npc[num11].GivenName + " was interested in dyeing my attire, but his choice of plant dye was 'strange' to say the least.")
			{
				Main.npcChatText = Main.npc[num11].GivenName + " был заинтересован в покраске моего наряда, но выбор этой самой краски был 'странным', говоря мягкими словами.";
			}
			if (num12 != -1 && Main.npcChatText == "Look at " + Main.npc[num12].GivenName + " over there! He's got an entire arsenal of guns, is that really safe?")
			{
				Main.npcChatText = "Ты только посмотри на " + Main.npc[num12].GivenName + "! У него целый арсенал оружия, это точно безопасно?";
			}
			if (Main.npcChatText == "We certainly have some strange people around this town, don't we...?")
			{
				Main.npcChatText = "В этом городе хватает странных людей, верно..?";
			}
			if (Main.npcChatText == "You didn't see any giant bird shadows while you were out in the desert, did you?")
			{
				Main.npcChatText = "Во время путешествия в пустыне ты не видел гигантскую тень птицы, а?";
			}
			if (Main.npcChatText == "I had originally stopped just to refill my canteen, but you seem like someone who can deal with a real threat!")
			{
				Main.npcChatText = "Изначально я остановился только для того, чтобы наполнить свой походный ящик. Но вы, похоже, человек, который может справиться с угрозой!";
			}
			if (Main.npcChatText == "Have you ever heard tale of the Thunder Birds? Legend says they had long protected our world from cataclysmic threats, before a disagreement between them and three individuals led to their disappearance...")
			{
				Main.npcChatText = "Слышал когда-нибудь сказки о гром-птицах? В легендах сказано, что они долго защищали наш мир от катастроф, прежде чем разногласия между ними и тремя личностями привели к их исчезновению...";
			}
			if (Main.npcChatText == "I have seen so much evil in my travels... I only hope someone can put a stop to them!")
			{
				Main.npcChatText = "В своём странствии я видел столь много зла... Единственная моя надежда о появлении того, кто его остановит!";
			}
			if (Main.npcChatText == "Although I'm only an acolyte, one of the first things we learn is how to create a sandstorm. Beware the creatures that lurk within however...")
			{
				Main.npcChatText = "Пускай я только послушник, но первая вещь которой мы учимся - вызов песчаной бури. Но бойтесь существ, что в это время скрываются глубинах...";
			}
			if (Main.npcChatText == "Creating a sandstorm is a very taxing job. I would prefer to have some compensation in the form of money, please.")
			{
				Main.npcChatText = "Вызов песчаной бури довольно утомителен. Я бы предпочел получить деньги вперед, пожалуйста.";
			}
			if (Main.npcChatText == "Visiting that sea rift again wasn't my best idea... that mutant jellyfish almost ate me whole!")
			{
				Main.npcChatText = "Посещение того океанического пролома было не лучшей идеей... та мутировавшая медуза чуть целиком меня не сожрала!";
			}
			if (Main.npcChatText == "Yuck... that vile creature almost got away with eating me! Thank you for saving me, hero.")
			{
				Main.npcChatText = "Ох... это злостное создание почти съело меня! Спасибо за спасение, герой.";
			}
			int num13 = NPC.FindFirstNPC(229);
			int num14 = NPC.FindFirstNPC(369);
			if (num13 != -1 && Main.npcChatText == "You wouldn't believe it, but " + Main.npc[num13].GivenName + " and me go way back. He wasn't always a salt water scourge, yunno'.")
			{
				Main.npcChatText = "Можешь не верить, но " + Main.npc[num13].GivenName + " и я всегда имеем путь назад. Не всегда же он был просоленным бродягой, знаешь ли.";
			}
			if (num14 != -1 && Main.npcChatText == "That little twerp, " + Main.npc[num14].GivenName + ", thinks he knows so much about the sea...")
			{
				Main.npcChatText = "Этот мелкий хам, " + Main.npc[num14].GivenName + ", думает, будто много знает о море...";
			}
			if (Main.npcChatText == "Have you adventured into the aquatic depths yet...? Its choking atmosphere prevents most explorers from entering, but I'm confident you'll find a way around it...")
			{
				Main.npcChatText = "Ты уже спускался в морскиее глубины? Его давящая атмосфера отпугивает многих исследователей, но я уверен, что ты найдешь способ обойти этот неприступный барьер...";
			}
			if (Main.npcChatText == "I've collected many marine items in my travels, hero. Would you like to purchase one?")
			{
				Main.npcChatText = "В своих странствиях по дну морскому я собрал множество различных предметов, герой. Хотел бы что-нибудь купить?";
			}
			if (Main.npcChatText == "Being at the bottom of the ocean for long periods of time has taught me one thing. Always come prepared!")
			{
				Main.npcChatText = "Один раз я долго пробыл на океаническом дне и осознал одну вещь. Нужно постоянно быть бдительным!";
			}
			if (Main.npcChatText == "You ever try to drink a bottle of water, while drowning, to save yourself? I know I have!")
			{
				Main.npcChatText = "Ты когда-нибудь пытался выпить из бутылки пока тонешь, чтобы спасти свою шкуру? Я знаю о чем говорю!";
			}
			if (Main.npcChatText == "Here you go friend! This air tank will automatically activate when your breath reaches critical level. Come visit me afterwards and I'll refill it free of charge!")
			{
				Main.npcChatText = "Держи, салага! Этот воздушный баллон автоматически активируется, стоит твоему запасу воздуха достигнуть критического уровня. После этого можешь посетить меня снова, я его бесплатно заполню!";
			}
			if (Main.npcChatText == "Let me refill that air tank for you, friend. Do continue to take caution out there; Terraria needs you alive and well...")
			{
				Main.npcChatText = "Дай-ка наполню твой баллон, салага. Будь осторожен; Ты нужен Террарии в живым и здоровым...";
			}
			if (Main.npcChatText == "Hmm, your air tank looks full to me... Did you just want to chat? I have all manner of tales to tell!")
			{
				Main.npcChatText = "Хм, твой баллон полный... Так ты хотел пообщаться? У меня есть куча историй, могу рассказать!";
			}
			if (Main.npcChatText == "")
			{
				Main.npcChatText = "";
			}
			int num15 = NPC.FindFirstNPC(20);
			int num16 = NPC.FindFirstNPC(228);
			if (num15 != -1 && Main.npcChatText == "Ever since I was a child, I've always wanted to meet a dryad. What luck it is to find " + Main.npc[num15].GivenName + " here!")
			{
				Main.npcChatText = "С самого детства я хотела хотела встретить дриаду. И мне повезло найти " + Main.npc[num15].GivenName + " здесь!";
			}
			if (num16 != -1 && Main.npcChatText == "Our friend there, " + Main.npc[num16].GivenName + ", is rather strange isn't he? He speaks in riddles...")
			{
				Main.npcChatText = "Наш друг, " + Main.npc[num16].GivenName + ", довольно странный, не находишь? Он постоянно говорит этими загадками...";
			}
			bool flag = Main.player[Main.myPlayer].talkNPC != -1;
			int i = 0;
			while (i < 200 && flag)
			{
				if (Main.npc[Main.player[Main.myPlayer].talkNPC].type == ModLoader.GetMod("ThoriumMod").NPCType("Druid"))
				{
					string chatru = "Интересно, смогу ли я убедить ";
					string chatru2 = " приготовить мне салат.";
					Main.npcChatText = Main.npcChatText.Replace("I wonder if I can convince ", chatru).Replace(" to whip me up a salad.", chatru2);
				}
				i++;
			}
			if (Main.npcChatText == "Why don't you go fetch those seeds yourself you lazy, good for nothing-")
			{
				Main.npcChatText = "Почему бы тебе не пойти и собрать эти семена самостоятельно, ни на что не годный лентяй";
			}
			if (Main.npcChatText == "I bet you don't even feel guilty about destroying and killing the natural world to better suit your needs...")
			{
				Main.npcChatText = "Бьюсь об заклад, ты даже не чувствуешь вины за разрушение и убийство природы и делаешь это только ради удовлетворения своих низких потребностей...";
			}
			if (Main.npcChatText == "Getting these seeds is a bigger hassle than you would think. Nearly drowning, almost melting, freezing to- You get the idea.")
			{
				Main.npcChatText = "Сбор этих семян гораздо большая морока, чем ты думаешь. Для меня нормально почти утопать, сгорать от жары, замерзать до смер... Ну ты понял.";
			}
			if (Main.npcChatText == "I often take visits to the jungle. I can understand the aversion to the place, but the creatures within don't seem to hassle me...")
			{
				Main.npcChatText = "Я довольно часто посещаю джунгли. Могу понять твоё отвращение к этому месту, но существа внутри не трогают меня...";
			}
			if (Main.npcChatText == "My mother was a well known herbalist back in the day. She doesn't talk about my father, though. I wonder why?")
			{
				Main.npcChatText = "Когда-то моя мать была известной травницей. И при всём этом не говорила про отца. Интересно, почему?";
			}
			if (Main.npcChatText == "How does today find you, " + localPlayer.name + "? Make sure to stop and smell the roses!")
			{
				Main.npcChatText = "Как день, " + localPlayer.name + "? Остановись и понюхай эти розы вокруг!";
			}
			if (Main.npcChatText == "The natural world is quite a wonder. Every little place has its own charm. Some more than others!")
			{
				Main.npcChatText = "Мир природы просто чудесен. У каждого места есть свой особенный шарм. Но у некоторых он лучше!";
			}
			if (Main.npcChatText == "Is- Is that my cross? How in the world did you manage to find it? It's been lost for so long...")
			{
				Main.npcChatText = "Э-это мой крест? Как ты, черт побери, его нашел? Я потерял его столь давно...";
			}
			int num17 = NPC.FindFirstNPC(369);
			int num18 = NPC.FindFirstNPC(228);
			if (num17 != -1 && Main.npcChatText == Main.npc[num17].GivenName + " often comes to me in private to discuss things that are bothering him. Such a young age to be in his position...")
			{
				Main.npcChatText = Main.npc[num17].GivenName + " часто приходит ко мне, чтобы обсудить вещи, которые его бесят. В столь юном возрасте быть таким...";
			}
			if (num18 != -1 && Main.npcChatText == Main.npc[num18].GivenName + " and I spent all of last night discussing philosophy. That one has a wise head on his shoulders.")
			{
				Main.npcChatText = Main.npc[num18].GivenName + " и я провели всю ночь, обсуждая философию. В своей голове он имеет мудрый разум.";
			}
			if (Main.npcChatText == "Beware my friend... true evil walks among us this night.")
			{
				Main.npcChatText = "Остерегайся, друг... этой ночью истинное зло раскроет личину среди нас.";
			}
			if (Main.npcChatText == "Ah, it's been a while friend. It is good to see you are well after so long!")
			{
				Main.npcChatText = "Ох, давно тебя не было видно, друг. Рад видеть тебя в полном здравии спустя столь большое время!";
			}
			if (Main.npcChatText == "Not all who wander are lost, remember this friend...")
			{
				Main.npcChatText = "Не всякий, кто бродит, потерялся, запомни это, друг...";
			}
			if (Main.npcChatText == "Energy, chi, spirit... it's all the same to me. There is power in all things.")
			{
				Main.npcChatText = "Энергия, ци, дух... Все для меня одно. Во всех этих вещах есть мощь.";
			}
			if (Main.npcChatText == "I have no doubt of your physical power, hero. But sometimes hardship is fought in a battle of will, not strength.")
			{
				Main.npcChatText = "Я не имею сомнений в твоей физической силе, герой. Но иногда трудности требуется преодолевать не силой, но волей.";
			}
			if (Main.npcChatText == "I'm afraid I can't currently protect you. The residual energy from my power is still interfering with my attempts to empower you.")
			{
				Main.npcChatText = "Боюсь, сейчас я не могу защитить тебя, друг. Остаточная энергия от моей силы мешает попыткам твоего усиления.";
			}
			if (Main.npcChatText == "With these shards, I have imbued you with an incredibly potent shield. Should you take fatal damage, you shall receive my protection for as long as I can hold it. Stay safe out there, my friend.")
			{
				Main.npcChatText = "С этими осколками я наложу на тебя мощный щит. Если получишь смертельный удар, то он активируется и будет держаться столько, на что мне хватит сил. Будь осторожен, друг.";
			}
			if (Main.npcChatText == "I require no money to watch over you my friend, but my protection is limited without some Purified Shards. Once you acquire some, come visit me again.")
			{
				Main.npcChatText = "Я не требую с тебя денег, друг, но без очищенных осколков моя сила сильно ограничена. Возвращайся, как найдешь их.";
			}
			if (Main.npcChatText == "No need to fear my friend, my power is already protecting you. Come back when my power has faded.")
			{
				Main.npcChatText = "Нет причин бояться, моя сила уже защищает тебя. Возвращайся, когда данная мной сила угаснет.";
			}
			if (Main.npcChatText == "Seen any interesting beasts lurking around lately? Minotaurs? Beholders? Gorgons?")
			{
				Main.npcChatText = "Видел бродящих в последнее время монстров? Минотавров? Созерцателей? Горгон?";
			}
			if (Main.npcChatText == "Bear your scars with pride, as each one has a tale to tell... What do your scars say about you hero?")
			{
				Main.npcChatText = "Носи свои шрамы с гордостью, ведь каждый из них несет свою историю... Что же говорят о тебе твои шрамы, герой?";
			}
			if (Main.npcChatText == "Many beasts have fallen to me and my blade, but new ones are always on the prowl. Keep your eyes peeled, kid.")
			{
				Main.npcChatText = "Множество грозных монстров пало от меня и моего меча, но эти новые всегда нападают неожиданно. Держи нос по ветру, мелкий.";
			}
			if (Main.npcChatText == "You'd be surprised how effective a single shoulder pad can be.")
			{
				Main.npcChatText = "Ты будешь удивлен, насколько эффективным может быть всего один наплечник.";
			}
			int j = 0;
			while (j < 200 && flag)
			{
				if (Main.npc[Main.player[Main.myPlayer].talkNPC].type == ModLoader.GetMod("ThoriumMod").NPCType("WeaponMaster"))
				{
					Main.npcChatText = Main.npcChatText.Replace(" blankly stares through you, as though he's not entirely there...", " смотрит сквозь вас пустым взглядом, будто он совсем не тут...");
				}
				j++;
			}
			int num19 = NPC.FindFirstNPC(22);
			int num20 = NPC.FindFirstNPC(441);
			if (num19 != -1 && Main.npcChatText == "That man over there, " + Main.npc[num19].GivenName + ", keeps giving me dirty looks...")
			{
				Main.npcChatText = "Тот человек, " + Main.npc[num19].GivenName + ", продолжает кидать на меня презрительные взгляды...";
			}
			if (num20 != -1 && Main.npcChatText == "I see we have another demon within our ranks. What was his name again? " + Main.npc[num20].GivenName + "?")
			{
				Main.npcChatText = "Как погляжу, наши ряды пополнились новым демоном. Как там его зовут? " + Main.npc[num20].GivenName + "?";
			}
			if (Main.npcChatText == "*So... you've gained the ability to speak in tongues, " + localPlayer.name + "? Very fascinating...*")
			{
				Main.npcChatText = "*О... Так ты обрёл способность говорить на нашем языке, " + localPlayer.name + "? Довольно увлекательно...*";
			}
			if (Main.npcChatText == "Ie... oep'wl vmnjld hrl mfnbnho he iwlmc nj hejvpli, " + localPlayer.name + "? wlgo zmisnjmhnjv...")
			{
				Main.npcChatText = "Ыщ... нщг'му пфштув еру фишдшен ещызуфл шт ещтпгуы, " + localPlayer.name + "? Мукн афысштфештп...";
			}
			if (Main.npcChatText == "Long ago, when this world was first taking form, my race reigned supreme. That time has passed it seems...")
			{
				Main.npcChatText = "Давным-давно, когда мир только принял свою форму, моя раса безраздельно властвовала. Но эти времена давно прошли...";
			}
			if (Main.npcChatText == "I'm not one for idle chatter. If you have need of me, make it quick.")
			{
				Main.npcChatText = "Я здесь не для пустой болтовни. Если я тебе нужен, давай быстрее.";
			}
			if (Main.npcChatText == "My race's obsession with voodoo dolls has only become rampant just recently. It's truly a fad gone wrong...")
			{
				Main.npcChatText = "Одержимость моей расы куклами вуду только недавно стала безудержной. Все это действительно зашло куда-то не туда...";
			}
			if (Main.npcChatText == "Should you have the coin, I would be willing to accompany you in your endeavors...")
			{
				Main.npcChatText = "Демону заплатите чеканной монетой, и я буду готов сопровождать вас в ваших странствиях...";
			}
			if (Main.npcChatText == "A warrior without his weapon stands no chance against the ever-powering threats he must face...")
			{
				Main.npcChatText = "У воина без оружия нет ни шанса одолеть извечных врагов, что встречаются на его пути...";
			}
			if (Main.npcChatText == "I see you're lacking in coin. Remedy that and I may just help you out...")
			{
				Main.npcChatText = "Как погляжу, тебе не хватает монет. Исправь эту досадную оплошность и я помогу тебе...";
			}
			if (Main.npcChatText == "Before you sits a rather strange mirror... Something seems to be calling out from it?")
			{
				Main.npcChatText = "Перед вами довольно странное зеркало... Кажется, оттуда что-то взывает?";
			}
			if (Main.npcChatText == "Got a special deal for ya, straight from this poor lot who wandered into that old Bat's lair unprepared.")
			{
				Main.npcChatText = "У меня есть для тебя особое предложение, прямо от этого бедолаги, который забрел в логово старой летучей мыши, неподготовленным.";
			}
			if (Main.npcChatText == "You see a lot when you wander these buried caverns. Why just the other day I stumbled upon some sort of 'blood stained chamber'. I wonder what its purpose was...?")
			{
				Main.npcChatText = "Ты многое видишь, когда бродишь по этим погребенным пещерам. Ведь как раз на днях я наткнулся на какую-то 'заляпанную кровью камеру'. Интересно, какова была его цель?..?";
			}
			if (Main.npcChatText == "Aye, I once saw a sea demon risin' from those depths. Somethin' dark, somethin' ancient, somethin'... uhh... You gonna buy somethin'?!")
			{
				Main.npcChatText = "Да, однажды я видел морского демона, поднимающегося из этих глубин. Что-то 'темное', что-то 'древнее', что-то еще... ухх... Ты собираешься что-нибудь покупать?!";
			}
			if (Main.npcChatText == "Aye, so the legends be true... A great and terrible beast lurks beneath the depths, matey. Best if you go and handle it, eh?")
			{
				Main.npcChatText = "Да, значит, легенды правдивы... Большой и ужасный зверь скрывается в глубинах, приятель. Будет лучше, если ты сам займешься этим, а?";
			}
			if (Main.npcChatText == "Another healer in town? Ugh, this will be bad for business...")
			{
				Main.npcChatText = "Еще один целитель в городе? Фу, это будет плохо для бизнеса...";
			}
			if (Main.npcChatText == "Are you sure you really need my help healing you and your allies? You seem to have it under control...")
			{
				Main.npcChatText = "Ты уверен, что тебе действительно нужна моя помощь в исцелении тебя и твоих союзников? Похоже, у тебя все под контролем...";
			}
			if (Main.npcChatText == "In my younger years I was quite the experienced bard too! I've since left that behind me, though.")
			{
				Main.npcChatText = "В молодые годы я тоже был довольно опытным бардом! Но с тех пор я забросил это.";
			}
			if (Main.npcChatText == "You know, people would pay good money for quality music like yours. Care to hear my business proposition...?")
			{
				Main.npcChatText = "Вы знаете, люди платят хорошие деньги за такую качественную музыку, как ваша. Хотите услышать мое деловое предложение...?";
			}
			int k = 0;
			while (k < 200 && flag)
			{
				if (Main.npc[Main.player[Main.myPlayer].talkNPC].type == num2)
				{
					string chatru3 = "Ах, ";
					string chatru4 = "мужчина музыки!";
					string chatru5 = "женщина музыки!";
					string chatru6 = " Как хорошо вы можете выполнить мелодию?";
					Main.npcChatText = Main.npcChatText.Replace("Ah, a ", chatru3).Replace("man of music!", chatru4).Replace("woman of music!", chatru5).Replace(" How well can you carry a tune?", chatru6);
				}
				k++;
			}
		}
		
		private static string[][] _translations;
	}
}
