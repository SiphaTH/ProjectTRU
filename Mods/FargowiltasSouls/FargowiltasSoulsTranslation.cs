using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Core;

namespace CalamityRuTranslate.Mods.FargowiltasSouls;

public class FargowiltasSoulsTranslation : SetupTranslation
{
    public override string InternalName => "FargowiltasSouls";
    public override Version ExpectedVersion => new(1, 4, 0, 6);

    public FargowiltasSoulsTranslation()
    {
        IsBuffsEndabled = true;
        IsItemsEnabled = true;
        IsNPCsEnabled = true;
        Tiles = FargowiltasSoulsCatalog.Tiles;
    }
}