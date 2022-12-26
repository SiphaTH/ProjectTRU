using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Core;

namespace CalamityRuTranslate.Mods.Fargowiltas;

public class FargowiltasTranslation : TranslateMod
{
    public override string InternalModName => "Fargowiltas";
    public override Version ExpectedVersion => new(2, 8, 6);

    public FargowiltasTranslation()
    {
        IsBuffsEndabled = true;
        IsItemsEnabled = true;
        IsNPCsEnabled = true;
        Tiles = FargowiltasCatalog.Tiles;
    }
}