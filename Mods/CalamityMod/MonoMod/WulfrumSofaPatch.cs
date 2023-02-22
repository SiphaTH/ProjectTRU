using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class WulfrumSofaPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(global::CalamityMod.Tiles.FurnitureWulfrum.WulfrumSofa).GetCachedMethod(nameof(global::CalamityMod.Tiles.FurnitureWulfrum.WulfrumSofa.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}