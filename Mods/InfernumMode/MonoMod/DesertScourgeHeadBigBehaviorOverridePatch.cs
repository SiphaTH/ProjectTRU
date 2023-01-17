using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.DesertScourge;
using InfernumMode.Core.GlobalInstances.Systems;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class DesertScourgeHeadBigBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DesertScourgeHeadBigBehaviorOverride).GetCachedMethod(nameof(DesertScourgeHeadBigBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(DesertScourgeHeadBigBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, DesertScourgeHeadBigBehaviorOverride self)
    {
        yield return n => "Бич обычно рычит, когда собирается поднять песчаную бурю, забирайся на возвышенность!";
        yield return n => "Крюк может помочь быстро выбраться из-под челюстей бича!";
        yield return n => HatGirlTipsManager.ShouldUseJokeText ? "Я не люблю песок, он грубый, жёсткий, неприятный и проникает в каждую часть моих ног." : string.Empty;
        yield return n => HatGirlTipsManager.ShouldUseJokeText ? "Лучше тебе приготовить мне что-нибудь сладкое после этого ..." : string.Empty;
    }
}