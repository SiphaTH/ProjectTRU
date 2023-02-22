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
        TranslationHelper.ModifyIL(il, "It would not be a stretch to call the jungle the hub of this planet. All is centered around it, and none know not of it. It brings me no small amount of unease to see the uncomfortable, raw forms of the living beings who pass through on their journeys above. Fortunately, these labs provide everything I need in my research and more. There is little need to visit the surface, save for Yharim’s summons.", "Не будет ошибкой называть джунгли центром этой планеты. Всё сосредоточено вокруг них, что известно немногим. Я испытываю немалое беспокойство, видя неудобные, грубые формы живых существ, которые живут в них на поверхности. К счастью, эти лаборатории обеспечивают всё, что мне нужно в моих исследованиях и не только. Нет никакой необходимости когда-либо посещать поверхность, за исключением вызова по приказу Ярима.");
        TranslationHelper.ModifyIL(il, "Continued experiments have led to significant results. With a mechanically modified Queen Bee as a primary host, it may act as the core of a hive mind of those my plague has touched. However, Yharim was outraged upon learning of my experiments here and decried them as inhumane. After a brief verbal conflict, he wordlessly left and I have not heard from him since. Fortunately, I need not rely on the slayer of gods any longer, nor have I needed to for years.", "");
        TranslationHelper.ModifyIL(il, "Few travel down here, with far fewer making the expedition to reach as far down as this research station. As such, I have taken to using this isolation to develop advanced nanotechnology for use in controlling the minds of biologicals. I yearn for it to be capable of spreading from organism to organism, a perfected blend of a virus and nanotechnology. Yet, it has been an arduous task even with my newly developed technologies. Further experimentation and research are required.", "");
    };
}