namespace CalamityRuTranslate.Core;

public abstract class ContentTranslation
{
    public virtual bool IsTranslationEnabled => false;
    public virtual float Priority => 1f;
    public virtual void ModifyNpcChatText() { }
    public virtual void ModifyModCombatText() { }
    public virtual void LoadContent() { }
    public virtual void UnloadContent() { }
}