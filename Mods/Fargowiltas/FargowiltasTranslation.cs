using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Core;

namespace CalamityRuTranslate.Mods.Fargowiltas;

public class FargowiltasTranslation : SetupTranslation
{
    public override string InternalName => "Fargowiltas";
    public override Version ExpectedVersion => new(2, 8, 2);

    public FargowiltasTranslation()
    {
        Buffs = FargowiltasCatalog.Buffs;
        Items = FargowiltasCatalog.Items;
        NPCs = FargowiltasCatalog.NPCs;
    }
}