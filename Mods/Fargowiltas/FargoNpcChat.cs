using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Fargowiltas;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas;

public class FargoNpcChat : ContentTranslation, INpcChatText
{
    public override bool IsTranslationEnabled => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;
    
    public override float Priority => 1f;
    
    #region Properties
    private int Abominationn => NPC.FindFirstNPC(ModsCall.Fargo.Find<ModNPC>("Abominationn").Type);
    private int Mutant => NPC.FindFirstNPC(ModsCall.Fargo.Find<ModNPC>("Mutant").Type);
    private int Deviantt => NPC.FindFirstNPC(ModsCall.Fargo.Find<ModNPC>("Deviantt").Type);
    private int LumberJack => NPC.FindFirstNPC(ModsCall.Fargo.Find<ModNPC>("LumberJack").Type);
    private int Squirrel => NPC.FindFirstNPC(ModsCall.Fargo.Find<ModNPC>("Squirrel").Type);
    private int Mechanic => NPC.FindFirstNPC(NPCID.Mechanic);
    private int Angler => NPC.FindFirstNPC(NPCID.Angler);
    private int Dryad => NPC.FindFirstNPC(NPCID.Dryad);
    private int Nurse => NPC.FindFirstNPC(NPCID.Nurse);
    private int PartyGirl => NPC.FindFirstNPC(NPCID.PartyGirl);
    private int WitchDoctor => NPC.FindFirstNPC(NPCID.WitchDoctor);
    private int Stylist => NPC.FindFirstNPC(NPCID.Stylist);
    private int Truffle => NPC.FindFirstNPC(NPCID.Truffle);
    private int TaxCollector => NPC.FindFirstNPC(NPCID.TaxCollector);
    private int Guide => NPC.FindFirstNPC(NPCID.Guide);
    private int Cyborg => NPC.FindFirstNPC(NPCID.Cyborg);
    private int Demolitionist => NPC.FindFirstNPC(NPCID.Demolitionist);
    private int DD2Bartender => NPC.FindFirstNPC(NPCID.DD2Bartender);
    private int DyeTrader => NPC.FindFirstNPC(NPCID.DyeTrader);
    private bool IsTalking => Main.LocalPlayer.talkNPC >= 0;
    private int TalkingNpc => Main.player[Main.myPlayer].talkNPC;
    #endregion
    private bool IsExistingNPC(int npcType) => npcType >= 0;

