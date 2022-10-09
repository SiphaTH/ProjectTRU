using System;

namespace CalamityRuTranslate.Common.Exceptions;

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
                case ExceptionType.OutdatedFargowiltas:
                case ExceptionType.OutdatedFargowiltasSouls:
                case ExceptionType.OutdatedStarsAbove:
                case ExceptionType.OutdatedInfernumMode:
                    return @$"
 [c/FF0000:###]                     [c/FF0000:###]                     [c/FF0000:###]
 [c/FF0000:# #]                     [c/FF0000:# #]                     [c/FF0000:# #]
[c/FF0000:## ##]                   [c/FF0000:## ##]                   [c/FF0000:## ##]
 [c/FF0000:# #]                     [c/FF0000:# #]                     [c/FF0000:# #]
  [c/FF0000:#]                       [c/FF0000:#]                       [c/FF0000:#]
Было обнаружено, что ваша версия '{ModName}' {CurrectModVersion} не соответствует требуемой версии {ExpectedModVersion}, которую переводит русификатор.
  [c/FF0000:#]                       [c/FF0000:#]                       [c/FF0000:#]
 [c/FF0000:# #]                     [c/FF0000:# #]                     [c/FF0000:# #]
[c/FF0000:## ##]                   [c/FF0000:## ##]                   [c/FF0000:## ##]
 [c/FF0000:# #]                     [c/FF0000:# #]                     [c/FF0000:# #]
 [c/FF0000:###]                     [c/FF0000:###]                     [c/FF0000:###]
";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    public enum ExceptionType
    {
        OutdatedCalamity,
        OutdatedThorium,
        OutdatedFargowiltas,
        OutdatedFargowiltasSouls,
        OutdatedStarsAbove,
        OutdatedInfernumMode,
    }
}