using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using MonoMod.Cil;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class FargowiltasTryClearEvents : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(global::Fargowiltas.Fargowiltas).GetCachedMethod("TryClearEvents");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The invaders have left!", "");
        TranslationHelper.ModifyIL(il, "The Pumpkin Moon is lowering...", "");
        TranslationHelper.ModifyIL(il, "The Frost Moon is lowering...", "");
        TranslationHelper.ModifyIL(il, "A solar eclipse is not happening!", "");
        TranslationHelper.ModifyIL(il, "The blood moon is descending...", "");
        TranslationHelper.ModifyIL(il, "The wind has ended!", "");
        TranslationHelper.ModifyIL(il, "The Old One's Army is leaving!", "");
        TranslationHelper.ModifyIL(il, "The sandstorm has ended!", "");
        TranslationHelper.ModifyIL(il, "Celestial creatures are not invading!", "");
        TranslationHelper.ModifyIL(il, "The rain has ended!", "");
    };
}

[JITWhenModsEnabled("Fargowiltas")]
public class FargowiltasSpawnBoss : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(global::Fargowiltas.Fargowiltas).GetMethod("SpawnBoss", BindingFlags.Static | BindingFlags.NonPublic, new []{typeof(Player), typeof(int), typeof(bool), typeof(Vector2), typeof(string), typeof(bool)});

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " have awoken!", " пробудился!");
        TranslationHelper.ModifyIL(il, " have awoken!", " пробудился!", 2);
    };
}