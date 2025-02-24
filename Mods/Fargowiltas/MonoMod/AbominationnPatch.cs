﻿using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.NPCs;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

public class AbominationnSetChatButtons : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Abominationn).GetCachedMethod(nameof(Abominationn.SetChatButtons));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Cancel Event", "Остановить событие");
    };
}

public class AbominationnOnChatButtonClicked : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Abominationn).GetCachedMethod(nameof(Abominationn.OnChatButtonClicked));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "I'm not feeling it right now, come back in ", "Я не в настроении, возвращайся через ");
        TranslationHelper.ModifyIL(il, " seconds.", " секунд.");
    };
}