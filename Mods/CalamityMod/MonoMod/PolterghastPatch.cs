using System.Reflection;
using CalamityMod.NPCs.Polterghast;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class PolterghastPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Polterghast).GetCachedMethod(nameof(Polterghast.AI));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Necroghast", "Некрогаст");
        TranslationHelper.ModifyIL(il, "Necroplasm", "Некроплазм");
    };
}