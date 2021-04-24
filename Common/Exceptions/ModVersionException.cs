using System;

namespace CalamityRuTranslate.Common.Exceptions
{
    // Original Code https://github.com/Steviegt6/CataclysmMod
    public sealed class ModVersionException : Exception
    {
        private string _modName { get; }

        private Version _expectedModVersion { get; }
        
        private Version _currectModVersion { get; }
        
        private ExceptionType _outdatedType { get; }
        
        public ModVersionException(string modName, Version currectModVersion, Version expectedModVersion, ExceptionType outdatedType)
        {
            _modName = modName;
            _expectedModVersion = expectedModVersion;
            _currectModVersion = currectModVersion;
            _outdatedType = outdatedType;
        }

        public override string Message
        {
            get
            {
                switch (_outdatedType)
                {
                    case ExceptionType.OutdatedCalamity:
                    case ExceptionType.OutdatedThorium:
                    case ExceptionType.OutdatedFargo:
                    case ExceptionType.OutdatedFargoSouls:
                        return $"Было обнаружено, что ваша версия \"{_modName}\" {_currectModVersion} не соответствует ожидаемой версии {_expectedModVersion}. Русификатор поддерживает только версию {_expectedModVersion}. Вы можете загрузить поддерживаемую версию \"{_modName}\" в браузере модов или по прямой ссылке (нажмите внизу справа \"Открыть веб помощь\")\n";
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
        
        public override string HelpLink
        {
            get
            {
                switch (_outdatedType)
                {
                    case ExceptionType.OutdatedCalamity:
                        return "https://mirror.sgkoi.dev/tModLoader/download.php?Down=mods/CalamityMod.tmod";
                    
                    case ExceptionType.OutdatedThorium:
                        return "https://mirror.sgkoi.dev/tModLoader/download.php?Down=mods/ThoriumMod.tmod";
                    
                    case ExceptionType.OutdatedFargo:
                        return "https://mirror.sgkoi.dev/tModLoader/download.php?Down=mods/Fargowiltas.tmod";
                    
                    case ExceptionType.OutdatedFargoSouls:
                        return "https://mirror.sgkoi.dev/tModLoader/download.php?Down=mods/FargowiltasSouls.tmod";

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public enum ExceptionType
        {
            OutdatedCalamity,
            OutdatedThorium,
            OutdatedFargo,
            OutdatedFargoSouls
        }
    }
}