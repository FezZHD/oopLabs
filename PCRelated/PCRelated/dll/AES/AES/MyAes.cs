using System.IO;
using System.Security.Cryptography;
using System.Text;
using PCRelated.WorkClasses;

namespace MyAes
{
    public class MyAes:IDll
    {
        private byte[] _key;
        private byte[] _IV;
      
        private void InitializationKey()
        {
            _key = new byte[32];
            _IV= new byte[16];
            for (int i = 0; i < 32; i++)
            {
                _key[i] = (byte)i;
                if (i < 16)
                {
                    _IV[i] = (byte)i;
                }
            }
        }


        public void Crypt(string path , int serializationType)
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] fileBytes = new byte[file.Length];
            switch (serializationType)
            {
                case 1:
                {
                    BinaryReader fileReader = new BinaryReader(file, Encoding.ASCII);
                    fileReader.Read(fileBytes, 0, fileBytes.Length);
                    fileReader.Close();

                    break;
                }
                default:
                {
                    StreamReader textFileReader = new StreamReader(file, Encoding.ASCII);
                    string fileString = textFileReader.ReadToEnd();
                    int a = fileString.Length;
                    textFileReader.Close();
                    ASCIIEncoding stringAsciiEncoding = new ASCIIEncoding();
                    fileBytes = stringAsciiEncoding.GetBytes(fileString);
                    break;
                }

            }
            file.Close();
            MemoryStream stream;
            stream = new MemoryStream();
            InitializationKey();
                using (Aes myAes = Aes.Create())
                {
                    myAes.Key = _key;
                    myAes.IV = _IV;

                    ICryptoTransform encryptor = myAes.CreateEncryptor(myAes.Key, myAes.IV);
                    var encrypt = new CryptoStream(stream, encryptor, CryptoStreamMode.Write);
                        encrypt.Write(fileBytes, 0, fileBytes.Length);
                        encrypt.FlushFinalBlock();
                }

            FileStream cryptedFile = new FileStream(path + (".aescrypt"), FileMode.OpenOrCreate, FileAccess.Write);
            cryptedFile.Write(stream.ToArray(), 0, stream.ToArray().Length);
            cryptedFile.Close();
            stream.Close();
        }



        public void Decrypt(string path , int serializableType)
        {
            InitializationKey();
            FileStream file = new FileStream(path,FileMode.Open, FileAccess.Read);
            byte[] bytesFile = new byte[file.Length];
            file.Read(bytesFile, 0, bytesFile.Length);
            file.Close();
            MemoryStream stream;
            stream = new MemoryStream();
            using (Aes myAes = Aes.Create())
            {
                myAes.Key = _key;
                myAes.IV = _IV;

                ICryptoTransform decryptor = myAes.CreateDecryptor(myAes.Key, myAes.IV);
                var decrypt = new CryptoStream(stream, decryptor, CryptoStreamMode.Write);
                decrypt.Write(bytesFile, 0, bytesFile.Length);
                decrypt.FlushFinalBlock();

            }
            FileStream newFile = new FileStream(path.Remove(path.Length - 9),FileMode.Create,FileAccess.Write);
            switch (serializableType)
            {
                case 1:
                { 
                    newFile.Write(stream.ToArray(), 0, stream.ToArray().Length);
                    newFile.Close();
                    break;
                }
                default:
                {
                    newFile.Close();
                    FileInfo currentFileInfo = new FileInfo(newFile.Name);
                    StreamWriter streamWriter = currentFileInfo.CreateText();
                    ASCIIEncoding stringAsciiEncoding = new ASCIIEncoding();
                    string newString = stringAsciiEncoding.GetString(stream.ToArray());
                    streamWriter.WriteLine(newString);
                    streamWriter.Close();
                    break;
                }
            }   
            stream.Close();
        }
    }
}

                   
