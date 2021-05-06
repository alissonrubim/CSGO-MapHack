using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQOTA.Models
{
    internal class MemoryData
    {
        public byte[] Buffer = new byte[1024];
        public int BytesRead = 0;
    }
}
