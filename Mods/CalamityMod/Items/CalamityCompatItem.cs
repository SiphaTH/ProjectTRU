using CalamityRuTranslate.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.Items
{
    public abstract class CalamityCompatItem : GlobalItem
    {
        public override bool Autoload(ref string name) => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
    }
}