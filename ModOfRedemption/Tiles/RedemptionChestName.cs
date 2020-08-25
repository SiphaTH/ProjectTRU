using Terraria.ModLoader;
using Terraria.Localization;

namespace CalamityRuTranslate.ModOfRedemption.Tiles
{
    public class RedemptionChestName : GlobalTile
    {
        public override void SetDefaults()
        {
            Mod redemption = ModLoader.GetMod("Redemption");
            if (redemption != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                ModTile tile1 = TileLoader.GetTile(redemption.TileType("AncientWoodChestTile"));
                tile1.chest = "Сундук из древней древесины";

                ModTile tile2 = TileLoader.GetTile(redemption.TileType("DeadWoodChestTile"));
                tile2.chest = "Сундук из окаменевшей древесины";

                ModTile tile3 = TileLoader.GetTile(redemption.TileType("DeadWoodDresserTile"));
                tile3.dresser = "Комод из окаменевшей древесины";

                ModTile tile4 = TileLoader.GetTile(redemption.TileType("LabChestTile"));
                tile4.chest = "Лабораторный сундук";

                ModTile tile5 = TileLoader.GetTile(redemption.TileType("LabChestTileLocked"));
                tile5.chest = "Лабораторный сундук";

                ModTile tile6 = TileLoader.GetTile(redemption.TileType("LabChestTileLocked2"));
                tile6.chest = "Лабораторный сундук";

                ModTile tile7 = TileLoader.GetTile(redemption.TileType("HolochestTile"));
                tile7.chest = "Голосундук";
            }
        }
    }
}
