using System.Reflection;
using CalamityMod.Projectiles.Summon.SmallAresArms;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class ExoskeletonPanelPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodBase ModifiedMethod => typeof(ExoskeletonPanel).GetCachedMethod(nameof(ExoskeletonPanel.PreDraw));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Insufficient minion slots!", "Недостаточно слотов призываемых миньонов!");
    };
}