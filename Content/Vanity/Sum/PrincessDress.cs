using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Sum
{
    [AutoloadEquip(EquipType.Body)]
    public class PrincessDress : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Платье Sum");
            Tooltip.SetDefault("Грязное платье грязной принцессы");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 26;
            Item.rare = 1;
            Item.vanity = true;
        }
    }
}