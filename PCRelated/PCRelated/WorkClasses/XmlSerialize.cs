using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PCRelated.CurrentClasses;

namespace PCRelated.WorkClasses
{
    class XmlSerialize:ISerializable
    {
        public void Serialize(object currentObject, string fileName,FileStream currentFile)
        {
            XmlSerializer xmlFormater = new XmlSerializer(typeof (XmlSerializableClass));
            xmlFormater.Serialize(currentFile,currentObject);
        }

        public object Deserialize(FileStream currentFile)
        {
            XmlSerializer xmlFormater = new XmlSerializer(typeof(XmlSerializableClass));
            XmlSerializableClass returnedObject = (XmlSerializableClass) xmlFormater.Deserialize(currentFile);
            return returnedObject;
        }
    }
}
