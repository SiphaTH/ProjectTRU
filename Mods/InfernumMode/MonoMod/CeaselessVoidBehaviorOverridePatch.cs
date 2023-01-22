using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.CeaselessVoid;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class CeaselessVoidBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CeaselessVoidBehaviorOverride).GetCachedMethod(nameof(CeaselessVoidBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(CeaselessVoidBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, CeaselessVoidBehaviorOverride self)
    {
        yield return n => "В начале боя старайся особо не передвигаться. Найди хорошее положение и оставайся рядом с ним - это очень помогает!";
        yield return n => "Большинство атак Пустоты требуют быстрой реакции для уклонения. Внимательно следи за любыми снарядами на экране!";
    }
}