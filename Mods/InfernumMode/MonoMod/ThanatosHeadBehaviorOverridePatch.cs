// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.Draedon.Thanatos;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class ThanatosHeadBehaviorOverrideDoBehavior_MaximumOverdrive : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(ThanatosHeadBehaviorOverride).GetCachedMethod(nameof(ThanatosHeadBehaviorOverride.DoBehavior_MaximumOverdrive));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "THANATOS-05: EXO TURRETS BURNING AT UNSTABLE ENERGY LEVELS. SELF DESTRUCTION IMMINENT.", "ТАНАТОС-05: ЭКЗО-ТУРЕЛИ РАБОТАЮТ НА НЕСТАБИЛЬНОМ УРОВНЕ ЭНЕРГИИ. САМОУНИЧТОЖЕНИЕ НЕИЗБЕЖНО.");
//         TranslationHelper.ModifyIL(il, "THANATOS-05: PREPARING 'MAXIMUM OVERDRIVE CHARGE' MUTUTAL DESTRUCTION PROTOCOL.", "ТАНАТОС-05: ПОДГОТОВКА ПРОТОКОЛА ОБОЮДНОГО УНИЧТОЖЕНИЯ 'МАКСИМАЛЬНАЯ ПЕРЕГРУЗКА ЗАРЯДА'");
//     };
// }