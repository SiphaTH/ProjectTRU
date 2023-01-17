using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Draedon.ArtemisAndApollo;
using MonoMod.Cil;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class ApolloBehaviorOverrideDoBehavior_ThemonuclearBlitz : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ApolloBehaviorOverride).GetCachedMethod(nameof(ApolloBehaviorOverride.DoBehavior_ThemonuclearBlitz));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "ARTEMIS-01: COMBINED ENERGY RESERVES AT LOW CAPACITY. SYSTEM FAILURE IMMINENT.", "АРТЕМИДА-01: РЕЗЕРВЫ КОМБИНИРОВАННОЙ ЭНЕРГИИ НА НИЗКОЙ МОЩНОСТИ. ОТКАЗ СИСТЕМЫ НЕИЗБЕЖЕН.");
        TranslationHelper.ModifyIL(il, "APOLLO-03: PREPARING 'THERMONUCLEAR BLITZ' MUTUAL DESTRUCTION PROTOCOL.", "АПОЛЛОН-03: ПОДГОТОВКА ПРОТОКОЛА ОБОЮДНОГО УНИЧТОЖЕНИЯ 'ТЕРМОЯДЕРНЫЙ ВЗРЫВ'.");
    };
}

public class ApolloBehaviorOverrideGetTips : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ApolloBehaviorOverride).GetCachedMethod(nameof(ApolloBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(ApolloBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, ApolloBehaviorOverride self)
    {
        yield return n => "Экзо-близнецы великолепно синхронизированы, попробуй понять ритм и перехитрить их!";
    }
}