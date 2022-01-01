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
            item.width = 30;
            item.height = 12;
            item.rare = 1;
            item.vanity = true;
        }
    }
}