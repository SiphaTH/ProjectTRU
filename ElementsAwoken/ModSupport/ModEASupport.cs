using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ElementsAwoken.ModSupport
{
	public class ModEASupport
	{
		public static void ElementsAwokenNpcChat()
		{
			if (Main.npcChatText == "No matter how large the wound, healing potions shall fix it.")
			{
				Main.npcChatText = "Неважно, сколь большая у тебя рана, зелье лечения вылечит его.";
			}
			if (Main.npcChatText == "All your potion needs, taken care of right here.")
			{
				Main.npcChatText = "Зелье хотите - вдвойне получите.";
			}
			if (Main.npcChatText == "I travel the world searching for ingredients for my potions, its not an easy task.")
			{
				Main.npcChatText = "Я путешествую по миру в поисках ингредиентов для своих зелий, и это не так-то просто.";
			}
			if (Main.npcChatText == "I come from a dark world...")
			{
				Main.npcChatText = "Я прибыл из темного мира...";
			}
			if (Main.npcChatText == "Be careful out there, I hate fighting. I'd much rather talk my way out of it.")
			{
				Main.npcChatText = "Будь осторожен, я ненавижу драться. Я бы скорее нашел дипломатический выход из ситуации.";
			}
			if (Main.npcChatText == "Going truffle worm hunting? I suggest an invisibility potion.")
			{
				Main.npcChatText = "Собираешься на охоту за трюфельными червями? Предлагаю взять с собой зелье невидимости.";
			}
			if (Main.npcChatText == "And, how are we feeling today?")
			{
				Main.npcChatText = "О, как себя сегодня чувствуешь?";
			}
			if (Main.npcChatText == "I hear there is a 'Book of Shadows' that shows what is affecting your sanity. I'm sure it isnt as effective as my services.")
			{
				Main.npcChatText = "Я слышал о существовании 'книги теней', которая рассказывает о влиянии на твой рассудок. Уверен, она не сравниться с моими услугами.";
			}
			if (Main.npcChatText == "I am the best psychologist around...and most likely the only one.")
			{
				Main.npcChatText = "Я лучший психолог в округе... и, скорее всего, единственный.";
			}
			if (Main.npcChatText == "Did you see my glasses? I can't seem to find them...oh, there they are. What do you want?")
			{
				Main.npcChatText = "Ты не видел мои очки? Я не могу их найти... ох, вот они. Так что ты хотел?";
			}
			if (Main.npcChatText == "To be honest, I'm surprised by the fact that you don't have an trauma - considering you fought an gigantic wall made out of flesh...")
			{
				Main.npcChatText = "Если быть честный, я удивлен, что у тебя нет никакой психической травмы, учитывая что ты сражался с гигантской стеной из плоти...";
			}
			if (Main.npcChatText == "The townspeople seem plagued by hallucinations...luckily I am not. Anyways, who's your zombie friend there?")
			{
				Main.npcChatText = "Кажется, прочих жителей поразили галлюцинации... хорошо, что я не среди их числа. Ладно, а что у тебя появился новый друг-зомби?";
			}
			if (Main.npcChatText == "Your sanity is pretty low...you should maybe see a psychologist. Oh, wait...")
			{
				Main.npcChatText = "Твой рассудок очень низкий... ты должен посетить психолого. А, стоп...";
			}
			if (Main.npcChatText == "The fact that we never sleep is extremely strange. Who coded us to be this way?")
			{
				Main.npcChatText = "Факт того, что мы никогда не спим, довольно странен. И кто только нас так запрограммировал?";
			}
			if (Main.npcChatText == "You took down a being said to make others grow insane with alone it's presence. Are you even human?")
			{
				Main.npcChatText = "Ты убил существо, что сводило с ума людей одним своим присутствием. Ты вообще человек?";
			}
			if (Main.npcChatText == "I'm doing fine. I'm ABSOLUTELY DOING FINE. NOW STOP ASKING!")
			{
				Main.npcChatText = "У меня все нормально. ДА НОРМАЛЬНО У МЕНЯ ВСЕ. ПРЕКРАЩАЙ СПРАШИВАТЬ!";
			}
			Player player = Main.player[Main.myPlayer];
			int num = NPC.FindFirstNPC(208);
			int num2 = NPC.FindFirstNPC(17);
			int num3 = NPC.FindFirstNPC(22);
			int num4 = NPC.FindFirstNPC(20);
			int num5 = NPC.FindFirstNPC(19);
			int num6 = NPC.FindFirstNPC(18);
			int num7 = NPC.FindFirstNPC(160);
			if (Main.npcChatText == "The flare of chaos is now extinct... that such a great warrior did fall with ease is truly interesting...")
			{
				Main.npcChatText = "Пламя хаоса потухло... то, что великий воин так легко пал, действительно интересно...";
			}
			if (Main.npcChatText == "You did put the ex-goddess out of her misery, huh? I'm curious... what do you seek?")
			{
				Main.npcChatText = "Ты избавил бывшую богиню от страданий, да? Мне интересно... что же ты ищешь?";
			}
			if (Main.npcChatText == "Little do you know what power you've set free...you're just as foolish as you look...")
			{
				Main.npcChatText = "Да будто ты знаешь, какую силу высвободил... ты столь же глуп, как и выглядишь...";
			}
			bool flag = Main.player[Main.myPlayer].talkNPC != -1;
			int i = 0;
			while (i < 200 && flag)
			{
				if (Main.npc[Main.player[Main.myPlayer].talkNPC].type == ModLoader.GetMod("ElementsAwoken").NPCType("Storyteller"))
				{
					Main.npcChatText = Main.npcChatText.Replace("Gah, perhaps I should just kill ", "Ох, думаю мне надо просто убить ").Replace(" now. Oh! I didn't see you there ", ". Ох! Я тебя только заметил, ").Replace("... You didn't hear anything did you?", "... Ты ничего не слышал, понял?");
					Main.npcChatText = Main.npcChatText.Replace("The king of the slimes roams the fields with it's followers, causing earthquakes. A '", "Король слизней, вместе со своей свитой, бродит по полям, вызывая землетрясения. '").Replace("' may provoke him.", "' может спровоцировать его появление.");
					Main.npcChatText = Main.npcChatText.Replace("A giant eyeball is terrorizing the night, which hides sharp teeth underneath his lens. You found this '", "Гигантский глаз наводит ночью ужас, скрывая под линзой острые зубы. Ты ведь нашел этот '").Replace("'...maybe it'll be just perfect for the eyeball to appear.", "'... кажется, он просто идеален для появления глаза.");
					Main.npcChatText = Main.npcChatText.Replace("Dust is spreading out within the desert, storming. Scorpions suddenly arise from the sands. No doubt, it's Wasteland hunting it's next victim. Catch one of the '", "В пустыне поднимаются облака пыли, бушуют бури. Скорпионы внезапно вылезают из песка. Без сомнений, это Картул ищет свою следующую жертву. Один '").Replace("' with a net to get his attention.", "', если его поймать в сеть, привлечет его внимание.");
					Main.npcChatText = Main.npcChatText.Replace("A loud roar halled through the dead lands of the Crimson. It's guardian roams free again, it seems. Destroy three of these 'Crimson Hearts' within the caves. Alternatively, provoke it with a '", "Громкий рев пронесся по мертвым землям Багрянца. Кажется, их освободился страж вновь. Разрушь три 'живых сердца' в пещерах Багрянца. Ну, или спровоцируй стража этим - '");
					Main.npcChatText = Main.npcChatText.Replace("A loud roar halled through the dead lands of the Corruption. It's guardian roams free again, it seems. Destroy three of these 'Shadow Orbs' within the caves. Alternatively, provoke it with some '", "Громкий рев пронесся по мертвым землям Искажения. Кажется, их освободился страж вновь. Разрушь три 'теневых сферы' в пещерах Искажения. Ну, или спровоцируй стража этим - '");
					Main.npcChatText = Main.npcChatText.Replace("The queen of all bees buzzes through the jungle, trying to build it's hives at every corner. Smash one of the hive's larva or use an '", "Королева всех пчел летает по джунглям, пытаясь построить на каждом углу свои ульи. Сломай одну из личинок в улье, или используй '").Replace("' to put an end to that madness.", "', и закончи это безумие.");
					Main.npcChatText = Main.npcChatText.Replace("An ancient curse has befallen the old man near the dungeon. This curse will cause a giant skull to emerge. Kill him with a '", "Древнее проклятие пало на старика, что ошивается возле темницы. Это проклятие вызывает появление огромного черепа. Убей старика, надев '").Replace("' or visit the halls of the dungeon to summon it.", "', или же ночью посети залы темницы, чтобы призвать его.");
					Main.npcChatText = Main.npcChatText.Replace("After the skull has fallen, ash and fire rains down upon the lands. The fire lord Infernace seems to be enraged. Create a '", "После того, как тот череп пал, пепел и огонь дождем осыпались на землю. Кажется огненный повелитель, Инфернэйс, в ярости. Создай '").Replace("' and use it within the underworld to get him to show up.", "' и используй его в Аду, это заставит его показаться.");
					Main.npcChatText = Main.npcChatText.Replace("I've heared that the guide is fully aware of his fate and deems you challenging to fight the underworld's master. Heh, what a fool. Little does he know what it's defeat will bring over the world...", "Я слышал, что гид полностью осведомлен о своей судьбе и считает, что вы осмелитесь бросить вызов хозяйке Ада. Хах, что за дурак! Если бы он только знал, что принесет этому миру ее поражение...");
					Main.npcChatText = Main.npcChatText.Replace("Do you remember that giant eyeball? Some group of scientists created an mechanical copy of him - and this time, there are two of them. Use a '", "Помнишь тот гигантский глаз? Какая-то группа ученых создала его механическую копию, и да. В этот раз их два. Используй '").Replace("'. As it's similiar to the eye you've made back then, it may cause them to appear.", "'. Поскольку они похожи на уже поверженный тобой глаз, эта штука может заставить их появиться.");
					Main.npcChatText = Main.npcChatText.Replace("You feel those earthquakes? They are way worse than the ones of the King Slime back then. Create an '", "Чувствуешь эти землетрясения? Они даже хуже, чем те, что были при Короле слизней. Создай '").Replace("' and use it, maybe the source of the earthquake will show up then.", "' и используй его, а там, глядишь, появится и источник этих землетрясений.");
					Main.npcChatText = Main.npcChatText.Replace("The skull has been reborn as a four armed mechanoid. And he causes more havoc than ever before. A '", "Череп переродился в четырёхрукий механизм. И он вызывает еще большее опустошение, чем прежде. '").Replace("' will cause it to appear.", "' заставит его появиться.");
					Main.npcChatText = Main.npcChatText.Replace("A group of martians had created a powerful jet robot long ago dubbed the Scourge Fighter, with an AI to destroy whatever it comes across. If you can obtain a duplicate of his '", "Давным-давно, кучка пришельцев создала могучего реактивного робота, называемого Карающий воин, и с основной программой - уничтожение всего живого. Если достанешь копию его '").Replace("', you may be able to signal it your coordinates.", "', то сможете отправить ему свои координаты.");
					Main.npcChatText = Main.npcChatText.Replace("The mechanical trio went rogue after shocking thunders hit them. It was caused by the cosmic thunder serpent, Regaroth. If you are able to get ahold of a piece of his '", "Та механическая троица вышла из себя, стоило молнии ударить их. Они были вызваны космическим громовым змеем, Регаротом. Если сумеешь завладеть хотя бы кусочком его '").Replace("', he may come to reclaim it. Prepare for the worst.", "', он может прийти и попытаться забрать ее. Приготовься к худшему.");
					Main.npcChatText = Main.npcChatText.Replace("Flowers are always pretty, however, not when they're giant and have tentacles and spikes. I'm talking about the jungle guardian Plantera. Destroy her bulb to awaken her.", "Цветы всегда прекрасны. Но только не тогда, когда они огромны и имеют щупальца с шипами. Я говорю о хранительнице джунглей, Плантере. Найди и уничтожь бутон, чтобы пробудить ее.");
					Main.npcChatText = Main.npcChatText.Replace("The Golem is a ancient automaton within the depths of the jungle temple. Right now it's deactivated, but you can reactivate it by using one of it's '", "Голем - это древний автоматон в глубине храма джунглей. Сейчас он деактивирован, но ты можешь вновь активировать его, используя одну из этих '").Replace("' at an Lihzahrd Altar.", "' на алтаре ящеров.");
					Main.npcChatText = Main.npcChatText.Replace("The once friendly ice wizard Permafrost returned as a hatred filled spirit, taking revenge upon those who forgot him. An '", "Некогда дружелюбный ледяной заклинатель Пермафрост вернулся как наполненный ненавистью дух, мстя тем, кто посмел забыть его. '").Replace("' will call upon him.", "' вызовет его.");
					Main.npcChatText = Main.npcChatText.Replace("Forbidden artifact only cause calamitous things, yet some do not want to listen. The resulted, obsidian-plated monster, Obsidious, can be summoned with a '", "Запретные артефакты причиняют одни беды, но некоторые не желают слушать. Как результат, покрытое обсидианом чудовище, Обсидиус, может быть вызван при помощи '");
					Main.npcChatText = Main.npcChatText.Replace("The king of the ocean, Duke Fishron recently scared me when I was looking for some fresh fish to have a nice dinner. He nearly devoured one of my arms. He is highly dangerous, so it's better to catch him with a '", "Король вод, герцог Рыброн, недавно напугал меня, когда я искал свежую рыбу для неплохого ужина. Он чуть не сожрал одну из моих рук. Он невероятно опасен, поэтому лучше поймай эту рыбу-переростка с помощью '").Replace("' and get rid of him.", "' и избавься от нее.");
					Main.npcChatText = Main.npcChatText.Replace("No bad action remains unpunished. The knight of the ocean has come to take your life for taking Fishron's. Get ready for a tough battle. The knight will be further provoked by holding a '", "Ни одно злодеяние не остается безнаказанным. Рыцарь океана пришел забрать твою жизнь за то, что ты забрал жизнь Рыброна. Приготовься к трудной битве. Рыцарь будет еще больше спровоцирован, держи ты в руках '").Replace("' at the ocean.", "' недалеко от океана.");
					Main.npcChatText = Main.npcChatText.Replace("A group of cultists stand at the entrance of the dungeon, praising something that they shouldn't. You better take them out before they summon anything chaotic.", "Группа культистов стоит на входе в темницу, вознося хвалы тому, чему не должны. Тебе лучше позаботиться о них до того, как они вызвали что-нибудь хаотичное.");
					Main.npcChatText = Main.npcChatText.Replace("You've caused a great mess. Because of you, the moon lord and the 4 lunar pillars awaken in the land once more. This creature could mean the end of everything. Are you ready to take on him? If so, kill those pillars or use a '", "Ты устроил большой переполох. Из-за вас Лунный лорд и четыре лунных башни вновь пробудились на этой земле. Это существо может обозначать собой конец всего сущего. Ты готов убить его? Если так, то уничтожь эти башни, или же используй '").Replace("' to awake him for real.", "', чтобы пробудить его.");
					Main.npcChatText = Main.npcChatText.Replace("The divine being of the underworld, Volcanox, has been freed from it's prison. To calm the underworld down once again, you will have to make sure that he will fall. A '", "Ты устроил большой переполох. Из-за вас Лунный лорд и четыре лунных башни вновь пробудились на этой земле. Это существо может обозначать собой конец всего сущего. Ты готов убить его? Если так, то уничтожь эти башни, или же используй '").Replace("' to awake him for real.", "', чтобы пробудить его.");
					Main.npcChatText = Main.npcChatText.Replace("The town is full of hallucinations and fatigue and the void glows with a sinister power - the Void Leviathan has returned from it's slumber. He is after your soul, so he can reach his full potenial once again. Take him down by summoning him with the '", "Город наводнен галлюцинациями и апатией, а пустота сияет зловещей силой - Пустотный левиафан пробудился от своей спячки. Он пришел по твою душу, чтобы снова полностью раскрыть свою мощь. Убей его, используя для его призыва '");
					Main.npcChatText = Main.npcChatText.Replace("A long forgotten chaotic infection has taken the control of a scientist, infusing her with a mechanical suit to create an mindless, horrifying abomination. If you use an '", "Древняя хаотическая инфекция взяла под контроль ученого, соединив его с механическим костюмом для создания бессмысленной, ужасающей мерзости. Если ты используешь '").Replace("', you might be able to gain it's attention...", "', то можешь попробовать привлечь ее внимание...");
					Main.npcChatText = Main.npcChatText.Replace("Sorry, I'm all out of tales", "Извини, у меня кончились легенды");
					Main.npcChatText = Main.npcChatText.Replace("You question my origin? I am a crystalline being, born within the depths of ", "Спрашиваешь о моем происхождении? Я - кристаллическое существо, рожденное в глубине ").Replace(". For so long, you mindlessly did what I said, without questioning. You did your job well. Now, it's time for you to perish. I do not need you any longer.", ". Сколь же долго ты слушал мои указания, даже не задавая вопросов. Ты хорошо выполнил свою работу. А теперь пришло время тебе погибнуть. Ты мне больше не нужен.");
				}
				i++;
			}
			if (Main.npcChatText == "Say, is it really you who makes these decisions? Or is it the puppeteer behind the curtain who pulls your strings?")
			{
				Main.npcChatText = "Скажи, правда ли ты принимаешь все эти решения? Или это кукловод за занавесом дергает тебя за ниточки?";
			}
			if (Main.npcChatText == "What a great night to kill monsters. The red moon makes it even way more fun.")
			{
				Main.npcChatText = "Какая замечательная ночь для убийства чудищ. Красная луна только добавляет веселья.";
			}
			if (Main.npcChatText == "I never could understand humanity's satisfaction at that time of the year. They clearly didn't see real monsters. And the beings of this Pumpkin Moon are nothing compared to true ones, either.")
			{
				Main.npcChatText = "Я никогда не мог понять, почему человечество так радуется в это время года. Они явно не видели настоящих монстров. И существа этой 'тыквенной луны' тоже ничто по сравнению с истинными.";
			}
			if (Main.npcChatText == "At least this cold night ended in a good fight and not into an ice queen singing about her doubts. Ugh.")
			{
				Main.npcChatText = "По крайней мере, эта холодная ночь закончилась хорошей дракой, а не ледяной королевой, поющей о своих сомнениях. Тьфу.";
			}
			if (num != -1 && Main.npcChatText == "Go tell " + Main.npc[num].GivenName + " to tone down the noise, I'm sick of her partying.")
			{
				Main.npcChatText = "Иди и скажи этой девчонке, " + Main.npc[num].GivenName + ", быть потише. Я уже устал от этих ее вечеринок.";
			}
			if (num4 != -1 && Main.npcChatText == Main.npc[num4].GivenName + " calls herself old. She has barely been born.")
			{
				Main.npcChatText = Main.npc[num4].GivenName + " называет себя старой. Она ведь только родилась.";
			}
			if (num7 != -1 && Main.npcChatText == "What on Earth is " + Main.npc[num7].GivenName + "? In all my time here, I have never seen a being so peculiar...")
			{
				Main.npcChatText = "Что, черт побери, такое " + Main.npc[num7].GivenName + "? За все проведенное здесь время, ни разу не видел столь необычное существо.";
			}
			if (num5 != -1 && Main.npcChatText == Main.npc[num5].GivenName + "'s weapons are feeble little creations.")
			{
				Main.npcChatText = Main.npc[num5].GivenName + " оружия - ничтожные маленькие творения.";
			}
			if (num3 != -1 && Main.npcChatText == "Hah, " + Main.npc[num3].GivenName + " is a useless fool! No one requires his little 'tips' he has. Petty...")
			{
				Main.npcChatText = "Хах, " + Main.npc[num3].GivenName + " бесполезный кретин! Никому не нужны его маленькие 'советы'. Бедняжка...";
			}
			if (Main.npcChatText == "Really? Boss Checklist? Am I seriously not good enough... Well then, guess I'll have to prove I'm better. You'll see.")
			{
				Main.npcChatText = "Серьезно? Boss Checklist? Видимо я недостаточно хорош... Кажется прядется доказать, что я куда полезнее. Вот увидишь.";
			}
			if (Main.npcChatText == "Ah, the Moon Lord is defeated... Well done, you are almost as strong as I.")
			{
				Main.npcChatText = "Ах, Лунный лорд побежден... Неплохо, теперь ты по силам почти сравним со мной.";
			}
			if (num2 != -1 && Main.npcChatText == "Old " + Main.npc[num2].GivenName + " is afraid of some puny eyeball! I would slay it in seconds if I believed it was even worth the effort. Hah!")
			{
				Main.npcChatText = "Старик " + Main.npc[num2].GivenName + " боится какого-то жалкого глаза! Я бы убил его за секунды, если бы считал, что оно того стоит. Хах!";
			}
			if (Main.npcChatText == "Argh! These damn scorpions keep getting in my house! I heard of a genetics lab meltdown after that giant eye was slain. Imbeciles cant even contain a scorpion!")
			{
				Main.npcChatText = "Аргх! Эти проклятые скорпионы все лезут и лезут в мою комнату! Я слышал о крахе генетической лаборатории после того, как был убит тот гигантский глаз. Эти имбецилы даже скорпиона не могут сдержать!";
			}
			if (Main.npcChatText == "Strange floral creatures have started appearing in the jungle... I saw one with a shell made of petals!")
			{
				Main.npcChatText = "В джунглях начали появляться странные цветочные существа... Я видел одного, у которого был панцирь из лепестков!";
			}
			if (Main.npcChatText == "The skies brighten once more, creatures that harbour an ore of immense power reside up there now.")
			{
				Main.npcChatText = "Небеса осветились вновь и те существа, что питались рудой безмерной мощи, теперь проживают здесь.";
			}
			if (Main.npcChatText == "Death spreads. The critters are looking sickly. I watched one get eaten from the inside out by a giant purple tick...")
			{
				Main.npcChatText = "Смерть распространяется. Твари выглядят болезненно. Я видел, как одну из них съел изнутри гигантский фиолетовый клещ...";
			}
			if (Main.npcChatText == "Burning spirits have began to appear in the dungeon. I suspect that the lunar surge may have caused Volcanox to release them into the world.")
			{
				Main.npcChatText = "В темнице стали появляться пылающие духи. Я подозреваю, что лунный всплеск, возможно, заставил Вулканокса выпустить их в мир.";
			}
			if (num6 != -1 && Main.npcChatText == "You look weary, " + player.name + ". Go pay a visit to " + Main.npc[num6].GivenName)
			{
				Main.npcChatText = "Ты выглядишь уставшим, " + player.name + ". Иди-ка посети " + Main.npc[num6].GivenName;
			}
			if (Main.npcChatText == "You look weary, " + player.name + ". Go pay a visit to the nurse. Oh wait... We don't have one")
			{
				Main.npcChatText = "Ты выглядишь уставшим, " + player.name + ". Иди-ка посети медсестру. А, погоди... У нас же ее нет";
			}
			if (Main.npcChatText == "I wouldn't reccomend getting into a fight with me. I may be old but trust me, I have plenty of strength.")
			{
				Main.npcChatText = "Не рекомендую вступать в бой со мной. Может я и стар, но поверь, силы у меня еще достаточно.";
			}
			if (Main.npcChatText == "The beasts of Terraria are rough, I'll sell you some nasty weapons to aid in your combat.")
			{
				Main.npcChatText = "Звери Террарии суровы. Я продам тебе какое-нибудь мерзкое оружие, оно поможет тебе в битве.";
			}
			if (Main.npcChatText == "These weapons are all made from 100% natural resources!")
			{
				Main.npcChatText = "Эти оружия на 100% сделаны из натуральных продуктов!";
			}
			if (Main.npcChatText == "Hope you enjoy what I'm selling. Who am I kidding, of course you will!")
			{
				Main.npcChatText = "Надеюсь, тебе понравятся мои товары. Кого я обманываю, конечно же понравятся!";
			}
			if (Main.npcChatText == "Hmph. Sometimes standing around and mingling with all these people gets boring. I miss the days of war.")
			{
				Main.npcChatText = "Хмф. Иногда шататься вокруг и общаться со всеми этими людьми становится скучно. Я скучаю по дням войны.";
			}
			if (Main.npcChatText == "You want help crafting? I'm a storyteller! I deal legends not knowledge.")
			{
				Main.npcChatText = "Ты хочешь помощи в изготовлении предметов? Я сказатель! Я несу легенды, не знания.";
			}
			if (Main.npcChatText == "Why don't I kill the monsters myself? Uh, I'm awfully busy and you look like a strong young man.")
			{
				Main.npcChatText = "Почему я не убиваю всех этих монстров сам? Э, ну, я невероятно занят, да и ты выглядишь довольно сильным.";
			}
			if (Main.npcChatText == "I despise cookies. They are way too sweet for me. Honestly, I prefer the spicy stuff.")
			{
				Main.npcChatText = "Не люблю печенье. Больно они для меня сладкие. Если честно, я предпочитаю вещи поострей.";
			}
		}
	}
}
