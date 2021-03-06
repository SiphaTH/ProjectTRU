using CalamityRuTranslate.Common;
using CalamityRuTranslate.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public abstract class CalamityCompatItem : GlobalItem
    {
        public override bool Autoload(ref string name) => ModsCall.Calamity != null && Translation.IsRussianLanguage;
    }
}