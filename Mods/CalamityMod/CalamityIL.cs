using System.Reflection;
using CalamityMod;
using CalamityMod.CalPlayer;
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
using CalamityMod.Items.Weapons.Melee;
using CalamityMod.Items.Weapons.Ranged;
using CalamityMod.Items.Weapons.Summon;
using CalamityMod.NPCs.Bumblebirb;
using CalamityMod.NPCs.Calamitas;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.NormalNPCs;
using CalamityMod.NPCs.Perforator;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.ProfanedGuardians;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.TownNPCs;
using CalamityMod.Projectiles.Boss;
using CalamityMod.Projectiles.Pets;
using CalamityMod.Tiles.FurniturePlaguedPlate;
using CalamityMod.UI;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Utilities;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class RipperUIIL : ILEdit
    {
        private event ILContext.Manipulator RipperUIHook
        {
            add => HookEndpointManager.Modify(typeof(RipperUI).GetMethod("HandleMouseInteraction", BindingFlags.Static | BindingFlags.NonPublic), value);
            
            remove => HookEndpointManager.Unmodify(typeof(RipperUI).GetMethod("HandleMouseInteraction", BindingFlags.Static | BindingFlags.NonPublic), value);
        }

        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;

        public override void Load() => RipperUIHook += TranslationRipperUIHook;

        public override void Unload() => RipperUIHook -= TranslationRipperUIHook;

        private void TranslationRipperUIHook(ILContext il)
        {
            Translation.ILTranslate(il, "Adrenaline: {0} / {1}", Translation.EncodeToUtf16("Адреналин: {0} / {1}"));
            Translation.ILTranslate(il, "Rage: {0} / {1}", Translation.EncodeToUtf16("Ярость: {0} / {1}"));
        }
    }
    
    public class StealthUIIL : ILEdit
    {
        
    
        private event ILContext.Manipulator StealthUIHook
        {
            add => HookEndpointManager.Modify(typeof(StealthUI).GetMethod("Draw", BindingFlags.Static | BindingFlags.Public), value);
            
            remove => HookEndpointManager.Unmodify(typeof(StealthUI).GetMethod("Draw", BindingFlags.Static | BindingFlags.Public), value);
        }
    
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => StealthUIHook += TranslationStealthUIHook;
    
        public override void Unload() => StealthUIHook -= TranslationStealthUIHook;
        
        private void TranslationStealthUIHook(ILContext il) => Translation.ILTranslate(il, "Stealth: ", Translation.EncodeToUtf16("Скрытность: "));
    }
    
    public class AcidRainUIIL: ILEdit
    {
        
    
        private event ILContext.Manipulator AcidRainUIHook
        {
            add => HookEndpointManager.Modify(typeof(AcidRainUI).GetMethod("get_InvasionName", BindingFlags.Instance | BindingFlags.Public), value);
            
            remove => HookEndpointManager.Unmodify(typeof(AcidRainUI).GetMethod("get_InvasionName", BindingFlags.Instance | BindingFlags.Public), value);
        }
    
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
    
        public override void Load() => AcidRainUIHook += TranslationAcidRainUIHook;
    
        public override void Unload() => AcidRainUIHook -= TranslationAcidRainUIHook;
        
        private void TranslationAcidRainUIHook(ILContext il) => Translation.ILTranslate(il, "Acid Rain", Translation.EncodeToUtf16("Кислотный дождь"));
    }
    
    public class CalamityPlayerIL: ILEdit
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
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load()
        {
            PreKillHook += TranslationPreKillHook;
            KillPlayerHook += TranslationKillPlayerHook;
        }
    
        public override void Unload()
        {
            PreKillHook -= TranslationPreKillHook;
            KillPlayerHook -= TranslationKillPlayerHook;
        }
    
        private void TranslationPreKillHook(ILContext il)
        {
            Translation.ILTranslate(il, " downed too many shots.", Translation.EncodeToUtf16(" выпил слишком много напитков."));
            Translation.ILTranslate(il, "'s liver failed.", Translation.EncodeToUtf16(" отказала печень."));
            Translation.ILTranslate(il, " was charred by the brimstone inferno.", Translation.EncodeToUtf16(" был обуглен серным пламенем."));
            Translation.ILTranslate(il, "'s soul was released by the lava.", Translation.EncodeToUtf16(" душа была освобождена лавой."));
            Translation.ILTranslate(il, "'s soul was extinguished.", Translation.EncodeToUtf16(" душа была погашена."));
            Translation.ILTranslate(il, " was melted by the toxic waste.", Translation.EncodeToUtf16(" был расплавлен токсичными отходами."));
            Translation.ILTranslate(il, " disintegrated into ashes.", Translation.EncodeToUtf16(" рассыпался в прах."));
            Translation.ILTranslate(il, " was turned to ashes by the Profaned Goddess.", Translation.EncodeToUtf16(" был обращён Осквернённой богиней в пепел."));
            Translation.ILTranslate(il, " fell prey to their sins.", Translation.EncodeToUtf16(" пал жертвой своих грехов."));
            Translation.ILTranslate(il, "'s spirit was turned to ash.", Translation.EncodeToUtf16(" дух превратился в пепел."));
            Translation.ILTranslate(il, " became a blood geyser.", Translation.EncodeToUtf16(" стал кровавым гейзером."));
            Translation.ILTranslate(il, " was crushed by the pressure.", Translation.EncodeToUtf16(" был раздавлен давлением."));
            Translation.ILTranslate(il, "'s lungs collapsed.", Translation.EncodeToUtf16(" лёгкие отказали."));
            Translation.ILTranslate(il, " was consumed by the black flames.", Translation.EncodeToUtf16(" был поглощён чёрным пламенем."));
            Translation.ILTranslate(il, "'s flesh was melted by the plague.", Translation.EncodeToUtf16(" плоть была расплавлена чумой."));
            Translation.ILTranslate(il, " didn't vaccinate.", Translation.EncodeToUtf16(" не сделал прививок."));
            Translation.ILTranslate(il, "'s infection spread too far.", Translation.EncodeToUtf16(" инфекция распространилась слишком сильно."));
            Translation.ILTranslate(il, "'s skin was replaced by the astral virus.", Translation.EncodeToUtf16(" кожа была заменена астральным вирусом."));
            Translation.ILTranslate(il, " was incinerated by lunar rays.", Translation.EncodeToUtf16(" был испепелён лунными лучами."));
            Translation.ILTranslate(il, " vaporized into thin air.", Translation.EncodeToUtf16(" растворился в воздухе."));
            Translation.ILTranslate(il, "'s life was completely converted into mana.", Translation.EncodeToUtf16(" здоровье было полностью преобразовано в ману."));
            Translation.ILTranslate(il, " succumbed to alcohol sickness.", Translation.EncodeToUtf16(" поддался алкогольной болезни."));
            Translation.ILTranslate(il, " was summoned too soon.", Translation.EncodeToUtf16(" был призван слишком рано."));
        }
        
        private void TranslationKillPlayerHook(ILContext il)
        {
            Translation.ILTranslate(il, " is food for the Wyrms.", Translation.EncodeToUtf16(" стал пищей для змей."));
            Translation.ILTranslate(il, "Oxygen failed to reach ", Translation.EncodeToUtf16("Не хватило кислорода для "));
            Translation.ILTranslate(il, " from the depths of the Abyss.", Translation.EncodeToUtf16(" из глубин бездны."));
            Translation.ILTranslate(il, " was defeated.", Translation.EncodeToUtf16(" был повержен."));
            Translation.ILTranslate(il, " was chilled to the bone by the frigid environment.", Translation.EncodeToUtf16(" промёрз до костей из-за холодной окружающей среды."));
            Translation.ILTranslate(il, " was consumed by his inner hatred.", Translation.EncodeToUtf16(" был поглощён своей внутренней ненавистью."));
            Translation.ILTranslate(il, " was consumed by her inner hatred.", Translation.EncodeToUtf16(" была поглощена своей внутренней ненавистью."));
            Translation.ILTranslate(il, " failed the challenge at hand.", Translation.EncodeToUtf16(" не справился с испытанием."));
            Translation.ILTranslate(il, " was destroyed by a mysterious force.", Translation.EncodeToUtf16(" был уничтожен таинственной силой."));
        }
    }
    
    public class CheatTestThingIL: ILEdit
    {
        
        
        private event ILContext.Manipulator CheatTestThingHook
        {
            add => HookEndpointManager.Modify(typeof(CheatTestThing).GetMethod("UpdateAccessory", BindingFlags.Instance | BindingFlags.Public), value);
        
            remove => HookEndpointManager.Unmodify(typeof(CheatTestThing).GetMethod("UpdateAccessory", BindingFlags.Instance | BindingFlags.Public), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => CheatTestThingHook += TranslationCheatTestThingHook;
    
        public override void Unload() => CheatTestThingHook -= TranslationCheatTestThingHook;
        
        private void TranslationCheatTestThingHook(ILContext il) => Translation.ILTranslate(il, " isn't worthy.", Translation.EncodeToUtf16(" не достоин."));
    }
    
    public class DraedonLogHellGUIIL: ILEdit
    {
        
            
        private event ILContext.Manipulator DraedonLogHellGUIHook
        {
            add => HookEndpointManager.Modify(typeof(DraedonLogHellGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(DraedonLogHellGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => DraedonLogHellGUIHook += TranslationDraedonLogHellGUIHook;
    
        public override void Unload() => DraedonLogHellGUIHook -= TranslationDraedonLogHellGUIHook;
        
        private void TranslationDraedonLogHellGUIHook(ILContext il)
        {
            Translation.ILTranslate(il, "The entire landscape is a constant source of geothermal energy, and heat for a forge. If it was not entirely uninhabitable save for demons and spirits, I would conduct much more of my research in the bowels of the earth. Where I have actively chosen not to settle however, is in the crags of the underworld. There, the magma is... uncooperative and far more corrosive than should be possible, as it is saturated with cursed, twisted souls, courtesy of that Witch.", Translation.EncodeToUtf16("Весь природный ландшафт — постоянный источник геотермальной энергии и тепла для кузни. Если бы он не был совсем необитаемым, за исключением демонов и духов, я бы проводил больше исследований в недрах земли. Где я точно ни поселился бы, так это в скалах ада. Магма там... 'несговорчива' и агрессивна, намного больше, чем это возможно. Всё из-за того, что она пропиталась проклятыми тёмными душами, любезно предоставленными этой Ведьмой."));
            Translation.ILTranslate(il, "A blade completely inundated with my surroundings during the time of its creation. It was tempered by the fires which are fueled by spirits, and formed in the magma I draw into my laboratories. Its cutting edge, unparalleled, though its reach is limited making general usage questionable. I would consider it my very first foray into work for the sake of craftsmanship and art. If I was born synthetically, any creation which leads one to question whether I was, is a creation I may be proud of. It shows that I can after all, be graced by a muse.", Translation.EncodeToUtf16("Меч, полностью окружённый моим вниманием во время создания. Он сформировался в магме, а закалён огнём душ. Его лезвие — непревзойдённое, хотя его дальность ограничена, что делает общее применение сомнительным. Я думаю, что это моя первая работа, сделанная во имя искусства и мастерства. Если я был рождён синтетически, то любое моё творение, вызывающие вопрос: «Был ли я создан?» — результат, которым можно гордиться. Это доказывает, что я всё же могу быть удостоенным музы."));
            Translation.ILTranslate(il, "What a terrible abomination and yet an enticing subject. Not unlike the fusion of spirits which haunts the dungeons, this entity is formed not of one, but a multitude of sinners. What holds different for it however, is that the limitations caused by the artificiality of the dungeon's existence do not apply to it. It is the laws of hell which brought them together into a single overlord of the underworld. And when an innocent life is sacrificed... Their hunger, which appears to be in tune with the afterlife, surges.", Translation.EncodeToUtf16("Какое ужасное существо, но всё же интересное с научной точки зрения. В отличие от сплава душ темницы, эта сущность была сформирована не из одного грешника, а из многих. Ещё одно отличие заключается в том, что ограничения, вызванные искусственным происхождением темницы, неприменимы к нему. Именно законы Ада свели их вместе в единого владыку подземного мира. И когда невинная жизнь приносится в жертву... Их голод, который, кажется, является частью загробной жизни, нарастает."));
        }
    }
    
    public class DraedonLogJungleGUIIL: ILEdit
    {
        
            
        private event ILContext.Manipulator DraedonLogJungleGUIHook
        {
            add => HookEndpointManager.Modify(typeof(DraedonLogJungleGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(DraedonLogJungleGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => DraedonLogJungleGUIHook += TranslationDraedonLogJungleGUIHook;
    
        public override void Unload() => DraedonLogJungleGUIHook -= TranslationDraedonLogJungleGUIHook;
        
        private void TranslationDraedonLogJungleGUIHook(ILContext il)
        {
            Translation.ILTranslate(il, "As I record this, it would not be a stretch to call the jungle the hub of this planet. All is centered around it, and none know not of it. It brings me no small amount of unease to see the uncomfortable, raw forms of the living beings who pass through on their journeys above. Fortunately these labs provide everything I need in my research and more. There is no need to ever visit the surface, save for summons on the Lord's orders.", Translation.EncodeToUtf16("Поскольку я записываю это, не будет ошибкой назвать джунгли центром этой планеты. Всё сосредоточено вокруг них, но мало кто знает об этом. Я испытываю немалое беспокойство, видя неудобные, грубые формы живых существ, которые живут в них наверху. К счастью, эти лаборатории обеспечивают всё, что мне нужно в моих исследованиях и не только. Нет никакой необходимости когда-либо посещать поверхность, за исключением вызова по приказу Лорда."));
            Translation.ILTranslate(il, "Mechanically augmented, the Queen Bee which I had prior experimented on was theoretically a perfect host for the plague virus. When the first sign of the technology bonding with the creature began however, the problems also showed immediately. The mind of the insect fought the control of the nanotechnology, nothing like the simpler creatures I had used as test subjects. It grew increasingly violent, and only once subdued did it receive simple orders. However, if we were to utilize it at all, there is no other way than to let it roam free entirely. I will consider this further.", Translation.EncodeToUtf16("Механически усиленная королева пчёл, над которой я ранее экспериментировал, теоретически была идеальным разносчиком чумы. Однако, когда технологии начали менять сущность пчелы, начались проблемы. Разум насекомого противостоял нанотехнологиям, такого раньше не происходило. Она выросла невероятно жестокой и почти не подчинялась приказам. Однако, если мы хотим использовать её, нет другого способа, кроме как позволить ей свободно разгуливать. Я продожлу изучать это дальше."));
            Translation.ILTranslate(il, "A virus, capable of devouring and converting almost anything. And nanotechnology, constructed painstakingly for the sake of control. Development was swift, and every piece fell into place almost eerily, forming an abhorrent existence. I struggle to think of practical applications which would be friendly to common life forms. However, it is not a major concern. Many were hesitant to continue its creation, but I granted them leave if they desired. I would have no need for any who were not entirely as dedicated as my machines.", Translation.EncodeToUtf16("Вирус, способный пожирать и превращать практически всё. И тщательно сделанная нанотехнология контроля. Превращение шло пугающе быстро, создавая мерзкую тварь. Я стараюсь сделать так, чтобы она была дружелюбна к обычным формам жизни. Однако это не главная проблема. Многие не решались продолжать создание, но я разрешил уйти, если они пожелают. Я не нуждался ни в ком, кто не был бы так же предан делу, как мои машины."));
        }
    }
    
    public class DraedonLogPlanetoidGUIIL: ILEdit
    {
        
            
        private event ILContext.Manipulator DraedonLogPlanetoidGUIHook
        {
            add => HookEndpointManager.Modify(typeof(DraedonLogPlanetoidGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(DraedonLogPlanetoidGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => DraedonLogPlanetoidGUIHook += TranslationDraedonLogPlanetoidGUIHook;
    
        public override void Unload() => DraedonLogPlanetoidGUIHook -= TranslationDraedonLogPlanetoidGUIHook;
        
        private void TranslationDraedonLogPlanetoidGUIHook(ILContext il)
        {
            Translation.ILTranslate(il, "Hung low in orbit, masses of ground and various parts of the world provide a secluded and distant point for research. Undeniably optimal for the science of astronomy and otherwise. In my labs here I grow many things, testing their limits against the cold and vacuum of the stratosphere. Though not many survive, the existence of certain creatures here, confirm the capabilities of life simply given more time.", Translation.EncodeToUtf16("Висящие низко на орбите массы земли и другие структуры мира, обеспечивают укромное и отдалённое место для исследований. Это оптимальный вариант для изучения астрономии и других наук. В моих лабораториях я выращиваю разные растения и тестирую их способность к выживанию в условиях холода и вакуума стратосферы. Несмотря на то, что многие растения погибают, существование жизни здесь подтверждается. Просто нужно дать этой жизни больше времени на развитие."));
            Translation.ILTranslate(il, "The bloated cosmic worm, though I understand why the Lord decides to employ it given he can control it, is a disgusting existence. However the idea of creating an armor suited to it in every way, was an offer I could not refuse. Forged from the cosmic steel of my own creation, it resists nearly any attack, yet allows the creature the same flexibility it would have without it, as well as augmenting its dimensional abilities. I remain pleased with the result.", Translation.EncodeToUtf16("Раздутый отвратительный космический червь. Впрочем, я понимаю, почему Лорд его использует, ведь он может его контролировать... Идея создания брони, подходящей ему во всех отношениях, была предложением, от которого я не мог отказаться. Выкованная из космической стали, моего собственного создания, броня защищала практически от любой атаки. А также она не уменьшает изначальной гибкости существа, а ещё увеличивает пространственные способности. Я доволен результатом."));
            Translation.ILTranslate(il, "I do not care much for the interstellar, or the cosmos. Though I have traversed it, there is still plenty in my own world to manage and discover at this time. Even if I once inhabited a different planet, the Lord's wishes that I provide him machinery were the only condition that I needed to leave it and settle elsewhere. Once I have discovered and dissected every part of this place, perhaps then, I could look up towards the macroscopic.", Translation.EncodeToUtf16("Меня мало волнует космос. Да, я путешествовал по нему, но сейчас мне достаточно работы по изучению собственного мира. Даже если бы я когда-то жил на другой планете, одного желания Лорда получать мои технологии было бы достаточно, чтобы я улетел с неё сюда. Если же я когда-нибудь полностью изучу каждый кусочек этого места, то тогда, возможно, я обращу свой взор наверх, в сторону макроскопического."));
        }
    }
    
    public class DraedonLogSnowBiomeGUIIL: ILEdit
    {
        
            
        private event ILContext.Manipulator DraedonLogSnowBiomeGUIHook
        {
            add => HookEndpointManager.Modify(typeof(DraedonLogSnowBiomeGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(DraedonLogSnowBiomeGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => DraedonLogSnowBiomeGUIHook += TranslationDraedonLogSnowBiomeGUIHook;
    
        public override void Unload() => DraedonLogSnowBiomeGUIHook -= TranslationDraedonLogSnowBiomeGUIHook;
        
        private void TranslationDraedonLogSnowBiomeGUIHook(ILContext il)
        {
            Translation.ILTranslate(il, "A freezing tundra, where only creatures entirely adapted to the subzero temperatures exist and thrive. It is a shocking transition from the forests of the purity and the sun baked desert. A climate like this should not exist naturally in this part of the world with ease. The weather patterns seem to shift unnaturally arounds the skies of these icy plains. There is likely a reason for this, which necessitates further research.", Translation.EncodeToUtf16("Холодная тундра, где существуют и процветают существа, полностью приспособленные к минусовым температурам. Это шокирующий переход от чистых лесов и выжженной солнцем пустыни. Климат, подобный этому, не должен существовать естественно. Погодные условия на этих ледяных равнинах, кажется, неестественно меняются. Вероятно, этому есть причина, которая требует дальнейших исследований."));
            Translation.ILTranslate(il, "I am not the only singular being to inhabit this biome. Once before, the Archmage who opposed the Lord resided here, cloaked by constant artificial blizzards of his own creation, which no longer fall. He likely chose this place as a conduit for research into his ice spells, and extended the period of time that this place remained frozen. Deep underground my research and materials lay well protected, but above in the natural storms there are traces of the prison of ice he resides in, still haunting its place of creation.", Translation.EncodeToUtf16("Я не единственное разумное существо, находившееся в этом биоме. До этого Архимаг, противостоявший Лорду, жил здесь. Скорее всего, он выбрал это место для изучения ледяных заклятий, одно из которых — нескончаемые ледяные бури. Его действия поддерживали биом в глубокой заморозке. Глубоко под землёй мои исследования хорошо защищены, но снаружи, в естественных бурях, есть следы ледяной тюрьмы, в которой он пребывает по сей день, всё ещё бродящей в месте своего создания."));
            Translation.ILTranslate(il, "Intriguing. Though embedded deep into the caverns of ice and worn from centuries of frost and meltwater, I have uncovered several mechanisms which once filled the tunnels here. The ingenuity present is remarkable, and I have found parallels within my own work, as well as devices even I have something to learn from. From where do these come? Why machinery so complex in so sparse and dreary a habitat? Perhaps, they are related to the unnatural conditions.", Translation.EncodeToUtf16("Интригующе. Я нашёл механизмы, когда-то заполнявшие туннели. Они находились в ледяных пещерах, поломанные из-за веков во льду и талой воды. Мастерство исполнения поражает. Я нашёл схожести с моими работами, а также узнал что-то новое. Но кто их создал? Почему настолько сложные машины находятся в такой скудной и унылой среде обитания. Возможно, именно они виноваты в настолько неестественных условиях."));
        }
    }
    
    public class DraedonLogSunkenSeaGUIIL: ILEdit
    {
        
            
        private event ILContext.Manipulator DraedonLogSunkenSeaGUIHook
        {
            add => HookEndpointManager.Modify(typeof(DraedonLogSunkenSeaGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(DraedonLogSunkenSeaGUI).GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => DraedonLogSunkenSeaGUIHook += TranslationDraedonLogSunkenSeaGUIHook;
    
        public override void Unload() => DraedonLogSunkenSeaGUIHook -= TranslationDraedonLogSunkenSeaGUIHook;
        
        private void TranslationDraedonLogSunkenSeaGUIHook(ILContext il)
        {
            Translation.ILTranslate(il, "Preserved for millennia, a paradise for the living beings who sought shelter in prehistoric seas. They remain untouched by evolution, save for their adaptations to the oxygen starved waters and dim crystals, continuing to thrive. One mystery which continues to escape my understanding however, is how large some of the creatures have become. There is a blatant lack of nutrition and oxygen in the caves, and yet...", Translation.EncodeToUtf16("Сохранившийся на протяжении тысячелетий рай для живых существ, искавших убежища в доисторических морях. Они остаются не тронутыми эволюцией, за исключением их адаптации к необогащенной воздухом воде и тусклым кристаллам, продолжая процветать. Однако одна загадка, которая продолжает ускользать от моего понимания, заключается в том, насколько большими стали некоторые из этих существ. В пещерах явно не хватает питания и кислорода, и всё же..."));
            Translation.ILTranslate(il, "A specimen which has developed a grand size, and inexplicably, impressive psychic abilities. What is most curious is its strong connection to its lesser kin. Without any noticeable communication, when it comes under threat, other mollusks rally to its aggressor and begin attacking. Is this perhaps the very first signs of a higher life form, the evolutionary link hidden away in the sunken sea? Or a self sacrificial fluke, which would lead to their destruction if they inhabited any area other than these pacified caverns.", Translation.EncodeToUtf16("Образец, который развил грандиозные размеры и необъяснимо-впечатляющие телепатические способности. Что самое любопытное, так это его сильная связь со своими меньшими родственниками. Когда он оказывается под угрозой, другие моллюски окружают своего агрессора и начинают атаковать. Может быть, это самые первые признаки высшей формы жизни, эволюционное звено, скрытое в затерянном море? Или самоотверженная случайность, которая привела бы к уничтожению, если они населяли любую область, кроме этих умиротворённых пещер."));
            Translation.ILTranslate(il, "The marine life in these caves do have eyes though they are barely functional, dulled by lack of use and milky white upon observation. On their tough, gnarled hides, crystals find an easy purchase, and grow in great numbers, providing the creatures protection. Perhaps another adaptation to the life they have adopted. The most striking wonder is within their bodies. In specimens dissected, I have noticed that the mineral is buried into their very digestive systems, and perhaps, through some chemical process, pass nutrients into their sluggish hosts. A peculiar yet entirely beneficial interaction.", Translation.EncodeToUtf16("У морских обитателей в этих пещерах есть глаза-рудименты, внешне они молочно-белые. На их жёстких узловатых шкурах кристаллы растут в большом количестве, обеспечивая существам защиту. Возможно, это ещё одна адаптация к жизни, которую они приняли. Но самое поразительное чудо — внутренности их тел. В образцах, подвергнутых вскрытию, я заметил, что минерал находится в самой их пищеварительной системе и, возможно, через какой-то химический процесс передаёт питательные вещества их вялым хозяевам. Своеобразное, но совершенно благотворное взаимодействие."));
        }
    }
    
    public class WeakReferenceSupportIL: ILEdit
    {
        
            
        private event ILContext.Manipulator AddCalamityBossesHook
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("AddCalamityBosses", BindingFlags.Static | BindingFlags.NonPublic), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("AddCalamityBosses", BindingFlags.Static | BindingFlags.NonPublic), value);
        }
        
        private event ILContext.Manipulator CensusSupportHook
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("CensusSupport", BindingFlags.NonPublic | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("CensusSupport", BindingFlags.NonPublic | BindingFlags.Static), value);
        }
        
        private event ILContext.Manipulator AddCalamityInvasionsHook
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("AddCalamityInvasions", BindingFlags.NonPublic | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("AddCalamityInvasions", BindingFlags.NonPublic | BindingFlags.Static), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
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
            Translation.ILTranslate(il, "Use a [i:{0}] in the Desert Biome", Translation.EncodeToUtf16("Используйте [i:{0}] в пустыне."));
            Translation.ILTranslate(il, "The scourge of the desert delved back into the sand.", Translation.EncodeToUtf16("Пустынный бич снова погрузился в песок."));
            Translation.ILTranslate(il, "Desert Scourge", Translation.EncodeToUtf16("Пустынный бич"));
            Translation.ILTranslate(il, "Can spawn naturally in the Sunken Sea", Translation.EncodeToUtf16("Может естественно появится в затерянном море."));
            Translation.ILTranslate(il, "The Giant Clam returns into hiding in its grotto.", Translation.EncodeToUtf16("Гигантский моллюск скрывается в своём гроту."));
            Translation.ILTranslate(il, "Giant Clam", Translation.EncodeToUtf16("Гигантский моллюск"));
            Translation.ILTranslate(il, "Use a [i:{0}] in the Mushroom Biome", Translation.EncodeToUtf16("Используйте [i:{0}] в грибном биоме."));
            Translation.ILTranslate(il, "The mycleium crab has lost interest.", Translation.EncodeToUtf16("Мицелиевый краб потерял интерес."));
            Translation.ILTranslate(il, "Crabulon", Translation.EncodeToUtf16("Крабулон"), 2);
            Translation.ILTranslate(il, "Kill a Cyst in the Corruption or use a [i:{0}] in the Corruption", Translation.EncodeToUtf16("Убейте кисту или используйте [i:{0}] в искажении."));
            Translation.ILTranslate(il, "The corrupted colony began searching for a new breeding ground.", Translation.EncodeToUtf16("Искажённая стая начала поиски нового места для размножения."));
            Translation.ILTranslate(il, "Hive Mind", Translation.EncodeToUtf16("Разум Улья"));
            Translation.ILTranslate(il, "Kill a Cyst in the Crimson or use a [i:{0}] in the Crimson", Translation.EncodeToUtf16("Убейте кисту или используйте [i:{0}] в багрянце."));
            Translation.ILTranslate(il, "The parasitic hive began searching for a new host.", Translation.EncodeToUtf16("Паразитический улей начал искать нового носителя."));
            Translation.ILTranslate(il, "The Perforators", Translation.EncodeToUtf16("Перфораторы"));
            Translation.ILTranslate(il, "Use an [i:{0}]", Translation.EncodeToUtf16("Используйте [i:{0}]."));
            Translation.ILTranslate(il, "The gelatinous monstrosity achieved vengeance for its brethren.", Translation.EncodeToUtf16("Желатиновое чудовище отомстило за своих собратьев."));
            Translation.ILTranslate(il, "Slime God", Translation.EncodeToUtf16("Бог слизней"));
            Translation.ILTranslate(il, "Use a [i:{0}] in the Snow Biome", Translation.EncodeToUtf16("Используйте [i:{0}] в снегах."));
            Translation.ILTranslate(il, "Cryogen drifts away, carried on a freezing wind.", Translation.EncodeToUtf16("Криоген уносится прочь ледяным ветром."));
            Translation.ILTranslate(il, "Cryogen", Translation.EncodeToUtf16("Криоген"), 2);
            Translation.ILTranslate(il, "Use a [i:{0}] in the Brimstone Crag", Translation.EncodeToUtf16("Используйте [i:{0}] в серной скале."));
            Translation.ILTranslate(il, "Brimstone Elemental withdraws to the ruins of her shrine.", Translation.EncodeToUtf16("Серный элементаль отступает к руинам своей святыни."));
            Translation.ILTranslate(il, "Brimstone Elemental", Translation.EncodeToUtf16("Серный элементаль"));
            Translation.ILTranslate(il, "Use a [i:{0}] in the Sulphuric Sea or wait for it to spawn in the Sulphuric Sea", Translation.EncodeToUtf16("Используйте [i:{0}] или подождите его появление в сернистом море."));
            Translation.ILTranslate(il, "The Aquatic Scourge swam back into the open ocean.", Translation.EncodeToUtf16("Акватический бич уплыл обратно в открытый океан."));
            Translation.ILTranslate(il, "Aquatic Scourge", Translation.EncodeToUtf16("Акватический бич"));
            Translation.ILTranslate(il, "Use an [i:{0}] at Night", Translation.EncodeToUtf16("Используйте [i:{0}] ночью."));
            Translation.ILTranslate(il, "If you wanted a fight, you should've came more prepared.", Translation.EncodeToUtf16("Если вы хотели драки, вы должны были прийти более подготовленными."));
            Translation.ILTranslate(il, "Calamitas", Translation.EncodeToUtf16("Каламитас"), 2);
            Translation.ILTranslate(il, "Kill 10 sand sharks after defeating Plantera or use a [i:{0}] in the Desert Biome", Translation.EncodeToUtf16("Убейте 10 песчаных акул после победы над Плантерой или используйте [i:{0}] в пустыне."));
            Translation.ILTranslate(il, "The apex predator of the sands disappears into the dunes...", Translation.EncodeToUtf16("Высший хищник песков исчезает в дюнах..."));
            Translation.ILTranslate(il, "Great Sand Shark", Translation.EncodeToUtf16("Великая песчаная акула"));
            Translation.ILTranslate(il, "By killing an unknown entity in the Ocean Biome", Translation.EncodeToUtf16("Убейте неизвестное существо в океане"));
            Translation.ILTranslate(il, "The aquatic entities sink back beneath the ocean depths.", Translation.EncodeToUtf16("Водные существа возвращаются в глубины океана."));
            Translation.ILTranslate(il, "Leviathan", Translation.EncodeToUtf16("Левиафан"), 2);
            Translation.ILTranslate(il, "Use an [i:{0}] at Night in the Astral Biome", Translation.EncodeToUtf16("Используйте [i:{0}] ночью в астральном биоме."));
            Translation.ILTranslate(il, "Astrum Aureus’ program has been executed. Initiate recall.", Translation.EncodeToUtf16("Программа Аструм Ареуса выполнена. Запущен возврат."));
            Translation.ILTranslate(il, "Astrum Aureus", Translation.EncodeToUtf16("Аструм Ареус"));
            Translation.ILTranslate(il, "Use an [i:{0}] in the Jungle Biome", Translation.EncodeToUtf16("Используйте [i:{0}] в джунглях."));
            Translation.ILTranslate(il, "HOSTILE SPECIMENS TERMINATED. INITIATE RECALL TO HOME BASE.", Translation.EncodeToUtf16("ВРАЖДЕБНЫЕ СУЩНОСТИ УНИЧТОЖЕНЫ. ЗАПУЩЕН ВОЗВРАТ НА БАЗУ."));
            Translation.ILTranslate(il, "Plaguebringer Goliath", Translation.EncodeToUtf16("Разносчица чумы, Голиаф"));
            Translation.ILTranslate(il, "Use an [i:{0}]", Translation.EncodeToUtf16("Используйте [i:{0}]."), 2);
            Translation.ILTranslate(il, "The automaton of misshapen victims went looking for the true perpetrator.", Translation.EncodeToUtf16("Машина бесформенных жертв отправилась на поиски истинного нарушителя."));
            Translation.ILTranslate(il, "Ravager", Translation.EncodeToUtf16("Разрушитель"), 2);
            Translation.ILTranslate(il, "Use a [i:{0}] or [i:{1}] as offering at an [i:{2}]", Translation.EncodeToUtf16("Используйте [i:{0}] или [i:{1}] в качестве подношения на [i:{2}]."));
            Translation.ILTranslate(il, "The infected deity retreats to the heavens.", Translation.EncodeToUtf16("Заражённое божество отступает к небесам."));
            Translation.ILTranslate(il, "Astrum Deus", Translation.EncodeToUtf16("Аструм Деус"));
            Translation.ILTranslate(il, "Use a [i:{0}] in the Hallow or Underworld Biomes", Translation.EncodeToUtf16("Используйте [i:{0}] в святых землях или в аду."));
            Translation.ILTranslate(il, "The guardians must protect their goddess at all costs.", Translation.EncodeToUtf16("Стражи должны защищать свою богиню любой ценой."));
            Translation.ILTranslate(il, "Profaned Guardians", Translation.EncodeToUtf16("Осквернённые стражи"));
            Translation.ILTranslate(il, "Use [i:{0}] in the Jungle Biome", Translation.EncodeToUtf16("Используйте [i:{0}] в джунглях."));
            Translation.ILTranslate(il, "The failed experiment returns to its reproductive routine.", Translation.EncodeToUtf16("Неудачный эксперимент вернулся к своему репродуктивному распорядку."));
            Translation.ILTranslate(il, "Dragonfolly", Translation.EncodeToUtf16("Псевдодракон"), 2);
            Translation.ILTranslate(il, "Use either [i:{0}] or [i:{1}] in the Hallow or Underworld Biomes", Translation.EncodeToUtf16("Используйте либо [i:{0}], либо [i:{1}] в святых землях или аду."));
            Translation.ILTranslate(il, "The Profaned Goddess vanishes in a burning blaze.", Translation.EncodeToUtf16("Осквернённая богиня исчезает в горящем пламени."));
            Translation.ILTranslate(il, "Providence", Translation.EncodeToUtf16("Провиденс"), 2);
            Translation.ILTranslate(il, "Use a [i:{0}] in the Dungeon", Translation.EncodeToUtf16("Используйте [i:{0}] в темнице."));
            Translation.ILTranslate(il, "The rift in time and space has moved away from your reach.", Translation.EncodeToUtf16("Разлом во времени и пространстве удалился вдаль."));
            Translation.ILTranslate(il, "Ceaseless Void", Translation.EncodeToUtf16("Нескончаемая пустота"));
            Translation.ILTranslate(il, "Use a [i:{0}] in Space", Translation.EncodeToUtf16("Используйте [i:{0}] в космосе."));
            Translation.ILTranslate(il, "Storm Weaver hid itself once again within the stormfront.", Translation.EncodeToUtf16("Штормовой ткач снова спрятался в грозовом фронте."));
            Translation.ILTranslate(il, "Storm Weaver", Translation.EncodeToUtf16("Штормовой ткач"));
            Translation.ILTranslate(il, "Use a [i:{0}] in the Underworld", Translation.EncodeToUtf16("Используйте [i:{0}] в аду."));
            Translation.ILTranslate(il, "The Devourer's assassin has finished its easy task.", Translation.EncodeToUtf16("Убийца Пожирателя выполнил свою лёгкую задачу."));
            Translation.ILTranslate(il, "Signus", Translation.EncodeToUtf16("Сигнус"), 2);
            Translation.ILTranslate(il, "Kill 30 phantom spirits or use a [i:{0}] in the Dungeon", Translation.EncodeToUtf16("Убейте 30 фантомных духов или используйте [i:{0}] в темнице."));
            Translation.ILTranslate(il, "The volatile spirits disperse throughout the depths of the dungeon.", Translation.EncodeToUtf16("Нестабильные духи разбредаются по темнице."));
            Translation.ILTranslate(il, "Polterghast", Translation.EncodeToUtf16("Полтергаст"), 2);
            Translation.ILTranslate(il, "Defeat the Acid Rain event post-Polterghast or fish using a [i:{0}] in the Sulphurous Sea", Translation.EncodeToUtf16("Одолейте событие «Кислотный дождь» после победы над Полтергастом или выловите с помощью [i:{0}] в сернистом море"));
            Translation.ILTranslate(il, "The old duke disappears amidst the acidic downpour.", Translation.EncodeToUtf16("Старый герцог исчезает посреди кислотного ливня."));
            Translation.ILTranslate(il, "Old Duke", Translation.EncodeToUtf16("Старый герцог"));
            Translation.ILTranslate(il, "Use a [i:{0}]", Translation.EncodeToUtf16("Используйте [i:{0}]."));
            Translation.ILTranslate(il, "The Devourer of Gods has slain everyone and feasted on their essence.", Translation.EncodeToUtf16("Пожиратель богов убил всех и пировал их сущностью."));
            Translation.ILTranslate(il, "Devourer of Gods", Translation.EncodeToUtf16("Пожиратель богов"));
            Translation.ILTranslate(il, "Use a [i:{0}] in the Jungle Biome", Translation.EncodeToUtf16("Используйте [i:{0}] в джунглях."));
            Translation.ILTranslate(il, "Yharon found you too weak to stay near your gravestone.", Translation.EncodeToUtf16("Ярон считает вас слишком слабым, чтобы оставаться с вашим надгробием."));
            Translation.ILTranslate(il, "Yharon", Translation.EncodeToUtf16("Ярон"), 2);
            Translation.ILTranslate(il, "Use an [i:{0}]", Translation.EncodeToUtf16("Используйте [i:{0}]."), 3);
            Translation.ILTranslate(il, "Please don't waste my time.", Translation.EncodeToUtf16("Пожалуйста, не трать моё время."));
            Translation.ILTranslate(il, "Supreme Calamitas", Translation.EncodeToUtf16("Высшая Каламитас"));
        }
        
        private void TranslationCensusSupportHook(ILContext il)
        {
            Translation.ILTranslate(il, "Defeat a Giant Clam after defeating the Desert Scourge", Translation.EncodeToUtf16("Одолейте Гигантского моллюска после победы над Пустынным бичем"));
            Translation.ILTranslate(il, "Have a [i:", Translation.EncodeToUtf16("Имейте [i:"));
            Translation.ILTranslate(il, "] in your inventory after defeating Skeletron", Translation.EncodeToUtf16("] в вашем инвентаре после победы над Скелетроном"));
            Translation.ILTranslate(il, "Defeat Cryogen", Translation.EncodeToUtf16("Одолейте Криогена"));
            Translation.ILTranslate(il, "Have [i:", Translation.EncodeToUtf16("Имейте [i:"));
            Translation.ILTranslate(il, "] in your inventory in Hardmode", Translation.EncodeToUtf16("] в вашем инвентаре в Хардмоде"));
        }
        
        private void TranslationAddCalamityInvasionsHook(ILContext il)
        {
            Translation.ILTranslate(il, "Use a [i:{0}] or wait for the invasion to occur naturally after the Eye of Cthulhu is defeated.", Translation.EncodeToUtf16("Используйте [i:{0}] или дождитесь, пока событие произойдёт естественным образом после победы над Глазом Ктулху."));
            Translation.ILTranslate(il, "The mysterious creatures of the sulphuric sea descended back into the ocean.", Translation.EncodeToUtf16("Таинственные существа сернистого моря спустились обратно в океан."));
            Translation.ILTranslate(il, "Acid Rain", Translation.EncodeToUtf16("Кислотный дождь"));
            Translation.ILTranslate(il, "Use a [i:{0}] or [i:{1}] or wait for the invasion to occur naturally after the Aquatic Scourge is defeated", Translation.EncodeToUtf16("Используйте [i:{0}] или, [i:{1}] или дождитесь, пока событие произойдёт естественным образом после победы над Акватическим бичом."));
            Translation.ILTranslate(il, "The mysterious creatures of the sulphuric sea descended back into the deep ocean.", Translation.EncodeToUtf16("Таинственные существа сернистого моря спустились обратно в глубины океана."));
            Translation.ILTranslate(il, "Acid Rain (Post-AS)", Translation.EncodeToUtf16("Кислотный дождь (Пост-Аб)"));
            Translation.ILTranslate(il, "Use a [i:{0}] or [i:{1}] or wait for the invasion to occur naturally after the Polterghast is defeated", Translation.EncodeToUtf16("Используйте [i:{0}] или, [i:{1}] или дождитесь, пока событие произойдёт естественным образом после победы над Полтергастом."));
            Translation.ILTranslate(il, "Acid Rain (Post-Polter)", Translation.EncodeToUtf16("Кислотный дождь (Пост-Полтер)"));
            Translation.ILTranslate(il, "The mysterious creatures of the sulphuric sea descended back into the deep ocean.", Translation.EncodeToUtf16("Таинственные существа сернистого моря спустились обратно в глубины океана."), 2);
        }
    }
    
    public class FAPIL: ILEdit
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
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
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
    
        private void TranslationSetChatButtonsHook(ILContext il) => Translation.ILTranslate(il, "Death Count", Translation.EncodeToUtf16("Количество смертей"));
        
        private void TranslationGetChatHook(ILContext il) => Translation.ILTranslate(il, " was slapped too hard.", Translation.EncodeToUtf16(" получил слишком сильную пощечину."));
    }
    
    public class SEAHOEIL: ILEdit
    {
        
            
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.TownNPCs.SEAHOE").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.TownNPCs.SEAHOE").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;
    
        public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;
        
        private void TranslationSetChatButtonsHook(ILContext il) => Translation.ILTranslate(il, "Help", Translation.EncodeToUtf16("Помощь"));
    }
    
    public class THIEFIL: ILEdit
    {
        
            
        private event ILContext.Manipulator SetChatButtonsHook
        {
            add => HookEndpointManager.Modify(typeof(THIEF).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(THIEF).GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => SetChatButtonsHook += TranslationSetChatButtonsHook;
    
        public override void Unload() => SetChatButtonsHook -= TranslationSetChatButtonsHook;
        
        private void TranslationSetChatButtonsHook(ILContext il) => Translation.ILTranslate(il, "Refund", Translation.EncodeToUtf16("Возврат"));
    }
    
    public class LabHologramProjectorUIIL: ILEdit
    {
        
            
        private event ILContext.Manipulator LabHologramProjectorUIHook
        {
            add => HookEndpointManager.Modify(typeof(LabHologramProjectorUI).GetMethod("ChooseDialogue", BindingFlags.Public | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(typeof(LabHologramProjectorUI).GetMethod("ChooseDialogue", BindingFlags.Public | BindingFlags.Static), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => LabHologramProjectorUIHook += TranslationLabHologramProjectorUIHook;
    
        public override void Unload() => LabHologramProjectorUIHook -= TranslationLabHologramProjectorUIHook;
        
        private void TranslationLabHologramProjectorUIHook(ILContext il)
        {
            Translation.ILTranslate(il, "To any personnel engaged in the laboratories. Please wear your steel engraved ID badge at all times. It is the easiest method to discern your body if any accidents do occur.", Translation.EncodeToUtf16("Напоминаем всему персоналу. Пожалуйста, носите ваш персональный стальной идентификационный значок. Это самый простой способ опознать тело в случае несчастного случая."));
            Translation.ILTranslate(il, "To experiment is to fail. To fail is to learn. To learn is to advance.", Translation.EncodeToUtf16("Экспериментировать — значит терпеть неудачи. Терпеть неудачи — значит учиться. Учиться — значит становиться лучше."));
            Translation.ILTranslate(il, "Apparent danger while researching serves only to enhance the research experience.", Translation.EncodeToUtf16("Кажущаяся опасность во время исследований только усиливает исследовательский опыт."));
            Translation.ILTranslate(il, "Laser-type weapon prototypes are incredibly lethal and are not to be used within presentation halls.", Translation.EncodeToUtf16("Прототипы лазерного оружия невероятно смертоносны и не должны использоваться в презентационных залах."));
            Translation.ILTranslate(il, "High-energy plasma emissions have adverse effects on both flesh and metal. Do not attempt to handle vented plasma.", Translation.EncodeToUtf16("Высокоэнергетические плазменные выбросы оказывают неблагоприятное воздействие как на плоть, так и на металл. Не пытайтесь обращаться с изливающейся плазмой."));
            Translation.ILTranslate(il, "Electric shocks from military equipment are intended to be fatal. If you survive such a shock, that is a clear indicator that the device is not functioning properly. Please report any such cases.", Translation.EncodeToUtf16("Удары электрического тока, вызванные оружием, должны быть летальными. Если вы пережили удар током, это явный признак того, что устройство не функционирует должным образом. Пожалуйста, сообщите о любых таких случаях."));
            Translation.ILTranslate(il, "All employees are hereby notified that they will be held accountable for any collateral damage caused by Gauss weapon fire, even during sanctioned testing exercises.", Translation.EncodeToUtf16("Все сотрудники уведомляются, что они будут нести ответственность за любой сопутствующий ущерб, причинённый огнём гауссовского оружия, даже во время санкционированных испытательных учений."));
            Translation.ILTranslate(il, "Security Field Emitters will vaporize all unauthorized equipment and personnel. Please leave personal effects in the designated lockers off-site. This also means: Do not bring any family members who are not enlisted as personnel.", Translation.EncodeToUtf16("Излучатели защитного поля уничтожат всё несанкционированное оборудование и персонал. Пожалуйста, оставьте личные вещи в специально отведённых запирающихся шкафчиках за пределами поля. Это также означает: Не приводите с собой членов семьи, которые не зачислены в личный состав."));
            Translation.ILTranslate(il, "If one does manage to breach restricted testing facilities, do at least record any unexpected burns, lacerations, bruising, fractur... ...trauma, shocks and otherwise. Thank you.", Translation.EncodeToUtf16("Если кто-то всё же решит пробраться в закрытые испытательные помещения, то хотя бы сделайте запись неожиданных ожогов, рваных ран, кровоизлияний, переломов... травм, шоковых ожогов и др. Спасибо."));
            Translation.ILTranslate(il, "The power grid has been... ...eavily compromised. Abort research and proceed to the emergency exits located at... ...and egress with haste.", Translation.EncodeToUtf16("Энергосистема была... ...кована, серьёзные повреждения. Прервите исследования и пройдите к аварийным выходам, расположенным... ...и выходите с поспешностью."));
            Translation.ILTranslate(il, "Notify the Security Department of any aggressive local fauna immediately.", Translation.EncodeToUtf16("Немедленно сообщите в Службу безопасности о любой местной агрессивной фауне."));
            Translation.ILTranslate(il, "Sensors have detected a significant breach in the spacetime continuum.", Translation.EncodeToUtf16("Сенсоры обнаружили значительное нарушение пространственно-временного континуума."));
            Translation.ILTranslate(il, "Please help. I'm stuck in this hologram machine.", Translation.EncodeToUtf16("Пожалуйста, помогите. Я застрял в голограмме."));
        }
    }
    
    public class AstralInjectionIL: ILEdit
    {
        
            
        private event ILContext.Manipulator AstralInjectionHook
        {
            add => HookEndpointManager.Modify(typeof(AstralInjection).GetMethod("OnConsumeItem", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(AstralInjection).GetMethod("OnConsumeItem", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => AstralInjectionHook += TranslationAstralInjectionHook;
    
        public override void Unload() => AstralInjectionHook -= TranslationAstralInjectionHook;
        
        private void TranslationAstralInjectionHook(ILContext il) => Translation.ILTranslate(il, "'s blood vessels burst from drug overdose.", Translation.EncodeToUtf16(" кровеносные сосуды лопаются от передозировки наркотиков."));
    }
    
    public class ThornBlossomIL: ILEdit
    {
        
            
        private event ILContext.Manipulator ThornBlossomHook
        {
            add => HookEndpointManager.Modify(typeof(ThornBlossom).GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(ThornBlossom).GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => ThornBlossomHook += TranslationThornBlossomHook;
    
        public override void Unload() => ThornBlossomHook -= TranslationThornBlossomHook;
        
        private void TranslationThornBlossomHook(ILContext il) => Translation.ILTranslate(il, " was violently pricked by a flower.", Translation.EncodeToUtf16(" был яростно уколот цветком."));
    }
    
    public class LucreciaIL: ILEdit
    {
        
            
        private event ILContext.Manipulator LucreciaHook
        {
            add => HookEndpointManager.Modify(typeof(Lucrecia).GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(Lucrecia).GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => LucreciaHook += TranslationLucreciaHook;
    
        public override void Unload() => LucreciaHook -= TranslationLucreciaHook;
        
        private void TranslationLucreciaHook(ILContext il) => Translation.ILTranslate(il, "'s DNA was destroyed.", Translation.EncodeToUtf16(" ДНК была уничтожена."));
    }
    
    public class BloodBoilerIL: ILEdit
    {
        
            
        private event ILContext.Manipulator BloodBoilerHook
        {
            add => HookEndpointManager.Modify(typeof(BloodBoiler).GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(BloodBoiler).GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => BloodBoilerHook += TranslationBloodBoilerHook;
    
        public override void Unload() => BloodBoilerHook -= TranslationBloodBoilerHook;
        
        private void TranslationBloodBoilerHook(ILContext il)
        {
            Translation.ILTranslate(il, " suffered from severe anemia.", Translation.EncodeToUtf16(" страдал тяжёлой анемией."));
            Translation.ILTranslate(il, " was unable to obtain a blood transfusion.", Translation.EncodeToUtf16(" не удалось добиться переливания крови."));
        }
    }
    
    public class MolecularManipulatorIL: ILEdit
    {
        
            
        private event ILContext.Manipulator MolecularManipulatorHook
        {
            add => HookEndpointManager.Modify(typeof(MolecularManipulator).GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(MolecularManipulator).GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => MolecularManipulatorHook += TranslationMolecularManipulatorHook;
    
        public override void Unload() => MolecularManipulatorHook -= TranslationMolecularManipulatorHook;
        
        private void TranslationMolecularManipulatorHook(ILContext il)
        {
            Translation.ILTranslate(il, " was vaporized by the imbuement of his life.", Translation.EncodeToUtf16(" испарился из-за насыщенности своей жизни."));
            Translation.ILTranslate(il, " was vaporized by the imbuement of her life.", Translation.EncodeToUtf16(" испарилась из-за насыщенности своей жизни."));
        }
    }
    
    public class NullificationRifleIL: ILEdit
    {
        
            
        private event ILContext.Manipulator NullificationRifleHook
        {
            add => HookEndpointManager.Modify(typeof(NullificationRifle).GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(NullificationRifle).GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => NullificationRifleHook += TranslationNullificationRifleHook;
    
        public override void Unload() => NullificationRifleHook -= TranslationNullificationRifleHook;
        
        private void TranslationNullificationRifleHook(ILContext il)
        {
            Translation.ILTranslate(il, " was vaporized by the imbuement of his life.", Translation.EncodeToUtf16(" испарился из-за насыщенности своей жизни."));
            Translation.ILTranslate(il, " was vaporized by the imbuement of her life.", Translation.EncodeToUtf16(" испарилась из-за насыщенности своей жизни."));
        }
    }
    
    public class DevourerofGodsHeadIL: ILEdit
    {
        
            
        private event ILContext.Manipulator DevourerofGodsHeadHook
        {
            add => HookEndpointManager.Modify(typeof(DevourerofGodsHead).GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(DevourerofGodsHead).GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => DevourerofGodsHeadHook += TranslationDevourerofGodsHeadHook;
    
        public override void Unload() => DevourerofGodsHeadHook -= TranslationDevourerofGodsHeadHook;
        
        private void TranslationDevourerofGodsHeadHook(ILContext il) => Translation.ILTranslate(il, "'s essence was consumed by the devourer.", Translation.EncodeToUtf16(" сущность была поглощена пожирателем."));
    }
    
    public class DevourerofGodsHeadSIL: ILEdit
    {
        
            
        private event ILContext.Manipulator DevourerofGodsHeadSHook
        {
            add => HookEndpointManager.Modify(typeof(DevourerofGodsHeadS).GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(DevourerofGodsHeadS).GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => DevourerofGodsHeadSHook += TranslationDevourerofGodsHeadSHook;
    
        public override void Unload() => DevourerofGodsHeadSHook -= TranslationDevourerofGodsHeadSHook;
        
        private void TranslationDevourerofGodsHeadSHook(ILContext il) => Translation.ILTranslate(il, "'s essence was consumed by the devourer.", Translation.EncodeToUtf16(" сущность была поглощена пожирателем."));
    }
    
    public class FearlessGoldfishWarriorIL: ILEdit
    {
        
            
        private event ILContext.Manipulator FearlessGoldfishWarriorHook
        {
            add => HookEndpointManager.Modify(typeof(FearlessGoldfishWarrior).GetMethod("ModifyHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(FearlessGoldfishWarrior).GetMethod("ModifyHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => FearlessGoldfishWarriorHook += TranslationFearlessGoldfishWarriorHook;
    
        public override void Unload() => FearlessGoldfishWarriorHook -= TranslationFearlessGoldfishWarriorHook;
        
        private void TranslationFearlessGoldfishWarriorHook(ILContext il) => Translation.ILTranslate(il, " was once again impaled by Goldfish.", Translation.EncodeToUtf16(" был снова проткнут Золотой рыбкой."));
    }
    
    public class HealOrbProvIL: ILEdit
    {
        
            
        private event ILContext.Manipulator HealOrbProvHook
        {
            add => HookEndpointManager.Modify(typeof(HealOrbProv).GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(HealOrbProv).GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => HealOrbProvHook += TranslationHealOrbProvHook;
    
        public override void Unload() => HealOrbProvHook -= TranslationHealOrbProvHook;
        
        private void TranslationHealOrbProvHook(ILContext il) => Translation.ILTranslate(il, " burst into sinless ash.", Translation.EncodeToUtf16(" превратился в безгрешный пепел."));
    }
    
    public class HolyBurnOrbIL: ILEdit
    {
        
            
        private event ILContext.Manipulator HolyBurnOrbHook
        {
            add => HookEndpointManager.Modify(typeof(HolyBurnOrb).GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(HolyBurnOrb).GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => HolyBurnOrbHook += TranslationHolyBurnOrbHook;
    
        public override void Unload() => HolyBurnOrbHook -= TranslationHolyBurnOrbHook;
        
        private void TranslationHolyBurnOrbHook(ILContext il) => Translation.ILTranslate(il, " burst into sinless ash.", Translation.EncodeToUtf16(" превратился в безгрешный пепел."));
    }
    
    public class ChibiiDoggoIL: ILEdit
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
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
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
    
        private void TranslationAIHook(ILContext il) => Translation.ILTranslate(il, " couldn't stand the sharp objects.", Translation.EncodeToUtf16(" не выдерживал острых предметов."));
        
        private void TranslationSpawnDoggoHook(ILContext il)
        {
            Translation.ILTranslate(il, "It's not over yet, kid!", Translation.EncodeToUtf16("Это ещё не конец, малыш!"));
            Translation.ILTranslate(il, "Don't get cocky, kid!", Translation.EncodeToUtf16("Не будь таким самоуверенным, малыш!"));
        }
    }
    
    public class CalamityUtilsIL: ILEdit
    {
        
            
        private event ILContext.Manipulator CalamityUtilsHook
        {
            add => HookEndpointManager.Modify(typeof(CalamityUtils).GetMethod("BedRightClick", BindingFlags.Public | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(typeof(CalamityUtils).GetMethod("BedRightClick", BindingFlags.Public | BindingFlags.Static), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => CalamityUtilsHook += TranslationCalamityUtilsHook;
    
        public override void Unload() => CalamityUtilsHook -= TranslationCalamityUtilsHook;
        
        private void TranslationCalamityUtilsHook(ILContext il)
        {
            Translation.ILTranslate(il, "Spawn point removed!", Translation.EncodeToUtf16("Точка воскрешения удалена!"));
            Translation.ILTranslate(il, "Spawn point set!", Translation.EncodeToUtf16("Точка воскрешения задана!"));
        }
    }
    
    public class PlaguedPlateBedIL: ILEdit
    {
        
            
        private event ILContext.Manipulator PlaguedPlateBedHook
        {
            add => HookEndpointManager.Modify(typeof(PlaguedPlateBed).GetMethod("NewRightClick", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(PlaguedPlateBed).GetMethod("NewRightClick", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => PlaguedPlateBedHook += TranslationPlaguedPlateBedHook;
    
        public override void Unload() => PlaguedPlateBedHook -= TranslationPlaguedPlateBedHook;
        
        private void TranslationPlaguedPlateBedHook(ILContext il)
        {
            Translation.ILTranslate(il, "Spawn point removed!", Translation.EncodeToUtf16("Точка воскрешения удалена!"));
            Translation.ILTranslate(il, "Spawn point set!", Translation.EncodeToUtf16("Точка воскрешения задана!"));
        }
    }
    
    public class RavagerBodyIL: ILEdit
    {
        
            
        private event ILContext.Manipulator RavagerBodyHook
        {
            add => HookEndpointManager.Modify(typeof(RavagerBody).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(RavagerBody).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => RavagerBodyHook += TranslationRavagerBodyHook;
    
        public override void Unload() => RavagerBodyHook -= TranslationRavagerBodyHook;
        
        private void TranslationRavagerBodyHook(ILContext il) => Translation.ILTranslate(il, "Ravager", Translation.EncodeToUtf16("Разрушитель"));
    }
    
    public class CalamitasRun3IL: ILEdit
    {
        
            
        private event ILContext.Manipulator CalamitasRun3Hook
        {
            add => HookEndpointManager.Modify(typeof(CalamitasRun3).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(CalamitasRun3).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => CalamitasRun3Hook += TranslationCalamitasRun3Hook;
    
        public override void Unload() => CalamitasRun3Hook -= TranslationCalamitasRun3Hook;
        
        private void TranslationCalamitasRun3Hook(ILContext il) => Translation.ILTranslate(il, "The Calamitas Clone", Translation.EncodeToUtf16("Клон Каламитас"));
    }
    
    public class BossHPUIIL: ILEdit
    {
        
            
        private event ILContext.Manipulator DrawHook
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.BossHealthBarManager+BossHPUI").GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.BossHealthBarManager+BossHPUI").GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        private event ILContext.Manipulator DrawOpenAnimHook
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.BossHealthBarManager+BossHPUI").GetMethod("DrawOpenAnim", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.BossHealthBarManager+BossHPUI").GetMethod("DrawOpenAnim", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load()
        {
            DrawHook += TranslationDrawHook;
            DrawOpenAnimHook += TranslationDrawOpenAnimHook;
        }
    
        public override void Unload()
        {
            DrawHook -= TranslationDrawHook;
            DrawOpenAnimHook -= TranslationDrawOpenAnimHook;
        }
    
        private void TranslationDrawHook(ILContext il)
        {
            Translation.ILTranslate(il, "(Segments left: ", Translation.EncodeToUtf16("(Осталось сегментов: "));
            Translation.ILTranslate(il, "(Creepers left: ", Translation.EncodeToUtf16("(Осталось ползунов: "));
            Translation.ILTranslate(il, "(Hands left: ", Translation.EncodeToUtf16("(Осталось рук: "));
            Translation.ILTranslate(il, "(Arms left: ", Translation.EncodeToUtf16("(Осталось оружий: "));
            Translation.ILTranslate(il, "(Guns left: ", Translation.EncodeToUtf16("(Осталось ружей: "));
            Translation.ILTranslate(il, "(Cannons left: ", Translation.EncodeToUtf16("(Осталось пушек: "));
            Translation.ILTranslate(il, "(Dark Energy left: ", Translation.EncodeToUtf16("(Осталось тёмной энергии: "));
            Translation.ILTranslate(il, "(Body Parts left: ", Translation.EncodeToUtf16("(Осталось частей тела: "));
            Translation.ILTranslate(il, "(Large Slimes left: ", Translation.EncodeToUtf16("(Осталось больших слизней: "));
        }
        
        private void TranslationDrawOpenAnimHook(ILContext il)
        {
            Translation.ILTranslate(il, "(Segments left: ", Translation.EncodeToUtf16("(Осталось сегментов: "));
            Translation.ILTranslate(il, "(Creepers left: ", Translation.EncodeToUtf16("(Осталось ползунов: "));
            Translation.ILTranslate(il, "(Hands left: ", Translation.EncodeToUtf16("(Осталось рук: "));
            Translation.ILTranslate(il, "(Arms left: ", Translation.EncodeToUtf16("(Осталось оружий: "));
            Translation.ILTranslate(il, "(Guns left: ", Translation.EncodeToUtf16("(Осталось ружей: "));
            Translation.ILTranslate(il, "(Cannons left: ", Translation.EncodeToUtf16("(Осталось пушек: "));
            Translation.ILTranslate(il, "(Dark Energy left: ", Translation.EncodeToUtf16("(Осталось тёмной энергии: "));
            Translation.ILTranslate(il, "(Body Parts left: ", Translation.EncodeToUtf16("(Осталось частей тела: "));
            Translation.ILTranslate(il, "(Large Slimes left: ", Translation.EncodeToUtf16("(Осталось больших слизней: "));
        }
    }
    
    public class ProfanedGuardianBoss2IL: ILEdit
    {
        
            
        private event ILContext.Manipulator ProfanedGuardianBoss2Hook
        {
            add => HookEndpointManager.Modify(typeof(ProfanedGuardianBoss2).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(ProfanedGuardianBoss2).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => ProfanedGuardianBoss2Hook += TranslationProfanedGuardianBoss2Hook;
    
        public override void Unload() => ProfanedGuardianBoss2Hook -= TranslationProfanedGuardianBoss2Hook;
        
        private void TranslationProfanedGuardianBoss2Hook(ILContext il) => Translation.ILTranslate(il, "A Profaned Guardian", Translation.EncodeToUtf16("Осквернённый страж"));
    }
    
    public class PerforatorHeadLargeIL: ILEdit
    {
        
            
        private event ILContext.Manipulator PerforatorHeadLargeHook
        {
            add => HookEndpointManager.Modify(typeof(PerforatorHeadLarge).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(PerforatorHeadLarge).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => PerforatorHeadLargeHook += TranslationPerforatorHeadLargeHook;
    
        public override void Unload() => PerforatorHeadLargeHook -= TranslationPerforatorHeadLargeHook;
        
        private void TranslationPerforatorHeadLargeHook(ILContext il) => Translation.ILTranslate(il, "The Large Perforator", Translation.EncodeToUtf16("Перфоратор"));
    }
    
    public class PerforatorHeadSmallIL: ILEdit
    {
        
            
        private event ILContext.Manipulator PerforatorHeadSmallHook
        {
            add => HookEndpointManager.Modify(typeof(PerforatorHeadSmall).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(PerforatorHeadSmall).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => PerforatorHeadSmallHook += TranslationPerforatorHeadSmallHook;
    
        public override void Unload() => PerforatorHeadSmallHook -= TranslationPerforatorHeadSmallHook;
        
        private void TranslationPerforatorHeadSmallHook(ILContext il) => Translation.ILTranslate(il, "The Small Perforator", Translation.EncodeToUtf16("Перфоратор"));
    }
    
    public class BumblefuckIL: ILEdit
    {
        
            
        private event ILContext.Manipulator BumblefuckHook
        {
            add => HookEndpointManager.Modify(typeof(Bumblefuck).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(Bumblefuck).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => BumblefuckHook += TranslationBumblefuckHook;
    
        public override void Unload() => BumblefuckHook -= TranslationBumblefuckHook;
        
        private void TranslationBumblefuckHook(ILContext il) => Translation.ILTranslate(il, "A Dragonfolly", Translation.EncodeToUtf16("Псевдодракон"));
    }
    
    public class PerforatorHeadMediumIL: ILEdit
    {
        
            
        private event ILContext.Manipulator PerforatorHeadMediumHook
        {
            add => HookEndpointManager.Modify(typeof(PerforatorHeadMedium).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(PerforatorHeadMedium).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => PerforatorHeadMediumHook += TranslationPerforatorHeadMediumHook;
    
        public override void Unload() => PerforatorHeadMediumHook -= TranslationPerforatorHeadMediumHook;
        
        private void TranslationPerforatorHeadMediumHook(ILContext il) => Translation.ILTranslate(il, "The Medium Perforator", Translation.EncodeToUtf16("Перфоратор"));
    }
    
    public class ProfanedGuardianBoss3IL: ILEdit
    {
        
            
        private event ILContext.Manipulator ProfanedGuardianBoss3Hook
        {
            add => HookEndpointManager.Modify(typeof(ProfanedGuardianBoss3).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(ProfanedGuardianBoss3).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => ProfanedGuardianBoss3Hook += TranslationProfanedGuardianBoss3Hook;
    
        public override void Unload() => ProfanedGuardianBoss3Hook -= TranslationProfanedGuardianBoss3Hook;
        
        private void TranslationProfanedGuardianBoss3Hook(ILContext il) => Translation.ILTranslate(il, "A Profaned Guardian", Translation.EncodeToUtf16("Осквернённый страж"));
    }
    
    public class ProfanedGuardianBossIL: ILEdit
    {
        
            
        private event ILContext.Manipulator ProfanedGuardianBossHook
        {
            add => HookEndpointManager.Modify(typeof(ProfanedGuardianBoss).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(ProfanedGuardianBoss).GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => ProfanedGuardianBossHook += TranslationProfanedGuardianBossHook;
    
        public override void Unload() => ProfanedGuardianBossHook -= TranslationProfanedGuardianBossHook;
        
        private void TranslationProfanedGuardianBossHook(ILContext il) => Translation.ILTranslate(il, "A Profaned Guardian", Translation.EncodeToUtf16("Осквернённый страж"));
    }
    
    public class BossRushUIIL: ILEdit
    {
        
            
        private event ILContext.Manipulator BossRushUIHook
        {
            add => HookEndpointManager.Modify(typeof(BossRushUI).GetMethod("get_InvasionName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(BossRushUI).GetMethod("get_InvasionName", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => BossRushUIHook += TranslationBossRushUIHook;
    
        public override void Unload() => BossRushUIHook -= TranslationBossRushUIHook;
        
        private void TranslationBossRushUIHook(ILContext il) => Translation.ILTranslate(il, "Boss Rush", Translation.EncodeToUtf16("Босс-Раш"));
    }
    
    public class ColdDivinityIL: ILEdit
    {
        
            
        private event ILContext.Manipulator ColdDivinityHook
        {
            add => HookEndpointManager.Modify(typeof(ColdDivinity).GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(ColdDivinity).GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => ColdDivinityHook += TranslationColdDivinityHook;
    
        public override void Unload() => ColdDivinityHook -= TranslationColdDivinityHook;
        
        private void TranslationColdDivinityHook(ILContext il) => Translation.ILTranslate(il, "Tooltip7", "Tooltip6");
    }
    
    public class FurnitureOccultIL: ILEdit
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
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
    
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
    
        private void TranslationOccultBathtubHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Bathtub", Translation.EncodeToUtf16("Потусторонняя ванна"));
        
        private void TranslationOccultBedHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Bed", Translation.EncodeToUtf16("Потусторонняя кровать"));
        
        private void TranslationOccultBookcaseHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Bookcase", Translation.EncodeToUtf16("Потусторонний книжный шкаф"));
        
        private void TranslationOccultCandelabraHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Candelabra", Translation.EncodeToUtf16("Потусторонний канделябр"));
        
        private void TranslationOccultCandleHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Candle", Translation.EncodeToUtf16("Потусторонняя свеча"));
        
        private void TranslationOccultChairHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Chair", Translation.EncodeToUtf16("Потусторонний стул"));
        
        private void TranslationOccultChandelierHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Chandelier", Translation.EncodeToUtf16("Потусторонняя люстра"));
        
        private void TranslationOccultChestHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Chest", Translation.EncodeToUtf16("Потусторонний сундук"));
        
        private void TranslationOccultClockHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Clock", Translation.EncodeToUtf16("Потусторонние часы"));
        
        private void TranslationOccultDoorHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Door", Translation.EncodeToUtf16("Потусторонняя дверь"));
        
        private void TranslationOccultDresserHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Dresser", Translation.EncodeToUtf16("Потусторонний комод"));
        
        private void TranslationOccultLampHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Lamp", Translation.EncodeToUtf16("Потусторонняя лампа"));
        
        private void TranslationOccultLanternHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Lantern", Translation.EncodeToUtf16("Потусторонний фонарь"));
        
        private void TranslationOccultPianoHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Piano", Translation.EncodeToUtf16("Потустороннее пианино"));
        
        private void TranslationOccultPlatformHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Platform", Translation.EncodeToUtf16("Потусторонняя платформа"));
        
        private void TranslationOccultSinkHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Sink", Translation.EncodeToUtf16("Потусторонняя раковина"));
        
        private void TranslationOccultSofaHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Sofa", Translation.EncodeToUtf16("Потусторонний диван"));
        
        private void TranslationOccultStoneHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Stone", Translation.EncodeToUtf16("Потусторонний камень"));
        
        private void TranslationOccultTableHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Table", Translation.EncodeToUtf16("Потусторонний стол"));
        
        private void TranslationOccultWorkBenchHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Work Bench", Translation.EncodeToUtf16("Потусторонний верстак"));
        
        private void TranslationOccultStoneWallHook(ILContext il) => Translation.ILTranslate(il, "Otherworldly Stone Wall", Translation.EncodeToUtf16("Стена из потустороннего камня"));
    }
    
    public class StratusWorkbenchIL: ILEdit
    {
        
            
        private event ILContext.Manipulator StratusWorkbenchHook
        {
            add => HookEndpointManager.Modify(typeof(StratusWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(StratusWorkbench).GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
        public override void Load() => StratusWorkbenchHook += TranslationStratusWorkbenchHook;
    
        public override void Unload() => StratusWorkbenchHook -= TranslationStratusWorkbenchHook;
        
        private void TranslationStratusWorkbenchHook(ILContext il) => Translation.ILTranslate(il, "Stratus Work Bench", Translation.EncodeToUtf16("Слоистый верстак"));
    }
    
    public class FurnitureStatigelIL: ILEdit
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
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
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
    
        private void TranslationStatigelWorkbenchHook(ILContext il) => Translation.ILTranslate(il, "Statigel Work Bench", Translation.EncodeToUtf16("Статиджеловый верстак"));
        
        private void TranslationStatigelBathHook(ILContext il) => Translation.ILTranslate(il, "Statigel Bathtub", Translation.EncodeToUtf16("Статиджеловая ванна"));
    }
    
    public class FurnitureProfanedIL: ILEdit
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
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
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
    
        private void TranslationProfanedWorkbenchHook(ILContext il) => Translation.ILTranslate(il, "Profaned Work Bench", Translation.EncodeToUtf16("Осквернённый верстак"));
        
        private void TranslationProfanedBathHook(ILContext il) => Translation.ILTranslate(il, "Profaned Bathtub", Translation.EncodeToUtf16("Осквернённая ванна"));
    }
    
    public class FurnitureVoidIL: ILEdit
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
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
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
    
        private void TranslationVoidWorkbenchHook(ILContext il) => Translation.ILTranslate(il, "Void Work Bench", Translation.EncodeToUtf16("Пустотный верстак"));
        
        private void TranslationVoidClockHook(ILContext il) => Translation.ILTranslate(il, "Void Obelisk", Translation.EncodeToUtf16("Пустотный обелиск"));
        
        private void TranslationVoidBathHook(ILContext il) => Translation.ILTranslate(il, "Void Bathtub", Translation.EncodeToUtf16("Пустотная ванна"));
    }
    
    public class FurnitureCosmiliteIL: ILEdit
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
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
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
    
        private void TranslationCosmiliteWorkbenchHook(ILContext il) => Translation.ILTranslate(il, "Cosmilite Work Bench", Translation.EncodeToUtf16("Космилитовый верстак"));
        
        private void TranslationCosmiliteBathHook(ILContext il) => Translation.ILTranslate(il, "Cosmilite Bathtub", Translation.EncodeToUtf16("Космилитовая ванна"));
    }
    
    public class FurnitureAshenIL: ILEdit
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
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
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
    
        private void TranslationAshenPianoHook(ILContext il) => Translation.ILTranslate(il, "Ashen Pipe Organ", Translation.EncodeToUtf16("Пепельный трубный орган"));
        
        private void TranslationAshenWorkbenchHook(ILContext il) => Translation.ILTranslate(il, "Ashen Work Bench", Translation.EncodeToUtf16("Пепельный верстак"));
        
        private void TranslationAshenBathHook(ILContext il) => Translation.ILTranslate(il, "Ashen Bathtub", Translation.EncodeToUtf16("Пепельная ванна"));
    }
    
    public class CraftingStationsIL: ILEdit
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
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
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
    
        private void TranslationEutrophicCraftingHook(ILContext il) => Translation.ILTranslate(il, "Eutrophic Shelf", Translation.EncodeToUtf16("Эвтрофная полка"));
        
        private void TranslationMonolithCraftingHook(ILContext il) => Translation.ILTranslate(il, "Monolith Amalgam", Translation.EncodeToUtf16("Монолитное слияние"));
        
        private void TranslationProfanedBasinHook(ILContext il) => Translation.ILTranslate(il, "Profaned Crucible", Translation.EncodeToUtf16("Осквернённый тигель"));
        
        private void TranslationSilvaBasinHook(ILContext il) => Translation.ILTranslate(il, "Effulgent Manipulator", Translation.EncodeToUtf16("Лучезарный манипулятор"));
    }
    
    public class FurnitureAbyssIL: ILEdit
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
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
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
    
        private void TranslationAbyssBathHook(ILContext il) => Translation.ILTranslate(il, "Abyss Bathtub", Translation.EncodeToUtf16("Ванна бездны"));
        
        private void TranslationAbyssWorkbenchHook(ILContext il) => Translation.ILTranslate(il, "Abyss Work Bench", Translation.EncodeToUtf16("Верстак бездны"));
        
        private void TranslationAbyssPianoHook(ILContext il) => Translation.ILTranslate(il, "Abyss Synth", Translation.EncodeToUtf16("Синтезатор бездны"));
    }
    
    public class FurnitureAncientIL: ILEdit
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
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
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
    
        private void TranslationAncientBathHook(ILContext il) => Translation.ILTranslate(il, "Ancient Bathtub", Translation.EncodeToUtf16("Древняя ванна"));
        
        private void TranslationAncientWorkbenchHook(ILContext il) => Translation.ILTranslate(il, "Ancient Work Bench", Translation.EncodeToUtf16("Древний верстак"));
        
        private void TranslationAncientPianoHook(ILContext il) => Translation.ILTranslate(il, "Ancient Pipe Organ", Translation.EncodeToUtf16("Древний трубный орган"));
    }
    
    public class FurnitureAstralIL: ILEdit
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
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
        
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
    
        private void TranslationMonolithBathtubHook(ILContext il) => Translation.ILTranslate(il, "Monolith Bathtub", Translation.EncodeToUtf16("Монолитная ванна"));
        
        private void TranslationMonolithBedHook(ILContext il) => Translation.ILTranslate(il, "Monolith Bed", Translation.EncodeToUtf16("Монолитная кровать"));
        
        private void TranslationMonolithBenchHook(ILContext il) => Translation.ILTranslate(il, "Monolith Bench", Translation.EncodeToUtf16("Монолитная скамья"));
        
        private void TranslationMonolithBookcaseHook(ILContext il) => Translation.ILTranslate(il, "Monolith Bookcase", Translation.EncodeToUtf16("Монолитный книжный шкаф"));
        
        private void TranslationMonolithCandelabraHook(ILContext il) => Translation.ILTranslate(il, "Monolith Candelabra", Translation.EncodeToUtf16("Монолитный канделябр"));
        
        private void TranslationMonolithCandleHook(ILContext il) => Translation.ILTranslate(il, "Monolith Candle", Translation.EncodeToUtf16("Монолитная свеча"));
        
        private void TranslationMonolithChairHook(ILContext il) => Translation.ILTranslate(il, "Monolith Chair", Translation.EncodeToUtf16("Монолитный стул"));
        
        private void TranslationMonolithChandelierHook(ILContext il) => Translation.ILTranslate(il, "Monolith Chandelier", Translation.EncodeToUtf16("Монолитная люстра"));
        
        private void TranslationMonolithChestHook(ILContext il) => Translation.ILTranslate(il, "Monolith Chest", Translation.EncodeToUtf16("Монолитный сундук"));
        
        private void TranslationMonolithClockHook(ILContext il) => Translation.ILTranslate(il, "Monolith Clock", Translation.EncodeToUtf16("Монолитные часы"));
        
        private void TranslationMonolithDoorHook(ILContext il) => Translation.ILTranslate(il, "Monolith Door", Translation.EncodeToUtf16("Монолитная дверь"));
        
        private void TranslationMonolithDresserHook(ILContext il) => Translation.ILTranslate(il, "Monolith Dresser", Translation.EncodeToUtf16("Монолитный комод"));
        
        private void TranslationMonolithLampHook(ILContext il) => Translation.ILTranslate(il, "Monolith Lamp", Translation.EncodeToUtf16("Монолитная лампа"));
        
        private void TranslationMonolithPianoHook(ILContext il) => Translation.ILTranslate(il, "Monolith Piano", Translation.EncodeToUtf16("Монолитное пианино"));
        
        private void TranslationMonolithLanternHook(ILContext il) => Translation.ILTranslate(il, "Monolith Lantern", Translation.EncodeToUtf16("Монолитный фонарь"));
        
        private void TranslationMonolithPlatformHook(ILContext il) => Translation.ILTranslate(il, "Monolith Platform", Translation.EncodeToUtf16("Монолитная платформа"));
        
        private void TranslationMonolithSinkHook(ILContext il) => Translation.ILTranslate(il, "Monolith Sink", Translation.EncodeToUtf16("Монолитная раковина"));
        
        private void TranslationMonolithTableHook(ILContext il) => Translation.ILTranslate(il, "Monolith Table", Translation.EncodeToUtf16("Монолитный стол"));
        
        private void TranslationMonolithWorkBenchHook(ILContext il) => Translation.ILTranslate(il, "Monolith Work Bench", Translation.EncodeToUtf16("Монолитный верстак"));
    }
    
    public class NanotechIL: ILEdit
    {
        private event ILContext.Manipulator NanotechHook
        {
            add => HookEndpointManager.Modify(typeof(Nanotech).GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(Nanotech).GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance), value);
        }
    
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
    
        public override void Load() => NanotechHook += TranslationNanotechHook;
    
        public override void Unload() => NanotechHook -= TranslationNanotechHook;
    
        private void TranslationNanotechHook(ILContext il) => Translation.ILTranslate(il, "Tooltip8", Translation.EncodeToUtf16("Tooltip7"));
    }
        
    public class PolterghastIL: ILEdit
    {
        private event ILContext.Manipulator PolterghastHook
        {
            add => HookEndpointManager.Modify(typeof(Polterghast).GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(typeof(Polterghast).GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        }
    
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null && Translation.IsRussianLanguage;
    
        public override void Load() => PolterghastHook += TranslationPolterghastHook;
    
        public override void Unload() => PolterghastHook -= TranslationPolterghastHook;
    
        private void TranslationPolterghastHook(ILContext il)
        {
            Translation.ILTranslate(il, "Necroghast", Translation.EncodeToUtf16("Некрогаст"));
            Translation.ILTranslate(il, "Necroplasm", Translation.EncodeToUtf16("Некроплазм"));
        }
    }
}