using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ProjectQOTA.Helpers
{
    internal class MemoryHelper
    {
        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        public MemoryData ReadFromAddress(IntPtr processPointer, int address)
        {
            
        }
    }
}
