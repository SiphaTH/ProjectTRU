using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common.Exceptions;
using CalamityRuTranslate.Core;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class CalamityTranslation : SetupModTranslation
    {
        public CalamityTranslation() : base("CalamityMod")
        {
            BuffsTranslation = CalamityCatalog.Buffs;
            ItemsNameTranslation = CalamityCatalog.ItemsName;
            ItemsTooltipTranslation = CalamityCatalog.ItemsTooltip;
            ProjectilesTranslation = CalamityCatalog.Projectiles;
            NPCsTranslation = CalamityCatalog.NPCs;
            ChestsTranslation = CalamityCatalog.Chests;
            DressersTranslation = CalamityCatalog.Dressers;
            PrefixesTranslation = CalamityCatalog.Prefixes;
            KeysLocalization = CalamityCatalog.KeysLocalization;
            TilesTranslation = CalamityCatalog.Tiles;
        }

         private Version _expectedCalamityVersion = new Version(1, 5, 1, 3);

         public override void Load()
         {
             if (!TRuConfig.Instance.IsEnabledModVersionException)
                 return;

             if (ModInstance.Version != _expectedCalamityVersion)
             {
                 throw new ModVersionException("Calamity Mod (No Calamity Music)", ModInstance.Version,
                     _expectedCalamityVersion, ModVersionException.ExceptionType.OutdatedCalamity);
             }
         }

        public override void SetupDialoguesTranslation()
        {
            NpcDialoguesTranslation.SetupTranslation();
        }

        public override void SetupCombatTextsTranslation()
        {
            CombatTextsTranslation.SetupTranslation();
        }
    }
}