using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Fargowiltas.NPCs;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.GlobalModifications;

[JITWhenModsEnabled("Fargowiltas")]
public class FargoTownNpcNames : GlobalNPC
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyNPCNameList(NPC npc, List<string> nameList)
    {
        if (npc.type == ModContent.NPCType<Abominationn>())
        {
            nameList.Clear();
            nameList.AddRange(new[] { "Вилта", "Джек", "Харли", "Жнец", "Стивенн", "Дуф", "Бару", "Фергус", "Энтев", "Катастроф", "Бардо", "Бетсон" });
        }
        
        if (npc.type == ModContent.NPCType<Deviantt>())
        {
            nameList.Clear();
            nameList.AddRange(new[] { "Акира", "Реми", "Саку", "Сейра", "Кои", "Элли", "Лори", "Калия", "Тери", "Артт", "Флан", "Сион", "Тьюи" });
        }
        
        if (npc.type == ModContent.NPCType<LumberJack>())
        {
            nameList.Clear();
            nameList.AddRange(new[] { "Грифф", "Джек", "Брюс", "Ларри", "Уилл", "Джерри", "Лиам", "Стэн", "Ли", "Вуди", "Лейф", "Пауло" });
        }
        
        if (npc.type == ModContent.NPCType<Mutant>())
        {
            nameList.Clear();
            nameList.AddRange(new[] { "Флакен", "Дорф", "Бинго", "Ханс", "Фарго", "Грим", "Майк", "Фаргу", "Терренс", "Кэтти Н. Пэм", "Том", "Вердус", "Полли" });
        }
        
        if (npc.type == ModContent.NPCType<Squirrel>())
        {
            nameList.Clear();
            nameList.AddRange(new[] { "Рик", "Жёлудь", "Пуфф", "Коко", "Трюфель", "Фурго", "Пискун" });
        }
    }
}