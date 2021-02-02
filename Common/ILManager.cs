using System;
using System.Collections.Generic;

namespace CalamityRuTranslate.Common
{
    public class ILManager
    {
        public static Dictionary<string, ILEdit> ILEdits;
        public static Dictionary<string, ILEdit2> ILEdits2;
        public static Dictionary<string, ILEdit3> ILEdits3;

        public static void Load()
        {
            ILEdits = new Dictionary<string, ILEdit>();
            ILEdits2 = new Dictionary<string, ILEdit2>();
            ILEdits3 = new Dictionary<string, ILEdit3>();

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
                    
                    if (type.IsSubclassOf(typeof(ILEdit2)))
                    {
                        ILEdit2 ilEdit2 = Activator.CreateInstance(type) as ILEdit2;

                        if (ilEdit2.Autoload())
                        {
                            ILEdits2.Add(ilEdit2.DictKey, ilEdit2);
                        }
                    }
                    
                    if (type.IsSubclassOf(typeof(ILEdit3)))
                    {
                        ILEdit3 ilEdit3 = Activator.CreateInstance(type) as ILEdit3;

                        if (ilEdit3.Autoload())
                        {
                            ILEdits3.Add(ilEdit3.DictKey, ilEdit3);
                        }
                    }
                }
            }
            
            foreach (ILEdit ilEdit in ILEdits.Values)
            {
                ilEdit.Load();
            }
            
            foreach (ILEdit2 ilEdit2 in ILEdits2.Values)
            {
                ilEdit2.Load();
            }
            
            foreach (ILEdit3 ilEdit3 in ILEdits3.Values)
            {
                ilEdit3.Load();
            }
        }

        public static void Unload()
        {
            foreach (ILEdit ilEdit in ILEdits.Values)
            {
                ilEdit.Unload();
            }
            
            foreach (ILEdit2 ilEdit2 in ILEdits2.Values)
            {
                ilEdit2.Unload();
            }
            
            foreach (ILEdit3 ilEdit3 in ILEdits3.Values)
            {
                ilEdit3.Unload();
            }

            ILEdits = null;
            ILEdits2 = null;
            ILEdits3 = null;
        }
    }
}