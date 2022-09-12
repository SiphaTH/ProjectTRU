using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class DraedonLogSnowBiomeGUIPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(DraedonLogSnowBiomeGUI).GetCachedMethod(nameof(DraedonLogSnowBiomeGUI.GetTextByPage));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "A freezing tundra, where only creatures entirely adapted to the subzero temperatures exist and thrive. It is a shocking transition from the forests of the purity and the sun baked desert. A climate like this should not exist naturally in this part of the world with ease. The weather patterns seem to shift unnaturally arounds the skies of these icy plains. There is likely a reason for this, which necessitates further research.", "Холодная тундра, где существуют и процветают существа, полностью приспособленные к минусовым температурам. Это шокирующий переход от чистых лесов и выжженной солнцем пустыни. Климат, подобный этому, не должен существовать естественно. Погодные условия на этих ледяных равнинах неестественны. Вероятно, этому есть причина, которая требует дальнейших исследований.");
        TranslationHelper.ModifyIL(il, "I am not the only singular being to inhabit this biome. Once before, the Archmage who opposed the Lord resided here, cloaked by constant artificial blizzards of his own creation, which no longer fall. He likely chose this place as a conduit for research into his ice spells, and extended the period of time that this place remained frozen. Deep underground my research and materials lay well protected, but above in the natural storms there are traces of the prison of ice he resides in, still haunting its place of creation.", "Я не единственное разумное существо, находившееся в этом биоме. До этого здесь жил Архимаг, противостоявший Лорду. Скорее всего, он выбрал это место для изучения ледяных заклятий, одно из которых — нескончаемые ледяные бури. Его действия поддерживали биом в глубокой заморозке. Глубоко под землёй мои исследования хорошо защищены, но снаружи, в естественных бурях, есть следы ледяной тюрьмы, в которой он пребывает по сей день, всё ещё бродящей в месте своего создания.");
        TranslationHelper.ModifyIL(il, "Intriguing. Though embedded deep into the caverns of ice and worn from centuries of frost and meltwater, I have uncovered several mechanisms which once filled the tunnels here. The ingenuity present is remarkable, and I have found parallels within my own work, as well as devices even I have something to learn from. From where do these come? Why machinery so complex in so sparse and dreary a habitat? Perhaps, they are related to the unnatural conditions.", "Интригующе. Я нашёл механизмы, когда-то заполнявшие туннели. Они находились в ледяных пещерах, поломанные из-за веков во льду и талой воде. Мастерство исполнения поражает. Я нашёл схожести с моими работами, а также узнал что-то новое. Но кто их создал? Почему настолько сложные машины находятся в такой скудной и унылой среде обитания? Возможно, именно они виноваты в настолько неестественных условиях.");
    };
}