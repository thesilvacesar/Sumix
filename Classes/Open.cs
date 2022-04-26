using System;
using System.Diagnostics;

namespace Sumix.Classes
{
    internal class Open
    {

        public static void Link(string link)
        {
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = link;
            System.Diagnostics.Process.Start(psi);
        }

    }
}
