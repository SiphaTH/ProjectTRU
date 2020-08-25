using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ThoriumMod.Tiles
{
    public class ThoriumChestName : GlobalTile
    {
        public override void SetDefaults()
        {
            Mod thorium = ModLoader.GetMod("ThoriumMod");
            if (thorium != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                TileLoader.GetTile(thorium.TileType("AquaticDepthsBiomeChest")).chest = "Акватический глубоководный сундук";
                TileLoader.GetTile(thorium.TileType("DepthChestTile")).chest = "Глубинный сундук";
                TileLoader.GetTile(thorium.TileType("DesertBiomeChest")).chest = "Пустынный сундук";
                TileLoader.GetTile(thorium.TileType("LodestoneChest")).chest = "Магнетитовый сундук";
                TileLoader.GetTile(thorium.TileType("MarineChest")).chest = "Морской сундук";
                TileLoader.GetTile(thorium.TileType("PermafrostChest")).chest = "Сундук вечной мерзлоты";
                TileLoader.GetTile(thorium.TileType("PlateChest")).chest = "Пластинчатый сундук";
                TileLoader.GetTile(thorium.TileType("ScarletChest")).chest = "Кровавый сундук";
                TileLoader.GetTile(thorium.TileType("ThoriumChest")).chest = "Ториевый сундук";
                TileLoader.GetTile(thorium.TileType("UnderworldChest")).chest = "Адский сундук";
                TileLoader.GetTile(thorium.TileType("YewChest")).chest = "Тисовый сундук";
                TileLoader.GetTile(thorium.TileType("OrnateChest")).chest = "Изысканный сундук";
                TileLoader.GetTile(thorium.TileType("FurnitureDresser")).dresser = "Комод";
            }
        }
    }
}