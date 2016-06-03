using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlugin
{
    public interface IPlugin
    {
        void Crypt(string path, int serializationType);
        void Decrypt(string path, int serializationType);
    }
}