    private int AbomClearCD => (int)typeof(FargoWorld).GetField("AbomClearCD", BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(null)!;
    
    public void NpcChatTextTranslation()
    {
        if (!IsTalking)
            return;
            
        string npcPhrase = Main.npcChatText;

        if (TalkingNpc == Abominationn)
        {
            npcPhrase = npcPhrase switch
            {
                "Where'd I get my scythe from? Ask me later." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.1"),
                "Where'd I get my scythe from? You'll figure it out." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.2"),
                "I have defeated everything in this land... nothing can beat me." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.3"),
                "Have you ever had a weapon stuck to your hand? It's not very handy." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.4"),
                "What happened to Yoramur? No idea who you're talking about." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.5"),
                "You wish you could dress like me? Ha! Actually yea.. you can." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.6"),
                "You ever read the ancient classics, I love all the fighting in them." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.7"),
                "I'm a world class poet, ever read my piece about impending doom?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.8"),
                "You want swarm summons? Maybe next year." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.9"),
                "Like my wings? Thanks, the thing I got them from didn't like it much." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.10"),
                "Heroism has no place in this world, instead let's just play ping pong." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.11"),
                "Why are you looking at me like that? Your fashion sense isn't going to be winning you any awards either." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.12"),
                "No, you can't have my hat." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.13"),
                "Embrace suffering... Wait what do you mean that's already taken?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.14"),
                "Your attempt to exploit my anger is admirable, but I cannot be angered." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.15"),
                "Is it really a crime if everyone else does it." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.16"),
                "Inflicting suffering upon others is the most amusing thing there is." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.17"),
                "Irony is the best kind of humor, isn't that ironic?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.18"),
                "I like Cat... What do you mean who's Cat?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.19"),
                "Check the wiki if you need anything, the kirb is slowly getting it up to par." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.20"),
                "I've heard tales of a legendary Diver... Anyway what was that about a giant jellyfish?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.21"),
                "Overloaded events...? Yeah, they're pretty cool." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.22"),
                "It's not like I don't enjoy your company, but can you buy something?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.23"),
                "I have slain one thousand humans! Huh? You're a human? There's so much blood on your hands.." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.24"),
                "I don't think there's an event right now." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.28"),
                "You really defeated me... not bad. Now do it again without getting hit. Oh, and Copper Shortsword only." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.29"),
                "I hope all these graves lying around don't belong to you." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.30"),
                "Hocus pocus, the event is over" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.31"),
                "What nostalgic armor you're wearing... No, it doesn't fit on me anymore. And its battery takes too long to charge." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.32"),
                _ => npcPhrase
            };

            if (IsExistingNPC(Mutant) && npcPhrase == $"That one guy, {Main.npc[Mutant].GivenName}, he is my brother... I've fought more bosses than him.")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.25"), Main.npc[Mutant].GivenName);
            }

            if (IsExistingNPC(Deviantt) && npcPhrase == $"That one girl, {Main.npc[Deviantt].GivenName}, she is my sister... I've defeated more events than her.")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.26"), Main.npc[Deviantt].GivenName);
            }

            if (IsExistingNPC(Mechanic) && npcPhrase == $"Can you please ask {Main.npc[Mechanic].GivenName} to stop touching my laser arm please.")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Abominationn.27"), Main.npc[Mechanic].GivenName);
            }
        }
        else if (TalkingNpc == Deviantt)
        {
            npcPhrase = npcPhrase switch
            {
                "The blood moon's effects? I'm not human anymore, so nope!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.1"),
                "Did you know? The only real music genres are death metal and artcore." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.2"),
                "I'll have you know I'm over a hundred Fargo years old! Don't ask me how long a Fargo year is." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.3"),
                "I might be able to afford a taller body if you keep buying!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.4"),
                "Where's that screm cat?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.5"),
                "You're the Terrarian? Honestly, I was expecting someone a little... taller." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.6"),
                "Don't look at me like that! The only thing I've deviated from is my humanity." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.7"),
                "Rip and tear and buy from me for more things to rip and tear!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.8"),
                "What's a chee-bee doe-goe?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.9"),
                "Wait a second. Are you sure this house isn't what they call 'prison?'" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.10"),
                "Deviantt has awoken! Quick, give her all your money to defeat her!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.11"),
                "One day, I'll sell a summon for myself! ...Just kidding." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.12"),
                "Hmm, I can tell! You've killed a lot, but you haven't killed enough!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.13"),
                "Why the extra letter, you ask? Only the strongest sibling is allowed to remove their own!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.14"),
                "The more rare things you kill, the more stuff I sell! Simple, right?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.15"),
                "Embrace suffering... and while you're at it, embrace another purchase!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.16"),
                "This world looks tougher than usual, so you can have these on the house just this once! Talk to me if you need any tips, yeah?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.17"),
                "We all came from the end of time. This past world is a lot better than the timeless abyss of nothing!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.18"),
                "Lumberjack is 'the one who cuts.' That means trees, connections, and even severing alternate timelines." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.19"),
                "Who do you think we are? We're parts of you, a few hundred million years from now after you shed the need for a physical body." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.20"),
                "Mutant is inhabiting the physical shell of your future self, but we're all manifestations of your power and experience." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.21"),
                "In our first past, it took you eons to amass power. Since we happened to come back, we decided to help speed it up a little!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.22"),
                "Even if the three of us joined forces again, we still wouldn't regain the full power of our original self. You could probably still beat us!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.23"),
                "To accelerate your growth, Mutant released his powers to the rest of the world. Good work gathering it all back for yourself!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.24"),
                "Don't worry about our true names. We don't actually have any!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.25"),
                "No hard feelings about killing Abominationn, by the way. He comes back, right? Not that it won't miff Mutant if you do it again!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.26"),
                "We summon enemies and control events because we are them! Sort of. It's a long story." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.27"),
                "Take on a bigger form? I could do that, but I don't feel like it! Sorry!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.28"),
                "Why was Mutant in that big slime? It was the best way to power it up. Too bad he's too lazy to do that with the rest!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.29"),
                "Don't worry about the end of time, it's still billions of years away! I think. Dunno how this timey-wimey stuff works, really!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.30"),
                "There's no fighting Lumberjack at full power. He's already cut away every timeline in which you tried." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.31"),
                "Cthulhu? Hastur? All I know is where we came from, so your guess is as good as mine when it comes to them!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.32"),
                "I once heard Mutant mention a once cat-like being so far beyond us that its existence transcends cause and effect. It's more like a law of reality."
                   => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.33"),
                "What's that? You want to fight me for real? ...nah, I can't put up a good fight on my own." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.41"),
                "Hey, you've almost made it to the end! Got all your Soul accessories ready? What's that? You want to fight my big brother? ...maybe if he had a reason to." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.42"),
                "Ready to fight my big brother? Remember how you've learned to learn. Stay focused, look for patterns, and don't panic. Good luck!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.43"),
                "Only a specific type of weapon will work against each specific pillar. As for that moon guy, his weakness will keep changing." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.44"),
                "Some powerful enemies like that dungeon guy can create their own arenas. You won't be able to escape, so make full use of the room you do have." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.45"),
                "Did you beat that fish pig dragon yet? He reduces your maximum life a little on every hit. He's also strong enough to break defenses in one hit. Too bad you don't have any reinforced plating to prevent that, right?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.46"),
                "That temple? Reach the altar to regain wire control! The golem gets upset when you leave, so fighting in there is best. Platforms won't work, but a Lihzahrd Instactuation Bomb can help clear space!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.47"),
                "That overgrown plant inflicts a special venom that works her into an enraged frenzy if she stacks enough hits on you. She also has a ring of crystal leaves, but minions go through it." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.48"),
                "Good work getting one over on me! Hope I didn't make you sweat too much. Keep at the grind - I wanna see how far you can go!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.49"),
                "That metal worm has a few upgrades, but its probes were downgraded to compensate. It'll start shooting homing dark stars and flying. When it coils around you, don't try to escape!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.50"),
                "I saw that metal eye spinning while firing a huge laser the other day. Also, even if you kill them, they won't die until they're both killed!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.51"),
                "Focus on taking down that metal skull, not its limbs. Don't try to outrun its spinning limbs! Keep your eyes open and learn to recognize what's doing what." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.52"),
                "That thing's mouth is as good as immune to damage, so you'll have to aim for the eye. Only one of them is vulnerable at a time, though. What thing? You know, that thing!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.53"),
                "Next up is me! Make sure you can recognize whatever attack I'll throw at you. Blocks and turning away can nullify petrification!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.54"),
                "The master of the dungeon can use its babies to attack! Which attack it uses depends on whether or not it's spinning. It'll also take a last stand, so be ready to run when you make the kill!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.55"),
                "The queen bee will summon her progeny for backup. She's harder to hurt while they're there, so take them out first. Oh, and her swarm can't hit right above or below her!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.56"),
                "Focus on how the ichor moves and don't get overwhelmed! When the brain gets mad, it'll confuse you every few seconds. Four rings to confuse you, one ring when it wears off!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.57"),
                "The more the world eater splits, the more worms can rush you at once. The head is extra sturdy now, but don't let them pile up too much!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.58"),
                "Watch out when you break your second Crimson Heart! It might attract the goblins, so prepare before you do it." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.59"),
                "Watch out when you break your second Shadow Orb! It might attract the goblins, so prepare before you do it." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.60"),
                "That big eyeball has the power of the moon, but it's too flashy for its own good! Learn to notice and focus only on the bits that threaten to hurt you." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.61"),
                "Gonna fight that slime king soon? Crafting a Mini Instabridge or two might help, and mind the spike rain. Don't stay up and out of his range or he'll get mad, though!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.62"),
                "Seems like everyone's learning to project auras these days. If you look at the particles, you can see whether it'll affect you at close range or a distance!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.63"),
                "There's probably a thousand items to protect against all these debuffs. It's a shame you don't have a thousand hands to carry them all at once!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.64"),
                "Don't forget you can turn off your soul toggles! They're all in that little wrench button right below your inventory. Those small buttons at the very bottom of the list include a recommended low-lag preset!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.65"),
                // "Just so you know, ammos are less effective. Only a bit of their damage contributes to your total output!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.66"),
                // "Found any Top Hat Squirrels yet? Keep one in your inventory and maybe a special friend will show up!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.67"),
                "I don't have any more Life Crystals for you, but I think my big brother left some in the fat slime king. Maybe he'll share if you beat it up!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.68"),
                "I've always wondered why those other monsters never bothered to carry any healing potions. Well, you probably shouldn't wait and see if they actually do." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.69"),
                "Watch out for those fish! Sharks will leave you alone if you leave them alone, but piranhas go wild when they smell blood. They can jump out of water to get you!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.70"),
                "The water is bogging you down? Never had an issue with it, personally... Have you tried breathing water instead of air?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.71"),
                "The underworld has gotten a lot hotter since the last time I visited. I hear an obsidian skull is a good luck charm against burning alive, though!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.72"),
                "Want to have a breath-holding contest? The empty vacuum of space would be perfect. No, I won't cheat by breathing water instead of air!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.73"),
                "UWAH! Please don't hurt... wait, it's just you. Don't scare me like that! And why is that THING following you?!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.74"),
                "Why not go hunting for some rare monsters every once in a while? Plenty of treasure to be looted and all that." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.75"),
                // case "Why're you so sad? Has the underground hallow been disorientating? Try turning that frown upside-down, I hear that gravity potions can help!":
                //     npcPhrase = LangUtils.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.76");
                //     break;
                "If you ask me, Plantera is really letting herself go. A diet of Chlorophyte Ore and Life Fruit isn't THAT healthy! Why don't you help her slim down?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.77"),
                "Trick or treat? Merry Christmas? I don't have anything for you, but go ask Pumpking or Ice Queen!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.78"),
                "Wanna craft Forces, but missing Enchantments? Craft the Sigil of Champions and they'll give you what you want, so long as you earn it." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.79"),
                "Now's a good time to go for Betsy! Don't worry. If you reach the last wave and lose, you won't have to retry the event for more attempts at her. Careful not to slip up before then, and mind her debuffs!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.80"),
                "That's a funny face you're making... Is the underground Hallow too disorienting? Try controlling gravity on your own and maybe it can't flip you by force!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.81"),
                _ => npcPhrase
            };

            if (npcPhrase == $"{Main.LocalPlayer.name}! I saw something rodent-y just now! You don't have a hamster infestation, right? Right!?")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.34"), Main.LocalPlayer.name);
            }

            if (IsExistingNPC(Mutant))
            {
                if (npcPhrase == $"Can you tell {Main.npc[Mutant].GivenName} to put some clothes on?")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.35"), Main.npc[Mutant].GivenName);
                }
                else if (npcPhrase == $"One day, I'll sell a summon for myself! ...Just kidding. That's {Main.npc[Mutant].GivenName}'s job.")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.36"), Main.npc[Mutant].GivenName);
                }
                else if (npcPhrase == $"{Main.npc[Mutant].GivenName} is here! That's my big brother!")
                {
                    npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.37"), Main.npc[Mutant].GivenName);
                }
            }

            if (IsExistingNPC(Abominationn) && npcPhrase == $"{Main.npc[Abominationn].GivenName} is here! That's my big-but-not-biggest brother!")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.38"), Main.npc[Abominationn].GivenName);
            }

            if (IsExistingNPC(LumberJack) && npcPhrase == $"What's that? You want to fight {Main.npc[LumberJack].GivenName}? ...even I know better than to try.")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.39"), Main.npc[LumberJack].GivenName);
            }

            if (IsExistingNPC(Angler) && npcPhrase == $"Have you ever considered throwing {Main.npc[Angler].GivenName} back where you found him?")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Deviantt.40"), Main.npc[Angler].GivenName);
            }
        }
        else if (TalkingNpc == LumberJack)
        {
            npcPhrase = npcPhrase switch
            {
                "Dynasty wood? Between you and me, that stuff ain't real wood!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.1"),
                "Sure cactus isn't wood, but I can still chop it with me trusty axe." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.2"),
                "You wouldn't by chance have any fantasies about me... right?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.3"),
                "I eat a bowl of woodchips for breakfast... without any milk." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.4"),
                "TIIIIIIIIIMMMBEEEEEEEERRR!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.5"),
                "I'm a lumberjack and I'm okay, I sleep all night and I work all day!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.6"),
                "You won't ever need an axe again with me around." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.7"),
                "I have heard of people cutting trees with fish, who does that?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.8"),
                "You wanna see me work without my shirt on? Maybe in 2030." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.9"),
                "You ever seen the world tree?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.10"),
                "You want what? ...Sorry that's not the kind of wood I'm selling." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.11"),
                "Why don't I sell acorns? ...I replant all the trees I chop, don't you?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.12"),
                "What's the best kind of tree? ... Any if I can chop it." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.13"),
                "Can I axe you a question?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.14"),
                "Might take a nap under a tree later, care to join me?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.15"),
                "I'm an expert in all wood types." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.16"),
                "I'm glad there's more trees to chop here at journey's end." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.17"),
                "Red is one of my favourite colors, right after wood." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.18"),
                "It's always flannel season." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.19"),
                "I'm glad my wood put such a big smile on your face." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.20"),
                "Astroturf? Sorry I only grow trees on real grass." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.21"),
                "Yew tree? Sakura tree? Nope, haven't found any." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.22"),
                "While I was chopping down a cactus these things leaped at me, why don't you take care of them?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.23"),
                "These mahogany trees are full of life, but a tree only has one purpose: to be chopped. Oh yea these fell out of the last one." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.24"),
                "This place is a bit fanciful for my tastes, but the wood's as choppable as any. Nighttime has these cool bugs though, take a few." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.25"),
                "Whatever causes these to glow is beyond me, you're probably gonna eat them anyway so have this while you're at it." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.26"),
                "The trees here are probably the toughest in this branch of reality.. Sorry, just tree puns. I found these for you here." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.27"),
                "Back in the day, people used to forge butterflies into powerful gear. We try to forget those days... but here have one." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.28"),
                "These little critters are always falling out of the trees I cut down. Maybe you can find a use for them?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.29"),
                "Chopping trees at night is always relaxing... well except for the flying eyeballs. Have one of these little guys to keep you company." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.30"),
                "I looked around here for a while and didn't find any trees. I did find this little thing though. Maybe you'll want it?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.31"),
                "I'm resting after a good day of chopping, come back tomorrow and maybe I'll have something else for you." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.32"),
                "This neck of the woods is pretty eh? Here I've got some of my favorite wood for you." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.35"),
                "Lucy from that universe.. Interesting things await you." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.36"),
                "Even on vacation, I always fit in a little chopping. A couple annoying birds fell out of a palm tree. Take them off my hands.. maybe cook them up?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.37"),
                "I looked around here for a while and didn't find any trees. I did find these little guys though. Maybe you'll want them?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.38"),
                "I certainly didn't expect to find such wonderful trees down here. Check this out." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.39"),
                _ => npcPhrase
            };

            if (IsExistingNPC(Dryad) && npcPhrase == $"{Main.npc[Dryad].GivenName} told me to start hugging trees... I hug trees with my chainsaw.")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.33"), Main.npc[Dryad].GivenName);
            }

            if (IsExistingNPC(Nurse) && npcPhrase == $"I always see {Main.npc[Nurse].GivenName} looking at my biceps when I'm working. Wonder if she wants some of my wood.")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.LumberJack.34"), Main.npc[Nurse].GivenName);
            }
        }
        else if (TalkingNpc == Mutant)
        {
            npcPhrase = npcPhrase switch
            {
                "Savagery, barbarism, bloodthirst, that's what I like seeing in people." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.1"),
                "The stronger you get, the more stuff I sell. Makes sense, right?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.2"),
                "There's something all of you have that I don't... Death perception, I think it's called?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.3"),
                "It would be pretty cool if I sold a summon for myself..." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.4"),
                "The only way to get stronger is to keep buying from me and in bulk too!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.5"),
                "Why are you looking at me like that, all I did was eat an apple." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.6"),
                "Don't bother with anyone else, all you'll ever need is right here." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.7"),
                "You're lucky I'm on your side." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.8"),
                "Thanks for the house, I guess." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.9"),
                "Why yes I would love a ham and swiss sandwich." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.10"),
                "Should I start wearing clothes? ...Nah." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.11"),
                "It's not like I can actually use all the gold you're spending." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.12"),
                "Violence for violence is the law of the beast." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.13"),
                "Those guys really need to get more creative. All of their first bosses are desert themed!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.14"),
                "You say you want to know how a Mutant and Abominationn are brothers? You're better off not knowing." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.15"),
                "I'm all you need for a calamity." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.16"),
                "Everything shall bow before me! ...after you make this purchase." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.17"),
                "It's clear that I'm helping you out, but uh.. what's in this for me? A house you say? I eat zombies for breakfast." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.18"),
                "Can I jump? No, I don't have something called a 'spacebar'." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.19"),
                "Got your nose, I needed one to replace mine." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.20"),
                "What's a Terry?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.21"),
                "Why do so many creatures carry around a weird looking blue doll? The world may never know." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.22"),
                "Impending doom approaches. ...If you don't buy anything of course." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.23"),
                "I've heard of a '3rd dimension', I wonder what that looks like." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.24"),
                "Boy don't I look fabulous today." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.25"),
                "You have fewer friends than I do eyes." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.26"),
                "The ocean is a dangerous place, I wonder where Diver is?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.27"),
                "Do you know what an Ee-arth is?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.28"),
                "I can't even spell 'apotheosis', do you expect me to know what it is?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.29"),
                "Where do monsters get their gold from? ...I don't have pockets you know." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.30"),
                "Dogs are cool and all, but cats don't try to bite my brain." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.31"),
                "Beware the green dragon... What's that face mean?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.32"),
                "Where is this O-hi-o I keep hearing about." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.33"),
                "I've told you 56 times already, I'm busy... Oh wait you want to buy something, I suppose I have time." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.34"),
                "I've heard of a 'Soul of Souls' that only exists in 2015." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.35"),
                "Adding EX after everything makes it way more difficult." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.36"),
                "I think that all modern art looks great, especially the bloody stuff." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.37"),
                "How many guides does it take to change a lightbulb? ... I don't know, how about you ask him." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.38"),
                "Good thing I don't have a bed, I'd probably never leave it." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.39"),
                "What's this about an update? Sounds rare." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.40"),
                "If you need me I'll be slacking off somewhere." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.41"),
                "What do you mean who is Fargo!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.42"),
                "Have you seen the ech cat?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.43"),
                "I don't understand music nowadays, I prefer some smooth jazz... or the dying screams of monsters." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.44"),
                "Cthulhu's got nothing on me!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.45"),
                "Now that you've defeated the big guy, I'd say it's time to start collecting those materials!" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.46"),
                "What's that? You want to fight me? ...sure, I guess." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.47"),
                "What's that? You want to fight me? ...maybe if I had a reason." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.48"),
                "What's that? You want to fight me? ...you're not worthy you rat." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.49"),
                "Why would you do this." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.50"),
                "I feel a great imbalance in this world." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.51"),
                "A great choice, shame about that first desert boss thing though." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.52"),
                "A bit spooky tonight, isn't it." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.53"),
                "I'd ask for a coat, but I don't think you have any my size." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.54"),
                "Weather seems odd today, wouldn't you agree?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.55"),
                "Lovely night, isn't it?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.56"),
                "I hope the constant arguing I'm hearing isn't my fault." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.57"),
                "I'd follow and help, but I'd much rather sit around right now." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.58"),
                "I don't know what everyone's so happy about, but as long as nobody mistakes me for a Pigronata, I'm happy too." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.59"),
                "Congratulations. You truly embraced eternity... at least, I think you did? So what happens next? Ascend from this plane of existence? Fight a transcendant cat-like entity? Destroy the world? All the power's in your hands now." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.74"),
                "Good work beating me, I guess. I still feel like stretching my wings... Why don't we go at it for real next time?" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.75"),
                "I heard of a rumor of infinite use boss summons. Makes me sick.." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.76"),
                "Nice armor you have, very realistic skin. As a matter of fact, mind if I borrow it? Your skin, that is." => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.77"),
                _ => npcPhrase
            };

            if (IsExistingNPC(PartyGirl) && npcPhrase == $"{Main.npc[PartyGirl].GivenName} is the one who invited me, I don't understand why though.")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.60"), Main.npc[PartyGirl].GivenName);
            }

            if (IsExistingNPC(LumberJack) && npcPhrase == $"It's okay {Main.npc[Mutant].GivenName}, just don't look straight into {Main.npc[LumberJack].GivenName}'s eyes. He can't scare you that way...")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.61"), Main.npc[Mutant].GivenName, Main.npc[LumberJack].GivenName);
            }

            if (IsExistingNPC(Nurse) && npcPhrase == $"Whenever we're alone, {Main.npc[Nurse].GivenName} keeps throwing syringes at me, no matter how many times I tell her to stop!")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.62"), Main.npc[Nurse].GivenName);
            }

            if (IsExistingNPC(WitchDoctor) && npcPhrase == $"Please go tell {Main.npc[WitchDoctor].GivenName} to drop the 'mystical' shtick, I mean, come on! I get it, you make tainted water or something.")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.63"), Main.npc[WitchDoctor].GivenName);
            }

            if (IsExistingNPC(Dryad) && npcPhrase == $"Why does {Main.npc[Dryad].GivenName}'s outfit make my wings flutter?")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.64"), Main.npc[Dryad].GivenName);
            }

            if (IsExistingNPC(Stylist) && npcPhrase == $"{Main.npc[Stylist].GivenName} once gave me a wig... I look hideous with long hair.")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.65"), Main.npc[Stylist].GivenName);
            }

            if (IsExistingNPC(Truffle) && npcPhrase == "That mutated mushroom seems like my type of fella.")
            {
                npcPhrase = LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.66");
            }

            if (IsExistingNPC(TaxCollector) && npcPhrase == $"{Main.npc[TaxCollector].GivenName} keeps asking me for money, but he won't accept my spawners!")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.67"), Main.npc[TaxCollector].GivenName);
            }

            if (IsExistingNPC(Guide) && npcPhrase == $"Any idea why {Main.npc[Guide].GivenName} is always cowering in fear when I get near him?")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.68"), Main.npc[Guide].GivenName);
            }

            if (IsExistingNPC(Truffle) && IsExistingNPC(WitchDoctor) && IsExistingNPC(Cyborg) && npcPhrase == $"If any of us could play instruments, I'd totally start a band with {Main.npc[WitchDoctor].GivenName}, {Main.npc[Truffle].GivenName}, and {Main.npc[Cyborg].GivenName}.")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.69"), Main.npc[WitchDoctor].GivenName, Main.npc[Truffle].GivenName, Main.npc[Cyborg].GivenName);
            }

            if (IsExistingNPC(PartyGirl) && npcPhrase == $"Man, {Main.npc[PartyGirl].GivenName}'s confetti keeps getting stuck to my wings")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.70"), Main.npc[PartyGirl].GivenName);
            }

            if (IsExistingNPC(Demolitionist) && npcPhrase == $"I'm surprised {Main.npc[Demolitionist].GivenName} hasn't blown a hole in the floor yet, on second thought that sounds fun.")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.71"), Main.npc[Demolitionist].GivenName);
            }

            if (IsExistingNPC(DD2Bartender) && npcPhrase == $"{Main.npc[DD2Bartender].GivenName} keeps suggesting I drink some beer, something tells me he wouldn't like me when I'm drunk though.")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.72"), Main.npc[DD2Bartender].GivenName);
            }

            if (IsExistingNPC(DyeTrader) && npcPhrase == $"{Main.npc[DyeTrader].GivenName} wants to see what I would look like in blue... I don't know how to feel.")
            {
                npcPhrase = string.Format(LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Mutant.73"), Main.npc[DyeTrader].GivenName);
            }
        }
        else if (TalkingNpc == Squirrel)
        {
            npcPhrase = npcPhrase switch
            {
                "[c/FF0000:You will suffer.]" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Squirrel.1"),
                "*squeak*" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Squirrel.2"),
                "*chitter*" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Squirrel.3"),
                "*crunch crunch*" => LangHelper.GetText("Fargowiltas.NPCs.Dialogues.Squirrel.4"),
                _ => npcPhrase
            };
        }

        Main.npcChatText = npcPhrase;
    }
}