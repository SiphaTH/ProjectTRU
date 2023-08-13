// using System;
// using System.Collections.Generic;
// using System.Reflection;
// using CalamityMod.NPCs.Leviathan;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.Leviathan;
// using Terraria;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class AnahitaBehaviorOverridePatch : OnPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(AnahitaBehaviorOverride).GetCachedMethod(nameof(AnahitaBehaviorOverride.GetTips));
//
//     private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(AnahitaBehaviorOverride self);
//
//     public override Delegate Delegate => Translation;
//
//     private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, AnahitaBehaviorOverride self)
//     {
//         yield return n => "Манипулируя её движением, можно уклоняться от нот!";
//         yield return n => NPC.AnyNPCs(ModContent.NPCType<Leviathan>()) ? "Все метеориты разделяются одинаково, используй это знание себе на пользу!" : string.Empty;
//     }
// }