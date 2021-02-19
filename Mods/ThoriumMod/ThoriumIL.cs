using System;
using System.Reflection;
using CalamityRuTranslate.Utilities;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;

namespace CalamityRuTranslate.Mods.ThoriumMod
{
    internal class ThoriumIL
    {
        public static void Load() => LoadIL();
        
        public static void Unload() => UnloadIL();

        private static void LoadIL()
        {
            Type aquaticAbility = null;
            Type attackSpeed = null;
            Type criticalStrikeChance = null;
            Type damage = null;
            Type damageReduction = null;
            Type defense = null;
            Type empowermentProlongation = null;
            Type flatDamage = null;
            Type flightTime = null;
            Type invincibilityFrames = null;
            Type jumpHeight = null;
            Type lifeRegeneration = null;
            Type movementSpeed = null;
            Type resourceConsumptionChance = null;
            Type resourceGrabRange = null;
            Type resourceMaximum = null;
            Type resourceRegen = null;
            Type weakReferencesHandler = null;
            Type thoriumMod = null;
            Type almostContract = null;
            Type boneLeeContract = null;
            Type cursedContract = null;
            Type doctorContract = null;
            Type gildedContract = null;
            Type hagContract = null;
            Type hardmodeContract = null;
            Type iceContract = null;
            Type mimicContract = null;
            Type minotaurContract = null;
            Type mothContract = null;
            Type mothronContract = null;
            Type nymphContract = null;
            Type pigronContract = null;
            Type pinkyContract = null;
            Type pirateShipContract = null;
            Type recluseContract = null;
            Type runeContract = null;
            Type sandContract = null;
            Type timContract = null;
            Type wyvernContract = null;
            Type trackerCustomCurrency = null;
            Type tracker = null;
            Type weaponMaster = null;
            Type spiritualist = null;
            Type diverman = null;
            Type desertTraveler = null;
            Type cook = null;
            Type confusedZombie = null;
            Type cobbler = null;
            Type dangerContract = null;
            Type trackerUi = null;
            Type furnitureBed = null;
            Type thoriumPlayer = null;
            Type illusionistSpawn = null;
            Type thoriumItem = null;

            Assembly thoriumAssembly = CoreThoriumTranslation.ThoriumMod.GetType().Assembly;

            foreach (Type thoriumClass in thoriumAssembly.GetTypes())
            {
                switch (thoriumClass.Name)
                {
                    case "AquaticAbility":
                        aquaticAbility = thoriumClass;
                        break;
                    case "AttackSpeed":
                        attackSpeed = thoriumClass;
                        break;
                    case "CriticalStrikeChance":
                        criticalStrikeChance = thoriumClass;
                        break;
                    case "Damage":
                        damage = thoriumClass;
                        break;
                    case "DamageReduction":
                        damageReduction = thoriumClass;
                        break;
                    case "Defense":
                        defense = thoriumClass;
                        break;
                    case "EmpowermentProlongation":
                        empowermentProlongation = thoriumClass;
                        break;
                    case "FlatDamage":
                        flatDamage = thoriumClass;
                        break;
                    case "FlightTime":
                        flightTime = thoriumClass;
                        break;
                    case "InvincibilityFrames":
                        invincibilityFrames = thoriumClass;
                        break;
                    case "JumpHeight":
                        jumpHeight = thoriumClass;
                        break;
                    case "LifeRegeneration":
                        lifeRegeneration = thoriumClass;
                        break;
                    case "MovementSpeed":
                        movementSpeed = thoriumClass;
                        break;
                    case "ResourceConsumptionChance":
                        resourceConsumptionChance = thoriumClass;
                        break;
                    case "ResourceGrabRange":
                        resourceGrabRange = thoriumClass;
                        break;
                    case "ResourceMaximum":
                        resourceMaximum = thoriumClass;
                        break;
                    case "ResourceRegen":
                        resourceRegen = thoriumClass;
                        break;
                    case "WeakReferencesHandler":
                        weakReferencesHandler = thoriumClass;
                        break;
                    case "ThoriumMod":
                        thoriumMod = thoriumClass;
                        break;
                    case "AlmostContract":
                        almostContract = thoriumClass;
                        break;
                    case "BoneLeeContract":
                        boneLeeContract = thoriumClass;
                        break;
                    case "CursedContract":
                        cursedContract = thoriumClass;
                        break;
                    case "DoctorContract":
                        doctorContract = thoriumClass;
                        break;
                    case "GildedContract":
                        gildedContract = thoriumClass;
                        break;
                    case "HagContract":
                        hagContract = thoriumClass;
                        break;
                    case "HardmodeContract":
                        hardmodeContract = thoriumClass;
                        break;
                    case "IceContract":
                        iceContract = thoriumClass;
                        break;
                    case "MimicContract":
                        mimicContract = thoriumClass;
                        break;
                    case "MinotaurContract":
                        minotaurContract = thoriumClass;
                        break;
                    case "MothContract":
                        mothContract = thoriumClass;
                        break;
                    case "MothronContract":
                        mothronContract = thoriumClass;
                        break;
                    case "NymphContract":
                        nymphContract = thoriumClass;
                        break;
                    case "PigronContract":
                        pigronContract = thoriumClass;
                        break;
                    case "PinkyContract":
                        pinkyContract = thoriumClass;
                        break;
                    case "PirateShipContract":
                        pirateShipContract = thoriumClass;
                        break;
                    case "RecluseContract":
                        recluseContract = thoriumClass;
                        break;
                    case "RuneContract":
                        runeContract = thoriumClass;
                        break;
                    case "SandContract":
                        sandContract = thoriumClass;
                        break;
                    case "TimContract":
                        timContract = thoriumClass;
                        break;
                    case "WyvernContract":
                        wyvernContract = thoriumClass;
                        break;
                    case "TrackerCustomCurrency":
                        trackerCustomCurrency = thoriumClass;
                        break;
                    case "Tracker":
                        tracker = thoriumClass;
                        break;
                    case "WeaponMaster":
                        weaponMaster = thoriumClass;
                        break;
                    case "Spiritualist":
                        spiritualist = thoriumClass;
                        break;
                    case "Diverman":
                        diverman = thoriumClass;
                        break;
                    case "DesertTraveler":
                        desertTraveler = thoriumClass;
                        break;
                    case "Cook":
                        cook = thoriumClass;
                        break;
                    case "ConfusedZombie":
                        confusedZombie = thoriumClass;
                        break;
                    case "Cobbler":
                        cobbler = thoriumClass;
                        break;
                    case "DangerContract":
                        dangerContract = thoriumClass;
                        break;
                    case "TrackerUI":
                        trackerUi = thoriumClass;
                        break;
                    case "FurnitureBed":
                        furnitureBed = thoriumClass;
                        break;
                    case "ThoriumPlayer":
                        thoriumPlayer = thoriumClass;
                        break;
                    case "IllusionistSpawn":
                        illusionistSpawn = thoriumClass;
                        break;
                    case "ThoriumItem":
                        thoriumItem = thoriumClass;
                        break;
                }
            }
            
            _getCombatTextAquaticAbility = aquaticAbility?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextAquaticAbility != null) ModifyGetCombatTextAquaticAbility += Ru_ModifyGetCombatTextAquaticAbility;
            
            _getCombatTextAttackSpeed = attackSpeed?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextAttackSpeed != null) ModifyGetCombatTextAttackSpeed += Ru_ModifyGetCombatTextAttackSpeed;
            
