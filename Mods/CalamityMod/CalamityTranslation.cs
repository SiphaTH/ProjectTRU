using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Core;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class CalamityTranslation : SetupTranslation
{
    public override string InternalName => "CalamityMod";
    public override Version ExpectedVersion => new(2, 0, 0, 3);
    public CalamityTranslation()
    {
        Buffs = CalamityCatalog.Buffs;
        Items = CalamityCatalog.Items;
        NPCs = CalamityCatalog.NPCs;
        Containers = CalamityCatalog.Containers;
        Prefixes = CalamityCatalog.Prefixes;
        Tiles = CalamityCatalog.Tiles;
    }
}