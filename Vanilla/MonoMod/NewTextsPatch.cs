using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Microsoft.Xna.Framework;
using On.Terraria;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class NewTextsPatch : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => TranslationHelper.IsRussianLanguage;

    public override float Priority => 1f;

    public void LoadContent()
    {
        Main.NewText_string_byte_byte_byte += MainOnNewText_string_byte_byte_byte;
        Main.NewTextMultiline += MainOnNewTextMultiline;
    }

    public void UnloadContent()
    {
        Main.NewText_string_byte_byte_byte -= MainOnNewText_string_byte_byte_byte;
        Main.NewTextMultiline -= MainOnNewTextMultiline;
    }
    
    private void MainOnNewText_string_byte_byte_byte(Main.orig_NewText_string_byte_byte_byte orig, string newtext, byte r, byte g, byte b)
    {
        newtext = newtext switch
        {
            "The invaders have left!" => "Вторженцы уходят!",
            "The Pumpkin Moon is lowering..." => "Заходит тыквенная луна...",
            "The Frost Moon is lowering..." => "Заходит морозная луна...",
            "A solar eclipse is not happening!" => "Солнечное затмение не происходит!",
            "The blood moon is descending..." => "Кровавая луна опускается за горизонт...",
            "The wind has ended!" => "Ветер закончился!",
            "The Old One's Army is leaving!" => "Армия Древних уходит!",
            "The sandstorm has ended!" => "Песчаная буря закончилась!",
            "Celestial creatures are not invading!" => "Неземные сущности не атакуют!",
            "The rain has ended!" => "Дождь закончился!",
            _ => newtext
        };

        orig.Invoke(newtext, r, g, b);
    }
    
    private void MainOnNewTextMultiline(Main.orig_NewTextMultiline orig, string text, bool force, Color c, int widthlimit)
    {
        text = text switch
        {
            "The invaders have left!" => "Вторженцы уходят!",
            "The Pumpkin Moon is lowering..." => "Заходит тыквенная луна...",
            "The Frost Moon is lowering..." => "Заходит морозная луна...",
            "A solar eclipse is not happening!" => "Солнечное затмение не происходит!",
            "The blood moon is descending..." => "Кровавая луна опускается за горизонт...",
            "The wind has ended!" => "Ветер закончился!",
            "The Old One's Army is leaving!" => "Армия Древних уходит!",
            "The sandstorm has ended!" => "Песчаная буря закончилась!",
            "Celestial creatures are not invading!" => "Неземные сущности не атакуют!",
            "The rain has ended!" => "Дождь закончился!",
            _ => text
        };

        orig.Invoke(text, force, c, widthlimit);
    }
}