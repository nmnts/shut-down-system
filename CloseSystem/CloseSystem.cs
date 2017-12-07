using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace CloseSystem
{
    public class CloseSystem
    {
        public static void CloseAllBrowser()
        {
            Process[] AllProcesses = Process.GetProcesses();
            foreach (var process in AllProcesses)
            {
                if (process.MainWindowTitle != "")
                {
                    string s = process.ProcessName.ToLower();
                    if (s == "iexplore" || s == "iexplorer" || s == "chrome" || s == "firefox")
                        process.Kill();
                }
            }
        }

        public static void CloseAllFolders()
        {
            foreach (Process p in Process.GetProcessesByName("explorer"))
            {
                p.Kill();
            }
        }

        public static void ShutDownSystem()
        {
            Process.Start("Shutdown", "-s -t 0");
        }
    }
}
