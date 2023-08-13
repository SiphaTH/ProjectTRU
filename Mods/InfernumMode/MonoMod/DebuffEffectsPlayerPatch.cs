// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Core.GlobalInstances.Players;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class DebuffEffectsPlayerPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(DebuffEffectsPlayer).GetCachedMethod(nameof(DebuffEffectsPlayer.PreKill));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, " could not withstand the red lightning.", " не выдерживает красной молнии.");
//         TranslationHelper.ModifyIL(il, " was incinerated by ungodly fire.", " сгорает осквернённым огнём.");
//         TranslationHelper.ModifyIL(il, " went mad.", " сходит с ума. ");
//     };
// }
