// using System;
// using System.Collections.Generic;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.OldDuke;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class OldDukeBehaviorOverridePatch : OnPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(OldDukeBehaviorOverride).GetCachedMethod(nameof(OldDukeBehaviorOverride.GetTips));
//
//     private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(OldDukeBehaviorOverride self);
//
//     public override Delegate Delegate => Translation;
//
//     private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, OldDukeBehaviorOverride self)
//     {
//         yield return n => "Обязательно запомни, если появлялись какие-нибудь акулоны или шары зубов, чтобы их остатки не удивили позже!";
//         yield return n => "Против этой рыбы понадобится неплохая такая скорость передвижения!";
//         yield return n => n.life < n.lifeMax * 0.2f ?  "Старайся считать на последней фазе. Старый герцог телепортируется и делает семь раз рывок, затем просто повторяет." : string.Empty;
//         yield return n => !Main.LocalPlayer.HasDash() ? "Эм, ты точно уверен, что не хочешь использовать рывки против этой рыбины?" : string.Empty;
//         yield return n => !Main.LocalPlayer.HasDash() ? "Знаешь, аксессуар, дающий рывки, был тут пипец полезен..." : string.Empty;
//     }
// }