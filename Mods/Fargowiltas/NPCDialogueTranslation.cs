using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;

namespace CalamityRuTranslate.Mods.Fargowiltas
{
    internal static class NPCDialogueTranslation
    {
        #region Properties
        private static int Abominationn => NPC.FindFirstNPC(ModsCall.Fargo.NPCType("Abominationn"));
        private static int Mutant => NPC.FindFirstNPC(ModsCall.Fargo.NPCType("Mutant"));
        private static int Deviantt => NPC.FindFirstNPC(ModsCall.Fargo.NPCType("Deviantt"));
        private static int LumberJack => NPC.FindFirstNPC(ModsCall.Fargo.NPCType("LumberJack"));
        private static int Squirrel => NPC.FindFirstNPC(ModsCall.Fargo.NPCType("Squirrel"));
        private static int Mechanic => NPC.FindFirstNPC(NPCID.Mechanic);
        private static int Angler => NPC.FindFirstNPC(NPCID.Angler);
        private static int Dryad => NPC.FindFirstNPC(NPCID.Dryad);
        private static int Nurse => NPC.FindFirstNPC(NPCID.Nurse);
        private static int PartyGirl => NPC.FindFirstNPC(NPCID.PartyGirl);
        private static int WitchDoctor => NPC.FindFirstNPC(NPCID.WitchDoctor);
        private static int Stylist => NPC.FindFirstNPC(NPCID.Stylist);
        private static int Truffle => NPC.FindFirstNPC(NPCID.Truffle);
        private static int TaxCollector => NPC.FindFirstNPC(NPCID.TaxCollector);
        private static int Guide => NPC.FindFirstNPC(NPCID.Guide);
        private static int Cyborg => NPC.FindFirstNPC(NPCID.Cyborg);
        private static int Demolitionist => NPC.FindFirstNPC(NPCID.Demolitionist);
        private static int DD2Bartender => NPC.FindFirstNPC(NPCID.DD2Bartender);
        private static int DyeTrader => NPC.FindFirstNPC(NPCID.DyeTrader);
        private static bool IsTalking => Main.LocalPlayer.talkNPC >= 0;
        private static int TalkingNpc => Main.player[Main.myPlayer].talkNPC;
        #endregion
        private static bool IsExistingNPC(this int npcType) => npcType >= 0;
        
