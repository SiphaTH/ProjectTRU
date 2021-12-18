using System.Reflection;
using CalamityMod.Items.Accessories;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class CheatTestThingPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(CheatTestThing).GetCachedMethod(nameof(CheatTestThing.UpdateAccessory));
        
        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " isn't worthy.", " не достоин.");
        }
    }
}