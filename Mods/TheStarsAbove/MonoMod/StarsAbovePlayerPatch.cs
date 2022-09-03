// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using StarsAbove;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;
//
// [JITWhenModsEnabled("StarsAbove")]
// public class StarsAbovePlayerOnEnterWorld : Patch<ILContext.Manipulator>
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(StarsAbovePlayer).GetCachedMethod(nameof(StarsAbovePlayer.OnEnterWorld));
//
//     protected override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, " has been binded to ", " был связан с миром: ");
//         TranslationHelper.ModifyIL(il, "The Stars Above progression will only occur on this world. (Check Mod Settings if necessary)", "");
//         TranslationHelper.ModifyIL(il, " has already been binded to ", "");
//         TranslationHelper.ModifyIL(il, ". (World ID ", "");
//         TranslationHelper.ModifyIL(il, " has already been binded to World ID ", "");
//         TranslationHelper.ModifyIL(il, "The world is shrouded with Light!", "");
//         TranslationHelper.ModifyIL(il, "Enable the client-side configuration option 'Disable Player Progress World Lock' to enable The Stars Above progression on this world.", "");
//     };
// }
//
// [JITWhenModsEnabled("StarsAbove")]
// public class StarsAbovePlayerPreUpdate : Patch<ILContext.Manipulator>
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(StarsAbovePlayer).GetCachedMethod(nameof(StarsAbovePlayer.PreUpdate));
//
//     protected override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Refulgent Prism", "");
//         TranslationHelper.ModifyIL(il, "Refulgent Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Refulgent Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Everflame Prism", "");
//         TranslationHelper.ModifyIL(il, "Everflame Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Everflame Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Crystalline Prism", "");
//         TranslationHelper.ModifyIL(il, "Crystalline Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Crystalline Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Verdant Prism", "");
//         TranslationHelper.ModifyIL(il, "Verdant Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Verdant Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Radiant Prism", "");
//         TranslationHelper.ModifyIL(il, "Radiant Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Radiant Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Apocryphic Prism", "");
//         TranslationHelper.ModifyIL(il, "Apocryphic Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Apocryphic Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Alchemic Prism", "");
//         TranslationHelper.ModifyIL(il, "Alchemic Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Alchemic Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Castellic Prism", "");
//         TranslationHelper.ModifyIL(il, "Castellic Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Castellic Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Lucent Prism", "");
//         TranslationHelper.ModifyIL(il, "Lucent Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Lucent Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Phylactic Prism", "");
//         TranslationHelper.ModifyIL(il, "Phylactic Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Phylactic Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Calamitous Prism", "");
//         TranslationHelper.ModifyIL(il, "Calamitous Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Calamitous Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Lightsworn Prism", "");
//         TranslationHelper.ModifyIL(il, "Lightsworn Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Lightsworn Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Burnished Prism", "");
//         TranslationHelper.ModifyIL(il, "Burnished Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Burnished Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Spatial Prism", "");
//         TranslationHelper.ModifyIL(il, "Spatial Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Spatial Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Painted Prism", "");
//         TranslationHelper.ModifyIL(il, "Painted Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Painted Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Voidsent Prism", "");
//         TranslationHelper.ModifyIL(il, "Voidsent Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Voidsent Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Royal Slime Prism", "");
//         TranslationHelper.ModifyIL(il, "Royal Slime Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Royal Slime Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Mechanical Prism", "");
//         TranslationHelper.ModifyIL(il, "Mechanical Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Mechanical Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Overgrown Prism", "");
//         TranslationHelper.ModifyIL(il, "Overgrown Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Overgrown Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Lihzahrd Prism", "");
//         TranslationHelper.ModifyIL(il, "Lihzahrd Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Lihzahrd Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Typhoon Prism", "");
//         TranslationHelper.ModifyIL(il, "Typhoon Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Typhoon Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Empress Prism", "");
//         TranslationHelper.ModifyIL(il, "Empress Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Empress Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Luminite Prism", "");
//         TranslationHelper.ModifyIL(il, "Luminite Prism", "", 2);
//         TranslationHelper.ModifyIL(il, "Luminite Prism", "", 3);
//         TranslationHelper.ModifyIL(il, "Prism of the Ruined King", "");
//         TranslationHelper.ModifyIL(il, "Prism of the Cosmic Phoenix", "");
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "");
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 2);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 3);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 4);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 5);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 6);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 7);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 8);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 9);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 10);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 11);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 12);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 13);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 14);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 15);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 16);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 17);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 18);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 19);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 20);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 21);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 22);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 23);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 24);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 25);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 25);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 26);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 27);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 28);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 29);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 30);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 31);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 32);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 33);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 34);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 35);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 36);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 37);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 38);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 39);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 40);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 41);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 42);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 43);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 44);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 45);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 46);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 47);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 48);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 49);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 50);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 51);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 52);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 53);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 54);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 55);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 56);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 57);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 58);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 59);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 60);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 61);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 62);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 63);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 64);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 65);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 66);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 67);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 68);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 69);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 70);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 71);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 72);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 73);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 74);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 75);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 76);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 77);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 78);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 79);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 80);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 81);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 82);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 83);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 84);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 85);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 86);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 87);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 88);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 89);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 90);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 91);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 92);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 93);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "", 94);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "");
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 2);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 3);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 4);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 5);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 6);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 7);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 8);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 9);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 10);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 11);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 12);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 13);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 14);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 15);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 16);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 17);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 18);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 19);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 20);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 21);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 22);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 23);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "", 24);
//         TranslationHelper.ModifyIL(il, "You have acquired a new Stellar Nova!", "");
//         TranslationHelper.ModifyIL(il, "You have acquired a new Stellar Nova!", "", 2);
//         TranslationHelper.ModifyIL(il, "You have acquired a new Stellar Nova!", "", 3);
//         TranslationHelper.ModifyIL(il, "You have acquired a new Stellar Nova!", "", 4);
//         TranslationHelper.ModifyIL(il, "You have acquired a new Stellar Nova!", "", 5);
//         TranslationHelper.ModifyIL(il, "The sky becomes heavy with overwhelming Light...", "");
//         TranslationHelper.ModifyIL(il, "The Light flooding this world has been cleansed!", "");
//         TranslationHelper.ModifyIL(il, "The Boss Checklist updates to reveal a hidden foe..!", "");
//         TranslationHelper.ModifyIL(il, "Stellar Novas have been unlocked!", "");
//         TranslationHelper.ModifyIL(il, "The Stellar Array reaches new heights!", "");
//     };
// }
//
// [JITWhenModsEnabled("StarsAbove")]
// public class StarsAbovePlayerPreKill : Patch<ILContext.Manipulator>
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(StarsAbovePlayer).GetCachedMethod(nameof(StarsAbovePlayer.PreKill));
//
//     protected override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, " died beyond their world.", "");
//         TranslationHelper.ModifyIL(il, " was lost in space.", "");
//         TranslationHelper.ModifyIL(il, " drifted away from their home planet.", "");
//         TranslationHelper.ModifyIL(il, " was brought to kneel beyond their world.", "");
//         TranslationHelper.ModifyIL(il, " died within another realm.", "");
//         TranslationHelper.ModifyIL(il, " was struck down during their duel with The Warrior Of Light.", "");
//         TranslationHelper.ModifyIL(il, " faltered during their fight with the Witch of Ink.", "");
//         TranslationHelper.ModifyIL(il, " was cleaved in twain by the Burnished King.", "");
//         TranslationHelper.ModifyIL(il, " was found wanting.", "");
//         TranslationHelper.ModifyIL(il, " has been completely reduced to elementary particles.", "");
//         TranslationHelper.ModifyIL(il, " was rent asunder by the Vagrant of Space and Time.", "");
//         TranslationHelper.ModifyIL(il, " couldn't handle the vacuum of space.", "");
//     };
// }