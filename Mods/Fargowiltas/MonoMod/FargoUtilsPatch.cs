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
public class FargoUtilsPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModsCall.Fargo.Code.GetType("Fargowiltas.FargoUtils")?.GetMethod("TryDowned", BindingFlags.Public | BindingFlags.Static, new []{typeof(NPC), typeof(string), typeof(Color), typeof(bool), typeof(string[])});

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "A new item has been unlocked in ", "Новый предмет был разблокирован в магазине ");
        TranslationHelper.ModifyIL(il, "'s shop!", "!");
    };
}