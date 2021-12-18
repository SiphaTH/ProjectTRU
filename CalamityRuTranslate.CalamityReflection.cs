using System.Collections.Generic;
using System.Reflection;
using CalamityMod;
using CalamityMod.NPCs.CeaselessVoid;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.SlimeGod;
using CalamityMod.UI;
using CalamityMod.UI.CalamitasEnchants;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityRuTranslate
{
    public partial class CalamityRuTranslate
    {
        private void CalamityReflections()
        {
            List<(string, string)> enchantmentTranslation = new List<(string, string)>
            {
                (LangHelper.GetText("Calamity.EnchantmentName.Exhume"), LangHelper.GetText("Calamity.EnchantmentDesc.Exhume")),
                (LangHelper.GetText("Calamity.EnchantmentName.Indignant"), LangHelper.GetText("Calamity.EnchantmentDesc.Indignant")),
                (LangHelper.GetText("Calamity.EnchantmentName.Aflame"), LangHelper.GetText("Calamity.EnchantmentDesc.Aflame")),
                (LangHelper.GetText("Calamity.EnchantmentName.Oblatory"), LangHelper.GetText("Calamity.EnchantmentDesc.Oblatory")),
                (LangHelper.GetText("Calamity.EnchantmentName.Resentful"), LangHelper.GetText("Calamity.EnchantmentDesc.Resentful")),
                (LangHelper.GetText("Calamity.EnchantmentName.Bloodthirsty"), LangHelper.GetText("Calamity.EnchantmentDesc.Bloodthirsty")),
                (LangHelper.GetText("Calamity.EnchantmentName.Ephemeral"), LangHelper.GetText("Calamity.EnchantmentDesc.Ephemeral")),
                (LangHelper.GetText("Calamity.EnchantmentName.Hellbound"), LangHelper.GetText("Calamity.EnchantmentDesc.Hellbound")),
                (LangHelper.GetText("Calamity.EnchantmentName.Tainted"), LangHelper.GetText("Calamity.EnchantmentDesc.Tainted")),
                (LangHelper.GetText("Calamity.EnchantmentName.Traitorous"), LangHelper.GetText("Calamity.EnchantmentDesc.Traitorous")),
                (LangHelper.GetText("Calamity.EnchantmentName.Withering"), LangHelper.GetText("Calamity.EnchantmentDesc.Withering")),
                (LangHelper.GetText("Calamity.EnchantmentName.Persecuted"), LangHelper.GetText("Calamity.EnchantmentDesc.Persecuted")),
                (LangHelper.GetText("Calamity.EnchantmentName.Lecherous"), LangHelper.GetText("Calamity.EnchantmentDesc.Lecherous")),
            };

            Dictionary<int, BossHealthBarManager.BossEntityExtension> dictionary = new Dictionary<int, BossHealthBarManager.BossEntityExtension>
            {
                {13, new BossHealthBarManager.BossEntityExtension("Сегментов", 13, 14, 15)},
                {266, new BossHealthBarManager.BossEntityExtension("Ползунов", 267)},
                {35, new BossHealthBarManager.BossEntityExtension("Рук", 36)},
                {127, new BossHealthBarManager.BossEntityExtension("Оружий", 128, 129, 130, 131)},
                {395, new BossHealthBarManager.BossEntityExtension("Ружий", 393, 394)},
                {ModContent.NPCType<CeaselessVoid>(), new BossHealthBarManager.BossEntityExtension("Тёмной энергии", ModContent.NPCType<DarkEnergy>())},
                {ModContent.NPCType<RavagerBody>(), new BossHealthBarManager.BossEntityExtension("Частей тела", ModContent.NPCType<RavagerClawLeft>(), ModContent.NPCType<RavagerClawRight>(), ModContent.NPCType<RavagerLegLeft>(), ModContent.NPCType<RavagerLegRight>())},
                {ModContent.NPCType<SlimeGodCore>(), new BossHealthBarManager.BossEntityExtension("Больших слизней", ModContent.NPCType<SlimeGod>(), ModContent.NPCType<SlimeGodSplit>(), ModContent.NPCType<SlimeGodRun>(), ModContent.NPCType<SlimeGodRunSplit>())},
            
            };
            BossHealthBarManager.EntityExtensionHandler = dictionary;

            if (typeof(AstralArcanumUI).GetField("CircleNames", BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(null) is string[] circleNames)
            {
                circleNames[0] = LangHelper.GetText("Calamity.AstralArcanumUI.CircleNames.Hell");
                circleNames[1] = LangHelper.GetText("Calamity.AstralArcanumUI.CircleNames.Dungeon");
                circleNames[2] = LangHelper.GetText("Calamity.AstralArcanumUI.CircleNames.Jungle");
                circleNames[3] = LangHelper.GetText("Calamity.AstralArcanumUI.CircleNames.Random");
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
            enchantment?.SetValue(typeof(Enchantment), new Enchantment(LangHelper.GetText("Calamity.EnchantmentName.ClearEnchantment"), string.Empty, -18591774, null, delegate(Item item)
            {
                item.Calamity().AppliedEnchantment = null;
                item.Calamity().DischargeEnchantExhaustion = 0f;
            }, item => item.IsEnchantable() && item.shoot >= ProjectileID.None));

            FieldInfo alphanumericCharacters = typeof(CalamityUtils).GetField("AlphanumericCharacters", BindingFlags.NonPublic | BindingFlags.Static);
            alphanumericCharacters?.SetValue(typeof(string), "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789");
        }
    }
}