using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.StepMolchX
{
    [AutoloadEquip(EquipType.Head)]
    public class StepMolchXHood : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Капюшон SPH");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}");
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 22;
            Item.rare = 1;
            Item.vanity = true;
        }
    }
}