using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.Items
{
    public class ModifiedGlobalItemTooltips : GlobalItem
    {
        public override bool Autoload(ref string name) => CoreFargowiltasSoulsTranslation.FargoSouls != null;

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("EternitySoul"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "tooltip");
                if (tooltip != null)
                {
                    tooltip.text = tooltip.text
                        .Replace("250% increased damage", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.1"))
                        .Replace("250% increased attack speed", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.2"))
                        .Replace("100% increased shoot speed", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.3"))
                        .Replace("100% increased knockback", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.4"))
                        .Replace("Increases armor penetration by 50", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.5"))
                        .Replace("Crits deal 10x damage", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.6"))
                        .Replace("Drastically increases life regeneration", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.7"))
                        .Replace("Increases your maximum mana to 999", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.8"))
                        .Replace("Increases your maximum minions by 30", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.9"))
                        .Replace("Increases your maximum sentries by 20", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.10"))
                        .Replace("Increases your maximum HP by 50%", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.11"))
                        .Replace("All attacks inflict Flames of the Universe", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.12"))
                        .Replace("All attacks inflict Sadism", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.13"))
                        .Replace("All attacks inflict Midas", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.14"))
                        .Replace("All attacks reduce enemy immunity frames", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.15"))
                        .Replace("Summons fireballs arund you", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.16"))
                        .Replace("Summons 2 shadow orbs around you", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.17"))
                        .Replace("Summons icicles around you", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.18"))
                        .Replace("Summons leaf crystals around you", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.19"))
                        .Replace("Summons a hallowed sword and shield", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.20"))
                        .Replace("Summons beetles to protect you", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.21"))
                        .Replace("Summons a Flameburst minion", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.22"))
                        .Replace("Summons a ton of pets", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.23"))
                        .Replace("Summons all Eternity Mode bosses to your side ", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.24"))
                        .Replace("Attacks may spawn lightning", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.25"))
                        .Replace("Attacks may spawn flower petals", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.26"))
                        .Replace("Attacks may spawn spectre orbs", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.27"))
                        .Replace("Attacks may spawn a Dungeon Guardian", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.28"))
                        .Replace("Attacks may spawn snowballs", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.29"))
                        .Replace("Attacks may spawn spears", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.30"))
                        .Replace("Attacks may spawn hearts", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.31"))
                        .Replace("Attacks may spawn a miniture storm", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.32"))
                        .Replace("Attacks may spawn buff boosters", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.33"))
                        .Replace("Attacks cause increased life regen", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.34"))
                        .Replace("Attacks cause shadow dodge", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.35"))
                        .Replace("Attacks cause Flameburst shots", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.36"))
                        .Replace("Attacks cause Pumpking attacks", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.37"))
                        .Replace("Attacks cause Cultist spells", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.38"))
                        .Replace("Attacks cause meteor showers", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.39"))
                        .Replace("All Projectiles will split", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.40"))
                        .Replace("Projectiles may shatter", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.41"))
                        .Replace("Projectiles spawn stars", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.42"))
                        .Replace("Item and projectile size increased", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.43"))
                        .Replace("You leave a trail of fire", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.44"))
                        .Replace("Nearby enemies are ignited", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.45"))
                        .Replace("Minions occasionally spew scythes", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.46"))
                        .Replace("You may spawn temporary minions", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.47"))
                        .Replace("Critters have increased defense", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.48"))
                        .Replace("Critter's souls may aid you", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.49"))
                        .Replace("Enemies explode into needles", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.50"))
                        .Replace("Greatly enhances all DD2 sentries", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.51"))
                        .Replace("Double-tap down to spawn a palm tree sentry", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.52"))
                        .Replace("Double-tap down to call an ancient storm", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.53"))
                        .Replace("Double-tap down to call a rain of arrows", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.54"))
                        .Replace("Double-tap down to toggle stealth", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.55"))
                        .Replace("Double-tap down to spawn a portal", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.56"))
                        .Replace("Double-tap down to direct your empowered guardian", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.57"))
                        .Replace("Right Click to Guard", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.58"))
                        .Replace("Press the Gold Key to encase yourself in gold", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.59"))
                        .Replace("Press the Freeze Key to freeze time for 5 seconds", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.60"))
                        .Replace("Solar shield allows you to dash", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.61"))
                        .Replace("Dashing into solid blocks teleports you through them", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.62"))
                        .Replace("Throw a smoke bomb to teleport to it and gain the first strike buff", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.63"))
                        .Replace("Jumping will release a spore explosion", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.64"))
                        .Replace("Enemies getting too close will trigger all on hit effects", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.65"))
                        .Replace("Getting hit reflects damage", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.66"))
                        .Replace("Getting hit triggers a blood geyser", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.67"))
                        .Replace("Getting hit may squeak", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.68"))
                        .Replace("Getting hit causes you to erupt into spiky balls", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.69"))
                        .Replace("Getting hit causes you to erupt into Ancient Visions", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.70"))
                        .Replace("Grants Crimson regen", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.71"))
                        .Replace("Grants immunity to fire", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.72"))
                        .Replace("Grants immunity to fall damage", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.73"))
                        .Replace("Grants immunity to lava", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.74"))
                        .Replace("Grants immunity to knockback", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.75"))
                        .Replace("Grants immunity to most debuffs", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.76"))
                        .Replace("Grants doubled herb collection", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.77"))
                        .Replace("Grants 50% chance for Mega Bees", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.78"))
                        .Replace("15% chance for minion crits", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.79"))
                        .Replace("20% chance for bonus loot", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.80"))
                        .Replace("Allows Supersonic running and ", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.81"))
                        .Replace("Allows infinite flight", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.82"))
                        .Replace("Increases fishing skill substantially", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.83"))
                        .Replace("All fishing rods will have 10 extra lures", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.84"))
                        .Replace("You respawn 10x as fast", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.85"))
                        .Replace("Prevents boss spawns", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.86"))
                        .Replace("Increases spawn rates", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.87"))
                        .Replace("Reduces skeletons hostility outside of the dungeon", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.88"))
                        .Replace("Empowers Cute Fishron", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.89"))
                        .Replace("Grants autofire", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.90"))
                        .Replace("Grants modifier protection", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.91"))
                        .Replace("Grants gravity control", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.92"))
                        .Replace("Grants fast fall", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.93"))
                        .Replace("Enhances grappling hooks", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.94"))
                        .Replace("You attract items from further away", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.95"))
                        .Replace("Increased block and wall placement speed by 50%", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.96"))
                        .Replace("Near infinite block placement", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.97"))
                        .Replace("Near infinite mining reach", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.98"))
                        .Replace("Mining speed dramatically increased", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.99"))
                        .Replace("You reflect all projectiles", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.100"))
                        .Replace("When you are hurt, you violently explode to damage nearby enemies", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.101"))
                        .Replace("When you die, you revive with full HP", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.102"))
                        .Replace("Effects of Fire Gauntlet", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.103"))
                        .Replace("Effects of Yoyo Bag", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.104"))
                        .Replace("Effects of Sniper Scope", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.105"))
                        .Replace("Effects of Celestial Cuffs", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.106"))
                        .Replace("Effects of Mana Flower", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.107"))
                        .Replace("Effects of Brain of Confusion", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.108"))
                        .Replace("Effects of Star Veil", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.109"))
                        .Replace("Effects of Sweetheart Necklace", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.110"))
                        .Replace("Effects of Bee Cloak", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.111"))
                        .Replace("Effects of Spore Sac", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.112"))
                        .Replace("Effects of Paladin's Shield", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.113"))
                        .Replace("Effects of Frozen Turtle Shell", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.114"))
                        .Replace("Effects of Arctic Diving Gear", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.115"))
                        .Replace("Effects of Frog Legs", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.116"))
                        .Replace("Effects of Flying Carpet", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.117"))
                        .Replace("Effects of Lava Waders", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.118"))
                        .Replace("Effects of Angler Tackle Bag", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.119"))
                        .Replace("Effects of Paint Sprayer", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.120"))
                        .Replace("Effects of Presserator", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.121"))
                        .Replace("Effects of Cell Phone", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.122"))
                        .Replace("Effects of Flower Boots", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.123"))
                        .Replace("Effects of Master Ninja Gear", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.124"))
                        .Replace("Effects of Greedy Ring", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.125"))
                        .Replace("Effects of Celestial Shell", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.126"))
                        .Replace("Effects of Shiny Stone", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.127"))
                        .Replace("Effects of Spelunker potion", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.128"))
                        .Replace("Effects of Dangersense potion", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.129"))
                        .Replace("Effects of Hunter potion", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.130"))
                        .Replace("Effects of Shine potion", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.131"))
                        .Replace("Effects of Builder Mode", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.132"))
                        .Replace("Armor bonuses from Living Wood", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.133"))
                        .Replace("Armor bonuses from Life Bloom", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.134"))
                        .Replace("Armor bonuses from Yew Wood", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.135"))
                        .Replace("Armor bonuses from Tide Hunter", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.136"))
                        .Replace("Armor bonuses from Icy", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.137"))
                        .Replace("Armor bonuses from Cryo Magus", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.138"))
                        .Replace("Armor bonuses from Whispering", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.139"))
                        .Replace("Armor bonuses from Sacred", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.140"))
                        .Replace("Armor bonuses from Warlock", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.141"))
                        .Replace("Armor bonuses from Biotech", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.142"))
                        .Replace("Armor bonuses from Cyber Punk", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.143"))
                        .Replace("Armor bonuses from Maestro", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.144"))
                        .Replace("Armor bonuses from Bronze", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.145"))
                        .Replace("Armor bonuses from Darksteel", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.146"))
                        .Replace("Armor bonuses from Durasteel", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.147"))
                        .Replace("Armor bonuses from Conduit", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.148"))
                        .Replace("Armor bonuses from Lodestone", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.149"))
                        .Replace("Armor bonuses from Illumite", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.150"))
                        .Replace("Armor bonuses from Jester", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.151"))
                        .Replace("Armor bonuses from Thorium", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.152"))
                        .Replace("Armor bonuses from Terrarium", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.153"))
                        .Replace("Armor bonuses from Malignant", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.154"))
                        .Replace("Armor bonuses from Folv", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.155"))
                        .Replace("Armor bonuses from White Dwarf", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.156"))
                        .Replace("Armor bonuses from Celestial", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.157"))
                        .Replace("Armor bonuses from Spirit Trapper", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.158"))
                        .Replace("Armor bonuses from Dragon", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.159"))
                        .Replace("Armor bonuses from Dread", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.160"))
                        .Replace("Armor bonuses from Flesh", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.161"))
                        .Replace("Armor bonuses from Demon Blood", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.162"))
                        .Replace("Armor bonuses from Tide Turner", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.163"))
                        .Replace("Armor bonuses from Assassin", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.164"))
                        .Replace("Armor bonuses from Pyromancer", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.165"))
                        .Replace("Armor bonuses from Dream Weaver", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.166"))
                        .Replace("Effects of Flawless Chrysalis", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.167"))
                        .Replace("Effects of Bubble Magnet", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.168"))
                        .Replace("Effects of Agnor's Bowl", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.169"))
                        .Replace("Effects of Ice Bound Strider Hide", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.170"))
                        .Replace("Effects of Ring of Unity", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.171"))
                        .Replace("Effects of Mix Tape", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.172"))
                        .Replace("Effects of Eye of the Storm", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.173"))
                        .Replace("Effects of Champion's Rebuttal", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.174"))
                        .Replace("Effects of Incandescent Spark", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.175"))
                        .Replace("Effects of Greedy Magnet", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.176"))
                        .Replace("Effects of Abyssal Shell", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.177"))
                        .Replace("Effects of Astro-Beetle Husk", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.178"))
                        .Replace("Effects of Eye of the Beholder", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.179"))
                        .Replace("Effects of Crietz", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.180"))
                        .Replace("Effects of Mana-Charged Rocketeers", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.181"))
                        .Replace("Effects of Inner Flame", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.182"))
                        .Replace("Effects of Crash Boots", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.183"))
                        .Replace("Effects of Vampire Gland", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.184"))
                        .Replace("Effects of Demon Blood Badge", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.185"))
                        .Replace("Effects of Lich's Gaze", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.186"))
                        .Replace("Effects of Plague Lord's Flask", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.187"))
                        .Replace("Effects of Phylactery", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.188"))
                        .Replace("Effects of Crystal Scorpion", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.189"))
                        .Replace("Effects of Guide to Expert Throwing - Volume III", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.190"))
                        .Replace("Effects of Mermaid's Canteen", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.191"))
                        .Replace("Effects of Deadman's Patch", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.192"))
                        .Replace("Effects of Support Sash", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.193"))
                        .Replace("Effects of Saving Grace", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.194"))
                        .Replace("Effects of Soul Guard", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.195"))
                        .Replace("Effects of Archdemon's Curse", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.196"))
                        .Replace("Effects of Archangel's Heart", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.197"))
                        .Replace("Effects of Medical Bag", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.198"))
                        .Replace("Effects of Epic Mouthpiece", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.199"))
                        .Replace("Effects of Straight Mute", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.200"))
                        .Replace("Effects of Digital Tuner", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.201"))
                        .Replace("Effects of Guitar Pick Claw", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.202"))
                        .Replace("Effects of Ocean's Retaliation", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.203"))
                        .Replace("Effects of Terrarium Defender", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.204"))
                        .Replace("Effects of Air Walkers", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.205"))
                        .Replace("Effects of Survivalist Boots", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.206"))
                        .Replace("Effects of Weighted Winglets", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.207"))
                        .Replace("Armor bonuses from Aerospec", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.208"))
                        .Replace("Armor bonuses from Statigel", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.209"))
                        .Replace("Armor bonuses from Daedalus", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.210"))
                        .Replace("Armor bonuses from Bloodflare", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.211"))
                        .Replace("Armor bonuses from Victide", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.212"))
                        .Replace("Armor bonuses from Xeroc", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.213"))
                        .Replace("Armor bonuses from Omega Blue", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.214"))
                        .Replace("Armor bonuses from God Slayer", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.215"))
                        .Replace("Armor bonuses from Silva", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.216"))
                        .Replace("Armor bonuses from Auric Tesla", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.217"))
                        .Replace("Armor bonuses from Mollusk", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.218"))
                        .Replace("Armor bonuses from Reaver", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.219"))
                        .Replace("Armor bonuses from Ataxia", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.220"))
                        .Replace("Armor bonuses from Astral", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.221"))
                        .Replace("Armor bonuses from Tarragon", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.222"))
                        .Replace("Armor bonuses from Demonshade", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.223"))
                        .Replace("Effects of Spirit Glyph", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.224"))
                        .Replace("Effects of Raider's Talisman", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.225"))
                        .Replace("Effects of Trinket of Chi", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.226"))
                        .Replace("Effects of Gladiator's Locket", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.227"))
                        .Replace("Effects of Unstable Prism", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.228"))
                        .Replace("Effects of Counter Scarf", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.229"))
                        .Replace("Effects of Fungal Symbiote", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.230"))
                        .Replace("Effects of Permafrost's Concoction", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.231"))
                        .Replace("Effects of Regenator", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.232"))
                        .Replace("Effects of Core of the Blood God", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.233"))
                        .Replace("Effects of Affliction", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.234"))
                        .Replace("Effects of Deep Dive", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.235"))
                        .Replace("Effects of The Transformer", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.236"))
                        .Replace("Effects of Luxor's Gift", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.237"))
                        .Replace("Effects of The Community", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.238"))
                        .Replace("Effects of Abyssal Diving Suit", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.239"))
                        .Replace("Effects of Lumenous Amulet", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.240"))
                        .Replace("Effects of Aquatic Emblem", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.241"))
                        .Replace("Effects of Nebulous Core", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.242"))
                        .Replace("Effects of Draedon's Heart", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.243"))
                        .Replace("Effects of The Amalgam", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.244"))
                        .Replace("Effects of Godly Soul Artifact", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.245"))
                        .Replace("Effects of Yharim's Gift", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.246"))
                        .Replace("Effects of Heart of the Elements", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.247"))
                        .Replace("Effects of The Sponge", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.248"))
                        .Replace("Effects of Giant Pearl", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.249"))
                        .Replace("Effects of Amidias' Pendant", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.250"))
                        .Replace("Effects of Fabled Tortoise Shell", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.251"))
                        .Replace("Effects of Plague Hive", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.252"))
                        .Replace("Effects of Astral Arcanum", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.253"))
                        .Replace("Effects of Hide of Astrum Deus", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.254"))
                        .Replace("Effects of Profaned Soul Artifact", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.255"))
                        .Replace("Effects of Dark Sun Ring", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.256"))
                        .Replace("Effects of Elemental Gauntlet", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.257"))
                        .Replace("Effects of Elemental Quiver", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.258"))
                        .Replace("Effects of Ethereal Talisman", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.259"))
                        .Replace("Effects of Statis' Belt of Curses", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.260"))
                        .Replace("Effects of Nanotech", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.261"))
                        .Replace("Effects of Asgardian Aegis", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.262"))
                        .Replace("Effects of Zenkai Charm", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.263"))
                        .Replace("Effects of Aspera Crystallite", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.264"))
                        .Replace("Armor bonuses from Bismuth", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.265"))
                        .Replace("Armor bonuses from Frosthunter", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.266"))
                        .Replace("Armor bonuses from Blightbone", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.267"))
                        .Replace("Armor bonuses from Dreadfire", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.268"))
                        .Replace("Armor bonuses from Space Junk", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.269"))
                        .Replace("Armor bonuses from Marstech", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.270"))
                        .Replace("Armor bonuses from Blazing Brute", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.271"))
                        .Replace("Armor bonuses from Cosmic Commander", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.272"))
                        .Replace("Armor bonuses from Nebulous Apprentic", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.273"))
                        .Replace("Armor bonuses from Stellar Priest", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.274"))
                        .Replace("Armor bonuses from Fallen Prince", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.275"))
                        .Replace("Armor bonuses from Void Warden", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.276"))
                        .Replace("Armor bonuses from Vulcan Reaper", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.277"))
                        .Replace("Armor bonuses from Flarium", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.278"))
                        .Replace("Armor bonuses from Asthraltite", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.279"))
                        .Replace("Effects of Dreadflame Emblem", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.280"))
                        .Replace("Effects of Lapis Pendant", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.281"))
                        .Replace("Effects of Frigid Pendant", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.282"))
                        .Replace("Effects of Pumpkin Amulet", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.283"))
                        .Replace("Effects of Nuba's Blessing", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.284"))
                        .Replace("Effects of Novaniel's Resolve", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.285"))
                        .Replace("Effects of Celestial Ring", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.286"))
                        .Replace("Effects of Ring of the Fallen", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.287"))
                        .Replace("Effects of Memento Mori", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.288"))
                        .Replace("Effects of Arcanum of the Caster", LangUtilities.GetTextValue("FargoSouls", "CustomTooltip.EternitySouls.289"));
                }
            }

            if (item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("MedallionoftheFallenKing") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("ComputationOrb") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("StaffOfUnleashedOcean") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("RoombaPet") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("PiranhaPlantVoodooDoll") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("FigBranch") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("ParadoxWolfSoul") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("SquidwardDoor") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("MissDrakovisFishingPole"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "tooltip");
                if (tooltip != null)
                {
                    tooltip.text = tooltip.text.Replace(">> Patreon Item <<", LangUtilities.GetTextValue("FargoSouls", "TooltipName.Tooltip"));
                }
            }

            if (item.ammo != AmmoID.None && item.damage > 0)
            {
                if (item.ammo == AmmoID.Arrow || item.ammo == AmmoID.Bullet || item.ammo == AmmoID.Dart)
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                    if (tooltip != null)
                    {
                        tooltip.text = tooltip.text.Replace("[c/ff0000:Eternity Mode:] Contributes 80% less damage to weapons", LangUtilities.GetTextValue("FargoSouls", "TooltipName.masoNerf1"));
                    }
                }
                else if (!(item.type >= 71 && item.type <= 74))
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                    if (tooltip != null)
                    {
                        tooltip.text = tooltip.text.Replace("[c/ff0000:Eternity Mode:] Contributes 20% less damage to weapons", LangUtilities.GetTextValue("FargoSouls", "TooltipName.masoNerf2"));
                    }
                }
            }

            if (item.type == ItemID.CrystalBullet || item.type == ItemID.HolyArrow)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf2");
                if (tooltip != null)
                {
                    tooltip.text = tooltip.text.Replace("[c/ff0000:Eternity Mode:] Can only split 4 times per second", LangUtilities.GetTextValue("FargoSouls", "TooltipName.masoNerf3"));
                }
            }

            if (item.type == ItemID.ChlorophyteBullet)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf2");
                if (tooltip != null)
                {
                    tooltip.text = tooltip.text.Replace("[c/ff0000:Eternity Mode:] Reduced speed and duration", LangUtilities.GetTextValue("FargoSouls", "TooltipName.masoNerf4"));
                }
            }

            if (item.type == ItemID.WaterBolt && !NPC.downedBoss3)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = tooltip.text.Replace("[c/ff0000:Eternity Mode:] Cannot be used until Skeletron is defeated", LangUtilities.GetTextValue("FargoSouls", "TooltipName.masoNerf5"));
                }
            }

            if (item.type >= 1215 && item.type <= 1219)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = tooltip.text.Replace("[c/ff0000:Eternity Mode:] Shadow Dodge activation will temporarily reduce your damage", LangUtilities.GetTextValue("FargoSouls", "TooltipName.masoNerf6"));
                }
            }

            if (item.type == ItemID.SpectreHood)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = tooltip.text.Replace("[c/ff0000:Eternity Mode:] Healing orbs move slower and disappear quickly", LangUtilities.GetTextValue("FargoSouls", "TooltipName.masoNerf7"));
                }
            }

            if (item.type == ItemID.FrozenTurtleShell)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf");
                if (tooltip != null)
                {
                    tooltip.text = tooltip.text.Replace("[c/ff0000:Eternity Mode:] Damage reduction is 15% instead of 25%", LangUtilities.GetTextValue("FargoSouls", "TooltipName.masoNerf8"));
                }
            }

            if (item.type == ItemID.VampireKnives)
            {
                if (item.type == ItemID.FrozenTurtleShell)
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "masoNerf2");
                    if (tooltip != null)
                    {
                        tooltip.text = tooltip.text.Replace("[c/ff0000:Eternity Mode:] Reduced chance of lifesteal", LangUtilities.GetTextValue("FargoSouls", "TooltipName.masoNerf9"));
                    }
                }
            }
            
            foreach (TooltipLine tooltipLine in tooltips)
            {
                if (tooltipLine.Name == "help")
                {
                    tooltipLine.text = tooltipLine.text.Replace("Right click to convert", LangUtilities.GetTextValue("FargoSouls", "TooltipName.Help"));
                }
            }
            
            foreach (TooltipLine tooltipLine in tooltips)
            {
                if (tooltipLine.Name == "FargowiltasSouls:Eternity")
                {
                    tooltipLine.text = tooltipLine.text.Replace("Eternity", LangUtilities.GetTextValue("FargoSouls", "TooltipName.Eternity"));
                }
            }
        }
    }
}