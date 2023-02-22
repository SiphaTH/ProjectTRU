using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Core;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class CalamityTranslation : TranslateMod
{
    public override string InternalModName => "CalamityMod";
    public override Version ExpectedVersion => new(2, 0, 2, 1);
    
    public CalamityTranslation()
    {
        IsBuffsEnabled = true;
        IsItemsEnabled = true;
        IsNPCsEnabled = true;
        IsPrefixesEnabled = true;
        Projectiles = CalamityCatalog.Projectiles;
        Tiles = CalamityCatalog.Tiles;
    }
}