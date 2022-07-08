using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.NPCs;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class DevianttPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Deviantt).GetCachedMethod(nameof(Deviantt.SetChatButtons));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Help", "Помощь");
    };
}