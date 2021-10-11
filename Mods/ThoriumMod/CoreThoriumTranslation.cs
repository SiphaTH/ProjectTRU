using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Exceptions;

namespace CalamityRuTranslate.Mods.ThoriumMod
{
    public class CoreThoriumTranslation : ModRussianTranslation
    {
        public CoreThoriumTranslation() : base("ThoriumMod")
        {
            DresserTranslation = ThoriumCatalog.Dresser;
            ChestTranslation = ThoriumCatalog.Chest;
            PrefixTranslation = ThoriumCatalog.Prefix;
        }

        private readonly Version ExpectedThoriumVersion = new Version(1, 6, 5, 1);

        public override void Load()
        {
            if (ModInstance.Version != ExpectedThoriumVersion)
            {
                throw new ModVersionException("Thorium Mod", ModInstance.Version, ExpectedThoriumVersion,
                    ModVersionException.ExceptionType.OutdatedThorium);
            }

            ThoriumTranslationLists.LoadLists();
            ThoriumRussianDictionaries.LoadDictionaries();
        }
        
        public static void Unload()
        {
            ThoriumRussianDictionaries.UnloadDictionaries();
            ThoriumTranslationLists.UnloadLists();
        }
    }
}