using System.Reflection;
using CalamityMod.UI.DraedonLogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class DraedonLogSunkenSeaGUIPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(DraedonLogSunkenSeaGUI).GetCachedMethod(nameof(DraedonLogSunkenSeaGUI.GetTextByPage));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "A hub of diverse ocean life, and all that remains of Ilmeris that is unscorched. Once its rural outskirts, it is now the final fragment of a once powerful kingdom. It is fortunate that the Witch only focused on attacking the cities proper, and spared some amount of the sea from the Incineration. I have long yearned to research these waters in great depth, yet was never able due to the ongoing conflict. Although many species went extinct in the devastation, many still thrive down here in its depths. It is in this lab that I may finally study the aquatic life properly and learn of their nature.", "Оазис разнообразной морской жизни и единственный уцелевший фрагмент некогда могущественного королевства Ильмерис. Хорошо, что Ведьма сфокусировалась на атаке городов и сохранила некоторую часть моря от испепеления. Я всегда мечтал изучать глубины моря, но война мешала мне. Несмотря на множество исчезнувших видов, в этих глубинах все ещё обитают удивительные существа. Именно здесь, в моей лаборатории, я смогу изучить морские формы жизни и раскрыть секреты их природы.");
        TranslationHelper.ModifyIL(il, "Although the marine life in these caves do have eyes, some of their eyes are weak and process few colors. All they are made to see is the light of the sea prisms that surround them, with many creatures relying on them to guide their way through the submerged caverns. Their tough, gnarled hides possess crystal growths that I had originally assumed were the prisms settling on their backs. However, dissection results reveal that they instead possess these crystals internally, and the growths are a result of internal sea prisms bursting out of their hides. The growth of these crystals reaches such an extent that some creatures are more geological than biological in certain areas.", "Несмотря на наличие глаз у морской жизни в этих пещерах, некоторые из них способны обрабатывать лишь ограниченный спектр цветов. Их глаза настроены на восприятие света от морских призм, окружающих их среду, и многие из них полагаются на это, чтобы ориентироваться в затопленных пещерах. Их прочная, изрытая шрамами кожа покрыта кристаллическими наростами, которые я сначала принял за морские призмы, осевшие на их спинах. Однако результаты вскрытия показали, что эти кристаллы расположены внутри них, а наросты являются результатом прорыва внутренних морских призм из их кожи. Эти кристаллы разрастаются настолько быстро, что некоторые существа в определённых местах больше напоминают геологические образования, нежели живые организмы.");
        TranslationHelper.ModifyIL(il, "Of the specimens here, the abnormally large clams capture my interest the most. Many times larger than the average person, their weight is so great that they lack the ability to move via the same methods as their smaller counterparts. Instead, they rely on teleportation to transport their hulking, heavily armored bodies. They seem to have once possessed further magical powers according to scouts. However, as they were seen only from afar, their reports could have easily been mistaken. Alternatively, their source of power simply could have faded after Ilmeris’ downfall. It is unwise to entirely discount the latter possibility.", "Наибольший интерес для меня представляют аномально крупные моллюски, обитающие здесь. Они многократно превосходят в размерах обычного человека и настолько тяжелы, что не способны передвигаться привычным способом, как их меньшие сородичи. Вместо этого они полагаются на телепортацию для переноса своих массивных, бронированных тел. Согласно сведениям разведчиков, раньше эти моллюски обладали более высокими магическими способностями. Однако, так как их видели только издалека, их сведения могут быть неточными. А что, если их магические способности просто исчезли после падения Ильмериса? В любом случае, мне не следует исключать даже такую возможность.");
    };
}