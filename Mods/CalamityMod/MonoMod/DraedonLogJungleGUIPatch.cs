using System.Reflection;
using CalamityMod.UI.DraedonLogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class DraedonLogJungleGUIPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(DraedonLogJungleGUI).GetCachedMethod(nameof(DraedonLogJungleGUI.GetTextByPage));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "It would not be a stretch to call the jungle the hub of this planet. All is centered around it, and none know not of it. It brings me no small amount of unease to see the uncomfortable, raw forms of the living beings who pass through on their journeys above. Fortunately, these labs provide everything I need in my research and more. There is little need to visit the surface, save for Yharim’s summons.", "Это не преувеличение, когда говорят, что джунгли - центр планеты. Всё сосредоточено вокруг них, и нет никого, кто бы не знал об этом. Я испытываю немалое беспокойство, наблюдая за неудобными, грубыми формами живых существ, проходящих на поверхности. Здесь, в этих лабораториях, у меня есть всё необходимое для моих исследований, и даже больше. Нет никакой необходимости посещать поверхность, за исключением вызова по приказу Ярима.");
        TranslationHelper.ModifyIL(il, "Continued experiments have led to significant results. With a mechanically modified Queen Bee as a primary host, it may act as the core of a hive mind of those my plague has touched. However, Yharim was outraged upon learning of my experiments here and decried them as inhumane. After a brief verbal conflict, he wordlessly left and I have not heard from him since. Fortunately, I need not rely on the slayer of gods any longer, nor have I needed to for years.", "Мои продолжительные эксперименты привели к значительным результатам. Механически модифицированная королева пчёл в качестве главного носителя может служить ядром сознания для всех, кого поразила моя чума. Однако, узнав о моих экспериментах, Ярим был возмущён и осудил их как бесчеловечные. После короткой словесной перепалки он молча ушёл, и с тех пор я ничего о нём не слышал. Слава богу, я больше не вынужден полагаться на убийцу богов и не нуждаюсь в нём уже много лет.");
        TranslationHelper.ModifyIL(il, "Few travel down here, with far fewer making the expedition to reach as far down as this research station. As such, I have taken to using this isolation to develop advanced nanotechnology for use in controlling the minds of biologicals. I yearn for it to be capable of spreading from organism to organism, a perfected blend of a virus and nanotechnology. Yet, it has been an arduous task even with my newly developed technologies. Further experimentation and research are required.", "Только самые отважные рискуют спуститься на такую глубину, и далеко не все достигают моей исследовательской базы. Используя это безлюдное место, я начал разрабатывать передовую нанотехнологию для контроля за разумом биологических существ. Я стремлюсь к тому, чтобы она могла распространяться от организма к организму, представляя собой идеальное сочетание вируса и нанотехнологии. Но даже с использованием моих новейших разработок это сложная задача. Поэтому мне необходимо проводить дополнительные исследования и эксперименты.");
    };
}