using System;
using System.Reflection;
using CalamityMod;
using CalamityMod.Items.DraedonMisc;
using CalamityMod.TileEntities;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode;
using MonoMod.Cil;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class UtilitiesInfernalRelicText : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(Utilities).GetCachedMethod("get_InfernalRelicText");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Imbued with the infernal flames of a defeated foe", "Окружено инфернальными огнями поверженного врага");
    };
}

public class UtilitiesGetNPCFullNameFromID : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(Utilities).GetCachedMethod(nameof(Utilities.GetNPCFullNameFromID));

    private delegate string GetNPCFullNameFromIDDelegate(int id);

    public override Delegate Delegate => Translation;

    private string Translation(GetNPCFullNameFromIDDelegate orig, int id)
    {
        return id < NPCID.Count ? NPC.GetFullnameByID(id) : NPCLoader.GetNPC(id).DisplayName.GetTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian));
    }
}