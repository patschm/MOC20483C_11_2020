using System;
using System.Security.Cryptography;
using System.Text;

namespace Integrity
{
    class Program
    {
        static void Main(string[] args)
        {
            //Symmetrische();
            ASymmetrische();
        }

        private static void ASymmetrische()
        {
            // Dit is de versturende partij
            string message = "Hello World";
            DSA method = new DSACryptoServiceProvider();
            string pubKey = method.ToXmlString(false);
            SHA1Managed alg = new SHA1Managed();
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            byte[] hash = alg.ComputeHash(buffer);
            byte[] signature =method.SignData(hash, HashAlgorithmName.SHA1);

            // Ed
            //message += ".";


            // De ontvangende partij
            DSA method2 = new DSACryptoServiceProvider();
            method2.FromXmlString(pubKey);
            SHA1Managed alg2 = new SHA1Managed();
            byte[] buffer2 = Encoding.UTF8.GetBytes(message);
            byte[] hash2 = alg2.ComputeHash(buffer2);
            bool isOk = method2.VerifyData(hash2, signature, HashAlgorithmName.SHA1);

            Console.WriteLine(isOk ? "Document in orde" : " Hier is mee gerommeld");


        }

        private static void Symmetrische()
        {
            // Dit is de versturende partij
            string message = "Hello World";
            //SHA1Managed alg = new SHA1Managed();
            HMACSHA1 alg = new HMACSHA1();
            byte[] key = alg.Key;
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            byte[] hash = alg.ComputeHash(buffer);

            Console.WriteLine(Convert.ToBase64String(hash));

            // De ontvangende partij
            //SHA1Managed alg2 = new SHA1Managed();
            HMACSHA1 alg2 = new HMACSHA1();
            alg2.Key = key;
            byte[] buffer2 = Encoding.UTF8.GetBytes(message);
            byte[] hash2 = alg2.ComputeHash(buffer2);
            Console.WriteLine(Convert.ToBase64String(hash2));
        }
    }
}
