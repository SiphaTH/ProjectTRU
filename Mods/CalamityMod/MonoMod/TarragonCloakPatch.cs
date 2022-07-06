using System.Reflection;
using CalamityMod.Cooldowns;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class TarragonCloakPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(TarragonCloak).GetCachedMethod("get_DisplayName");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Tarragon Cloak Cooldown", "Перезарядка плаща таррагона");
    };
}