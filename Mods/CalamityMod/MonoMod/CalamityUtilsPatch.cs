using System.Linq;
using System.Reflection;
using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.RuntimeDetour.HookGen;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class CalamityUtilsPatch : ILEdit
{
    private MethodInfo _generateRandomAlphanumericString => typeof(CalamityUtils).GetCachedMethod(nameof(CalamityUtils.GenerateRandomAlphanumericString));

    private delegate string orig_GenerateRandomAlphanumericString(int length);
    private delegate string hook_GenerateRandomAlphanumericString(orig_GenerateRandomAlphanumericString orig, int length);

    private event hook_GenerateRandomAlphanumericString GenerateRandomAlphanumericString
    {
        add => HookEndpointManager.Add<hook_GenerateRandomAlphanumericString>(_generateRandomAlphanumericString, value);
        remove => HookEndpointManager.Remove<hook_GenerateRandomAlphanumericString>(_generateRandomAlphanumericString, value);
    }

    public override bool Autoload() => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override void Load()
    {
        GenerateRandomAlphanumericString += Translation;
    }

    public override void Unload()
    {
        GenerateRandomAlphanumericString -= Translation;
    }

    private string Translation(orig_GenerateRandomAlphanumericString orig, int length)
    {
        string alphanumericCharacters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789";
        return new string(Enumerable.Repeat(alphanumericCharacters, length).Select(s => s[Main.rand.Next(s.Length)]).ToArray());
    }
}