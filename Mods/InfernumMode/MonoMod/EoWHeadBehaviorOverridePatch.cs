// using System;
// using System.Collections.Generic;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.EoW;
// using InfernumMode.Core.GlobalInstances.Systems;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class EoWHeadBehaviorOverridePatch : OnPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(EoWHeadBehaviorOverride).GetCachedMethod(nameof(EoWHeadBehaviorOverride.GetTips));
//
//     private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(EoWHeadBehaviorOverride self);
//
//     public override Delegate Delegate => Translation;
//
//     private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, EoWHeadBehaviorOverride self)
//     {
//         yield return n => "Многоуровневые платформы помогут избежать взрывающихся проклятых огней!";
//         yield return n => "Крюк и рывок значительно помогают реагировать на резкие всплески скоростей пожирателей!";
//         yield return n => TipsManager.ShouldUseJokeText ? "Думаю, он пожирает нечто большее, чем просто миры." : string.Empty;
//     }
// }