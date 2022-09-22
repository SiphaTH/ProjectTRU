using System.Reflection;
using CalamityMod.CalPlayer;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")] 
public class CalamityPlayerOnEnterWorld : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(CalamityPlayer).GetCachedMethod(nameof(CalamityPlayer.OnEnterWorld));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " [c/EE4939:Be sure to check out the Official Calamity Mod Wiki at ][c/3989FF:calamitymod.wiki.gg][c/EE4939:!] ", " [c/EE4939:Актуальную информацию вы можете посмотреть на официальной вики Каламити] [c/3989FF:calamitymod.wiki.gg][c/EE4939:!]");
    };
}
