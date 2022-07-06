using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.StepMolchX
{
    [AutoloadEquip(EquipType.Legs)]
    public class StepMolchXBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Штаны SPH");
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