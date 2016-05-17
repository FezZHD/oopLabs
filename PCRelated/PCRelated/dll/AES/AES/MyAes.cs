﻿using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MyAes
{
    public class MyAes
    {
      
        public void Crypt(string path , int serializationType)
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] fileBytes = new byte[file.Length];
            switch (serializationType)
            {
                case 1:
                {
                    BinaryReader fileReader = new BinaryReader(file, Encoding.Default);
                    fileReader.Read(fileBytes, 0, fileBytes.Length);
                    fileReader.Close();

                    break;
                }
                default:
                {
                    StreamReader textFileReader = new StreamReader(file, Encoding.Default);
                    string fileString = textFileReader.ReadToEnd();
                    textFileReader.Close();
                    fileBytes = Encoding.Default.GetBytes(fileString);
                    break;
                }


            }
            file.Close();
            MemoryStream stream;
            using (Aes currentAes = Aes.Create())
            {
                currentAes.Key = new byte[] {0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F};
                using (Aes myAes = Aes.Create())
                {
                    myAes.Key = currentAes.Key;
                    myAes.IV = currentAes.IV;

                    stream = new MemoryStream();
                    ICryptoTransform encryptor = myAes.CreateEncryptor(myAes.Key, myAes.IV);
                    using (var encrypt = new CryptoStream(stream, encryptor, CryptoStreamMode.Write))
                    {
                        encrypt.Write(fileBytes, 0, fileBytes.Length);
                        encrypt.FlushFinalBlock();
                    }
                }

            }
            FileStream cryptedFile = new FileStream(path + (".aescrypt"), FileMode.OpenOrCreate, FileAccess.Write);
            cryptedFile.Write(stream.ToArray(), 0, stream.ToArray().Length);
            cryptedFile.Close();
            stream.Close();
        }


        public void Decrypt(string path , int serializableType)
        {
            FileStream file = new FileStream(path,FileMode.Open, FileAccess.Read);
            byte[] bytesFile = new byte[file.Length];
            file.Read(bytesFile, 0, bytesFile.Length);
            file.Close();
            MemoryStream stream;
            using (Aes currentAes = Aes.Create())
            {
                currentAes.Key = new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F }; 
                using (Aes myAes = Aes.Create())
                {
                    myAes.Key = currentAes.Key;
                    myAes.IV = currentAes.IV;
                    stream = new MemoryStream();
                    ICryptoTransform decryptor = myAes.CreateDecryptor(myAes.Key, myAes.IV);
                    using (var decrypt = new CryptoStream(stream, decryptor, CryptoStreamMode.Write))
                    {
                        decrypt.Write(bytesFile, 0 ,bytesFile.Length);
                        decrypt.FlushFinalBlock();
                    }

                }
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
                    string newString = Encoding.Default.GetString(stream.ToArray());
                    streamWriter.WriteLine(newString);
                    streamWriter.Close();
                    break;
                }
            }
           
           
            
            stream.Close();
        }
    }
}

                   