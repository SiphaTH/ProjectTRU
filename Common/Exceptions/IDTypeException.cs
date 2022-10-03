using System;

namespace CalamityRuTranslate.Common.Exceptions;

public class IdTypeException : Exception
{
    private string InvalidId { get; }
    private string ModName { get; }

    public IdTypeException(string invalidId, string modName)
    {
        InvalidId = invalidId;
        ModName = modName;
    }

    public override string Message => $"Internal name '{InvalidId}' в моде '{ModName}' не найден!\n";
}