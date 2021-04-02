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
            item.width = 20;
            item.height = 24;
            item.rare = 1;
            item.vanity = true;
        }
    }
}