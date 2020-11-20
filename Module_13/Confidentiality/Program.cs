using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Confidentiality
{
    class Program
    {
        static void Main(string[] args)
        {
            //Symmetrische();
            //Asymmetrische();
            Certificates();
        }

        private static void Certificates()
        {
            X509Store store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);
            foreach (X509Certificate2 cert in store.Certificates)
            {
                Console.WriteLine(cert.Subject);
                RSA rsa = cert.PrivateKey as RSA;

                RSA rsaOnt =  cert.PublicKey.Key as RSA;
                //rsa.Decrypt
            }
            store.Dispose();
        }

        private static void Symmetrische()
        {
            // Versturende partij
            string message = "Hello World";
            AesManaged alg = new AesManaged();
            alg.Mode = CipherMode.CBC;  // Default
            byte[] key = alg.Key;
            byte[] iv = alg.IV;
            ICryptoTransform ct = alg.CreateEncryptor();
            byte[] data;

            using (MemoryStream mem = new MemoryStream())
            {
                using (CryptoStream crypt = new CryptoStream(mem, ct, CryptoStreamMode.Write))
                {
                    using (StreamWriter writer = new StreamWriter(crypt))
                    {
                        writer.WriteLine(message);
                    }
                }
                data = mem.ToArray();
                //Console.WriteLine(Encoding.UTF8.GetString(data));
            }

            // Ontvangende partij
            AesManaged ontvanger = new AesManaged();
            ontvanger.Mode = CipherMode.CBC;
            ontvanger.Key = key;
            ontvanger.IV = iv;
            ICryptoTransform ct2 = ontvanger.CreateDecryptor();

            using(MemoryStream mem = new MemoryStream(data))
            {
                using(CryptoStream crypt = new CryptoStream(mem, ct2, CryptoStreamMode.Read))
                {
                    using(StreamReader reader = new StreamReader(crypt))
                    {
                        string line = reader.ReadToEnd();
                        Console.WriteLine(line);
                    }
                }
            }


        }

        private static void Asymmetrische()
        {
            // Ontvanger regelt public en private key paar
            RSACryptoServiceProvider tmp = new RSACryptoServiceProvider();
            string privateKey = tmp.ToXmlString(true);
            string publicKey = tmp.ToXmlString(false);

            // Versturende partij
            string message = "Hello World";
            RSACryptoServiceProvider sender = new RSACryptoServiceProvider();
            sender.FromXmlString(publicKey);
            byte[] cipher = sender.Encrypt(Encoding.UTF8.GetBytes(message), true);

            // Ontvangende partij
            RSACryptoServiceProvider ontvanger = new RSACryptoServiceProvider();
            ontvanger.FromXmlString(privateKey);
            byte[] data = ontvanger.Decrypt(cipher, true);
            Console.WriteLine(Encoding.UTF8.GetString(data));

        }
    }
}
