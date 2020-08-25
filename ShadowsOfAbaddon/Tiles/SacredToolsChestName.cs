using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ShadowsOfAbaddon.Tiles
{
    public class SacredToolsChestName : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            Mod sacredTools = ModLoader.GetMod("SacredTools");
            if (sacredTools != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                TileLoader.GetTile(sacredTools.TileType("FlareChest")).chest = "Сундук яркого пламени";
                TileLoader.GetTile(sacredTools.TileType("FlariumDresser")).chest = "Комод яркого пламени";
                TileLoader.GetTile(sacredTools.TileType("LunarCrate")).chest = "Лунное хранилище";
                TileLoader.GetTile(sacredTools.TileType("AsthralChestTile")).chest = "Азралтитовый сундук";
                TileLoader.GetTile(sacredTools.TileType("AsthralDresser")).chest = "Азралтитовый комод";
                TileLoader.GetTile(sacredTools.TileType("WeaverChest")).chest = "Ткацкий комод";
            }
        }
    }
}