using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Core;
using CalamityRuTranslate.Mods.CalamityMod;
using CalamityRuTranslate.Mods.Fargowiltas;
using CalamityRuTranslate.Mods.FargowiltasSouls;
using Terraria.ModLoader;
using Terraria.UI;

namespace CalamityRuTranslate;

public class CalamityRuTranslateModSystem : ModSystem
{
    private readonly List<IContentTranslation> _contents = new()
    {
        new CalamityCombatText(),
        new CalamityNpcChat(),
        new FargoNpcChat(),
        new FargowiltasSoulsCombatText(),
        new FargowiltasSoulsNpcChat()
    };
    
    public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
    {
        foreach (var content in _contents.Where(content => content.IsTranslationEnabled))
        {
            content.LoadTranslation();
        }
    }
}