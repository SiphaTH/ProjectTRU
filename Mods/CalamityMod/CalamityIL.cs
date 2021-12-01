using System.Reflection;
using CalamityMod;
using CalamityMod.CalPlayer;
using CalamityMod.Events;
using CalamityMod.Items;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Placeables.Furniture.CraftingStations;
using CalamityMod.Items.Placeables.FurnitureAbyss;
using CalamityMod.Items.Placeables.FurnitureAncient;
using CalamityMod.Items.Placeables.FurnitureAshen;
using CalamityMod.Items.Placeables.FurnitureAstral;
using CalamityMod.Items.Placeables.FurnitureCosmilite;
using CalamityMod.Items.Placeables.FurnitureOccult;
using CalamityMod.Items.Placeables.FurnitureProfaned;
using CalamityMod.Items.Placeables.FurnitureStatigel;
using CalamityMod.Items.Placeables.FurnitureStratus;
using CalamityMod.Items.Placeables.FurnitureVoid;
using CalamityMod.Items.Placeables.Walls;
using CalamityMod.Items.Potions;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Items.Weapons.Ranged;
using CalamityMod.NPCs.Bumblebirb;
using CalamityMod.NPCs.Calamitas;
using CalamityMod.NPCs.NormalNPCs;
using CalamityMod.NPCs.Perforator;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.ProfanedGuardians;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.TownNPCs;
using CalamityMod.Projectiles.Boss;
using CalamityMod.Projectiles.Pets;
using CalamityMod.TileEntities;
using CalamityMod.Tiles.FurniturePlaguedPlate;
using CalamityMod.UI;
using CalamityMod.UI.CalamitasEnchants;
using CalamityMod.World;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;
using On.CalamityMod.Items.DifficultyItems;
using Terraria;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class RipperUIIL : ILEdit
    {
        private event ILContext.Manipulator RipperUIHook
        {
            add => HookEndpointManager.Modify(typeof(RipperUI).GetMethod("HandleMouseInteraction", BindingFlags.Static | BindingFlags.NonPublic), value);

            remove => HookEndpointManager.Unmodify(typeof(RipperUI).GetMethod("HandleMouseInteraction", BindingFlags.Static | BindingFlags.NonPublic), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => RipperUIHook += TranslationRipperUIHook;

        public override void Unload() => RipperUIHook -= TranslationRipperUIHook;

        private void TranslationRipperUIHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Adrenaline: ", "Адреналин: ");
            TranslationUtils.ILTranslate(il, "Rage: ", "Ярость: ");
        }
    }

    public class StealthUIIL : ILEdit
    {
        private event ILContext.Manipulator StealthUIHook
        {
            add => HookEndpointManager.Modify(typeof(StealthUI).GetMethod("Draw", BindingFlags.Static | BindingFlags.Public), value);

            remove => HookEndpointManager.Unmodify(typeof(StealthUI).GetMethod("Draw", BindingFlags.Static | BindingFlags.Public), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => StealthUIHook += TranslationStealthUIHook;

        public override void Unload() => StealthUIHook -= TranslationStealthUIHook;

        private void TranslationStealthUIHook(ILContext il) => TranslationUtils.ILTranslate(il, "Stealth: ", "Скрытность: ");
    }

    public class AcidRainUIIL : ILEdit
    {
        private event ILContext.Manipulator AcidRainUIHook
        {
            add => HookEndpointManager.Modify(typeof(AcidRainUI).GetMethod("get_InvasionName", BindingFlags.Instance | BindingFlags.Public), value);

            remove => HookEndpointManager.Unmodify(typeof(AcidRainUI).GetMethod("get_InvasionName", BindingFlags.Instance | BindingFlags.Public), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => AcidRainUIHook += TranslationAcidRainUIHook;

        public override void Unload() => AcidRainUIHook -= TranslationAcidRainUIHook;

        private void TranslationAcidRainUIHook(ILContext il) => TranslationUtils.ILTranslate(il, "Acid Rain", "Кислотный дождь");
    }

    public class CalamityPlayerIL : ILEdit
    {
        private event ILContext.Manipulator PreKillHook
        {
            add => HookEndpointManager.Modify(typeof(CalamityPlayer).GetMethod("PreKill", BindingFlags.Instance | BindingFlags.Public), value);

            remove => HookEndpointManager.Unmodify(typeof(CalamityPlayer).GetMethod("PreKill", BindingFlags.Instance | BindingFlags.Public), value);
        }

        private event ILContext.Manipulator KillPlayerHook
        {
            add => HookEndpointManager.Modify(typeof(CalamityPlayer).GetMethod("KillPlayer", BindingFlags.Instance | BindingFlags.Public), value);

            remove => HookEndpointManager.Unmodify(typeof(CalamityPlayer).GetMethod("KillPlayer", BindingFlags.Instance | BindingFlags.Public), value);
        }
        
        private event ILContext.Manipulator OnConsumeManaHook
        {
            add => HookEndpointManager.Modify(typeof(CalamityPlayer).GetMethod("OnConsumeMana", BindingFlags.Instance | BindingFlags.Public), value);

            remove => HookEndpointManager.Unmodify(typeof(CalamityPlayer).GetMethod("OnConsumeMana", BindingFlags.Instance | BindingFlags.Public), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            PreKillHook += TranslationPreKillHook;
            KillPlayerHook += TranslationKillPlayerHook;
            OnConsumeManaHook += TranslationOnConsumeManaHook;
        }

        public override void Unload()
        {
            PreKillHook -= TranslationPreKillHook;
            KillPlayerHook -= TranslationKillPlayerHook;
            OnConsumeManaHook -= TranslationOnConsumeManaHook;
        }

        private void TranslationPreKillHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, " downed too many shots.", " выпил слишком много напитков.");
            TranslationUtils.ILTranslate(il, "'s liver failed.", " отказала печень.");
            TranslationUtils.ILTranslate(il, " was charred by the brimstone inferno.", " был обуглен серным пламенем.");
            TranslationUtils.ILTranslate(il, "'s soul was released by the lava.", " душа была освобождена лавой.");
            TranslationUtils.ILTranslate(il, "'s soul was extinguished.", " душа была погашена.");
            TranslationUtils.ILTranslate(il, " was melted by the toxic waste.", " был расплавлен токсичными отходами.");
            TranslationUtils.ILTranslate(il, " disintegrated into ashes.", " рассыпался в прах.");
            TranslationUtils.ILTranslate(il, " was turned to ashes by the Profaned Goddess.", " был обращён Осквернённой богиней в пепел.");
            TranslationUtils.ILTranslate(il, " fell prey to their sins.", " пал жертвой своих грехов.");
            TranslationUtils.ILTranslate(il, "'s spirit was turned to ash.", " дух превратился в пепел.");
            TranslationUtils.ILTranslate(il, " became a blood geyser.", " стал кровавым гейзером.");
            TranslationUtils.ILTranslate(il, " was crushed by the pressure.", " был раздавлен давлением.");
            TranslationUtils.ILTranslate(il, "'s lungs collapsed.", " лёгкие отказали.");
            TranslationUtils.ILTranslate(il, " was consumed by the black flames.", " был поглощён чёрным пламенем.");
            TranslationUtils.ILTranslate(il, "'s flesh was melted by the plague.", " плоть была расплавлена чумой.");
            TranslationUtils.ILTranslate(il, " didn't vaccinate.", " не сделал прививок.");
            TranslationUtils.ILTranslate(il, "'s infection spread too far.", " инфекция распространилась слишком сильно.");
            TranslationUtils.ILTranslate(il, "'s skin was replaced by the astral virus.", " кожа была заменена астральным вирусом.");
            TranslationUtils.ILTranslate(il, " was incinerated by lunar rays.", " был испепелён лунными лучами.");
            TranslationUtils.ILTranslate(il, " vaporized into thin air.", " растворился в воздухе.");
            TranslationUtils.ILTranslate(il, "'s life was completely converted into mana.", " здоровье было полностью преобразовано в ману.");
            TranslationUtils.ILTranslate(il, " succumbed to alcohol sickness.", " поддался алкогольной болезни.");
            TranslationUtils.ILTranslate(il, " withered away.", " зачах.");
            TranslationUtils.ILTranslate(il, " was summoned too soon.", " был призван слишком рано.");
        }

        private void TranslationKillPlayerHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, " is food for the Wyrms.", " стал пищей для змей.");
            TranslationUtils.ILTranslate(il, "Oxygen failed to reach ", "Не хватило кислорода для ");
            TranslationUtils.ILTranslate(il, " from the depths of the Abyss.", " из глубин бездны.");
            TranslationUtils.ILTranslate(il, " was defeated.", " был повержен.");
            TranslationUtils.ILTranslate(il, " was chilled to the bone by the frigid environment.", " промёрз до костей из-за холодной окружающей среды.");
            TranslationUtils.ILTranslate(il, " failed the challenge at hand.", " не справился с испытанием.");
            TranslationUtils.ILTranslate(il, " was destroyed by a mysterious force.", " был уничтожен таинственной силой.");
        }
        
        private void TranslationOnConsumeManaHook(ILContext il) => TranslationUtils.ILTranslate(il, " converted all of their life to mana.", " обернул всю свою жизнь в ману.");
    }

    public class CheatTestThingIL : ILEdit
    {
        private event ILContext.Manipulator CheatTestThingHook
        {
            add => HookEndpointManager.Modify(typeof(CheatTestThing).GetMethod("UpdateAccessory", BindingFlags.Instance | BindingFlags.Public), value);

            remove => HookEndpointManager.Unmodify(typeof(CheatTestThing).GetMethod("UpdateAccessory", BindingFlags.Instance | BindingFlags.Public), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => CheatTestThingHook += TranslationCheatTestThingHook;

        public override void Unload() => CheatTestThingHook -= TranslationCheatTestThingHook;
        
        private void TranslationCheatTestThingHook(ILContext il) => TranslationUtils.ILTranslate(il, " isn't worthy.", " не достоин.");
    }

    public class DraedonLogHellGUIIL : ILEdit
    {
        private event ILContext.Manipulator DraedonLogHellGUIHook
        {
            add => HookEndpointManager.Modify(typeof(DraedonLogHellGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(DraedonLogHellGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => DraedonLogHellGUIHook += TranslationDraedonLogHellGUIHook;

        public override void Unload() => DraedonLogHellGUIHook -= TranslationDraedonLogHellGUIHook;

        private void TranslationDraedonLogHellGUIHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "The entire landscape is a constant source of geothermal energy, and heat for a forge. If it was not entirely uninhabitable save for demons and spirits, I would conduct much more of my research in the bowels of the earth. Where I have actively chosen not to settle however, is in the crags of the underworld. There, the magma is... uncooperative and far more corrosive than should be possible, as it is saturated with cursed, twisted souls, courtesy of that Witch.", "Весь природный ландшафт — постоянный источник геотермальной энергии и тепла для кузни. Если бы он не был совсем необитаемым, за исключением демонов и духов, я бы проводил больше исследований в недрах земли. Где я точно ни поселился бы, так это в скалах ада. Магма там... 'несговорчива' и агрессивна, намного больше, чем это возможно. Всё из-за того, что она пропиталась проклятыми тёмными душами, любезно предоставленными этой Ведьмой.");
            TranslationUtils.ILTranslate(il, "A blade completely inundated with my surroundings during the time of its creation. It was tempered by the fires which are fueled by spirits, and formed in the magma I draw into my laboratories. Its cutting edge, unparalleled, though its reach is limited making general usage questionable. I would consider it my very first foray into work for the sake of craftsmanship and art. If I was born synthetically, any creation which leads one to question whether I was, is a creation I may be proud of. It shows that I can after all, be graced by a muse.", "Меч, полностью окружённый моим вниманием во время создания. Он сформировался в магме, а закалён огнём душ. Его лезвие — непревзойдённое, хотя его дальность ограничена, что делает общее применение сомнительным. Я думаю, что это моя первая работа, сделанная во имя искусства и мастерства. Если я был рождён синтетически, то любое моё творение, вызывающие вопрос: «Был ли я создан?» — результат, которым можно гордиться. Это доказывает, что я всё же могу быть удостоенным музы.");
            TranslationUtils.ILTranslate(il, "What a terrible abomination and yet an enticing subject. Not unlike the fusion of spirits which haunts the dungeons, this entity is formed not of one, but a multitude of sinners. What holds different for it however, is that the limitations caused by the artificiality of the dungeon's existence do not apply to it. It is the laws of hell which brought them together into a single overlord of the underworld. And when an innocent life is sacrificed... Their hunger, which appears to be in tune with the afterlife, surges.", "Какое ужасное существо, но всё же интересное с научной точки зрения. В отличие от сплава душ темницы, эта сущность была сформирована не из одного грешника, а из многих. Ещё одно отличие заключается в том, что ограничения, вызванные искусственным происхождением темницы, неприменимы к нему. Именно законы Ада свели их вместе в единого владыку подземного мира. И когда невинная жизнь приносится в жертву... Их голод, который, кажется, является частью загробной жизни, нарастает.");
        }
    }

    public class DraedonLogJungleGUIIL : ILEdit
    {
        private event ILContext.Manipulator DraedonLogJungleGUIHook
        {
            add => HookEndpointManager.Modify(typeof(DraedonLogJungleGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(DraedonLogJungleGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => DraedonLogJungleGUIHook += TranslationDraedonLogJungleGUIHook;

        public override void Unload() => DraedonLogJungleGUIHook -= TranslationDraedonLogJungleGUIHook;

        private void TranslationDraedonLogJungleGUIHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "As I record this, it would not be a stretch to call the jungle the hub of this planet. All is centered around it, and none know not of it. It brings me no small amount of unease to see the uncomfortable, raw forms of the living beings who pass through on their journeys above. Fortunately these labs provide everything I need in my research and more. There is no need to ever visit the surface, save for summons on the Lord's orders.", "Поскольку я записываю это, не будет ошибкой назвать джунгли центром этой планеты. Всё сосредоточено вокруг них, но мало кто знает об этом. Я испытываю немалое беспокойство, видя неудобные, грубые формы живых существ, которые живут в них наверху. К счастью, эти лаборатории обеспечивают всё, что мне нужно в моих исследованиях и не только. Нет никакой необходимости когда-либо посещать поверхность, за исключением вызова по приказу Лорда.");
            TranslationUtils.ILTranslate(il, "Mechanically augmented, the Queen Bee which I had prior experimented on was theoretically a perfect host for the plague virus. When the first sign of the technology bonding with the creature began however, the problems also showed immediately. The mind of the insect fought the control of the nanotechnology, nothing like the simpler creatures I had used as test subjects. It grew increasingly violent, and only once subdued did it receive simple orders. However, if we were to utilize it at all, there is no other way than to let it roam free entirely. I will consider this further.", "Механически усиленная королева пчёл, над которой я ранее экспериментировал, теоретически была идеальным разносчиком чумы. Однако, когда технологии начали менять сущность пчелы, начались проблемы. Разум насекомого противостоял нанотехнологиям, такого раньше не происходило. Она выросла невероятно жестокой и почти не подчинялась приказам. Однако, если мы хотим использовать её, нет другого способа, кроме как позволить ей свободно разгуливать. Я продолжу изучать это дальше.");
            TranslationUtils.ILTranslate(il, "A virus, capable of devouring and converting almost anything. And nanotechnology, constructed painstakingly for the sake of control. Development was swift, and every piece fell into place almost eerily, forming an abhorrent existence. I struggle to think of practical applications which would be friendly to common life forms. However, it is not a major concern. Many were hesitant to continue its creation, but I granted them leave if they desired. I would have no need for any who were not entirely as dedicated as my machines.", "Вирус, способный пожирать и превращать практически всё. И тщательно сделанная нанотехнология контроля. Превращение шло пугающе быстро, создавая мерзкую тварь. Я стараюсь сделать так, чтобы она была дружелюбна к обычным формам жизни. Однако это не главная проблема. Многие не решались продолжать создание, но я разрешил уйти, если они пожелают. Я не нуждался ни в ком, кто не был бы так же предан делу, как мои машины.");
        }
    }

    public class DraedonLogPlanetoidGUIIL : ILEdit
    {
        private event ILContext.Manipulator DraedonLogPlanetoidGUIHook
        {
            add => HookEndpointManager.Modify(typeof(DraedonLogPlanetoidGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(DraedonLogPlanetoidGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => DraedonLogPlanetoidGUIHook += TranslationDraedonLogPlanetoidGUIHook;

        public override void Unload() => DraedonLogPlanetoidGUIHook -= TranslationDraedonLogPlanetoidGUIHook;

        private void TranslationDraedonLogPlanetoidGUIHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Hung low in orbit, masses of ground and various parts of the world provide a secluded and distant point for research. Undeniably optimal for the science of astronomy and otherwise. In my labs here I grow many things, testing their limits against the cold and vacuum of the stratosphere. Though not many survive, the existence of certain creatures here, confirm the capabilities of life simply given more time.", "Висящие низко на орбите массы земли и другие структуры мира, обеспечивают укромное и отдалённое место для исследований. Это оптимальный вариант для изучения астрономии и других наук. В моих лабораториях я выращиваю разные растения и тестирую их способность к выживанию в условиях холода и вакуума стратосферы. Несмотря на то, что многие растения погибают, существование жизни здесь подтверждается. Просто нужно дать этой жизни больше времени на развитие.");
            TranslationUtils.ILTranslate(il, "The bloated cosmic worm, though I understand why the Lord decides to employ it given he can control it, is a disgusting existence. However the idea of creating an armor suited to it in every way, was an offer I could not refuse. Forged from the cosmic steel of my own creation, it resists nearly any attack, yet allows the creature the same flexibility it would have without it, as well as augmenting its dimensional abilities. I remain pleased with the result.", "Раздутый отвратительный космический червь. Впрочем, я понимаю, почему Лорд его использует, ведь он может его контролировать... Идея создания брони, подходящей ему во всех отношениях, была предложением, от которого я не мог отказаться. Выкованная из космической стали, моего собственного создания, броня защищала практически от любой атаки. А также она не уменьшает изначальной гибкости существа, а ещё увеличивает пространственные способности. Я доволен результатом.");
            TranslationUtils.ILTranslate(il, "I do not care much for the interstellar, or the cosmos. Though I have traversed it, there is still plenty in my own world to manage and discover at this time. Even if I once inhabited a different planet, the Lord's wishes that I provide him machinery were the only condition that I needed to leave it and settle elsewhere. Once I have discovered and dissected every part of this place, perhaps then, I could look up towards the macroscopic.", "Меня мало волнует космос. Да, я путешествовал по нему, но сейчас мне достаточно работы по изучению собственного мира. Даже если бы я когда-то жил на другой планете, одного желания Лорда получать мои технологии было бы достаточно, чтобы я улетел с неё сюда. Если же я когда-нибудь полностью изучу каждый кусочек этого места, то тогда, возможно, я обращу свой взор наверх, в сторону макроскопического.");
        }
    }

    public class DraedonLogSnowBiomeGUIIL : ILEdit
    {
        private event ILContext.Manipulator DraedonLogSnowBiomeGUIHook
        {
            add => HookEndpointManager.Modify(typeof(DraedonLogSnowBiomeGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(DraedonLogSnowBiomeGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => DraedonLogSnowBiomeGUIHook += TranslationDraedonLogSnowBiomeGUIHook;

        public override void Unload() => DraedonLogSnowBiomeGUIHook -= TranslationDraedonLogSnowBiomeGUIHook;

        private void TranslationDraedonLogSnowBiomeGUIHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "A freezing tundra, where only creatures entirely adapted to the subzero temperatures exist and thrive. It is a shocking transition from the forests of the purity and the sun baked desert. A climate like this should not exist naturally in this part of the world with ease. The weather patterns seem to shift unnaturally arounds the skies of these icy plains. There is likely a reason for this, which necessitates further research.", "Холодная тундра, где существуют и процветают существа, полностью приспособленные к минусовым температурам. Это шокирующий переход от чистых лесов и выжженной солнцем пустыни. Климат, подобный этому, не должен существовать естественно. Погодные условия на этих ледяных равнинах, кажется, неестественно меняются. Вероятно, этому есть причина, которая требует дальнейших исследований.");
            TranslationUtils.ILTranslate(il, "I am not the only singular being to inhabit this biome. Once before, the Archmage who opposed the Lord resided here, cloaked by constant artificial blizzards of his own creation, which no longer fall. He likely chose this place as a conduit for research into his ice spells, and extended the period of time that this place remained frozen. Deep underground my research and materials lay well protected, but above in the natural storms there are traces of the prison of ice he resides in, still haunting its place of creation.", "Я не единственное разумное существо, находившееся в этом биоме. До этого Архимаг, противостоявший Лорду, жил здесь. Скорее всего, он выбрал это место для изучения ледяных заклятий, одно из которых — нескончаемые ледяные бури. Его действия поддерживали биом в глубокой заморозке. Глубоко под землёй мои исследования хорошо защищены, но снаружи, в естественных бурях, есть следы ледяной тюрьмы, в которой он пребывает по сей день, всё ещё бродящей в месте своего создания.");
            TranslationUtils.ILTranslate(il, "Intriguing. Though embedded deep into the caverns of ice and worn from centuries of frost and meltwater, I have uncovered several mechanisms which once filled the tunnels here. The ingenuity present is remarkable, and I have found parallels within my own work, as well as devices even I have something to learn from. From where do these come? Why machinery so complex in so sparse and dreary a habitat? Perhaps, they are related to the unnatural conditions.", "Интригующе. Я нашёл механизмы, когда-то заполнявшие туннели. Они находились в ледяных пещерах, поломанные из-за веков во льду и талой воды. Мастерство исполнения поражает. Я нашёл схожести с моими работами, а также узнал что-то новое. Но кто их создал? Почему настолько сложные машины находятся в такой скудной и унылой среде обитания. Возможно, именно они виноваты в настолько неестественных условиях.");
        }
    }

    public class DraedonLogSunkenSeaGUIIL : ILEdit
    {
        private event ILContext.Manipulator DraedonLogSunkenSeaGUIHook
        {
            add => HookEndpointManager.Modify(typeof(DraedonLogSunkenSeaGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(DraedonLogSunkenSeaGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => DraedonLogSunkenSeaGUIHook += TranslationDraedonLogSunkenSeaGUIHook;

        public override void Unload() => DraedonLogSunkenSeaGUIHook -= TranslationDraedonLogSunkenSeaGUIHook;

        private void TranslationDraedonLogSunkenSeaGUIHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Preserved for millennia, a paradise for the living beings who sought shelter in prehistoric seas. They remain untouched by evolution, save for their adaptations to the oxygen starved waters and dim crystals, continuing to thrive. One mystery which continues to escape my understanding however, is how large some of the creatures have become. There is a blatant lack of nutrition and oxygen in the caves, and yet...", "Сохранившийся на протяжении тысячелетий рай для живых существ, искавших убежища в доисторических морях. Они остаются не тронутыми эволюцией, за исключением их адаптации к необогащенной воздухом воде и тусклым кристаллам, продолжая процветать. Однако одна загадка, которая продолжает ускользать от моего понимания, заключается в том, насколько большими стали некоторые из этих существ. В пещерах явно не хватает питания и кислорода, и всё же...");
            TranslationUtils.ILTranslate(il, "A specimen which has developed a grand size, and inexplicably, impressive psychic abilities. What is most curious is its strong connection to its lesser kin. Without any noticeable communication, when it comes under threat, other mollusks rally to its aggressor and begin attacking. Is this perhaps the very first signs of a higher life form, the evolutionary link hidden away in the sunken sea? Or a self sacrificial fluke, which would lead to their destruction if they inhabited any area other than these pacified caverns.", "Образец, который развил грандиозные размеры и необъяснимо-впечатляющие телепатические способности. Что самое любопытное, так это его сильная связь со своими меньшими родственниками. Когда он оказывается под угрозой, другие моллюски окружают своего агрессора и начинают атаковать. Может быть, это самые первые признаки высшей формы жизни, эволюционное звено, скрытое в затерянном море? Или самоотверженная случайность, которая привела бы к уничтожению, если они населяли любую область, кроме этих умиротворённых пещер.");
            TranslationUtils.ILTranslate(il, "The marine life in these caves do have eyes though they are barely functional, dulled by lack of use and milky white upon observation. On their tough, gnarled hides, crystals find an easy purchase, and grow in great numbers, providing the creatures protection. Perhaps another adaptation to the life they have adopted. The most striking wonder is within their bodies. In specimens dissected, I have noticed that the mineral is buried into their very digestive systems, and perhaps, through some chemical process, pass nutrients into their sluggish hosts. A peculiar yet entirely beneficial interaction.", "У морских обитателей в этих пещерах есть глаза-рудименты, внешне они молочно-белые. На их жёстких узловатых шкурах кристаллы растут в большом количестве, обеспечивая существам защиту. Возможно, это ещё одна адаптация к жизни, которую они приняли. Но самое поразительное чудо — внутренности их тел. В образцах, подвергнутых вскрытию, я заметил, что минерал находится в самой их пищеварительной системе и, возможно, через какой-то химический процесс передаёт питательные вещества их вялым хозяевам. Своеобразное, но совершенно благотворное взаимодействие.");
        }
    }

    public class WeakReferenceSupportIL : ILEdit
    {
        private event ILContext.Manipulator AddCalamityBossesHook
        {
            add => HookEndpointManager.Modify(ModsCall.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("AddCalamityBosses", BindingFlags.Static | BindingFlags.NonPublic), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("AddCalamityBosses", BindingFlags.Static | BindingFlags.NonPublic), value);
        }

        private event ILContext.Manipulator CensusSupportHook
        {
            add => HookEndpointManager.Modify(ModsCall.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("CensusSupport", BindingFlags.NonPublic | BindingFlags.Static), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("CensusSupport", BindingFlags.NonPublic | BindingFlags.Static), value);
        }

        private event ILContext.Manipulator AddCalamityInvasionsHook
        {
            add => HookEndpointManager.Modify(ModsCall.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("AddCalamityInvasions", BindingFlags.NonPublic | BindingFlags.Static), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("AddCalamityInvasions", BindingFlags.NonPublic | BindingFlags.Static), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            AddCalamityBossesHook += TranslationAddCalamityBossesHook;
            CensusSupportHook += TranslationCensusSupportHook;
            AddCalamityInvasionsHook += TranslationAddCalamityInvasionsHook;
        }

        public override void Unload()
        {
            AddCalamityBossesHook -= TranslationAddCalamityBossesHook;
            CensusSupportHook -= TranslationCensusSupportHook;
            AddCalamityInvasionsHook -= TranslationAddCalamityInvasionsHook;
        }

        private void TranslationAddCalamityBossesHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Use a [i:{0}] in the Desert Biome", "Используйте [i:{0}] в пустыне.");
            TranslationUtils.ILTranslate(il, "The scourge of the desert delved back into the sand.", "Пустынный бич снова погрузился в песок.");
            TranslationUtils.ILTranslate(il, "Desert Scourge", "Пустынный бич");
            TranslationUtils.ILTranslate(il, "Can spawn naturally in the Sunken Sea", "Может естественно появится в затерянном море.");
            TranslationUtils.ILTranslate(il, "The Giant Clam returns into hiding in its grotto.", "Гигантский моллюск скрывается в своём гроту.");
            TranslationUtils.ILTranslate(il, "Giant Clam", "Гигантский моллюск");
            TranslationUtils.ILTranslate(il, "Use a [i:{0}] in the Mushroom Biome", "Используйте [i:{0}] в грибном биоме.");
            TranslationUtils.ILTranslate(il, "The mycleium crab has lost interest.", "Мицелиевый краб потерял интерес.");
            TranslationUtils.ILTranslate(il, "Crabulon", "Крабулон", 2);
            TranslationUtils.ILTranslate(il, "Kill a Cyst in the Corruption or use a [i:{0}] in the Corruption", "Убейте кисту или используйте [i:{0}] в искажении.");
            TranslationUtils.ILTranslate(il, "The corrupted colony began searching for a new breeding ground.", "Искажённая стая начала поиски нового места для размножения.");
            TranslationUtils.ILTranslate(il, "Hive Mind", "Разум Улья");
            TranslationUtils.ILTranslate(il, "Kill a Cyst in the Crimson or use a [i:{0}] in the Crimson", "Убейте кисту или используйте [i:{0}] в багрянце.");
            TranslationUtils.ILTranslate(il, "The parasitic hive began searching for a new host.", "Паразитический улей начал искать нового носителя.");
            TranslationUtils.ILTranslate(il, "The Perforators", "Перфораторы");
            TranslationUtils.ILTranslate(il, "Use an [i:{0}]", "Используйте [i:{0}].");
            TranslationUtils.ILTranslate(il, "The gelatinous monstrosity achieved vengeance for its brethren.", "Желатиновое чудовище отомстило за своих собратьев.");
            TranslationUtils.ILTranslate(il, "Slime God", "Бог слизней");
            TranslationUtils.ILTranslate(il, "Use a [i:{0}] in the Snow Biome", "Используйте [i:{0}] в снегах.");
            TranslationUtils.ILTranslate(il, "Cryogen drifts away, carried on a freezing wind.", "Криоген уносится прочь ледяным ветром.");
            TranslationUtils.ILTranslate(il, "Cryogen", "Криоген", 2);
            TranslationUtils.ILTranslate(il, "Use a [i:{0}] in the Brimstone Crag", "Используйте [i:{0}] в серной скале.");
            TranslationUtils.ILTranslate(il, "Brimstone Elemental withdraws to the ruins of her shrine.", "Серный элементаль отступает к руинам своей святыни.");
            TranslationUtils.ILTranslate(il, "Brimstone Elemental", "Серный элементаль");
            TranslationUtils.ILTranslate(il, "Use a [i:{0}] in the Sulphuric Sea or wait for it to spawn in the Sulphuric Sea", "Используйте [i:{0}] или подождите его появление в сернистом море.");
            TranslationUtils.ILTranslate(il, "The Aquatic Scourge swam back into the open ocean.", "Акватический бич уплыл обратно в открытый океан.");
            TranslationUtils.ILTranslate(il, "Aquatic Scourge", "Акватический бич");
            TranslationUtils.ILTranslate(il, "Use an [i:{0}] at Night", "Используйте [i:{0}] ночью.");
            TranslationUtils.ILTranslate(il, "If you wanted a fight, you should've came more prepared.", "Если вы хотели драки, вы должны были прийти более подготовленными.");
            TranslationUtils.ILTranslate(il, "Calamitas", "Каламитас", 2);
            TranslationUtils.ILTranslate(il, "Kill 10 sand sharks after defeating Plantera or use a [i:{0}] in the Desert Biome", "Убейте 10 песчаных акул после победы над Плантерой или используйте [i:{0}] в пустыне.");
            TranslationUtils.ILTranslate(il, "The apex predator of the sands disappears into the dunes...", "Высший хищник песков исчезает в дюнах...");
            TranslationUtils.ILTranslate(il, "Great Sand Shark", "Великая песчаная акула");
            TranslationUtils.ILTranslate(il, "By killing an unknown entity in the Ocean Biome", "Убейте неизвестное существо в океане");
            TranslationUtils.ILTranslate(il, "The aquatic entities sink back beneath the ocean depths.", "Водные существа возвращаются в глубины океана.");
            TranslationUtils.ILTranslate(il, "Leviathan", "Левиафан", 2);
            TranslationUtils.ILTranslate(il, "Use an [i:{0}] at Night in the Astral Biome", "Используйте [i:{0}] ночью в астральном биоме.");
            TranslationUtils.ILTranslate(il, "Astrum Aureus’ program has been executed. Initiate recall.", "Программа Аструм Ареуса выполнена. Запущен возврат.");
            TranslationUtils.ILTranslate(il, "Astrum Aureus", "Аструм Ареус");
            TranslationUtils.ILTranslate(il, "Use an [i:{0}] in the Jungle Biome", "Используйте [i:{0}] в джунглях.");
            TranslationUtils.ILTranslate(il, "HOSTILE SPECIMENS TERMINATED. INITIATE RECALL TO HOME BASE.", "ВРАЖДЕБНЫЕ СУЩНОСТИ УНИЧТОЖЕНЫ. ЗАПУЩЕН ВОЗВРАТ НА БАЗУ.");
            TranslationUtils.ILTranslate(il, "Plaguebringer Goliath", "Разносчица чумы, Голиаф");
            TranslationUtils.ILTranslate(il, "Use a [i:{0}]", "Используйте [i:{0}].");
            TranslationUtils.ILTranslate(il, "The automaton of misshapen victims went looking for the true perpetrator.", "Машина бесформенных жертв отправилась на поиски истинного нарушителя.");
            TranslationUtils.ILTranslate(il, "Ravager", "Разрушитель", 2);
            TranslationUtils.ILTranslate(il, "Use a [i:{0}] or [i:{1}] as offering at an [i:{2}]", "Используйте [i:{0}] или [i:{1}] в качестве подношения на [i:{2}].");
            TranslationUtils.ILTranslate(il, "The infected deity retreats to the heavens.", "Заражённое божество отступает к небесам.");
            TranslationUtils.ILTranslate(il, "Astrum Deus", "Аструм Деус");
            TranslationUtils.ILTranslate(il, "Use a [i:{0}] in the Hallow or Underworld Biomes", "Используйте [i:{0}] в святых землях или в аду.");
            TranslationUtils.ILTranslate(il, "The guardians must protect their goddess at all costs.", "Стражи должны защищать свою богиню любой ценой.");
            TranslationUtils.ILTranslate(il, "Profaned Guardians", "Осквернённые стражи");
            TranslationUtils.ILTranslate(il, "Use [i:{0}] in the Jungle Biome", "Используйте [i:{0}] в джунглях.");
            TranslationUtils.ILTranslate(il, "The failed experiment returns to its reproductive routine.", "Неудачный эксперимент вернулся к своему репродуктивному распорядку.");
            TranslationUtils.ILTranslate(il, "Dragonfolly", "Псевдодракон", 2);
            TranslationUtils.ILTranslate(il, "Use [i:{0}] in the Hallow or Underworld Biomes", "Используйте [i:{0}] в святых землях или аду.");
            TranslationUtils.ILTranslate(il, "The Profaned Goddess vanishes in a burning blaze.", "Осквернённая богиня исчезает в горящем пламени.");
            TranslationUtils.ILTranslate(il, "Providence", "Провиденс", 2);
            TranslationUtils.ILTranslate(il, "Use a [i:{0}] in the Dungeon", "Используйте [i:{0}] в темнице.");
            TranslationUtils.ILTranslate(il, "The rift in time and space has moved away from your reach.", "Разлом во времени и пространстве удалился вдаль.");
            TranslationUtils.ILTranslate(il, "Ceaseless Void", "Нескончаемая пустота");
            TranslationUtils.ILTranslate(il, "Use a [i:{0}] in Space", "Используйте [i:{0}] в космосе.");
            TranslationUtils.ILTranslate(il, "Storm Weaver hid itself once again within the stormfront.", "Штормовой ткач снова спрятался в грозовом фронте.");
            TranslationUtils.ILTranslate(il, "Storm Weaver", "Штормовой ткач");
            TranslationUtils.ILTranslate(il, "Use a [i:{0}] in the Underworld", "Используйте [i:{0}] в аду.");
            TranslationUtils.ILTranslate(il, "The Devourer's assassin has finished its easy task.", "Убийца Пожирателя выполнил свою лёгкую задачу.");
            TranslationUtils.ILTranslate(il, "Signus", "Сигнус", 2);
            TranslationUtils.ILTranslate(il, "Kill 30 phantom spirits or use a [i:{0}] in the Dungeon", "Убейте 30 фантомных духов или используйте [i:{0}] в темнице.");
            TranslationUtils.ILTranslate(il, "The volatile spirits disperse throughout the depths of the dungeon.", "Нестабильные духи разбредаются по темнице.");
            TranslationUtils.ILTranslate(il, "Polterghast", "Полтергаст", 2);
            TranslationUtils.ILTranslate(il, "Defeat the Acid Rain event post-Polterghast or fish using a [i:{0}] in the Sulphurous Sea", "Одолейте событие «Кислотный дождь» после победы над Полтергастом или выловите с помощью [i:{0}] в сернистом море");
            TranslationUtils.ILTranslate(il, "The old duke disappears amidst the acidic downpour.", "Старый герцог исчезает посреди кислотного ливня.");
            TranslationUtils.ILTranslate(il, "Old Duke", "Старый герцог");
            TranslationUtils.ILTranslate(il, "Use a [i:{0}]", "Используйте [i:{0}].", 2);
            TranslationUtils.ILTranslate(il, "The Devourer of Gods has slain everyone and feasted on their essence.", "Пожиратель богов убил всех и пировал их сущностью.");
            TranslationUtils.ILTranslate(il, "Devourer of Gods", "Пожиратель богов");
            TranslationUtils.ILTranslate(il, "Use a [i:{0}] in the Jungle Biome", "Используйте [i:{0}] в джунглях.");
            TranslationUtils.ILTranslate(il, "Yharon found you too weak to stay near your gravestone.", "Ярон считает вас слишком слабым, чтобы оставаться с вашим надгробием.");
            TranslationUtils.ILTranslate(il, "Yharon", "Ярон", 2);
            TranslationUtils.ILTranslate(il, "Use an [i:{0}]", "Используйте [i:{0}].", 2);
            TranslationUtils.ILTranslate(il, "Please don't waste my time.", "Пожалуйста, не трать моё время.");
            TranslationUtils.ILTranslate(il, "Supreme Calamitas", "Высшая Каламитас");
            TranslationUtils.ILTranslate(il, "By using a high-tech computer", "С помощью высокотехнологичного компьютера.");
            TranslationUtils.ILTranslate(il, "An imperfection after all... what a shame.", "Несовершенство... какой позор.");
            TranslationUtils.ILTranslate(il, "Exo Mechs", "Экзо-механизмы");
            TranslationUtils.ILTranslate(il, "While in the Abyss, use an item that inflicts Chaos State", "Находясь в бездне, используйте предмет, который накладывает дебафф «Хаотичность»");
            TranslationUtils.ILTranslate(il, "Adult Eidolon Wyrm", "Фантомный змей");
        }

        private void TranslationCensusSupportHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Defeat a Giant Clam after defeating the Desert Scourge", "Одолейте Гигантского моллюска после победы над Пустынным бичем");
            TranslationUtils.ILTranslate(il, "Have a [i:", "Имейте [i:");
            TranslationUtils.ILTranslate(il, "] in your inventory after defeating Skeletron", "] в вашем инвентаре после победы над Скелетроном");
            TranslationUtils.ILTranslate(il, "Defeat Cryogen", "Одолейте Криогена");
            TranslationUtils.ILTranslate(il, "Have [i:", "Имейте [i:");
            TranslationUtils.ILTranslate(il, "] in your inventory in Hardmode", "] в вашем инвентаре в Хардмоде");
            TranslationUtils.ILTranslate(il, "Defeat Supreme Calamitas", "Одолейте Высшую Каламитас");
        }

        private void TranslationAddCalamityInvasionsHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Use a [i:{0}] or wait for the invasion to occur naturally after the Eye of Cthulhu is defeated.", "Используйте [i:{0}] или дождитесь, пока событие произойдёт естественным образом после победы над Глазом Ктулху.");
            TranslationUtils.ILTranslate(il, "The mysterious creatures of the sulphuric sea descended back into the ocean.", "Таинственные существа сернистого моря спустились обратно в океан.");
            TranslationUtils.ILTranslate(il, "Acid Rain", "Кислотный дождь");
            TranslationUtils.ILTranslate(il, "Use a [i:{0}] or [i:{1}] or wait for the invasion to occur naturally after the Aquatic Scourge is defeated", "Используйте [i:{0}] или, [i:{1}] или дождитесь, пока событие произойдёт естественным образом после победы над Акватическим бичом.");
            TranslationUtils.ILTranslate(il, "The mysterious creatures of the sulphuric sea descended back into the deep ocean.", "Таинственные существа сернистого моря спустились обратно в глубины океана.");
            TranslationUtils.ILTranslate(il, "Acid Rain (Post-AS)", "Кислотный дождь (Пост-Аб)");
            TranslationUtils.ILTranslate(il, "Use a [i:{0}] or [i:{1}] or wait for the invasion to occur naturally after the Polterghast is defeated", "Используйте [i:{0}] или, [i:{1}] или дождитесь, пока событие произойдёт естественным образом после победы над Полтергастом.");
            TranslationUtils.ILTranslate(il, "Acid Rain (Post-Polter)", "Кислотный дождь (Пост-Полтер)");
            TranslationUtils.ILTranslate(il, "The mysterious creatures of the sulphuric sea descended back into the deep ocean.", "Таинственные существа сернистого моря спустились обратно в глубины океана.", 2);
        }
    }

    public class FAPIL : ILEdit
    {
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(typeof(FAP).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(FAP).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator GetChatHook
        {
            add => HookEndpointManager.Modify(typeof(FAP).GetMethod("GetChat", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(FAP).GetMethod("GetChat", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            SetChatButtonsHook += TranslationSetChatButtonsHook;
            GetChatHook += TranslationGetChatHook;
        }

        public override void Unload()
        {
            SetChatButtonsHook -= TranslationSetChatButtonsHook;
            GetChatHook -= TranslationGetChatHook;
        }

        private void TranslationSetChatButtonsHook(ILContext il) => TranslationUtils.ILTranslate(il, "Death Count", "Количество смертей");

        private void TranslationGetChatHook(ILContext il) => TranslationUtils.ILTranslate(il, " was slapped too hard.", " получил слишком сильную пощечину.");
    }

    public class SEAHOEIL : ILEdit
    {
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(ModsCall.Calamity.Code.GetType("CalamityMod.NPCs.TownNPCs.SEAHOE").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Calamity.Code.GetType("CalamityMod.NPCs.TownNPCs.SEAHOE").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;

        public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il) => TranslationUtils.ILTranslate(il, "Help", "Помощь");
    }

    public class THIEFIL : ILEdit
    {
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(typeof(THIEF).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(THIEF).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;

        public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il) => TranslationUtils.ILTranslate(il, "Refund", "Возврат");
    }

    public class LabHologramProjectorUIIL : ILEdit
    {
        private event ILContext.Manipulator LabHologramProjectorUIHook
        {
            add => HookEndpointManager.Modify(typeof(LabHologramProjectorUI).GetMethod("ChooseDialogue", BindingFlags.Public | BindingFlags.Static), value);

            remove => HookEndpointManager.Unmodify(typeof(LabHologramProjectorUI).GetMethod("ChooseDialogue", BindingFlags.Public | BindingFlags.Static), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => LabHologramProjectorUIHook += TranslationLabHologramProjectorUIHook;

        public override void Unload() => LabHologramProjectorUIHook -= TranslationLabHologramProjectorUIHook;

        private void TranslationLabHologramProjectorUIHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "To any personnel engaged in the laboratories. Please wear your steel engraved ID badge at all times. It is the easiest method to discern your body if any accidents do occur.", "Напоминаем всему персоналу. Пожалуйста, носите ваш персональный стальной идентификационный значок. Это самый простой способ опознать тело в случае несчастного случая.");
            TranslationUtils.ILTranslate(il, "To experiment is to fail. To fail is to learn. To learn is to advance.", "Экспериментировать — значит терпеть неудачи. Терпеть неудачи — значит учиться. Учиться — значит становиться лучше.");
            TranslationUtils.ILTranslate(il, "Apparent danger while researching serves only to enhance the research experience.", "Кажущаяся опасность во время исследований только усиливает исследовательский опыт.");
            TranslationUtils.ILTranslate(il, "Laser-type weapon prototypes are incredibly lethal and are not to be used within presentation halls.", "Прототипы лазерного оружия невероятно смертоносны и не должны использоваться в презентационных залах.");
            TranslationUtils.ILTranslate(il, "High-energy plasma emissions have adverse effects on both flesh and metal. Do not attempt to handle vented plasma.", "Высокоэнергетические плазменные выбросы оказывают неблагоприятное воздействие как на плоть, так и на металл. Не пытайтесь обращаться с изливающейся плазмой.");
            TranslationUtils.ILTranslate(il, "Electric shocks from military equipment are intended to be fatal. If you survive such a shock, that is a clear indicator that the device is not functioning properly. Please report any such cases.", "Удары электрического тока, вызванные оружием, должны быть летальными. Если вы пережили удар током, это явный признак того, что устройство не функционирует должным образом. Пожалуйста, сообщите о любых таких случаях.");
            TranslationUtils.ILTranslate(il, "All employees are hereby notified that they will be held accountable for any collateral damage caused by Gauss weapon fire, even during sanctioned testing exercises.", "Все сотрудники уведомляются, что они будут нести ответственность за любой сопутствующий ущерб, причинённый огнём гауссовского оружия, даже во время санкционированных испытательных учений.");
            TranslationUtils.ILTranslate(il, "Security Field Emitters will vaporize all unauthorized equipment and personnel. Please leave personal effects in the designated lockers off-site. This also means: Do not bring any family members who are not enlisted as personnel.", "Излучатели защитного поля уничтожат всё несанкционированное оборудование и персонал. Пожалуйста, оставьте личные вещи в специально отведённых запирающихся шкафчиках за пределами поля. Это также означает: Не приводите с собой членов семьи, которые не зачислены в личный состав.");
            TranslationUtils.ILTranslate(il, "If one does manage to breach restricted testing facilities, do at least record any unexpected burns, lacerations, bruising, fractur... ...trauma, shocks and otherwise. Thank you.", "Если кто-то всё же решит пробраться в закрытые испытательные помещения, то хотя бы сделайте запись неожиданных ожогов, рваных ран, кровоизлияний, переломов... травм, шоковых ожогов и др. Спасибо.");
            TranslationUtils.ILTranslate(il, "The power grid has been... ...eavily compromised. Abort research and proceed to the emergency exits located at... ...and egress with haste.", "Энергосистема была... ...кована, серьёзные повреждения. Прервите исследования и пройдите к аварийным выходам, расположенным... ...и выходите с поспешностью.");
            TranslationUtils.ILTranslate(il, "Notify the Security Department of any aggressive local fauna immediately.", "Немедленно сообщите в Службу безопасности о любой местной агрессивной фауне.");
            TranslationUtils.ILTranslate(il, "Sensors have detected a significant breach in the spacetime continuum.", "Сенсоры обнаружили значительное нарушение пространственно-временного континуума.");
            TranslationUtils.ILTranslate(il, "Please help. I'm stuck in this hologram machine.", "Пожалуйста, помогите. Я застрял в голограмме.");
        }
    }

    public class AstralInjectionIL : ILEdit
    {
        private event ILContext.Manipulator AstralInjectionHook
        {
            add => HookEndpointManager.Modify(typeof(AstralInjection).GetMethod("OnConsumeItem", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(AstralInjection).GetMethod("OnConsumeItem", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => AstralInjectionHook += TranslationAstralInjectionHook;

        public override void Unload() => AstralInjectionHook -= TranslationAstralInjectionHook;

        private void TranslationAstralInjectionHook(ILContext il) => TranslationUtils.ILTranslate(il, "'s blood vessels burst from drug overdose.", " кровеносные сосуды лопаются от передозировки наркотиков.");
    }

    public class ThornBlossomIL : ILEdit
    {
        private event ILContext.Manipulator ThornBlossomHook
        {
            add => HookEndpointManager.Modify(typeof(ThornBlossom).GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ThornBlossom).GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => ThornBlossomHook += TranslationThornBlossomHook;

        public override void Unload() => ThornBlossomHook -= TranslationThornBlossomHook;

        private void TranslationThornBlossomHook(ILContext il) => TranslationUtils.ILTranslate(il, " was violently pricked by a flower.", " был яростно уколот цветком.");
    }

    public class BloodBoilerIL : ILEdit
    {
        private event ILContext.Manipulator BloodBoilerHook
        {
            add => HookEndpointManager.Modify(typeof(BloodBoiler).GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(BloodBoiler).GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => BloodBoilerHook += TranslationBloodBoilerHook;

        public override void Unload() => BloodBoilerHook -= TranslationBloodBoilerHook;

        private void TranslationBloodBoilerHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, " suffered from severe anemia.", " страдал тяжёлой анемией.");
            TranslationUtils.ILTranslate(il, " was unable to obtain a blood transfusion.", " не удалось добиться переливания крови.");
        }
    }

    public class FearlessGoldfishWarriorIL : ILEdit
    {
        private event ILContext.Manipulator FearlessGoldfishWarriorHook
        {
            add => HookEndpointManager.Modify(typeof(FearlessGoldfishWarrior).GetMethod("ModifyHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(FearlessGoldfishWarrior).GetMethod("ModifyHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => FearlessGoldfishWarriorHook += TranslationFearlessGoldfishWarriorHook;

        public override void Unload() => FearlessGoldfishWarriorHook -= TranslationFearlessGoldfishWarriorHook;

        private void TranslationFearlessGoldfishWarriorHook(ILContext il) => TranslationUtils.ILTranslate(il, " was once again impaled by Goldfish.", " был снова проткнут Золотой рыбкой.");
    }

    public class HealOrbProvIL : ILEdit
    {
        private event ILContext.Manipulator HealOrbProvHook
        {
            add => HookEndpointManager.Modify(typeof(HealOrbProv).GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(HealOrbProv).GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => HealOrbProvHook += TranslationHealOrbProvHook;

        public override void Unload() => HealOrbProvHook -= TranslationHealOrbProvHook;

        private void TranslationHealOrbProvHook(ILContext il) => TranslationUtils.ILTranslate(il, " burst into sinless ash.", " превратился в безгрешный пепел.");
    }

    public class HolyBurnOrbIL : ILEdit
    {
        private event ILContext.Manipulator HolyBurnOrbHook
        {
            add => HookEndpointManager.Modify(typeof(HolyBurnOrb).GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(HolyBurnOrb).GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => HolyBurnOrbHook += TranslationHolyBurnOrbHook;

        public override void Unload() => HolyBurnOrbHook -= TranslationHolyBurnOrbHook;

        private void TranslationHolyBurnOrbHook(ILContext il) => TranslationUtils.ILTranslate(il, " burst into sinless ash.", " превратился в безгрешный пепел.");
    }

    public class ChibiiDoggoIL : ILEdit
    {
        private event ILContext.Manipulator AIHook
        {
            add => HookEndpointManager.Modify(typeof(ChibiiDoggo).GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ChibiiDoggo).GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator SpawnDoggoHook
        {
            add => HookEndpointManager.Modify(typeof(ChibiiDoggo).GetMethod("SpawnDoggo", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ChibiiDoggo).GetMethod("SpawnDoggo", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            AIHook += TranslationAIHook;
            SpawnDoggoHook += TranslationSpawnDoggoHook;
        }

        public override void Unload()
        {
            AIHook -= TranslationAIHook;
            SpawnDoggoHook -= TranslationSpawnDoggoHook;
        }

        private void TranslationAIHook(ILContext il) => TranslationUtils.ILTranslate(il, " couldn't stand the sharp objects.", " не выдерживал острых предметов.");

        private void TranslationSpawnDoggoHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "It's not over yet, kid!", "Это ещё не конец, малыш!");
            TranslationUtils.ILTranslate(il, "Don't get cocky, kid!", "Не будь таким самоуверенным, малыш!");
        }
    }

    public class CalamityUtilsIL : ILEdit
    {
        private event ILContext.Manipulator CalamityUtilsHook
        {
            add => HookEndpointManager.Modify(typeof(CalamityUtils).GetMethod("BedRightClick", BindingFlags.Public | BindingFlags.Static), value);

            remove => HookEndpointManager.Unmodify(typeof(CalamityUtils).GetMethod("BedRightClick", BindingFlags.Public | BindingFlags.Static), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => CalamityUtilsHook += TranslationCalamityUtilsHook;

        public override void Unload() => CalamityUtilsHook -= TranslationCalamityUtilsHook;

        private void TranslationCalamityUtilsHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Spawn point removed!", "Точка воскрешения удалена!");
            TranslationUtils.ILTranslate(il, "Spawn point set!", "Точка воскрешения задана!");
        }
    }

    public class PlaguedPlateBedIL : ILEdit
    {
        private event ILContext.Manipulator PlaguedPlateBedHook
        {
            add => HookEndpointManager.Modify(typeof(PlaguedPlateBed).GetMethod("NewRightClick", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(PlaguedPlateBed).GetMethod("NewRightClick", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => PlaguedPlateBedHook += TranslationPlaguedPlateBedHook;

        public override void Unload() => PlaguedPlateBedHook -= TranslationPlaguedPlateBedHook;

        private void TranslationPlaguedPlateBedHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Spawn point removed!", "Точка воскрешения удалена!");
            TranslationUtils.ILTranslate(il, "Spawn point set!", "Точка воскрешения задана!");
        }
    }

    public class RavagerBodyIL : ILEdit
    {
        private event ILContext.Manipulator RavagerBodyHook
        {
            add => HookEndpointManager.Modify(typeof(RavagerBody).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(RavagerBody).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => RavagerBodyHook += TranslationRavagerBodyHook;

        public override void Unload() => RavagerBodyHook -= TranslationRavagerBodyHook;

        private void TranslationRavagerBodyHook(ILContext il) => TranslationUtils.ILTranslate(il, "Ravager", "Разрушитель");
    }

    public class CalamitasRun3IL : ILEdit
    {
        private event ILContext.Manipulator CalamitasRun3Hook
        {
            add => HookEndpointManager.Modify(typeof(CalamitasRun3).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(CalamitasRun3).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => CalamitasRun3Hook += TranslationCalamitasRun3Hook;

        public override void Unload() => CalamitasRun3Hook -= TranslationCalamitasRun3Hook;

        private void TranslationCalamitasRun3Hook(ILContext il) => TranslationUtils.ILTranslate(il, "The Calamitas Clone", "Клон Каламитас");
    }

    public class BossHealthBarManagerIL : ILEdit
    {
        private event ILContext.Manipulator DrawHook
        {
            add => HookEndpointManager.Modify(ModsCall.Calamity.Code.GetType("CalamityMod.UI.BossHealthBarManager+BossHPUI").GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(ModsCall.Calamity.Code.GetType("CalamityMod.UI.BossHealthBarManager+BossHPUI").GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => DrawHook += TranslationDrawHook;

        public override void Unload() => DrawHook -= TranslationDrawHook;

        private void TranslationDrawHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "({0} left: {1})", "({0} осталось: {1})");
        }
    }

    public class ProfanedGuardianBoss2IL : ILEdit
    {
        private event ILContext.Manipulator ProfanedGuardianBoss2Hook
        {
            add => HookEndpointManager.Modify(typeof(ProfanedGuardianBoss2).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ProfanedGuardianBoss2).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => ProfanedGuardianBoss2Hook += TranslationProfanedGuardianBoss2Hook;

        public override void Unload() => ProfanedGuardianBoss2Hook -= TranslationProfanedGuardianBoss2Hook;

        private void TranslationProfanedGuardianBoss2Hook(ILContext il) => TranslationUtils.ILTranslate(il, "A Profaned Guardian", "Осквернённый страж");
    }

    public class PerforatorHeadLargeIL : ILEdit
    {
        private event ILContext.Manipulator PerforatorHeadLargeHook
        {
            add => HookEndpointManager.Modify(typeof(PerforatorHeadLarge).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(PerforatorHeadLarge).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => PerforatorHeadLargeHook += TranslationPerforatorHeadLargeHook;

        public override void Unload() => PerforatorHeadLargeHook -= TranslationPerforatorHeadLargeHook;

        private void TranslationPerforatorHeadLargeHook(ILContext il) => TranslationUtils.ILTranslate(il, "The Large Perforator", "Перфоратор");
    }

    public class PerforatorHeadSmallIL : ILEdit
    {
        private event ILContext.Manipulator PerforatorHeadSmallHook
        {
            add => HookEndpointManager.Modify(typeof(PerforatorHeadSmall).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(PerforatorHeadSmall).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => PerforatorHeadSmallHook += TranslationPerforatorHeadSmallHook;

        public override void Unload() => PerforatorHeadSmallHook -= TranslationPerforatorHeadSmallHook;

        private void TranslationPerforatorHeadSmallHook(ILContext il) => TranslationUtils.ILTranslate(il, "The Small Perforator", "Перфоратор");
    }

    public class BumblefuckIL : ILEdit
    {
        private event ILContext.Manipulator BumblefuckHook
        {
            add => HookEndpointManager.Modify(typeof(Bumblefuck).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(Bumblefuck).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => BumblefuckHook += TranslationBumblefuckHook;

        public override void Unload() => BumblefuckHook -= TranslationBumblefuckHook;

        private void TranslationBumblefuckHook(ILContext il) => TranslationUtils.ILTranslate(il, "A Dragonfolly", "Псевдодракон");
    }

    public class PerforatorHeadMediumIL : ILEdit
    {
        private event ILContext.Manipulator PerforatorHeadMediumHook
        {
            add => HookEndpointManager.Modify(typeof(PerforatorHeadMedium).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(PerforatorHeadMedium).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => PerforatorHeadMediumHook += TranslationPerforatorHeadMediumHook;

        public override void Unload() => PerforatorHeadMediumHook -= TranslationPerforatorHeadMediumHook;

        private void TranslationPerforatorHeadMediumHook(ILContext il) => TranslationUtils.ILTranslate(il, "The Medium Perforator", "Перфоратор");
    }

    public class ProfanedGuardianBoss3IL : ILEdit
    {
        private event ILContext.Manipulator ProfanedGuardianBoss3Hook
        {
            add => HookEndpointManager.Modify(typeof(ProfanedGuardianBoss3).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ProfanedGuardianBoss3).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => ProfanedGuardianBoss3Hook += TranslationProfanedGuardianBoss3Hook;

        public override void Unload() => ProfanedGuardianBoss3Hook -= TranslationProfanedGuardianBoss3Hook;

        private void TranslationProfanedGuardianBoss3Hook(ILContext il) => TranslationUtils.ILTranslate(il, "A Profaned Guardian", "Осквернённый страж");
    }

    public class ProfanedGuardianBossIL : ILEdit
    {
        private event ILContext.Manipulator ProfanedGuardianBossHook
        {
            add => HookEndpointManager.Modify(typeof(ProfanedGuardianBoss).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ProfanedGuardianBoss).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => ProfanedGuardianBossHook += TranslationProfanedGuardianBossHook;

        public override void Unload() => ProfanedGuardianBossHook -= TranslationProfanedGuardianBossHook;

        private void TranslationProfanedGuardianBossHook(ILContext il) => TranslationUtils.ILTranslate(il, "A Profaned Guardian", "Осквернённый страж");
    }

    public class BossRushUIIL : ILEdit
    {
        private event ILContext.Manipulator BossRushUIHook
        {
            add => HookEndpointManager.Modify(typeof(BossRushUI).GetMethod("get_InvasionName", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(BossRushUI).GetMethod("get_InvasionName", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => BossRushUIHook += TranslationBossRushUIHook;

        public override void Unload() => BossRushUIHook -= TranslationBossRushUIHook;

        private void TranslationBossRushUIHook(ILContext il) => TranslationUtils.ILTranslate(il, "Boss Rush", "Босс-Раш");
    }

    public class FurnitureOccultIL : ILEdit
    {
        private event ILContext.Manipulator OccultBathtubHook
        {
            add => HookEndpointManager.Modify(typeof(OccultBathtub).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultBathtub).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultBedHook
        {
            add => HookEndpointManager.Modify(typeof(OccultBed).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultBed).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultBookcaseHook
        {
            add => HookEndpointManager.Modify(typeof(OccultBookcase).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultBookcase).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultCandelabraHook
        {
            add => HookEndpointManager.Modify(typeof(OccultCandelabra).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultCandelabra).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultCandleHook
        {
            add => HookEndpointManager.Modify(typeof(OccultCandle).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultCandle).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultChairHook
        {
            add => HookEndpointManager.Modify(typeof(OccultChair).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultChair).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultChandelierHook
        {
            add => HookEndpointManager.Modify(typeof(OccultChandelier).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultChandelier).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultChestHook
        {
            add => HookEndpointManager.Modify(typeof(OccultChest).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultChest).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultClockHook
        {
            add => HookEndpointManager.Modify(typeof(OccultClock).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultClock).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultDoorHook
        {
            add => HookEndpointManager.Modify(typeof(OccultDoor).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultDoor).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultDresserHook
        {
            add => HookEndpointManager.Modify(typeof(OccultDresser).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultDresser).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultLampHook
        {
            add => HookEndpointManager.Modify(typeof(OccultLamp).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultLamp).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultLanternHook
        {
            add => HookEndpointManager.Modify(typeof(OccultLantern).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultLantern).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultPianoHook
        {
            add => HookEndpointManager.Modify(typeof(OccultPiano).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultPiano).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultPlatformHook
        {
            add => HookEndpointManager.Modify(typeof(OccultPlatform).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultPlatform).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultSinkHook
        {
            add => HookEndpointManager.Modify(typeof(OccultSink).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultSink).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultSofaHook
        {
            add => HookEndpointManager.Modify(typeof(OccultSofa).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultSofa).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultStoneHook
        {
            add => HookEndpointManager.Modify(typeof(OccultStone).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultStone).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultTableHook
        {
            add => HookEndpointManager.Modify(typeof(OccultTable).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultTable).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultWorkBenchHook
        {
            add => HookEndpointManager.Modify(typeof(OccultWorkBench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultWorkBench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator OccultStoneWallHook
        {
            add => HookEndpointManager.Modify(typeof(OccultStoneWall).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(OccultStoneWall).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            OccultBathtubHook += TranslationOccultBathtubHook;
            OccultBedHook += TranslationOccultBedHook;
            OccultBookcaseHook += TranslationOccultBookcaseHook;
            OccultCandelabraHook += TranslationOccultCandelabraHook;
            OccultCandleHook += TranslationOccultCandleHook;
            OccultChairHook += TranslationOccultChairHook;
            OccultChandelierHook += TranslationOccultChandelierHook;
            OccultChestHook += TranslationOccultChestHook;
            OccultClockHook += TranslationOccultClockHook;
            OccultDoorHook += TranslationOccultDoorHook;
            OccultDresserHook += TranslationOccultDresserHook;
            OccultLampHook += TranslationOccultLampHook;
            OccultLanternHook += TranslationOccultLanternHook;
            OccultPianoHook += TranslationOccultPianoHook;
            OccultPlatformHook += TranslationOccultPlatformHook;
            OccultSinkHook += TranslationOccultSinkHook;
            OccultSofaHook += TranslationOccultSofaHook;
            OccultStoneHook += TranslationOccultStoneHook;
            OccultTableHook += TranslationOccultTableHook;
            OccultWorkBenchHook += TranslationOccultWorkBenchHook;
            OccultStoneWallHook += TranslationOccultStoneWallHook;
        }

        public override void Unload()
        {
            OccultBathtubHook -= TranslationOccultBathtubHook;
            OccultBedHook -= TranslationOccultBedHook;
            OccultBookcaseHook -= TranslationOccultBookcaseHook;
            OccultCandelabraHook -= TranslationOccultCandelabraHook;
            OccultCandleHook -= TranslationOccultCandleHook;
            OccultChairHook -= TranslationOccultChairHook;
            OccultChandelierHook -= TranslationOccultChandelierHook;
            OccultChestHook -= TranslationOccultChestHook;
            OccultClockHook -= TranslationOccultClockHook;
            OccultDoorHook -= TranslationOccultDoorHook;
            OccultDresserHook -= TranslationOccultDresserHook;
            OccultLampHook -= TranslationOccultLampHook;
            OccultLanternHook -= TranslationOccultLanternHook;
            OccultPianoHook -= TranslationOccultPianoHook;
            OccultPlatformHook -= TranslationOccultPlatformHook;
            OccultSinkHook -= TranslationOccultSinkHook;
            OccultSofaHook -= TranslationOccultSofaHook;
            OccultStoneHook -= TranslationOccultStoneHook;
            OccultTableHook -= TranslationOccultTableHook;
            OccultWorkBenchHook -= TranslationOccultWorkBenchHook;
            OccultStoneWallHook -= TranslationOccultStoneWallHook;
        }

        private void TranslationOccultBathtubHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Bathtub", "Потусторонняя ванна");

        private void TranslationOccultBedHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Bed", "Потусторонняя кровать");

        private void TranslationOccultBookcaseHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Bookcase", "Потусторонний книжный шкаф");

        private void TranslationOccultCandelabraHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Candelabra", "Потусторонний канделябр");

        private void TranslationOccultCandleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Candle", "Потусторонняя свеча");

        private void TranslationOccultChairHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Chair", "Потусторонний стул");

        private void TranslationOccultChandelierHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Chandelier", "Потусторонняя люстра");

        private void TranslationOccultChestHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Chest", "Потусторонний сундук");

        private void TranslationOccultClockHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Clock", "Потусторонние часы");

        private void TranslationOccultDoorHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Door", "Потусторонняя дверь");

        private void TranslationOccultDresserHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Dresser", "Потусторонний комод");

        private void TranslationOccultLampHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Lamp", "Потусторонняя лампа");

        private void TranslationOccultLanternHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Lantern", "Потусторонний фонарь");

        private void TranslationOccultPianoHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Piano", "Потустороннее пианино");

        private void TranslationOccultPlatformHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Platform", "Потусторонняя платформа");

        private void TranslationOccultSinkHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Sink", "Потусторонняя раковина");

        private void TranslationOccultSofaHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Sofa", "Потусторонний диван");

        private void TranslationOccultStoneHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Stone", "Потусторонний камень");

        private void TranslationOccultTableHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Table", "Потусторонний стол");

        private void TranslationOccultWorkBenchHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Work Bench", "Потусторонний верстак");

        private void TranslationOccultStoneWallHook(ILContext il) => TranslationUtils.ILTranslate(il, "Otherworldly Stone Wall", "Стена из потустороннего камня");
    }

    public class StratusWorkbenchIL : ILEdit
    {
        private event ILContext.Manipulator StratusWorkbenchHook
        {
            add => HookEndpointManager.Modify(typeof(StratusWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(StratusWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => StratusWorkbenchHook += TranslationStratusWorkbenchHook;

        public override void Unload() => StratusWorkbenchHook -= TranslationStratusWorkbenchHook;

        private void TranslationStratusWorkbenchHook(ILContext il) => TranslationUtils.ILTranslate(il, "Stratus Work Bench", "Слоистый верстак");
    }

    public class FurnitureStatigelIL : ILEdit
    {
        private event ILContext.Manipulator StatigelWorkbenchHook
        {
            add => HookEndpointManager.Modify(typeof(StatigelWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(StatigelWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator StatigelBathHook
        {
            add => HookEndpointManager.Modify(typeof(StatigelBath).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(StatigelBath).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            StatigelWorkbenchHook += TranslationStatigelWorkbenchHook;
            StatigelBathHook += TranslationStatigelBathHook;
        }

        public override void Unload()
        {
            StatigelWorkbenchHook -= TranslationStatigelWorkbenchHook;
            StatigelBathHook -= TranslationStatigelBathHook;
        }

        private void TranslationStatigelWorkbenchHook(ILContext il) => TranslationUtils.ILTranslate(il, "Statigel Work Bench", "Статиджеловый верстак");

        private void TranslationStatigelBathHook(ILContext il) => TranslationUtils.ILTranslate(il, "Statigel Bathtub", "Статиджеловая ванна");
    }

    public class FurnitureProfanedIL : ILEdit
    {
        private event ILContext.Manipulator ProfanedWorkbenchHook
        {
            add => HookEndpointManager.Modify(typeof(ProfanedWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ProfanedWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator ProfanedBathHook
        {
            add => HookEndpointManager.Modify(typeof(ProfanedBath).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ProfanedBath).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            ProfanedWorkbenchHook += TranslationProfanedWorkbenchHook;
            ProfanedBathHook += TranslationProfanedBathHook;
        }

        public override void Unload()
        {
            ProfanedWorkbenchHook -= TranslationProfanedWorkbenchHook;
            ProfanedBathHook -= TranslationProfanedBathHook;
        }

        private void TranslationProfanedWorkbenchHook(ILContext il) => TranslationUtils.ILTranslate(il, "Profaned Work Bench", "Осквернённый верстак");

        private void TranslationProfanedBathHook(ILContext il) => TranslationUtils.ILTranslate(il, "Profaned Bathtub", "Осквернённая ванна");
    }

    public class FurnitureVoidIL : ILEdit
    {
        private event ILContext.Manipulator VoidWorkbenchHook
        {
            add => HookEndpointManager.Modify(typeof(VoidWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(VoidWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator VoidClockHook
        {
            add => HookEndpointManager.Modify(typeof(VoidClock).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(VoidClock).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator VoidBathHook
        {
            add => HookEndpointManager.Modify(typeof(VoidBath).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(VoidBath).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            VoidWorkbenchHook += TranslationVoidWorkbenchHook;
            VoidClockHook += TranslationVoidClockHook;
            VoidBathHook += TranslationVoidBathHook;
        }

        public override void Unload()
        {
            VoidWorkbenchHook -= TranslationVoidWorkbenchHook;
            VoidClockHook -= TranslationVoidClockHook;
            VoidBathHook -= TranslationVoidBathHook;
        }

        private void TranslationVoidWorkbenchHook(ILContext il) => TranslationUtils.ILTranslate(il, "Void Work Bench", "Пустотный верстак");

        private void TranslationVoidClockHook(ILContext il) => TranslationUtils.ILTranslate(il, "Void Obelisk", "Пустотный обелиск");

        private void TranslationVoidBathHook(ILContext il) => TranslationUtils.ILTranslate(il, "Void Bathtub", "Пустотная ванна");
    }

    public class FurnitureCosmiliteIL : ILEdit
    {
        private event ILContext.Manipulator CosmiliteWorkbenchHook
        {
            add => HookEndpointManager.Modify(typeof(CosmiliteWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(CosmiliteWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator CosmiliteBathHook
        {
            add => HookEndpointManager.Modify(typeof(CosmiliteBath).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(CosmiliteBath).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            CosmiliteWorkbenchHook += TranslationCosmiliteWorkbenchHook;
            CosmiliteBathHook += TranslationCosmiliteBathHook;
        }

        public override void Unload()
        {
            CosmiliteWorkbenchHook -= TranslationCosmiliteWorkbenchHook;
            CosmiliteBathHook -= TranslationCosmiliteBathHook;
        }

        private void TranslationCosmiliteWorkbenchHook(ILContext il) => TranslationUtils.ILTranslate(il, "Cosmilite Work Bench", "Космилитовый верстак");

        private void TranslationCosmiliteBathHook(ILContext il) => TranslationUtils.ILTranslate(il, "Cosmilite Bathtub", "Космилитовая ванна");
    }

    public class FurnitureAshenIL : ILEdit
    {
        private event ILContext.Manipulator AshenPianoHook
        {
            add => HookEndpointManager.Modify(typeof(AshenPiano).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(AshenPiano).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator AshenWorkbenchHook
        {
            add => HookEndpointManager.Modify(typeof(AshenWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(AshenWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator AshenBathHook
        {
            add => HookEndpointManager.Modify(typeof(AshenBath).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(AshenBath).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            AshenPianoHook += TranslationAshenPianoHook;
            AshenWorkbenchHook += TranslationAshenWorkbenchHook;
            AshenBathHook += TranslationAshenBathHook;
        }

        public override void Unload()
        {
            AshenPianoHook -= TranslationAshenPianoHook;
            AshenWorkbenchHook -= TranslationAshenWorkbenchHook;
            AshenBathHook -= TranslationAshenBathHook;
        }

        private void TranslationAshenPianoHook(ILContext il) => TranslationUtils.ILTranslate(il, "Ashen Pipe Organ", "Пепельный трубный орган");

        private void TranslationAshenWorkbenchHook(ILContext il) => TranslationUtils.ILTranslate(il, "Ashen Work Bench", "Пепельный верстак");

        private void TranslationAshenBathHook(ILContext il) => TranslationUtils.ILTranslate(il, "Ashen Bathtub", "Пепельная ванна");
    }

    public class CraftingStationsIL : ILEdit
    {
        private event ILContext.Manipulator EutrophicCraftingHook
        {
            add => HookEndpointManager.Modify(typeof(EutrophicCrafting).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(EutrophicCrafting).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithCraftingHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithCrafting).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithCrafting).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator ProfanedBasinHook
        {
            add => HookEndpointManager.Modify(typeof(ProfanedBasin).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(ProfanedBasin).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator SilvaBasinHook
        {
            add => HookEndpointManager.Modify(typeof(SilvaBasin).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(SilvaBasin).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            EutrophicCraftingHook += TranslationEutrophicCraftingHook;
            MonolithCraftingHook += TranslationMonolithCraftingHook;
            ProfanedBasinHook += TranslationProfanedBasinHook;
            SilvaBasinHook += TranslationSilvaBasinHook;
        }

        public override void Unload()
        {
            EutrophicCraftingHook -= TranslationEutrophicCraftingHook;
            MonolithCraftingHook -= TranslationMonolithCraftingHook;
            ProfanedBasinHook -= TranslationProfanedBasinHook;
            SilvaBasinHook -= TranslationSilvaBasinHook;
        }

        private void TranslationEutrophicCraftingHook(ILContext il) => TranslationUtils.ILTranslate(il, "Eutrophic Shelf", "Эвтрофная полка");

        private void TranslationMonolithCraftingHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Amalgam", "Монолитное слияние");

        private void TranslationProfanedBasinHook(ILContext il) => TranslationUtils.ILTranslate(il, "Profaned Crucible", "Осквернённый тигель");

        private void TranslationSilvaBasinHook(ILContext il) => TranslationUtils.ILTranslate(il, "Effulgent Manipulator", "Лучезарный манипулятор");
    }

    public class FurnitureAbyssIL : ILEdit
    {
        private event ILContext.Manipulator AbyssBathHook
        {
            add => HookEndpointManager.Modify(typeof(AbyssBath).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(AbyssBath).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator AbyssWorkbenchHook
        {
            add => HookEndpointManager.Modify(typeof(AbyssWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(AbyssWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator AbyssPianoHook
        {
            add => HookEndpointManager.Modify(typeof(AbyssPiano).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(AbyssPiano).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            AbyssBathHook += TranslationAbyssBathHook;
            AbyssWorkbenchHook += TranslationAbyssWorkbenchHook;
            AbyssPianoHook += TranslationAbyssPianoHook;
        }

        public override void Unload()
        {
            AbyssBathHook -= TranslationAbyssBathHook;
            AbyssWorkbenchHook -= TranslationAbyssWorkbenchHook;
            AbyssPianoHook -= TranslationAbyssPianoHook;
        }

        private void TranslationAbyssBathHook(ILContext il) => TranslationUtils.ILTranslate(il, "Abyss Bathtub", "Ванна бездны");

        private void TranslationAbyssWorkbenchHook(ILContext il) => TranslationUtils.ILTranslate(il, "Abyss Work Bench", "Верстак бездны");

        private void TranslationAbyssPianoHook(ILContext il) => TranslationUtils.ILTranslate(il, "Abyss Synth", "Синтезатор бездны");
    }

    public class FurnitureAncientIL : ILEdit
    {
        private event ILContext.Manipulator AncientBathHook
        {
            add => HookEndpointManager.Modify(typeof(AncientBath).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(AncientBath).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator AncientWorkbenchHook
        {
            add => HookEndpointManager.Modify(typeof(AncientWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(AncientWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator AncientPianoHook
        {
            add => HookEndpointManager.Modify(typeof(AncientPiano).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(AncientPiano).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            AncientBathHook += TranslationAncientBathHook;
            AncientWorkbenchHook += TranslationAncientWorkbenchHook;
            AncientPianoHook += TranslationAncientPianoHook;
        }

        public override void Unload()
        {
            AncientBathHook -= TranslationAncientBathHook;
            AncientWorkbenchHook -= TranslationAncientWorkbenchHook;
            AncientPianoHook -= TranslationAncientPianoHook;
        }

        private void TranslationAncientBathHook(ILContext il) => TranslationUtils.ILTranslate(il, "Ancient Bathtub", "Древняя ванна");

        private void TranslationAncientWorkbenchHook(ILContext il) => TranslationUtils.ILTranslate(il, "Ancient Work Bench", "Древний верстак");

        private void TranslationAncientPianoHook(ILContext il) => TranslationUtils.ILTranslate(il, "Ancient Pipe Organ", "Древний трубный орган");
    }

    public class FurnitureAstralIL : ILEdit
    {
        private event ILContext.Manipulator MonolithBathtubHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithBathtub).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithBathtub).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithBedHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithBed).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithBed).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithBenchHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithBench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithBench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithBookcaseHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithBookcase).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithBookcase).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithCandelabraHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithCandelabra).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithCandelabra).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithCandleHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithCandle).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithCandle).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithChairHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithChair).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithChair).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithChandelierHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithChandelier).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithChandelier).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithChestHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithChest).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithChest).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithClockHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithClock).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithClock).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithDoorHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithDoor).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithDoor).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithDresserHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithDresser).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithDresser).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithLampHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithLamp).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithLamp).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithPianoHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithPiano).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithPiano).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithLanternHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithLantern).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithLantern).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithPlatformHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithPlatform).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithPlatform).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithSinkHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithSink).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithSink).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithTableHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithTable).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithTable).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        private event ILContext.Manipulator MonolithWorkBenchHook
        {
            add => HookEndpointManager.Modify(typeof(MonolithWorkBench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(MonolithWorkBench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            MonolithBathtubHook += TranslationMonolithBathtubHook;
            MonolithBedHook += TranslationMonolithBedHook;
            MonolithBenchHook += TranslationMonolithBenchHook;
            MonolithBookcaseHook += TranslationMonolithBookcaseHook;
            MonolithCandelabraHook += TranslationMonolithCandelabraHook;
            MonolithCandleHook += TranslationMonolithCandleHook;
            MonolithChairHook += TranslationMonolithChairHook;
            MonolithChandelierHook += TranslationMonolithChandelierHook;
            MonolithChestHook += TranslationMonolithChestHook;
            MonolithClockHook += TranslationMonolithClockHook;
            MonolithDoorHook += TranslationMonolithDoorHook;
            MonolithDresserHook += TranslationMonolithDresserHook;
            MonolithLampHook += TranslationMonolithLampHook;
            MonolithPianoHook += TranslationMonolithPianoHook;
            MonolithLanternHook += TranslationMonolithLanternHook;
            MonolithPlatformHook += TranslationMonolithPlatformHook;
            MonolithSinkHook += TranslationMonolithSinkHook;
            MonolithTableHook += TranslationMonolithTableHook;
            MonolithWorkBenchHook += TranslationMonolithWorkBenchHook;
        }

        public override void Unload()
        {
            MonolithBathtubHook -= TranslationMonolithBathtubHook;
            MonolithBedHook -= TranslationMonolithBedHook;
            MonolithBenchHook -= TranslationMonolithBenchHook;
            MonolithBookcaseHook -= TranslationMonolithBookcaseHook;
            MonolithCandelabraHook -= TranslationMonolithCandelabraHook;
            MonolithCandleHook -= TranslationMonolithCandleHook;
            MonolithChairHook -= TranslationMonolithChairHook;
            MonolithChandelierHook -= TranslationMonolithChandelierHook;
            MonolithChestHook -= TranslationMonolithChestHook;
            MonolithClockHook -= TranslationMonolithClockHook;
            MonolithDoorHook -= TranslationMonolithDoorHook;
            MonolithDresserHook -= TranslationMonolithDresserHook;
            MonolithLampHook -= TranslationMonolithLampHook;
            MonolithPianoHook -= TranslationMonolithPianoHook;
            MonolithLanternHook -= TranslationMonolithLanternHook;
            MonolithPlatformHook -= TranslationMonolithPlatformHook;
            MonolithSinkHook -= TranslationMonolithSinkHook;
            MonolithTableHook -= TranslationMonolithTableHook;
            MonolithWorkBenchHook -= TranslationMonolithWorkBenchHook;
        }

        private void TranslationMonolithBathtubHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Bathtub", "Монолитная ванна");

        private void TranslationMonolithBedHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Bed", "Монолитная кровать");

        private void TranslationMonolithBenchHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Bench", "Монолитная скамья");

        private void TranslationMonolithBookcaseHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Bookcase", "Монолитный книжный шкаф");

        private void TranslationMonolithCandelabraHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Candelabra", "Монолитный канделябр");

        private void TranslationMonolithCandleHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Candle", "Монолитная свеча");

        private void TranslationMonolithChairHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Chair", "Монолитный стул");

        private void TranslationMonolithChandelierHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Chandelier", "Монолитная люстра");

        private void TranslationMonolithChestHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Chest", "Монолитный сундук");

        private void TranslationMonolithClockHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Clock", "Монолитные часы");

        private void TranslationMonolithDoorHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Door", "Монолитная дверь");

        private void TranslationMonolithDresserHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Dresser", "Монолитный комод");

        private void TranslationMonolithLampHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Lamp", "Монолитная лампа");

        private void TranslationMonolithPianoHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Piano", "Монолитное пианино");

        private void TranslationMonolithLanternHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Lantern", "Монолитный фонарь");

        private void TranslationMonolithPlatformHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Platform", "Монолитная платформа");

        private void TranslationMonolithSinkHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Sink", "Монолитная раковина");

        private void TranslationMonolithTableHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Table", "Монолитный стол");

        private void TranslationMonolithWorkBenchHook(ILContext il) => TranslationUtils.ILTranslate(il, "Monolith Work Bench", "Монолитный верстак");
    }

    public class PolterghastIL : ILEdit
    {
        private event ILContext.Manipulator PolterghastHook
        {
            add => HookEndpointManager.Modify(typeof(Polterghast).GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(Polterghast).GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => PolterghastHook += TranslationPolterghastHook;

        public override void Unload() => PolterghastHook -= TranslationPolterghastHook;

        private void TranslationPolterghastHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Necroghast", "Некрогаст");
            TranslationUtils.ILTranslate(il, "Necroplasm", "Некроплазм");
        }
    }

    public class DeathIL : ILEdit
    {
        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => Death.UseItem += TranslationDeathUseItem;

        private bool TranslationDeathUseItem(Death.orig_UseItem orig, global::CalamityMod.Items.DifficultyItems.Death self, object player)
        {
            if (Main.netMode == 1)
            {
                return true;
            }
            
            if (CalamityPlayer.areThereAnyDamnBosses || CalamityWorld.DoGSecondStageCountdown > 0 || BossRushEvent.BossRushActive)
            {
                string key = "Mods.CalamityMod.ChangingTheRules";
                Color crimson = Color.Crimson;
                CalamityUtils.DisplayLocalizedText(key, crimson);
                return true;
            }
            if (!CalamityWorld.death)
            {
                CalamityWorld.death = true;
                string key2 = !Main.dedServ ? "Смерть активирована; наслаждайся весельем." : "Смерть активирована; наслаждайтесь весельем.";
                Color crimson2 = Color.Crimson;
                CalamityUtils.DisplayLocalizedText(key2, crimson2);
            }
            else
            {
                CalamityWorld.death = false;
                string key3 = !Main.dedServ ? "Смерть деактивирована; недостаточно весело для тебя?" : "Смерть деактивирована; недостаточно весело для вас?";
                Color crimson3 = Color.Crimson;
                CalamityUtils.DisplayLocalizedText(key3, crimson3);
            }
            CalamityWorld.DoGSecondStageCountdown = 0;
            CalamityNetcode.SyncWorld();
            
            return true;
        }

        public override void Unload() => Death.UseItem -= TranslationDeathUseItem;
    }
    
    public class AstralArcanumUIIL : ILEdit
    {
        private event ILContext.Manipulator UpdateAndDrawHook
        {
            add => HookEndpointManager.Modify(typeof(AstralArcanumUI).GetMethod("UpdateAndDraw", BindingFlags.Public | BindingFlags.Static), value);

            remove => HookEndpointManager.Unmodify(typeof(AstralArcanumUI).GetMethod("UpdateAndDraw", BindingFlags.Public | BindingFlags.Static), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => UpdateAndDrawHook += TranslationUpdateAndDrawHook;

        public override void Unload() => UpdateAndDrawHook -= TranslationUpdateAndDrawHook;

        private void TranslationUpdateAndDrawHook(ILContext il) => TranslationUtils.ILTranslate(il, "Select", "Выбрать");
    }
    
    public class WITCHIL : ILEdit
    {
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(typeof(WITCH).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);

            remove => HookEndpointManager.Unmodify(typeof(WITCH).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;

        public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;

        private void TranslationSetChatButtonsHook(ILContext il) => TranslationUtils.ILTranslate(il, "Enchant", "Зачарование");
    }

    public class ExoMechSelectionUIIL : ILEdit
    {
        private event ILContext.Manipulator HandleInteractionWithButtonHook
        {
            add => HookEndpointManager.Modify(typeof(ExoMechSelectionUI).GetMethod("HandleInteractionWithButton", BindingFlags.Public | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(typeof(ExoMechSelectionUI).GetMethod("HandleInteractionWithButton", BindingFlags.Public | BindingFlags.Static), value);
        }
        
        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;
        
        public override void Load() => HandleInteractionWithButtonHook += TranslationHandleInteractionWithButtonHook;
        
        public override void Unload() => HandleInteractionWithButtonHook -= TranslationHandleInteractionWithButtonHook;
        
        private void TranslationHandleInteractionWithButtonHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets.", "Танатос - змееподобное создание с непробиваемой броней и несчётными лазерными турелями.");
            TranslationUtils.ILTranslate(il, "Ares, a heavyweight, diabolical monstrosity with four Exo superweapons.", "Арес - тяжеловесное чудовище с четырьмя экзо-супероружиями.");
            TranslationUtils.ILTranslate(il, "Artemis and Apollo, a pair of extremely agile destroyers with pulse cannons.", "Артемида и Аполлон - тандем чрезвычайно маневренных уничтожителей, обладающих импульсными пушками.");
        }
    }
    
    public class CalamitasEnchantUIIL : ILEdit
    {
        private event ILContext.Manipulator DrawEnchantmentCostHook
        {
            add => HookEndpointManager.Modify(typeof(CalamitasEnchantUI).GetMethod("DrawEnchantmentCost", BindingFlags.Public | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(typeof(CalamitasEnchantUI).GetMethod("DrawEnchantmentCost", BindingFlags.Public | BindingFlags.Static), value);
        }
        
        private event ILContext.Manipulator InteractWithEnchantIconHook
        {
            add => HookEndpointManager.Modify(typeof(CalamitasEnchantUI).GetMethod("InteractWithEnchantIcon", BindingFlags.Public | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(typeof(CalamitasEnchantUI).GetMethod("InteractWithEnchantIcon", BindingFlags.Public | BindingFlags.Static), value);
        }
        
        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;
        
        public override void Load()
        {
            DrawEnchantmentCostHook += TranslationHandleInteractionWithButtonHook;
            InteractWithEnchantIconHook += TranslationInteractWithEnchantIconHook;
        }

        public override void Unload()
        {
            DrawEnchantmentCostHook -= TranslationHandleInteractionWithButtonHook;
            InteractWithEnchantIconHook -= TranslationInteractWithEnchantIconHook;
        }

        private void TranslationHandleInteractionWithButtonHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Cost: ", "Стоимость: ");
            TranslationUtils.ILTranslate(il, "Exhume", "Наполнение");
        }
        
        private void TranslationInteractWithEnchantIconHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Exhume", "Наполнение");
            TranslationUtils.ILTranslate(il, "Exhume", "Наполнение", 2);
            TranslationUtils.ILTranslate(il, "Exhume", "Наполнение", 3);
        }
    }
    
    public class ModeIndicatorUIIL : ILEdit
    {
        private event ILContext.Manipulator DrawHook
        {
            add => HookEndpointManager.Modify(typeof(ModeIndicatorUI).GetMethod("Draw", BindingFlags.Public | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(typeof(ModeIndicatorUI).GetMethod("Draw", BindingFlags.Public | BindingFlags.Static), value);
        }
        
        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;
        
        public override void Load() => DrawHook += TranslationDrawHook;
        
        public override void Unload() => DrawHook -= TranslationDrawHook;
        
        private void TranslationDrawHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Death", "Смерть");
            TranslationUtils.ILTranslate(il, "Revengeance", "Месть");
            TranslationUtils.ILTranslate(il, " Mode is ", " ");
            TranslationUtils.ILTranslate(il, "active", "активирована");
            TranslationUtils.ILTranslate(il, "not active", "деактивирована");
            TranslationUtils.ILTranslate(il, "Armageddon is ", "Армагеддон ");
            TranslationUtils.ILTranslate(il, "active", "активирован", 2);
            TranslationUtils.ILTranslate(il, "not active", "деактивирован", 2);
            TranslationUtils.ILTranslate(il, "Malice Mode is ", "Злоба ");
            TranslationUtils.ILTranslate(il, "active", "активирована", 3);
            TranslationUtils.ILTranslate(il, "not active", "деактивирована", 3);
        }
    }
    
    public class CodebreakerUIIL : ILEdit
    {
        private event ILContext.Manipulator DisplayCostTextHook
        {
            add => HookEndpointManager.Modify(typeof(CodebreakerUI).GetMethod("DisplayCostText", BindingFlags.Public | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(typeof(CodebreakerUI).GetMethod("DisplayCostText", BindingFlags.Public | BindingFlags.Static), value);
        }
        
        private event ILContext.Manipulator DrawDecryptCancelConfirmationTextHook
        {
            add => HookEndpointManager.Modify(typeof(CodebreakerUI).GetMethod("DrawDecryptCancelConfirmationText", BindingFlags.Public | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(typeof(CodebreakerUI).GetMethod("DrawDecryptCancelConfirmationText", BindingFlags.Public | BindingFlags.Static), value);
        }
        
        private event ILContext.Manipulator HandleDraedonSummonButtonHook
        {
            add => HookEndpointManager.Modify(typeof(CodebreakerUI).GetMethod("HandleDraedonSummonButton", BindingFlags.Public | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(typeof(CodebreakerUI).GetMethod("HandleDraedonSummonButton", BindingFlags.Public | BindingFlags.Static), value);
        }
        
        private event ILContext.Manipulator DisplayNotStrongEnoughErrorTextHook
        {
            add => HookEndpointManager.Modify(typeof(CodebreakerUI).GetMethod("DisplayNotStrongEnoughErrorText", BindingFlags.Public | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(typeof(CodebreakerUI).GetMethod("DisplayNotStrongEnoughErrorText", BindingFlags.Public | BindingFlags.Static), value);
        }
        
        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;
        
        public override void Load()
        {
            DisplayCostTextHook += TranslationDisplayCostTextHook;
            DrawDecryptCancelConfirmationTextHook += TranslationDrawDecryptCancelConfirmationTextHook;
            HandleDraedonSummonButtonHook += TranslationHandleDraedonSummonButtonHook;
            DisplayNotStrongEnoughErrorTextHook += TranslationDisplayNotStrongEnoughErrorTextHook;
        }

        public override void Unload()
        {
            DisplayCostTextHook -= TranslationDisplayCostTextHook;
            DrawDecryptCancelConfirmationTextHook -= TranslationDrawDecryptCancelConfirmationTextHook;
            HandleDraedonSummonButtonHook -= TranslationHandleDraedonSummonButtonHook;
            DisplayNotStrongEnoughErrorTextHook -= TranslationDisplayNotStrongEnoughErrorTextHook;
        }

        private void TranslationDisplayCostTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "Cost: ", "Стоимость: ");
        
        private void TranslationDrawDecryptCancelConfirmationTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "Are you sure?", "Вы уверены?");
        
        private void TranslationHandleDraedonSummonButtonHook(ILContext il) => TranslationUtils.ILTranslate(il, "Contact", "Контакт");
        
        private void TranslationDisplayNotStrongEnoughErrorTextHook(ILContext il) => TranslationUtils.ILTranslate(il, "Encryption unsolveable: Upgrades required.", "Шифрование нерешаемое: требуются обновления.");
    }
    
    public class ChargeMeterUIIL : ILEdit
    {
        private event ILContext.Manipulator DrawHook
        {
            add => HookEndpointManager.Modify(typeof(ChargeMeterUI).GetMethod("Draw", BindingFlags.Public | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(typeof(ChargeMeterUI).GetMethod("Draw", BindingFlags.Public | BindingFlags.Static), value);
        }
        
        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;
        
        public override void Load() => DrawHook += TranslationDrawHook;
        
        public override void Unload() => DrawHook -= TranslationDrawHook;
        
        private void TranslationDrawHook(ILContext il) => TranslationUtils.ILTranslate(il, "Current Charge: ", "Текущий заряд: ");
    }
    
    public class TECodebreakerIL : ILEdit
    {
        private event ILContext.Manipulator DrawHook
        {
            add => HookEndpointManager.Modify(typeof(TECodebreaker).GetMethod("get_UnderlyingSchematicText", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(TECodebreaker).GetMethod("get_UnderlyingSchematicText", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;
        
        public override void Load() => DrawHook += TranslationDrawHook;
        
        public override void Unload() => DrawHook -= TranslationDrawHook;
        
        private void TranslationDrawHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Within an army, as weapons do, the soldiers serve different purposes. That distinction is crucial, as the wrong tool in the wrong hands—no matter how potent—may as well be a wooden club.\nAddendum: Seek out my base of operations closest to the Lihzard’s home. I wish you the best of luck with all sincerity, for it has been a long time since I have had a worthy test subject. ", "В армии солдаты, как и оружие, служат разным целям. Это различие имеет решающее значение, поскольку неправильный инструмент в неправильных руках, каким бы мощным он ни был, с таким же успехом может быть деревянной дубиной.\nДополнение: Найдите мою базу, она недалеко от храма ящщеров. Искренне желаю вам удачи. Прошло много времени с тех пор, как у меня был достойный испытуемый.");
            TranslationUtils.ILTranslate(il, "As rank progresses, so often does the lethality of equipment. In the hands of competent soldiers, the weapons have the ability to make change. However, competent soldiers take no action but orders from above.\nAddendum: If you read this, you have come far. Do not disappoint. Go now to Hell, for the next component stored in what were once my forges.", "С ростом в звании неизбежен и рост мощности снаряжения. В компетентных руках оружие способно вносить огромные изменения на всём поле боя. Но эти же руки не самостоятельны, лишь выполняют приказы.\nДополнение: Вы далеко продвинулись. Не разочаровывайте. Теперь идите в Ад. Следующий компонент хранится в месте, что некогда были моими кузницами.");
            TranslationUtils.ILTranslate(il, "Only the highest ranking in the battalions of Yharim’s army held these weapons. However these are still not my most potent tools. Those...characters could not be trusted with them.\nAddendum: The final piece remains. Travel now from the hottest fire this land has to offer, to the most frigid cold. I cannot deny having some sense of poetic symmetry.", "Лишь высшие чины армии Ярима обладали столь смертоносным оружием. Но даже им я не мог доверить мои последние разработки. Этим... лицам не было доверия.\nДополнение: Осталось немного. Теперь же путешествуйте от самого жаркого огня, который может предложить эта земля, до самого лютого мороза. Не могу отрицать, у меня есть некоторое чувство поэтической симметрии.");
            TranslationUtils.ILTranslate(il, "I have since made progress to even greater weapons than these, but they remain creations to be proud of. No progress can be made without a desire that comes from dissatisfaction.\nAddendum: The time has come. You are ready.", "С тех пор я добился немалого прогресса в создании ещё более смертоносного оружия, но они остаются творениями, которыми можно гордиться. Не может быть достигнуто прогресса без желания, проистекающего из неудовлетворённости.\nДополнение: Время пришло. Ты готов.");
        }
    }
    
    public class CalamityGlobalItemIL : ILEdit
    {
        private event ILContext.Manipulator HookStatsTooltipHook
        {
            add => HookEndpointManager.Modify(typeof(CalamityGlobalItem).GetMethod("<ModifyVanillaTooltips>g__HookStatsTooltip|197_104", BindingFlags.NonPublic | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(typeof(CalamityGlobalItem).GetMethod("<ModifyVanillaTooltips>g__HookStatsTooltip|197_104", BindingFlags.NonPublic | BindingFlags.Static), value);
        }
        
        public override bool Autoload() => ModsCall.Calamity != null && TranslationUtils.IsRussianLanguage;
        
        public override void Load() => HookStatsTooltipHook += TranslationHookStatsTooltipHook;
        
        public override void Unload() => HookStatsTooltipHook -= TranslationHookStatsTooltipHook;
        
        private void TranslationHookStatsTooltipHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Reach: {0:N3} tiles\n", "Дальность: {0} блоков\n");
            TranslationUtils.ILTranslate(il, "Launch Velocity: {0:N2}\n", "Скорость вылета: {0}\n");
            TranslationUtils.ILTranslate(il, "Reelback Velocity: {0:N2}\n", "Скорость возврата: {0}\n");
            TranslationUtils.ILTranslate(il, "Pull Velocity: {0:N2}", "Скорость притягивания: {0}");
        }
    }
}