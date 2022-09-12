using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class DraedonSchematicHellGUIPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DraedonSchematicHellGUI).GetCachedMethod(nameof(DraedonSchematicHellGUI.GetTextByPage));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Only the highest ranking in the battalions of the Yharim's army held these weapons.\nHowever these are still not my most potent tools. Those...characters could not be trusted with them.\nAddendum: The final piece remains. Travel now from the hottest fire this land has to offer, to the most frigid cold. I cannot deny having some sense of poetic symmetry.", "Лишь высшие чины армии Ярима обладали столь смертоносным оружием.\nНо даже им я не мог доверить мои последние разработки. Этим... лицам не было доверия.\nДополнение: Осталось немного. Теперь же путешествуйте от самого жаркого огня, который может предложить эта земля, до самого лютого мороза. Не могу отрицать, у меня есть некоторое чувство поэтической симметрии.");
    };
}