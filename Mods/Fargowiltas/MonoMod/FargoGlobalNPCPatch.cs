using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.NPCs;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class FargoGlobalNPCCheckDead : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FargoGlobalNPC).GetCachedMethod(nameof(FargoGlobalNPC.CheckDead));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Betsy has been defeated!", "Бэтси побеждена!");
    };
}

[JITWhenModsEnabled("Fargowiltas")]
public class FargoGlobalNPCSwarm : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FargoGlobalNPC).GetCachedMethod("Swarm");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Killed: ", "Убито: ");
        TranslationHelper.ModifyIL(il, "Killed: ", "Убито: ", 2);
        TranslationHelper.ModifyIL(il, "Total: ", "Всего: ");
        TranslationHelper.ModifyIL(il, "Total: ", "Всего: ", 2);
        TranslationHelper.ModifyIL(il, "The swarm has been defeated!", "Орда побеждена!");
        TranslationHelper.ModifyIL(il, "The swarm has been defeated!", "Орда побеждена!", 2);
    };
}