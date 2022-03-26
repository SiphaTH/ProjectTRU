using System.Collections.Generic;
using CalamityMod.Items.Weapons.Melee;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications
{
    public class AttunementTranslation : CalamityGlobalItemBase
    {
        private static string[] _attunementTooltips =
        {
            "Andromeda's Stride",
            "Hold the attack button to charge a god-erasing lunge, release to unleash the devastating blow. Galaxia emits cosmic bolts while charging",
            "Striking the earth with the lunge will cause a massive impact which summons an apocalyptic storm of cosmic energies",
            "Cancer's Blessing",
            "Periodically releases a ring of lifestealing stars around yourself when attacking\nThe ring is attracted towards you at first, before slowing down over time",
            "Aries' Wrath",
            "Throw Galaxia to your cursor, holding it in place with constellations. Galaxia follows your cursor, rapidly spinning to shred enemies",
            "Striking enemies causes nebulous explosions which spawn homing cosmic bolts",
            "Capricorn's Blessing",
            "Periodically releases a ring of weakening stars around your cursor when attacking\nThe ring is repelled away from you at first, before slowing down over time",
            "Extant Abhorrence",
            "Hold the attack button to charge a star-piercing lunge, release to unleash the devastating blow",
            "Striking the earth with the lunge will cause a massive impact which raises otherworldly monoliths",
            "Biting Embrace",
            "Perform a 3 strike combo with a glacial blade. The final strike freezes foes for a split second",
            "Pure Clarity",
            "Fires a weak projectile that crushes enemy defenses",
            "Decay's Retort",
            "Lunge forward using a ghostly rapier projection that leeches life off any struck foes. You also get bounced away from hit targets",
            "Lamentations of the Chained",
            "Lash out with a flurry of chained blades. Striking enemies with the tip of the blades guarantees a critical hit",
            "Critical strikes send out extra phantom chains which latch onto multiple targets",
            "An enchanted chain hook floats near you. Striking enemies makes the hook whirl around you, freezing enemies",
            "Heaven's Might",
            "Hold the attack button to swing the sword around you, accelerating over time",
            "Releasing the attack button hurls the sword towards your cursor. The sword then quickly returns to your hand",
            "Arid Grandeur",
            "Conjures searing blades in front of you that get larger and stronger the more you hit enemies. The blades can also be used to bounce off tiles when in the air",
            "Gesture for the Drowned",
            "Shoot out two water balls at your sides. On ground contact the water balls will turn into small waves that ride along the ground",
            "Waves fired while underwater or that touch water will become much larger and faster",
            "Phoenix's Pride",
            "Hold the attack button to swing Galaxia around you, accelerating over time. The swirling nebula constantly emits homing cosmic bolts",
            "Releasing the attack button hurls the sword towards your cursor alongside a burst of 6 gigantic cosmic bolts. The sword then quickly returns to your hand",
            "Polaris' Gaze",
            "Hold the attack button to channel the Northern Star's power into a tight vortex of galactic energies, bound by concentric rings of stars.\nThe vortex powers up over time and when hitting enemies",
            "Release the attack button to fire off the charged star. Attacking again immediately thereafter dashes to the star, emitting a nova of cosmic bolts",
            "Mercurial Tides",
            "Hold the attack button to charge a heaven-shattering lunge, release to unleash the devastating blow.\nShock waves are emitted as the sword charges up",
            "Striking the earth with the lunge will cause a massive shock wave on impact which raises a flood of monoliths",
            "Periodically emit shock waves while attacking",
            "Sanguine Fury",
            "Conjures molten blades in front of you that get larger and stronger the more you hit enemies.\nThe blades can also be used to bounce off tiles when in the air",
            "Releasing the attack button sends the charged blades hurtling forwards like a wheel.\n Attacking again immediately thereafter dashes to the wheel, shredding anything in the way",
            "Striking enemies rarely steals a small amount of life",
            "Grovetender's Touch",
            "Throw out the blade using a vine whip. Striking enemies with the tip of the whip as it cracks guarantees a critical hit. The whip will also propel you towards struck tiles",
            "Lingering glacial mist is released on each swing, dealing damage to enemies wandering into it",
            "Landing true melee hits places a sigil of purity over the enemy. Your projectiles home onto the marked foes",
            "Landing three strikes without touching the ground changes your next attack into an empowered dash thrust",
            "Releasing the attack button after the blades are fully charged sends them hurtling forwards to shred your foes",
            "Spreading vines sprout from critical strikes. These vines can hit up to three targets",
            "Swordsmith's Pride",
            "Sword beams are fired wildly while swinging",
            "Releasing the attack button hurls the sword towards your cursor. Sword beams home onto enemies struck by the thrown sword",
            "All attacks have a chance to fire sword beams"
        };

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ModContent.ItemType<BiomeBlade>() ||
                item.type == ModContent.ItemType<FourSeasonsGalaxia>() ||
                item.type == ModContent.ItemType<OmegaBiomeBlade>() ||
                item.type == ModContent.ItemType<TrueBiomeBlade>())
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    for (var i = 0; i < _attunementTooltips.Length; i++)
                    {
                        tooltip.text = tooltip.text.Replace(_attunementTooltips[i], LangHelper.GetTextValue($"Calamity.AttunementTooltip.{i}"));
                    }
                }
            }

            if (item.type == ModContent.ItemType<BiomeBlade>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = tooltip.text.Replace("Does nothing..yet", "Ничего не делает... пока");
                });

                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = tooltip.text
                        .Replace("Main Attunement", "Основная настройка")
                        .Replace("None", "Нет");
                });

                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = tooltip.text
                        .Replace("Secondary Attunement", "Вторичная настройка")
                        .Replace("None", "Нет");
                });
            }

            if (item.type == ModContent.ItemType<OmegaBiomeBlade>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = tooltip.text.Replace("Does nothing..yet\nIt seems that upgrading the blade expanded the scope of the previous attunements", "Ничего не делает... пока\nПохоже, что улучшение клинка расширило возможности предыдущих настроек");
                });

                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = tooltip.text.Replace("Your secondary attunement can now provide passive bonuses", "Ваша вторичная настройка теперь может давать пассивные бонусы");
                });

                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = tooltip.text
                        .Replace("Active Attunement", "Активная настройка")
                        .Replace("None", "Нет");
                });

                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = tooltip.text
                        .Replace("Passive Attunement", "Пассивная настройка")
                        .Replace("None", "Нет");
                });
            }

            if (item.type == ModContent.ItemType<TrueBiomeBlade>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = tooltip.text.Replace("Does nothing..yet\nRepairing the blade seems to have improved its attuning capacities", "Ничего не делает... пока\nПохоже, что восстановление клинка улучшило его возможности настройки");
                });

                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = tooltip.text
                        .Replace("Main Attunement", "Основная настройка")
                        .Replace("None", "Нет");
                });

                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = tooltip.text
                        .Replace("Secondary Attunement", "Вторичная настройка")
                        .Replace("None", "Нет");
                });
            }

            if (item.type == ModContent.ItemType<FourSeasonsGalaxia>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = tooltip.text.Replace("Active Attunement", "Активная настройка");
                });

                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = tooltip.text.Replace("Passive Blessing", "Пассивное благословение");
                });
            }
        }
    }
}