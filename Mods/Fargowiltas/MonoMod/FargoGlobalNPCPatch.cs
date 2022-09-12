using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.NPCs;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class FargoGlobalNPCCheckDead : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FargoGlobalNPC).GetCachedMethod(nameof(FargoGlobalNPC.CheckDead));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт");
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 2);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 3);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 4);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 5);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 6);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 7);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 8);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 9);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 10);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 11);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 12);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 13);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 14);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 15);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 16);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 17);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 18);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 19);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 20);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 21);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 22);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 23);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 24);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 25);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 26);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 27);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 28);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 29);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 30);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 31);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 32);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 33);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 34);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 35);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 36);
        TranslationHelper.ModifyIL(il, "Deviantt", "Девиантт", 37);
        TranslationHelper.ModifyIL(il, "Abominationn", "Мерзостти");
        TranslationHelper.ModifyIL(il, "Abominationn", "Мерзостти", 2);
        TranslationHelper.ModifyIL(il, "Abominationn", "Мерзостти", 3);
        TranslationHelper.ModifyIL(il, "Abominationn", "Мерзостти", 4);
        TranslationHelper.ModifyIL(il, "Betsy has been defeated!", "Бэтси побеждена!");
    };
}

[JITWhenModsEnabled("Fargowiltas")]
public class FargoGlobalNPCSwarm : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FargoGlobalNPC).GetCachedMethod("Swarm");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Killed: ", "Убито: ");
        TranslationHelper.ModifyIL(il, "Killed: ", "Убито: ", 2);
        TranslationHelper.ModifyIL(il, "Total: ", "Всего: ");
        TranslationHelper.ModifyIL(il, "Total: ", "Всего: ", 2);
        TranslationHelper.ModifyIL(il, "The swarm has been defeated!", "Орда побеждена!");
        TranslationHelper.ModifyIL(il, "The swarm has been defeated!", "Орда побеждена!", 2);
    };
}