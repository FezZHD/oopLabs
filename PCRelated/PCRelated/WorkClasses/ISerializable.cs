using System.IO;

namespace PCRelated.WorkClasses
{
    public interface ISerializable
    {
        void Serialize(object currentObject, string fileName = null, FileStream currentFile = null);
        object Deserialize(FileStream currentFile);
    }
}
