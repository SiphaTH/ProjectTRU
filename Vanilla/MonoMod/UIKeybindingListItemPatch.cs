using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using On.Terraria.GameContent.UI.Elements;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class UIKeybindingListItemPatch : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => TranslationHelper.IsRussianLanguage;

    public override float Priority => 1f;
    
    public void LoadContent()
    {
        UIKeybindingListItem.GetFriendlyName += UIKeybindingListItemOnGetFriendlyName;
    }

    public void UnloadContent()
    {
        UIKeybindingListItem.GetFriendlyName -= UIKeybindingListItemOnGetFriendlyName;
    }
    
    private string UIKeybindingListItemOnGetFriendlyName(UIKeybindingListItem.orig_GetFriendlyName orig, Terraria.GameContent.UI.Elements.UIKeybindingListItem self)
    {
        string keybindName = self.GetType().GetField("_keybind", (BindingFlags)60)?.GetValue(self) as string;
        
        return keybindName switch
        {
            "CalamityMod: Normality Relocator" => "CalamityMod: Релокатор нормальной формы",
            "CalamityMod: Rage Mode" => "CalamityMod: Режим ярости",
            "CalamityMod: Adrenaline Mode" => "CalamityMod: Режим адреналина",
            "CalamityMod: Elysian Guard" => "CalamityMod: Элизийский страж",
            "CalamityMod: Armor Set Bonus" => "CalamityMod: Бонус комплекта брони",
            "CalamityMod: Astral Teleport" => "CalamityMod: Астральная телепортация",
            "CalamityMod: Astral Arcanum UI Toggle" => "CalamityMod: Телепортация астрального арканума",
            "CalamityMod: Sand Cloak Effect" => "CalamityMod: Эффект песчаной мантии",
            "CalamityMod: Spectral Veil Teleport" => "CalamityMod: Телепортация спектральной вуали",
            "CalamityMod: Booster Dash" => "CalamityMod: Усилитель рывка",
            "CalamityMod: Angelic Alliance Blessing" => "CalamityMod: Божественность альянса ангелов",
            "CalamityMod: God Slayer Dash" => "CalamityMod: Рывок богоубийцы",
            "CalamityMod: Exo Chair Slow Down" => "CalamityMod: Замедление экзо-бокса",
            "Fargowiltas: Quick Recall/Mirror" => "Fargowiltas: Быстрое зелье возврата/зеркало",
            "Fargowiltas: Quick Rod of Discord" => "Fargowiltas: Быстрый жезл раздора",
            "Fargowiltas: Quick Use Custom (Bottom Left Inventory Slot)" => "Fargowiltas: Быстрое использ. (нижний левый слот инвентаря)",
            "Fargowiltas: Open Stat Sheet" => "Fargowiltas: Открыть таблицу характеристик",
            "FargowiltasSouls: Freeze" => "FargowiltasSouls: Заморозка",
            "FargowiltasSouls: Turn Gold" => "FargowiltasSouls: Превращение в золото",
            "FargowiltasSouls: Throw Smoke Bomb" => "FargowiltasSouls: Дымовая бомба",
            "FargowiltasSouls: Special Dash" => "FargowiltasSouls: Особый рывок",
            "FargowiltasSouls: Bomb" => "FargowiltasSouls: Бомба",
            "FargowiltasSouls: Open Soul Toggler" => "FargowiltasSouls: Открыть настройки эффектов душ",
            "FargowiltasSouls: Precision Movement" => "FargowiltasSouls: Точное передвижение",
            "FargowiltasSouls: Magical Cleanse" => "FargowiltasSouls: Магическое очищение",
            "FargowiltasSouls: Frigid Spell" => "FargowiltasSouls: Холодное заклинание",
            "FargowiltasSouls: Debuff Install" => "FargowiltasSouls: Инсталляция дебаффа",
            "FargowiltasSouls: Ammo Cycle" => "FargowiltasSouls: Смена боеприпаса",
            _ => orig.Invoke(self)
        };
    }
}