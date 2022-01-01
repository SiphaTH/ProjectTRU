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
            item.width = 30;
            item.height = 26;
            item.rare = 1;
            item.vanity = true;
        }
    }
}