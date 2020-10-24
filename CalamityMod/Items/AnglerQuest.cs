using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Items
{
	public class AnglerQuest : GlobalItem
	{
		public override void AnglerChat(int type, ref string chat, ref string catchLocation)
		{
			Mod calamity = ModLoader.GetMod("CalamityMod");
			
			if (calamity != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				if (CalamityRuTranslate.TRuConfig.CalamityTranslation)
				{
					if (type == calamity.ItemType("EutrophicSandfish"))
					{
						chat = "Вы когда-нибудь видели, что произойдёт, если ящерица, жившая в пустыне, заберётся слишком глубоко под землю? Я видел, и они выглядят реально круто! Правда, они слишком скользкие, чтобы я мог держать их в своих руках. Пойди и получи его, чтобы я мог держать его как домашнее животное!";
						catchLocation = "Поймать в Затерянном море";
					}

					if (type == calamity.ItemType("Serpentuna"))
					{
						chat = "Морские змеи милые, но не такие милые, как лицо того, кто найдёт их в своём кресле. Мне нужно, чтобы ты принёс мне реквизит для моего следующего страшного пранка, и крайний срок — завтра.";
						catchLocation = "Поймать в Затерянном море";
					}

					if (type == calamity.ItemType("SurfClam"))
					{
						chat = "Вы знали, что моллюски — это деликатес? Ходят слухи, что под пустыней живёт большая колония. Просто разговор о них пробуждает мой голод. Мне нужно, чтобы ты принёс одного для меня, чтобы я мог практиковать свои кулинарные навыки и обуздать свой голод.";
						catchLocation = "Поймать в Затерянном море";
					}

					if (type == calamity.ItemType("Brimlish"))
					{
						chat = "Когда ты победил древнюю богиню, её дети упали в лаву. Ходят слухи, что из-за этого мутировала местная рыба, и я буду очень рад, если ты принесёшь одну для моего нового лавового аквариума.";
						catchLocation = "Поймать в Серной скале";
					}

					if (type == calamity.ItemType("Slurpfish"))
					{
						chat = "Знаешь, это было бы абсолютным бедствием, если бы я отправил тебя в древние руины в глубине ада ловить рыбу. И я планирую сделать именно это. А теперь проваливай! Рыба сама себя не поймает.";
						catchLocation = "Поймать в Серной скале";
					}
				}
			}
		}
	}
}
