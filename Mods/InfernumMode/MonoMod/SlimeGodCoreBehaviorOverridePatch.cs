// using System;
// using System.Collections.Generic;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.SlimeGod;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class SlimeGodCoreBehaviorOverridePatch : OnPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(SlimeGodCoreBehaviorOverride).GetCachedMethod(nameof(SlimeGodCoreBehaviorOverride.GetTips));
//
//     private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(SlimeGodCoreBehaviorOverride self);
//
//     public override Delegate Delegate => Translation;
//
//     private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, SlimeGodCoreBehaviorOverride self)
//     {
//         yield return n => "Они кажутся не очень умными. Может, ты бы смог обмануть их, чтобы они прыгнули выше, если сделаешь то же самое?";
//         yield return n => SlimeGodComboAttackManager.FightState == SlimeGodFightState.CorePhase ? "Не пугайся снарядов, но будь осторожен в своих движениях!" : string.Empty;
//
//     }
// }