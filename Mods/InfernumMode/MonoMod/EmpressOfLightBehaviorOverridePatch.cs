// using System;
// using System.Collections.Generic;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.EmpressOfLight;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class EmpressOfLightBehaviorOverridePatch : OnPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(EmpressOfLightBehaviorOverride).GetCachedMethod(nameof(EmpressOfLightBehaviorOverride.GetTips));
//
//     private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(EmpressOfLightBehaviorOverride self);
//
//     public override Delegate Delegate => Translation;
//
//     private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, EmpressOfLightBehaviorOverride self)
//     {
//         yield return n => "Понимаешь, я всегда была в восторге от радуг, но атаки этого существа просто смертельно красивы. Упс, неправильно подобрала слова.";
//     }
// }