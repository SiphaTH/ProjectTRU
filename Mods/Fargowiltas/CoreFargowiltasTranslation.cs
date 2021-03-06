using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Utilities;

namespace CalamityRuTranslate.Mods.Fargowiltas
{
    public class CoreFargowiltasTranslation : ModRussianTranslation
    {
        public CoreFargowiltasTranslation() : base("Fargowiltas")
        {
            BuffTranslation = FargoTranslationCatalog.Buff;
            ItemNameTranslation = FargoTranslationCatalog.ItemName;
            ItemTooltipTranslation = FargoTranslationCatalog.ItemTooltip;
            NPCTranslation = FargoTranslationCatalog.NPC;
            TileTranslation = FargoTranslationCatalog.Tile;
        }

        public override void Load()
        {
            if (IsLoaded && ModInstance.Version != new Version(2, 2, 7))
            {
                throw new ModVersionException("Fargowiltas", "2.2.7", ModInstance.Version);
            }
            
            if (ModsCall.FargoSouls != null)
            {
                ItemNameTranslation.Add("InnocuousSkull");
                ItemTooltipTranslation.Add("InnocuousSkull");
                NPCTranslation.Add("Squirrel");
            }
            
            if (ModsCall.Thorium != null || ModsCall.Calamity != null)
            {
                ItemNameTranslation.Add("OmnistationPlus");
                ItemTooltipTranslation.Add("OmnistationPlus");
            }
            
            if (ModsCall.Thorium != null)
            {
                ItemNameTranslation.AddRange(FargoTranslationCatalog.FargoThoriumCrossItems);
                ItemTooltipTranslation.AddRange(FargoTranslationCatalog.FargoThoriumCrossItems);
            }
        }

        public override void DialogueTranslation()
        {
            NPCDialogueTranslation.SetupTranslation();
        }
    }
}