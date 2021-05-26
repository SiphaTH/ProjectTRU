using System;
using System.Collections;
using System.Collections.Generic;
using CalamityRuTranslate.Common;

namespace CalamityRuTranslate
{
    public partial class CalamityRuTranslate
    {
        private List<ILoadable> _loadCache;

        private void LoadCache()
        {
            _loadCache = new List<ILoadable>();

            foreach (Type type in Code.GetTypes())
            {
                if (!type.IsAbstract && ((IList) type.GetInterfaces()).Contains(typeof(ILoadable)))
                {
                    var instance = Activator.CreateInstance(type);
                    _loadCache.Add(instance as ILoadable);
                }

                _loadCache.Sort((n, t) => n.Priority > t.Priority ? 1 : -1);
            }

            foreach (var cache in _loadCache)
            {
                cache.Load();
            }
        }

        private void UnloadCache()
        {
            if (_loadCache != null)
                foreach (var cache in _loadCache)
                    cache.Unload();

            _loadCache = null;
        }
    }
}