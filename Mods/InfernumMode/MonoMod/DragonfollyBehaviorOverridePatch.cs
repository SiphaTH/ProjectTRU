using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Dragonfolly;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class DragonfollyBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DragonfollyBehaviorOverride).GetCachedMethod(nameof(DragonfollyBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(DragonfollyBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, DragonfollyBehaviorOverride self)
    {
        yield return n => "Бой с псевдодраконом весьма хаотичен и динамичен. Хорошая мобильность и скорость реакции очень помогают!";
        yield return n => "Эти большие красные столбы молний можно избежать, просто пролетев под ними!";
    }
}