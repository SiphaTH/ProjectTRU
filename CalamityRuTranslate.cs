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
            foreach (ContentTranslation content in Contents.Where(x => x.IsTranslationEnabled))
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
                ModsCall.Wikithis.Call(0, ModsCall.Calamity, "calamitymod.wiki.gg");
                ModsCall.Wikithis.Call(0, ModsCall.Calamity, "terraria-calamity-mod.fandom.com/ru", GameCulture.CultureName.Russian);
            }
        }
    }
}