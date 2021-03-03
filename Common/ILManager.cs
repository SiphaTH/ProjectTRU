using System;
using System.Collections.Generic;

namespace CalamityRuTranslate.Common
{
    public class ILManager
    {
        public static List<ILEdit> ILEdits;

        public static void Load()
        {
            ILEdits = new List<ILEdit>();

            foreach (Type type in CalamityRuTranslate.Instance.Code.GetTypes())
            {
                if (!type.IsAbstract && type.GetConstructor(new Type[] { }) != null)
                {
                    if (type.IsSubclassOf(typeof(ILEdit)))
                    {
                        ILEdit ilEdit = Activator.CreateInstance(type) as ILEdit;

                        if (ilEdit.Autoload())
                            ILEdits.Add(ilEdit);
                    }
                }
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