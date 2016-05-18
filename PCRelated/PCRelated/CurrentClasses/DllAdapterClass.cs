using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCRelated.WorkClasses;

namespace PCRelated.CurrentClasses
{
    class DllAdapterClass:DllClass
    {

        private string _methodName;

        public DllAdapterClass(FileDialog dialog,  ComboBox dllBox, ComboBox serializableBox, List<DllList> list ,string name) : base(dialog, dllBox, serializableBox ,list)
        {
            _methodName = name;
        }

        public override void DoDll()
        {
            try
            {
                Assembly newDll = Assembly.LoadFrom(DllList[DllBox.SelectedIndex].DllPath);
                Object currentObject = newDll.CreateInstance(DllBox.Text + '.' + DllBox.Text);
                Type dllType = newDll.GetType(DllBox.Text + '.' + DllBox.Text);
                Object[] methodParammetrs = new object[2];
                methodParammetrs[0] = FileDialog.FileName;
                methodParammetrs[1] = SerializableBox.SelectedIndex;
                MethodInfo getMethod = dllType.GetMethod(_methodName);
                getMethod.Invoke(currentObject, methodParammetrs);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Ошибка при добавлении или при работе модуля");
                return;
            }
        }
    }
}
