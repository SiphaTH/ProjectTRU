using System;
using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public static class NpcDialoguesTranslation
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
        private static int Witch => NPC.FindFirstNPC(ModsCall.Calamity.NPCType("WITCH"));
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
                    case "The sun beats down harshly upon my creations here. If you would allow me to conjure a blizzard every now and then...":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.1");
                        break;
                    case "I must admit, I’m not quite used to this weather. It's far too warm for my tastes...":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.2");
                        break;
                    case "Nightfall is a good time for practicing magic. We mages often rely on celestial bodies and their fragments to enhance our mana.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.3");
                        break;
                    case "Necromancy was never a field I found interesting. Why utilize the rotting corpses of people, when you could form far more elegant servants of ice?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.4");
                        break;
                    case "The tundra’s unnatural state is not all my doing. Decades ago, I came across it and amplified the climate with my magic.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.5");
                        break;
                    case "If you have a request, make it quick. I am in the process of weaving a spell, which requires great focus.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.6");
                        break;
                    case "You have the makings of a gifted mage. Tell me, what do you think of ice magic?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.7");
                        break;
                    case "Flowers and the like don’t hold a candle to the beauty of intricately formed ice.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.8");
                        break;
                    case "Sometimes... I feel like all I'm good for during these events is making ice cubes and slushies.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.9");
                        break;
                    case "If your blood were to thoroughly freeze, it would be quite fatal.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.10");
                        break;
                    case "The undead which roam tonight are still monsters of blood and guts, but they seem... fresher.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.11");
                        break;
                    case "It is shocking, to see you have come so far. I wish you the best of luck on your future endeavours.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.12");
                        break;
                    case "You, having bested so many beings, even deities, I wonder if I have anything left to offer you.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.13");
                        break;
                    case "I have not seen such a sky in decades. Who are you, to so brazenly march against that Tyrant?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.14");
                        break;
                    case "I... deeply appreciate you rescuing me from being trapped within my frozen castle. It's been many, many years.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DIFL.15");
                        break;
                }
            }
            else if (TalkingNpc == DrunkPrincess)
            {
                switch (npcPhrase)
                {
                    case "Why are you talking to me right now? Shouldn't you be bumbling around and dying for my amusement?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.1");
                        break;
                    case "I could smell my vodka from MILES away!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.2");
                        break;
                    case "Have any spare rooms available? Preferably candle-lit with a hefty supply of booze?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.3");
                        break;
                    case "I drink to forget certain... things. What things, you might ask? Well, the point is to forget them, isn't it?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.9");
                        break;
                    case "I'm literally balls drunk off my sass right now, what do you want?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.10");
                        break;
                    case
                        "I'm either laughing because I'm drunk or because I've lost my mind, probably both.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.11");
                        break;
                    case "When I'm drunk I'm way happier... at least until the talking worms start to appear.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.12");
                        break;
                    case
                        "I should reprogram the whole mod, while drunk, then send it back to the testers.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.13");
                        break;
                    case "What a great day! Might just drink so much that I get poisoned again.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.15");
                        break;
                    case "A perfect night to light some candles, drink some wine and relax.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.16");
                        break;
                    case "Here's a challenge... take a shot for every time you've had to look at the wiki. Oh wait, you'd die.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.17");
                        break;
                    case "Yes, everyone knows the mechworm is buggy. Well, not anymore, but still.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.18");
                        break;
                    case "You lost or something? I don't mind company, but I'd rather be left alone at night.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.19");
                        break;
                    case "Are you sure you're 21? ...Alright, fine, but don't tell anyone I sold you these.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.20");
                        break;
                    case "I HATE WALMART! ...Anyway, what do you want this time?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.22");
                        break;
                    case "Drink something that turns you into a magical flying unicorn so you can be just like me.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.23");
                        break;
                    case "Did anyone ever tell you that large assets cause back pain? Well, they were right.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.24");
                        break;
                    case "Deals so good I'll [$$!$] myself! ...Sorry, just had a minor stroke!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.25");
                        break;
                    case "You'll always find me at parties where booze is involved... well, you'll always find BOOZE where I'M involved!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.26");
                        break;
                    case "You should probably deal with those ayy lmaos before anything else, but whatever.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.27");
                        break;
                    case "God I can't wait to smash some ice again! ...For drinks, of course.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.28");
                        break;
                    case "How could you murder such a beautiful creature!? ...The blue sexy one, not the obese cucumber.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.29");
                        break;
                    case "Ever wondered why the Moon Lord needed so many tentacles? Uh... on second thought, I won't answer that.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.30");
                        break;
                    case "I'm melting! Put a stop to this inclement weather this instant before it ruins my hair!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.31");
                        break;
                    case "I saw a ghost down by the old train tracks back at my homeland once, flailing wildly at the lily pads... frightening times those were.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.32");
                        break;
                    case "I hear it's amazing when the famous Devourer of Gods out in flap-jaw space, with the tuning fork, does a raw blink on Hara-kiri rock. I need scissors! 61!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.33");
                        break;
                    case "The hell is that? Looks like something I'd carry around if I was 5 years old.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.39");
                        break;
                    case "Nice scales... is it hot in here or is it just me?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.40");
                        break;
                    case "Do you like my vodka? I created it by mixing fairy dust, crystallized cave sweat and other magical crap.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.41");
                        break;
                    case "So... you found my special bottle. Hope you enjoy it, I know I will.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.42");
                        break;
                    case "Be sure to dismount me once in a while, I get tired. And besides, I can't rip you off-I mean offer you excellent deals you won't find anywhere else if you're riding me 24/7.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.43");
                        break;
                    case "Before you ask, no, I do NOT have a heart on my butt while in human form. Don't question my transformation preferences!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.44");
                        break;
                    case "I'm gonna make some Bloody Marys to relax, celery included. Want one?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.45");
                        break;
                    case "If you're too lazy to craft potions normally, try Blood Orbs. Blood is fuel, dumbass.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.46");
                        break;
                    case "I'm trying to not be bitchy tonight, but it's hard when everyone else won't shut up.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.47");
                        break;
                    case "Sorry, I have no moral compass at the moment.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.48");
                        break;
                }
                if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} time.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.49"), npcPhrase.Split(' ')[3]);
                }
                else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.50"), npcPhrase.Split(' ')[3]);
                }
                else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times. Congratulations! You are now, officially, the biggest loser in Terraria's history! Who was number two? Hell if I know.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.51"), npcPhrase.Split(' ')[3]);
                }
                else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times. I'm not sure what to say this time. That you're bad and should feel bad? That much was known already.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.52"), npcPhrase.Split(' ')[3]);
                }
                else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times. Bless your heart. I could dodge better than you even if I were drunk high.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.53"), npcPhrase.Split(' ')[3]);
                }
                else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times. It is said the average Terrarian has a lifespan of 2 minutes or less. ...Well, not really, but I feel like you'd be part of that statistic.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.54"), npcPhrase.Split(' ')[3]);
                }
                else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times. Your inability to avoid dying to even the most basic of attacks is astonishing to me.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.55"), npcPhrase.Split(' ')[3]);
                }
                else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times. I admire your tenacity. Keep it up, your enemies are racking up quite the kill count!")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.56"), npcPhrase.Split(' ')[3]);
                }
                else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times. Consider lowering the difficulty. If you found that statement irritating, good.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.57"), npcPhrase.Split(' ')[3]);
                }
                if (Bartender.IsExistingNPC())
                {
                    if (npcPhrase == "I've had to tell baldie where my eyes are so many times that I've lost count.")
                    {
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.FAP.34");
                    }
                    if (npcPhrase == $"Tell {Main.npc[Bartender].GivenName} to stop calling me. He's not wanted.")
                    {
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.35"), Main.npc[Bartender].GivenName);
                    }
                    else if (npcPhrase == $"My booze will always be better than {Main.npc[Bartender].GivenName}'s, and nobody can convince me otherwise.")
                    {
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.36"), Main.npc[Bartender].GivenName);
                    }
                }
                if (Archmage.IsExistingNPC() && npcPhrase == $"I never realized how well-endowed {Main.npc[Archmage].GivenName} was. It had to be the largest icicle I'd ever seen.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.37"), Main.npc[Archmage].GivenName);
                }
                if (Witch.IsExistingNPC() && npcPhrase == $"The abuse {Main.npc[Witch].GivenName} went through is something I can hardly comprehend. I'd offer her a drink, but I don't think she'd enjoy it.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.38"), Main.npc[Witch].GivenName);
                }
                if (Stylist.IsExistingNPC())
                {
                    if (npcPhrase == $"You can't stop me from trying to move in with {Main.npc[Stylist].GivenName}.")
                    {
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.4"), Main.npc[Stylist].GivenName);
                    }
                    else if (npcPhrase == $"I love it when {Main.npc[Stylist].GivenName}'s hands get sticky from all that... wax.")
                    {
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.5"), Main.npc[Stylist].GivenName);
                    }
                    else if (npcPhrase == $"{Main.npc[Stylist].GivenName} works wonders for my hair... among other things.")
                    {
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.6"), Main.npc[Stylist].GivenName);
                    }
                    else if (npcPhrase == $"Ever since {Main.npc[Stylist].GivenName} moved in I haven't been drinking as much... a strange but not unwelcome feeling.")
                    {
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.7"), Main.npc[Stylist].GivenName);
                    }
                    else if (npcPhrase == $"{Main.npc[Stylist].GivenName} helped me learn to accept my past. It's been rough, but I think I'm on the right track now.")
                    {
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.8"), Main.npc[Stylist].GivenName);
                    }
                    else if (npcPhrase == $"Might go out for a jog later with {Main.npc[Stylist].GivenName}. Nice day for it.")
                    {
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.14"), Main.npc[Stylist].GivenName);
                    }
                    else if (npcPhrase == $"I should watch some movies with {Main.npc[Stylist].GivenName} tonight. You could come too, but only if you bring snacks for us.")
                    {
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.FAP.21"), Main.npc[Stylist].GivenName);
                    }
                }
                if (npcPhrase.Contains("You're all pretty good!"))
                {
                    npcPhrase = npcPhrase
                        .Replace("Hey", "Привет")
                        .Replace(" and ", "и")
                        .Replace("You're all pretty good", "Вы все очень хороши");
                }
            }
            else if (TalkingNpc == SeaKing)
            {
                switch (npcPhrase)
                {
                    case "My home may have been destroyed and my people lost... But I will assist you to honor their memory.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.1");
                        break;
                    case "How odd it is, that your people leave the care of those yet to be born to the females. Our males carry the eggs until they hatch.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.2");
                        break;
                    case "How can I survive on land? Ah, that is a secret. No, actually... I can breathe air like you!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.3");
                        break;
                    case "Ah, if only you could have seen the beauty of a kingdom submerged in water. The way the light refracted and shone over our coral homes...":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.4");
                        break;
                    case "There lurk horrifying creatures beyond the light of our homes. You should take care.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.5");
                        break;
                    case "My eyes are not well suited to bright lights after so many years of darkness. The peace of the night is welcome.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.6");
                        break;
                    case "Oh, me? I do not sleep, it is part of my nature.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.7");
                        break;
                    case "Since ancient times people have said that deities cause celestial events. Which one then, is the cause for these?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.13");
                        break;
                    case "I've never been keen on these nights. Such violence.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.14");
                        break;
                    case "Your presence is now known to a great many things. It is unlikely that they will be as friendly towards you as I have been.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.15");
                        break;
                    case "Hm... The veil has fallen, and the world begins to show its true colors. I hope you will trek a righteous path, though even I am not sure what that may be.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.16");
                        break;
                    case "These days, the night sky feels... just a little less oppressive now.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.17");
                        break;
                    case "Some of these beings I had thought previously to be only legends. To see them in all their glory... what a macabre privilege.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.18");
                        break;
                    case "To see that Tyrant’s serpent free of its shackles. It gave me chills.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.19");
                        break;
                    case "How much more has the world fallen to ruin? Even the Tyrant’s empire...":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.20");
                        break;
                    case "Thank you for your service, my child, but I am afraid I am without a home now.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.21");
                        break;
                    case "If this shows up, something went wrong.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.22");
                        break;
                    case "Draedon's style of confrontation is very... alien and hands-off. You may be more likely to fight any one of his mechs before taking him down.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.23");
                        break;
                    case "Lord Yharim possesses god-like strength. He may not even fight you at full power which is fortunate for you. His attacks may just kill you in one hit, so be careful.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.24");
                        break;
                    case "Pockets of ore have appeared once more in the land. This will allow you to create the most powerful weaponry and armor imagined!":
                    npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.25");
                        break;
                    // case "Ah, the dragon Yharon is fickle. You may find that he will refuse to use his full power unless you are strong enough to unleash the power of the Dark Sun.":
                    //     npcPhrase = LangUtils.GetText("Calamity.NpcChatText.SEAHOE.26");
                    //     break;
                    case "The Devourer of Gods is extremely powerful. However, he is young, foolhardy, and very lazy. Perhaps if he had been given time to develop he would have turned into quite the threat.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.27");
                        break;
                    case "With the cosmic steel you can fashion many of your weapons into much more powerful forms.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.28");
                        break;
                    case "The Devourer of God's cosmic armor is unique in that it is capable of not only protecting his body from tearing itself apart when ripping through the fabric of space and time, but also allows him to control his powers.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.29");
                        break;
                    case "Ah... I can sense a powerful change in the weather. You may want to venture to the Sulphurous Seas once more during the rain to experience it.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.30");
                        break;
                    case "The Abyss holds many secrets revealed with time. Checking it out again may not be a bad idea.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.31");
                        break;
                    case "The Dungeon seems to be more active now. You may hear the faint whisperings of angry spirits who have not left to the Void... I would recommend searching there before taking on the Sentinels.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.32");
                        break;
                    case "Ironic, is it not, that Statis was defeated by the very Sentinel his people fashioned their art of stealth from. Fate so often weaves cruel tales.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.33");
                        break;
                    case "The Rune of Kos holds a significant portion of Providence's brand of magic, easily distinguishable from all others. Activating it in certain places would have some... risky consequences.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.34");
                        break;
                    case "The stories have it that when Providence faced and defeated Yharim and his forces she lost a lot of energy and reverted to a more skeletal form. She's merely a fraction of the power she was before.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.35");
                        break;
                    case "Providence is as much the sun goddess as much as the Moon Lord is the moon god. They are two sides of the same coin, choosing to remain neutral amongst our petty squabbles.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.36");
                        break;
                    case "Touching Providence's offerings is usually a death wish. Shame that Yharim didn't think to just mess with her things to get her out of hiding.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.37");
                        break;
                    case "The Profaned Guardians will do anything to protect their goddess. Makes sense they would die for her since they can be revived just as quickly.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.38");
                        break;
                    case "Profaned creatures now lurk in the Hallow and in Hell. If you destroy enough and gather their essence together you shall be able to capture the attention of the Profaned Guardians.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.39");
                        break;
                    case "Your adventure focuses to the jungle it seems. The Dragonfolly and its swarming offspring should be eliminated before their numbers spiral out of control.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.40");
                        break;
                    case "The plague was just one of the many experiments authorized by Yharim to raze towns to the ground. This is probably one of the few he shelved for being too terrible.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.41");
                        break;
                    case "The Abyss has become far more active than before. You might be able to mine some of the volcanic rubble contained within.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.42");
                        break;
                    case "The men at the front of the dungeon are performing a ritual to keep the Moon Lord contained in his prison. In order to gain Yharim's attention, however, you may need to defeat them.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.43");
                        break;
                    case "When exploring the jungle temple be careful. You may not wish to disturb the Lihzard's idol, the Golem. It's quite the destructive force.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.44");
                        break;
                    case "Be careful when defeating Plantera and the Golem. You might accidentally unleash a new threat in the jungle that needs to be quelled.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.45");
                        break;
                    case "If you've gathered the souls used to power those automatons head once more to the jungle. You will find a powerful enemy to fight, which will unleash the full fervor of the jungle once defeated. Do not underestimate it!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.46");
                        break;
                    case "The Brimstone Crags... Yharim despised that place, and did everything he could to raze it to the ground. It might explain a few things about him.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.47");
                        break;
                    case "If you take an idol down to the Brimstone Crags you might be able to see just what is lurking in the shadows.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.48");
                        break;
                    case "Once those mechanical creations have been defeated you would do well to seek out the crippled clone of the witch, Calamitas. It might provide some useful weaponry.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.49");
                        break;
                    case "I would recommend saving some of your old items. You never know if you can engineer them into stronger weapons in the future.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.50");
                        break;
                    case "Have you heard of the story of Archmage Permafrost? Rumor has it he's been locked away in an icy prison by Lord Yharim. Perhaps you would be able to free him if Cryogen was destroyed.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.51");
                        break;
                    case "You will find more ores have been unlocked due to the magic sealing them away being dispelled. Some of them may require more than just the ore itself to create.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.52");
                        break;
                    case "Throughout the world lie various structures left behind by Draedon. Archaic defenses may remain, but the goods inside may be worth your while.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.53");
                        break;
                    case "The Crimson used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.54");
                        break;
                    case "The Corruption used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.55");
                        break;
                    // case "The dungeon is a dark place. None of us know of its true purpose, however, the ancient Eidolist cultists used it for worship before Lord Yharim took it over.":
                    //     npcPhrase = LangUtils.GetText("Calamity.NpcChatText.SEAHOE.56");
                    //     break;
                    case "I'm assuming you've heard the legends that speak of the ninja, Statis? There are some who say that if you were able to defeat the gods which his clan once worshipped you would be able to harness some of his powers.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.57");
                        break;
                    case "Scattered across the lands are shrines dedicated to the gods. You can take whatever is in them, but a few items you may not be able to use until much later.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.58");
                        break;
                    case "Be careful what you attack in the Crimson. You might just unveil a greater threat than what was there before.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.59");
                        break;
                    case "Be careful what you attack in the Corruption. You might just unveil a greater threat than what was there before.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.60");
                        break;
                    case "The Sulphurous Seas were created long ago, when Yharim's dungeon could no longer hold as many corpses as it needed to. Many of the bodies were dumped into the ocean. This, along with severe pollution from the heydays of Draedon's experiments have turned a paradise into a wasteland.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.61");
                        break;
                    case "The Sulphurous Seas are dangerous. The toxic waters will burn your skin, but if you can brave them you will be able to reach the Abyss, where there are powerful weapons and dangers aplenty.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.62");
                        break;
                    case "Ah yes, the Abyss. That trench is full of powerful creatures that could devour you in a heartbeat. I would explore the dungeon first.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.63");
                        break;
                    case "Have you heard of the Brimstone Crags? It was once a grand kingdom, not too different from my own. However, it also met a similar fate. I would not advise going down there, unless you seek a painful death.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.64");
                        break;
                    case "There are rumors of ores that lay in latency. When you defeat certain bosses you will undo the ancient magic which conceals those materials.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.65");
                        break;
                }
                if (PartyGirl.IsExistingNPC() && npcPhrase == $"{Main.npc[PartyGirl].GivenName} asked if my nose could be used as a vuvuzela. What is a vuvuzela?")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.SEAHOE.8"), Main.npc[PartyGirl].GivenName);
                }
                if (Angler.IsExistingNPC())
                {
                    if (npcPhrase == $"Meet me at {Main.npc[Angler].GivenName}'s house at night. We will throw him to the Trashers.")
                    {
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.SEAHOE.9"), Main.npc[Angler].GivenName);
                    }
                    else if (npcPhrase == $"Not sure how {Main.npc[Angler].GivenName} has not been roasted and digested by now, hanging around the sulphuric seas for so long. Perhaps it got to his head.")
                    {
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.SEAHOE.10"), Main.npc[Angler].GivenName);
                    }
                }
                if (DrunkPrincess.IsExistingNPC() && npcPhrase == $"Rumor has it {Main.npc[DrunkPrincess].GivenName} drinks to forget her troubled past.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.SEAHOE.11"), Main.npc[DrunkPrincess].GivenName);
                }
                if (Witch.IsExistingNPC() && npcPhrase == "I must admit, the Witch's presence is unsettling to me. But so many years have passed, and she too has suffered much.")
                {
                    npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SEAHOE.12");
                }
            }
            else if (TalkingNpc == Bandit)
            {
                switch (npcPhrase)
                {
                    case "Oy, watch where you're going or I might just use you for dart practice.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.1");
                        break;
                    case "Bet you'd look good as a pincushion, amiright?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.2");
                        break;
                    case "Zombies don't dodge very well. Maybe you'll do a bit better.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.3");
                        break;
                    case "Hey, careful over there. I've rigged the place. One wrong step and you're going to get a knife in your forehead.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.4");
                        break;
                    case "Hm, the stars are too bright tonight. Makes sneaking around a little more difficult.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.5");
                        break;
                    case "You think those stars that fall occasionally would make good throwing weapons?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.6");
                        break;
                    case "Where is my party hat? Well, I stole it of course.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.7");
                        break;
                    case "The nice thing about maps is I can track anything that has fallen.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.8");
                        break;
                    case "Imagine how fast you could throw if you just had more hands.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.9");
                        break;
                    case "I also take food for currency.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.10");
                        break;
                    case "Usually I only think of animals as food or target practice, but dragons are an exception.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.11");
                        break;
                    case "Anything is a weapon if you throw it hard enough.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.12");
                        break;
                    case "That's your chucking arm? You need to work out more.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.13");
                        break;
                    case "Listen here. It's all in the wrist, the wrist! Oh, forget it.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.14");
                        break;
                    case "Eh you know how it goes; steal from the rich, give to the poor, but I do take a cut of the profit.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.15");
                        break;
                    case "Snakes! Why does it always have to be snakes!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.16");
                        break;
                    case "It's super nice you know, to just have everything you want. Some people never got that luxury.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.17");
                        break;
                    case "It's not stealing! I'm just borrowing it until I die!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.18");
                        break;
                    case "Wouldn't be the first time I used remains as weapons.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.19");
                        break;
                    case "All sorts of new weapons to be found and looted. Get to that, and I'll share some of my collection too!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.20");
                        break;
                    case "There's so much scrap around this land with valuable parts to them. Makes you wonder who could afford to leave em all around.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.21");
                        break;
                    case "Crypts, tombs, dungeons, those're all just treasure troves to me. The dead are dead, they've got nothing to do with it.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.22");
                        break;
                    case "If you find anything cool, make sure to drop by and show it to me, I promise I’ll keep my hands off it.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.23");
                        break;
                    case "So many new things to steal, I can’t think of where to start!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.24");
                        break;
                    case "If I end up angering some deities or whatever, would you mind taking the blame for me?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.25");
                        break;
                    case "Oh man, did you rip that off a shark!? Now that's a weapon!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.26");
                        break;
                    case "I'd rather not be here. This place has bad vibes, y'know? It brings back some unpleasant memories.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.27");
                        break;
                    case "Hey, if government officials can get tax, why can't I? The heck do you mean that these two things are nothing alike?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.33");
                        break;
                    case "Sorry, I got nothing. Perhaps you could reforge something and come back later...":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.34");
                        break;
                }
                if (Merchant.IsExistingNPC() && npcPhrase == $"Don't tell {Main.npc[Merchant].GivenName}, but I took some of his stuff and replaced it with Angel Statues.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.THIEF.28"), Main.npc[Merchant].GivenName);
                }
                if (Witch.IsExistingNPC() && npcPhrase == "Hey, hey, has Calamitas seriously moved in here with us? Why???")
                {
                    npcPhrase = LangHelper.GetText("Calamity.NpcChatText.THIEF.29");
                }
                if (DrunkPrincess.IsExistingNPC() && npcPhrase == $"I learned never to steal {Main.npc[DrunkPrincess].GivenName}'s drinks. She doesn't appreciate me right now, so I'll go back to hiding.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.THIEF.30"), Main.npc[DrunkPrincess].GivenName);
                }
                if (ArmsDealer.IsExistingNPC() && Nurse.IsExistingNPC() && npcPhrase == $"Don't tell {Main.npc[Nurse].GivenName} that I was responsible for {Main.npc[ArmsDealer].GivenName}'s injuries.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.THIEF.31"), Main.npc[Nurse].GivenName, Main.npc[ArmsDealer].GivenName);
                }
                if (GoblinTinkerer.IsExistingNPC() && npcPhrase == $"Want in on a little secret? Since {Main.npc[GoblinTinkerer].GivenName} always gets so much cash from you, I've been stealing some of it as we go. I need you to keep quiet about it, so here.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.THIEF.32"), Main.npc[GoblinTinkerer].GivenName);
                }
            }
            else if (TalkingNpc == Witch)
            {
                switch (npcPhrase)
                {
                    case "I'm considering moving back to that old cave of mine.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.1");
                        break;
                    case "I certainly can't return to the Tyrant's old dwellings now, have you got any places to stay?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.2");
                        break;
                    case "I can't pay rent, but if you've got any dead relative you want me to try and... what? You don't?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.3");
                        break;
                    case "One of these days, I was thinking of starting a garden with the flowers from the old capitol of hell. I love the smell of brimstone in the morning.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.4");
                        break;
                    case "I think I've settled comfortably, thank you very much.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.5");
                        break;
                    case "Many seasons have gone by since I first met with the Tyrant, and only now did I break free. I wish I'd been stronger...":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.6");
                        break;
                    case "If you've got any curses you want dispelled... well I'm not your person.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.6");
                        break;
                    case "Such an unnatural shade of red. Nothing like my brimstone flames.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.7");
                        break;
                    case "I can't work with nights like these. The stars seem to have shrunk away in fear.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.8");
                        break;
                    case "These undead are horrific, I can't stand to look at them. How could anyone be satisfied with such amateur work?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.9");
                        break;
                    case "I don't think it's a stretch to say that astrology is utter nonsense... but it was a hobby of mine once.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.10");
                        break;
                    case "If another person asks me if I can dance or not, I will light their hat on fire.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.11");
                        break;
                    case "Mrrp is cringe.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.15");
                        break;
                }
                
                if (SeaKing.IsExistingNPC() && npcPhrase == "I cannot understand the Sea King. He does not seem to want me dead. That amount of compassion I just can't understand.")
                {
                    npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.12");
                }
                if (Archmage.IsExistingNPC() && npcPhrase == "That frosty old man... even if you ignore our brands of magic and our old alliances, I doubt I'd ever get along with him.")
                {
                    npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Witch.13");
                }
                if (DrunkPrincess.IsExistingNPC() && npcPhrase == $"I wonder if {Main.npc[DrunkPrincess].GivenName} ever feels cold given how revealing her dress is. Perhaps she should cover up a bit more.")
                {
                    npcPhrase = String.Format(LangHelper.GetText("Calamity.NpcChatText.Witch.14"), Main.npc[DrunkPrincess].GivenName);
                }
            }
            else if (TalkingNpc == Merchant)
            {
                switch (npcPhrase)
                {
                    case "Each night seems only more foreboding than the last. I feel unthinkable terrors are watching your every move.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Merchant.1");
                        break;
                    case "Are you daft?! Turn off those lamps!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Merchant.2");
                        break;
                    case "If this acid rain keeps up, there'll be a shortage of Dirt Blocks soon enough!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Merchant.3");
                        break;
                    case "I happen to have several Angel Statues at the moment, a truely rare commodity. Want one?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Merchant.4");
                        break;
                    case "The caverns have become increasingly dark as of late, so I stocked up on some special torches if you have the funds.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Merchant.5");
                        break;
                }
            }
            else if (TalkingNpc == ArmsDealer)
            {
                switch (npcPhrase)
                {
                    case "That's the biggest moth I've ever seen for sure. You'd need one big gun to take one of those down.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.ArmsDealer.1");
                        break;
                    case "Is it me or are your weapons getting bigger and bigger?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.ArmsDealer.2");
                        break;
                }
            }
            else if (TalkingNpc == Dryad)
            {
                switch (npcPhrase)
                {
                    case "There's a dark solar energy emanating from the moths that appear during this time. Ah, the moths as you progress further get more powerful... hmm... what power was Yharon holding back?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Dryad.1");
                        break;
                    case "That starborne illness sits upon this land like a blister. Do even more vile forces of corruption exist in worlds beyond?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Dryad.2");
                        break;
                    case "My ancestor was lost here long ago. I must pay my respects to her.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Dryad.4");
                        break;
                    case "\u0093I'm not here for any reason! Just picking up mushrooms for uh, later use.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Dryad.5");
                        break;
                }
                if (DrunkPrincess.IsExistingNPC() && npcPhrase == $"{Main.npc[DrunkPrincess].GivenName} put me up to this.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.Dryad.3"), Main.npc[DrunkPrincess].GivenName);
                }
            }
            else if (TalkingNpc == Guide)
            {
                switch (npcPhrase)
                {
                    case "Could you be so kind as to, ah... check hell for me...? I left someone I kind of care about down there.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Guide.1");
                        break;
                    case "I have this sudden shiver up my spine, like a meteor just fell and thousands of innocent creatures turned into monsters from the stars.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Guide.2");
                        break;
                    case "The dungeon seems even more restless than usual, watch out for the powerful abominations stirring up in there.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Guide.3");
                        break;
                    case "Seems like extinguishing that butterfly caused its life to seep into the hallowed areas, try taking a peek there and see what you can find!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Guide.4");
                        break;
                    case "I've heard there is a portal of antimatter absorbing everything it can see in the dungeon, try using the Rune of Kos there!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Guide.5");
                        break;
                }
            }
            else if (TalkingNpc == Demolitionist)
            {
                if (npcPhrase == "God Slayer Dynamite? Boy do I like the sound of that!")
                {
                    npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Demolitionist.1");
                }
            }
            else if (TalkingNpc == Clothier)
            {
                switch (npcPhrase)
                {
                    case "Who you gonna call?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Clothier.1");
                        break;
                    case "Those screams... I'm not sure why, but I feel like a nameless fear has awoken in my heart.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Clothier.2");
                        break;
                    case "I can faintly hear ghostly shrieks from the dungeon... and not ones I'm familiar with at all. Just what is going on in there?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Clothier.3");
                        break;
                    case "Whatever that thing was, I'm glad it's gone now.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Clothier.4");
                        break;
                    case "Houston, we've had a problem.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Clothier.5");
                        break;
                }
            }
            else if (TalkingNpc == GoblinTinkerer)
            {
                switch (npcPhrase)
                {
                    case "You know... we haven't had an invasion in a while...":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.GoblinTinkerer.2");
                        break;
                }
                if (Bandit.IsExistingNPC() && npcPhrase == $"Hey, is it just me or have my pockets gotten lighter ever since {Main.npc[Bandit].GivenName} arrived?")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.GoblinTinkerer.1"), Main.npc[Bandit].GivenName);
                }
            }
            else if (TalkingNpc == Wizard)
            {
                switch (npcPhrase)
                {
                    case "Space just got way too close for comfort.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Wizard.1");
                        break;
                }
            }
            else if (TalkingNpc == Mechanic)
            {
                switch (npcPhrase)
                {
                    case "What do you mean your traps aren't making the cut? Don't look at me!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Mechanic.1");
                        break;
                    case "Um... should my nightlight be on?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Mechanic.2");
                        break;
                    case "Maybe I should've waterproofed my gadgets... They're starting to corrode.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Mechanic.4");
                        break;
                }
                if (DrunkPrincess.IsExistingNPC())
                {
                    if (npcPhrase == $"Well, I like {Main.npc[DrunkPrincess].GivenName}, but I, ah... I have my eyes on someone else.")
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.Mechanic.3"), Main.npc[DrunkPrincess].GivenName);
                }
            }
            else if (TalkingNpc == Truffle)
            {
                switch (npcPhrase)
                {
                    case "I don't feel very safe; I think there's pigs following me around and it frightens me.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Truffle.1");
                        break;
                }
                if (DrunkPrincess.IsExistingNPC())
                {
                    if (npcPhrase == $"Sometimes, {Main.npc[DrunkPrincess].GivenName} just looks at me funny and I'm not sure how I feel about that.")
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.Mechanic.2"), Main.npc[DrunkPrincess].GivenName);
                }
            }
            else if (TalkingNpc == Steampunk)
            {
                switch (npcPhrase)
                {
                    case "Just what is that contraption? It makes my Teleporters look like child's play!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Steampunker.1");
                        break;
                    case "Yep! I'm also considering being a space pirate now.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Steampunker.2");
                        break;
                    case "Some of my machines are starting to go haywire thanks to this Astral Infection. I probably shouldn't have built them here":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Steampunker.3");
                        break;
                    case "I'm sorry I really don't have any Unicorn proof tech here, you're on your own.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Steampunker.4");
                        break;
                }
            }
            else if (TalkingNpc == DyeTrader)
            {
                switch (npcPhrase)
                {
                    case "Have you seen those gemstone creatures in the caverns? Their colors are simply breathtaking!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.DyeTrader.1");
                        break;
                }
                if (Archmage.IsExistingNPC() && npcPhrase == $"Do you think {Main.npc[Archmage].GivenName} knows how to 'let it go?'")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.DyeTrader.2"), Main.npc[Archmage].GivenName);
                }
            }
            else if (TalkingNpc == PartyGirl)
            {
                switch (npcPhrase)
                {
                    case "I think my light display is turning into an accidental bug zapper. At least the monsters are enjoying it.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.PartyGirl.2");
                        break;
                    case "Ooh! I love parties where everyone wears a scary costume!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.PartyGirl.3");
                        break;
                }
                if (DrunkPrincess >= 0 && npcPhrase == $"I have a feeling we're going to have absolutely fantastic parties with {Main.npc[DrunkPrincess].GivenName} around!")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.PartyGirl.1"), Main.npc[DrunkPrincess].GivenName);
                }
            }
            else if (TalkingNpc == Cyborg)
            {
                switch (npcPhrase)
                {
                    case "All these moments will be lost in time. Like tears... in the rain.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Cyborg.1");
                        break;
                    case "Always shoot for the moon! It has clearly worked before.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Cyborg.2");
                        break;
                    case "Draedon? He's... a little 'high octane' if you know what I mean.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Cyborg.3");
                        break;
                    case "Those oversized bugs terrorizing the jungle... Surely you of all people could shut them down!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Cyborg.4");
                        break;
                }
            }
            else if (TalkingNpc == Painter)
            {
                switch (npcPhrase)
                {
                    case "A little sickness isn't going to stop me from doing my work as an artist!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Painter.1");
                        break;
                    case "There's a surprising art to this area. A sort of horrifying, eldritch feeling. It inspires me!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Painter.2");
                        break;
                    case "I'm not exactly suited for this cold weather. Still looks pretty, though.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Painter.3");
                        break;
                    case "I hate sand. It's coarse, and rough and gets in my paint.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Painter.5");
                        break;
                    case "Do you think unicorn blood could be used as a good pigment or resin? No I'm not going to find out myself.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Painter.6");
                        break;
                    case "I can't work in this environment. All of my paint just floats off.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Painter.7");
                        break;
                    case "Painting the tortoises in a still life isn't going so well.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Painter.8");
                        break;
                    case "I can't paint a still life if the fruit grows legs and walks away.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Painter.9");
                        break;
                    case "On the canvas, things get heated around here all the time. Like the environment!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Painter.10");
                        break;
                    case "Sorry, I'm all out of watercolors. They keep evaporating.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Painter.11");
                        break;
                    case "Roses, really? That's such an overrated thing to paint.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Painter.12");
                        break;
                    case "Fun fact! Sulphur was used as pigment once upon a time! Or was it Cinnabar?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Painter.13");
                        break;
                    case "Easiest landscape I've ever painted in my life.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Painter.14");
                        break;
                }
                if (Archmage >= 0 && npcPhrase == $"Think {Main.npc[Archmage].GivenName} would let me paint him like one of his French girls?!")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.Painter.4"), Main.npc[Archmage].GivenName);
                }
            }
            else if (TalkingNpc == WitchDoctor)
            {
                switch (npcPhrase)
                {
                    case "My home here has an extensive history and a mysterious past. You'll find out quickly just how extensive it is...":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.WitchDoctor.1");
                        break;
                    case "I have unique items if you show me that you have bested the guardian of this jungle.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.WitchDoctor.2");
                        break;
                    case "This is as good a time as any to pick up the best ingredients for potions.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.WitchDoctor.3");
                        break;
                }
            }
            else if (TalkingNpc == Pirate)
            {
                switch (npcPhrase)
                {
                    case "Aye, I've heard of a mythical creature in the oceans, singing with an alluring voice. Careful when yer fishin out there.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Pirate.1");
                        break;
                    case "I have to thank ye again for takin' care of that sea serpent. Or was that another one...":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Pirate.2");
                        break;
                    case "Twenty-nine bottles of beer on the wall...":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Pirate.4");
                        break;
                    case "Now this is a scene that I can admire any time! I feel like something is watching me though.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Pirate.5");
                        break;
                    case "It ain't much of a sight, but there's still life living in these waters.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Pirate.6");
                        break;
                    case "Me ship might just sink from the acid alone.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Pirate.7");
                        break;
                }
                if (SeaKing.IsExistingNPC() && npcPhrase == $"I remember legends about that {Main.npc[SeaKing].GivenName}. He ain't quite how the stories make him out to be though.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.Pirate.3"), Main.npc[SeaKing].GivenName);
                }
            }
            else if (TalkingNpc == Stylist)
            {
                switch (npcPhrase)
                {
                    case "Please don't catch space lice. Or Crimson lice. Or just lice in general.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Stylist.1");
                        break;
                    case "Please don't catch space lice. Or Corruption lice. Or just lice in general.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Stylist.2");
                        break;
                    case "They look so cute and yet, I can feel their immense power just by being near them. What are you?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Stylist.5");
                        break;
                    case "I hate to break it to you, but you don't have hair to cut or style, hun.":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Stylist.6");
                        break;
                    case "Aww, they're so cute, do they have names?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Stylist.7");
                        break;
                }
                if (DrunkPrincess.IsExistingNPC())
                {
                    if (npcPhrase == $"Sometimes I catch {Main.npc[DrunkPrincess].GivenName} sneaking up from behind me.")
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.Stylist.3"), Main.npc[DrunkPrincess].GivenName);
                    else if (npcPhrase == $"{Main.npc[DrunkPrincess].GivenName} is always trying to brighten my mood... even if, deep down, I know she's sad...")
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.Stylist.4"), Main.npc[DrunkPrincess].GivenName);
                }
            }
            else if (TalkingNpc == TravellingMerchant)
            {
                if (DrunkPrincess.IsExistingNPC() && Merchant.IsExistingNPC() && npcPhrase == $"Tell {Main.npc[DrunkPrincess].GivenName} I'll take up her offer and meet with her at the back of {Main.npc[Merchant].GivenName}'s house.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.TravellingMerchant.1"), Main.npc[DrunkPrincess].GivenName, Main.npc[Merchant].GivenName);
                }
            }
            else if (TalkingNpc == Angler)
            {
                if (SeaKing.IsExistingNPC())
                {
                    if (npcPhrase == $"Someone tell {Main.npc[SeaKing].GivenName} to quit trying to throw me out of town, it's not going to work.")
                    {
                        npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.Angler.1"), Main.npc[SeaKing].GivenName);
                    }
                }
            }
            else if (TalkingNpc == TaxCollector)
            {
                switch (npcPhrase)
                {
                    case "BAH! Doesn't seem like I'll ever be able to quarrel with the debts of the town again!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.TaxCollector.1");
                        break;
                    case "Where and how are you getting all of this money?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.TaxCollector.2");
                        break;
                    case "Perhaps with all that time you've got you could check those old ruins? Certainly something of value in it for you!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.TaxCollector.3");
                        break;
                    case "Devourer of what, you said? Devourer of Funds, if its payroll is anything to go by!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.TaxCollector.4");
                        break;
                    case "Goodness! That cane has swagger!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.TaxCollector.5");
                        break;
                }
            }
            else if (TalkingNpc == SkeletonMerchant)
            {
                switch (npcPhrase)
                {
                    case "What'dya buyin'?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.SkeletonMerchant.1");
                        break;
                }
            }
            else if (TalkingNpc == Bartender)
            {
                switch (npcPhrase)
                {
                    case "Care for a little Moonshine?":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Bartender.1");
                        break;
                }
                if (DrunkPrincess.IsExistingNPC() && npcPhrase == $"Sheesh, {Main.npc[DrunkPrincess].GivenName} is a little cruel, isn't she? I never claimed to be an expert on anything but ale!")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Calamity.NpcChatText.Bartender.2"), Main.npc[DrunkPrincess].GivenName);
                }
            }
            else if (TalkingNpc == Nurse)
            {
                switch (npcPhrase)
                {
                    case "Now is not the time!":
                        npcPhrase = LangHelper.GetText("Calamity.NpcChatText.Nurse.1");
                        break;
                }
            }

            Main.npcChatText = npcPhrase;
        }
    }
}