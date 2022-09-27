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
                "Any Hardmode Anvil" => () => "",
                "Any Hardmode Forge" => () => "",
                "Any Large Gem" => () => "",
                "Any Food Item" => () => "",
                "Any Copper Bar" => () => "",
                "Any Silver Bar" => () => "",
                "Any Gold Ore" => () => "",
                "Any Gold Bar" => () => "",
                "Any Evil Bar" => () => "",
                "Any Cobalt Bar" => () => "",
                "Any Mythril Bar" => () => "",
                "Any Adamantite Bar" => () => "",
                "Any Evil Powder" => () => "",
                "Shadow Scale or Tissue Sample" => () => "",
                "Cursed Flame or Ichor" => () => "",
                "Any Evil Water" => () => "",
                "Any Evil Flask" => () => "",
                "Any Stone Block" => () => "",
                "Any Snow Block" => () => "",
                "Any Ice Block" => () => "",
                "Any Silt" => () => "",
                "Any Evil Block" => () => "",
                "Any Good Block" => () => "",
                "Any Wooden Sword" => () => "",
                "Any Hallowed Helmet" => () => "",
                "Any Hallowed Platemail" => () => "",
                "Any Hallowed Greaves" => () => "",
                "Any Gold Crown" => () => "",
                "Any Lunar Pickaxe" => () => "",
                "Any Lunar Hamaxe" => () => "",
                "Any Mana Flower" => () => "",
                "Any Quiver" => () => "",
                "Any Tombstone" => () => "",
                "Any Wings" => () => "",
                _ => recipeGroupName.Value.GetText
            };
        }
    }
}