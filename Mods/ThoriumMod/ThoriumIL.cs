using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;
using ThoriumMod;
using ThoriumMod.Empowerments;
using ThoriumMod.Contracts;
using ThoriumMod.Items;
using ThoriumMod.NPCs;
using ThoriumMod.Tiles;

namespace CalamityRuTranslate.Mods.ThoriumMod
{
    public class AquaticAbilityIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(AquaticAbility).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(AquaticAbility).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "% underwater breath & speed", "% подводного дыхания и скорости");
    }
    
    public class AttackSpeedIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(AttackSpeed).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(AttackSpeed).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "% attack speed", "% скорости атаки");
    }
    
    public class CriticalStrikeChanceIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(CriticalStrikeChance).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(CriticalStrikeChance).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "% critical strike chance", "% шанс критического удара");
    }
    
    public class DamageIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(Damage).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(Damage).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "% damage", "% урона");
    }
    
    public class DamageReductionIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(DamageReduction).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(DamageReduction).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "% damage reduction", "% сопротивление урону");
    }
    
    public class DefenseIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(Defense).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(Defense).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, " defense", " защиты");
    }
    
    public class EmpowermentProlongationIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(EmpowermentProlongation).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(EmpowermentProlongation).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, " second", " секунда");
            TranslationUtils.ILTranslate(il, " seconds", " секунды");
        }
    }
    
    public class FlatDamageIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(FlatDamage).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(FlatDamage).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, " flat damage", " фиксированого урона");
    }
    
    public class FlightTimeIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(FlightTime).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(FlightTime).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "% flight time", "% времени полёта");
    }
    
    public class InvincibilityFramesIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(InvincibilityFrames).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(InvincibilityFrames).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "  sec. of after hit invincibility", " сек. неуязвимости");
    }
    
    public class JumpHeightIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(JumpHeight).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(JumpHeight).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, " block of jump height", " блока высоты прыжка");
    }
    
    public class LifeRegenerationIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(LifeRegeneration).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(LifeRegeneration).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, " life/sec", " здоровья/сек");
    }
    
    public class MovementSpeedIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(MovementSpeed).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MovementSpeed).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "% base and bonus movement speed", "% базовой и дополнительной скорости передвижения");
    }
    
    public class ResourceConsumptionChanceIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(ResourceConsumptionChance).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ResourceConsumptionChance).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "% chance to not consume resource", "% шанс не использовать ресурс");
    }
    
    public class ResourceGrabRangeIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(ResourceGrabRange).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ResourceGrabRange).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, " resource item grab range", " дальность захвата предметов");
    }

    public class ResourceMaximumIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(ResourceMaximum).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ResourceMaximum).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "% maximum resource", " максимума ресурсов");
    }

    public class ResourceRegenIL : ILEdit
    {
        private event ILContext.Manipulator GetCombatTextHook
        {
            add => HookEndpointManager.Modify(typeof(ResourceRegen).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ResourceRegen).GetMethod("GetCombatText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetCombatTextHook += TranslationGetCombatTextHook;

        public override void Unload() => GetCombatTextHook -= TranslationGetCombatTextHook;

        private void TranslationGetCombatTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "% resource regeneration", "% регенерации ресурсов");
    }

    public class WeakReferencesHandlerIL : ILEdit
    {
        private event ILContext.Manipulator DoBossChecklistSupportHook
        {
            add => HookEndpointManager.Modify(ModsCall.Thorium.Code.GetType("ThoriumMod.ModSupport.WeakReferencesHandler").GetMethod("DoBossChecklistSupport", BindingFlags.NonPublic | BindingFlags.Static), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Thorium.Code.GetType("ThoriumMod.ModSupport.WeakReferencesHandler").GetMethod("DoBossChecklistSupport", BindingFlags.NonPublic | BindingFlags.Static), value);
        }

        private event ILContext.Manipulator DoCensusModSupportHook
        {
            add => HookEndpointManager.Modify(ModsCall.Thorium.Code.GetType("ThoriumMod.ModSupport.WeakReferencesHandler").GetMethod("DoCensusModSupport", BindingFlags.NonPublic | BindingFlags.Static), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Thorium.Code.GetType("ThoriumMod.ModSupport.WeakReferencesHandler").GetMethod("DoCensusModSupport", BindingFlags.NonPublic | BindingFlags.Static), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            DoBossChecklistSupportHook += TranslationDoBossChecklistSupportHook;
            DoCensusModSupportHook += TranslationDoCensusModSupportHook;
        }

        public override void Unload()
        {
            DoBossChecklistSupportHook -= TranslationDoBossChecklistSupportHook;
            DoCensusModSupportHook -= TranslationDoCensusModSupportHook;
        }

        private void TranslationDoBossChecklistSupportHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "The Grand Thunder Bird", "Великая гром-птица");
            TranslationUtils.ILTranslate(il, "Use a [i:", "Используйте [i:");
            TranslationUtils.ILTranslate(il, "] with [i:", "] с [i:");
            TranslationUtils.ILTranslate(il, "] during the day in the Desert.", "] днём в пустыне.");
            TranslationUtils.ILTranslate(il, "Patch Werk", "Лоскутик");
            TranslationUtils.ILTranslate(il, "Randomly appears during the Blood Moon. Start the Blood Moon with a [i:", "Случайно появляется во время кровавой луны. Начните кровавую луну используя [i:");
            TranslationUtils.ILTranslate(il, "The Queen Jellyfish", "Королева медуз");
            TranslationUtils.ILTranslate(il, "Use a [i:", "Используйте [i:", 2);
            TranslationUtils.ILTranslate(il, "] during the day at the Ocean.", "] днём в океане.");
            TranslationUtils.ILTranslate(il, "Viscount", "Виконт");
            TranslationUtils.ILTranslate(il, "Use 5 [i:", "Используйте 5 [i:");
            TranslationUtils.ILTranslate(il, "] at an underground Blood Chamber. Use a [i:", "] в поздемной кровавой камере. Используйте [i:");
            TranslationUtils.ILTranslate(il, "] to track down the Blood Chamber.", "] чтобы найти кровавую камеру.");
            TranslationUtils.ILTranslate(il, "Corpse Bloom", "Трупоцвет");
            TranslationUtils.ILTranslate(il, "Randomly appears in the post-Skeletron underground jungle.", "Случайно появляется в подземных джунглях после убийства Скелетрона.");
            TranslationUtils.ILTranslate(il, "Illusionist", "Иллюзионист");
            TranslationUtils.ILTranslate(il, "Randomly appears in the Dungeon.", "Случайно появляется в темнице.");
            TranslationUtils.ILTranslate(il, "Granite Energy Storm", "Гранитный энергетический шторм");
            TranslationUtils.ILTranslate(il, "Use a [i:", "Используйте [i:", 3);
            TranslationUtils.ILTranslate(il, "] deep underground within a Granite Enclosure or find and defeat an Unstable Energy Anomaly.", "] глубоко под землёй в гранитных пещерах или найдите и одолейте Нестабильную энергетическую аномалию");
            TranslationUtils.ILTranslate(il, "Buried Champion", "Погребённый чемпион");
            TranslationUtils.ILTranslate(il, "Use a [i:", "Используйте [i:", 4);
            TranslationUtils.ILTranslate(il, "] deep underground within a Marble Enclosure or find and defeat a Bizarre Rock Formation.", "] глубоко под землёй в мраморных пещерах или найдите и одолейте Причудливую горную породу");
            TranslationUtils.ILTranslate(il, "Star Scouter", "Звёздный разведчик");
            TranslationUtils.ILTranslate(il, "Use a [i:", "Используйте [i:", 5);
            TranslationUtils.ILTranslate(il, "] high in the sky.", "] высоко в небе.");
            TranslationUtils.ILTranslate(il, "Borean Strider", "Борейский странник");
            TranslationUtils.ILTranslate(il, "Randomly appears during a Blizzard or summoned with a [i:", "Случайно появляется во время метели или вызывается [i:");
            TranslationUtils.ILTranslate(il, "Coznix, the Fallen Beholder", "Козникс, падший Созерцатель");
            TranslationUtils.ILTranslate(il, "Use a [i:", "Используйте [i:", 6);
            TranslationUtils.ILTranslate(il, "] within the Underworld.", "] в аду.");
            TranslationUtils.ILTranslate(il, "The Lich", "Лич");
            TranslationUtils.ILTranslate(il, "Use a [i:", "Используйте [i:", 7);
            TranslationUtils.ILTranslate(il, "] during the Night.", "] ночью.");
            TranslationUtils.ILTranslate(il, "Abyssion, the Forgotten One", "Абиссион, Забытый");
            TranslationUtils.ILTranslate(il, "Pick up 3 [i:", "Поднимите 3 [i:");
            TranslationUtils.ILTranslate(il, "], which are dropped by Aquatic Hallucinations in the Aquatic Depths.", "], которые падают с Морской иллюзии в акватических глубинах.");
            TranslationUtils.ILTranslate(il, "The Primordials", "Вечные");
            TranslationUtils.ILTranslate(il, "Use a [i:", "Используйте [i:", 8);
            TranslationUtils.ILTranslate(il, "] and prepare for the worst...", "] и готовьтесь к худшему...");
        }

        private void TranslationDoCensusModSupportHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Have any kind of basic mushroom in your inventory ([i/s1:5][i/s1:183][i/s1:60][i/s1:2887])", "Положите в инвентарь любой из этих грибов ([i/s1:5][i/s1:183][i/s1:60][i/s1:2887])");
            TranslationUtils.ILTranslate(il, "Have any kind of non-cobbler boot accessory equipped or in your inventory ([i/s1:285][i/s1:54][i/s1:128][i/s1:863] etc.)", "Экипируйте или положите в инвентарь любой из этих предметов ([i/s1:285][i/s1:54][i/s1:128][i/s1:863] и т.д.)");
            TranslationUtils.ILTranslate(il, "Defeat the [c/4dffb8:Grand Thunder Bird]", "Одолейте [c/4dffb8:Великую гром-птицу]");
            TranslationUtils.ILTranslate(il, "Defeat [c/4dffb8:Patchwerk] during a Blood Moon", "Одолейте [c/4dffb8:Лоскутика] в кровавую луну");
            TranslationUtils.ILTranslate(il, "Defeat the Eye of Cthulhu", "Одолейте Глаз Ктулху");
            TranslationUtils.ILTranslate(il, "Defeat the Eye of Cthulhu", "Одолейте Глаз Ктулху", 2);
            TranslationUtils.ILTranslate(il, "Defeat the [c/4dffb8:Queen Jellyfish]", "Одолейте [c/4dffb8:Королеву медуз]");
            TranslationUtils.ILTranslate(il, "Defeat [c/4dffb8:Corpse Bloom] in the post-Skeletron Jungle", "Одолейте [c/4dffb8:Трупоцвет] в джунглях после убийства Скелетрона");
            TranslationUtils.ILTranslate(il, "Defeat the [c/4dffb8:Buried Champion]", "Одолейте [c/4dffb8:Погребённого чемпиона]");
            TranslationUtils.ILTranslate(il, "Defeat the [c/4dffb8:Fallen Beholder]", "Одолейте [c/4dffb8:Падшего Созерцателя]");
        }
    }

    public class ThoriumModIL : ILEdit
    {
        private event ILContext.Manipulator DisplayDRShieldIconHook
        {
            add => HookEndpointManager.Modify(ModsCall.Thorium.Code.GetType("ThoriumMod.ThoriumMod").GetMethod("DisplayDRShieldIcon", BindingFlags.NonPublic | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Thorium.Code.GetType("ThoriumMod.ThoriumMod").GetMethod("DisplayDRShieldIcon", BindingFlags.NonPublic | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator DisplayHealerIconHook
        {
            add => HookEndpointManager.Modify(ModsCall.Thorium.Code.GetType("ThoriumMod.ThoriumMod").GetMethod("DisplayHealerIcon", BindingFlags.NonPublic | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Thorium.Code.GetType("ThoriumMod.ThoriumMod").GetMethod("DisplayHealerIcon", BindingFlags.NonPublic | BindingFlags.Instance), value);
        }
        
        private event ILContext.Manipulator DisplayBardIconHook
        {
            add => HookEndpointManager.Modify(ModsCall.Thorium.Code.GetType("ThoriumMod.ThoriumMod").GetMethod("DisplayBardIcon", BindingFlags.NonPublic | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Thorium.Code.GetType("ThoriumMod.ThoriumMod").GetMethod("DisplayBardIcon", BindingFlags.NonPublic | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            DisplayDRShieldIconHook += TranslationDisplayDRShieldIconHook;
            DisplayHealerIconHook += TranslationDisplayHealerIconHook;
            DisplayBardIconHook += TranslationDisplayBardIconHook;
        }

        public override void Unload()
        {
            DisplayDRShieldIconHook -= TranslationDisplayDRShieldIconHook;
            DisplayHealerIconHook -= TranslationDisplayHealerIconHook;
            DisplayBardIconHook -= TranslationDisplayBardIconHook;
        }

        private void TranslationDisplayDRShieldIconHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Total: ", "Всего: ");
            TranslationUtils.ILTranslate(il, "% Damage Reduction\nVanilla: ", "% сопротивления урону\nВанилла: ");
            TranslationUtils.ILTranslate(il, "%\nThorium: ", "%\nТориум: ");
            TranslationUtils.ILTranslate(il, "% Before Cap)", "% до предела)");
        }

        private void TranslationDisplayHealerIconHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, ":Healer Stats]\nCurrent Bonus Healing: ", ":Характеристики целителя]\nТекущее бонусное лечение: ");
            TranslationUtils.ILTranslate(il, "\nBest Heal Streak: ", "\nЛучшая серия лечения: ");
            TranslationUtils.ILTranslate(il, "\nHealing done: ", "\nИсцелений: ");
            TranslationUtils.ILTranslate(il, "\nDamage mitigated: ", "\nПредотвращено урона: ");
            TranslationUtils.ILTranslate(il, "\nLives saved: ", "\nЖизней спасено: ");
            TranslationUtils.ILTranslate(il, "\nClose calls: ", "\nНа волоске: ");
        }

        private void TranslationDisplayBardIconHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, ":Bard Stats]\nBonus Duration: ", ":Характеристики барда]\nДополнительная длительность: ");
            TranslationUtils.ILTranslate(il, " sec(s)\nMax-Use Duration: +", " сек.\nМаксимальная длительность: +");
            TranslationUtils.ILTranslate(il, "%\nBase Inspiration: ", "%\nБазовое вдохновение: ");
            TranslationUtils.ILTranslate(il, "\nBonus Inspiration: ", "\nДополнительное вдохновение: ");
            // TranslationUtils.ILTranslate(il, "\nTimed Hits: ", "\n: ");
        }
    }

    public class AlmostContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(AlmostContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(AlmostContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(AlmostContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(AlmostContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "To Be Continued...", "Продолжение следует...");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "Complete all other contracts to continue...", "Сначала завершите все оставшиеся контракты...");
    }

    public class BoneLeeContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(BoneLeeContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(BoneLeeContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(BoneLeeContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(BoneLeeContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Tracker's End", "Конец Охотника");

        private void TranslationGetDescriptionHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "I've got a personal contract for you, kid. I don't ask this of you lightly, so please hear me out. Years ago, me and my partner, Lee, would take on the world together. We were an unstoppable duo, but made the grave error of underestimating a particularly difficult contract. In a desperate attempt to save me, he was struck down within the Dungeon halls where he surely rots. I've never forgiven myself for what happened... Please, go into the Dungeon and put his tortured soul to rest.", "Парень, у меня есть для тебя особый контракт. Ты должен взяться за это всерьёз, так что выслушай меня. Много лет назад, я и мой друг Ли исследовали мир вместе. Мы были неудержимы, но допустили смертельную ошибку - недооценили один особенно сложный контракт. В отчаянной попытке спасти меня он был скинут в залы Темницы, где он, скорее всего, гниёт до сих пор. Я никогда не прощу себя за это... Пожалуйста, отправься в Темницу и дай его измученной душе отдых.");
            TranslationUtils.ILTranslate(il, "You've done me a favor I could never repay in a thousand lifetimes. What I would give to apologize to Lee face to face... I'm confident, that at this point, you've surpassed any strength we thought we possessed. It's sobering to be humbled by an upstart like you, kid. As a reward, I've got a collection of weapons Lee would often use. I'm sure he would be honored if you wielded them in battle. Take care out there!", "Ты оказал мне услугу, которую я не смогу отплатить и за тысячу жизней. Я бы всё отдал, что бы попрощаться с Ли лицом к лицу... Я уверен, что к этому моменту ты уже превзошёл нас в силе. Это отрезвляюще - быть оскорбленным таким выскочкой, как ты. В награду, у меня есть коллекция оружия, которое Ли часто использовал. Уверен, он был бы почтён, если бы ты орудовал ими в бою. Береги себя!");
        }
    }

    public class CursedContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(CursedContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(CursedContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(CursedContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(CursedContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Enchanted Engagement", "Зачарованное вовлечение");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "I'm sure you've seen that unregulated spirit magic can lead to a lot of things, such as possessed weapons and armor. That prospect alone is terrifying, but when powerful artifacts are possessed, things can get ugly... Keep your eyes peeled for aggressive Enchanted weapons deep underground.", "Я уверен ты наблюдал, что неконтролируемая духовная магия может привести к разным последствиям, например, к одержимости брони или оружия. Сама перспектива этого уже ужасающая, но когда мощные артефакты становятся одержимыми, дела могут стать ещё хуже... Смотри в оба за наличием агрессивных заколдованных орудий в подземельях.");
    }

    public class DoctorContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(DoctorContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(DoctorContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(DoctorContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(DoctorContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Arc of the Lost Raider", "Ковчег заплутавшего Расхитителя");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "Many adventurers have braved the intense foliage of the jungle, but even fewer return. I sent a friend of mine, Doctor Bones, out on a mission to the jungle quite a while ago, but he hasn't returned... Could you go check out the jungle's surface at night and see if you can find any signs of him?", "Многие путешественники смогли пройти сквозь густые заросли джунглей, но лишь немногие вернулись. Я послал своего друга, Доктора Бонса, на миссию в джунгли довольно давно, но он так и не вернулся... Не мог бы ты посетить и обследовать поверхность джунглей ночью и найти хоть какие-то его следы?");
    }

    public class GildedContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(GildedContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(GildedContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(GildedContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(GildedContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Pay Day", "Час расплаты");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "Radiant beasts have been spotted prowling underground Terraria, illuminating a path of ruin. The Gilded Bat, Gilded Lycan and Gilded Slime light up their surrounding area and pack quite a punch. It would be best if their numbers dwindled, even just a little...", "Недавно в подземельях Террарии были замечены лучезарные твари, освещающие свой путь разрушений. Позолоченная летучая мышь, слизень и ликан подсвечивают окружающую местность и бьют довольно сильно. Будет намного лучше, если их число упадёт, даже немного.");
    }

    public class HagContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(HagContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(HagContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(HagContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(HagContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Haggard Hagglers", "Измодждённый торгаш");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "Many try to take shortcuts in their quest for power, often calling upon the elements for their boon. But while the elements can provide what they seek, it comes with a hefty price. There exists beings known as Hags that roam the world looking to steal back their traded youth. The Underworld, Jungle, Ocean, and Sky are the most likely spots to find one. Do us a favor and take one out.", "Многие пробуют сэкономить время в погоне за силой, зачастую взывая к элементам для своей же выгоды. Хоть элементы и могут предоставить то, что от них просят, это будет стоить многого. Существуют Ведьмы, которые бродят по миру в поисках своей утерянной молодости, которую они хотят украсть обратно. Они обычно встречаются в аду, джунглях, океане и на небесах. Сделай нам одолжение - убей одну из них.");
    }

    public class HardmodeContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(HardmodeContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(HardmodeContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(HardmodeContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(HardmodeContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "To Be Continued...", "Продолжение следует...");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "Defeat the terrifying Wall of Flesh to continue...", "Победите ужасающую Стену плоти для новых контрактов.");
    }

    public class IceContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(IceContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(IceContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(IceContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(IceContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Ice Breaker", "Крушитель льда");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "Better pack some warm clothes for this one kid; this automaton, crafted from the coldest ice you can fathom, only appears in raging blizzards. Its deadly frost beams will freeze you solid if you aren't careful, so keep on the move and hide behind cover!", "Лучше взять вещи потеплее для этого дела, парень; этот механизм, собранный из самого холодного льда, который ты только можешь себе представить, появляется только во время страшных вьюг. Его смертельный ледяной луч превратит тебя в лядышку, если ты недостаточно аккуратен, так что не прекращай двигаться и прячься за укрытиями!");
    }

    public class MimicContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(MimicContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MimicContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(MimicContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MimicContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Fool's Gold", "Золото дураков");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "I don't know what you did out there, kid, but things have gotten a lot more hectic. With the released spirits possessing our world, you can't trust anything now! Worse yet, it seems some avarice spirits have possessed a collection of chests deep underground turning them into Mimics. Keep your eyes peeled for any chests laying around. They may not be what they seem...", "Я не знаю что ты наделал, парень, но всё в округе стало гораздо неспокойнее. После того, как освободившиеся духи заполнили этот мир, нельзя ничему доверять! И еще хуже то, что некоторые наиболее алчные духи, похоже, поработили множество сундуков подземелья, превращая их в мимиков. Будь повнимательнее, если видишь оставленные сундуки. Они могут оказаться не тем, чем кажутся...");
    }

    public class MinotaurContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(MinotaurContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MinotaurContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(MinotaurContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MinotaurContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Beast in the Maze", "Чудовище Лабиринта");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "The Dungeon is bad enough with skeletons and slimes roaming around, but with a Raging Minotaur loose, it gets even more complicated. That beast can charge at incredible speed, blindsiding anyone not paying attention and crippling their movement. Don't get staggered out there, kid.", "Темница - плохое место само по себе, из-за бродящих по нему слизней и скелетов. Но после освобождения разъяренного Минотавра, оно стала в разы опаснее. Это невероятно быстрое чудовище исподтишка нападает на невнимательных и калечит их. Постарайся стоять на своих ногах покрепче, парень.");
    }

    public class MothContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(MothContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MothContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(MothContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MothContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Gonna Need a Bigger Lamp", "Понадобится лампа побольше");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "Don't be fooled, kid, the creature that lurks within the underground jungle is a being of pure terror, not beauty. Its mere existence is testament to our arrogance as individuals. It's... a moth!", "Не дай себя обмануть, парень, то существо, которое прячется в подземных джунглях несет лишь ужас, а не красоту. Само ее существование это следствие самоуверенности отдельных лиц. Это... Моль!");
    }

    public class MothronContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(MothronContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MothronContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(MothronContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MothronContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Destroy All Monsters", "Уничтожь всех чудищ");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "When the moon perfectly blocks the sun, the terror within us is released upon the world. My biggest fear has manifested as well in the form of a mutant moth! Hey, we don't choose what we fear, kid...", "Когда луна полностью закрывает солнце, наши страхи выходят в этот мир. Мой самый жуткий кошмар также проявился в виде мотылька-мутанта!. Хэй, не мы выбираем свои страхи, парень...");
    }

    public class NymphContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(NymphContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(NymphContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(NymphContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(NymphContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Damsel of Distress", "Девица бедствий");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "You've got a good heart, kid. Don't let that be the end of you with this contract... Deep within the snow caves, there hides a creature masquerading as a defenseless young girl. Once close enough, however, you'll see she's not so defenseless. Take her out if you find her!", "У тебя доброе сердце, парень. Но не дай ему стать причиной твоего конца во время этого контракта... Глубоко в заснеженных пещерах прячется существо, маскирующееся под безобидную молодую девушку. Но, стоит тебе подойти и ты убеждаешься, что она не так беззащитна. Прикончи ее, если найдешь!");
    }

    public class PigronContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(PigronContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(PigronContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(PigronContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(PigronContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Boared to Death", "Захрючен до смерти");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "The Pigron are a rather bizarre hybrid of creatures. 50% pig, 50% dragon, and 100% evil. You might encounter them where the ice caverns meet the worlds evil. Beware their grumbling bellies as they approach; It's quite audible.", "Свинодракон это довольно причудливый гибрид существ. 50% свиньи, 50% дракона и 100% зла. Ты можешь встретить их там, где оледенелые пещеры встречаются с заражением. Остерегайся их пустых животов; они очень громкие.");
    }

    public class PinkyContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(PinkyContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(PinkyContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(PinkyContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(PinkyContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Pinky, the World Ender", "Пинки, Вестник конца");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "Never before have I heard of a creature with such terrifying power... It's pink, it's mean, and it journeys around with a powerful storm of slime. Destroy it!", "Я еще никогда не слышал о существе с настолько устрашающей силой... Оно розовое, оно злое и оно путешествует по миру, преследуемое сильным штормом из слизи. Уничтожь это!");
    }

    public class PirateShipContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(PirateShipContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(PirateShipContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(PirateShipContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(PirateShipContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Drunken Sailor's Query", "Вопрос пьяного моряка");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "Have you heard tale of the pirates and their insatiable lust for gold? They can smell a coin from miles around, and from the looks of it, you've got quite a few. I would keep on guard for their inevitable siege. Make them regret attacking here by breaking one of their Flying Dutchman ships.", "Слышал ли ты сказки о пиратах и их неутолимую тягу к золоту? Они способны учуять запах золотой монеты за многие километры и, похоже, денег у тебя предостаточно. Я буду стаять на страже, в ожидании их неизбежной осады. Заставь их пожалеть об этой атаке, сломав один из их Летучих Голландцев.");
    }

    public class RecluseContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(RecluseContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(RecluseContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(RecluseContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(RecluseContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Not so Itsy Bitsy", "Не совсем крошка-паучок");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "Alright kid, I've got a bit of a double contract for you this time; a lot of our fellow townsfolk have severe cases of arachnophobia it seems. Rumors of a 'Brown Recluse' roaming the spider caverns have surfaced, but it seems like our only way to draw it out of hiding is to ALSO take down some kind of icy 'Gargantuan Spider', which prowls the tundra during harsh blizzards. If you can take both of them down, the folks around here should feel a lot safer.", "Ну что ж, парень, у меня для тебя есть двойной контракт в этот раз. Многие из наших жителей, похоже, имеют тяжелые случаи арахнофобии. Появились слухи о 'Буром Отшельнике', бродящему в паучьих пещерах, но, похоже, что бы выманить его из убежища нам ТАКЖЕ стоит убить какого-то ледяного 'Гигантского Паука', который бродит по тундре во время суровых вьюг. Если ты их обоих устранишь, наши люди смогут чувствовать себя намного безопаснее.");
    }

    public class RuneContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(RuneContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(RuneContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(RuneContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(RuneContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Rune Prune", "Рунный-Занудный");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "The uncontrollable energies released by the Wall of Flesh's defeat have allowed some unsavory individuals to get quite a power boost. A rogue skeleton has harnessed the power of some long sealed spirits, and now terrorizes the underground as a Rune Wizard. His power is volatile and unpredictable; We can't allow him to live!", "Неконтролируемая энергия, выпущенная после победы над стеной плоти, позволила некоторым неприятным существам получить нехилое усиление. Один скелет смог использовать силы запечатанных духов в свою пользу и теперь терроризирует подземелья под именем Рунного мага. Его силы изменчивы и непредсказуемы; Мы не можем позволить ему жить!");
    }

    public class SandContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(SandContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(SandContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(SandContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(SandContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Line in the Sand", "Черта на песке");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "An elemental's personality is heavily influenced by the environment it forms in. Considering sandstorms are rough, coarse, and dangerous, you can imagine why we would want to take down a few Sand Elementals. Watch your step for any nasty monsters wanting to take a bite out of you, kid!", "Среда обитания элементаля сильно влияет на его характер. Зная, как грубы и опасны бури пустынь, ты можешь понять, почему нам лучше уничтожить несколько элементалей. Остерегайся монстров, которые так и хотят укусить тебя, парень!");
    }

    public class TimContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(TimContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(TimContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(TimContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(TimContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Casting a Shadow", "Заклинатель теней");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "I've managed to track down quite an elusive dark caster in the deeper levels of our world by the name of... Tim. Names aside, he's got quite a bit of power behind him, but one fatal weakness. It seems he's quite prideful of his outfit, thinking his better than any other. Maybe you should wear a gem robe to lure him out...?", "В глубинах нашего мира я смог отследить довольно необычного тёмного колдуна. Его имя... Тим. Хотя имя не так уж и важно. Он довольно силён, но имеет одну смертельную слабость - он cлишком сильно гордится своим внешним видом. Может, тебе стоит надеть робу с самоцветами, дабы выманить его...?");
    }

    public class WyvernContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(WyvernContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(WyvernContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(WyvernContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(WyvernContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Off Cloud Nine", "С седьмого неба");

        private void TranslationGetDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "The winds of change are upon us it seems. But these winds don't seem to be in our favor... A nasty nest of Wyverns have found their way to the nearby sky islands floating just above our heads. I think it would be best for everyone if some of them were culled.", "Похоже, на нас тоже повеяло ветром перемен, но эти перемены далеко не в нашу пользу... Стая виверн нашли путь к островам, парящим прямо над нашими головами. Я думаю, всем будет лучше, если мы усмирим парочку.");
    }

    public class TrackerCustomCurrencyIL : ILEdit
    {
        private event ILContext.Manipulator GetPriceTextHook
        {
            add => HookEndpointManager.Modify(typeof(TrackerCustomCurrency).GetMethod("GetPriceText", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(TrackerCustomCurrency).GetMethod("GetPriceText", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => GetPriceTextHook += TranslationGetPriceTextHook;

        public override void Unload() => GetPriceTextHook -= TranslationGetPriceTextHook;

        private void TranslationGetPriceTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "vanquisher medals", "медалей победителя");
    }

    public class TrackerIL : ILEdit
    {
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(typeof(Tracker).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(Tracker).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;

        public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Spend Medals", "Потратить медали");
            TranslationUtils.ILTranslate(il, "Available Contracts", "Доступные контракты");
        }
    }

    public class WeaponMasterIL : ILEdit
    {
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(typeof(WeaponMaster).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(WeaponMaster).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;

        public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Hire Demon ", "Нанять демона ");
            TranslationUtils.ILTranslate(il, "(8 Gold)", "(8 золотых)");
            TranslationUtils.ILTranslate(il, "(10 Gold)", "(10 золотых)");
        }
    }

    public class SpiritualistIL : ILEdit
    {
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(typeof(Spiritualist).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(Spiritualist).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;

        public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il) => TranslationUtils.ILTranslate(il, "Guardian Angel (5 Purified Shards)", "Ангел-хранитель (5 очищенных осколков)");
    }

    public class DivermanIL : ILEdit
    {
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(typeof(Diverman).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(Diverman).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;

        public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il) => TranslationUtils.ILTranslate(il, "Air Tank", "Воздушный баллон");
    }

    public class DesertTravelerIL : ILEdit
    {
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(typeof(DesertTraveler).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(DesertTraveler).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;

        public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Sandstorm ", "Песчаная буря ");
            TranslationUtils.ILTranslate(il, "(80 Silver)", "(80 серебряных)");
            TranslationUtils.ILTranslate(il, "(1 Gold)", "(1 золотая)");
        }
    }

    public class CookIL : ILEdit
    {
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(typeof(Cook).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(Cook).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;

        public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il) => TranslationUtils.ILTranslate(il, "Supply Ingredients", "Снабдить ингредиентами");
    }

    public class ConfusedZombieIL : ILEdit
    {
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(typeof(ConfusedZombie).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ConfusedZombie).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;

        public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Enemy Repellent ", "Репеллент");
            TranslationUtils.ILTranslate(il, "(1 Gold 60 Silver)", "(1 золотая 60 серебряных)");
            TranslationUtils.ILTranslate(il, "(2 Gold)", "(2 золотые)");
        }
    }

    public class CobblerIL : ILEdit
    {
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(typeof(Cobbler).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(Cobbler).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;

        public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il) => TranslationUtils.ILTranslate(il, "Shine Shoes", "Полированная обувь");
    }

    public class DangerContractIL : ILEdit
    {
        private event ILContext.Manipulator GetTitleHook
        {
            add => HookEndpointManager.Modify(typeof(DangerContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(DangerContract).GetMethod("get_Title", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetDescriptionHook
        {
            add => HookEndpointManager.Modify(typeof(DangerContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(DangerContract).GetMethod("get_Description", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            GetTitleHook += TranslationGetTitleHook;
            GetDescriptionHook += TranslationGetDescriptionHook;
        }

        public override void Unload()
        {
            GetTitleHook -= TranslationGetTitleHook;
            GetDescriptionHook -= TranslationGetDescriptionHook;
        }

        private void TranslationGetTitleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Learning the Ropes", "Изучение верёвок");

        private void TranslationGetDescriptionHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Alright kid, I think we should start you off easy... I've tracked down a group of wild creatures deep beneath our surface. On your adventures underground, you may encounter formidable creatures known as Crawdads, Salamanders and Giant Shellys. Taking out a couple of them would make the world a lot safer, and let me sleep peacefully for the night.", "Хорошо, парень, я думаю, мы должны начать с простого... Я выследил группу диких существ глубоко под поверхностью. В своих приключениях под землей вы можете встретить грозных существ, известных как пресноводный рак, саламандра и гигантский ракушечник. Уничтожив пару из них, вы сделаете мир намного безопаснее и позволите мне спокойно спать по ночам.");
            TranslationUtils.ILTranslate(il, "Not bad at all, kid. Hopefully it wasn't too hard hunting one down. You may have noticed they dropped a 'Vanquisher Medal'. With those, you can redeem them for items I keep on me. Typically, they relate to the tracked creature, so be sure to visit me after completing any contracts.", "Недурно, парень. Надеюсь, было не так уж сложно охотиться на кого-то из них. Ты, наверное, заметил, что они обронили 'Медаль победителя'. Ты можешь обменять их на вещи, которые я храню при себе. Как правило, они относятся к отслеживаемому существу, так что не забудь навестить меня после выполнения любых контрактов.");
        }
    }

    public class TrackerUIIL : ILEdit
    {
        private event ILContext.Manipulator OnInitializeHook
        {
            add => HookEndpointManager.Modify(ModsCall.Thorium.Code.GetType("ThoriumMod.UI.TrackerUI").GetMethod("OnInitialize", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Thorium.Code.GetType("ThoriumMod.UI.TrackerUI").GetMethod("OnInitialize", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => OnInitializeHook += TranslationOnInitializeHook;

        public override void Unload() => OnInitializeHook -= TranslationOnInitializeHook;

        private void TranslationOnInitializeHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Close", "Закрыть");
            TranslationUtils.ILTranslate(il, "Previous", "Предыдущий");
            TranslationUtils.ILTranslate(il, "Next", "Следующий");
        }
    }

    public class FurnitureBedIL : ILEdit
    {
        private event ILContext.Manipulator NewRightClickHook
        {
            add => HookEndpointManager.Modify(typeof(FurnitureBed).GetMethod("NewRightClick", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(FurnitureBed).GetMethod("NewRightClick", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => NewRightClickHook += TranslationNewRightClickHook;

        public override void Unload() => NewRightClickHook -= TranslationNewRightClickHook;

        private void TranslationNewRightClickHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Spawn point removed!", "Точка воскрешения удалена!");
            TranslationUtils.ILTranslate(il, "Spawn point set!", "Точка воскрешения задана!");
        }
    }

    public class ThoriumPlayerIL : ILEdit
    {
        private event ILContext.Manipulator PostUpdateEquipsHook
        {
            add => HookEndpointManager.Modify(typeof(ThoriumPlayer).GetMethod("PostUpdateEquips", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ThoriumPlayer).GetMethod("PostUpdateEquips", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        private event ILContext.Manipulator PreKillHook
        {
            add => HookEndpointManager.Modify(typeof(ThoriumPlayer).GetMethod("PreKill", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ThoriumPlayer).GetMethod("PreKill", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            PostUpdateEquipsHook += TranslationPostUpdateEquipsHook;
            PreKillHook += TranslationPreKillHook;
        }

        public override void Unload()
        {
            PostUpdateEquipsHook -= TranslationPostUpdateEquipsHook;
            PreKillHook -= TranslationPreKillHook;
        }

        private void TranslationPostUpdateEquipsHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, " held on to life for as long as they could.", " держался за жизнь до последнего.");
            TranslationUtils.ILTranslate(il, " gave it their all...", " пожертвовал всем...");
            TranslationUtils.ILTranslate(il, " was consumed by darkness...", " был поглощён тьмой...");
        }

        private void TranslationPreKillHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, " was completely eradicated.", " был полностью искоренен.");
            TranslationUtils.ILTranslate(il, " couldn't 'grasp' the situation.", " не смог 'уловить' ситуацию.");
            TranslationUtils.ILTranslate(il, " has failed Terraria...", " подвел Террарию...");
            TranslationUtils.ILTranslate(il, " got liquefied.", " разжижился.");
            TranslationUtils.ILTranslate(il, " couldn't contain the granite energy.", " не смог сдержать энергию гранита.");
        }
    }

    public class IllusionistSpawnIL : ILEdit
    {
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(typeof(IllusionistSpawn).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(IllusionistSpawn).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;

        public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il) => TranslationUtils.ILTranslate(il, "Touch", "Коснуться");
    }

    public class ThoriumItemIL : ILEdit
    {
        private event ILContext.Manipulator ModifyTooltipsHook
        {
            add => HookEndpointManager.Modify(typeof(ThoriumItem).GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ThoriumItem).GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => ModifyTooltipsHook += TranslationModifyTooltipsHook;

        public override void Unload() => ModifyTooltipsHook -= TranslationModifyTooltipsHook;

        private void TranslationModifyTooltipsHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, " & ", " и ");
            TranslationUtils.ILTranslate(il, " life", " здоровья");
        }
    }
    
    public class ThoriumGlobalItemIL : ILEdit
    {
        private event ILContext.Manipulator OnConsumeManaHook
        {
            add => HookEndpointManager.Modify(typeof(ThoriumGlobalItem).GetMethod("OnConsumeMana", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ThoriumGlobalItem).GetMethod("OnConsumeMana", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        private event ILContext.Manipulator ConsumeItemHook
        {
            add => HookEndpointManager.Modify(typeof(ThoriumGlobalItem).GetMethod("ConsumeItem", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ThoriumGlobalItem).GetMethod("ConsumeItem", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            OnConsumeManaHook += TranslationOnConsumeManaHook;
            ConsumeItemHook += TranslationConsumeItemHook;
        }

        public override void Unload()
        {
            OnConsumeManaHook -= TranslationOnConsumeManaHook;
            ConsumeItemHook -= TranslationConsumeItemHook;
        }

        private void TranslationOnConsumeManaHook(ILContext il) => TranslationUtils.ILTranslate(il, "Freebie!", "Бесплатно!");
        
        private void TranslationConsumeItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Freebie!", "Бесплатно!");
            TranslationUtils.ILTranslate(il, "Freebie!", "Бесплатно!", 2);
        }
    }
}