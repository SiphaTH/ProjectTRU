using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using CalamityRuTranslate.Core.GlobalModifications;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using CalamityRuTranslate.Mods.CalamityMod;
using CalamityRuTranslate.Mods.Fargowiltas;
using CalamityRuTranslate.Mods.FargowiltasSouls;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using Terraria.ID;

namespace CalamityRuTranslate
{
    public partial class CalamityRuTranslate : Mod
    {
        public static CalamityRuTranslate Instance { get; private set; }
        public static List<Hook> Hooks { get; private set; }
        public static List<(MethodInfo, Delegate)> Modifiers { get; private set; }
        private List<ILoadable> _loadCache;

        private readonly SetupModTranslation[] _translations =
        {
            new CalamityTranslation(),
            new FargowiltasSoulsTranslation(),
            new FargowiltasTranslation()
        };

        public override void Load()
        {
            Instance = this;
            _loadCache = new List<ILoadable>();
            Hooks = new List<Hook>();
            Modifiers = new List<(MethodInfo, Delegate)>();

            foreach (SetupModTranslation mod in _translations)
                mod.TryLoad();

            foreach (Type type in Code.GetTypes().Where(x => !x.IsAbstract && x.GetInterfaces().Contains(typeof(ILoadable))))
                _loadCache.Add((ILoadable) Activator.CreateInstance(type));

            _loadCache.Sort((n, t) => n.Priority > t.Priority ? 1 : -1);

            foreach (var cache in _loadCache)
                cache.Load();

            foreach (Type type in Code.GetTypes().Where(x => !x.IsAbstract && x.GetConstructor(Type.EmptyTypes) != null))
            {
                ModDependencyAttribute[] modDependencies = type.GetCustomAttributes<ModDependencyAttribute>().ToArray();
                CultureDependencyAttribute[] cultureDependencies = type.GetCustomAttributes<CultureDependencyAttribute>().ToArray();

                string contentName = type.Name;
                object instance = Activator.CreateInstance(type);

                bool missingDependency = false;

                if (modDependencies.Length == 0) continue;

                foreach (CultureDependencyAttribute dependency in cultureDependencies)
                {
                    if (Main.netMode == NetmodeID.SinglePlayer && LanguageManager.Instance.ActiveCulture == GameCulture.FromName(dependency.Culture))
                        continue;

                    if (Main.netMode == NetmodeID.Server && GameCulture.FromName(dependency.Culture) == GameCulture.Russian)
                        continue;

                    missingDependency = true;
                }
                
                foreach (ModDependencyAttribute dependency in modDependencies)
                {
                    if (ModLoader.Mods.Any(x => x.Name.Equals(dependency.Mod)))
                        continue;

                    missingDependency = true;
                }

                if (missingDependency) continue;

                switch (instance)
                {
                    case ModifyGlobalBuff modifyGlobalBuff:
                        if (modifyGlobalBuff.Autoload(ref contentName))
                            continue;

                        if (modifyGlobalBuff.LoadWithValidMods())
                            AddGlobalBuff(contentName, modifyGlobalBuff);
                        break;

                    case ModifyGlobalItem modifyGlobalItem:
                        if (modifyGlobalItem.Autoload(ref contentName))
                            continue;

                        if (modifyGlobalItem.LoadWithValidMods())
                            AddGlobalItem(contentName, modifyGlobalItem);
                        break;

                    case ModifyGlobalNPC modifyGlobalNPC:
                        if (modifyGlobalNPC.Autoload(ref contentName))
                            continue;

                        if (modifyGlobalNPC.LoadWithValidMods())
                            AddGlobalNPC(contentName, modifyGlobalNPC);
                        break;
                    
                    case ModifyGlobalProjectile modifyGlobalProjectile:
                        if (modifyGlobalProjectile.Autoload(ref contentName))
                            continue;

                        if (modifyGlobalProjectile.LoadWithValidMods())
                            AddGlobalProjectile(contentName, modifyGlobalProjectile);
                        break;

                    case MonoModPatcher<string> monoModPatcher:
                        monoModPatcher.Apply();
                        break;
            
                    case MonoModPatcher<MethodInfo> monoModPatcher:
                        monoModPatcher.Apply();
                        break;
                }
            }

            if (ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage)
                CalamityReflections();
        }

