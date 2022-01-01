using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Sum
{
    [AutoloadEquip(EquipType.Head)]
    public class PrincessCrown : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Корона Sum");
            Tooltip.SetDefault("Парик принцессы");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 24;
            item.rare = 1;
            item.vanity = true;
        }
    }
}