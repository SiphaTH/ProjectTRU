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
        foreach (KeyValuePair<int, RecipeGroup> recipeGroupName in RecipeGroup.recipeGroups)
        {
            recipeGroupName.Value.GetText = recipeGroupName.Value.GetText() switch
            {
                "Any Hardmode Anvil" => () => "Хардмодная наковальня",
                "Any Hardmode Forge" => () => "Хардмодная кузня",
                "Any Large Gem" => () => "Любой большой самоцвет",
                "Any Food Item" => () => "Любая еда",
                "Any Evil Bar" => () => "Слиток мирового зла",
                "Any Evil Powder" => () => "Порошок мирового зла",
                "Shadow Scale or Tissue Sample" => () => "Теневая чешуйка или образец ткани",
                "Cursed Flame or Ichor" => () => "Проклятый огонь или ихор",
                "Any Evil Water" => () => "Вода мирового зла",
                "Any Evil Flask" => () => "Флакон мирового зла",
                "Any Evil Block" => () => "Блок мирового зла",
                "Any Good Block" => () => "Блок мирового добра",
                "Any Lunar Pickaxe" => () => "Любая лунная кирка",
                "Any Lunar Hamaxe" => () => "Любой лунный молотопор",
                "Any Quiver" => () => "Любой колчан",
                "Any Wings" => () => "Любые крылья",
                _ => recipeGroupName.Value.GetText
            };
        }
    }
}