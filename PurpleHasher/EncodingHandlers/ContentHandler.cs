using PurpleHasher.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PurpleHasher.EncodingHandlers
{
    /// <summary>
    /// Main object able to read any string or file , hash it and transform it to string again
    /// </summary>
    public class ContentHandler
    {

        private byte[] rawData;
        private byte[] hashedData;


        #region CTORs
        public ContentHandler()
        {

        }
        public ContentHandler(byte[] rawData)
        {
            this.rawData = rawData;
        }
        #endregion

        #region MAIN_METHODS

        /// <summary>
        /// Reads a file filling its raw data with the File's data.
        /// </summary>
        /// <param name="filePath">File's path to read</param>
        public void ReadFile(string filePath) 
        {
            using (Stream str = File.OpenRead(filePath))
            {
                using (BinaryReader br = new BinaryReader(str, Encoding.Default))
                {
                    rawData = br.ReadBytes((int)str.Length);
                }
            }                    
        }

        /// <summary>
        /// Transform desired string specifying the coding to use.
        /// </summary>
        /// <param name="str">String to decode</param>
        /// <param name="coding">Coding type of string</param>
        public void ReadString(string str, Codings coding) 
        {
            switch (coding)
            { 
                case Codings.RAW:
                    rawData = RawToRaw(str);
                    break;
                case Codings.ASCII:
                    rawData = ASCIIToRaw(str);
                    break;
                case Codings.UTF8:
                    rawData = UTF8ToRaw(str);
                    break;
                case Codings.UTF16:
                    rawData = UnicodeToRaw(str);
                    break;
            }
        }


        /// <summary>
        /// Fills the hashedData with the Hash of the rawData specifying the has to use.
        /// </summary>
        /// <param name="hash">Hash to compute</param>
        public void HashTo(Hashings hash) 
        {
            switch (hash) 
            {
                case Hashings.MD5:
                    RawToMD5();
                    break;
            
                case Hashings.SHA256:
                    RawToSHA256();
                    break;
            
                case Hashings.SHA512:
                    RawToSHA512();
                    break;

                default:
                    // No hay default :: Esto es un reloj
                    break;
            } 
        }

        /// <summary>
        /// Retrieves the string from hashedData depending on coding used.
        /// </summary>
        /// <param name="coding"></param>
        /// <returns></returns>
        public string GetHashedString(Codings coding) 
        {
            switch (coding) 
            {
                case Codings.RAW:
                    return HashedToHEX();
                case Codings.ASCII:
                    return HashedToASCII();
                case Codings.UTF8:
                    return HashedToUTF8();
                case Codings.UTF16:
                    return HashedToUnicode();
                case Codings.NUM:
                    return HashedToInt();
                default:
                    // No hay default :: Esto es un reloj
                    return string.Empty;
            }
        }

        /// <summary>
        /// Retrieves the string from rawData depending on coding used.
        /// </summary>
        /// <param name="representation">Type of byte representation</param>
        /// <returns></returns>
        public string GetRawString(ByteRep representation) 
        {
            switch (representation) 
            {
                case ByteRep.HEX:
                    return RawToHEX();
                case ByteRep.NUM:
                    return RawToInt();
                default:
                    // No hay default :: Esto es un reloj , por si no ha quedado claro
                    return string.Empty;
            }
        }

        #endregion

        #region TRANSFORMATIONS
        public void RawToMD5() 
        {
            hashedData = MD5Hash(rawData);
        }
        public void RawToSHA256() 
        {
            hashedData = SHA256Hash(rawData);
        }
        public void RawToSHA512() 
        {
            hashedData = SHA512Hash(rawData);
        }

        public string RawToHEX() 
        {
            return RawToHEX(this.rawData);
        }

        public string RawToInt() 
        {
            return RawToInt(this.rawData);
        }

        public string HashedToInt() 
        {
            return RawToInt(this.hashedData);
        }


        public string HashedToHEX() 
        {
            return RawToHEX(this.hashedData);
        }

        public string HashedToASCII() 
        {
            return RawToASCII(hashedData);
        }

        public string HashedToUTF8() 
        {
            return RawToUTF8(hashedData);
        }
        public string HashedToUnicode() 
        {
            return RawToUnicode(hashedData);
        }
        public byte[] RawToRaw(string hex)
        {
            hex = String.Concat(hex.Where(c => !Char.IsWhiteSpace(c)));
            return Enumerable.Range(0, hex.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                     .ToArray();
        }

        #endregion

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
            return Encoding.UTF8.GetString(rawData);
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


        public string RawToInt(byte[] rawData) 
        {
            return String.Join(" ", rawData.ToList());
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
             SHA256 sha256 =  SHA256.Create();
            return sha256.ComputeHash(rawData);
        }

        public byte[] SHA512Hash(byte[] rawData)
        {
            SHA512 sha512 = SHA512.Create();
            return sha512.ComputeHash(rawData);
        }



        #endregion

    }
}
