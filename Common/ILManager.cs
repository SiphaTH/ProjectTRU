using System;
using System.Collections.Generic;

namespace CalamityRuTranslate.Common
{
    // Original Code https://github.com/Steviegt6/CataclysmMod
    public static class ILManager
    {
        private static List<ILEdit> _ilEdits;

        public static void Load()
        {
            _ilEdits = new List<ILEdit>();

            foreach (Type type in CalamityRuTranslate.Instance.Code.GetTypes())
            {
                if (type.IsAbstract || type.GetConstructor(new Type[] { }) == null)
                    continue;

                if (!type.IsSubclassOf(typeof(ILEdit)))
                    continue;

                if(Activator.CreateInstance(type) is ILEdit ilEdit && ilEdit.Autoload())
                    _ilEdits.Add(ilEdit);
            }

            foreach (ILEdit ilEdit in _ilEdits)
                ilEdit.Load();
        }

        public static void Unload()
        {
            if(_ilEdits != null)
                foreach (ILEdit ilEdit in _ilEdits)
                    ilEdit.Unload();

            _ilEdits = null;
        }
    }
}