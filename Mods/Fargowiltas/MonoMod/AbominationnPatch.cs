using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.NPCs;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class AbominationnSetChatButtons : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Abominationn).GetCachedMethod(nameof(Abominationn.SetChatButtons));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Cancel Event", "Остановить событие");
    };
}

[JITWhenModsEnabled("Fargowiltas")]
public class AbominationnOnChatButtonClicked : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Abominationn).GetCachedMethod(nameof(Abominationn.OnChatButtonClicked));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Hocus pocus, the event is over", "Фокус-покус, событие кончилось.");
        TranslationHelper.ModifyIL(il, "I'm not feeling it right now, come back in ", "Не думаю, что смогу это сделать сейчас, возвращайся через ");
        TranslationHelper.ModifyIL(il, " seconds.", " секунд.");
    };
}