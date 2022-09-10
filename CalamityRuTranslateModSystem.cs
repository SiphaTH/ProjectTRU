using System;
using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Core;
using CalamityRuTranslate.Core.MonoMod;
using Terraria.ModLoader;
using Terraria.UI;

namespace CalamityRuTranslate;

public class CalamityRuTranslateModSystem : ModSystem
{
    private List<IContentTranslation> _contents;
    
    public override void Load()
    {
        _contents = new List<IContentTranslation>();

        foreach (Type type in CalamityRuTranslate.Instance.Code.GetTypes())
        {
            if (type.IsSubclassOf(typeof(ContentTranslation)) && Activator.CreateInstance(type) is ContentTranslation contentTranslation)
            {
                _contents.Add(contentTranslation);
            }
        }
    }
    
    public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
    {
        foreach (IContentTranslation content in _contents.Where(content => content.IsTranslationEnabled))
        {
            content.LoadTranslation();
        }
    }
}