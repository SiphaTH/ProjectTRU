using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Draedon.Ares;
using MonoMod.Cil;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class AresBodyBehaviorOverrideDoBehavior_PrecisionBlasts : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(AresBodyBehaviorOverride).GetCachedMethod(nameof(AresBodyBehaviorOverride.DoBehavior_PrecisionBlasts));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "ARES-09: CORE TEMPERATURES RAPIDLY INCREASING. SELF DESTRUCTION IMMINENT.", "АРЕС-09: ТЕМПЕРАТУРА ЯДРА БЫСТРО РАСТЁТ. САМОУНИЧТОЖЕНИЕ НЕИЗБЕЖНО.");
        TranslationHelper.ModifyIL(il, "ARES-09: PREPARING 'PRECISION GAMMA-BLASTS' MUTUAL DESTRUCTION PROTOCOL.", "АРЕС-09: ПОДГОТОВКА ПРОТОКОЛА ОБОЮДНОГО УНИЧТОЖЕНИЯ 'ВЫСОКОТОЧНЫЕ ГАММА-ВЗРЫВЫ'.");
        TranslationHelper.ModifyIL(il, "You have made a grave miscalculation.", "Ты серьёзно просчитался.");
    };
}

public class AresBodyBehaviorOverrideGetTips : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(AresBodyBehaviorOverride).GetCachedMethod(nameof(AresBodyBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(AresBodyBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, AresBodyBehaviorOverride self)
    {
        yield return n => "Лучше всего держаться поближе во время атак экзо-перегрузки, иначе могут возникнуть проблемы с поддержанием вращения!";
        yield return n => "Арес обладает чертовски крутым суперкомпьютером, из-за этого его руки предугадывают движения! Может, ты сможешь использовать это себе на руку?";
    }
}