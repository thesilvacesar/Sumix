using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumix.Classes
{
    internal class Export
    {

        public static string GetHashFileName(string text, string character)
        {
            return text.Substring(text.LastIndexOf(character) + 1);
        }

        public static string GetHashFileExt(string hash)
        {
            return hash.Replace(" ", "").ToLower();
        }

        public static string GetHashFileFilter(string hash)
        {
            if (GetHashFileExt(hash) == "md5")
            {
                return "MD 5|*.md5";
            }
            else if (GetHashFileExt(hash) == "sha1")
            {
                return "SHA 1|*.sha1";
            }
            else if (GetHashFileExt(hash) == "sha256")
            {
                return "SHA 256|*.sha256";
            }
            else if (GetHashFileExt(hash) == "sha384")
            {
                return "SHA 384|*.sha384";
            }
            else if (GetHashFileExt(hash) == "sha512")
            {
                return "SHA 512|*.sha512";
            }

            return "";
        }

        public static string GetHashFileContent(string name, string content)
        {
            return "*" + name + "*: " + content;
        }

    }
}
