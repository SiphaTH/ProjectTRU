using System;
using System.Reflection;
using CalamityRuTranslate.Utilities;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    internal static class CalamityIL
    {
        public static void Load() => LoadIL();
        
        public static void Unload() => UnloadIL();

        private static void LoadIL()
        {
            Type ripperUi = null;
            Type acidRainUi = null;
            Type stealthUi = null;
            Type calamityPlayer = null;
            Type cheatTestThing = null;
            Type labHologramProjectorUi = null;
            Type draedonLogHellGui = null;
            Type draedonLogJungleGui = null;
            Type draedonLogPlanetoidGui = null;
            Type draedonLogSnowBiomeGui = null;
            Type draedonLogSunkenSeaGui = null;
            Type weakReferenceSupport = null;
            Type fap = null;
            Type seahoe = null;
            Type thief = null;
            Type astralInjection = null;
            Type thornBlossom = null;
            Type lucrecia = null;
            Type bloodBoiler = null;
            Type molecularManipulator = null;
            Type nullificationRifle = null;
            Type devourerofGodsHead = null;
            Type devourerofGodsHeadS = null;
            Type fearlessGoldfishWarrior = null;
            Type healOrbProv = null;
            Type holyBurnOrb = null;
            Type chibiiDoggo = null;
            Type calamityUtils = null;
            Type plaguedPlateBed = null;
            Type ravagerBody = null;
            Type calamitasRun3 = null;
            Type profanedGuardianBoss2 = null;
            Type bossHpui = null;
            Type perforatorHeadLarge = null;
            Type perforatorHeadSmall = null;
            Type bumblefuck = null;
            Type perforatorHeadMedium = null;
            Type profanedGuardianBoss3 = null;
            Type profanedGuardianBoss = null;
            Type bossRushUi = null;
            Type coldDivinity = null;

            Assembly calamityAssembly = CoreCalamityTranslation.CalamityMod.GetType().Assembly;

            foreach (Type calamityClass in calamityAssembly.GetTypes())
            {
                switch (calamityClass.Name)
                {
                    case "RipperUI":
                        ripperUi = calamityClass;
                        break;
                    case "DraedonLogHellGUI":
                        draedonLogHellGui = calamityClass;
                        break;
                    case "StealthUI":
                        stealthUi = calamityClass;
                        break;
                    case "CalamityPlayer":
                        calamityPlayer = calamityClass;
                        break;
                    case "CheatTestThing":
                        cheatTestThing = calamityClass;
                        break;
                    case "AcidRainUI":
                        acidRainUi = calamityClass;
                        break;
                    case "DraedonLogJungleGUI":
                        draedonLogJungleGui = calamityClass;
                        break;
                    case "DraedonLogPlanetoidGUI":
                        draedonLogPlanetoidGui = calamityClass;
                        break;
                    case "DraedonLogSnowBiomeGUI":
                        draedonLogSnowBiomeGui = calamityClass;
                        break;
                    case "DraedonLogSunkenSeaGUI":
                        draedonLogSunkenSeaGui = calamityClass;
                        break;
                    case "WeakReferenceSupport":
                        weakReferenceSupport = calamityClass;
                        break;
                    case "FAP":
                        fap = calamityClass;
                        break;
                    case "SEAHOE":
                        seahoe = calamityClass;
                        break;
                    case "THIEF":
                        thief = calamityClass;
                        break;
                    case "LabHologramProjectorUI":
                        labHologramProjectorUi = calamityClass;
                        break;
                    case "AstralInjection":
                        astralInjection = calamityClass;
                        break;
                    case "ThornBlossom":
                        thornBlossom = calamityClass;
                        break;
                    case "Lucrecia":
                        lucrecia = calamityClass;
                        break;
                    case "BloodBoiler":
                        bloodBoiler = calamityClass;
                        break;
                    case "MolecularManipulator":
                        molecularManipulator = calamityClass;
                        break;
                    case "NullificationRifle":
                        nullificationRifle = calamityClass;
                        break;
                    case "DevourerofGodsHead":
                        devourerofGodsHead = calamityClass;
                        break;
                    case "DevourerofGodsHeadS":
                        devourerofGodsHeadS = calamityClass;
                        break;
                    case "FearlessGoldfishWarrior":
                        fearlessGoldfishWarrior = calamityClass;
                        break;
                    case "HealOrbProv":
                        healOrbProv = calamityClass;
                        break;
                    case "HolyBurnOrb":
                        holyBurnOrb = calamityClass;
                        break;
                    case "ChibiiDoggo":
                        chibiiDoggo = calamityClass;
                        break;
                    case "CalamityUtils":
                        calamityUtils = calamityClass;
                        break;
                    case "PlaguedPlateBed" when calamityClass.Namespace == "CalamityMod.Tiles.FurniturePlaguedPlate":
                        plaguedPlateBed = calamityClass;
                        break;
                    case "RavagerBody":
                        ravagerBody = calamityClass;
                        break;
                    case "CalamitasRun3":
                        calamitasRun3 = calamityClass;
                        break;
                    case "BossHPUI":
                        bossHpui = calamityClass;
                        break;
                    case "ProfanedGuardianBoss2":
                        profanedGuardianBoss2 = calamityClass;
                        break;
                    case "PerforatorHeadLarge":
                        perforatorHeadLarge = calamityClass;
                        break;
                    case "PerforatorHeadSmall":
                        perforatorHeadSmall = calamityClass;
                        break;
                    case "Bumblefuck":
                        bumblefuck = calamityClass;
                        break;
                    case "PerforatorHeadMedium":
                        perforatorHeadMedium = calamityClass;
                        break;
                    case "ProfanedGuardianBoss3":
                        profanedGuardianBoss3 = calamityClass;
                        break;
                    case "ProfanedGuardianBoss":
                        profanedGuardianBoss = calamityClass;
                        break;
                    case "BossRushUI":
                        bossRushUi = calamityClass;
                        break;
                    case "ColdDivinity":
                        coldDivinity = calamityClass;
                        break;
                }
            }

            _handleMouseInteraction = ripperUi?.GetMethod("HandleMouseInteraction", BindingFlags.Static | BindingFlags.NonPublic);
            if(_handleMouseInteraction != null) ModifyHandleMouseInteraction += Ru_ModifyHandleMouseInteraction;
            
            _drawAcidRain = acidRainUi?.GetMethod("get_InvasionName", BindingFlags.Instance | BindingFlags.Public);
            if(_drawAcidRain != null) ModifyDrawAcidRain += Ru_ModifyDrawAcidRain;
            
            _drawStealth = stealthUi?.GetMethod("Draw", BindingFlags.Static | BindingFlags.Public);
            if(_drawStealth != null) ModifyDrawStealth += Ru_ModifyDrawStealth;
            
            _killPlayer = calamityPlayer?.GetMethod("KillPlayer", BindingFlags.Instance | BindingFlags.Public);
            _preKill = calamityPlayer?.GetMethod("PreKill", BindingFlags.Instance | BindingFlags.Public);
            if(_killPlayer != null) ModifyKillPlayer += Ru_ModifyKillPlayer;
            if(_preKill != null) ModifyPreKill += Ru_ModifyPreKill;

            _updateAccessory = cheatTestThing?.GetMethod("UpdateAccessory", BindingFlags.Instance | BindingFlags.Public);
            if(_updateAccessory != null) ModifyUpdateAccessory += Ru_ModifyUpdateAccessory;
            
            _chooseDialogue = labHologramProjectorUi?.GetMethod("ChooseDialogue", BindingFlags.Public | BindingFlags.Static);
            if(_chooseDialogue != null) ModifyChooseDialogue += Ru_ModifyChooseDialogue;

            _getTextByPageHellGui = draedonLogHellGui?.GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance);
            if(_getTextByPageHellGui != null) ModifyGetTextByPageHellGui += Ru_ModifyGetTextByPageHellGui;
            
            _getTextByPageJungleGui = draedonLogJungleGui?.GetMethod("GetTextByPage", BindingFlags.Instance | BindingFlags.Public);
            if(_getTextByPageJungleGui != null) ModifyGetTextByPageJungleGui += Ru_ModifyGetTextByPageJungleGui;
            
            _getTextByPagePlanetoidGui = draedonLogPlanetoidGui?.GetMethod("GetTextByPage", BindingFlags.Instance | BindingFlags.Public);
            if(_getTextByPagePlanetoidGui != null) ModifyGetTextByPagePlanetoidGui += Ru_ModifyGetTextByPagePlanetoidGui;

            _getTextByPageSnowBiomeGui = draedonLogSnowBiomeGui?.GetMethod("GetTextByPage", BindingFlags.Instance | BindingFlags.Public);
            if(_getTextByPageSnowBiomeGui != null) ModifyGetTextByPageSnowBiomeGui += Ru_ModifyGetTextByPageSnowBiomeGui;

            _getTextByPageSunkenSeaGui = draedonLogSunkenSeaGui?.GetMethod("GetTextByPage", BindingFlags.Instance | BindingFlags.Public);
            if(_getTextByPageSunkenSeaGui != null) ModifyGetTextByPageSunkenSeaGui += Ru_ModifyGetTextByPageSunkenSeaGui;

            _addCalamityBosses = weakReferenceSupport?.GetMethod("AddCalamityBosses", BindingFlags.Static | BindingFlags.NonPublic);
            if(_addCalamityBosses != null) ModifyAddCalamityBosses += Ru_ModifyAddCalamityBosses;
            
            _setChatButtonsFap = fap?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            if(_setChatButtonsFap != null) ModifySetChatButtonsFap += Ru_ModifySetChatButtonsFap;
            
            _setChatButtonsSeahoe = seahoe?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            if(_setChatButtonsSeahoe != null) ModifySetChatButtonsSeahoe += Ru_ModifySetChatButtonsSeahoe;
            
            _setChatButtonsThief = thief?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            if(_setChatButtonsThief != null) ModifySetChatButtonsThief += Ru_ModifySetChatButtonsThief;
            
            _onConsumeItemAstralInjection = astralInjection?.GetMethod("OnConsumeItem", BindingFlags.Public | BindingFlags.Instance);
            if(_onConsumeItemAstralInjection != null) ModifyOnConsumeItemAstralInjection += Ru_ModifyOnConsumeItemAstralInjection;

            _shootThornBlossom = thornBlossom?.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            if(_shootThornBlossom != null) ModifyShootThornBlossom += Ru_ModifyShootThornBlossom;
            
            _shootThornLucrecia = lucrecia?.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            if(_shootThornLucrecia != null) ModifyShootThornLucrecia += Ru_ModifyShootThornLucrecia;

            _shootBloodBoiler = bloodBoiler?.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            if(_shootBloodBoiler != null) ModifyShootBloodBoiler += Ru_ModifyShootBloodBoiler;

            _shootMolecularManipulator = molecularManipulator?.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            if(_shootMolecularManipulator != null) ModifyMolecularManipulator += Ru_ModifyMolecularManipulator;

            _shootNullificationRifle = nullificationRifle?.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            if(_shootNullificationRifle != null) ModifyShootNullificationRifle += Ru_ModifyShootNullificationRifle;

            _onHitPlayerDevourerofGodsHead = devourerofGodsHead?.GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance);
            if(_onHitPlayerDevourerofGodsHead != null) ModifyOnHitPlayerDevourerofGodsHead += Ru_ModifyOnHitPlayerDevourerofGodsHead;

            _onHitPlayerDevourerofGodsHeadS = devourerofGodsHeadS?.GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance);
            if(_onHitPlayerDevourerofGodsHeadS != null) ModifyOnHitPlayerDevourerofGodsHeadS += Ru_ModifyOnHitPlayerDevourerofGodsHeadS;

            _modifyHitPlayerFearlessGoldfishWarrior = fearlessGoldfishWarrior?.GetMethod("ModifyHitPlayer", BindingFlags.Public | BindingFlags.Instance);
            if(_modifyHitPlayerFearlessGoldfishWarrior != null) ModifyModifyHitPlayerFearlessGoldfishWarrior += Ru_ModifyModifyHitPlayerFearlessGoldfishWarrior;

            _getChatFap = fap?.GetMethod("GetChat", BindingFlags.Public | BindingFlags.Instance);
            if(_getChatFap != null) ModifyGetChatFap += Ru_ModifyGetChatFap;

            _aiHealOrbProv = healOrbProv?.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            if(_aiHealOrbProv != null) ModifyAiHealOrbProv += Ru_ModifyAIHealOrbProv;
            
            _aiHolyBurnOrb = holyBurnOrb?.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            if(_aiHolyBurnOrb != null) ModifyAiHolyBurnOrb += Ru_ModifyAIHolyBurnOrb;
            
            _aiChibiiDoggo = chibiiDoggo?.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            if(_aiChibiiDoggo != null) ModifyAiChibiiDoggo += Ru_ModifyAIChibiiDoggo;
            
            _spawnDoggo = chibiiDoggo?.GetMethod("SpawnDoggo", BindingFlags.Public | BindingFlags.Instance);
            if(_spawnDoggo != null) ModifySpawnDoggo += Ru_ModifySpawnDoggo;
            
            _bedRightClick = calamityUtils?.GetMethod("BedRightClick", BindingFlags.Public | BindingFlags.Static);
            if(_bedRightClick != null) ModifyBedRightClick += Ru_ModifyBedRightClick;
            
            _newRightClick = plaguedPlateBed?.GetMethod("NewRightClick", BindingFlags.Public | BindingFlags.Instance);
            if(_newRightClick != null) ModifyNewRightClick += Ru_ModifyNewRightClick;
            
            _addCalamityInvasions = weakReferenceSupport?.GetMethod("AddCalamityInvasions", BindingFlags.NonPublic | BindingFlags.Static);
            if(_addCalamityInvasions != null) ModifyAddCalamityInvasions += Ru_ModifyAddCalamityInvasions;
            
            _censusSupport = weakReferenceSupport?.GetMethod("CensusSupport", BindingFlags.NonPublic | BindingFlags.Static);
            if(_censusSupport != null) ModifyCensusSupport += Ru_ModifyCensusSupport;
            
            _bossLootRavager = ravagerBody?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            if(_bossLootRavager != null) ModifyBossLootRavager += Ru_ModifyBossLootRavager;
            
            _bossLootCalamitasRun3 = calamitasRun3?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            if(_bossLootCalamitasRun3 != null) ModifyBossLootCalamitasRun3 += Ru_ModifyBossLootCalamitasRun3;
            
            _drawBossHpui = bossHpui?.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            if(_drawBossHpui != null) ModifyDrawBossHpui += Ru_ModifyDrawBossHpui;
            
            _drawOpenAnim = bossHpui?.GetMethod("DrawOpenAnim", BindingFlags.Public | BindingFlags.Instance);
            if(_drawOpenAnim != null) ModifyDrawOpenAnim += Ru_ModifyDrawOpenAnim;
            
            _bossLootProfanedGuardianBoss2 = profanedGuardianBoss2?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            if(_bossLootProfanedGuardianBoss2 != null) ModifyBossLootProfanedGuardianBoss2 += Ru_ModifyBossLootProfanedGuardianBoss2;
            
            _bossLootPerforatorHeadLarge = perforatorHeadLarge?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            if(_bossLootPerforatorHeadLarge != null) ModifyBossLootPerforatorHeadLarge += Ru_ModifyBossLootPerforatorHeadLarge;

            _bossLootPerforatorHeadSmall = perforatorHeadSmall?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            if(_bossLootPerforatorHeadSmall != null) ModifyBossLootPerforatorHeadSmall += Ru_ModifyBossLootPerforatorHeadSmall;

            _bossLootBumblefuck = bumblefuck?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            if(_bossLootBumblefuck != null) ModifyBossLootBumblefuck += Ru_ModifyBossLootBumblefuck;
            
            _bossLootPerforatorHeadMedium = perforatorHeadMedium?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            if(_bossLootPerforatorHeadMedium != null) ModifyBossLootPerforatorHeadMedium += Ru_ModifyBossLootPerforatorHeadMedium;
            
            _bossLootProfanedGuardianBoss3 = profanedGuardianBoss3?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            if(_bossLootProfanedGuardianBoss3 != null) ModifyBossLootProfanedGuardianBoss3 += Ru_ModifyBossLootProfanedGuardianBoss3;
            
            _bossLootProfanedGuardianBoss = profanedGuardianBoss?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            if(_bossLootProfanedGuardianBoss != null) ModifyBossLootProfanedGuardianBoss += Ru_ModifyBossLootProfanedGuardianBoss;
            
            _invasionNamebossRushUi = bossRushUi?.GetMethod("get_InvasionName", BindingFlags.Public | BindingFlags.Instance);
            if(_invasionNamebossRushUi != null) ModifyInvasionNamebossRushUi += Ru_ModifyInvasionNamebossRushUI;
            
            _coldDivinityModifyTooltips = coldDivinity?.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            if(_coldDivinityModifyTooltips != null) ModifyColdDivinityModifyTooltips += Ru_ModifyColdDivinityModifyTooltips;
        }

        private static void UnloadIL()
        {
            if(_handleMouseInteraction != null) ModifyHandleMouseInteraction -= Ru_ModifyHandleMouseInteraction;
            if(_drawAcidRain != null) ModifyDrawAcidRain -= Ru_ModifyDrawAcidRain;
            if(_drawStealth != null) ModifyDrawStealth -= Ru_ModifyDrawStealth;
            if(_preKill != null) ModifyPreKill -= Ru_ModifyPreKill;
            if(_killPlayer != null) ModifyKillPlayer -= Ru_ModifyKillPlayer;
            if(_updateAccessory != null) ModifyUpdateAccessory -= Ru_ModifyUpdateAccessory;
            if(_chooseDialogue != null) ModifyChooseDialogue -= Ru_ModifyChooseDialogue;
            if(_getTextByPageHellGui != null) ModifyGetTextByPageHellGui -= Ru_ModifyGetTextByPageHellGui;
            if(_getTextByPageJungleGui != null) ModifyGetTextByPageJungleGui -= Ru_ModifyGetTextByPageJungleGui;
            if(_getTextByPagePlanetoidGui != null) ModifyGetTextByPagePlanetoidGui -= Ru_ModifyGetTextByPagePlanetoidGui;
            if(_getTextByPageSnowBiomeGui != null) ModifyGetTextByPageSnowBiomeGui -= Ru_ModifyGetTextByPageSnowBiomeGui;
            if(_getTextByPageSunkenSeaGui != null) ModifyGetTextByPageSunkenSeaGui -= Ru_ModifyGetTextByPageSunkenSeaGui;
            if(_addCalamityBosses != null) ModifyAddCalamityBosses -= Ru_ModifyAddCalamityBosses;
            if(_setChatButtonsFap != null) ModifySetChatButtonsFap -= Ru_ModifySetChatButtonsFap;
            if(_setChatButtonsSeahoe != null) ModifySetChatButtonsSeahoe -= Ru_ModifySetChatButtonsSeahoe;
            if(_setChatButtonsThief != null) ModifySetChatButtonsThief -= Ru_ModifySetChatButtonsThief;
            if(_onConsumeItemAstralInjection != null) ModifyOnConsumeItemAstralInjection -= Ru_ModifyOnConsumeItemAstralInjection;
            if(_shootThornBlossom != null) ModifyShootThornBlossom -= Ru_ModifyShootThornBlossom;
            if(_shootThornLucrecia != null) ModifyShootThornLucrecia -= Ru_ModifyShootThornLucrecia;
            if(_shootBloodBoiler != null) ModifyShootBloodBoiler -= Ru_ModifyShootBloodBoiler;
            if(_shootMolecularManipulator != null) ModifyMolecularManipulator -= Ru_ModifyMolecularManipulator;
            if(_shootNullificationRifle != null) ModifyShootNullificationRifle -= Ru_ModifyShootNullificationRifle;
            if(_onHitPlayerDevourerofGodsHead != null) ModifyOnHitPlayerDevourerofGodsHead -= Ru_ModifyOnHitPlayerDevourerofGodsHead;
            if(_onHitPlayerDevourerofGodsHeadS != null) ModifyOnHitPlayerDevourerofGodsHeadS -= Ru_ModifyOnHitPlayerDevourerofGodsHeadS;
            if(_modifyHitPlayerFearlessGoldfishWarrior != null) ModifyModifyHitPlayerFearlessGoldfishWarrior -= Ru_ModifyModifyHitPlayerFearlessGoldfishWarrior;
            if(_getChatFap != null) ModifyGetChatFap -= Ru_ModifyGetChatFap;
            if(_aiHealOrbProv != null) ModifyAiHealOrbProv -= Ru_ModifyAIHealOrbProv;
            if(_aiHolyBurnOrb != null) ModifyAiHolyBurnOrb -= Ru_ModifyAIHolyBurnOrb;
            if(_aiChibiiDoggo != null) ModifyAiChibiiDoggo -= Ru_ModifyAIChibiiDoggo;
            if(_spawnDoggo != null) ModifySpawnDoggo -= Ru_ModifySpawnDoggo;
            if(_bedRightClick != null) ModifyBedRightClick -= Ru_ModifyBedRightClick;
            if(_newRightClick != null) ModifyNewRightClick -= Ru_ModifyNewRightClick;
            if(_addCalamityInvasions != null) ModifyAddCalamityInvasions -= Ru_ModifyAddCalamityInvasions;
            if(_censusSupport != null) ModifyCensusSupport -= Ru_ModifyCensusSupport;
            if(_bossLootRavager != null) ModifyBossLootRavager -= Ru_ModifyBossLootRavager;
            if(_bossLootCalamitasRun3 != null) ModifyBossLootCalamitasRun3 -= Ru_ModifyBossLootCalamitasRun3;
            if(_drawBossHpui != null) ModifyDrawBossHpui -= Ru_ModifyDrawBossHpui;
            if(_drawOpenAnim != null) ModifyDrawOpenAnim -= Ru_ModifyDrawOpenAnim;
            if(_bossLootProfanedGuardianBoss2 != null) ModifyBossLootProfanedGuardianBoss2 -= Ru_ModifyBossLootProfanedGuardianBoss2;
            if(_bossLootPerforatorHeadLarge != null) ModifyBossLootPerforatorHeadLarge -= Ru_ModifyBossLootPerforatorHeadLarge;
            if(_bossLootPerforatorHeadSmall != null) ModifyBossLootPerforatorHeadSmall -= Ru_ModifyBossLootPerforatorHeadSmall;
            if(_bossLootBumblefuck != null) ModifyBossLootBumblefuck -= Ru_ModifyBossLootBumblefuck;
            if(_bossLootPerforatorHeadMedium != null) ModifyBossLootPerforatorHeadMedium -= Ru_ModifyBossLootPerforatorHeadMedium;
            if(_bossLootProfanedGuardianBoss3 != null) ModifyBossLootProfanedGuardianBoss3 -= Ru_ModifyBossLootProfanedGuardianBoss3;
            if(_bossLootProfanedGuardianBoss != null) ModifyBossLootProfanedGuardianBoss -= Ru_ModifyBossLootProfanedGuardianBoss;
            if(_invasionNamebossRushUi != null) ModifyInvasionNamebossRushUi -= Ru_ModifyInvasionNamebossRushUI;
            if(_coldDivinityModifyTooltips != null) ModifyColdDivinityModifyTooltips -= Ru_ModifyColdDivinityModifyTooltips;
        }

        #region IL Editing

        private static void Ru_ModifyColdDivinityModifyTooltips(ILContext il) => Translation.ILTranslate(il, "Tooltip7", "Tooltip6");
        
        private static void Ru_ModifyInvasionNamebossRushUI(ILContext il) => Translation.ILTranslate(il, "Boss Rush", Translation.EncodeToUtf16("Босс-Раш"));
        
        private static void Ru_ModifyBossLootProfanedGuardianBoss(ILContext il) => Translation.ILTranslate(il, "A Profaned Guardian", Translation.EncodeToUtf16("Осквернённый страж"));
        
        private static void Ru_ModifyBossLootProfanedGuardianBoss3(ILContext il) => Translation.ILTranslate(il, "A Profaned Guardian", Translation.EncodeToUtf16("Осквернённый страж"));
        
        private static void Ru_ModifyBossLootPerforatorHeadMedium(ILContext il) => Translation.ILTranslate(il, "The Medium Perforator", Translation.EncodeToUtf16("Перфоратор средний"));
        
        private static void Ru_ModifyBossLootBumblefuck(ILContext il) => Translation.ILTranslate(il, "A Dragonfolly", Translation.EncodeToUtf16("Псевдодракон"));
        
        private static void Ru_ModifyBossLootPerforatorHeadSmall(ILContext il) => Translation.ILTranslate(il, "The Small Perforator", Translation.EncodeToUtf16("Перфоратор младший"));
        
        private static void Ru_ModifyBossLootPerforatorHeadLarge(ILContext il) => Translation.ILTranslate(il, "The Large Perforator", Translation.EncodeToUtf16("Перфоратор старший"));
        
        private static void Ru_ModifyBossLootProfanedGuardianBoss2(ILContext il) => Translation.ILTranslate(il, "A Profaned Guardian", Translation.EncodeToUtf16("Осквернённый страж"));
        
        private static void Ru_ModifyDrawBossHpui(ILContext il)
        {
            Translation.ILTranslate(il, "(Segments left: ", Translation.EncodeToUtf16("(Осталось сегментов: "));
            Translation.ILTranslate(il, "(Creepers left: ", Translation.EncodeToUtf16("(Осталось ползунов: "));
            Translation.ILTranslate(il, "(Hands left: ", Translation.EncodeToUtf16("(Осталось рук: "));
            Translation.ILTranslate(il, "(Arms left: ", Translation.EncodeToUtf16("(Осталось оружий: "));
            Translation.ILTranslate(il, "(Guns left: ", Translation.EncodeToUtf16("(Осталось ружей: "));
            Translation.ILTranslate(il, "(Cannons left: ", Translation.EncodeToUtf16("(Осталось пушек: "));
            Translation.ILTranslate(il, "(Dark Energy left: ", Translation.EncodeToUtf16("(Осталось тёмной энергии: "));
            Translation.ILTranslate(il, "(Body Parts left: ", Translation.EncodeToUtf16("(Осталось частей тела: "));
            Translation.ILTranslate(il, "(Large Slimes left: ", Translation.EncodeToUtf16("(Осталось больших слизней: "));
        }
        
        private static void Ru_ModifyDrawOpenAnim(ILContext il)
        {
            Translation.ILTranslate(il, "(Segments left: ", Translation.EncodeToUtf16("(Осталось сегментов: "));
            Translation.ILTranslate(il, "(Creepers left: ", Translation.EncodeToUtf16("(Осталось ползунов: "));
            Translation.ILTranslate(il, "(Hands left: ", Translation.EncodeToUtf16("(Осталось рук: "));
            Translation.ILTranslate(il, "(Arms left: ", Translation.EncodeToUtf16("(Осталось оружий: "));
            Translation.ILTranslate(il, "(Guns left: ", Translation.EncodeToUtf16("(Осталось ружей: "));
            Translation.ILTranslate(il, "(Cannons left: ", Translation.EncodeToUtf16("(Осталось пушек: "));
            Translation.ILTranslate(il, "(Dark Energy left: ", Translation.EncodeToUtf16("(Осталось тёмной энергии: "));
            Translation.ILTranslate(il, "(Body Parts left: ", Translation.EncodeToUtf16("(Осталось частей тела: "));
            Translation.ILTranslate(il, "(Large Slimes left: ", Translation.EncodeToUtf16("(Осталось больших слизней: "));
        }
        
        private static void Ru_ModifyBossLootCalamitasRun3(ILContext il) => Translation.ILTranslate(il, "The Calamitas Clone", Translation.EncodeToUtf16("Клон Каламитас"));
        
        private static void Ru_ModifyBossLootRavager(ILContext il) => Translation.ILTranslate(il, "Ravager", Translation.EncodeToUtf16("Разрушитель"));
        
        private static void Ru_ModifyCensusSupport(ILContext il)
        {
            Translation.ILTranslate(il, "Defeat a Giant Clam after defeating the Desert Scourge", Translation.EncodeToUtf16("Одолейте Гигантского моллюска после победы над Пустынным бичем"));
            Translation.ILTranslate(il, "Have a [i:", Translation.EncodeToUtf16("Имейте [i:"));
            Translation.ILTranslate(il, "] in your inventory after defeating Skeletron", Translation.EncodeToUtf16("] в вашем инвентаре после победы над Скелетроном"));
            Translation.ILTranslate(il, "Defeat Cryogen", Translation.EncodeToUtf16("Одолейте Криогена"));
            Translation.ILTranslate(il, "Have [i:", Translation.EncodeToUtf16("Имейте [i:"));
            Translation.ILTranslate(il, "] in your inventory in Hardmode", Translation.EncodeToUtf16("] в вашем инвентаре в Хардмоде"));
        }
        
        private static void Ru_ModifyAddCalamityInvasions(ILContext il)
        {
            Translation.ILTranslate(il, "Use a [i:{0}] or wait for the invasion to occur naturally after the Eye of Cthulhu is defeated.", Translation.EncodeToUtf16("Используйте [i:{0}] или дождитесь, пока событие произойдёт естественным образом после победы над Глазом Ктулху."));
            Translation.ILTranslate(il, "The mysterious creatures of the sulphuric sea descended back into the ocean.", Translation.EncodeToUtf16("Таинственные существа сернистого моря спустились обратно в океан."));
            Translation.ILTranslate(il, "Acid Rain", Translation.EncodeToUtf16("Кислотный дождь"));
            Translation.ILTranslate(il, "Use a [i:{0}] or [i:{1}] or wait for the invasion to occur naturally after the Aquatic Scourge is defeated", Translation.EncodeToUtf16("Используйте [i:{0}] или, [i:{1}] или дождитесь, пока событие произойдёт естественным образом после победы над Акватическим бичом."));
            Translation.ILTranslate(il, "The mysterious creatures of the sulphuric sea descended back into the deep ocean.", Translation.EncodeToUtf16("Таинственные существа сернистого моря спустились обратно в глубины океана."));
            Translation.ILTranslate(il, "Acid Rain (Post-AS)", Translation.EncodeToUtf16("Кислотный дождь (Пост-Аб)"));
            Translation.ILTranslate(il, "Use a [i:{0}] or [i:{1}] or wait for the invasion to occur naturally after the Polterghast is defeated", Translation.EncodeToUtf16("Используйте [i:{0}] или, [i:{1}] или дождитесь, пока событие произойдёт естественным образом после победы над Полтергастом."));
            Translation.ILTranslate(il, "Acid Rain (Post-Polter)", Translation.EncodeToUtf16("Кислотный дождь (Пост-Полтер)"));
            Translation.ILTranslate(il, "The mysterious creatures of the sulphuric sea descended back into the deep ocean.", Translation.EncodeToUtf16("Таинственные существа сернистого моря спустились обратно в глубины океана."), 2);
        }
        
        private static void Ru_ModifyNewRightClick(ILContext il)
        {
            Translation.ILTranslate(il, "Spawn point removed!", Translation.EncodeToUtf16("Точка воскрешения удалена!"));
            Translation.ILTranslate(il, "Spawn point set!", Translation.EncodeToUtf16("Точка воскрешения задана!"));
        }
        
        private static void Ru_ModifyBedRightClick(ILContext il)
        {
            Translation.ILTranslate(il, "Spawn point removed!", Translation.EncodeToUtf16("Точка воскрешения удалена!"));
            Translation.ILTranslate(il, "Spawn point set!", Translation.EncodeToUtf16("Точка воскрешения задана!"));
        }
        
        private static void Ru_ModifySpawnDoggo(ILContext il)
        {
            Translation.ILTranslate(il, "It's not over yet, kid!", Translation.EncodeToUtf16("Это ещё не конец, малыш!"));
            Translation.ILTranslate(il, "Don't get cocky, kid!", Translation.EncodeToUtf16("Не будь таким самоуверенным, малыш!"));
        }
        
        private static void Ru_ModifyAIChibiiDoggo(ILContext il) => Translation.ILTranslate(il, " couldn't stand the sharp objects.", Translation.EncodeToUtf16(" не выдерживал острых предметов."));
        
        private static void Ru_ModifyAIHolyBurnOrb(ILContext il) => Translation.ILTranslate(il, " burst into sinless ash.", Translation.EncodeToUtf16(" превратился в безгрешный пепел."));
        
        private static void Ru_ModifyAIHealOrbProv(ILContext il) => Translation.ILTranslate(il, " burst into sinless ash.", Translation.EncodeToUtf16(" превратился в безгрешный пепел."));
        
        private static void Ru_ModifyGetChatFap(ILContext il) => Translation.ILTranslate(il, " was slapped too hard.", Translation.EncodeToUtf16(" получил слишком сильную пощечину."));
        
        private static void Ru_ModifyModifyHitPlayerFearlessGoldfishWarrior(ILContext il) => Translation.ILTranslate(il, " was once again impaled by Goldfish.", Translation.EncodeToUtf16(" был снова проткнут Золотой рыбкой."));
        
        private static void Ru_ModifyOnHitPlayerDevourerofGodsHeadS(ILContext il) => Translation.ILTranslate(il, "'s essence was consumed by the devourer.", Translation.EncodeToUtf16(" сущность была поглощена пожирателем."));
        
        private static void Ru_ModifyOnHitPlayerDevourerofGodsHead(ILContext il) => Translation.ILTranslate(il, "'s essence was consumed by the devourer.", Translation.EncodeToUtf16(" сущность была поглощена пожирателем."));
        
        private static void Ru_ModifyShootNullificationRifle(ILContext il)
        {
            Translation.ILTranslate(il, " was vaporized by the imbuement of his life.", Translation.EncodeToUtf16(" испарился из-за насыщенности своей жизни."));
            Translation.ILTranslate(il, " was vaporized by the imbuement of her life.", Translation.EncodeToUtf16(" испарилась из-за насыщенности своей жизни."));
        }
        
        private static void Ru_ModifyMolecularManipulator(ILContext il)
        {
            Translation.ILTranslate(il, " was vaporized by the imbuement of his life.", Translation.EncodeToUtf16(" испарился из-за насыщенности своей жизни."));
            Translation.ILTranslate(il, " was vaporized by the imbuement of her life.", Translation.EncodeToUtf16(" испарилась из-за насыщенности своей жизни."));
        }
        
        private static void Ru_ModifyShootBloodBoiler(ILContext il)
        {
            Translation.ILTranslate(il, " suffered from severe anemia.", Translation.EncodeToUtf16(" страдал тяжёлой анемией."));
            Translation.ILTranslate(il, " was unable to obtain a blood transfusion.", Translation.EncodeToUtf16(" не удалось добиться переливания крови."));
        }
        
        private static void Ru_ModifyShootThornLucrecia(ILContext il)
        {
            Translation.ILTranslate(il, "'s DNA was destroyed.", Translation.EncodeToUtf16(" ДНК была уничтожена."));
        }
        
        private static void Ru_ModifyShootThornBlossom(ILContext il)
        {
            Translation.ILTranslate(il, " was violently pricked by a flower.", Translation.EncodeToUtf16(" был яростно уколот цветком."));
        }
        
        private static void Ru_ModifyOnConsumeItemAstralInjection(ILContext il)
        {
            Translation.ILTranslate(il, "'s blood vessels burst from drug overdose.", Translation.EncodeToUtf16(" кровеносные сосуды лопаются от передозировки наркотиков."));
        }

        private static void Ru_ModifyChooseDialogue(ILContext il)
        {
            Translation.ILTranslate(il, "To any personnel engaged in the laboratories. Please wear your steel engraved ID badge at all times. It is the easiest method to discern your body if any accidents do occur.", Translation.EncodeToUtf16("Напоминаем всему персоналу. Пожалуйста, носите ваш персональный стальной идентификационный значок. Это самый простой способ опознать тело в случае несчастного случая."));
            Translation.ILTranslate(il, "To experiment is to fail. To fail is to learn. To learn is to advance.", Translation.EncodeToUtf16("Экспериментировать — значит терпеть неудачи. Терпеть неудачи — значит учиться. Учиться — значит становиться лучше."));
            Translation.ILTranslate(il, "Apparent danger while researching serves only to enhance the research experience.", Translation.EncodeToUtf16("Кажущаяся опасность во время исследований только усиливает исследовательский опыт."));
            Translation.ILTranslate(il, "Laser-type weapon prototypes are incredibly lethal and are not to be used within presentation halls.", Translation.EncodeToUtf16("Прототипы лазерного оружия невероятно смертоносны и не должны использоваться в презентационных залах."));
            Translation.ILTranslate(il, "High-energy plasma emissions have adverse effects on both flesh and metal. Do not attempt to handle vented plasma.", Translation.EncodeToUtf16("Высокоэнергетические плазменные выбросы оказывают неблагоприятное воздействие как на плоть, так и на металл. Не пытайтесь обращаться с изливающейся плазмой."));
            Translation.ILTranslate(il, "Electric shocks from military equipment are intended to be fatal. If you survive such a shock, that is a clear indicator that the device is not functioning properly. Please report any such cases.", Translation.EncodeToUtf16("Удары электрического тока, вызванные оружием, должны быть летальными. Если вы пережили удар током, это явный признак того, что устройство не функционирует должным образом. Пожалуйста, сообщите о любых таких случаях."));
            Translation.ILTranslate(il, "All employees are hereby notified that they will be held accountable for any collateral damage caused by Gauss weapon fire, even during sanctioned testing exercises.", Translation.EncodeToUtf16("Все сотрудники уведомляются, что они будут нести ответственность за любой сопутствующий ущерб, причинённый огнём гауссовского оружия, даже во время санкционированных испытательных учений."));
            Translation.ILTranslate(il, "Security Field Emitters will vaporize all unauthorized equipment and personnel. Please leave personal effects in the designated lockers off-site. This also means: Do not bring any family members who are not enlisted as personnel.", Translation.EncodeToUtf16("Излучатели защитного поля уничтожат всё несанкционированное оборудование и персонал. Пожалуйста, оставьте личные вещи в специально отведённых запирающихся шкафчиках за пределами поля. Это также означает: Не приводите с собой членов семьи, которые не зачислены в личный состав."));
            Translation.ILTranslate(il, "If one does manage to breach restricted testing facilities, do at least record any unexpected burns, lacerations, bruising, fractur... ...trauma, shocks and otherwise. Thank you.", Translation.EncodeToUtf16("Если кто-то всё же решит пробраться в закрытые испытательные помещения, то хотя бы сделайте запись неожиданных ожогов, рваных ран, кровоизлияний, переломов... травм, шоковых ожогов и др. Спасибо."));
            Translation.ILTranslate(il, "The power grid has been... ...eavily compromised. Abort research and proceed to the emergency exits located at... ...and egress with haste.", Translation.EncodeToUtf16("Энергосистема была... ...кована, серьёзные повреждения. Прервите исследования и пройдите к аварийным выходам, расположенным... ...и выходите с поспешностью."));
            Translation.ILTranslate(il, "Notify the Security Department of any aggressive local fauna immediately.", Translation.EncodeToUtf16("Немедленно сообщите в Службу безопасности о любой местной агрессивной фауне."));
            Translation.ILTranslate(il, "Sensors have detected a significant breach in the spacetime continuum.", Translation.EncodeToUtf16("Сенсоры обнаружили значительное нарушение пространственно-временного континуума."));
            Translation.ILTranslate(il, "Please help. I'm stuck in this hologram machine.", Translation.EncodeToUtf16("Пожалуйста, помогите. Я застрял в голограмме."));
        }
        
        private static void Ru_ModifySetChatButtonsThief(ILContext il) => Translation.ILTranslate(il, "Refund", Translation.EncodeToUtf16("Возврат"));
        
        private static void Ru_ModifySetChatButtonsSeahoe(ILContext il) => Translation.ILTranslate(il, "Help", Translation.EncodeToUtf16("Помощь"));
        
        private static void Ru_ModifySetChatButtonsFap(ILContext il) => Translation.ILTranslate(il, "Death Count", Translation.EncodeToUtf16("Количество смертей"));
        
        private static void Ru_ModifyAddCalamityBosses(ILContext il)
        {
            Translation.ILTranslate(il, "Use a [i:{0}] in the Desert Biome", Translation.EncodeToUtf16("Используйте [i:{0}] в пустыне."));
            Translation.ILTranslate(il, "The scourge of the desert delved back into the sand.", Translation.EncodeToUtf16("Пустынный бич снова погрузился в песок."));
            Translation.ILTranslate(il, "Desert Scourge", Translation.EncodeToUtf16("Пустынный бич"));
            Translation.ILTranslate(il, "Can spawn naturally in the Sunken Sea", Translation.EncodeToUtf16("Может естественно появится в затерянном море."));
            Translation.ILTranslate(il, "The Giant Clam returns into hiding in its grotto.", Translation.EncodeToUtf16("Гигантский моллюск скрывается в своём гроту."));
            Translation.ILTranslate(il, "Giant Clam", Translation.EncodeToUtf16("Гигантский моллюск"));
            Translation.ILTranslate(il, "Use a [i:{0}] in the Mushroom Biome", Translation.EncodeToUtf16("Используйте [i:{0}] в грибном биоме."));
            Translation.ILTranslate(il, "The mycleium crab has lost interest.", Translation.EncodeToUtf16("Мицелиевый краб потерял интерес."));
            Translation.ILTranslate(il, "Crabulon", Translation.EncodeToUtf16("Крабулон"), 2);
            Translation.ILTranslate(il, "Kill a Cyst in the Corruption or use a [i:{0}] in the Corruption", Translation.EncodeToUtf16("Убейте кисту или используйте [i:{0}] в искажении."));
            Translation.ILTranslate(il, "The corrupted colony began searching for a new breeding ground.", Translation.EncodeToUtf16("Искажённая стая начала поиски нового места для размножения."));
            Translation.ILTranslate(il, "Hive Mind", Translation.EncodeToUtf16("Разум Улья"));
            Translation.ILTranslate(il, "Kill a Cyst in the Crimson or use a [i:{0}] in the Crimson", Translation.EncodeToUtf16("Убейте кисту или используйте [i:{0}] в багрянце."));
            Translation.ILTranslate(il, "The parasitic hive began searching for a new host.", Translation.EncodeToUtf16("Паразитический улей начал искать нового носителя."));
            Translation.ILTranslate(il, "The Perforators", Translation.EncodeToUtf16("Перфораторы"));
            Translation.ILTranslate(il, "Use an [i:{0}]", Translation.EncodeToUtf16("Используйте [i:{0}]."));
            Translation.ILTranslate(il, "The gelatinous monstrosity achieved vengeance for its brethren.", Translation.EncodeToUtf16("Желатиновое чудовище отомстило за своих собратьев."));
            Translation.ILTranslate(il, "Slime God", Translation.EncodeToUtf16("Бог слизней"));
            Translation.ILTranslate(il, "Use a [i:{0}] in the Snow Biome", Translation.EncodeToUtf16("Используйте [i:{0}] в снегах."));
            Translation.ILTranslate(il, "Cryogen drifts away, carried on a freezing wind.", Translation.EncodeToUtf16("Криоген уносится прочь ледяным ветром."));
            Translation.ILTranslate(il, "Cryogen", Translation.EncodeToUtf16("Криоген"), 2);
            Translation.ILTranslate(il, "Use a [i:{0}] in the Brimstone Crag", Translation.EncodeToUtf16("Используйте [i:{0}] в серной скале."));
            Translation.ILTranslate(il, "Brimstone Elemental withdraws to the ruins of her shrine.", Translation.EncodeToUtf16("Серный элементаль отступает к руинам своей святыни."));
            Translation.ILTranslate(il, "Brimstone Elemental", Translation.EncodeToUtf16("Серный элементаль"));
            Translation.ILTranslate(il, "Use a [i:{0}] in the Sulphuric Sea or wait for it to spawn in the Sulphuric Sea", Translation.EncodeToUtf16("Используйте [i:{0}] или подождите его появление в сернистом море."));
            Translation.ILTranslate(il, "The Aquatic Scourge swam back into the open ocean.", Translation.EncodeToUtf16("Акватический бич уплыл обратно в открытый океан."));
            Translation.ILTranslate(il, "Aquatic Scourge", Translation.EncodeToUtf16("Акватический бич"));
            Translation.ILTranslate(il, "Use an [i:{0}] at Night", Translation.EncodeToUtf16("Используйте [i:{0}] ночью."));
            Translation.ILTranslate(il, "If you wanted a fight, you should've came more prepared.", Translation.EncodeToUtf16("Если вы хотели драки, вы должны были прийти более подготовленными."));
            Translation.ILTranslate(il, "Calamitas", Translation.EncodeToUtf16("Каламитас"), 2);
            Translation.ILTranslate(il, "Kill 10 sand sharks after defeating Plantera or use a [i:{0}] in the Desert Biome", Translation.EncodeToUtf16("Убейте 10 песчаных акул после победы над Плантерой или используйте [i:{0}] в пустыне."));
            Translation.ILTranslate(il, "The apex predator of the sands disappears into the dunes...", Translation.EncodeToUtf16("Высший хищник песков исчезает в дюнах..."));
            Translation.ILTranslate(il, "Great Sand Shark", Translation.EncodeToUtf16("Великая песчаная акула"));
            Translation.ILTranslate(il, "By killing an unknown entity in the Ocean Biome", Translation.EncodeToUtf16("Убейте неизвестное существо в океане"));
            Translation.ILTranslate(il, "The aquatic entities sink back beneath the ocean depths.", Translation.EncodeToUtf16("Водные существа возвращаются в глубины океана."));
            Translation.ILTranslate(il, "Leviathan", Translation.EncodeToUtf16("Левиафан"), 2);
            Translation.ILTranslate(il, "Use an [i:{0}] at Night in the Astral Biome", Translation.EncodeToUtf16("Используйте [i:{0}] ночью в астральном биоме."));
            Translation.ILTranslate(il, "Astrum Aureus’ program has been executed. Initiate recall.", Translation.EncodeToUtf16("Программа Аструм Ареуса выполнена. Запущен возврат."));
            Translation.ILTranslate(il, "Astrum Aureus", Translation.EncodeToUtf16("Аструм Ареус"));
            Translation.ILTranslate(il, "Use an [i:{0}] in the Jungle Biome", Translation.EncodeToUtf16("Используйте [i:{0}] в джунглях."));
            Translation.ILTranslate(il, "HOSTILE SPECIMENS TERMINATED. INITIATE RECALL TO HOME BASE.", Translation.EncodeToUtf16("ВРАЖДЕБНЫЕ СУЩНОСТИ УНИЧТОЖЕНЫ. ЗАПУЩЕН ВОЗВРАТ НА БАЗУ."));
            Translation.ILTranslate(il, "Plaguebringer Goliath", Translation.EncodeToUtf16("Разносчица чумы, Голиаф"));
            Translation.ILTranslate(il, "Use an [i:{0}]", Translation.EncodeToUtf16("Используйте [i:{0}]."), 2);
            Translation.ILTranslate(il, "The automaton of misshapen victims went looking for the true perpetrator.", Translation.EncodeToUtf16("Машина бесформенных жертв отправилась на поиски истинного нарушителя."));
            Translation.ILTranslate(il, "Ravager", Translation.EncodeToUtf16("Разрушитель"), 2);
            Translation.ILTranslate(il, "Use a [i:{0}] or [i:{1}] as offering at an [i:{2}]", Translation.EncodeToUtf16("Используйте [i:{0}] или [i:{1}] в качестве подношения на [i:{2}]."));
            Translation.ILTranslate(il, "The infected deity retreats to the heavens.", Translation.EncodeToUtf16("Заражённое божество отступает к небесам."));
            Translation.ILTranslate(il, "Astrum Deus", Translation.EncodeToUtf16("Аструм Деус"));
            Translation.ILTranslate(il, "Use a [i:{0}] in the Hallow or Underworld Biomes", Translation.EncodeToUtf16("Используйте [i:{0}] в святых землях или в аду."));
            Translation.ILTranslate(il, "The guardians must protect their goddess at all costs.", Translation.EncodeToUtf16("Стражи должны защищать свою богиню любой ценой."));
            Translation.ILTranslate(il, "Profaned Guardians", Translation.EncodeToUtf16("Осквернённые стражи"));
            Translation.ILTranslate(il, "Use [i:{0}] in the Jungle Biome", Translation.EncodeToUtf16("Используйте [i:{0}] в джунглях."));
            Translation.ILTranslate(il, "The failed experiment returns to its reproductive routine.", Translation.EncodeToUtf16("Неудачный эксперимент вернулся к своему репродуктивному распорядку."));
            Translation.ILTranslate(il, "Dragonfolly", Translation.EncodeToUtf16("Псевдодракон"), 2);
            Translation.ILTranslate(il, "Use either [i:{0}] or [i:{1}] in the Hallow or Underworld Biomes", Translation.EncodeToUtf16("Используйте либо [i:{0}], либо [i:{1}] в святых землях или аду."));
            Translation.ILTranslate(il, "The Profaned Goddess vanishes in a burning blaze.", Translation.EncodeToUtf16("Осквернённая богиня исчезает в горящем пламени."));
            Translation.ILTranslate(il, "Providence", Translation.EncodeToUtf16("Провиденс"), 2);
            Translation.ILTranslate(il, "Use a [i:{0}] in the Dungeon", Translation.EncodeToUtf16("Используйте [i:{0}] в темнице."));
            Translation.ILTranslate(il, "The rift in time and space has moved away from your reach.", Translation.EncodeToUtf16("Разлом во времени и пространстве удалился вдаль."));
            Translation.ILTranslate(il, "Ceaseless Void", Translation.EncodeToUtf16("Нескончаемая пустота"));
            Translation.ILTranslate(il, "Use a [i:{0}] in Space", Translation.EncodeToUtf16("Используйте [i:{0}] в космосе."));
            Translation.ILTranslate(il, "Storm Weaver hid itself once again within the stormfront.", Translation.EncodeToUtf16("Штормовой ткач снова спрятался в грозовом фронте."));
            Translation.ILTranslate(il, "Storm Weaver", Translation.EncodeToUtf16("Штормовой ткач"));
            Translation.ILTranslate(il, "Use a [i:{0}] in the Underworld", Translation.EncodeToUtf16("Используйте [i:{0}] в аду."));
            Translation.ILTranslate(il, "The Devourer's assassin has finished its easy task.", Translation.EncodeToUtf16("Убийца Пожирателя выполнил свою лёгкую задачу."));
            Translation.ILTranslate(il, "Signus", Translation.EncodeToUtf16("Сигнус"), 2);
            Translation.ILTranslate(il, "Kill 30 phantom spirits or use a [i:{0}] in the Dungeon", Translation.EncodeToUtf16("Убейте 30 фантомных духов или используйте [i:{0}] в темнице."));
            Translation.ILTranslate(il, "The volatile spirits disperse throughout the depths of the dungeon.", Translation.EncodeToUtf16("Нестабильные духи разбредаются по темнице."));
            Translation.ILTranslate(il, "Polterghast", Translation.EncodeToUtf16("Полтергаст"), 2);
            Translation.ILTranslate(il, "Defeat the Acid Rain event post-Polterghast or fish using a [i:{0}] in the Sulphurous Sea", Translation.EncodeToUtf16("Одолейте событие «Кислотный дождь» после победы над Полтергастом или выловите с помощью [i:{0}] в сернистом море"));
            Translation.ILTranslate(il, "The old duke disappears amidst the acidic downpour.", Translation.EncodeToUtf16("Старый герцог исчезает посреди кислотного ливня."));
            Translation.ILTranslate(il, "Old Duke", Translation.EncodeToUtf16("Старый герцог"));
            Translation.ILTranslate(il, "Use a [i:{0}]", Translation.EncodeToUtf16("Используйте [i:{0}]."));
            Translation.ILTranslate(il, "The Devourer of Gods has slain everyone and feasted on their essence.", Translation.EncodeToUtf16("Пожиратель богов убил всех и пировал их сущностью."));
            Translation.ILTranslate(il, "Devourer of Gods", Translation.EncodeToUtf16("Пожиратель богов"));
            Translation.ILTranslate(il, "Use a [i:{0}] in the Jungle Biome", Translation.EncodeToUtf16("Используйте [i:{0}] в джунглях."));
            Translation.ILTranslate(il, "Yharon found you too weak to stay near your gravestone.", Translation.EncodeToUtf16("Ярон считает вас слишком слабым, чтобы оставаться с вашим надгробием."));
            Translation.ILTranslate(il, "Yharon", Translation.EncodeToUtf16("Ярон"), 2);
            Translation.ILTranslate(il, "Use an [i:{0}]", Translation.EncodeToUtf16("Используйте [i:{0}]."), 3);
            Translation.ILTranslate(il, "Please don't waste my time.", Translation.EncodeToUtf16("Пожалуйста, не трать моё время."));
            Translation.ILTranslate(il, "Supreme Calamitas", Translation.EncodeToUtf16("Высшая Каламитас"));
        }
        
        private static void Ru_ModifyGetTextByPageSunkenSeaGui(ILContext il)
        {
            Translation.ILTranslate(il, "Preserved for millennia, a paradise for the living beings who sought shelter in prehistoric seas. They remain untouched by evolution, save for their adaptations to the oxygen starved waters and dim crystals, continuing to thrive. One mystery which continues to escape my understanding however, is how large some of the creatures have become. There is a blatant lack of nutrition and oxygen in the caves, and yet...", Translation.EncodeToUtf16("Сохранившийся на протяжении тысячелетий рай для живых существ, искавших убежища в доисторических морях. Они остаются не тронутыми эволюцией, за исключением их адаптации к необогащенной воздухом воде и тусклым кристаллам, продолжая процветать. Однако одна загадка, которая продолжает ускользать от моего понимания, заключается в том, насколько большими стали некоторые из этих существ. В пещерах явно не хватает питания и кислорода, и всё же..."));
            Translation.ILTranslate(il, "A specimen which has developed a grand size, and inexplicably, impressive psychic abilities. What is most curious is its strong connection to its lesser kin. Without any noticeable communication, when it comes under threat, other mollusks rally to its aggressor and begin attacking. Is this perhaps the very first signs of a higher life form, the evolutionary link hidden away in the sunken sea? Or a self sacrificial fluke, which would lead to their destruction if they inhabited any area other than these pacified caverns.", Translation.EncodeToUtf16("Образец, который развил грандиозные размеры и необъяснимо-впечатляющие телепатические способности. Что самое любопытное, так это его сильная связь со своими меньшими родственниками. Когда он оказывается под угрозой, другие моллюски окружают своего агрессора и начинают атаковать. Может быть, это самые первые признаки высшей формы жизни, эволюционное звено, скрытое в затерянном море? Или самоотверженная случайность, которая привела бы к уничтожению, если они населяли любую область, кроме этих умиротворённых пещер."));
            Translation.ILTranslate(il, "The marine life in these caves do have eyes though they are barely functional, dulled by lack of use and milky white upon observation. On their tough, gnarled hides, crystals find an easy purchase, and grow in great numbers, providing the creatures protection. Perhaps another adaptation to the life they have adopted. The most striking wonder is within their bodies. In specimens dissected, I have noticed that the mineral is buried into their very digestive systems, and perhaps, through some chemical process, pass nutrients into their sluggish hosts. A peculiar yet entirely beneficial interaction.", Translation.EncodeToUtf16("У морских обитателей в этих пещерах есть глаза-рудименты, внешне они молочно-белые. На их жёстких узловатых шкурах кристаллы растут в большом количестве, обеспечивая существам защиту. Возможно, это ещё одна адаптация к жизни, которую они приняли. Но самое поразительное чудо — внутренности их тел. В образцах, подвергнутых вскрытию, я заметил, что минерал находится в самой их пищеварительной системе и, возможно, через какой-то химический процесс передаёт питательные вещества их вялым хозяевам. Своеобразное, но совершенно благотворное взаимодействие."));
        }
        
        private static void Ru_ModifyGetTextByPageSnowBiomeGui(ILContext il)
        {
            Translation.ILTranslate(il, "A freezing tundra, where only creatures entirely adapted to the subzero temperatures exist and thrive. It is a shocking transition from the forests of the purity and the sun baked desert. A climate like this should not exist naturally in this part of the world with ease. The weather patterns seem to shift unnaturally arounds the skies of these icy plains. There is likely a reason for this, which necessitates further research.", Translation.EncodeToUtf16("Холодная тундра, где существуют и процветают существа, полностью приспособленные к минусовым температурам. Это шокирующий переход от чистых лесов и выжженной солнцем пустыни. Климат, подобный этому, не должен существовать естественно. Погодные условия на этих ледяных равнинах, кажется, неестественно меняются. Вероятно, этому есть причина, которая требует дальнейших исследований."));
            Translation.ILTranslate(il, "I am not the only singular being to inhabit this biome. Once before, the Archmage who opposed the Lord resided here, cloaked by constant artificial blizzards of his own creation, which no longer fall. He likely chose this place as a conduit for research into his ice spells, and extended the period of time that this place remained frozen. Deep underground my research and materials lay well protected, but above in the natural storms there are traces of the prison of ice he resides in, still haunting its place of creation.", Translation.EncodeToUtf16("Я не единственное разумное существо, находившееся в этом биоме. До этого Архимаг, противостоявший Лорду, жил здесь. Скорее всего, он выбрал это место для изучения ледяных заклятий, одно из которых — нескончаемые ледяные бури. Его действия поддерживали биом в глубокой заморозке. Глубоко под землёй мои исследования хорошо защищены, но снаружи, в естественных бурях, есть следы ледяной тюрьмы, в которой он пребывает по сей день, всё ещё бродящей в месте своего создания."));
            Translation.ILTranslate(il, "Intriguing. Though embedded deep into the caverns of ice and worn from centuries of frost and meltwater, I have uncovered several mechanisms which once filled the tunnels here. The ingenuity present is remarkable, and I have found parallels within my own work, as well as devices even I have something to learn from. From where do these come? Why machinery so complex in so sparse and dreary a habitat? Perhaps, they are related to the unnatural conditions.", Translation.EncodeToUtf16("Интригующе. Я нашёл механизмы, когда-то заполнявшие туннели. Они находились в ледяных пещерах, поломанные из-за веков во льду и талой воды. Мастерство исполнения поражает. Я нашёл схожести с моими работами, а также узнал что-то новое. Но кто их создал? Почему настолько сложные машины находятся в такой скудной и унылой среде обитания. Возможно, именно они виноваты в настолько неестественных условиях."));
        }
        
        private static void Ru_ModifyGetTextByPagePlanetoidGui(ILContext il)
        {
            Translation.ILTranslate(il, "Hung low in orbit, masses of ground and various parts of the world provide a secluded and distant point for research. Undeniably optimal for the science of astronomy and otherwise. In my labs here I grow many things, testing their limits against the cold and vacuum of the stratosphere. Though not many survive, the existence of certain creatures here, confirm the capabilities of life simply given more time.", Translation.EncodeToUtf16("Висящие низко на орбите массы земли и другие структуры мира, обеспечивают укромное и отдалённое место для исследований. Это оптимальный вариант для изучения астрономии и других наук. В моих лабораториях я выращиваю разные растения и тестирую их способность к выживанию в условиях холода и вакуума стратосферы. Несмотря на то, что многие растения погибают, существование жизни здесь подтверждается. Просто нужно дать этой жизни больше времени на развитие."));
            Translation.ILTranslate(il, "The bloated cosmic worm, though I understand why the Lord decides to employ it given he can control it, is a disgusting existence. However the idea of creating an armor suited to it in every way, was an offer I could not refuse. Forged from the cosmic steel of my own creation, it resists nearly any attack, yet allows the creature the same flexibility it would have without it, as well as augmenting its dimensional abilities. I remain pleased with the result.", Translation.EncodeToUtf16("Раздутый отвратительный космический червь. Впрочем, я понимаю, почему Лорд его использует, ведь он может его контролировать... Идея создания брони, подходящей ему во всех отношениях, была предложением, от которого я не мог отказаться. Выкованная из космической стали, моего собственного создания, броня защищала практически от любой атаки. А также она не уменьшает изначальной гибкости существа, а ещё увеличивает пространственные способности. Я доволен результатом."));
            Translation.ILTranslate(il, "I do not care much for the interstellar, or the cosmos. Though I have traversed it, there is still plenty in my own world to manage and discover at this time. Even if I once inhabited a different planet, the Lord's wishes that I provide him machinery were the only condition that I needed to leave it and settle elsewhere. Once I have discovered and dissected every part of this place, perhaps then, I could look up towards the macroscopic.", Translation.EncodeToUtf16("Меня мало волнует космос. Да, я путешествовал по нему, но сейчас мне достаточно работы по изучению собственного мира. Даже если бы я когда-то жил на другой планете, одного желания Лорда получать мои технологии было бы достаточно, чтобы я улетел с неё сюда. Если же я когда-нибудь полностью изучу каждый кусочек этого места, то тогда, возможно, я обращу свой взор наверх, в сторону макроскопического."));
        }
        
        private static void Ru_ModifyGetTextByPageJungleGui(ILContext il)
        {
            Translation.ILTranslate(il, "As I record this, it would not be a stretch to call the jungle the hub of this planet. All is centered around it, and none know not of it. It brings me no small amount of unease to see the uncomfortable, raw forms of the living beings who pass through on their journeys above. Fortunately these labs provide everything I need in my research and more. There is no need to ever visit the surface, save for summons on the Lord's orders.", Translation.EncodeToUtf16("Поскольку я записываю это, не будет ошибкой назвать джунгли центром этой планеты. Всё сосредоточено вокруг них, но мало кто знает об этом. Я испытываю немалое беспокойство, видя неудобные, грубые формы живых существ, которые живут в них наверху. К счастью, эти лаборатории обеспечивают всё, что мне нужно в моих исследованиях и не только. Нет никакой необходимости когда-либо посещать поверхность, за исключением вызова по приказу Лорда."));
            Translation.ILTranslate(il, "Mechanically augmented, the Queen Bee which I had prior experimented on was theoretically a perfect host for the plague virus. When the first sign of the technology bonding with the creature began however, the problems also showed immediately. The mind of the insect fought the control of the nanotechnology, nothing like the simpler creatures I had used as test subjects. It grew increasingly violent, and only once subdued did it receive simple orders. However, if we were to utilize it at all, there is no other way than to let it roam free entirely. I will consider this further.", Translation.EncodeToUtf16("Механически усиленная королева пчёл, над которой я ранее экспериментировал, теоретически была идеальным разносчиком чумы. Однако, когда технологии начали менять сущность пчелы, начались проблемы. Разум насекомого противостоял нанотехнологиям, такого раньше не происходило. Она выросла невероятно жестокой и почти не подчинялась приказам. Однако, если мы хотим использовать её, нет другого способа, кроме как позволить ей свободно разгуливать. Я продожлу изучать это дальше."));
            Translation.ILTranslate(il, "A virus, capable of devouring and converting almost anything. And nanotechnology, constructed painstakingly for the sake of control. Development was swift, and every piece fell into place almost eerily, forming an abhorrent existence. I struggle to think of practical applications which would be friendly to common life forms. However, it is not a major concern. Many were hesitant to continue its creation, but I granted them leave if they desired. I would have no need for any who were not entirely as dedicated as my machines.", Translation.EncodeToUtf16("Вирус, способный пожирать и превращать практически всё. И тщательно сделанная нанотехнология контроля. Превращение шло пугающе быстро, создавая мерзкую тварь. Я стараюсь сделать так, чтобы она была дружелюбна к обычным формам жизни. Однако это не главная проблема. Многие не решались продолжать создание, но я разрешил уйти, если они пожелают. Я не нуждался ни в ком, кто не был бы так же предан делу, как мои машины."));
        }
        
        private static void Ru_ModifyDrawAcidRain(ILContext il) => Translation.ILTranslate(il, "Acid Rain", Translation.EncodeToUtf16("Кислотный дождь"));
        
        private static void Ru_ModifyUpdateAccessory(ILContext il) => Translation.ILTranslate(il, " isn't worthy.", Translation.EncodeToUtf16(" не достоин."));
        
        private static void Ru_ModifyKillPlayer(ILContext il)
        {
            Translation.ILTranslate(il, " is food for the Wyrms.", Translation.EncodeToUtf16(" стал пищей для змей."));
            Translation.ILTranslate(il, "Oxygen failed to reach ", Translation.EncodeToUtf16("Не хватило кислорода для "));
            Translation.ILTranslate(il, " from the depths of the Abyss.", Translation.EncodeToUtf16(" из глубин бездны."));
            Translation.ILTranslate(il, " was defeated.", Translation.EncodeToUtf16(" был повержен."));
            Translation.ILTranslate(il, " was chilled to the bone by the frigid environment.", Translation.EncodeToUtf16(" промёрз до костей из-за холодной окружающей среды."));
            Translation.ILTranslate(il, " was consumed by his inner hatred.", Translation.EncodeToUtf16(" был поглощён своей внутренней ненавистью."));
            Translation.ILTranslate(il, " was consumed by her inner hatred.", Translation.EncodeToUtf16(" была поглощена своей внутренней ненавистью."));
            Translation.ILTranslate(il, " failed the challenge at hand.", Translation.EncodeToUtf16(" не справился с испытанием."));
            Translation.ILTranslate(il, " was destroyed by a mysterious force.", Translation.EncodeToUtf16(" был уничтожен таинственной силой."));
        }
        
        private static void Ru_ModifyPreKill(ILContext il)
        {
            Translation.ILTranslate(il, " downed too many shots.", Translation.EncodeToUtf16(" выпил слишком много напитков."));
            Translation.ILTranslate(il, "'s liver failed.", Translation.EncodeToUtf16(" отказала печень."));
            Translation.ILTranslate(il, " was charred by the brimstone inferno.", Translation.EncodeToUtf16(" был обуглен серным пламенем."));
            Translation.ILTranslate(il, "'s soul was released by the lava.", Translation.EncodeToUtf16(" душа была освобождена лавой."));
            Translation.ILTranslate(il, "'s soul was extinguished.", Translation.EncodeToUtf16(" душа была погашена."));
            Translation.ILTranslate(il, " was melted by the toxic waste.", Translation.EncodeToUtf16(" был расплавлен токсичными отходами."));
            Translation.ILTranslate(il, " disintegrated into ashes.", Translation.EncodeToUtf16(" рассыпался в прах."));
            Translation.ILTranslate(il, " was turned to ashes by the Profaned Goddess.", Translation.EncodeToUtf16(" был обращён Осквернённой богиней в пепел."));
            Translation.ILTranslate(il, " fell prey to their sins.", Translation.EncodeToUtf16(" пал жертвой своих грехов."));
            Translation.ILTranslate(il, "'s spirit was turned to ash.", Translation.EncodeToUtf16(" дух превратился в пепел."));
            Translation.ILTranslate(il, " became a blood geyser.", Translation.EncodeToUtf16(" стал кровавым гейзером."));
            Translation.ILTranslate(il, " was crushed by the pressure.", Translation.EncodeToUtf16(" был раздавлен давлением."));
            Translation.ILTranslate(il, "'s lungs collapsed.", Translation.EncodeToUtf16(" лёгкие отказали."));
            Translation.ILTranslate(il, " was consumed by the black flames.", Translation.EncodeToUtf16(" был поглощён чёрным пламенем."));
            Translation.ILTranslate(il, "'s flesh was melted by the plague.", Translation.EncodeToUtf16(" плоть была расплавлена чумой."));
            Translation.ILTranslate(il, " didn't vaccinate.", Translation.EncodeToUtf16(" не сделал прививок."));
            Translation.ILTranslate(il, "'s infection spread too far.", Translation.EncodeToUtf16(" инфекция распространилась слишком сильно."));
            Translation.ILTranslate(il, "'s skin was replaced by the astral virus.", Translation.EncodeToUtf16(" кожа была заменена астральным вирусом."));
            Translation.ILTranslate(il, " was incinerated by lunar rays.", Translation.EncodeToUtf16(" был испепелён лунными лучами."));
            Translation.ILTranslate(il, " vaporized into thin air.", Translation.EncodeToUtf16(" растворился в воздухе."));
            Translation.ILTranslate(il, "'s life was completely converted into mana.", Translation.EncodeToUtf16(" здоровье было полностью преобразовано в ману."));
            Translation.ILTranslate(il, " succumbed to alcohol sickness.", Translation.EncodeToUtf16(" поддался алкогольной болезни."));
            Translation.ILTranslate(il, " was summoned too soon.", Translation.EncodeToUtf16(" был призван слишком рано."));
        }
        
        private static void Ru_ModifyGetTextByPageHellGui(ILContext il)
        {
            Translation.ILTranslate(il, "The entire landscape is a constant source of geothermal energy, and heat for a forge. If it was not entirely uninhabitable save for demons and spirits, I would conduct much more of my research in the bowels of the earth. Where I have actively chosen not to settle however, is in the crags of the underworld. There, the magma is... uncooperative and far more corrosive than should be possible, as it is saturated with cursed, twisted souls, courtesy of that Witch.", Translation.EncodeToUtf16("Весь природный ландшафт — постоянный источник геотермальной энергии и тепла для кузни. Если бы он не был совсем необитаемым, за исключением демонов и духов, я бы проводил больше исследований в недрах земли. Где я точно ни поселился бы, так это в скалах ада. Магма там... 'несговорчива' и агрессивна, намного больше, чем это возможно. Всё из-за того, что она пропиталась проклятыми тёмными душами, любезно предоставленными этой Ведьмой."));
            Translation.ILTranslate(il, "A blade completely inundated with my surroundings during the time of its creation. It was tempered by the fires which are fueled by spirits, and formed in the magma I draw into my laboratories. Its cutting edge, unparalleled, though its reach is limited making general usage questionable. I would consider it my very first foray into work for the sake of craftsmanship and art. If I was born synthetically, any creation which leads one to question whether I was, is a creation I may be proud of. It shows that I can after all, be graced by a muse.", Translation.EncodeToUtf16("Меч, полностью окружённый моим вниманием во время создания. Он сформировался в магме, а закалён огнём душ. Его лезвие — непревзойдённое, хотя его дальность ограничена, что делает общее применение сомнительным. Я думаю, что это моя первая работа, сделанная во имя искусства и мастерства. Если я был рождён синтетически, то любое моё творение, вызывающие вопрос: «Был ли я создан?» — результат, которым можно гордиться. Это доказывает, что я всё же могу быть удостоенным музы."));
            Translation.ILTranslate(il, "What a terrible abomination and yet an enticing subject. Not unlike the fusion of spirits which haunts the dungeons, this entity is formed not of one, but a multitude of sinners. What holds different for it however, is that the limitations caused by the artificiality of the dungeon's existence do not apply to it. It is the laws of hell which brought them together into a single overlord of the underworld. And when an innocent life is sacrificed... Their hunger, which appears to be in tune with the afterlife, surges.", Translation.EncodeToUtf16("Какое ужасное существо, но всё же интересное с научной точки зрения. В отличие от сплава душ темницы, эта сущность была сформирована не из одного грешника, а из многих. Ещё одно отличие заключается в том, что ограничения, вызванные искусственным происхождением темницы, неприменимы к нему. Именно законы Ада свели их вместе в единого владыку подземного мира. И когда невинная жизнь приносится в жертву... Их голод, который, кажется, является частью загробной жизни, нарастает."));
        }
        
        private static void Ru_ModifyHandleMouseInteraction(ILContext il)
        {
            Translation.ILTranslate(il, "Adrenaline: {0} / {1}", Translation.EncodeToUtf16("Адреналин: {0} / {1}"));
            Translation.ILTranslate(il, "Rage: {0} / {1}", Translation.EncodeToUtf16("Ярость: {0} / {1}"));
        }
        
        private static void Ru_ModifyDrawStealth(ILContext il) => Translation.ILTranslate(il, "Stealth: ", Translation.EncodeToUtf16("Скрытность: "));
        
        #endregion

        #region Calamity IL Manipulator

        private static event ILContext.Manipulator ModifyHandleMouseInteraction
        {
            add => HookEndpointManager.Modify(_handleMouseInteraction, value);
            remove => HookEndpointManager.Unmodify(_handleMouseInteraction, value);
        }
        private static event ILContext.Manipulator ModifyDrawStealth
        {
            add => HookEndpointManager.Modify(_drawStealth, value);
            remove => HookEndpointManager.Unmodify(_drawStealth, value);
        }
        private static event ILContext.Manipulator ModifyDrawAcidRain
        {
            add => HookEndpointManager.Modify(_drawAcidRain, value);
            remove => HookEndpointManager.Unmodify(_drawAcidRain, value);
        }
        private static event ILContext.Manipulator ModifyPreKill
        {
            add => HookEndpointManager.Modify(_preKill, value);
            remove => HookEndpointManager.Unmodify(_preKill, value);
        }
        private static event ILContext.Manipulator ModifyKillPlayer
        {
            add => HookEndpointManager.Modify(_killPlayer, value);
            remove => HookEndpointManager.Unmodify(_killPlayer, value);
        }
        private static event ILContext.Manipulator ModifyUpdateAccessory
        {
            add => HookEndpointManager.Modify(_updateAccessory, value);
            remove => HookEndpointManager.Unmodify(_updateAccessory, value);
        }
        private static event ILContext.Manipulator ModifyGetTextByPageHellGui
        {
            add => HookEndpointManager.Modify(_getTextByPageHellGui, value);
            remove => HookEndpointManager.Unmodify(_getTextByPageHellGui, value);
        }
        private static event ILContext.Manipulator ModifyGetTextByPageJungleGui
        {
            add => HookEndpointManager.Modify(_getTextByPageJungleGui, value);
            remove => HookEndpointManager.Unmodify(_getTextByPageJungleGui, value);
        }
        private static event ILContext.Manipulator ModifyGetTextByPagePlanetoidGui
        {
            add => HookEndpointManager.Modify(_getTextByPagePlanetoidGui, value);
            remove => HookEndpointManager.Unmodify(_getTextByPagePlanetoidGui, value);
        }
        private static event ILContext.Manipulator ModifyGetTextByPageSnowBiomeGui
        {
            add => HookEndpointManager.Modify(_getTextByPageSnowBiomeGui, value);
            remove => HookEndpointManager.Unmodify(_getTextByPageSnowBiomeGui, value);
        }
        private static event ILContext.Manipulator ModifyGetTextByPageSunkenSeaGui
        {
            add => HookEndpointManager.Modify(_getTextByPageSunkenSeaGui, value);
            remove => HookEndpointManager.Unmodify(_getTextByPageSunkenSeaGui, value);
        }
        private static event ILContext.Manipulator ModifyAddCalamityBosses
        {
            add => HookEndpointManager.Modify(_addCalamityBosses, value);
            remove => HookEndpointManager.Unmodify(_addCalamityBosses, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsFap
        {
            add => HookEndpointManager.Modify(_setChatButtonsFap, value);
            remove => HookEndpointManager.Unmodify(_setChatButtonsFap, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsSeahoe
        {
            add => HookEndpointManager.Modify(_setChatButtonsSeahoe, value);
            remove => HookEndpointManager.Unmodify(_setChatButtonsSeahoe, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsThief
        {
            add => HookEndpointManager.Modify(_setChatButtonsThief, value);
            remove => HookEndpointManager.Unmodify(_setChatButtonsThief, value);
        }
        private static event ILContext.Manipulator ModifyChooseDialogue
        {
            add => HookEndpointManager.Modify(_chooseDialogue, value);
            remove => HookEndpointManager.Unmodify(_chooseDialogue, value);
        }
        private static event ILContext.Manipulator ModifyOnConsumeItemAstralInjection
        {
            add => HookEndpointManager.Modify(_onConsumeItemAstralInjection, value);
            remove => HookEndpointManager.Unmodify(_onConsumeItemAstralInjection, value);
        }
        private static event ILContext.Manipulator ModifyShootThornBlossom
        {
            add => HookEndpointManager.Modify(_shootThornBlossom, value);
            remove => HookEndpointManager.Unmodify(_shootThornBlossom, value);
        }
        private static event ILContext.Manipulator ModifyShootThornLucrecia
        {
            add => HookEndpointManager.Modify(_shootThornLucrecia, value);
            remove => HookEndpointManager.Unmodify(_shootThornLucrecia, value);
        }
        private static event ILContext.Manipulator ModifyShootBloodBoiler
        {
            add => HookEndpointManager.Modify(_shootBloodBoiler, value);
            remove => HookEndpointManager.Unmodify(_shootBloodBoiler, value);
        }
        private static event ILContext.Manipulator ModifyMolecularManipulator
        {
            add => HookEndpointManager.Modify(_shootMolecularManipulator, value);
            remove => HookEndpointManager.Unmodify(_shootMolecularManipulator, value);
        }
        private static event ILContext.Manipulator ModifyShootNullificationRifle
        {
            add => HookEndpointManager.Modify(_shootNullificationRifle, value);
            remove => HookEndpointManager.Unmodify(_shootNullificationRifle, value);
        }
        private static event ILContext.Manipulator ModifyOnHitPlayerDevourerofGodsHead
        {
            add => HookEndpointManager.Modify(_onHitPlayerDevourerofGodsHead, value);
            remove => HookEndpointManager.Unmodify(_onHitPlayerDevourerofGodsHead, value);
        }
        private static event ILContext.Manipulator ModifyOnHitPlayerDevourerofGodsHeadS
        {
            add => HookEndpointManager.Modify(_onHitPlayerDevourerofGodsHeadS, value);
            remove => HookEndpointManager.Unmodify(_onHitPlayerDevourerofGodsHeadS, value);
        }
        private static event ILContext.Manipulator ModifyModifyHitPlayerFearlessGoldfishWarrior
        {
            add => HookEndpointManager.Modify(_modifyHitPlayerFearlessGoldfishWarrior, value);
            remove => HookEndpointManager.Unmodify(_modifyHitPlayerFearlessGoldfishWarrior, value);
        }
        private static event ILContext.Manipulator ModifyGetChatFap
        {
            add => HookEndpointManager.Modify(_getChatFap, value);
            remove => HookEndpointManager.Unmodify(_getChatFap, value);
        }
        private static event ILContext.Manipulator ModifyAiHealOrbProv
        {
            add => HookEndpointManager.Modify(_aiHealOrbProv, value);
            remove => HookEndpointManager.Unmodify(_aiHealOrbProv, value);
        }
        private static event ILContext.Manipulator ModifyAiHolyBurnOrb
        {
            add => HookEndpointManager.Modify(_aiHolyBurnOrb, value);
            remove => HookEndpointManager.Unmodify(_aiHolyBurnOrb, value);
        }
        private static event ILContext.Manipulator ModifyAiChibiiDoggo
        {
            add => HookEndpointManager.Modify(_aiChibiiDoggo, value);
            remove => HookEndpointManager.Unmodify(_aiChibiiDoggo, value);
        }
        private static event ILContext.Manipulator ModifySpawnDoggo
        {
            add => HookEndpointManager.Modify(_spawnDoggo, value);
            remove => HookEndpointManager.Unmodify(_spawnDoggo, value);
        }
        private static event ILContext.Manipulator ModifyBedRightClick
        {
            add => HookEndpointManager.Modify(_bedRightClick, value);
            remove => HookEndpointManager.Unmodify(_bedRightClick, value);
        }
        private static event ILContext.Manipulator ModifyNewRightClick
        {
            add => HookEndpointManager.Modify(_newRightClick, value);
            remove => HookEndpointManager.Unmodify(_newRightClick, value);
        }
        private static event ILContext.Manipulator ModifyAddCalamityInvasions
        {
            add => HookEndpointManager.Modify(_addCalamityInvasions, value);
            remove => HookEndpointManager.Unmodify(_addCalamityInvasions, value);
        }
        private static event ILContext.Manipulator ModifyCensusSupport
        {
            add => HookEndpointManager.Modify(_censusSupport, value);
            remove => HookEndpointManager.Unmodify(_censusSupport, value);
        }
        private static event ILContext.Manipulator ModifyBossLootRavager
        {
            add => HookEndpointManager.Modify(_bossLootRavager, value);
            remove => HookEndpointManager.Unmodify(_bossLootRavager, value);
        }
        private static event ILContext.Manipulator ModifyBossLootCalamitasRun3
        {
            add => HookEndpointManager.Modify(_bossLootCalamitasRun3, value);
            remove => HookEndpointManager.Unmodify(_bossLootCalamitasRun3, value);
        }
        private static event ILContext.Manipulator ModifyDrawBossHpui
        {
            add => HookEndpointManager.Modify(_drawBossHpui, value);
            remove => HookEndpointManager.Unmodify(_drawBossHpui, value);
        }
        private static event ILContext.Manipulator ModifyDrawOpenAnim
        {
            add => HookEndpointManager.Modify(_drawOpenAnim, value);
            remove => HookEndpointManager.Unmodify(_drawOpenAnim, value);
        }
        private static event ILContext.Manipulator ModifyBossLootProfanedGuardianBoss2
        {
            add => HookEndpointManager.Modify(_bossLootProfanedGuardianBoss2, value);
            remove => HookEndpointManager.Unmodify(_bossLootProfanedGuardianBoss2, value);
        }
        private static event ILContext.Manipulator ModifyBossLootPerforatorHeadLarge
        {
            add => HookEndpointManager.Modify(_bossLootPerforatorHeadLarge, value);
            remove => HookEndpointManager.Unmodify(_bossLootPerforatorHeadLarge, value);
        }
        private static event ILContext.Manipulator ModifyBossLootPerforatorHeadSmall
        {
            add => HookEndpointManager.Modify(_bossLootPerforatorHeadSmall, value);
            remove => HookEndpointManager.Unmodify(_bossLootPerforatorHeadSmall, value);
        }
        private static event ILContext.Manipulator ModifyBossLootBumblefuck
        {
            add => HookEndpointManager.Modify(_bossLootBumblefuck, value);
            remove => HookEndpointManager.Unmodify(_bossLootBumblefuck, value);
        }
        private static event ILContext.Manipulator ModifyBossLootPerforatorHeadMedium
        {
            add => HookEndpointManager.Modify(_bossLootPerforatorHeadMedium, value);
            remove => HookEndpointManager.Unmodify(_bossLootPerforatorHeadMedium, value);
        }
        private static event ILContext.Manipulator ModifyBossLootProfanedGuardianBoss3
        {
            add => HookEndpointManager.Modify(_bossLootProfanedGuardianBoss3, value);
            remove => HookEndpointManager.Unmodify(_bossLootProfanedGuardianBoss3, value);
        }
        private static event ILContext.Manipulator ModifyBossLootProfanedGuardianBoss
        {
            add => HookEndpointManager.Modify(_bossLootProfanedGuardianBoss, value);
            remove => HookEndpointManager.Unmodify(_bossLootProfanedGuardianBoss, value);
        }
        private static event ILContext.Manipulator ModifyInvasionNamebossRushUi
        {
            add => HookEndpointManager.Modify(_invasionNamebossRushUi, value);
            remove => HookEndpointManager.Unmodify(_invasionNamebossRushUi, value);
        }
        private static event ILContext.Manipulator ModifyColdDivinityModifyTooltips
        {
            add => HookEndpointManager.Modify(_coldDivinityModifyTooltips, value);
            remove => HookEndpointManager.Unmodify(_coldDivinityModifyTooltips, value);
        }

        #endregion

        #region Calamity MethodInfo

        private static MethodInfo _handleMouseInteraction;
        private static MethodInfo _drawStealth;
        private static MethodInfo _drawAcidRain;
        private static MethodInfo _preKill;
        private static MethodInfo _killPlayer;
        private static MethodInfo _updateAccessory;
        private static MethodInfo _addCalamityBosses;
        private static MethodInfo _chooseDialogue;
        private static MethodInfo _getTextByPageHellGui;
        private static MethodInfo _getTextByPageJungleGui;
        private static MethodInfo _getTextByPagePlanetoidGui;
        private static MethodInfo _getTextByPageSnowBiomeGui;
        private static MethodInfo _getTextByPageSunkenSeaGui;
        private static MethodInfo _setChatButtonsFap;
        private static MethodInfo _setChatButtonsSeahoe;
        private static MethodInfo _setChatButtonsThief;
        private static MethodInfo _onConsumeItemAstralInjection;
        private static MethodInfo _shootThornBlossom;
        private static MethodInfo _shootThornLucrecia;
        private static MethodInfo _shootBloodBoiler;
        private static MethodInfo _shootMolecularManipulator;
        private static MethodInfo _shootNullificationRifle;
        private static MethodInfo _onHitPlayerDevourerofGodsHead;
        private static MethodInfo _onHitPlayerDevourerofGodsHeadS;
        private static MethodInfo _modifyHitPlayerFearlessGoldfishWarrior;
        private static MethodInfo _getChatFap;
        private static MethodInfo _aiHealOrbProv;
        private static MethodInfo _aiHolyBurnOrb;
        private static MethodInfo _aiChibiiDoggo;
        private static MethodInfo _spawnDoggo;
        private static MethodInfo _bedRightClick;
        private static MethodInfo _newRightClick;
        private static MethodInfo _addCalamityInvasions;
        private static MethodInfo _censusSupport;
        private static MethodInfo _bossLootRavager;
        private static MethodInfo _bossLootCalamitasRun3;
        private static MethodInfo _bossLootProfanedGuardianBoss2;
        private static MethodInfo _bossLootProfanedGuardianBoss3;
        private static MethodInfo _drawBossHpui;
        private static MethodInfo _drawOpenAnim;
        private static MethodInfo _bossLootPerforatorHeadLarge;
        private static MethodInfo _bossLootPerforatorHeadMedium;
        private static MethodInfo _bossLootPerforatorHeadSmall;
        private static MethodInfo _bossLootBumblefuck;
        private static MethodInfo _bossLootProfanedGuardianBoss;
        private static MethodInfo _invasionNamebossRushUi;
        private static MethodInfo _coldDivinityModifyTooltips;

        #endregion
    }
}