using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using On.Terraria;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class MouseTextPatch : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => TranslationHelper.IsRussianLanguage;

    public override float Priority => 1f;

    public void LoadContent()
    {
        Main.MouseText_string_int_byte_int_int_int_int_int += MainOnMouseText_string_int_byte_int_int_int_int_int;
    }

    public void UnloadContent()
    {
        Main.MouseText_string_int_byte_int_int_int_int_int -= MainOnMouseText_string_int_byte_int_int_int_int_int;
    }
    
    private void MainOnMouseText_string_int_byte_int_int_int_int_int(Main.orig_MouseText_string_int_byte_int_int_int_int_int orig, Terraria.Main self, string cursortext, int rare, byte diff, int hackedmousex, int hackedmousey, int hackedscreenwidth, int hackedscreenheight, int pushwidthx)
    {
        cursortext = cursortext switch
        {
            "Ice Shield Cooldown" => "Перезарядка ледяного щита",
            "Blood Frenzy Cooldown" => "Перезарядка кровавого неистовства",
            "Bloodflare Soul Cooldown" => "Перезарядка душ кровавой вспышки",
            "Brimflame Frenzy Cooldown" => "Перезарядка серного неистовства",
            "Teleportation Cooldown" => "Перезарядка телепортации",
            "Scarf Cooldown" => "Перезарядка шарфа",
            "Divine Bless Cooldown" => "Перезарядка божественности",
            "Abyssal Diving Suit Plates Durability" => "Прочность пластин глубоководного водолазного костюма",
            "Abyssal Diving Suit Broken Plates" => "Сломанные пластины глубоководного водолазного костюма",
            "Draconic Surge Cooldown" => "Перезарядка драконьего всплеска",
            "Contact Damage Halving Cooldown" => "Перезарядка сокращения контактного урона вдвое",
            "Dodge Cooldown" => "Перезарядка уклонения",
            "God Slayer Dash Cooldown" => "Перезарядка рывка богоубийцы",
            "Ink Bomb Cooldown" => "Перезарядка чернильной бомбы",
            "Energy Shell Cooldown" => "Перезарядка энергетического панциря",
            "Nebulous Core Cooldown" => "Перезарядка ядра туманности",
            "Abyssal Madness Cooldown" => "Перезарядка безумия бездны",
            "Abyssal Madness" => "Безумие бездны",
            "Permafrost's Concoction Cooldown" => "Перезарядка варева Пермафроста",
            "Plague Blackout Cooldown" => "Перезарядка чумного ослепления",
            "Healing Cooldown" => "Перезарядка зелий лечения",
            "Prismatic Laser Barrage Cooldown" => "Перезарядка призматического лазерного шквала",
            "Profaned Soul Artifact Burnout" => "Сожжение осквернённого артефакта душ",
            "Relic of Resilience Cooldown" => "Перезарядка реликвии устойчивости",
            "Rogue Booster Cooldown" => "Перезарядка усилителя разбойника",
            "Sand Cloak Cooldown" => "Перезарядка песчаного плаща",
            "Sandsmoke Bomb Cooldown" => "Перезарядка бомбы песчаной завесы",
            "Sandsmoke Bomb Duration" => "Длительность бомбы песчаной завесы",
            "Silva Revive Cooldown" => "Перезарядка возрождения леса",
            "Tarragon Cloak Cooldown" => "Перезарядка плаща таррагона",
            "Tarragon Immunity Cooldown" => "Перезарядка неуязвимости таррагона",
            "Universe Splitter Cooldown" => "Перезарядка рассекателя вселенной",
            "Wulfrum Bastion Cooldown" => "Перезарядка вульфрумового бастиона",
            "Power Armor Durability" => "Прочность силовой брони",
            "Protective Matrix Durability" => "Прочность защитной матрицы",
            "Protective Matrix Recharge" => "Перезарядка защитной матрицы",
            _ => cursortext
        };
        
        orig.Invoke(self, cursortext, rare, diff, hackedmousex, hackedmousey, hackedscreenwidth, hackedscreenheight, pushwidthx);
    }
}