using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Veystreks
{
    [AutoloadEquip(EquipType.Body)]
    public class VeystreksChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Нагрудник Veystreks");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 20;
            item.rare = 1;
            item.vanity = true;
        }
    }
}