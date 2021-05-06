using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ProjectQOTA.Helpers
{
    internal class ProcessHelper
    {
        const int PROCESS_WM_READ = 0x0010;

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        public static Process GetByName(string processName)
        {
            return Process.GetProcessesByName(processName).First();
        }

        public static IntPtr GetReadAccess(Process process)
        {
            return OpenProcess(PROCESS_WM_READ, false, process.Id);
        }
    }
}
