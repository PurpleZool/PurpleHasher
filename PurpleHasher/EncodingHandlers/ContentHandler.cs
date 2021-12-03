using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PurpleHasher.EncodingHandlers
{
    public class ContentHandler
    {

        private byte[] rawData;



        public ContentHandler()
        {

        }


        #region EncodingDecoding


        public string RawToASCII(byte[] rawData)
        {
            ASCIIEncoding asciiEnc = new ASCIIEncoding();
            return asciiEnc.GetString(rawData);
        }

        public byte[] ASCIIToRaw(string asciiStr)
        {
            ASCIIEncoding asciiEnc = new ASCIIEncoding();
            return asciiEnc.GetBytes(asciiStr);
        }
        public string RawToUTF8(byte[] rawData)
        {
            UTF8Encoding utf8Enc = new UTF8Encoding();
            return utf8Enc.GetString(rawData);
        }

        public byte[] UTF8ToRaw(string utf8Str)
        {
            UTF8Encoding utf8Enc = new UTF8Encoding();
            return utf8Enc.GetBytes(utf8Str);
        }
        public string RawToUnicode(byte[] rawData)
        {
            UnicodeEncoding unicodeEnd = new UnicodeEncoding();
            return unicodeEnd.GetString(rawData);
        }

        public byte[] UnicodeToRaw(string unicodeStr)
        {
            UnicodeEncoding unicodeEnd = new UnicodeEncoding();
            return unicodeEnd.GetBytes(unicodeStr);
        }

        public byte[] FileToRaw(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllBytes(filePath);
            }
            return new byte[] { };
        }

        public string RawToHEX(byte[] rawData)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < rawData.Length; i++)
            {
                sb.Append(rawData[i].ToString("X2") + " ");
            }
            return sb.ToString();
        }


        #endregion

        #region HASHERS
        public byte[] MD5Hash(byte[] rawData)
        {
            MD5 md5 =  MD5.Create();
            return md5.ComputeHash(rawData);
        }

        public byte[] SHA256Hash(byte[] rawData)
        {
             SHA =  MD5.Create();
            return md5.ComputeHash(rawData);
        }

        public byte[] MD5Hash(byte[] rawData)
        {
            MD5 md5 =  MD5.Create();
            return md5.ComputeHash(rawData);
        }



        #endregion

    }
}
