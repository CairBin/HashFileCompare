using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Hash
{
    internal class HashTran
    {
        public static string[] hashName = {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA512",
            "SHA384"
        };

        public static string GetTxtHashValue(string txt, string kind)
        {
            HashAlgorithm hash =  HashAlgorithm.Create(kind);

            if (hash == null) return "错误：不是有效哈希算法";

            byte[] hashBytes = hash.ComputeHash(
                Encoding.Default.GetBytes(txt));


            return BitConverter.ToString(hashBytes);

        }

        public static string GetFileHashValue(string filePath,string kind)
        {
            HashAlgorithm hash = HashAlgorithm.Create(kind);

            if (hash == null) return "错误：不是有效哈希算法";

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] hashBytes = hash.ComputeHash(fs);

            fs.Close();

            return BitConverter.ToString(hashBytes);
        }


    }
}
