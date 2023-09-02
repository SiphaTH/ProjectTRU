// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using Terraria;
// using Terraria.ModLoader;
// using ThoriumMod.NPCs;
//
// namespace CalamityRuTranslate.Mods.ThoriumMod;
//
// public class ThoriumNpcChat : GlobalNPC
// {
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModsCall.Thorium != null && TranslationHelper.IsRussianLanguage;
//     }
//
//     public override void GetChat(NPC npc, ref string chat)
//     {
//         string GetNPCName(int type) => Main.npc[NPC.FindFirstNPC(type)].GivenName;
//
//         if (npc.type == ModContent.NPCType<Blacksmith>())
//         {
//             chat = chat switch
//             {
//                 "Don't forget to wipe your blade if you're planning on going out there! I don't care how magical it is, those freaks' blood will rust any metal!" => "",
//                 "You know all those special weapons you find scattered about the land? I've always wondered just how they were forged in the first place. I'm an old man now, but I've still got a long journey to mastery ahead of me..." => "",
//                 "Every blade's got its place in the world: a signature weapon for a hero, a beloved knife for a chef, or maybe just some gaudy piece of junk hanging from a wall." => "",
//                 "Hey brat, corral some people into helping me out at the forge. Blacksmithing ain't a single-man task, and you'll just end up with second-rate junk if you try going solo!" => "",
//                 "'course I followed you here, brat. I crash-coursed you on how to forge and smith weapons for yourself before you arrived here, I'll be damned if I don't get to sit back and watch the ensuing fireworks." => "",
//                 "Welcome! I'm busy workin' on a commission weapon, if you touch anything, consider it sold!" => "",
//                 _ => chat
//             };
//
//             if (NPC.AnyNPCs(38))
//             {
//                 if (chat == $"Me and {GetNPCName(38)} have a little routine going: he delivers me metal to smith, and I give him a heart attack by smoking near his explosives on purpose.")
//                 {
//                     chat = "";
//                 }
//             }
//             
//             if (NPC.AnyNPCs(208))
//             {
//                 if (chat == $"I just witnessed {GetNPCName(208)} make a knife out of chocolate that's better than half of my own blades...")
//                 {
//                     chat = "";
//                 }
//             }
//             
//             if (NPC.AnyNPCs(17))
//             {
//                 if (chat == $"What does that conman {GetNPCName(17)} think he's doing trying to offer his cheap trash he calls 'weapons'? If you want the real deal, you've come to the right place!")
//                 {
//                     chat = "";
//                 }
//             }
//             
//             if (NPC.AnyNPCs(ModContent.NPCType<Tracker>()))
//             {
//                 if (chat == $"That brute {GetNPCName(ModContent.NPCType<Tracker>())} is more Barbarian than Tracker! Do you have any idea how many times the oaf asked me to fix that battleaxe of his?!")
//                 {
//                     chat = "";
//                 }
//             }
//         }
//
//         if (npc.type == ModContent.NPCType<Cobbler>())
//         {
//             chat = chat switch
//             {
//                 "In my younger years, I myself was a hero. But after a bad fall, I've since retired. Perhaps if I had better boots back then I would still be a hero today..." => "",
//                 "Worry not young man. While the journey may be tough, I have full confidence in your ability!" => "",
//                 "Worry not young lady. While the journey may be tough, I have full confidence in your ability!" => "",
//                 "You can learn a lot by walking a mile in someone else's boots. If only some of these townsfolk would walk a mile in yours, then they could understand..." => "",
//                 _ => chat
//             };
//             
//             if (chat == $"Having proper footwear is no joke, {Main.LocalPlayer.name}. Always make sure your shoes are polished and ready for adventure!")
//             {
//                 chat = "";
//             }
//             
//             if (chat == $"How are you doing, {Main.LocalPlayer.name}? Are you staying safe out there in the wilds?")
//             {
//                 chat = "";
//             }
//             
//             if (NPC.AnyNPCs(208))
//             {
//                 if (chat == $"Can you believe that {GetNPCName(208)} wanted to throw me a birthday party? I haven't had one in so long!")
//                 {
//                     chat = "";
//                 }
//             }
//             
//             if (NPC.AnyNPCs(108))
//             {
//                 if (chat == $"Oh my... I think {GetNPCName(108)} might be even older than I am!")
//                 {
//                     chat = "";
//                 }
//             }
//             
//             if (NPC.AnyNPCs(22))
//             {
//                 if (chat == $"Ah, so {GetNPCName(22)} has been giving you advice this whole time? It's always nice to see a young man appreciate his studies.")
//                 {
//                     chat = "";
//                 }
//             }
//         }
//
//         if (npc.type == ModContent.NPCType<ConfusedZombie>())
//         {
//             chat = chat switch
//             {
//                 "I can't remember much about my past life... Chemicals and the like were my passion I think; I only get fragments and pieces of the truth. It's saddening at times..." => "",
//                 "Why am I not like the others...? Oh, I'm sorry, did you need something?" => "",
//                 "Most people don't have the stomach to handle the things I sell. The trick is to not have a stomach at all!" => "",
//                 "I gotta thank you for letting me stick around. Only coming out at night is pretty boring..." => "",
//                 _ => chat
//             };
//             
//             if (NPC.AnyNPCs(22))
//             {
//                 if (chat == $"I bet {GetNPCName(22)} has a big juicy brain... not that I would wanna... uh... did you need something?")
//                 {
//                     chat = "";
//                 }
//             }
//             
//             if (NPC.AnyNPCs(208))
//             {
//                 if (chat == $"{GetNPCName(208)}'s brain would surely taste like candy... Oh uh, hello there!")
//                 {
//                     chat = "";
//                 }
//             }
//         }
//
//         if (npc.type == ModContent.NPCType<Cook>())
//         {
//             chat = chat switch
//             {
//                 "I've got a lot of orders from the other townsfolk right now, make it quick!" => "",
//                 "How did any of you survive before I arrived? What could you have possibly been eating, dirt?" => "",
//                 "I'm stuck with dull knives while you wield weapons of unimaginable power? Give me a break..." => "",
//                 "No one should go adventuring on an empty stomach. Eat well, hero!" => "",
//                 "Supply me with the proper ingredients, and I can make some truly powerful foods for you, hero!" => "",
//                 _ => chat
//             };
//             
//             if (NPC.AnyNPCs(369))
//             {
//                 if (chat == $"{GetNPCName(369)} can be a real brat at times, but as long as he keeps providing me with fresh fish, I won't complain.")
//                 {
//                     chat = "";
//                 }
//             }
//             
//             if (NPC.AnyNPCs(20))
//             {
//                 if (chat == $"Cooking for {GetNPCName(20)} is no easy task. She simply refuses to eat any form of meat!")
//                 {
//                     chat = "";
//                 }
//             }
//             
//             if (NPC.AnyNPCs(228))
//             {
//                 if (chat == $"The last time {GetNPCName(228)} asked me to cook for him, he requested bugs! This truly is a strange place...")
//                 {
//                     chat = "";
//                 }
//             }
//         }
//
//         if (npc.type == ModContent.NPCType<DesertAcolyte>())
//         {
//             chat = chat switch
//             {
//                 "We certainly have some strange people around this town, don't we...?" => "",
//                 "You didn't see any giant bird shadows while you were out in the desert, did you?" => "",
//                 "I had originally stopped just to refill my canteen, but you seem like someone who can deal with a real threat!" => "",
//                 "Have you ever heard tale of the Thunder Birds? Legend says they had long protected our world from cataclysmic threats, before a disagreement between them and three individuals led to their disappearance..." => "",
//                 "If you're interested in the secrets of my people, be sure to purchase a 'Blank Technique Scroll'. They offer great power to those that utilize them well..." => "",
//                 "I have seen so much evil in my travels... I only hope someone can put a stop to them!" => "",
//                 _ => chat
//             };
//             
//             if (NPC.AnyNPCs(207))
//             {
//                 if (chat == $"{GetNPCName(207)} was interested in dyeing my attire, but his choice of plant dye was 'strange' to say the least.")
//                 {
//                     chat = "";
//                 }
//             }
//             
//             if (NPC.AnyNPCs(19))
//             {
//                 if (chat == $"Look at {GetNPCName(19)} over there! He's got an entire arsenal of guns, is that really safe?")
//                 {
//                     chat = "";
//                 }
//             }
//         }
//         
//         if (npc.type == ModContent.NPCType<Diverman>())
//         {
//             chat = chat switch
//             {
//                 "Visiting that sea rift again wasn't my best idea... that mutant jellyfish almost ate me whole!" => "",
//                 "Yuck... that vile creature almost got away with eating me! Thank you for saving me, hero." => "",
//                 "Have you adventured into the aquatic depths yet...? Its choking atmosphere prevents most explorers from entering, but I'm confident you'll find a way around it..." => "",
//                 "I've collected many marine items in my travels, hero. Would you like to purchase one?" => "",
//                 "Being at the bottom of the ocean for long periods of time has taught me one thing; Always come prepared!" => "",
//                 "You would think it gets hard to breath under this helmet, but really I'm just used to it now." => "",
//                 "You ever try to drink a bottle of water, while drowning, to save yourself? I know I have!" => "",
//                 _ => chat
//             };
//         }
//         
//         if (npc.type == ModContent.NPCType<Druid>())
//         {
//             chat = chat switch
//             {
//                 "Why don't you go fetch those seeds yourself you lazy, good for nothing-" => "",
//                 "I bet you don't even feel guilty about destroying the natural world to better suit your needs..." => "",
//                 "Getting these seeds is a bigger hassle than you would think. Nearly drowning, almost melting, freezing to- You get the idea." => "",
//                 "I often take visits to the jungle. I can understand the aversion to the place, but the creatures within don't seem to hassle me..." => "",
//                 "My mother was a well known herbalist back in the day. She doesn't talk about my father, though. I wonder why?" => "",
//                 "The natural world is quite a wonder. Every little place has its own charm. Some more than others!" => "",
//                 _ => chat
//             };
//             
//             if (NPC.AnyNPCs(228))
//             {
//                 if (chat == $"Our friend there, {GetNPCName(228)}, is rather strange isn't he? He speaks in riddles...")
//                 {
//                     chat = "";
//                 }
//             }
//             
//             if (NPC.AnyNPCs(ModContent.NPCType<Cook>()))
//             {
//                 if (chat == $"I wonder if I can convince {GetNPCName(ModContent.NPCType<Cook>())} to whip me up a salad.")
//                 {
//                     chat = "";
//                 }
//             }
//             
//             if (chat == $"How does today find you, {Main.LocalPlayer.name}? Make sure to stop and smell the roses!")
//             {
//                 chat = "";
//             }
//             
//             if (chat == $"Even a small seed can grow into a mighty oak! Keep that in mind, {Main.LocalPlayer.name}...")
//             {
//                 chat = "";
//             }
//         }
//
//         if (npc.type == ModContent.NPCType<PeculiarMirror>())
//         {
//             chat = chat switch
//             {
//                 "Before you sits a rather strange mirror. Something seems to be calling out from it...?" => "",
//                 _ => chat
//             };
//         }
//         
//         if (npc.type == ModContent.NPCType<Spiritualist>())
//         {
//             chat = chat switch
//             {
//                 "Is- Is that my cross? How in the world did you manage to find it? It's been lost for so long..." => "",
//                 "Beware my friend... true evil walks among us this night." => "",
//                 "Ah, it's been a while friend. It is good to see you are well after so long!" => "",
//                 "Whether in body, mind, or spirit, always consider how you may grow today, my friend." => "",
//                 "Energy, chi, spirit... it's all the same to me. There is power in all things." => "",
//                 "I have no doubt of your physical power, hero. But sometimes hardship is fought in a battle of will, not strength." => "",
//                 _ => chat
//             };
//             
//             if (NPC.AnyNPCs(369))
//             {
//                 if (chat == $"{GetNPCName(369)} often comes to me in private to discuss things that are bothering him. Such a young age to be in his position...")
//                 {
//                     chat = "";
//                 }
//             }
//         }
//         
//         if (npc.type == ModContent.NPCType<Tracker>())
//         {
//             chat = chat switch
//             {
//                 "Seen any interesting beasts lurking around lately? Minotaurs? Beholders? Gorgons?" => "",
//                 "Bear your scars with pride, as each one has a tale to tell... What do your scars say about you, hero?" => "",
//                 "Many beasts have fallen to me and my axe, but new ones are always on the prowl. Keep your eyes peeled, kid." => "",
//                 "You'd be surprised how effective a single shoulder pad can be." => "",
//                 _ => chat
//             };
//             
//             if (NPC.AnyNPCs(353))
//             {
//                 if (chat == $"Do you think {GetNPCName(353)} would give a haircut even to a brute like me...?")
//                 {
//                     chat = "";
//                 }
//             }
//             
//             if (NPC.AnyNPCs(550) && NPC.AnyNPCs(ModContent.NPCType<WeaponMaster>()))
//             {
//                 if (chat == $"{GetNPCName(550)}, {GetNPCName(ModContent.NPCType<WeaponMaster>())}, and I were gonna start a gym together. You want in?")
//                 {
//                     chat = "";
//                 }
//             }
//         }
//         
//         if (npc.type == ModContent.NPCType<WeaponMaster>())
//         {
//             chat = chat switch
//             {
//                 "Long ago, when this world was first taking form, my race reigned supreme. That time has passed it seems..." => "",
//                 "I'm not one for idle chatter. If you have need of me, make it quick." => "",
//                 "My race's obsession with voodoo dolls has only become rampant just recently. It's truly a fad gone wrong..." => "",
//                 "Should you have the coin, I would be willing to accompany you in your endeavors..." => "",
//                 "A warrior without his weapon stands no chance against the ever-powering threats he must face..." => "",
//                 _ => chat
//             };
//             
//             if (chat == $"{GetNPCName(ModContent.NPCType<WeaponMaster>())} blankly stares through you, as though he's not entirely there...")
//             {
//                 chat = "";
//             }
//             
//             if (chat == $"*So... you've gained the ability to speak in tongues, {Main.LocalPlayer.name}? Very fascinating...*")
//             {
//                 chat = "";
//             }
//             
//             if (chat == $"Ie... oep'wl vmnjld hrl mfnbnho he iwlmc nj hejvpli, {Main.LocalPlayer.name}? Wlgo zmisnjmhnjv...")
//             {
//                 chat = "";
//             }
//             
//             if (NPC.AnyNPCs(22))
//             {
//                 if (chat == $"{GetNPCName(22)} keeps giving me dirty looks... It's not like I carry a doll myself.")
//                 {
//                     chat = "";
//                 }
//             }
//         }
//     }
//
//     public override void OnChatButtonClicked(NPC npc, bool firstButton)
//     {
//         string GetNPCName(int type) => Main.npc[NPC.FindFirstNPC(type)].GivenName;
//         if (npc.type == ModContent.NPCType<Cobbler>())
//         {
//             if (Main.npcChatText == $"There we go, {Main.LocalPlayer.name}, good as new. It won't last long, but maybe you'll notice some more spring in your step. Make sure to stay safe out there, hero!")
//             {
//                 Main.npcChatText = "";
//             }
//         }
//
//         if (npc.type == ModContent.NPCType<ConfusedZombie>())
//         {
//             Main.npcChatText = Main.npcChatText switch
//             {
//                 "I just whipped up the perfect recipe to deter bats from bothering you; no more tiny nibbles!" => "",
//                 "If this turned out correctly, you'll smell just like a zombie. Hopefully your nights will be a tad more calm!" => "",
//                 "Getting this stuff to work underwater was a huge hassle... Either way, hungry fish shouldn't attempt to eat you with this." => "",
//                 "I'll be honest, this is just a bottle of pure liquid calcium. Don't question it, the skeletons surely won't." => "",
//                 "With this nasty concoction, insects will associate your scent with their queen! Neat, huh?" => "",
//                 "Looks like you're a bit short on funds. Come back to me when you have a little more coin in your pocket!" => "",
//                 "I'm afraid you'll have to give me some more time to prepare the next repellent. This stuff can get pretty complicated..." => "",
//                 _ => Main.npcChatText
//             };
//         }
//         
//         if (npc.type == ModContent.NPCType<Cook>())
//         {
//             Main.npcChatText = Main.npcChatText switch
//             {
//                 "This crisp morel was just asking to be put in a dish. I hope it's to your liking!" => "",
//                 "Pink pears can be problematic if prepared improperly. Good thing I'm a professional pear pickler!" => "",
//                 "Well uh... I DID cook it, though I'm not entirely sure you should eat this stuff." => "",
//                 "With just the right amount of green, this dish gets real mean. Be careful eating it!" => "",
//                 "I had to visit a far away land to learn how to make this dish. Hopefully you'll appreciate it!" => "",
//                 "When I was younger, my mother would always greet me with some mint tea after a long, hard day... I miss the simpler times." => "",
//                 "Yunno, it's not just called a 'Sky Blue Flower' because of its color. Some say they've fallen from the sky islands themselves long ago." => "",
//                 "Last time I took a bite of this stuff, I started thinking everything was out to get me... but hey, maybe that's what you're looking for?" => "",
//                 "Ah, just what I need to help ripen this cheese! Hopefully this'll offer a little more 'pizazz' to its taste." => "",
//                 "I'm honored that you'd trust me with such rare commodities. Hopefully this new recipe suits your fancy!" => "",
//                 "I myself don't know much about the Hallow, it's a rather strange place... but berries are berries, right?" => "",
//                 "So the legends are true... The kitchen scholars thought this recipe was lost to time, but it's right in front of me. I can barely contain my excitement to try it out!" => "",
//                 "I can tell this was written by an ogre... still, the pictures give me a clear idea on how to brew this. Be careful with this stuff, it's highly potent!" => "",
//                 "Leaves? You want me to cook some food... with leaves? Well, I don't think these would really work in a salad, so how about some tea instead? I'm sure it will calm you down if you're stressed." => "",
//                 "These were exactly what I was missing for my special hot chocolate recipe! If you're planning on going somewhere a little chilly, these will warm you right up for sure." => "",
//                 "Looks like you don't have any ingredients in your bag. If you can find enough of an ingredient I'm looking for, I can supply you with new purchasable foods. Some of these dishes will be far more powerful than my usual wares, so keep your eyes peeled for unique ingredients!" => "",
//                 _ => Main.npcChatText
//             };
//             
//             if (Main.npcChatText == $"Lovely, just enough blueberries for the job! Thanks, and please enjoy, {Main.LocalPlayer.name}!")
//             {
//                 Main.npcChatText = "";
//             }
//         }
//
//         if (npc.type == ModContent.NPCType<DesertAcolyte>())
//         {
//             Main.npcChatText = Main.npcChatText switch
//             {
//                 "Although I'm only an acolyte, one of the first things we learn is how to create a sandstorm. Beware the creatures that lurk within however..." => "",
//                 "Creating a sandstorm is a very taxing job. I would prefer to have some compensation in the form of money, please." => "",
//                 _ => Main.npcChatText
//             };
//         }
//         
//         if (npc.type == ModContent.NPCType<Diverman>())
//         {
//             Main.npcChatText = Main.npcChatText switch
//             {
//                 "Here you go friend! This air tank will automatically activate when your breath reaches critical level. Come visit me afterwards and I'll refill it free of charge!" => "",
//                 "Hmm, your air tank looks full to me... Did you just want to chat? I have all manner of tales to tell!" => "",
//                 _ => Main.npcChatText
//             };
//         }
//         
//         if (npc.type == ModContent.NPCType<Spiritualist>())
//         {
//             Main.npcChatText = Main.npcChatText switch
//             {
//                 "I'm afraid I can't currently protect you, friend. Give your soul some time to heal, and then come speak to me again." => "",
//                 "With these shards, I have imbued you with an incredibly potent shield. Should you take fatal damage, you shall receive my protection for as long as I can hold it. Stay safe out there, my friend." => "",
//                 "I require no money to watch over you my friend, but my protection is limited without some Purified Shards. Once you acquire 5, come visit me again." => "",
//                 "No need to fear my friend, my power is already protecting you. Come back when my power has faded." => "",
//                 _ => Main.npcChatText
//             };
//         }
//         
//         if (npc.type == ModContent.NPCType<WeaponMaster>())
//         {
//             Main.npcChatText = Main.npcChatText switch
//             {
//                 "I see you're lacking in coin. Remedy that and I may just help you out..." => "",
//                 _ => Main.npcChatText
//             };
//             
//             if (Main.npcChatText == $"{GetNPCName(ModContent.NPCType<WeaponMaster>())} blankly stares through you, as though he's not entirely there...")
//             {
//                 Main.npcChatText = "";
//             }
//         }
//     }
// }