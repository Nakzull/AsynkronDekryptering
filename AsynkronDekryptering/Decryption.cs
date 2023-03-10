using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AsynkronDekryptering
{
    internal class Decryption
    {

        const string ContainerName = "MyContainer";
        public RSAParameters AssignNewKey()
        {
            CspParameters parameters = new CspParameters(1);
            parameters.KeyContainerName = ContainerName;
            parameters.Flags = CspProviderFlags.UseMachineKeyStore;
            parameters.ProviderName = "Microsoft Strong Cryptographic Provider";

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider { PersistKeyInCsp = true };
            RSAParameters publicKey = rsa.ExportParameters(false);
            return publicKey;
        }

        public string HexPrint(byte[] text)
        {
            var hexString = BitConverter.ToString(text);
            return hexString;
        }

        public byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }

        public byte[] Decrypt(byte[] dataToDecrypt)
        {
            byte[] plain;

            CspParameters parameters = new CspParameters { KeyContainerName = ContainerName };

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048, parameters);

            plain = rsa.Decrypt(dataToDecrypt, false);

            return plain;
        }
    }
}
