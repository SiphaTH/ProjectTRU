using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Mods.ThoriumMod;
using CalamityRuTranslate.Utilities;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;

namespace CalamityRuTranslate.Mods.Fargowiltas
{
    public class BattleCryIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Misc.BattleCry.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Misc.BattleCry.UseItem += TranslationUseItemHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Misc.BattleCry.UseItem -= TranslationUseItemHook;
        
        private void TranslationUseItemHook(ILContext il)
        {
            Translation.ILTranslate(il, "Spawn rates ", Translation.EncodeToUtf16("Скорость появления врагов "));
            Translation.ILTranslate(il, "increased!", Translation.EncodeToUtf16("увеличена!"));
            Translation.ILTranslate(il, "decreased!", Translation.EncodeToUtf16("снижена!"));
        }
    }
    
    public class ExpertToggleIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Misc.ExpertToggle.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Misc.ExpertToggle.UseItem += TranslationUseItemHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Misc.ExpertToggle.UseItem -= TranslationUseItemHook;
        
        private void TranslationUseItemHook(ILContext il)
        {
            Translation.ILTranslate(il, "Expert mode is now enabled!", Translation.EncodeToUtf16("Режим эксперта теперь включён!"));
            Translation.ILTranslate(il, "Expert mode is now disabled!", Translation.EncodeToUtf16("Режим эксперта теперь отключён!"));
        }
    }
    
    public class CursedSextantIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.CursedSextant.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.Abom.CursedSextant.UseItem += TranslationUseItemHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.Abom.CursedSextant.UseItem -= TranslationUseItemHook;
        
        private void TranslationUseItemHook(ILContext il) => Translation.ILTranslate(il, "The Blood Moon is rising...", Translation.EncodeToUtf16("Кровавая луна восходит..."));
    }
    
    public class ForbiddenScarabIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.ForbiddenScarab.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.Abom.ForbiddenScarab.UseItem += TranslationUseItemHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.Abom.ForbiddenScarab.UseItem -= TranslationUseItemHook;
        
        private void TranslationUseItemHook(ILContext il) => Translation.ILTranslate(il, "A sandstorm has begun.", Translation.EncodeToUtf16("Началась песчаная буря."));
    }
    
    public class PartyConeIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.PartyCone.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.Abom.PartyCone.UseItem += TranslationUseItemHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.Abom.PartyCone.UseItem -= TranslationUseItemHook;
        
        private void TranslationUseItemHook(ILContext il) => Translation.ILTranslate(il, "Looks like someone's throwing a Party!", Translation.EncodeToUtf16("Похоже, кто-то закатывает вечеринку!"));
    }
    
    public class PillarSummonIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.PillarSummon.Shoot";
    
        private event ILContext.Manipulator ShootHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.PillarSummon").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.PillarSummon").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => ShootHook += TranslationShootHook;
    
        public override void Unload() => ShootHook -= TranslationShootHook;
        
        private void TranslationShootHook(ILContext il)
        {
            Translation.ILTranslate(il, "The Celestial Pillars have awoken!", Translation.EncodeToUtf16("Небесные башни пробудились!"));
            Translation.ILTranslate(il, "The Celestial Pillars have awoken!", Translation.EncodeToUtf16("Небесные башни пробудились!"), 2);
        }
    }
    
    public class WeatherBalloonIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.WeatherBalloon.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.Abom.WeatherBalloon.UseItem += TranslationUseItemHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.Abom.WeatherBalloon.UseItem -= TranslationUseItemHook;
        
        private void TranslationUseItemHook(ILContext il) => Translation.ILTranslate(il, "Rain clouds cover the sky.", Translation.EncodeToUtf16("Тучи закрывают небо."));
    }
    
    public class AncientSealIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Mutant.AncientSeal";

        private event ILContext.Manipulator ShootHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.AncientSeal").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.AncientSeal").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load()
        {
            ShootHook += TranslationShootHook;
            IL.Fargowiltas.Items.Summons.Mutant.AncientSeal.SpawnBoss += TranslationSpawnBossHook;
        }

        public override void Unload()
        {
            ShootHook -= TranslationShootHook;
            IL.Fargowiltas.Items.Summons.Mutant.AncientSeal.SpawnBoss -= TranslationSpawnBossHook;
        }

        private void TranslationShootHook(ILContext il)
        {
            Translation.ILTranslate(il, "Every boss has awoken!", Translation.EncodeToUtf16("Все боссы пробудились!"));
            Translation.ILTranslate(il, "Every boss has awoken!", Translation.EncodeToUtf16("Все боссы пробудились!"), 2);
        }
        
        private void TranslationSpawnBossHook(ILContext il) => Translation.ILTranslate(il, " has awoken!", Translation.EncodeToUtf16(" пробудился!"));
    }
    
    public class DeathBringerFairyIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Mutant.DeathBringerFairy.Shoot";
    
        private event ILContext.Manipulator ShootHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.DeathBringerFairy").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.DeathBringerFairy").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => ShootHook += TranslationShootHook;
    
        public override void Unload() => ShootHook -= TranslationShootHook;
    
        private void TranslationShootHook(ILContext il)
        {
            Translation.ILTranslate(il, "Several bosses have awoken!", Translation.EncodeToUtf16("Несколько боссов пробудились!"));
            Translation.ILTranslate(il, "Several bosses have awoken!", Translation.EncodeToUtf16("Несколько боссов пробудились!"), 2);
        }
    }
    
    public class MutantVoodooIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Mutant.MutantVoodoo.Shoot";
    
        private event ILContext.Manipulator ShootHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.MutantVoodoo").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.MutantVoodoo").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => ShootHook += TranslationShootHook;
    
        public override void Unload() => ShootHook -= TranslationShootHook;
    
        private void TranslationShootHook(ILContext il)
        {
            Translation.ILTranslate(il, "Several bosses have awoken!", Translation.EncodeToUtf16("Несколько боссов пробудились!"));
            Translation.ILTranslate(il, "Several bosses have awoken!", Translation.EncodeToUtf16("Несколько боссов пробудились!"), 2);
        }
    }
    
    public class SuspiciousSkullIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Mutant.SuspiciousSkull.Shoot";
    
        private event ILContext.Manipulator ShootHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.SuspiciousSkull").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.SuspiciousSkull").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => ShootHook += TranslationShootHook;
    
        public override void Unload() => ShootHook -= TranslationShootHook;
    
        private void TranslationShootHook(ILContext il)
        {
            Translation.ILTranslate(il, "Skeletron has awoken!", Translation.EncodeToUtf16("Скелетрон пробудился!"));
            Translation.ILTranslate(il, "Skeletron has awoken!", Translation.EncodeToUtf16("Скелетрон пробудился!"), 2);
            Translation.ILTranslate(il, "Dungeon Guardian has awoken!", Translation.EncodeToUtf16("Страж темницы пробудился!"));
            Translation.ILTranslate(il, "Dungeon Guardian has awoken!", Translation.EncodeToUtf16("Страж темницы пробудился!"), 2);
        }
    }
    
    public class OverloadCoznixIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadCoznix.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadCoznix.UseItem += TranslationUseItemHook;

        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadCoznix.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            Translation.ILTranslate(il, "The gates of hell have opened wide!", Translation.EncodeToUtf16("Врата ада распахнулись!"));
            Translation.ILTranslate(il, "The gates of hell have opened wide!", Translation.EncodeToUtf16("Врата ада распахнулись!"), 2);
        }
    }
    
    public class OverloadJellyIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadJelly.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadJelly.UseItem += TranslationUseItemHook;

        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadJelly.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            Translation.ILTranslate(il, "National Jelly Day has arrived!", Translation.EncodeToUtf16("Наступил национальный день желе!"));
            Translation.ILTranslate(il, "National Jelly Day has arrived!", Translation.EncodeToUtf16("Наступил национальный день желе!"), 2);
        }
    }
    
    public class OverloadLichIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadLich.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadLich.UseItem += TranslationUseItemHook;

        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadLich.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            Translation.ILTranslate(il, "Death is in the air!", Translation.EncodeToUtf16("Смерть витает в воздухе!"));
            Translation.ILTranslate(il, "Death is in the air!", Translation.EncodeToUtf16("Смерть витает в воздухе!"), 2);
        }
    }
    
    public class OverloadSaucerIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadSaucer.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadSaucer.UseItem += TranslationUseItemHook;

        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadSaucer.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            Translation.ILTranslate(il, "Invaders have arrived!", Translation.EncodeToUtf16("Произошло вторжение!"));
            Translation.ILTranslate(il, "Invaders have arrived!", Translation.EncodeToUtf16("Произошло вторжение!"), 2);
        }
    }
    
    public class OverloadStriderIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadStrider.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadStrider.UseItem += TranslationUseItemHook;

        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadStrider.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            Translation.ILTranslate(il, "A wave of frozen air begins howling!", Translation.EncodeToUtf16("Морозный ветер завывает!"));
            Translation.ILTranslate(il, "A wave of frozen air begins howling!", Translation.EncodeToUtf16("Морозный ветер завывает!"), 2);
        }
    }
    
    public class OverloadThunderbirdIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadThunderbird.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadThunderbird.UseItem += TranslationUseItemHook;

        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.Thorium.OverloadThunderbird.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            Translation.ILTranslate(il, "Electricity fills the air!", Translation.EncodeToUtf16("Электричество наполняет воздух!"));
            Translation.ILTranslate(il, "Electricity fills the air!", Translation.EncodeToUtf16("Электричество наполняет воздух!"), 2);
        }
    }
    
    public class OverloadFrostMoonIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadFrostMoon.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadFrostMoon.UseItem += TranslationUseItemHook;

        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadFrostMoon.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            Translation.ILTranslate(il, "The Frost Moon fades away!", Translation.EncodeToUtf16("Морозная луна исчезает!"));
            Translation.ILTranslate(il, "The Frost Moon fades away!", Translation.EncodeToUtf16("Морозная луна исчезает!"), 2);
            Translation.ILTranslate(il, "The Frost Moon is rising...", Translation.EncodeToUtf16("Восходит морозная луна..."));
            Translation.ILTranslate(il, "The Frost Moon is rising...", Translation.EncodeToUtf16("Восходит морозная луна..."), 2);
            Translation.ILTranslate(il, "Wave: 20: Everything", Translation.EncodeToUtf16("Волна 20: Все"));
            Translation.ILTranslate(il, "Wave: 20: Everything", Translation.EncodeToUtf16("Волна 20: Все"), 2);
        }
    }
    
    public class OverloadGoblinsIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadGoblins.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadGoblins.UseItem += TranslationUseItemHook;

        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadGoblins.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            Translation.ILTranslate(il, "The goblins have calmed down!", Translation.EncodeToUtf16("Гоблины успокоились!"));
            Translation.ILTranslate(il, "The goblins have calmed down!", Translation.EncodeToUtf16("Гоблины успокоились!"), 2);
        }
    }
    
    public class OverloadMartiansIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadMartians.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadMartians.UseItem += TranslationUseItemHook;

        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadMartians.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            Translation.ILTranslate(il, "The martians have calmed down!", Translation.EncodeToUtf16("Марсиане успокоились!"));
            Translation.ILTranslate(il, "The martians have calmed down!", Translation.EncodeToUtf16("Марсиане успокоились!"), 2);
        }
    }
    
    public class OverloadPiratesIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadPirates.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadPirates.UseItem += TranslationUseItemHook;

        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadPirates.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            Translation.ILTranslate(il, "The pirates have calmed down!", Translation.EncodeToUtf16("Пираты успокоились!"));
            Translation.ILTranslate(il, "The pirates have calmed down!", Translation.EncodeToUtf16("Пираты успокоились!"), 2);
        }
    }
    
    public class OverloadPumpkinMoonIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadPumpkinMoon.UseItem";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadPumpkinMoon.UseItem += TranslationUseItemHook;

        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadPumpkinMoon.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            Translation.ILTranslate(il, "The Pumpkin Moon fades away!", Translation.EncodeToUtf16("Тыквенная луна исчезает!"));
            Translation.ILTranslate(il, "The Pumpkin Moon fades away!", Translation.EncodeToUtf16("Тыквенная луна исчезает!"), 2);
            Translation.ILTranslate(il, "The Pumpkin Moon is rising...", Translation.EncodeToUtf16("Восходит тыквенная луна..."));
            Translation.ILTranslate(il, "The Pumpkin Moon is rising...", Translation.EncodeToUtf16("Восходит тыквенная луна..."), 2);
            Translation.ILTranslate(il, "Wave: 15: Everything", Translation.EncodeToUtf16("Волна 15: Все"));
            Translation.ILTranslate(il, "Wave: 15: Everything", Translation.EncodeToUtf16("Волна 15: Все"), 2);
        }
    }
    
    public class BaseSummonIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.BaseSummon.Shoot";
    
        private event ILContext.Manipulator ShootHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.BaseSummon").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.BaseSummon").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => ShootHook += TranslationShootHook;
    
        public override void Unload() => ShootHook -= TranslationShootHook;
    
        private void TranslationShootHook(ILContext il)
        {
            Translation.ILTranslate(il, " has awoken!", Translation.EncodeToUtf16(" пробудился!"));
            Translation.ILTranslate(il, " has awoken!", Translation.EncodeToUtf16(" пробудился!"), 2);
        }
    }
    
    public class WormyFoodIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.WormyFood.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.WormyFood").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.WormyFood").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Eater of Worlds", Translation.EncodeToUtf16("Пожиратель миров"));
    }
    
    public class BatteredClubIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.BatteredClub.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.BatteredClub").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.BatteredClub").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Ogre", Translation.EncodeToUtf16("Огр"));
    }
    
    public class BetsyEggIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.BetsyEgg.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.BetsyEgg").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.BetsyEgg").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Betsy", Translation.EncodeToUtf16("Бетси"));
    }
    
    public class FestiveOrnamentIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.FestiveOrnament.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.FestiveOrnament").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.FestiveOrnament").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Everscream", Translation.EncodeToUtf16("Злая ель"));
    }
    
    public class ForbiddenTomeIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.ForbiddenTome.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.ForbiddenTome").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.ForbiddenTome").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Dark Mage", Translation.EncodeToUtf16("Тёмный маг"));
    }
    
    public class HeadofManIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.HeadofMan.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.HeadofMan").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.HeadofMan").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Headless Horseman", Translation.EncodeToUtf16("Всадник без головы"));
    }
    
    public class IceKingsRemainsIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.IceKingsRemains.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.IceKingsRemains").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.IceKingsRemains").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Ice Queen", Translation.EncodeToUtf16("Ледяная королева"));
    }
    
    public class MartianMemoryStickIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.MartianMemoryStick.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.MartianMemoryStick").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.MartianMemoryStick").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Martian Saucer", Translation.EncodeToUtf16("Летающая тарелка марсиан"));
    }
    
    public class NaughtyListIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.NaughtyList.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.NaughtyList").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.NaughtyList").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Santa-NK1", Translation.EncodeToUtf16("Санта-НК1"));
    }
    
    public class SpookyBranchIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.SpookyBranch.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.SpookyBranch").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.SpookyBranch").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Mourning Wood", Translation.EncodeToUtf16("Плакучий древень"));
    }
    
    public class SuspiciousLookingScytheIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abom.SuspiciousLookingScythe.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.SuspiciousLookingScythe").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.SuspiciousLookingScythe").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Pumpking", Translation.EncodeToUtf16("Тыквенный король"));
    }
    
    public class AthenianIdolIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.AthenianIdol.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.AthenianIdol").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.AthenianIdol").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Medusa", Translation.EncodeToUtf16("Медуза"));
    }
    
    public class AttractiveOreIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.AttractiveOre.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.AttractiveOre").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.AttractiveOre").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Undead Miner", Translation.EncodeToUtf16("Скелет-шахтёр"));
    }
    
    public class CloudSnackIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.CloudSnack.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CloudSnack").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CloudSnack").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Wyvern", Translation.EncodeToUtf16("Виверна"));
    }
    
    public class ClownLicenseIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.ClownLicense.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ClownLicense").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ClownLicense").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Clown", Translation.EncodeToUtf16("Клоун"));
    }
    
    public class CoreoftheFrostCoreIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.CoreoftheFrostCore.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CoreoftheFrostCore").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CoreoftheFrostCore").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Ice Golem", Translation.EncodeToUtf16("Ледяной голем"));
    }
    
    public class CorruptChestIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.CorruptChest.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CorruptChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CorruptChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Corrupt Mimic", Translation.EncodeToUtf16("Искажённый мимик"));
    }
    
    public class CrimsonChestIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.CrimsonChest.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CrimsonChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CrimsonChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Crimson Mimic", Translation.EncodeToUtf16("Багряный мимик"));
    }
    
    public class DilutedRainbowMatterIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.DilutedRainbowMatter.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.DilutedRainbowMatter").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.DilutedRainbowMatter").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Rainbow Slime", Translation.EncodeToUtf16("Радужный слизень"));
    }
    
    public class EggplantIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.Eggplant.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.Eggplant").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.Eggplant").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Doctor Bones", Translation.EncodeToUtf16("Доктор Боунс"));
    }
    
    public class ForbiddenForbiddenFragmentIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.ForbiddenForbiddenFragment.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ForbiddenForbiddenFragment").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ForbiddenForbiddenFragment").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Sand Elemental", Translation.EncodeToUtf16("Песчаный элементаль"));
    }
    
    public class GrandCrossIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.GrandCross.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.GrandCross").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.GrandCross").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Paladin", Translation.EncodeToUtf16("Паладин"));
    }
    
    public class HallowChestIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.HallowChest.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HallowChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HallowChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Hallowed Mimic", Translation.EncodeToUtf16("Освящённый мимик"));
    }
    
    public class HeartChocolateIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.HeartChocolate.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HeartChocolate").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HeartChocolate").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Nymph", Translation.EncodeToUtf16("Нимфа"));
    }
    
    public class HolyGrailIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.HolyGrail.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HolyGrail").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HolyGrail").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Tim", Translation.EncodeToUtf16("Тим"));
    }
    
    public class InnocuousSkullIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.InnocuousSkull.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.InnocuousSkull").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.InnocuousSkull").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Baby Guardian", Translation.EncodeToUtf16("Маленький страж"));
    }
    
    public class JungleChestIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.JungleChest.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.JungleChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.JungleChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Jungle Mimic", Translation.EncodeToUtf16("Мимик джунглей"));
    }
    
    public class LeesHeadbandIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.LeesHeadband.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.LeesHeadband").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.LeesHeadband").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Bone Lee", Translation.EncodeToUtf16("Костюс Ли"));
    }
    
    public class MothLampIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.MothLamp.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.MothLamp").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.MothLamp").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Moth", Translation.EncodeToUtf16("Мотылёк"));
    }
    
    public class MothronEggIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.MothronEgg.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.MothronEgg").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.MothronEgg").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Mothron", Translation.EncodeToUtf16("Мотрон"));
    }
    
    public class PinkSlimeCrownIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.PinkSlimeCrown.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PinkSlimeCrown").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PinkSlimeCrown").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Pinky", Translation.EncodeToUtf16("Пинки"));
    }
    
    public class PirateFlagIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.PirateFlag.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PirateFlag").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PirateFlag").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Pirate Captain", Translation.EncodeToUtf16("Капитан пиратов"));
    }
    
    public class PlunderedBootyIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.PlunderedBooty.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PlunderedBooty").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PlunderedBooty").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Flying Dutchman", Translation.EncodeToUtf16("Летучий голландец"));
    }
    
    public class RuneOrbIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.RuneOrb.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.RuneOrb").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.RuneOrb").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Rune Wizard", Translation.EncodeToUtf16("Рунический маг"));
    }
    
    public class ShadowflameIconIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.ShadowflameIcon.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ShadowflameIcon").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ShadowflameIcon").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Goblin Summoner", Translation.EncodeToUtf16("Гоблин-призыватель"));
    }
    
    public class SlimyLockBoxIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.SlimyLockBox.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.SlimyLockBox").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.SlimyLockBox").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Dungeon Slime", Translation.EncodeToUtf16("Слизень темницы"));
    }
    
    public class SuspiciousLookingChestIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.SuspiciousLookingChest.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.SuspiciousLookingChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.SuspiciousLookingChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Mimic", Translation.EncodeToUtf16("Мимик"));
    }
    
    public class WormSnackIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Deviantt.WormSnack.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.WormSnack").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.WormSnack").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il)
        {
            Translation.ILTranslate(il, "Digger", Translation.EncodeToUtf16("Землекоп"));
            Translation.ILTranslate(il, "Giant Worm", Translation.EncodeToUtf16("Гигантский червь"));
        }
    }
    
    public class CultistSummonIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Mutant.CultistSummon.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.CultistSummon").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.CultistSummon").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Lunatic Cultist", Translation.EncodeToUtf16("Культист-лунатик"));
    }
    
    public class PlanterasFruitIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Mutant.PlanterasFruit.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.PlanterasFruit").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.PlanterasFruit").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Plantera", Translation.EncodeToUtf16("Плантера"));
    }
    
    public class Abeemination2IL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.Abeemination2.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abeemination2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abeemination2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Queen Bee", Translation.EncodeToUtf16("Королева пчёл"));
    }
    
    public class CelestialSigil2IL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.CelestialSigil2.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.CelestialSigil2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.CelestialSigil2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Moon Lord", Translation.EncodeToUtf16("Лунный лорд"));
    }
    
    public class GoreySpineIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.GoreySpine.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.GoreySpine").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.GoreySpine").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Brain of Cthulhu", Translation.EncodeToUtf16("Мозг Ктулху"));
    }
    
    public class LihzahrdPowerCell2IL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.VanillaCopy.LihzahrdPowerCell2.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.VanillaCopy.LihzahrdPowerCell2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.VanillaCopy.LihzahrdPowerCell2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Golem", Translation.EncodeToUtf16("Голем"));
    }
    
    public class MechSkullIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.MechSkull.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.MechSkull").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.MechSkull").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Skeletron Prime", Translation.EncodeToUtf16("Скелетрон Прайм"));
    }
    
    public class MechWormIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.MechWorm.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.MechWorm").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.MechWorm").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "The Destroyer", Translation.EncodeToUtf16("Разрушитель"));
    }
    
    public class SlimyCrownIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SlimyCrown.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SlimyCrown").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SlimyCrown").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "King Slime", Translation.EncodeToUtf16("Король слизней"));
    }
    
    public class SuspiciousEyeIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SuspiciousEye.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SuspiciousEye").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.SuspiciousEye").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Eye of Cthulhu", Translation.EncodeToUtf16("Глаз Ктулху"));
    }
    
    public class TruffleWorm2IL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.TruffleWorm2.get_NPCName";
        
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.TruffleWorm2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Summons.TruffleWorm2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => Translation.ILTranslate(il, "Duke Fishron", Translation.EncodeToUtf16("Герцог Рыброн"));
    }
    
    public class StatsFargoIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Misc.Stats.ModifyTooltips";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null ;

        public override void Load()
        {
            IL.Fargowiltas.Items.Misc.Stats.ModifyTooltips += TranslationModifyTooltipsHook;
        }

        public override void Unload()
        {
            IL.Fargowiltas.Items.Misc.Stats.ModifyTooltips -= TranslationModifyTooltipsHook;
        }

        private void TranslationModifyTooltipsHook(ILContext il)
        {
            Translation.ILTranslate(il, "Melee Damage: {0}%", Translation.EncodeToUtf16("Урон ближнего боя: {0}%"));
            Translation.ILTranslate(il, "Melee Speed: {0}%", Translation.EncodeToUtf16("Скорость атаки ближнего боя: {0}%"));
            Translation.ILTranslate(il, "Melee Crit: {0}%", Translation.EncodeToUtf16("Шанс критического удара ближнего боя: {0}%"));
            Translation.ILTranslate(il, "Ranged Damage: {0}%", Translation.EncodeToUtf16("Стрелковый урон: {0}%"));
            Translation.ILTranslate(il, "Ranged Crit: {0}%", Translation.EncodeToUtf16("Стрелковый шанс критического удара: {0}%"));
            Translation.ILTranslate(il, "Magic Damage: {0}%", Translation.EncodeToUtf16("Магический урон: {0}%"));
            Translation.ILTranslate(il, "Magic Crit: {0}%", Translation.EncodeToUtf16("Магический шанс критического удара: {0}%"));
            Translation.ILTranslate(il, "Summon Damage: {0}%", Translation.EncodeToUtf16("Урон миньонов: {0}%"));
            Translation.ILTranslate(il, "Max Minions: {0}", Translation.EncodeToUtf16("Максимальное число миньонов: {0}"));
            Translation.ILTranslate(il, "Max Sentries: {0}", Translation.EncodeToUtf16("Максимальное число турелей: {0}"));
            Translation.ILTranslate(il, "Damage Reduction: {0}%", Translation.EncodeToUtf16("Сопротивление урону: {0}%"));
            Translation.ILTranslate(il, "Life Regen: {0} HP/second",Translation.EncodeToUtf16("Регенерация здоровья: {0} здоровья/сек"));
            Translation.ILTranslate(il, "Armor Pen: {0}", Translation.EncodeToUtf16("Пробивание брони: {0}"));
            Translation.ILTranslate(il, "Max Speed: {0} mph", Translation.EncodeToUtf16("Максимальная скорость: {0} км/ч"));
            Translation.ILTranslate(il, "Wing Time: {0} seconds", Translation.EncodeToUtf16("Время полёта: {0} сек"));
        }
    }
    
     public class StatsThoriumIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Misc.Stats.ThoriumStats";
        
        private event ILContext.Manipulator ThoriumStatsHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Misc.Stats").GetMethod("ThoriumStats", BindingFlags.NonPublic | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.Items.Misc.Stats").GetMethod("ThoriumStats", BindingFlags.NonPublic | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null && CoreThoriumTranslation.ThoriumMod != null;

        public override void Load()
        {
            ThoriumStatsHook += TranslationThoriumStatsHook;
        }

        public override void Unload()
        {
            ThoriumStatsHook -= TranslationThoriumStatsHook;
        }

        private void TranslationThoriumStatsHook(ILContext il)
        {
            Translation.ILTranslate(il, "Symphonic Damage: {0}%", Translation.EncodeToUtf16("Симфонический урон: {0}%"));
            Translation.ILTranslate(il, "Symphonic Speed: {0}%", Translation.EncodeToUtf16("Симфоническая скорость атаки: {0}%"));
            Translation.ILTranslate(il, "Symphonic Crit: {0}%", Translation.EncodeToUtf16("Симфонический шанс критического удара: {0}%"));
            Translation.ILTranslate(il, "Inspiration Regen: {0}%", Translation.EncodeToUtf16("Регенарация вдохновения: {0}%"));
            Translation.ILTranslate(il, "Empowerment Duration: {0} seconds", Translation.EncodeToUtf16("Длительность усиления: {0} сек"));
            Translation.ILTranslate(il, "Radiant Damage: {0}%", Translation.EncodeToUtf16("Лучезарный урон: {0}%"));
            Translation.ILTranslate(il, "Radiant Speed: {0}%", Translation.EncodeToUtf16("Лучезарная скорость атаки: {0}%"));
            Translation.ILTranslate(il, "Healing Speed: {0}%", Translation.EncodeToUtf16("Скорость лечения: {0}%"));
            Translation.ILTranslate(il, "Radiant Crit: {0}%", Translation.EncodeToUtf16("Лучезарный шанс критического удара: {0}%"));
            Translation.ILTranslate(il, "Bonus Healing: {0}", Translation.EncodeToUtf16("Бонусное лечение: {0}"));
        }
    }
    
    public class AbominationnIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.NPCs.Abominationn";

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load()
        {
            IL.Fargowiltas.NPCs.Abominationn.SetChatButtons += TranslationSetChatButtonsHook;
            IL.Fargowiltas.NPCs.Abominationn.OnChatButtonClicked += TranslationOnChatButtonClickedHook;
        }

        public override void Unload()
        {
            IL.Fargowiltas.NPCs.Abominationn.SetChatButtons -= TranslationSetChatButtonsHook;
            IL.Fargowiltas.NPCs.Abominationn.OnChatButtonClicked -= TranslationOnChatButtonClickedHook;
        }

        private void TranslationSetChatButtonsHook(ILContext il) => Translation.ILTranslate(il, "Cancel Event", Translation.EncodeToUtf16("Остановить событие"));
        
        private void TranslationOnChatButtonClickedHook(ILContext il)
        {
            Translation.ILTranslate(il, "The event has been cancelled!", Translation.EncodeToUtf16("Событие было остановлено!"));
            Translation.ILTranslate(il, "Hocus pocus, the event is over.", Translation.EncodeToUtf16("Фокус-покус, событие кончилось."));
        }
    }
    
    public class DevianttIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.NPCs.Deviantt.SetChatButtons";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.NPCs.Deviantt.SetChatButtons += TranslationSetChatButtonsHook;

        public override void Unload() => IL.Fargowiltas.NPCs.Deviantt.SetChatButtons -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il)
        {
            Translation.ILTranslate(il, "Help", Translation.EncodeToUtf16("Помощь"));
            Translation.ILTranslate(il, "Receive Gift", Translation.EncodeToUtf16("Получить подарок"));
        }
    }
    
    public class FargoGlobalNPCIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.NPCs.FargoGlobalNPC";
        
        private event ILContext.Manipulator SwarmHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.FargoGlobalNPC").GetMethod("Swarm", BindingFlags.NonPublic | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasTranslation.Fargo.Code.GetType("Fargowiltas.NPCs.FargoGlobalNPC").GetMethod("Swarm", BindingFlags.NonPublic | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load()
        {
            IL.Fargowiltas.NPCs.FargoGlobalNPC.CheckDead += TranslationCheckDeadHook;
            SwarmHook += TranslationSwarmHook;
        }

        public override void Unload()
        {
            IL.Fargowiltas.NPCs.FargoGlobalNPC.CheckDead -= TranslationCheckDeadHook;
            SwarmHook -= TranslationSwarmHook;
        }

        private void TranslationCheckDeadHook(ILContext il) => Translation.ILTranslate(il, "Betsy has been defeated!", Translation.EncodeToUtf16("Бетси была побеждена!"));
        
        private void TranslationSwarmHook(ILContext il)
        {
            Translation.ILTranslate(il, "Killed: ", Translation.EncodeToUtf16("Убито: "));
            Translation.ILTranslate(il, "Killed: ", Translation.EncodeToUtf16("Убито: "), 2);
            Translation.ILTranslate(il, "Total: ", Translation.EncodeToUtf16("Всего: "));
            Translation.ILTranslate(il, "Total: ", Translation.EncodeToUtf16("Всего: "), 2);
            Translation.ILTranslate(il, "The swarm has been defeated!", Translation.EncodeToUtf16("Орда была побеждена!"));
            Translation.ILTranslate(il, "The swarm has been defeated!", Translation.EncodeToUtf16("Орда была побеждена!"), 2);
        }
    }
    
    public class FargowiltasIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Fargowiltas";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load()
        {
            IL.Fargowiltas.Fargowiltas.PostSetupContent += TranslationPostSetupContentHook;
            IL.Fargowiltas.Fargowiltas.HandlePacket += TranslationHandlePacketHook;
        }

        public override void Unload()
        {
            IL.Fargowiltas.Fargowiltas.PostSetupContent -= TranslationPostSetupContentHook;
            IL.Fargowiltas.Fargowiltas.HandlePacket -= TranslationHandlePacketHook;
        }

        private void TranslationPostSetupContentHook(ILContext il)
        {
            Translation.ILTranslate(il, "Defeat any rare enemy or... embrace eternity", Translation.EncodeToUtf16("Одолейте любого редкого врага или... примите вечность"));
            Translation.ILTranslate(il, "Defeat any boss or miniboss", Translation.EncodeToUtf16("Одолейте любого босса или мини-босса"));
            Translation.ILTranslate(il, "Chop down enough trees", Translation.EncodeToUtf16("Срубите достаточно деревьев"));
            Translation.ILTranslate(il, "Clear any event", Translation.EncodeToUtf16("Пройдите любое событие"));
            Translation.ILTranslate(il, "Have a Top Hat Squirrel ([i:{0}]) in your inventory", Translation.EncodeToUtf16("Положите в инвентарь белку в цилиндре ([i:{0}])"));
        }

        private void TranslationHandlePacketHook(ILContext il) => Translation.ILTranslate(il, "The event has been cancelled!", Translation.EncodeToUtf16("Событие было остановлено!"));
    }
    
    public class LumberJackIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.NPCs.LumberJack.SetChatButtons";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.NPCs.LumberJack.SetChatButtons += TranslationSetChatButtonsHook;

        public override void Unload() => IL.Fargowiltas.NPCs.LumberJack.SetChatButtons -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il) => Translation.ILTranslate(il, "Tree Treasures", Translation.EncodeToUtf16("Древесные сокровища"));
    }
    
    public class MutantIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.NPCs.Mutant.SetChatButtons";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;

        public override void Load() => IL.Fargowiltas.NPCs.Mutant.SetChatButtons += TranslationSetChatButtonsHook;

        public override void Unload() => IL.Fargowiltas.NPCs.Mutant.SetChatButtons -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il)
        {
            Translation.ILTranslate(il, "Pre Hardmode", Translation.EncodeToUtf16("Прехардмод"));
            Translation.ILTranslate(il, "Hardmode", Translation.EncodeToUtf16("Хардмод"));
            Translation.ILTranslate(il, "Post Moon Lord", Translation.EncodeToUtf16("Пост-Лунный лорд"));
            Translation.ILTranslate(il, "Cycle Shop", Translation.EncodeToUtf16("Переключить магазин"));
        }
    }
    
    public class OverloadBeeIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadBee.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadBee.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadBee.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il)
        {
            Translation.ILTranslate(il, "A deafening buzz pierces through you!", Translation.EncodeToUtf16("Оглушающее жжужание пронзает ваши уши!"));
        }
    }
    
    public class OverloadBetsyIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadBetsy.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadBetsy.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadBetsy.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "The real Old One's Army is attacking!", Translation.EncodeToUtf16("Истинная армия Древних атакует!"));
    }
    
    public class OverloadBrainIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadBrain.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadBrain.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadBrain.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "You feel dumb among so many brains!", Translation.EncodeToUtf16("Количество мозгов вокруг заставляет вас чуствовать себя тупым!"));
    }
    
    public class OverloadCultistIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadCultist.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadCultist.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadCultist.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "Defeaning chants fill your ears!", Translation.EncodeToUtf16("Оглушающие песнопения переполняют ваш слух!"));
    }
    
    public class OverloadDestroyerIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadDestroyer.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadDestroyer.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadDestroyer.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "The planet trembles from the core!", Translation.EncodeToUtf16("Земля дрожит!"));
    }
    
    public class OverloadEyeIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadEye.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadEye.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadEye.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "Countless eyes pierce the veil staring in your direction!", Translation.EncodeToUtf16("Вы ощущаете бесчисленные взгляды на себе!"));
    }
    
    public class OverloadFishIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadFish.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadFish.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadFish.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "The ocean swells with ferocious pigs!", Translation.EncodeToUtf16("Свирепые свиньи наполняют океан!"));
    }
    
    public class OverloadGolemIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadGolem.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadGolem.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadGolem.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "Ancient automatons come crashing down!", Translation.EncodeToUtf16("Древние конструкции обрушиваются на вас!"));
    }
    
    public class OverloadMoonIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadMoon.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadMoon.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadMoon.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "The wind whispers of death's approach!", Translation.EncodeToUtf16("Ветер шепчет о приближающейся смерти!"));
    }
    
    public class OverloadPlantIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadPlant.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadPlant.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadPlant.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "The jungle beats as one!", Translation.EncodeToUtf16("Джунгли бьются как одно целое!"));
    }
    
    public class OverloadPrimeIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadPrime.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadPrime.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadPrime.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "A sickly chill envelops the world!", Translation.EncodeToUtf16("Мерзкий холод окутывает мир!"));
    }
    
    public class OverloadSkeleIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadSkele.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadSkele.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadSkele.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "A great clammering of bones rises from the dungeon!", Translation.EncodeToUtf16("Огромные груды костей восстают из темницы!"));
    }
    
    public class OverloadSlimeCrownIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadSlimeCrown.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadSlimeCrown.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadSlimeCrown.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "Welcome to the true slime rain!", Translation.EncodeToUtf16("Добро пожаловать в истинный дождь слизней!"));
    }
    
    public class OverloadTwinsIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadTwins.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadTwins.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadTwins.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "A legion of glowing iris sing a dreadful song!", Translation.EncodeToUtf16("Полчища светящихся глаз поют зловещую песню!"));
    }
    
    public class OverloadWallIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadWall.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadWall.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadWall.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "A fortress of flesh arises from the depths!", Translation.EncodeToUtf16("Крепость плоти возникает из глубин!"));
    }
    
    public class OverloadWormIL : ILEdit
    {
        public override string DictKey => "Fargowiltas.Items.Summons.SwarmSummons.OverloadWorm.ctor";
        
        public override bool Autoload() => CoreFargowiltasTranslation.Fargo != null;
    
        public override void Load() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadWorm.ctor += TranslationCtorHook;
    
        public override void Unload() => IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadWorm.ctor -= TranslationCtorHook;
    
        private void TranslationCtorHook(ILContext il) => Translation.ILTranslate(il, "The ground shifts with formulated precision!", Translation.EncodeToUtf16("Земля под вашими ногами раздвигается с удивительной точностью!"));
    }
}