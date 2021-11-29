using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Exceptions;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class CoreCalamityTranslation : ModRussianTranslation
    {
        public CoreCalamityTranslation() : base("CalamityMod")
        {
            BuffTranslation = CalamityCatalog.Buff;
            ItemNameTranslation = CalamityCatalog.ItemName;
            ItemTooltipTranslation = CalamityCatalog.ItemTooltip;
            ProjectileTranslation = CalamityCatalog.Projectile;
            NPCTranslation = CalamityCatalog.NPC;
            ChestTranslation = CalamityCatalog.Chest;
            DresserTranslation = CalamityCatalog.Dresser;
            PrefixTranslation = CalamityCatalog.Prefix;
            KeyLocalization = CalamityCatalog.KeyLocalization;
            TileTranslation = CalamityCatalog.Tile;
        }

         private readonly Version ExpectedCalamityVersion = new Version(1, 5, 0, 2);
        
         public override void Load()
         {
             if (!TRuConfig.Instance.IsEnabledModVersionException)
                 return;

             if (ModInstance.Version != ExpectedCalamityVersion)
             {
                 throw new ModVersionException("Calamity Mod (No Calamity Music)", ModInstance.Version,
                     ExpectedCalamityVersion, ModVersionException.ExceptionType.OutdatedCalamity);
             }
         }

        public override void DialogueTranslation() => NPCDialogueTranslation.SetupTranslation();

        public override void CombatTextTranslation() => CombatTranslation.SetupTranslation();
    }
}