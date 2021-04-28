using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public abstract class CalamityAutoLoad : GlobalItem
    {
        public override bool Autoload(ref string name) => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;
    }
}