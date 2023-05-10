using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using On.Terraria.UI.Chat;
using ReLogic.Graphics;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class DrawColorCodedStringWithShadowPatch : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => TranslationHelper.IsRussianLanguage;

    public override float Priority => 1f;
    
    public void LoadContent()
    {
        ChatManager.DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float += DrawColorCodedStringWithShadowHook;
    }

    public void UnloadContent()
    {
        ChatManager.DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float -= DrawColorCodedStringWithShadowHook;
    }
    
    private Vector2 DrawColorCodedStringWithShadowHook(ChatManager.orig_DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float orig, SpriteBatch spritebatch, DynamicSpriteFont font, string text, Vector2 position, Color basecolor, float rotation, Vector2 origin, Vector2 basescale, float maxwidth, float spread)
    {
        text = text switch
        {
            // Infernum
            "Toggle cybernetic immortality" => "Переключить кибернетическое бессмертие",
            "Toggle physics defiance flying" => "Переключить игнорирование физики полёта",
            "Accelerate time until sunrise" => "Ускорить время до восхода солнца",
            "Accelerate time until noon" => "Ускорить время до полудня",
            "Accelerate time until sunset" => "Ускорить время до заката солнца",
            "Atomize every single hostile NPC" => "Атомизировать всех враждебных НИПов",
            _ => text
        };
        return orig.Invoke(spritebatch, font, text, position, basecolor, rotation, origin, basescale, maxwidth, spread);
    }
}