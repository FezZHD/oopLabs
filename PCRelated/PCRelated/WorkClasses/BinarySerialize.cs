using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using PCRelated.CurrentClasses;

namespace PCRelated.WorkClasses
{
    class BinarySerialize:ISerializable
    {
        public void Serialize(object currentObject,string fileName, FileStream currentFile)
        {
            BinaryFormatter binaryFormater = new BinaryFormatter();
            binaryFormater.Serialize(currentFile,currentObject);
        }

        public object Deserialize(FileStream currentFile)
        {
            BinaryFormatter binaryFormater = new BinaryFormatter();
            Object returnedItem = (List<RelatedCommon>) binaryFormater.Deserialize(currentFile);
            return returnedItem;
        }
    }
}
