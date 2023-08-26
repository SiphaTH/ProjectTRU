using System;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using ReLogic.Graphics;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate;

public class CalamityRuTranslate : Mod
{
    internal static CalamityRuTranslate Instance;
    public DynamicSpriteFont BossIntroScreensFont;

    public CalamityRuTranslate()
    {
        Instance = this;
        PreJITFilter = new DisableJIT();
    }

    public override void Load()
    {
        foreach (Type type in Instance.Code.GetTypes())
        {
            if (type.IsSubclassOf(typeof(ILPatcher)) && Activator.CreateInstance(type) is ILPatcher {AutoLoad: true} ilPatcher)
            {
                try
                {
                    MonoModHooks.Modify(ilPatcher.ModifiedMethod, ilPatcher.PatchMethod);
                }
                catch (NullReferenceException)
                {
                    throw new Exception($"[IL] Экземпляр типа '{type.Name}' не создан!");
                }
            }
        
            if (type.IsSubclassOf(typeof(OnPatcher)) && Activator.CreateInstance(type) is OnPatcher {AutoLoad: true} onPatcher)
                MonoModHooks.Add(onPatcher.ModifiedMethod, onPatcher.Delegate);
        }
    }
    
    public override void Unload()
    {
        Instance = null;
        TRuConfig.Instance = null;
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