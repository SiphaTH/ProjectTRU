using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.BehaviorOverrides.BossAIs.Providence;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class ProvidenceBehaviorOverridePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ProvidenceBehaviorOverride).GetCachedMethod(nameof(ProvidenceBehaviorOverride.PreAI));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The blazing air rises...", "Поднимается обжигающий воздух...");
        TranslationHelper.ModifyIL(il, "The blue flames roar...", "Ревёт синее пламя...");
    };
}