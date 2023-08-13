// using System;
// using System.Collections.Generic;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.WallOfFlesh;
// using InfernumMode.Core.GlobalInstances.Systems;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class WallOfFleshMouthBehaviorOverridePatch : OnPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(WallOfFleshMouthBehaviorOverride).GetCachedMethod(nameof(WallOfFleshMouthBehaviorOverride.GetTips));
//
//     private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(WallOfFleshMouthBehaviorOverride self);
//
//     public override Delegate Delegate => Translation;
//
//     private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, WallOfFleshMouthBehaviorOverride self)
//     {
//         yield return n => TipsManager.ShouldUseJokeText ? "Обязательно беги в противоположном направлении!" : string.Empty;
//
//     }
// }