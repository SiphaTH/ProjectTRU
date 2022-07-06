using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Sum
{
    [AutoloadEquip(EquipType.Legs)]
    public class PrincessBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Каблуки Sum");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 12;
            Item.rare = 1;
            Item.vanity = true;
        }
    }
}