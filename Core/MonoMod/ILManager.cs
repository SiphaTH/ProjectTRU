using System;
using System.Collections.Generic;

namespace CalamityRuTranslate.Core.MonoMod
{
    public class ILManager : ILoadable
    {
        private List<ILEdit> _ilEdits;

        public float Priority => 1f;

        public void Load()
        {
            _ilEdits = new List<ILEdit>();

            foreach (Type type in CalamityRuTranslate.Instance.Code.GetTypes())
            {
                if (type.IsAbstract || type.GetConstructor(new Type[] { }) == null)
                    continue;

                if (!type.IsSubclassOf(typeof(ILEdit)))
                    continue;

                if (Activator.CreateInstance(type) is ILEdit ilEdit && ilEdit.Autoload())
                    _ilEdits.Add(ilEdit);
            }

            foreach (ILEdit ilEdit in _ilEdits)
                ilEdit.Load();
        }

        public void Unload()
        {
            if(_ilEdits != null)
                foreach (ILEdit ilEdit in _ilEdits)
                    ilEdit.Unload();

            _ilEdits = null;
        }
    }
}