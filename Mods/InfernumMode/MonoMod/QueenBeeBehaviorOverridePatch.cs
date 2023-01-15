using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.QueenBee;
using InfernumMode.Core.GlobalInstances.Systems;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class QueenBeeBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(QueenBeeBehaviorOverride).GetCachedMethod(nameof(QueenBeeBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(QueenBeeBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, QueenBeeBehaviorOverride self)
    {
        yield return n => "Эти медовые выстрелы невероятно прыгучие. Не двигайся слишком быстро, иначе они повсюду разлетятся!";
        yield return n => "Избавление от лишних шершней должно стать твоей приоритетной задачей!";
        yield return n => HatGirlTipsManager.ShouldUseJokeText ? "Обжужжаться можно совершенно неуместно!" : string.Empty;
        yield return n => HatGirlTipsManager.ShouldUseJokeText ? "Уф, вот это жалко..." : string.Empty;
    }
}