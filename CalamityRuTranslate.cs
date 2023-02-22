using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Core;
using CalamityRuTranslate.Core.MonoMod;
using CalamityRuTranslate.Mods.CalamityMod;
using CalamityRuTranslate.Mods.Fargowiltas;
using CalamityRuTranslate.Mods.FargowiltasSouls;
using CalamityRuTranslate.Mods.InfernumMode;
using MonoMod.RuntimeDetour;
using ReLogic.Graphics;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate;

public class CalamityRuTranslate : Mod
{
    internal static CalamityRuTranslate Instance;
    public List<ContentTranslation> Contents;
    public DynamicSpriteFont BossIntroScreensFont;
    public readonly TranslateMod[] Mods =
    {
        new CalamityTranslation(),
        new FargowiltasTranslation(),
        new FargowiltasSoulsTranslation(),
        new InfernumModeTranslation()
    };
    private List<ILHook> _ilHooks;
    private List<Hook> _onHooks;

    public CalamityRuTranslate()
    {
        Instance = this;
        PreJITFilter = new DisableJIT();
    }

    public override void Load()
    {
        MonoModHooks.RequestNativeAccess();
        Contents = new List<ContentTranslation>();
        _ilHooks = new List<ILHook>();
        _onHooks = new List<Hook>();
        
        foreach (Type type in Instance.Code.GetTypes())
        {
            if (type.IsSubclassOf(typeof(ContentTranslation)) && Activator.CreateInstance(type) is ContentTranslation contentTranslation)
                Contents.Add(contentTranslation);
            
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
            
            Contents.Sort((n, t) => n.Priority.CompareTo(t.Priority));
        }
        
        if (_ilHooks.Count > 0)
            foreach (ILHook hook in _ilHooks)
                hook?.Apply();
        
        if (_onHooks.Count > 0)
            foreach (Hook hook in _onHooks)
                hook?.Apply();
        
        if (Contents.Count > 0)
            foreach (ContentTranslation content in Contents.Where(x => x.IsTranslationEnabled))
                (content as ILoadableContent)?.LoadContent();
    }
    
    public override void Unload()
    {
        Instance = null;
        TRuConfig.Instance = null;
        
        if (Contents != null)
            foreach (ContentTranslation content in Contents)
                (content as ILoadableContent)?.UnloadContent();
        
        if (_ilHooks != null)
            foreach (ILHook hook in _ilHooks)
                hook?.Dispose();
        
        if (_onHooks != null)
            foreach (Hook hook in _onHooks)
                hook?.Dispose();
        
        Contents = null;
        _ilHooks = null;
        _onHooks = null;
        
        Dictionary<string, WeakReference> cache = (Dictionary<string, WeakReference>)typeof(MonoMod.Utils.ReflectionHelper).GetField("AssemblyCache", BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(null);
        string[] list = cache?.Keys.Where(k => k.Contains("CalamityRuTranslate") || k.Contains("tModLoader")).ToArray();
        
        foreach (var key in list)
            cache?.Remove(key);
        
        Dictionary<string, WeakReference[]> caches = (Dictionary<string, WeakReference[]>)typeof(MonoMod.Utils.ReflectionHelper).GetField("AssembliesCache", BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(null);
        list = caches?.Keys.Where(k => k.Contains("CalamityRuTranslate") || k.Contains("tModLoader")).ToArray();
        
        foreach (var key in list)
            cache?.Remove(key);
        
        cache = (Dictionary<string, WeakReference>)typeof(MonoMod.Utils.ReflectionHelper).GetField("ResolveReflectionCache", BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(null);
        list = cache?.Keys.Where(k => k.Contains("CalamityRuTranslate") || k.Contains("tModLoader")).ToArray();
        
        foreach (var key in list)
            cache?.Remove(key);
    }

    public override void PostSetupContent()
    {
        foreach (TranslateMod mod in Mods)
            mod.LoadTranslate();

        if (TRuConfig.Instance.WikithisInfo && ModsCall.Wikithis != null && !Main.dedServ)
        {
            if (ModsCall.Calamity != null)
            {
	            ModsCall.Wikithis.Call("AddModURL", ModsCall.Calamity, "calamitymod.wiki.gg/ru", GameCulture.CultureName.Russian);
	            ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "BloodOrange").Type, "Кровавый апельсин (calamity)", GameCulture.CultureName.Russian);
                ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "Elderberry").Type, "Бузина (calamity)", GameCulture.CultureName.Russian);
                ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "PineapplePet").Type, "Ананас (calamity)", GameCulture.CultureName.Russian);
                ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "TrashmanTrashcan").Type, "Урна (питомец)", GameCulture.CultureName.Russian);
                ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "Butcher").Type, "Мясник (оружие)", GameCulture.CultureName.Russian);
                ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "SandstormGun").Type, "Песчаная буря (оружие)", GameCulture.CultureName.Russian);
                ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "Thunderstorm").Type, "Гроза (оружие)", GameCulture.CultureName.Russian);
                ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreAstralInfection").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
                ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreAbyss").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
                ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "AtlasMunitionsBeacon").Type, "Маячок установки Атлас", GameCulture.CultureName.Russian);
                ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreAquaticScourge").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
                ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreArchmage").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreAstrumAureus").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreAstrumDeus").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreAwakening").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreAzafure").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreBloodMoon").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreBrainofCthulhu").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreBrimstoneElemental").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreCalamitas").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreCalamitasClone").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreCeaselessVoid").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreCeaselessVoid").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreCrabulon").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreCrimson").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreCynosure").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreDesertScourge").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreDestroyer").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreDevourerofGods").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreDragonfolly").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreDukeFishron").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreEaterofWorlds").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreEmpressofLight").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreExoMechs").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreExoMechs").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreGolem").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreHiveMind").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreKingSlime").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreLeviathanAnahita").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreMechs").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreMechs").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LorePerforators").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LorePlaguebringerGoliath").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LorePlantera").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LorePlantera").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LorePlantera").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LorePlantera").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LorePlantera").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LorePlantera").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreRavager").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreRavager").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreRavager").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreRavager").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreRavager").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreSkeletronPrime").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreSlimeGod").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreStormWeaver").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreSulphurSea").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreTwins").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreUnderworld").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreWallofFlesh").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "LoreYharon").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(2, ModContent.Find<ModNPC>("CalamityMod", "HiveEnemy").Type, "Улей (враг)", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(2, ModContent.Find<ModNPC>("CalamityMod", "KingSlimeJewel").Type, "Королевская драгоценность (враг)", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(2, ModContent.Find<ModNPC>("CalamityMod", "OldDukeToothBall").Type, "Зубастый шар (Старый герцог)", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(2, ModContent.Find<ModNPC>("CalamityMod", "CalamitasEnchantDemon").Type, "Зачарование", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(2, ModContent.Find<ModNPC>("CalamityMod", "LeviathanStart").Type, "%3F%3F%3F", GameCulture.CultureName.Russian);
            }
        }
    }
}