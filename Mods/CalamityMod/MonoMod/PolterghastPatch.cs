using System.Reflection;
using CalamityMod.NPCs.Polterghast;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class PolterghastPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Polterghast).GetCachedMethod(nameof(Polterghast.AI));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Necroghast", "Некрогаст");
        TranslationHelper.ModifyIL(il, "Necroplasm", "Некроплазм");
    };
}