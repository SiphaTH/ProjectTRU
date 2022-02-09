using CalamityRuTranslate.Core.GlobalModifications;
using CalamityRuTranslate.Core.ModCompatibility;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public abstract class CalamityGlobalItemBase : ModifyGlobalItem
    {
    }
}