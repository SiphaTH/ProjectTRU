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
            Item.width = 22;
            Item.height = 24;
            Item.rare = 1;
            Item.vanity = true;
        }
    }
}