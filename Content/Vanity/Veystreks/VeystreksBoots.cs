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
            Item.width = 22;
            Item.height = 18;
            Item.rare = 1;
            Item.vanity = true;
        }
    }
}