        public override void Unload()
        {
            Instance = null;
            TRuConfig.Instance = null;

            foreach (Hook hook in Hooks)
                hook.Undo();

            foreach ((MethodInfo method, Delegate @delegate) in Modifiers)
                HookEndpointManager.Unmodify(method, @delegate);

            Hooks = null;
            Modifiers = null;

            foreach (var cache in _loadCache)
                cache.Unload();

            _loadCache = null;

            if (FargoCatalog.ItemsName.Contains("Squirrel") && FargoCatalog.ItemsTooltip.Contains("Squirrel"))
            {
                FargoCatalog.ItemsName.Remove("Squirrel");
                FargoCatalog.ItemsTooltip.Remove("Squirrel");
            }

            if (FargoCatalog.ItemsName.Contains("InnocuousSkull") && FargoCatalog.ItemsTooltip.Contains("InnocuousSkull"))
            {
                FargoCatalog.ItemsName.Remove("InnocuousSkull");
                FargoCatalog.ItemsTooltip.Remove("InnocuousSkull");
            }

            if (FargoCatalog.ItemsName.Contains("EternityAdvisor") && FargoCatalog.ItemsTooltip.Contains("EternityAdvisor"))
            {
                FargoCatalog.ItemsName.Remove("EternityAdvisor");
                FargoCatalog.ItemsTooltip.Remove("EternityAdvisor");
            }
            
            if (FargoCatalog.NPCs.Contains("Squirrel"))
            {
                FargoCatalog.NPCs.Remove("Squirrel");
            }
            
            if (FargoCatalog.ItemsName.Contains("OmnistationPlus") && FargoCatalog.ItemsTooltip.Contains("OmnistationPlus"))
            {
                FargoCatalog.ItemsName.Remove("OmnistationPlus");
                FargoCatalog.ItemsTooltip.Remove("OmnistationPlus");
            }

            if (FargoCatalog.ItemsName.Contains("OverloadCoznix") && FargoCatalog.ItemsTooltip.Contains("OverloadCoznix"))
            {
                FargoCatalog.ItemsName.Remove("OverloadCoznix");
                FargoCatalog.ItemsTooltip.Remove("OverloadCoznix");
            }

            if (FargoCatalog.ItemsName.Contains("OverloadJelly") && FargoCatalog.ItemsTooltip.Contains("OverloadJelly"))
            {
                FargoCatalog.ItemsName.Remove("OverloadJelly");
                FargoCatalog.ItemsTooltip.Remove("OverloadJelly");
            }

            if (FargoCatalog.ItemsName.Contains("OverloadLich") && FargoCatalog.ItemsTooltip.Contains("OverloadLich"))
            {
                FargoCatalog.ItemsName.Remove("OverloadLich");
                FargoCatalog.ItemsTooltip.Remove("OverloadLich");
            }

            if (FargoCatalog.ItemsName.Contains("OverloadSaucer") && FargoCatalog.ItemsTooltip.Contains("OverloadSaucer"))
            {
                FargoCatalog.ItemsName.Remove("OverloadSaucer");
                FargoCatalog.ItemsTooltip.Remove("OverloadSaucer");
            }

            if (FargoCatalog.ItemsName.Contains("OverloadStrider") && FargoCatalog.ItemsTooltip.Contains("OverloadStrider"))
            {
                FargoCatalog.ItemsName.Remove("OverloadStrider");
                FargoCatalog.ItemsTooltip.Remove("OverloadStrider");
            }

            if (FargoCatalog.ItemsName.Contains("OverloadThunderbird") && FargoCatalog.ItemsTooltip.Contains("OverloadThunderbird"))
            {
                FargoCatalog.ItemsName.Remove("OverloadThunderbird");
                FargoCatalog.ItemsTooltip.Remove("OverloadThunderbird");
            }
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            foreach (SetupModTranslation mod in _translations)
            {
                mod.LoadSetupDialoguesTranslation();
                mod.LoadSetupCombatTextsTranslation();
            }

        }

        public override void PostSetupContent()
        {
            foreach (SetupModTranslation mod in _translations)
                mod.LoadSetupContentTranslation();
        }
    }
}