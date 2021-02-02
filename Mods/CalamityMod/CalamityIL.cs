using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Utilities;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class ILHandleMouseInteraction : ILEdit
    {
        public override string DictKey => "CalamityMod.UI.RipperUI";

        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;

        public override void Load() => ModifyHandleMouseInteraction += TranslationHandleMouseInteraction;

        public override void Unload() => ModifyHandleMouseInteraction -= TranslationHandleMouseInteraction;
        
        private void TranslationHandleMouseInteraction(ILContext il)
        {
            Translation.ILTranslate(il, "Adrenaline: {0} / {1}", Translation.EncodeToUtf16("Адреналин: {0} / {1}"));
            Translation.ILTranslate(il, "Rage: {0} / {1}", Translation.EncodeToUtf16("Ярость: {0} / {1}"));
        }
        
        private event ILContext.Manipulator ModifyHandleMouseInteraction
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.RipperUI").GetMethod("HandleMouseInteraction", BindingFlags.Static | BindingFlags.NonPublic), value);
            
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.RipperUI").GetMethod("HandleMouseInteraction", BindingFlags.Static | BindingFlags.NonPublic), value);
        }
    }

    public class ILModifyDrawStealth : ILEdit
    {
        public override string DictKey => "CalamityMod.UI.StealthUI";
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyDrawStealth += TranslationModifyDrawStealth;

        public override void Unload() => ModifyDrawStealth -= TranslationModifyDrawStealth;
        
        private void TranslationModifyDrawStealth(ILContext il) => Translation.ILTranslate(il, "Stealth: ", Translation.EncodeToUtf16("Скрытность: "));
        
        private event ILContext.Manipulator ModifyDrawStealth
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.StealthUI").GetMethod("Draw", BindingFlags.Static | BindingFlags.Public), value);
            
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.StealthUI").GetMethod("Draw", BindingFlags.Static | BindingFlags.Public), value);
        }
    }
    
    public class ILModifyDrawAcidRain: ILEdit
    {
        public override string DictKey => "CalamityMod.UI.AcidRainUI";
        
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
    
        public override void Load() => ModifyDrawAcidRain += TranslatioModifyDrawAcidRain;

        public override void Unload() => ModifyDrawAcidRain -= TranslatioModifyDrawAcidRain;
        
        private void TranslatioModifyDrawAcidRain(ILContext il) => Translation.ILTranslate(il, "Acid Rain", Translation.EncodeToUtf16("Кислотный дождь"));
        
        private event ILContext.Manipulator ModifyDrawAcidRain
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.AcidRainUI").GetMethod("get_InvasionName", BindingFlags.Instance | BindingFlags.Public), value);
            
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.AcidRainUI").GetMethod("get_InvasionName", BindingFlags.Instance | BindingFlags.Public), value);
        }
    }
        
    public class ILModifyPreKill: ILEdit
    {
        public override string DictKey => "CalamityMod.CalPlayer.CalamityPlayer";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyPreKill += TranslationModifyPreKill;

        public override void Unload() => ModifyPreKill -= TranslationModifyPreKill;
    
        private void TranslationModifyPreKill(ILContext il)
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
    
        private event ILContext.Manipulator ModifyPreKill
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.CalPlayer.CalamityPlayer").GetMethod("PreKill", BindingFlags.Instance | BindingFlags.Public), value);
            
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.CalPlayer.CalamityPlayer").GetMethod("PreKill", BindingFlags.Instance | BindingFlags.Public), value);
        }
    }
        
    public class ILModifyKillPlayer: ILEdit2
    {
        public override string DictKey => "CalamityMod.CalPlayer.CalamityPlayer";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyKillPlayer += TranslationModifyKillPlayer;
    
        public override void Unload() => ModifyKillPlayer -= TranslationModifyKillPlayer;
        
        private void TranslationModifyKillPlayer(ILContext il)
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
        
        private event ILContext.Manipulator ModifyKillPlayer
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.CalPlayer.CalamityPlayer").GetMethod("KillPlayer", BindingFlags.Instance | BindingFlags.Public), value);
            
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.CalPlayer.CalamityPlayer").GetMethod("KillPlayer", BindingFlags.Instance | BindingFlags.Public), value);
        }
    }
        
    public class ILModifyUpdateAccessory: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Accessories.CheatTestThing";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyUpdateAccessory += TranslationModifyUpdateAccessory;
    
        public override void Unload() => ModifyUpdateAccessory -= TranslationModifyUpdateAccessory;
        
        private void TranslationModifyUpdateAccessory(ILContext il) => Translation.ILTranslate(il, " isn't worthy.", Translation.EncodeToUtf16(" не достоин."));
        
        private event ILContext.Manipulator ModifyUpdateAccessory
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Accessories.CheatTestThing").GetMethod("UpdateAccessory", BindingFlags.Instance | BindingFlags.Public), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Accessories.CheatTestThing").GetMethod("UpdateAccessory", BindingFlags.Instance | BindingFlags.Public), value);
        }
    }
        
    public class ILModifyGetTextByPageHellGui: ILEdit
    {
        public override string DictKey => "CalamityMod.UI.DraedonLogHellGUI";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyGetTextByPageHellGui += TranslationModifyGetTextByPageHellGui;
    
        public override void Unload() => ModifyGetTextByPageHellGui -= TranslationModifyGetTextByPageHellGui;
        
        private void TranslationModifyGetTextByPageHellGui(ILContext il)
        {
            Translation.ILTranslate(il, "The entire landscape is a constant source of geothermal energy, and heat for a forge. If it was not entirely uninhabitable save for demons and spirits, I would conduct much more of my research in the bowels of the earth. Where I have actively chosen not to settle however, is in the crags of the underworld. There, the magma is... uncooperative and far more corrosive than should be possible, as it is saturated with cursed, twisted souls, courtesy of that Witch.", Translation.EncodeToUtf16("Весь природный ландшафт — постоянный источник геотермальной энергии и тепла для кузни. Если бы он не был совсем необитаемым, за исключением демонов и духов, я бы проводил больше исследований в недрах земли. Где я точно ни поселился бы, так это в скалах ада. Магма там... 'несговорчива' и агрессивна, намного больше, чем это возможно. Всё из-за того, что она пропиталась проклятыми тёмными душами, любезно предоставленными этой Ведьмой."));
            Translation.ILTranslate(il, "A blade completely inundated with my surroundings during the time of its creation. It was tempered by the fires which are fueled by spirits, and formed in the magma I draw into my laboratories. Its cutting edge, unparalleled, though its reach is limited making general usage questionable. I would consider it my very first foray into work for the sake of craftsmanship and art. If I was born synthetically, any creation which leads one to question whether I was, is a creation I may be proud of. It shows that I can after all, be graced by a muse.", Translation.EncodeToUtf16("Меч, полностью окружённый моим вниманием во время создания. Он сформировался в магме, а закалён огнём душ. Его лезвие — непревзойдённое, хотя его дальность ограничена, что делает общее применение сомнительным. Я думаю, что это моя первая работа, сделанная во имя искусства и мастерства. Если я был рождён синтетически, то любое моё творение, вызывающие вопрос: «Был ли я создан?» — результат, которым можно гордиться. Это доказывает, что я всё же могу быть удостоенным музы."));
            Translation.ILTranslate(il, "What a terrible abomination and yet an enticing subject. Not unlike the fusion of spirits which haunts the dungeons, this entity is formed not of one, but a multitude of sinners. What holds different for it however, is that the limitations caused by the artificiality of the dungeon's existence do not apply to it. It is the laws of hell which brought them together into a single overlord of the underworld. And when an innocent life is sacrificed... Their hunger, which appears to be in tune with the afterlife, surges.", Translation.EncodeToUtf16("Какое ужасное существо, но всё же интересное с научной точки зрения. В отличие от сплава душ темницы, эта сущность была сформирована не из одного грешника, а из многих. Ещё одно отличие заключается в том, что ограничения, вызванные искусственным происхождением темницы, неприменимы к нему. Именно законы Ада свели их вместе в единого владыку подземного мира. И когда невинная жизнь приносится в жертву... Их голод, который, кажется, является частью загробной жизни, нарастает."));
        }
        
        private event ILContext.Manipulator ModifyGetTextByPageHellGui
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.DraedonLogHellGUI").GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.DraedonLogHellGUI").GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyGetTextByPageJungleGui: ILEdit
    {
        public override string DictKey => "CalamityMod.UI.DraedonLogJungleGUI";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyGetTextByPageJungleGui += TranslationModifyGetTextByPageJungleGui;
    
        public override void Unload() => ModifyGetTextByPageJungleGui -= TranslationModifyGetTextByPageJungleGui;
        
        private void TranslationModifyGetTextByPageJungleGui(ILContext il)
        {
            Translation.ILTranslate(il, "As I record this, it would not be a stretch to call the jungle the hub of this planet. All is centered around it, and none know not of it. It brings me no small amount of unease to see the uncomfortable, raw forms of the living beings who pass through on their journeys above. Fortunately these labs provide everything I need in my research and more. There is no need to ever visit the surface, save for summons on the Lord's orders.", Translation.EncodeToUtf16("Поскольку я записываю это, не будет ошибкой назвать джунгли центром этой планеты. Всё сосредоточено вокруг них, но мало кто знает об этом. Я испытываю немалое беспокойство, видя неудобные, грубые формы живых существ, которые живут в них наверху. К счастью, эти лаборатории обеспечивают всё, что мне нужно в моих исследованиях и не только. Нет никакой необходимости когда-либо посещать поверхность, за исключением вызова по приказу Лорда."));
            Translation.ILTranslate(il, "Mechanically augmented, the Queen Bee which I had prior experimented on was theoretically a perfect host for the plague virus. When the first sign of the technology bonding with the creature began however, the problems also showed immediately. The mind of the insect fought the control of the nanotechnology, nothing like the simpler creatures I had used as test subjects. It grew increasingly violent, and only once subdued did it receive simple orders. However, if we were to utilize it at all, there is no other way than to let it roam free entirely. I will consider this further.", Translation.EncodeToUtf16("Механически усиленная королева пчёл, над которой я ранее экспериментировал, теоретически была идеальным разносчиком чумы. Однако, когда технологии начали менять сущность пчелы, начались проблемы. Разум насекомого противостоял нанотехнологиям, такого раньше не происходило. Она выросла невероятно жестокой и почти не подчинялась приказам. Однако, если мы хотим использовать её, нет другого способа, кроме как позволить ей свободно разгуливать. Я продожлу изучать это дальше."));
            Translation.ILTranslate(il, "A virus, capable of devouring and converting almost anything. And nanotechnology, constructed painstakingly for the sake of control. Development was swift, and every piece fell into place almost eerily, forming an abhorrent existence. I struggle to think of practical applications which would be friendly to common life forms. However, it is not a major concern. Many were hesitant to continue its creation, but I granted them leave if they desired. I would have no need for any who were not entirely as dedicated as my machines.", Translation.EncodeToUtf16("Вирус, способный пожирать и превращать практически всё. И тщательно сделанная нанотехнология контроля. Превращение шло пугающе быстро, создавая мерзкую тварь. Я стараюсь сделать так, чтобы она была дружелюбна к обычным формам жизни. Однако это не главная проблема. Многие не решались продолжать создание, но я разрешил уйти, если они пожелают. Я не нуждался ни в ком, кто не был бы так же предан делу, как мои машины."));
        }
        
        private event ILContext.Manipulator ModifyGetTextByPageJungleGui
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.DraedonLogJungleGUI").GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.DraedonLogJungleGUI").GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyGetTextByPagePlanetoidGui: ILEdit
    {
        public override string DictKey => "CalamityMod.UI.DraedonLogPlanetoidGUI";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyGetTextByPagePlanetoidGui += TranslationModifyGetTextByPagePlanetoidGui;
    
        public override void Unload() => ModifyGetTextByPagePlanetoidGui -= TranslationModifyGetTextByPagePlanetoidGui;
        
        private void TranslationModifyGetTextByPagePlanetoidGui(ILContext il)
        {
            Translation.ILTranslate(il, "Hung low in orbit, masses of ground and various parts of the world provide a secluded and distant point for research. Undeniably optimal for the science of astronomy and otherwise. In my labs here I grow many things, testing their limits against the cold and vacuum of the stratosphere. Though not many survive, the existence of certain creatures here, confirm the capabilities of life simply given more time.", Translation.EncodeToUtf16("Висящие низко на орбите массы земли и другие структуры мира, обеспечивают укромное и отдалённое место для исследований. Это оптимальный вариант для изучения астрономии и других наук. В моих лабораториях я выращиваю разные растения и тестирую их способность к выживанию в условиях холода и вакуума стратосферы. Несмотря на то, что многие растения погибают, существование жизни здесь подтверждается. Просто нужно дать этой жизни больше времени на развитие."));
            Translation.ILTranslate(il, "The bloated cosmic worm, though I understand why the Lord decides to employ it given he can control it, is a disgusting existence. However the idea of creating an armor suited to it in every way, was an offer I could not refuse. Forged from the cosmic steel of my own creation, it resists nearly any attack, yet allows the creature the same flexibility it would have without it, as well as augmenting its dimensional abilities. I remain pleased with the result.", Translation.EncodeToUtf16("Раздутый отвратительный космический червь. Впрочем, я понимаю, почему Лорд его использует, ведь он может его контролировать... Идея создания брони, подходящей ему во всех отношениях, была предложением, от которого я не мог отказаться. Выкованная из космической стали, моего собственного создания, броня защищала практически от любой атаки. А также она не уменьшает изначальной гибкости существа, а ещё увеличивает пространственные способности. Я доволен результатом."));
            Translation.ILTranslate(il, "I do not care much for the interstellar, or the cosmos. Though I have traversed it, there is still plenty in my own world to manage and discover at this time. Even if I once inhabited a different planet, the Lord's wishes that I provide him machinery were the only condition that I needed to leave it and settle elsewhere. Once I have discovered and dissected every part of this place, perhaps then, I could look up towards the macroscopic.", Translation.EncodeToUtf16("Меня мало волнует космос. Да, я путешествовал по нему, но сейчас мне достаточно работы по изучению собственного мира. Даже если бы я когда-то жил на другой планете, одного желания Лорда получать мои технологии было бы достаточно, чтобы я улетел с неё сюда. Если же я когда-нибудь полностью изучу каждый кусочек этого места, то тогда, возможно, я обращу свой взор наверх, в сторону макроскопического."));
        }
        
        private event ILContext.Manipulator ModifyGetTextByPagePlanetoidGui
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.DraedonLogPlanetoidGUI").GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.DraedonLogPlanetoidGUI").GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyGetTextByPageSnowBiomeGui: ILEdit
    {
        public override string DictKey => "CalamityMod.UI.DraedonLogSnowBiomeGUI";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyGetTextByPageSnowBiomeGui += TranslationModifyGetTextByPageSnowBiomeGui;
    
        public override void Unload() => ModifyGetTextByPageSnowBiomeGui -= TranslationModifyGetTextByPageSnowBiomeGui;
        
        private void TranslationModifyGetTextByPageSnowBiomeGui(ILContext il)
        {
            Translation.ILTranslate(il, "A freezing tundra, where only creatures entirely adapted to the subzero temperatures exist and thrive. It is a shocking transition from the forests of the purity and the sun baked desert. A climate like this should not exist naturally in this part of the world with ease. The weather patterns seem to shift unnaturally arounds the skies of these icy plains. There is likely a reason for this, which necessitates further research.", Translation.EncodeToUtf16("Холодная тундра, где существуют и процветают существа, полностью приспособленные к минусовым температурам. Это шокирующий переход от чистых лесов и выжженной солнцем пустыни. Климат, подобный этому, не должен существовать естественно. Погодные условия на этих ледяных равнинах, кажется, неестественно меняются. Вероятно, этому есть причина, которая требует дальнейших исследований."));
            Translation.ILTranslate(il, "I am not the only singular being to inhabit this biome. Once before, the Archmage who opposed the Lord resided here, cloaked by constant artificial blizzards of his own creation, which no longer fall. He likely chose this place as a conduit for research into his ice spells, and extended the period of time that this place remained frozen. Deep underground my research and materials lay well protected, but above in the natural storms there are traces of the prison of ice he resides in, still haunting its place of creation.", Translation.EncodeToUtf16("Я не единственное разумное существо, находившееся в этом биоме. До этого Архимаг, противостоявший Лорду, жил здесь. Скорее всего, он выбрал это место для изучения ледяных заклятий, одно из которых — нескончаемые ледяные бури. Его действия поддерживали биом в глубокой заморозке. Глубоко под землёй мои исследования хорошо защищены, но снаружи, в естественных бурях, есть следы ледяной тюрьмы, в которой он пребывает по сей день, всё ещё бродящей в месте своего создания."));
            Translation.ILTranslate(il, "Intriguing. Though embedded deep into the caverns of ice and worn from centuries of frost and meltwater, I have uncovered several mechanisms which once filled the tunnels here. The ingenuity present is remarkable, and I have found parallels within my own work, as well as devices even I have something to learn from. From where do these come? Why machinery so complex in so sparse and dreary a habitat? Perhaps, they are related to the unnatural conditions.", Translation.EncodeToUtf16("Интригующе. Я нашёл механизмы, когда-то заполнявшие туннели. Они находились в ледяных пещерах, поломанные из-за веков во льду и талой воды. Мастерство исполнения поражает. Я нашёл схожести с моими работами, а также узнал что-то новое. Но кто их создал? Почему настолько сложные машины находятся в такой скудной и унылой среде обитания. Возможно, именно они виноваты в настолько неестественных условиях."));
        }
        
        private event ILContext.Manipulator ModifyGetTextByPageSnowBiomeGui
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.DraedonLogSnowBiomeGUI").GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.DraedonLogSnowBiomeGUI").GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyGetTextByPageSunkenSeaGui: ILEdit
    {
        public override string DictKey => "CalamityMod.UI.DraedonLogSunkenSeaGUI";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyGetTextByPageSunkenSeaGui += TranslationModifyGetTextByPageSunkenSeaGui;
    
        public override void Unload() => ModifyGetTextByPageSunkenSeaGui -= TranslationModifyGetTextByPageSunkenSeaGui;
        
        private void TranslationModifyGetTextByPageSunkenSeaGui(ILContext il)
        {
            Translation.ILTranslate(il, "Preserved for millennia, a paradise for the living beings who sought shelter in prehistoric seas. They remain untouched by evolution, save for their adaptations to the oxygen starved waters and dim crystals, continuing to thrive. One mystery which continues to escape my understanding however, is how large some of the creatures have become. There is a blatant lack of nutrition and oxygen in the caves, and yet...", Translation.EncodeToUtf16("Сохранившийся на протяжении тысячелетий рай для живых существ, искавших убежища в доисторических морях. Они остаются не тронутыми эволюцией, за исключением их адаптации к необогащенной воздухом воде и тусклым кристаллам, продолжая процветать. Однако одна загадка, которая продолжает ускользать от моего понимания, заключается в том, насколько большими стали некоторые из этих существ. В пещерах явно не хватает питания и кислорода, и всё же..."));
            Translation.ILTranslate(il, "A specimen which has developed a grand size, and inexplicably, impressive psychic abilities. What is most curious is its strong connection to its lesser kin. Without any noticeable communication, when it comes under threat, other mollusks rally to its aggressor and begin attacking. Is this perhaps the very first signs of a higher life form, the evolutionary link hidden away in the sunken sea? Or a self sacrificial fluke, which would lead to their destruction if they inhabited any area other than these pacified caverns.", Translation.EncodeToUtf16("Образец, который развил грандиозные размеры и необъяснимо-впечатляющие телепатические способности. Что самое любопытное, так это его сильная связь со своими меньшими родственниками. Когда он оказывается под угрозой, другие моллюски окружают своего агрессора и начинают атаковать. Может быть, это самые первые признаки высшей формы жизни, эволюционное звено, скрытое в затерянном море? Или самоотверженная случайность, которая привела бы к уничтожению, если они населяли любую область, кроме этих умиротворённых пещер."));
            Translation.ILTranslate(il, "The marine life in these caves do have eyes though they are barely functional, dulled by lack of use and milky white upon observation. On their tough, gnarled hides, crystals find an easy purchase, and grow in great numbers, providing the creatures protection. Perhaps another adaptation to the life they have adopted. The most striking wonder is within their bodies. In specimens dissected, I have noticed that the mineral is buried into their very digestive systems, and perhaps, through some chemical process, pass nutrients into their sluggish hosts. A peculiar yet entirely beneficial interaction.", Translation.EncodeToUtf16("У морских обитателей в этих пещерах есть глаза-рудименты, внешне они молочно-белые. На их жёстких узловатых шкурах кристаллы растут в большом количестве, обеспечивая существам защиту. Возможно, это ещё одна адаптация к жизни, которую они приняли. Но самое поразительное чудо — внутренности их тел. В образцах, подвергнутых вскрытию, я заметил, что минерал находится в самой их пищеварительной системе и, возможно, через какой-то химический процесс передаёт питательные вещества их вялым хозяевам. Своеобразное, но совершенно благотворное взаимодействие."));
        }
        
        private event ILContext.Manipulator ModifyGetTextByPageSunkenSeaGui
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.DraedonLogSunkenSeaGUI").GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.DraedonLogSunkenSeaGUI").GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyAddCalamityBosses: ILEdit
    {
        public override string DictKey => "CalamityMod.WeakReferenceSupport";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyAddCalamityBosses += TranslationModifyAddCalamityBosses;
    
        public override void Unload() => ModifyAddCalamityBosses -= TranslationModifyAddCalamityBosses;
        
        private void TranslationModifyAddCalamityBosses(ILContext il)
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
        
        private event ILContext.Manipulator ModifyAddCalamityBosses
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("AddCalamityBosses", BindingFlags.Static | BindingFlags.NonPublic), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("AddCalamityBosses", BindingFlags.Static | BindingFlags.NonPublic), value);
        }
    }
        
    public class ILModifySetChatButtonsFap: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.TownNPCs.FAP";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetChatButtonsFap += TranslationModifySetChatButtonsFap;
    
        public override void Unload() => ModifySetChatButtonsFap -= TranslationModifySetChatButtonsFap;
        
        private void TranslationModifySetChatButtonsFap(ILContext il) => Translation.ILTranslate(il, "Death Count", Translation.EncodeToUtf16("Количество смертей"));
        
        private event ILContext.Manipulator ModifySetChatButtonsFap
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.TownNPCs.FAP").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.TownNPCs.FAP").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetChatButtonsSeahoe: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.TownNPCs.SEAHOE";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetChatButtonsSeahoe += TranslationModifySetChatButtonsSeahoe;
    
        public override void Unload() => ModifySetChatButtonsSeahoe -= TranslationModifySetChatButtonsSeahoe;
        
        private void TranslationModifySetChatButtonsSeahoe(ILContext il) => Translation.ILTranslate(il, "Help", Translation.EncodeToUtf16("Помощь"));
        
        private event ILContext.Manipulator ModifySetChatButtonsSeahoe
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.TownNPCs.SEAHOE").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.TownNPCs.SEAHOE").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetChatButtonsThief: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.TownNPCs.THIEF";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetChatButtonsThief += TranslationModifySetChatButtonsThief;
    
        public override void Unload() => ModifySetChatButtonsThief -= TranslationModifySetChatButtonsThief;
        
        private void TranslationModifySetChatButtonsThief(ILContext il) => Translation.ILTranslate(il, "Refund", Translation.EncodeToUtf16("Возврат"));
        
        private event ILContext.Manipulator ModifySetChatButtonsThief
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.TownNPCs.THIEF").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.TownNPCs.THIEF").GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyChooseDialogue: ILEdit
    {
        public override string DictKey => "CalamityMod.UI.LabHologramProjectorUI";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyChooseDialogue += TranslationModifyChooseDialogue;
    
        public override void Unload() => ModifyChooseDialogue -= TranslationModifyChooseDialogue;
        
        private void TranslationModifyChooseDialogue(ILContext il)
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
        
        private event ILContext.Manipulator ModifyChooseDialogue
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.LabHologramProjectorUI").GetMethod("ChooseDialogue", BindingFlags.Public | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.LabHologramProjectorUI").GetMethod("ChooseDialogue", BindingFlags.Public | BindingFlags.Static), value);
        }
    }
        
    public class ILModifyOnConsumeItemAstralInjection: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Potions.AstralInjection";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyOnConsumeItemAstralInjection += TranslationModifyOnConsumeItemAstralInjection;
    
        public override void Unload() => ModifyOnConsumeItemAstralInjection -= TranslationModifyOnConsumeItemAstralInjection;
        
        private void TranslationModifyOnConsumeItemAstralInjection(ILContext il) => Translation.ILTranslate(il, "'s blood vessels burst from drug overdose.", Translation.EncodeToUtf16(" кровеносные сосуды лопаются от передозировки наркотиков."));
    
        private event ILContext.Manipulator ModifyOnConsumeItemAstralInjection
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Potions.AstralInjection").GetMethod("OnConsumeItem", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Potions.AstralInjection").GetMethod("OnConsumeItem", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyShootThornBlossom: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Weapons.Magic.ThornBlossom";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyShootThornBlossom += TranslationModifyShootThornBlossom;
    
        public override void Unload() => ModifyShootThornBlossom -= TranslationModifyShootThornBlossom;
        
        private void TranslationModifyShootThornBlossom(ILContext il) => Translation.ILTranslate(il, " was violently pricked by a flower.", Translation.EncodeToUtf16(" был яростно уколот цветком."));
    
        private event ILContext.Manipulator ModifyShootThornBlossom
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Weapons.Magic.ThornBlossom").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Weapons.Magic.ThornBlossom").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyShootThornLucrecia: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Weapons.Melee.Lucrecia";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyShootThornLucrecia += TranslationModifyShootThornLucrecia;
    
        public override void Unload() => ModifyShootThornLucrecia -= TranslationModifyShootThornLucrecia;
        
        private void TranslationModifyShootThornLucrecia(ILContext il) => Translation.ILTranslate(il, "'s DNA was destroyed.", Translation.EncodeToUtf16(" ДНК была уничтожена."));
    
        private event ILContext.Manipulator ModifyShootThornLucrecia
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Weapons.Melee.Lucrecia").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Weapons.Melee.Lucrecia").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyShootBloodBoiler: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Weapons.Ranged.BloodBoiler";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyShootBloodBoiler += TranslationModifyShootBloodBoiler;
    
        public override void Unload() => ModifyShootBloodBoiler -= TranslationModifyShootBloodBoiler;
        
        private void TranslationModifyShootBloodBoiler(ILContext il)
        {
            Translation.ILTranslate(il, " suffered from severe anemia.", Translation.EncodeToUtf16(" страдал тяжёлой анемией."));
            Translation.ILTranslate(il, " was unable to obtain a blood transfusion.", Translation.EncodeToUtf16(" не удалось добиться переливания крови."));
        }
        
        private event ILContext.Manipulator ModifyShootBloodBoiler
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Weapons.Ranged.BloodBoiler").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Weapons.Ranged.BloodBoiler").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyMolecularManipulator: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Weapons.Ranged.MolecularManipulator";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyMolecularManipulator += TranslationModifyMolecularManipulator;
    
        public override void Unload() => ModifyMolecularManipulator -= TranslationModifyMolecularManipulator;
        
        private void TranslationModifyMolecularManipulator(ILContext il)
        {
            Translation.ILTranslate(il, " was vaporized by the imbuement of his life.", Translation.EncodeToUtf16(" испарился из-за насыщенности своей жизни."));
            Translation.ILTranslate(il, " was vaporized by the imbuement of her life.", Translation.EncodeToUtf16(" испарилась из-за насыщенности своей жизни."));
        }
        
        private event ILContext.Manipulator ModifyMolecularManipulator
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Weapons.Ranged.MolecularManipulator").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Weapons.Ranged.MolecularManipulator").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyShootNullificationRifle: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Weapons.Ranged.NullificationRifle";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyShootNullificationRifle += TranslationModifyShootNullificationRifle;
    
        public override void Unload() => ModifyShootNullificationRifle -= TranslationModifyShootNullificationRifle;
        
        private void TranslationModifyShootNullificationRifle(ILContext il)
        {
            Translation.ILTranslate(il, " was vaporized by the imbuement of his life.", Translation.EncodeToUtf16(" испарился из-за насыщенности своей жизни."));
            Translation.ILTranslate(il, " was vaporized by the imbuement of her life.", Translation.EncodeToUtf16(" испарилась из-за насыщенности своей жизни."));
        }
        
        private event ILContext.Manipulator ModifyShootNullificationRifle
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Weapons.Ranged.NullificationRifle").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Weapons.Ranged.NullificationRifle").GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyOnHitPlayerDevourerofGodsHead: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.DevourerofGods.DevourerofGodsHead";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyOnHitPlayerDevourerofGodsHead += TranslationModifyOnHitPlayerDevourerofGodsHead;
    
        public override void Unload() => ModifyOnHitPlayerDevourerofGodsHead -= TranslationModifyOnHitPlayerDevourerofGodsHead;
        
        private void TranslationModifyOnHitPlayerDevourerofGodsHead(ILContext il) => Translation.ILTranslate(il, "'s essence was consumed by the devourer.", Translation.EncodeToUtf16(" сущность была поглощена пожирателем."));
        
        private event ILContext.Manipulator ModifyOnHitPlayerDevourerofGodsHead
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.DevourerofGods.DevourerofGodsHead").GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.DevourerofGods.DevourerofGodsHead").GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyOnHitPlayerDevourerofGodsHeadS: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.DevourerofGods.DevourerofGodsHeadS";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyOnHitPlayerDevourerofGodsHeadS += TranslationModifyOnHitPlayerDevourerofGodsHeadS;
    
        public override void Unload() => ModifyOnHitPlayerDevourerofGodsHeadS -= TranslationModifyOnHitPlayerDevourerofGodsHeadS;
        
        private void TranslationModifyOnHitPlayerDevourerofGodsHeadS(ILContext il) => Translation.ILTranslate(il, "'s essence was consumed by the devourer.", Translation.EncodeToUtf16(" сущность была поглощена пожирателем."));
        
        private event ILContext.Manipulator ModifyOnHitPlayerDevourerofGodsHeadS
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.DevourerofGods.DevourerofGodsHeadS").GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.DevourerofGods.DevourerofGodsHeadS").GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyModifyHitPlayerFearlessGoldfishWarrior: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.NormalNPCs.FearlessGoldfishWarrior";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyModifyHitPlayerFearlessGoldfishWarrior += TranslationModifyModifyHitPlayerFearlessGoldfishWarrior;
    
        public override void Unload() => ModifyModifyHitPlayerFearlessGoldfishWarrior -= TranslationModifyModifyHitPlayerFearlessGoldfishWarrior;
        
        private void TranslationModifyModifyHitPlayerFearlessGoldfishWarrior(ILContext il) => Translation.ILTranslate(il, " was once again impaled by Goldfish.", Translation.EncodeToUtf16(" был снова проткнут Золотой рыбкой."));
        
        private event ILContext.Manipulator ModifyModifyHitPlayerFearlessGoldfishWarrior
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.NormalNPCs.FearlessGoldfishWarrior").GetMethod("ModifyHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.NormalNPCs.FearlessGoldfishWarrior").GetMethod("ModifyHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyGetChatFap: ILEdit2
    {
        public override string DictKey => "CalamityMod.NPCs.TownNPCs.FAP";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyGetChatFap += TranslationModifyGetChatFap;
    
        public override void Unload() => ModifyGetChatFap -= TranslationModifyGetChatFap;
        
        private void TranslationModifyGetChatFap(ILContext il) => Translation.ILTranslate(il, " was slapped too hard.", Translation.EncodeToUtf16(" получил слишком сильную пощечину."));
        
        private event ILContext.Manipulator ModifyGetChatFap
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.TownNPCs.FAP").GetMethod("GetChat", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.TownNPCs.FAP").GetMethod("GetChat", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyAiHealOrbProv: ILEdit
    {
        public override string DictKey => "CalamityMod.Projectiles.Boss.HealOrbProv";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyAiHealOrbProv += TranslationModifyAiHealOrbProv;
    
        public override void Unload() => ModifyAiHealOrbProv -= TranslationModifyAiHealOrbProv;
        
        private void TranslationModifyAiHealOrbProv(ILContext il) => Translation.ILTranslate(il, " burst into sinless ash.", Translation.EncodeToUtf16(" превратился в безгрешный пепел."));
        
        private event ILContext.Manipulator ModifyAiHealOrbProv
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Projectiles.Boss.HealOrbProv").GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Projectiles.Boss.HealOrbProv").GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyAiHolyBurnOrb: ILEdit
    {
        public override string DictKey => "CalamityMod.Projectiles.Boss.HolyBurnOrb";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyAiHolyBurnOrb += TranslationModifyAiHolyBurnOrb;
    
        public override void Unload() => ModifyAiHolyBurnOrb -= TranslationModifyAiHolyBurnOrb;
        
        private void TranslationModifyAiHolyBurnOrb(ILContext il) => Translation.ILTranslate(il, " burst into sinless ash.", Translation.EncodeToUtf16(" превратился в безгрешный пепел."));
        
        private event ILContext.Manipulator ModifyAiHolyBurnOrb
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Projectiles.Boss.HolyBurnOrb").GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Projectiles.Boss.HolyBurnOrb").GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyAiChibiiDoggo: ILEdit
    {
        public override string DictKey => "CalamityMod.Projectiles.Pets.ChibiiDoggo";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyAiChibiiDoggo += TranslationModifyAiChibiiDoggo;
    
        public override void Unload() => ModifyAiChibiiDoggo -= TranslationModifyAiChibiiDoggo;
        
        private void TranslationModifyAiChibiiDoggo(ILContext il) => Translation.ILTranslate(il, " couldn't stand the sharp objects.", Translation.EncodeToUtf16(" не выдерживал острых предметов."));
        
        private event ILContext.Manipulator ModifyAiChibiiDoggo
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Projectiles.Pets.ChibiiDoggo").GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Projectiles.Pets.ChibiiDoggo").GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
    
    public class ILModifySpawnDoggo: ILEdit2
    {
        public override string DictKey => "CalamityMod.Projectiles.Pets.ChibiiDoggo";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySpawnDoggo += TranslationModifySpawnDoggo;
    
        public override void Unload() => ModifySpawnDoggo -= TranslationModifySpawnDoggo;
        
        private void TranslationModifySpawnDoggo(ILContext il)
        {
            Translation.ILTranslate(il, "It's not over yet, kid!", Translation.EncodeToUtf16("Это ещё не конец, малыш!"));
            Translation.ILTranslate(il, "Don't get cocky, kid!", Translation.EncodeToUtf16("Не будь таким самоуверенным, малыш!"));
        }
        
        private event ILContext.Manipulator ModifySpawnDoggo
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Projectiles.Pets.ChibiiDoggo").GetMethod("SpawnDoggo", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Projectiles.Pets.ChibiiDoggo").GetMethod("SpawnDoggo", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyBedRightClick: ILEdit
    {
        public override string DictKey => "CalamityMod.CalamityUtils";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyBedRightClick += TranslationModifyBedRightClick;
    
        public override void Unload() => ModifyBedRightClick -= TranslationModifyBedRightClick;
        
        private void TranslationModifyBedRightClick(ILContext il)
        {
            Translation.ILTranslate(il, "Spawn point removed!", Translation.EncodeToUtf16("Точка воскрешения удалена!"));
            Translation.ILTranslate(il, "Spawn point set!", Translation.EncodeToUtf16("Точка воскрешения задана!"));
        }
        
        private event ILContext.Manipulator ModifyBedRightClick
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.CalamityUtils").GetMethod("BedRightClick", BindingFlags.Public | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.CalamityUtils").GetMethod("BedRightClick", BindingFlags.Public | BindingFlags.Static), value);
        }
    }
        
    public class ILModifyNewRightClick: ILEdit
    {
        public override string DictKey => "CalamityMod.Tiles.FurniturePlaguedPlate.PlaguedPlateBed";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyNewRightClick += TranslationModifyNewRightClick;
    
        public override void Unload() => ModifyNewRightClick -= TranslationModifyNewRightClick;
        
        private void TranslationModifyNewRightClick(ILContext il)
        {
            Translation.ILTranslate(il, "Spawn point removed!", Translation.EncodeToUtf16("Точка воскрешения удалена!"));
            Translation.ILTranslate(il, "Spawn point set!", Translation.EncodeToUtf16("Точка воскрешения задана!"));
        }
        
        private event ILContext.Manipulator ModifyNewRightClick
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Tiles.FurniturePlaguedPlate.PlaguedPlateBed").GetMethod("NewRightClick", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Tiles.FurniturePlaguedPlate.PlaguedPlateBed").GetMethod("NewRightClick", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyAddCalamityInvasions: ILEdit2
    {
        public override string DictKey => "CalamityMod.WeakReferenceSupport";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyAddCalamityInvasions += TranslationModifyAddCalamityInvasions;
    
        public override void Unload() => ModifyAddCalamityInvasions -= TranslationModifyAddCalamityInvasions;
        
        private void TranslationModifyAddCalamityInvasions(ILContext il)
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
        
        private event ILContext.Manipulator ModifyAddCalamityInvasions
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("AddCalamityInvasions", BindingFlags.NonPublic | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("AddCalamityInvasions", BindingFlags.NonPublic | BindingFlags.Static), value);
        }
    }
        
    public class ILModifyCensusSupport: ILEdit3
    {
        public override string DictKey => "CalamityMod.WeakReferenceSupport";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyCensusSupport += TranslationModifyCensusSupport;
    
        public override void Unload() => ModifyCensusSupport -= TranslationModifyCensusSupport;
        
        private void TranslationModifyCensusSupport(ILContext il)
        {
            Translation.ILTranslate(il, "Defeat a Giant Clam after defeating the Desert Scourge", Translation.EncodeToUtf16("Одолейте Гигантского моллюска после победы над Пустынным бичем"));
            Translation.ILTranslate(il, "Have a [i:", Translation.EncodeToUtf16("Имейте [i:"));
            Translation.ILTranslate(il, "] in your inventory after defeating Skeletron", Translation.EncodeToUtf16("] в вашем инвентаре после победы над Скелетроном"));
            Translation.ILTranslate(il, "Defeat Cryogen", Translation.EncodeToUtf16("Одолейте Криогена"));
            Translation.ILTranslate(il, "Have [i:", Translation.EncodeToUtf16("Имейте [i:"));
            Translation.ILTranslate(il, "] in your inventory in Hardmode", Translation.EncodeToUtf16("] в вашем инвентаре в Хардмоде"));
        }
        
        private event ILContext.Manipulator ModifyCensusSupport
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("CensusSupport", BindingFlags.NonPublic | BindingFlags.Static), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetMethod("CensusSupport", BindingFlags.NonPublic | BindingFlags.Static), value);
        }
    }
        
    public class ILModifyBossLootRavager: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.Ravager.RavagerBody";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyBossLootRavager += TranslationModifyBossLootRavager;
    
        public override void Unload() => ModifyBossLootRavager -= TranslationModifyBossLootRavager;
        
        private void TranslationModifyBossLootRavager(ILContext il) => Translation.ILTranslate(il, "Ravager", Translation.EncodeToUtf16("Разрушитель"));
        
        private event ILContext.Manipulator ModifyBossLootRavager
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.Ravager.RavagerBody").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.Ravager.RavagerBody").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyBossLootCalamitasRun3: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.Calamitas.CalamitasRun3";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyBossLootCalamitasRun3 += TranslationModifyBossLootCalamitasRun3;
    
        public override void Unload() => ModifyBossLootCalamitasRun3 -= TranslationModifyBossLootCalamitasRun3;
        
        private void TranslationModifyBossLootCalamitasRun3(ILContext il) => Translation.ILTranslate(il, "The Calamitas Clone", Translation.EncodeToUtf16("Клон Каламитас"));
        
        private event ILContext.Manipulator ModifyBossLootCalamitasRun3
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.Calamitas.CalamitasRun3").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.Calamitas.CalamitasRun3").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyDrawBossHpui: ILEdit
    {
        public override string DictKey => "CalamityMod.UI.BossHealthBarManager+BossHPUI";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyDrawBossHpui += TranslationModifyDrawBossHpui;
    
        public override void Unload() => ModifyDrawBossHpui -= TranslationModifyDrawBossHpui;
        
        private void TranslationModifyDrawBossHpui(ILContext il)
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
        
        private event ILContext.Manipulator ModifyDrawBossHpui
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.BossHealthBarManager+BossHPUI").GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.BossHealthBarManager+BossHPUI").GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyDrawOpenAnim: ILEdit2
    {
        public override string DictKey => "CalamityMod.UI.BossHealthBarManager+BossHPUI";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyDrawOpenAnim += TranslationModifyDrawOpenAnim;
    
        public override void Unload() => ModifyDrawOpenAnim -= TranslationModifyDrawOpenAnim;
        
        private void TranslationModifyDrawOpenAnim(ILContext il)
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
        
        private event ILContext.Manipulator ModifyDrawOpenAnim
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.BossHealthBarManager+BossHPUI").GetMethod("DrawOpenAnim", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.BossHealthBarManager+BossHPUI").GetMethod("DrawOpenAnim", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyBossLootProfanedGuardianBoss2: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.ProfanedGuardians.ProfanedGuardianBoss2";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyBossLootProfanedGuardianBoss2 += TranslationModifyBossLootProfanedGuardianBoss2;
    
        public override void Unload() => ModifyBossLootProfanedGuardianBoss2 -= TranslationModifyBossLootProfanedGuardianBoss2;
        
        private void TranslationModifyBossLootProfanedGuardianBoss2(ILContext il) => Translation.ILTranslate(il, "A Profaned Guardian", Translation.EncodeToUtf16("Осквернённый страж"));
        
        private event ILContext.Manipulator ModifyBossLootProfanedGuardianBoss2
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.ProfanedGuardians.ProfanedGuardianBoss2").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.ProfanedGuardians.ProfanedGuardianBoss2").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyBossLootPerforatorHeadLarge: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.Perforator.PerforatorHeadLarge";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyBossLootPerforatorHeadLarge += TranslationModifyBossLootPerforatorHeadLarge;
    
        public override void Unload() => ModifyBossLootPerforatorHeadLarge -= TranslationModifyBossLootPerforatorHeadLarge;
        
        private void TranslationModifyBossLootPerforatorHeadLarge(ILContext il) => Translation.ILTranslate(il, "The Large Perforator", Translation.EncodeToUtf16("Перфоратор"));
        
        private event ILContext.Manipulator ModifyBossLootPerforatorHeadLarge
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.Perforator.PerforatorHeadLarge").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.Perforator.PerforatorHeadLarge").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyBossLootPerforatorHeadSmall: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.Perforator.PerforatorHeadSmall";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyBossLootPerforatorHeadSmall += TranslationModifyBossLootPerforatorHeadSmall;
    
        public override void Unload() => ModifyBossLootPerforatorHeadSmall -= TranslationModifyBossLootPerforatorHeadSmall;
        
        private void TranslationModifyBossLootPerforatorHeadSmall(ILContext il) => Translation.ILTranslate(il, "The Small Perforator", Translation.EncodeToUtf16("Перфоратор"));
        
        private event ILContext.Manipulator ModifyBossLootPerforatorHeadSmall
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.Perforator.PerforatorHeadSmall").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.Perforator.PerforatorHeadSmall").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyBossLootBumblefuck: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.Bumblebirb.Bumblefuck";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyBossLootBumblefuck += TranslationModifyBossLootBumblefuck;
    
        public override void Unload() => ModifyBossLootBumblefuck -= TranslationModifyBossLootBumblefuck;
        
        private void TranslationModifyBossLootBumblefuck(ILContext il) => Translation.ILTranslate(il, "A Dragonfolly", Translation.EncodeToUtf16("Псевдодракон"));
        
        private event ILContext.Manipulator ModifyBossLootBumblefuck
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.Bumblebirb.Bumblefuck").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.Bumblebirb.Bumblefuck").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyBossLootPerforatorHeadMedium: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.Perforator.PerforatorHeadMedium";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyBossLootPerforatorHeadMedium += TranslationModifyBossLootPerforatorHeadMedium;
    
        public override void Unload() => ModifyBossLootPerforatorHeadMedium -= TranslationModifyBossLootPerforatorHeadMedium;
        
        private void TranslationModifyBossLootPerforatorHeadMedium(ILContext il) => Translation.ILTranslate(il, "The Medium Perforator", Translation.EncodeToUtf16("Перфоратор"));
        
        private event ILContext.Manipulator ModifyBossLootPerforatorHeadMedium
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.Perforator.PerforatorHeadMedium").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.Perforator.PerforatorHeadMedium").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyBossLootProfanedGuardianBoss3: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.ProfanedGuardians.ProfanedGuardianBoss3";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyBossLootProfanedGuardianBoss3 += TranslationModifyBossLootProfanedGuardianBoss3;
    
        public override void Unload() => ModifyBossLootProfanedGuardianBoss3 -= TranslationModifyBossLootProfanedGuardianBoss3;
        
        private void TranslationModifyBossLootProfanedGuardianBoss3(ILContext il) => Translation.ILTranslate(il, "A Profaned Guardian", Translation.EncodeToUtf16("Осквернённый страж"));
        
        private event ILContext.Manipulator ModifyBossLootProfanedGuardianBoss3
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.ProfanedGuardians.ProfanedGuardianBoss3").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.ProfanedGuardians.ProfanedGuardianBoss3").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyBossLootProfanedGuardianBoss: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.ProfanedGuardians.ProfanedGuardianBoss";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyBossLootProfanedGuardianBoss += TranslationModifyBossLootProfanedGuardianBoss;
    
        public override void Unload() => ModifyBossLootProfanedGuardianBoss -= TranslationModifyBossLootProfanedGuardianBoss;
        
        private void TranslationModifyBossLootProfanedGuardianBoss(ILContext il) => Translation.ILTranslate(il, "A Profaned Guardian", Translation.EncodeToUtf16("Осквернённый страж"));
        
        private event ILContext.Manipulator ModifyBossLootProfanedGuardianBoss
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.ProfanedGuardians.ProfanedGuardianBoss").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.ProfanedGuardians.ProfanedGuardianBoss").GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyInvasionNamebossRushUi: ILEdit
    {
        public override string DictKey => "CalamityMod.UI.BossRushUI";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyInvasionNamebossRushUi += TranslationModifyInvasionNamebossRushUi;
    
        public override void Unload() => ModifyInvasionNamebossRushUi -= TranslationModifyInvasionNamebossRushUi;
        
        private void TranslationModifyInvasionNamebossRushUi(ILContext il) => Translation.ILTranslate(il, "Boss Rush", Translation.EncodeToUtf16("Босс-Раш"));
        
        private event ILContext.Manipulator ModifyInvasionNamebossRushUi
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.BossRushUI").GetMethod("get_InvasionName", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.UI.BossRushUI").GetMethod("get_InvasionName", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyColdDivinityModifyTooltips: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Weapons.Summon.ColdDivinity";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifyColdDivinityModifyTooltips += TranslationModifyColdDivinityModifyTooltips;
    
        public override void Unload() => ModifyColdDivinityModifyTooltips -= TranslationModifyColdDivinityModifyTooltips;
        
        private void TranslationModifyColdDivinityModifyTooltips(ILContext il) => Translation.ILTranslate(il, "Tooltip7", "Tooltip6");
        
        private event ILContext.Manipulator ModifyColdDivinityModifyTooltips
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Weapons.Summon.ColdDivinity").GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Weapons.Summon.ColdDivinity").GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultBathtub: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultBathtub";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultBathtub += TranslationModifySetDefaultsOccultBathtub;
    
        public override void Unload() => ModifySetDefaultsOccultBathtub -= TranslationModifySetDefaultsOccultBathtub;
        
        private void TranslationModifySetDefaultsOccultBathtub(ILContext il) => Translation.ILTranslate(il, "Otherworldly Bathtub", Translation.EncodeToUtf16("Потусторонняя ванна"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultBathtub
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultBathtub").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultBathtub").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultBed: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultBed";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultBed += TranslationModifySetDefaultsOccultBed;
    
        public override void Unload() => ModifySetDefaultsOccultBed -= TranslationModifySetDefaultsOccultBed;
        
        private void TranslationModifySetDefaultsOccultBed(ILContext il) => Translation.ILTranslate(il, "Otherworldly Bed", Translation.EncodeToUtf16("Потусторонняя кровать"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultBed
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultBed").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultBed").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultBookcase: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultBookcase";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultBookcase += TranslationModifySetDefaultsOccultBookcase;
    
        public override void Unload() => ModifySetDefaultsOccultBookcase -= TranslationModifySetDefaultsOccultBookcase;
        
        private void TranslationModifySetDefaultsOccultBookcase(ILContext il) => Translation.ILTranslate(il, "Otherworldly Bookcase", Translation.EncodeToUtf16("Потусторонний книжный шкаф"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultBookcase
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultBookcase").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultBookcase").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
    
    public class ILModifySetDefaultsOccultCandelabra: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultCandelabra";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultCandelabra += TranslationModifySetDefaultsOccultCandelabra;
    
        public override void Unload() => ModifySetDefaultsOccultCandelabra -= TranslationModifySetDefaultsOccultCandelabra;
        
        private void TranslationModifySetDefaultsOccultCandelabra(ILContext il) => Translation.ILTranslate(il, "Otherworldly Candelabra", Translation.EncodeToUtf16("Потусторонний канделябр"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultCandelabra
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultCandelabra").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultCandelabra").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultCandle: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultCandle";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultCandle += TranslationModifySetDefaultsOccultCandle;
    
        public override void Unload() => ModifySetDefaultsOccultCandle -= TranslationModifySetDefaultsOccultCandle;
        
        private void TranslationModifySetDefaultsOccultCandle(ILContext il) => Translation.ILTranslate(il, "Otherworldly Candle", Translation.EncodeToUtf16("Потусторонняя свеча"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultCandle
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultCandle").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultCandle").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultChair: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultChair";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultChair += TranslationModifySetDefaultsOccultChair;
    
        public override void Unload() => ModifySetDefaultsOccultChair -= TranslationModifySetDefaultsOccultChair;
        
        private void TranslationModifySetDefaultsOccultChair(ILContext il) => Translation.ILTranslate(il, "Otherworldly Chair", Translation.EncodeToUtf16("Потусторонний стул"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultChair
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultChair").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultChair").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultChandelier: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultChandelier";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultChandelier += TranslationModifySetDefaultsOccultChandelier;
    
        public override void Unload() => ModifySetDefaultsOccultChandelier -= TranslationModifySetDefaultsOccultChandelier;
        
        private void TranslationModifySetDefaultsOccultChandelier(ILContext il) => Translation.ILTranslate(il, "Otherworldly Chandelier", Translation.EncodeToUtf16("Потусторонняя люстра"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultChandelier
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultChandelier").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultChandelier").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultChest: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultChest";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultChest += TranslationModifySetDefaultsOccultChest;
    
        public override void Unload() => ModifySetDefaultsOccultChest -= TranslationModifySetDefaultsOccultChest;
        
        private void TranslationModifySetDefaultsOccultChest(ILContext il) => Translation.ILTranslate(il, "Otherworldly Chest", Translation.EncodeToUtf16("Потусторонний сундук"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultChest
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultChest").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultChest").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultClock: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultClock";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultClock += TranslationModifySetDefaultsOccultClock;
    
        public override void Unload() => ModifySetDefaultsOccultClock -= TranslationModifySetDefaultsOccultClock;
        
        private void TranslationModifySetDefaultsOccultClock(ILContext il) => Translation.ILTranslate(il, "Otherworldly Clock", Translation.EncodeToUtf16("Потусторонние часы"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultClock
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultClock").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultClock").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultDoor: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultDoor";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultDoor += TranslationModifySetDefaultsOccultDoor;
    
        public override void Unload() => ModifySetDefaultsOccultDoor -= TranslationModifySetDefaultsOccultDoor;
        
        private void TranslationModifySetDefaultsOccultDoor(ILContext il) => Translation.ILTranslate(il, "Otherworldly Door", Translation.EncodeToUtf16("Потусторонняя дверь"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultDoor
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultDoor").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultDoor").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultDresser: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultDresser";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultDresser += TranslationModifySetDefaultsOccultDresser;
    
        public override void Unload() => ModifySetDefaultsOccultDresser -= TranslationModifySetDefaultsOccultDresser;
        
        private void TranslationModifySetDefaultsOccultDresser(ILContext il) => Translation.ILTranslate(il, "Otherworldly Dresser", Translation.EncodeToUtf16("Потусторонний комод"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultDresser
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultDresser").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultDresser").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultLamp: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultLamp";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultLamp += TranslationModifySetDefaultsOccultLamp;
    
        public override void Unload() => ModifySetDefaultsOccultLamp -= TranslationModifySetDefaultsOccultLamp;
        
        private void TranslationModifySetDefaultsOccultLamp(ILContext il) => Translation.ILTranslate(il, "Otherworldly Lamp", Translation.EncodeToUtf16("Потусторонняя лампа"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultLamp
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultLamp").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultLamp").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultLantern: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultLantern";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultLantern += TranslationModifySetDefaultsOccultLantern;
    
        public override void Unload() => ModifySetDefaultsOccultLantern -= TranslationModifySetDefaultsOccultLantern;
        
        private void TranslationModifySetDefaultsOccultLantern(ILContext il) => Translation.ILTranslate(il, "Otherworldly Lantern", Translation.EncodeToUtf16("Потусторонний фонарь"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultLantern
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultLantern").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultLantern").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultPiano: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultPiano";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultPiano += TranslationModifySetDefaultsOccultPiano;
    
        public override void Unload() => ModifySetDefaultsOccultPiano -= TranslationModifySetDefaultsOccultPiano;
        
        private void TranslationModifySetDefaultsOccultPiano(ILContext il) => Translation.ILTranslate(il, "Otherworldly Piano", Translation.EncodeToUtf16("Потустороннее пианино"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultPiano
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultPiano").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultPiano").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultPlatform: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultPlatform";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultPlatform += TranslationModifySetDefaultsOccultPlatform;
    
        public override void Unload() => ModifySetDefaultsOccultPlatform -= TranslationModifySetDefaultsOccultPlatform;
        
        private void TranslationModifySetDefaultsOccultPlatform(ILContext il) => Translation.ILTranslate(il, "Otherworldly Platform", Translation.EncodeToUtf16("Потусторонняя платформа"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultPlatform
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultPlatform").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultPlatform").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultSink: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultSink";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultSink += TranslationModifySetDefaultsOccultSink;
    
        public override void Unload() => ModifySetDefaultsOccultSink -= TranslationModifySetDefaultsOccultSink;
        
        private void TranslationModifySetDefaultsOccultSink(ILContext il) => Translation.ILTranslate(il, "Otherworldly Sink", Translation.EncodeToUtf16("Потусторонняя раковина"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultSink
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultSink").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultSink").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultSofa: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultSofa";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultSofa += TranslationModifySetDefaultsOccultSofa;
    
        public override void Unload() => ModifySetDefaultsOccultSofa -= TranslationModifySetDefaultsOccultSofa;
        
        private void TranslationModifySetDefaultsOccultSofa(ILContext il) => Translation.ILTranslate(il, "Otherworldly Sofa", Translation.EncodeToUtf16("Потусторонний диван"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultSofa
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultSofa").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultSofa").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultStone: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultStone";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultStone += TranslationModifySetDefaultsOccultStone;
    
        public override void Unload() => ModifySetDefaultsOccultStone -= TranslationModifySetDefaultsOccultStone;
        
        private void TranslationModifySetDefaultsOccultStone(ILContext il) => Translation.ILTranslate(il, "Otherworldly Stone", Translation.EncodeToUtf16("Потусторонний камень"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultStone
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultStone").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultStone").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultTable: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultTable";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultTable += TranslationModifySetDefaultsOccultTable;
    
        public override void Unload() => ModifySetDefaultsOccultTable -= TranslationModifySetDefaultsOccultTable;
        
        private void TranslationModifySetDefaultsOccultTable(ILContext il) => Translation.ILTranslate(il, "Otherworldly Table", Translation.EncodeToUtf16("Потусторонний стол"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultTable
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultTable").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultTable").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultWorkBench: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureOccult.OccultWorkBench";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultWorkBench += TranslationModifySetDefaultsOccultWorkBench;
    
        public override void Unload() => ModifySetDefaultsOccultWorkBench -= TranslationModifySetDefaultsOccultWorkBench;
        
        private void TranslationModifySetDefaultsOccultWorkBench(ILContext il) => Translation.ILTranslate(il, "Otherworldly Work Bench", Translation.EncodeToUtf16("Потусторонний верстак"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultWorkBench
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultWorkBench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureOccult.OccultWorkBench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsOccultStoneWall: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.Walls.OccultStoneWall";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsOccultStoneWall += TranslationModifySetDefaultsOccultStoneWall;
    
        public override void Unload() => ModifySetDefaultsOccultStoneWall -= TranslationModifySetDefaultsOccultStoneWall;
        
        private void TranslationModifySetDefaultsOccultStoneWall(ILContext il) => Translation.ILTranslate(il, "Otherworldly Stone Wall", Translation.EncodeToUtf16("Стена из потустороннего камня"));
        
        private event ILContext.Manipulator ModifySetDefaultsOccultStoneWall
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.Walls.OccultStoneWall").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.Walls.OccultStoneWall").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsStratusWorkbench: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureStratus.StratusWorkbench";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsStratusWorkbench += TranslationModifySetDefaultsStratusWorkbench;
    
        public override void Unload() => ModifySetDefaultsStratusWorkbench -= TranslationModifySetDefaultsStratusWorkbench;
        
        private void TranslationModifySetDefaultsStratusWorkbench(ILContext il) => Translation.ILTranslate(il, "Stratus Work Bench", Translation.EncodeToUtf16("Слоистый верстак"));
        
        private event ILContext.Manipulator ModifySetDefaultsStratusWorkbench
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureStratus.StratusWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureStratus.StratusWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsStatigelWorkbench: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureStatigel.StatigelWorkbench";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsStatigelWorkbench += TranslationModifySetDefaultsStatigelWorkbench;
    
        public override void Unload() => ModifySetDefaultsStatigelWorkbench -= TranslationModifySetDefaultsStatigelWorkbench;
        
        private void TranslationModifySetDefaultsStatigelWorkbench(ILContext il) => Translation.ILTranslate(il, "Statigel Work Bench", Translation.EncodeToUtf16("Статиджеловый верстак"));
        
        private event ILContext.Manipulator ModifySetDefaultsStatigelWorkbench
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureStatigel.StatigelWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureStatigel.StatigelWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsStatigelBath: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureStatigel.StatigelBath";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsStatigelBath += TranslationModifySetDefaultsStatigelBath;
    
        public override void Unload() => ModifySetDefaultsStatigelBath -= TranslationModifySetDefaultsStatigelBath;
        
        private void TranslationModifySetDefaultsStatigelBath(ILContext il) => Translation.ILTranslate(il, "Statigel Bathtub", Translation.EncodeToUtf16("Статиджеловая ванна"));
        
        private event ILContext.Manipulator ModifySetDefaultsStatigelBath
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureStatigel.StatigelBath").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureStatigel.StatigelBath").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
    
    public class ILModifySetDefaultsProfanedWorkbench: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureProfaned.ProfanedWorkbench";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsProfanedWorkbench += TranslationModifySetDefaultsProfanedWorkbench;
    
        public override void Unload() => ModifySetDefaultsProfanedWorkbench -= TranslationModifySetDefaultsProfanedWorkbench;
        
        private void TranslationModifySetDefaultsProfanedWorkbench(ILContext il) => Translation.ILTranslate(il, "Profaned Work Bench", Translation.EncodeToUtf16("Осквернённый верстак"));
        
        private event ILContext.Manipulator ModifySetDefaultsProfanedWorkbench
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureProfaned.ProfanedWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureProfaned.ProfanedWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsProfanedBath: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureProfaned.ProfanedBath";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsProfanedBath += TranslationModifySetDefaultsProfanedBath;
    
        public override void Unload() => ModifySetDefaultsProfanedBath -= TranslationModifySetDefaultsProfanedBath;
        
        private void TranslationModifySetDefaultsProfanedBath(ILContext il) => Translation.ILTranslate(il, "Profaned Bathtub", Translation.EncodeToUtf16("Осквернённая ванна"));
        
        private event ILContext.Manipulator ModifySetDefaultsProfanedBath
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureProfaned.ProfanedBath").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureProfaned.ProfanedBath").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsVoidWorkbench: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureVoid.VoidWorkbench";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsVoidWorkbench += TranslationModifySetDefaultsVoidWorkbench;
    
        public override void Unload() => ModifySetDefaultsVoidWorkbench -= TranslationModifySetDefaultsVoidWorkbench;
        
        private void TranslationModifySetDefaultsVoidWorkbench(ILContext il) => Translation.ILTranslate(il, "Void Work Bench", Translation.EncodeToUtf16("Пустотный верстак"));
        
        private event ILContext.Manipulator ModifySetDefaultsVoidWorkbench
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureVoid.VoidWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureVoid.VoidWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsVoidClock: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureVoid.VoidClock";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsVoidClock += TranslationModifySetDefaultsVoidClock;
    
        public override void Unload() => ModifySetDefaultsVoidClock -= TranslationModifySetDefaultsVoidClock;
        
        private void TranslationModifySetDefaultsVoidClock(ILContext il) => Translation.ILTranslate(il, "Void Obelisk", Translation.EncodeToUtf16("Пустотный обелиск"));
        
        private event ILContext.Manipulator ModifySetDefaultsVoidClock
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureVoid.VoidClock").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureVoid.VoidClock").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsVoidBath: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureVoid.VoidBath";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsVoidBath += TranslationModifySetDefaultsVoidBath;
    
        public override void Unload() => ModifySetDefaultsVoidBath -= TranslationModifySetDefaultsVoidBath;
        
        private void TranslationModifySetDefaultsVoidBath(ILContext il) => Translation.ILTranslate(il, "Void Bathtub", Translation.EncodeToUtf16("Пустотная ванна"));
        
        private event ILContext.Manipulator ModifySetDefaultsVoidBath
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureVoid.VoidBath").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureVoid.VoidBath").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsCosmiliteWorkbench: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureCosmilite.CosmiliteWorkbench";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsCosmiliteWorkbench += TranslationModifySetDefaultsCosmiliteWorkbench;
    
        public override void Unload() => ModifySetDefaultsCosmiliteWorkbench -= TranslationModifySetDefaultsCosmiliteWorkbench;
        
        private void TranslationModifySetDefaultsCosmiliteWorkbench(ILContext il) => Translation.ILTranslate(il, "Cosmilite Work Bench", Translation.EncodeToUtf16("Космилитовый верстак"));
        
        private event ILContext.Manipulator ModifySetDefaultsCosmiliteWorkbench
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureCosmilite.CosmiliteWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureCosmilite.CosmiliteWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsCosmiliteBath: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureCosmilite.CosmiliteBath";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsCosmiliteBath += TranslationModifySetDefaultsCosmiliteBath;
    
        public override void Unload() => ModifySetDefaultsCosmiliteBath -= TranslationModifySetDefaultsCosmiliteBath;
        
        private void TranslationModifySetDefaultsCosmiliteBath(ILContext il) => Translation.ILTranslate(il, "Cosmilite Bathtub", Translation.EncodeToUtf16("Космилитовая ванна"));
        
        private event ILContext.Manipulator ModifySetDefaultsCosmiliteBath
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureCosmilite.CosmiliteBath").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureCosmilite.CosmiliteBath").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsAshenPiano: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAshen.AshenPiano";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsAshenPiano += TranslationModifySetDefaultsAshenPiano;
    
        public override void Unload() => ModifySetDefaultsAshenPiano -= TranslationModifySetDefaultsAshenPiano;
        
        private void TranslationModifySetDefaultsAshenPiano(ILContext il) => Translation.ILTranslate(il, "Ashen Pipe Organ", Translation.EncodeToUtf16("Пепельный трубный орган"));
        
        private event ILContext.Manipulator ModifySetDefaultsAshenPiano
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAshen.AshenPiano").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAshen.AshenPiano").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsAshenWorkbench: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAshen.AshenWorkbench";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsAshenWorkbench += TranslationModifySetDefaultsAshenWorkbench;
    
        public override void Unload() => ModifySetDefaultsAshenWorkbench -= TranslationModifySetDefaultsAshenWorkbench;
        
        private void TranslationModifySetDefaultsAshenWorkbench(ILContext il) => Translation.ILTranslate(il, "Ashen Work Bench", Translation.EncodeToUtf16("Пепельный верстак"));
        
        private event ILContext.Manipulator ModifySetDefaultsAshenWorkbench
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAshen.AshenWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAshen.AshenWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsEutrophicCrafting: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.Furniture.CraftingStations.EutrophicCrafting";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsEutrophicCrafting += TranslationModifySetDefaultsEutrophicCrafting;
    
        public override void Unload() => ModifySetDefaultsEutrophicCrafting -= TranslationModifySetDefaultsEutrophicCrafting;
        
        private void TranslationModifySetDefaultsEutrophicCrafting(ILContext il) => Translation.ILTranslate(il, "Eutrophic Shelf", Translation.EncodeToUtf16("Эвтрофная полка"));
        
        private event ILContext.Manipulator ModifySetDefaultsEutrophicCrafting
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.Furniture.CraftingStations.EutrophicCrafting").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.Furniture.CraftingStations.EutrophicCrafting").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsMonolithCrafting: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.Furniture.CraftingStations.MonolithCrafting";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithCrafting += TranslationModifySetDefaultsMonolithCrafting;
    
        public override void Unload() => ModifySetDefaultsMonolithCrafting -= TranslationModifySetDefaultsMonolithCrafting;
        
        private void TranslationModifySetDefaultsMonolithCrafting(ILContext il) => Translation.ILTranslate(il, "Monolith Amalgam", Translation.EncodeToUtf16("Монолитное слияние"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithCrafting
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.Furniture.CraftingStations.MonolithCrafting").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.Furniture.CraftingStations.MonolithCrafting").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsProfanedBasin: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.Furniture.CraftingStations.ProfanedBasin";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsProfanedBasin += TranslationModifySetDefaultsProfanedBasin;
    
        public override void Unload() => ModifySetDefaultsProfanedBasin -= TranslationModifySetDefaultsProfanedBasin;
        
        private void TranslationModifySetDefaultsProfanedBasin(ILContext il) => Translation.ILTranslate(il, "Profaned Crucible", Translation.EncodeToUtf16("Осквернённый тигель"));
        
        private event ILContext.Manipulator ModifySetDefaultsProfanedBasin
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.Furniture.CraftingStations.ProfanedBasin").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.Furniture.CraftingStations.ProfanedBasin").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsSilvaBasin: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.Furniture.CraftingStations.SilvaBasin";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsSilvaBasin += TranslationModifySetDefaultsSilvaBasin;
    
        public override void Unload() => ModifySetDefaultsSilvaBasin -= TranslationModifySetDefaultsSilvaBasin;
        
        private void TranslationModifySetDefaultsSilvaBasin(ILContext il) => Translation.ILTranslate(il, "Effulgent Manipulator", Translation.EncodeToUtf16("Лучезарный манипулятор"));
        
        private event ILContext.Manipulator ModifySetDefaultsSilvaBasin
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.Furniture.CraftingStations.SilvaBasin").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.Furniture.CraftingStations.SilvaBasin").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsAbyssBath: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAbyss.AbyssBath";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsAbyssBath += TranslationModifySetDefaultsAbyssBath;
    
        public override void Unload() => ModifySetDefaultsAbyssBath -= TranslationModifySetDefaultsAbyssBath;
        
        private void TranslationModifySetDefaultsAbyssBath(ILContext il) => Translation.ILTranslate(il, "Abyss Bathtub", Translation.EncodeToUtf16("Ванна бездны"));
        
        private event ILContext.Manipulator ModifySetDefaultsAbyssBath
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAbyss.AbyssBath").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAbyss.AbyssBath").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsAbyssWorkbench: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAbyss.AbyssWorkbench";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsAbyssWorkbench += TranslationModifySetDefaultsAbyssWorkbench;
    
        public override void Unload() => ModifySetDefaultsAbyssWorkbench -= TranslationModifySetDefaultsAbyssWorkbench;
        
        private void TranslationModifySetDefaultsAbyssWorkbench(ILContext il) => Translation.ILTranslate(il, "Abyss Work Bench", Translation.EncodeToUtf16("Верстак бездны"));
        
        private event ILContext.Manipulator ModifySetDefaultsAbyssWorkbench
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAbyss.AbyssWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAbyss.AbyssWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsAbyssPiano: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAbyss.AbyssPiano";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsAbyssPiano += TranslationModifySetDefaultsAbyssPiano;
    
        public override void Unload() => ModifySetDefaultsAbyssPiano -= TranslationModifySetDefaultsAbyssPiano;
        
        private void TranslationModifySetDefaultsAbyssPiano(ILContext il) => Translation.ILTranslate(il, "Abyss Synth", Translation.EncodeToUtf16("Синтезатор бездны"));
        
        private event ILContext.Manipulator ModifySetDefaultsAbyssPiano
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAbyss.AbyssPiano").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAbyss.AbyssPiano").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsAncientBath: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAncient.AncientBath";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsAncientBath += TranslationModifySetDefaultsAncientBath;
    
        public override void Unload() => ModifySetDefaultsAncientBath -= TranslationModifySetDefaultsAncientBath;
        
        private void TranslationModifySetDefaultsAncientBath(ILContext il) => Translation.ILTranslate(il, "Ancient Bathtub", Translation.EncodeToUtf16("Древняя ванна"));
        
        private event ILContext.Manipulator ModifySetDefaultsAncientBath
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAncient.AncientBath").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAncient.AncientBath").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsAshenBath: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAshen.AshenBath";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsAshenBath += TranslationModifySetDefaultsAshenBath;
    
        public override void Unload() => ModifySetDefaultsAshenBath -= TranslationModifySetDefaultsAshenBath;
        
        private void TranslationModifySetDefaultsAshenBath(ILContext il) => Translation.ILTranslate(il, "Ashen Bathtub", Translation.EncodeToUtf16("Пепельная ванна"));
        
        private event ILContext.Manipulator ModifySetDefaultsAshenBath
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAshen.AshenBath").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAshen.AshenBath").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsAncientWorkbench: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAncient.AncientWorkbench";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsAncientWorkbench += TranslationModifySetDefaultsAncientWorkbench;
    
        public override void Unload() => ModifySetDefaultsAncientWorkbench -= TranslationModifySetDefaultsAncientWorkbench;
        
        private void TranslationModifySetDefaultsAncientWorkbench(ILContext il) => Translation.ILTranslate(il, "Ancient Work Bench", Translation.EncodeToUtf16("Древний верстак"));
        
        private event ILContext.Manipulator ModifySetDefaultsAncientWorkbench
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAncient.AncientWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAncient.AncientWorkbench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsAncientPiano: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAncient.AncientPiano";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsAncientPiano += TranslationModifySetDefaultsAncientPiano;
    
        public override void Unload() => ModifySetDefaultsAncientPiano -= TranslationModifySetDefaultsAncientPiano;
        
        private void TranslationModifySetDefaultsAncientPiano(ILContext il) => Translation.ILTranslate(il, "Ancient Pipe Organ", Translation.EncodeToUtf16("Древний трубный орган"));
        
        private event ILContext.Manipulator ModifySetDefaultsAncientPiano
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAncient.AncientPiano").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAncient.AncientPiano").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsMonolithBathtub: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithBathtub";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithBathtub += TranslationModifySetDefaultsMonolithBathtub;
    
        public override void Unload() => ModifySetDefaultsMonolithBathtub -= TranslationModifySetDefaultsMonolithBathtub;
        
        private void TranslationModifySetDefaultsMonolithBathtub(ILContext il) => Translation.ILTranslate(il, "Monolith Bathtub", Translation.EncodeToUtf16("Монолитная ванна"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithBathtub
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithBathtub").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithBathtub").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
    
    public class ILModifySetDefaultsMonolithBed: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithBed";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithBed += TranslationModifySetDefaultsMonolithBed;
    
        public override void Unload() => ModifySetDefaultsMonolithBed -= TranslationModifySetDefaultsMonolithBed;
        
        private void TranslationModifySetDefaultsMonolithBed(ILContext il) => Translation.ILTranslate(il, "Monolith Bed", Translation.EncodeToUtf16("Монолитная кровать"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithBed
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithBed").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithBed").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsMonolithBench: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithBench";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithBench += TranslationModifySetDefaultsMonolithBench;
    
        public override void Unload() => ModifySetDefaultsMonolithBench -= TranslationModifySetDefaultsMonolithBench;
        
        private void TranslationModifySetDefaultsMonolithBench(ILContext il) => Translation.ILTranslate(il, "Monolith Bench", Translation.EncodeToUtf16("Монолитная скамья"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithBench
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithBench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithBench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsMonolithBookcase: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithBookcase";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithBookcase += TranslationModifySetDefaultsMonolithBookcase;
    
        public override void Unload() => ModifySetDefaultsMonolithBookcase -= TranslationModifySetDefaultsMonolithBookcase;
        
        private void TranslationModifySetDefaultsMonolithBookcase(ILContext il) => Translation.ILTranslate(il, "Monolith Bookcase", Translation.EncodeToUtf16("Монолитный книжный шкаф"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithBookcase
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithBookcase").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithBookcase").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
    
    public class ILModifySetDefaultsMonolithCandelabra: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithCandelabra";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithCandelabra += TranslationModifySetDefaultsMonolithCandelabra;
    
        public override void Unload() => ModifySetDefaultsMonolithCandelabra -= TranslationModifySetDefaultsMonolithCandelabra;
        
        private void TranslationModifySetDefaultsMonolithCandelabra(ILContext il) => Translation.ILTranslate(il, "Monolith Candelabra", Translation.EncodeToUtf16("Монолитный канделябр"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithCandelabra
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithCandelabra").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithCandelabra").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsMonolithCandle: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithCandle";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithCandle += TranslationModifySetDefaultsMonolithCandle;
    
        public override void Unload() => ModifySetDefaultsMonolithCandle -= TranslationModifySetDefaultsMonolithCandle;
        
        private void TranslationModifySetDefaultsMonolithCandle(ILContext il) => Translation.ILTranslate(il, "Monolith Candle", Translation.EncodeToUtf16("Монолитная свеча"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithCandle
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithCandle").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithCandle").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsMonolithChair: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithChair";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithChair += TranslationModifySetDefaultsMonolithChair;
    
        public override void Unload() => ModifySetDefaultsMonolithChair -= TranslationModifySetDefaultsMonolithChair;
        
        private void TranslationModifySetDefaultsMonolithChair(ILContext il) => Translation.ILTranslate(il, "Monolith Chair", Translation.EncodeToUtf16("Монолитный стул"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithChair
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithChair").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithChair").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
    
    public class ILModifySetDefaultsMonolithChandelier: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithChandelier";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithChandelier += TranslationModifySetDefaultsMonolithChandelier;
    
        public override void Unload() => ModifySetDefaultsMonolithChandelier -= TranslationModifySetDefaultsMonolithChandelier;
        
        private void TranslationModifySetDefaultsMonolithChandelier(ILContext il) => Translation.ILTranslate(il, "Monolith Chandelier", Translation.EncodeToUtf16("Монолитная люстра"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithChandelier
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithChandelier").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithChandelier").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsMonolithChest: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithChest";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithChest += TranslationModifySetDefaultsMonolithChest;
    
        public override void Unload() => ModifySetDefaultsMonolithChest -= TranslationModifySetDefaultsMonolithChest;
        
        private void TranslationModifySetDefaultsMonolithChest(ILContext il) => Translation.ILTranslate(il, "Monolith Chest", Translation.EncodeToUtf16("Монолитный сундук"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithChest
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithChest").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithChest").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsMonolithClock: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithClock";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithClock += TranslationModifySetDefaultsMonolithClock;
    
        public override void Unload() => ModifySetDefaultsMonolithClock -= TranslationModifySetDefaultsMonolithClock;
        
        private void TranslationModifySetDefaultsMonolithClock(ILContext il) => Translation.ILTranslate(il, "Monolith Clock", Translation.EncodeToUtf16("Монолитные часы"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithClock
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithClock").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithClock").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
    
    public class ILModifySetDefaultsMonolithDoor: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithDoor";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithDoor += TranslationModifySetDefaultsMonolithDoor;
    
        public override void Unload() => ModifySetDefaultsMonolithDoor -= TranslationModifySetDefaultsMonolithDoor;
        
        private void TranslationModifySetDefaultsMonolithDoor(ILContext il) => Translation.ILTranslate(il, "Monolith Door", Translation.EncodeToUtf16("Монолитная дверь"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithDoor
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithDoor").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithDoor").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsMonolithDresser: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithDresser";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithDresser += TranslationModifySetDefaultsMonolithDresser;
    
        public override void Unload() => ModifySetDefaultsMonolithDresser -= TranslationModifySetDefaultsMonolithDresser;
        
        private void TranslationModifySetDefaultsMonolithDresser(ILContext il) => Translation.ILTranslate(il, "Monolith Dresser", Translation.EncodeToUtf16("Монолитный комод"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithDresser
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithDresser").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithDresser").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsMonolithLamp: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithLamp";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithLamp += TranslationModifySetDefaultsMonolithLamp;
    
        public override void Unload() => ModifySetDefaultsMonolithLamp -= TranslationModifySetDefaultsMonolithLamp;
        
        private void TranslationModifySetDefaultsMonolithLamp(ILContext il) => Translation.ILTranslate(il, "Monolith Lamp", Translation.EncodeToUtf16("Монолитная лампа"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithLamp
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithLamp").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithLamp").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
    
    public class ILModifySetDefaultsMonolithPiano: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithPiano";
            
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
        
        public override void Load() => ModifySetDefaultsMonolithPiano += TranslationModifySetDefaultsMonolithPiano;
    
        public override void Unload() => ModifySetDefaultsMonolithPiano -= TranslationModifySetDefaultsMonolithPiano;
    
        private void TranslationModifySetDefaultsMonolithPiano(ILContext il) => Translation.ILTranslate(il, "Monolith Piano", Translation.EncodeToUtf16("Монолитное пианино"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithPiano
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithPiano").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithPiano").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsMonolithLantern: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithLantern";
                
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
            
        public override void Load() => ModifySetDefaultsMonolithLantern += TranslationModifySetDefaultsMonolithLantern;
        
        public override void Unload() => ModifySetDefaultsMonolithLantern -= TranslationModifySetDefaultsMonolithLantern;
        
        private void TranslationModifySetDefaultsMonolithLantern(ILContext il) => Translation.ILTranslate(il, "Monolith Lantern", Translation.EncodeToUtf16("Монолитный фонарь"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithLantern
            {
                add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithLantern").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
                
                remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithLantern").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
            }
    }
        
    public class ILModifySetDefaultsMonolithPlatform: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithPlatform";
                
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
    
        public override void Load() =>
            ModifySetDefaultsMonolithPlatform += TranslationModifySetDefaultsMonolithPlatform;
    
        public override void Unload() =>
            ModifySetDefaultsMonolithPlatform -= TranslationModifySetDefaultsMonolithPlatform;
        
        private void TranslationModifySetDefaultsMonolithPlatform(ILContext il) => Translation.ILTranslate(il, "Monolith Platform", Translation.EncodeToUtf16("Монолитная платформа"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithPlatform
            {
                add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithPlatform").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
                
                remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithPlatform").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
            }
    }
        
    public class ILModifySetDefaultsMonolithSink: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithSink";
                
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
            
        public override void Load() => ModifySetDefaultsMonolithSink += TranslationModifySetDefaultsMonolithSink;
        
        public override void Unload() => ModifySetDefaultsMonolithSink -= TranslationModifySetDefaultsMonolithSink;
        
        private void TranslationModifySetDefaultsMonolithSink(ILContext il) => Translation.ILTranslate(il, "Monolith Sink", Translation.EncodeToUtf16("Монолитная раковина"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithSink
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithSink").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithSink").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsMonolithTable: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithTable";
                
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
            
        public override void Load() => ModifySetDefaultsMonolithTable += TranslationModifySetDefaultsMonolithTable;
        
        public override void Unload() => ModifySetDefaultsMonolithTable -= TranslationModifySetDefaultsMonolithTable;
        
        private void TranslationModifySetDefaultsMonolithTable(ILContext il) => Translation.ILTranslate(il, "Monolith Table", Translation.EncodeToUtf16("Монолитный стол"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithTable
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithTable").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithTable").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifySetDefaultsMonolithWorkBench: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Placeables.FurnitureAstral.MonolithWorkBench";
                    
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
                
        public override void Load() => ModifySetDefaultsMonolithWorkBench += TranslationModifySetDefaultsMonolithWorkBench;
            
        public override void Unload() => ModifySetDefaultsMonolithWorkBench -= TranslationModifySetDefaultsMonolithWorkBench;
        
        private void TranslationModifySetDefaultsMonolithWorkBench(ILContext il) => Translation.ILTranslate(il, "Monolith Work Bench", Translation.EncodeToUtf16("Монолитный верстак"));
        
        private event ILContext.Manipulator ModifySetDefaultsMonolithWorkBench
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithWorkBench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Placeables.FurnitureAstral.MonolithWorkBench").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyTooltipsNanotech: ILEdit
    {
        public override string DictKey => "CalamityMod.Items.Accessories.Nanotech";
                    
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
                
        public override void Load() => ModifyTooltipsNanotech += TranslationModifyTooltipsNanotech;
            
        public override void Unload() => ModifyTooltipsNanotech -= TranslationModifyTooltipsNanotech;
        
        private void TranslationModifyTooltipsNanotech(ILContext il) => Translation.ILTranslate(il, "Tooltip8", Translation.EncodeToUtf16("Tooltip7"));
        
        private event ILContext.Manipulator ModifyTooltipsNanotech
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Accessories.Nanotech").GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.Items.Accessories.Nanotech").GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
        
    public class ILModifyPolterghastNpcGivenName: ILEdit
    {
        public override string DictKey => "CalamityMod.NPCs.Polterghast.Polterghast";
                    
        public override bool Autoload() => CoreCalamityTranslation.Calamity != null;
                
        public override void Load() => ModifyPolterghastNpcGivenName += TranslationModifyPolterghastNpcGivenName;
            
        public override void Unload() => ModifyPolterghastNpcGivenName -= TranslationModifyPolterghastNpcGivenName;
        
        private void TranslationModifyPolterghastNpcGivenName(ILContext il)
        {
            Translation.ILTranslate(il, "Necroghast", Translation.EncodeToUtf16("Некрогаст"));
            Translation.ILTranslate(il, "Necroplasm", Translation.EncodeToUtf16("Некроплазм"));
        }
        
        private event ILContext.Manipulator ModifyPolterghastNpcGivenName
        {
            add => HookEndpointManager.Modify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.Polterghast.Polterghast").GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreCalamityTranslation.Calamity.Code.GetType("CalamityMod.NPCs.Polterghast.Polterghast").GetMethod("AI", BindingFlags.Public | BindingFlags.Instance), value);
        }
    }
}