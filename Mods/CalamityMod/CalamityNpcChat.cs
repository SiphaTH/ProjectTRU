using System;
using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

[JITWhenModsEnabled("CalamityMod")]
public class CalamityNpcChat : ContentTranslation
{
    public override bool IsTranslationEnabled => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    #region Properties
    private int Dryad => NPC.FindFirstNPC(NPCID.Dryad);
    private int Bartender => NPC.FindFirstNPC(NPCID.DD2Bartender);
    private int Stylist => NPC.FindFirstNPC(NPCID.Stylist);
    private int PartyGirl => NPC.FindFirstNPC(NPCID.PartyGirl);
    private int Angler => NPC.FindFirstNPC(NPCID.Angler);
    private int Merchant => NPC.FindFirstNPC(NPCID.Merchant);
    private int ArmsDealer => NPC.FindFirstNPC(NPCID.ArmsDealer);
    private int Nurse => NPC.FindFirstNPC(NPCID.Nurse);
    private int GoblinTinkerer => NPC.FindFirstNPC(NPCID.GoblinTinkerer);
    private int Guide => NPC.FindFirstNPC(NPCID.Guide);
    private int Demolitionist => NPC.FindFirstNPC(NPCID.Demolitionist);
    private int Clothier => NPC.FindFirstNPC(NPCID.Clothier);
    private int Wizard => NPC.FindFirstNPC(NPCID.Wizard);
    private int Mechanic => NPC.FindFirstNPC(NPCID.Mechanic);
    private int Truffle => NPC.FindFirstNPC(NPCID.Truffle);
    private int Steampunk => NPC.FindFirstNPC(NPCID.Steampunker);
    private int DyeTrader => NPC.FindFirstNPC(NPCID.DyeTrader);
    private int Cyborg => NPC.FindFirstNPC(NPCID.Cyborg);
    private int Painter => NPC.FindFirstNPC(NPCID.Painter);
    private int WitchDoctor => NPC.FindFirstNPC(NPCID.WitchDoctor);
    private int Pirate => NPC.FindFirstNPC(NPCID.Pirate);
    private int TravellingMerchant => NPC.FindFirstNPC(NPCID.TravellingMerchant);
    private int TaxCollector => NPC.FindFirstNPC(NPCID.TaxCollector);
    private int SkeletonMerchant => NPC.FindFirstNPC(NPCID.SkeletonMerchant);
    private int Archmage => NPC.FindFirstNPC(ModsCall.Calamity.Find<ModNPC>("DILF").Type);
    private int DrunkPrincess => NPC.FindFirstNPC(ModsCall.Calamity.Find<ModNPC>("FAP").Type);
    private int SeaKing => NPC.FindFirstNPC(ModsCall.Calamity.Find<ModNPC>("SEAHOE").Type);
    private int Bandit => NPC.FindFirstNPC(ModsCall.Calamity.Find<ModNPC>("THIEF").Type);
    private int Witch => NPC.FindFirstNPC(ModsCall.Calamity.Find<ModNPC>("WITCH").Type);
    private bool IsTalking => Main.LocalPlayer.talkNPC >= 0;
    private int TalkingNpc => Main.player[Main.myPlayer].talkNPC;
    #endregion
    
    private bool IsExistingNPC(int npcType) => npcType >= 0;
    
