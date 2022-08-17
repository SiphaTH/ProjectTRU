using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.NPCs;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class MutantPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Mutant).GetCachedMethod(nameof(Mutant.SetChatButtons));

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Pre Hardmode", "Прехардмод");
        TranslationHelper.ModifyIL(il, "Hardmode", "Хардмод");
        TranslationHelper.ModifyIL(il, "Post Moon Lord", "Пост-Лунный лорд");
        TranslationHelper.ModifyIL(il, "Cycle Shop", "Переключить магазин");
    };
}