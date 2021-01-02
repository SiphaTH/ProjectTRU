using Terraria;
using Terraria.ID;

namespace CalamityRuTranslate.Mods.CalamityMod.NPCs
{
    internal static class NpcChatText
    {
	    public static void SetupTranslation()
        {
	        int dryad = NPC.FindFirstNPC(NPCID.Dryad);
	        int bartender = NPC.FindFirstNPC(NPCID.DD2Bartender);
			int stylist = NPC.FindFirstNPC(NPCID.Stylist);
			int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
			int angler = NPC.FindFirstNPC(NPCID.Angler);
			int merchant = NPC.FindFirstNPC(NPCID.Merchant);
			int armsDealer = NPC.FindFirstNPC(NPCID.ArmsDealer);
			int nurse = NPC.FindFirstNPC(NPCID.Nurse);
			int goblinTinkerer = NPC.FindFirstNPC(NPCID.GoblinTinkerer);
			int thief = NPC.FindFirstNPC(CoreCalamityTranslation.CalamityMod.NPCType("THIEF"));
			bool flag = Main.player[Main.myPlayer].talkNPC >= 0;

			switch (Main.npcChatText)
			{
				case "I deeply appreciate you rescuing me from being trapped within my frozen castle... It's been many, many years...":
					Main.npcChatText = "Я премного благодарен вам за спасение из заточения в моём ледяном замке... Прошло так много, много лет...";
					break;
				case "Thank you for saving me...though now I admit I am without a home since mine got destroyed.":
					Main.npcChatText = "Спасибо, что спасли меня... Теперь я признаю, что у меня нет дома, так как мой был разрушен.";
					break;
				case "I must admit...I am not quite used to this weather. It's too warm for my taste...":
					Main.npcChatText = "Должен признаться... Я не очень привык к такой погоде. Она, на мой взгляд, слишком тепла.";
					break;
				case "My dear! What is it you would like to talk about today?":
					Main.npcChatText = "Дружище! О чём бы вы хотели поговорить сегодня?";
					break;
				case "Why...I don't have to worry about any time of the day! If it is hot...then I can use my ice magic to cool down!":
					Main.npcChatText = "Почему... Я могу не беспокоиться о времени суток! Если будет жарко... то я могу использовать свою ледяную магию, чтобы остыть!";
					break;
				case "I do usually prefer a spot of humidity for my ice magic. It likes to come out as steam when it's too hot and dry...":
					Main.npcChatText = "Я предпочитаю места повлажнее для своей ледяной магии. Иначе она становится паром, если слишком жарко и сухо.";
					break;
				case "Magic is a skill that must be learned and practiced! You seem to have an inherent talent for it at your age. I have spent all of my life honing it...":
					Main.npcChatText = "Магия — это умение, которое нужно изучать и практиковать! Похоже, у тебя есть врождённый талант к ней в твоём возрасте. Я потратил всю свою жизнь на её оттачивание...";
					break;
				case "Why ice magic, you ask? Well, my parents were both pyromaniacs...":
					Main.npcChatText = "Почему ледяная магия, ты спрашиваешь? Ну, мои родители были пироманами...";
					break;
				case "There be monsters lurking in the darkness. Most...unnatural monsters.":
					Main.npcChatText = "В темноте прячутся чудовища. Наиболее... противоестественные чудовища.";
					break;
				case "You could break the icy stillness in the air tonight.":
					Main.npcChatText = "Ты можешь разрушить ледяную тишину этой ночью.";
					break;
				case "Hmm...some would say that an unforeseen outside force is the root of the blood moon...":
					Main.npcChatText = "Хм... Некоторые сказали бы, что невиданная сила снаружи это корень кровавой луны...";
					break;
				case "I was once the greatest Archmage of ice that ever hailed the lands. Whether or not that is still applicable, I am not sure...":
					Main.npcChatText = "Я был величайшем Архимагом льда, существовавшим когда-либо на этих землях. Применимо ли это звание сейчас? Не уверен...";
					break;
				case "There used to be other Archmages of other elements. I wonder where they are now...if they are also alive...":
					Main.npcChatText = "Раньше были и другие Архимаги стихий. Интересно, где они сейчас?.. Если они живы...";
					break;
				case "Oh...I wish I could tell you all about my life and the lessons I have learned, but it appears you have a great many things to do...":
					Main.npcChatText = "О... Я хотел бы рассказать вам всё о своей жизни и уроках, которые я выучил, но, похоже, у вас есть очень много дел...";
					break;
				case "I assure you, I will do my best to act as the cool grandfather figure you always wanted.":
					Main.npcChatText = "Уверяю вас, я сделаю всё возможное, чтобы стать тем крутым дедушкой, о котором вы всегда мечтали.";
					break;
				case "Sometimes...I feel like all I'm good for during these events is making ice cubes and slushies.":
					Main.npcChatText = "Иногда... Я чувствую, что всё, на что я годен во время этих событий — это делать кубики льда и коктейли.";
					break;
				case "Tread carefully, my friend... Now that the Moon Lord has been defeated, many powerful creatures will crawl out to challenge you...":
					Main.npcChatText = "Ступай осторожнее, мой друг... Теперь, когда Лунный лорд побеждён, многие могущественные существа выползут, чтобы бросить вам вызов...";
					break;
				case "I feel the balance of nature tilting farther than ever before. Is it due to you, or because of the events leading to now...?":
					Main.npcChatText = "Я чувствую, что баланс в природе сильно нарушен. Это из-за тебя, или события так сложились?..";
					break;
				case "I felt a sudden chill down my spine. I sense something dangerous stirring in the Abyss...":
					Main.npcChatText = "Я почувствовал неожиданный холодок, проходящий по моей спине. Я чувствую, что в бездне шевелится что-то опасное...";
					break;
				case "...Where is Lord Yharim? He must be up to something...":
					Main.npcChatText = "...Где Лорд Ярим? Должно быть, он что-то задумал...";
					break;
				case "What an adorable tiny companion you have! Where in the world did you find such a...creature...? Actually, I'd rather not know.":
					Main.npcChatText = "Какой очаровательный компаньон у вас есть! Где же вы нашли такое ...существо?.. Знаешь, я бы предпочёл не знать.";
					break;
				case "It wouldn't be the first time something unknown and powerful dropped from the heavens...I would tread carefully if I were you...":
					Main.npcChatText = "Это был не первый раз, когда что-то неизвестное и могущественное упало с небес... На вашем месте я бы действовал осторожно...";
					break;
				case "Why are you talking to me right now? Either way, I expect you to turn in a perfect performance!":
					Main.npcChatText = "Почему ты сейчас со мной разговариваешь? В любом случае я ожидаю, что ты устроишь невероятное выступление!";
					break;
				case "I could smell my vodka from MILES away!":
					Main.npcChatText = "Я могу почувствовать запах моей водки за много КИЛОМЕТРОВ отсюда!";
					break;
				case "Have any spare rooms available? Preferably candle-lit with a hefty supply of booze.":
					Main.npcChatText = "Есть ли свободные комнаты? Предпочтительно со свечами и с изрядным запасом спиртного.";
					break;
				case "Hey, nice night! I'm gonna make some Bloody Marys, celery included. Want one?":
					Main.npcChatText = "Хей, хорошая ночка! Я собираюсь сделать парочку Кровавых Мэри, конечно же, с сельдереями. Хочешь одну?";
					break;
				case "More blood for the blood gods!":
					Main.npcChatText = "Больше крови для богов крови!";
					break;
				case "Everyone else is so rude tonight. If they don't get over it soon, I'll break down their doors and make them!":
					Main.npcChatText = "Все остальные такие грубые сегодня. Если они не прекратят в ближайшее время, я выломаю их двери и заставлю их прекратить!";
					break;
				case "Being drunk, I have no moral compass atm.":
					Main.npcChatText = "Я в хлам, и моральный компас у меня не работает.";
					break;
				case "Nothard/10, if I fight bosses I wanna feel like screaming 'OH YES DADDY!' while I die repeatedly.":
					Main.npcChatText = "Если бы я сражалась с боссом, то я бы орала: 'О ДА ПАПОЧКА', — пока босс неоднократно меня убивает.";
					break;
				case "Like I always say, when you're drunk you can tolerate annoying people a lot more easily...":
					Main.npcChatText = "Как я всегда говорю, когда ты пьян, тебе гораздо легче переносить раздражающих людей...";
					break;
				case "I'm literally balls drunk off my sass right now.":
					Main.npcChatText = "Я пьяная в говно.";
					break;
				case "I'm either laughing because I'm drunk or because I've lost my mind. Probably both.":
					Main.npcChatText = "Я смеюсь или потому что пьяна, или потому что безумна. Возможно, и то и другое.";
					break;
				case "When I'm drunk I'm way happier...at least until the talking worms start to appear.":
					Main.npcChatText = "Когда я пьяна, я такая... счастливая... ну, по крайней мере, до тех пор, пока не начнут появляться говорящие черви.";
					break;
				case "I should reprogram the whole game while drunk and send it back to the testers.":
					Main.npcChatText = "Я должна перепрограммировать всю игру в пьяном виде и отправить её обратно тестировщикам.";
					break;
				case "What a great day, might just drink so much that I get poisoned again.":
					Main.npcChatText = "Какой замечательный день, может быть, я просто выпью так много, что снова отравлюсь.";
					break;
				case "A perfect night...for alcohol! First drinks are on me!":
					Main.npcChatText = "Прекрасная ночь... для бухлишка! Первая выпивка за мой счёт!";
					break;
				case "Here's a challenge...take a drink whenever you get hit. Oh wait, you'd die.":
					Main.npcChatText = "Вот тебе и вызов... пей за каждый удар, который ты получил. О, подожди, ты же умрёшь.";
					break;
				case "Well I was planning to light some candles in order to relax...ah well, time to code while drunk.":
					Main.npcChatText = "Ну, я планировала зажечь несколько свечей, чтобы расслабиться...Ну что же, пора кодить пока пьяна.";
					break;
				case "Yes, everyone knows the mechworm is buggy. Well, not so much anymore, but still.":
					Main.npcChatText = "Да, все знают, что механический червь глючит. Ну, уже не так много, но всё же.";
					break;
				case "Are you sure you're 21? ...alright, fine, but don't tell anyone I sold you this.":
					Main.npcChatText = "Ты уверен, что тебе 21 год?.. хорошо, хорошо, только не говори никому, что я продала тебе это.";
					break;
				case "Drink something that turns you into a magical flying unicorn so you can be super gay.":
					Main.npcChatText = "Выпей что-нибудь, что превратит тебя в волшебного летающего единорога, чтобы ты мог быть супервесёлым.";
					break;
				case "Did anyone ever tell you that large assets cause back pain? Well, they were right.":
					Main.npcChatText = "Кто-нибудь когда-нибудь говорил вам, что большие активы вызывают боль в спине? Что ж, они были правы.";
					break;
				case "You'll always find me at parties where booze is involved...well, you'll always find booze where I'm involved.":
					Main.npcChatText = "Ты всегда найдёшь меня на вечеринках, где замешана выпивка... ну, там, где я замешана, ты всегда найдёшь выпивку.";
					break;
				case "Shoot down the space invaders! Sexy time will be postponed if we are invaded by UFOs!":
					Main.npcChatText = "Сбивай космических захватчиков! Время интима будет отложено, если на нас нападут НЛО!";
					break;
				case "God I can't wait to beat on some ice again!":
					Main.npcChatText = "Боже, я не могу дождаться, когда снова вмажу льду!";
					break;
				case "The only things I'm attracted to are fish women, women, men who look like women and that's it.":
					Main.npcChatText = "Единственное, что меня привлекает, - это женщины-рыбы, женщины, мужчины, которые выглядят как женщины и всё.";
					break;
				case "I'll always be watching.":
					Main.npcChatText = "Я всегда буду наблюдать.";
					break;
				case "Why did that weird monster need that many tentacles? ...actually, don't answer that.":
					Main.npcChatText = "Зачем этому странному монстру понадобилось столько щупалец?.. вообще, не отвечай на этот вопрос.";
					break;
				case "There's chemicals in the water...and they're turning the frogs gay!":
					Main.npcChatText = "Химикаты в воде... они превращают лягушек в геев.";
					break;
				case "I saw a ghost down by the old train tracks once, flailing wildly at the lily pads, those were the days.":
					Main.npcChatText = "Однажды я видел привидение у старых железнодорожных путей, дико размахивающее кувшинками, вот это были деньки.";
					break;
				case "I hear it's amazing when the famous purple-stuffed worm out in flap-jaw space, with the tuning fork, does a raw blink on Hara-kiri rock. I need scissors! 61!":
					Main.npcChatText = "Я слышала, что это потрясающе, когда знаменитый фиолетовый червяк с челюстями, с камертоном появляется на мгновение на скале Харакири. Мне нужны ножницы! 61!";
					break;
				case "I never realized how well-endowed Пермафрост was. It had to be the largest icicle I had ever seen.":
					Main.npcChatText = "Я никогда не осознавала, насколько же Пермафрост одарён. Это была самая большая сосулька, которую я видела.";
					break;
				case "Is that a toy? Looks like something I'd carry around if I was 5 years old.":
					Main.npcChatText = "Это что, игрушка? Похоже, что-то такое, что я бы носила с собой, если бы мне было 5 лет.";
					break;
				case "Nice scales...did it get hot in here?":
					Main.npcChatText = "Классная чешуя... Мне кажется или здесь стало жарче?";
					break;
				case "Oh yeah, now you're drinking the good stuff! Do you like it? I created the recipe by mixing fairy dust, crystals and other magical crap.":
					Main.npcChatText = "О, теперь ты пьёшь нормальное пойло! Понравилось? Я сделала этот рецепт, смешивая пыльцу, кристаллы и другую магическую хрень.";
					break;
				case "So...you're riding me, huh? That's not weird at all.":
					Main.npcChatText = "Так...ты на мне катаешься, да? Это совсем не странно.";
					break;
				case "Are you coming on to me?":
					Main.npcChatText = "Ты ко мне пристаёшь?";
					break;
				case "If I was a magical horse, I'd be out in space, swirling cocktails, as I watch space worms battle for my enjoyment.":
					Main.npcChatText = "Если я была бы пони, то я была бы в космосе, окружённым вихрями коктейлей и наблюдал бы за космическими червями, сражающемся на моё удовольствие.";
					break;
				case "Is this...what the world is like now? It seems so much more lifeless than when I saw it before I disappeared.":
					Main.npcChatText = "Что... что произошло с миром? Он, кажется, гораздо более безжизненным, чем когда я видел его перед тем, как исчезнуть.";
					break;
				case "Thank you for your service, my child, but I am afraid I am without a home now.":
					Main.npcChatText = "Спасибо за вашу помощь, дитя, но я боюсь, что я теперь бездомный.";
					break;
				case "My homeland may have dried up but the memories of my people still remain. I will not let them be in vain.":
					Main.npcChatText = "Моя родина, возможно, иссохла, но воспоминания о моём народе всё ещё жива. Я не позволю им быть напрасными.";
					break;
				case "There is a lot that you do not know about this world, specifically regarding the past. Much of it has been lost to history due to the many wars that plagued it.":
					Main.npcChatText = "Есть много такого, чего вы не знаете об этом мире, особенно о прошлом. Большая часть истории прошлого была потеряна из-за многочисленных войн, которые отравляли его.";
					break;
				case "How can I survive on land? Ah, that is a secret. No, actually...I can breathe air like you!":
					Main.npcChatText = "Как я могу выжить на суше? Ах, это секрет. Вообще-то, нет... Я могу дышать воздухом, как ты!";
					break;
				case "Why do you ask if it's the males that carry the young? Don't your males carry their young?":
					Main.npcChatText = "Почему ты спрашиваешь, не самцы ли вынашивают детёнышей? Разве ваши мужчины не носят своих детёнышей?";
					break;
				case "Most creatures look up at the moon and admire it. I look up and fear it.":
					Main.npcChatText = "Большинство существ смотрят на луну и восхищаются ею. Я смотрю вверх и боюсь.";
					break;
				case "Oh, me? I don't sleep, it's part of my nature.":
					Main.npcChatText = "А, я? Я не сплю, это часть моего естества.";
					break;
				case "Rumor has it Циррус drinks to forget her troubled past.":
					Main.npcChatText = "Слухи говорят о том, что Циррус пьёт, чтобы забыть своё проблемное прошлое.";
					break;
				case "I'm never keen on these nights. They're so violent.":
					Main.npcChatText = "Я никогда не интересовался такими ночами. Они такие жестокие.";
					break;
				case "Ah, nice duds, my child!":
					Main.npcChatText = "Ах, славные шмотки, дитя моё!";
					break;
				case "Shouldn't you be wearing a clam bra?":
					Main.npcChatText = "Не следует ли тебе стоит надеть бюстгальтер из моллюсков?";
					break;
				case "The balance between light and dark is tipping. Stay strong, my child.":
					Main.npcChatText = "Равновесие между светом и тьмой нарушается. Будь сильным, дитя моё.";
					break;
				case "Ah, you are starting to realize just how complicated this world is now. You are learning the story of what became of him.":
					Main.npcChatText = "Ах, вы начинаете понимать, насколько сложён этот мир. Вы узнаёте историю того, что с ним стало.";
					break;
				case "Do you ever get the feeling that something out there is watching you very carefully? Whatever it is, it's very small and sly, I think.":
					Main.npcChatText = "У вас никогда не возникало ощущения, что кто-то очень внимательно наблюдает за вами? Что бы это ни было, оно очень маленькое и хитрое, я думаю.";
					break;
				case "I must admit, I am quite shaken up now. Never would I have imagined that I would see one of the dark gods again. Not in this lifetime anyhow.":
					Main.npcChatText = "Должен признаться, я сейчас потрясён. Никогда бы я не подумал, что снова увижу одного из тёмных богов. Во всяком случае, не в этой жизни.";
					break;
				case "Times like this I wish my home was still in one piece instead of evaporated away. I don't blame the witch for anything, it's just...oh, never mind.":
					Main.npcChatText = "В такие моменты мне хочется, чтобы мой дом был цел и невредим. Я ни в чём не виню ведьму, просто... о, не обращай внимания.";
					break;
				case "I suppose that witch was mistaken. Defeating the Ceaseless Void and the Devourer has not caused our world to collapse... but I would not lower my guard if I were you.":
					Main.npcChatText = "Наверное, ведьма ошиблась. Победа над Нескончаемой пустотой и Пожирателем не привела к краху нашего мира... но на твоём месте я бы не стал терять бдительность.";
					break;
				case "The Crimson used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.":
					Main.npcChatText = "Багрянец раньше легко управлялся природой. Однако недавние войны и загрязнение окружающей среды пошатнули баланс.";
					break;
				case "The Corruption used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.":
					Main.npcChatText = "Искажение раньше легко управлялось природой. Однако недавние войны и загрязнение окружающей среды пошатнули баланс.";
					break;
				case "If this shows up, something went wrong.":
					Main.npcChatText = "Если это обнаружится, значит, что-то пошло не так.";
					break;
				case "Draedon's style of confrontation is very...alien and hands-off. You may be more likely to fight any one of his mechs before taking him down.":
					Main.npcChatText = "Стиль боя Дрейдона очень... чужд и выходит из ряда вон. Тебе, скорее всего, придётся сразиться с какой-нибудь из его машин, прежде чем убить его.";
					break;
				case "Lord Yharim possesses god-like strength. He may not even fight you at full power which is fortunate for you. His attacks may just kill you in one hit, so be careful.":
					Main.npcChatText = "Лорд Ярим обладает божественной силой. Он может даже не сражаться с вами в полную силу, что очень хорошо для вас. Его атаки могут убить вас одним ударом, так что будьте осторожны.";
					break;
				case "Pockets of ore have appeared once more in the land. This will allow you to create the most powerful weaponry and armor imagined!":
					Main.npcChatText = "В земле вновь появились некоторые руды. Это позволит вам создать самое мощное оружие и броню, какие вы только можете себе представить!";
					break;
				case "Ah, the dragon Yharon is fickle. You may find that he will refuse to use his full power unless you are strong enough to unleash the power of the Dark Sun.":
					Main.npcChatText = "Ах, дракон Ярон переменчив. Ты можешь обнаружить, что он, возможно, откажется использовать свою полную силу, если вы не будете достаточно сильны, чтобы высвободить силу тёмного солнца.";
					break;
				case "The Devourer of Gods is extremely powerful. However, he is young, foolhardy, and very lazy. Perhaps if he had been given time to develop he would have turned into quite the threat.":
					Main.npcChatText = "Пожиратель богов невероятно могущественный. Однако он молод, безрассуден и очень ленив. Возможно, если ему позволить вырасти ещё немного и натренировать свои способности, он станет силой, с которой придётся считаться.";
					break;
				case "With the cosmic steel you can fashion many of your weapons into much more powerful forms.":
					Main.npcChatText = "Имея космическую сталь, ты можешь создавать и комбинировать своё оружие в чрезвычайно мощные и полезные предметы.";
					break;
				case "The Devourer of God's cosmic armor is unique in that it is capable of not only protecting his body from tearing itself apart when ripping through the fabric of space and time, but also allows him to control his powers.":
					Main.npcChatText = "Космическая броня Пожирателя Богов уникальна тем, что способна не только защитить тело от разрыва на части при открытии разломов в пространстве и времени, но и позволяет ему контролировать свои силы.";
					break;
				case "Ah...I can sense a powerful change in the weather. You may want to venture to the Sulphurous Seas once more during the rain to experience it.":
					Main.npcChatText = "Ах... Я чувствую сильную перемену в погоде. Возможно, вы захотите отправиться в сернистые моря ещё раз во время дождя, чтобы испытать это.";
					break;
				case "The Abyss holds many secrets revealed with time. Checking it out again may not be a bad idea.":
					Main.npcChatText = "Бездна хранит много тайн, открытых со временем. Проверить их ещё раз, возможно, не такая уж плохая идея.";
					break;
				case "The Dungeon seems to be more active now. You may hear the faint whisperings of angry spirits who have not left to the Void...I would recommend searching there before taking on the Sentinels.":
					Main.npcChatText = "Похоже, что темница активизировалась. Ты можешь услышать слабый шёпот разгневанных духов, не ушедших в Пустоту... Я бы порекомендовал заглянуть туда прежде, чем браться за Стражей.";
					break;
				case "Ironic, is it not, that Statis was defeated by the very Sentinel his people fashioned their art of stealth from. Fate so often weaves cruel tales.":
					Main.npcChatText = "Иронично, что Статис потерпел поражение от того самого стража, из которого его народ создал своё искусство скрытности. Судьба так часто бывает жестокой.";
					break;
				case "The Rune of Kos holds a significant portion of Providence's brand of magic, easily distinguishable from all others. Activating it in certain places would have some...risky consequences.":
					Main.npcChatText = "Руна Кос содержит значительную часть магии Провиденс, легко отличимую от всех остальных. Активация его в определённых местах будет иметь некоторые последствия... рискованные последствия.";
					break;
				case "The stories have it that when Providence faced and defeated Yharim and his forces she lost a lot of energy and reverted to a more skeletal form. She's merely a fraction of the power she was before.":
					Main.npcChatText = "Рассказывают, что когда Провиденс столкнулось с Яримом и его войсками и победила их, она потеряла много энергии и вернулась в более скелетообразную форму. Она всего лишь часть той силы, которой была раньше.";
					break;
				case "Providence is as much the sun goddess as much as the Moon Lord is the moon god. They are two sides of the same coin, choosing to remain neutral amongst our petty squabbles.":
					Main.npcChatText = "Провиденс настолько богиня солнца, насколько Лунный лорд — бог луны. Они — две стороны одной монеты, предпочитающие занимать нейтральную позицию в наших мелких ссорах.";
					break;
				case "Touching Providence's offerings is usually a death wish. Shame that Yharim didn't think to just mess with her things to get her out of hiding.":
					Main.npcChatText = "Прикосновение к подношениям Провиденс обычно смертельно. Позорно, что Ярим не додумался просто потрогать её вещи, чтобы выманить её из укрытия.";
					break;
				case "The Profaned Guardians will do anything to protect their goddess. Makes sense they would die for her since they can be revived just as quickly.":
					Main.npcChatText = "Осквернённые стражи сделают всё, чтобы защитить свою богиню. Они умрут за неё, ведь их можно оживить очень быстро.";
					break;
				case "Profaned creatures now lurk in the Hallow and in Hell. If you destroy enough and gather their essence together you shall be able to capture the attention of the Profaned Guardians.":
					Main.npcChatText = "Осквернённые существа теперь скрываются в освящении и в аду. Если вы уничтожите достаточно и соберёте их сущность вместе, вы сможете привлечь внимание осквернённых стражей.";
					break;
				case "Your adventure focuses to the jungle it seems. The Dragonfolly and its swarming offspring should be eliminated before their numbers spiral out of control.":
					Main.npcChatText = "Кажется, ваше приключение сосредотачивается на джунглях. Вам следует уничтожить Псевдодракона и его отпрысков пока их количество не вышло из под контроля.";
					break;
				case "The plague was just one of the many experiments authorized by Yharim to raze towns to the ground. This is probably one of the few he shelved for being too terrible.":
					Main.npcChatText = "Чума была лишь одним из немногих экспериментов Ярима по стиранию городов с лица земли. Возможно, этот эксперимент — один из немногих, отложенных Лордом в долгий ящик, потому что он был слишком ужасен.";
					break;
				case "The Abyss has become far more active than before. You might be able to mine some of the volcanic rubble contained within.":
					Main.npcChatText = "Бездна стала гораздо более активной, чем раньше. Возможно, вам удастся добыть часть вулканических обломков, находящихся внутри.";
					break;
				case "The men at the front of the dungeon are performing a ritual to keep the Moon Lord contained in his prison. In order to gain Yharim's attention, however, you may need to defeat them.":
					Main.npcChatText = "Люди на входе в темницу проводят ритуал сдерживания Лунного Лорда в заточении. Однако, чтобы привлечь внимание Ярима тебе, скорее всего, придётся убить их.";
					break;
				case "When exploring the jungle temple be careful. You may not wish to disturb the Lihzard's idol, the Golem. It's quite the destructive force.":
					Main.npcChatText = "Будьте осторожны пока исследуете джунгли. Я сомневаюсь, что вы захотите потревожить божество ящщеров, Голема. Это довольно разрушительная сила.";
					break;
				case "Be careful when defeating Plantera and the Golem. You might accidentally unleash a new threat in the jungle that needs to be quelled.":
					Main.npcChatText = "Будьте осторожны при уничтожении Плантеры или Голема. Вы можете выпустить новую угрозу в джунгли, которую нужно будет уничтожить.";
					break;
				case "If you've gathered the souls used to power those automatons head once more to the jungle. You will find a powerful enemy to fight, which will unleash the full fervor of the jungle once defeated. Do not underestimate it!":
					Main.npcChatText = "Если вы собрали души, используемые для питания этих автоматов, отправляйтесь ещё раз в джунгли. Вы найдёте могущественного врага, которая выпустит всю силу джунглей, как только будет побеждена. Не стоит недооценивать её!";
					break;
				case "The Brimstone Crags...Yharim despised that place, and did everything he could to raze it to the ground. It might explain a few things about him.":
					Main.npcChatText = "Серные скалы... Ярим никогда не любил это место и делал всё возможное, чтобы стереть его с лица земли. Это может сказать некоторые вещи о нём.";
					break;
				case "If you take an idol down to the Brimstone Crags you might be able to see just what is lurking in the shadows.":
					Main.npcChatText = "Если вы возьмёте идол в серные скалы, то вы сможете увидеть скрывающиеся в тенях существо.";
					break;
				case "Once those mechanical creations have been defeated you would do well to seek out the crippled clone of the witch, Calamitas. It might provide some useful weaponry.":
					Main.npcChatText = "Когда механические создания будут повержены, вам следует хорошо поискать в ночи, чтобы найти изуродованного клона ведьмы, Каламитас. Победа над ней позволит вам создать мощное оружие.";
					break;
				case "I would recommend saving some of your old items. You never know if you can engineer them into stronger weapons in the future.":
					Main.npcChatText = "Я рекомендую сохранить свои старые предметы. Никогда не знаешь, можно ли сотворить из них сильное оружие в будущем.";
					break;
				case "Have you heard of the story of Archmage Permafrost? Rumor has it he's been locked away in an icy prison by Lord Yharim. Perhaps you would be able to free him if Cryogen was destroyed.":
					Main.npcChatText = "Ты слышал историю об архимаге Пермафросте? Ходят слухи, что он был заперт в своей ледяной тюрьме Лордом Яримом. Я думаю, что ты сможешь его освободить после того, как уничтожишь Криогена.";
					break;
				case "You will find more ores have been unlocked due to the magic sealing them away being dispelled. Some of them may require more than just the ore itself to create.":
					Main.npcChatText = "Вы обнаружите, что больше руд станет доступно, так как магия, запечатывающая их, разрушена. Чтобы создать что-то из некоторых таких, можешь потребоваться больше, чем просто руда.";
					break;
				case "Throughout the world lie various structures left behind by Draedon. Archaic defenses may remain, but the goods inside may be worth your while.":
					Main.npcChatText = "По всему миру расположены различные сооружения, оставленные Дрейдоном. Архаичная система обороны возможно осталась, но предметы, находящиеся внутри, могут стоить потраченных усилий.";
					break;
				case "The dungeon is a dark place. None of us know of its true purpose, however, the ancient Eidolist cultists used it for worship before Lord Yharim took it over.":
					Main.npcChatText = "Темница — тёмное место. Никто из нас не знает его истинного назначения, однако древние фантомные культисты использовали его для поклонения до того, как им завладел Лорд Ярим.";
					break;
				case "I'm assuming you've heard the legends that speak of the ninja, Statis? There are some who say that if you were able to defeat the gods which his clan once worshipped you would be able to harness some of his powers.":
					Main.npcChatText = "Я полагаю, вы слышали легенды о ниндзе Статисе? Некоторые говорят, что если бы ты смог победить богов, которым когда-то поклонялся его клан, то смог бы использовать некоторые из его сил.";
					break;
				case "Scattered across the lands are shrines dedicated to the gods. You can take whatever is in them, but a few items you may not be able to use until much later.":
					Main.npcChatText = "По всей земле разбросаны святыни, посвящённые богам. Вы можете взять всё, что в них есть, но некоторые предметы вы не сможете использовать некоторое время.";
					break;
				case "Be careful what you attack in the Crimson. You might just unveil a greater threat than what was there before.":
					Main.npcChatText = "Будь осторожен, когда атакуешь что-то в багрянце. Ты можешь высвободить куда большую угрозу, чем раньше.";
					break;
				case "Be careful what you attack in the Corruption. You might just unveil a greater threat than what was there before.":
					Main.npcChatText = "Будь осторожен, когда атакуешь что-то в искажении. Ты можешь высвободить куда большую угрозу, чем раньше.";
					break;
				case "The Sulphurous Seas were created long ago, when Yharim's dungeon could no longer hold as many corpses as it needed to. Many of the bodies were dumped into the ocean. This, along with severe pollution from the heydays of Draedon's experiments have turned a paradise into a wasteland.":
					Main.npcChatText = "Сернистые моря были созданы давным-давно, когда темница Ярима уже не могла вместить столько трупов, сколько требовалось. Многие тела были сброшены в океан. Это, как и загрязнения, вызванные исследованиями Дрейдона, превратили рай в пустошь.";
					break;
				case "The Sulphurous Seas are dangerous. The toxic waters will burn your skin, but if you can brave them you will be able to reach the Abyss, where there are powerful weapons and dangers aplenty.":
					Main.npcChatText = "Сернистые моря опасны. Ядовитые воды сожгут вашу кожу, но если вы будете достаточно отважны, то сможете достичь бездны, где есть мощное оружие и множество опасностей.";
					break;
				case "Ah yes, the Abyss. That trench is full of powerful creatures that could devour you in a heartbeat. I would explore the dungeon first.":
					Main.npcChatText = "Ах да, бездна. Эта траншея полна могущественных существ, которые могут сожрать тебя в мгновение ока. На твоём месте я бы сначала исследовал темницу.";
					break;
				case "Have you heard of the Brimstone Crags? It was once a grand kingdom, not too different from my own. However, it also met a similar fate. I would not advise going down there, unless you seek a painful death.":
					Main.npcChatText = "Вы слышали о серных скалах? Однажды это было великое королевство, которое не сильно отличалось от моего. Однако, его постигла та же участь. Я бы не советовал спускаться туда, если только вы не ищете мучительной смерти.";
					break;
				case "There are rumors of ores that lay in latency. When you defeat certain bosses you will undo the ancient magic which conceals those materials.":
					Main.npcChatText = "Ходят легенды о рудах, находящихся в неактивном состоянии. Когда ты победишь определённых боссов, ты можешь отменить их магию, скрывающую эти материалы.";
					break;
				case "Oy, watch where you're going or I might just use you for dart practice.":
					Main.npcChatText = "Эй, смотри куда идёшь, или я могу использовать тебя в качестве мишени для тренировки в дартс.";
					break;
				case "Bet you'd look good as a pincushion, amiright?":
					Main.npcChatText = "Спорим, ты бы хорошо смотрелся в качестве мальчика для битья?";
					break;
				case "Zombies don't dodge very well. Maybe you'll do a bit better.":
					Main.npcChatText = "Зомби не очень хорошо уворачиваются. Может быть, у тебя получится немного лучше.";
					break;
				case "Hey, careful over there. I've rigged the place. One wrong step and you're going to get a knife in your forehead.":
					Main.npcChatText = "Эй, аккуратнее тут. Я расставила ловушки повсюду. Один неправильный шаг и получишь ножом в лоб.";
					break;
				case "You know what's really cool? Watching the glint of throwing stars as they reflect the moon.":
					Main.npcChatText = "Знаешь, что действительно круто? Наблюдать за отражением луны в метательных звёздах.";
					break;
				case "You think those stars that fall occasionally would make good throwing weapons?":
					Main.npcChatText = "Как думаешь, из звёзд, которые иногда падают, можно сделать хорошие метательные оружия?";
					break;
				case "Statis' clan's got nothing on me. Mostly cause they're all dead.":
					Main.npcChatText = "У клана Статиса ничего на меня нет. В основном потому что они все мертвы.";
					break;
				case "Where is my party hat? Well, I stole it of course.":
					Main.npcChatText = "Как я получила праздничную шапку? Конечно же, я её украла.";
					break;
				case "The nice thing about maps is I can track anything that has fallen.":
					Main.npcChatText = "Самое приятное в карте — способность отслеживания всего, что упало.";
					break;
				case "Imagine how fast you could throw if you just had more hands.":
					Main.npcChatText = "Представь себе, как быстро ты бы смог метать, если бы у тебя было больше рук.";
					break;
				case "I also take food for currency.":
					Main.npcChatText = "Я также принимаю еду в качестве валюты.";
					break;
				case "Usually I only think of animals as food or target practice, but dragons are an exception.":
					Main.npcChatText = "Обычно я думаю о животных только как о пище или мишени, но драконы — исключение.";
					break;
				case "Anything is a weapon if you throw it hard enough.":
					Main.npcChatText = "Всё является оружием, если швырнёшь достаточно сильно.";
					break;
				case "That's your chucking arm? You need to work out more.":
					Main.npcChatText = "И это твоё предплечье? Тебе нужно больше тренироваться.";
					break;
				case "Listen here. It's all in the wrist, the wrist! Oh, forget it.":
					Main.npcChatText = "Слушай сюда. Весь секрет в запястье, запястье! А впрочем забудь.";
					break;
				case "I don't think Mom and Dad are proud of the job I have right now.":
					Main.npcChatText = "Не думаю, что мама и папа гордятся моей работой.";
					break;
				case "Eh you know how it goes; steal from the rich, give to the poor. Of course, for a price.":
					Main.npcChatText = "Эх, ты знаешь, как это работает; крадёшь у богатого, даёшь бедному. Конечно, не бесплатно.";
					break;
				case "Want to hear about this one time I was stuck in a room with a rabid dog and a dead guy?":
					Main.npcChatText = "Хочешь услышать, как однажды я застрял в комнате с бешеной псиной и трупаком?";
					break;
				case "Argh snakes. For some reason it's always snakes.":
					Main.npcChatText = "Бр-р-р змеи. Почему это постоянно змеи.";
					break;
				case "Maybe I'm bitter. It's been a long time, so whatever. Just do a good job out there.":
					Main.npcChatText = "Может быть, я жестокая. Я всегда такая, так что не обессудь. Просто сделай хорошую работу там.";
					break;
				case "It's not stealing! I'm just borrowing it until I die!":
					Main.npcChatText = "Это не воровство! Я просто позаимствую его, пока не умру!";
					break;
				case "Wouldn't be the first time I used my friends' remains as weapons.":
					Main.npcChatText = "Не в первый раз я использую останки моих друзей в качестве оружия.";
					break;
				case "With all of this new stuff cropping up, looks like we got some easy loot and new items to craft up, eh? Well, YOU craft them, I'll steal em.":
					Main.npcChatText = "С появлением новых материалов мы с лёгкостью можем сделать новые виды оружия. Ну как мы, ты, а я сворую их у тебя.";
					break;
				case "Draedon thinks he can build awesome machines, but he doesn't know how much crap I've stolen from him and sold by dismantling his drones.":
					Main.npcChatText = "Дрейдон думает, что он может строить потрясающие машины, но не знает, сколько барахла я наворовала у него и продала, путём уничтожения его же дронов.";
					break;
				case "Gramma always said never to invade ancient temples or you'll be cursed and die. Let's say both of us attest that is untrue. We're still alive. Somewhat.":
					Main.npcChatText = "Бабушка говорила никогда не вторгаться в древние храмы, иначе ты будешь проклят и умрёшь. Будем честны, мы оба испытали это проверили. Мы все ещё живы. В каком-то смысле.";
					break;
				case "I heard that there's some really neat and awesome rogue items you can get. Show em to me if you ever get the time.":
					Main.npcChatText = "Я слышал, что есть некоторые действительно аккуратные и потрясающие разбойничьи предметы, которые ты можешь получить. Покажи их мне, если у тебя будет время.";
					break;
				case "Providence HATES it when you take her stuff. I learned that the hard way.":
					Main.npcChatText = "Провиденс НЕНАВИДИТ, когда ты берёшь её вещи. Я узнала это на собственном горьком опыте.";
					break;
				case "You think I can get away with looting from ghosts? It ain't like they can pick things up.":
					Main.npcChatText = "Думаешь, мне сойдёт с рук грабёж у призраков? Не похоже, чтобы они могли что-то поднять.";
					break;
				case "Oh man, did you rip that off a shark!? Now that's a weapon!":
					Main.npcChatText = "О, чувак, ты вырвал это у акулы!? Вот это оружие!";
					break;
				case "I tried looting Storm Weaver's armor once. Before I could get a chunk of the stuff... well let's just say the bigger, fatter cosmic worm arrived and it didn't end well.":
					Main.npcChatText = "Я однажды попыталась получить броню Штормового Ткача. До того, как я смогла достать хотя бы кусок этой вещи... давай просто скажем, что появился большой толстый космический червь и это всё кончилось печально.";
					break;
				case "I'd rather not be here. This place has bad vibes, y'know? It brings back some unpleasant memories.":
					Main.npcChatText = "Я бы не хотела быть здесь. В этом месте царит плохая атмосфера, знаешь ли? Возвращает некоторые неприятные воспоминания.";
					break;
				case "I learned never to steal Циррус's drinks. She doesn't appreciate me right now so I'll go back to hiding.":
					Main.npcChatText = "Я научась никогда не красть выпивку Циррус. Сейчас она меня ненавидит, так что я снова буду прятаться.";
					break;
				case "Hey, if government officials can get tax, why can't I? The heck do you mean that these two things are nothing alike?":
					Main.npcChatText = "Эй, если государственные чиновники могут получать налоги, то почему я не могу? Чёрт возьми, ты хочешь сказать, что это разные вещи?";
					break;
				case "Sorry, I got nothing. Perhaps you could reforge something and come back later...":
					Main.npcChatText = "Извини, у меня ничего нет. Возможно, ты что-то перекуёшь и вернёшься позже...";
					break;
				case "Each night seems only more foreboding than the last. I feel unthinkable terrors are watching your every move.":
					Main.npcChatText = "Каждая ночь кажется лишь более зловещей, чем предыдущая. Я чувствую, что немыслимые ужасы следят за каждым твоим шагом.";
					break;
				case "Are you daft?! Turn off those lamps!":
					Main.npcChatText = "Ты что, придурок? Выключи эти лампы!";
					break;
				case "If this acid rain keeps up, there'll be a shortage of Dirt Blocks soon enough!":
					Main.npcChatText = "Если кислотный дождь не прекратится, то очень скоро возникнет нехватка земли!";
					break;
				case "I happen to have several Angel Statues at the moment, a truely rare commodity. Want one?":
					Main.npcChatText = "Так получилось, что на данный момент у меня есть несколько действительно редких товаров — статуи ангелов. Хотите одну?";
					break;
				case "The caverns have become increasingly dark as of late, so I stocked up on some special torches if you have the funds.":
					Main.npcChatText = "Пещеры в последнее время стали всё темнее, поэтому я запасся факелами и готов тебе их продать, если у тебя есть монеты.";
					break;
				case "That's the biggest moth I've ever seen for sure. You'd need one big gun to take one of those down.":
					Main.npcChatText = "Это самая большая бабочка, которую я когда-либо видел. Вам понадобится большая пушка, чтобы уничтожить одну из них.";
					break;
				case "Is it me or are your weapons getting bigger and bigger?":
					Main.npcChatText = "Это я или твоё оружие становится всё больше и больше?";
					break;
				case "There's a dark solar energy emanating from the moths that appear during this time. Ah, the moths as you progress further get more powerful...hmm...what power was Yharon holding back?":
					Main.npcChatText = "Существует тёмная солнечная энергия, исходящая от мотыльков, которые появляются в это время. Ах, мотыльки по мере того, как вы продвигаетесь дальше, становятся всё более мощными... что за силу сдерживает Ярон?";
					break;
				case "That starborne illness sits upon this land like a blister. Do even more vile forces of corruption exist in worlds beyond?":
					Main.npcChatText = "Болезнь звёзд заразила эти земли. Существуют ли ещё более гнусные силы разложения в потусторонних мирах?";
					break;
				case "Циррус put me up to this.":
					Main.npcChatText = "Циррус меня подставила.";
					break;
				case "My ancestor was lost here long ago. I must pay my respects to her.":
					Main.npcChatText = "Мой предок погиб здесь давным-давно. Я должен отдать ей своё почтение.";
					break;
				case "\u0093I'm not here for any reason! Just picking up mushrooms for uh, later use.":
					Main.npcChatText = "Я здесь не по какой-то причине! Просто собираю грибы для последующего использования.";
					break;
				case "Could you be so kind as to, ah...check hell for me...? I left someone I kind of care about down there.":
					Main.npcChatText = "Не могли бы вы быть так любезны проверить ад для меня?.. Я оставил там кое-кого, кто мне небезразличен.";
					break;
				case "I have this sudden shiver up my spine, like a meteor just fell and thousands of innocent creatures turned into monsters from the stars.":
					Main.npcChatText = "У меня вдруг по спине пробежала дрожь, как будто только что упал метеорит и тысячи невинных созданий превратились в монстров со звёзд.";
					break;
				case "The dungeon seems even more restless than usual, watch out for the powerful abominations stirring up in there.":
					Main.npcChatText = "Темница кажется ещё более беспокойной, чем обычно, следи за мощными тварями, шевелящиеся там.";
					break;
				case "Seems like extinguishing that butterfly caused its life to seep into the hallowed areas, try taking a peek there and see what you can find!":
					Main.npcChatText = "Похоже, что охлаждение этой бабочки заставило её жизнь просочиться в священные области, попробуйте заглянуть туда и посмотреть, что вы можете найти!";
					break;
				case "I've heard there is a portal of antimatter absorbing everything it can see in the dungeon, try using the Rune of Kos there!":
					Main.npcChatText = "Я слышал, что есть портал антиматерии, поглощающий всё, можно встретить в темнице, попробуйте использовать руну кос там!";
					break;
				case "God Slayer Dynamite? Boy do I like the sound of that!":
					Main.npcChatText = "Динамит богоубийства? Парень, мне нравится как это звучит!";
					break;
				case "Who you gonna call?":
					Main.npcChatText = "Кому вы собираетесь звонить?";
					break;
				case "Those screams...I'm not sure why, but I feel like a nameless fear has awoken in my heart.":
					Main.npcChatText = "Эти крики... Я не уверен почему, но чувствую как безызвестный страх пробуждается в моём сердце.";
					break;
				case "I can faintly hear ghostly shrieks from the dungeon...and not ones I'm familiar with at all. Just what is going on in there?":
					Main.npcChatText = "Я едва слышу призрачные крики, доносящиеся из темницы... и совсем не те, которые я слышал. Что там происходит?";
					break;
				case "Whatever that thing was, I'm glad it's gone now.":
					Main.npcChatText = "Что бы это ни было, я рад, что оно ушло.";
					break;
				case "Houston, we've had a problem.":
					Main.npcChatText = "Хьюстон, у нас проблема.";
					break;
				case "You know...we haven't had an invasion in a while...":
					Main.npcChatText = "Вы знаете... у нас давно не было нашествий...";
					break;
				case "I'd let Пермафрост coldheart MY icicle.":
					Main.npcChatText = "Я бы позволил Пермафросту охладить Мою сосульку.";
					break;
				case "Space just got way too close for comfort.":
					Main.npcChatText = "Космос слишком тесный для комфорта.";
					break;
				case "What do you mean your traps aren't making the cut? Don't look at me!":
					Main.npcChatText = "Что ты имеешь в виду, говоря, что мои ловушки бесполезны? Не смотри так на меня!";
					break;
				case "Um...should my nightlight be on?":
					Main.npcChatText = "Эм... должен ли мой ночник быть включён?";
					break;
				case "Well, I like Циррус, but I, ah...I have my eyes on someone else.":
					Main.npcChatText = "Ну, мне нравится Циррус, но мне... мне нравится кое-кто другой.";
					break;
				case "Maybe I should've waterproofed my gadgets... They're starting to corrode.":
					Main.npcChatText = "Может, мне стоило гидроизолировать мои гаджеты... Они начинают ржаветь.";
					break;
				case "I don't feel very safe; I think there's pigs following me around and it frightens me.":
					Main.npcChatText = "Я не чувствую себя в безопасности; Я думаю, свиньи преследуют меня, и это пугает меня.";
					break;
				case "Sometimes, Циррус just looks at me funny and I'm not sure how I feel about that.":
					Main.npcChatText = "Иногда Циррус забавно смотрит на меня, и я неуверен как мне реагировать на это.";
					break;
				case "Just what is that contraption? It makes my Teleporters look like child's play!":
					Main.npcChatText = "Что же это за штуковина? Это делает мои телепорты игрушками!";
					break;
				case "Yep! I'm also considering being a space pirate now.":
					Main.npcChatText = "Ага! Я также думаю о том, чтобы стать космическим пиратом.";
					break;
				case "Some of my machines are starting to go haywire thanks to this Astral Infection. I probably shouldn't have built them here":
					Main.npcChatText = "Некоторые из моих машин начинают выходить из строя из-за этой астральной инфекции. Наверное, мне не следовало строить их здесь.";
					break;
				case "I'm sorry I really don't have any Unicorn proof tech here, you're on your own.":
					Main.npcChatText = "Мне очень жаль, что у меня нет никакой технологии защиты от единорогов, вы сами по себе.";
					break;
				case "Have you seen those gemstone creatures in the caverns? Their colors are simply breathtaking!":
					Main.npcChatText = "Ты видел этих существ из драгоценностей в пещерах? Их цвета просто захватывают дух!";
					break;
				case "Do you think Пермафрост knows how to 'let it go?'":
					Main.npcChatText = "Как вы думаете Пермафрост знает, как отпустить и забыть?";
					break;
				case "I have a feeling we're going to have absolutely fantastic parties with Циррус around!":
					Main.npcChatText = "У меня такое чувство, что Циррус устроит нам фантастические вечеринки!";
					break;
				case "I think my light display is turning into an accidental bug zapper. At least the monsters are enjoying it.":
					Main.npcChatText = "Я думаю, что мой дисплей превращается в электрическую ловушку для насекомых. Ну хотя бы они этим наслаждаются.";
					break;
				case "Ooh! I love parties where everyone wears a scary costume!":
					Main.npcChatText = "О! Обожаю вечеринки, где все носят жуткие костюмы!";
					break;
				case "All these moments will be lost in time. Like tears...in the rain.":
					Main.npcChatText = "Все эти моменты будут затеряны во времени. Как слёзы... под дождём.";
					break;
				case "Always shoot for the moon! It has clearly worked before.":
					Main.npcChatText = "Всегда стреляйте на луну! Очевидно, что раньше это работало.";
					break;
				case "Draedon? He's...a little 'high octane' if you know what I mean.":
					Main.npcChatText = "Дрейдон? Он... немного 'высокооктановый', если вы понимаете, о чём я.";
					break;
				case "Those oversized bugs terrorizing the jungle... Surely you of all people could shut them down!":
					Main.npcChatText = "Эти огромные жуки, терроризирующие джунгли... Конечно же, только вы можете их уничтожить!";
					break;
				case "A little sickness isn't going to stop me from doing my work as an artist!":
					Main.npcChatText = "Небольшая болезнь не помешает мне работать художником!";
					break;
				case "There's a surprising art to this area. A sort of horrifying, eldritch feeling. It inspires me!":
					Main.npcChatText = "Атмосфера этой области — удивительна. Какое-то жуткое, древнее чувство. Это вдохновляет меня!";
					break;
				case "I'm not exactly suited for this cold weather. Still looks pretty, though.":
					Main.npcChatText = "Я не очень люблю холодную погоду. Ну хоть выглядит красиво.";
					break;
				case "Think Пермафрост would let me paint him like one of his French girls?!":
					Main.npcChatText = "Думаешь, Пермафрост позволит мне нарисовать его, как одну из его француженок?!";
					break;
				case "I hate sand. It's coarse, and rough and gets in my paint.":
					Main.npcChatText = "Я ненавижу песок. Он грубый, шершавый и попадает мне в краску.";
					break;
				case "Do you think unicorn blood could be used as a good pigment or resin? No I'm not going to find out myself.":
					Main.npcChatText = "Как вы думаете, кровь единорога может быть использована в качестве хорошего пигмента или смолы? Нет, я не собираюсь выяснять это сам.";
					break;
				case "I can't work in this environment. All of my paint just floats off.":
					Main.npcChatText = "Я не могу работать в такой обстановке. Вся моя краска просто стекает.";
					break;
				case "Painting the tortoises in a still life isn't going so well.":
					Main.npcChatText = "Рисовать черепах в натюрморте не очень хорошо получается.";
					break;
				case "I can't paint a still life if the fruit grows legs and walks away.":
					Main.npcChatText = "Я не смогу написать натюрморт, если у плода вырастут ноги и он уйдёт.";
					break;
				case "On the canvas, things get heated around here all the time. Like the environment!":
					Main.npcChatText = "Рисование заставляет попотеть. Как и окружающая среда!";
					break;
				case "Sorry, I'm all out of watercolors. They keep evaporating.":
					Main.npcChatText = "Извините, у меня закончились акварели. Они продолжают испаряться.";
					break;
				case "Roses, really? That's such an overrated thing to paint.":
					Main.npcChatText = "Розы, правда? Слишком переоценённый цветок.";
					break;
				case "Fun fact! Sulphur was used as pigment once upon a time! Or was it Cinnabar?":
					Main.npcChatText = "Забавный факт! Сера когда-то использовалась в качестве пигмента! Или это была киноварь?";
					break;
				case "Easiest landscape I've ever painted in my life.":
					Main.npcChatText = "Самый простой пейзаж, который я когда-либо рисовал в своей жизни.";
					break;
				case "My home here has an extensive history and a mysterious past. You'll find out quickly just how extensive it is...":
					Main.npcChatText = "Мой дом здесь имеет обширную историю и таинственное прошлое. Вы быстро узнаёте, насколько она обширна...";
					break;
				case "I have unique items if you show me that you have bested the guardian of this jungle.":
					Main.npcChatText = "Я смогу продать уникальные предметы, если вы покажете мне, что победили стража этих джунглей.";
					break;
				case "This is as good a time as any to pick up the best ingredients for potions.":
					Main.npcChatText = "Это самое подходящее время, чтобы собрать лучшие ингредиенты для зелий.";
					break;
				case "Aye, I've heard of a mythical creature in the oceans, singing with an alluring voice. Careful when yer fishin out there.":
					Main.npcChatText = "Да, я слышал о мифическом существе в океанах, поющем манящим голосом. Осторожнее, когда рыбачишь там.";
					break;
				case "I have to thank ye again for takin' care of that sea serpent. Or was that another one...":
					Main.npcChatText = "Стоит поблагодарить тебя за то, что разобрался с тем морским змеем. Или может, всё же не с тем...";
					break;
				case "I remember legends about that Амидиас. He ain't quite how the stories make him out to be though.":
					Main.npcChatText = "Я помню легенды о Амидиасе. Хотя он не совсем такой, каким его изображают в рассказах.";
					break;
				case "Twenty-nine bottles of beer on the wall...":
					Main.npcChatText = "Двадцать девять бутылок пива на стене...";
					break;
				case "Now this is a scene that I can admire any time! I feel like something is watching me though.":
					Main.npcChatText = "Теперь это сцена, которой я могу восхищаться в любое время! Я чувствую, что что-то наблюдает за мной.";
					break;
				case "It ain't much of a sight, but there's still life living in these waters.":
					Main.npcChatText = "Не очень красивое зрелище, но в этих водах всё ещё есть жизнь.";
					break;
				case "Me ship might just sink from the acid alone.":
					Main.npcChatText = "Мой корабль может затонуть из-за одной лишь кислоты.";
					break;
				case "Please don't catch space lice. Or Crimson lice. Or just lice in general.":
					Main.npcChatText = "Пожалуйста, не ловите космических вшей. Или багряных вшей. Или вообще вшей.";
					break;
				case "Please don't catch space lice. Or Corruption lice. Or just lice in general.":
					Main.npcChatText = "Пожалуйста, не ловите космических вшей. Или искажённых вшей. Или вообще вшей.";
					break;
				case "Sometimes I catch Циррус sneaking up from behind me.":
					Main.npcChatText = "Иногда, я замечаю, как Циррус подкрадывается сзади.";
					break;
				case "Циррус is always trying to brighten my mood...even if, deep down, I know she's sad.":
					Main.npcChatText = "Циррус всегда пытается поднять мне настроение...даже если в глубине души ей грустно.";
					break;
				case "They look so cute and yet, I can feel their immense power just by being near them. What are you?":
					Main.npcChatText = "Они выглядят так мило и всё же, я могу чувствовать огромную силу, просто находясь рядом с ними. Что ты такое?";
					break;
				case "I hate to break it to you, but you don't have hair to cut or style, hun.":
					Main.npcChatText = "Мне очень не хочется тебя огорчать, но у вас нет волос, чтобы подстричь или уложить.";
					break;
				case "Aww, they're so cute, do they have names?":
					Main.npcChatText = "Ой, они такие милые, у них есть имена?";
					break;
				case "Someone tell Амидиас to quit trying to throw me out of town, it's not going to work.":
					Main.npcChatText = "Кто-нибудь скажите Амидиасу перестать пытаться выкинуть меня с города. Всё равно у него не получится.";
					break;
				case "BAH! Doesn't seem like I'll ever be able to quarrel with the debts of the town again!":
					Main.npcChatText = "БА! Не похоже, что я когда-нибудь смогу переплюнуть налоги города!";
					break;
				case "Where and how are you getting all of this money?":
					Main.npcChatText = "Где и как вы получаете все эти деньги?";
					break;
				case "Perhaps with all that time you've got you could check those old ruins? Certainly something of value in it for you!":
					Main.npcChatText = "Возможно, вы сможете найти время для посещения этих старых руин? Там определённо есть что-то ценное!";
					break;
				case "Devourer of what, you said? Devourer of Funds, if its payroll is anything to go by!":
					Main.npcChatText = "Пожиратель чего, ты сказал? Пожиратель монет, если его зарплата хоть что-то значит!";
					break;
				case "Goodness! That cane has swagger!":
					Main.npcChatText = "Боже мой! Эта трость такая крутая!";
					break;
				case "What'dya buyin'?":
					Main.npcChatText = "Что покупаете?";
					break;
				case "Care for a little Moonshine?":
					Main.npcChatText = "Хотите немного самогона?";
					break;
				case "Sheesh, Циррус is a little cruel, isn't she? I never claimed to be an expert on anything but ale!":
					Main.npcChatText = "Воу, Циррус немного жестокая, не так ли? Я никогда не утверждал, что разбираюсь в чем-то, кроме эля!";
					break;
			}
            
			if (Main.npcChatText == $"{Main.player[Main.myPlayer].name}...just between us, I think I forgot my soul in the ice castle. If you see it, please do let me know.")
				Main.npcChatText = $"{Main.player[Main.myPlayer].name} ...только между нами, я думаю, что забыл свою душу в ледяном замке. Если вы её увидите, пожалуйста, дайте мне знать.";
            
			if (Main.npcChatText == $"That's west, {Main.player[Main.myPlayer].name }. You're fired again.")
				Main.npcChatText = $"Это запад, {Main.player[Main.myPlayer].name}. Ты снова уволен.";

			if (dryad >= 0 && Main.npcChatText == $"Yes, I am older than {Main.npc[dryad].GivenName}. You can stop asking now...")
				Main.npcChatText = $"Да, я старше, чем {Main.npc[dryad].GivenName}. Ты можешь прекратить спрашивать...";

			if (bartender >= 0)
			{
				if (Main.npcChatText == $"Tell {Main.npc[bartender].GivenName} to stop calling me. He's not wanted.")
					Main.npcChatText = $"Скажи {Main.npc[bartender].GivenName} перестать звать меня. Ему здесь не рады.";
						
				if (Main.npcChatText == $"My booze will always be better than {Main.npc[bartender].GivenName}'s, and nobody can convince me otherwise.")
					Main.npcChatText = $"Моё бухлишко всегда будет лучше, чем у {Main.npc[bartender].GivenName}. Попробуй измени моё мнение.";
			}

			if (stylist >= 0)
			{
				if (Main.npcChatText == $"You still can't stop me from trying to move in with {Main.npc[stylist].GivenName}.")
					Main.npcChatText = $"Ты всё ещё не можешь помешать мне переехать к {Main.npc[stylist].GivenName}.";

				if (Main.npcChatText == $"I love it when {Main.npc[stylist].GivenName}'s hands get sticky from all that...wax.")
					Main.npcChatText = $"Я люблю когда у {Main.npc[stylist].GivenName} руки становятся липкими... от воска.";

				if (Main.npcChatText == $"{Main.npc[stylist].GivenName} works wonders for my hair...among other things.")
					Main.npcChatText = $"{Main.npc[stylist].GivenName} творит чудеса с моими волосами... и не только.";

				if (Main.npcChatText == $"Ever since {Main.npc[stylist].GivenName} moved in I haven't been drinking as much...it's a weird feeling.")
					Main.npcChatText = $"С момента заселения {Main.npc[stylist].GivenName} я стала пить меньше... Я чувствую себя странно.";
			}

			if (partyGirl >= 0)
			{
				if (Main.npcChatText == $"{Main.npc[partyGirl].GivenName} asked if my nose could be used as a vuvuzela. What is a vuvuzela?")
					Main.npcChatText = $"{Main.npc[partyGirl].GivenName} спросил меня, можно ли использовать мой нос как вувузелу. Что за вувузела?";
			}

			if (angler >= 0)
			{
				if (Main.npcChatText == $"Meet me at {Main.npc[angler].GivenName}'s house at night. We're going to throw him to the Trashers.")
					Main.npcChatText = $"Встреть меня у дома {Main.npc[angler].GivenName} ночью. Будем скармливать его мусорщикам.";

				if (Main.npcChatText == $"Not sure how {Main.npc[angler].GivenName} has not been roasted and digested by now, hanging around the sulphuric seas for so long. Perhaps it got to his head.")
					Main.npcChatText = $"Неуверен как, но {Main.npc[angler].GivenName} не был зажарен и переварен, тусуясь вокруг сернистых морей в течение большого количества времени. Скорее всего, это повлияло на его голову.";
			}

			if (merchant >= 0)
			{
				if (Main.npcChatText == $"Don't tell {Main.npc[merchant].GivenName}, but I took some of his stuff and replaced it with Angel Statues.")
					Main.npcChatText = $"Не говори {Main.npc[merchant].GivenName}, но я взял кое-какие его вещи и заменил их статуями ангелов.";
	            
				if (Main.npcChatText == $"Tell Циррус I'll take up her offer and meet with her at the back of {Main.npc[merchant].GivenName}'s house.")
					Main.npcChatText = $"Скажи Циррус, что я приняла её сделку, а ещё что нам следует встретиться у дома {Main.npc[merchant].GivenName}";
			}

			if (armsDealer >= 0 && nurse >= 0)
			{
				if (Main.npcChatText == $"Don't tell {Main.npc[armsDealer].GivenName} that I was responsible for {Main.npc[nurse].GivenName}'s injuries.")
					Main.npcChatText = $"Не говори {Main.npc[armsDealer].GivenName}, что я ответственна за ранения {Main.npc[nurse].GivenName}";
			}

			if (goblinTinkerer >= 0)
			{
				if (Main.npcChatText == $"Want in on a little secret? Since {Main.npc[goblinTinkerer].GivenName} always gets so much cash from you, I've been stealing some of it as we go. I need you to keep quiet about it, so here.")
					Main.npcChatText = $"Хочешь маленький секрет? Так как {Main.npc[goblinTinkerer].GivenName} получает слишком много денег, я решила своровать немного у него. За твоё молчание ты получишь это.";
			}
            
			if (thief >= 0)
			{
				if (Main.npcChatText == $"Hey, is it just me or have my pockets gotten lighter ever since {Main.npc[thief].GivenName} arrived?")
					Main.npcChatText = $"Эй, мне кажется или мои карманы стали легче с тех пор, как {Main.npc[thief].GivenName} прибыла?";
			}
			
			for (int k = 0; k < 200 && flag; k++)
			{
				if (Main.npc[k].type == CoreCalamityTranslation.CalamityMod.NPCType("FAP") && Main.npc[Main.player[Main.myPlayer].talkNPC].type == CoreCalamityTranslation.CalamityMod.NPCType("FAP"))
				{
					string str = Main.npcChatText;
					str = str.Replace("Hey ", "Привет Eternity, osaka_drift, ILLIK ");
					str = str.Replace(" and ", " и ");
					str = str.Replace("! You're all pretty good! ...wait, who are you again?", "! Вы все очень хороши! ...подожди, а ты кто такой?");
					str = str.Replace("You have failed ", "Вы потерпели неудачу ");
					str = str.Replace(" times", " раза");
					str = str.Replace(" time", " раз");
					Main.npcChatText = str;
				}
			}
		}
    }
}