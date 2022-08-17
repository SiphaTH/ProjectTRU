using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Core;

namespace CalamityRuTranslate.Mods.FargowiltasSouls;

public class FargowiltasSoulsTranslation : SetupTranslation
{
    public override string InternalName => "FargowiltasSouls";
    public override Version ExpectedVersion => new(1, 4, 0, 4);

    public FargowiltasSoulsTranslation()
    {
        Buffs = FargowiltasSoulsCatalog.Buffs;
        Items = FargowiltasSoulsCatalog.Items;
        NPCs = FargowiltasSoulsCatalog.NPCs;
        Tiles = FargowiltasSoulsCatalog.Tiles;
    }
}