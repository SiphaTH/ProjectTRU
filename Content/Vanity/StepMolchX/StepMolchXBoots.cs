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
            item.width = 22;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
    }
}