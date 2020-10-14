using Terraria.ModLoader;

namespace CalamityRuTranslate.ThoriumMod.Tiles
{
    internal class ThoriumChestName
    {
        public static void Setup()
        {
            ThoriumChest();
        }

        private static void ThoriumChest()
        {
            Mod thorium = ModLoader.GetMod("ThoriumMod");

            TileLoader.GetTile(thorium.TileType("AquaticDepthsBiomeChest")).chest = "Акватический глубинный сундук";
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
            TileLoader.GetTile(thorium.TileType("CursedChest")).chest = "Проклятый сундук";
            TileLoader.GetTile(thorium.TileType("NagaChest")).chest = "Нага-сундук";
            TileLoader.GetTile(thorium.TileType("ShadyChest")).chest = "Теневой сундук";
            TileLoader.GetTile(thorium.TileType("ValadiumChest")).chest = "Валадиумовый сундук";
            TileLoader.GetTile(thorium.TileType("FurnitureDresser")).dresser = "Комод";
        }
    }
}