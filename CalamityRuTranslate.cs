using System;
using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.RuntimeDetour;
using ReLogic.Graphics;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate;

public class CalamityRuTranslate : Mod
{
    internal static CalamityRuTranslate Instance;
    public DynamicSpriteFont BossIntroScreensFont;

    private static List<ILHook> _ilHooks;
    private static List<Hook> _onHooks;

    public CalamityRuTranslate()
    {
        Instance = this;
        PreJITFilter = new DisableJIT();
    }

    public override void Load()
    {
        _ilHooks = new List<ILHook>();
        _onHooks = new List<Hook>();
        
        foreach (Type type in Instance.Code.GetTypes())
        {
            if (type.IsSubclassOf(typeof(ILPatcher)) && Activator.CreateInstance(type) is ILPatcher {AutoLoad: true} ilPatcher)
            {
                try
                {
                    _ilHooks.Add(new ILHook(ilPatcher.ModifiedMethod, ilPatcher.PatchMethod));
                }
                catch (NullReferenceException)
                {
                    throw new Exception($"[IL] Экземпляр типа '{type.Name}' не создан!");
                }
            }
        
            if (type.IsSubclassOf(typeof(OnPatcher)) && Activator.CreateInstance(type) is OnPatcher {AutoLoad: true} onPatcher)
                _onHooks.Add(new Hook(onPatcher.ModifiedMethod, onPatcher.Delegate));
        }
        
        if (_ilHooks.Count > 0)
            foreach (ILHook hook in _ilHooks)
                hook?.Apply();
        
        if (_onHooks.Count > 0)
            foreach (Hook hook in _onHooks)
                hook?.Apply();
    }
    
    public override void Unload()
    {
        Instance = null;
        TRuConfig.Instance = null;
        
        if (_ilHooks != null)
        {
            foreach (ILHook hook in _ilHooks)
                hook?.Dispose();
            _ilHooks = null;
        }
        
        if (_onHooks != null)
        {
            foreach (Hook hook in _onHooks)
                hook?.Dispose();
            _onHooks = null;
        }

        Dictionary<string, WeakReference> cache = typeof(MonoMod.Utils.ReflectionHelper).GetCachedField("AssemblyCache").GetValue<Dictionary<string, WeakReference>>(null);
        string[] list = cache?.Keys.Where(k => k.Contains("CalamityRuTranslate") || k.Contains("tModLoader")).ToArray();
        
        foreach (var key in list)
            cache?.Remove(key);
        
        Dictionary<string, WeakReference[]> caches = typeof(MonoMod.Utils.ReflectionHelper).GetCachedField("AssembliesCache").GetValue<Dictionary<string, WeakReference[]>>(null);
        list = caches?.Keys.Where(k => k.Contains("CalamityRuTranslate") || k.Contains("tModLoader")).ToArray();
        
        foreach (var key in list)
            cache?.Remove(key);
        
        cache = typeof(MonoMod.Utils.ReflectionHelper).GetCachedField("ResolveReflectionCache").GetValue<Dictionary<string, WeakReference>>(null);
        list = cache?.Keys.Where(k => k.Contains("CalamityRuTranslate") || k.Contains("tModLoader")).ToArray();
        
        foreach (var key in list)
            cache?.Remove(key);
    }

    public override void PostSetupContent()
    {
        if (TRuConfig.Instance.WikithisInfo && ModsCall.Wikithis != null && !Main.dedServ)
        {
            if (ModsCall.Calamity != null)
            {
                ModsCall.Wikithis.Call("AddModURL", ModsCall.Calamity, "https://calamitymod.wiki.gg/ru/wiki/{}", GameCulture.CultureName.Russian);
                TranslationHelper.WikithisRedirectItem("BloodOrange", "Кровавый апельсин (calamity)");
                TranslationHelper.WikithisRedirectItem("Elderberry", "Бузина (calamity)");
                TranslationHelper.WikithisRedirectItem("PineapplePet", "Ананас (calamity)");
                TranslationHelper.WikithisRedirectItem("TrashmanTrashcan", "Урна (питомец)");
                TranslationHelper.WikithisRedirectItem("Butcher", "Мясник (оружие)");
                TranslationHelper.WikithisRedirectItem("SandstormGun", "Песчаная буря (оружие)");
                TranslationHelper.WikithisRedirectItem("Thunderstorm", "Гроза (оружие)");
                TranslationHelper.WikithisRedirectItem("AtlasMunitionsBeacon", "Маячок установки Атлас");
                TranslationHelper.WikithisRedirectItem(new []
                {
                    "LoreAstralInfection", "LoreAbyss", "LoreAquaticScourge", "LoreArchmage", "LoreAstrumAureus",
                    "LoreAstrumDeus", "LoreAwakening", "LoreAzafure", "LoreBloodMoon", "LoreBrainofCthulhu",
                    "LoreBrimstoneElemental", "LoreCalamitas", "LoreCalamitasClone", "LoreCeaselessVoid",
                    "LoreCorruption", "LoreCrabulon", "LoreCrimson", "LoreCynosure", "LoreDesertScourge",
                    "LoreDestroyer", "LoreDevourerofGods", "LoreDragonfolly", "LoreDukeFishron", "LoreEaterofWorlds",
                    "LoreEmpressofLight", "LoreExoMechs", "LoreEyeofCthulhu", "LoreGolem", "LoreHiveMind",
                    "LoreKingSlime", "LoreLeviathanAnahita", "LoreMechs", "LoreOldDuke", "LorePerforators",
                    "LorePlaguebringerGoliath", "LorePlantera", "LorePolterghast", "LorePrelude", "LoreProfanedGuardians",
                    "LoreProvidence", "LoreQueenBee", "LoreQueenSlime", "LoreRavager", "LoreRequiem",
                    "LoreSignus", "LoreSkeletron", "LoreSkeletronPrime", "LoreSlimeGod", "LoreStormWeaver",
                    "LoreSulphurSea", "LoreTwins", "LoreUnderworld", "LoreWallofFlesh", "LoreYharon"
                }, "История#Предметы_истории");
                TranslationHelper.WikithisRedirectNPC("HiveEnemy", "Улей (враг)");
                TranslationHelper.WikithisRedirectNPC("KingSlimeJewel", "Королевская драгоценность (враг)");
                TranslationHelper.WikithisRedirectNPC("OldDukeToothBall", "Зубастый шар (Старый герцог)");
                TranslationHelper.WikithisRedirectNPC("CalamitasEnchantDemon", "Зачарование");
                TranslationHelper.WikithisRedirectNPC("LeviathanStart", "%3F%3F%3F");

            }
        }
    }
}