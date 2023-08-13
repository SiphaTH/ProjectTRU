// using System;
// using System.Collections.Generic;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.Polterghast;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class PolterghastBehaviorOverridePatch : OnPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(PolterghastBehaviorOverride).GetCachedMethod(nameof(PolterghastBehaviorOverride.GetTips));
//
//     private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(PolterghastBehaviorOverride self);
//
//     public override Delegate Delegate => Translation;
//
//     private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, PolterghastBehaviorOverride self)
//     {
//         yield return n => "Рывок в каком-то роде очень помогает при вращающейся кольцевой атаке, так как он позволяет быстро добраться до прорехи!";
//         yield return n => "Если одна из ног Полтергаста станет красной - быстро назад. Он собирается ударить по тебе и выпустить быстрые снаряды!";
//     }
// }