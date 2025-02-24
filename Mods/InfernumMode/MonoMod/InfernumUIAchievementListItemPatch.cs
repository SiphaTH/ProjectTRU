﻿using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.UI;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class InfernumUIAchievementListItemPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(InfernumUIAchievementListItem).GetCachedMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        // Увеличиваем длину для переноса текста на новую строку
        TranslationHelper.ModifyIL(il, 20f, -30f);
    };
}