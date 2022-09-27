using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Core;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

namespace CalamityRuTranslate;

public class CalamityRuTranslateModSystem : ModSystem
{
    public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
    {
        foreach (ContentTranslation content in CalamityRuTranslate.Instance.Contents.Where(x => x.IsTranslationEnabled))
        {
            (content as INpcChatText)?.NpcChatTextTranslation();
            (content as ICombatText)?.CombatTextTranslation();
        }
    }

    public override void PostAddRecipes()
    {
        foreach (var recipeGroupName in RecipeGroup.recipeGroups)
        {
            recipeGroupName.Value.GetText = recipeGroupName.Value.GetText.Invoke() switch
            {
                "Any Hardmode Anvil" => () => "Хардмодная наковальня",
                "Any Hardmode Forge" => () => "Хардмодная кузня",
                "Any Large Gem" => () => "Любой большой самоцвет",
                "Any Food Item" => () => "Любая еда",
                "Any Copper Bar" => () => "Медный или оловянный слиток",
                "Any Silver Bar" => () => "Серебряный или вольфрамовый слиток",
                "Any Gold Ore" => () => "Золотая или платиновая руда",
                "Any Gold Bar" => () => "Золотой или платиновый слиток",
                "Any Evil Bar" => () => "Слиток мирового зла",
                "Any Cobalt Bar" => () => "Кобальтовый или палладиевый слиток",
                "Any Mythril Bar" => () => "Мифриловый или орихалковый слиток",
                "Any Adamantite Bar" => () => "Адамантитовый или титановый слиток",
                "Any Evil Powder" => () => "Порошок мирового зла",
                "Shadow Scale or Tissue Sample" => () => "Теневая чешуйка или образец ткани",
                "Cursed Flame or Ichor" => () => "Проклятый огонь или ихор",
                "Any Evil Water" => () => "Вода мирового зла",
                "Any Evil Flask" => () => "Флакон мирового зла",
                "Any Stone Block" => () => "Любой камень",
                "Any Snow Block" => () => "Любой снег",
                "Any Ice Block" => () => "Любой лёд",
                "Any Silt" => () => "Любой ил",
                "Any Evil Block" => () => "Блок мирового зла",
                "Any Good Block" => () => "Блок мирового добра",
                "Any Wooden Sword" => () => "Любой деревянный меч",
                "Any Hallowed Helmet" => () => "Любой освящённый шлем",
                "Any Hallowed Platemail" => () => "Любые освящённые латы",
                "Any Hallowed Greaves" => () => "Любые освящённые ботинки",
                "Any Gold Crown" => () => "Золотая или платиновая корона",
                "Any Lunar Pickaxe" => () => "Любая лунная кирка",
                "Any Lunar Hamaxe" => () => "Любой лунный молотопор",
                "Any Mana Flower" => () => "Любой цветок маны",
                "Any Quiver" => () => "Любой колчан",
                "Any Tombstone" => () => "Любое надгробие",
                "Any Wings" => () => "Любые крылья",
                _ => recipeGroupName.Value.GetText
            };
        }
    }
}