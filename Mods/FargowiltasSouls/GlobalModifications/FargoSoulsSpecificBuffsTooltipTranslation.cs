using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using FargowiltasSouls.Buffs;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.GlobalModifications;

public class FargoSoulsSpecificBuffsTooltipTranslation : GlobalBuff
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyBuffTip(int type, ref string tip, ref int rare)
    {
        
    }
}