using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumix.Classes
{
    internal class Hashes
    {
        
        public static string MD5(string str)
        {
            using (StreamReader sw = new StreamReader(str))
            {
                using (var md5 = System.Security.Cryptography.MD5.Create())
                {
                    string ln = sw.ReadLine();
                    byte[] bytes = Encoding.ASCII.GetBytes(ln);
                    var hash = md5.ComputeHash(bytes);
                    return BitConverter.ToString(hash).Replace("-", "");
                }
            }
        }
        
        public static string SHA1(string str)
        {
            using (StreamReader sw = new StreamReader(str))
            {
                using (var sha1 = System.Security.Cryptography.SHA1.Create())
                {
                    string ln = sw.ReadLine();
                    byte[] bytes = Encoding.ASCII.GetBytes(ln);
                    var hash = sha1.ComputeHash(bytes);
                    return BitConverter.ToString(hash).Replace("-", "");
                }
            }
        }

        public static string SHA256(string str)
        {
            using (StreamReader sw = new StreamReader(str))
            {
                using (var sha256 = System.Security.Cryptography.SHA256.Create())
                {
                    string ln = sw.ReadLine();
                    byte[] bytes = Encoding.ASCII.GetBytes(ln);
                    var hash = sha256.ComputeHash(bytes);
                    return BitConverter.ToString(hash).Replace("-", "");
                }
            }
        }

        public static string SHA384(string str)
        {
            using (StreamReader sw = new StreamReader(str))
            {
                using (var sha384 = System.Security.Cryptography.SHA384.Create())
                {
                    string ln = sw.ReadLine();
                    byte[] bytes = Encoding.ASCII.GetBytes(ln);
                    var hash = sha384.ComputeHash(bytes);
                    return BitConverter.ToString(hash).Replace("-", "");
                }
            }
        }

        public static string SHA512(string str)
        {
            using (StreamReader sw = new StreamReader(str))
            {
                using (var sha512 = System.Security.Cryptography.SHA512.Create())
                {
                    string ln = sw.ReadLine();
                    byte[] bytes = Encoding.ASCII.GetBytes(ln);
                    var hash = sha512.ComputeHash(bytes);
                    return BitConverter.ToString(hash).Replace("-", "");
                }
            }
        }

        public static string GetHash(string str, string hash)
        {
            string ret_hash = "";

            if (hash == "MD 5")
            {
                ret_hash = MD5(str);
            }
            else if (hash == "SHA 1")
            {
                ret_hash = SHA1(str);
            }
            else if (hash == "SHA 256")
            {
                ret_hash = SHA256(str);
            }
            else if (hash == "SHA 384")
            {
                ret_hash = SHA384(str);
            }
            else if (hash == "SHA 512")
            {
                ret_hash = SHA512(str);
            }
            else
            {
                return "";
            }

            Properties.Settings.Default.last_plain_hash = ret_hash;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();

            return ret_hash;
        }

        public static bool Compare(string hash1, string hash2, string algo)
        {
            if (Regex.Hash(hash2, algo))
            {
                return hash1.ToLower().Equals(hash2.ToLower());
            }
            else
            {
                return false;
            }
        }

    }
}