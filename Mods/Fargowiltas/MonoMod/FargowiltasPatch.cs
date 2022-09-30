using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using MonoMod.Cil;
using Terraria;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

public class FargowiltasTryClearEvents : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(global::Fargowiltas.Fargowiltas).GetCachedMethod("TryClearEvents");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The invaders have left!", "Вторженцы уходят!");
        TranslationHelper.ModifyIL(il, "The Pumpkin Moon is lowering...", "Заходит тыквенная луна...");
        TranslationHelper.ModifyIL(il, "The Frost Moon is lowering...", "Заходит морозная луна...");
        TranslationHelper.ModifyIL(il, "A solar eclipse is not happening!", "Солнечное затмение не происходит!");
        TranslationHelper.ModifyIL(il, "The blood moon is descending...", "Кровавая луна опускается за горизонт...");
        TranslationHelper.ModifyIL(il, "The wind has ended!", "Ветер закончился!");
        TranslationHelper.ModifyIL(il, "The Old One's Army is leaving!", "Армия Древних уходит!");
        TranslationHelper.ModifyIL(il, "The sandstorm has ended!", "Песчаная буря закончилась!");
        TranslationHelper.ModifyIL(il, "Celestial creatures are not invading!", "Неземные сущности не атакуют!");
        TranslationHelper.ModifyIL(il, "The rain has ended!", "Дождь закончился!");
    };
}

public class FargowiltasSpawnBoss : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(global::Fargowiltas.Fargowiltas).GetMethod("SpawnBoss", BindingFlags.Static | BindingFlags.NonPublic, new []{typeof(Player), typeof(int), typeof(bool), typeof(Vector2), typeof(string), typeof(bool)});

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " have awoken!", " пробуждается!");
        TranslationHelper.ModifyIL(il, " have awoken!", " пробуждается!", 2);
    };
}