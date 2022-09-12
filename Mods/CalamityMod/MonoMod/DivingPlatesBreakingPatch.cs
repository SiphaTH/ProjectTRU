using System.Reflection;
using CalamityMod.Cooldowns;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class DivingPlatesBreakingPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    public override MethodInfo ModifiedMethod => typeof(DivingPlatesBreaking).GetCachedMethod("get_DisplayName");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Abyssal Diving Suit Plates Durability", "Прочность пластин глубоководного водолазного костюма");
    };
}