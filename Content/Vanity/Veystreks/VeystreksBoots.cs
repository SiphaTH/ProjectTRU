using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Veystreks
{
    [AutoloadEquip(EquipType.Legs)]
    public class VeystreksBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Поножи Veystreks");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
    }
}