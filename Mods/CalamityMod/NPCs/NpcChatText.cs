using CalamityMod;
using CalamityRuTranslate.Utilities;
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
            int guide = NPC.FindFirstNPC(NPCID.Guide);
            int demolitionist = NPC.FindFirstNPC(NPCID.Demolitionist);
            int clothier = NPC.FindFirstNPC(NPCID.Clothier);
            int wizard = NPC.FindFirstNPC(NPCID.Wizard);
            int mechanic = NPC.FindFirstNPC(NPCID.Mechanic);
            int truffle = NPC.FindFirstNPC(NPCID.Truffle);
            int steampunker = NPC.FindFirstNPC(NPCID.Steampunker);
            int dyeTrader = NPC.FindFirstNPC(NPCID.DyeTrader);
            int cyborg = NPC.FindFirstNPC(NPCID.Cyborg);
            int painter = NPC.FindFirstNPC(NPCID.Painter);
            int witchDoctor = NPC.FindFirstNPC(NPCID.WitchDoctor);
            int pirate = NPC.FindFirstNPC(NPCID.Pirate);
            int travellingMerchant = NPC.FindFirstNPC(NPCID.TravellingMerchant);
            int taxCollector = NPC.FindFirstNPC(NPCID.TaxCollector);
            int skeletonMerchant = NPC.FindFirstNPC(NPCID.SkeletonMerchant);
            int difl = NPC.FindFirstNPC(CoreCalamityTranslation.CalamityMod.NPCType("DILF"));
            int fap = NPC.FindFirstNPC(CoreCalamityTranslation.CalamityMod.NPCType("FAP"));
            int seahoe = NPC.FindFirstNPC(CoreCalamityTranslation.CalamityMod.NPCType("SEAHOE"));
            int thief = NPC.FindFirstNPC(CoreCalamityTranslation.CalamityMod.NPCType("THIEF"));
            bool flag = Main.player[Main.myPlayer].talkNPC >= 0;

            if (difl >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "I must admit...I am not quite used to this weather. It's too warm for my taste...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.1");
                        break;
                    case "My dear! What is it you would like to talk about today?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.2");
                        break;
                    case "Why...I don't have to worry about any time of the day! If it is hot...then I can use my ice magic to cool down!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.3");
                        break;
                    case "I do usually prefer a spot of humidity for my ice magic. It likes to come out as steam when it's too hot and dry...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.4");
                        break;
                    case "Magic is a skill that must be learned and practiced! You seem to have an inherent talent for it at your age. I have spent all of my life honing it...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.5");
                        break;
                    case "Why ice magic, you ask? Well, my parents were both pyromaniacs...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.6");
                        break;
                    case "There be monsters lurking in the darkness. Most...unnatural monsters.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.7");
                        break;
                    case "You could break the icy stillness in the air tonight.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.8");
                        break;
                    case "Hmm...some would say that an unforeseen outside force is the root of the blood moon...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.9");
                        break;
                    case "I was once the greatest Archmage of ice that ever hailed the lands. Whether or not that is still applicable, I am not sure...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.10");
                        break;
                    case "There used to be other Archmages of other elements. I wonder where they are now...if they are also alive...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.11");
                        break;
                    case "Oh...I wish I could tell you all about my life and the lessons I have learned, but it appears you have a great many things to do...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.12");
                        break;
                    case "I assure you, I will do my best to act as the cool grandfather figure you always wanted.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.13");
                        break;
                    case "Sometimes...I feel like all I'm good for during these events is making ice cubes and slushies.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.14");
                        break;
                    case "Tread carefully, my friend... Now that the Moon Lord has been defeated, many powerful creatures will crawl out to challenge you...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.15");
                        break;
                    case "I feel the balance of nature tilting farther than ever before. Is it due to you, or because of the events leading to now...?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.16");
                        break;
                    case "I felt a sudden chill down my spine. I sense something dangerous stirring in the Abyss...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.17");
                        break;
                    case "...Where is Lord Yharim? He must be up to something...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.18");
                        break;
                    case "What an adorable tiny companion you have! Where in the world did you find such a...creature...? Actually, I'd rather not know.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.20");
                        break;
                    case "It wouldn't be the first time something unknown and powerful dropped from the heavens...I would tread carefully if I were you...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.22");
                        break;
                    case "I deeply appreciate you rescuing me from being trapped within my frozen castle... It's been many, many years...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.23");
                        break;
                    case "Thank you for saving me...though now I admit I am without a home since mine got destroyed.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DIFL.24");
                        break;
                }
                
                if (dryad >= 0)
                {
                    if (Main.npcChatText == $"Yes, I am older than {Main.npc[dryad].GivenName}. You can stop asking now...")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.DIFL.19"), Main.npc[dryad].GivenName) ;
                }
                if (Main.npcChatText == $"{Main.player[Main.myPlayer].name}...just between us, I think I forgot my soul in the ice castle. If you see it, please do let me know.")
                    Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.DIFL.21"), Main.player[Main.myPlayer].name);
            }

            if (fap >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "Why are you talking to me right now? Either way, I expect you to turn in a perfect performance!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.1");
                        break;
                    case "I could smell my vodka from MILES away!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.2");
                        break;
                        case "Have any spare rooms available? Preferably candle-lit with a hefty supply of booze.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.3");
                        break;
                    case "Hey, nice night! I'm gonna make some Bloody Marys, celery included. Want one?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.4");
                        break;
                    case "More blood for the blood gods!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.5");
                        break;
                    case "Everyone else is so rude tonight. If they don't get over it soon, I'll break down their doors and make them!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.6");
                        break;
                    case "Being drunk, I have no moral compass atm.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.7");
                        break;
                    case "Nothard/10, if I fight bosses I wanna feel like screaming 'OH YES DADDY!' while I die repeatedly.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.8");
                        break;
                    case "Like I always say, when you're drunk you can tolerate annoying people a lot more easily...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.9");
                        break;
                    case "I'm literally balls drunk off my sass right now.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.10");
                        break;
                    case "I'm either laughing because I'm drunk or because I've lost my mind. Probably both.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.11");
                        break;
                    case "When I'm drunk I'm way happier...at least until the talking worms start to appear.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.12");
                        break;
                    case "I should reprogram the whole game while drunk and send it back to the testers.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.13");
                        break;
                    case "What a great day, might just drink so much that I get poisoned again.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.14");
                        break;
                    case "A perfect night...for alcohol! First drinks are on me!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.15");
                        break;
                    case "Here's a challenge...take a drink whenever you get hit. Oh wait, you'd die.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.16");
                        break;
                    case "Well I was planning to light some candles in order to relax...ah well, time to code while drunk.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.17");
                        break;
                    case "Yes, everyone knows the mechworm is buggy. Well, not so much anymore, but still.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.18");
                        break;
                    case "Are you sure you're 21? ...alright, fine, but don't tell anyone I sold you this.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.20");
                        break;
                    case "Drink something that turns you into a magical flying unicorn so you can be super gay.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.21");
                        break;
                    case "You'll always find me at parties where booze is involved...well, you'll always find booze where I'm involved.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.22");
                        break;
                    case "Shoot down the space invaders! Sexy time will be postponed if we are invaded by UFOs!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.23");
                        break;
                    case "God I can't wait to beat on some ice again!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.24");
                        break;
                    case "The only things I'm attracted to are fish women, women, men who look like women and that's it.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.25");
                        break;
                    case "I'll always be watching.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.26");
                        break;
                    case "Why did that weird monster need that many tentacles? ...actually, don't answer that.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.27");
                        break;
                    case "There's chemicals in the water...and they're turning the frogs gay!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.28");
                        break;
                    case "I saw a ghost down by the old train tracks once, flailing wildly at the lily pads, those were the days.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.29");
                        break;
                    case "I hear it's amazing when the famous purple-stuffed worm out in flap-jaw space, with the tuning fork, does a raw blink on Hara-kiri rock. I need scissors! 61!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.30");
                        break;
                    case "Is that a toy? Looks like something I'd carry around if I was 5 years old.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.38");
                        break;
                    case "Nice scales...did it get hot in here?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.39");
                        break;
                    case "Oh yeah, now you're drinking the good stuff! Do you like it? I created the recipe by mixing fairy dust, crystals and other magical crap.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.40");
                        break;
                    case "So...you're riding me, huh? That's not weird at all.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.41");
                        break;
                    case "Are you coming on to me?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.42");
                        break;
                    case "If I was a magical horse, I'd be out in space, swirling cocktails, as I watch space worms battle for my enjoyment.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.43");
                        break;
                    case "Did anyone ever tell you that large assets cause back pain? Well, they were right.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.FAP.44");
                        break;
                }
                
                if (Main.npcChatText == $"That's west, {Main.player[Main.myPlayer].name}. You're fired again.")
                    Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.FAP.19"), Main.player[Main.myPlayer].name);
                
                if (Main.npcChatText == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} time.")
                    Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.FAP.45"), Main.npcChatText.Split(' ')[3]);
                
                if (Main.npcChatText == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times.")
                    Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.FAP.46"), Main.npcChatText.Split(' ')[3]);

                if (bartender >= 0)
                {
                    if (Main.npcChatText == $"Tell {Main.npc[bartender].GivenName} to stop calling me. He's not wanted.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.FAP.31"), Main.npc[bartender].GivenName);
                    
                    if (Main.npcChatText == $"My booze will always be better than {Main.npc[bartender].GivenName}'s, and nobody can convince me otherwise.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.FAP.32"), Main.npc[bartender].GivenName);
                }

                if (difl >= 0)
                {
                    if (Main.npcChatText == $"I never realized how well-endowed {Main.npc[difl].GivenName} was. It had to be the largest icicle I had ever seen.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.FAP.33"), Main.npc[difl].GivenName);
                }

                if (stylist >= 0)
                {
                    if (Main.npcChatText == $"You still can't stop me from trying to move in with {Main.npc[stylist].GivenName}.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.FAP.34"), Main.npc[stylist].GivenName);
                    
                    if (Main.npcChatText == $"I love it when {Main.npc[stylist].GivenName}'s hands get sticky from all that...wax.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.FAP.35"), Main.npc[stylist].GivenName);
                    
                    if (Main.npcChatText == $"{Main.npc[stylist].GivenName} works wonders for my hair...among other things.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.FAP.36"), Main.npc[stylist].GivenName);
                    
                    if (Main.npcChatText == $"Ever since {Main.npc[stylist].GivenName} moved in I haven't been drinking as much...it's a weird feeling.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.FAP.37"), Main.npc[stylist].GivenName);
                }
                
                for (int i = 0; i < 200 && flag; i++)
                {
                    if (Main.npc[i].type == CoreCalamityTranslation.CalamityMod.NPCType("FAP") &&
                        Main.npc[Main.player[Main.myPlayer].talkNPC].type == CoreCalamityTranslation.CalamityMod.NPCType("FAP"))
                    {
                        string str = Main.npcChatText;
                        str = str.Replace("Hey", "Привет Eternity, osaka_drift, ILLIK,");
                        str = str.Replace("and", "и");
                        str = str.Replace("! You're all pretty good! ...wait, who are you again?", "! Вы все очень хороши! ...подожди, а ты кто такой?");
                        Main.npcChatText = str;
                    }
                }
            }

            if (seahoe >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "My homeland may have dried up but the memories of my people still remain. I will not let them be in vain.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.1");
                        break;
                    case "There is a lot that you do not know about this world, specifically regarding the past. Much of it has been lost to history due to the many wars that plagued it.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.2");
                        break;
                    case "How can I survive on land? Ah, that is a secret. No, actually...I can breathe air like you!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.3");
                        break;
                    case "Why do you ask if it's the males that carry the young? Don't your males carry their young?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.4");
                        break;
                    case "There be monsters lurking in the darkness. Most...unnatural monsters.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.5");
                        break;
                    case "Most creatures look up at the moon and admire it. I look up and fear it.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.6");
                        break;
                    case "Oh, me? I don't sleep, it's part of my nature.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.7");
                        break;
                    case "I'm never keen on these nights. They're so violent.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.12");
                        break;
                    case "Ah, nice duds, my child!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.13");
                        break;
                    case "Shouldn't you be wearing a clam bra?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.14");
                        break;
                    case "The balance between light and dark is tipping. Stay strong, my child.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.15");
                        break;
                    case "Ah, you are starting to realize just how complicated this world is now. You are learning the story of what became of him.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.16");
                        break;
                    case "Do you ever get the feeling that something out there is watching you very carefully? Whatever it is, it's very small and sly, I think.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.17");
                        break;
                    case "I must admit, I am quite shaken up now. Never would I have imagined that I would see one of the dark gods again. Not in this lifetime anyhow.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.18");
                        break;
                    case "Times like this I wish my home was still in one piece instead of evaporated away. I don't blame the witch for anything, it's just...oh, never mind.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.19");
                        break;
                    case "I suppose that witch was mistaken. Defeating the Ceaseless Void and the Devourer has not caused our world to collapse... but I would not lower my guard if I were you.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.20");
                        break;
                    case "Is this...what the world is like now? It seems so much more lifeless than when I saw it before I disappeared.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.21");
                        break;
                    case "Thank you for your service, my child, but I am afraid I am without a home now.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.22");
                        break;
                    case "If this shows up, something went wrong.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.23");
                        break;
                    case "Draedon's style of confrontation is very...alien and hands-off. You may be more likely to fight any one of his mechs before taking him down.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.24");
                        break;
                    case "Lord Yharim possesses god-like strength. He may not even fight you at full power which is fortunate for you. His attacks may just kill you in one hit, so be careful.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.25");
                        break;
                    case "Pockets of ore have appeared once more in the land. This will allow you to create the most powerful weaponry and armor imagined!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.26");
                        break;
                    case "Ah, the dragon Yharon is fickle. You may find that he will refuse to use his full power unless you are strong enough to unleash the power of the Dark Sun.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.27");
                        break;
                    case "The Devourer of Gods is extremely powerful. However, he is young, foolhardy, and very lazy. Perhaps if he had been given time to develop he would have turned into quite the threat.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.28");
                        break;
                    case "With the cosmic steel you can fashion many of your weapons into much more powerful forms.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.29");
                        break;
                    case "The Devourer of God's cosmic armor is unique in that it is capable of not only protecting his body from tearing itself apart when ripping through the fabric of space and time, but also allows him to control his powers.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.30");
                        break;
                    case "Ah...I can sense a powerful change in the weather. You may want to venture to the Sulphurous Seas once more during the rain to experience it.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.31");
                        break;
                    case "The Abyss holds many secrets revealed with time. Checking it out again may not be a bad idea.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.32");
                        break;
                    case "The Dungeon seems to be more active now. You may hear the faint whisperings of angry spirits who have not left to the Void...I would recommend searching there before taking on the Sentinels.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.33");
                        break;
                    case "Ironic, is it not, that Statis was defeated by the very Sentinel his people fashioned their art of stealth from. Fate so often weaves cruel tales.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.34");
                        break;
                    case "The Rune of Kos holds a significant portion of Providence's brand of magic, easily distinguishable from all others. Activating it in certain places would have some...risky consequences.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.35");
                        break;
                    case "The stories have it that when Providence faced and defeated Yharim and his forces she lost a lot of energy and reverted to a more skeletal form. She's merely a fraction of the power she was before.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.36");
                        break;
                    case "Providence is as much the sun goddess as much as the Moon Lord is the moon god. They are two sides of the same coin, choosing to remain neutral amongst our petty squabbles.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.37");
                        break;
                    case "Touching Providence's offerings is usually a death wish. Shame that Yharim didn't think to just mess with her things to get her out of hiding.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.38");
                        break;
                    case "The Profaned Guardians will do anything to protect their goddess. Makes sense they would die for her since they can be revived just as quickly.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.39");
                        break;
                    case "Profaned creatures now lurk in the Hallow and in Hell. If you destroy enough and gather their essence together you shall be able to capture the attention of the Profaned Guardians.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.40");
                        break;
                    case "Your adventure focuses to the jungle it seems. The Dragonfolly and its swarming offspring should be eliminated before their numbers spiral out of control.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.41");
                        break;
                    case "The plague was just one of the many experiments authorized by Yharim to raze towns to the ground. This is probably one of the few he shelved for being too terrible.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.42");
                        break;
                    case "The Abyss has become far more active than before. You might be able to mine some of the volcanic rubble contained within.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.43");
                        break;
                    case "The men at the front of the dungeon are performing a ritual to keep the Moon Lord contained in his prison. In order to gain Yharim's attention, however, you may need to defeat them.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.44");
                        break;
                    case "When exploring the jungle temple be careful. You may not wish to disturb the Lihzard's idol, the Golem. It's quite the destructive force.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.45");
                        break;
                    case "Be careful when defeating Plantera and the Golem. You might accidentally unleash a new threat in the jungle that needs to be quelled.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.46");
                        break;
                    case "If you've gathered the souls used to power those automatons head once more to the jungle. You will find a powerful enemy to fight, which will unleash the full fervor of the jungle once defeated. Do not underestimate it!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.47");
                        break;
                    case "The Brimstone Crags...Yharim despised that place, and did everything he could to raze it to the ground. It might explain a few things about him.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.48");
                        break;
                    case "If you take an idol down to the Brimstone Crags you might be able to see just what is lurking in the shadows.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.49");
                        break;
                    case "Once those mechanical creations have been defeated you would do well to seek out the crippled clone of the witch, Calamitas. It might provide some useful weaponry.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.50");
                        break;
                    case "I would recommend saving some of your old items. You never know if you can engineer them into stronger weapons in the future.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.51");
                        break;
                    case "Have you heard of the story of Archmage Permafrost? Rumor has it he's been locked away in an icy prison by Lord Yharim. Perhaps you would be able to free him if Cryogen was destroyed.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.52");
                        break;
                    case "You will find more ores have been unlocked due to the magic sealing them away being dispelled. Some of them may require more than just the ore itself to create.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.53");
                        break;
                    case "Throughout the world lie various structures left behind by Draedon. Archaic defenses may remain, but the goods inside may be worth your while.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.54");
                        break;
                    case "The Crimson used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.55");
                        break;
                    case "The Corruption used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.56");
                        break;
                    case "The dungeon is a dark place. None of us know of its true purpose, however, the ancient Eidolist cultists used it for worship before Lord Yharim took it over.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.57");
                        break;
                    case "I'm assuming you've heard the legends that speak of the ninja, Statis? There are some who say that if you were able to defeat the gods which his clan once worshipped you would be able to harness some of his powers.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.58");
                        break;
                    case "Scattered across the lands are shrines dedicated to the gods. You can take whatever is in them, but a few items you may not be able to use until much later.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.59");
                        break;
                    case "Be careful what you attack in the Crimson. You might just unveil a greater threat than what was there before.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.60");
                        break;
                    case "Be careful what you attack in the Corruption. You might just unveil a greater threat than what was there before.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.61");
                        break;
                    case "The Sulphurous Seas were created long ago, when Yharim's dungeon could no longer hold as many corpses as it needed to. Many of the bodies were dumped into the ocean. This, along with severe pollution from the heydays of Draedon's experiments have turned a paradise into a wasteland.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.62");
                        break;
                    case "The Sulphurous Seas are dangerous. The toxic waters will burn your skin, but if you can brave them you will be able to reach the Abyss, where there are powerful weapons and dangers aplenty.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.63");
                        break;
                    case "Ah yes, the Abyss. That trench is full of powerful creatures that could devour you in a heartbeat. I would explore the dungeon first.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.64");
                        break;
                    case "Have you heard of the Brimstone Crags? It was once a grand kingdom, not too different from my own. However, it also met a similar fate. I would not advise going down there, unless you seek a painful death.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.65");
                        break;
                    case "There are rumors of ores that lay in latency. When you defeat certain bosses you will undo the ancient magic which conceals those materials.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SEAHOE.66");
                        break;
                }

                if (partyGirl >= 0)
                {
                    if (Main.npcChatText == $"{Main.npc[partyGirl].GivenName} asked if my nose could be used as a vuvuzela. What is a vuvuzela?")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.SEAHOE.8"), Main.npc[partyGirl].GivenName);
                }

                if (angler >= 0)
                {
                    if (Main.npcChatText == $"Meet me at {Main.npc[angler].GivenName}'s house at night. We're going to throw him to the Trashers.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.SEAHOE.9"), Main.npc[angler].GivenName);
                    
                    if (Main.npcChatText == $"Not sure how {Main.npc[angler].GivenName} has not been roasted and digested by now, hanging around the sulphuric seas for so long. Perhaps it got to his head.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.SEAHOE.10"), Main.npc[angler].GivenName);
                }

                if (fap >= 0)
                {
                    if (Main.npcChatText == $"Rumor has it {Main.npc[fap].GivenName} drinks to forget her troubled past.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.SEAHOE.11"), Main.npc[fap].GivenName);
                }
            }

            if (thief >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "Oy, watch where you're going or I might just use you for dart practice.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.1");
                        break;
                    case "Bet you'd look good as a pincushion, amiright?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.2");
                        break;
                    case "Zombies don't dodge very well. Maybe you'll do a bit better.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.3");
                        break;
                    case "Hey, careful over there. I've rigged the place. One wrong step and you're going to get a knife in your forehead.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.4");
                        break;
                    case "You know what's really cool? Watching the glint of throwing stars as they reflect the moon.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.5");
                        break;
                    case "You think those stars that fall occasionally would make good throwing weapons?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.6");
                        break;
                    case "Statis' clan's got nothing on me. Mostly cause they're all dead.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.7");
                        break;
                    case "Where is my party hat? Well, I stole it of course.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.8");
                        break;
                    case "The nice thing about maps is I can track anything that has fallen.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.9");
                        break;
                    case "Imagine how fast you could throw if you just had more hands.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.10");
                        break;
                    case "I also take food for currency.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.11");
                        break;
                    case "Usually I only think of animals as food or target practice, but dragons are an exception.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.12");
                        break;
                    case "Anything is a weapon if you throw it hard enough.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.13");
                        break;
                    case "That's your chucking arm? You need to work out more.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.14");
                        break;
                    case "Listen here. It's all in the wrist, the wrist! Oh, forget it.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.15");
                        break;
                    case "I don't think Mom and Dad are proud of the job I have right now.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.16");
                        break;
                    case "Eh you know how it goes; steal from the rich, give to the poor. Of course, for a price.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.17");
                        break;
                    case "Want to hear about this one time I was stuck in a room with a rabid dog and a dead guy?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.18");
                        break;
                    case "Argh snakes. For some reason it's always snakes.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.19");
                        break;
                    case "Maybe I'm bitter. It's been a long time, so whatever. Just do a good job out there.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.20");
                        break;
                    case "It's not stealing! I'm just borrowing it until I die!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.21");
                        break;
                    case "Wouldn't be the first time I used my friends' remains as weapons.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.22");
                        break;
                    case "With all of this new stuff cropping up, looks like we got some easy loot and new items to craft up, eh? Well, YOU craft them, I'll steal em.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.23");
                        break;
                    case "Draedon thinks he can build awesome machines, but he doesn't know how much crap I've stolen from him and sold by dismantling his drones.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.24");
                        break;
                    case "Gramma always said never to invade ancient temples or you'll be cursed and die. Let's say both of us attest that is untrue. We're still alive. Somewhat.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.25");
                        break;
                    case "I heard that there's some really neat and awesome rogue items you can get. Show em to me if you ever get the time.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.26");
                        break;
                    case "Providence HATES it when you take her stuff. I learned that the hard way.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.27");
                        break;
                    case "You think I can get away with looting from ghosts? It ain't like they can pick things up.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.28");
                        break;
                    case "Oh man, did you rip that off a shark!? Now that's a weapon!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.29");
                        break;
                    case "I tried looting Storm Weaver's armor once. Before I could get a chunk of the stuff... well let's just say the bigger, fatter cosmic worm arrived and it didn't end well.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.30");
                        break;
                    case "I'd rather not be here. This place has bad vibes, y'know? It brings back some unpleasant memories.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.31");
                        break;
                    case "Hey, if government officials can get tax, why can't I? The heck do you mean that these two things are nothing alike?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.36");
                        break;
                    case "Sorry, I got nothing. Perhaps you could reforge something and come back later...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.THIEF.37");
                        break;
                }

                if (merchant >= 0)
                {
                    if (Main.npcChatText == $"Don't tell {Main.npc[merchant].GivenName}, but I took some of his stuff and replaced it with Angel Statues.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.THIEF.32"), Main.npc[merchant].GivenName);
                }

                if (fap >= 0)
                {
                    if (Main.npcChatText == $"I learned never to steal {Main.npc[fap].GivenName}'s drinks. She doesn't appreciate me right now so I'll go back to hiding.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.THIEF.33"), Main.npc[fap].GivenName);
                }

                if (armsDealer >= 0 && nurse >= 0)
                {
                    if (Main.npcChatText == $"Don't tell {Main.npc[armsDealer].GivenName} that I was responsible for {Main.npc[nurse].GivenName}'s injuries.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.THIEF.34"), Main.npc[armsDealer].GivenName, Main.npc[nurse].GivenName);
                }
                
                if (goblinTinkerer >= 0)
                {
                    if (Main.npcChatText == $"Want in on a little secret? Since {Main.npc[goblinTinkerer].GivenName} always gets so much cash from you, I've been stealing some of it as we go. I need you to keep quiet about it, so here.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.THIEF.35"), Main.npc[goblinTinkerer].GivenName);
                }
            }

            if (merchant >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "Each night seems only more foreboding than the last. I feel unthinkable terrors are watching your every move.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Merchant.1");
                        break;
                    case "Are you daft?! Turn off those lamps!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Merchant.2");
                        break;
                    case "If this acid rain keeps up, there'll be a shortage of Dirt Blocks soon enough!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Merchant.3");
                        break;
                    case "I happen to have several Angel Statues at the moment, a truely rare commodity. Want one?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Merchant.4");
                        break;
                    case "The caverns have become increasingly dark as of late, so I stocked up on some special torches if you have the funds.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Merchant.5");
                        break;
                }
            }

            if (armsDealer >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "That's the biggest moth I've ever seen for sure. You'd need one big gun to take one of those down.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.ArmsDealer.1");
                        break;
                    case "Is it me or are your weapons getting bigger and bigger?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.ArmsDealer.2");
                        break;
                }
            }

            if (dryad >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "There's a dark solar energy emanating from the moths that appear during this time. Ah, the moths as you progress further get more powerful...hmm...what power was Yharon holding back?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Dryad.1");
                        break;
                    case "That starborne illness sits upon this land like a blister. Do even more vile forces of corruption exist in worlds beyond?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Dryad.2");
                        break;
                    case "My ancestor was lost here long ago. I must pay my respects to her.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Dryad.4");
                        break;
                    case "\u0093I'm not here for any reason! Just picking up mushrooms for uh, later use.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Dryad.5");
                        break;
                }

                if (fap >= 0)
                {
                    if (Main.npcChatText == $"{Main.npc[fap].GivenName} put me up to this.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.Dryad.3"), Main.npc[fap].GivenName);
                }
            }

            if (guide >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "Could you be so kind as to, ah...check hell for me...? I left someone I kind of care about down there.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Guide.1");
                        break;
                    case "I have this sudden shiver up my spine, like a meteor just fell and thousands of innocent creatures turned into monsters from the stars.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Guide.2");
                        break;
                    case "The dungeon seems even more restless than usual, watch out for the powerful abominations stirring up in there.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Guide.3");
                        break;
                    case "Seems like extinguishing that butterfly caused its life to seep into the hallowed areas, try taking a peek there and see what you can find!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Guide.4");
                        break;
                    case "I've heard there is a portal of antimatter absorbing everything it can see in the dungeon, try using the Rune of Kos there!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Guide.5");
                        break;
                }
            }

            if (demolitionist >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "God Slayer Dynamite? Boy do I like the sound of that!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Demolitionist.1");
                        break;
                }
            }

            if (clothier >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "Who you gonna call?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Clothier.1");
                        break;
                    case "Those screams...I'm not sure why, but I feel like a nameless fear has awoken in my heart.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Clothier.2");
                        break;
                    case "I can faintly hear ghostly shrieks from the dungeon...and not ones I'm familiar with at all. Just what is going on in there?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Clothier.3");
                        break;
                    case "Whatever that thing was, I'm glad it's gone now.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Clothier.4");
                        break;
                    case "Houston, we've had a problem.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Clothier.5");
                        break;
                }
            }

            if (goblinTinkerer >= 0)
            {
                if (thief >= 0)
                {
                    if (Main.npcChatText == $"Hey, is it just me or have my pockets gotten lighter ever since {Main.npc[thief].GivenName} arrived?")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.GoblinTinkerer.1"), Main.npc[thief].GivenName);
                }
                if (Main.npcChatText == "You know...we haven't had an invasion in a while...")
                    Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.GoblinTinkerer.2");
            }

            if (wizard >= 0)
            {
                if (difl >= 0)
                {
                    if (Main.npcChatText == $"I'd let {Main.npc[difl].GivenName} coldheart MY icicle.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.Wizard.1"), Main.npc[difl].GivenName);
                }
                
                if (Main.npcChatText == "Space just got way too close for comfort.")
                    Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Wizard.2");
            }

            if (mechanic >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "What do you mean your traps aren't making the cut? Don't look at me!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Mechanic.1");
                        break;
                    case "Um...should my nightlight be on?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Mechanic.2");
                        break;
                    case "Maybe I should've waterproofed my gadgets... They're starting to corrode.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Mechanic.4");
                        break;
                }

                if (fap >= 0)
                {
                    if (Main.npcChatText == $"Well, I like {Main.npc[fap].GivenName}, but I, ah...I have my eyes on someone else.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.Mechanic.3"), Main.npc[fap].GivenName);
                }
            }

            if (truffle >= 0)
            {
                if (Main.npcChatText == "I don't feel very safe; I think there's pigs following me around and it frightens me.")
                    Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Truffle.1");

                if (fap >= 0)
                {
                    if (Main.npcChatText == $"Sometimes, {Main.npc[fap].GivenName} just looks at me funny and I'm not sure how I feel about that.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.Mechanic.2"), Main.npc[fap].GivenName);
                }
            }

            if (steampunker >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "Just what is that contraption? It makes my Teleporters look like child's play!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Steampunker.1");
                        break;
                    case "Yep! I'm also considering being a space pirate now.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Steampunker.2");
                        break;
                    case "Some of my machines are starting to go haywire thanks to this Astral Infection. I probably shouldn't have built them here":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Steampunker.3");
                        break;
                    case "I'm sorry I really don't have any Unicorn proof tech here, you're on your own.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Steampunker.4");
                        break;
                }
            }

            if (dyeTrader >= 0)
            {
                if (Main.npcChatText == "Have you seen those gemstone creatures in the caverns? Their colors are simply breathtaking!")
                    Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.DyeTrader.1");

                if (difl >= 0)
                {
                    if (Main.npcChatText == $"Do you think {Main.npc[difl].GivenName} knows how to 'let it go?'")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.DyeTrader.2"), Main.npc[difl].GivenName);
                }
            }

            if (partyGirl >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "I think my light display is turning into an accidental bug zapper. At least the monsters are enjoying it.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.PartyGirl.2");
                        break;
                    case "Ooh! I love parties where everyone wears a scary costume!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.PartyGirl.3");
                        break;
                }

                if (fap >= 0)
                {
                    if (Main.npcChatText == $"I have a feeling we're going to have absolutely fantastic parties with {Main.npc[fap].GivenName} around!")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.PartyGirl.1"), Main.npc[fap].GivenName);
                }
            }

            if (cyborg >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "All these moments will be lost in time. Like tears...in the rain.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Cyborg.1");
                        break;
                    case "Always shoot for the moon! It has clearly worked before.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Cyborg.2");
                        break;
                    case "Draedon? He's...a little 'high octane' if you know what I mean.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Cyborg.3");
                        break;
                    case "Those oversized bugs terrorizing the jungle... Surely you of all people could shut them down!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Cyborg.4");
                        break;
                }
            }

            if (painter >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "A little sickness isn't going to stop me from doing my work as an artist!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Painter.1");
                        break;
                    case "There's a surprising art to this area. A sort of horrifying, eldritch feeling. It inspires me!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Painter.2");
                        break;
                    case "I'm not exactly suited for this cold weather. Still looks pretty, though.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Painter.3");
                        break;
                    case "I hate sand. It's coarse, and rough and gets in my paint.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Painter.5");
                        break;
                    case "Do you think unicorn blood could be used as a good pigment or resin? No I'm not going to find out myself.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Painter.6");
                        break;
                    case "I can't work in this environment. All of my paint just floats off.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Painter.7");
                        break;
                    case "Painting the tortoises in a still life isn't going so well.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Painter.8");
                        break;
                    case "I can't paint a still life if the fruit grows legs and walks away.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Painter.9");
                        break;
                    case "On the canvas, things get heated around here all the time. Like the environment!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Painter.10");
                        break;
                    case "Sorry, I'm all out of watercolors. They keep evaporating.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Painter.11");
                        break;
                    case "Roses, really? That's such an overrated thing to paint.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Painter.12");
                        break;
                    case "Fun fact! Sulphur was used as pigment once upon a time! Or was it Cinnabar?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Painter.13");
                        break;
                    case "Easiest landscape I've ever painted in my life.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Painter.14");
                        break;
                }

                if (difl >= 0)
                {
                    if (Main.npcChatText == $"Think {Main.npc[difl].GivenName} would let me paint him like one of his French girls?!")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.PartyGirl.4"), Main.npc[difl].GivenName);
                }
            }

            if (witchDoctor >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "My home here has an extensive history and a mysterious past. You'll find out quickly just how extensive it is...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.WitchDoctor.1");
                        break;
                    case "I have unique items if you show me that you have bested the guardian of this jungle.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.WitchDoctor.2");
                        break;
                    case "This is as good a time as any to pick up the best ingredients for potions.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.WitchDoctor.3");
                        break;
                }
            }

            if (pirate >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "Aye, I've heard of a mythical creature in the oceans, singing with an alluring voice. Careful when yer fishin out there.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Pirate.1");
                        break;
                    case "I have to thank ye again for takin' care of that sea serpent. Or was that another one...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Pirate.2");
                        break;
                    case "Twenty-nine bottles of beer on the wall...":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Pirate.4");
                        break;
                    case "Now this is a scene that I can admire any time! I feel like something is watching me though.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Pirate.5");
                        break;
                    case "It ain't much of a sight, but there's still life living in these waters.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Pirate.6");
                        break;
                    case "Me ship might just sink from the acid alone.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Pirate.7");
                        break;
                }

                if (seahoe >= 0)
                {
                    if (Main.npcChatText == $"I remember legends about that {Main.npc[seahoe].GivenName}. He ain't quite how the stories make him out to be though.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.Pirate.3"), Main.npc[seahoe].GivenName);
                }
            }

            if (stylist >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "Please don't catch space lice. Or Crimson lice. Or just lice in general.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Stylist.1");
                        break;
                    case "Please don't catch space lice. Or Corruption lice. Or just lice in general.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Stylist.2");
                        break;
                    case "They look so cute and yet, I can feel their immense power just by being near them. What are you?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Stylist.5");
                        break;
                    case "I hate to break it to you, but you don't have hair to cut or style, hun.":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Stylist.6");
                        break;
                    case "Aww, they're so cute, do they have names?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Stylist.7");
                        break;
                }

                if (fap >= 0)
                {
                    if (Main.npcChatText == $"Sometimes I catch {Main.npc[fap].GivenName} sneaking up from behind me.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.Stylist.3"), Main.npc[fap].GivenName);
                    
                    if (Main.npcChatText == $"{Main.npc[fap].GivenName} is always trying to brighten my mood...even if, deep down, I know she's sad.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.Stylist.4"), Main.npc[fap].GivenName);
                }
            }

            if (travellingMerchant >= 0)
            {
                if (fap >= 0 && merchant >= 0)
                {
                    if (Main.npcChatText == $"Tell {Main.npc[fap].GivenName} I'll take up her offer and meet with her at the back of {Main.npc[merchant].GivenName}'s house.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.TravellingMerchant.1"), Main.npc[fap].GivenName, Main.npc[merchant].GivenName);
                }
            }

            if (angler >= 0)
            {
                if (seahoe >= 0)
                {
                    if (Main.npcChatText == $"Someone tell {Main.npc[seahoe].GivenName} to quit trying to throw me out of town, it's not going to work.")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.Angler.1"), Main.npc[seahoe].GivenName);
                }
            }

            if (taxCollector >= 0)
            {
                switch (Main.npcChatText)
                {
                    case "BAH! Doesn't seem like I'll ever be able to quarrel with the debts of the town again!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.TaxCollector.1");
                        break;
                    case "Where and how are you getting all of this money?":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.TaxCollector.2");
                        break;
                    case "Perhaps with all that time you've got you could check those old ruins? Certainly something of value in it for you!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.TaxCollector.3");
                        break;
                    case "Devourer of what, you said? Devourer of Funds, if its payroll is anything to go by!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.TaxCollector.4");
                        break;
                    case "Goodness! That cane has swagger!":
                        Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.TaxCollector.5");
                        break;
                }
            }

            if (skeletonMerchant >= 0)
            {
                if (Main.npcChatText == "What'dya buyin'?")
                    Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.SkeletonMerchant.1");
            }

            if (bartender >= 0)
            {
                if (Main.npcChatText == "Care for a little Moonshine?")
                    Main.npcChatText = Translation.KeyText("Calamity.NpcChatText.Bartender.1");

                if (fap >= 0)
                {
                    if (Main.npcChatText == $"Sheesh, {Main.npc[fap].GivenName} is a little cruel, isn't she? I never claimed to be an expert on anything but ale!")
                        Main.npcChatText = string.Format(Translation.KeyText("Calamity.NpcChatText.Bartender.2"), Main.npc[fap].GivenName);
                }
            }
        }
    }
}