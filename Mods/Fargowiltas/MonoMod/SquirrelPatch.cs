using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.NPCs;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class SquirrelPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(Squirrel).GetCachedMethod(nameof(Squirrel.SetChatButtons));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Cycle Shop", "Циклический магазин");
        }
    }
}