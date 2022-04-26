using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumix.Classes
{
    internal class FS
    {
        
        public static bool Exists(string path)
        {
            return System.IO.File.Exists(path);
        }

        public static void WriteAllText(string path, string contents)
        {
            System.IO.File.WriteAllText(path, contents);
        }

        public static string ReadAllText(string path)
        {
            return System.IO.File.ReadAllText(path);
        }

        public static void AppendAllText(string path, string contents)
        {
            System.IO.File.AppendAllText(path, contents);
        }

        public static void Delete(string path)
        {
            System.IO.File.Delete(path);
        }

    }
}
