// using System;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using Terraria.ModLoader.Config;
//
// namespace CalamityRuTranslate.Vanilla.MonoMod;
//
// public class TooltipAttributePatch : OnPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(TooltipAttribute).GetCachedMethod("get_Tooltip");
//
//     private delegate string TooltipDelegate(TooltipAttribute self);
//
//     public override Delegate Delegate => Translation;
//     
//     private string Translation(TooltipDelegate orig, TooltipAttribute self)
//     {
//         string tooltip = self.GetType().GetField("tooltip", (BindingFlags)60)?.GetValue(self) as string;
//         
//         return tooltip switch
//         {
//             "Enables boss introduction animations. They only activate when Infernum Mode is active." => "Включает вступительную анимацию босса. Она активируются только когда включёна сложность Инфернум.",
//             "Determines whether the pet from the Blasted Tophat should display its tips in chat or not." => "Отвечает за то, должен ли питомец Проклятого цилиндра отображать свои подсказки в чате или нет.",
//             "Enables reduced graphics mode. Use this if lag is an issue." => "Включает режим сниженной графики. Используйте это, если низкая производительность вызывает проблемы.",
//             "How intense color saturation bloom effects should be. Such effects are disabled when this value is zero. Be warned that high values may be overwhelming." => "Насколько интенсивными должны быть эффекты насыщенности свечения. Такие эффекты отключаются, когда эта настройка равняется нулю.\nИмейте в виду, что высокие значения могут оказаться ошеломляющими.",
//             "Enables screen overlay 'flashbang' effects. This will not directly affect gameplay mechanics." => "Включает наложение эффектов 'вспышек' на экране. Это никак не влияет на игровую механику.",
//             "Enables boss footage recordings for the playback during the credits." => "Включает запись кадров битвы с боссом для воспроизведения в титрах.",
//             _ => orig.Invoke(self)
//         };
//     }
// }