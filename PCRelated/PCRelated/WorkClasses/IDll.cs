using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRelated.WorkClasses
{
    interface IDll
    {
        void InitializationKey();
        void Crypt(string path, int serializationType);
        void Decrypt(string path, int serializableType);
    }
}