    public override void LoadTranslation()
    {
        if (!IsTalking)
            return;

        string npcPhrase = Main.npcChatText;

        if (TalkingNpc == Archmage)
        {
            npcPhrase = npcPhrase switch
            {
                "The sun beats down harshly upon my creations here. If you would allow me to conjure a blizzard every now and then..." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.1"),
                "I must admit, I’m not quite used to this weather. It's far too warm for my tastes..." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.2"),
                "Nightfall is a good time for practicing magic. We mages often rely on celestial bodies and their fragments to enhance our mana." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.3"),
                "Necromancy was never a field I found interesting. Why utilize the rotting corpses of people, when you could form far more elegant servants of ice?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.4"),
                "The tundra’s unnatural state is not all my doing. Decades ago, I came across it and amplified the climate with my magic." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.5"),
                "If you have a request, make it quick. I am in the process of weaving a spell, which requires great focus." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.6"),
                "You have the makings of a gifted mage. Tell me, what do you think of ice magic?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.7"),
                "Flowers and the like don’t hold a candle to the beauty of intricately formed ice." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.8"),
                "Sometimes... I feel like all I'm good for during these events is making ice cubes and slushies." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.9"),
                "If your blood were to thoroughly freeze, it would be quite fatal." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.10"),
                "The undead which roam tonight are still monsters of blood and guts, but they seem... fresher." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.11"),
                "It is shocking, to see you have come so far. I wish you the best of luck on your future endeavours." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.12"),
                "You, having bested so many beings, even deities, I wonder if I have anything left to offer you." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.13"),
                "I have not seen such a sky in decades. Who are you, to so brazenly march against that Tyrant?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.14"),
                "I... deeply appreciate you rescuing me from being trapped within my frozen castle. It's been many, many years." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Archmage.15"),
                _ => npcPhrase
            };
        }
        else if (TalkingNpc == DrunkPrincess)
        {
            npcPhrase = npcPhrase switch
            {
                "Why are you talking to me right now? Shouldn't you be bumbling around and dying for my amusement?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.1"),
                "I could smell my vodka from MILES away!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.2"),
                "Have any spare rooms available? Preferably candle-lit with a hefty supply of booze?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.3"),
                "I drink to forget certain... things. What things, you might ask? Well, the point is to forget them, isn't it?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.9"),
                "I'm literally balls drunk off my sass right now, what do you want?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.10"),
                "I'm either laughing because I'm drunk or because I've lost my mind, probably both." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.11"),
                "When I'm drunk I'm way happier... at least until the talking worms start to appear." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.12"),
                "I should reprogram the whole mod, while drunk, then send it back to the testers." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.13"),
                "What a great day! Might just drink so much that I get poisoned again." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.15"),
                "A perfect night to light some candles, drink some wine and relax." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.16"),
                "Here's a challenge... take a shot for every time you've had to look at the wiki. Oh wait, you'd die." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.17"),
                "Yes, everyone knows the mechworm is buggy. Well, not anymore, but still." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.18"),
                "You lost or something? I don't mind company, but I'd rather be left alone at night." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.19"),
                "Are you sure you're 21? ...Alright, fine, but don't tell anyone I sold you these." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.20"),
                "I HATE WALMART! ...Anyway, what do you want this time?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.22"),
                "Drink something that turns you into a magical flying unicorn so you can be just like me." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.23"),
                "Did anyone ever tell you that large assets cause back pain? Well, they were right." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.24"),
                "Deals so good I'll [$$!$] myself! ...Sorry, just had a minor stroke!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.25"),
                "You'll always find me at parties where booze is involved... well, you'll always find BOOZE where I'M involved!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.26"),
                "You should probably deal with those ayy lmaos before anything else, but whatever." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.27"),
                "God I can't wait to smash some ice again! ...For drinks, of course." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.28"),
                "How could you murder such a beautiful creature!? ...The blue sexy one, not the obese cucumber." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.29"),
                "Ever wondered why the Moon Lord needed so many tentacles? Uh... on second thought, I won't answer that." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.30"),
                "I'm melting! Put a stop to this inclement weather this instant before it ruins my hair!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.31"),
                "I saw a ghost down by the old train tracks back at my homeland once, flailing wildly at the lily pads... frightening times those were." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.32"),
                "I hear it's amazing when the famous Devourer of Gods out in flap-jaw space, with the tuning fork, does a raw blink on Hara-kiri rock. I need scissors! 61!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.33"),
                "The hell is that? Looks like something I'd carry around if I was 5 years old." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.39"),
                "Nice scales... is it hot in here or is it just me?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.40"),
                "Do you like my vodka? I created it by mixing fairy dust, crystallized cave sweat and other magical crap." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.41"),
                "So... you found my special bottle. Hope you enjoy it, I know I will." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.42"),
                "Be sure to dismount me once in a while, I get tired. And besides, I can't rip you off-I mean offer you excellent deals you won't find anywhere else if you're riding me 24/7." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.43"),
                "Before you ask, no, I do NOT have a heart on my butt while in human form. Don't question my transformation preferences!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.44"),
                "I'm gonna make some Bloody Marys to relax, celery included. Want one?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.45"),
                "If you're too lazy to craft potions normally, try Blood Orbs. Blood is fuel, dumbass." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.46"),
                "I'm trying to not be bitchy tonight, but it's hard when everyone else won't shut up." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.47"),
                "Sorry, I have no moral compass at the moment." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.48"),
                _ => npcPhrase
            };
            if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} time.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.49"), npcPhrase.Split(' ')[3]);
            }
            else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.50"), npcPhrase.Split(' ')[3]);
            }
            else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times. Congratulations! You are now, officially, the biggest loser in Terraria's history! Who was number two? Hell if I know.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.51"), npcPhrase.Split(' ')[3]);
            }
            else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times. I'm not sure what to say this time. That you're bad and should feel bad? That much was known already.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.52"), npcPhrase.Split(' ')[3]);
            }
            else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times. Bless your heart. I could dodge better than you even if I were drunk high.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.53"), npcPhrase.Split(' ')[3]);
            }
            else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times. It is said the average Terrarian has a lifespan of 2 minutes or less. ...Well, not really, but I feel like you'd be part of that statistic.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.54"), npcPhrase.Split(' ')[3]);
            }
            else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times. Your inability to avoid dying to even the most basic of attacks is astonishing to me.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.55"), npcPhrase.Split(' ')[3]);
            }
            else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times. I admire your tenacity. Keep it up, your enemies are racking up quite the kill count!")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.56"), npcPhrase.Split(' ')[3]);
            }
            else if (npcPhrase == $"You have failed {Main.player[Main.myPlayer].Calamity().deathCount} times. Consider lowering the difficulty. If you found that statement irritating, good.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.57"), npcPhrase.Split(' ')[3]);
            }
            if (IsExistingNPC(Bartender))
            {
                if (npcPhrase == "I've had to tell baldie where my eyes are so many times that I've lost count.")
                {
                    npcPhrase = LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.34");
                }
                if (npcPhrase == $"Tell {Main.npc[Bartender].GivenName} to stop calling me. He's not wanted.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.35"), Main.npc[Bartender].GivenName);
                }
                else if (npcPhrase == $"My booze will always be better than {Main.npc[Bartender].GivenName}'s, and nobody can convince me otherwise.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.36"), Main.npc[Bartender].GivenName);
                }
            }
            if (IsExistingNPC(Archmage) && npcPhrase == $"I never realized how well-endowed {Main.npc[Archmage].GivenName} was. It had to be the largest icicle I'd ever seen.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.37"), Main.npc[Archmage].GivenName);
            }
            if (IsExistingNPC(Witch) && npcPhrase == $"The abuse {Main.npc[Witch].GivenName} went through is something I can hardly comprehend. I'd offer her a drink, but I don't think she'd enjoy it.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.38"), Main.npc[Witch].GivenName);
            }
            if (IsExistingNPC(Stylist))
            {
                if (npcPhrase == $"You can't stop me from trying to move in with {Main.npc[Stylist].GivenName}.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.4"), Main.npc[Stylist].GivenName);
                }
                else if (npcPhrase == $"I love it when {Main.npc[Stylist].GivenName}'s hands get sticky from all that... wax.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.5"), Main.npc[Stylist].GivenName);
                }
                // else if (npcPhrase == $"{Main.npc[Stylist].GivenName} works wonders for my hair... among other things.")
                // {
                //     npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.6"), Main.npc[Stylist].GivenName);
                // }
                else if (npcPhrase == $"Ever since {Main.npc[Stylist].GivenName} moved in I haven't been drinking as much... a strange but not unwelcome feeling.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.7"), Main.npc[Stylist].GivenName);
                }
                else if (npcPhrase == $"{Main.npc[Stylist].GivenName} helped me learn to accept my past. It's been rough, but I think I'm on the right track now.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.8"), Main.npc[Stylist].GivenName);
                }
                else if (npcPhrase == $"Might go out for a jog later with {Main.npc[Stylist].GivenName}. Nice day for it.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.14"), Main.npc[Stylist].GivenName);
                }
                else if (npcPhrase == $"I should watch some movies with {Main.npc[Stylist].GivenName} tonight. You could come too, but only if you bring snacks for us.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DrunkPrincess.21"), Main.npc[Stylist].GivenName);
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
            npcPhrase = npcPhrase switch
            {
                "My home may have been destroyed and my people lost... But I will assist you to honor their memory." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.1"),
                "How odd it is, that your people leave the care of those yet to be born to the females. Our males carry the eggs until they hatch." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.2"),
                "How can I survive on land? Ah, that is a secret. No, actually... I can breathe air like you!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.3"),
                "Ah, if only you could have seen the beauty of a kingdom submerged in water. The way the light refracted and shone over our coral homes..." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.4"),
                "There lurk horrifying creatures beyond the light of our homes. You should take care." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.5"),
                "My eyes are not well suited to bright lights after so many years of darkness. The peace of the night is welcome." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.6"),
                "Oh, me? I do not sleep, it is part of my nature." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.7"),
                "Since ancient times people have said that deities cause celestial events. Which one then, is the cause for these?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.13"),
                "I've never been keen on these nights. Such violence." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.14"),
                "Your presence is now known to a great many things. It is unlikely that they will be as friendly towards you as I have been." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.15"),
                "Hm... The veil has fallen, and the world begins to show its true colors. I hope you will trek a righteous path, though even I am not sure what that may be." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.16"),
                "These days, the night sky feels... just a little less oppressive now." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.17"),
                "Some of these beings I had thought previously to be only legends. To see them in all their glory... what a macabre privilege." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.18"),
                "To see that Tyrant’s serpent free of its shackles. It gave me chills." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.19"),
                "How much more has the world fallen to ruin? Even the Tyrant’s empire..." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.20"),
                "Thank you for your service, my child, but I am afraid I am without a home now." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.21"),
                "If this shows up, something went wrong." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.22"),
                "Draedon's style of confrontation is very... alien and hands-off. You may be more likely to fight any one of his mechs before taking him down." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.23"),
                "Lord Yharim possesses god-like strength. He may not even fight you at full power which is fortunate for you. His attacks may just kill you in one hit, so be careful." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.24"),
                "Pockets of ore have appeared once more in the land. This will allow you to create the most powerful weaponry and armor imagined!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.25"),
                // case "Ah, the dragon Yharon is fickle. You may find that he will refuse to use his full power unless you are strong enough to unleash the power of the Dark Sun.":
                //     npcPhrase = LangUtils.GetText("CalamityMod.NPCs.Dialogues.SeaKing.26");
                //     break;
                "The Devourer of Gods is extremely powerful. However, he is young, foolhardy, and very lazy. Perhaps if he had been given time to develop he would have turned into quite the threat." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.27"),
                "With the cosmic steel you can fashion many of your weapons into much more powerful forms." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.28"),
                "The Devourer of God's cosmic armor is unique in that it is capable of not only protecting his body from tearing itself apart when ripping through the fabric of space and time, but also allows him to control his powers." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.29"),
                "Ah... I can sense a powerful change in the weather. You may want to venture to the Sulphurous Seas once more during the rain to experience it." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.30"),
                "The Abyss holds many secrets revealed with time. Checking it out again may not be a bad idea." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.31"),
                "The Dungeon seems to be more active now. You may hear the faint whisperings of angry spirits who have not left to the Void... I would recommend searching there before taking on the Sentinels." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.32"),
                "Ironic, is it not, that Statis was defeated by the very Sentinel his people fashioned their art of stealth from. Fate so often weaves cruel tales." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.33"),
                "The Rune of Kos holds a significant portion of Providence's brand of magic, easily distinguishable from all others. Activating it in certain places would have some... risky consequences." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.34"),
                "The stories have it that when Providence faced and defeated Yharim and his forces she lost a lot of energy and reverted to a more skeletal form. She's merely a fraction of the power she was before." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.35"),
                "Providence is as much the sun goddess as much as the Moon Lord is the moon god. They are two sides of the same coin, choosing to remain neutral amongst our petty squabbles." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.36"),
                "Touching Providence's offerings is usually a death wish. Shame that Yharim didn't think to just mess with her things to get her out of hiding." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.37"),
                "The Profaned Guardians will do anything to protect their goddess. Makes sense they would die for her since they can be revived just as quickly." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.38"),
                "Profaned creatures now lurk in the Hallow and in Hell. If you destroy enough and gather their essence together you shall be able to capture the attention of the Profaned Guardians." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.39"),
                "Your adventure focuses to the jungle it seems. The Dragonfolly and its swarming offspring should be eliminated before their numbers spiral out of control." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.40"),
                "The plague was just one of the many experiments authorized by Yharim to raze towns to the ground. This is probably one of the few he shelved for being too terrible." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.41"),
                "The Abyss has become far more active than before. You might be able to mine some of the volcanic rubble contained within." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.42"),
                "The men at the front of the dungeon are performing a ritual to keep the Moon Lord contained in his prison. In order to gain Yharim's attention, however, you may need to defeat them." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.43"),
                "When exploring the jungle temple be careful. You may not wish to disturb the Lihzahrd's idol, the Golem. It's quite the destructive force." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.44"),
                "Be careful when defeating Plantera and the Golem. You might accidentally unleash a new threat in the jungle that needs to be quelled." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.45"),
                "If you've gathered the souls used to power those automatons head once more to the jungle. You will find a powerful enemy to fight, which will unleash the full fervor of the jungle once defeated. Do not underestimate it!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.46"),
                "The Brimstone Crags... Yharim despised that place, and did everything he could to raze it to the ground. It might explain a few things about him." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.47"),
                "If you take an idol down to the Brimstone Crags you might be able to see just what is lurking in the shadows." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.48"),
                "Once those mechanical creations have been defeated you would do well to seek out the crippled clone of the witch, Calamitas. It might provide some useful weaponry." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.49"),
                "I would recommend saving some of your old items. You never know if you can engineer them into stronger weapons in the future." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.50"),
                "Have you heard of the story of Archmage Permafrost? Rumor has it he's been locked away in an icy prison by Lord Yharim. Perhaps you would be able to free him if Cryogen was destroyed." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.51"),
                "You will find more ores have been unlocked due to the magic sealing them away being dispelled. Some of them may require more than just the ore itself to create." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.52"),
                "Throughout the world lie various structures left behind by Draedon. Archaic defenses may remain, but the goods inside may be worth your while." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.53"),
                "The Crimson used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.54"),
                "The Corruption used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.55"),
                // case "The dungeon is a dark place. None of us know of its true purpose, however, the ancient Eidolist cultists used it for worship before Lord Yharim took it over.":
                //     npcPhrase = LangUtils.GetText("CalamityMod.NPCs.Dialogues.SeaKing.56");
                //     break;
                "I'm assuming you've heard the legends that speak of the ninja, Statis? There are some who say that if you were able to defeat the gods which his clan once worshipped you would be able to harness some of his powers." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.57"),
                "Scattered across the lands are shrines dedicated to the gods. They contain powerful gear that may help you on your adventures." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.58"),
                "Be careful what you attack in the Crimson. You might just unveil a greater threat than what was there before." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.59"),
                "Be careful what you attack in the Corruption. You might just unveil a greater threat than what was there before." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.60"),
                "The Sulphurous Seas were created long ago, when Yharim's dungeon could no longer hold as many corpses as it needed to. Many of the bodies were dumped into the ocean. This, along with severe pollution from the heydays of Draedon's experiments have turned a paradise into a wasteland." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.61"),
                "The Sulphurous Seas are dangerous. The toxic waters will burn your skin, but if you can brave them you will be able to reach the Abyss, where there are powerful weapons and dangers aplenty." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.62"),
                "Ah yes, the Abyss. That trench is full of powerful creatures that could devour you in a heartbeat. I would explore the dungeon first." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.63"),
                "Have you heard of the Brimstone Crags? It was once a grand kingdom, not too different from my own. However, it also met a similar fate. I would not advise going down there, unless you seek a painful death." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.64"),
                "There are rumors of ores that lay in latency. When you defeat certain bosses you will undo the ancient magic which conceals those materials." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.65"),
                _ => npcPhrase
            };
            if (IsExistingNPC(PartyGirl) && npcPhrase == $"{Main.npc[PartyGirl].GivenName} asked if my nose could be used as a vuvuzela. What is a vuvuzela?")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.8"), Main.npc[PartyGirl].GivenName);
            }
            if (IsExistingNPC(Angler))
            {
                if (npcPhrase == $"Meet me at {Main.npc[Angler].GivenName}'s house at night. We will throw him to the Trashers.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.9"), Main.npc[Angler].GivenName);
                }
                else if (npcPhrase == $"Not sure how {Main.npc[Angler].GivenName} has not been roasted and digested by now, hanging around the sulphuric seas for so long. Perhaps it got to his head.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.10"), Main.npc[Angler].GivenName);
                }
            }
            if (IsExistingNPC(DrunkPrincess) && npcPhrase == $"Rumor has it {Main.npc[DrunkPrincess].GivenName} drinks to forget her troubled past.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.11"), Main.npc[DrunkPrincess].GivenName);
            }
            if (IsExistingNPC(Witch) && npcPhrase == "I must admit, the Witch's presence is unsettling to me. But so many years have passed, and she too has suffered much.")
            {
                npcPhrase = LangHelper.GetText("CalamityMod.NPCs.Dialogues.SeaKing.12");
            }
        }
        else if (TalkingNpc == Bandit)
        {
            npcPhrase = npcPhrase switch
            {
                "Oy, watch where you're going or I might just use you for dart practice." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.1"),
                "Bet you'd look good as a pincushion, amiright?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.2"),
                "Zombies don't dodge very well. Maybe you'll do a bit better." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.3"),
                "Hey, careful over there. I've rigged the place. One wrong step and you're going to get a knife in your forehead." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.4"),
                "Hm, the stars are too bright tonight. Makes sneaking around a little more difficult." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.5"),
                "You think those stars that fall occasionally would make good throwing weapons?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.6"),
                "Where is my party hat? Well, I stole it of course." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.7"),
                "The nice thing about maps is I can track anything that has fallen." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.8"),
                "Imagine how fast you could throw if you just had more hands." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.9"),
                "I also take food for currency." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.10"),
                "Usually I only think of animals as food or target practice, but dragons are an exception." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.11"),
                "Anything is a weapon if you throw it hard enough." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.12"),
                "That's your chucking arm? You need to work out more." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.13"),
                "Listen here. It's all in the wrist, the wrist! Oh, forget it." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.14"),
                "Eh you know how it goes; steal from the rich, give to the poor, but I do take a cut of the profit." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.15"),
                "Snakes! Why does it always have to be snakes!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.16"),
                "It's super nice you know, to just have everything you want. Some people never got that luxury." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.17"),
                "It's not stealing! I'm just borrowing it until I die!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.18"),
                "Wouldn't be the first time I used remains as weapons." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.19"),
                "All sorts of new weapons to be found and looted. Get to that, and I'll share some of my collection too!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.20"),
                "There's so much scrap around this land with valuable parts to them. Makes you wonder who could afford to leave em all around." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.21"),
                "Crypts, tombs, dungeons, those're all just treasure troves to me. The dead are dead, they've got nothing to do with it." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.22"),
                "If you find anything cool, make sure to drop by and show it to me, I promise I’ll keep my hands off it." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.23"),
                "So many new things to steal, I can’t think of where to start!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.24"),
                "If I end up angering some deities or whatever, would you mind taking the blame for me?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.25"),
                "Oh man, did you rip that off a shark!? Now that's a weapon!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.26"),
                "I'd rather not be here. This place has bad vibes, y'know? It brings back some unpleasant memories." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.27"),
                "Hey, if government officials can get tax, why can't I? The heck do you mean that these two things are nothing alike?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.33"),
                "Sorry, I got nothing. Perhaps you could reforge something and come back later..." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.34"),
                _ => npcPhrase
            };
            if (IsExistingNPC(Merchant) && npcPhrase == $"Don't tell {Main.npc[Merchant].GivenName}, but I took some of his stuff and replaced it with Angel Statues.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.28"), Main.npc[Merchant].GivenName);
            }
            if (IsExistingNPC(Witch) && npcPhrase == "Hey, hey, has Calamitas seriously moved in here with us? Why???")
            {
                npcPhrase = LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.29");
            }
            if (IsExistingNPC(DrunkPrincess) && npcPhrase == $"I learned never to steal {Main.npc[DrunkPrincess].GivenName}'s drinks. She doesn't appreciate me right now, so I'll go back to hiding.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.30"), Main.npc[DrunkPrincess].GivenName);
            }
            if (IsExistingNPC(ArmsDealer) && IsExistingNPC(Nurse) && npcPhrase == $"Don't tell {Main.npc[Nurse].GivenName} that I was responsible for {Main.npc[ArmsDealer].GivenName}'s injuries.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.31"), Main.npc[Nurse].GivenName, Main.npc[ArmsDealer].GivenName);
            }
            if (IsExistingNPC(GoblinTinkerer) && npcPhrase == $"Want in on a little secret? Since {Main.npc[GoblinTinkerer].GivenName} always gets so much cash from you, I've been stealing some of it as we go. I need you to keep quiet about it, so here.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bandit.32"), Main.npc[GoblinTinkerer].GivenName);
            }
        }
        else if (TalkingNpc == Witch)
        {
            npcPhrase = npcPhrase switch
            {
                "I'm considering moving back to that old cave of mine." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.1"),
                "I certainly can't return to the Tyrant's old dwellings now, have you got any places to stay?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.2"),
                "I can't pay rent, but if you've got any dead relative you want me to try and... what? You don't?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.3"),
                "One of these days, I was thinking of starting a garden with the flowers from the old capitol of hell. I love the smell of brimstone in the morning." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.4"),
                "I think I've settled comfortably, thank you very much." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.5"),
                "Many seasons have gone by since I first met with the Tyrant, and only now did I break free. I wish I'd been stronger..." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.6"),
                "If you've got any curses you want dispelled... well I'm not your person." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.6"),
                "Such an unnatural shade of red. Nothing like my brimstone flames." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.7"),
                "I can't work with nights like these. The stars seem to have shrunk away in fear." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.8"),
                "These undead are horrific, I can't stand to look at them. How could anyone be satisfied with such amateur work?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.9"),
                "I don't think it's a stretch to say that astrology is utter nonsense... but it was a hobby of mine once." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.10"),
                "If another person asks me if I can dance or not, I will light their hat on fire." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.11"),
                "Mrrp is cringe." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.15"),
                _ => npcPhrase
            };

            if (IsExistingNPC(SeaKing) && npcPhrase == "I cannot understand the Sea King. He does not seem to want me dead. That amount of compassion I just can't understand.")
            {
                npcPhrase = LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.12");
            }
            if (IsExistingNPC(Archmage) && npcPhrase == "That frosty old man... even if you ignore our brands of magic and our old alliances, I doubt I'd ever get along with him.")
            {
                npcPhrase = LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.13");
            }
            if (IsExistingNPC(DrunkPrincess) && npcPhrase == $"I wonder if {Main.npc[DrunkPrincess].GivenName} ever feels cold given how revealing her dress is. Perhaps she should cover up a bit more.")
            {
                npcPhrase = String.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.Witch.14"), Main.npc[DrunkPrincess].GivenName);
            }
        }
        else if (TalkingNpc == Merchant)
        {
            npcPhrase = npcPhrase switch
            {
                "Each night seems only more foreboding than the last. I feel unthinkable terrors are watching your every move." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Merchant.1"),
                "Are you daft?! Turn off those lamps!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Merchant.2"),
                "If this acid rain keeps up, there'll be a shortage of Dirt Blocks soon enough!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Merchant.3"),
                "I happen to have several Angel Statues at the moment, a truely rare commodity. Want one?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Merchant.4"),
                "The caverns have become increasingly dark as of late, so I stocked up on some special torches if you have the funds." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Merchant.5"),
                _ => npcPhrase
            };
        }
        else if (TalkingNpc == ArmsDealer)
        {
            npcPhrase = npcPhrase switch
            {
                "That's the biggest moth I've ever seen for sure. You'd need one big gun to take one of those down." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.ArmsDealer.1"),
                "Is it me or are your weapons getting bigger and bigger?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.ArmsDealer.2"),
                _ => npcPhrase
            };
        }
        else if (TalkingNpc == Dryad)
        {
            npcPhrase = npcPhrase switch
            {
                "There's a dark solar energy emanating from the moths that appear during this time. Ah, the moths as you progress further get more powerful... hmm... what power was Yharon holding back?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Dryad.1"),
                "That starborne illness sits upon this land like a blister. Do even more vile forces of corruption exist in worlds beyond?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Dryad.2"),
                "My ancestor was lost here long ago. I must pay my respects to her." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Dryad.4"),
                "\u0093I'm not here for any reason! Just picking up mushrooms for uh, later use." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Dryad.5"),
                _ => npcPhrase
            };
            if (IsExistingNPC(DrunkPrincess) && npcPhrase == $"{Main.npc[DrunkPrincess].GivenName} put me up to this.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.Dryad.3"), Main.npc[DrunkPrincess].GivenName);
            }
        }
        else if (TalkingNpc == Guide)
        {
            npcPhrase = npcPhrase switch
            {
                "Could you be so kind as to, ah... check hell for me...? I left someone I kind of care about down there." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Guide.1"),
                "I have this sudden shiver up my spine, like a meteor just fell and thousands of innocent creatures turned into monsters from the stars." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Guide.2"),
                "The dungeon seems even more restless than usual, watch out for the powerful abominations stirring up in there." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Guide.3"),
                "Seems like extinguishing that butterfly caused its life to seep into the hallowed areas, try taking a peek there and see what you can find!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Guide.4"),
                "I've heard there is a portal of antimatter absorbing everything it can see in the dungeon, try using the Rune of Kos there!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Guide.5"),
                _ => npcPhrase
            };
        }
        else if (TalkingNpc == Demolitionist)
        {
            if (npcPhrase == "God Slayer Dynamite? Boy do I like the sound of that!")
            {
                npcPhrase = LangHelper.GetText("CalamityMod.NPCs.Dialogues.Demolitionist.1");
            }
        }
        else if (TalkingNpc == Clothier)
        {
            npcPhrase = npcPhrase switch
            {
                "Who you gonna call?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Clothier.1"),
                "Those screams... I'm not sure why, but I feel like a nameless fear has awoken in my heart." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Clothier.2"),
                "I can faintly hear ghostly shrieks from the dungeon... and not ones I'm familiar with at all. Just what is going on in there?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Clothier.3"),
                "Whatever that thing was, I'm glad it's gone now." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Clothier.4"),
                "Houston, we've had a problem." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Clothier.5"),
                _ => npcPhrase
            };
        }
        else if (TalkingNpc == GoblinTinkerer)
        {
            npcPhrase = npcPhrase switch
            {
                "You know... we haven't had an invasion in a while..." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.GoblinTinkerer.2"),
                _ => npcPhrase
            };
            if (IsExistingNPC(Bandit) && npcPhrase == $"Hey, is it just me or have my pockets gotten lighter ever since {Main.npc[Bandit].GivenName} arrived?")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.GoblinTinkerer.1"), Main.npc[Bandit].GivenName);
            }
        }
        else if (TalkingNpc == Wizard)
        {
            npcPhrase = npcPhrase switch
            {
                "Space just got way too close for comfort." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Wizard.1"),
                _ => npcPhrase
            };
        }
        else if (TalkingNpc == Mechanic)
        {
            npcPhrase = npcPhrase switch
            {
                "What do you mean your traps aren't making the cut? Don't look at me!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Mechanic.1"),
                "Um... should my nightlight be on?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Mechanic.2"),
                "Maybe I should've waterproofed my gadgets... They're starting to corrode." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Mechanic.4"),
                _ => npcPhrase
            };
            if (IsExistingNPC(DrunkPrincess))
            {
                if (npcPhrase == $"Well, I like {Main.npc[DrunkPrincess].GivenName}, but I, ah... I have my eyes on someone else.")
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.Mechanic.3"), Main.npc[DrunkPrincess].GivenName);
            }
        }
        else if (TalkingNpc == Truffle)
        {
            npcPhrase = npcPhrase switch
            {
                "I don't feel very safe; I think there's pigs following me around and it frightens me." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Truffle.1"),
                _ => npcPhrase
            };
            if (IsExistingNPC(DrunkPrincess))
            {
                if (npcPhrase == $"Sometimes, {Main.npc[DrunkPrincess].GivenName} just looks at me funny and I'm not sure how I feel about that.")
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.Mechanic.2"), Main.npc[DrunkPrincess].GivenName);
            }
        }
        else if (TalkingNpc == Steampunk)
        {
            npcPhrase = npcPhrase switch
            {
                "Just what is that contraption? It makes my Teleporters look like child's play!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Steampunker.1"),
                "Yep! I'm also considering being a space pirate now." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Steampunker.2"),
                "Some of my machines are starting to go haywire thanks to this Astral Infection. I probably shouldn't have built them here" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Steampunker.3"),
                "I'm sorry I really don't have any Unicorn proof tech here, you're on your own." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Steampunker.4"),
                _ => npcPhrase
            };
        }
        else if (TalkingNpc == DyeTrader)
        {
            npcPhrase = npcPhrase switch
            {
                "Have you seen those gemstone creatures in the caverns? Their colors are simply breathtaking!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.DyeTrader.1"),
                _ => npcPhrase
            };
            if (IsExistingNPC(Archmage) && npcPhrase == $"Do you think {Main.npc[Archmage].GivenName} knows how to 'let it go?'")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.DyeTrader.2"), Main.npc[Archmage].GivenName);
            }
        }
        else if (TalkingNpc == PartyGirl)
        {
            npcPhrase = npcPhrase switch
            {
                "I think my light display is turning into an accidental bug zapper. At least the monsters are enjoying it." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.PartyGirl.2"),
                "Ooh! I love parties where everyone wears a scary costume!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.PartyGirl.3"),
                _ => npcPhrase
            };
            if (DrunkPrincess >= 0 && npcPhrase == $"I have a feeling we're going to have absolutely fantastic parties with {Main.npc[DrunkPrincess].GivenName} around!")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.PartyGirl.1"), Main.npc[DrunkPrincess].GivenName);
            }
        }
        else if (TalkingNpc == Cyborg)
        {
            npcPhrase = npcPhrase switch
            {
                "All these moments will be lost in time. Like tears... in the rain." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Cyborg.1"),
                "Always shoot for the moon! It has clearly worked before." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Cyborg.2"),
                "Draedon? He's... a little 'high octane' if you know what I mean." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Cyborg.3"),
                "Those oversized bugs terrorizing the jungle... Surely you of all people could shut them down!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Cyborg.4"),
                _ => npcPhrase
            };
        }
        else if (TalkingNpc == Painter)
        {
            npcPhrase = npcPhrase switch
            {
                "A little sickness isn't going to stop me from doing my work as an artist!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Painter.1"),
                "There's a surprising art to this area. A sort of horrifying, eldritch feeling. It inspires me!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Painter.2"),
                "I'm not exactly suited for this cold weather. Still looks pretty, though." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Painter.3"),
                "I hate sand. It's coarse, and rough and gets in my paint." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Painter.5"),
                "Do you think unicorn blood could be used as a good pigment or resin? No I'm not going to find out myself." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Painter.6"),
                "I can't work in this environment. All of my paint just floats off." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Painter.7"),
                "Painting the tortoises in a still life isn't going so well." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Painter.8"),
                "I can't paint a still life if the fruit grows legs and walks away." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Painter.9"),
                "On the canvas, things get heated around here all the time. Like the environment!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Painter.10"),
                "Sorry, I'm all out of watercolors. They keep evaporating." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Painter.11"),
                "Roses, really? That's such an overrated thing to paint." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Painter.12"),
                "Fun fact! Sulphur was used as pigment once upon a time! Or was it Cinnabar?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Painter.13"),
                "Easiest landscape I've ever painted in my life." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Painter.14"),
                _ => npcPhrase
            };
            if (Archmage >= 0 && npcPhrase == $"Think {Main.npc[Archmage].GivenName} would let me paint him like one of his French girls?!")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.Painter.4"), Main.npc[Archmage].GivenName);
            }
        }
        else if (TalkingNpc == WitchDoctor)
        {
            npcPhrase = npcPhrase switch
            {
                "My home here has an extensive history and a mysterious past. You'll find out quickly just how extensive it is..." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.WitchDoctor.1"),
                "I have unique items if you show me that you have bested the guardian of this jungle." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.WitchDoctor.2"),
                "This is as good a time as any to pick up the best ingredients for potions." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.WitchDoctor.3"),
                _ => npcPhrase
            };
        }
        else if (TalkingNpc == Pirate)
        {
            npcPhrase = npcPhrase switch
            {
                "Aye, I've heard of a mythical creature in the oceans, singing with an alluring voice. Careful when yer fishin out there." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Pirate.1"),
                "I have to thank ye again for takin' care of that sea serpent. Or was that another one..." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Pirate.2"),
                "Twenty-nine bottles of beer on the wall..." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Pirate.4"),
                "Now this is a scene that I can admire any time! I feel like something is watching me though." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Pirate.5"),
                "It ain't much of a sight, but there's still life living in these waters." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Pirate.6"),
                "Me ship might just sink from the acid alone." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Pirate.7"),
                _ => npcPhrase
            };
            if (IsExistingNPC(SeaKing) && npcPhrase == $"I remember legends about that {Main.npc[SeaKing].GivenName}. He ain't quite how the stories make him out to be though.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.Pirate.3"), Main.npc[SeaKing].GivenName);
            }
        }
        else if (TalkingNpc == Stylist)
        {
            npcPhrase = npcPhrase switch
            {
                "Please don't catch space lice. Or Crimson lice. Or just lice in general." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Stylist.1"),
                "Please don't catch space lice. Or Corruption lice. Or just lice in general." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Stylist.2"),
                "They look so cute and yet, I can feel their immense power just by being near them. What are you?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Stylist.5"),
                "I hate to break it to you, but you don't have hair to cut or style, hun." => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Stylist.6"),
                "Aww, they're so cute, do they have names?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Stylist.7"),
                _ => npcPhrase
            };
            if (IsExistingNPC(DrunkPrincess))
            {
                if (npcPhrase == $"Sometimes I catch {Main.npc[DrunkPrincess].GivenName} sneaking up from behind me.")
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.Stylist.3"), Main.npc[DrunkPrincess].GivenName);
                else if (npcPhrase == $"{Main.npc[DrunkPrincess].GivenName} is always trying to brighten my mood... even if, deep down, I know she's sad...")
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.Stylist.4"), Main.npc[DrunkPrincess].GivenName);
            }
        }
        else if (TalkingNpc == TravellingMerchant)
        {
            if (IsExistingNPC(DrunkPrincess) && IsExistingNPC(Merchant) && npcPhrase == $"Tell {Main.npc[DrunkPrincess].GivenName} I'll take up her offer and meet with her at the back of {Main.npc[Merchant].GivenName}'s house.")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.TravellingMerchant.1"), Main.npc[DrunkPrincess].GivenName, Main.npc[Merchant].GivenName);
            }
        }
        else if (TalkingNpc == Angler)
        {
            if (IsExistingNPC(SeaKing))
            {
                if (npcPhrase == $"Someone tell {Main.npc[SeaKing].GivenName} to quit trying to throw me out of town, it's not going to work.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.Angler.1"), Main.npc[SeaKing].GivenName);
                }
            }
        }
        else if (TalkingNpc == TaxCollector)
        {
            npcPhrase = npcPhrase switch
            {
                "BAH! Doesn't seem like I'll ever be able to quarrel with the debts of the town again!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.TaxCollector.1"),
                "Where and how are you getting all of this money?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.TaxCollector.2"),
                "Perhaps with all that time you've got you could check those old ruins? Certainly something of value in it for you!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.TaxCollector.3"),
                "Devourer of what, you said? Devourer of Funds, if its payroll is anything to go by!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.TaxCollector.4"),
                "Goodness! That cane has swagger!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.TaxCollector.5"),
                _ => npcPhrase
            };
        }
        else if (TalkingNpc == SkeletonMerchant)
        {
            npcPhrase = npcPhrase switch
            {
                "What'dya buyin'?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.SkeletonMerchant.1"),
                _ => npcPhrase
            };
        }
        else if (TalkingNpc == Bartender)
        {
            npcPhrase = npcPhrase switch
            {
                "Care for a little Moonshine?" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bartender.1"),
                _ => npcPhrase
            };
            if (IsExistingNPC(DrunkPrincess) && npcPhrase == $"Sheesh, {Main.npc[DrunkPrincess].GivenName} is a little cruel, isn't she? I never claimed to be an expert on anything but ale!")
            {
                npcPhrase = string.Format(LangHelper.GetText("CalamityMod.NPCs.Dialogues.Bartender.2"), Main.npc[DrunkPrincess].GivenName);
            }
        }
        else if (TalkingNpc == Nurse)
        {
            npcPhrase = npcPhrase switch
            {
                "Now is not the time!" => LangHelper.GetText("CalamityMod.NPCs.Dialogues.Nurse.1"),
                _ => npcPhrase
            };
        }

        Main.npcChatText = npcPhrase;
    }
}