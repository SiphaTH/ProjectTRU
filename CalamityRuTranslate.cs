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
using CalamityRuTranslate.Mods.FargowiltasSouls;
using Terraria;
using Terraria.GameContent.UI.States;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate;

public class CalamityRuTranslate : Mod, IPatchRepository
{
    internal static CalamityRuTranslate Instance;
    public List<IMonoModPatch> Patches { get; } = new();

    public readonly SetupTranslation[] Mods =
    {
        new CalamityTranslation(),
        new FargowiltasTranslation(),
        new FargowiltasSoulsTranslation()
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

        if (ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage)
            CalamityReflection.Load();

        if (!Main.dedServ && ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage)
            FargowiltasSoulsReflection.Load();
        
        if (!Main.dedServ && ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage)
            FargowiltasReflection.Load();

        if (!Main.dedServ && TranslationHelper.IsRussianLanguage)
        {
            ConstructorInfo constructor = typeof(UIManageControls).GetConstructor(Type.EmptyTypes);
            object controlsObject = constructor?.Invoke(Array.Empty<object>());
            MethodInfo onInitialize = typeof(UIManageControls).GetMethod("OnInitialize", BindingFlags.Instance | BindingFlags.Public);
            onInitialize?.Invoke(controlsObject, null);
        }

        foreach (Type type in ModsCall.Calamity.Code.GetTypes())
        {
            if (type.IsAssignableFrom(typeof(ModItem)))
                Logger.Info(type.Name);
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

        if (TRuConfig.Instance.WikithisInfo && ModsCall.Wikithis != null && !Main.dedServ)
        {
            if (ModsCall.Calamity != null)
            {
                ModsCall.Wikithis.Call(0, ModsCall.Calamity, "calamitymod.wiki.gg");
                ModsCall.Wikithis.Call(0, ModsCall.Calamity, "terraria-calamity-mod.fandom.com/ru", GameCulture.CultureName.Russian);
            }
        }
    }
}