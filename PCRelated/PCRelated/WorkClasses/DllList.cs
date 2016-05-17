using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRelated.WorkClasses
{
    class DllList
    {
        public string DllPath;
        public string DllName;


        public DllList(string path, string name)
        {
            DllPath = path;
            DllName = name;
        }
    }
}
