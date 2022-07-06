using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Veystreks
{
    [AutoloadEquip(EquipType.Head)]
    public class VeystreksScarf : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Налицовник Veystreks");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}");
        }
        
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 24;
            Item.rare = 1;
            Item.vanity = true;
        }
    }
}