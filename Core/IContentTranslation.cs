namespace CalamityRuTranslate.Core;

public interface IContentTranslation
{
    bool IsTranslationEnabled => false;
    void LoadTranslation();
}