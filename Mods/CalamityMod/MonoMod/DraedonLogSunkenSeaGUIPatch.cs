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
        TranslationHelper.ModifyIL(il, "A hub of diverse ocean life, and all that remains of Ilmeris that is unscorched. Once its rural outskirts, it is now the final fragment of a once powerful kingdom. It is fortunate that the Witch only focused on attacking the cities proper, and spared some amount of the sea from the Incineration. I have long yearned to research these waters in great depth, yet was never able due to the ongoing conflict. Although many species went extinct in the devastation, many still thrive down here in its depths. It is in this lab that I may finally study the aquatic life properly and learn of their nature.", "");
        TranslationHelper.ModifyIL(il, "Although the marine life in these caves do have eyes, some of their eyes are weak and process few colors. All they are made to see is the light of the sea prisms that surround them, with many creatures relying on them to guide their way through the submerged caverns. Their tough, gnarled hides possess crystal growths that I had originally assumed were the prisms settling on their backs. However, dissection results reveal that they instead possess these crystals internally, and the growths are a result of internal sea prisms bursting out of their hides. The growth of these crystals reaches such an extent that some creatures are more geological than biological in certain areas.", "");
        TranslationHelper.ModifyIL(il, "Of the specimens here, the abnormally large clams capture my interest the most. Many times larger than the average person, their weight is so great that they lack the ability to move via the same methods as their smaller counterparts. Instead, they rely on teleportation to transport their hulking, heavily armored bodies. They seem to have once possessed further magical powers according to scouts. However, as they were seen only from afar, their reports could have easily been mistaken. Alternatively, their source of power simply could have faded after Ilmeris’ downfall. It is unwise to entirely discount the latter possibility.", "");
    };
}