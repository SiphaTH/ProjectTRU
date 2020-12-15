using System;
using Terraria.Localization;

namespace CalamityRuTranslate.Utilities
{
    public class TranslationException : Exception
    {
        public TranslationException(string invalidKey, GameCulture gameCulture) : base($"Ключ {invalidKey} не найден! Отправьте скриншот ошибки нам на сервер.\n")
        {
        }
    }

    public class ModVersionException : Exception
    {
        public ModVersionException(string mod, string version) : base($"Данная версия русификатора работает для версии {version} мода {mod}. Обновите русификатор и {mod} до последних версий. Если после обновлений эта ошибка продолжает появлятся - ждите новую версию русификатора. Она появится в ближайшее время.\n")
        {
        }
    }
}