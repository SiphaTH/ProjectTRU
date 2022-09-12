// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;
//
// [JITWhenModsEnabled("StarsAbove")]
// public class StarfarerSelectionOnInitialize : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => ModsCall.StarsAbove.Code
//         .GetType("StarsAbove.UI.Starfarers.StarfarerSelection").GetCachedMethod("OnInitialize");
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Choose a Starfarer to aid you on your journey", "Выберите Астру, помогающую вам в пути");
//         TranslationHelper.ModifyIL(il, "[c/E36666:This decision is permanent! (per character)]", "[c/E36666:Этот выбор не изменить! (для текущего персонажа)]");
//     };
// }
//
// [JITWhenModsEnabled("StarsAbove")]
// public class StarfarerSelectionMouseClickA : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => ModsCall.StarsAbove.Code
//         .GetType("StarsAbove.UI.Starfarers.StarfarerSelection").GetCachedMethod("MouseClickA");
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "You feel astral energy coursing through you...", "Вы чувствуете проходящую сквозь вас астральную энергию...");
//         TranslationHelper.ModifyIL(il, "Maximum mana increased by 20!", "Максимальный запас маны увеличен на 20!");
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate; looks like someone wants to talk.", "Пространственный диск резонирует. Кажется кто-то хочет поговорить.");
//     };
// }
//
// [JITWhenModsEnabled("StarsAbove")]
// public class StarfarerSelectionMouseClickB : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => ModsCall.StarsAbove.Code
//         .GetType("StarsAbove.UI.Starfarers.StarfarerSelection").GetCachedMethod("MouseClickB");
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "You feel umbral energy coursing through you...", "Вы чувствуете проходящую сквозь вас пустотную энергию...");
//         TranslationHelper.ModifyIL(il, "Maximum mana increased by 20!", "Максимальный запас маны увеличен на 20!");
//         TranslationHelper.ModifyIL(il, "The Spatial Disk begins to resonate; looks like someone wants to talk.", "Пространственный диск резонирует. Кажется кто-то хочет поговорить.");
//     };
// }