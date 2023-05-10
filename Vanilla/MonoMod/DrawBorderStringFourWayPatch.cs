using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using On.Terraria;
using ReLogic.Graphics;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class DrawBorderStringFourWayPatch : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => TranslationHelper.IsRussianLanguage;

    public override float Priority => 1f;
    
    public void LoadContent()
    {
        Utils.DrawBorderStringFourWay += UtilsOnDrawBorderStringFourWay;
    }

    public void UnloadContent()
    {
        Utils.DrawBorderStringFourWay -= UtilsOnDrawBorderStringFourWay;
    }
    
    private void UtilsOnDrawBorderStringFourWay(Utils.orig_DrawBorderStringFourWay orig, SpriteBatch sb, DynamicSpriteFont font, string text, float x, float y, Color textcolor, Color bordercolor, Vector2 origin, float scale)
    {
        text = text switch
        {
            // Calamity
            "Insufficient minion slots!" => "Недостаточно слотов призываемых миньонов!",
            _ => text
        };

        orig.Invoke(sb, font, text, x, y, textcolor, bordercolor, origin, scale);
    }
}