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
// public class StarsAbovePlayerOnEnterWorld : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(StarsAbovePlayer).GetCachedMethod(nameof(StarsAbovePlayer.OnEnterWorld));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, " has been binded to ", " был связан с миром: ");
//         TranslationHelper.ModifyIL(il, "The Stars Above progression will only occur on this world. (Check Mod Settings if necessary)", "");
//         TranslationHelper.ModifyIL(il, " has already been binded to ", "");
//         TranslationHelper.ModifyIL(il, ". (World ID ", "");
//         TranslationHelper.ModifyIL(il, " has already been binded to World ID ", "");
//         TranslationHelper.ModifyIL(il, "The world is shrouded with Light!", "Мир окутан Светом!");
//         TranslationHelper.ModifyIL(il, "Enable the client-side configuration option 'Disable Player Progress World Lock' to enable The Stars Above progression on this world.", "");
//     };
// }
//
// [JITWhenModsEnabled("StarsAbove")]
// public class StarsAbovePlayerPreUpdate : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(StarsAbovePlayer).GetCachedMethod(nameof(StarsAbovePlayer.PreUpdate));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Refulgent Prism", "Сверкающая призма");
//         TranslationHelper.ModifyIL(il, "Refulgent Prism", "Сверкающая призма", 2);
//         TranslationHelper.ModifyIL(il, "Refulgent Prism", "Сверкающая призма", 3);
//         TranslationHelper.ModifyIL(il, "Everflame Prism", "Вечногорящая призма");
//         TranslationHelper.ModifyIL(il, "Everflame Prism", "Вечногорящая призма", 2);
//         TranslationHelper.ModifyIL(il, "Everflame Prism", "Вечногорящая призма", 3);
//         TranslationHelper.ModifyIL(il, "Crystalline Prism", "Кристаллиновая призма");
//         TranslationHelper.ModifyIL(il, "Crystalline Prism", "Кристаллиновая призма", 2);
//         TranslationHelper.ModifyIL(il, "Crystalline Prism", "Кристаллиновая призма", 3);
//         TranslationHelper.ModifyIL(il, "Verdant Prism", "Зелёная призма");
//         TranslationHelper.ModifyIL(il, "Verdant Prism", "Зелёная призма", 2);
//         TranslationHelper.ModifyIL(il, "Verdant Prism", "Зелёная призма", 3);
//         TranslationHelper.ModifyIL(il, "Radiant Prism", "Лучезарная призма");
//         TranslationHelper.ModifyIL(il, "Radiant Prism", "Лучезарная призма", 2);
//         TranslationHelper.ModifyIL(il, "Radiant Prism", "Лучезарная призма", 3);
//         TranslationHelper.ModifyIL(il, "Apocryphic Prism", "Апокрифическая призма");
//         TranslationHelper.ModifyIL(il, "Apocryphic Prism", "Апокрифическая призма", 2);
//         TranslationHelper.ModifyIL(il, "Apocryphic Prism", "Апокрифическая призма", 3);
//         TranslationHelper.ModifyIL(il, "Alchemic Prism", "Алхимическая призма");
//         TranslationHelper.ModifyIL(il, "Alchemic Prism", "Алхимическая призма", 2);
//         TranslationHelper.ModifyIL(il, "Alchemic Prism", "Алхимическая призма", 3);
//         TranslationHelper.ModifyIL(il, "Castellic Prism", "Кастеллическая призма");
//         TranslationHelper.ModifyIL(il, "Castellic Prism", "Кастеллическая призма", 2);
//         TranslationHelper.ModifyIL(il, "Castellic Prism", "Кастеллическая призма", 3);
//         TranslationHelper.ModifyIL(il, "Lucent Prism", "Светлая призма");
//         TranslationHelper.ModifyIL(il, "Lucent Prism", "Светлая призма", 2);
//         TranslationHelper.ModifyIL(il, "Lucent Prism", "Светлая призма", 3);
//         TranslationHelper.ModifyIL(il, "Phylactic Prism", "Профилактическая призма");
//         TranslationHelper.ModifyIL(il, "Phylactic Prism", "Профилактическая призма", 2);
//         TranslationHelper.ModifyIL(il, "Phylactic Prism", "Профилактическая призма", 3);
//         TranslationHelper.ModifyIL(il, "Calamitous Prism", "Бедственная призма");
//         TranslationHelper.ModifyIL(il, "Calamitous Prism", "Бедственная призма", 2);
//         TranslationHelper.ModifyIL(il, "Calamitous Prism", "Бедственная призма", 3);
//         TranslationHelper.ModifyIL(il, "Lightsworn Prism", "Светоносная призма");
//         TranslationHelper.ModifyIL(il, "Lightsworn Prism", "Светоносная призма", 2);
//         TranslationHelper.ModifyIL(il, "Lightsworn Prism", "Светоносная призма", 3);
//         TranslationHelper.ModifyIL(il, "Burnished Prism", "Воронёная призма");
//         TranslationHelper.ModifyIL(il, "Burnished Prism", "Воронёная призма", 2);
//         TranslationHelper.ModifyIL(il, "Burnished Prism", "Воронёная призма", 3);
//         TranslationHelper.ModifyIL(il, "Spatial Prism", "Пространственная призма");
//         TranslationHelper.ModifyIL(il, "Spatial Prism", "Пространственная призма", 2);
//         TranslationHelper.ModifyIL(il, "Spatial Prism", "Пространственная призма", 3);
//         TranslationHelper.ModifyIL(il, "Painted Prism", "Крашеная призма");
//         TranslationHelper.ModifyIL(il, "Painted Prism", "Крашеная призма", 2);
//         TranslationHelper.ModifyIL(il, "Painted Prism", "Крашеная призма", 3);
//         TranslationHelper.ModifyIL(il, "Voidsent Prism", "Пустотная призма");
//         TranslationHelper.ModifyIL(il, "Voidsent Prism", "Пустотная призма", 2);
//         TranslationHelper.ModifyIL(il, "Voidsent Prism", "Пустотная призма", 3);
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
//         TranslationHelper.ModifyIL(il, "Prism of the Ruined King", "Призма свергнутого короля");
//         TranslationHelper.ModifyIL(il, "Prism of the Cosmic Phoenix", "Призма космического феникса");
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.");
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 2);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 3);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 4);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 5);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 6);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 7);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 8);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 9);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 10);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 11);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 12);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 13);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 14);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 15);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 16);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 17);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 18);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 19);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 20);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 21);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 22);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 23);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 24);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 25);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 25);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 26);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 27);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 28);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 29);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 30);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 31);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 32);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 33);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 34);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 35);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 36);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 37);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 38);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 39);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 40);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 41);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 42);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 43);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 44);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 45);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 46);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 47);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 48);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 49);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 50);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 51);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 52);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 53);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 54);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 55);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 56);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 57);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 58);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 59);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 60);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 61);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 62);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 63);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 64);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 65);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 66);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 67);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 68);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 69);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 70);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 71);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 72);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 73);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 74);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 75);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 76);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 77);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 78);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 79);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 80);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 81);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 82);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 83);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 84);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 85);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 86);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 87);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 88);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 89);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 90);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 91);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 92);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 93);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 94);
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate. Left click to interact.", "Простраственный диск резонирует. Нажмите ЛКМ для взаимодействия.", 95);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!");
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 2);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 3);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 4);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 5);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 6);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 7);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 8);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 9);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 10);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 11);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 12);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 13);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 14);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 15);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 16);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 17);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 18);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 19);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 20);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 21);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 22);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 23);
//         TranslationHelper.ModifyIL(il, "The Stellar Array has gained a new ability!", "Открывается новое Созвездие!", 24);
//         TranslationHelper.ModifyIL(il, "You have acquired a new Stellar Nova!", "Вы получили новую Сверхновую!");
//         TranslationHelper.ModifyIL(il, "You have acquired a new Stellar Nova!", "Вы получили новую Сверхновую!", 2);
//         TranslationHelper.ModifyIL(il, "You have acquired a new Stellar Nova!", "Вы получили новую Сверхновую!", 3);
//         TranslationHelper.ModifyIL(il, "You have acquired a new Stellar Nova!", "Вы получили новую Сверхновую!", 4);
//         TranslationHelper.ModifyIL(il, "You have acquired a new Stellar Nova!", "Вы получили новую Сверхновую!", 5);
//         TranslationHelper.ModifyIL(il, "The sky becomes heavy with overwhelming Light...", "Небо тяжелеет от переполняющего Света...");
//         TranslationHelper.ModifyIL(il, "The Light flooding this world has been cleansed!", "Свет, переполняющий этот мир, был очищен!");
//         TranslationHelper.ModifyIL(il, "The Boss Checklist updates to reveal a hidden foe..!", "Boss Checklist обновляется, открывая скрытого врага!..");
//         TranslationHelper.ModifyIL(il, "Stellar Novas have been unlocked!", "Сверхновые разблокированы!");
//         TranslationHelper.ModifyIL(il, "The Stellar Array reaches new heights!", "Созвездия достигают новых высот!");
//     };
// }
//
// [JITWhenModsEnabled("StarsAbove")]
// public class StarsAbovePlayerPreKill : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(StarsAbovePlayer).GetCachedMethod(nameof(StarsAbovePlayer.PreKill));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, " died beyond their world.", "");
//         TranslationHelper.ModifyIL(il, " was lost in space.", "");
//         TranslationHelper.ModifyIL(il, " drifted away from their home planet.", "");
//         TranslationHelper.ModifyIL(il, " was brought to kneel beyond their world.", "");
//         TranslationHelper.ModifyIL(il, " died within another realm.", "");
//         TranslationHelper.ModifyIL(il, " was struck down during their duel with The Warrior Of Light.", " был сражён во время дуэли с Воином Света.");
//         TranslationHelper.ModifyIL(il, " faltered during their fight with the Witch of Ink.", " дрогнул во время битвы с Ведьмой чернил.");
//         TranslationHelper.ModifyIL(il, " was cleaved in twain by the Burnished King.", " был располовинен Воронёным королём.");
//         TranslationHelper.ModifyIL(il, " was found wanting.", " был признан жаждущим.");
//         TranslationHelper.ModifyIL(il, " has been completely reduced to elementary particles.", " был полностью разложен на элементарные частицы.");
//         TranslationHelper.ModifyIL(il, " was rent asunder by the Vagrant of Space and Time.", " был разорван на части Ходящим между пространством и временем.");
//         TranslationHelper.ModifyIL(il, " couldn't handle the vacuum of space.", " не выдержал вакуума космоса.");
//     };
// }