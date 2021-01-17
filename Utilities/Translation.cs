using System;
using System.Collections.Generic;
using System.Text;
using CalamityRuTranslate.Mods.CalamityMod;
using CalamityRuTranslate.Mods.ThoriumMod;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using static System.Linq.Enumerable;

namespace CalamityRuTranslate.Utilities
{
    public static class Translation
    {
        public static bool IsRussianLanguage => LanguageManager.Instance.ActiveCulture == GameCulture.Russian;

        public static bool CheckRussian(this string text)
        {
            if (text.Length == 0)
            {
                return true;
            }
            char symbol = text[0];
            return symbol >= 'а' && 'я' >= symbol || symbol >= 'А' && 'Я' >= symbol;
        }

        public static string KeyText(string key) => CalamityRuTranslate.translations[$"Mods.CalamityRuTranslate.{key}"].GetTranslation(Language.ActiveCulture);
        
        public static string KeyText2(string key) => Language.GetTextValue($"Mods.CalamityRuTranslate.{key}");

        public static void ILTranslate(ILContext il, string original, string translation, int iterations = 1)
        {
            var cursor = new ILCursor(il);

            for (int j = 0; j < iterations; j++)
            {
                if (!cursor.TryGotoNext(i => i.MatchLdstr(original)))
                {
                    CalamityRuTranslate.Instance.Logger.Warn($"IL failed when trying edit \"{original}\" with \"{translation}\"");
                    return;
                }
            }

            cursor.Index++;
            cursor.Emit(OpCodes.Pop);
            cursor.Emit(OpCodes.Ldstr, translation);
        }

        public static string EncodeToUtf16(string line)
        {
            Dictionary<char, string> unicode = new Dictionary<char, string>
            {
                {'А', "\u0410"},
                {'а', "\u0430"},
                {'Б', "\u0411"},
                {'б', "\u0431"},
                {'В', "\u0412"},
                {'в', "\u0432"},
                {'Г', "\u0413"},
                {'г', "\u0433"},
                {'Д', "\u0414"},
                {'д', "\u0434"},
                {'Е', "\u0415"},
                {'е', "\u0435"},
                {'Ё', "\u0401"},
                {'ё', "\u0451"},
                {'Ж', "\u0416"},
                {'ж', "\u0436"},
                {'З', "\u0417"},
                {'з', "\u0437"},
                {'И', "\u0418"},
                {'и', "\u0438"},
                {'Й', "\u0419"},
                {'й', "\u0439"},
                {'К', "\u041A"},
                {'к', "\u043A"},
                {'Л', "\u041B"},
                {'л', "\u043B"},
                {'М', "\u041C"},
                {'м', "\u043C"},
                {'Н', "\u041D"},
                {'н', "\u043D"},
                {'О', "\u041E"},
                {'о', "\u043E"},
                {'П', "\u041F"},
                {'п', "\u043F"},
                {'Р', "\u0420"},
                {'р', "\u0440"},
                {'С', "\u0421"},
                {'с', "\u0441"},
                {'Т', "\u0422"},
                {'т', "\u0442"},
                {'У', "\u0423"},
                {'у', "\u0443"},
                {'Ф', "\u0424"},
                {'ф', "\u0444"},
                {'Х', "\u0425"},
                {'х', "\u0445"},
                {'Ц', "\u0426"},
                {'ц', "\u0446"},
                {'Ч', "\u0427"},
                {'ч', "\u0447"},
                {'Ш', "\u0428"},
                {'ш', "\u0448"},
                {'Щ', "\u0429"},
                {'щ', "\u0449"},
                {'Ъ', "\u042A"},
                {'ъ', "\u044A"},
                {'Ы', "\u042B"},
                {'ы', "\u044B"},
                {'Ь', "\u042C"},
                {'ь', "\u044C"},
                {'Э', "\u042D"},
                {'э', "\u044D"},
                {'Ю', "\u042E"},
                {'ю', "\u044E"},
                {'Я', "\u042F"},
                {'я', "\u044F"},
                {' ', "\u0020"},
                {'!', "\u0021"},
                {'?', "\u003F"},
                {';', "\u003B"},
                {'.', "\u002e"},
                {':', "\u003a"},
                {'—', "\u2014"},
                {'-', "\u002D"},
                {'(', "\u0028"},
                {')', "\u0029"},
                {'%', "\u0025"},
                {'»', "\u00BB"},
                {'«', "\u00AB"},
                {',', "\u002C"},
                {'\'', "\u0027"},
                {'/', "\u002F"},
                {'[', "\u005b"},
                {']', "\u005d"},
                {'0', "\u0030"},
                {'1', "\u0031"},
                {'2', "\u0032"},
                {'3', "\u0033"},
                {'4', "\u0034"},
                {'5', "\u0035"},
                {'6', "\u0036"},
                {'7', "\u0037"},
                {'8', "\u0038"},
                {'9', "\u0039"}
            };
            StringBuilder builder = new StringBuilder();
            foreach (char @char in line)
            {
                if (unicode.ContainsKey(@char))
                {
                    builder.Append(unicode[@char]);
                }
                else if (Range('a', 'z').Contains(@char) || Range('A', 'Z').Contains(@char) || @char == '\n')
                {
                    builder.Append(@char);
                }
                else
                {
                    throw new Exception($"Ошибка загрузки символа: {@char}, {builder}");
                }
            }

            Encoding u16 = Encoding.GetEncoding("UTF-16");
            return u16.GetString(u16.GetBytes(builder.ToString()));
        }
		
