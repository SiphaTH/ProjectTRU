using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode;
using InfernumMode.Content.BehaviorOverrides.BossAIs.DoG;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class DoGPhase1HeadBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DoGPhase1HeadBehaviorOverride).GetCachedMethod(nameof(DoGPhase1HeadBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(DoGPhase1HeadBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, DoGPhase1HeadBehaviorOverride self)
    {
        yield return n =>
        {
            if (!Main.LocalPlayer.HasDash())
                return "Знаешь, аксессуар, дающий рывки, был тут пипец полезен...";
            return !Main.LocalPlayer.HasShieldBash() ? "Возможность врезать ему в голову с помощью тарана звучит неплохо, не находишь?" : string.Empty;
        };
    }
}