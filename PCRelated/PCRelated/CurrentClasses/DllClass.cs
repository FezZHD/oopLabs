using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCRelated.WorkClasses;

namespace PCRelated.CurrentClasses
{
    class DllClass
    {
        protected FileDialog FileDialog;
        protected ComboBox DllBox;
        protected ComboBox SerializableBox;
        protected List<DllList> DllList; 


        protected DllClass(FileDialog dialog, ComboBox dllBox, ComboBox serializableBox, List<DllList> list)
        {
            FileDialog = dialog;
            DllBox = dllBox;
            SerializableBox = serializableBox;
            DllList = list;
        }

        public virtual void DoDll()
        {
            
        }

    }
}
