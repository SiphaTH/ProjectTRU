using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria;
using Item = On.Terraria.Item;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class AffixName : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => ModsCall.Calamity == null && TranslationHelper.IsRussianLanguage;

    public override float Priority => 1f;

    public void LoadContent() => Item.AffixName += ItemOnAffixName;

    public void UnloadContent() => Item.AffixName -= ItemOnAffixName;

    private string ItemOnAffixName(Item.orig_AffixName orig, Terraria.Item self)
    {
        if (self.prefix < 0 && self.prefix >= Lang.prefix.Length)
            return self.Name;

        string prefix = Lang.prefix[self.prefix].Value;
        PrefixOverhaul prefixOverhaul = new PrefixOverhaul();
        if (prefix == string.Empty)
            return self.Name;

        foreach (var t in prefixOverhaul.Prefixes)
        {
            if (t[0] == prefix)
                return prefixOverhaul.GetGenderedPrefix(t, self.type) + " " + self.Name.ToLower();
        }

        return prefix + " " + self.Name;
    }
}

public class AffixNameWithCalamity : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override float Priority => 1f;

    public void LoadContent() => Item.AffixName += ItemOnAffixName;

    public void UnloadContent() => Item.AffixName -= ItemOnAffixName;

    private string ItemOnAffixName(Item.orig_AffixName orig, Terraria.Item self)
    {
        string calamityEnchantment = string.Empty;
        string goblinPrefix = string.Empty;
        PrefixOverhaul prefixOverhaul = new PrefixOverhaul();
        
        foreach (string[] t in prefixOverhaul.Prefixes)
        {
            if (!self.IsAir && self.Calamity().AppliedEnchantment != null)
            {
                if (t[0] == self.Calamity().AppliedEnchantment?.Name)
                    calamityEnchantment = prefixOverhaul.GetGenderedPrefix(t, self.type) + " ";

                if (calamityEnchantment != string.Empty)
                    goblinPrefix = goblinPrefix.ToLower();
            }

            if (t[0] == Lang.prefix[self.prefix].Value)
                goblinPrefix = prefixOverhaul.GetGenderedPrefix(t, self.type) + " ";
        }

        if (goblinPrefix == string.Empty && calamityEnchantment == string.Empty)
            return self.Name;
        
        return calamityEnchantment + goblinPrefix + self.Name.ToLower();
    }
}