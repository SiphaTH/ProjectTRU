using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.BehaviorOverrides.BossAIs.Draedon;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class DraedonBehaviorOverridePreAI : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DraedonBehaviorOverride).GetCachedMethod(nameof(DraedonBehaviorOverride.PreAI));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Now choose.", "");
        TranslationHelper.ModifyIL(il, "Your efforts are very intriguing.", "");
        TranslationHelper.ModifyIL(il, "Go on. Continue feeding information to my machines.", "");
    };
}

public class DraedonBehaviorOverrideHandleDefeatStuff : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DraedonBehaviorOverride).GetCachedMethod(nameof(DraedonBehaviorOverride.HandleDefeatStuff));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Intriguing. Truly, intriguing.", "");
        TranslationHelper.ModifyIL(il, "My magnum opera, truly and utterly defeated.", "");
        TranslationHelper.ModifyIL(il, "This outcome was not what I had expected.", "");
        TranslationHelper.ModifyIL(il, "...Excuse my introspection. I must gather my thoughts after that display.", "");
        TranslationHelper.ModifyIL(il, "It is perhaps not irrational to infer that you are beyond my reasoning.", "");
        TranslationHelper.ModifyIL(il, "Now.", "");
        TranslationHelper.ModifyIL(il, "You would wish to reach the Tyrant. I cannot assist you in that.", "");
        TranslationHelper.ModifyIL(il, "It is not a matter of spite, for I would wish nothing more than to observe such a conflict.", "");
        TranslationHelper.ModifyIL(il, "But now, I must return to my machinery. You may use the Codebreaker if you wish to face my creations once again.", "");
        TranslationHelper.ModifyIL(il, "In the meantime, I bid you farewell, and good luck in your future endeavors.", "");
    };
}