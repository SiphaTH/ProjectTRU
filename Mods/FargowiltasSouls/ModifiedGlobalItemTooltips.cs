﻿using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls
{
    public class ModifiedGlobalItemTooltips : GlobalItem
    {
        public override bool Autoload(ref string name) => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            TooltipLine tooltip0 = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
            TooltipLine tooltip1 = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
            TooltipLine tooltip2 = tooltips.FirstOrDefault(x => x.Name == "Tooltip2");
            TooltipLine tooltip3 = tooltips.FirstOrDefault(x => x.Name == "Tooltip3");
            TooltipLine tooltip4 = tooltips.FirstOrDefault(x => x.Name == "Tooltip4");
            TooltipLine tooltip5 = tooltips.FirstOrDefault(x => x.Name == "Tooltip5");
            TooltipLine tooltip6 = tooltips.FirstOrDefault(x => x.Name == "Tooltip6");
            TooltipLine tooltip7 = tooltips.FirstOrDefault(x => x.Name == "Tooltip7");
            TooltipLine tooltip8 = tooltips.FirstOrDefault(x => x.Name == "Tooltip8");
            TooltipLine tooltip9 = tooltips.FirstOrDefault(x => x.Name == "Tooltip9");
            TooltipLine tooltip10 = tooltips.FirstOrDefault(x => x.Name == "Tooltip10");

            if (item.type == ModsCall.FargoSouls.ItemType("EternitySoul"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "tooltip");
                if (tooltip != null)
                {
                    tooltip.text = tooltip.text
                        .Replace("Additionally grants:", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.0"))
                        .Replace("250% increased damage", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.1"))
                        .Replace("250% increased attack speed", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.2"))
                        .Replace("100% increased shoot speed", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.3"))
                        .Replace("100% increased knockback", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.4"))
                        .Replace("Increases armor penetration by 50", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.5"))
                        .Replace("Crits deal 10x damage", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.6"))
                        .Replace("Drastically increases life regeneration", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.7"))
                        .Replace("Increases your maximum mana to 999", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.8"))
                        .Replace("Increases your maximum minions by 30", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.9"))
                        .Replace("Increases your maximum sentries by 20", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.10"))
                        .Replace("Increases your maximum HP by 50%", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.11"))
                        .Replace("All attacks inflict Flames of the Universe", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.12"))
                        .Replace("All attacks inflict Sadism", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.13"))
                        .Replace("All attacks inflict Midas", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.14"))
                        .Replace("All attacks reduce enemy immunity frames", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.15"))
                        .Replace("Summons fireballs arund you", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.16"))
                        .Replace("Summons 2 shadow orbs around you", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.17"))
                        .Replace("Summons icicles around you", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.18"))
                        .Replace("Summons leaf crystals around you", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.19"))
                        .Replace("Summons a hallowed sword and shield", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.20"))
                        .Replace("Summons beetles to protect you", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.21"))
                        .Replace("Summons a Flameburst minion", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.22"))
                        .Replace("Summons a ton of pets", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.23"))
                        .Replace("Summons all Eternity Mode bosses to your side ", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.24"))
                        .Replace("Attacks may spawn lightning", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.25"))
                        .Replace("Attacks may spawn flower petals", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.26"))
                        .Replace("Attacks may spawn spectre orbs", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.27"))
                        .Replace("Attacks may spawn a Dungeon Guardian", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.28"))
                        .Replace("Attacks may spawn snowballs", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.29"))
                        .Replace("Attacks may spawn spears", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.30"))
                        .Replace("Attacks may spawn hearts", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.31"))
                        .Replace("Attacks may spawn a miniture storm", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.32"))
                        .Replace("Attacks may spawn buff boosters", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.33"))
                        .Replace("Attacks cause increased life regen", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.34"))
                        .Replace("Attacks cause shadow dodge", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.35"))
                        .Replace("Attacks cause Flameburst shots", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.36"))
                        .Replace("Attacks cause Pumpking attacks", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.37"))
                        .Replace("Attacks cause Cultist spells", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.38"))
                        .Replace("Attacks cause meteor showers", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.39"))
                        .Replace("All Projectiles will split", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.40"))
                        .Replace("Projectiles may shatter", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.41"))
                        .Replace("Projectiles spawn stars", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.42"))
                        .Replace("Item and projectile size increased", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.43"))
                        .Replace("You leave a trail of fire", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.44"))
                        .Replace("Nearby enemies are ignited", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.45"))
                        .Replace("Minions occasionally spew scythes", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.46"))
                        .Replace("You may spawn temporary minions", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.47"))
                        .Replace("Critters have increased defense", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.48"))
                        .Replace("Critter's souls may aid you", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.49"))
                        .Replace("Enemies explode into needles", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.50"))
                        .Replace("Greatly enhances all DD2 sentries", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.51"))
                        .Replace("Double-tap down to spawn a palm tree sentry", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.52"))
                        .Replace("Double-tap down to call an ancient storm", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.53"))
                        .Replace("Double-tap down to call a rain of arrows", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.54"))
                        .Replace("Double-tap down to toggle stealth", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.55"))
                        .Replace("Double-tap down to spawn a portal", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.56"))
                        .Replace("Double-tap down to direct your empowered guardian", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.57"))
                        .Replace("Right Click to Guard", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.58"))
                        .Replace("Press the Gold Key to encase yourself in gold", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.59"))
                        .Replace("Press the Freeze Key to freeze time for 5 seconds", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.60"))
                        .Replace("Solar shield allows you to dash", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.61"))
                        .Replace("Dashing into solid blocks teleports you through them", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.62"))
                        .Replace("Throw a smoke bomb to teleport to it and gain the first strike buff", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.63"))
                        .Replace("Jumping will release a spore explosion", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.64"))
                        .Replace("Enemies getting too close will trigger all on hit effects", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.65"))
                        .Replace("Getting hit reflects damage", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.66"))
                        .Replace("Getting hit triggers a blood geyser", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.67"))
                        .Replace("Getting hit may squeak", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.68"))
                        .Replace("Getting hit causes you to erupt into spiky balls", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.69"))
                        .Replace("Getting hit causes you to erupt into Ancient Visions", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.70"))
                        .Replace("Grants Crimson regen", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.71"))
                        .Replace("Grants immunity to fire", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.72"))
                        .Replace("Grants immunity to fall damage", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.73"))
                        .Replace("Grants immunity to lava", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.74"))
                        .Replace("Grants immunity to knockback", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.75"))
                        .Replace("Grants immunity to most debuffs", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.76"))
                        .Replace("Grants doubled herb collection", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.77"))
                        .Replace("Grants 50% chance for Mega Bees", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.78"))
                        .Replace("15% chance for minion crits", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.79"))
                        .Replace("20% chance for bonus loot", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.80"))
                        .Replace("Allows Supersonic running and ", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.81"))
                        .Replace("Allows infinite flight", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.82"))
                        .Replace("Increases fishing skill substantially", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.83"))
                        .Replace("All fishing rods will have 10 extra lures", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.84"))
                        .Replace("You respawn 10x as fast", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.85"))
                        .Replace("Prevents boss spawns", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.86"))
                        .Replace("Increases spawn rates", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.87"))
                        .Replace("Reduces skeletons hostility outside of the dungeon", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.88"))
                        .Replace("Empowers Cute Fishron", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.89"))
                        .Replace("Grants autofire", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.90"))
                        .Replace("Grants modifier protection", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.91"))
                        .Replace("Grants gravity control", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.92"))
                        .Replace("Grants fast fall", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.93"))
                        .Replace("Enhances grappling hooks", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.94"))
                        .Replace("You attract items from further away", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.95"))
                        .Replace("Increased block and wall placement speed by 50%", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.96"))
                        .Replace("Near infinite block placement", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.97"))
                        .Replace("Near infinite mining reach", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.98"))
                        .Replace("Mining speed dramatically increased", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.99"))
                        .Replace("You reflect all projectiles", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.100"))
                        .Replace("When you are hurt, you violently explode to damage nearby enemies", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.101"))
                        .Replace("When you die, you revive with full HP", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.102"))
                        .Replace("Effects of Fire Gauntlet", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.103"))
                        .Replace("Effects of Yoyo Bag", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.104"))
                        .Replace("Effects of Sniper Scope", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.105"))
                        .Replace("Effects of Celestial Cuffs", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.106"))
                        .Replace("Effects of Mana Flower", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.107"))
                        .Replace("Effects of Brain of Confusion", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.108"))
                        .Replace("Effects of Star Veil", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.109"))
                        .Replace("Effects of Sweetheart Necklace", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.110"))
                        .Replace("Effects of Bee Cloak", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.111"))
                        .Replace("Effects of Spore Sac", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.112"))
                        .Replace("Effects of Paladin's Shield", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.113"))
                        .Replace("Effects of Frozen Turtle Shell", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.114"))
                        .Replace("Effects of Arctic Diving Gear", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.115"))
                        .Replace("Effects of Frog Legs", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.116"))
                        .Replace("Effects of Flying Carpet", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.117"))
                        .Replace("Effects of Lava Waders", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.118"))
                        .Replace("Effects of Angler Tackle Bag", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.119"))
                        .Replace("Effects of Paint Sprayer", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.120"))
                        .Replace("Effects of Presserator", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.121"))
                        .Replace("Effects of Cell Phone", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.122"))
                        .Replace("Effects of Flower Boots", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.123"))
                        .Replace("Effects of Master Ninja Gear", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.124"))
                        .Replace("Effects of Greedy Ring", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.125"))
                        .Replace("Effects of Celestial Shell", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.126"))
                        .Replace("Effects of Shiny Stone", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.127"))
                        .Replace("Effects of Spelunker potion", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.128"))
                        .Replace("Effects of Dangersense potion", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.129"))
                        .Replace("Effects of Hunter potion", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.130"))
                        .Replace("Effects of Shine potion", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.131"))
                        .Replace("Effects of Builder Mode", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.132"))
                        .Replace("Armor bonuses from Living Wood", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.133"))
                        .Replace("Armor bonuses from Life Bloom", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.134"))
                        .Replace("Armor bonuses from Yew Wood", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.135"))
                        .Replace("Armor bonuses from Tide Hunter", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.136"))
                        .Replace("Armor bonuses from Icy", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.137"))
                        .Replace("Armor bonuses from Cryo Magus", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.138"))
                        .Replace("Armor bonuses from Whispering", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.139"))
                        .Replace("Armor bonuses from Sacred", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.140"))
                        .Replace("Armor bonuses from Warlock", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.141"))
                        .Replace("Armor bonuses from Biotech", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.142"))
                        .Replace("Armor bonuses from Cyber Punk", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.143"))
                        .Replace("Armor bonuses from Maestro", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.144"))
                        .Replace("Armor bonuses from Bronze", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.145"))
                        .Replace("Armor bonuses from Darksteel", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.146"))
                        .Replace("Armor bonuses from Durasteel", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.147"))
                        .Replace("Armor bonuses from Conduit", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.148"))
                        .Replace("Armor bonuses from Lodestone", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.149"))
                        .Replace("Armor bonuses from Illumite", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.150"))
                        .Replace("Armor bonuses from Jester", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.151"))
                        .Replace("Armor bonuses from Thorium", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.152"))
                        .Replace("Armor bonuses from Terrarium", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.153"))
                        .Replace("Armor bonuses from Malignant", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.154"))
                        .Replace("Armor bonuses from Folv", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.155"))
                        .Replace("Armor bonuses from White Dwarf", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.156"))
                        .Replace("Armor bonuses from Celestial", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.157"))
                        .Replace("Armor bonuses from Spirit Trapper", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.158"))
                        .Replace("Armor bonuses from Dragon", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.159"))
                        .Replace("Armor bonuses from Dread", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.160"))
                        .Replace("Armor bonuses from Flesh", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.161"))
                        .Replace("Armor bonuses from Demon Blood", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.162"))
                        .Replace("Armor bonuses from Tide Turner", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.163"))
                        .Replace("Armor bonuses from Assassin", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.164"))
                        .Replace("Armor bonuses from Pyromancer", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.165"))
                        .Replace("Armor bonuses from Dream Weaver", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.166"))
                        .Replace("Effects of Flawless Chrysalis", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.167"))
                        .Replace("Effects of Bubble Magnet", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.168"))
                        .Replace("Effects of Agnor's Bowl", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.169"))
                        .Replace("Effects of Ice Bound Strider Hide", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.170"))
                        .Replace("Effects of Ring of Unity", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.171"))
                        .Replace("Effects of Mix Tape", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.172"))
                        .Replace("Effects of Eye of the Storm", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.173"))
                        .Replace("Effects of Champion's Rebuttal", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.174"))
                        .Replace("Effects of Incandescent Spark", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.175"))
                        .Replace("Effects of Greedy Magnet", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.176"))
                        .Replace("Effects of Abyssal Shell", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.177"))
                        .Replace("Effects of Astro-Beetle Husk", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.178"))
                        .Replace("Effects of Eye of the Beholder", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.179"))
                        .Replace("Effects of Crietz", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.180"))
                        .Replace("Effects of Mana-Charged Rocketeers", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.181"))
                        .Replace("Effects of Inner Flame", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.182"))
                        .Replace("Effects of Crash Boots", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.183"))
                        .Replace("Effects of Vampire Gland", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.184"))
                        .Replace("Effects of Demon Blood Badge", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.185"))
                        .Replace("Effects of Lich's Gaze", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.186"))
                        .Replace("Effects of Plague Lord's Flask", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.187"))
                        .Replace("Effects of Phylactery", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.188"))
                        .Replace("Effects of Crystal Scorpion", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.189"))
                        .Replace("Effects of Guide to Expert Throwing - Volume III", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.190"))
                        .Replace("Effects of Mermaid's Canteen", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.191"))
                        .Replace("Effects of Deadman's Patch", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.192"))
                        .Replace("Effects of Support Sash", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.193"))
                        .Replace("Effects of Saving Grace", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.194"))
                        .Replace("Effects of Soul Guard", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.195"))
                        .Replace("Effects of Archdemon's Curse", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.196"))
                        .Replace("Effects of Archangel's Heart", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.197"))
                        .Replace("Effects of Medical Bag", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.198"))
                        .Replace("Effects of Epic Mouthpiece", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.199"))
                        .Replace("Effects of Straight Mute", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.200"))
                        .Replace("Effects of Digital Tuner", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.201"))
                        .Replace("Effects of Guitar Pick Claw", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.202"))
                        .Replace("Effects of Ocean's Retaliation", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.203"))
                        .Replace("Effects of Terrarium Defender", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.204"))
                        .Replace("Effects of Air Walkers", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.205"))
                        .Replace("Effects of Survivalist Boots", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.206"))
                        .Replace("Effects of Weighted Winglets", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.207"))
                        .Replace("Armor bonuses from Aerospec", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.208"))
                        .Replace("Armor bonuses from Statigel", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.209"))
                        .Replace("Armor bonuses from Daedalus", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.210"))
                        .Replace("Armor bonuses from Bloodflare", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.211"))
                        .Replace("Armor bonuses from Victide", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.212"))
                        .Replace("Armor bonuses from Xeroc", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.213"))
                        .Replace("Armor bonuses from Omega Blue", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.214"))
                        .Replace("Armor bonuses from God Slayer", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.215"))
                        .Replace("Armor bonuses from Silva", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.216"))
                        .Replace("Armor bonuses from Auric Tesla", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.217"))
                        .Replace("Armor bonuses from Mollusk", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.218"))
                        .Replace("Armor bonuses from Reaver", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.219"))
                        .Replace("Armor bonuses from Ataxia", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.220"))
                        .Replace("Armor bonuses from Astral", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.221"))
                        .Replace("Armor bonuses from Tarragon", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.222"))
                        .Replace("Armor bonuses from Demonshade", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.223"))
                        .Replace("Effects of Spirit Glyph", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.224"))
                        .Replace("Effects of Raider's Talisman", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.225"))
                        .Replace("Effects of Trinket of Chi", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.226"))
                        .Replace("Effects of Gladiator's Locket", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.227"))
                        .Replace("Effects of Unstable Prism", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.228"))
                        .Replace("Effects of Counter Scarf", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.229"))
                        .Replace("Effects of Fungal Symbiote", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.230"))
                        .Replace("Effects of Permafrost's Concoction", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.231"))
                        .Replace("Effects of Regenator", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.232"))
                        .Replace("Effects of Core of the Blood God", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.233"))
                        .Replace("Effects of Affliction", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.234"))
                        .Replace("Effects of Deep Dive", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.235"))
                        .Replace("Effects of The Transformer", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.236"))
                        .Replace("Effects of Luxor's Gift", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.237"))
                        .Replace("Effects of The Community", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.238"))
                        .Replace("Effects of Abyssal Diving Suit", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.239"))
                        .Replace("Effects of Lumenous Amulet", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.240"))
                        .Replace("Effects of Aquatic Emblem", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.241"))
                        .Replace("Effects of Nebulous Core", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.242"))
                        .Replace("Effects of Draedon's Heart", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.243"))
                        .Replace("Effects of The Amalgam", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.244"))
                        .Replace("Effects of Godly Soul Artifact", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.245"))
                        .Replace("Effects of Yharim's Gift", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.246"))
                        .Replace("Effects of Heart of the Elements", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.247"))
                        .Replace("Effects of The Sponge", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.248"))
                        .Replace("Effects of Giant Pearl", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.249"))
                        .Replace("Effects of Amidias' Pendant", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.250"))
                        .Replace("Effects of Fabled Tortoise Shell", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.251"))
                        .Replace("Effects of Plague Hive", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.252"))
                        .Replace("Effects of Astral Arcanum", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.253"))
                        .Replace("Effects of Hide of Astrum Deus", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.254"))
                        .Replace("Effects of Profaned Soul Artifact", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.255"))
                        .Replace("Effects of Dark Sun Ring", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.256"))
                        .Replace("Effects of Elemental Gauntlet", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.257"))
                        .Replace("Effects of Elemental Quiver", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.258"))
                        .Replace("Effects of Ethereal Talisman", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.259"))
                        .Replace("Effects of Statis' Belt of Curses", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.260"))
                        .Replace("Effects of Nanotech", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.261"))
                        .Replace("Effects of Asgardian Aegis", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.262"))
                        .Replace("Effects of Zenkai Charm", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.263"))
                        .Replace("Effects of Aspera Crystallite", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.264"))
                        .Replace("Armor bonuses from Bismuth", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.265"))
                        .Replace("Armor bonuses from Frosthunter", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.266"))
                        .Replace("Armor bonuses from Blightbone", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.267"))
                        .Replace("Armor bonuses from Dreadfire", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.268"))
                        .Replace("Armor bonuses from Space Junk", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.269"))
                        .Replace("Armor bonuses from Marstech", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.270"))
                        .Replace("Armor bonuses from Blazing Brute", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.271"))
                        .Replace("Armor bonuses from Cosmic Commander", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.272"))
                        .Replace("Armor bonuses from Nebulous Apprentic", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.273"))
                        .Replace("Armor bonuses from Stellar Priest", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.274"))
                        .Replace("Armor bonuses from Fallen Prince", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.275"))
                        .Replace("Armor bonuses from Void Warden", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.276"))
                        .Replace("Armor bonuses from Vulcan Reaper", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.277"))
                        .Replace("Armor bonuses from Flarium", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.278"))
                        .Replace("Armor bonuses from Asthraltite", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.279"))
                        .Replace("Effects of Dreadflame Emblem", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.280"))
                        .Replace("Effects of Lapis Pendant", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.281"))
                        .Replace("Effects of Frigid Pendant", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.282"))
                        .Replace("Effects of Pumpkin Amulet", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.283"))
                        .Replace("Effects of Nuba's Blessing", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.284"))
                        .Replace("Effects of Novaniel's Resolve", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.285"))
                        .Replace("Effects of Celestial Ring", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.286"))
                        .Replace("Effects of Ring of the Fallen", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.287"))
                        .Replace("Effects of Memento Mori", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.288"))
                        .Replace("Effects of Arcanum of the Caster", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.289"))
                        .Replace("Reduces your mana usage by 50%", LangUtils.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.290"));
                }
            }
            else if (item.type == ModsCall.FargoSouls.ItemType("MedallionoftheFallenKing") || item.type == ModsCall.FargoSouls.ItemType("ComputationOrb") ||
                     item.type == ModsCall.FargoSouls.ItemType("StaffOfUnleashedOcean") || item.type == ModsCall.FargoSouls.ItemType("RoombaPet") ||
                     item.type == ModsCall.FargoSouls.ItemType("PiranhaPlantVoodooDoll") || item.type == ModsCall.FargoSouls.ItemType("FigBranch") ||
                     item.type == ModsCall.FargoSouls.ItemType("ParadoxWolfSoul") || item.type == ModsCall.FargoSouls.ItemType("SquidwardDoor") ||
                     item.type == ModsCall.FargoSouls.ItemType("MissDrakovisFishingPole") || item.type == ModsCall.FargoSouls.ItemType("DeviousAestheticus") ||
                     item.type == ModsCall.FargoSouls.ItemType("ScientificRailgun") || item.type == ModsCall.FargoSouls.ItemType("VortexMagnetRitual") ||
                     item.type == ModsCall.FargoSouls.ItemType("CrimetroidEgg"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "tooltip");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.Tooltip");
                }
            }
            else if (item.type == ItemID.RodofDiscord)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.RodofDiscord");
                }
            }
            else if (item.type == ItemID.ArcheryPotion ||
                     item.type == ItemID.MagicQuiver ||
                     item.type == ItemID.ShroomiteHelmet ||
                     item.type == ItemID.ShroomiteHeadgear ||
                     item.type == ItemID.ShroomiteMask)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.ComboItems");
                }
            }
            else if (item.type == ItemID.CrystalBullet || item.type == ItemID.HolyArrow)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf2");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf2.CrystalBullet.HolyArrow");
                }
            }
            else if (item.type == ItemID.ChlorophyteBullet)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf2");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf2.ChlorophyteBullet");
                }
            }
            else if (item.type == ItemID.WaterBolt && !NPC.downedBoss3)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.WaterBolt");
                }
            }
            else if (item.type >= 1215 && item.type <= 1219)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.TitaniumPieces");
                }
            }
            else if (item.type == ItemID.StardustCellStaff)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.StardustCellStaff");
                }
            }
            else if (item.type == ItemID.DD2BetsyBow || item.type == ItemID.Uzi ||
                     item.type == ItemID.PhoenixBlaster || item.type == ItemID.LastPrism ||
                     item.type == ItemID.OnyxBlaster || item.type == ItemID.SkyFracture ||
                     item.type == ItemID.Handgun || item.type == ItemID.SpikyBall ||
                     item.type == ItemID.SDMG || item.type == ItemID.Xenopopper ||
                     item.type == ItemID.NebulaArcanum || item.type == ItemID.PainterPaintballGun ||
                     item.type == ItemID.MoltenFury || item.type == ItemID.Phantasm)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.ComboItems2");
                }
            }
            else if (item.type == ItemID.SkyFracture || item.type == ItemID.SnowmanCannon)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.SkyFracture");
                }
            }
            else if (item.type == ItemID.Tsunami || item.type == ItemID.Flairon || item.type == ItemID.ChlorophyteShotbow ||
                     item.type == ItemID.HellwingBow || item.type == ItemID.DartPistol ||
                     item.type == ItemID.DartRifle || item.type == ItemID.Megashark ||
                     item.type == ItemID.BatScepter || item.type == ItemID.XenoStaff ||
                     item.type == ItemID.ChainGun || item.type == ItemID.VortexBeater ||
                     item.type == ItemID.SnowmanCannon || item.type == ItemID.RavenStaff ||
                     item.type == ItemID.XenoStaff)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.ComboItems4");
                }
            }
            else if (item.type == ItemID.StarCannon || item.type == ItemID.ElectrosphereLauncher ||
                     item.type == ItemID.BeesKnees || item.type == ItemID.DaedalusStormbow || item.type == ItemID.LaserMachinegun)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.ComboItems3");
                }
            }
            else if (item.type == ItemID.Beenade || item.type == ItemID.Razorpine)
            {
                TooltipLine masoNerf = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                TooltipLine masoNerf2 = tooltips.FirstOrDefault(x => x.Name == "masoNerf2");
                if (masoNerf != null)
                {
                    masoNerf.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.ComboItems6");
                }
                if (masoNerf2 != null)
                {
                    masoNerf2.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf2.ComboItems6");
                }
            }
            else if (item.type == ItemID.BeeGun || item.type == ItemID.Grenade)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf2");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf2.BeeGun");
                }
            }
            else if (item.type == ItemID.DD2BallistraTowerT1Popper || item.type == ItemID.DD2BallistraTowerT2Popper ||
                     item.type == ItemID.DD2BallistraTowerT3Popper || item.type == ItemID.DD2ExplosiveTrapT1Popper ||
                     item.type == ItemID.DD2ExplosiveTrapT2Popper || item.type == ItemID.DD2ExplosiveTrapT3Popper ||
                     item.type == ItemID.DD2FlameburstTowerT1Popper || item.type == ItemID.DD2FlameburstTowerT2Popper ||
                     item.type == ItemID.DD2FlameburstTowerT3Popper || item.type == ItemID.DD2LightningAuraT1Popper ||
                     item.type == ItemID.DD2LightningAuraT2Popper || item.type == ItemID.DD2LightningAuraT3Popper)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.ComboItems7");
                }
            }
            else if (item.type == ItemID.SpiderStaff || item.type == ItemID.OpticStaff || item.type == ItemID.DeadlySphereStaff)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoBuff");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoBuff.ComboItems8");
                }
            }
            else if (item.type == ItemID.SpectreHood)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.SpectreHood");
                }
            }
            else if (item.type == ItemID.FrozenTurtleShell)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.FrozenTurtleShell");
                }
            }
            else if (item.type == ItemID.VampireKnives)
            {
                TooltipLine masoNerf = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                TooltipLine masoNerf2 = tooltips.FirstOrDefault(x => x.Name == "masoNerf2");
                TooltipLine masoNerf1 = tooltips.FirstOrDefault(x => x.Name == "masoNerf" && x.text == "[c/ff0000:Eternity Mode:] Reduced attack speed by 25%");
                if (masoNerf != null)
                {
                    masoNerf.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.VampireKnives");
                }
                if (masoNerf2 != null)
                {
                    masoNerf2.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf2.VampireKnives");
                }
                if (masoNerf1 != null)
                {
                    masoNerf1.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.VampireKnives1");
                }
            }
            else if (item.type == ItemID.BlizzardStaff || item.type == ItemID.Razorpine)
            {
                TooltipLine masoNerf = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                TooltipLine masoNerf2 = tooltips.FirstOrDefault(x => x.Name == "masoNerf2");
                if (masoNerf != null)
                {
                    masoNerf.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.ComboItems5");
                }
                if (masoNerf2 != null)
                {
                    masoNerf2.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf2.ComboItems5");
                }
            }
            else if (item.type == ItemID.DemonScythe)
            {
                TooltipLine masoNerf = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                TooltipLine masoNerf2 = tooltips.FirstOrDefault(x => x.Name == "masoNerf2");
                if (NPC.downedBoss2)
                {
                    if (masoNerf != null)
                    {
                        masoNerf.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.DemonScythe1");
                    }
                }
                else
                {
                    if (masoNerf != null)
                    {
                        masoNerf.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.DemonScythe");
                    }
                    if (masoNerf2 != null)
                    {
                        masoNerf2.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf2.DemonScythe");
                    }
                }
            }
            else if (item.type == ItemID.SpaceGun)
            {
                TooltipLine masoNerf = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                TooltipLine masoNerf1 = tooltips.FirstOrDefault(x => x.Name == "masoNerf" && x.text == "[c/ff0000:Eternity Mode:] Reduced attack speed by 25% until an evil boss is defeated");
                if (NPC.downedBoss2)
                {
                    if (masoNerf != null)
                    {
                        masoNerf.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.SpaceGun");
                    }
                }
                else
                {
                    if (masoNerf != null)
                    {
                        masoNerf.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.SpaceGun1");
                    }
                    if (masoNerf1 != null)
                    {
                        masoNerf1.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.SpaceGun2");
                    }
                }
            }
            else if (item.type == ItemID.DD2SquireBetsySword)
            {
                TooltipLine masoBuff = tooltips.FirstOrDefault(x => x.Name == "masoBuff");
                TooltipLine masoBuff2 = tooltips.FirstOrDefault(x => x.Name == "masoBuff2");
                if (masoBuff != null)
                {
                    masoBuff.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoBuff.DD2SquireBetsySword");
                }
                if (masoBuff2 != null)
                {
                    masoBuff2.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoBuff2.DD2SquireBetsySword");
                }
            }
            else if (item.type == ItemID.MonkStaffT3)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoBuff");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoBuff.MonkStaffT3");
                }
            }
            else if (item.type == ItemID.SlimeStaff)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoBuff");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoBuff.SlimeStaff");
                }
            }
            else if (item.type == ItemID.MonkAltHead || item.type == ItemID.MonkAltPants || item.type == ItemID.MonkAltShirt ||
                     item.type == ItemID.MonkBrows || item.type == ItemID.MonkPants || item.type == ItemID.MonkShirt ||
                     item.type == ItemID.SquireAltHead || item.type == ItemID.SquireAltPants || item.type == ItemID.SquireAltShirt ||
                     item.type == ItemID.SquireGreatHelm || item.type == ItemID.SquireGreaves || item.type == ItemID.SquirePlating ||
                     item.type == ItemID.HuntressAltHead || item.type == ItemID.HuntressAltPants || item.type == ItemID.HuntressAltShirt ||
                     item.type == ItemID.HuntressJerkin || item.type == ItemID.HuntressPants || item.type == ItemID.HuntressWig ||
                     item.type == ItemID.ApprenticeAltHead || item.type == ItemID.ApprenticeAltPants || item.type == ItemID.ApprenticeAltShirt ||
                     item.type == ItemID.ApprenticeHat || item.type == ItemID.ApprenticeRobe || item.type == ItemID.ApprenticeTrousers ||
                     item.type == ItemID.AncientBattleArmorHat || item.type == ItemID.AncientBattleArmorPants || item.type == ItemID.AncientBattleArmorShirt)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoBuff");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoBuff.ComboItems9");
                }
            }
            else if (item.type == ModsCall.FargoSouls.ItemType("CosmoForce"))
            {
                if (tooltip0 != null)
                    tooltip0.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.CosmoForce.Tooltip0", $"[i:{ModsCall.FargoSouls.ItemType("MeteorEnchant")}]");
                if (tooltip1 != null)
                    tooltip1.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.CosmoForce.Tooltip1", $"[i:{ModsCall.FargoSouls.ItemType("SolarEnchant")}]");
                if (tooltip2 != null)
                    tooltip2.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.CosmoForce.Tooltip2", $"[i:{ModsCall.FargoSouls.ItemType("SolarEnchant")}]");
                if (tooltip3 != null)
                    tooltip3.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.CosmoForce.Tooltip3", $"[i:{ModsCall.FargoSouls.ItemType("VortexEnchant")}]");
                if (tooltip4 != null)
                    tooltip4.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.CosmoForce.Tooltip4", $"[i:{ModsCall.FargoSouls.ItemType("NebulaEnchant")}]");
                if (tooltip5 != null)
                    tooltip5.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.CosmoForce.Tooltip5", $"[i:{ModsCall.FargoSouls.ItemType("StardustEnchant")}]");
                if (tooltip6 != null)
                    tooltip6.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.CosmoForce.Tooltip6", $"[i:{ModsCall.FargoSouls.ItemType("StardustEnchant")}]");
                if (tooltip7 != null)
                    tooltip7.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.CosmoForce.Tooltip7");
            }
            else if (item.type == ModsCall.FargoSouls.ItemType("EarthForce"))
            {
                if (tooltip0 != null)
                    tooltip0.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.EarthForce.Tooltip0", $"[i:{ModsCall.FargoSouls.ItemType("CobaltEnchant")}]");
                if (tooltip1 != null)
                    tooltip1.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.EarthForce.Tooltip1", $"[i:{ModsCall.FargoSouls.ItemType("MythrilEnchant")}]");
                if (tooltip2 != null)
                    tooltip2.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.EarthForce.Tooltip2", $"[i:{ModsCall.FargoSouls.ItemType("PalladiumEnchant")}]");
                if (tooltip3 != null)
                    tooltip3.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.EarthForce.Tooltip3", $"[i:{ModsCall.FargoSouls.ItemType("PalladiumEnchant")}]");
                if (tooltip4 != null)
                    tooltip4.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.EarthForce.Tooltip4", $"[i:{ModsCall.FargoSouls.ItemType("OrichalcumEnchant")}]");
                if (tooltip5 != null)
                    tooltip5.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.EarthForce.Tooltip5", $"[i:{ModsCall.FargoSouls.ItemType("OrichalcumEnchant")}]");
                if (tooltip6 != null)
                    tooltip6.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.EarthForce.Tooltip6", $"[i:{ModsCall.FargoSouls.ItemType("AdamantiteEnchant")}]");
                if (tooltip7 != null)
                    tooltip7.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.EarthForce.Tooltip7", $"[i:{ModsCall.FargoSouls.ItemType("TitaniumEnchant")}]");
                if (tooltip8 != null)
                    tooltip8.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.EarthForce.Tooltip8");
            }
            else if (item.type == ModsCall.FargoSouls.ItemType("LifeForce"))
            {
                if (tooltip0 != null)
                    tooltip0.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.LifeForce.Tooltip0", $"[i:{ModsCall.FargoSouls.ItemType("PumpkinEnchant")}]");
                if (tooltip1 != null)
                    tooltip1.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.LifeForce.Tooltip1", $"[i:{ModsCall.FargoSouls.ItemType("CactusEnchant")}]");
                if (tooltip2 != null)
                    tooltip2.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.LifeForce.Tooltip2", $"[i:{ModsCall.FargoSouls.ItemType("BeeEnchant")}]");
                if (tooltip3 != null)
                    tooltip3.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.LifeForce.Tooltip3", $"[i:{ModsCall.FargoSouls.ItemType("SpiderEnchant")}]");
                if (tooltip4 != null)
                    tooltip4.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.LifeForce.Tooltip4", $"[i:{ModsCall.FargoSouls.ItemType("TurtleEnchant")}]");
                if (tooltip5 != null)
                    tooltip5.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.LifeForce.Tooltip5", $"[i:{ModsCall.FargoSouls.ItemType("BeetleEnchant")}]");
                if (tooltip6 != null)
                    tooltip6.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.LifeForce.Tooltip6", $"[i:{ModsCall.FargoSouls.ItemType("BeetleEnchant")}]");
                if (tooltip7 != null)
                    tooltip7.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.LifeForce.Tooltip7");
            }
            else if (item.type == ModsCall.FargoSouls.ItemType("NatureForce"))
            {
                if (tooltip0 != null)
                    tooltip0.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.NatureForce.Tooltip0", $"[i:{ModsCall.FargoSouls.ItemType("CrimsonEnchant")}]");
                if (tooltip1 != null)
                    tooltip1.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.NatureForce.Tooltip1", $"[i:{ModsCall.FargoSouls.ItemType("MoltenEnchant")}]");
                if (tooltip2 != null)
                    tooltip2.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.NatureForce.Tooltip2", $"[i:{ModsCall.FargoSouls.ItemType("MoltenEnchant")}]");
                if (tooltip3 != null)
                    tooltip3.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.NatureForce.Tooltip3", $"[i:{ModsCall.FargoSouls.ItemType("RainEnchant")}]");
                if (tooltip4 != null)
                    tooltip4.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.NatureForce.Tooltip4", $"[i:{ModsCall.FargoSouls.ItemType("FrostEnchant")}]");
                if (tooltip5 != null)
                    tooltip5.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.NatureForce.Tooltip5", $"[i:{ModsCall.FargoSouls.ItemType("SnowEnchant")}]");
                if (tooltip6 != null)
                    tooltip6.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.NatureForce.Tooltip6", $"[i:{ModsCall.FargoSouls.ItemType("ChlorophyteEnchant")}]");
                if (tooltip7 != null)
                    tooltip7.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.NatureForce.Tooltip7", $"[i:{ModsCall.FargoSouls.ItemType("JungleEnchant")}]");
                if (tooltip8 != null)
                    tooltip8.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.NatureForce.Tooltip8", $"[i:{ModsCall.FargoSouls.ItemType("ShroomiteEnchant")}]");
                if (tooltip9 != null)
                    tooltip9.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.NatureForce.Tooltip9", $"[i:{ModsCall.FargoSouls.ItemType("ShroomiteEnchant")}]");
                if (tooltip10 != null)
                    tooltip10.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.NatureForce.Tooltip10");
            }
            else if (item.type == ModsCall.FargoSouls.ItemType("ShadowForce"))
            {
                if (tooltip0 != null)
                    tooltip0.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.ShadowForce.Tooltip0", $"[i:{ModsCall.FargoSouls.ItemType("ShadowEnchant")}]");
                if (tooltip1 != null)
                    tooltip1.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.ShadowForce.Tooltip1", $"[i:{ModsCall.FargoSouls.ItemType("AncientShadowEnchant")}]");
                if (tooltip2 != null)
                    tooltip2.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.ShadowForce.Tooltip2", $"[i:{ModsCall.FargoSouls.ItemType("NecroEnchant")}]");
                if (tooltip3 != null)
                    tooltip3.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.ShadowForce.Tooltip3", $"[i:{ModsCall.FargoSouls.ItemType("SpookyEnchant")}]");
                if (tooltip4 != null)
                    tooltip4.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.ShadowForce.Tooltip4", $"[i:{ModsCall.FargoSouls.ItemType("NinjaEnchant")}]");
                if (tooltip5 != null)
                    tooltip5.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.ShadowForce.Tooltip5", $"[i:{ModsCall.FargoSouls.ItemType("MonkEnchant")}]");
                if (tooltip6 != null)
                    tooltip6.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.ShadowForce.Tooltip6", $"[i:{ModsCall.FargoSouls.ItemType("ShinobiEnchant")}]");
                if (tooltip7 != null)
                    tooltip7.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.ShadowForce.Tooltip7", $"[i:{ModsCall.FargoSouls.ItemType("DarkArtistEnchant")}]");
                if (tooltip8 != null)
                    tooltip8.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.ShadowForce.Tooltip8", $"[i:{ModsCall.FargoSouls.ItemType("ApprenticeEnchant")}]");
                if (tooltip9 != null)
                    tooltip9.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.ShadowForce.Tooltip9", $"[i:{ModsCall.FargoSouls.ItemType("ApprenticeEnchant")}]");
                if (tooltip10 != null)
                    tooltip10.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.ShadowForce.Tooltip10");
            }
            else if (item.type == ModsCall.FargoSouls.ItemType("SpiritForce"))
            {
                if (tooltip0 != null)
                    tooltip0.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.SpiritForce.Tooltip0", $"[i:{ModsCall.FargoSouls.ItemType("FossilEnchant")}]");
                if (tooltip1 != null)
                    tooltip1.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.SpiritForce.Tooltip1", $"[i:{ModsCall.FargoSouls.ItemType("FossilEnchant")}]");
                if (tooltip2 != null)
                    tooltip2.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.SpiritForce.Tooltip2", $"[i:{ModsCall.FargoSouls.ItemType("ForbiddenEnchant")}]");
                if (tooltip3 != null)
                    tooltip3.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.SpiritForce.Tooltip3", $"[i:{ModsCall.FargoSouls.ItemType("ForbiddenEnchant")}]");
                if (tooltip4 != null)
                    tooltip4.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.SpiritForce.Tooltip4", $"[i:{ModsCall.FargoSouls.ItemType("HallowEnchant")}]");
                if (tooltip5 != null)
                    tooltip5.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.SpiritForce.Tooltip5", $"[i:{ModsCall.FargoSouls.ItemType("HallowEnchant")}]");
                if (tooltip6 != null)
                    tooltip6.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.SpiritForce.Tooltip6", $"[i:{ModsCall.FargoSouls.ItemType("TikiEnchant")}]");
                if (tooltip7 != null)
                    tooltip7.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.SpiritForce.Tooltip7", $"[i:{ModsCall.FargoSouls.ItemType("TikiEnchant")}]");
                if (tooltip8 != null)
                    tooltip8.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.SpiritForce.Tooltip8", $"[i:{ModsCall.FargoSouls.ItemType("SpectreEnchant")}]");
                if (tooltip9 != null)
                    tooltip9.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.SpiritForce.Tooltip9");
            }
            else if (item.type == ModsCall.FargoSouls.ItemType("TerraForce"))
            {
                if (tooltip0 != null)
                    tooltip0.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TerraForce.Tooltip0", $"[i:{ModsCall.FargoSouls.ItemType("CopperEnchant")}]");
                if (tooltip1 != null)
                    tooltip1.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TerraForce.Tooltip1", $"[i:{ModsCall.FargoSouls.ItemType("TinEnchant")}]");
                if (tooltip2 != null)
                    tooltip2.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TerraForce.Tooltip2", $"[i:{ModsCall.FargoSouls.ItemType("TinEnchant")}]");
                if (tooltip3 != null)
                    tooltip3.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TerraForce.Tooltip3", $"[i:{ModsCall.FargoSouls.ItemType("IronEnchant")}]");
                if (tooltip4 != null)
                    tooltip4.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TerraForce.Tooltip4", $"[i:{ModsCall.FargoSouls.ItemType("IronEnchant")}]");
                if (tooltip5 != null)
                    tooltip5.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TerraForce.Tooltip5", $"[i:{ModsCall.FargoSouls.ItemType("LeadEnchant")}]");
                if (tooltip6 != null)
                    tooltip6.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TerraForce.Tooltip6", $"[i:{ModsCall.FargoSouls.ItemType("TungstenEnchant")}]");
                if (tooltip7 != null)
                    tooltip7.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TerraForce.Tooltip7", $"[i:{ModsCall.FargoSouls.ItemType("TungstenEnchant")}]");
                if (tooltip8 != null)
                    tooltip8.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TerraForce.Tooltip8");
            }
            else if (item.type == ModsCall.FargoSouls.ItemType("TimberForce"))
            {
                if (tooltip0 != null)
                    tooltip0.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TimberForce.Tooltip0", $"[i:{ModsCall.FargoSouls.ItemType("WoodEnchant")}]");
                if (tooltip1 != null)
                    tooltip1.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TimberForce.Tooltip1", $"[i:{ModsCall.FargoSouls.ItemType("BorealWoodEnchant")}]");
                if (tooltip2 != null)
                    tooltip2.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TimberForce.Tooltip2", $"[i:{ModsCall.FargoSouls.ItemType("RichMahoganyEnchant")}]");
                if (tooltip3 != null)
                    tooltip3.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TimberForce.Tooltip3", $"[i:{ModsCall.FargoSouls.ItemType("EbonwoodEnchant")}]");
                if (tooltip4 != null)
                    tooltip4.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TimberForce.Tooltip4", $"[i:{ModsCall.FargoSouls.ItemType("PalmWoodEnchant")}]");
                if (tooltip5 != null)
                    tooltip5.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TimberForce.Tooltip5", $"[i:{ModsCall.FargoSouls.ItemType("PearlwoodEnchant")}]");
                if (tooltip6 != null)
                    tooltip6.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.TimberForce.Tooltip6");
            }
            else if (item.type == ModsCall.FargoSouls.ItemType("WillForce"))
            {
                if (tooltip0 != null)
                    tooltip0.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.WillForce.Tooltip0", $"[i:{ModsCall.FargoSouls.ItemType("GoldEnchant")}]");
                if (tooltip1 != null)
                    tooltip1.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.WillForce.Tooltip1", $"[i:{ModsCall.FargoSouls.ItemType("PlatinumEnchant")}]");
                if (tooltip2 != null)
                    tooltip2.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.WillForce.Tooltip2", $"[i:{ModsCall.FargoSouls.ItemType("GladiatorEnchant")}]");
                if (tooltip3 != null)
                    tooltip3.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.WillForce.Tooltip3", $"[i:{ModsCall.FargoSouls.ItemType("RedRidingEnchant")}]");
                if (tooltip4 != null)
                    tooltip4.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.WillForce.Tooltip4", $"[i:{ModsCall.FargoSouls.ItemType("ValhallaKnightEnchant")}]");
                if (tooltip5 != null)
                    tooltip5.text = LangUtils.GetTextValue("FargoSouls", "ItemTooltip.WillForce.Tooltip5");
            }
            
            if (item.ammo != AmmoID.None && item.damage > 0)
            {
                if (item.ammo == AmmoID.Arrow || item.ammo == AmmoID.Bullet || item.ammo == AmmoID.Dart)
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                    if (tooltip != null)
                    {
                        tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.Ammo");
                    }
                }
                else if (!(item.type >= 71 && item.type <= 74))
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                    if (tooltip != null)
                    {
                        tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoNerf.AmmoRocket");
                    }
                }
            }

            if (item.summon)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoMinionNerf");
                if (tooltip != null)
                {
                    tooltip.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.masoMinionNerf.masoMinionNerfSummonItems");
                }
            }

            foreach (var tooltipLine in tooltips.Where(tooltipLine => tooltipLine.Name == "help"))
            {
                tooltipLine.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.Help");
            }
            
            foreach (var tooltipLine in tooltips.Where(tooltipLine => tooltipLine.Name == "FargowiltasSouls:Eternity"))
            {
                tooltipLine.text = LangUtils.GetTextValue("FargoSouls", "TooltipName.Eternity");
            }
        }
    }
}