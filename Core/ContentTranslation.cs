namespace CalamityRuTranslate.Core;

public abstract class ContentTranslation : IContentTranslation
{
    public abstract bool IsTranslationEnabled { get; }
    public abstract void LoadTranslation();
}