        public static void SetupTranslation()
        {
            if (!IsTalking)
                return;
            
            string npcPhrase = Main.npcChatText;
            if (TalkingNpc == Abominationn)
            {
                switch (npcPhrase)
                {
                    case "Where'd I get my scythe from? Ask me later.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.1");
                        break;
                    case "Where'd I get my scythe from? You'll figure it out.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.2");
                        break;
                    case "I have defeated everything in this land... nothing can beat me.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.3");
                        break;
                    case "Have you ever had a weapon stuck to your hand? It's not very handy.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.4");
                        break;
                    case "What happened to Yoramur? No idea who you're talking about.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.5");
                        break;
                    case "You wish you could dress like me? Ha! Maybe in 2020.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.6");
                        break;
                    case "You ever read the ancient classics, I love all the fighting in them.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.7");
                        break;
                    case "I'm a world class poet, ever read my piece about impending doom?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.8");
                        break;
                    case "You want swarm summons? Maybe next year.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.9");
                        break;
                    case "Like my wings? Thanks, the thing I got them from didn't like it much.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.10");
                        break;
                    case "Heroism has no place in this world, instead let's just play ping pong.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.11");
                        break;
                    case "Why are you looking at me like that? Your fashion sense isn't going to be winning you any awards either.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.12");
                        break;
                    case "No, you can't have my hat.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.13");
                        break;
                    case "Embrace suffering... Wait what do you mean that's already taken?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.14");
                        break;
                    case "Your attempt to exploit my anger is admirable, but I cannot be angered.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.15");
                        break;
                    case "Is it really a crime if everyone else does it.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.16");
                        break;
                    case "Inflicting suffering upon others is the most amusing thing there is.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.17");
                        break;
                    case "Irony is the best kind of humor, isn't that ironic?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.18");
                        break;
                    case "I like Cat... What do you mean who's Cat?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.19");
                        break;
                    case "Check the wiki if you need anything, the kirb is slowly getting it up to par.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.20");
                        break;
                    case "I've heard tales of a legendary Diver... Anyway what was that about a giant jellyfish?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.21");
                        break;
                    case "Overloaded events...? Yeah, they're pretty cool.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.22");
                        break;
                    case "It's not like I don't enjoy your company, but can you buy something?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.23");
                        break;
                    case "I have slain one thousand humans! Huh? You're a human? There's so much blood on your hands..":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.24");
                        break;
                    case "I don't think there's an event right now.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.28");
                        break;
                }

                if (Mutant.IsExistingNPC() && npcPhrase == $"That one guy, {Main.npc[Mutant].GivenName}, he is my brother... I've fought more bosses than him.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.25"), Main.npc[Mutant].GivenName);
                }
                
                if (Deviantt.IsExistingNPC() && npcPhrase == $"That one girl, {Main.npc[Deviantt].GivenName}, she is my sister... I've defeated more events than her.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.26"), Main.npc[Deviantt].GivenName);
                }
                
                if (Mechanic.IsExistingNPC() && npcPhrase == $"Can you please ask {Main.npc[Mechanic].GivenName} to stop touching my laser arm please.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Abominationn.27"), Main.npc[Mechanic].GivenName);
                }
                
                if (npcPhrase.Contains("I'm not feeling it right now, come back in"))
                {
                    npcPhrase = npcPhrase.Replace("I'm not feeling it right now, come back in", "Не думаю, что смогу это сделать сейчас, возвращайся через").Replace("seconds.", "секунд");
                }
            }
            else if (TalkingNpc == Deviantt)
            {
                switch (npcPhrase)
                {
                    case "The blood moon's effects? I'm not human anymore, so nope!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.1");
                        break;
                    case "Did you know? The only real music genres are death metal and artcore.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.2");
                        break;
                    case "I'll have you know I'm over a hundred Fargo years old! Don't ask me how long a Fargo year is.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.3");
                        break;
                    case "I might be able to afford a taller body if you keep buying!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.4");
                        break;
                    case "Where's that screm cat?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.5");
                        break;
                    case "You're the Terrarian? Honestly, I was expecting someone a little... taller.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.6");
                        break;
                    case "Don't look at me like that! The only thing I've deviated from is my humanity.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.7");
                        break;
                    case "Rip and tear and buy from me for more things to rip and tear!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.8");
                        break;
                    case "What's a chee-bee doe-goe?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.9");
                        break;
                    case "Wait a second. Are you sure this house isn't what they call 'prison?'":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.10");
                        break;
                    case "Deviantt has awoken! Quick, give her all your money to defeat her!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.11");
                        break;
                    case "One day, I'll sell a summon for myself! ...Just kidding.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.12");
                        break;
                    case "Hmm, I can tell! You've killed a lot, but you haven't killed enough!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.13");
                        break;
                    case "Why the extra letter, you ask? Only the strongest sibling is allowed to remove their own!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.14");
                        break;
                    case "The more rare things you kill, the more stuff I sell! Simple, right?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.15");
                        break;
                    case "Embrace suffering... and while you're at it, embrace another purchase!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.16");
                        break;
                    case "This world looks tougher than usual, so you can have these on the house just this once! Talk to me if you need any tips, yeah?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.17");
                        break;
                    case "We all came from the end of time. This past world is a lot better than the timeless abyss of nothing!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.18");
                        break;
                    case "Lumberjack is 'the one who cuts.' That means trees, connections, and even severing alternate timelines.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.19");
                        break;
                    case "Who do you think we are? We're parts of you, a few hundred million years from now after you shed the need for a physical body.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.20");
                        break;
                    case "Mutant is inhabiting the physical shell of your future self, but we're all manifestations of your power and experience.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.21");
                        break;
                    case "In our first past, it took you eons to amass power. Since we happened to come back, we decided to help speed it up a little!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.22");
                        break;
                    case "Even if the three of us joined forces again, we still wouldn't regain the full power of our original self. You could probably still beat us!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.23");
                        break;
                    case "To accelerate your growth, Mutant released his powers to the rest of the world. Good work gathering it all back for yourself!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.24");
                        break;
                    case "Don't worry about our true names. We don't actually have any!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.25");
                        break;
                    case "No hard feelings about killing Abominationn, by the way. He comes back, right? Not that it won't miff Mutant if you do it again!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.26");
                        break;
                    case "We summon enemies and control events because we are them! Sort of. It's a long story.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.27");
                        break;
                    case "Take on a bigger form? I could do that, but I don't feel like it! Sorry!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.28");
                        break;
                    case "Why was Mutant in that big slime? It was the best way to power it up. Too bad he's too lazy to do that with the rest!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.29");
                        break;
                    case "Don't worry about the end of time, it's still billions of years away! I think. Dunno how this timey-wimey stuff works, really!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.30");
                        break;
                    case "There's no fighting Lumberjack at full power. He's already cut away every timeline in which you tried.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.31");
                        break;
                    case "Cthulhu? Hastur? All I know is where we came from, so your guess is as good as mine when it comes to them!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.32");
                        break;
                    case "I once heard Mutant mention a once cat-like being so far beyond us that its existence transcends cause and effect. It's more like a law of reality.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.33");
                        break;
                    case "What's that? You want to fight me for real? ...nah, I can't put up a good fight on my own.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.41");
                        break;
                    case "Hey, you've almost made it to the end! Got all your Soul accessories ready? What's that? You want to fight my big brother? ...maybe if he had a reason to.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.42");
                        break;
                    case "Ready to fight my big brother? Remember how you've learned to learn. Stay focused, look for patterns, and don't panic. Good luck!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.43");
                        break;
                    case "Only a specific type of weapon will work against each specific pillar. As for that moon guy, his weakness will keep changing.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.44");
                        break;
                    case "Some powerful enemies like that dungeon guy can create their own arenas. You won't be able to escape, so make full use of the room you do have.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.45");
                        break;
                    case "Did you beat that fish pig dragon yet? He reduces your maximum life a little on every hit. He's also strong enough to break defenses in one hit. Too bad you don't have any reinforced plating to prevent that, right?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.46");
                        break;
                    case "That golem? It gets upset when you leave the temple, so fighting in there is best. Platforms won't work, but a Lihzahrd Instactuation Bomb can help clear space!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.47");
                        break;
                    case "That overgrown plant inflicts a special venom that works her into an enraged frenzy if she stacks enough hits on you. She also has a ring of crystal leaves, but minions go through it.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.48");
                        break;
                    // case "Watch out when you break your fourth altar! It might attract the pirates, so be sure you're ready when you do it.":
                    //     npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.49");
                    //     break;
                    case "That metal worm has a few upgrades, but its probes were downgraded to compensate. It'll start shooting homing dark stars and flying. When it coils around you, don't try to escape!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.50");
                        break;
                    case "I saw that metal eye spinning while firing a huge laser the other day. Also, even if you kill them, they won't die until they're both killed!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.51");
                        break;
                    case "Focus on taking down that metal skull, not its limbs. Don't try to outrun its spinning limbs! Keep your eyes open and learn to recognize what's doing what.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.52");
                        break;
                    case "That thing's mouth is as good as immune to damage, so you'll have to aim for the eye. Only one of them is vulnerable at a time, though. What thing? You know, that thing!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.53");
                        break;
                    case "Next up is me! Make sure you can recognize whatever attack I'll throw at you. Blocks and turning away can nullify petrification!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.54");
                        break;
                    case "The master of the dungeon can use its babies to attack! Which attack it uses depends on whether or not it's spinning. It'll also take a last stand, so be ready to run when you make the kill!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.55");
                        break;
                    case "The queen bee will summon her progeny for backup. She's harder to hurt while they're there, so take them out first. Oh, and her swarm can't hit right above or below her!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.56");
                        break;
                    case "Focus on how the ichor moves and don't get overwhelmed! When the brain gets mad, it'll confuse you every few seconds. Four rings to confuse you, one ring when it wears off!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.57");
                        break;
                    case "The more the world eater splits, the more worms can rush you at once. The head is extra sturdy now, but don't let them pile up too much!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.58");
                        break;
                    case "Watch out when you break your second Crimson Heart! It might attract the goblins, so prepare before you do it.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.59");
                        break;
                    case "Watch out when you break your second Shadow Orb! It might attract the goblins, so prepare before you do it.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.60");
                        break;
                    case "That big eyeball has the power of the moon, but it's too flashy for its own good! Learn to notice and focus only on the bits that threaten to hurt you.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.61");
                        break;
                    case "Gonna fight that slime king soon? Don't spend too long up and out of his reach or he'll get mad. Very, very mad.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.62");
                        break;
                    case "Seems like everyone's learning to project auras these days. If you look at the particles, you can see whether it'll affect you at close range or a distance!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.63");
                        break;
                    case "There's probably a thousand items to protect against all these debuffs. It's a shame you don't have a thousand hands to carry them all at once!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.64");
                        break;
                    case "Don't forget you can turn off your soul toggles! They're all in that little wrench button right below your inventory. Those small buttons at the very bottom of the list include a recommended low-lag preset!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.65");
                        break;
                    case "Just so you know, ammos are less effective. Only a bit of their damage contributes to your total output!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.66");
                        break;
                    case "Found any Top Hat Squirrels yet? Keep one in your inventory and maybe a special friend will show up!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.67");
                        break;
                    case "I don't have any more Life Crystals for you, but I think my big brother left some in the fat slime king. Maybe he'll share if you beat it up!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.68");
                        break;
                    case "I've always wondered why those other monsters never bothered to carry any healing potions. Well, you probably shouldn't wait and see if they actually do.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.69");
                        break;
                    case "Watch out for those fish! Sharks will leave you alone if you leave them alone, but piranhas go wild when they smell blood. They can jump out of water to get you!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.70");
                        break;
                    case "The water is bogging you down? Never had an issue with it, personally... Have you tried breathing water instead of air?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.71");
                        break;
                    case "The underworld has gotten a lot hotter since the last time I visited. I hear an obsidian skull is a good luck charm against burning alive, though!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.72");
                        break;
                    case "Want to have a breath-holding contest? The empty vacuum of space would be perfect. No, I won't cheat by breathing water instead of air!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.73");
                        break;
                    // case "The spirits of light and dark stopped by and they sounded pretty upset with you. Don't be too surprised if something happens to you for entering their territory!":
                    //     npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.74");
                    //     break;
                    // case "Why not go hunting for some rare monsters every once in a while? Plenty of treasure to be looted and all that.":
                    //     npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.75");
                    //     break;
                    // case "Why're you so sad? Has the underground hallow been disorientating? Try turning that frown upside-down, I hear that gravity potions can help!":
                    //     npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.76");
                    //     break;
                    case "If you ask me, Plantera is really letting herself go. A diet of Chlorophyte Ore and Life Fruit isn't THAT healthy! Why don't you help her slim down?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.77");
                        break;
                    case "Trick or treat? Merry Christmas? I don't have anything for you, but go ask Pumpking or Ice Queen!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.78");
                        break;
                    case "Wanna craft Forces, but missing Enchantments? Craft the Sigil of Champions and they'll give you what you want, so long as you earn it.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.79");
                        break;
                    case "Now's a good time to go for Betsy! Don't worry. If you reach the last wave and lose, you won't have to retry the event for more attempts at her. Careful not to slip up before then, and mind her debuffs!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.80");
                        break;
                    case "That's a funny face you're making... Is the underground Hallow too disorienting? Try controlling gravity on your own and maybe it can't flip you by force!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.81");
                        break;
                }

                if (npcPhrase == $"{Main.LocalPlayer.name}! I saw something rodent-y just now! You don't have a hamster infestation, right? Right!?")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.34"), Main.LocalPlayer.name);
                }
                
                if (Mutant.IsExistingNPC())
                {
                    if (npcPhrase == $"Can you tell {Main.npc[Mutant].GivenName} to put some clothes on?")
                    {
                        npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.35"), Main.npc[Mutant].GivenName);
                    }
                    else if (npcPhrase == $"One day, I'll sell a summon for myself! ...Just kidding. That's {Main.npc[Mutant].GivenName}'s job.")
                    {
                        npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.36"), Main.npc[Mutant].GivenName);
                    }
                    else if (npcPhrase == $"{Main.npc[Mutant].GivenName} is here! That's my big brother!")
                    {
                        npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.37"), Main.npc[Mutant].GivenName);
                    }
                }

                if (Abominationn.IsExistingNPC() && npcPhrase == $"{Main.npc[Abominationn].GivenName} is here! That's my big-but-not-biggest brother!")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.38"), Main.npc[Abominationn].GivenName);
                }
                
                if (LumberJack.IsExistingNPC() && npcPhrase == $"What's that? You want to fight {Main.npc[LumberJack].GivenName}? ...even I know better than to try.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.39"), Main.npc[LumberJack].GivenName);
                }
                
                if (Angler.IsExistingNPC() && npcPhrase == $"Have you ever considered throwing {Main.npc[Angler].GivenName} back where you found him?")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Deviantt.40"), Main.npc[Angler].GivenName);
                }
            }
            else if (TalkingNpc == LumberJack)
            {
                switch (npcPhrase)
                {
                    case "Dynasty wood? Between you and me, that stuff ain't real wood!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.1");
                        break;
                    case "Sure cactus isn't wood, but I can still chop it with me trusty axe.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.2");
                        break;
                    case "You wouldn't by chance have any fantasies about me... right?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.3");
                        break;
                    case "I eat a bowl of woodchips for breakfast... without any milk.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.4");
                        break;
                    case "TIIIIIIIIIMMMBEEEEEEEERRR!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.5");
                        break;
                    case "I'm a lumberjack and I'm okay, I sleep all night and I work all day!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.6");
                        break;
                    case "You won't ever need an axe again with me around.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.7");
                        break;
                    case "I have heard of people cutting trees with fish, who does that?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.8");
                        break;
                    case "You wanna see me work without my shirt on? Maybe in 2030.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.9");
                        break;
                    case "You ever seen the world tree?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.10");
                        break;
                    case "You want what? ...Sorry that's not the kind of wood I'm selling.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.11");
                        break;
                    case "Why don't I sell acorns? ...I replant all the trees I chop, don't you?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.12");
                        break;
                    case "What's the best kind of tree? ... Any if I can chop it.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.13");
                        break;
                    case "Can I axe you a question?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.14");
                        break;
                    case "Might take a nap under a tree later, care to join me?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.15");
                        break;
                    case "I'm an expert in all wood types.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.16");
                        break;
                    case "I wonder if there'll be more trees to chop in 1.4.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.17");
                        break;
                    case "Red is one of my favourite colors, right after wood.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.18");
                        break;
                    case "It's always flannel season.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.19");
                        break;
                    case "I'm glad my wood put such a big smile on your face.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.20");
                        break;
                    case "Astroturf? Sorry I only grow trees on real grass.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.21");
                        break;
                    case "Yew tree? Sakura tree? Nope, haven't found any.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.22");
                        break;
                    case "While I was chopping down a cactus these things leaped at me, why don't you take care of them?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.23");
                        break;
                    case "These mahogany trees are full of life, but a tree only has one purpose: to be chopped. Oh yea this fell out of the last one.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.24");
                        break;
                    case "This place is a bit fanciful for my tastes, but the wood's as choppable as any. Nighttime has these cool bugs though, take a few.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.25");
                        break;
                    case "Whatever causes these to glow is beyond me, you're probably gonna eat them anyway so have this while you're at it.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.26");
                        break;
                    case "The trees here are probably the toughest in this branch of reality.. Sorry, just tree puns, I haven't found anything interesting here.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.27");
                        break;
                    case "Back in the day, people used to forge butterflies into powerful gear. We try to forget those days... but here have one.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.28");
                        break;
                    case "These little critters are always falling out of the trees I cut down. Maybe you can find a use for them?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.29");
                        break;
                    case "Chopping trees at night is always relaxing... well except for the flying eyeballs. Have one of these little guys to keep you company.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.30");
                        break;
                    case "I looked around here for a while and didn't find any trees. I did find this little thing though. Maybe you'll want it?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.31");
                        break;
                    case "I'm resting after a good day of chopping, come back tomorrow and maybe I'll have something else for you.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.32");
                        break;
                    case "This neck of the woods is pretty eh? Here I've got some of my favorite wood for you.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.35");
                        break;
                }

                if (Dryad.IsExistingNPC() && npcPhrase == $"{Main.npc[Dryad].GivenName} told me to start hugging trees... I hug trees with my chainsaw.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.33"), Main.npc[Dryad].GivenName);
                }
                
                if (Nurse.IsExistingNPC() && npcPhrase == $"I always see {Main.npc[Nurse].GivenName} looking at my biceps when I'm working. Wonder if she wants some of my wood.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.LumberJack.34"), Main.npc[Nurse].GivenName);
                }
            }
            else if (TalkingNpc == Mutant)
            {
                switch (npcPhrase)
                {
                    case "Savagery, barbarism, bloodthirst, that's what I like seeing in people.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.1");
                        break;
                    case "The stronger you get, the more stuff I sell. Makes sense, right?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.2");
                        break;
                    case "There's something all of you have that I don't... Death perception, I think it's called?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.3");
                        break;
                    case "It would be pretty cool if I sold a summon for myself...":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.4");
                        break;
                    case "The only way to get stronger is to keep buying from me and in bulk too!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.5");
                        break;
                    case "Why are you looking at me like that, all I did was eat an apple.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.6");
                        break;
                    case "Don't bother with anyone else, all you'll ever need is right here.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.7");
                        break;
                    case "You're lucky I'm on your side.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.8");
                        break;
                    case "Thanks for the house, I guess.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.9");
                        break;
                    case "Why yes I would love a ham and swiss sandwich.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.10");
                        break;
                    case "Should I start wearing clothes? ...Nah.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.11");
                        break;
                    case "It's not like I can actually use all the gold you're spending.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.12");
                        break;
                    case "Violence for violence is the law of the beast.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.13");
                        break;
                    case "Those guys really need to get more creative. All of their first bosses are desert themed!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.14");
                        break;
                    case "You say you want to know how a Mutant and Abominationn are brothers? You're better off not knowing.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.15");
                        break;
                    case "I'm all you need for a calamity.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.16");
                        break;
                    case "Everything shall bow before me! ...after you make this purchase.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.17");
                        break;
                    case "It's clear that I'm helping you out, but uh.. what's in this for me? A house you say? I eat zombies for breakfast.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.18");
                        break;
                    case "Can I jump? No, I don't have something called a 'spacebar'.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.19");
                        break;
                    case "Got your nose, I needed one to replace mine.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.20");
                        break;
                    case "What's a Terry?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.21");
                        break;
                    case "Why do so many creatures carry around a weird looking blue doll? The world may never know.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.22");
                        break;
                    case "Impending doom approaches. ...If you don't buy anything of course.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.23");
                        break;
                    case "I've heard of a '3rd dimension', I wonder what that looks like.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.24");
                        break;
                    case "Boy don't I look fabulous today.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.25");
                        break;
                    case "You have fewer friends than I do eyes.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.26");
                        break;
                    case "The ocean is a dangerous place, I wonder where Diver is?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.27");
                        break;
                    case "Do you know what an Ee-arth is?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.28");
                        break;
                    case "I can't even spell 'apotheosis', do you expect me to know what it is?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.29");
                        break;
                    case "Where do monsters get their gold from? ...I don't have pockets you know.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.30");
                        break;
                    case "Dogs are cool and all, but cats don't try to bite my brain.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.31");
                        break;
                    case "Beware the green dragon... What's that face mean?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.32");
                        break;
                    case "Where is this O-hi-o I keep hearing about.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.33");
                        break;
                    case "I've told you 56 times already, I'm busy... Oh wait you want to buy something, I suppose I have time.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.34");
                        break;
                    case "I've heard of a 'Soul of Souls' that only exists in 2015.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.35");
                        break;
                    case "Adding EX after everything makes it way more difficult.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.36");
                        break;
                    case "I think that all modern art looks great, especially the bloody stuff.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.37");
                        break;
                    case "How many guides does it take to change a lightbulb? ... I don't know, how about you ask him.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.38");
                        break;
                    case "Good thing I don't have a bed, I'd probably never leave it.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.39");
                        break;
                    case "What's this about an update? Sounds rare.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.40");
                        break;
                    case "If you need me I'll be slacking off somewhere.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.41");
                        break;
                    case "What do you mean who is Fargo!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.42");
                        break;
                    case "Have you seen the ech cat?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.43");
                        break;
                    case "I don't understand music nowadays, I prefer some smooth jazz... or the dying screams of monsters.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.44");
                        break;
                    case "Cthulhu's got nothing on me!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.45");
                        break;
                    case "Now that you've defeated the big guy, I'd say it's time to start collecting those materials!":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.46");
                        break;
                    case "What's that? You want to fight me? ...sure, I guess.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.47");
                        break;
                    case "What's that? You want to fight me? ...maybe if I had a reason.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.48");
                        break;
                    case "What's that? You want to fight me? ...you're not worthy you rat.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.49");
                        break;
                    case "Why would you do this.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.50");
                        break;
                    case "I feel a great imbalance in this world.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.51");
                        break;
                    case "A great choice, shame about that first desert boss thing though.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.52");
                        break;
                    case "A bit spooky tonight, isn't it.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.53");
                        break;
                    case "I'd ask for a coat, but I don't think you have any my size.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.54");
                        break;
                    case "Weather seems odd today, wouldn't you agree?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.55");
                        break;
                    case "Lovely night, isn't it?":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.56");
                        break;
                    case "I hope the constant arguing I'm hearing isn't my fault.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.57");
                        break;
                    case "I'd follow and help, but I'd much rather sit around right now.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.58");
                        break;
                    case "I don't know what everyone's so happy about, but as long as nobody mistakes me for a Pigronata, I'm happy too.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.59");
                        break;
                }
                
                if (PartyGirl.IsExistingNPC() && npcPhrase == $"{Main.npc[PartyGirl].GivenName} is the one who invited me, I don't understand why though.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.60"), Main.npc[PartyGirl].GivenName);
                }
                
                if (LumberJack.IsExistingNPC() && npcPhrase == $"It's okay {Main.npc[Mutant].GivenName}, just don't look straight into {Main.npc[LumberJack].GivenName}'s eyes. He can't scare you that way...")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.61"), Main.npc[Mutant].GivenName, Main.npc[LumberJack].GivenName);
                }
                
                if (Nurse.IsExistingNPC() && npcPhrase == $"Whenever we're alone, {Main.npc[Nurse].GivenName} keeps throwing syringes at me, no matter how many times I tell her to stop!")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.62"), Main.npc[Nurse].GivenName);
                }
                
                if (WitchDoctor.IsExistingNPC() && npcPhrase == $"Please go tell {Main.npc[WitchDoctor].GivenName} to drop the 'mystical' shtick, I mean, come on! I get it, you make tainted water or something.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.63"), Main.npc[WitchDoctor].GivenName);
                }
                
                if (Dryad.IsExistingNPC() && npcPhrase == $"Why does {Main.npc[Dryad].GivenName}'s outfit make my wings flutter?")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.64"), Main.npc[Dryad].GivenName);
                }
                
                if (Stylist.IsExistingNPC() && npcPhrase == $"{Main.npc[Stylist].GivenName} once gave me a wig... I look hideous with long hair.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.65"), Main.npc[Stylist].GivenName);
                }
                
                if (Truffle.IsExistingNPC() && npcPhrase == "That mutated mushroom seems like my type of fella.")
                {
                    npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.66");
                }
                
                if (TaxCollector.IsExistingNPC() && npcPhrase == $"{Main.npc[TaxCollector].GivenName} keeps asking me for money, but he won't accept my spawners!")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.67"), Main.npc[TaxCollector].GivenName);
                }
                
                if (Guide.IsExistingNPC() && npcPhrase == $"Any idea why {Main.npc[Guide].GivenName} is always cowering in fear when I get near him?")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.68"), Main.npc[Guide].GivenName);
                }
                
                if (Truffle.IsExistingNPC() && WitchDoctor.IsExistingNPC() && Cyborg.IsExistingNPC() && npcPhrase == $"If any of us could play instruments, I'd totally start a band with {Main.npc[WitchDoctor].GivenName}, {Main.npc[Truffle].GivenName}, and {Main.npc[Cyborg].GivenName}.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.69"), Main.npc[WitchDoctor].GivenName, Main.npc[Truffle].GivenName, Main.npc[Cyborg].GivenName);
                }
                
                if (PartyGirl.IsExistingNPC() && npcPhrase == $"Man, {Main.npc[PartyGirl].GivenName}'s confetti keeps getting stuck to my wings")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.70"), Main.npc[PartyGirl].GivenName);
                }
                
                if (Demolitionist.IsExistingNPC() && npcPhrase == $"I'm surprised {Main.npc[Demolitionist].GivenName} hasn't blown a hole in the floor yet, on second thought that sounds fun.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.71"), Main.npc[Demolitionist].GivenName);
                }
                
                if (DD2Bartender.IsExistingNPC() && npcPhrase == $"{Main.npc[DD2Bartender].GivenName} keeps suggesting I drink some beer, something tells me he wouldn't like me when I'm drunk though.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.72"), Main.npc[DD2Bartender].GivenName);
                }
                
                if (DyeTrader.IsExistingNPC() && npcPhrase == $"{Main.npc[DyeTrader].GivenName} wants to see what I would look like in blue... I don't know how to feel.")
                {
                    npcPhrase = string.Format(LangUtils.TranslationKey("Fargo.NpcChatText.Mutant.73"), Main.npc[DyeTrader].GivenName);
                }
            }
            else if (TalkingNpc == Squirrel)
            {
                switch (npcPhrase)
                {
                    case "You will suffer.":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Squirrel.1");
                        break;
                    case "*squeak*":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Squirrel.2");
                        break;
                    case "*chitter*":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Squirrel.3");
                        break;
                    case "*crunch crunch*":
                        npcPhrase = LangUtils.TranslationKey("Fargo.NpcChatText.Squirrel.4");
                        break;
                }
            }
            Main.npcChatText = npcPhrase;
        }
    }
}