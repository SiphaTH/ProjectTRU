// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using Terraria;
// using Terraria.ID;
// using Terraria.ModLoader;
// using ThoriumMod.Items.ArcaneArmor;
// using ThoriumMod.Items.BardItems;
// using ThoriumMod.Items.BossForgottenOne;
// using ThoriumMod.Items.BossLich;
// using ThoriumMod.Items.BossThePrimordials.Aqua;
// using ThoriumMod.Items.BossThePrimordials.Dream;
// using ThoriumMod.Items.BossThePrimordials.Omni;
// using ThoriumMod.Items.BossThePrimordials.Rhapsodist;
// using ThoriumMod.Items.BossThePrimordials.Slag;
// using ThoriumMod.Items.Bronze;
// using ThoriumMod.Items.Coral;
// using ThoriumMod.Items.Darksteel;
// using ThoriumMod.Items.DemonBlood;
// using ThoriumMod.Items.Depths;
// using ThoriumMod.Items.Donate;
// using ThoriumMod.Items.Dragon;
// using ThoriumMod.Items.Dread;
// using ThoriumMod.Items.EarlyMagic;
// using ThoriumMod.Items.Flesh;
// using ThoriumMod.Items.Geode;
// using ThoriumMod.Items.Granite;
// using ThoriumMod.Items.HealerItems;
// using ThoriumMod.Items.Icy;
// using ThoriumMod.Items.Illumite;
// using ThoriumMod.Items.Lodestone;
// using ThoriumMod.Items.MagicItems;
// using ThoriumMod.Items.Misc;
// using ThoriumMod.Items.Sandstone;
// using ThoriumMod.Items.Steel;
// using ThoriumMod.Items.SummonItems;
// using ThoriumMod.Items.Terrarium;
// using ThoriumMod.Items.Thorium;
// using ThoriumMod.Items.ThrownItems;
// using ThoriumMod.Items.Titan;
// using ThoriumMod.Items.Valadium;
// using ThoriumMod.Items.Vanity;
//
// namespace CalamityRuTranslate.Mods.ThoriumMod;
//
// public class ThoriumGlobalItem : GlobalItem
// {
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModsCall.Thorium != null && TranslationHelper.IsRussianLanguage;
//     }
//
//     public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
//     {
//         ItemHelper.TranslateTooltip(tooltips, "SetBonus", tooltip =>
//         {
//             Player player = Main.player[Main.myPlayer];
//
//             if (player.armor[0].type == ModContent.ItemType<WhisperingHood>() &&
//                 player.armor[1].type == ModContent.ItemType<WhisperingTabard>() &&
//                 player.armor[2].type == ModContent.ItemType<WhisperingLeggings>())
//             {
//                 tooltip.Text = "Иногда из вас появляется щупальце бездонной энергии, которое атакует ближайших врагов\nУ вас может быть до шести щупалец, и их урон отбирает 1 здоровье и ману у поражённого врага";
//             }
//             
//             if (player.armor[0].type == ItemID.WizardHat &&
//                 player.armor[1].type == ModContent.ItemType<AquamarineRobe>() ||
//                 player.armor[1].type == ModContent.ItemType<OpalRobe>())
//             {
//                 tooltip.Text = "Увеличивает магический шанс критического удара на 10%";
//             }
//             
//             if (player.armor[0].type == ItemID.MagicHat &&
//                 player.armor[1].type == ModContent.ItemType<AquamarineRobe>() ||
//                 player.armor[1].type == ModContent.ItemType<OpalRobe>())
//             {
//                 tooltip.Text = "Увеличивает максимальный запас маны на 60";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<FlightMask>() &&
//                 player.armor[1].type == ModContent.ItemType<FlightMail>() &&
//                 player.armor[2].type == ModContent.ItemType<FlightBoots>())
//             {
//                 tooltip.Text = "Теперь вы можете кратковременно летать";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<YewWoodHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<YewWoodBreastguard>() &&
//                 player.armor[2].type == ModContent.ItemType<YewWoodLeggings>())
//             {
//                 tooltip.Text = "После четырёх не критических ударов ваша следующая стрелковая атака нанесет мини-критический удар в 150%\nМини-критические выстрелы считаются критическими ударами для соответствующих эффектов";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<CriersCap>() &&
//                 player.armor[1].type == ModContent.ItemType<CriersSash>() &&
//                 player.armor[2].type == ModContent.ItemType<CriersLeggings>())
//             {
//                 tooltip.Text = "Симфонические усиления действуют на 3 секунды дольше";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<CyberPunkHeadset>() &&
//                 player.armor[1].type == ModContent.ItemType<CyberPunkSuit>() &&
//                 player.armor[2].type == ModContent.ItemType<CyberPunkLeggings>())
//             {
//                 tooltip.Text = "При нажатии клавиши 'Способность брони' вы переключитесь между четырьмя состояниями:\nКрасное - Вы и ближайшие союзники получаете Фиксированный урон II и Урон II\nЗелёное - Вы и ближайшие союзники получаете Скорость передвижения II и Время полёта II\nФиолетовое - Вы и ближайшие союзники получаете Максимальный запас ресурсов II и Восстановление ресурсов II\nСинее - Вы и ближайшие союзники получаете Защита II и Сопротивление урону II";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<JestersMask>() &&
//                 player.armor[1].type == ModContent.ItemType<JestersShirt>() &&
//                 player.armor[2].type == ModContent.ItemType<JestersLeggings>())
//             {
//                 tooltip.Text = "При симфонических критических ударах над головой зазвонит колокол, замедляя всех ближайших врагов на короткое время";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<MaestroWig>() &&
//                 player.armor[1].type == ModContent.ItemType<MaestroSuit>() &&
//                 player.armor[2].type == ModContent.ItemType<MaestroLeggings>())
//             {
//                 tooltip.Text = "Нажатие клавиши 'Способность брони' призывает хор играющих призрачных музыкантов\nПризраки быстро наносят урон ближайшим врагам духовыми, деревянными, струнными и ударными инструментами";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<MarchingBandCap>() &&
//                 player.armor[1].type == ModContent.ItemType<MarchingBandUniform>() &&
//                 player.armor[2].type == ModContent.ItemType<MarchingBandLeggings>())
//             {
//                 tooltip.Text = "Находясь в бою, за вами следует радуга наносящих урон симфонических символов, которые следуют за вами и оглушают врагов";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<NoblesHat>() &&
//                 player.armor[1].type == ModContent.ItemType<NoblesJerkin>() &&
//                 player.armor[2].type == ModContent.ItemType<NoblesLeggings>())
//             {
//                 tooltip.Text = "Inspiration notes that drop are twice as potent and increase your symphonic damage briefly";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<OrnateHat>() &&
//                 player.armor[1].type == ModContent.ItemType<OrnateJerkin>() &&
//                 player.armor[2].type == ModContent.ItemType<OrnateLeggings>())
//             {
//                 tooltip.Text = "Symphonic critical strikes cause a random active empowerment to ascend to a fourth level of intensity\nThis effect can only trigger once every 5 seconds";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<ShootingStarHat>() &&
//                 player.armor[1].type == ModContent.ItemType<ShootingStarShirt>() &&
//                 player.armor[2].type == ModContent.ItemType<ShootingStarBoots>())
//             {
//                 tooltip.Text = "Increases the duration of your symphonic empowerments by 6 seconds\nEach unique empowerment you have increases your symphonic damage by 5%\nEach unique empowerment you have increases your inspiration regeneration by 2%";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<WhisperingHood>() &&
//                 player.armor[1].type == ModContent.ItemType<WhisperingTabard>() &&
//                 player.armor[2].type == ModContent.ItemType<WhisperingLeggings>())
//             {
//                 tooltip.Text = "You occasionally birth a tentacle of abyssal energy that attacks nearby enemies\nYou can have up to six tentacles and their damage saps 1 life & mana from the hit enemy%";
//             }
//
//             if (player.armor[0].type == ModContent.ItemType<LichCowl>() &&
//                 player.armor[1].type == ModContent.ItemType<LichCarapace>() &&
//                 player.armor[2].type == ModContent.ItemType<LichTalon>())
//             {
//                 tooltip.Text = "Killing an enemy will release a soul fragment\nTouching a soul fragment greatly increases your movement and throwing speed briefly";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<TideTurnerHelmet>() &&
//                player.armor[1].type == ModContent.ItemType<TideTurnerBreastplate>() &&
//                player.armor[2].type == ModContent.ItemType<TideTurnerGreaves>())
//             {
//                 tooltip.Text = "Pressing the 'Armor Ability' key will envelop you within an impervious bubble\nWhile the bubble is active, all damage taken is converted into healing";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<TideTurnersGaze>() &&
//                 player.armor[1].type == ModContent.ItemType<TideTurnerBreastplate>() &&
//                 player.armor[2].type == ModContent.ItemType<TideTurnerGreaves>())
//             {
//                 tooltip.Text = "Throwing damage has a 20% chance to unleash aquatic homing daggers all around you";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<DreamWeaversHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<DreamWeaversTabard>() &&
//                 player.armor[2].type == ModContent.ItemType<DreamWeaversTreads>())
//             {
//                 tooltip.Text = "Pressing the 'Armor Ability' key will spend 200 mana and bend the very fabric of reality\nEnemies will be heavily slowed and take 15% more damage from all sources\nAllies will receive greatly increased movement and attack speed";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<DreamWeaversHood>() &&
//                 player.armor[1].type == ModContent.ItemType<DreamWeaversTabard>() &&
//                 player.armor[2].type == ModContent.ItemType<DreamWeaversTreads>())
//             {
//                 tooltip.Text = "Pressing the 'Armor Ability' key will spend 200 mana and place you within the Dream\nWhile in the Dream, healed allies will become briefly invulnerable and be cured of all debuffs";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<MasterArbalestHood>() &&
//                 player.armor[1].type == ModContent.ItemType<AssassinsGuard>() &&
//                 player.armor[2].type == ModContent.ItemType<AssassinsWalkers>())
//             {
//                 tooltip.Text = "Your ranged damage has a 10% chance to completely duplicate itself and deal 15% more damage";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<MasterMarksmansScouter>() &&
//                 player.armor[1].type == ModContent.ItemType<AssassinsGuard>() &&
//                 player.armor[2].type == ModContent.ItemType<AssassinsWalkers>())
//             {
//                 tooltip.Text = "Your ranged damage has a 5% chance to completely eradicate the hit target\nThis effect can only occur on bosses if they are below 5% maximum life";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<InspiratorsHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<RhapsodistChestWoofer>() &&
//                 player.armor[2].type == ModContent.ItemType<RhapsodistBoots>())
//             {
//                 tooltip.Text = "Pressing the 'Armor Ability' key will overload all nearby allies with every empowerment III for 15 seconds\nUsing this ability requires 20 inspiration and must recharge for 1 minute";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<SoloistHat>() &&
//                 player.armor[1].type == ModContent.ItemType<RhapsodistChestWoofer>() &&
//                 player.armor[2].type == ModContent.ItemType<RhapsodistBoots>())
//             {
//                 tooltip.Text = "Pressing the 'Armor Ability' key will grant you endless inspiration, greatly increased symphonic damage and playing speed\nThis effect lasts for 10 seconds and needs to recharge for 1 minute";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<MagmaSeersMask>() &&
//                 player.armor[1].type == ModContent.ItemType<PyromancerTabard>() &&
//                 player.armor[2].type == ModContent.ItemType<PyromancerLeggings>())
//             {
//                 tooltip.Text = "All minion damage leaves a lingering burn that deals significant damage over time";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<PyromancerCowl>() &&
//                 player.armor[1].type == ModContent.ItemType<PyromancerTabard>() &&
//                 player.armor[2].type == ModContent.ItemType<PyromancerLeggings>())
//             {
//                 tooltip.Text = "Your magic damage will heavily burn and damage all adjacent enemies";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<BronzeHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<BronzeBreastplate>() &&
//                 player.armor[2].type == ModContent.ItemType<BronzeGreaves>())
//             {
//                 tooltip.Text = "Throwing damage has a 20% chance to unleash a piercing lightning strike";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<CoralHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<CoralChestGuard>() &&
//                 player.armor[2].type == ModContent.ItemType<CoralGreaves>())
//             {
//                 tooltip.Text = "Radiant damage builds up to 20 life shield and life shielding no longer decays on you\nHealing an ally transfers the life shield to them";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<DarksteelFaceGuard>() &&
//                 player.armor[1].type == ModContent.ItemType<DarksteelBreastPlate>() &&
//                 player.armor[2].type == ModContent.ItemType<DarksteelGreaves>())
//             {
//                 tooltip.Text = "Nothing will stop your movement! Double tap to dash!";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<DemonBloodHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<DemonBloodBreastPlate>() &&
//                 player.armor[2].type == ModContent.ItemType<DemonBloodGreaves>())
//             {
//                 tooltip.Text = "Maximum life increased by 100";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<DepthDiverHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<DepthDiverChestplate>() &&
//                 player.armor[2].type == ModContent.ItemType<DepthDiverGreaves>())
//             {
//                 tooltip.Text = "You gain each of your emanating effects as well";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<NagaSkinMask>() &&
//                 player.armor[1].type == ModContent.ItemType<NagaSkinSuit>() &&
//                 player.armor[2].type == ModContent.ItemType<NagaSkinTail>())
//             {
//                 tooltip.Text = "Every 75 mana spent will dramatically increase your magic damage and casting speed briefly";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<TideHunterCap>() &&
//                 player.armor[1].type == ModContent.ItemType<TideHunterChestpiece>() &&
//                 player.armor[2].type == ModContent.ItemType<TideHunterLeggings>())
//             {
//                 tooltip.Text = "Ranged critical strikes release a splash of foam, slowing nearby enemies";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<FeralFurHead>() &&
//                 player.armor[1].type == ModContent.ItemType<FeralFurChest>() &&
//                 player.armor[2].type == ModContent.ItemType<FeralFurLegs>())
//             {
//                 tooltip.Text = "Lookin' good!";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<DragonMask>() &&
//                 player.armor[1].type == ModContent.ItemType<DragonBreastplate>() &&
//                 player.armor[2].type == ModContent.ItemType<DragonGreaves>())
//             {
//                 tooltip.Text = "Attacks have a chance to unleash an explosion of dragon flames";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<DreadSkull>() &&
//                 player.armor[1].type == ModContent.ItemType<DreadChestPlate>() &&
//                 player.armor[2].type == ModContent.ItemType<DreadGreaves>())
//             {
//                 tooltip.Text = "Your boots vibrate at an unreal frequency, increasing base movement speed significantly\nWhile moving, your melee damage and critical strike chance are increased";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<SilkHat>() &&
//                 player.armor[1].type == ModContent.ItemType<SilkTabard>() &&
//                 player.armor[2].type == ModContent.ItemType<SilkLeggings>())
//             {
//                 tooltip.Text = "12% increased magic damage while above 90% maximum mana";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<FleshMask>() &&
//                 player.armor[1].type == ModContent.ItemType<FleshBody>() &&
//                 player.armor[2].type == ModContent.ItemType<FleshLegs>())
//             {
//                 tooltip.Text = "While hurt, damaged enemies have a 10% chance to drop flesh\n Collected flesh restores life and grants bonus damage";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<GeodeHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<GeodeChestplate>() &&
//                 player.armor[2].type == ModContent.ItemType<GeodeGreaves>())
//             {
//                 tooltip.Text = "You can now mine entire ore veins at once";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<GraniteHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<GraniteChestGuard>() &&
//                 player.armor[2].type == ModContent.ItemType<GraniteGreaves>())
//             {
//                 tooltip.Text = "Immune to intense heat and enemy knockback, but your movement speed is slowed down greatly";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<BioTechHood>() &&
//                 player.armor[1].type == ModContent.ItemType<BioTechGarment>() &&
//                 player.armor[2].type == ModContent.ItemType<BioTechLeggings>())
//             {
//                 tooltip.Text = "A biotech probe will assist you in healing your allies\nHeals ally life equal to your bonus healing";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<BloomingCrown>() &&
//                 player.armor[1].type == ModContent.ItemType<BloomingTabard>() &&
//                 player.armor[2].type == ModContent.ItemType<BloomingLeggings>())
//             {
//                 tooltip.Text = "Your healing spells increase the life recovery and life recovery rate of the healed target";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<CelestialCrown>() &&
//                 player.armor[1].type == ModContent.ItemType<CelestialVestment>() &&
//                 player.armor[2].type == ModContent.ItemType<CelestialLeggings>())
//             {
//                 tooltip.Text = "Pressing the 'Armor Ability' key will summon a large aura around your cursor at the cost of 150 mana\nAllies touched by the aura gain increased damage, damage reduction, defense, and life recovery\nEnemies touched by the aura suffer from holy glare and take 15% more damage from all sources";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<EbonHood>() &&
//                 player.armor[1].type == ModContent.ItemType<EbonCloak>() &&
//                 player.armor[2].type == ModContent.ItemType<EbonLeggings>())
//             {
//                 tooltip.Text = "Empowers certain radiant attacks with dark energy, causing them to take on dark forms and deal additional effects";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<FallenPaladinFaceguard>() &&
//                 player.armor[1].type == ModContent.ItemType<FallenPaladinCuirass>() &&
//                 player.armor[2].type == ModContent.ItemType<FallenPaladinGreaves>())
//             {
//                 tooltip.Text = "Taking damage heals nearby allies equal to 15% of the damage taken";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<IridescentHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<IridescentMail>() &&
//                 player.armor[2].type == ModContent.ItemType<IridescentGreaves>())
//             {
//                 tooltip.Text = "Your radiant damage has a 15% chance to release a blinding flash of light\nThe flash heals nearby allies equal to your bonus healing and confuses enemies";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<LifeBinderMask>() &&
//                 player.armor[1].type == ModContent.ItemType<LifeBinderBreastplate>() &&
//                 player.armor[2].type == ModContent.ItemType<LifeBinderGreaves>())
//             {
//                 tooltip.Text = "Healing spells will shortly increase the healed player's maximum life by 50";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<NoviceClericCowl>() &&
//                 player.armor[1].type == ModContent.ItemType<NoviceClericTabard>() &&
//                 player.armor[2].type == ModContent.ItemType<NoviceClericPants>())
//             {
//                 tooltip.Text = "Every 5 seconds you generate up to 3 holy crosses\nWhen casting healing spells, a cross is used instead of mana";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<SacredHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<SacredBreastplate>() &&
//                 player.armor[2].type == ModContent.ItemType<SacredLeggings>())
//             {
//                 tooltip.Text = "Healing spells will heal an additional 5 life";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<TemplarsCirclet>() &&
//                 player.armor[1].type == ModContent.ItemType<TemplarsTabard>() &&
//                 player.armor[2].type == ModContent.ItemType<TemplarsLeggings>())
//             {
//                 tooltip.Text = "If an ally is below half health, you will gain increased healing abilities";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<WarlockHood>() &&
//                 player.armor[1].type == ModContent.ItemType<WarlockGarb>() &&
//                 player.armor[2].type == ModContent.ItemType<WarlockLeggings>())
//             {
//                 tooltip.Text = "Radiant attacks have a chance to generate up to 15 shadow wisps\nPressing the 'Armor Ability' key will unleash every stored shadow wisp towards your cursor's position";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<IcyHeadgear>() &&
//                 player.armor[1].type == ModContent.ItemType<IcyMail>() &&
//                 player.armor[2].type == ModContent.ItemType<IcyGreaves>())
//             {
//                 tooltip.Text = "An icy aura surrounds you, freezing enemies that stay too long within it";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<IllumiteMask>() &&
//                 player.armor[1].type == ModContent.ItemType<IllumiteChestplate>() &&
//                 player.armor[2].type == ModContent.ItemType<IllumiteGreaves>())
//             {
//                 tooltip.Text = "Your bows, guns, and launchers fire off additional projectiles periodically";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<LodeStoneFaceGuard>() &&
//                 player.armor[1].type == ModContent.ItemType<LodeStoneChestGuard>() &&
//                 player.armor[2].type == ModContent.ItemType<LodeStoneShinGuards>())
//             {
//                 tooltip.Text = "Damage reduction is increased by 6% for every 25% of life lost\nMaximum damage reduction is reached at 18% while below 25% life";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<CryomancersCrown>() &&
//                 player.armor[1].type == ModContent.ItemType<CryomancersTabard>() &&
//                 player.armor[2].type == ModContent.ItemType<CryomancersLeggings>())
//             {
//                 tooltip.Text = "Your magic damage will freeze enemies for two seconds";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<WhiteKnightMask>() &&
//                 player.armor[1].type == ModContent.ItemType<WhiteKnightTabard>() &&
//                 player.armor[2].type == ModContent.ItemType<WhiteKnightLeggings>())
//             {
//                 tooltip.Text =
//                     $"40% of the mana you spend is stored as energy to a maximum of [c/99ccff:{player.statManaMax2 * 2}]\nPressing the 'Armor Ability' key will spend energy to restore up to [c/99ccff:{player.statManaMax2}] mana and [c/bffdbd:{(int) (player.statManaMax2 * 0.1f)}] life at a time";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<ConduitHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<ConduitSuit>() &&
//                 player.armor[2].type == ModContent.ItemType<ConduitLeggings>())
//             {
//                 tooltip.Text = "Moving around generates up to 5 static rings, with each one generating life shielding\nWhen fully charged, a bubble of energy will protect you from one attack\nWhen the bubble blocks an attack, an electrical discharge is released at nearby enemies";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<HallowedChapeau>() &&
//                 player.armor[1].type is 551 or 4900 &&
//                 player.armor[2].type is 552 or 4901)
//             {
//                 tooltip.Text = "Become immune after striking an enemy,\nand increases the duration of your symphonic empowerments by 8 seconds";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<HallowedCowl>() &&
//                 player.armor[1].type is 551 or 4900 &&
//                 player.armor[2].type is 552 or 4901)
//             {
//                 tooltip.Text = "Become immune after striking an enemy,\nand healing spells will heal an additional 6 life";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<HallowedGuise>() &&
//                 player.armor[1].type is 551 or 4900 &&
//                 player.armor[2].type is 552 or 4901)
//             {
//                 tooltip.Text = "Become immune after striking an enemy,\nand increases your maximum technique points by 2";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<SandStoneHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<SandStoneMail>() &&
//                 player.armor[2].type == ModContent.ItemType<SandStoneGreaves>())
//             {
//                 tooltip.Text = "Desert winds have granted you a sandy double jump";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<DurasteelHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<DurasteelChestplate>() &&
//                 player.armor[2].type == ModContent.ItemType<DurasteelGreaves>())
//             {
//                 tooltip.Text = "Damage taken reduced by 10%";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<SteelHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<SteelChestplate>() &&
//                 player.armor[2].type == ModContent.ItemType<SteelGreaves>())
//             {
//                 tooltip.Text = "Damage taken reduced by 8%";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<AstroHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<AstroSuit>() &&
//                 player.armor[2].type == ModContent.ItemType<AstroBoots>())
//             {
//                 tooltip.Text = "Minion damage has a chance to unleash a burst of damaging plasma on hit";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<LifeBloomMask>() &&
//                 player.armor[1].type == ModContent.ItemType<LifeBloomMail>() &&
//                 player.armor[2].type == ModContent.ItemType<LifeBloomLeggings>())
//             {
//                 tooltip.Text = "Minion attacks have a 25% chance to heal you on hit\nYou cannot heal more than 50 life every 10 seconds";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<LivingWoodMask>() &&
//                 player.armor[1].type == ModContent.ItemType<LivingWoodChestguard>() &&
//                 player.armor[2].type == ModContent.ItemType<LivingWoodBoots>())
//             {
//                 tooltip.Text = "Increases your max number of minions by 1\nYour living wood sapling's auto attack will home in on enemies";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<SpiritTrapperHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<SpiritTrapperCuirass>() &&
//                 player.armor[2].type == ModContent.ItemType<SpiritTrapperGreaves>())
//             {
//                 tooltip.Text = "Increases your max number of minions by 1\nKilling enemies or continually damaging bosses generates soul wisps\nAfter generating 5 wisps, they are instantly consumed to heal you for 10 life";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<SpiritTrapperMask>() &&
//                 player.armor[1].type == ModContent.ItemType<SpiritTrapperCuirass>() &&
//                 player.armor[2].type == ModContent.ItemType<SpiritTrapperGreaves>())
//             {
//                 tooltip.Text = "Increases your max number of sentries by 1\nKilling enemies or continually damaging bosses generates soul wisps\nAfter generating 5 wisps, they are instantly consumed to heal you for 10 life";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<TerrariumHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<TerrariumBreastPlate>() &&
//                 player.armor[2].type == ModContent.ItemType<TerrariumGreaves>())
//             {
//                 tooltips.ReplaceText("The energies of Terraria will seek to protect you when you're in combat", "");
//                 tooltips.ReplaceText("Melee Focus: 15% increased damage reduction", "");
//                 tooltips.ReplaceText("Ranged Focus: 15% increased firing speed", "");
//                 tooltips.ReplaceText("Magic Focus: Maximum mana increased by 100", "");
//                 tooltips.ReplaceText("Summon Focus: Increases your max number of minions by 3", "");
//                 tooltips.ReplaceText("Thrown Focus: Increases your maximum technique points by 2", "");
//                 tooltips.ReplaceText("Radiant Focus: Healing spells will heal an additional 3 life", "");
//                 tooltips.ReplaceText("Symphonic Focus: Increases empowerment duration by 6 seconds", "");
//                 tooltips.ReplaceText("No Focus: 20% increased damage", "");
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<ThoriumHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<ThoriumMail>() &&
//                 player.armor[2].type == ModContent.ItemType<ThoriumGreaves>())
//             {
//                 tooltip.Text = "Damage done increased by 10%";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<FungusHat>() &&
//                 player.armor[1].type == ModContent.ItemType<FungusGuard>() &&
//                 player.armor[2].type == ModContent.ItemType<FungusLeggings>())
//             {
//                 tooltip.Text = "Damage done against mycelium infected enemies is increased by 10%\nDealing damage to enemies infected with mycelium briefly increases throwing speed by 10%";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<PlagueDoctorsMask>() &&
//                 player.armor[1].type == ModContent.ItemType<PlagueDoctorsGarb>() &&
//                 player.armor[2].type == ModContent.ItemType<PlagueDoctorsLeggings>())
//             {
//                 tooltip.Text = "Your plague gas will linger in the air twice as long and your plague reactions will deal 20% more damage";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<ShadeMasterMask>() &&
//                 player.armor[1].type == ModContent.ItemType<ShadeMasterGarb>() &&
//                 player.armor[2].type == ModContent.ItemType<ShadeMasterTreads>())
//             {
//                 tooltip.Text = "Up to 50% of the damage you take is staggered over the next 10 seconds";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<WhiteDwarfMask>() &&
//                 player.armor[1].type == ModContent.ItemType<WhiteDwarfGuard>() &&
//                 player.armor[2].type == ModContent.ItemType<WhiteDwarfGreaves>())
//             {
//                 tooltip.Text = "Critical strikes will unleash ivory flares from the cosmos\nIvory flares deal 0.1% of the hit target's maximum life as damage";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<TitanHeadgear>() &&
//                 player.armor[1].type == ModContent.ItemType<TitanBreastplate>() &&
//                 player.armor[2].type == ModContent.ItemType<TitanGreaves>())
//             {
//                 tooltip.Text = "Damage done increased by 18%!";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<TitanHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<TitanBreastplate>() &&
//                 player.armor[2].type == ModContent.ItemType<TitanGreaves>())
//             {
//                 tooltip.Text = "Damage done increased by 18%!";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<TitanMask>() &&
//                 player.armor[1].type == ModContent.ItemType<TitanBreastplate>() &&
//                 player.armor[2].type == ModContent.ItemType<TitanGreaves>())
//             {
//                 tooltip.Text = "Damage done increased by 18%!";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<ValadiumHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<ValadiumBreastPlate>() &&
//                 player.armor[2].type == ModContent.ItemType<ValadiumGreaves>())
//             {
//                 tooltip.Text = "Reverse gravity by pressing UP. While reversed, ranged damage is increased by 15%!";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<BlueKnightHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<BlueKnightArmor>() &&
//                 player.armor[2].type == ModContent.ItemType<BlueKnightGreaves>())
//             {
//                 tooltip.Text = "Lookin' good!";
//             }
//             
//             if (player.armor[0].type == ModContent.ItemType<GlitteringHelmet>() &&
//                 player.armor[1].type == ModContent.ItemType<GlitteringChestplate>() &&
//                 player.armor[2].type == ModContent.ItemType<GlitteringGreaves>())
//             {
//                 tooltip.Text = "Lookin' good!";
//             }
//         });
//     }
// }