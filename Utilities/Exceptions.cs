using System;
using Terraria.Localization;

namespace CalamityRuTranslate.Utilities
{
    public class TranslationException : Exception
    {
        public TranslationException(string invalidKey) : base($"Ключ {invalidKey} не найден! Отправьте скриншот ошибки нам на сервер.\n")
        {
        }
    }

    public class ModVersionException : Exception
    {
        public ModVersionException(string mod, string version) : base($"Было обнаружено, что вы используете версию мода {mod}, которую не поддерживает русификатор. Русификатор работает только с версией {version}. Если ваша версия {mod} ниже версии {version} - вам необходимо обновить {mod} до последней версии. Если ваша версия {mod} выше версии {version} - вам необходимо ждать обновление русификатора с поддержкой нового обновления {mod}. Она появится в ближайшее время.\n")
        {
        }
    }
}