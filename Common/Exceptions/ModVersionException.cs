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
                        return $@"
Было обнаружено, что ваша версия '{_modName}' {_currectModVersion} не соответствует требуемой версии {_expectedModVersion}, которую переводит русификатор.
Что бы исправить эту ошибку вам нужно:
1. Открыть браузер модов и обновить мод. Если обновление не найдено, переходим к пункту 1.1.

1.1. Нажать на кнопку 'Открыть веб помощь'.
2. Найти на открывшейся ссылке в браузере версию мода {_expectedModVersion}.
3. Скачать нужную версию мода и открыть его как обычный файл. Мод автоматически переместиться в папку с модами.
";
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
                        return "https://github.com/MountainDrew8/CalamityMod/releases";
                    
                    case ExceptionType.OutdatedThorium:
                        return "https://github.com/SamsonAllen13/ThoriumMod/releases";
                    
                    case ExceptionType.OutdatedFargo:
                        return "https://mega.nz/folder/JupwBAzS#TfCEeRTIFxdfVD6vo75tJQ";
                    
                    case ExceptionType.OutdatedFargoSouls:
                        return "https://mega.nz/folder/Ur4CDQQB#H4pt0k5BcDjxP-Naf6EJeg";

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