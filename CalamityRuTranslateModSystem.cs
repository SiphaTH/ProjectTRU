using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Core;
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
}