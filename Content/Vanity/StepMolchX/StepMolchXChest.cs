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
            item.width = 34;
            item.height = 28;
            item.rare = 1;
            item.vanity = true;
        }
    }
}