using System.Reflection;
using CalamityMod.Items;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class CalamityGlobalItemPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CalamityGlobalItem).GetCachedMethod("<ModifyVanillaTooltips>g__HookStatsTooltip|87_141");

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Reach: ", "Дальность: ");
        TranslationHelper.ModifyIL(il, " tiles\n", " блоков\n");
        TranslationHelper.ModifyIL(il, "Launch Velocity: ", "Скорость вылета: ");
        TranslationHelper.ModifyIL(il, "Reelback Velocity: ", "Скорость возврата: ");
        TranslationHelper.ModifyIL(il, "Pull Velocity: ", "Скорость притягивания: ");
    };
}