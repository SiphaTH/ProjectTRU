// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Core.GlobalInstances.Players;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class CyberneticImmortalityPlayerPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(CyberneticImmortalityPlayer).GetCachedMethod(nameof(CyberneticImmortalityPlayer.ToggleImmortality));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Cybernetic immortality has been ", "Кибернетическое бессмертие ");
//         TranslationHelper.ModifyIL(il, "enabled", "включено");
//         TranslationHelper.ModifyIL(il, "disabled", "отключено");
//     };
// }