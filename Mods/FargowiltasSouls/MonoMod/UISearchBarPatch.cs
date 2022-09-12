using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.UI;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod;

[JITWhenModsEnabled("FargowiltasSouls")]
public class UISearchBarPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodBase ModifiedMethod => typeof(UISearchBar).GetCachedMethod("DrawChildren");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Search...", "Поиск...");
    };
}