// using System.Collections.Generic;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.RuntimeDetour.HookGen;
// using StarsAbove;
// using StarsAbove.Items.Consumables;
// using StarsAbove.Items.Materials;
// using StarsAbove.Items.Prisms;
// using StarsAbove.NPCs;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;
//
// [JITWhenModsEnabled("StarsAbove")]
// public class StarsAbovePatch : ILEdit
// {
//     private MethodInfo _postSetupContent => typeof(StarsAbove.StarsAbove).GetCachedMethod(nameof(StarsAbove.StarsAbove.PostSetupContent));
//
//     private delegate void orig_PostSetupContent(StarsAbove.StarsAbove self);
//     private delegate void hook_PostSetupContent(orig_PostSetupContent orig, StarsAbove.StarsAbove self);
//
//     private event hook_PostSetupContent PostSetupContent
//     {
//         add => HookEndpointManager.Add<hook_PostSetupContent>(_postSetupContent, value);
//         remove => HookEndpointManager.Remove<hook_PostSetupContent>(_postSetupContent, value);
//     }
//
//     private bool DownedWarrior => DownedBossSystem.downedWarrior;
//     private bool DownedVagrant => DownedBossSystem.downedVagrant;
//     private bool DownedNalhaun => DownedBossSystem.downedNalhaun;
//     private bool DownedPenth => DownedBossSystem.downedPenth;
//     private bool DownedArbiter => DownedBossSystem.downedArbiter;
//     private bool DownedTsuki => DownedBossSystem.downedTsuki;
//
//     public override bool Autoload() => ModsCall.StarsAbove != null && ModsCall.BossChecklist != null && TranslationHelper.IsRussianLanguage;
//
//     public override void Load()
//     {
//         PostSetupContent += OnPostSetupContent;
//     }
//
//     public override void Unload()
//     {
//         PostSetupContent -= OnPostSetupContent;
//     }
//     
//     private void OnPostSetupContent(orig_PostSetupContent orig, StarsAbove.StarsAbove self)
//     {
//         ModsCall.BossChecklist.Call(
//             "AddBoss",
//             ModsCall.StarsAbove,
//             "Воин Света",
//             ModContent.NPCType<WarriorOfLight>(),
//             18.5f,
//             () => DownedWarrior,
//             () => true,
//             new List<int>
//             {
//                 ModContent.ItemType<PrismOfTheRuinedKing>(),
//                 ModContent.ItemType<PrismOfTheCosmicPhoenix>(),
//                 ModContent.ItemType<DullTotemOfLight>(),
//                 ModContent.ItemType<TotemOfLightEmpowered>()
//             },
//             ModContent.ItemType<ProgenitorWish>(),
//             "Dispel the unending Light through defeating this foe, summoned with your Starfarer's help from the Moon Lord's corpse. (The Vagrant of Space and Time must have been defeated.)",
//             "The Flood of Light has consumed all..."
//         );
//
//         ModsCall.BossChecklist.Call(
//             "AddBoss",
//             ModsCall.StarsAbove,
//             "The Vagrant of Space and Time",
//             ModContent.NPCType<VagrantOfSpaceAndTime>(),
//             7.1f,
//             () => DownedVagrant,
//             () => true,
//             new List<int>
//             {
//                 ModContent.ItemType<EnigmaticDust>(),
//                 ModContent.ItemType<SpatialPrism>()
//             },
//             ModContent.ItemType<ShatteredDisk>(),
//             "Defeat this strange foe through the Shattered Disk, obtained from the Wall of Flesh. This fight will be critical to progression later!",
//             "Space and time return to normal..."
//         );
//             
//         ModsCall.BossChecklist.Call(
//             "AddBoss",
//             ModsCall.StarsAbove,
//             "Nalhaun, the Burnished King",
//             ModContent.NPCType<Nalhaun>(),
//             11.5f,
//             () => DownedNalhaun,
//             () => true,
//             new List<int> { ModContent.ItemType<BurnishedPrism>() },
//             ModContent.ItemType<AncientShard>(),
//             "Confront this aged monarch with the Ancient Shard, given to you by your Starfarer after any Mechanical Boss is defeated. (The Vagrant of Space and Time must have been defeated.)",
//             "The king's crimson blade rings true yet again..."
//         );
//         
//         ModsCall.BossChecklist.Call(
//             "AddBoss",
//             ModsCall.StarsAbove,
//             "Penthesilea, the Witch of Ink",
//             ModContent.NPCType<Penthesilea>(),
//             12.5f,
//             () => DownedPenth,
//             () => true,
//             new List<int> { ModContent.ItemType<PaintedPrism>() },
//             ModContent.ItemType<UnsulliedCanvas>(),
//             "Face this fearsome foe with the Unsullied Canvas, given to you by your Starfarer after Plantera is bested. (The Vagrant of Space and Time must have been defeated.)",
//             "You have been splattered away..."
//         );
//
//         ModsCall.BossChecklist.Call(
//             "AddBoss",
//             ModsCall.StarsAbove,
//             "Arbitration",
//             ModContent.NPCType<Arbitration>(),
//             15.5f,
//             () => DownedArbiter,
//             () => true,
//             new List<int> {ModContent.ItemType<VoidsentPrism>()},
//             ModContent.ItemType<DemonicCrux>(),
//             "This foe embodies true fear... Obtain the Crux from your Starfarer after Golem is defeated. (The Vagrant of Space and Time must have been defeated.)",
//             "Chaos and order intertwined hath consumed you whole."
//         );
//             
//         ModsCall.BossChecklist.Call(
//             "AddBoss",
//             ModsCall.StarsAbove,
//             "Tsukiyomi, the First Starfarer",
//             ModContent.NPCType<Tsukiyomi2>(),
//             18.9f,
//             () => DownedTsuki,
//             () => DownedWarrior,
//             new List<int> { ModContent.ItemType<SpatialMemoriam>() },
//             ModContent.ItemType<MnemonicSigil>(),
//             "The time has finally come. Craft all the Mnemonic Traces together to create the Mnemonic Sigil, and use it within the Observatory Hyperborea to be taken to Tsukiyomi's boss arena.",
//             "..."
//         );
//     }
// }