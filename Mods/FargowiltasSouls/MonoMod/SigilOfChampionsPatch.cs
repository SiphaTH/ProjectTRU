using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Items.Summons;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class SigilOfChampionsPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(SigilOfChampions).GetCachedMethod(nameof(SigilOfChampions.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "A strong spirit stirs...", "Сильный дух будоражит...");
            TranslationHelper.ILTranslation(il, "The core of the planet rumbles...", "Ядро планеты урчит...");
            TranslationHelper.ILTranslation(il, "A verdant wind is blowing...", "Дует зелёный ветер...");
            TranslationHelper.ILTranslation(il, "The stones tremble around you...", "Камни дрожат вокруг вас...");
            TranslationHelper.ILTranslation(il, "The stars are aligning...", "Звезды выравниваются...");
            TranslationHelper.ILTranslation(il, "Metallic groans echo from the depths...", "Металлические стоны эхом разносятся из глубины...");
            TranslationHelper.ILTranslation(il, "A wave of warmth passes over you...", "Волна тепла проходит по тебе...");
            TranslationHelper.ILTranslation(il, "The darkness of the night feels deeper...", "Темнота ночи кажется глубже...");
            TranslationHelper.ILTranslation(il, "You are surrounded by the rustling of trees...", "Вы окружены шорохом деревьев...");
            TranslationHelper.ILTranslation(il, "Nothing seems to answer the call...", "Кажется, никто не отвечает на звонок...");
        }
    }
}