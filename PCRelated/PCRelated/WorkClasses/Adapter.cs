using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRelated.WorkClasses
{
    public class Adapter : ISerializable
    {
        XmlSerialize serializer = new XmlSerialize();
        private PluginInterface.IPlugin plugin;

        public Adapter(PluginInterface.IPlugin plugin)
        {
            this.plugin = plugin;
        }

        public object Deserialize(FileStream currentFile)
        {
            string path = currentFile.Name;
            plugin.Decrypt(path, 0);
            currentFile.Close();
            path = Path.ChangeExtension(path, null);
            object obj = serializer.Deserialize(new FileStream(path, FileMode.Open));
            return obj;
        }

        public void Serialize(object currentObject, string fileName = null, FileStream currentFile = null)
        {
            serializer.Serialize(currentObject, fileName,currentFile);
            currentFile.Close();
            plugin.Crypt(fileName,0);
        }
    }
}
