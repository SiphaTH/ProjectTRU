using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Core;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfernumModeTranslation : TranslateMod
{
    public override string InternalModName => "InfernumMode";
    public override Version ExpectedVersion => new(1, 7, 9);

    public InfernumModeTranslation()
    {
        IsBuffsEndabled = true;
        IsItemsEnabled = true;
        IsNPCsEnabled = true;
        Tiles = InfernumModeCatalog.Tiles;
    }
}