            _getCombatTextCriticalStrikeChance = criticalStrikeChance?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextCriticalStrikeChance != null) ModifyGetCombatTextCriticalStrikeChance += Ru_ModifyGetCombatTextCriticalStrikeChance;
            
            _getCombatTextDamage = damage?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextDamage != null) ModifyGetCombatTextDamage += Ru_ModifyGetCombatTextDamage;
            
            _getCombatTextDamageReduction = damageReduction?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextDamageReduction != null) ModifyGetCombatTextDamageReduction += Ru_ModifyGetCombatTextDamageReduction;
            
            _getCombatTextDefense = defense?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextDefense != null) ModifyGetCombatTextDefense += Ru_ModifyGetCombatTextDefense;
            
            _getCombatTextEmpowermentProlongation = empowermentProlongation?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextEmpowermentProlongation != null) ModifyGetCombatTextEmpowermentProlongation += Ru_ModifyGetCombatTextEmpowermentProlongation;
            
            _getCombatTextFlatDamage = flatDamage?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextFlatDamage != null) ModifyGetCombatTextFlatDamage += Ru_ModifyGetCombatTextFlatDamage;
            
            _getCombatTextFlightTime = flightTime?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextFlightTime != null) ModifyGetCombatTextFlightTime += Ru_ModifyGetCombatTextFlightTime;
            
            _getCombatTextInvincibilityFrames = invincibilityFrames?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextInvincibilityFrames != null) ModifyGetCombatTextInvincibilityFrames += Ru_ModifyGetCombatTextInvincibilityFrames;
            
            _getCombatTextJumpHeight = jumpHeight?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextJumpHeight != null) ModifyGetCombatTextJumpHeight += Ru_ModifyGetCombatTextJumpHeight;
            
            _getCombatTextLifeRegeneration = lifeRegeneration?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextLifeRegeneration != null) ModifyGetCombatTextLifeRegeneration += Ru_ModifyGetCombatTextLifeRegeneration;
            
            _getCombatTextMovementSpeed = movementSpeed?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextMovementSpeed != null) ModifyGetCombatTextMovementSpeed += Ru_ModifyGetCombatTextMovementSpeed;
            
            _getCombatTextResourceConsumptionChance = resourceConsumptionChance?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextResourceConsumptionChance != null) ModifyGetCombatTextResourceConsumptionChance += Ru_ModifyGetCombatTextResourceConsumptionChance;
            
            _getCombatTextResourceGrabRange = resourceGrabRange?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextResourceGrabRange != null) ModifyGetCombatTextResourceGrabRange += Ru_ModifyGetCombatTextResourceGrabRange;
            
            _getCombatTextResourceMaximum = resourceMaximum?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextResourceMaximum != null) ModifyGetCombatTextResourceMaximum += Ru_ModifyGetCombatTextResourceMaximum;
            
            _getCombatTextResourceRegen = resourceRegen?.GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance);
            if(_getCombatTextResourceRegen != null) ModifyGetCombatTextResourceRegen += Ru_ModifyGetCombatTextResourceRegen;
            
            _doBossChecklistSupport = weakReferencesHandler?.GetMethod("DoBossChecklistSupport", BindingFlags.NonPublic | BindingFlags.Static);
            _doCensusModSupport = weakReferencesHandler?.GetMethod("DoCensusModSupport", BindingFlags.NonPublic | BindingFlags.Static);
            if(_doBossChecklistSupport != null) ModifyDoBossChecklistSupport += Ru_ModifyDoBossChecklistSupport;
            if(_doCensusModSupport != null) ModifyDoCensusModSupport += Ru_ModifyDoCensusModSupport;
            
            _displayDrShieldIcon = thoriumMod?.GetMethod("DisplayDRShieldIcon", BindingFlags.NonPublic | BindingFlags.Instance);
            _displayHealerIcon = thoriumMod?.GetMethod("DisplayHealerIcon", BindingFlags.NonPublic | BindingFlags.Instance);
            if(_displayDrShieldIcon != null) ModifyDisplayDrShieldIcon += Ru_ModifyDisplayDrShieldIcon;
            if(_displayHealerIcon != null) ModifyDisplayHealerIcon += Ru_ModifyDisplayHealerIcon;

            _titleAlmostContract = almostContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionAlmostContract = almostContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleAlmostContract != null) ModifyTitleAlmostContract += Ru_ModifyTitleAlmostContract;
            if(_descriptionAlmostContract != null) ModifyDescriptionAlmostContract += Ru_ModifyDescriptionAlmostContract;
            
            _titleBoneLeeContract = boneLeeContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionBoneLeeContract = boneLeeContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleBoneLeeContract != null) ModifyTitleBoneLeeContract += Ru_ModifyTitleBoneLeeContract;
            if(_descriptionBoneLeeContract != null) ModifyDescriptionBoneLeeContract += Ru_ModifyDescriptionBoneLeeContract;
            
            _titleCursedContract = cursedContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionCursedContract = cursedContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleCursedContract != null) ModifyTitleCursedContract += Ru_ModifyTitleCursedContract;
            if(_descriptionCursedContract != null) ModifyDescriptionCursedContract += Ru_ModifyDescriptionCursedContract;
            
            _titleDoctorContract = doctorContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionDoctorContract = doctorContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleDoctorContract != null) ModifyTitleDoctorContract += Ru_ModifyTitleDoctorContract;
            if(_descriptionDoctorContract != null) ModifyDescriptionDoctorContract += Ru_ModifyDescriptionDoctorContract;
            
            _titleGildedContract = gildedContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionGildedContract = gildedContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleGildedContract != null) ModifyTitleGildedContract += Ru_ModifyTitleGildedContract;
            if(_descriptionGildedContract != null) ModifyDescriptionGildedContract += Ru_ModifyDescriptionGildedContract;
            
            _titleHagContract = hagContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionHagContract = hagContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleHagContract != null) ModifyTitleHagContract += Ru_ModifyTitleHagContract;
            if(_descriptionHagContract != null) ModifyDescriptionHagContract += Ru_ModifyDescriptionHagContract;
            
            _titleHardmodeContract = hardmodeContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionHardmodeContract = hardmodeContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleHardmodeContract != null) ModifyTitleHardmodeContract += Ru_ModifyTitleHardmodeContract;
            if(_descriptionHardmodeContract != null) ModifyDescriptionHardmodeContract += Ru_ModifyDescriptionHardmodeContract;
            
            _titleIceContract = iceContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionIceContract = iceContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleIceContract != null) ModifyTitleIceContract += Ru_ModifyTitleIceContract;
            if(_descriptionIceContract != null) ModifyDescriptionIceContract += Ru_ModifyDescriptionIceContract;
            
            _titleMimicContract = mimicContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionMimicContract = mimicContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleMimicContract != null) ModifyTitleMimicContract += Ru_ModifyTitleMimicContract;
            if(_descriptionMimicContract != null) ModifyDescriptionMimicContract += Ru_ModifyDescriptionMimicContract;
            
            _titleMinotaurContract = minotaurContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionMinotaurContract = minotaurContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleMinotaurContract != null) ModifyTitleMinotaurContract += Ru_ModifyTitleMinotaurContract;
            if(_descriptionMinotaurContract != null) ModifyDescriptionMinotaurContract += Ru_ModifyDescriptionMinotaurContract;
            
            _titleMothContract = mothContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionMothContract = mothContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleMothContract != null) ModifyTitleMothContract += Ru_ModifyTitleMothContract;
            if(_descriptionMothContract != null) ModifyDescriptionMothContract += Ru_ModifyDescriptionMothContract;
            
            _titleMothronContract = mothronContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionMothronContract = mothronContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleMothronContract != null) ModifyTitleMothronContract += Ru_ModifyTitleMothronContract;
            if(_descriptionMothronContract != null) ModifyDescriptionMothronContract += Ru_ModifyDescriptionMothronContract;
            
            _titleNymphContract = nymphContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionNymphContract = nymphContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleNymphContract != null) ModifyTitleNymphContract += Ru_ModifyTitleNymphContract;
            if(_descriptionNymphContract != null) ModifyDescriptionNymphContract += Ru_ModifyDescriptionNymphContract;
            
            _titlePigronContract = pigronContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionPigronContract = pigronContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titlePigronContract != null) ModifyTitlePigronContract += Ru_ModifyTitlePigronContract;
            if(_descriptionPigronContract != null) ModifyDescriptionPigronContract += Ru_ModifyDescriptionPigronContract;
            
            _titlePinkyContract = pinkyContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionPinkyContract = pinkyContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titlePinkyContract != null) ModifyTitlePinkyContract += Ru_ModifyTitlePinkyContract;
            if(_descriptionPinkyContract != null) ModifyDescriptionPinkyContract += Ru_ModifyDescriptionPinkyContract;
            
            _titlePirateShipContract = pirateShipContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionPirateShipContract = pirateShipContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titlePirateShipContract != null) ModifyTitlePirateShipContract += Ru_ModifyTitlePirateShipContract;
            if(_descriptionPirateShipContract != null) ModifyDescriptionPirateShipContract += Ru_ModifyDescriptionPirateShipContract;
            
            _titleRecluseContract = recluseContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionRecluseContract = recluseContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleRecluseContract != null) ModifyTitleRecluseContract += Ru_ModifyTitleRecluseContract;
            if(_descriptionRecluseContract != null) ModifyDescriptionRecluseContract += Ru_ModifyDescriptionRecluseContract;
            
            _titleRuneContract = runeContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionRuneContract = runeContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleRuneContract != null) ModifyTitleRuneContract += Ru_ModifyTitleRuneContract;
            if(_descriptionRuneContract != null) ModifyDescriptionRuneContract += Ru_ModifyDescriptionRuneContract;
            
            _titleSandContract = sandContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionSandContract = sandContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleSandContract != null) ModifyTitleSandContract += Ru_ModifyTitleSandContract;
            if(_descriptionSandContract != null) ModifyDescriptionSandContract += Ru_ModifyDescriptionSandContract;
            
            _titleTimContract = timContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionTimContract = timContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleTimContract != null) ModifyTitleTimContract += Ru_ModifyTitleTimContract;
            if(_descriptionTimContract != null) ModifyDescriptionTimContract += Ru_ModifyDescriptionTimContract;
            
            _titleWyvernContract = wyvernContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionWyvernContract = wyvernContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleWyvernContract != null) ModifyTitleWyvernContract += Ru_ModifyTitleWyvernContract;
            if(_descriptionWyvernContract != null) ModifyDescriptionWyvernContract += Ru_ModifyDescriptionWyvernContract;
            
            _getPriceText = trackerCustomCurrency?.GetMethod("GetPriceText", BindingFlags.Public | BindingFlags.Instance);
            if(_getPriceText != null) ModifyGetPriceText += Ru_ModifyGetPriceText;
            
            _setChatButtonsTracker = tracker?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            if(_setChatButtonsTracker != null) ModifySetChatButtonsTracker += Ru_ModifySetChatButtonsTracker;
            
            _setChatButtonsWeaponMaster = weaponMaster?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            if(_setChatButtonsWeaponMaster != null) ModifySetChatButtonsWeaponMaster += Ru_ModifySetChatButtonsWeaponMaster;
            
            _setChatButtonsSpiritualist = spiritualist?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            if(_setChatButtonsSpiritualist != null) ModifySetChatButtonsSpiritualist += Ru_ModifySetChatButtonsSpiritualist;
            
            _setChatButtonsDiverman = diverman?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            if(_setChatButtonsDiverman != null) ModifySetChatButtonsDiverman += Ru_ModifySetChatButtonsDiverman;
            
            _setChatButtonsDesertTraveler = desertTraveler?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            if(_setChatButtonsDesertTraveler != null) ModifySetChatButtonsDesertTraveler += Ru_ModifySetChatButtonsDesertTraveler;
            
            _setChatButtonsCook = cook?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            if(_setChatButtonsCook != null) ModifySetChatButtonsCook += Ru_ModifySetChatButtonsCook;
            
            _setChatButtonsConfusedZombie = confusedZombie?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            if(_setChatButtonsConfusedZombie != null) ModifySetChatButtonsConfusedZombie += Ru_ModifySetChatButtonsConfusedZombie;
            
            _setChatButtonsCobbler = cobbler?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            if(_setChatButtonsCobbler != null) ModifySetChatButtonsCobbler += Ru_ModifySetChatButtonsCobbler;
            
            _titleDangerContract = dangerContract?.GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance);
            _descriptionDangerContract = dangerContract?.GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance);
            if(_titleDangerContract != null) ModifyTitleDangerContract += Ru_ModifyTitleDangerContract;
            if(_descriptionDangerContract != null) ModifyDescriptionDangerContract += Ru_ModifyModifyDescriptionDangerContract;
            
            _onInitialize = trackerUi?.GetMethod("OnInitialize", BindingFlags.Public | BindingFlags.Instance);
            if(_onInitialize != null) ModifyOnInitialize += Ru_ModifyOnInitialize;
            
            _newRightClick = furnitureBed?.GetMethod("NewRightClick", BindingFlags.Public | BindingFlags.Instance);
            if(_newRightClick != null) ModifyNewRightClick += Ru_ModifyNewRightClick;
            
            _postUpdateEquips = thoriumPlayer?.GetMethod("PostUpdateEquips", BindingFlags.Public | BindingFlags.Instance);
            _preKill = thoriumPlayer?.GetMethod("PreKill", BindingFlags.Public | BindingFlags.Instance);
            if(_postUpdateEquips != null) ModifyPostUpdateEquips += Ru_ModifyPostUpdateEquips;
            if(_preKill != null) ModifyPreKill += Ru_ModifyPreKill;
            
            _setChatButtonsIllusionistSpawn = illusionistSpawn?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            if(_setChatButtonsIllusionistSpawn != null) ModifySetChatButtonsIllusionistSpawn += Ru_ModifySetChatButtonsIllusionistSpawn;
            
            _usesManaThoriumItem = thoriumItem?.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            if(_usesManaThoriumItem != null) ModifyUsesManaThoriumItem += Ru_ModifyUsesManaThoriumItem;
        }

        private static void UnloadIL()
        {
            if(_getCombatTextAquaticAbility != null) ModifyGetCombatTextAquaticAbility -= Ru_ModifyGetCombatTextAquaticAbility;
            if(_getCombatTextAttackSpeed != null) ModifyGetCombatTextAttackSpeed -= Ru_ModifyGetCombatTextAttackSpeed;
            if(_getCombatTextCriticalStrikeChance != null) ModifyGetCombatTextCriticalStrikeChance -= Ru_ModifyGetCombatTextCriticalStrikeChance;
            if(_getCombatTextDamage != null) ModifyGetCombatTextDamage -= Ru_ModifyGetCombatTextDamage;
            if(_getCombatTextDamageReduction != null) ModifyGetCombatTextDamageReduction -= Ru_ModifyGetCombatTextDamageReduction;
            if(_getCombatTextDefense != null) ModifyGetCombatTextDefense -= Ru_ModifyGetCombatTextDefense;
            if(_getCombatTextEmpowermentProlongation != null) ModifyGetCombatTextEmpowermentProlongation -= Ru_ModifyGetCombatTextEmpowermentProlongation;
            if(_getCombatTextFlatDamage != null) ModifyGetCombatTextFlatDamage -= Ru_ModifyGetCombatTextFlatDamage;
            if(_getCombatTextFlightTime != null) ModifyGetCombatTextFlightTime -= Ru_ModifyGetCombatTextFlightTime;
            if(_getCombatTextInvincibilityFrames != null) ModifyGetCombatTextInvincibilityFrames -= Ru_ModifyGetCombatTextInvincibilityFrames;
            if(_getCombatTextJumpHeight != null) ModifyGetCombatTextJumpHeight -= Ru_ModifyGetCombatTextJumpHeight;
            if(_getCombatTextLifeRegeneration != null) ModifyGetCombatTextLifeRegeneration -= Ru_ModifyGetCombatTextLifeRegeneration;
            if(_getCombatTextMovementSpeed != null) ModifyGetCombatTextMovementSpeed -= Ru_ModifyGetCombatTextMovementSpeed;
            if(_getCombatTextResourceConsumptionChance != null) ModifyGetCombatTextResourceConsumptionChance -= Ru_ModifyGetCombatTextResourceConsumptionChance;
            if(_getCombatTextResourceGrabRange != null) ModifyGetCombatTextResourceGrabRange -= Ru_ModifyGetCombatTextResourceGrabRange;
            if(_getCombatTextResourceMaximum != null) ModifyGetCombatTextResourceMaximum -= Ru_ModifyGetCombatTextResourceMaximum;
            if(_getCombatTextResourceRegen != null) ModifyGetCombatTextResourceRegen -= Ru_ModifyGetCombatTextResourceRegen;
            if(_doBossChecklistSupport != null) ModifyDoBossChecklistSupport -= Ru_ModifyDoBossChecklistSupport;
            if(_doCensusModSupport != null) ModifyDoCensusModSupport -= Ru_ModifyDoCensusModSupport;
            if(_displayDrShieldIcon != null) ModifyDisplayDrShieldIcon -= Ru_ModifyDisplayDrShieldIcon;
            if(_displayHealerIcon != null) ModifyDisplayHealerIcon -= Ru_ModifyDisplayHealerIcon;
            if(_titleAlmostContract != null) ModifyTitleAlmostContract -= Ru_ModifyTitleAlmostContract;
            if(_descriptionAlmostContract != null) ModifyDescriptionAlmostContract -= Ru_ModifyDescriptionAlmostContract;
            if(_titleBoneLeeContract != null) ModifyTitleBoneLeeContract -= Ru_ModifyTitleBoneLeeContract;
            if(_descriptionBoneLeeContract != null) ModifyDescriptionBoneLeeContract -= Ru_ModifyDescriptionBoneLeeContract;
            if(_titleCursedContract != null) ModifyTitleCursedContract -= Ru_ModifyTitleCursedContract;
            if(_descriptionCursedContract != null) ModifyDescriptionCursedContract -= Ru_ModifyDescriptionCursedContract;
            if(_titleDoctorContract != null) ModifyTitleDoctorContract -= Ru_ModifyTitleDoctorContract;
            if(_descriptionDoctorContract != null) ModifyDescriptionDoctorContract -= Ru_ModifyDescriptionDoctorContract;
            if(_titleGildedContract != null) ModifyTitleGildedContract -= Ru_ModifyTitleGildedContract;
            if(_descriptionGildedContract != null) ModifyDescriptionGildedContract -= Ru_ModifyDescriptionGildedContract;
            if(_titleHagContract != null) ModifyTitleHagContract -= Ru_ModifyTitleHagContract;
            if(_descriptionHagContract != null) ModifyDescriptionHagContract -= Ru_ModifyDescriptionHagContract;
            if(_titleHardmodeContract != null) ModifyTitleHardmodeContract -= Ru_ModifyTitleHardmodeContract;
            if(_descriptionHardmodeContract != null) ModifyDescriptionHardmodeContract -= Ru_ModifyDescriptionHardmodeContract;
            if(_titleIceContract != null) ModifyTitleIceContract -= Ru_ModifyTitleIceContract;
            if(_descriptionIceContract != null) ModifyDescriptionIceContract -= Ru_ModifyDescriptionIceContract;
            if(_titleMimicContract != null) ModifyTitleMimicContract -= Ru_ModifyTitleMimicContract;
            if(_descriptionMimicContract != null) ModifyDescriptionMimicContract -= Ru_ModifyDescriptionMimicContract;
            if(_titleMinotaurContract != null) ModifyTitleMinotaurContract -= Ru_ModifyTitleMinotaurContract;
            if(_descriptionMinotaurContract != null) ModifyDescriptionMinotaurContract -= Ru_ModifyDescriptionMinotaurContract;
            if(_titleMothContract != null) ModifyTitleMothContract -= Ru_ModifyTitleMothContract;
            if(_descriptionMothContract != null) ModifyDescriptionMothContract -= Ru_ModifyDescriptionMothContract;
            if(_titleMothronContract != null) ModifyTitleMothronContract -= Ru_ModifyTitleMothronContract;
            if(_descriptionMothronContract != null) ModifyDescriptionMothronContract -= Ru_ModifyDescriptionMothronContract;
            if(_titleNymphContract != null) ModifyTitleNymphContract -= Ru_ModifyTitleNymphContract;
            if(_descriptionNymphContract != null) ModifyDescriptionNymphContract -= Ru_ModifyDescriptionNymphContract;
            if(_titlePigronContract != null) ModifyTitlePigronContract -= Ru_ModifyTitlePigronContract;
            if(_descriptionPigronContract != null) ModifyDescriptionPigronContract -= Ru_ModifyDescriptionPigronContract;
            if(_titlePinkyContract != null) ModifyTitlePinkyContract -= Ru_ModifyTitlePinkyContract;
            if(_descriptionPinkyContract != null) ModifyDescriptionPinkyContract -= Ru_ModifyDescriptionPinkyContract;
            if(_titlePirateShipContract != null) ModifyTitlePirateShipContract -= Ru_ModifyTitlePirateShipContract;
            if(_descriptionPirateShipContract != null) ModifyDescriptionPirateShipContract -= Ru_ModifyDescriptionPirateShipContract;
            if(_titleRecluseContract != null) ModifyTitleRecluseContract -= Ru_ModifyTitleRecluseContract;
            if(_descriptionRecluseContract != null) ModifyDescriptionRecluseContract -= Ru_ModifyDescriptionRecluseContract;
            if(_titleRuneContract != null) ModifyTitleRuneContract -= Ru_ModifyTitleRuneContract;
            if(_descriptionRuneContract != null) ModifyDescriptionRuneContract -= Ru_ModifyDescriptionRuneContract;
            if(_titleSandContract != null) ModifyTitleSandContract -= Ru_ModifyTitleSandContract;
            if(_descriptionSandContract != null) ModifyDescriptionSandContract -= Ru_ModifyDescriptionSandContract;
            if(_titleTimContract != null) ModifyTitleTimContract -= Ru_ModifyTitleTimContract;
            if(_descriptionTimContract != null) ModifyDescriptionTimContract -= Ru_ModifyDescriptionTimContract;
            if(_titleWyvernContract != null) ModifyTitleWyvernContract -= Ru_ModifyTitleWyvernContract;
            if(_descriptionWyvernContract != null) ModifyDescriptionWyvernContract -= Ru_ModifyDescriptionWyvernContract;
            if(_getPriceText != null) ModifyGetPriceText -= Ru_ModifyGetPriceText;
            if(_setChatButtonsTracker != null) ModifySetChatButtonsTracker -= Ru_ModifySetChatButtonsTracker;
            if(_setChatButtonsWeaponMaster != null) ModifySetChatButtonsWeaponMaster -= Ru_ModifySetChatButtonsWeaponMaster;
            if(_setChatButtonsSpiritualist != null) ModifySetChatButtonsSpiritualist -= Ru_ModifySetChatButtonsSpiritualist;
            if(_setChatButtonsDiverman != null) ModifySetChatButtonsDiverman -= Ru_ModifySetChatButtonsDiverman;
            if(_setChatButtonsDesertTraveler != null) ModifySetChatButtonsDesertTraveler -= Ru_ModifySetChatButtonsDesertTraveler;
            if(_setChatButtonsCook != null) ModifySetChatButtonsCook += Ru_ModifySetChatButtonsCook;
            if(_setChatButtonsConfusedZombie != null) ModifySetChatButtonsConfusedZombie -= Ru_ModifySetChatButtonsConfusedZombie;
            if(_setChatButtonsCobbler != null) ModifySetChatButtonsCobbler -= Ru_ModifySetChatButtonsCobbler;
            if(_titleDangerContract != null) ModifyTitleDangerContract -= Ru_ModifyTitleDangerContract;
            if(_descriptionDangerContract != null) ModifyDescriptionDangerContract -= Ru_ModifyModifyDescriptionDangerContract;
            if(_onInitialize != null) ModifyOnInitialize -= Ru_ModifyOnInitialize;
            if(_newRightClick != null) ModifyNewRightClick -= Ru_ModifyNewRightClick;
            if(_postUpdateEquips != null) ModifyPostUpdateEquips += Ru_ModifyPostUpdateEquips;
            if(_preKill != null) ModifyPreKill += Ru_ModifyPreKill;
            if(_setChatButtonsIllusionistSpawn != null) ModifySetChatButtonsIllusionistSpawn -= Ru_ModifySetChatButtonsIllusionistSpawn;
            if(_usesManaThoriumItem != null) ModifyUsesManaThoriumItem -= Ru_ModifyUsesManaThoriumItem;
        }

        #region IL Editing

        private static void Ru_ModifyGetCombatTextAquaticAbility(ILContext il) => Translation.ILTranslate(il, "% underwater breath & speed", Translation.EncodeToUtf16("% подводного дыхания и скорости"));
        
        private static void Ru_ModifyGetCombatTextAttackSpeed(ILContext il) => Translation.ILTranslate(il, "% attack speed", Translation.EncodeToUtf16("% скорости атаки"));
        
        private static void Ru_ModifyGetCombatTextCriticalStrikeChance(ILContext il) => Translation.ILTranslate(il, "% critical strike chance", Translation.EncodeToUtf16("% шанс критического удара"));
        
        private static void Ru_ModifyGetCombatTextDamage(ILContext il) => Translation.ILTranslate(il, "% damage", Translation.EncodeToUtf16("% урона"));
        
        private static void Ru_ModifyGetCombatTextDamageReduction(ILContext il) => Translation.ILTranslate(il, "% damage reduction", Translation.EncodeToUtf16("% сопротивление урону"));
        
        private static void Ru_ModifyGetCombatTextDefense(ILContext il) => Translation.ILTranslate(il, " defense", Translation.EncodeToUtf16(" защиты"));

        private static void Ru_ModifyGetCombatTextEmpowermentProlongation(ILContext il)
        {
            Translation.ILTranslate(il, " second", Translation.EncodeToUtf16(" секунда"));
            Translation.ILTranslate(il, " seconds", Translation.EncodeToUtf16(" секунды"));
        }
        
        private static void Ru_ModifyGetCombatTextFlatDamage(ILContext il) => Translation.ILTranslate(il, " flat damage", Translation.EncodeToUtf16(" фиксированого урона"));
        
        private static void Ru_ModifyGetCombatTextFlightTime(ILContext il) => Translation.ILTranslate(il, "% flight time", Translation.EncodeToUtf16("% времени полёта"));
        
        private static void Ru_ModifyGetCombatTextInvincibilityFrames(ILContext il) => Translation.ILTranslate(il, "  sec. of after hit invincibility", Translation.EncodeToUtf16(" сек. неуязвимости"));
        
        private static void Ru_ModifyGetCombatTextJumpHeight(ILContext il) => Translation.ILTranslate(il, " block of jump height", Translation.EncodeToUtf16(" блока высоты прыжка"));
        
        private static void Ru_ModifyGetCombatTextLifeRegeneration(ILContext il) => Translation.ILTranslate(il, " life/sec", Translation.EncodeToUtf16(" здоровья/сек"));
        
        private static void Ru_ModifyGetCombatTextMovementSpeed(ILContext il) => Translation.ILTranslate(il, "% base and bonus movement speed", Translation.EncodeToUtf16("% базовой и дополнительной скорости передвижения"));
        
        private static void Ru_ModifyGetCombatTextResourceConsumptionChance(ILContext il) => Translation.ILTranslate(il, "% chance to not consume resource", Translation.EncodeToUtf16("% шанс не использовать ресурс"));
        
        private static void Ru_ModifyGetCombatTextResourceGrabRange(ILContext il) => Translation.ILTranslate(il, " resource item grab range", Translation.EncodeToUtf16(" дальность захвата предметов"));
        
        private static void Ru_ModifyGetCombatTextResourceMaximum(ILContext il) => Translation.ILTranslate(il, "% maximum resource", Translation.EncodeToUtf16(" максимума ресурсов"));
        
        private static void Ru_ModifyGetCombatTextResourceRegen(ILContext il) => Translation.ILTranslate(il, "% resource regeneration", Translation.EncodeToUtf16(" регенерации ресурсов"));
        
        private static void Ru_ModifyDoBossChecklistSupport(ILContext il)
        {
            Translation.ILTranslate(il, "The Grand Thunder Bird", Translation.EncodeToUtf16("Великая гром-птица"));
            Translation.ILTranslate(il, "Use a [i:", Translation.EncodeToUtf16("Используйте [i:"));
            Translation.ILTranslate(il, "] with [i:", Translation.EncodeToUtf16("] с [i:"));
            Translation.ILTranslate(il, "] during the day in the Desert.", Translation.EncodeToUtf16("] днём в пустыне."));
            Translation.ILTranslate(il, "Patch Werk", Translation.EncodeToUtf16("Лоскутик"));
            Translation.ILTranslate(il, "Randomly appears during the Blood Moon. Start the Blood Moon with a [i:", Translation.EncodeToUtf16("Случайно появляется во время кровавой луны. Начните кровавую луну используя [i:"));
            Translation.ILTranslate(il, "The Queen Jellyfish", Translation.EncodeToUtf16("Королева медуз"));
            Translation.ILTranslate(il, "Use a [i:", Translation.EncodeToUtf16("Используйте [i:"), 2);
            Translation.ILTranslate(il, "] during the day at the Ocean.", Translation.EncodeToUtf16("] днём в океане."));
            Translation.ILTranslate(il, "Viscount", Translation.EncodeToUtf16("Виконт"));
            Translation.ILTranslate(il, "Use 5 [i:", Translation.EncodeToUtf16("Используйте 5 [i:"));
            Translation.ILTranslate(il, "] at an underground Blood Chamber. Use a [i:", Translation.EncodeToUtf16("] в поздемной кровавой камере. Используйте [i:"));
            Translation.ILTranslate(il, "] to track down the Blood Chamber.", Translation.EncodeToUtf16("] чтобы найти кровавую камеру."));
            Translation.ILTranslate(il, "Corpse Bloom", Translation.EncodeToUtf16("Трупоцвет"));
            Translation.ILTranslate(il, "Randomly appears in the post-Skeletron underground jungle.", Translation.EncodeToUtf16("Случайно появляется в подземных джунглях после убийства Скелетрона."));
            Translation.ILTranslate(il, "Illusionist", Translation.EncodeToUtf16("Иллюзионист"));
            Translation.ILTranslate(il, "Randomly appears in the Dungeon.", Translation.EncodeToUtf16("Случайно появляется в темнице."));
            Translation.ILTranslate(il, "Granite Energy Storm", Translation.EncodeToUtf16("Гранитный энергетический шторм"));
            Translation.ILTranslate(il, "Use a [i:", Translation.EncodeToUtf16("Используйте [i:"), 3);
            Translation.ILTranslate(il, "] deep underground within a Granite Enclosure or find and defeat an Unstable Energy Anomaly.", Translation.EncodeToUtf16("] глубоко под землёй в гранитных пещерах или найдите и одолейте Нестабильную энергетическую аномалию"));
            Translation.ILTranslate(il, "Buried Champion", Translation.EncodeToUtf16("Погребённый чемпион"));
            Translation.ILTranslate(il, "Use a [i:", Translation.EncodeToUtf16("Используйте [i:"), 4);
            Translation.ILTranslate(il, "] deep underground within a Marble Enclosure or find and defeat a Bizarre Rock Formation.", Translation.EncodeToUtf16("] глубоко под землёй в мраморных пещерах или найдите и одолейте Причудливую горную породу"));
            Translation.ILTranslate(il, "Star Scouter", Translation.EncodeToUtf16("Звёздный разведчик"));
            Translation.ILTranslate(il, "Use a [i:", Translation.EncodeToUtf16("Используйте [i:"), 5);
            Translation.ILTranslate(il, "] high in the sky.", Translation.EncodeToUtf16("] высоко в небе."));
            Translation.ILTranslate(il, "Borean Strider", Translation.EncodeToUtf16("Арктический страйдер"));
            Translation.ILTranslate(il, "Randomly appears during a Blizzard or summoned with a [i:", Translation.EncodeToUtf16("Случайно появляется во время метели или вызывается [i:"));
            Translation.ILTranslate(il, "Coznix, the Fallen Beholder", Translation.EncodeToUtf16("Козникс, падший Созерцатель"));
            Translation.ILTranslate(il, "Use a [i:", Translation.EncodeToUtf16("Используйте [i:"), 6);
            Translation.ILTranslate(il, "] within the Underworld.", Translation.EncodeToUtf16("] в аду."));
            Translation.ILTranslate(il, "The Lich", Translation.EncodeToUtf16("Лич"));
            Translation.ILTranslate(il, "Use a [i:", Translation.EncodeToUtf16("Используйте [i:"), 7);
            Translation.ILTranslate(il, "] during the Night.", Translation.EncodeToUtf16("] ночью."));
            Translation.ILTranslate(il, "Abyssion, the Forgotten One", Translation.EncodeToUtf16("Абиссион, Забытый"));
            Translation.ILTranslate(il, "Pick up 3 [i:", Translation.EncodeToUtf16("Поднимите 3 [i:"));
            Translation.ILTranslate(il, "], which are dropped by Aquatic Hallucinations in the Aquatic Depths.", Translation.EncodeToUtf16("], которые падают с Морской иллюзии в акватических глубинах."));
            Translation.ILTranslate(il, "The Primordials", Translation.EncodeToUtf16("Вечные"));
            Translation.ILTranslate(il, "Use a [i:", Translation.EncodeToUtf16("Используйте [i:"), 8);
            Translation.ILTranslate(il, "] and prepare for the worst...", Translation.EncodeToUtf16("] и готовьтесь к худшему..."));
        }
        
        private static void Ru_ModifyDoCensusModSupport(ILContext il)
        {
            Translation.ILTranslate(il, "Have any kind of basic mushroom in your inventory ([i/s1:5][i/s1:183][i/s1:60][i/s1:2887])", Translation.EncodeToUtf16("Положите в инвентарь любой из этих грибов ([i/s1:5][i/s1:183][i/s1:60][i/s1:2887])"));
            Translation.ILTranslate(il, "Have any kind of non-cobbler boot accessory equipped or in your inventory ([i/s1:285][i/s1:54][i/s1:128][i/s1:863] etc.)", Translation.EncodeToUtf16("Экипируйте или положите в инвентарь любой из этих предметов ([i/s1:285][i/s1:54][i/s1:128][i/s1:863] и т.д.)"));
            Translation.ILTranslate(il, "Defeat the [c/4dffb8:Grand Thunder Bird]", Translation.EncodeToUtf16("Одолейте [c/4dffb8:Великую гром-птицу]"));
            Translation.ILTranslate(il, "Defeat [c/4dffb8:Patchwerk] during a Blood Moon", Translation.EncodeToUtf16("Одолейте [c/4dffb8:Лоскутика] в кровавую луну"));
            Translation.ILTranslate(il, "Defeat the Eye of Cthulhu", Translation.EncodeToUtf16("Одолейте Глаз Ктулху"));
            Translation.ILTranslate(il, "Defeat the Eye of Cthulhu", Translation.EncodeToUtf16("Одолейте Глаз Ктулху"), 2);
            Translation.ILTranslate(il, "Defeat the [c/4dffb8:Queen Jellyfish]", Translation.EncodeToUtf16("Одолейте [c/4dffb8:Королеву медуз]"));
            Translation.ILTranslate(il, "Defeat [c/4dffb8:Corpse Bloom] in the post-Skeletron Jungle", Translation.EncodeToUtf16("Одолейте [c/4dffb8:Трупоцвет] в джунглях после убийства Скелетрона."));
            Translation.ILTranslate(il, "Defeat the [c/4dffb8:Buried Champion]", Translation.EncodeToUtf16("Одолейте [c/4dffb8:Погребённого чемпиона]"));
            Translation.ILTranslate(il, "Defeat the [c/4dffb8:Fallen Beholder]", Translation.EncodeToUtf16("Одолейте [c/4dffb8:Падшего Созерцателя]"));
        }
        
        private static void Ru_ModifyDisplayDrShieldIcon(ILContext il)
        {
            Translation.ILTranslate(il, "Total: ", Translation.EncodeToUtf16("Всего: "));
            Translation.ILTranslate(il, "% Damage Reduction\nVanilla: ", Translation.EncodeToUtf16("% сопротивления урону\nВанилла: "));
            Translation.ILTranslate(il, "%\nThorium: ", Translation.EncodeToUtf16("%\nТориум: "));
            Translation.ILTranslate(il, "% Before Cap)", Translation.EncodeToUtf16("% до предела"));
        }

        private static void Ru_ModifyTitleAlmostContract(ILContext il) => Translation.ILTranslate(il, "To Be Continued...", Translation.EncodeToUtf16("Продолжение следует..."));
        
        private static void Ru_ModifyDescriptionAlmostContract(ILContext il) => Translation.ILTranslate(il, "Complete all other contracts to continue...", Translation.EncodeToUtf16("Сначала завершите все оставшиеся контракты..."));
        
        private static void Ru_ModifyTitleBoneLeeContract(ILContext il) => Translation.ILTranslate(il, "Tracker's End", Translation.EncodeToUtf16("Конец Охотника"));

        private static void Ru_ModifyDescriptionBoneLeeContract(ILContext il)
        {
            Translation.ILTranslate(il, "I've got a personal contract for you, kid. I don't ask this of you lightly, so please hear me out. Years ago, me and my partner, Lee, would take on the world together. We were an unstoppable duo, but made the grave error of underestimating a particularly difficult contract. In a desperate attempt to save me, he was struck down within the Dungeon halls where he surely rots. I've never forgiven myself for what happened... Please, go into the Dungeon and put his tortured soul to rest.", Translation.EncodeToUtf16("Парень, у меня есть для тебя особый контракт. Ты должен взяться за это всерьёз, так что выслушай меня. Много лет назад, я и мой друг Ли исследовали мир вместе. Мы были неудержимы, но допустили смертельную ошибку - недооценили один особенно сложный контракт. В отчаянной попытке спасти меня он был скинут в залы Темницы, где он, скорее всего, гниёт до сих пор. Я никогда не прощу себя за это... Пожалуйста, отправься в Темницу и дай его измученной душе отдых."));
            Translation.ILTranslate(il, "You've done me a favor I could never repay in a thousand lifetimes. What I would give to apologize to Lee face to face... I'm confident, that at this point, you've surpassed any strength we thought we possessed. It's sobering to be humbled by an upstart like you, kid. As a reward, I've got a collection of weapons Lee would often use. I'm sure he would be honored if you wielded them in battle. Take care out there!", Translation.EncodeToUtf16("Ты окозал мне услугу, которую я не смогу отплатить и за тысячу жизней. Я бы всё отдал, что бы попрощаться с Ли лицом к лицу... Я уверен, что к этому моменту ты уже превзошёл нас в силе. Это отрезвляюще - быть оскорбленным таким выскочкой, как ты. В награду, у меня есть коллекция оружия, которое Ли часто использовал. Уверен, он был бы почтён, если бы ты орудовал ими в бою. Береги себя!"));
        }
        
        private static void Ru_ModifyTitleCursedContract(ILContext il) => Translation.ILTranslate(il, "Enchanted Engagement", Translation.EncodeToUtf16("Зачарованное вовлечение"));
        
        private static void Ru_ModifyDescriptionCursedContract(ILContext il) => Translation.ILTranslate(il, "I'm sure you've seen that unregulated spirit magic can lead to a lot of things, such as possessed weapons and armor. That prospect alone is terrifying, but when powerful artifacts are possessed, things can get ugly... Keep your eyes peeled for aggressive Enchanted weapons deep underground.", Translation.EncodeToUtf16("Я уверен ты наблюдал, что неконтролируемая духовная магия может привести к разным последствиям, например, к одержимости брони или оружия. Сама перспектива этого уже ужасающая, но когда мощные артефакты становятся одержимыми, дела могут стать ещё хуже... Смотри в оба за наличием агрессивных заколдованных орудий в подземельях."));
        
        private static void Ru_ModifyTitleDoctorContract(ILContext il) => Translation.ILTranslate(il, "Arc of the Lost Raider", Translation.EncodeToUtf16("Ковчег заплутавшего Расхитителя"));
        
        private static void Ru_ModifyDescriptionDoctorContract(ILContext il) => Translation.ILTranslate(il, "Many adventurers have braved the intense foliage of the jungle, but even fewer return. I sent a friend of mine, Doctor Bones, out on a mission to the jungle quite a while ago, but he hasn't returned... Could you go check out the jungle's surface at night and see if you can find any signs of him?", Translation.EncodeToUtf16("Многие путешественники смогли пройти сквозь густые заросли джунглей, но лишь немногие вернулись. Я послал своего друга, Доктора Бонса, на миссию в джунгли довольно давно, но он так и не вернулся... Не мог бы ты посетить и обследовать поверхность джунглей ночью и найти хоть какие-то его следы?"));
        
        private static void Ru_ModifyTitleGildedContract(ILContext il) => Translation.ILTranslate(il, "Pay Day", Translation.EncodeToUtf16("Час расплаты"));
        
        private static void Ru_ModifyDescriptionGildedContract(ILContext il) => Translation.ILTranslate(il, "Radiant beasts have been spotted prowling underground Terraria, illuminating a path of ruin. The Gilded Bat, Gilded Lycan and Gilded Slime light up their surrounding area and pack quite a punch. It would be best if their numbers dwindled, even just a little...", Translation.EncodeToUtf16("Недавно в подземельях Террарии были замечены лучезарные твари, освещающие свой путь разрушений. Позолоченная летучая мышь, слизень и ликан подсвечивают окружающую местность и бьют довольно сильно. Будет намного лучше, если их число упадёт, даже немного."));
        
        private static void Ru_ModifyTitleHagContract(ILContext il) => Translation.ILTranslate(il, "Haggard Hagglers", Translation.EncodeToUtf16("Измодждённый торгаш"));
        
        private static void Ru_ModifyDescriptionHagContract(ILContext il) => Translation.ILTranslate(il, "Many try to take shortcuts in their quest for power, often calling upon the elements for their boon. But while the elements can provide what they seek, it comes with a hefty price. There exists beings known as Hags that roam the world looking to steal back their traded youth. The Underworld, Jungle, Ocean, and Sky are the most likely spots to find one. Do us a favor and take one out.", Translation.EncodeToUtf16("Многие пробуют сэкономить время в погоне за силой, зачастую взывая к элементам для своей же выгоды. Хоть элементы и могут предоставить то, что от них просят, это будет стоить многого. Существуют Ведьмы, которые бродят по миру в поисках своей утерянной молодости, которую они хотят украсть обратно. Они обычно встречаются в аду, джунглях, океане и на небесах. Сделай нам одолжение - убей одну из них."));
        
        private static void Ru_ModifyTitleHardmodeContract(ILContext il) => Translation.ILTranslate(il, "To Be Continued...", Translation.EncodeToUtf16("Продолжение следует..."));
        
        private static void Ru_ModifyDescriptionHardmodeContract(ILContext il) => Translation.ILTranslate(il, "Defeat the terrifying Wall of Flesh to continue...", Translation.EncodeToUtf16("Победите ужасающую Стену плоти для новых контрактов."));
        
        private static void Ru_ModifyTitleIceContract(ILContext il) => Translation.ILTranslate(il, "Ice Breaker", Translation.EncodeToUtf16("Крушитель льда"));
        
        private static void Ru_ModifyDescriptionIceContract(ILContext il) => Translation.ILTranslate(il, "Better pack some warm clothes for this one kid; this automaton, crafted from the coldest ice you can fathom, only appears in raging blizzards. Its deadly frost beams will freeze you solid if you aren't careful, so keep on the move and hide behind cover!", Translation.EncodeToUtf16("Лучше взять вещи потеплее для этого дела, парень; этот механизм, собранный из самого холодного льда, который ты только можешь себе представить, появляется только во время страшных вьюг. Его смертельный ледяной луч превратит тебя в лядышку, если ты недостаточно аккуратен, так что не прекращай двигаться и прячься за укрытиями!"));
        
        private static void Ru_ModifyTitleMimicContract(ILContext il) => Translation.ILTranslate(il, "Fool's Gold", Translation.EncodeToUtf16("Золото дураков"));
        
        private static void Ru_ModifyDescriptionMimicContract(ILContext il) => Translation.ILTranslate(il, "I don't know what you did out there, kid, but things have gotten a lot more hectic. With the released spirits possessing our world, you can't trust anything now! Worse yet, it seems some avarice spirits have possessed a collection of chests deep underground turning them into Mimics. Keep your eyes peeled for any chests laying around. They may not be what they seem...", Translation.EncodeToUtf16("Я не знаю что ты наделал, парень, но всё в округе стало гораздо неспокойнее. После того, как освободившиеся духи заполнили этот мир, нельзя ничему доверять! И еще хуже то, что некоторые наиболее алчные духи, похоже, поработили множество сундуков подземелья, превращая их в мимиков. Будь повнимательнее, если видишь оставленные сундуки. Они могут оказаться не тем, чем кажутся..."));
        
        private static void Ru_ModifyTitleMinotaurContract(ILContext il) => Translation.ILTranslate(il, "Beast in the Maze", Translation.EncodeToUtf16("Чудовище Лабиринта"));
        
        private static void Ru_ModifyDescriptionMinotaurContract(ILContext il) => Translation.ILTranslate(il, "The Dungeon is bad enough with skeletons and slimes roaming around, but with a Raging Minotaur loose, it gets even more complicated. That beast can charge at incredible speed, blindsiding anyone not paying attention and crippling their movement. Don't get staggered out there, kid.", Translation.EncodeToUtf16("Темница - плохое место само по себе, из-за бродящих по нему слизней и скелетов. Но после освобождения разъяренного Минотавра, оно стала в разы опаснее. Это невероятно быстрое чудовище исподтишка нападает на невнимательных и калечит их. Постарайся стоять на своих ногах покрепче, парень."));
        
        private static void Ru_ModifyTitleMothContract(ILContext il) => Translation.ILTranslate(il, "Gonna Need a Bigger Lamp", Translation.EncodeToUtf16("Понадобится лампа побольше"));
        
        private static void Ru_ModifyDescriptionMothContract(ILContext il) => Translation.ILTranslate(il, "Don't be fooled, kid, the creature that lurks within the underground jungle is a being of pure terror, not beauty. Its mere existence is testament to our arrogance as individuals. It's... a moth!", Translation.EncodeToUtf16("Не дай себя обмануть, парень, то существо, которое прячется в подземных джунглях несет лишь ужас, а не красоту. Само ее существование это следствие самоуверенности отдельных лиц. Это... Моль!"));
        
        private static void Ru_ModifyTitleMothronContract(ILContext il) => Translation.ILTranslate(il, "Destroy All Monsters", Translation.EncodeToUtf16("Уничтожь всех чудищ"));
        
        private static void Ru_ModifyDescriptionMothronContract(ILContext il) => Translation.ILTranslate(il, "When the moon perfectly blocks the sun, the terror within us is released upon the world. My biggest fear has manifested as well in the form of a mutant moth! Hey, we don't choose what we fear, kid...", Translation.EncodeToUtf16("Когда луна полностью закрывает солнце, наши страхи выходят в этот мир. Мой самый жуткий кошмар также проявился в виде мотылька-мутанта!. Хэй, не мы выбираем свои страхи, парень..."));
        
        private static void Ru_ModifyTitleNymphContract(ILContext il) => Translation.ILTranslate(il, "Damsel of Distress", Translation.EncodeToUtf16("Девица бедствий"));
        
        private static void Ru_ModifyDescriptionNymphContract(ILContext il) => Translation.ILTranslate(il, "You've got a good heart, kid. Don't let that be the end of you with this contract... Deep within the snow caves, there hides a creature masquerading as a defenseless young girl. Once close enough, however, you'll see she's not so defenseless. Take her out if you find her!", Translation.EncodeToUtf16("У тебя доброе сердце, парень. Но не дай ему стать причиной твоего конца во время этого контракта... Глубоко в заснеженных пещерах прячется существо, маскирующееся под безобидную молодую девушку. Но, стоит тебе подойти и ты убеждаешься, что она не так беззащитна. Прикончи ее, если найдешь!"));
        
        private static void Ru_ModifyTitlePigronContract(ILContext il) => Translation.ILTranslate(il, "Boared to Death", Translation.EncodeToUtf16("Захрючен до смерти"));
        
        private static void Ru_ModifyDescriptionPigronContract(ILContext il) => Translation.ILTranslate(il, "The Pigron are a rather bizarre hybrid of creatures. 50% pig, 50% dragon, and 100% evil. You might encounter them where the ice caverns meet the worlds evil. Beware their grumbling bellies as they approach; It's quite audible.", Translation.EncodeToUtf16("Свинодракон это довольно причудливый гибрид существ. 50% свиньи, 50% дракона и 100% зла. Ты можешь встретить их там, где оледенелые пещеры встречаются с заражением. Остерегайся их пустых животов; они очень громкие."));
        
        private static void Ru_ModifyTitlePinkyContract(ILContext il) => Translation.ILTranslate(il, "Pinky, the World Ender", Translation.EncodeToUtf16("Пинки, Вестник конца"));
        
        private static void Ru_ModifyDescriptionPinkyContract(ILContext il) => Translation.ILTranslate(il, "Never before have I heard of a creature with such terrifying power... It's pink, it's mean, and it journeys around with a powerful storm of slime. Destroy it!", Translation.EncodeToUtf16("Я еще никогда не слышал о существе с настолько устрашающей силой... Оно розовое, оно злое и оно путешествует по миру, преследуемое сильным штормом из слизи. Уничтожь это!"));
        
        private static void Ru_ModifyTitlePirateShipContract(ILContext il) => Translation.ILTranslate(il, "Drunken Sailor's Query", Translation.EncodeToUtf16("Вопрос пьяного моряка"));
        
        private static void Ru_ModifyDescriptionPirateShipContract(ILContext il) => Translation.ILTranslate(il, "Have you heard tale of the pirates and their insatiable lust for gold? They can smell a coin from miles around, and from the looks of it, you've got quite a few. I would keep on guard for their inevitable siege. Make them regret attacking here by breaking one of their Flying Dutchman ships.", Translation.EncodeToUtf16("Слышал ли ты сказки о пиратах и их неутолимую тягу к золоту? Они способны учуять запах золотой монеты за многие километры и, похоже, денег у тебя предостаточно. Я буду стаять на страже, в ожидании их неизбежной осады. Заставь их пожалеть об этой атаке, сломав один из их Летучих Голландцев."));
        
        private static void Ru_ModifyTitleRecluseContract(ILContext il) => Translation.ILTranslate(il, "Not so Itsy Bitsy", Translation.EncodeToUtf16("Не совсем крошка-паучок"));
        
        private static void Ru_ModifyDescriptionRecluseContract(ILContext il) => Translation.ILTranslate(il, "Alright kid, I've got a bit of a double contract for you this time; a lot of our fellow townsfolk have severe cases of arachnophobia it seems. Rumors of a 'Brown Recluse' roaming the spider caverns have surfaced, but it seems like our only way to draw it out of hiding is to ALSO take down some kind of icy 'Gargantuan Spider', which prowls the tundra during harsh blizzards. If you can take both of them down, the folks around here should feel a lot safer.", Translation.EncodeToUtf16("Ну что ж, парень, у меня для тебя есть двойной контракт в этот раз. Многие из наших жителей, похоже, имеют тяжелые случаи арахнофобии. Появились слухи о 'Буром Отшельнике', бродящему в паучьих пещерах, но, похоже, что бы выманить его из убежища нам ТАКЖЕ стоит убить какого-то ледяного 'Гигантского Паука', который бродит по тундре во время суровых вьюг. Если ты их обоих устранишь, наши люди смогут чувствовать себя намного безопаснее."));
        
        private static void Ru_ModifyTitleRuneContract(ILContext il) => Translation.ILTranslate(il, "Rune Prune", Translation.EncodeToUtf16("Рунный-Занудный"));
        
        private static void Ru_ModifyDescriptionRuneContract(ILContext il) => Translation.ILTranslate(il, "The uncontrollable energies released by the Wall of Flesh's defeat have allowed some unsavory individuals to get quite a power boost. A rogue skeleton has harnessed the power of some long sealed spirits, and now terrorizes the underground as a Rune Wizard. His power is volatile and unpredictable; We can't allow him to live!", Translation.EncodeToUtf16("Неконтролируемая энергия, выпущенная после победы над стеной плоти, позволила некоторым неприятным существам получить нехилое усиление. Один скелет смог использовать силы запечатанных духов в свою пользу и теперь терроризирует подземелья под именем Рунного мага. Его силы изменчивы и непредсказуемы; Мы не можем позволить ему жить!"));
        
        private static void Ru_ModifyTitleSandContract(ILContext il) => Translation.ILTranslate(il, "Line in the Sand", Translation.EncodeToUtf16("Черта на песке"));
        
        private static void Ru_ModifyDescriptionSandContract(ILContext il) => Translation.ILTranslate(il, "An elemental's personality is heavily influenced by the environment it forms in. Considering sandstorms are rough, coarse, and dangerous, you can imagine why we would want to take down a few Sand Elementals. Watch your step for any nasty monsters wanting to take a bite out of you, kid!", Translation.EncodeToUtf16("Среда обитания элементаля сильно влияет на его характер. Зная, как грубы и опасны бури пустынь, ты можешь понять, почему нам лучше уничтожить несколько элементалей. Остерегайся монстров, которые так и хотят укусить тебя, парень!"));
        
        private static void Ru_ModifyTitleTimContract(ILContext il) => Translation.ILTranslate(il, "Casting a Shadow", Translation.EncodeToUtf16("Заклинатель теней"));
        
        private static void Ru_ModifyDescriptionTimContract(ILContext il) => Translation.ILTranslate(il, "I've managed to track down quite an elusive dark caster in the deeper levels of our world by the name of... Tim. Names aside, he's got quite a bit of power behind him, but one fatal weakness. It seems he's quite prideful of his outfit, thinking his better than any other. Maybe you should wear a gem robe to lure him out...?", Translation.EncodeToUtf16("В глубинах нашего мира я смог отследить довольно необычного тёмного колдуна. Его имя... Тим. Хотя имя не так уж и важно. Он довольно силён, но имеет одну смертельную слабость - он cлишком сильно гордится своим внешним видом. Может, тебе стоит надеть робу с самоцветами, дабы выманить его...?"));
        
        private static void Ru_ModifyTitleWyvernContract(ILContext il) => Translation.ILTranslate(il, "Off Cloud Nine", Translation.EncodeToUtf16("С седьмого неба"));
        
        private static void Ru_ModifyDescriptionWyvernContract(ILContext il) => Translation.ILTranslate(il, "The winds of change are upon us it seems. But these winds don't seem to be in our favor... A nasty nest of Wyverns have found their way to the nearby sky islands floating just above our heads. I think it would be best for everyone if some of them were culled.", Translation.EncodeToUtf16("Похоже, на нас тоже повеяло ветром перемен, но эти перемены далеко не в нашу пользу... Стая виверн нашли путь к островам, парящим прямо над нашими головами. Я думаю, всем будет лучше, если мы усмирим парочку."));
        
        private static void Ru_ModifyGetPriceText(ILContext il) => Translation.ILTranslate(il, "vanquisher medals", Translation.EncodeToUtf16("медалей победителя"));

        private static void Ru_ModifySetChatButtonsTracker(ILContext il)
        {
            Translation.ILTranslate(il, "Spend Medals", Translation.EncodeToUtf16("Потратить медали"));
            Translation.ILTranslate(il, "Available Contracts", Translation.EncodeToUtf16("Доступные контракты"));
        }
        
        private static void Ru_ModifySetChatButtonsDesertTraveler(ILContext il)
        {
            Translation.ILTranslate(il, "Sandstorm ", Translation.EncodeToUtf16("Песчаная буря "));
            Translation.ILTranslate(il, "(80 Silver)", Translation.EncodeToUtf16("(80 серебряных)"));
            Translation.ILTranslate(il, "(1 Gold)", Translation.EncodeToUtf16("(1 золотая)"));
        }
        
        private static void Ru_ModifySetChatButtonsSpiritualist(ILContext il) => Translation.ILTranslate(il, "Guardian Angel (5 Purified Shards)", Translation.EncodeToUtf16("Ангел-хранитель (5 очищенных осколков)"));
        
        private static void Ru_ModifySetChatButtonsDiverman(ILContext il) => Translation.ILTranslate(il, "Air Tank", Translation.EncodeToUtf16("Воздушный баллон"));
        
        private static void Ru_ModifySetChatButtonsWeaponMaster(ILContext il)
        {
            Translation.ILTranslate(il, "Hire Demon ", Translation.EncodeToUtf16("Нанять демона "));
            Translation.ILTranslate(il, "(8 Gold)", Translation.EncodeToUtf16("(8 золотых)"));
            Translation.ILTranslate(il, "(10 Gold)", Translation.EncodeToUtf16("(10 золотых)"));
        }
        
        private static void Ru_ModifySetChatButtonsCook(ILContext il) => Translation.ILTranslate(il, "Supply Ingredients", Translation.EncodeToUtf16("Снабдить ингредиентами"));
        
        private static void Ru_ModifySetChatButtonsConfusedZombie(ILContext il)
        {
            Translation.ILTranslate(il, "Enemy Repellent ", Translation.EncodeToUtf16("Репеллент"));
            Translation.ILTranslate(il, "(1 Gold 60 Silver)", Translation.EncodeToUtf16("(1 золотая 60 серебряных)"));
            Translation.ILTranslate(il, "(2 Gold)", Translation.EncodeToUtf16("(2 золотые)"));
        }
        
        private static void Ru_ModifySetChatButtonsCobbler(ILContext il) => Translation.ILTranslate(il, "Shine Shoes", Translation.EncodeToUtf16("Полированная обувь"));
        
        private static void Ru_ModifyTitleDangerContract(ILContext il) => Translation.ILTranslate(il, "Learning the Ropes", Translation.EncodeToUtf16("Изучение верёвок"));
        
        private static void Ru_ModifyModifyDescriptionDangerContract(ILContext il)
        {
            Translation.ILTranslate(il, "Alright kid, I think we should start you off easy... I've tracked down a group of wild creatures deep beneath our surface. On your adventures underground, you may encounter formidable creatures known as Crawdads, Salamanders and Giant Shellys. Taking out a couple of them would make the world a lot safer, and let me sleep peacefully for the night.", Translation.EncodeToUtf16("Хорошо, парень, я думаю, мы должны начать с простого... Я выследил группу диких существ глубоко под поверхностью. В своих приключениях под землей вы можете встретить грозных существ, известных как пресноводный рак, саламандра и гигантский ракушечник. Уничтожив пару из них, вы сделаете мир намного безопаснее и позволите мне спокойно спать по ночам."));
            Translation.ILTranslate(il, "Not bad at all, kid. Hopefully it wasn't too hard hunting one down. You may have noticed they dropped a 'Vanquisher Medal'. With those, you can redeem them for items I keep on me. Typically, they relate to the tracked creature, so be sure to visit me after completing any contracts.", Translation.EncodeToUtf16("Недурно, парень. Надеюсь, было не так уж сложно охотиться на кого-то из них. Ты, наверное, заметил, что они обронили 'Медаль победителя'. Ты можешь обменять их на вещи, которые я храню при себе. Как правило, они относятся к отслеживаемому существу, так что не забудь навестить меня после выполнения любых контрактов."));
        }
        
        private static void Ru_ModifyOnInitialize(ILContext il)
        {
            Translation.ILTranslate(il, "Close", Translation.EncodeToUtf16("Закрыть"));
            Translation.ILTranslate(il, "Previous", Translation.EncodeToUtf16("Предыдущий"));
            Translation.ILTranslate(il, "Next", Translation.EncodeToUtf16("Следующий"));
        }
        
        private static void Ru_ModifyNewRightClick(ILContext il)
        {
            Translation.ILTranslate(il, "Spawn point removed!", Translation.EncodeToUtf16("Точка воскрешения удалена!"));
            Translation.ILTranslate(il, "Spawn point set!", Translation.EncodeToUtf16("Точка воскрешения задана!"));
        }
        
        private static void Ru_ModifyPostUpdateEquips(ILContext il)
        {
            Translation.ILTranslate(il, " held on to life for as long as they could.", Translation.EncodeToUtf16(" держался за жизнь до последнего."));
            Translation.ILTranslate(il, " gave it their all...", Translation.EncodeToUtf16(" пожертвовал всем..."));
            Translation.ILTranslate(il, " was consumed by darkness...", Translation.EncodeToUtf16(" был поглощён тьмой..."));
        }
        
        private static void Ru_ModifyPreKill(ILContext il)
        {
            Translation.ILTranslate(il, " was completely eradicated.", Translation.EncodeToUtf16(" был полностью искоренен."));
            Translation.ILTranslate(il, " couldn't 'grasp' the situation.", Translation.EncodeToUtf16(" не смог 'уловить' ситуацию."));
            Translation.ILTranslate(il, " has failed Terraria...", Translation.EncodeToUtf16(" подвел Террарию..."));
            Translation.ILTranslate(il, " got liquefied.", Translation.EncodeToUtf16(" разжижился."));
            Translation.ILTranslate(il, " couldn't contain the granite energy.", Translation.EncodeToUtf16(" не смог сдержать энергию гранита."));
        }
        
        private static void Ru_ModifySetChatButtonsIllusionistSpawn(ILContext il) => Translation.ILTranslate(il, "Touch", Translation.EncodeToUtf16("Коснуться"));
        
        private static void Ru_ModifyUsesManaThoriumItem(ILContext il)
        {
            Translation.ILTranslate(il, " & ", Translation.EncodeToUtf16(" и "));
            Translation.ILTranslate(il, " life", Translation.EncodeToUtf16(" здоровья"));
        }
        
        private static void Ru_ModifyDisplayHealerIcon(ILContext il)
        {
            Translation.ILTranslate(il, ":Healer Stats]\nCurrent Bonus Healing: ", Translation.EncodeToUtf16(":Характеристики целителя]\nТекущее бонусное лечение: "));
            //Translation.ILTranslate(il, "\nBest Heal Streak: ", Translation.EncodeToUtf16("\n"));
            Translation.ILTranslate(il, "\nHealing done: ", Translation.EncodeToUtf16("\nВсего исцелено: "));
            Translation.ILTranslate(il, "\nDamage mitigated: ", Translation.EncodeToUtf16("\nПредотвращено урона: "));
            Translation.ILTranslate(il, "\nLives saved: ", Translation.EncodeToUtf16("\nЖизней спасено: "));
            Translation.ILTranslate(il, "\nClose calls: ", Translation.EncodeToUtf16("\nНа волоске"));
        }

        #endregion
        
        #region Thorium IL Manipulator

        private static event ILContext.Manipulator ModifyGetCombatTextAquaticAbility
        {
            add => HookEndpointManager.Modify(_getCombatTextAquaticAbility, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextAquaticAbility, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextAttackSpeed
        {
            add => HookEndpointManager.Modify(_getCombatTextAttackSpeed, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextAttackSpeed, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextCriticalStrikeChance
        {
            add => HookEndpointManager.Modify(_getCombatTextCriticalStrikeChance, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextCriticalStrikeChance, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextDamage
        {
            add => HookEndpointManager.Modify(_getCombatTextDamage, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextDamage, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextDamageReduction
        {
            add => HookEndpointManager.Modify(_getCombatTextDamageReduction, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextDamageReduction, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextDefense
        {
            add => HookEndpointManager.Modify(_getCombatTextDefense, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextDefense, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextEmpowermentProlongation
        {
            add => HookEndpointManager.Modify(_getCombatTextEmpowermentProlongation, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextEmpowermentProlongation, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextFlatDamage
        {
            add => HookEndpointManager.Modify(_getCombatTextFlatDamage, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextFlatDamage, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextFlightTime
        {
            add => HookEndpointManager.Modify(_getCombatTextFlightTime, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextFlightTime, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextInvincibilityFrames
        {
            add => HookEndpointManager.Modify(_getCombatTextInvincibilityFrames, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextInvincibilityFrames, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextJumpHeight
        {
            add => HookEndpointManager.Modify(_getCombatTextJumpHeight, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextJumpHeight, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextLifeRegeneration
        {
            add => HookEndpointManager.Modify(_getCombatTextLifeRegeneration, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextLifeRegeneration, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextMovementSpeed
        {
            add => HookEndpointManager.Modify(_getCombatTextMovementSpeed, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextMovementSpeed, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextResourceConsumptionChance
        {
            add => HookEndpointManager.Modify(_getCombatTextResourceConsumptionChance, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextResourceConsumptionChance, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextResourceGrabRange
        {
            add => HookEndpointManager.Modify(_getCombatTextResourceGrabRange, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextResourceGrabRange, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextResourceMaximum
        {
            add => HookEndpointManager.Modify(_getCombatTextResourceMaximum, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextResourceMaximum, value);
        }
        private static event ILContext.Manipulator ModifyGetCombatTextResourceRegen
        {
            add => HookEndpointManager.Modify(_getCombatTextResourceRegen, value);
            remove => HookEndpointManager.Unmodify(_getCombatTextResourceRegen, value);
        }
        private static event ILContext.Manipulator ModifyDoBossChecklistSupport
        {
            add => HookEndpointManager.Modify(_doBossChecklistSupport, value);
            remove => HookEndpointManager.Unmodify(_doBossChecklistSupport, value);
        }
        private static event ILContext.Manipulator ModifyDoCensusModSupport
        {
            add => HookEndpointManager.Modify(_doCensusModSupport, value);
            remove => HookEndpointManager.Unmodify(_doCensusModSupport, value);
        }
        private static event ILContext.Manipulator ModifyDisplayDrShieldIcon
        {
            add => HookEndpointManager.Modify(_displayDrShieldIcon, value);
            remove => HookEndpointManager.Unmodify(_displayDrShieldIcon, value);
        }
        private static event ILContext.Manipulator ModifyTitleAlmostContract
        {
            add => HookEndpointManager.Modify(_titleAlmostContract, value);
            remove => HookEndpointManager.Unmodify(_titleAlmostContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionAlmostContract
        {
            add => HookEndpointManager.Modify(_descriptionAlmostContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionAlmostContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleBoneLeeContract
        {
            add => HookEndpointManager.Modify(_titleBoneLeeContract, value);
            remove => HookEndpointManager.Unmodify(_titleBoneLeeContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionBoneLeeContract
        {
            add => HookEndpointManager.Modify(_descriptionBoneLeeContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionBoneLeeContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleCursedContract
        {
            add => HookEndpointManager.Modify(_titleCursedContract, value);
            remove => HookEndpointManager.Unmodify(_titleCursedContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionCursedContract
        {
            add => HookEndpointManager.Modify(_descriptionCursedContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionCursedContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleDoctorContract
        {
            add => HookEndpointManager.Modify(_titleDoctorContract, value);
            remove => HookEndpointManager.Unmodify(_titleDoctorContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionDoctorContract
        {
            add => HookEndpointManager.Modify(_descriptionDoctorContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionDoctorContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleGildedContract
        {
            add => HookEndpointManager.Modify(_titleGildedContract, value);
            remove => HookEndpointManager.Unmodify(_titleGildedContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionGildedContract
        {
            add => HookEndpointManager.Modify(_descriptionGildedContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionGildedContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleHagContract
        {
            add => HookEndpointManager.Modify(_titleHagContract, value);
            remove => HookEndpointManager.Unmodify(_titleHagContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionHagContract
        {
            add => HookEndpointManager.Modify(_descriptionHagContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionHagContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleHardmodeContract
        {
            add => HookEndpointManager.Modify(_titleHardmodeContract, value);
            remove => HookEndpointManager.Unmodify(_titleHardmodeContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionHardmodeContract
        {
            add => HookEndpointManager.Modify(_descriptionHardmodeContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionHardmodeContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleIceContract
        {
            add => HookEndpointManager.Modify(_titleIceContract, value);
            remove => HookEndpointManager.Unmodify(_titleIceContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionIceContract
        {
            add => HookEndpointManager.Modify(_descriptionIceContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionIceContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleMimicContract
        {
            add => HookEndpointManager.Modify(_titleMimicContract, value);
            remove => HookEndpointManager.Unmodify(_titleMimicContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionMimicContract
        {
            add => HookEndpointManager.Modify(_descriptionMimicContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionMimicContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleMinotaurContract
        {
            add => HookEndpointManager.Modify(_titleMinotaurContract, value);
            remove => HookEndpointManager.Unmodify(_titleMinotaurContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionMinotaurContract
        {
            add => HookEndpointManager.Modify(_descriptionMinotaurContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionMinotaurContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleMothContract
        {
            add => HookEndpointManager.Modify(_titleMothContract, value);
            remove => HookEndpointManager.Unmodify(_titleMothContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionMothContract
        {
            add => HookEndpointManager.Modify(_descriptionMothContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionMothContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleMothronContract
        {
            add => HookEndpointManager.Modify(_titleMothronContract, value);
            remove => HookEndpointManager.Unmodify(_titleMothronContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionMothronContract
        {
            add => HookEndpointManager.Modify(_descriptionMothronContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionMothronContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleNymphContract
        {
            add => HookEndpointManager.Modify(_titleNymphContract, value);
            remove => HookEndpointManager.Unmodify(_titleNymphContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionNymphContract
        {
            add => HookEndpointManager.Modify(_descriptionNymphContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionNymphContract, value);
        }
        private static event ILContext.Manipulator ModifyTitlePigronContract
        {
            add => HookEndpointManager.Modify(_titlePigronContract, value);
            remove => HookEndpointManager.Unmodify(_titlePigronContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionPigronContract
        {
            add => HookEndpointManager.Modify(_descriptionPigronContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionPigronContract, value);
        }
        private static event ILContext.Manipulator ModifyTitlePinkyContract
        {
            add => HookEndpointManager.Modify(_titlePinkyContract, value);
            remove => HookEndpointManager.Unmodify(_titlePinkyContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionPinkyContract
        {
            add => HookEndpointManager.Modify(_descriptionPinkyContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionPinkyContract, value);
        }
        private static event ILContext.Manipulator ModifyTitlePirateShipContract
        {
            add => HookEndpointManager.Modify(_titlePirateShipContract, value);
            remove => HookEndpointManager.Unmodify(_titlePirateShipContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionPirateShipContract
        {
            add => HookEndpointManager.Modify(_descriptionPirateShipContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionPirateShipContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleRecluseContract
        {
            add => HookEndpointManager.Modify(_titleRecluseContract, value);
            remove => HookEndpointManager.Unmodify(_titleRecluseContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionRecluseContract
        {
            add => HookEndpointManager.Modify(_descriptionRecluseContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionRecluseContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleRuneContract
        {
            add => HookEndpointManager.Modify(_titleRuneContract, value);
            remove => HookEndpointManager.Unmodify(_titleRuneContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionRuneContract
        {
            add => HookEndpointManager.Modify(_descriptionRuneContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionRuneContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleSandContract
        {
            add => HookEndpointManager.Modify(_titleSandContract, value);
            remove => HookEndpointManager.Unmodify(_titleSandContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionSandContract
        {
            add => HookEndpointManager.Modify(_descriptionSandContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionSandContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleTimContract
        {
            add => HookEndpointManager.Modify(_titleTimContract, value);
            remove => HookEndpointManager.Unmodify(_titleTimContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionTimContract
        {
            add => HookEndpointManager.Modify(_descriptionTimContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionTimContract, value);
        }
        private static event ILContext.Manipulator ModifyTitleWyvernContract
        {
            add => HookEndpointManager.Modify(_titleWyvernContract, value);
            remove => HookEndpointManager.Unmodify(_titleWyvernContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionWyvernContract
        {
            add => HookEndpointManager.Modify(_descriptionWyvernContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionWyvernContract, value);
        }
        private static event ILContext.Manipulator ModifyGetPriceText
        {
            add => HookEndpointManager.Modify(_getPriceText, value);
            remove => HookEndpointManager.Unmodify(_getPriceText, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsTracker
        {
            add => HookEndpointManager.Modify(_setChatButtonsTracker, value);
            remove => HookEndpointManager.Unmodify(_setChatButtonsTracker, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsWeaponMaster
        {
            add => HookEndpointManager.Modify(_setChatButtonsWeaponMaster, value);
            remove => HookEndpointManager.Unmodify(_setChatButtonsWeaponMaster, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsSpiritualist
        {
            add => HookEndpointManager.Modify(_setChatButtonsSpiritualist, value);
            remove => HookEndpointManager.Unmodify(_setChatButtonsSpiritualist, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsDiverman
        {
            add => HookEndpointManager.Modify(_setChatButtonsDiverman, value);
            remove => HookEndpointManager.Unmodify(_setChatButtonsDiverman, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsDesertTraveler
        {
            add => HookEndpointManager.Modify(_setChatButtonsDesertTraveler, value);
            remove => HookEndpointManager.Unmodify(_setChatButtonsDesertTraveler, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsCook
        {
            add => HookEndpointManager.Modify(_setChatButtonsCook, value);
            remove => HookEndpointManager.Unmodify(_setChatButtonsCook, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsConfusedZombie
        {
            add => HookEndpointManager.Modify(_setChatButtonsConfusedZombie, value);
            remove => HookEndpointManager.Unmodify(_setChatButtonsConfusedZombie, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsCobbler
        {
            add => HookEndpointManager.Modify(_setChatButtonsCobbler, value);
            remove => HookEndpointManager.Unmodify(_setChatButtonsCobbler, value);
        }
        private static event ILContext.Manipulator ModifyTitleDangerContract
        {
            add => HookEndpointManager.Modify(_titleDangerContract, value);
            remove => HookEndpointManager.Unmodify(_titleDangerContract, value);
        }
        private static event ILContext.Manipulator ModifyDescriptionDangerContract
        {
            add => HookEndpointManager.Modify(_descriptionDangerContract, value);
            remove => HookEndpointManager.Unmodify(_descriptionDangerContract, value);
        }
        private static event ILContext.Manipulator ModifyOnInitialize
        {
            add => HookEndpointManager.Modify(_onInitialize, value);
            remove => HookEndpointManager.Unmodify(_onInitialize, value);
        }
        private static event ILContext.Manipulator ModifyNewRightClick
        {
            add => HookEndpointManager.Modify(_newRightClick, value);
            remove => HookEndpointManager.Unmodify(_newRightClick, value);
        }
        private static event ILContext.Manipulator ModifyPostUpdateEquips
        {
            add => HookEndpointManager.Modify(_postUpdateEquips, value);
            remove => HookEndpointManager.Unmodify(_postUpdateEquips, value);
        }
        private static event ILContext.Manipulator ModifyPreKill
        {
            add => HookEndpointManager.Modify(_preKill, value);
            remove => HookEndpointManager.Unmodify(_preKill, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsIllusionistSpawn
        {
            add => HookEndpointManager.Modify(_setChatButtonsIllusionistSpawn, value);
            remove => HookEndpointManager.Unmodify(_setChatButtonsIllusionistSpawn, value);
        }
        private static event ILContext.Manipulator ModifyUsesManaThoriumItem
        {
            add => HookEndpointManager.Modify(_usesManaThoriumItem, value);
            remove => HookEndpointManager.Unmodify(_usesManaThoriumItem, value);
        }
        
        private static event ILContext.Manipulator ModifyDisplayHealerIcon
        {
            add => HookEndpointManager.Modify(_displayHealerIcon, value);
            remove => HookEndpointManager.Unmodify(_displayHealerIcon, value);
        }

        #endregion
        
        #region Thorium MethodInfo

        private static MethodInfo _getCombatTextAquaticAbility;
        private static MethodInfo _getCombatTextAttackSpeed;
        private static MethodInfo _getCombatTextCriticalStrikeChance;
        private static MethodInfo _getCombatTextDamage;
        private static MethodInfo _getCombatTextDamageReduction;
        private static MethodInfo _getCombatTextDefense;
        private static MethodInfo _getCombatTextEmpowermentProlongation;
        private static MethodInfo _getCombatTextFlatDamage;
        private static MethodInfo _getCombatTextFlightTime;
        private static MethodInfo _getCombatTextInvincibilityFrames;
        private static MethodInfo _getCombatTextJumpHeight;
        private static MethodInfo _getCombatTextLifeRegeneration;
        private static MethodInfo _getCombatTextMovementSpeed;
        private static MethodInfo _getCombatTextResourceConsumptionChance;
        private static MethodInfo _getCombatTextResourceGrabRange;
        private static MethodInfo _getCombatTextResourceMaximum;
        private static MethodInfo _getCombatTextResourceRegen;
        private static MethodInfo _doBossChecklistSupport;
        private static MethodInfo _doCensusModSupport;
        private static MethodInfo _displayDrShieldIcon;
        private static MethodInfo _displayHealerIcon;
        private static MethodInfo _titleAlmostContract;
        private static MethodInfo _descriptionAlmostContract;
        private static MethodInfo _titleBoneLeeContract;
        private static MethodInfo _descriptionBoneLeeContract;
        private static MethodInfo _titleCursedContract;
        private static MethodInfo _descriptionCursedContract;
        private static MethodInfo _titleDoctorContract;
        private static MethodInfo _descriptionDoctorContract;
        private static MethodInfo _titleGildedContract;
        private static MethodInfo _descriptionGildedContract;
        private static MethodInfo _titleHagContract;
        private static MethodInfo _descriptionHagContract;
        private static MethodInfo _titleHardmodeContract;
        private static MethodInfo _descriptionHardmodeContract;
        private static MethodInfo _titleIceContract;
        private static MethodInfo _descriptionIceContract;
        private static MethodInfo _titleMimicContract;
        private static MethodInfo _descriptionMimicContract;
        private static MethodInfo _titleMinotaurContract;
        private static MethodInfo _descriptionMinotaurContract;
        private static MethodInfo _titleMothContract;
        private static MethodInfo _descriptionMothContract;
        private static MethodInfo _titleMothronContract;
        private static MethodInfo _descriptionMothronContract;
        private static MethodInfo _titleNymphContract;
        private static MethodInfo _descriptionNymphContract;
        private static MethodInfo _titlePigronContract;
        private static MethodInfo _descriptionPigronContract;
        private static MethodInfo _titlePinkyContract;
        private static MethodInfo _descriptionPinkyContract;
        private static MethodInfo _titlePirateShipContract;
        private static MethodInfo _descriptionPirateShipContract;
        private static MethodInfo _titleRecluseContract;
        private static MethodInfo _descriptionRecluseContract;
        private static MethodInfo _titleRuneContract;
        private static MethodInfo _descriptionRuneContract;
        private static MethodInfo _titleSandContract;
        private static MethodInfo _descriptionSandContract;
        private static MethodInfo _titleTimContract;
        private static MethodInfo _descriptionTimContract;
        private static MethodInfo _titleWyvernContract;
        private static MethodInfo _descriptionWyvernContract;
        private static MethodInfo _getPriceText;
        private static MethodInfo _setChatButtonsTracker;
        private static MethodInfo _setChatButtonsWeaponMaster;
        private static MethodInfo _setChatButtonsSpiritualist;
        private static MethodInfo _setChatButtonsDiverman;
        private static MethodInfo _setChatButtonsDesertTraveler;
        private static MethodInfo _setChatButtonsCook;
        private static MethodInfo _setChatButtonsConfusedZombie;
        private static MethodInfo _setChatButtonsCobbler;
        private static MethodInfo _titleDangerContract;
        private static MethodInfo _descriptionDangerContract;
        private static MethodInfo _onInitialize;
        private static MethodInfo _newRightClick;
        private static MethodInfo _postUpdateEquips;
        private static MethodInfo _preKill;
        private static MethodInfo _setChatButtonsIllusionistSpawn;
        private static MethodInfo _usesManaThoriumItem;

        #endregion
    }
}