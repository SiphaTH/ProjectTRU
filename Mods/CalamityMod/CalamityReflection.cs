using System.Collections.Generic;
using System.Reflection;
using CalamityMod;
using CalamityMod.DataStructures;
using CalamityMod.Items.Placeables.Furniture.DevPaintings;
using CalamityMod.NPCs.CeaselessVoid;
using CalamityMod.NPCs.Ravager;
using CalamityMod.Systems;
using CalamityMod.UI;
using CalamityMod.UI.CalamitasEnchants;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class CalamityReflection : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override float Priority => 1f;
    
    public void LoadContent()
    {
        List<(string, string)> enchantmentTranslation = new List<(string, string)>
        {
            (LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Exhume.Name"), LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Exhume.Description")),
            (LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Indignant.Name"), LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Indignant.Description")),
            (LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Aflame.Name"), LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Aflame.Description")),
            (LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Oblatory.Name"), LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Oblatory.Description")),
            (LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Resentful.Name"), LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Resentful.Description")),
            (LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Bloodthirsty.Name"), LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Bloodthirsty.Description")),
            (LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Ephemeral.Name"), LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Ephemeral.Description")),
            (LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Hellbound.Name"), LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Hellbound.Description")),
            (LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Tainted.Name"), LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Tainted.Description")),
            (LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Traitorous.Name"), LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Traitorous.Description")),
            (LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Withering.Name"), LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Withering.Description")),
            (LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Persecuted.Name"), LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Persecuted.Description")),
            (LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Lecherous.Name"), LangHelper.GetText("CalamityMod.Prefixes.Enchantments.Lecherous.Description"))
        };
        
        Dictionary<int, BossHealthBarManager.BossEntityExtension> dictionary = new Dictionary<int, BossHealthBarManager.BossEntityExtension>
        {
            {13, new BossHealthBarManager.BossEntityExtension("Сегментов", 13, 14, 15)},
            {266, new BossHealthBarManager.BossEntityExtension("Проныр", 267)},
            {35, new BossHealthBarManager.BossEntityExtension("Рук", 36)},
            {127, new BossHealthBarManager.BossEntityExtension("Вооружений", 128, 129, 130, 131)},
            {395, new BossHealthBarManager.BossEntityExtension("Ружий", 393, 394)},
            {491, new BossHealthBarManager.BossEntityExtension("Пушек", 492)},
            {ModContent.NPCType<CeaselessVoid>(), new BossHealthBarManager.BossEntityExtension("Тёмной энергии", ModContent.NPCType<DarkEnergy>())},
            {ModContent.NPCType<RavagerBody>(), new BossHealthBarManager.BossEntityExtension("Частей тела", ModContent.NPCType<RavagerClawLeft>(), ModContent.NPCType<RavagerClawRight>(), ModContent.NPCType<RavagerLegLeft>(), ModContent.NPCType<RavagerLegRight>())},
        };
        BossHealthBarManager.EntityExtensionHandler = dictionary;
        
        if (typeof(AstralArcanumUI).GetField("CircleNames", BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(null) is string[] circleNames)
        {
            circleNames[0] = LangHelper.GetText("CalamityMod.Items.AstralArcanum.CircleNames.Hell");
            circleNames[1] = LangHelper.GetText("CalamityMod.Items.AstralArcanum.CircleNames.Dungeon");
            circleNames[2] = LangHelper.GetText("CalamityMod.Items.AstralArcanum.CircleNames.Jungle");
            circleNames[3] = LangHelper.GetText("CalamityMod.Items.AstralArcanum.CircleNames.Random");
        }
        
        if (typeof(EnchantmentManager).GetProperty("EnchantmentList", BindingFlags.Public | BindingFlags.Static)?.GetValue(null) is List<Enchantment> enchantmentList)
        {
            for (int i = 0; i < enchantmentList.Count; i++)
            {
                Enchantment currentEnchantment = enchantmentList[i];
                currentEnchantment.Name = enchantmentTranslation[i].Item1;
                currentEnchantment.Description = enchantmentTranslation[i].Item2;
                enchantmentList[i] = currentEnchantment;
            }
        }

        PropertyInfo enchantment = typeof(EnchantmentManager).GetProperty("ClearEnchantment", BindingFlags.Public | BindingFlags.Static);
        enchantment?.SetValue(typeof(Enchantment), new Enchantment(LangHelper.GetText("CalamityMod.Prefixes.Enchantments.ClearEnchantment.Name"), string.Empty, -18591774, null, item => 
        {
            item.Calamity().AppliedEnchantment = new Enchantment?();
            item.Calamity().DischargeEnchantExhaustion = 0.0f;
        }, item => item.IsEnchantable() && item.shoot >= 0));

        Attunement.attunementArray[0].name = LangHelper.GetText("CalamityMod.Attunements.DefaultAttunement.Name");
        Attunement.attunementArray[0].function_description = LangHelper.GetText("CalamityMod.Attunements.DefaultAttunement.Function_Description");
        Attunement.attunementArray[1].name = LangHelper.GetText("CalamityMod.Attunements.HotAttunement.Name");
        Attunement.attunementArray[1].function_description = LangHelper.GetText("CalamityMod.Attunements.HotAttunement.Function_Description");
        Attunement.attunementArray[2].name = LangHelper.GetText("CalamityMod.Attunements.ColdAttunement.Name");
        Attunement.attunementArray[2].function_description = LangHelper.GetText("CalamityMod.Attunements.ColdAttunement.Function_Description");
        Attunement.attunementArray[3].name = LangHelper.GetText("CalamityMod.Attunements.TropicalAttunement.Name");
        Attunement.attunementArray[3].function_description = LangHelper.GetText("CalamityMod.Attunements.TropicalAttunement.Function_Description");
        Attunement.attunementArray[4].name = LangHelper.GetText("CalamityMod.Attunements.EvilAttunement.Name");
        Attunement.attunementArray[4].function_description = LangHelper.GetText("CalamityMod.Attunements.EvilAttunement.Function_Description");
        Attunement.attunementArray[5].name = LangHelper.GetText("CalamityMod.Attunements.TrueDefaultAttunement.Name");
        Attunement.attunementArray[5].function_description = LangHelper.GetText("CalamityMod.Attunements.TrueDefaultAttunement.Function_Description");
        Attunement.attunementArray[5].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.TrueDefaultAttunement.Function_Description_Extra");
        Attunement.attunementArray[6].name = LangHelper.GetText("CalamityMod.Attunements.TrueHotAttunement.Name");
        Attunement.attunementArray[6].function_description = LangHelper.GetText("CalamityMod.Attunements.TrueHotAttunement.Function_Description");
        Attunement.attunementArray[6].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.TrueHotAttunement.Function_Description_Extra");
        Attunement.attunementArray[7].name = LangHelper.GetText("CalamityMod.Attunements.TrueColdAttunement.Name");
        Attunement.attunementArray[7].function_description = LangHelper.GetText("CalamityMod.Attunements.TrueColdAttunement.Function_Description");
        Attunement.attunementArray[7].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.TrueColdAttunement.Function_Description_Extra");
        Attunement.attunementArray[8].name = LangHelper.GetText("CalamityMod.Attunements.TrueTropicalAttunement.Name");
        Attunement.attunementArray[8].function_description = LangHelper.GetText("CalamityMod.Attunements.TrueTropicalAttunement.Function_Description");
        Attunement.attunementArray[8].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.TrueTropicalAttunement.Function_Description_Extra");
        Attunement.attunementArray[9].name = LangHelper.GetText("CalamityMod.Attunements.TrueEvilAttunement.Name");
        Attunement.attunementArray[9].function_description = LangHelper.GetText("CalamityMod.Attunements.TrueEvilAttunement.Function_Description");
        Attunement.attunementArray[9].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.TrueEvilAttunement.Function_Description_Extra");
        Attunement.attunementArray[10].name = LangHelper.GetText("CalamityMod.Attunements.HolyAttunement.Name");
        Attunement.attunementArray[10].function_description = LangHelper.GetText("CalamityMod.Attunements.HolyAttunement.Function_Description");
        Attunement.attunementArray[10].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.HolyAttunement.Function_Description_Extra");
        Attunement.attunementArray[11].name = LangHelper.GetText("CalamityMod.Attunements.AstralAttunement.Name");
        Attunement.attunementArray[11].function_description = LangHelper.GetText("CalamityMod.Attunements.AstralAttunement.Function_Description");
        Attunement.attunementArray[11].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.AstralAttunement.Function_Description_Extra");
        Attunement.attunementArray[12].name = LangHelper.GetText("CalamityMod.Attunements.MarineAttunement.Name");
        Attunement.attunementArray[12].function_description = LangHelper.GetText("CalamityMod.Attunements.MarineAttunement.Function_Description");
        Attunement.attunementArray[12].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.MarineAttunement.Function_Description_Extra");
        Attunement.attunementArray[13].name = LangHelper.GetText("CalamityMod.Attunements.WhirlwindAttunement.Name");
        Attunement.attunementArray[13].function_description = LangHelper.GetText("CalamityMod.Attunements.WhirlwindAttunement.Function_Description");
        Attunement.attunementArray[13].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.WhirlwindAttunement.Function_Description_Extra");
        Attunement.attunementArray[13].passive_description = LangHelper.GetText("CalamityMod.Attunements.WhirlwindAttunement.Passive_Description");
        Attunement.attunementArray[14].name = LangHelper.GetText("CalamityMod.Attunements.FlailBladeAttunement.Name");
        Attunement.attunementArray[14].function_description = LangHelper.GetText("CalamityMod.Attunements.FlailBladeAttunement.Function_Description");
        Attunement.attunementArray[14].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.FlailBladeAttunement.Function_Description_Extra");
        Attunement.attunementArray[14].passive_description = LangHelper.GetText("CalamityMod.Attunements.FlailBladeAttunement.Passive_Description");
        Attunement.attunementArray[15].name = LangHelper.GetText("CalamityMod.Attunements.SuperPogoAttunement.Name");
        Attunement.attunementArray[15].function_description = LangHelper.GetText("CalamityMod.Attunements.SuperPogoAttunement.Function_Description");
        Attunement.attunementArray[15].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.SuperPogoAttunement.Function_Description_Extra");
        Attunement.attunementArray[15].passive_description = LangHelper.GetText("CalamityMod.Attunements.SuperPogoAttunement.Passive_Description");
        Attunement.attunementArray[16].name = LangHelper.GetText("CalamityMod.Attunements.ShockwaveAttunement.Name");
        Attunement.attunementArray[16].function_description = LangHelper.GetText("CalamityMod.Attunements.ShockwaveAttunement.Function_Description");
        Attunement.attunementArray[16].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.ShockwaveAttunement.Function_Description_Extra");
        Attunement.attunementArray[16].passive_description = LangHelper.GetText("CalamityMod.Attunements.ShockwaveAttunement.Passive_Description");
        Attunement.attunementArray[17].name = LangHelper.GetText("CalamityMod.Attunements.PhoenixAttunement.Name");
        Attunement.attunementArray[17].function_description = LangHelper.GetText("CalamityMod.Attunements.PhoenixAttunement.Function_Description");
        Attunement.attunementArray[17].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.PhoenixAttunement.Function_Description_Extra");
        Attunement.attunementArray[17].passive_name = LangHelper.GetText("CalamityMod.Attunements.PhoenixAttunement.Passive_Name");
        Attunement.attunementArray[17].passive_description = LangHelper.GetText("CalamityMod.Attunements.PhoenixAttunement.Passive_Description");
        Attunement.attunementArray[18].name = LangHelper.GetText("CalamityMod.Attunements.AriesAttunement.Name");
        Attunement.attunementArray[18].function_description = LangHelper.GetText("CalamityMod.Attunements.AriesAttunement.Function_Description");
        Attunement.attunementArray[18].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.AriesAttunement.Function_Description_Extra");
        Attunement.attunementArray[18].passive_name = LangHelper.GetText("CalamityMod.Attunements.AriesAttunement.Passive_Name");
        Attunement.attunementArray[18].passive_description = LangHelper.GetText("CalamityMod.Attunements.AriesAttunement.Passive_Description");
        Attunement.attunementArray[19].name = LangHelper.GetText("CalamityMod.Attunements.PolarisAttunement.Name");
        Attunement.attunementArray[19].function_description = LangHelper.GetText("CalamityMod.Attunements.PolarisAttunement.Function_Description");
        Attunement.attunementArray[19].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.PolarisAttunement.Function_Description_Extra");
        Attunement.attunementArray[19].passive_name = LangHelper.GetText("CalamityMod.Attunements.PolarisAttunement.Passive_Name");
        Attunement.attunementArray[19].passive_description = LangHelper.GetText("CalamityMod.Attunements.PolarisAttunement.Passive_Description");
        Attunement.attunementArray[20].name = LangHelper.GetText("CalamityMod.Attunements.AndromedaAttunement.Name");
        Attunement.attunementArray[20].function_description = LangHelper.GetText("CalamityMod.Attunements.AndromedaAttunement.Function_Description");
        Attunement.attunementArray[20].function_description_extra = LangHelper.GetText("CalamityMod.Attunements.AndromedaAttunement.Function_Description_Extra");
        Attunement.attunementArray[20].passive_name = LangHelper.GetText("CalamityMod.Attunements.AndromedaAttunement.Passive_Name");
        Attunement.attunementArray[20].passive_description = LangHelper.GetText("CalamityMod.Attunements.AndromedaAttunement.Passive_Description");

        DifficultyModeSystem.Difficulties[0].Name = LangHelper.GetText("CalamityMod.DifficultyModeSystem.Difficulties.None.Name");
        DifficultyModeSystem.Difficulties[0].ShortDescription = LangHelper.GetText("CalamityMod.DifficultyModeSystem.Difficulties.None.ShortDescription");
        DifficultyModeSystem.Difficulties[1].Name = LangHelper.GetText("CalamityMod.DifficultyModeSystem.Difficulties.Revengeance.Name");
        DifficultyModeSystem.Difficulties[1].ShortDescription = LangHelper.GetText("CalamityMod.DifficultyModeSystem.Difficulties.Revengeance.ShortDescription");
        DifficultyModeSystem.Difficulties[2].Name = LangHelper.GetText("CalamityMod.DifficultyModeSystem.Difficulties.Death.Name");
        DifficultyModeSystem.Difficulties[2].ShortDescription = LangHelper.GetText("CalamityMod.DifficultyModeSystem.Difficulties.Death.ShortDescription");
        DifficultyModeSystem.Difficulties[3].Name = LangHelper.GetText("CalamityMod.DifficultyModeSystem.Difficulties.Malice.Name");
        DifficultyModeSystem.Difficulties[3].ShortDescription = LangHelper.GetText("CalamityMod.DifficultyModeSystem.Difficulties.Malice.ShortDescription");

        ThankYouPainting.devList.RemoveAt(0);
        ThankYouPainting.devList.Insert(0, "Fabsol, основатель и владелец мода");
    }

    public void UnloadContent() { }
}