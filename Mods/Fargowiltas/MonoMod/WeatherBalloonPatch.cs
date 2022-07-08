using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons.Abom;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class WeatherBalloonPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(WeatherBalloon).GetCachedMethod(nameof(WeatherBalloon.UseItem));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Rain clouds cover the sky.", "Тучи закрывают небо.");
    };
}