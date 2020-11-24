using Terraria.Localization;

namespace CalamityRuTranslate.CalamityMod.Items
{
    internal static class CalamityPrefixName
	{
		public static void Setup()
		{
			PrefixName();
		}
		private static void PrefixName()
		{
			ModCompatibility.CalamityMod.GetPrefix("Pointy").DisplayName.AddTranslation(GameCulture.Russian, "Заострённый");
			ModCompatibility.CalamityMod.GetPrefix("Sharp").DisplayName.AddTranslation(GameCulture.Russian, "Острый");
			ModCompatibility.CalamityMod.GetPrefix("Feathered").DisplayName.AddTranslation(GameCulture.Russian, "Стремительный");
			ModCompatibility.CalamityMod.GetPrefix("Sleek").DisplayName.AddTranslation(GameCulture.Russian, "Обтекаемый");
			ModCompatibility.CalamityMod.GetPrefix("Hefty").DisplayName.AddTranslation(GameCulture.Russian, "Увесистый");
			ModCompatibility.CalamityMod.GetPrefix("Mighty").DisplayName.AddTranslation(GameCulture.Russian, "Могучий");
			ModCompatibility.CalamityMod.GetPrefix("Glorious").DisplayName.AddTranslation(GameCulture.Russian, "Выдающийся");
			ModCompatibility.CalamityMod.GetPrefix("Serrated").DisplayName.AddTranslation(GameCulture.Russian, "Зазубренный");
			ModCompatibility.CalamityMod.GetPrefix("Vicious").DisplayName.AddTranslation(GameCulture.Russian, "Свирепый");
			ModCompatibility.CalamityMod.GetPrefix("Lethal").DisplayName.AddTranslation(GameCulture.Russian, "Убойный");
			ModCompatibility.CalamityMod.GetPrefix("Flawless").DisplayName.AddTranslation(GameCulture.Russian, "Безупречный");
			ModCompatibility.CalamityMod.GetPrefix("Radical").DisplayName.AddTranslation(GameCulture.Russian, "Радикальный");
			ModCompatibility.CalamityMod.GetPrefix("Blunt").DisplayName.AddTranslation(GameCulture.Russian, "Грубый");
			ModCompatibility.CalamityMod.GetPrefix("Flimsy").DisplayName.AddTranslation(GameCulture.Russian, "Хрупкий");
			ModCompatibility.CalamityMod.GetPrefix("Unbalanced").DisplayName.AddTranslation(GameCulture.Russian, "Несбалансированный");
			ModCompatibility.CalamityMod.GetPrefix("Atrocious").DisplayName.AddTranslation(GameCulture.Russian, "Отвратительный");
			ModCompatibility.CalamityMod.GetPrefix("Quiet").DisplayName.AddTranslation(GameCulture.Russian, "Тихий");
			ModCompatibility.CalamityMod.GetPrefix("Cloaked").DisplayName.AddTranslation(GameCulture.Russian, "Скрытый");
			ModCompatibility.CalamityMod.GetPrefix("Camouflaged").DisplayName.AddTranslation(GameCulture.Russian, "Замаскированный");
			ModCompatibility.CalamityMod.GetPrefix("Silent").DisplayName.AddTranslation(GameCulture.Russian, "Безмолвный");
		}
	}
}