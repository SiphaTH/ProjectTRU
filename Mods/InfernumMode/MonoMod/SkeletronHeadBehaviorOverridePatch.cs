using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Skeletron;
using InfernumMode.Core.GlobalInstances.Systems;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class SkeletronHeadBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(SkeletronHeadBehaviorOverride).GetCachedMethod(nameof(SkeletronHeadBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(SkeletronHeadBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, SkeletronHeadBehaviorOverride self)
    {
        yield return n => "Всё немного не так, как ты думаешь. Бег сквозь стены теневого пламени не сработает, не торопись!";
        yield return n => n.life < n.lifeMax * 0.85f ? "Не паникуй, когда Скелетрон выпускает шквал огненных шаров! Просто прыгай и сохраняй спокойствие!" : string.Empty;
        yield return n => HatGirlTipsManager.ShouldUseJokeText ? "Иии... СЛИЛСЯ!!!" : string.Empty;
        
    }
}