using System;
using System.Linq;
using System.Reflection;
using CalamityMod;
using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.ExoMechs.Artemis;
using CalamityMod.UI;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class BossHealthBarManagerPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BossHealthBarManager.BossHPUI).GetCachedMethod(nameof(BossHealthBarManager.BossHPUI.Draw));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " left: ", " осталось: ");
    };
}

public class AttemptToAddBar : OnPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BossHealthBarManager).GetCachedMethod(nameof(BossHealthBarManager.AttemptToAddBar));

    private delegate void AttemptToAddBarDelegate(int index);

    public override Delegate Delegate => Translation;

    private void Translation(AttemptToAddBarDelegate orig, int index)
    {
        if (BossHealthBarManager.Bars.Count >= BossHealthBarManager.MaximumBars)
            return;
        
        NPC npc = Main.npc[index];
        bool flag = npc.active && npc.life > 0 && BossHealthBarManager.Bars.All((Func<BossHealthBarManager.BossHPUI, bool>) (b => b.NPCIndex != index)) && !npc.Calamity().ShouldCloseHPBar;
        string overridingName = null;
        
        if (npc.type == ModContent.NPCType<Artemis>())
            flag = false;
        
        if (npc.type == ModContent.NPCType<Apollo>())
            overridingName = "ВП-01 Артемида и ВП-03 Аполлон";
        
        if (!flag)
            return;
        
        BossHealthBarManager.Bars.Add(new BossHealthBarManager.BossHPUI(index, overridingName));
    }
}