         public static bool GlobalTownNpcName(NPC npc)
         {
             return npc.type == NPCID.Guide ||
                    npc.type == NPCID.Merchant ||
                    npc.type == NPCID.Nurse ||
                    npc.type == NPCID.Demolitionist ||
                    npc.type == NPCID.DyeTrader ||
                    npc.type == NPCID.Dryad ||
                    npc.type == NPCID.ArmsDealer ||
                    npc.type == NPCID.Stylist ||
                    npc.type == NPCID.Painter ||
                    npc.type == NPCID.Angler ||
                    npc.type == NPCID.GoblinTinkerer ||
                    npc.type == NPCID.WitchDoctor ||
                    npc.type == NPCID.Clothier ||
                    npc.type == NPCID.Mechanic ||
                    npc.type == NPCID.PartyGirl ||
                    npc.type == NPCID.Wizard ||
                    npc.type == NPCID.TaxCollector ||
                    npc.type == NPCID.Truffle ||
                    npc.type == NPCID.Pirate ||
                    npc.type == NPCID.Steampunker ||
                    npc.type == NPCID.Cyborg ||
                    npc.type == NPCID.TravellingMerchant ||
                    npc.type == NPCID.SkeletonMerchant ||
                    npc.type == CoreCalamityTranslation.CalamityMod?.NPCType("DILF") ||
                    npc.type == CoreCalamityTranslation.CalamityMod?.NPCType("FAP") ||
                    npc.type == CoreCalamityTranslation.CalamityMod?.NPCType("SEAHOE") ||
                    npc.type == CoreCalamityTranslation.CalamityMod?.NPCType("THIEF") ||
                    npc.type == CoreThoriumTranslation.ThoriumMod?.NPCType("Blacksmith") ||
                    npc.type == CoreThoriumTranslation.ThoriumMod?.NPCType("Cobbler") ||
                    npc.type == CoreThoriumTranslation.ThoriumMod?.NPCType("ConfusedZombie") ||
                    npc.type == CoreThoriumTranslation.ThoriumMod?.NPCType("Cook") ||
                    npc.type == CoreThoriumTranslation.ThoriumMod?.NPCType("DesertTraveler") ||
                    npc.type == CoreThoriumTranslation.ThoriumMod?.NPCType("Diverman") ||
                    npc.type == CoreThoriumTranslation.ThoriumMod?.NPCType("Druid") ||
                    npc.type == CoreThoriumTranslation.ThoriumMod?.NPCType("Spiritualist") ||
                    npc.type == CoreThoriumTranslation.ThoriumMod?.NPCType("Tracker") ||
                    npc.type == CoreThoriumTranslation.ThoriumMod?.NPCType("WeaponMaster");
         }
    }
}