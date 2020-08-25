using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Items
{
    internal class CalamityPrefixName
	{
		public static void Setup()
		{
			PrefixName();
		}
		private static void PrefixName()
		{
			Mod calamity = ModLoader.GetMod("CalamityMod");
			
			calamity.GetPrefix("Pointy").DisplayName.AddTranslation(GameCulture.Russian, "Заострённый");
			calamity.GetPrefix("Sharp").DisplayName.AddTranslation(GameCulture.Russian, "Острый");
			calamity.GetPrefix("Feathered").DisplayName.AddTranslation(GameCulture.Russian, "Cтремительный");
			calamity.GetPrefix("Sleek").DisplayName.AddTranslation(GameCulture.Russian, "Обтекаемый");
			calamity.GetPrefix("Hefty").DisplayName.AddTranslation(GameCulture.Russian, "Увесистый");
			calamity.GetPrefix("Mighty").DisplayName.AddTranslation(GameCulture.Russian, "Могучий");
			calamity.GetPrefix("Glorious").DisplayName.AddTranslation(GameCulture.Russian, "Выдающийся");
			calamity.GetPrefix("Serrated").DisplayName.AddTranslation(GameCulture.Russian, "Зазубренный");
			calamity.GetPrefix("Vicious").DisplayName.AddTranslation(GameCulture.Russian, "Свирепый");
			calamity.GetPrefix("Lethal").DisplayName.AddTranslation(GameCulture.Russian, "Убойный");
			calamity.GetPrefix("Flawless").DisplayName.AddTranslation(GameCulture.Russian, "Безупречный");
			calamity.GetPrefix("Radical").DisplayName.AddTranslation(GameCulture.Russian, "Радикальный");
			calamity.GetPrefix("Blunt").DisplayName.AddTranslation(GameCulture.Russian, "Грубый");
			calamity.GetPrefix("Flimsy").DisplayName.AddTranslation(GameCulture.Russian, "Хрупкий");
			calamity.GetPrefix("Unbalanced").DisplayName.AddTranslation(GameCulture.Russian, "Несбалансированный");
			calamity.GetPrefix("Atrocious").DisplayName.AddTranslation(GameCulture.Russian, "Отвратительный");
			calamity.GetPrefix("Quiet").DisplayName.AddTranslation(GameCulture.Russian, "Тихий");
			calamity.GetPrefix("Cloaked").DisplayName.AddTranslation(GameCulture.Russian, "Скрытый");
			calamity.GetPrefix("Camouflaged").DisplayName.AddTranslation(GameCulture.Russian, "Замаскированный");
			calamity.GetPrefix("Silent").DisplayName.AddTranslation(GameCulture.Russian, "Безмолвный");
		}
	}
}