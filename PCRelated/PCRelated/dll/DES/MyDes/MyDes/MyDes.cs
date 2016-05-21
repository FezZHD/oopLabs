using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PCRelated.WorkClasses;

namespace MyDes
{
    public class MyDes:IDll
    {
        private byte[] _key;
        private byte[] _IV;

        private void InitializationKey()
        {
            _key = new byte[24];
            _IV = new byte[8];
            for (int i = 0; i < 24; i++)
            {
                _key[i] = (byte) i;
                if (i < 8)
                {
                    _IV[i] = (byte) i;
                }
            }
        }

        public void Crypt(string path, int serializationType)
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
            using (TripleDESCryptoServiceProvider myDes = new TripleDESCryptoServiceProvider())
            {
                myDes.Key = _key;
                myDes.IV = _IV;

                ICryptoTransform encryptor = myDes.CreateEncryptor(myDes.Key, myDes.IV);
                var encrypt = new CryptoStream(stream, encryptor, CryptoStreamMode.Write);
                encrypt.Write(fileBytes, 0, fileBytes.Length);
                encrypt.FlushFinalBlock();
            }

            FileStream cryptedFile = new FileStream(path + (".descrypt"), FileMode.OpenOrCreate, FileAccess.Write);
            cryptedFile.Write(stream.ToArray(), 0, stream.ToArray().Length);
            cryptedFile.Close();
            stream.Close();
        }


        public void Decrypt(string path, int serializableType)
        {
            InitializationKey();
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] bytesFile = new byte[file.Length];
            file.Read(bytesFile, 0, bytesFile.Length);
            file.Close();
            MemoryStream stream;
            stream = new MemoryStream();
            using (TripleDESCryptoServiceProvider myDes = new TripleDESCryptoServiceProvider())
            {
                myDes.Key = _key;
                myDes.IV = _IV;

                ICryptoTransform decryptor = myDes.CreateDecryptor(myDes.Key, myDes.IV);
                var decrypt = new CryptoStream(stream, decryptor, CryptoStreamMode.Write);
                decrypt.Write(bytesFile, 0, bytesFile.Length);
                decrypt.FlushFinalBlock();

            }
            FileStream newFile = new FileStream(path.Remove(path.Length - 9), FileMode.Create, FileAccess.Write);
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
