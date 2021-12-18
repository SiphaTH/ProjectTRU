using System;

namespace CalamityRuTranslate.Common.Exceptions
{
    public sealed class ModVersionException : Exception
    {
        private string ModName { get; }

        private Version ExpectedModVersion { get; }

        private Version CurrectModVersion { get; }

        private ExceptionType OutdatedType { get; }

        public ModVersionException(string modName, Version currectModVersion, Version expectedModVersion, ExceptionType outdatedType)
        {
            ModName = modName;
            ExpectedModVersion = expectedModVersion;
            CurrectModVersion = currectModVersion;
            OutdatedType = outdatedType;
        }

        public override string Message
        {
            get
            {
                switch (OutdatedType)
                {
                    case ExceptionType.OutdatedCalamity:
                    case ExceptionType.OutdatedThorium:
                    case ExceptionType.OutdatedFargo:
                    case ExceptionType.OutdatedFargoSouls:
                        return $@"
Было обнаружено, что ваша версия '{ModName}' {CurrectModVersion} не соответствует требуемой версии {ExpectedModVersion}, которую переводит русификатор.
Что бы исправить эту ошибку вам нужно:
1. Открыть браузер модов и обновить мод. Если обновление не найдено, переходим к пункту 1.1.

1.1. Нажать на кнопку 'Открыть веб помощь'.
2. Найти на открывшейся ссылке в браузере версию мода {ExpectedModVersion}.
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
                switch (OutdatedType)
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