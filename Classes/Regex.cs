using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumix.Classes
{
    internal class Regex
    {

        private static string Patterns(string pattern)
        {
            switch (pattern)
            {
                case "url":
                    return @"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$";

                case "file":
                    return @"^[a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~]+[^\.\,\)\(\s]$";

                default:
                    return @"";
            }
        }

        private static string PatternsHashes(string pattern)
        {
            string result = "";
            
            switch (pattern)
            {
                case "CRC 32":
                    result = "^[a-f0-9]{8}$";
                    break;
                    
                case "MD 5":
                    result = "^[a-f0-9]{32}$";
                    break;
                    
                case "SHA 1":
                    result = "^[a-f0-9]{40}$";
                    break;
                    
                case "SHA 256":
                    result = "^[a-f0-9]{64}$";
                    break;
                    
                case "SHA 384":
                    result = "^[a-f0-9]{96}$";
                    break;
                    
                case "SHA 512":
                    result = "^[a-f0-9]{128}$";
                    break;

                case "Base 64":
                    result = "^[a-zA-Z0-9+/]{4}=[a-zA-Z0-9+/]{4}(?:[a-zA-Z0-9+/]{2}==|[a-zA-Z0-9+/]{3}=)?$";
                    break;

                case "Generic":
                    result = "^[a-f0-9]{8,128}$";
                    break;
            }
            
            return result;
        }

        public static bool Hash(string input, string regex)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, PatternsHashes(regex));
        }

        public static bool Url(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, Patterns("url"));
        }

        public static bool File(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, Patterns("file"));
        }

    }
}
