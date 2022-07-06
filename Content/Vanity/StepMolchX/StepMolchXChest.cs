using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.StepMolchX
{
    [AutoloadEquip(EquipType.Body)]
    public class StepMolchXChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Нагрудник SPH");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}");
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 28;
            Item.rare = 1;
            Item.vanity = true;
        }
    }
}