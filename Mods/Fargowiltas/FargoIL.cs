// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Utilities;
// using MonoMod.Cil;
// using MonoMod.RuntimeDetour.HookGen;
//
// namespace CalamityRuTranslate.Mods.Fargowiltas
// {
//     public class BattleCryIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Misc";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Misc.BattleCry").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Misc.BattleCry").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//     
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//         
//         private void TranslationUseItemHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Spawn rates ", Translation.EncodeToUtf16("Скорость появления врагов "));
//             Translation.ILTranslate(il, "increased!", Translation.EncodeToUtf16("увеличена!"));
//             Translation.ILTranslate(il, "decreased!", Translation.EncodeToUtf16("снижена!"));
//         }
//     }
//     
//     public class ExpertToggleIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Misc2";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Misc.ExpertToggle").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Misc.ExpertToggle").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//     
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//         
//         private void TranslationUseItemHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Expert mode is now enabled!", Translation.EncodeToUtf16("Режим эксперта теперь включён!"));
//             Translation.ILTranslate(il, "Expert mode is now disabled!", Translation.EncodeToUtf16("Режим эксперта теперь отключён!"));
//         }
//     }
//     
//     public class CursedSextantIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.CursedSextant").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.CursedSextant").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//     
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//         
//         private void TranslationUseItemHook(ILContext il) => Translation.ILTranslate(il, "The Blood Moon is rising...", Translation.EncodeToUtf16("Кровавая луна восходит..."));
//     }
//     
//     public class ForbiddenScarabIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom2";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.ForbiddenScarab").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.ForbiddenScarab").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//     
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//         
//         private void TranslationUseItemHook(ILContext il) => Translation.ILTranslate(il, "A sandstorm has begun.", Translation.EncodeToUtf16("Началась песчаная буря."));
//     }
//     
//     public class PartyConeIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom3";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.PartyCone").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.PartyCone").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//     
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//         
//         private void TranslationUseItemHook(ILContext il) => Translation.ILTranslate(il, "Looks like someone's throwing a Party!", Translation.EncodeToUtf16("Похоже, кто-то закатывает вечеринку!"));
//     }
//     
//     public class PillarSummonIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom4";
//         
//         private event ILContext.Manipulator ShootHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.PillarSummon").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.PillarSummon").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => ShootHook += TranslationShootHook;
//     
//         public override void Unload() => ShootHook -= TranslationShootHook;
//         
//         private void TranslationShootHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "The Celestial Pillars have awoken!", Translation.EncodeToUtf16("Небесные башни пробудились!"));
//             Translation.ILTranslate(il, "The Celestial Pillars have awoken!", Translation.EncodeToUtf16("Небесные башни пробудились!"), 2);
//         }
//     }
//     
//     public class WeatherBalloonIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom5";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.WeatherBalloon").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.WeatherBalloon").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//     
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//         
//         private void TranslationUseItemHook(ILContext il) => Translation.ILTranslate(il, "Rain clouds cover the sky.", Translation.EncodeToUtf16("Тучи закрывают небо."));
//     }
//     
//     public class AncientSealIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Mutant";
//         
//         private event ILContext.Manipulator ShootHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.AncientSeal").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.AncientSeal").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         private event ILContext.Manipulator SpawnBossHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.AncientSeal").GetMethod("SpawnBoss", BindingFlags.Public | BindingFlags.Static), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.AncientSeal").GetMethod("SpawnBoss", BindingFlags.Public | BindingFlags.Static), value);
//         }
//         
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load()
//         {
//             ShootHook += TranslationShootHook;
//             SpawnBossHook += TranslationSpawnBossHook;
//         }
//
//         public override void Unload()
//         {
//             ShootHook -= TranslationShootHook;
//             SpawnBossHook -= TranslationSpawnBossHook;
//         }
//
//         private void TranslationShootHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Every boss has awoken!", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "Every boss has awoken!", Translation.EncodeToUtf16(""), 2);
//         }
//         
//         private void TranslationSpawnBossHook(ILContext il) => Translation.ILTranslate(il, " has awoken!", Translation.EncodeToUtf16(""));
//     }
//     
//     public class DeathBringerFairyIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Mutant2";
//         
//         private event ILContext.Manipulator ShootHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.DeathBringerFairy").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.DeathBringerFairy").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => ShootHook += TranslationShootHook;
//
//         public override void Unload() => ShootHook -= TranslationShootHook;
//
//         private void TranslationShootHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Several bosses have awoken!", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "Several bosses have awoken!", Translation.EncodeToUtf16(""), 2);
//         }
//     }
//     
//     public class MutantVoodooIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Mutant3";
//         
//         private event ILContext.Manipulator ShootHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.MutantVoodoo").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.MutantVoodoo").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => ShootHook += TranslationShootHook;
//
//         public override void Unload() => ShootHook -= TranslationShootHook;
//
//         private void TranslationShootHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Several bosses have awoken!", Translation.EncodeToUtf16("Несколько боссов пробудились!"));
//             Translation.ILTranslate(il, "Several bosses have awoken!", Translation.EncodeToUtf16("Несколько боссов пробудились!"), 2);
//         }
//     }
//     
//     public class SuspiciousSkullIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Mutant4";
//         
//         private event ILContext.Manipulator ShootHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.SuspiciousSkull").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.SuspiciousSkull").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => ShootHook += TranslationShootHook;
//
//         public override void Unload() => ShootHook -= TranslationShootHook;
//
//         private void TranslationShootHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Skeletron has awoken!", Translation.EncodeToUtf16("Пробудился босс Скелетрон!"));
//             Translation.ILTranslate(il, "Skeletron has awoken!", Translation.EncodeToUtf16("Пробудился босс Скелетрон!"), 2);
//             Translation.ILTranslate(il, "Dungeon Guardian has awoken!", Translation.EncodeToUtf16("Пробудился босс Страж темницы!"));
//             Translation.ILTranslate(il, "Dungeon Guardian has awoken!", Translation.EncodeToUtf16("Пробудился босс Страж темницы!"), 2);
//         }
//     }
//     
//     public class OverloadCoznixIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.Thorium";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadCoznix").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadCoznix").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//
//         private void TranslationUseItemHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "The gates of hell have opened wide!", Translation.EncodeToUtf16("Врата ада распахнулись!"));
//             Translation.ILTranslate(il, "The gates of hell have opened wide!", Translation.EncodeToUtf16("Врата ада распахнулись!"), 2);
//         }
//     }
//     
//     public class OverloadJellyIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.Thorium2";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadJelly").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadJelly").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//
//         private void TranslationUseItemHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "National Jelly Day has arrived!", Translation.EncodeToUtf16("Наступил национальный день желе!"));
//             Translation.ILTranslate(il, "National Jelly Day has arrived!", Translation.EncodeToUtf16("Наступил национальный день желе!"), 2);
//         }
//     }
//     
//     public class OverloadLichIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.Thorium3";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadLich").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadLich").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//
//         private void TranslationUseItemHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Death is in the air!", Translation.EncodeToUtf16("Смерть витает в воздухе!"));
//             Translation.ILTranslate(il, "Death is in the air!", Translation.EncodeToUtf16("Смерть витает в воздухе!"), 2);
//         }
//     }
//     
//     public class OverloadSaucerIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.Thorium4";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadSaucer").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadSaucer").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//
//         private void TranslationUseItemHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Invaders have arrived!", Translation.EncodeToUtf16("Произошло вторжение!"));
//             Translation.ILTranslate(il, "Invaders have arrived!", Translation.EncodeToUtf16("Произошло вторжение!"), 2);
//         }
//     }
//     
//     public class OverloadStriderIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.Thorium5";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadStrider").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadStrider").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//
//         private void TranslationUseItemHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "A wave of frozen air begins howling!", Translation.EncodeToUtf16("Морозный ветер завывает!"));
//             Translation.ILTranslate(il, "A wave of frozen air begins howling!", Translation.EncodeToUtf16("Морозный ветер завывает!"), 2);
//         }
//     }
//     
//     public class OverloadThunderbirdIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.Thorium6";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadThunderbird").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadThunderbird").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//
//         private void TranslationUseItemHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Electricity fills the air!", Translation.EncodeToUtf16("Электричество наполняет воздух!"));
//             Translation.ILTranslate(il, "Electricity fills the air!", Translation.EncodeToUtf16("Электричество наполняет воздух!"), 2);
//         }
//     }
//     
//     public class OverloadFrostMoonIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.OverloadFrostMoon").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.OverloadFrostMoon").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//
//         private void TranslationUseItemHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "The Frost Moon fades away!", Translation.EncodeToUtf16("Морозная луна исчезает!"));
//             Translation.ILTranslate(il, "The Frost Moon fades away!", Translation.EncodeToUtf16("Морозная луна исчезает!"), 2);
//             Translation.ILTranslate(il, "The Frost Moon is rising...", Translation.EncodeToUtf16("Морозная луна восходит..."));
//             Translation.ILTranslate(il, "The Frost Moon is rising...", Translation.EncodeToUtf16("Морозная луна восходит..."), 2);
//             Translation.ILTranslate(il, "Wave: 20: Everything", Translation.EncodeToUtf16("Волна 20: Всё"));
//             Translation.ILTranslate(il, "Wave: 20: Everything", Translation.EncodeToUtf16("Волна 20: Всё"), 2);
//         }
//     }
//     
//     public class OverloadGoblinsIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons2";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.OverloadGoblins").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.OverloadGoblins").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//
//         private void TranslationUseItemHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "The goblins have calmed down!", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "The goblins have calmed down!", Translation.EncodeToUtf16(""), 2);
//         }
//     }
//     
//     public class OverloadMartiansIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons3";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.OverloadMartians").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.OverloadMartians").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//
//         private void TranslationUseItemHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "The martians have calmed down!", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "The martians have calmed down!", Translation.EncodeToUtf16(""), 2);
//         }
//     }
//     
//     public class OverloadPiratesIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons4";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.OverloadPirates").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.OverloadPirates").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//
//         private void TranslationUseItemHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "The pirates have calmed down!", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "The pirates have calmed down!", Translation.EncodeToUtf16(""), 2);
//         }
//     }
//     
//     public class OverloadPumpkinMoonIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons5";
//         
//         private event ILContext.Manipulator UseItemHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.OverloadPumpkinMoon").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SwarmSummons.OverloadPumpkinMoon").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => UseItemHook += TranslationUseItemHook;
//
//         public override void Unload() => UseItemHook -= TranslationUseItemHook;
//
//         private void TranslationUseItemHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "The Pumpkin Moon fades away!", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "The Pumpkin Moon fades away!", Translation.EncodeToUtf16(""), 2);
//             Translation.ILTranslate(il, "The Pumpkin Moon is rising...", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "The Pumpkin Moon is rising...", Translation.EncodeToUtf16(""), 2);
//             Translation.ILTranslate(il, "Wave: 15: Everything", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "Wave: 15: Everything", Translation.EncodeToUtf16(""), 2);
//         }
//     }
//     
//     public class BaseSummonIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons";
//         
//         private event ILContext.Manipulator ShootHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.BaseSummon").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.BaseSummon").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => ShootHook += TranslationShootHook;
//
//         public override void Unload() => ShootHook -= TranslationShootHook;
//
//         private void TranslationShootHook(ILContext il)
//         {
//             Translation.ILTranslate(il, " has awoken!", Translation.EncodeToUtf16(" пробудился!"));
//             Translation.ILTranslate(il, " has awoken!", Translation.EncodeToUtf16(" пробудился!"), 2);
//         }
//     }
//     
//     public class WormyFoodIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons2";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.WormyFood").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.WormyFood").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Eater of Worlds", Translation.EncodeToUtf16(""));
//     }
//     
//     public class BatteredClubIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom6";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.BatteredClub").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.BatteredClub").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Ogre", Translation.EncodeToUtf16(""));
//     }
//     
//     public class BetsyEggIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom7";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.BetsyEgg").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.BetsyEgg").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Betsy", Translation.EncodeToUtf16(""));
//     }
//     
//     public class FestiveOrnamentIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom8";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.FestiveOrnament").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.FestiveOrnament").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Everscream", Translation.EncodeToUtf16(""));
//     }
//     
//     public class ForbiddenTomeIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom9";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.ForbiddenTome").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.ForbiddenTome").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Dark Mage", Translation.EncodeToUtf16(""));
//     }
//     
//     public class HeadofManIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom10";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.HeadofMan").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.HeadofMan").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Headless Horseman", Translation.EncodeToUtf16(""));
//     }
//     
//     public class IceKingsRemainsIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom11";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.IceKingsRemains").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.IceKingsRemains").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Ice Queen", Translation.EncodeToUtf16(""));
//     }
//     
//     public class MartianMemoryStickIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom12";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.MartianMemoryStick").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.MartianMemoryStick").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Martian Saucer", Translation.EncodeToUtf16(""));
//     }
//     
//     public class NaughtyListIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom13";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.NaughtyList").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.NaughtyList").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Santa-NK1", Translation.EncodeToUtf16(""));
//     }
//     
//     public class SpookyBranchIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom14";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.SpookyBranch").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.SpookyBranch").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Mourning Wood", Translation.EncodeToUtf16(""));
//     }
//     
//     public class SuspiciousLookingScytheIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Abom15";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.SuspiciousLookingScythe").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.SuspiciousLookingScythe").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Pumpking", Translation.EncodeToUtf16(""));
//     }
//     
//     public class AthenianIdolIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.AthenianIdol").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.AthenianIdol").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Medusa", Translation.EncodeToUtf16(""));
//     }
//     
//     public class AttractiveOreIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt2";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.AttractiveOre").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.AttractiveOre").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Undead Miner", Translation.EncodeToUtf16(""));
//     }
//     
//     public class CloudSnackIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt3";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CloudSnack").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CloudSnack").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Wyvern", Translation.EncodeToUtf16(""));
//     }
//     
//     public class ClownLicenseIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt4";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ClownLicense").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ClownLicense").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Clown", Translation.EncodeToUtf16(""));
//     }
//     
//     public class CoreoftheFrostCoreIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt5";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CoreoftheFrostCore").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CoreoftheFrostCore").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Ice Golem", Translation.EncodeToUtf16(""));
//     }
//     
//     public class CorruptChestIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt6";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CorruptChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CorruptChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Corrupt Mimic", Translation.EncodeToUtf16(""));
//     }
//     
//     public class CrimsonChestIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt7";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CrimsonChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CrimsonChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Crimson Mimic", Translation.EncodeToUtf16(""));
//     }
//     
//     public class DilutedRainbowMatterIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt8";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.DilutedRainbowMatter").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.DilutedRainbowMatter").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Rainbow Slime", Translation.EncodeToUtf16(""));
//     }
//     
//     public class EggplantIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt9";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.Eggplant").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.Eggplant").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Doctor Bones", Translation.EncodeToUtf16(""));
//     }
//     
//     public class ForbiddenForbiddenFragmentIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt10";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ForbiddenForbiddenFragment").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ForbiddenForbiddenFragment").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Sand Elemental", Translation.EncodeToUtf16(""));
//     }
//     
//     public class GrandCrossIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt11";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.GrandCross").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.GrandCross").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Paladin", Translation.EncodeToUtf16(""));
//     }
//     
//     public class HallowChestIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt12";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HallowChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HallowChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Hallowed Mimic", Translation.EncodeToUtf16(""));
//     }
//     
//     public class HeartChocolateIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt13";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HeartChocolate").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HeartChocolate").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Nymph", Translation.EncodeToUtf16(""));
//     }
//     
//     public class HolyGrailIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt14";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HolyGrail").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HolyGrail").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Tim", Translation.EncodeToUtf16(""));
//     }
//     
//     public class InnocuousSkullIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt15";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.InnocuousSkull").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.InnocuousSkull").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Baby Guardian", Translation.EncodeToUtf16(""));
//     }
//     
//     public class JungleChestIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt16";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.JungleChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.JungleChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Jungle Mimic", Translation.EncodeToUtf16(""));
//     }
//     
//     public class LeesHeadbandIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt17";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.LeesHeadband").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.LeesHeadband").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Bone Lee", Translation.EncodeToUtf16(""));
//     }
//     
//     public class MothLampIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt18";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.MothLamp").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.MothLamp").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Moth", Translation.EncodeToUtf16(""));
//     }
//     
//     public class MothronEggIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt19";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.MothronEgg").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.MothronEgg").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Mothron", Translation.EncodeToUtf16(""));
//     }
//     
//     public class PinkSlimeCrownIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt20";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PinkSlimeCrown").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PinkSlimeCrown").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Pinky", Translation.EncodeToUtf16(""));
//     }
//     
//     public class PirateFlagIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt21";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PirateFlag").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PirateFlag").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Pirate Captain", Translation.EncodeToUtf16(""));
//     }
//     
//     public class PlunderedBootyIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt22";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PlunderedBooty").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PlunderedBooty").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Flying Dutchman", Translation.EncodeToUtf16(""));
//     }
//     
//     public class RuneOrbIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt23";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.RuneOrb").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.RuneOrb").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Rune Wizard", Translation.EncodeToUtf16(""));
//     }
//     
//     public class ShadowflameIconIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt24";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ShadowflameIcon").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ShadowflameIcon").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Goblin Summoner", Translation.EncodeToUtf16(""));
//     }
//     
//     public class SlimyLockBoxIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt25";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.SlimyLockBox").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.SlimyLockBox").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Dungeon Slime", Translation.EncodeToUtf16(""));
//     }
//     
//     public class SuspiciousLookingChestIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt26";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.SuspiciousLookingChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.SuspiciousLookingChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Mimic", Translation.EncodeToUtf16(""));
//     }
//     
//     public class WormSnackIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Deviantt27";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.WormSnack").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.WormSnack").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Digger", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "Giant Worm", Translation.EncodeToUtf16(""));
//         }
//     }
//     
//     public class CultistSummonIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Mutant5";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.CultistSummon").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.CultistSummon").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Lunatic Cultist", Translation.EncodeToUtf16(""));
//     }
//     
//     public class PlanterasFruitIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.Mutant6";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.PlanterasFruit").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.PlanterasFruit").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Plantera", Translation.EncodeToUtf16(""));
//     }
//     
//     public class Abeemination2IL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons3";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abeemination2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abeemination2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Queen Bee", Translation.EncodeToUtf16(""));
//     }
//     
//     public class CelestialSigil2IL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons4";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.CelestialSigil2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.CelestialSigil2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Moon Lord", Translation.EncodeToUtf16(""));
//     }
//     
//     public class GoreySpineIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons5";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.GoreySpine").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.GoreySpine").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Brain of Cthulhu", Translation.EncodeToUtf16(""));
//     }
//     
//     public class LihzahrdPowerCell2IL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons.VanillaCopy";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.VanillaCopy.LihzahrdPowerCell2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.VanillaCopy.LihzahrdPowerCell2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Golem", Translation.EncodeToUtf16("Голем"));
//     }
//     
//     public class MechSkullIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons6";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.MechSkull").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.MechSkull").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Skeletron Prime", Translation.EncodeToUtf16("Скелетрон Прайм"));
//     }
//     
//     public class MechWormIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons7";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.MechWorm").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.MechWorm").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "The Destroyer", Translation.EncodeToUtf16("Разрушитель"));
//     }
//     
//     public class SlimyCrownIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons8";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SlimyCrown").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SlimyCrown").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "King Slime", Translation.EncodeToUtf16("Король слизней"));
//     }
//     
//     public class SuspiciousEyeIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons9";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SuspiciousEye").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SuspiciousEye").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Eye of Cthulhu", Translation.EncodeToUtf16("Глаз Ктулху"));
//     }
//     
//     public class TruffleWorm2IL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Summons10";
//         
//         private event ILContext.Manipulator NPCNameHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.TruffleWorm2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.TruffleWorm2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => NPCNameHook += TranslationNPCNameHook;
//
//         public override void Unload() => NPCNameHook -= TranslationNPCNameHook;
//
//         private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Duke Fishron", Translation.EncodeToUtf16("Герцог Рыброн"));
//     }
//     
//     public class StatsIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Items.Misc3";
//         
//         private event ILContext.Manipulator ModifyTooltipsHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Misc.Stats").GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Misc.Stats").GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         private event ILContext.Manipulator ThoriumStatsHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Misc.Stats").GetMethod("ThoriumStats", BindingFlags.NonPublic | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Misc.Stats").GetMethod("ThoriumStats", BindingFlags.NonPublic | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load()
//         {
//             ModifyTooltipsHook += TranslationModifyTooltipsHook;
//             ThoriumStatsHook += TranslationThoriumStatsHook;
//         }
//
//         public override void Unload()
//         {
//             ModifyTooltipsHook -= TranslationModifyTooltipsHook;
//             ThoriumStatsHook -= TranslationThoriumStatsHook;
//         }
//
//         private void TranslationModifyTooltipsHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Melee Damage: {0}%", Translation.EncodeToUtf16("Урон ближнего боя: {0}%"));
//             Translation.ILTranslate(il, "Melee Speed: {0}%", Translation.EncodeToUtf16("Скорость атаки ближнего боя: {0}%"));
//             Translation.ILTranslate(il, "Melee Crit: {0}%", Translation.EncodeToUtf16("Шанс критического удара ближнего боя: {0}%"));
//             Translation.ILTranslate(il, "Ranged Damage: {0}%", Translation.EncodeToUtf16("Стрелковый урон: {0}%"));
//             Translation.ILTranslate(il, "Ranged Crit: {0}%", Translation.EncodeToUtf16("Стрелковый шанс критического удара: {0}%"));
//             Translation.ILTranslate(il, "Magic Damage: {0}%", Translation.EncodeToUtf16("Магический урон: {0}%"));
//             Translation.ILTranslate(il, "Magic Crit: {0}%", Translation.EncodeToUtf16("Магический шанс критического удара: {0}%"));
//             Translation.ILTranslate(il, "Summon Damage: {0}%", Translation.EncodeToUtf16("Урон миньонов: {0}%"));
//             Translation.ILTranslate(il, "Max Minions: {0}", Translation.EncodeToUtf16("Максимальное число миньонов: {0}"));
//             Translation.ILTranslate(il, "Max Sentries: {0}", Translation.EncodeToUtf16("Максимальное число турелей: {0}"));
//             Translation.ILTranslate(il, "Damage Reduction: {0}%", Translation.EncodeToUtf16("Сопротивление урону: {0}%"));
//             Translation.ILTranslate(il, "Life Regen: {0} HP/second",Translation.EncodeToUtf16("Регенерация здоровья: {0} здоровья/сек"));
//             Translation.ILTranslate(il, "Armor Pen: {0}", Translation.EncodeToUtf16("Пробивание брони: {0}"));
//             Translation.ILTranslate(il, "Max Speed: {0} mph", Translation.EncodeToUtf16("Максимальная скорость: {0} км/ч"));
//             Translation.ILTranslate(il, "Wing Time: {0} seconds", Translation.EncodeToUtf16("Время полёта: {0} сек"));
//         }
//         
//         private void TranslationThoriumStatsHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Symphonic Damage: {0}%", Translation.EncodeToUtf16("Симфонический урон: {0}%"));
//             Translation.ILTranslate(il, "Symphonic Speed: {0}%", Translation.EncodeToUtf16("Симфоническая скорость атаки: {0}%"));
//             Translation.ILTranslate(il, "Symphonic Crit: {0}%", Translation.EncodeToUtf16("Симфонический шанс критического удара: {0}%"));
//             Translation.ILTranslate(il, "Inspiration Regen: {0}%", Translation.EncodeToUtf16("Регенарация вдохновения: {0}%"));
//             Translation.ILTranslate(il, "Empowerment Duration: {0} seconds", Translation.EncodeToUtf16("Длительность усиления: {0} сек"));
//             Translation.ILTranslate(il, "Radiant Damage: {0}%", Translation.EncodeToUtf16("Лучезарный урон: {0}%"));
//             Translation.ILTranslate(il, "Radiant Speed: {0}%", Translation.EncodeToUtf16("Лучезарная скорость атаки: {0}%"));
//             Translation.ILTranslate(il, "Healing Speed: {0}%", Translation.EncodeToUtf16("Скорость лечения: {0}%"));
//             Translation.ILTranslate(il, "Radiant Crit: {0}%", Translation.EncodeToUtf16("Лучезарный шанс критического удара: {0}%"));
//             Translation.ILTranslate(il, "Bonus Healing: {0}", Translation.EncodeToUtf16("Бонусное лечение: {0}"));
//         }
//     }
//     
//     public class AbominationnIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.NPCs";
//         
//         private event ILContext.Manipulator SetChatButtonsHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.Abominationn").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.Abominationn").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         private event ILContext.Manipulator OnChatButtonClickedHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.Abominationn").GetMethod("OnChatButtonClicked", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.Abominationn").GetMethod("OnChatButtonClicked", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load()
//         {
//             SetChatButtonsHook += TranslationSetChatButtonsHook;
//             OnChatButtonClickedHook += TranslationOnChatButtonClickedHook;
//         }
//
//         public override void Unload()
//         {
//             SetChatButtonsHook -= TranslationSetChatButtonsHook;
//             OnChatButtonClickedHook -= TranslationOnChatButtonClickedHook;
//         }
//
//         private void TranslationSetChatButtonsHook(ILContext il) => Translation.ILTranslate(il, "Cancel Event", Translation.EncodeToUtf16(""));
//         
//         private void TranslationOnChatButtonClickedHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "The event has been cancelled!", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "Hocus pocus, the event is over.", Translation.EncodeToUtf16(""));
//         }
//     }
//     
//     public class DevianttIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.NPCs2";
//         
//         private event ILContext.Manipulator SetChatButtonsHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.Deviantt").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.Deviantt").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;
//
//         public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;
//
//         private void TranslationSetChatButtonsHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Help", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "Receive Gift", Translation.EncodeToUtf16(""));
//         }
//     }
//     
//     public class FargoGlobalNPCIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.NPCs3";
//         
//         private event ILContext.Manipulator CheckDeadHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.FargoGlobalNPC").GetMethod("CheckDead", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.FargoGlobalNPC").GetMethod("CheckDead", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         private event ILContext.Manipulator SwarmHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.FargoGlobalNPC").GetMethod("Swarm", BindingFlags.NonPublic | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.FargoGlobalNPC").GetMethod("Swarm", BindingFlags.NonPublic | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load()
//         {
//             CheckDeadHook += TranslationCheckDeadHook;
//             SwarmHook += TranslationSwarmHook;
//         }
//
//         public override void Unload()
//         {
//             CheckDeadHook -= TranslationCheckDeadHook;
//             SwarmHook -= TranslationSwarmHook;
//         }
//
//         private void TranslationCheckDeadHook(ILContext il) => Translation.ILTranslate(il, "Betsy has been defeated!", Translation.EncodeToUtf16(""));
//         
//         private void TranslationSwarmHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Killed: ", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "Killed: ", Translation.EncodeToUtf16(""), 2);
//             Translation.ILTranslate(il, "Total: ", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "Total: ", Translation.EncodeToUtf16(""), 2);
//             Translation.ILTranslate(il, "The swarm has been defeated!", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "The swarm has been defeated!", Translation.EncodeToUtf16(""), 2);
//         }
//     }
//     
//     public class FargowiltasIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.Fargowiltas";
//         
//         private event ILContext.Manipulator PostSetupContentHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Fargowiltas").GetMethod("PostSetupContent", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Fargowiltas").GetMethod("PostSetupContent", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         private event ILContext.Manipulator HandlePacketHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Fargowiltas").GetMethod("HandlePacket", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Fargowiltas").GetMethod("HandlePacket", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load()
//         {
//             PostSetupContentHook += TranslationPostSetupContentHook;
//             HandlePacketHook += TranslationHandlePacketHook;
//         }
//
//         public override void Unload()
//         {
//             PostSetupContentHook -= TranslationPostSetupContentHook;
//             HandlePacketHook -= TranslationHandlePacketHook;
//         }
//
//         private void TranslationPostSetupContentHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Defeat any rare enemy or... embrace eternity", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "Defeat any boss or miniboss", Translation.EncodeToUtf16("Одолейте любого босса или мини-босса"));
//             Translation.ILTranslate(il, "Chop down enough trees", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "Clear any event", Translation.EncodeToUtf16(""));
//             Translation.ILTranslate(il, "Have a Top Hat Squirrel ([i:{0}]) in your inventory", Translation.EncodeToUtf16(""));
//         }
//
//         private void TranslationHandlePacketHook(ILContext il) => Translation.ILTranslate(il, "The event has been cancelled!", Translation.EncodeToUtf16("Событие отменено!"));
//     }
//     
//     public class LumberJackIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.NPCs4";
//         
//         private event ILContext.Manipulator SetChatButtonsHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.LumberJack").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.LumberJack").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;
//
//         public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;
//
//         private void TranslationSetChatButtonsHook(ILContext il) => Translation.ILTranslate(il, "Tree Treasures", Translation.EncodeToUtf16("Древесные сокровища"));
//     }
//     
//     public class MutantIL : ILEdit
//     {
//         public override string DictKey => "Fargowiltas.NPCs5";
//         
//         private event ILContext.Manipulator SetChatButtonsHook
//         {
//             add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.Mutant").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.Mutant").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//
//         public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
//
//         public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;
//
//         public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;
//
//         private void TranslationSetChatButtonsHook(ILContext il)
//         {
//             Translation.ILTranslate(il, "Pre Hardmode", Translation.EncodeToUtf16("Дохардмод"));
//             Translation.ILTranslate(il, "Hardmode", Translation.EncodeToUtf16("Хардмод"));
//             Translation.ILTranslate(il, "Post Moon Lord", Translation.EncodeToUtf16("Пост-Лунный лорд"));
//             Translation.ILTranslate(il, "Cycle Shop", Translation.EncodeToUtf16("Переключить магазин"));
//         }
//     }
// }