using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Core;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfernumModeTranslation : SetupTranslation
{
    public override string InternalName => "InfernumMode";
    public override Version ExpectedVersion => new();
    public override bool CheckModVersion => false;

    public InfernumModeTranslation()
    {
        IsBuffsEndabled = true;
        IsItemsEnabled = true;
        Tiles = InfernumModeCatalog.Tiles;
    }
}