using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.GreatSandShark;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class BereftVassalBossTitle : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BereftVassal).GetCachedMethod("get_BossTitle");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bereft Vassal", "Обездоленный вассал");
    };
}

public class BereftVassalSpawnRequirement : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BereftVassal).GetCachedMethod("get_SpawnRequirement");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Use a [i:", "Используйте [i:");
        TranslationHelper.ModifyIL(il, "] at the pedestal in the heart of the desert.", "] на пьедестале в сердце пустыни.");
    };
}

public class BereftVassalDespawnMessage : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BereftVassal).GetCachedMethod("get_DespawnMessage");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Argus returns to quiet solitude at the center of the Colosseum.", "Аргус возвращается к тихому уединению в центре колизея.");
    };
}