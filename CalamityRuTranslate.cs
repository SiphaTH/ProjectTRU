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
                ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "AtlasMunitionsBeacon").Type, "Маячок установки Атлас", GameCulture.CultureName.Russian);
                ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeAquaticScourge").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
                ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeAstralInfection").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeAstrumAureus").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeAstrumDeus").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeBloodMoon").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeBrainofCthulhu").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeBrimstoneCrag").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeBrimstoneElemental").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeCalamitas").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeCalamitasClone").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeCorruption").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeCrabulon").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeCrimson").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeCryogen").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeDesertScourge").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeDestroyer").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeDevourerofGods").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeDragonfolly").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeDukeFishron").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeEaterofWorlds").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeExoMechs").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeEyeofCthulhu").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeGolem").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeHiveMind").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeKingSlime").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeLeviathanAnahita").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeLunaticCultist").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeMechs").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeMoonLord").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeOcean").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeOldDuke").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgePerforators").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgePlaguebringerGoliath").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgePlantera").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgePolterghast").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeProfanedGuardians").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeProvidence").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeQueenBee").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeRavager").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeSentinels").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeSkeletron").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeSkeletronPrime").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeSlimeGod").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeSulphurSea").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeTwins").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeUnderworld").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeWallofFlesh").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(1, ModContent.Find<ModItem>("CalamityMod", "KnowledgeYharon").Type, "История#Предметы_истории", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(2, ModContent.Find<ModNPC>("CalamityMod", "Catfish").Type, "Сом (враг)", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(2, ModContent.Find<ModNPC>("CalamityMod", "HiveEnemy").Type, "Улей (враг)", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(2, ModContent.Find<ModNPC>("CalamityMod", "KingSlimeJewel").Type, "Королевская драгоценность (враг)", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(2, ModContent.Find<ModNPC>("CalamityMod", "OldDukeToothBall").Type, "Зубастый шар (Старый герцог)", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(2, ModContent.Find<ModNPC>("CalamityMod", "CalamitasEnchantDemon").Type, "Зачарование", GameCulture.CultureName.Russian);
				ModsCall.Wikithis.Call(2, ModContent.Find<ModNPC>("CalamityMod", "LeviathanStart").Type, "%3F%3F%3F", GameCulture.CultureName.Russian);
            }
        }
    }
}