using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Core;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class CalamityTranslation : SetupTranslation
{
    public override string InternalName => "CalamityMod";
    public override Version ExpectedVersion => new(2, 0, 1, 1);
    public CalamityTranslation()
    {
        IsBuffsEndabled = true;
        IsItemsEnabled = true;
        IsNPCsEnabled = true;
        IsPrefixesEnabled = true;
        Projectiles = CalamityCatalog.Projectiles;
        Tiles = CalamityCatalog.Tiles;
    }
}