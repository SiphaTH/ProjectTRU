using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Terraria;
using Terraria.ModLoader;
using Item = On.Terraria.Item;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class AffixName : ILEdit
{
    public override bool Autoload() => TranslationHelper.IsRussianLanguage && !ModsCall.TryGetCalamity;

    public override void Load() => Item.AffixName += ItemOnAffixName;

    public override void Unload() => Item.AffixName -= ItemOnAffixName;

    private string ItemOnAffixName(Item.orig_AffixName orig, Terraria.Item self)
    {
        if (self.prefix < 0 && self.prefix >= Lang.prefix.Length)
            return self.Name;

        string prefix = Lang.prefix[self.prefix].Value;
        if (prefix == string.Empty)
            return self.Name;

        foreach (var t in RussianPrefixOverhaul.Prefixes)
        {
            if (t[0] == prefix)
                return RussianPrefixOverhaul.GetGenderedPrefix(t, self.type) + " " +
                       self.Name.ToLower();
        }

        return prefix + " " + self.Name;
    }
}

[JITWhenModsEnabled("CalamityMod")]
public class AffixNameWithCalamity : ILEdit
{
    public override bool Autoload() => TranslationHelper.IsRussianLanguage && ModsCall.TryGetCalamity;

    public override void Load() => Item.AffixName += ItemOnAffixName;

    public override void Unload() => Item.AffixName -= ItemOnAffixName;

    private string ItemOnAffixName(Item.orig_AffixName orig, Terraria.Item self)
    {
        string calamityEnchantment = string.Empty;
        string goblinPrefix = string.Empty;

        foreach (string[] t in RussianPrefixOverhaul.Prefixes)
        {
            if (!self.IsAir && self.Calamity().AppliedEnchantment != null)
            {
                if (t[0] == self.Calamity().AppliedEnchantment?.Name)
                    calamityEnchantment = RussianPrefixOverhaul.GetGenderedPrefix(t, self.type) + " ";

                if (calamityEnchantment != string.Empty)
                    goblinPrefix = goblinPrefix.ToLower();
            }

            if (t[0] == Lang.prefix[self.prefix].Value)
                goblinPrefix = RussianPrefixOverhaul.GetGenderedPrefix(t, self.type) + " ";
        }

        if (goblinPrefix == string.Empty && calamityEnchantment == string.Empty)
            return self.Name;

        return calamityEnchantment + goblinPrefix + self.Name.ToLower();
    }
}