using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class DrawColorCodedStringWithShadowPatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        On_ChatManager.DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float += DrawColorCodedStringWithShadowHook;
    }

    public void Unload()
    {
        On_ChatManager.DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float -= DrawColorCodedStringWithShadowHook;
    }

    private Vector2 DrawColorCodedStringWithShadowHook(On_ChatManager.orig_DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float orig, SpriteBatch spritebatch, DynamicSpriteFont font, string text, Vector2 position, Color basecolor, float rotation, Vector2 origin, Vector2 basescale, float maxwidth, float spread)
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
            // Thorium
            // "\n\nConsumes [i/s5:75] to change the world difficulty\nChange to Мастер Mode" => "\n\nРасходует [i/s5:75] для изменения сложности мира\nПереключает сложность в режим Мастера",
            // "\n\nConsumes [i/s5:75] to change the world difficulty\nChange to Эксперт Mode" => "\n\nРасходует [i/s5:75] для изменения сложности мира\nПереключает сложность в режим Эксперта",
            // "\n\nConsumes [i/s5:75] to change the world difficulty\nChange to Классика Mode" => "\n\nРасходует [i/s5:75] для изменения сложности мира\nПереключает сложность в классический режим",
            // "\n\nYou cannot use this in Journey Mode, use its difficulty slider instead" => "Вы не можете использовать это в режиме Путешествия, используйте вместо этого его ползунок сложности.",
            _ => text
        };
        return orig.Invoke(spritebatch, font, text, position, basecolor, rotation, origin, basescale, maxwidth, spread);
    }
}