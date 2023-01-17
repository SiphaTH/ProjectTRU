using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.BoC;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class BoCBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BoCBehaviorOverride).GetCachedMethod(nameof(BoCBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(BoCBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, BoCBehaviorOverride self)
    {
        yield return n => "Мозг Ктулху часто пользуется предвидением и хитростью в своих атаках, так что не тупи!";
        yield return n => "Мозг попытается одурачить тебя обманом зрения, но ты должен следить за настоящим!";
    }
}