// using System;
// using System.Collections.Generic;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.AstrumAureus;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class AstrumAureusBehaviorOverridePatch : OnPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(AstrumAureusBehaviorOverride).GetCachedMethod(nameof(AstrumAureusBehaviorOverride.GetTips));
//
//     private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(AstrumAureusBehaviorOverride self);
//
//     public override Delegate Delegate => Translation;
//
//     private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, AstrumAureusBehaviorOverride self)
//     {
//         yield return n => "Старайся держаться рядом, иначе тебя могут застать врасплох!";
//     }
// }