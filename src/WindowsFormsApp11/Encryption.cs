using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsApp11
{
    class Encryption
    {
        static byte[] Key;
        static byte[] IV;

        public static byte[] RC2Encrypt(byte[] Input, int InputOffset, long InputLength)
        {   
            RC2CryptoServiceProvider RC2 = new RC2CryptoServiceProvider();
            ICryptoTransform Crypto = RC2.CreateEncryptor(Key, IV);
            byte[] Output = Crypto.TransformFinalBlock(Input, InputOffset, (int)InputLength);

            return Output;
        }

        public static bool GenerateKey(string Password)
        {
            byte[] Hash;
            Key = new byte[16];
            IV = new byte[16];
            SHA256CryptoServiceProvider SHA256 = new SHA256CryptoServiceProvider();
            byte[] PassByte = Encoding.Default.GetBytes(Password);

            Hash = SHA256.ComputeHash(PassByte);

            Array.Copy(Hash, Key, 16);
            Array.Copy(Hash, 16, IV, 0, 16);

            return true;
        }

        public static byte[] RC2Decrypt(byte[] Input, int InputOffset, long InputLength)
        {
            byte[] Output = null;
            RC2CryptoServiceProvider RC2 = new RC2CryptoServiceProvider();
            ICryptoTransform Crypto = RC2.CreateDecryptor(Key, IV);

            try
            {
                Output = Crypto.TransformFinalBlock(Input, InputOffset, (int)InputLength);
            }
            catch
            {

            }
            return Output;
        }


    }
}
