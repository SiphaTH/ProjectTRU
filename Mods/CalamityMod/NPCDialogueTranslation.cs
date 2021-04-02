using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public static class NPCDialogueTranslation
    {
        #region Properties
        private static int Dryad => NPC.FindFirstNPC(NPCID.Dryad);
        private static int Bartender => NPC.FindFirstNPC(NPCID.DD2Bartender);
        private static int Stylist => NPC.FindFirstNPC(NPCID.Stylist);
        private static int PartyGirl => NPC.FindFirstNPC(NPCID.PartyGirl);
        private static int Angler => NPC.FindFirstNPC(NPCID.Angler);
        private static int Merchant => NPC.FindFirstNPC(NPCID.Merchant);
        private static int ArmsDealer => NPC.FindFirstNPC(NPCID.ArmsDealer);
        private static int Nurse => NPC.FindFirstNPC(NPCID.Nurse);
        private static int GoblinTinkerer => NPC.FindFirstNPC(NPCID.GoblinTinkerer);
        private static int Guide => NPC.FindFirstNPC(NPCID.Guide);
        private static int Demolitionist => NPC.FindFirstNPC(NPCID.Demolitionist);
        private static int Clothier => NPC.FindFirstNPC(NPCID.Clothier);
        private static int Wizard => NPC.FindFirstNPC(NPCID.Wizard);
        private static int Mechanic => NPC.FindFirstNPC(NPCID.Mechanic);
        private static int Truffle => NPC.FindFirstNPC(NPCID.Truffle);
        private static int Steampunk => NPC.FindFirstNPC(NPCID.Steampunker);
        private static int DyeTrader => NPC.FindFirstNPC(NPCID.DyeTrader);
        private static int Cyborg => NPC.FindFirstNPC(NPCID.Cyborg);
        private static int Painter => NPC.FindFirstNPC(NPCID.Painter);
        private static int WitchDoctor => NPC.FindFirstNPC(NPCID.WitchDoctor);
        private static int Pirate => NPC.FindFirstNPC(NPCID.Pirate);
        private static int TravellingMerchant => NPC.FindFirstNPC(NPCID.TravellingMerchant);
        private static int TaxCollector => NPC.FindFirstNPC(NPCID.TaxCollector);
        private static int SkeletonMerchant => NPC.FindFirstNPC(NPCID.SkeletonMerchant);
        private static int Archmage => NPC.FindFirstNPC(ModsCall.Calamity.NPCType("DILF"));
        private static int DrunkPrincess => NPC.FindFirstNPC(ModsCall.Calamity.NPCType("FAP"));
        private static int SeaKing => NPC.FindFirstNPC(ModsCall.Calamity.NPCType("SEAHOE"));
        private static int Bandit => NPC.FindFirstNPC(ModsCall.Calamity.NPCType("THIEF"));
        private static bool IsTalking => Main.LocalPlayer.talkNPC >= 0;
        private static int TalkingNpc => Main.player[Main.myPlayer].talkNPC;
        #endregion
        private static bool IsExistingNPC(this int npcType) => npcType >= 0;
        
        internal static void SetupTranslation()
        {
            if (!IsTalking)
                return;
            
            string npcPhrase = Main.npcChatText;
            if (TalkingNpc == Archmage)
            {
                switch (npcPhrase)
                {
                    case "I must admit...I am not quite used to this weather. It's too warm for my taste...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.1");
                        break;
                    case "My dear! What is it you would like to talk about today?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.2");
                        break;
                    case "Why...I don't have to worry about any time of the day! If it is hot...then I can use my ice magic to cool down!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.3");
                        break;
                    case "I do usually prefer a spot of humidity for my ice magic. It likes to come out as steam when it's too hot and dry...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.4");
                        break;
                    case "Magic is a skill that must be learned and practiced! You seem to have an inherent talent for it at your age. I have spent all of my life honing it...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.5");
                        break;
                    case "Why ice magic, you ask? Well, my parents were both pyromaniacs...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.6");
                        break;
                    case "There be monsters lurking in the darkness. Most...unnatural monsters.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.7");
                        break;
                    case "You could break the icy stillness in the air tonight.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.8");
                        break;
                    case "Hmm...some would say that an unforeseen outside force is the root of the blood moon...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.9");
                        break;
                    case "I was once the greatest Archmage of ice that ever hailed the lands. Whether or not that is still applicable, I am not sure...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.10");
                        break;
                    case "There used to be other Archmages of other elements. I wonder where they are now...if they are also alive...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.11");
                        break;
                    case "Oh...I wish I could tell you all about my life and the lessons I have learned, but it appears you have a great many things to do...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.12");
                        break;
                    case "I assure you, I will do my best to act as the cool grandfather figure you always wanted.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.13");
                        break;
                    case "Sometimes...I feel like all I'm good for during these events is making ice cubes and slushies.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.14");
                        break;
                    case "Tread carefully, my friend... Now that the Moon Lord has been defeated, many powerful creatures will crawl out to challenge you...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.15");
                        break;
                    case "I feel the balance of nature tilting farther than ever before. Is it due to you, or because of the events leading to now...?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.16");
                        break;
                    case "I felt a sudden chill down my spine. I sense something dangerous stirring in the Abyss...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.17");
                        break;
                    case "...Where is Lord Yharim? He must be up to something...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.18");
                        break;
                    case "What an adorable tiny companion you have! Where in the world did you find such a...creature...? Actually, I'd rather not know.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.20");
                        break;
                    case "It wouldn't be the first time something unknown and powerful dropped from the heavens...I would tread carefully if I were you...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.22");
                        break;
                    case "I deeply appreciate you rescuing me from being trapped within my frozen castle... It's been many, many years...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.23");
                        break;
                    case "Thank you for saving me...though now I admit I am without a home since mine got destroyed.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.24");
                        break;
                }
                if (Dryad.IsExistingNPC())
                {
                    if (npcPhrase == $"Yes, I am older than {Main.npc[Dryad].GivenName}. You can stop asking now...")
                    {
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.19"), Main.npc[Dryad].GivenName);
                    }
                }
                if (npcPhrase == $"{Main.player[Main.myPlayer].name}...just between us, I think I forgot my soul in the ice castle. If you see it, please do let me know.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.DIFL.21"), Main.player[Main.myPlayer].name);
                }
            }
            else if (TalkingNpc == DrunkPrincess)
            {
                switch (npcPhrase)
                {
                    case
                        "Why are you talking to me right now? Either way, I expect you to turn in a perfect performance!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.1");
                        break;
                    case "I could smell my vodka from MILES away!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.2");
                        break;
                    case "Have any spare rooms available? Preferably candle-lit with a hefty supply of booze.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.3");
                        break;
                    case "Hey, nice night! I'm gonna make some Bloody Marys, celery included. Want one?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.4");
                        break;
                    case "More blood for the blood gods!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.5");
                        break;
                    case
                        "Everyone else is so rude tonight. If they don't get over it soon, I'll break down their doors and make them!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.6");
                        break;
                    case "Being drunk, I have no moral compass atm.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.7");
                        break;
                    case
                        "Nothard/10, if I fight bosses I wanna feel like screaming 'OH YES DADDY!' while I die repeatedly.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.8");
                        break;
                    case "Like I always say, when you're drunk you can tolerate annoying people a lot more easily...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.9");
                        break;
                    case "I'm literally balls drunk off my sass right now.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.10");
                        break;
                    case "I'm either laughing because I'm drunk or because I've lost my mind. Probably both.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.11");
                        break;
                    case "When I'm drunk I'm way happier...at least until the talking worms start to appear.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.12");
                        break;
                    case "I should reprogram the whole game while drunk and send it back to the testers.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.13");
                        break;
                    case "What a great day, might just drink so much that I get poisoned again.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.14");
                        break;
                    case "A perfect night...for alcohol! First drinks are on me!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.15");
                        break;
                    case "Here's a challenge...take a drink whenever you get hit. Oh wait, you'd die.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.16");
                        break;
                    case
                        "Well I was planning to light some candles in order to relax...ah well, time to code while drunk.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.17");
                        break;
                    case "Yes, everyone knows the mechworm is buggy. Well, not so much anymore, but still.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.18");
                        break;
                    case "Are you sure you're 21? ...alright, fine, but don't tell anyone I sold you this.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.20");
                        break;
                    case "Drink something that turns you into a magical flying unicorn so you can be super gay.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.21");
                        break;
                    case
                        "You'll always find me at parties where booze is involved...well, you'll always find booze where I'm involved.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.22");
                        break;
                    case "Shoot down the space invaders! Sexy time will be postponed if we are invaded by UFOs!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.23");
                        break;
                    case "God I can't wait to beat on some ice again!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.24");
                        break;
                    case
                        "The only things I'm attracted to are fish women, women, men who look like women and that's it.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.25");
                        break;
                    case "I'll always be watching.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.26");
                        break;
                    case "Why did that weird monster need that many tentacles? ...actually, don't answer that.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.27");
                        break;
                    case "There's chemicals in the water...and they're turning the frogs gay!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.28");
                        break;
                    case
                        "I saw a ghost down by the old train tracks once, flailing wildly at the lily pads, those were the days.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.29");
                        break;
                    case
                        "I hear it's amazing when the famous purple-stuffed worm out in flap-jaw space, with the tuning fork, does a raw blink on Hara-kiri rock. I need scissors! 61!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.30");
                        break;
                    case "Is that a toy? Looks like something I'd carry around if I was 5 years old.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.38");
                        break;
                    case "Nice scales...did it get hot in here?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.39");
                        break;
                    case
                        "Oh yeah, now you're drinking the good stuff! Do you like it? I created the recipe by mixing fairy dust, crystals and other magical crap.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.40");
                        break;
                    case "So...you're riding me, huh? That's not weird at all.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.41");
                        break;
                    case "Are you coming on to me?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.42");
                        break;
                    case
                        "If I was a magical horse, I'd be out in space, swirling cocktails, as I watch space worms battle for my enjoyment.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.43");
                        break;
                    case "Did anyone ever tell you that large assets cause back pain? Well, they were right.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.FAP.44");
                        break;
                }
                if (npcPhrase == $"That's west, {Main.player[Main.myPlayer].name}. You're fired again.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.FAP.19"), Main.player[Main.myPlayer].name);
                }
                else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} time.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.FAP.45"), npcPhrase.Split(' ')[3]);
                }
                else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.FAP.46"), npcPhrase.Split(' ')[3]);
                }
                if (Bartender.IsExistingNPC())
                {
                    if (npcPhrase == $"Tell {Main.npc[Bartender].GivenName} to stop calling me. He's not wanted.")
                    {
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.FAP.31"), Main.npc[Bartender].GivenName);
                    }
                    else if (npcPhrase == $"My booze will always be better than {Main.npc[Bartender].GivenName}'s, and nobody can convince me otherwise.")
                    {
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.FAP.32"), Main.npc[Bartender].GivenName);
                    }
                }
                if (Archmage.IsExistingNPC() && npcPhrase == $"I never realized how well-endowed {Main.npc[Archmage].GivenName} was. It had to be the largest icicle I had ever seen.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.FAP.33"), Main.npc[Archmage].GivenName);
                }
                if (Stylist.IsExistingNPC())
                {
                    if (npcPhrase == $"You still can't stop me from trying to move in with {Main.npc[Stylist].GivenName}.")
                    {
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.FAP.34"),
                            Main.npc[Stylist].GivenName);
                    }
                    else if (npcPhrase == $"I love it when {Main.npc[Stylist].GivenName}'s hands get sticky from all that...wax.")
                    {
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.FAP.35"),
                            Main.npc[Stylist].GivenName);
                    }
                    else if (npcPhrase == $"{Main.npc[Stylist].GivenName} works wonders for my hair...among other things.")
                    {
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.FAP.36"),
                            Main.npc[Stylist].GivenName);
                    }
                    else if (npcPhrase == $"Ever since {Main.npc[Stylist].GivenName} moved in I haven't been drinking as much...it's a weird feeling.")
                    {
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.FAP.37"),
                            Main.npc[Stylist].GivenName);
                    }
                }
                if (npcPhrase.Contains("...wait, who are you again?"))
                {
                    npcPhrase = npcPhrase
                        .Replace("Hey", "Привет Eternity, osaka_drift, ILLIK,")
                        .Replace(" and ", "и")
                        .Replace("! You're all pretty good! ...wait, who are you again?", "! Вы все очень хороши! ...подожди, а ты кто такой?");
                }
            }
            else if (TalkingNpc == SeaKing)
            {
                switch (npcPhrase)
                {
                    case "My homeland may have dried up but the memories of my people still remain. I will not let them be in vain.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.1");
                        break;
                    case "There is a lot that you do not know about this world, specifically regarding the past. Much of it has been lost to history due to the many wars that plagued it.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.2");
                        break;
                    case "How can I survive on land? Ah, that is a secret. No, actually...I can breathe air like you!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.3");
                        break;
                    case "Why do you ask if it's the males that carry the young? Don't your males carry their young?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.4");
                        break;
                    case "There be monsters lurking in the darkness. Most...unnatural monsters.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.5");
                        break;
                    case "Most creatures look up at the moon and admire it. I look up and fear it.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.6");
                        break;
                    case "Oh, me? I don't sleep, it's part of my nature.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.7");
                        break;
                    case "I'm never keen on these nights. They're so violent.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.12");
                        break;
                    case "Ah, nice duds, my child!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.13");
                        break;
                    case "Shouldn't you be wearing a clam bra?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.14");
                        break;
                    case "The balance between light and dark is tipping. Stay strong, my child.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.15");
                        break;
                    case "Ah, you are starting to realize just how complicated this world is now. You are learning the story of what became of him.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.16");
                        break;
                    case "Do you ever get the feeling that something out there is watching you very carefully? Whatever it is, it's very small and sly, I think.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.17");
                        break;
                    case "I must admit, I am quite shaken up now. Never would I have imagined that I would see one of the dark gods again. Not in this lifetime anyhow.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.18");
                        break;
                    case "Times like this I wish my home was still in one piece instead of evaporated away. I don't blame the witch for anything, it's just...oh, never mind.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.19");
                        break;
                    case "I suppose that witch was mistaken. Defeating the Ceaseless Void and the Devourer has not caused our world to collapse... but I would not lower my guard if I were you.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.20");
                        break;
                    case "Is this...what the world is like now? It seems so much more lifeless than when I saw it before I disappeared.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.21");
                        break;
                    case "Thank you for your service, my child, but I am afraid I am without a home now.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.22");
                        break;
                    case "If this shows up, something went wrong.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.23");
                        break;
                    case "Draedon's style of confrontation is very...alien and hands-off. You may be more likely to fight any one of his mechs before taking him down.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.24");
                        break;
                    case "Lord Yharim possesses god-like strength. He may not even fight you at full power which is fortunate for you. His attacks may just kill you in one hit, so be careful.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.25");
                        break;
                    case "Pockets of ore have appeared once more in the land. This will allow you to create the most powerful weaponry and armor imagined!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.26");
                        break;
                    case "Ah, the dragon Yharon is fickle. You may find that he will refuse to use his full power unless you are strong enough to unleash the power of the Dark Sun.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.27");
                        break;
                    case "The Devourer of Gods is extremely powerful. However, he is young, foolhardy, and very lazy. Perhaps if he had been given time to develop he would have turned into quite the threat.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.28");
                        break;
                    case "With the cosmic steel you can fashion many of your weapons into much more powerful forms.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.29");
                        break;
                    case "The Devourer of God's cosmic armor is unique in that it is capable of not only protecting his body from tearing itself apart when ripping through the fabric of space and time, but also allows him to control his powers.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.30");
                        break;
                    case "Ah...I can sense a powerful change in the weather. You may want to venture to the Sulphurous Seas once more during the rain to experience it.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.31");
                        break;
                    case "The Abyss holds many secrets revealed with time. Checking it out again may not be a bad idea.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.32");
                        break;
                    case "The Dungeon seems to be more active now. You may hear the faint whisperings of angry spirits who have not left to the Void...I would recommend searching there before taking on the Sentinels.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.33");
                        break;
                    case "Ironic, is it not, that Statis was defeated by the very Sentinel his people fashioned their art of stealth from. Fate so often weaves cruel tales.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.34");
                        break;
                    case "The Rune of Kos holds a significant portion of Providence's brand of magic, easily distinguishable from all others. Activating it in certain places would have some...risky consequences.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.35");
                        break;
                    case "The stories have it that when Providence faced and defeated Yharim and his forces she lost a lot of energy and reverted to a more skeletal form. She's merely a fraction of the power she was before.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.36");
                        break;
                    case "Providence is as much the sun goddess as much as the Moon Lord is the moon god. They are two sides of the same coin, choosing to remain neutral amongst our petty squabbles.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.37");
                        break;
                    case "Touching Providence's offerings is usually a death wish. Shame that Yharim didn't think to just mess with her things to get her out of hiding.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.38");
                        break;
                    case "The Profaned Guardians will do anything to protect their goddess. Makes sense they would die for her since they can be revived just as quickly.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.39");
                        break;
                    case "Profaned creatures now lurk in the Hallow and in Hell. If you destroy enough and gather their essence together you shall be able to capture the attention of the Profaned Guardians.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.40");
                        break;
                    case "Your adventure focuses to the jungle it seems. The Dragonfolly and its swarming offspring should be eliminated before their numbers spiral out of control.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.41");
                        break;
                    case "The plague was just one of the many experiments authorized by Yharim to raze towns to the ground. This is probably one of the few he shelved for being too terrible.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.42");
                        break;
                    case "The Abyss has become far more active than before. You might be able to mine some of the volcanic rubble contained within.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.43");
                        break;
                    case "The men at the front of the dungeon are performing a ritual to keep the Moon Lord contained in his prison. In order to gain Yharim's attention, however, you may need to defeat them.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.44");
                        break;
                    case "When exploring the jungle temple be careful. You may not wish to disturb the Lihzard's idol, the Golem. It's quite the destructive force.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.45");
                        break;
                    case "Be careful when defeating Plantera and the Golem. You might accidentally unleash a new threat in the jungle that needs to be quelled.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.46");
                        break;
                    case "If you've gathered the souls used to power those automatons head once more to the jungle. You will find a powerful enemy to fight, which will unleash the full fervor of the jungle once defeated. Do not underestimate it!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.47");
                        break;
                    case "The Brimstone Crags...Yharim despised that place, and did everything he could to raze it to the ground. It might explain a few things about him.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.48");
                        break;
                    case "If you take an idol down to the Brimstone Crags you might be able to see just what is lurking in the shadows.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.49");
                        break;
                    case "Once those mechanical creations have been defeated you would do well to seek out the crippled clone of the witch, Calamitas. It might provide some useful weaponry.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.50");
                        break;
                    case "I would recommend saving some of your old items. You never know if you can engineer them into stronger weapons in the future.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.51");
                        break;
                    case "Have you heard of the story of Archmage Permafrost? Rumor has it he's been locked away in an icy prison by Lord Yharim. Perhaps you would be able to free him if Cryogen was destroyed.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.52");
                        break;
                    case "You will find more ores have been unlocked due to the magic sealing them away being dispelled. Some of them may require more than just the ore itself to create.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.53");
                        break;
                    case "Throughout the world lie various structures left behind by Draedon. Archaic defenses may remain, but the goods inside may be worth your while.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.54");
                        break;
                    case "The Crimson used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.55");
                        break;
                    case "The Corruption used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.56");
                        break;
                    case "The dungeon is a dark place. None of us know of its true purpose, however, the ancient Eidolist cultists used it for worship before Lord Yharim took it over.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.57");
                        break;
                    case "I'm assuming you've heard the legends that speak of the ninja, Statis? There are some who say that if you were able to defeat the gods which his clan once worshipped you would be able to harness some of his powers.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.58");
                        break;
                    case "Scattered across the lands are shrines dedicated to the gods. You can take whatever is in them, but a few items you may not be able to use until much later.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.59");
                        break;
                    case "Be careful what you attack in the Crimson. You might just unveil a greater threat than what was there before.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.60");
                        break;
                    case "Be careful what you attack in the Corruption. You might just unveil a greater threat than what was there before.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.61");
                        break;
                    case "The Sulphurous Seas were created long ago, when Yharim's dungeon could no longer hold as many corpses as it needed to. Many of the bodies were dumped into the ocean. This, along with severe pollution from the heydays of Draedon's experiments have turned a paradise into a wasteland.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.62");
                        break;
                    case "The Sulphurous Seas are dangerous. The toxic waters will burn your skin, but if you can brave them you will be able to reach the Abyss, where there are powerful weapons and dangers aplenty.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.63");
                        break;
                    case "Ah yes, the Abyss. That trench is full of powerful creatures that could devour you in a heartbeat. I would explore the dungeon first.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.64");
                        break;
                    case "Have you heard of the Brimstone Crags? It was once a grand kingdom, not too different from my own. However, it also met a similar fate. I would not advise going down there, unless you seek a painful death.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.65");
                        break;
                    case "There are rumors of ores that lay in latency. When you defeat certain bosses you will undo the ancient magic which conceals those materials.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.66");
                        break;
                }
                if (PartyGirl.IsExistingNPC() && npcPhrase == $"{Main.npc[PartyGirl].GivenName} asked if my nose could be used as a vuvuzela. What is a vuvuzela?")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.8"), Main.npc[PartyGirl].GivenName);
                }
                if (Angler.IsExistingNPC())
                {
                    if (npcPhrase == $"Meet me at {Main.npc[Angler].GivenName}'s house at night. We're going to throw him to the Trashers.")
                    {
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.9"), Main.npc[Angler].GivenName);
                    }
                    else if (npcPhrase == $"Not sure how {Main.npc[Angler].GivenName} has not been roasted and digested by now, hanging around the sulphuric seas for so long. Perhaps it got to his head.")
                    {
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.10"), Main.npc[Angler].GivenName);
                    }
                }
                if (DrunkPrincess.IsExistingNPC() && npcPhrase == $"Rumor has it {Main.npc[DrunkPrincess].GivenName} drinks to forget her troubled past.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.SEAHOE.11"), Main.npc[DrunkPrincess].GivenName);
                }
            }
            else if (TalkingNpc == Bandit)
            {
                switch (npcPhrase)
                {
                    case "Oy, watch where you're going or I might just use you for dart practice.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.1");
                        break;
                    case "Bet you'd look good as a pincushion, amiright?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.2");
                        break;
                    case "Zombies don't dodge very well. Maybe you'll do a bit better.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.3");
                        break;
                    case "Hey, careful over there. I've rigged the place. One wrong step and you're going to get a knife in your forehead.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.4");
                        break;
                    case "You know what's really cool? Watching the glint of throwing stars as they reflect the moon.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.5");
                        break;
                    case "You think those stars that fall occasionally would make good throwing weapons?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.6");
                        break;
                    case "Statis' clan's got nothing on me. Mostly cause they're all dead.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.7");
                        break;
                    case "Where is my party hat? Well, I stole it of course.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.8");
                        break;
                    case "The nice thing about maps is I can track anything that has fallen.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.9");
                        break;
                    case "Imagine how fast you could throw if you just had more hands.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.10");
                        break;
                    case "I also take food for currency.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.11");
                        break;
                    case "Usually I only think of animals as food or target practice, but dragons are an exception.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.12");
                        break;
                    case "Anything is a weapon if you throw it hard enough.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.13");
                        break;
                    case "That's your chucking arm? You need to work out more.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.14");
                        break;
                    case "Listen here. It's all in the wrist, the wrist! Oh, forget it.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.15");
                        break;
                    case "I don't think Mom and Dad are proud of the job I have right now.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.16");
                        break;
                    case "Eh you know how it goes; steal from the rich, give to the poor. Of course, for a price.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.17");
                        break;
                    case "Want to hear about this one time I was stuck in a room with a rabid dog and a dead guy?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.18");
                        break;
                    case "Argh snakes. For some reason it's always snakes.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.19");
                        break;
                    case "Maybe I'm bitter. It's been a long time, so whatever. Just do a good job out there.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.20");
                        break;
                    case "It's not stealing! I'm just borrowing it until I die!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.21");
                        break;
                    case "Wouldn't be the first time I used my friends' remains as weapons.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.22");
                        break;
                    case "With all of this new stuff cropping up, looks like we got some easy loot and new items to craft up, eh? Well, YOU craft them, I'll steal em.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.23");
                        break;
                    case "Draedon thinks he can build awesome machines, but he doesn't know how much crap I've stolen from him and sold by dismantling his drones.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.24");
                        break;
                    case "Gramma always said never to invade ancient temples or you'll be cursed and die. Let's say both of us attest that is untrue. We're still alive. Somewhat.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.25");
                        break;
                    case "I heard that there's some really neat and awesome rogue items you can get. Show em to me if you ever get the time.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.26");
                        break;
                    case "Providence HATES it when you take her stuff. I learned that the hard way.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.27");
                        break;
                    case "You think I can get away with looting from ghosts? It ain't like they can pick things up.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.28");
                        break;
                    case "Oh man, did you rip that off a shark!? Now that's a weapon!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.29");
                        break;
                    case "I tried looting Storm Weaver's armor once. Before I could get a chunk of the stuff... well let's just say the bigger, fatter cosmic worm arrived and it didn't end well.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.30");
                        break;
                    case "I'd rather not be here. This place has bad vibes, y'know? It brings back some unpleasant memories.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.31");
                        break;
                    case "Hey, if government officials can get tax, why can't I? The heck do you mean that these two things are nothing alike?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.36");
                        break;
                    case "Sorry, I got nothing. Perhaps you could reforge something and come back later...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.37");
                        break;
                }
                if (Merchant.IsExistingNPC() && npcPhrase == $"Don't tell {Main.npc[Merchant].GivenName}, but I took some of his stuff and replaced it with Angel Statues.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.32"), Main.npc[Merchant].GivenName);
                }
                if (DrunkPrincess.IsExistingNPC() && npcPhrase == $"I learned never to steal {Main.npc[DrunkPrincess].GivenName}'s drinks. She doesn't appreciate me right now so I'll go back to hiding.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.33"), Main.npc[DrunkPrincess].GivenName);
                }
                if (ArmsDealer.IsExistingNPC() && Nurse.IsExistingNPC() && npcPhrase == $"Don't tell {Main.npc[Nurse].GivenName} that I was responsible for {Main.npc[ArmsDealer].GivenName}'s injuries.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.34"),
                        Main.npc[Nurse].GivenName, Main.npc[ArmsDealer].GivenName);
                }
                if (GoblinTinkerer.IsExistingNPC() && npcPhrase == $"Want in on a little secret? Since {Main.npc[GoblinTinkerer].GivenName} always gets so much cash from you, I've been stealing some of it as we go. I need you to keep quiet about it, so here.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.THIEF.35"), Main.npc[GoblinTinkerer].GivenName);
                }
            }
            else if (TalkingNpc == Merchant)
            {
                switch (npcPhrase)
                {
                    case "Each night seems only more foreboding than the last. I feel unthinkable terrors are watching your every move.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Merchant.1");
                        break;
                    case "Are you daft?! Turn off those lamps!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Merchant.2");
                        break;
                    case "If this acid rain keeps up, there'll be a shortage of Dirt Blocks soon enough!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Merchant.3");
                        break;
                    case "I happen to have several Angel Statues at the moment, a truely rare commodity. Want one?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Merchant.4");
                        break;
                    case "The caverns have become increasingly dark as of late, so I stocked up on some special torches if you have the funds.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Merchant.5");
                        break;
                }
            }
            else if (TalkingNpc == ArmsDealer)
            {
                switch (npcPhrase)
                {
                    case "That's the biggest moth I've ever seen for sure. You'd need one big gun to take one of those down.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.ArmsDealer.1");
                        break;
                    case "Is it me or are your weapons getting bigger and bigger?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.ArmsDealer.2");
                        break;
                }
            }
            else if (TalkingNpc == Dryad)
            {
                switch (npcPhrase)
                {
                    case "There's a dark solar energy emanating from the moths that appear during this time. Ah, the moths as you progress further get more powerful...hmm...what power was Yharon holding back?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Dryad.1");
                        break;
                    case "That starborne illness sits upon this land like a blister. Do even more vile forces of corruption exist in worlds beyond?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Dryad.2");
                        break;
                    case "My ancestor was lost here long ago. I must pay my respects to her.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Dryad.4");
                        break;
                    case "\u0093I'm not here for any reason! Just picking up mushrooms for uh, later use.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Dryad.5");
                        break;
                }
                if (DrunkPrincess.IsExistingNPC() && npcPhrase == $"{Main.npc[DrunkPrincess].GivenName} put me up to this.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.Dryad.3"), Main.npc[DrunkPrincess].GivenName);
                }
            }
            else if (TalkingNpc == Guide)
            {
                switch (npcPhrase)
                {
                    case "Could you be so kind as to, ah...check hell for me...? I left someone I kind of care about down there.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Guide.1");
                        break;
                    case "I have this sudden shiver up my spine, like a meteor just fell and thousands of innocent creatures turned into monsters from the stars.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Guide.2");
                        break;
                    case "The dungeon seems even more restless than usual, watch out for the powerful abominations stirring up in there.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Guide.3");
                        break;
                    case "Seems like extinguishing that butterfly caused its life to seep into the hallowed areas, try taking a peek there and see what you can find!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Guide.4");
                        break;
                    case "I've heard there is a portal of antimatter absorbing everything it can see in the dungeon, try using the Rune of Kos there!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Guide.5");
                        break;
                }
            }
            else if (TalkingNpc == Demolitionist)
            {
                if (npcPhrase == "God Slayer Dynamite? Boy do I like the sound of that!")
                {
                    npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Demolitionist.1");
                }
            }
            else if (TalkingNpc == Clothier)
            {
                switch (npcPhrase)
                {
                    case "Who you gonna call?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Clothier.1");
                        break;
                    case "Those screams...I'm not sure why, but I feel like a nameless fear has awoken in my heart.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Clothier.2");
                        break;
                    case "I can faintly hear ghostly shrieks from the dungeon...and not ones I'm familiar with at all. Just what is going on in there?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Clothier.3");
                        break;
                    case "Whatever that thing was, I'm glad it's gone now.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Clothier.4");
                        break;
                    case "Houston, we've had a problem.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Clothier.5");
                        break;
                }
            }
            else if (TalkingNpc == GoblinTinkerer)
            {
                switch (npcPhrase)
                {
                    case "You know...we haven't had an invasion in a while...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.GoblinTinkerer.2");
                        break;
                }
                if (Bandit.IsExistingNPC() && npcPhrase == $"Hey, is it just me or have my pockets gotten lighter ever since {Main.npc[Bandit].GivenName} arrived?")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.GoblinTinkerer.1"), Main.npc[Bandit].GivenName);
                }
            }
            else if (TalkingNpc == Wizard)
            {
                switch (npcPhrase)
                {
                    case "Space just got way too close for comfort.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Wizard.2");
                        break;
                }
                if (Archmage.IsExistingNPC())
                {
                    if (npcPhrase == $"I'd let {Main.npc[Archmage].GivenName} coldheart MY icicle.")
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.Wizard.1"), Main.npc[Archmage].GivenName);
                }
            }
            else if (TalkingNpc == Mechanic)
            {
                switch (npcPhrase)
                {
                    case "What do you mean your traps aren't making the cut? Don't look at me!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Mechanic.1");
                        break;
                    case "Um...should my nightlight be on?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Mechanic.2");
                        break;
                    case "Maybe I should've waterproofed my gadgets... They're starting to corrode.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Mechanic.4");
                        break;
                }
                if (DrunkPrincess.IsExistingNPC())
                {
                    if (npcPhrase == $"Well, I like {Main.npc[DrunkPrincess].GivenName}, but I, ah...I have my eyes on someone else.")
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.Mechanic.3"), Main.npc[DrunkPrincess].GivenName);
                }
            }
            else if (TalkingNpc == Truffle)
            {
                switch (npcPhrase)
                {
                    case "I don't feel very safe; I think there's pigs following me around and it frightens me.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Truffle.1");
                        break;
                }
                if (DrunkPrincess.IsExistingNPC())
                {
                    if (npcPhrase == $"Sometimes, {Main.npc[DrunkPrincess].GivenName} just looks at me funny and I'm not sure how I feel about that.")
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.Mechanic.2"), Main.npc[DrunkPrincess].GivenName);
                }
            }
            else if (TalkingNpc == Steampunk)
            {
                switch (npcPhrase)
                {
                    case "Just what is that contraption? It makes my Teleporters look like child's play!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Steampunker.1");
                        break;
                    case "Yep! I'm also considering being a space pirate now.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Steampunker.2");
                        break;
                    case "Some of my machines are starting to go haywire thanks to this Astral Infection. I probably shouldn't have built them here":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Steampunker.3");
                        break;
                    case "I'm sorry I really don't have any Unicorn proof tech here, you're on your own.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Steampunker.4");
                        break;
                }
            }
            else if (TalkingNpc == DyeTrader)
            {
                switch (npcPhrase)
                {
                    case "Have you seen those gemstone creatures in the caverns? Their colors are simply breathtaking!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.DyeTrader.1");
                        break;
                }
                if (Archmage.IsExistingNPC() && npcPhrase == $"Do you think {Main.npc[Archmage].GivenName} knows how to 'let it go?'")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.DyeTrader.2"), Main.npc[Archmage].GivenName);
                }
            }
            else if (TalkingNpc == PartyGirl)
            {
                switch (npcPhrase)
                {
                    case "I think my light display is turning into an accidental bug zapper. At least the monsters are enjoying it.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.PartyGirl.2");
                        break;
                    case "Ooh! I love parties where everyone wears a scary costume!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.PartyGirl.3");
                        break;
                }
                if (DrunkPrincess >= 0 && npcPhrase == $"I have a feeling we're going to have absolutely fantastic parties with {Main.npc[DrunkPrincess].GivenName} around!")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.PartyGirl.1"), Main.npc[DrunkPrincess].GivenName);
                }
            }
            else if (TalkingNpc == Cyborg)
            {
                switch (npcPhrase)
                {
                    case "All these moments will be lost in time. Like tears...in the rain.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Cyborg.1");
                        break;
                    case "Always shoot for the moon! It has clearly worked before.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Cyborg.2");
                        break;
                    case "Draedon? He's...a little 'high octane' if you know what I mean.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Cyborg.3");
                        break;
                    case "Those oversized bugs terrorizing the jungle... Surely you of all people could shut them down!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Cyborg.4");
                        break;
                }
            }
            else if (TalkingNpc == Painter)
            {
                switch (npcPhrase)
                {
                    case "A little sickness isn't going to stop me from doing my work as an artist!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Painter.1");
                        break;
                    case "There's a surprising art to this area. A sort of horrifying, eldritch feeling. It inspires me!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Painter.2");
                        break;
                    case "I'm not exactly suited for this cold weather. Still looks pretty, though.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Painter.3");
                        break;
                    case "I hate sand. It's coarse, and rough and gets in my paint.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Painter.5");
                        break;
                    case "Do you think unicorn blood could be used as a good pigment or resin? No I'm not going to find out myself.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Painter.6");
                        break;
                    case "I can't work in this environment. All of my paint just floats off.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Painter.7");
                        break;
                    case "Painting the tortoises in a still life isn't going so well.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Painter.8");
                        break;
                    case "I can't paint a still life if the fruit grows legs and walks away.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Painter.9");
                        break;
                    case "On the canvas, things get heated around here all the time. Like the environment!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Painter.10");
                        break;
                    case "Sorry, I'm all out of watercolors. They keep evaporating.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Painter.11");
                        break;
                    case "Roses, really? That's such an overrated thing to paint.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Painter.12");
                        break;
                    case "Fun fact! Sulphur was used as pigment once upon a time! Or was it Cinnabar?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Painter.13");
                        break;
                    case "Easiest landscape I've ever painted in my life.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Painter.14");
                        break;
                }
                if (Archmage >= 0 && npcPhrase == $"Think {Main.npc[Archmage].GivenName} would let me paint him like one of his French girls?!")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.PartyGirl.4"), Main.npc[Archmage].GivenName);
                }
            }
            else if (TalkingNpc == WitchDoctor)
            {
                switch (npcPhrase)
                {
                    case "My home here has an extensive history and a mysterious past. You'll find out quickly just how extensive it is...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.WitchDoctor.1");
                        break;
                    case "I have unique items if you show me that you have bested the guardian of this jungle.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.WitchDoctor.2");
                        break;
                    case "This is as good a time as any to pick up the best ingredients for potions.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.WitchDoctor.3");
                        break;
                }
            }
            else if (TalkingNpc == Pirate)
            {
                switch (npcPhrase)
                {
                    case "Aye, I've heard of a mythical creature in the oceans, singing with an alluring voice. Careful when yer fishin out there.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Pirate.1");
                        break;
                    case "I have to thank ye again for takin' care of that sea serpent. Or was that another one...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Pirate.2");
                        break;
                    case "Twenty-nine bottles of beer on the wall...":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Pirate.4");
                        break;
                    case "Now this is a scene that I can admire any time! I feel like something is watching me though.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Pirate.5");
                        break;
                    case "It ain't much of a sight, but there's still life living in these waters.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Pirate.6");
                        break;
                    case "Me ship might just sink from the acid alone.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Pirate.7");
                        break;
                }
                if (SeaKing.IsExistingNPC() && npcPhrase == $"I remember legends about that {Main.npc[SeaKing].GivenName}. He ain't quite how the stories make him out to be though.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.Pirate.3"), Main.npc[SeaKing].GivenName);
                }
            }
            else if (TalkingNpc == Stylist)
            {
                switch (npcPhrase)
                {
                    case "Please don't catch space lice. Or Crimson lice. Or just lice in general.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Stylist.1");
                        break;
                    case "Please don't catch space lice. Or Corruption lice. Or just lice in general.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Stylist.2");
                        break;
                    case "They look so cute and yet, I can feel their immense power just by being near them. What are you?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Stylist.5");
                        break;
                    case "I hate to break it to you, but you don't have hair to cut or style, hun.":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Stylist.6");
                        break;
                    case "Aww, they're so cute, do they have names?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Stylist.7");
                        break;
                }
                if (DrunkPrincess.IsExistingNPC())
                {
                    if (npcPhrase == $"Sometimes I catch {Main.npc[DrunkPrincess].GivenName} sneaking up from behind me.")
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.Stylist.3"), Main.npc[DrunkPrincess].GivenName);
                    else if (npcPhrase == $"{Main.npc[DrunkPrincess].GivenName} is always trying to brighten my mood...even if, deep down, I know she's sad.")
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.Stylist.4"), Main.npc[DrunkPrincess].GivenName);
                }
            }
            else if (TalkingNpc == TravellingMerchant)
            {
                if (DrunkPrincess.IsExistingNPC() && Merchant.IsExistingNPC() && npcPhrase == $"Tell {Main.npc[DrunkPrincess].GivenName} I'll take up her offer and meet with her at the back of {Main.npc[Merchant].GivenName}'s house.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.TravellingMerchant.1"), Main.npc[DrunkPrincess].GivenName, Main.npc[Merchant].GivenName);
                }
            }
            else if (TalkingNpc == Angler)
            {
                if (SeaKing.IsExistingNPC())
                {
                    if (npcPhrase == $"Someone tell {Main.npc[SeaKing].GivenName} to quit trying to throw me out of town, it's not going to work.")
                    {
                        npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.Angler.1"), Main.npc[SeaKing].GivenName);
                    }
                }
            }
            else if (TalkingNpc == TaxCollector)
            {
                switch (npcPhrase)
                {
                    case "BAH! Doesn't seem like I'll ever be able to quarrel with the debts of the town again!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.TaxCollector.1");
                        break;
                    case "Where and how are you getting all of this money?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.TaxCollector.2");
                        break;
                    case "Perhaps with all that time you've got you could check those old ruins? Certainly something of value in it for you!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.TaxCollector.3");
                        break;
                    case "Devourer of what, you said? Devourer of Funds, if its payroll is anything to go by!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.TaxCollector.4");
                        break;
                    case "Goodness! That cane has swagger!":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.TaxCollector.5");
                        break;
                }
            }
            else if (TalkingNpc == SkeletonMerchant)
            {
                switch (npcPhrase)
                {
                    case "What'dya buyin'?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.SkeletonMerchant.1");
                        break;
                }
            }
            else if (TalkingNpc == Bartender)
            {
                switch (npcPhrase)
                {
                    case "Care for a little Moonshine?":
                        npcPhrase = LangUtils.TranslationKey("Calamity.NpcChatText.Bartender.1");
                        break;
                }
                if (DrunkPrincess.IsExistingNPC() && npcPhrase == $"Sheesh, {Main.npc[DrunkPrincess].GivenName} is a little cruel, isn't she? I never claimed to be an expert on anything but ale!")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Calamity.NpcChatText.Bartender.2"), Main.npc[DrunkPrincess].GivenName);
                }
            }
            Main.npcChatText = npcPhrase;
        }
    }
}