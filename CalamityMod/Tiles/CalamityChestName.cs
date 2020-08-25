using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Tiles
{
    internal class CalamityChestName
    {
	    public static void Setup()
        {
            CalamityChest();
        }

        private static void CalamityChest()
        { 
	        Mod calamity = ModLoader.GetMod("CalamityMod");

	        TileLoader.GetTile(calamity.TileType("AstralChestLocked")).chest = "Астральный сундук";
	        TileLoader.GetTile(calamity.TileType("AbyssChest")).chest = "Сундук бездны";
	        TileLoader.GetTile(calamity.TileType("AshenChest")).chest = "Пепельный сундук";
	        TileLoader.GetTile(calamity.TileType("BotanicChest")).chest = "Ботанический сундук";
	        TileLoader.GetTile(calamity.TileType("CosmiliteChest")).chest = "Космилитовый сундук";
	        TileLoader.GetTile(calamity.TileType("EutrophicChest")).chest = "Эвтрофный сундук";
	        TileLoader.GetTile(calamity.TileType("OccultChest")).chest = "Потусторонний сундук";
	        TileLoader.GetTile(calamity.TileType("PlaguedPlateChest")).chest = "Чумной сундук";
	        TileLoader.GetTile(calamity.TileType("ProfanedChest")).chest = "Осквернённый сундук";
	        TileLoader.GetTile(calamity.TileType("SilvaChest")).chest = "Лесной сундук";
	        TileLoader.GetTile(calamity.TileType("StatigelChest")).chest = "Статиджеловый сундук";
	        TileLoader.GetTile(calamity.TileType("StratusChest")).chest = "Слоистый сундук";
	        TileLoader.GetTile(calamity.TileType("VoidChest")).chest = "Пустотный сундук";
	        TileLoader.GetTile(calamity.TileType("MonolithChest")).chest = "Монолитный сундук";
	        TileLoader.GetTile(calamity.TileType("RustyChestTile")).chest = "Ржавый сундук";
	        TileLoader.GetTile(calamity.TileType("AgedSecurityChestTile")).chest = "Старый охранный сундук";
	        TileLoader.GetTile(calamity.TileType("SecurityChestTile")).chest = "Охранный сундук";
	        TileLoader.GetTile(calamity.TileType("AbyssDresser")).dresser = "Комод бездны";
	        TileLoader.GetTile(calamity.TileType("AncientDresser")).dresser = "Древний комод";
	        TileLoader.GetTile(calamity.TileType("AshenDresser")).dresser = "Пепельный комод";
	        TileLoader.GetTile(calamity.TileType("BotanicDresser")).dresser = "Ботанический комод";
	        TileLoader.GetTile(calamity.TileType("CosmiliteDresser")).dresser = "Космилитовый комод";
	        TileLoader.GetTile(calamity.TileType("EutrophicDresser")).dresser = "Эвтрофный комод";
	        TileLoader.GetTile(calamity.TileType("MonolithDresser")).dresser = "Монолитный комод";
	        TileLoader.GetTile(calamity.TileType("OccultDresser")).dresser = "Потусторонний комод";
	        TileLoader.GetTile(calamity.TileType("PlaguedPlateDresser")).dresser = "Чумной комод";
	        TileLoader.GetTile(calamity.TileType("ProfanedDresser")).dresser = "Осквернённый комод";
	        TileLoader.GetTile(calamity.TileType("SilvaDresser")).dresser = "Лесной комод";
	        TileLoader.GetTile(calamity.TileType("StatigelDresser")).dresser = "Статиджеловый комод";
	        TileLoader.GetTile(calamity.TileType("StratusDresser")).dresser = "Слоистый комод";
	        TileLoader.GetTile(calamity.TileType("VoidDresser")).dresser = "Пустотный комод";
        }
    }
}