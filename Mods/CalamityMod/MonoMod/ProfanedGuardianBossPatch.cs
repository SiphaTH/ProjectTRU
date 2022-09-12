using System.Reflection;
using CalamityMod.NPCs.ProfanedGuardians;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class ProfanedGuardianCommanderPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ProfanedGuardianCommander).GetCachedMethod(nameof(ProfanedGuardianCommander.BossLoot));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "A Profaned Guardian", "Осквернённый страж");
    };
}

[JITWhenModsEnabled("CalamityMod")]
public class ProfanedGuardianDefenderPacth : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ProfanedGuardianDefender).GetCachedMethod(nameof(ProfanedGuardianDefender.BossLoot));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "A Profaned Guardian", "Осквернённый страж");
    };
}

[JITWhenModsEnabled("CalamityMod")]
public class ProfanedGuardianHealerPacth : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ProfanedGuardianHealer).GetCachedMethod(nameof(ProfanedGuardianHealer.BossLoot));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "A Profaned Guardian", "Осквернённый страж");
    };
}