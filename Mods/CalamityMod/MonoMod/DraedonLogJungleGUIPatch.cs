using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class DraedonLogJungleGUIPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(DraedonLogJungleGUI).GetCachedMethod(nameof(DraedonLogJungleGUI.GetTextByPage));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "As I record this, it would not be a stretch to call the jungle the hub of this planet. All is centered around it, and none know not of it. It brings me no small amount of unease to see the uncomfortable, raw forms of the living beings who pass through on their journeys above. Fortunately these labs provide everything I need in my research and more. There is no need to ever visit the surface, save for summons on the Lord's orders.", "Во время создания записи не будет ошибкой называть джунгли центром этой планеты. Всё сосредоточено вокруг них, что известно немногим. Я испытываю немалое беспокойство, видя неудобные, грубые формы живых существ, которые живут в них на поверхности. К счастью, эти лаборатории обеспечивают всё, что мне нужно в моих исследованиях и не только. Нет никакой необходимости когда-либо посещать поверхность, за исключением вызова по приказу Лорда.");
        TranslationHelper.ModifyIL(il, "Mechanically augmented, the Queen Bee which I had prior experimented on was theoretically a perfect host for the plague virus. When the first sign of the technology bonding with the creature began however, the problems also showed immediately. The mind of the insect fought the control of the nanotechnology, nothing like the simpler creatures I had used as test subjects. It grew increasingly violent, and only once subdued did it receive simple orders. However, if we were to utilize it at all, there is no other way than to let it roam free entirely. I will consider this further.", "Механически аугментированная королева пчёл, над которой я ранее экспериментировал, теоретически была идеальным разносчиком чумы. Однако, когда технологии начали менять сущность пчелы, начались проблемы. Разум насекомого противостоял нанотехнологиям, чего раньше не происходило. Она выросла невероятно жестокой и почти неуправляемой. И если мы хотим её хоть как-то использовать, то не остаётся никакого иного выхода, кроме как отпустить её в недра джунглей. Я подумаю над этим.");
        TranslationHelper.ModifyIL(il, "A virus, capable of devouring and converting almost anything. And nanotechnology, constructed painstakingly for the sake of control. Development was swift, and every piece fell into place almost eerily, forming an abhorrent existence. I struggle to think of practical applications which would be friendly to common life forms. However, it is not a major concern. Many were hesitant to continue its creation, but I granted them leave if they desired. I would have no need for any who were not entirely as dedicated as my machines.", "Вирус, способный пожирать и преобразовывать практически всё, а также тщательно сделанная нанотехнология контроля. Её развитие шло взрывным темпом, в следствие образуя мерзких созданий. Я изо всех сил старался, чтобы она была дружелюбна к обычным формам жизни. Но не это было главной проблемой. Многие не решались продолжать разработку - им было дозволено уйти, если они того пожелают. Мне не нужен никто, кто не предан делу также, как мои машины.");
    };
}