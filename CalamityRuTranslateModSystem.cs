using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Mods.CalamityMod;
using Terraria.ModLoader;
using Terraria.UI;

namespace CalamityRuTranslate;

public class CalamityRuTranslateModSystem : ModSystem
{
    public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
    {
        if (ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage)
        {
            NpcDialoguesTranslation.SetupTranslation();
            CombatTextsTranslation.SetupTranslation();
        }
    }
}