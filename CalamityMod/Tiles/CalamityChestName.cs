using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Tiles
{
    internal static class CalamityChestName
    {
	    public static void Setup()
        {
            CalamityChest();
        }

        private static void CalamityChest()
        {
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("AstralChestLocked")).chest = "Астральный сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("AbyssChest")).chest = "Сундук бездны";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("AshenChest")).chest = "Пепельный сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("BotanicChest")).chest = "Ботанический сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("CosmiliteChest")).chest = "Космилитовый сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("EutrophicChest")).chest = "Эвтрофный сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("OccultChest")).chest = "Потусторонний сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("PlaguedPlateChest")).chest = "Чумной сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("ProfanedChest")).chest = "Осквернённый сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("SilvaChest")).chest = "Лесной сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("StatigelChest")).chest = "Статиджеловый сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("StratusChest")).chest = "Слоистый сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("VoidChest")).chest = "Пустотный сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("MonolithChest")).chest = "Монолитный сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("RustyChestTile")).chest = "Ржавый сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("AgedSecurityChestTile")).chest = "Старый охранный сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("SecurityChestTile")).chest = "Охранный сундук";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("AbyssDresser")).dresser = "Комод бездны";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("AncientDresser")).dresser = "Древний комод";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("AshenDresser")).dresser = "Пепельный комод";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("BotanicDresser")).dresser = "Ботанический комод";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("CosmiliteDresser")).dresser = "Космилитовый комод";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("EutrophicDresser")).dresser = "Эвтрофный комод";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("MonolithDresser")).dresser = "Монолитный комод";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("OccultDresser")).dresser = "Потусторонний комод";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("PlaguedPlateDresser")).dresser = "Чумной комод";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("ProfanedDresser")).dresser = "Осквернённый комод";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("SilvaDresser")).dresser = "Лесной комод";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("StatigelDresser")).dresser = "Статиджеловый комод";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("StratusDresser")).dresser = "Слоистый комод";
	        TileLoader.GetTile(ModCompatibility.CalamityMod.TileType("VoidDresser")).dresser = "Пустотный комод";
        }
    }
}