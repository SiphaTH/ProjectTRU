using System.Collections.Generic;
using CalamityMod.NPCs.TownNPCs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications;

[JITWhenModsEnabled("CalamityMod")]
public class CalamityTownNpcNames : GlobalNPC
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyNPCNameList(NPC npc, List<string> nameList)
    {
        if (npc.type == ModContent.NPCType<DILF>())
        {
            nameList.Clear();
            nameList.AddRange(new[] { "Пермафрост" });
        }

        if (npc.type == ModContent.NPCType<FAP>())
        {
            nameList.Clear();
            nameList.AddRange(new[] { "Циррус" });
        }
        
        if (npc.type == ModContent.NPCType<SEAHOE>())
        {
            nameList.Clear();
            nameList.AddRange(new[] { "Амидиас" });
        }
        
        if (npc.type == ModContent.NPCType<THIEF>())
        {
            nameList.Clear();
            nameList.AddRange(new[] { "Иксплиззи", "Причуда", "Лаура", "Миэ", "Бонни", "Сара", "Диана", "Кейт", "Пенелопа", "Мариса", "Марибель", "Валери", "Джессика", "Роуэн", "Джесси", "Джейд", "Хин", "Эмбер", "Энн", "Индиана" });
        }
        
        if (npc.type == ModContent.NPCType<WITCH>())
        {
            nameList.Clear();
            nameList.AddRange(new[] { "Каламитас" });
        }
    }
}