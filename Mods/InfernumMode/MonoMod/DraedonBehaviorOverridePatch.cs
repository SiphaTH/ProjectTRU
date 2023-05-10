using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Draedon;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
 
public class DraedonBehaviorOverridePreAI : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DraedonBehaviorOverride).GetCachedMethod(nameof(DraedonBehaviorOverride.PreAI));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Now choose.", "Теперь выбирай.");
        TranslationHelper.ModifyIL(il, "Your efforts are very intriguing.", "Твои старания интригуют.");
        TranslationHelper.ModifyIL(il, "Go on. Continue feeding information to my machines.", "Ну же, продолжай скармливать моим машинам информацию.");
    };
}

public class DraedonBehaviorOverrideHandleDefeatStuff : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DraedonBehaviorOverride).GetCachedMethod(nameof(DraedonBehaviorOverride.HandleDefeatStuff));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Intriguing. Truly, intriguing.", "Интригующе. Очень интригующе.");
        TranslationHelper.ModifyIL(il, "You have been an excellent test subject.", "Ты оказался отличным подопытным.");
        TranslationHelper.ModifyIL(il, "My magnum opera, truly and utterly defeated.", "Мой венец творения полностью и абсолютно повержен.");
        TranslationHelper.ModifyIL(il, "The data I have acquired from your combat has been invaluable.", "Данные, полученные в ходе твоей битвы, были бесценны.");
        TranslationHelper.ModifyIL(il, "This outcome was not what I had expected.", "Это не тот исход, которого я ожидал.");
        TranslationHelper.ModifyIL(il, "...Perhaps, I may be able to grant you a reward for your time.", "...Возможно, я смогу вознаградить тебя за потраченное время.");
        TranslationHelper.ModifyIL(il, "...Excuse my introspection. I must gather my thoughts after that display.", "...Извиняюсь за внезапную интроспекцию. После полученных результатов я должен собраться с мыслями.");
        TranslationHelper.ModifyIL(il, "It is perhaps not irrational to infer that you are beyond my reasoning.", "Возможно, рациональнее будет сделать вывод, что ты находишься за пределами моей логики.");
        TranslationHelper.ModifyIL(il, "My most useful creation. I'm sure you will find some use for it.", "Моё самое полезное изобретение. Я уверен, ты найдёшь ему применение.");
        TranslationHelper.ModifyIL(il, "Now.", "Итак.");
        TranslationHelper.ModifyIL(il, "Use it wisely.", "Используй его с умом.");
        TranslationHelper.ModifyIL(il, "You would wish to reach the Tyrant. I cannot assist you in that.", "Ты хочешь добраться до самого Тирана. Не жди в этом деле моей помощи.");
        TranslationHelper.ModifyIL(il, "It is not a matter of spite, for I would wish nothing more than to observe such a conflict.", "Не подумай, я просто хочу посмотреть на подобное противостояние. Ничего более.");
        TranslationHelper.ModifyIL(il, "But now, I must return to my machinery. You may use the Codebreaker if you wish to face my creations once again.", "А теперь предпочту вернуться к своим механизмам. Можешь использовать Дешифратор, если хочешь вновь сразиться с моими творениями.");
        TranslationHelper.ModifyIL(il, "In the meantime, I bid you farewell, and good luck in your future endeavors.", "А пока я прощаюсь с тобой и желаю удачи во всех будущих начинаниях.");
    };
}