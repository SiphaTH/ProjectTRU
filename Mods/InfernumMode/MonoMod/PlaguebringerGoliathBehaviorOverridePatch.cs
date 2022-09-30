using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.BehaviorOverrides.BossAIs.PlaguebringerGoliath;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class PlaguebringerGoliathBehaviorOverridePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(PlaguebringerGoliathBehaviorOverride).GetCachedMethod(nameof(PlaguebringerGoliathBehaviorOverride.DoBehavior_BombConstructors));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "NUCLEAR CORE GENERATED. INITIATING BUILD PROCEDURE!", "ЯДЕРНОЕ ЯДРО СГЕНЕРИРОВАНО. ИНИЦИИРОВАНА ПРОЦЕДУРА СБОРКИ!");
    };
}