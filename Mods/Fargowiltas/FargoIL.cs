using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using IL.Fargowiltas.Items.Misc;
using IL.Fargowiltas.Items.Summons.Abom;
using IL.Fargowiltas.Items.Summons.Mutant;
using IL.Fargowiltas.Items.Summons.SwarmSummons;
using IL.Fargowiltas.Items.Summons.SwarmSummons.Thorium;
using IL.Fargowiltas.NPCs;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;

namespace CalamityRuTranslate.Mods.Fargowiltas
{
    public class BattleCryIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => BattleCry.UseItem += TranslationUseItemHook;

        public override void Unload() => BattleCry.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Spawn rates ", TranslationUtils.EncodeToUtf16("Скорость появления врагов "));
            TranslationUtils.ILTranslate(il, "increased!", TranslationUtils.EncodeToUtf16("увеличена!"));
            TranslationUtils.ILTranslate(il, "decreased!", TranslationUtils.EncodeToUtf16("снижена!"));
        }
    }

    public class ExpertToggleIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => ExpertToggle.UseItem += TranslationUseItemHook;

        public override void Unload() => ExpertToggle.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Expert mode is now enabled!", TranslationUtils.EncodeToUtf16("Режим эксперта теперь включён!"));
            TranslationUtils.ILTranslate(il, "Expert mode is now disabled!", TranslationUtils.EncodeToUtf16("Режим эксперта теперь отключён!"));
        }
    }

    public class CursedSextantIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => CursedSextant.UseItem += TranslationUseItemHook;

        public override void Unload() => CursedSextant.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il) => TranslationUtils.ILTranslate(il, "The Blood Moon is rising...", TranslationUtils.EncodeToUtf16("Кровавая луна восходит..."));
    }

    public class ForbiddenScarabIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => ForbiddenScarab.UseItem += TranslationUseItemHook;

        public override void Unload() => ForbiddenScarab.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il) => TranslationUtils.ILTranslate(il, "A sandstorm has begun.", TranslationUtils.EncodeToUtf16("Началась песчаная буря."));
    }

    public class PartyConeIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => PartyCone.UseItem += TranslationUseItemHook;

        public override void Unload() => PartyCone.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il) => TranslationUtils.ILTranslate(il, "Looks like someone's throwing a Party!", TranslationUtils.EncodeToUtf16("Похоже, кто-то закатывает вечеринку!"));
    }

    public class PillarSummonIL : ILEdit
    {
        private event ILContext.Manipulator ShootHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.PillarSummon").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.PillarSummon").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => ShootHook += TranslationShootHook;

        public override void Unload() => ShootHook -= TranslationShootHook;

        private void TranslationShootHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "The Celestial Pillars have awoken!", TranslationUtils.EncodeToUtf16("Небесные башни пробудились!"));
            TranslationUtils.ILTranslate(il, "The Celestial Pillars have awoken!", TranslationUtils.EncodeToUtf16("Небесные башни пробудились!"), 2);
        }
    }

    public class WeatherBalloonIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => WeatherBalloon.UseItem += TranslationUseItemHook;

        public override void Unload() => WeatherBalloon.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il) => TranslationUtils.ILTranslate(il, "Rain clouds cover the sky.", TranslationUtils.EncodeToUtf16("Тучи закрывают небо."));
    }

    public class AncientSealIL : ILEdit
    {
        private event ILContext.Manipulator ShootHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.AncientSeal").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.AncientSeal").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            ShootHook += TranslationShootHook;
            AncientSeal.SpawnBoss += TranslationSpawnBossHook;
        }

        public override void Unload()
        {
            ShootHook -= TranslationShootHook;
            AncientSeal.SpawnBoss -= TranslationSpawnBossHook;
        }

        private void TranslationShootHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Every boss has awoken!", TranslationUtils.EncodeToUtf16("Все боссы пробудились!"));
            TranslationUtils.ILTranslate(il, "Every boss has awoken!", TranslationUtils.EncodeToUtf16("Все боссы пробудились!"), 2);
        }

        private void TranslationSpawnBossHook(ILContext il) => TranslationUtils.ILTranslate(il, " has awoken!", TranslationUtils.EncodeToUtf16(" пробудился!"));
    }

    public class DeathBringerFairyIL : ILEdit
    {
        private event ILContext.Manipulator ShootHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.DeathBringerFairy").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.DeathBringerFairy").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => ShootHook += TranslationShootHook;

        public override void Unload() => ShootHook -= TranslationShootHook;

        private void TranslationShootHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Several bosses have awoken!", TranslationUtils.EncodeToUtf16("Несколько боссов пробудились!"));
            TranslationUtils.ILTranslate(il, "Several bosses have awoken!", TranslationUtils.EncodeToUtf16("Несколько боссов пробудились!"), 2);
        }
    }

    public class MutantVoodooIL : ILEdit
    {
        private event ILContext.Manipulator ShootHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.MutantVoodoo").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.MutantVoodoo").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => ShootHook += TranslationShootHook;

        public override void Unload() => ShootHook -= TranslationShootHook;

        private void TranslationShootHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Several bosses have awoken!",
                TranslationUtils.EncodeToUtf16("Несколько боссов пробудились!"));
            TranslationUtils.ILTranslate(il, "Several bosses have awoken!",
                TranslationUtils.EncodeToUtf16("Несколько боссов пробудились!"), 2);
        }
    }

    public class SuspiciousSkullIL : ILEdit
    {
        private event ILContext.Manipulator ShootHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.SuspiciousSkull").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.SuspiciousSkull").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => ShootHook += TranslationShootHook;

        public override void Unload() => ShootHook -= TranslationShootHook;

        private void TranslationShootHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Skeletron has awoken!", TranslationUtils.EncodeToUtf16("Скелетрон пробудился!"));
            TranslationUtils.ILTranslate(il, "Skeletron has awoken!", TranslationUtils.EncodeToUtf16("Скелетрон пробудился!"), 2);
            TranslationUtils.ILTranslate(il, "Dungeon Guardian has awoken!", TranslationUtils.EncodeToUtf16("Страж темницы пробудился!"));
            TranslationUtils.ILTranslate(il, "Dungeon Guardian has awoken!", TranslationUtils.EncodeToUtf16("Страж темницы пробудился!"), 2);
        }
    }

    public class OverloadCoznixIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadCoznix.UseItem += TranslationUseItemHook;

        public override void Unload() => OverloadCoznix.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "The gates of hell have opened wide!", TranslationUtils.EncodeToUtf16("Врата ада распахнулись!"));
            TranslationUtils.ILTranslate(il, "The gates of hell have opened wide!", TranslationUtils.EncodeToUtf16("Врата ада распахнулись!"), 2);
        }
    }

    public class OverloadJellyIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadJelly.UseItem += TranslationUseItemHook;

        public override void Unload() => OverloadJelly.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "National Jelly Day has arrived!", TranslationUtils.EncodeToUtf16("Наступил национальный день желе!"));
            TranslationUtils.ILTranslate(il, "National Jelly Day has arrived!", TranslationUtils.EncodeToUtf16("Наступил национальный день желе!"), 2);
        }
    }

    public class OverloadLichIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadLich.UseItem += TranslationUseItemHook;

        public override void Unload() => OverloadLich.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Death is in the air!", TranslationUtils.EncodeToUtf16("Смерть витает в воздухе!"));
            TranslationUtils.ILTranslate(il, "Death is in the air!", TranslationUtils.EncodeToUtf16("Смерть витает в воздухе!"), 2);
        }
    }

    public class OverloadSaucerIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadSaucer.UseItem += TranslationUseItemHook;

        public override void Unload() => OverloadSaucer.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Invaders have arrived!", TranslationUtils.EncodeToUtf16("Произошло вторжение!"));
            TranslationUtils.ILTranslate(il, "Invaders have arrived!", TranslationUtils.EncodeToUtf16("Произошло вторжение!"), 2);
        }
    }

    public class OverloadStriderIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadStrider.UseItem += TranslationUseItemHook;

        public override void Unload() => OverloadStrider.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "A wave of frozen air begins howling!", TranslationUtils.EncodeToUtf16("Морозный ветер завывает!"));
            TranslationUtils.ILTranslate(il, "A wave of frozen air begins howling!", TranslationUtils.EncodeToUtf16("Морозный ветер завывает!"), 2);
        }
    }

    public class OverloadThunderbirdIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadThunderbird.UseItem += TranslationUseItemHook;

        public override void Unload() => OverloadThunderbird.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Electricity fills the air!", TranslationUtils.EncodeToUtf16("Электричество наполняет воздух!"));
            TranslationUtils.ILTranslate(il, "Electricity fills the air!", TranslationUtils.EncodeToUtf16("Электричество наполняет воздух!"), 2);
        }
    }

    public class OverloadFrostMoonIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadFrostMoon.UseItem += TranslationUseItemHook;

        public override void Unload() => OverloadFrostMoon.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "The Frost Moon fades away!", TranslationUtils.EncodeToUtf16("Морозная луна исчезает!"));
            TranslationUtils.ILTranslate(il, "The Frost Moon fades away!", TranslationUtils.EncodeToUtf16("Морозная луна исчезает!"), 2);
            TranslationUtils.ILTranslate(il, "The Frost Moon is rising...", TranslationUtils.EncodeToUtf16("Восходит морозная луна..."));
            TranslationUtils.ILTranslate(il, "The Frost Moon is rising...", TranslationUtils.EncodeToUtf16("Восходит морозная луна..."), 2);
            TranslationUtils.ILTranslate(il, "Wave: 20: Everything", TranslationUtils.EncodeToUtf16("Волна 20: Все"));
            TranslationUtils.ILTranslate(il, "Wave: 20: Everything", TranslationUtils.EncodeToUtf16("Волна 20: Все"), 2);
        }
    }

    public class OverloadGoblinsIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadGoblins.UseItem += TranslationUseItemHook;

        public override void Unload() => OverloadGoblins.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "The goblins have calmed down!", TranslationUtils.EncodeToUtf16("Гоблины успокоились!"));
            TranslationUtils.ILTranslate(il, "The goblins have calmed down!", TranslationUtils.EncodeToUtf16("Гоблины успокоились!"), 2);
        }
    }

    public class OverloadMartiansIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadMartians.UseItem += TranslationUseItemHook;

        public override void Unload() => OverloadMartians.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "The martians have calmed down!", TranslationUtils.EncodeToUtf16("Марсиане успокоились!"));
            TranslationUtils.ILTranslate(il, "The martians have calmed down!", TranslationUtils.EncodeToUtf16("Марсиане успокоились!"), 2);
        }
    }

    public class OverloadPiratesIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadPirates.UseItem += TranslationUseItemHook;

        public override void Unload() => OverloadPirates.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "The pirates have calmed down!", TranslationUtils.EncodeToUtf16("Пираты успокоились!"));
            TranslationUtils.ILTranslate(il, "The pirates have calmed down!", TranslationUtils.EncodeToUtf16("Пираты успокоились!"), 2);
        }
    }

    public class OverloadPumpkinMoonIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadPumpkinMoon.UseItem += TranslationUseItemHook;

        public override void Unload() => OverloadPumpkinMoon.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "The Pumpkin Moon fades away!", TranslationUtils.EncodeToUtf16("Тыквенная луна исчезает!"));
            TranslationUtils.ILTranslate(il, "The Pumpkin Moon fades away!", TranslationUtils.EncodeToUtf16("Тыквенная луна исчезает!"), 2);
            TranslationUtils.ILTranslate(il, "The Pumpkin Moon is rising...", TranslationUtils.EncodeToUtf16("Восходит тыквенная луна..."));
            TranslationUtils.ILTranslate(il, "The Pumpkin Moon is rising...", TranslationUtils.EncodeToUtf16("Восходит тыквенная луна..."), 2);
            TranslationUtils.ILTranslate(il, "Wave: 15: Everything", TranslationUtils.EncodeToUtf16("Волна 15: Все"));
            TranslationUtils.ILTranslate(il, "Wave: 15: Everything", TranslationUtils.EncodeToUtf16("Волна 15: Все"), 2);
        }
    }

    public class BaseSummonIL : ILEdit
    {
        private event ILContext.Manipulator ShootHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.BaseSummon").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.BaseSummon").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => ShootHook += TranslationShootHook;

        public override void Unload() => ShootHook -= TranslationShootHook;

        private void TranslationShootHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, " has awoken!", TranslationUtils.EncodeToUtf16(" пробудился!"));
            TranslationUtils.ILTranslate(il, " has awoken!", TranslationUtils.EncodeToUtf16(" пробудился!"), 2);
        }
    }

    public class WormyFoodIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.WormyFood").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.WormyFood").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }


        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Eater of Worlds", TranslationUtils.EncodeToUtf16("Пожиратель миров"));
    }

    public class BatteredClubIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.BatteredClub").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.BatteredClub").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Ogre", TranslationUtils.EncodeToUtf16("Огр"));
    }

    public class BetsyEggIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.BetsyEgg").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.BetsyEgg").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Betsy", TranslationUtils.EncodeToUtf16("Бетси"));
    }

    public class FestiveOrnamentIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.FestiveOrnament").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.FestiveOrnament").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Everscream", TranslationUtils.EncodeToUtf16("Злая ель"));
    }

    public class ForbiddenTomeIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.ForbiddenTome").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.ForbiddenTome").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Dark Mage", TranslationUtils.EncodeToUtf16("Тёмный маг"));
    }

    public class HeadofManIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.HeadofMan").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.HeadofMan").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Headless Horseman", TranslationUtils.EncodeToUtf16("Всадник без головы"));
    }

    public class IceKingsRemainsIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.IceKingsRemains").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.IceKingsRemains").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Ice Queen", TranslationUtils.EncodeToUtf16("Ледяная королева"));
    }

    public class MartianMemoryStickIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.MartianMemoryStick").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.MartianMemoryStick").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }


        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Martian Saucer", TranslationUtils.EncodeToUtf16("Летающая тарелка марсиан"));
    }

    public class NaughtyListIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.NaughtyList").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.NaughtyList").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }


        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Santa-NK1", TranslationUtils.EncodeToUtf16("Санта-НК1"));
    }

    public class SpookyBranchIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.SpookyBranch").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.SpookyBranch").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Mourning Wood", TranslationUtils.EncodeToUtf16("Плакучий древень"));
    }

    public class SuspiciousLookingScytheIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.SuspiciousLookingScythe").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abom.SuspiciousLookingScythe").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Pumpking", TranslationUtils.EncodeToUtf16("Тыквенный король"));
    }

    public class AthenianIdolIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.AthenianIdol").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.AthenianIdol").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Medusa", TranslationUtils.EncodeToUtf16("Медуза"));
    }

    public class AttractiveOreIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.AttractiveOre").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.AttractiveOre").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }


        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Undead Miner", TranslationUtils.EncodeToUtf16("Скелет-шахтёр"));
    }

    public class CloudSnackIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CloudSnack").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CloudSnack").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }


        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Wyvern", TranslationUtils.EncodeToUtf16("Виверна"));
    }

    public class ClownLicenseIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ClownLicense").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ClownLicense").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Clown", TranslationUtils.EncodeToUtf16("Клоун"));
    }

    public class CoreoftheFrostCoreIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CoreoftheFrostCore").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CoreoftheFrostCore").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Ice Golem", TranslationUtils.EncodeToUtf16("Ледяной голем"));
    }

    public class CorruptChestIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CorruptChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CorruptChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Corrupt Mimic", TranslationUtils.EncodeToUtf16("Искажённый мимик"));
    }

    public class CrimsonChestIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CrimsonChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.CrimsonChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Crimson Mimic", TranslationUtils.EncodeToUtf16("Багряный мимик"));
    }

    public class DilutedRainbowMatterIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.DilutedRainbowMatter").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.DilutedRainbowMatter").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Rainbow Slime", TranslationUtils.EncodeToUtf16("Радужный слизень"));
    }

    public class EggplantIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.Eggplant").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.Eggplant").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }


        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Doctor Bones", TranslationUtils.EncodeToUtf16("Доктор Боунс"));
    }

    public class ForbiddenForbiddenFragmentIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ForbiddenForbiddenFragment").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ForbiddenForbiddenFragment").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Sand Elemental", TranslationUtils.EncodeToUtf16("Песчаный элементаль"));
    }

    public class GrandCrossIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.GrandCross").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.GrandCross").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Paladin", TranslationUtils.EncodeToUtf16("Паладин"));
    }

    public class HallowChestIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HallowChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HallowChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Hallowed Mimic", TranslationUtils.EncodeToUtf16("Освящённый мимик"));
    }

    public class HeartChocolateIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HeartChocolate").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HeartChocolate").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Nymph", TranslationUtils.EncodeToUtf16("Нимфа"));
    }

    public class HolyGrailIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HolyGrail").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.HolyGrail").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Tim", TranslationUtils.EncodeToUtf16("Тим"));
    }

    public class InnocuousSkullIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.InnocuousSkull").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.InnocuousSkull").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Baby Guardian", TranslationUtils.EncodeToUtf16("Маленький страж"));
    }

    public class JungleChestIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.JungleChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.JungleChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Jungle Mimic", TranslationUtils.EncodeToUtf16("Мимик джунглей"));
    }

    public class LeesHeadbandIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.LeesHeadband").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.LeesHeadband").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Bone Lee", TranslationUtils.EncodeToUtf16("Костюс Ли"));
    }

    public class MothLampIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.MothLamp").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.MothLamp").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Moth", TranslationUtils.EncodeToUtf16("Мотылёк"));
    }

    public class MothronEggIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.MothronEgg").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.MothronEgg").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Mothron", TranslationUtils.EncodeToUtf16("Мотрон"));
    }

    public class PinkSlimeCrownIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PinkSlimeCrown").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PinkSlimeCrown").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Pinky", TranslationUtils.EncodeToUtf16("Пинки"));
    }

    public class PirateFlagIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PirateFlag").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PirateFlag").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Pirate Captain", TranslationUtils.EncodeToUtf16("Капитан пиратов"));
    }

    public class PlunderedBootyIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PlunderedBooty").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.PlunderedBooty").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Flying Dutchman", TranslationUtils.EncodeToUtf16("Летучий голландец"));
    }

    public class RuneOrbIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.RuneOrb").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.RuneOrb").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Rune Wizard", TranslationUtils.EncodeToUtf16("Рунический маг"));
    }

    public class ShadowflameIconIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ShadowflameIcon").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.ShadowflameIcon").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Goblin Summoner", TranslationUtils.EncodeToUtf16("Гоблин-призыватель"));
    }

    public class SlimyLockBoxIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.SlimyLockBox").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.SlimyLockBox").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Dungeon Slime", TranslationUtils.EncodeToUtf16("Слизень темницы"));
    }

    public class SuspiciousLookingChestIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.SuspiciousLookingChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.SuspiciousLookingChest").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Mimic", TranslationUtils.EncodeToUtf16("Мимик"));
    }

    public class WormSnackIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.WormSnack").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Deviantt.WormSnack").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Digger", TranslationUtils.EncodeToUtf16("Землекоп"));
            TranslationUtils.ILTranslate(il, "Giant Worm", TranslationUtils.EncodeToUtf16("Гигантский червь"));
        }
    }

    public class CultistSummonIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.CultistSummon").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.CultistSummon").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Lunatic Cultist", TranslationUtils.EncodeToUtf16("Культист-лунатик"));
    }

    public class PlanterasFruitIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.PlanterasFruit").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Mutant.PlanterasFruit").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Plantera", TranslationUtils.EncodeToUtf16("Плантера"));
    }

    public class Abeemination2IL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abeemination2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.Abeemination2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Queen Bee", TranslationUtils.EncodeToUtf16("Королева пчёл"));
    }

    public class CelestialSigil2IL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.CelestialSigil2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.CelestialSigil2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Moon Lord", TranslationUtils.EncodeToUtf16("Лунный лорд"));
    }

    public class GoreySpineIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.GoreySpine").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.GoreySpine").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Brain of Cthulhu", TranslationUtils.EncodeToUtf16("Мозг Ктулху"));
    }

    public class LihzahrdPowerCell2IL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.VanillaCopy.LihzahrdPowerCell2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.VanillaCopy.LihzahrdPowerCell2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Golem", TranslationUtils.EncodeToUtf16("Голем"));
    }

    public class MechSkullIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.MechSkull").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.MechSkull").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Skeletron Prime", TranslationUtils.EncodeToUtf16("Скелетрон Прайм"));
    }

    public class MechWormIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.MechWorm").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.MechWorm").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "The Destroyer", TranslationUtils.EncodeToUtf16("Разрушитель"));
    }

    public class SlimyCrownIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.SlimyCrown").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.SlimyCrown").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "King Slime", TranslationUtils.EncodeToUtf16("Король слизней"));
    }

    public class SuspiciousEyeIL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.SuspiciousEye").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.SuspiciousEye").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Eye of Cthulhu", TranslationUtils.EncodeToUtf16("Глаз Ктулху"));
    }

    public class TruffleWorm2IL : ILEdit
    {
        private event ILContext.Manipulator NPCNameHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.TruffleWorm2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Summons.TruffleWorm2").GetMethod("get_NPCName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NPCNameHook += TranslationNPCNameHook;

        public override void Unload() => NPCNameHook -= TranslationNPCNameHook;

        private void TranslationNPCNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "Duke Fishron", TranslationUtils.EncodeToUtf16("Герцог Рыброн"));
    }

    public class StatsFargoIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => Stats.ModifyTooltips += TranslationModifyTooltipsHook;

        public override void Unload() => Stats.ModifyTooltips -= TranslationModifyTooltipsHook;

        private void TranslationModifyTooltipsHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Melee Damage: {0}%", TranslationUtils.EncodeToUtf16("Урон ближнего боя: {0}%"));
            TranslationUtils.ILTranslate(il, "Melee Speed: {0}%", TranslationUtils.EncodeToUtf16("Скорость атаки ближнего боя: {0}%"));
            TranslationUtils.ILTranslate(il, "Melee Crit: {0}%", TranslationUtils.EncodeToUtf16("Шанс критического удара ближнего боя: {0}%"));
            TranslationUtils.ILTranslate(il, "Ranged Damage: {0}%", TranslationUtils.EncodeToUtf16("Стрелковый урон: {0}%"));
            TranslationUtils.ILTranslate(il, "Ranged Crit: {0}%", TranslationUtils.EncodeToUtf16("Стрелковый шанс критического удара: {0}%"));
            TranslationUtils.ILTranslate(il, "Magic Damage: {0}%", TranslationUtils.EncodeToUtf16("Магический урон: {0}%"));
            TranslationUtils.ILTranslate(il, "Magic Crit: {0}%", TranslationUtils.EncodeToUtf16("Магический шанс критического удара: {0}%"));
            TranslationUtils.ILTranslate(il, "Summon Damage: {0}%", TranslationUtils.EncodeToUtf16("Урон миньонов: {0}%"));
            TranslationUtils.ILTranslate(il, "Max Minions: {0}", TranslationUtils.EncodeToUtf16("Максимальное число миньонов: {0}"));
            TranslationUtils.ILTranslate(il, "Max Sentries: {0}", TranslationUtils.EncodeToUtf16("Максимальное число турелей: {0}"));
            TranslationUtils.ILTranslate(il, "Damage Reduction: {0}%", TranslationUtils.EncodeToUtf16("Сопротивление урону: {0}%"));
            TranslationUtils.ILTranslate(il, "Life Regen: {0} HP/second",TranslationUtils.EncodeToUtf16("Регенерация здоровья: {0} здоровья/сек"));
            TranslationUtils.ILTranslate(il, "Armor Pen: {0}", TranslationUtils.EncodeToUtf16("Пробивание брони: {0}"));
            TranslationUtils.ILTranslate(il, "Max Speed: {0} mph", TranslationUtils.EncodeToUtf16("Максимальная скорость: {0} км/ч"));
            TranslationUtils.ILTranslate(il, "Wing Time: {0} seconds", TranslationUtils.EncodeToUtf16("Время полёта: {0} сек"));
        }
    }

    public class StatsThoriumIL : ILEdit
    {
        private event ILContext.Manipulator ThoriumStatsHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Misc.Stats").GetMethod("ThoriumStats", BindingFlags.NonPublic | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.Items.Misc.Stats").GetMethod("ThoriumStats", BindingFlags.NonPublic | BindingFlags.Instance), value);
        }


        public override bool Autoload() => ModsCall.Fargo != null && ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => ThoriumStatsHook += TranslationThoriumStatsHook;

        public override void Unload() => ThoriumStatsHook -= TranslationThoriumStatsHook;

        private void TranslationThoriumStatsHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Symphonic Damage: {0}%", TranslationUtils.EncodeToUtf16("Симфонический урон: {0}%"));
            TranslationUtils.ILTranslate(il, "Symphonic Speed: {0}%", TranslationUtils.EncodeToUtf16("Симфоническая скорость атаки: {0}%"));
            TranslationUtils.ILTranslate(il, "Symphonic Crit: {0}%", TranslationUtils.EncodeToUtf16("Симфонический шанс критического удара: {0}%"));
            TranslationUtils.ILTranslate(il, "Inspiration Regen: {0}%", TranslationUtils.EncodeToUtf16("Регенарация вдохновения: {0}%"));
            TranslationUtils.ILTranslate(il, "Empowerment Duration: {0} seconds", TranslationUtils.EncodeToUtf16("Длительность усиления: {0} сек"));
            TranslationUtils.ILTranslate(il, "Radiant Damage: {0}%", TranslationUtils.EncodeToUtf16("Лучезарный урон: {0}%"));
            TranslationUtils.ILTranslate(il, "Radiant Speed: {0}%", TranslationUtils.EncodeToUtf16("Лучезарная скорость атаки: {0}%"));
            TranslationUtils.ILTranslate(il, "Healing Speed: {0}%", TranslationUtils.EncodeToUtf16("Скорость лечения: {0}%"));
            TranslationUtils.ILTranslate(il, "Radiant Crit: {0}%", TranslationUtils.EncodeToUtf16("Лучезарный шанс критического удара: {0}%"));
            TranslationUtils.ILTranslate(il, "Bonus Healing: {0}", TranslationUtils.EncodeToUtf16("Бонусное лечение: {0}"));
        }
    }

    public class AbominationnIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            Abominationn.SetChatButtons += TranslationSetChatButtonsHook;
            Abominationn.OnChatButtonClicked += TranslationOnChatButtonClickedHook;
        }

        public override void Unload()
        {
            Abominationn.SetChatButtons -= TranslationSetChatButtonsHook;
            Abominationn.OnChatButtonClicked -= TranslationOnChatButtonClickedHook;
        }

        private void TranslationSetChatButtonsHook(ILContext il) => TranslationUtils.ILTranslate(il, "Cancel Event", TranslationUtils.EncodeToUtf16("Остановить событие"));

        private void TranslationOnChatButtonClickedHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "The event has been cancelled!", TranslationUtils.EncodeToUtf16("Событие было остановлено!"));
            TranslationUtils.ILTranslate(il, "Hocus pocus, the event is over.", TranslationUtils.EncodeToUtf16("Фокус-покус, событие кончилось."));
        }
    }

    public class DevianttIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => Deviantt.SetChatButtons += TranslationSetChatButtonsHook;

        public override void Unload() => Deviantt.SetChatButtons -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Help", TranslationUtils.EncodeToUtf16("Помощь"));
            TranslationUtils.ILTranslate(il, "Receive Gift", TranslationUtils.EncodeToUtf16("Получить подарок"));
        }
    }

    public class FargoGlobalNPCIL : ILEdit
    {
        private event ILContext.Manipulator SwarmHook
        {
            add => HookEndpointManager.Modify(ModsCall.Fargo.Code.GetType("Fargowiltas.NPCs.FargoGlobalNPC").GetMethod("Swarm", BindingFlags.NonPublic | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Fargo.Code.GetType("Fargowiltas.NPCs.FargoGlobalNPC").GetMethod("Swarm", BindingFlags.NonPublic | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            FargoGlobalNPC.CheckDead += TranslationCheckDeadHook;
            SwarmHook += TranslationSwarmHook;
        }

        public override void Unload()
        {
            FargoGlobalNPC.CheckDead -= TranslationCheckDeadHook;
            SwarmHook -= TranslationSwarmHook;
        }

        private void TranslationCheckDeadHook(ILContext il) => TranslationUtils.ILTranslate(il, "Betsy has been defeated!", TranslationUtils.EncodeToUtf16("Бетси была побеждена!"));

        private void TranslationSwarmHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Killed: ", TranslationUtils.EncodeToUtf16("Убито: "));
            TranslationUtils.ILTranslate(il, "Killed: ", TranslationUtils.EncodeToUtf16("Убито: "), 2);
            TranslationUtils.ILTranslate(il, "Total: ", TranslationUtils.EncodeToUtf16("Всего: "));
            TranslationUtils.ILTranslate(il, "Total: ", TranslationUtils.EncodeToUtf16("Всего: "), 2);
            TranslationUtils.ILTranslate(il, "The swarm has been defeated!", TranslationUtils.EncodeToUtf16("Орда была побеждена!"));
            TranslationUtils.ILTranslate(il, "The swarm has been defeated!", TranslationUtils.EncodeToUtf16("Орда была побеждена!"), 2);
        }
    }

    public class FargowiltasIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

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
            TranslationUtils.ILTranslate(il, "Defeat any rare enemy or... embrace eternity", TranslationUtils.EncodeToUtf16("Одолейте любого редкого врага или... примите вечность"));
            TranslationUtils.ILTranslate(il, "Defeat any boss or miniboss", TranslationUtils.EncodeToUtf16("Одолейте любого босса или мини-босса"));
            TranslationUtils.ILTranslate(il, "Chop down enough trees", TranslationUtils.EncodeToUtf16("Срубите достаточно деревьев"));
            TranslationUtils.ILTranslate(il, "Clear any event", TranslationUtils.EncodeToUtf16("Пройдите любое событие"));
            TranslationUtils.ILTranslate(il, "Have a Top Hat Squirrel ([i:{0}]) in your inventory", TranslationUtils.EncodeToUtf16("Положите в инвентарь белку в цилиндре ([i:{0}])"));
        }

        private void TranslationHandlePacketHook(ILContext il) => TranslationUtils.ILTranslate(il,
            "The event has been cancelled!", TranslationUtils.EncodeToUtf16("Событие было остановлено!"));
    }

    public class LumberJackIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => LumberJack.SetChatButtons += TranslationSetChatButtonsHook;

        public override void Unload() => LumberJack.SetChatButtons -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il) => TranslationUtils.ILTranslate(il, "Tree Treasures", TranslationUtils.EncodeToUtf16("Древесные сокровища"));
    }

    public class MutantIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => Mutant.SetChatButtons += TranslationSetChatButtonsHook;

        public override void Unload() => Mutant.SetChatButtons -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Pre Hardmode", TranslationUtils.EncodeToUtf16("Прехардмод"));
            TranslationUtils.ILTranslate(il, "Hardmode", TranslationUtils.EncodeToUtf16("Хардмод"));
            TranslationUtils.ILTranslate(il, "Post Moon Lord", TranslationUtils.EncodeToUtf16("Пост-Лунный лорд"));
            TranslationUtils.ILTranslate(il, "Cycle Shop", TranslationUtils.EncodeToUtf16("Переключить магазин"));
        }
    }

    public class OverloadBeeIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadBee.ctor += TranslationCtorHook;

        public override void Unload() => OverloadBee.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "A deafening buzz pierces through you!", TranslationUtils.EncodeToUtf16("Оглушающее жжужание пронзает ваши уши!"));
    }

    public class OverloadBetsyIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadBetsy.ctor += TranslationCtorHook;

        public override void Unload() => OverloadBetsy.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "The real Old One's Army is attacking!", TranslationUtils.EncodeToUtf16("Истинная армия Древних атакует!"));
    }

    public class OverloadBrainIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadBrain.ctor += TranslationCtorHook;

        public override void Unload() => OverloadBrain.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "You feel dumb among so many brains!", TranslationUtils.EncodeToUtf16("Количество мозгов вокруг заставляет вас чуствовать себя тупым!"));
    }

    public class OverloadCultistIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadCultist.ctor += TranslationCtorHook;

        public override void Unload() => OverloadCultist.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "Defeaning chants fill your ears!", TranslationUtils.EncodeToUtf16("Оглушающие песнопения переполняют ваш слух!"));
    }

    public class OverloadDestroyerIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadDestroyer.ctor += TranslationCtorHook;

        public override void Unload() => OverloadDestroyer.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "The planet trembles from the core!", TranslationUtils.EncodeToUtf16("Земля дрожит!"));
    }

    public class OverloadEyeIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadEye.ctor += TranslationCtorHook;

        public override void Unload() => OverloadEye.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "Countless eyes pierce the veil staring in your direction!", TranslationUtils.EncodeToUtf16("Вы ощущаете бесчисленные взгляды на себе!"));
    }

    public class OverloadFishIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadFish.ctor += TranslationCtorHook;

        public override void Unload() => OverloadFish.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "The ocean swells with ferocious pigs!", TranslationUtils.EncodeToUtf16("Свирепые свиньи наполняют океан!"));
    }

    public class OverloadGolemIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadGolem.ctor += TranslationCtorHook;

        public override void Unload() => OverloadGolem.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "Ancient automatons come crashing down!", TranslationUtils.EncodeToUtf16("Древние конструкции обрушиваются на вас!"));
    }

    public class OverloadMoonIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadMoon.ctor += TranslationCtorHook;

        public override void Unload() => OverloadMoon.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "The wind whispers of death's approach!", TranslationUtils.EncodeToUtf16("Ветер шепчет о приближающейся смерти!"));
    }

    public class OverloadPlantIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadPlant.ctor += TranslationCtorHook;

        public override void Unload() => OverloadPlant.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "The jungle beats as one!", TranslationUtils.EncodeToUtf16("Джунгли бьются как одно целое!"));
    }

    public class OverloadPrimeIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadPrime.ctor += TranslationCtorHook;

        public override void Unload() => OverloadPrime.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "A sickly chill envelops the world!", TranslationUtils.EncodeToUtf16("Мерзкий холод окутывает мир!"));
    }

    public class OverloadSkeleIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadSkele.ctor += TranslationCtorHook;

        public override void Unload() => OverloadSkele.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "A great clammering of bones rises from the dungeon!", TranslationUtils.EncodeToUtf16("Огромные груды костей восстают из темницы!"));
    }

    public class OverloadSlimeCrownIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadSlimeCrown.ctor += TranslationCtorHook;

        public override void Unload() => OverloadSlimeCrown.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "Welcome to the true slime rain!", TranslationUtils.EncodeToUtf16("Добро пожаловать в истинный дождь слизней!"));
    }

    public class OverloadTwinsIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadTwins.ctor += TranslationCtorHook;

        public override void Unload() => OverloadTwins.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "A legion of glowing iris sing a dreadful song!", TranslationUtils.EncodeToUtf16("Полчища светящихся глаз поют зловещую песню!"));
    }

    public class OverloadWallIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadWall.ctor += TranslationCtorHook;

        public override void Unload() => OverloadWall.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "A fortress of flesh arises from the depths!", TranslationUtils.EncodeToUtf16("Крепость плоти возникает из глубин!"));
    }

    public class OverloadWormIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OverloadWorm.ctor += TranslationCtorHook;

        public override void Unload() => OverloadWorm.ctor -= TranslationCtorHook;

        private void TranslationCtorHook(ILContext il) => TranslationUtils.ILTranslate(il, "The ground shifts with formulated precision!", TranslationUtils.EncodeToUtf16("Земля под вашими ногами раздвигается с удивительной точностью!"));
    }
}