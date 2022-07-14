using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using CalamityRuTranslate.Core.Loaders;
using CalamityRuTranslate.Core.MonoMod;
using CalamityRuTranslate.Mods.CalamityMod;
using CalamityRuTranslate.Mods.Fargowiltas;
using Terraria;
using Terraria.GameContent.UI.States;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate;

public class CalamityRuTranslate : Mod, IPatchRepository
{
    public static CalamityRuTranslate Instance;
    public List<IMonoModPatch> Patches { get; } = new();
    public readonly SetupTranslation[] Mods =
    {
        new CalamityTranslation(),
        new FargowiltasTranslation(),
    };

    public CalamityRuTranslate()
    {
        Instance = this;
        MonoModHooks.RequestNativeAccess();
    }

    public override void Load()
    {
        LangLoader.Load();
        ILManager.Load();

        if (ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage)
            CalamityReflection.Load();

        if (!Main.dedServ && TranslationHelper.IsRussianLanguage)
        {
            ConstructorInfo uiManageControlsConstructor = typeof(UIManageControls).GetConstructor(Type.EmptyTypes);
            object uiManageControlsObject = uiManageControlsConstructor?.Invoke(new object[]{});
            MethodInfo onInitialize = typeof(UIManageControls).GetMethod("OnInitialize", BindingFlags.Instance | BindingFlags.Public);
            onInitialize?.Invoke(uiManageControlsObject, null);
        }
    }
    
    public override void Unload()
    {
        Instance = null;
        TRuConfig.Instance = null;
        LangLoader.Unload();
        ILManager.Unload();

        foreach (IMonoModPatch patch in Patches)
            patch.Unapply();
    }

    public override void PostSetupContent()
    {
        foreach (SetupTranslation mod in Mods)
            mod.LoadSetupContentTranslation();

        if (TRuConfig.Instance.WikithisInfo && ModsCall.TryGetWikithis && !Main.dedServ)
        {
            if (ModsCall.TryGetCalamity)
            {
                ModsCall.Wikithis.Call(0, ModsCall.Calamity, "calamitymod.wiki.gg");
                ModsCall.Wikithis.Call(0, ModsCall.Calamity, "terraria-calamity-mod.fandom.com/ru", GameCulture.CultureName.Russian);
            }
        }
    }
}