using System;
using System.Collections.Generic;

namespace CalamityRuTranslate.Common
{
    // Original Code https://github.com/Steviegt6/CataclysmMod
    public static class ILManager
    {
        private static List<ILEdit> ILEdits;

        public static void Load()
        {
            ILEdits = new List<ILEdit>();

            foreach (Type type in CalamityRuTranslate.Instance.Code.GetTypes())
            {
                if (type.IsAbstract && type.GetConstructor(new Type[] { }) != null)
                    continue;
                
                if (!type.IsSubclassOf(typeof(ILEdit)))
                    continue;
                
                if(Activator.CreateInstance(type) is ILEdit ilEdit && ilEdit.Autoload())
                    ILEdits.Add(ilEdit);
            }
            
            foreach (ILEdit ilEdit in ILEdits)
                ilEdit.Load();
        }

        public static void Unload()
        {
            foreach (ILEdit ilEdit in ILEdits)
                ilEdit.Unload();

            ILEdits = null;
        }
    }
}