using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ElementsAwoken.Tiles
{
    public class ElementsAwokenСhestName : GlobalTile
    {
        public override void SetDefaults()
        {
            Mod elementsAwoken = ModLoader.GetMod("ElementsAwoken");
            if (elementsAwoken != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                TileLoader.GetTile(elementsAwoken.TileType("Locker")).chest = "Шкафчик";
                TileLoader.GetTile(elementsAwoken.TileType("VoidChest")).chest = "Пустотный сундук";
                TileLoader.GetTile(elementsAwoken.TileType("VoidDresser")).dresser = "Пустотный комод";
            }
        }
    }
}