using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Core;

namespace CalamityRuTranslate.Mods.Fargowiltas;

public class FargowiltasTranslation : SetupTranslation
{
    public override string InternalName => "Fargowiltas";
    public override Version ExpectedVersion => new(2, 8, 5);

    public FargowiltasTranslation()
    {
        IsBuffsEndabled = true;
        IsItemsEnabled = true;
        IsNPCsEnabled = true;
        Tiles = FargowiltasCatalog.Tiles;
    }
}