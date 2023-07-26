// using System;
// using System.Reflection;
// using CalamityMod.Systems;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;
//
// public class YharonPhase2MusicScenePatch : OnPatcher
// {
//     public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(YharonPhase2MusicScene).GetCachedMethod("get_MusicModMusic");
//
//     private delegate int? MusicModMusicDelegate(YharonPhase2MusicScene self);
//
//     public override Delegate Delegate => Translation;
//
//     private int? Translation(MusicModMusicDelegate orig, YharonPhase2MusicScene self)
//     {
//         return MusicLoader.GetMusicSlot(CalamityRuTranslate.Instance, "Sounds/CalamityMod/YharonPhase2");
//     }
// }