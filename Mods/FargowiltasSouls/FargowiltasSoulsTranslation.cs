using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Core;

namespace CalamityRuTranslate.Mods.FargowiltasSouls;

public class FargowiltasSoulsTranslation : TranslateMod
{
    public override string InternalModName => "FargowiltasSouls";
    public override Version ExpectedVersion => new(1, 4, 1, 1);

    public FargowiltasSoulsTranslation()
    {
        IsBuffsEnabled = true;
        IsItemsEnabled = true;
        IsNPCsEnabled = true;
        Tiles = FargowiltasSoulsCatalog.Tiles;
    }
}