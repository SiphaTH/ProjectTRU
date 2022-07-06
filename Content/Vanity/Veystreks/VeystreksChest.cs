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
            Item.width = 24;
            Item.height = 20;
            Item.rare = 1;
            Item.vanity = true;
        }
    }
}