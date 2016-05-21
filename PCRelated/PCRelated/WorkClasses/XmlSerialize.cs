using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PCRelated.CurrentClasses;

namespace PCRelated.WorkClasses
{
    class XmlSerialize:ISerializable
    {
        public void Serialize(object currentObject, string fileName,FileStream currentFile)
        {
            XmlSerializer xmlFormater = new XmlSerializer(typeof (List<RelatedCommon>));
            xmlFormater.Serialize(currentFile,currentObject);
        }

        public object Deserialize(FileStream currentFile)
        {
            XmlSerializer xmlFormater = new XmlSerializer(typeof(List<RelatedCommon>));
            List<RelatedCommon> returnedObject = (List<RelatedCommon>) xmlFormater.Deserialize(currentFile);
            return returnedObject;
        }
    }
}
