using System;

namespace CalamityRuTranslate.ModCompatibilities;

public class ModVersionException : Exception
{
    public ModVersionException(string modName, Version currentModVersion, Version expectedModVersion)
        : base($"Обнаружена несовместимая версия мода '{modName}'. Ваша текущая версия: [c/FF0000:{currentModVersion}]. Ожидаемая версия: [c/00FF09:{expectedModVersion}]. Для корректной работы русификатора необходимо установить ожидаемую версию.\n") { }
}