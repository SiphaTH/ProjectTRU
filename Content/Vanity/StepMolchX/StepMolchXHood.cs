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
            item.width = 22;
            item.height = 22;
            item.rare = 1;
            item.vanity = true;
        }
    }
}