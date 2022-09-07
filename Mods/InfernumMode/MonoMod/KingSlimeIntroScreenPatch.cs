using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.BossIntroScreens;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class KingSlimeIntroScreenPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(KingSlimeIntroScreen).GetCachedMethod("get_TextToDisplay");

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Monarch of the Gelatinous\nKing Slime", "МОНАРХ ЖЕЛАТИНА\nКОРОЛЬ СЛИЗНЕЙ");
    };
}