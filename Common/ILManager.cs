using System;
using System.Collections.Generic;

namespace CalamityRuTranslate.Common
{
    public class ILManager
    {
        public static Dictionary<string, ILEdit> ILEdits;

        public static void Load()
        {
            ILEdits = new Dictionary<string, ILEdit>();

            foreach (Type type in CalamityRuTranslate.Instance.Code.GetTypes())
            {
                if (!type.IsAbstract && type.GetConstructor(new Type[] { }) != null)
                {
                    if (type.IsSubclassOf(typeof(ILEdit)))
                    {
                        ILEdit ilEdit = Activator.CreateInstance(type) as ILEdit;

                        if (ilEdit.Autoload())
                        {
                            ILEdits.Add(ilEdit.DictKey, ilEdit);
                        }
                    }
                }
            }
            
            foreach (ILEdit ilEdit in ILEdits.Values)
            {
                ilEdit.Load();
            }
        }

        public static void Unload()
        {
            foreach (ILEdit ilEdit in ILEdits.Values)
            {
                ilEdit.Unload();
            }

            ILEdits = null;
        }
    }
}