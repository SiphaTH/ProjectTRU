using System.Reflection;
using CalamityMod.Items.VanillaArmorChanges;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class AdamantiteArmorSetChangePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(AdamantiteArmorSetChange).GetCachedMethod(nameof(AdamantiteArmorSetChange.UpdateSetBonusText));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "\nHalf of your current DR is added to your critical strike chance\n", "\nПоловина вашего текущего сопротивления урону добавляется к шансу критического удара\n");
            TranslationHelper.ILTranslation(il, "Continuously doing damage makes you gradually gain more and more defense, up to a maximum of {0}\n", "Непрерывно нанося урон, вы постепенно получаете всё больше и больше защиты, вплоть до {0}\n");
            TranslationHelper.ILTranslation(il, "When not doing damage, this bonus gradually decays\nThis added defense can be broken by defense damage", "При бездействии, этот бонус постепенно убывает\nЭта дополнительная защита может быть снижена уроном по защите");
        }
    }
}