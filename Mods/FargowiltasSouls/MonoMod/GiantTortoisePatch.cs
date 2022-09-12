using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.EternityMode.Content.Enemy.Jungle;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod;

[JITWhenModsEnabled("FargowiltasSouls")]
public class GiantTortoisePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(GiantTortoise).GetCachedMethod(nameof(GiantTortoise.OnHitByItem));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " was impaled by a Giant Tortoise.", "");
    };
}