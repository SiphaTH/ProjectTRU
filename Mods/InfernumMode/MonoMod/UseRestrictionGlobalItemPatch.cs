﻿using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Core.GlobalInstances.GlobalItems;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class UseRestrictionGlobalItemPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(UseRestrictionGlobalItem).GetCachedMethod(nameof(UseRestrictionGlobalItem.DisplayTeleportDenialText));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "YOU CANNOT EVADE ME SO EASILY!", "ОТ МЕНЯ ТАК ЛЕГКО НЕ УСКОЛЬЗНУТЬ!");
        TranslationHelper.ModifyIL(il, "YOU CANNOT HOPE TO OUTSMART A MASTER OF DIMENSIONS!", "НЕ НАДЕЙСЯ ПЕРЕХИТРИТЬ МАСТЕРА ИЗМЕРЕНИЙ!");
        TranslationHelper.ModifyIL(il, "NOT SO FAST!", "НЕ ТАК БЫСТРО!");
    };
}