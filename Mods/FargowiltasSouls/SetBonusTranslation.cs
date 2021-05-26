using System.Linq;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls
{
    public class SetBonusTranslation : GlobalItem
    {
        public override bool Autoload(ref string name) => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override string IsArmorSet(Item head, Item body, Item legs) => ArmorSetBonusLoader.FargoSoulsArmorSets
            .Where(set => set.CheckArmorSet(head.type, body.type, legs.type)).Select(info => info.ToString()).FirstOrDefault();

        public override void UpdateArmorSet(Player player, string set) => player.setBonus = GlobalArmorSetBonus.GetFargoSoulsArmorSetBonusByName(set);
    }
}